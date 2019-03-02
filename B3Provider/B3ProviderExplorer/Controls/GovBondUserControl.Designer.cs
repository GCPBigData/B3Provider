﻿namespace B3ProviderExplorer.Controls
{
    partial class GovBondUserControl
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionUserControl));
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem1 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem1 = new DevExpress.Utils.ToolTipItem();
            this.mainOptionView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colOptionB3ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOptionISIN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOptionDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOptionTicker = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOptionStrike = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOptionStrikeCurrency = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOptionStrikeStyle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOptionType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOptionExpiration = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOptionLoadDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOptionUnderlyingID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.bdsEquity = new System.Windows.Forms.BindingSource(this.components);
            this.mainEquityView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCompanyName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTicker = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colB3ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMarketCapitalization = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSectorClassificationSetorEconomico = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSectorClassificationSubsetorEconomico = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSectorClassificationSegmentoEconomico = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCurrency = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLoadDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colISIN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiPrintPreview = new DevExpress.XtraBars.BarButtonItem();
            this.bsiRecordsCount = new DevExpress.XtraBars.BarStaticItem();
            this.bbiNew = new DevExpress.XtraBars.BarButtonItem();
            this.bbiEdit = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDelete = new DevExpress.XtraBars.BarButtonItem();
            this.bbiRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.bbiStocks = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.bbiFilter = new DevExpress.XtraBars.BarButtonItem();
            this.bbiClosingDate = new DevExpress.XtraBars.BarEditItem();
            this.ridClosingDate = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.bbiNextClose = new DevExpress.XtraBars.BarButtonItem();
            this.bbiPreviousClose = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgEquity = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.MainSplashScreenManager = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::B3ProviderExplorer.Controls.WaitForm1), true, true, typeof(System.Windows.Forms.UserControl), true);
            this.gridSplitContainer1 = new DevExpress.XtraGrid.GridSplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.mainOptionView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsEquity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainEquityView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ridClosingDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ridClosingDate.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1)).BeginInit();
            this.gridSplitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainOptionView
            // 
            this.mainOptionView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colOptionB3ID,
            this.colOptionISIN,
            this.colOptionDescription,
            this.colOptionTicker,
            this.colOptionStrike,
            this.colOptionStrikeCurrency,
            this.colOptionStrikeStyle,
            this.colOptionType,
            this.colOptionExpiration,
            this.colOptionLoadDate,
            this.colOptionUnderlyingID});
            this.mainOptionView.GridControl = this.gridControl;
            this.mainOptionView.Name = "mainOptionView";
            // 
            // colOptionB3ID
            // 
            this.colOptionB3ID.Caption = "B3 ID";
            this.colOptionB3ID.DisplayFormat.FormatString = "G";
            this.colOptionB3ID.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colOptionB3ID.FieldName = "B3ID";
            this.colOptionB3ID.GroupFormat.FormatString = "G";
            this.colOptionB3ID.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colOptionB3ID.Name = "colOptionB3ID";
            this.colOptionB3ID.Visible = true;
            this.colOptionB3ID.VisibleIndex = 0;
            // 
            // colOptionISIN
            // 
            this.colOptionISIN.Caption = "ISIN";
            this.colOptionISIN.FieldName = "ISIN";
            this.colOptionISIN.Name = "colOptionISIN";
            this.colOptionISIN.Visible = true;
            this.colOptionISIN.VisibleIndex = 1;
            // 
            // colOptionDescription
            // 
            this.colOptionDescription.Caption = "Description";
            this.colOptionDescription.FieldName = "Description";
            this.colOptionDescription.Name = "colOptionDescription";
            this.colOptionDescription.Visible = true;
            this.colOptionDescription.VisibleIndex = 2;
            // 
            // colOptionTicker
            // 
            this.colOptionTicker.Caption = "Ticker";
            this.colOptionTicker.FieldName = "Ticker";
            this.colOptionTicker.Name = "colOptionTicker";
            this.colOptionTicker.Visible = true;
            this.colOptionTicker.VisibleIndex = 3;
            // 
            // colOptionStrike
            // 
            this.colOptionStrike.Caption = "Strike";
            this.colOptionStrike.DisplayFormat.FormatString = "C2";
            this.colOptionStrike.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colOptionStrike.FieldName = "Strike";
            this.colOptionStrike.GroupFormat.FormatString = "C2";
            this.colOptionStrike.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colOptionStrike.Name = "colOptionStrike";
            this.colOptionStrike.Visible = true;
            this.colOptionStrike.VisibleIndex = 4;
            // 
            // colOptionStrikeCurrency
            // 
            this.colOptionStrikeCurrency.Caption = "Strike Currency";
            this.colOptionStrikeCurrency.FieldName = "StrikeCurrency";
            this.colOptionStrikeCurrency.Name = "colOptionStrikeCurrency";
            this.colOptionStrikeCurrency.Visible = true;
            this.colOptionStrikeCurrency.VisibleIndex = 5;
            // 
            // colOptionStrikeStyle
            // 
            this.colOptionStrikeStyle.Caption = "Style";
            this.colOptionStrikeStyle.FieldName = "Style";
            this.colOptionStrikeStyle.Name = "colOptionStrikeStyle";
            this.colOptionStrikeStyle.Visible = true;
            this.colOptionStrikeStyle.VisibleIndex = 6;
            // 
            // colOptionType
            // 
            this.colOptionType.Caption = "Type";
            this.colOptionType.FieldName = "Type";
            this.colOptionType.Name = "colOptionType";
            this.colOptionType.Visible = true;
            this.colOptionType.VisibleIndex = 7;
            // 
            // colOptionExpiration
            // 
            this.colOptionExpiration.Caption = "Expiration";
            this.colOptionExpiration.DisplayFormat.FormatString = "d";
            this.colOptionExpiration.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colOptionExpiration.FieldName = "Expiration";
            this.colOptionExpiration.GroupFormat.FormatString = "d";
            this.colOptionExpiration.GroupFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colOptionExpiration.Name = "colOptionExpiration";
            this.colOptionExpiration.Visible = true;
            this.colOptionExpiration.VisibleIndex = 8;
            // 
            // colOptionLoadDate
            // 
            this.colOptionLoadDate.Caption = "Load Date";
            this.colOptionLoadDate.DisplayFormat.FormatString = "d";
            this.colOptionLoadDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colOptionLoadDate.FieldName = "LoadDate";
            this.colOptionLoadDate.GroupFormat.FormatString = "d";
            this.colOptionLoadDate.GroupFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colOptionLoadDate.Name = "colOptionLoadDate";
            this.colOptionLoadDate.Visible = true;
            this.colOptionLoadDate.VisibleIndex = 9;
            // 
            // colOptionUnderlyingID
            // 
            this.colOptionUnderlyingID.Caption = "B3 ID Underlying";
            this.colOptionUnderlyingID.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colOptionUnderlyingID.FieldName = "B3IDUnderlying";
            this.colOptionUnderlyingID.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colOptionUnderlyingID.Name = "colOptionUnderlyingID";
            this.colOptionUnderlyingID.Visible = true;
            this.colOptionUnderlyingID.VisibleIndex = 10;
            // 
            // gridControl
            // 
            this.gridControl.DataSource = this.bdsEquity;
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.LevelTemplate = this.mainOptionView;
            gridLevelNode1.RelationName = "Level1";
            this.gridControl.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControl.Location = new System.Drawing.Point(0, 0);
            this.gridControl.MainView = this.mainEquityView;
            this.gridControl.MenuManager = this.ribbonControl;
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(800, 457);
            this.gridControl.TabIndex = 2;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.mainEquityView,
            this.mainOptionView});
            // 
            // bdsEquity
            // 
            this.bdsEquity.DataSource = typeof(B3Provider.Records.B3EquityInfo);
            // 
            // mainEquityView
            // 
            this.mainEquityView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.mainEquityView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCompanyName,
            this.colTicker,
            this.colLastPrice,
            this.colB3ID,
            this.colMarketCapitalization,
            this.colSectorClassificationSetorEconomico,
            this.colSectorClassificationSubsetorEconomico,
            this.colSectorClassificationSegmentoEconomico,
            this.colCurrency,
            this.colDescription,
            this.colLoadDate,
            this.colISIN});
            this.mainEquityView.GridControl = this.gridControl;
            this.mainEquityView.Name = "mainEquityView";
            this.mainEquityView.OptionsBehavior.Editable = false;
            this.mainEquityView.OptionsBehavior.ReadOnly = true;
            this.mainEquityView.MasterRowEmpty += new DevExpress.XtraGrid.Views.Grid.MasterRowEmptyEventHandler(this.mainEquityView_MasterRowEmpty);
            this.mainEquityView.MasterRowExpanding += new DevExpress.XtraGrid.Views.Grid.MasterRowCanExpandEventHandler(this.mainEquityView_MasterRowExpanding);
            this.mainEquityView.MasterRowGetChildList += new DevExpress.XtraGrid.Views.Grid.MasterRowGetChildListEventHandler(this.mainEquityView_MasterRowGetChildList);
            this.mainEquityView.MasterRowGetRelationName += new DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationNameEventHandler(this.mainEquityView_MasterRowGetRelationName);
            this.mainEquityView.MasterRowGetRelationCount += new DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationCountEventHandler(this.mainEquityView_MasterRowGetRelationCount);
            // 
            // colCompanyName
            // 
            this.colCompanyName.Caption = "Company Name";
            this.colCompanyName.FieldName = "CompanyName";
            this.colCompanyName.Name = "colCompanyName";
            this.colCompanyName.Visible = true;
            this.colCompanyName.VisibleIndex = 2;
            // 
            // colTicker
            // 
            this.colTicker.Caption = "Ticker";
            this.colTicker.FieldName = "Ticker";
            this.colTicker.Name = "colTicker";
            this.colTicker.Visible = true;
            this.colTicker.VisibleIndex = 4;
            // 
            // colLastPrice
            // 
            this.colLastPrice.DisplayFormat.FormatString = "C2";
            this.colLastPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colLastPrice.FieldName = "LastPrice";
            this.colLastPrice.GroupFormat.FormatString = "C2";
            this.colLastPrice.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colLastPrice.Name = "colLastPrice";
            this.colLastPrice.Visible = true;
            this.colLastPrice.VisibleIndex = 7;
            // 
            // colB3ID
            // 
            this.colB3ID.Caption = "B3 ID";
            this.colB3ID.FieldName = "B3ID";
            this.colB3ID.Name = "colB3ID";
            this.colB3ID.Visible = true;
            this.colB3ID.VisibleIndex = 0;
            // 
            // colMarketCapitalization
            // 
            this.colMarketCapitalization.Caption = "Market Cap.";
            this.colMarketCapitalization.DisplayFormat.FormatString = "N";
            this.colMarketCapitalization.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colMarketCapitalization.FieldName = "MarketCapitalization";
            this.colMarketCapitalization.GroupFormat.FormatString = "N";
            this.colMarketCapitalization.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colMarketCapitalization.Name = "colMarketCapitalization";
            this.colMarketCapitalization.Visible = true;
            this.colMarketCapitalization.VisibleIndex = 6;
            // 
            // colSectorClassificationSetorEconomico
            // 
            this.colSectorClassificationSetorEconomico.Caption = "Economic Sector";
            this.colSectorClassificationSetorEconomico.FieldName = "SectorClassification.EconomicSector";
            this.colSectorClassificationSetorEconomico.Name = "colSectorClassificationSetorEconomico";
            this.colSectorClassificationSetorEconomico.Visible = true;
            this.colSectorClassificationSetorEconomico.VisibleIndex = 9;
            // 
            // colSectorClassificationSubsetorEconomico
            // 
            this.colSectorClassificationSubsetorEconomico.Caption = "Econ. Subsector";
            this.colSectorClassificationSubsetorEconomico.FieldName = "SectorClassification.EconomicSubSector";
            this.colSectorClassificationSubsetorEconomico.Name = "colSectorClassificationSubsetorEconomico";
            this.colSectorClassificationSubsetorEconomico.Visible = true;
            this.colSectorClassificationSubsetorEconomico.VisibleIndex = 10;
            // 
            // colSectorClassificationSegmentoEconomico
            // 
            this.colSectorClassificationSegmentoEconomico.Caption = "Segmnet";
            this.colSectorClassificationSegmentoEconomico.FieldName = "SectorClassification.EconomicSegment";
            this.colSectorClassificationSegmentoEconomico.Name = "colSectorClassificationSegmentoEconomico";
            this.colSectorClassificationSegmentoEconomico.Visible = true;
            this.colSectorClassificationSegmentoEconomico.VisibleIndex = 11;
            // 
            // colCurrency
            // 
            this.colCurrency.Caption = "Ccy";
            this.colCurrency.FieldName = "Currency";
            this.colCurrency.Name = "colCurrency";
            this.colCurrency.Visible = true;
            this.colCurrency.VisibleIndex = 5;
            // 
            // colDescription
            // 
            this.colDescription.Caption = "Description";
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 3;
            // 
            // colLoadDate
            // 
            this.colLoadDate.Caption = "Load";
            this.colLoadDate.DisplayFormat.FormatString = "d";
            this.colLoadDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colLoadDate.FieldName = "LoadDate";
            this.colLoadDate.GroupFormat.FormatString = "d";
            this.colLoadDate.GroupFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colLoadDate.Name = "colLoadDate";
            this.colLoadDate.Visible = true;
            this.colLoadDate.VisibleIndex = 8;
            // 
            // colISIN
            // 
            this.colISIN.Caption = "ISIN";
            this.colISIN.FieldName = "ISIN";
            this.colISIN.Name = "colISIN";
            this.colISIN.Visible = true;
            this.colISIN.VisibleIndex = 1;
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem,
            this.bbiPrintPreview,
            this.bsiRecordsCount,
            this.bbiNew,
            this.bbiEdit,
            this.bbiDelete,
            this.bbiRefresh,
            this.bbiStocks,
            this.barButtonItem4,
            this.bbiFilter,
            this.bbiClosingDate,
            this.bbiNextClose,
            this.bbiPreviousClose});
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.MaxItemId = 29;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.ridClosingDate});
            this.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.Size = new System.Drawing.Size(800, 116);
            this.ribbonControl.StatusBar = this.ribbonStatusBar;
            this.ribbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // bbiPrintPreview
            // 
            this.bbiPrintPreview.Caption = "Print Preview";
            this.bbiPrintPreview.Id = 14;
            this.bbiPrintPreview.ImageOptions.ImageUri.Uri = "Preview";
            this.bbiPrintPreview.Name = "bbiPrintPreview";
            this.bbiPrintPreview.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiPrintPreview_ItemClick);
            // 
            // bsiRecordsCount
            // 
            this.bsiRecordsCount.Caption = "RECORDS : 0";
            this.bsiRecordsCount.Id = 15;
            this.bsiRecordsCount.Name = "bsiRecordsCount";
            // 
            // bbiNew
            // 
            this.bbiNew.Caption = "New";
            this.bbiNew.Id = 16;
            this.bbiNew.ImageOptions.ImageUri.Uri = "New";
            this.bbiNew.Name = "bbiNew";
            this.bbiNew.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // bbiEdit
            // 
            this.bbiEdit.Caption = "Edit";
            this.bbiEdit.Id = 17;
            this.bbiEdit.ImageOptions.ImageUri.Uri = "Edit";
            this.bbiEdit.Name = "bbiEdit";
            this.bbiEdit.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // bbiDelete
            // 
            this.bbiDelete.Caption = "Delete";
            this.bbiDelete.Id = 18;
            this.bbiDelete.ImageOptions.ImageUri.Uri = "Delete";
            this.bbiDelete.Name = "bbiDelete";
            this.bbiDelete.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // bbiRefresh
            // 
            this.bbiRefresh.Caption = "Refresh";
            this.bbiRefresh.Id = 19;
            this.bbiRefresh.ImageOptions.ImageUri.Uri = "Refresh";
            this.bbiRefresh.Name = "bbiRefresh";
            this.bbiRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiRefresh_ItemClick);
            // 
            // bbiStocks
            // 
            this.bbiStocks.Caption = "Stocks";
            this.bbiStocks.Id = 23;
            this.bbiStocks.ImageOptions.ImageUri.Uri = "Pie;Size32x32;Colored";
            this.bbiStocks.Name = "bbiStocks";
            this.bbiStocks.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiStocks_ItemClick);
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Options";
            this.barButtonItem4.Id = 24;
            this.barButtonItem4.ImageOptions.ImageUri.Uri = "Superscript;Size32x32;Colored";
            this.barButtonItem4.Name = "barButtonItem4";
            this.barButtonItem4.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem4_ItemClick);
            // 
            // bbiFilter
            // 
            this.bbiFilter.Caption = "Filter";
            this.bbiFilter.Id = 25;
            this.bbiFilter.ImageOptions.ImageUri.Uri = "Filter";
            this.bbiFilter.Name = "bbiFilter";
            // 
            // bbiClosingDate
            // 
            this.bbiClosingDate.Caption = "Close";
            this.bbiClosingDate.Edit = this.ridClosingDate;
            this.bbiClosingDate.EditWidth = 120;
            this.bbiClosingDate.Hint = "Close date you want results";
            this.bbiClosingDate.Id = 26;
            this.bbiClosingDate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiClosingDate.ImageOptions.Image")));
            this.bbiClosingDate.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiClosingDate.ImageOptions.LargeImage")));
            this.bbiClosingDate.Name = "bbiClosingDate";
            this.bbiClosingDate.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            toolTipTitleItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            toolTipTitleItem1.Text = "Close session date";
            toolTipItem1.LeftIndent = 6;
            toolTipItem1.Text = "Specify the close session reference of the calculations.";
            superToolTip1.Items.Add(toolTipTitleItem1);
            superToolTip1.Items.Add(toolTipItem1);
            this.bbiClosingDate.SuperTip = superToolTip1;
            // 
            // ridClosingDate
            // 
            this.ridClosingDate.AutoHeight = false;
            this.ridClosingDate.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ridClosingDate.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ridClosingDate.Name = "ridClosingDate";
            // 
            // bbiNextClose
            // 
            this.bbiNextClose.Hint = "Next";
            this.bbiNextClose.Id = 27;
            this.bbiNextClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiNextClose.ImageOptions.Image")));
            this.bbiNextClose.Name = "bbiNextClose";
            this.bbiNextClose.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            this.bbiNextClose.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiNextClose_ItemClick);
            // 
            // bbiPreviousClose
            // 
            this.bbiPreviousClose.Hint = "Previous";
            this.bbiPreviousClose.Id = 28;
            this.bbiPreviousClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiPreviousClose.ImageOptions.Image")));
            this.bbiPreviousClose.Name = "bbiPreviousClose";
            this.bbiPreviousClose.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiPreviousClose_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.rpgEquity});
            this.ribbonPage1.MergeOrder = 1;
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Home";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiNew);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiEdit);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiDelete);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiRefresh);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            this.ribbonPageGroup1.Text = "Tasks";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.AllowTextClipping = false;
            this.ribbonPageGroup2.ItemLinks.Add(this.bbiPrintPreview);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.ShowCaptionButton = false;
            this.ribbonPageGroup2.Text = "Print and Export";
            // 
            // rpgEquity
            // 
            this.rpgEquity.ItemLinks.Add(this.bbiStocks);
            this.rpgEquity.ItemLinks.Add(this.barButtonItem4);
            this.rpgEquity.ItemLinks.Add(this.bbiFilter);
            this.rpgEquity.Name = "rpgEquity";
            this.rpgEquity.Text = "Equity";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ItemLinks.Add(this.bsiRecordsCount);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 573);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbonControl;
            this.ribbonStatusBar.Size = new System.Drawing.Size(800, 27);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "New";
            this.barButtonItem1.Id = 16;
            this.barButtonItem1.ImageOptions.ImageUri.Uri = "New";
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "New";
            this.barButtonItem2.Id = 16;
            this.barButtonItem2.ImageOptions.ImageUri.Uri = "New";
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // MainSplashScreenManager
            // 
            this.MainSplashScreenManager.ClosingDelay = 500;
            // 
            // gridSplitContainer1
            // 
            this.gridSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridSplitContainer1.Grid = this.gridControl;
            this.gridSplitContainer1.Location = new System.Drawing.Point(0, 116);
            this.gridSplitContainer1.Name = "gridSplitContainer1";
            this.gridSplitContainer1.Panel1.Controls.Add(this.gridControl);
            this.gridSplitContainer1.Size = new System.Drawing.Size(800, 457);
            this.gridSplitContainer1.TabIndex = 5;
            // 
            // InstrumentsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridSplitContainer1);
            this.Controls.Add(this.ribbonControl);
            this.Controls.Add(this.ribbonStatusBar);
            this.Name = "InstrumentsUserControl";
            this.Size = new System.Drawing.Size(800, 600);
            this.Load += new System.EventHandler(this.InstrumentsUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainOptionView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsEquity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainEquityView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ridClosingDate.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ridClosingDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1)).EndInit();
            this.gridSplitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView mainEquityView;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem bbiPrintPreview;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarStaticItem bsiRecordsCount;
        private DevExpress.XtraBars.BarButtonItem bbiNew;
        private DevExpress.XtraBars.BarButtonItem bbiEdit;
        private DevExpress.XtraBars.BarButtonItem bbiDelete;
        private DevExpress.XtraBars.BarButtonItem bbiRefresh;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgEquity;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem bbiStocks;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem bbiFilter;
        private System.Windows.Forms.BindingSource bdsEquity;
        private DevExpress.XtraGrid.Columns.GridColumn colB3ID;
        private DevExpress.XtraGrid.Columns.GridColumn colISIN;
        private DevExpress.XtraGrid.Columns.GridColumn colCompanyName;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colTicker;
        private DevExpress.XtraGrid.Columns.GridColumn colCurrency;
        private DevExpress.XtraGrid.Columns.GridColumn colMarketCapitalization;
        private DevExpress.XtraGrid.Columns.GridColumn colLastPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colLoadDate;
        private DevExpress.XtraGrid.Columns.GridColumn colSectorClassificationSetorEconomico;
        private DevExpress.XtraGrid.Columns.GridColumn colSectorClassificationSubsetorEconomico;
        private DevExpress.XtraGrid.Columns.GridColumn colSectorClassificationSegmentoEconomico;
        private DevExpress.XtraGrid.Views.Grid.GridView mainOptionView;
        private DevExpress.XtraGrid.Columns.GridColumn colOptionB3ID;
        private DevExpress.XtraGrid.Columns.GridColumn colOptionISIN;
        private DevExpress.XtraGrid.Columns.GridColumn colOptionDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colOptionTicker;
        private DevExpress.XtraGrid.Columns.GridColumn colOptionStrike;
        private DevExpress.XtraGrid.Columns.GridColumn colOptionStrikeCurrency;
        private DevExpress.XtraGrid.Columns.GridColumn colOptionStrikeStyle;
        private DevExpress.XtraGrid.Columns.GridColumn colOptionType;
        private DevExpress.XtraGrid.Columns.GridColumn colOptionExpiration;
        private DevExpress.XtraGrid.Columns.GridColumn colOptionLoadDate;
        private DevExpress.XtraGrid.Columns.GridColumn colOptionUnderlyingID;
        private DevExpress.XtraSplashScreen.SplashScreenManager MainSplashScreenManager;
        private DevExpress.XtraBars.BarEditItem bbiClosingDate;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit ridClosingDate;
        private DevExpress.XtraBars.BarButtonItem bbiNextClose;
        private DevExpress.XtraBars.BarButtonItem bbiPreviousClose;
        private DevExpress.XtraGrid.GridSplitContainer gridSplitContainer1;
    }
}
