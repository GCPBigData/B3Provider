﻿using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;

namespace Prototyping.Code.Download.MarketData.Bovespa
{

    public class ClassificacaoSetorial
    {
        const string ENDERECO_ARQUIVO = @"http://www.bmfbovespa.com.br/lumis/portal/file/fileDownload.jsp?fileId=8AA8D0975A2D7918015A3C81693D4CA4";
        const string NOME_ARQUIVO = "classificacao_setorial-{0}.zip";

        const string HEADER_TEXTO_1 = "SETOR ECONÔMICO";
        const string HEADER_TEXTO_2 = "SUBSETOR";
        const string HEADER_TEXTO_3 = "SEGMENTO";

        public void DownloadFile()
        {
            string valorColuna1 = string.Empty;
            string valorColuna2 = string.Empty;
            string valorColuna3 = string.Empty;
            string valorColuna4 = string.Empty;
            string valorColuna5 = string.Empty;

            string setorEconomico = string.Empty;
            string subsetor = string.Empty;
            string segmento = string.Empty;
            string empresa = string.Empty;
            string empresaCodigo = string.Empty;
            string empresaSegmento = string.Empty;

            List<EmpresaSetorInfo> empresas = null;

            using (var client = new WebClient())
            {
                // download file
                var temporaryFolder = Path.GetTempPath();
                var filePath = Path.Combine(temporaryFolder, string.Format(NOME_ARQUIVO, DateTime.Now.ToString("yyyy-MM-dd")));
                client.DownloadFile(ENDERECO_ARQUIVO, filePath);

                // uncompress file
                using (ZipArchive zip = ZipFile.Open(filePath, ZipArchiveMode.Read))
                using (var ms = new MemoryStream())
                {
                    var entry = zip.Entries.First();
                    if (entry != null)
                    {
                        using (var stream = entry.Open())
                        {
                            stream.CopyTo(ms);
                            ms.Position = 0; // rewind
                        }

                        using (var reader = ExcelReaderFactory.CreateReader(ms))
                        {
                            // 1. Use the reader methods
                            do
                            {
                                empresas = new List<EmpresaSetorInfo>();
                                while (reader.Read())
                                {
                                    valorColuna1 = reader.GetString(0);
                                    valorColuna2 = reader.GetString(1);
                                    valorColuna3 = reader.GetString(2);
                                    valorColuna4 = reader.GetString(3);
                                    valorColuna5 = reader.GetString(4);

                                    if (
                                        !string.IsNullOrEmpty(valorColuna1)
                                        && !string.IsNullOrEmpty(valorColuna2)
                                        && !string.IsNullOrEmpty(valorColuna3)
                                        && string.IsNullOrEmpty(valorColuna4)
                                        && string.IsNullOrEmpty(valorColuna5))
                                    {
                                        //primeira categoria
                                        setorEconomico = valorColuna1.Trim();
                                        subsetor = valorColuna2.Trim();
                                        segmento = valorColuna3.Trim();
                                    }

                                    if (
                                        string.IsNullOrEmpty(valorColuna1)
                                        && string.IsNullOrEmpty(valorColuna2)
                                        && !string.IsNullOrEmpty(valorColuna3)
                                        && string.IsNullOrEmpty(valorColuna4)
                                        && string.IsNullOrEmpty(valorColuna5))
                                    {
                                        //trocou segmento
                                        segmento = valorColuna3.Trim();
                                    }

                                    if (
                                         string.IsNullOrEmpty(valorColuna1)
                                         && !string.IsNullOrEmpty(valorColuna2)
                                         && !string.IsNullOrEmpty(valorColuna3)
                                         && string.IsNullOrEmpty(valorColuna4)
                                         && string.IsNullOrEmpty(valorColuna5))
                                    {
                                        //trocou subsetor
                                        subsetor = valorColuna2.Trim();
                                        segmento = valorColuna3.Trim();
                                    }

                                    if (
                                        string.IsNullOrEmpty(valorColuna1)
                                        && string.IsNullOrEmpty(valorColuna2)
                                        && !string.IsNullOrEmpty(valorColuna3)
                                        && !string.IsNullOrEmpty(valorColuna4))
                                    {
                                        //empresa
                                        empresa = valorColuna3.Trim();
                                        empresaCodigo = valorColuna4.Trim();
                                        empresaSegmento = string.IsNullOrEmpty(valorColuna5) ? string.Empty : valorColuna5.Trim();
                                    }

                                    if (!string.IsNullOrEmpty(setorEconomico) &&
                                        !string.IsNullOrEmpty(subsetor) &&
                                        !string.IsNullOrEmpty(segmento) &&
                                        !string.IsNullOrEmpty(empresa) &&
                                        !string.IsNullOrEmpty(empresaCodigo))
                                    {
                                        empresas.Add(new EmpresaSetorInfo()
                                        {
                                            SetorEconomico = setorEconomico,
                                            SubSetorEconomico = subsetor,
                                            SegmentoEconomico = segmento,
                                            Empresa = empresa,
                                            Codigo = empresaCodigo,
                                            Segmento = empresaSegmento
                                        });

                                        empresa = string.Empty;
                                        empresaCodigo = string.Empty;
                                        empresaSegmento = string.Empty;
                                    }
                                    // adicionar informação empresa na lista
                                }
                            } while (reader.NextResult());
                        }
                    }
                }
            }

            if (empresas != null && empresas.Count > 0)
            {
                SalvarBase(empresas);
            }
        }

        private void SalvarBase(List<EmpresaSetorInfo> empresas)
        {
            var tabela = TransformarTabela(empresas);
            Salvar(tabela);
        }

        static DataTable TransformarTabela(List<EmpresaSetorInfo> empresas)
        {
            DataTable tabelaEmpresas = null;
            DataRow empresa = null;

            tabelaEmpresas = new DataTable("TB_TMP_RAW_BOVESPA_CLASSIFICACAO_SETORIAL");
            tabelaEmpresas.Columns.Add(new DataColumn("NM_SETOR_ECONOMICO", Type.GetType("System.String")));
            tabelaEmpresas.Columns.Add(new DataColumn("NM_SUBSETOR_ECONOMICO", Type.GetType("System.String")));
            tabelaEmpresas.Columns.Add(new DataColumn("NM_SEGMENTO_ECONOMICO", Type.GetType("System.String")));

            tabelaEmpresas.Columns.Add(new DataColumn("NM_EMPRESA", Type.GetType("System.String")));
            tabelaEmpresas.Columns.Add(new DataColumn("SG_EMPRESA", Type.GetType("System.String")));
            tabelaEmpresas.Columns.Add(new DataColumn("SG_EMPRESA_SEGMENTO", Type.GetType("System.String")));
            tabelaEmpresas.Columns.Add(new DataColumn("NR_HASH", Type.GetType("System.Double")));

            if (empresas != null && empresas.Count > 0)
            {
                foreach (var umaEmpresa in empresas)
                {
                    empresa = tabelaEmpresas.NewRow();

                    empresa["NM_SETOR_ECONOMICO"] = umaEmpresa.SetorEconomico;
                    empresa["NM_SUBSETOR_ECONOMICO"] = umaEmpresa.SubSetorEconomico;
                    empresa["NM_SEGMENTO_ECONOMICO"] = umaEmpresa.SegmentoEconomico;
                    empresa["NM_EMPRESA"] = umaEmpresa.Empresa;
                    empresa["SG_EMPRESA"] = umaEmpresa.Codigo;
                    empresa["SG_EMPRESA_SEGMENTO"] = umaEmpresa.Segmento;
                    empresa["NR_HASH"] = umaEmpresa.ComputeHash();

                    tabelaEmpresas.Rows.Add(empresa);
                }
            }

            return tabelaEmpresas;
        }

        static void Salvar(DataTable valoresInserir)
        {
            string connectionString = GetConnectionString();
            // Open a sourceConnection to the AdventureWorks database.

            // Open the destination connection. In the real world you would 
            // not use SqlBulkCopy to move data from one table to the other 
            // in the same database. This is for demonstration purposes only.
            using (SqlConnection destinationConnection = new SqlConnection(connectionString))
            {
                destinationConnection.Open();

                // Set up the bulk copy object. 
                // Note that the column positions in the source
                // data reader match the column positions in 
                // the destination table so there is no need to
                // map columns.
                using (SqlBulkCopy bulkCopy = new SqlBulkCopy(destinationConnection))
                {
                    bulkCopy.DestinationTableName =
                        "DATA_IMPORT.TB_TMP_RAW_BOVESPA_CLASSIFICACAO_SETORIAL";

                    try
                    {
                        // Write from the source to the destination.
                        bulkCopy.WriteToServer(valoresInserir);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    finally
                    {
                        // Close the SqlDataReader. The SqlBulkCopy
                        // object is automatically closed at the end
                        // of the using block.
                        //reader.Close();
                    }
                }
            }
        }


        private static string GetConnectionString()
        // To avoid storing the sourceConnection string in your code, 
        // you can retrieve it from a configuration file. 
        {
            var connection = System.Configuration.ConfigurationManager.ConnectionStrings["default"];
            return connection.ConnectionString;
        }
    }

    public class EmpresaSetorInfo
    {
        public string SetorEconomico { get; set; }
        public string SubSetorEconomico { get; set; }
        public string SegmentoEconomico { get; set; }
        public string Empresa { get; set; }
        public string Codigo { get; set; }
        public string Segmento { get; set; }

        public override string ToString()
        {
            return string.Format("{0}-{1}-{2}-{3}-{4}-{5}", SetorEconomico, SubSetorEconomico, SegmentoEconomico, Empresa, Codigo, Segmento);
        }

        public double ComputeHash()
        {
            using (System.Security.Cryptography.SHA1Managed sha1 = new System.Security.Cryptography.SHA1Managed())
            {
                var hash = sha1.ComputeHash(System.Text.Encoding.UTF8.GetBytes(this.ToString()));
                var sb = new System.Text.StringBuilder(hash.Length * 2);

                foreach (byte b in hash)
                {
                    // can be "x2" if you want lowercase
                    sb.Append(b.ToString("N0"));
                }

                return double.Parse(sb.ToString());
            }

        }
    }
}
