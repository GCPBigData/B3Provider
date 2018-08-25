﻿#region License
/*
 * B3ProviderClient.cs
 *
 * The MIT License
 *
 * Copyright (c) 2018 Felipe Bahiana Almeida
 *
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 *
 * The above copyright notice and this permission notice shall be included in
 * all copies or substantial portions of the Software.
 *
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
 * THE SOFTWARE.
 * 
 * Contributors:
 * - Felipe Bahiana Almeida <felipe.almeida@gmail.com> https://www.linkedin.com/in/felipe-almeida-ba222577
 */
#endregion

/// <summary>
/// Default namespace of the package
/// </summary>
namespace B3Provider
{
    using B3Provider.Database;
    using B3Provider.Records;
    using NLog;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    /// <summary>
    /// Class that provide data made available by Brazil Stock Market (B3 former BMF Bovespa)
    /// for aplications to use it.
    /// </summary>
    public class B3ProviderClient
    {
        private readonly Logger _logger = LogManager.GetCurrentClassLogger();
        private readonly Logger _databaseLogger = LogManager.GetLogger("Database");

        #region "private members"
        private B3ProviderConfig _configuration = null;
        private B3Dowloader _downloader = null;
        private B3ProviderDbContext _databaseContext = null;
        private bool _setupExecuted = false;
        #endregion

        #region "ctor"
        /// <summary>
        /// Defaulf constructor, it receives the path to where the files that are going to be downloaded from
        /// B3 (former BMF & Bovespa) are going will reside
        /// </summary>
        /// <param name="configuration"></param>
        public B3ProviderClient(B3ProviderConfig configuration)
        {
            _configuration = configuration ?? throw new ArgumentNullException("configuration", "the parameter configuration of type B3ProviderConfig cannot be null");
            _downloader = new B3Dowloader(_configuration.DownloadPath);
            _databaseContext = new B3ProviderDbContext((message => _databaseLogger.Info(message)));            
        }
        #endregion

        #region "properties to records found in files"
        /// <summary>
        /// All equity information found in a file.
        /// </summary>
        public IList<B3EquityInfo> EquityInstruments { get; set; } = null;

        /// <summary>
        /// All options on equity found in a file.
        /// </summary>
        public IList<B3OptionOnEquityInfo> OptionInstruments { get; set; } = null;

        /// <summary>
        /// Current market data (princes in the same day of the instruments file)
        /// </summary>
        public IList<B3MarketDataInfo> CurrentMarketData { get; set; } = null;

        /// <summary>
        /// Historic market data past princes
        /// </summary>
        public IDictionary<int,IList<B3HistoricMarketDataInfo>> HistoricMarketData { get; set; } = new Dictionary<int, IList<B3HistoricMarketDataInfo>>();

        /// <summary>
        /// Index to convert an instrument ticker to internal ID
        /// </summary>
        public IDictionary<string, long> TickerIDIndex { get; private set; } = new Dictionary<string, long>();

        /// <summary>
        /// Colection of market sector classification to companies listed on B3 stock exchange. 
        /// </summary>
        public IList<B3SectorClassifcationInfo> SectorClassification { get; set; } = null;

        #endregion

        #region "public methods"
        /// <summary>
        /// It makes all the preparation in order to run operations on provider
        /// </summary>
        public void Setup()
        {
            SetupFileSystem();
            _setupExecuted = true;
        }

        /// <summary>
        /// Load all the instruments found in files
        /// </summary>
        public void LoadInstruments()
        {
            Dictionary<string, long> tickerIDIndexDictionary = null;

            _logger.Info("setup provider");
            SetupIfNotSetup();

            _logger.Info("downloading file of instruments");
            var filePath = _downloader.DownloadInstrumentFile(null, _configuration.ReplaceExistingFiles);

            _logger.Info("reading equities");
            var equityReader = ReaderFactory.CreateReader<B3EquityInfo>(_configuration.ReadStrategy);
            EquityInstruments = equityReader.ReadRecords(filePath);

            _logger.Info("indexing equities");
            tickerIDIndexDictionary = EquityInstruments.ToDictionary(k => k.Ticker, v => v.B3ID.HasValue ? v.B3ID.Value : 0);
            TickerIDIndex = TickerIDIndex.Union(tickerIDIndexDictionary).ToDictionary(k => k.Key, v => v.Value);

            _logger.Info("reading options");
            var optionsReader = ReaderFactory.CreateReader<B3OptionOnEquityInfo>(_configuration.ReadStrategy);
            OptionInstruments = optionsReader.ReadRecords(filePath);

            _logger.Info("indexing options");
            tickerIDIndexDictionary = OptionInstruments.ToDictionary(k => k.Ticker, v => v.B3ID.HasValue ? v.B3ID.Value : 0);
            TickerIDIndex = TickerIDIndex.Union(tickerIDIndexDictionary).ToDictionary(k => k.Key, v => v.Value);

            _logger.Info("loading sector classification");
            LoadSectorClassification();

            _logger.Info("applying sector classification");
            ApplySectorClassification();

            _logger.Info("saving to database");
            SaveAllToDatabase();
        }        

        /// <summary>
        /// Load all the quotes found  in files (for a specific date)
        /// </summary>
        public void LoadQuotes()
        {
            _logger.Info("setup provider");
            SetupIfNotSetup();

            _logger.Info("downloading file of current market data");
            var filePath = _downloader.DownloadQuoteFile(null, _configuration.ReplaceExistingFiles);

            _logger.Info("reading file of current market data");
            var marketDataReader = ReaderFactory.CreateReader<B3MarketDataInfo>(_configuration.ReadStrategy);
            CurrentMarketData = marketDataReader.ReadRecords(filePath);
        }

        /// <summary>
        /// Load all the quotes found  in files (for a year file)
        /// </summary>
        /// <param name="yearToReadHistory">
        /// year of historic quotes file
        /// they are separated per year ans that's why we need to inform
        /// this parameter
        /// </param>
        public void LoadHistoricQuotes(int yearToReadHistory)
        {
            _logger.Info("setup provider");
            SetupIfNotSetup();

            _logger.Info("downloading file of historic market data");
            var filePath = _downloader.DownloadYearHistoricFile(yearToReadHistory, _configuration.ReplaceExistingFiles);

            _logger.Info("reading file of historic market data");
            var historicMarketDataReader = ReaderFactory.CreateReader<B3HistoricMarketDataInfo>(_configuration.ReadStrategy);
            HistoricMarketData[yearToReadHistory] = historicMarketDataReader.ReadRecords(filePath);
        }

        /// <summary>
        /// Get market data from all years loaded into the provider.
        /// </summary>
        /// <returns></returns>
        public IList<B3HistoricMarketDataInfo> GetHistoricMarketData()
        {
            IList<B3HistoricMarketDataInfo> _result = null;
            if (HistoricMarketData != null && HistoricMarketData.Count > 0)
            {
                foreach (KeyValuePair<int, IList<B3HistoricMarketDataInfo>> oneItem in HistoricMarketData)
                {
                    _result = _result==null ? oneItem.Value : _result.Concat(oneItem.Value).ToList();
                }
            }
            return _result;
        }


        /// <summary>
        /// Load all the company sector info found  in file
        /// </summary>
        public void LoadSectorClassification()
        {
            _logger.Info("setup provider");
            SetupIfNotSetup();

            _logger.Info("downloading file of sector classification");
            var filePath = _downloader.DownloadSectorClassificationFile(_configuration.ReplaceExistingFiles);

            _logger.Info("reading file of sector classification");
            var sectorClassificationDataReader = ReaderFactory.CreateReader<B3SectorClassifcationInfo>(_configuration.ReadStrategy);
            SectorClassification = sectorClassificationDataReader.ReadRecords(filePath);
        }

        #endregion

        #region "private methods"
        /// <summary>
        /// Method that checks if provider is initialized and setup if it was not performed by calling
        /// code already.
        /// </summary>
        private void SetupIfNotSetup()
        {
            if (!_setupExecuted)
                Setup();
        }

        /// <summary>
        /// Creates the necessary directory to download files to.
        /// </summary>
        private void SetupFileSystem()
        {
            var pathToCreate = string.Empty;
            //if directory does exist, it will return directory info to that
            //if directory does not exist, it will be created
            Directory.CreateDirectory(_configuration.BasePath);
            pathToCreate = Path.Combine(_configuration.BasePath, _configuration.DownloadPath);
            Directory.CreateDirectory(pathToCreate);
            pathToCreate = Path.Combine(_configuration.BasePath, _configuration.DatabasePath);
            Directory.CreateDirectory(pathToCreate);
            //use AppDomain.SetData to set the DataDirectory
            AppDomain.CurrentDomain.SetData("DataDirectory", pathToCreate);
        }

        /// <summary>
        /// Apply Market Classification to equity instruments
        /// </summary>
        private void ApplySectorClassification()
        {
            foreach (var oneEquityInstrument in EquityInstruments)
            {
                var oneClassification = SectorClassification.Where(e =>
                                            e.CompanyListingCode.Equals(
                                                oneEquityInstrument.Ticker.Substring(0, e.CompanyListingCode.Length)
                                                , StringComparison.InvariantCultureIgnoreCase)
                                            ).FirstOrDefault();

                if (oneClassification == null)
                {
                    oneClassification = new B3SectorClassifcationInfo();
                    oneClassification.EconomicSector = "N/A";
                    oneClassification.EconomicSegment = "N/A";
                    oneClassification.EconomicSubSector = "N/A";
                }

                oneEquityInstrument.SectorClassification = oneClassification;
            }
        }

        /// <summary>
        /// Save all types of records to the database
        /// </summary>
        private void SaveAllToDatabase()
        {
            SaveSectorClassificationDataToDatabase();
            SaveEquityInstrumentsToDatabase();
            SaveOptionsOnEquityInstrumentsToDatabase();
            SaveCurrentMarketDataToDatabase();
            SaveHistoricMarketDataToDatabase();
        }

        private void SaveSectorClassificationDataToDatabase()
        {
            if (_databaseContext == null) return;
            foreach (var oneSectorClassification in SectorClassification)
            {
                var alreadyExists = _databaseContext.SectorClassification.Where
                        (s => s.CompanyListingCode.Equals(oneSectorClassification.CompanyListingCode, StringComparison.InvariantCultureIgnoreCase))
                        .FirstOrDefault();
                if (alreadyExists == null)
                    _databaseContext.SectorClassification.Add(oneSectorClassification);
            }

            _databaseContext.SaveChanges();
        }

        private void SaveEquityInstrumentsToDatabase()
        {

        }

        private void SaveOptionsOnEquityInstrumentsToDatabase()
        {

        }

        private void SaveCurrentMarketDataToDatabase()
        {

        }

        private void SaveHistoricMarketDataToDatabase()
        {

        }

        

        #endregion

    }
}
