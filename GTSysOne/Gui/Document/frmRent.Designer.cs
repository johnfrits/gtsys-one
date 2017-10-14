namespace GTSysOne.Gui.Document
{
    partial class frmRent
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
            p_instance = null;
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRent));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barNew = new DevExpress.XtraBars.BarButtonItem();
            this.barClose = new DevExpress.XtraBars.BarButtonItem();
            this.barSearch = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemSearchControl1 = new DevExpress.XtraEditors.Repository.RepositoryItemSearchControl();
            this.barFirst = new DevExpress.XtraBars.BarButtonItem();
            this.barPrevious = new DevExpress.XtraBars.BarButtonItem();
            this.barNext = new DevExpress.XtraBars.BarButtonItem();
            this.barLast = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barSave = new DevExpress.XtraBars.BarButtonItem();
            this.barPayment = new DevExpress.XtraBars.BarButtonItem();
            this.barDelete = new DevExpress.XtraBars.BarButtonItem();
            this.barVoid = new DevExpress.XtraBars.BarButtonItem();
            this.barPrint = new DevExpress.XtraBars.BarButtonItem();
            this.rpNumberingSetup = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpNew = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpSave = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpDeleteVoid = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpTools = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpSearch = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpClose = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.gridColumnlastnumeric = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.textEditPreviousBalance = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.textEditGrandTotal = new DevExpress.XtraEditors.TextEdit();
            this.textEditChange = new DevExpress.XtraEditors.TextEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.textEditTotalPay = new DevExpress.XtraEditors.TextEdit();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.buttonEditRenter = new DevExpress.XtraEditors.ButtonEdit();
            this.buttonEditDeposit = new DevExpress.XtraEditors.ButtonEdit();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.textEditNumbering = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.dateEditDueDate = new DevExpress.XtraEditors.DateEdit();
            this.dateEditPostDate = new DevExpress.XtraEditors.DateEdit();
            this.dateEditDocDate = new DevExpress.XtraEditors.DateEdit();
            this.lookUpEditStatus = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.textEditIdentityNumber = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnVoid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnDelete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnRentType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEditRentType = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gridColumnCar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEditCar = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridColumnDriver = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEditAddDriver = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gridColumnDateOut = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEditDateOut = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.gridColumnTimeOut = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTimeEditTimeOut = new DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit();
            this.gridColumnExpectedReturnDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEditExpectedReturnDate = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.gridColumnDateReturn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEditReturnDate = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.gridColumnNoOfDays = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEditNoOfDays = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.gridColumnDailyRate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEditDailyRate = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.gridColumnKMFrom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEditKMFrom = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.gridColumnKMTo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEditKMTo = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.gridColumnCDW = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEditCDW = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.gridColumnDellColCharge = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEditDellCollCharge = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.gridColumnTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEditTotal = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.gridColumnTax = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEditTax = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gridColumnDiscount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEditDiscount = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.gridColumnNetTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEditNetTotal = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.gridColumnDRId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnDId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnTId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnCId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnRTId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtCountry = new DevExpress.XtraEditors.TextEdit();
            this.txtCurrency = new DevExpress.XtraEditors.TextEdit();
            this.txtExchangeRate = new DevExpress.XtraEditors.TextEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.txtRTInsurance = new DevExpress.XtraEditors.TextEdit();
            this.labelControl16 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditPreviousBalance.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditGrandTotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditChange.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditTotalPay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEditRenter.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEditDeposit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditNumbering.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDueDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDueDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditPostDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditPostDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDocDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDocDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditIdentityNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditRentType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditAddDriver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDateOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDateOut.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTimeEditTimeOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditExpectedReturnDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditExpectedReturnDate.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditReturnDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditReturnDate.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEditNoOfDays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEditDailyRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEditKMFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEditKMTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEditCDW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEditDellCollCharge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEditTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditTax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEditDiscount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEditNetTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCountry.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCurrency.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtExchangeRate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRTInsurance.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ApplicationIcon = ((System.Drawing.Bitmap)(resources.GetObject("ribbon.ApplicationIcon")));
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.barNew,
            this.barClose,
            this.barSearch,
            this.barFirst,
            this.barPrevious,
            this.barNext,
            this.barLast,
            this.barButtonItem1,
            this.barSave,
            this.barPayment,
            this.barDelete,
            this.barVoid,
            this.barPrint});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 20;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rpNumberingSetup});
            this.ribbon.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemSearchControl1});
            this.ribbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbon.Size = new System.Drawing.Size(1256, 143);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // barNew
            // 
            this.barNew.Caption = "New";
            this.barNew.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.barNew.Glyph = ((System.Drawing.Image)(resources.GetObject("barNew.Glyph")));
            this.barNew.Id = 1;
            this.barNew.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barNew.LargeGlyph")));
            this.barNew.LargeWidth = 100;
            this.barNew.Name = "barNew";
            // 
            // barClose
            // 
            this.barClose.Caption = "Close";
            this.barClose.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.barClose.Glyph = ((System.Drawing.Image)(resources.GetObject("barClose.Glyph")));
            this.barClose.Id = 2;
            this.barClose.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barClose.LargeGlyph")));
            this.barClose.LargeWidth = 100;
            this.barClose.Name = "barClose";
            // 
            // barSearch
            // 
            this.barSearch.Caption = "Search";
            this.barSearch.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.barSearch.Edit = this.repositoryItemSearchControl1;
            this.barSearch.Id = 3;
            this.barSearch.Name = "barSearch";
            this.barSearch.Width = 150;
            // 
            // repositoryItemSearchControl1
            // 
            this.repositoryItemSearchControl1.AutoHeight = false;
            this.repositoryItemSearchControl1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.repositoryItemSearchControl1.Name = "repositoryItemSearchControl1";
            this.repositoryItemSearchControl1.ShowDefaultButtonsMode = DevExpress.XtraEditors.Repository.ShowDefaultButtonsMode.Always;
            // 
            // barFirst
            // 
            this.barFirst.Caption = "First";
            this.barFirst.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.barFirst.Glyph = ((System.Drawing.Image)(resources.GetObject("barFirst.Glyph")));
            this.barFirst.Id = 4;
            this.barFirst.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barFirst.LargeGlyph")));
            this.barFirst.LargeWidth = 70;
            this.barFirst.Name = "barFirst";
            // 
            // barPrevious
            // 
            this.barPrevious.Caption = "Previous";
            this.barPrevious.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.barPrevious.Glyph = ((System.Drawing.Image)(resources.GetObject("barPrevious.Glyph")));
            this.barPrevious.Id = 5;
            this.barPrevious.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barPrevious.LargeGlyph")));
            this.barPrevious.LargeWidth = 70;
            this.barPrevious.Name = "barPrevious";
            // 
            // barNext
            // 
            this.barNext.Caption = "Next";
            this.barNext.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.barNext.Glyph = ((System.Drawing.Image)(resources.GetObject("barNext.Glyph")));
            this.barNext.Id = 6;
            this.barNext.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barNext.LargeGlyph")));
            this.barNext.LargeWidth = 70;
            this.barNext.Name = "barNext";
            // 
            // barLast
            // 
            this.barLast.Caption = "Last";
            this.barLast.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.barLast.Glyph = ((System.Drawing.Image)(resources.GetObject("barLast.Glyph")));
            this.barLast.Id = 7;
            this.barLast.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barLast.LargeGlyph")));
            this.barLast.LargeWidth = 70;
            this.barLast.Name = "barLast";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.barButtonItem1.Enabled = false;
            this.barButtonItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.Glyph")));
            this.barButtonItem1.Id = 8;
            this.barButtonItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.LargeGlyph")));
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barSave
            // 
            this.barSave.Caption = "Save";
            this.barSave.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.barSave.Glyph = ((System.Drawing.Image)(resources.GetObject("barSave.Glyph")));
            this.barSave.Id = 9;
            this.barSave.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barSave.LargeGlyph")));
            this.barSave.LargeWidth = 100;
            this.barSave.Name = "barSave";
            // 
            // barPayment
            // 
            this.barPayment.Caption = "Payment";
            this.barPayment.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.barPayment.Glyph = ((System.Drawing.Image)(resources.GetObject("barPayment.Glyph")));
            this.barPayment.Id = 16;
            this.barPayment.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barPayment.LargeGlyph")));
            this.barPayment.LargeWidth = 100;
            this.barPayment.Name = "barPayment";
            // 
            // barDelete
            // 
            this.barDelete.Caption = "Delete";
            this.barDelete.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.barDelete.Glyph = ((System.Drawing.Image)(resources.GetObject("barDelete.Glyph")));
            this.barDelete.Id = 17;
            this.barDelete.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barDelete.LargeGlyph")));
            this.barDelete.LargeWidth = 80;
            this.barDelete.Name = "barDelete";
            // 
            // barVoid
            // 
            this.barVoid.Caption = "Void";
            this.barVoid.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.barVoid.Glyph = ((System.Drawing.Image)(resources.GetObject("barVoid.Glyph")));
            this.barVoid.Id = 18;
            this.barVoid.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barVoid.LargeGlyph")));
            this.barVoid.LargeWidth = 80;
            this.barVoid.Name = "barVoid";
            // 
            // barPrint
            // 
            this.barPrint.Caption = "Print";
            this.barPrint.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.barPrint.Glyph = ((System.Drawing.Image)(resources.GetObject("barPrint.Glyph")));
            this.barPrint.Id = 19;
            this.barPrint.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barPrint.LargeGlyph")));
            this.barPrint.LargeWidth = 100;
            this.barPrint.Name = "barPrint";
            // 
            // rpNumberingSetup
            // 
            this.rpNumberingSetup.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpNew,
            this.rpSave,
            this.rpDeleteVoid,
            this.rpTools,
            this.rpSearch,
            this.rpClose});
            this.rpNumberingSetup.Name = "rpNumberingSetup";
            this.rpNumberingSetup.Text = "Rent";
            // 
            // rpNew
            // 
            this.rpNew.ItemLinks.Add(this.barNew);
            this.rpNew.Name = "rpNew";
            this.rpNew.Text = "New";
            // 
            // rpSave
            // 
            this.rpSave.ItemLinks.Add(this.barSave);
            this.rpSave.ItemLinks.Add(this.barPayment);
            this.rpSave.ItemLinks.Add(this.barPrint);
            this.rpSave.Name = "rpSave";
            this.rpSave.Text = "Save | Payment | Print";
            // 
            // rpDeleteVoid
            // 
            this.rpDeleteVoid.ItemLinks.Add(this.barDelete);
            this.rpDeleteVoid.ItemLinks.Add(this.barVoid);
            this.rpDeleteVoid.Name = "rpDeleteVoid";
            this.rpDeleteVoid.Text = "Delete | Void";
            // 
            // rpTools
            // 
            this.rpTools.ItemLinks.Add(this.barFirst);
            this.rpTools.ItemLinks.Add(this.barPrevious);
            this.rpTools.ItemLinks.Add(this.barButtonItem1);
            this.rpTools.ItemLinks.Add(this.barNext);
            this.rpTools.ItemLinks.Add(this.barLast);
            this.rpTools.Name = "rpTools";
            this.rpTools.Text = "Tools";
            // 
            // rpSearch
            // 
            this.rpSearch.ItemLinks.Add(this.barSearch);
            this.rpSearch.Name = "rpSearch";
            this.rpSearch.Text = "Search";
            // 
            // rpClose
            // 
            this.rpClose.ItemLinks.Add(this.barClose);
            this.rpClose.Name = "rpClose";
            this.rpClose.Text = "Close";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 636);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1256, 31);
            // 
            // gridColumnlastnumeric
            // 
            this.gridColumnlastnumeric.Name = "gridColumnlastnumeric";
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.labelControl2.Location = new System.Drawing.Point(123, 216);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(57, 16);
            this.labelControl2.TabIndex = 9;
            this.labelControl2.Text = "Customer";
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.labelControl4.Location = new System.Drawing.Point(843, 256);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(57, 16);
            this.labelControl4.TabIndex = 15;
            this.labelControl4.Text = "Doc Date";
            // 
            // labelControl5
            // 
            this.labelControl5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.labelControl5.Location = new System.Drawing.Point(374, 571);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(106, 16);
            this.labelControl5.TabIndex = 17;
            this.labelControl5.Text = "Previous Balance";
            // 
            // textEditPreviousBalance
            // 
            this.textEditPreviousBalance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textEditPreviousBalance.Location = new System.Drawing.Point(374, 590);
            this.textEditPreviousBalance.MenuManager = this.ribbon;
            this.textEditPreviousBalance.Name = "textEditPreviousBalance";
            this.textEditPreviousBalance.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEditPreviousBalance.Properties.Appearance.Options.UseFont = true;
            this.textEditPreviousBalance.Properties.Mask.EditMask = "n2";
            this.textEditPreviousBalance.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.textEditPreviousBalance.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.textEditPreviousBalance.Properties.NullText = "0.00";
            this.textEditPreviousBalance.Properties.NullValuePrompt = "Previous Balance";
            this.textEditPreviousBalance.Properties.NullValuePromptShowForEmptyValue = true;
            this.textEditPreviousBalance.Properties.ReadOnly = true;
            this.textEditPreviousBalance.Size = new System.Drawing.Size(345, 30);
            this.textEditPreviousBalance.TabIndex = 18;
            // 
            // labelControl9
            // 
            this.labelControl9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Location = new System.Drawing.Point(1160, 531);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(84, 20);
            this.labelControl9.TabIndex = 31;
            this.labelControl9.Text = "Grand Total";
            // 
            // textEditGrandTotal
            // 
            this.textEditGrandTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textEditGrandTotal.Location = new System.Drawing.Point(878, 555);
            this.textEditGrandTotal.MenuManager = this.ribbon;
            this.textEditGrandTotal.Name = "textEditGrandTotal";
            this.textEditGrandTotal.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEditGrandTotal.Properties.Appearance.Options.UseFont = true;
            this.textEditGrandTotal.Properties.Mask.EditMask = "n2";
            this.textEditGrandTotal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.textEditGrandTotal.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.textEditGrandTotal.Properties.NullText = "0.00";
            this.textEditGrandTotal.Properties.NullValuePrompt = "Grand Total";
            this.textEditGrandTotal.Properties.NullValuePromptShowForEmptyValue = true;
            this.textEditGrandTotal.Properties.ReadOnly = true;
            this.textEditGrandTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textEditGrandTotal.Size = new System.Drawing.Size(366, 36);
            this.textEditGrandTotal.TabIndex = 32;
            // 
            // textEditChange
            // 
            this.textEditChange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textEditChange.Location = new System.Drawing.Point(12, 590);
            this.textEditChange.MenuManager = this.ribbon;
            this.textEditChange.Name = "textEditChange";
            this.textEditChange.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEditChange.Properties.Appearance.Options.UseFont = true;
            this.textEditChange.Properties.Mask.EditMask = "n2";
            this.textEditChange.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.textEditChange.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.textEditChange.Properties.NullText = "0.00";
            this.textEditChange.Properties.NullValuePrompt = "Change";
            this.textEditChange.Properties.NullValuePromptShowForEmptyValue = true;
            this.textEditChange.Properties.ReadOnly = true;
            this.textEditChange.Size = new System.Drawing.Size(342, 30);
            this.textEditChange.TabIndex = 36;
            // 
            // labelControl11
            // 
            this.labelControl11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.labelControl11.Location = new System.Drawing.Point(12, 568);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(47, 16);
            this.labelControl11.TabIndex = 35;
            this.labelControl11.Text = "Change";
            // 
            // textEditTotalPay
            // 
            this.textEditTotalPay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textEditTotalPay.Location = new System.Drawing.Point(13, 535);
            this.textEditTotalPay.MenuManager = this.ribbon;
            this.textEditTotalPay.Name = "textEditTotalPay";
            this.textEditTotalPay.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEditTotalPay.Properties.Appearance.Options.UseFont = true;
            this.textEditTotalPay.Properties.Mask.EditMask = "n2";
            this.textEditTotalPay.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.textEditTotalPay.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.textEditTotalPay.Properties.NullText = "0.00";
            this.textEditTotalPay.Properties.NullValuePrompt = "Total Pay";
            this.textEditTotalPay.Properties.NullValuePromptShowForEmptyValue = true;
            this.textEditTotalPay.Properties.ReadOnly = true;
            this.textEditTotalPay.Size = new System.Drawing.Size(341, 30);
            this.textEditTotalPay.TabIndex = 38;
            // 
            // labelControl12
            // 
            this.labelControl12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.labelControl12.Location = new System.Drawing.Point(13, 513);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(58, 16);
            this.labelControl12.TabIndex = 37;
            this.labelControl12.Text = "Total Pay";
            // 
            // buttonEditRenter
            // 
            this.buttonEditRenter.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonEditRenter.Location = new System.Drawing.Point(230, 213);
            this.buttonEditRenter.MenuManager = this.ribbon;
            this.buttonEditRenter.Name = "buttonEditRenter";
            this.buttonEditRenter.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.buttonEditRenter.Properties.Appearance.Options.UseFont = true;
            this.buttonEditRenter.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("buttonEditRenter.Properties.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("buttonEditRenter.Properties.Buttons1"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", null, null, true)});
            this.buttonEditRenter.Properties.NullValuePrompt = "Customer";
            this.buttonEditRenter.Properties.NullValuePromptShowForEmptyValue = true;
            this.buttonEditRenter.Properties.ReadOnly = true;
            this.buttonEditRenter.Size = new System.Drawing.Size(196, 22);
            this.buttonEditRenter.TabIndex = 44;
            // 
            // buttonEditDeposit
            // 
            this.buttonEditDeposit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonEditDeposit.Location = new System.Drawing.Point(570, 253);
            this.buttonEditDeposit.MenuManager = this.ribbon;
            this.buttonEditDeposit.Name = "buttonEditDeposit";
            this.buttonEditDeposit.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.buttonEditDeposit.Properties.Appearance.Options.UseFont = true;
            this.buttonEditDeposit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("buttonEditDeposit.Properties.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject3, "", null, null, true)});
            this.buttonEditDeposit.Properties.Mask.EditMask = "n2";
            this.buttonEditDeposit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.buttonEditDeposit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.buttonEditDeposit.Properties.NullText = "0.00";
            this.buttonEditDeposit.Properties.NullValuePrompt = "Deposit";
            this.buttonEditDeposit.Properties.NullValuePromptShowForEmptyValue = true;
            this.buttonEditDeposit.Properties.ReadOnly = true;
            this.buttonEditDeposit.Size = new System.Drawing.Size(211, 22);
            this.buttonEditDeposit.TabIndex = 50;
            this.buttonEditDeposit.EditValueChanged += new System.EventHandler(this.buttonEditDeposit_EditValueChanged);
            // 
            // labelControl13
            // 
            this.labelControl13.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl13.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.labelControl13.Location = new System.Drawing.Point(123, 244);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(93, 16);
            this.labelControl13.TabIndex = 53;
            this.labelControl13.Text = "Identity Number";
            // 
            // textEditNumbering
            // 
            this.textEditNumbering.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textEditNumbering.Location = new System.Drawing.Point(230, 185);
            this.textEditNumbering.MenuManager = this.ribbon;
            this.textEditNumbering.Name = "textEditNumbering";
            this.textEditNumbering.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.textEditNumbering.Properties.Appearance.Options.UseFont = true;
            this.textEditNumbering.Properties.Mask.EditMask = "f";
            this.textEditNumbering.Properties.NullValuePrompt = "Numbering";
            this.textEditNumbering.Properties.NullValuePromptShowForEmptyValue = true;
            this.textEditNumbering.Size = new System.Drawing.Size(196, 22);
            this.textEditNumbering.TabIndex = 61;
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.labelControl1.Location = new System.Drawing.Point(124, 188);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(66, 16);
            this.labelControl1.TabIndex = 60;
            this.labelControl1.Text = "Numbering";
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.labelControl3.Location = new System.Drawing.Point(843, 200);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(59, 16);
            this.labelControl3.TabIndex = 64;
            this.labelControl3.Text = "Post Date";
            // 
            // labelControl6
            // 
            this.labelControl6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.labelControl6.Location = new System.Drawing.Point(843, 228);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(57, 16);
            this.labelControl6.TabIndex = 66;
            this.labelControl6.Text = "Due Date";
            // 
            // dateEditDueDate
            // 
            this.dateEditDueDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateEditDueDate.EditValue = null;
            this.dateEditDueDate.Location = new System.Drawing.Point(918, 225);
            this.dateEditDueDate.MenuManager = this.ribbon;
            this.dateEditDueDate.Name = "dateEditDueDate";
            this.dateEditDueDate.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateEditDueDate.Properties.Appearance.Options.UseFont = true;
            this.dateEditDueDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditDueDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditDueDate.Properties.NullValuePrompt = "Due Date";
            this.dateEditDueDate.Properties.NullValuePromptShowForEmptyValue = true;
            this.dateEditDueDate.Size = new System.Drawing.Size(190, 22);
            this.dateEditDueDate.TabIndex = 70;
            // 
            // dateEditPostDate
            // 
            this.dateEditPostDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateEditPostDate.EditValue = null;
            this.dateEditPostDate.Location = new System.Drawing.Point(918, 197);
            this.dateEditPostDate.MenuManager = this.ribbon;
            this.dateEditPostDate.Name = "dateEditPostDate";
            this.dateEditPostDate.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateEditPostDate.Properties.Appearance.Options.UseFont = true;
            this.dateEditPostDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditPostDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditPostDate.Properties.NullValuePrompt = "Post Date";
            this.dateEditPostDate.Properties.NullValuePromptShowForEmptyValue = true;
            this.dateEditPostDate.Size = new System.Drawing.Size(190, 22);
            this.dateEditPostDate.TabIndex = 71;
            // 
            // dateEditDocDate
            // 
            this.dateEditDocDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateEditDocDate.EditValue = null;
            this.dateEditDocDate.Location = new System.Drawing.Point(918, 253);
            this.dateEditDocDate.MenuManager = this.ribbon;
            this.dateEditDocDate.Name = "dateEditDocDate";
            this.dateEditDocDate.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateEditDocDate.Properties.Appearance.Options.UseFont = true;
            this.dateEditDocDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditDocDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditDocDate.Properties.NullValuePrompt = "Doc Date";
            this.dateEditDocDate.Properties.NullValuePromptShowForEmptyValue = true;
            this.dateEditDocDate.Size = new System.Drawing.Size(190, 22);
            this.dateEditDocDate.TabIndex = 74;
            // 
            // lookUpEditStatus
            // 
            this.lookUpEditStatus.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lookUpEditStatus.Location = new System.Drawing.Point(918, 169);
            this.lookUpEditStatus.MenuManager = this.ribbon;
            this.lookUpEditStatus.Name = "lookUpEditStatus";
            this.lookUpEditStatus.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lookUpEditStatus.Properties.Appearance.Options.UseFont = true;
            this.lookUpEditStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditStatus.Properties.NullText = "";
            this.lookUpEditStatus.Properties.NullValuePrompt = "Status";
            this.lookUpEditStatus.Properties.NullValuePromptShowForEmptyValue = true;
            this.lookUpEditStatus.Size = new System.Drawing.Size(190, 22);
            this.lookUpEditStatus.TabIndex = 77;
            // 
            // labelControl7
            // 
            this.labelControl7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.labelControl7.Location = new System.Drawing.Point(843, 175);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(37, 16);
            this.labelControl7.TabIndex = 78;
            this.labelControl7.Text = "Status";
            // 
            // textEditIdentityNumber
            // 
            this.textEditIdentityNumber.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textEditIdentityNumber.Location = new System.Drawing.Point(230, 241);
            this.textEditIdentityNumber.MenuManager = this.ribbon;
            this.textEditIdentityNumber.Name = "textEditIdentityNumber";
            this.textEditIdentityNumber.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.textEditIdentityNumber.Properties.Appearance.Options.UseFont = true;
            this.textEditIdentityNumber.Properties.Mask.EditMask = "f";
            this.textEditIdentityNumber.Properties.NullValuePrompt = "Identity Number";
            this.textEditIdentityNumber.Properties.NullValuePromptShowForEmptyValue = true;
            this.textEditIdentityNumber.Size = new System.Drawing.Size(196, 22);
            this.textEditIdentityNumber.TabIndex = 54;
            // 
            // labelControl8
            // 
            this.labelControl8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.labelControl8.Location = new System.Drawing.Point(458, 200);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(53, 16);
            this.labelControl8.TabIndex = 83;
            this.labelControl8.Text = "Currency";
            // 
            // labelControl14
            // 
            this.labelControl14.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl14.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.labelControl14.Location = new System.Drawing.Point(458, 172);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(45, 16);
            this.labelControl14.TabIndex = 82;
            this.labelControl14.Text = "Country";
            // 
            // labelControl15
            // 
            this.labelControl15.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl15.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.labelControl15.Location = new System.Drawing.Point(458, 228);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(92, 16);
            this.labelControl15.TabIndex = 81;
            this.labelControl15.Text = "Exchange Rate";
            // 
            // gridControl
            // 
            this.gridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl.Location = new System.Drawing.Point(12, 292);
            this.gridControl.MainView = this.gridView;
            this.gridControl.Name = "gridControl";
            this.gridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEditRentType,
            this.repositoryItemButtonEditCar,
            this.repositoryItemLookUpEditAddDriver,
            this.repositoryItemDateEditDateOut,
            this.repositoryItemTimeEditTimeOut,
            this.repositoryItemDateEditExpectedReturnDate,
            this.repositoryItemDateEditReturnDate,
            this.repositoryItemTextEditNoOfDays,
            this.repositoryItemTextEditDailyRate,
            this.repositoryItemTextEditKMFrom,
            this.repositoryItemTextEditKMTo,
            this.repositoryItemTextEditDellCollCharge,
            this.repositoryItemTextEditTotal,
            this.repositoryItemLookUpEditTax,
            this.repositoryItemTextEditDiscount,
            this.repositoryItemTextEditNetTotal,
            this.repositoryItemTextEditCDW});
            this.gridControl.Size = new System.Drawing.Size(1232, 207);
            this.gridControl.TabIndex = 94;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnid,
            this.gridColumnVoid,
            this.gridColumnDelete,
            this.gridColumnRentType,
            this.gridColumnCar,
            this.gridColumnDriver,
            this.gridColumnDateOut,
            this.gridColumnTimeOut,
            this.gridColumnExpectedReturnDate,
            this.gridColumnDateReturn,
            this.gridColumnNoOfDays,
            this.gridColumnDailyRate,
            this.gridColumnKMFrom,
            this.gridColumnKMTo,
            this.gridColumnCDW,
            this.gridColumnDellColCharge,
            this.gridColumnTotal,
            this.gridColumnTax,
            this.gridColumnDiscount,
            this.gridColumnNetTotal,
            this.gridColumnDRId,
            this.gridColumnDId,
            this.gridColumnTId,
            this.gridColumnCId,
            this.gridColumnRTId});
            this.gridView.CustomizationFormBounds = new System.Drawing.Rectangle(851, 660, 210, 172);
            this.gridView.GridControl = this.gridControl;
            this.gridView.Name = "gridView";
            this.gridView.OptionsView.ColumnAutoWidth = false;
            this.gridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView.OptionsView.ShowGroupPanel = false;
            this.gridView.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridView_RowCellStyle);
            this.gridView.RowCountChanged += new System.EventHandler(this.gridView_RowCountChanged);
            // 
            // gridColumnid
            // 
            this.gridColumnid.Caption = "Id";
            this.gridColumnid.FieldName = "id";
            this.gridColumnid.Name = "gridColumnid";
            // 
            // gridColumnVoid
            // 
            this.gridColumnVoid.Caption = "Void";
            this.gridColumnVoid.FieldName = "void";
            this.gridColumnVoid.Name = "gridColumnVoid";
            this.gridColumnVoid.Visible = true;
            this.gridColumnVoid.VisibleIndex = 0;
            // 
            // gridColumnDelete
            // 
            this.gridColumnDelete.Caption = "Delete";
            this.gridColumnDelete.FieldName = "deleted";
            this.gridColumnDelete.Name = "gridColumnDelete";
            this.gridColumnDelete.Visible = true;
            this.gridColumnDelete.VisibleIndex = 1;
            // 
            // gridColumnRentType
            // 
            this.gridColumnRentType.Caption = "Rent Type";
            this.gridColumnRentType.ColumnEdit = this.repositoryItemLookUpEditRentType;
            this.gridColumnRentType.FieldName = "RentType";
            this.gridColumnRentType.Name = "gridColumnRentType";
            this.gridColumnRentType.Visible = true;
            this.gridColumnRentType.VisibleIndex = 2;
            this.gridColumnRentType.Width = 95;
            // 
            // repositoryItemLookUpEditRentType
            // 
            this.repositoryItemLookUpEditRentType.AutoHeight = false;
            this.repositoryItemLookUpEditRentType.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEditRentType.Name = "repositoryItemLookUpEditRentType";
            this.repositoryItemLookUpEditRentType.NullText = "";
            // 
            // gridColumnCar
            // 
            this.gridColumnCar.Caption = "Add Car";
            this.gridColumnCar.ColumnEdit = this.repositoryItemButtonEditCar;
            this.gridColumnCar.FieldName = "Car";
            this.gridColumnCar.Name = "gridColumnCar";
            this.gridColumnCar.Visible = true;
            this.gridColumnCar.VisibleIndex = 3;
            this.gridColumnCar.Width = 117;
            // 
            // repositoryItemButtonEditCar
            // 
            this.repositoryItemButtonEditCar.AutoHeight = false;
            this.repositoryItemButtonEditCar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemButtonEditCar.Name = "repositoryItemButtonEditCar";
            // 
            // gridColumnDriver
            // 
            this.gridColumnDriver.Caption = "Add Driver";
            this.gridColumnDriver.ColumnEdit = this.repositoryItemLookUpEditAddDriver;
            this.gridColumnDriver.FieldName = "AddDriver";
            this.gridColumnDriver.Name = "gridColumnDriver";
            this.gridColumnDriver.Visible = true;
            this.gridColumnDriver.VisibleIndex = 4;
            this.gridColumnDriver.Width = 104;
            // 
            // repositoryItemLookUpEditAddDriver
            // 
            this.repositoryItemLookUpEditAddDriver.AutoHeight = false;
            this.repositoryItemLookUpEditAddDriver.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("repositoryItemLookUpEditAddDriver.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject4, "", null, null, true)});
            this.repositoryItemLookUpEditAddDriver.Name = "repositoryItemLookUpEditAddDriver";
            this.repositoryItemLookUpEditAddDriver.NullText = "";
            // 
            // gridColumnDateOut
            // 
            this.gridColumnDateOut.Caption = "Date Out";
            this.gridColumnDateOut.ColumnEdit = this.repositoryItemDateEditDateOut;
            this.gridColumnDateOut.FieldName = "DateOut";
            this.gridColumnDateOut.Name = "gridColumnDateOut";
            this.gridColumnDateOut.Visible = true;
            this.gridColumnDateOut.VisibleIndex = 5;
            this.gridColumnDateOut.Width = 121;
            // 
            // repositoryItemDateEditDateOut
            // 
            this.repositoryItemDateEditDateOut.AutoHeight = false;
            this.repositoryItemDateEditDateOut.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEditDateOut.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEditDateOut.Mask.UseMaskAsDisplayFormat = true;
            this.repositoryItemDateEditDateOut.Name = "repositoryItemDateEditDateOut";
            // 
            // gridColumnTimeOut
            // 
            this.gridColumnTimeOut.Caption = "Time Out";
            this.gridColumnTimeOut.ColumnEdit = this.repositoryItemTimeEditTimeOut;
            this.gridColumnTimeOut.FieldName = "TimeOut";
            this.gridColumnTimeOut.Name = "gridColumnTimeOut";
            this.gridColumnTimeOut.Visible = true;
            this.gridColumnTimeOut.VisibleIndex = 6;
            this.gridColumnTimeOut.Width = 122;
            // 
            // repositoryItemTimeEditTimeOut
            // 
            this.repositoryItemTimeEditTimeOut.AutoHeight = false;
            this.repositoryItemTimeEditTimeOut.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemTimeEditTimeOut.Mask.UseMaskAsDisplayFormat = true;
            this.repositoryItemTimeEditTimeOut.Name = "repositoryItemTimeEditTimeOut";
            // 
            // gridColumnExpectedReturnDate
            // 
            this.gridColumnExpectedReturnDate.Caption = "Expected Return Date";
            this.gridColumnExpectedReturnDate.ColumnEdit = this.repositoryItemDateEditExpectedReturnDate;
            this.gridColumnExpectedReturnDate.FieldName = "ExpectedReturnDate";
            this.gridColumnExpectedReturnDate.Name = "gridColumnExpectedReturnDate";
            this.gridColumnExpectedReturnDate.Visible = true;
            this.gridColumnExpectedReturnDate.VisibleIndex = 7;
            this.gridColumnExpectedReturnDate.Width = 133;
            // 
            // repositoryItemDateEditExpectedReturnDate
            // 
            this.repositoryItemDateEditExpectedReturnDate.AutoHeight = false;
            this.repositoryItemDateEditExpectedReturnDate.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEditExpectedReturnDate.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEditExpectedReturnDate.Mask.UseMaskAsDisplayFormat = true;
            this.repositoryItemDateEditExpectedReturnDate.Name = "repositoryItemDateEditExpectedReturnDate";
            // 
            // gridColumnDateReturn
            // 
            this.gridColumnDateReturn.Caption = "DateReturn";
            this.gridColumnDateReturn.ColumnEdit = this.repositoryItemDateEditReturnDate;
            this.gridColumnDateReturn.FieldName = "DateReturn";
            this.gridColumnDateReturn.Name = "gridColumnDateReturn";
            this.gridColumnDateReturn.Visible = true;
            this.gridColumnDateReturn.VisibleIndex = 8;
            this.gridColumnDateReturn.Width = 102;
            // 
            // repositoryItemDateEditReturnDate
            // 
            this.repositoryItemDateEditReturnDate.AutoHeight = false;
            this.repositoryItemDateEditReturnDate.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEditReturnDate.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEditReturnDate.Mask.UseMaskAsDisplayFormat = true;
            this.repositoryItemDateEditReturnDate.Name = "repositoryItemDateEditReturnDate";
            // 
            // gridColumnNoOfDays
            // 
            this.gridColumnNoOfDays.Caption = "No. of  Days";
            this.gridColumnNoOfDays.ColumnEdit = this.repositoryItemTextEditNoOfDays;
            this.gridColumnNoOfDays.FieldName = "NoOfDays";
            this.gridColumnNoOfDays.Name = "gridColumnNoOfDays";
            this.gridColumnNoOfDays.Visible = true;
            this.gridColumnNoOfDays.VisibleIndex = 9;
            this.gridColumnNoOfDays.Width = 84;
            // 
            // repositoryItemTextEditNoOfDays
            // 
            this.repositoryItemTextEditNoOfDays.AutoHeight = false;
            this.repositoryItemTextEditNoOfDays.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.repositoryItemTextEditNoOfDays.Name = "repositoryItemTextEditNoOfDays";
            this.repositoryItemTextEditNoOfDays.NullText = "0";
            // 
            // gridColumnDailyRate
            // 
            this.gridColumnDailyRate.Caption = "Daily Rate";
            this.gridColumnDailyRate.ColumnEdit = this.repositoryItemTextEditDailyRate;
            this.gridColumnDailyRate.FieldName = "DailyRate";
            this.gridColumnDailyRate.Name = "gridColumnDailyRate";
            this.gridColumnDailyRate.Visible = true;
            this.gridColumnDailyRate.VisibleIndex = 10;
            // 
            // repositoryItemTextEditDailyRate
            // 
            this.repositoryItemTextEditDailyRate.AutoHeight = false;
            this.repositoryItemTextEditDailyRate.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.repositoryItemTextEditDailyRate.Name = "repositoryItemTextEditDailyRate";
            this.repositoryItemTextEditDailyRate.NullText = "0.00";
            // 
            // gridColumnKMFrom
            // 
            this.gridColumnKMFrom.Caption = "Kilometer From";
            this.gridColumnKMFrom.ColumnEdit = this.repositoryItemTextEditKMFrom;
            this.gridColumnKMFrom.FieldName = "KMFrom";
            this.gridColumnKMFrom.Name = "gridColumnKMFrom";
            this.gridColumnKMFrom.Visible = true;
            this.gridColumnKMFrom.VisibleIndex = 11;
            this.gridColumnKMFrom.Width = 92;
            // 
            // repositoryItemTextEditKMFrom
            // 
            this.repositoryItemTextEditKMFrom.AutoHeight = false;
            this.repositoryItemTextEditKMFrom.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.repositoryItemTextEditKMFrom.Name = "repositoryItemTextEditKMFrom";
            this.repositoryItemTextEditKMFrom.NullText = "0";
            // 
            // gridColumnKMTo
            // 
            this.gridColumnKMTo.Caption = "Kilometer To";
            this.gridColumnKMTo.ColumnEdit = this.repositoryItemTextEditKMTo;
            this.gridColumnKMTo.FieldName = "KMTo";
            this.gridColumnKMTo.Name = "gridColumnKMTo";
            this.gridColumnKMTo.Visible = true;
            this.gridColumnKMTo.VisibleIndex = 12;
            this.gridColumnKMTo.Width = 80;
            // 
            // repositoryItemTextEditKMTo
            // 
            this.repositoryItemTextEditKMTo.AutoHeight = false;
            this.repositoryItemTextEditKMTo.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.repositoryItemTextEditKMTo.Name = "repositoryItemTextEditKMTo";
            this.repositoryItemTextEditKMTo.NullText = "0";
            // 
            // gridColumnCDW
            // 
            this.gridColumnCDW.Caption = "CDW";
            this.gridColumnCDW.ColumnEdit = this.repositoryItemTextEditCDW;
            this.gridColumnCDW.FieldName = "CDW";
            this.gridColumnCDW.Name = "gridColumnCDW";
            this.gridColumnCDW.Visible = true;
            this.gridColumnCDW.VisibleIndex = 13;
            // 
            // repositoryItemTextEditCDW
            // 
            this.repositoryItemTextEditCDW.AutoHeight = false;
            this.repositoryItemTextEditCDW.Mask.EditMask = "n2";
            this.repositoryItemTextEditCDW.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.repositoryItemTextEditCDW.Mask.UseMaskAsDisplayFormat = true;
            this.repositoryItemTextEditCDW.Name = "repositoryItemTextEditCDW";
            this.repositoryItemTextEditCDW.NullText = "0.00";
            // 
            // gridColumnDellColCharge
            // 
            this.gridColumnDellColCharge.Caption = "Dell/Col/Charge";
            this.gridColumnDellColCharge.ColumnEdit = this.repositoryItemTextEditDellCollCharge;
            this.gridColumnDellColCharge.FieldName = "Dell/Col/Charge";
            this.gridColumnDellColCharge.Name = "gridColumnDellColCharge";
            this.gridColumnDellColCharge.Visible = true;
            this.gridColumnDellColCharge.VisibleIndex = 14;
            this.gridColumnDellColCharge.Width = 110;
            // 
            // repositoryItemTextEditDellCollCharge
            // 
            this.repositoryItemTextEditDellCollCharge.AutoHeight = false;
            this.repositoryItemTextEditDellCollCharge.Mask.EditMask = "n2";
            this.repositoryItemTextEditDellCollCharge.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.repositoryItemTextEditDellCollCharge.Mask.UseMaskAsDisplayFormat = true;
            this.repositoryItemTextEditDellCollCharge.Name = "repositoryItemTextEditDellCollCharge";
            this.repositoryItemTextEditDellCollCharge.NullText = "0.00";
            // 
            // gridColumnTotal
            // 
            this.gridColumnTotal.Caption = "Total";
            this.gridColumnTotal.ColumnEdit = this.repositoryItemTextEditTotal;
            this.gridColumnTotal.FieldName = "Total";
            this.gridColumnTotal.Name = "gridColumnTotal";
            this.gridColumnTotal.Visible = true;
            this.gridColumnTotal.VisibleIndex = 15;
            // 
            // repositoryItemTextEditTotal
            // 
            this.repositoryItemTextEditTotal.AutoHeight = false;
            this.repositoryItemTextEditTotal.Mask.EditMask = "n2";
            this.repositoryItemTextEditTotal.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.repositoryItemTextEditTotal.Mask.UseMaskAsDisplayFormat = true;
            this.repositoryItemTextEditTotal.Name = "repositoryItemTextEditTotal";
            this.repositoryItemTextEditTotal.NullText = "0.00";
            // 
            // gridColumnTax
            // 
            this.gridColumnTax.Caption = "Tax";
            this.gridColumnTax.ColumnEdit = this.repositoryItemLookUpEditTax;
            this.gridColumnTax.FieldName = "Tax";
            this.gridColumnTax.Name = "gridColumnTax";
            this.gridColumnTax.Visible = true;
            this.gridColumnTax.VisibleIndex = 16;
            // 
            // repositoryItemLookUpEditTax
            // 
            this.repositoryItemLookUpEditTax.AutoHeight = false;
            this.repositoryItemLookUpEditTax.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("repositoryItemLookUpEditTax.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, "", null, null, true)});
            this.repositoryItemLookUpEditTax.Name = "repositoryItemLookUpEditTax";
            this.repositoryItemLookUpEditTax.NullText = "0.00";
            this.repositoryItemLookUpEditTax.NullValuePrompt = "0.00";
            this.repositoryItemLookUpEditTax.NullValuePromptShowForEmptyValue = true;
            // 
            // gridColumnDiscount
            // 
            this.gridColumnDiscount.Caption = "Discount";
            this.gridColumnDiscount.ColumnEdit = this.repositoryItemTextEditDiscount;
            this.gridColumnDiscount.FieldName = "Discount";
            this.gridColumnDiscount.Name = "gridColumnDiscount";
            this.gridColumnDiscount.Visible = true;
            this.gridColumnDiscount.VisibleIndex = 17;
            // 
            // repositoryItemTextEditDiscount
            // 
            this.repositoryItemTextEditDiscount.AutoHeight = false;
            this.repositoryItemTextEditDiscount.Mask.EditMask = "n2";
            this.repositoryItemTextEditDiscount.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.repositoryItemTextEditDiscount.Mask.UseMaskAsDisplayFormat = true;
            this.repositoryItemTextEditDiscount.Name = "repositoryItemTextEditDiscount";
            this.repositoryItemTextEditDiscount.NullText = "0.00";
            // 
            // gridColumnNetTotal
            // 
            this.gridColumnNetTotal.Caption = "Net Total";
            this.gridColumnNetTotal.ColumnEdit = this.repositoryItemTextEditNetTotal;
            this.gridColumnNetTotal.FieldName = "NetTotal";
            this.gridColumnNetTotal.Name = "gridColumnNetTotal";
            this.gridColumnNetTotal.Visible = true;
            this.gridColumnNetTotal.VisibleIndex = 18;
            // 
            // repositoryItemTextEditNetTotal
            // 
            this.repositoryItemTextEditNetTotal.AutoHeight = false;
            this.repositoryItemTextEditNetTotal.Mask.EditMask = "n2";
            this.repositoryItemTextEditNetTotal.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.repositoryItemTextEditNetTotal.Mask.UseMaskAsDisplayFormat = true;
            this.repositoryItemTextEditNetTotal.Name = "repositoryItemTextEditNetTotal";
            this.repositoryItemTextEditNetTotal.NullText = "0.00";
            // 
            // gridColumnDRId
            // 
            this.gridColumnDRId.Caption = "gridColumnDRId";
            this.gridColumnDRId.FieldName = "DRId";
            this.gridColumnDRId.Name = "gridColumnDRId";
            // 
            // gridColumnDId
            // 
            this.gridColumnDId.Caption = "gridColumnDId";
            this.gridColumnDId.FieldName = "DId";
            this.gridColumnDId.Name = "gridColumnDId";
            // 
            // gridColumnTId
            // 
            this.gridColumnTId.Caption = "gridColumnTId";
            this.gridColumnTId.FieldName = "TId";
            this.gridColumnTId.Name = "gridColumnTId";
            // 
            // gridColumnCId
            // 
            this.gridColumnCId.Caption = "gridColumnCId";
            this.gridColumnCId.FieldName = "CId";
            this.gridColumnCId.Name = "gridColumnCId";
            // 
            // gridColumnRTId
            // 
            this.gridColumnRTId.Caption = "gridColumnRTId";
            this.gridColumnRTId.FieldName = "RTId";
            this.gridColumnRTId.Name = "gridColumnRTId";
            // 
            // txtCountry
            // 
            this.txtCountry.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCountry.Location = new System.Drawing.Point(570, 169);
            this.txtCountry.MenuManager = this.ribbon;
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtCountry.Properties.Appearance.Options.UseFont = true;
            this.txtCountry.Properties.Mask.EditMask = "f";
            this.txtCountry.Properties.NullValuePrompt = "Country";
            this.txtCountry.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtCountry.Size = new System.Drawing.Size(213, 22);
            this.txtCountry.TabIndex = 97;
            // 
            // txtCurrency
            // 
            this.txtCurrency.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCurrency.Location = new System.Drawing.Point(570, 197);
            this.txtCurrency.MenuManager = this.ribbon;
            this.txtCurrency.Name = "txtCurrency";
            this.txtCurrency.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtCurrency.Properties.Appearance.Options.UseFont = true;
            this.txtCurrency.Properties.Mask.EditMask = "f";
            this.txtCurrency.Properties.NullValuePrompt = "Currency";
            this.txtCurrency.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtCurrency.Size = new System.Drawing.Size(213, 22);
            this.txtCurrency.TabIndex = 98;
            // 
            // txtExchangeRate
            // 
            this.txtExchangeRate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtExchangeRate.Location = new System.Drawing.Point(570, 225);
            this.txtExchangeRate.MenuManager = this.ribbon;
            this.txtExchangeRate.Name = "txtExchangeRate";
            this.txtExchangeRate.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtExchangeRate.Properties.Appearance.Options.UseFont = true;
            this.txtExchangeRate.Properties.Mask.EditMask = "f";
            this.txtExchangeRate.Properties.NullValuePrompt = "Exchange Rate";
            this.txtExchangeRate.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtExchangeRate.Size = new System.Drawing.Size(213, 22);
            this.txtExchangeRate.TabIndex = 99;
            // 
            // labelControl10
            // 
            this.labelControl10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.labelControl10.Location = new System.Drawing.Point(458, 256);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(48, 16);
            this.labelControl10.TabIndex = 102;
            this.labelControl10.Text = "Deposit";
            // 
            // txtRTInsurance
            // 
            this.txtRTInsurance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtRTInsurance.Location = new System.Drawing.Point(374, 535);
            this.txtRTInsurance.MenuManager = this.ribbon;
            this.txtRTInsurance.Name = "txtRTInsurance";
            this.txtRTInsurance.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRTInsurance.Properties.Appearance.Options.UseFont = true;
            this.txtRTInsurance.Properties.Mask.EditMask = "n2";
            this.txtRTInsurance.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtRTInsurance.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtRTInsurance.Properties.NullText = "0.00";
            this.txtRTInsurance.Properties.NullValuePrompt = "Previous Balance";
            this.txtRTInsurance.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtRTInsurance.Properties.ReadOnly = true;
            this.txtRTInsurance.Size = new System.Drawing.Size(345, 30);
            this.txtRTInsurance.TabIndex = 106;
            // 
            // labelControl16
            // 
            this.labelControl16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelControl16.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.labelControl16.Location = new System.Drawing.Point(374, 513);
            this.labelControl16.Name = "labelControl16";
            this.labelControl16.Size = new System.Drawing.Size(159, 16);
            this.labelControl16.TabIndex = 105;
            this.labelControl16.Text = "Returned Insurance (CDW)";
            // 
            // frmRent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 667);
            this.Controls.Add(this.txtRTInsurance);
            this.Controls.Add(this.labelControl16);
            this.Controls.Add(this.labelControl10);
            this.Controls.Add(this.txtExchangeRate);
            this.Controls.Add(this.txtCurrency);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.gridControl);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.labelControl14);
            this.Controls.Add(this.labelControl15);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.lookUpEditStatus);
            this.Controls.Add(this.dateEditDocDate);
            this.Controls.Add(this.dateEditPostDate);
            this.Controls.Add(this.dateEditDueDate);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.textEditNumbering);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.textEditIdentityNumber);
            this.Controls.Add(this.labelControl13);
            this.Controls.Add(this.buttonEditDeposit);
            this.Controls.Add(this.buttonEditRenter);
            this.Controls.Add(this.textEditTotalPay);
            this.Controls.Add(this.labelControl12);
            this.Controls.Add(this.textEditChange);
            this.Controls.Add(this.labelControl11);
            this.Controls.Add(this.textEditGrandTotal);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.textEditPreviousBalance);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Name = "frmRent";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Rent";
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditPreviousBalance.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditGrandTotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditChange.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditTotalPay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEditRenter.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEditDeposit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditNumbering.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDueDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDueDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditPostDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditPostDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDocDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDocDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditIdentityNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditRentType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditAddDriver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDateOut.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDateOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTimeEditTimeOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditExpectedReturnDate.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditExpectedReturnDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditReturnDate.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditReturnDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEditNoOfDays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEditDailyRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEditKMFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEditKMTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEditCDW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEditDellCollCharge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEditTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditTax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEditDiscount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEditNetTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCountry.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCurrency.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtExchangeRate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRTInsurance.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.BarButtonItem barNew;
        private DevExpress.XtraBars.BarButtonItem barClose;
        private DevExpress.XtraBars.BarEditItem barSearch;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchControl repositoryItemSearchControl1;
        private DevExpress.XtraBars.BarButtonItem barFirst;
        private DevExpress.XtraBars.BarButtonItem barPrevious;
        private DevExpress.XtraBars.BarButtonItem barNext;
        private DevExpress.XtraBars.BarButtonItem barLast;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barSave;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpNumberingSetup;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpNew;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpSave;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpTools;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpSearch;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpClose;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnlastnumeric;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit textEditPreviousBalance;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.TextEdit textEditGrandTotal;
        private DevExpress.XtraEditors.TextEdit textEditChange;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.TextEdit textEditTotalPay;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.ButtonEdit buttonEditRenter;
        private DevExpress.XtraEditors.ButtonEdit buttonEditDeposit;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.TextEdit textEditNumbering;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.DateEdit dateEditDueDate;
        private DevExpress.XtraEditors.DateEdit dateEditPostDate;
        private DevExpress.XtraEditors.DateEdit dateEditDocDate;
        private DevExpress.XtraBars.BarButtonItem barPayment;
        private DevExpress.XtraBars.BarButtonItem barDelete;
        private DevExpress.XtraBars.BarButtonItem barVoid;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditStatus;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit textEditIdentityNumber;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnid;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnVoid;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnDelete;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnRentType;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnCar;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnDriver;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnDateOut;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnTimeOut;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnExpectedReturnDate;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnDateReturn;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnNoOfDays;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnDailyRate;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnKMFrom;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnKMTo;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnCDW;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnDellColCharge;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnTotal;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnTax;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnDiscount;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnNetTotal;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnDRId;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnDId;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnTId;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnCId;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnRTId;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEditRentType;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEditCar;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEditAddDriver;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEditDateOut;
        private DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit repositoryItemTimeEditTimeOut;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEditExpectedReturnDate;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEditReturnDate;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEditNoOfDays;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEditDailyRate;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEditKMFrom;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEditKMTo;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEditDellCollCharge;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEditTotal;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEditTax;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEditDiscount;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEditNetTotal;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEditCDW;
        private DevExpress.XtraEditors.TextEdit txtCountry;
        private DevExpress.XtraEditors.TextEdit txtCurrency;
        private DevExpress.XtraEditors.TextEdit txtExchangeRate;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpDeleteVoid;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraBars.BarButtonItem barPrint;
        private DevExpress.XtraEditors.TextEdit txtRTInsurance;
        private DevExpress.XtraEditors.LabelControl labelControl16;



    }
}