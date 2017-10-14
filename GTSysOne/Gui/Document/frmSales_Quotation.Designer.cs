namespace GTSysOne.Gui.Document
{
    partial class frmSalesQuotation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSalesQuotation));
            this.repositoryItemLookUpEditSegment = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repositoryItemTextEditNumeric = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
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
            this.rpDefault = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpNew = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpSave = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpTools = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpSearch = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpClose = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.grdControlLines = new DevExpress.XtraGrid.GridControl();
            this.grdViewLines = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridSalesQuoteLineId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridSalesQuoteItemId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridSalesQuoteSequence = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridSalesQuoteItemName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ItemButtonEdit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridSalesQuoteItemDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridSalesQuoteQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.QuantityTextEdit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.gridSalesQuoteUnitPriceExclVAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridSalesQuoteUnitPriceInclVAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridSalesQuoteLineTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridSalesQuoteGrossPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridSalesQuoteDiscountPercentage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextSalesQuoteDiscount = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.gridSalesQuoteDiscountAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridSalesQuoteBarcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnSalesQuotePriceLevelId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridSalesQuotePriceLevel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridSalesQuoteLotNoCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridSalesQuoteSerialNoCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridSalesQuoteSlipUOMId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridSalesQuoteTaxId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridSalesQuoteTaxCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonSalesQuoteTax = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridSalesQuoteTaxPercentage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridSalesQuoteTaxAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtCustomerNo = new DevExpress.XtraEditors.ButtonEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtCustomerName = new DevExpress.XtraEditors.TextEdit();
            this.txtDocumentDate = new DevExpress.XtraEditors.DateEdit();
            this.txtContactPerson = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtPostingDate = new DevExpress.XtraEditors.DateEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtDocumentStatus = new DevExpress.XtraEditors.TextEdit();
            this.txtDocumentNo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtTotalAmount = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditSegment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEditNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdControlLines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdViewLines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemButtonEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityTextEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextSalesQuoteDiscount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonSalesQuoteTax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomerNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomerName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDocumentDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDocumentDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContactPerson.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPostingDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPostingDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDocumentStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDocumentNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalAmount.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // repositoryItemLookUpEditSegment
            // 
            this.repositoryItemLookUpEditSegment.AutoHeight = false;
            this.repositoryItemLookUpEditSegment.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEditSegment.Name = "repositoryItemLookUpEditSegment";
            this.repositoryItemLookUpEditSegment.NullText = "";
            this.repositoryItemLookUpEditSegment.NullValuePrompt = "Segment";
            this.repositoryItemLookUpEditSegment.NullValuePromptShowForEmptyValue = true;
            // 
            // repositoryItemTextEditNumeric
            // 
            this.repositoryItemTextEditNumeric.AutoHeight = false;
            this.repositoryItemTextEditNumeric.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemTextEditNumeric.EditFormat.FormatString = "n0";
            this.repositoryItemTextEditNumeric.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemTextEditNumeric.Mask.EditMask = "\\d+";
            this.repositoryItemTextEditNumeric.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.repositoryItemTextEditNumeric.Mask.UseMaskAsDisplayFormat = true;
            this.repositoryItemTextEditNumeric.Name = "repositoryItemTextEditNumeric";
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
            this.barSave});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 10;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rpDefault});
            this.ribbon.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemSearchControl1});
            this.ribbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbon.Size = new System.Drawing.Size(1013, 143);
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
            this.barSearch.Width = 200;
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
            // rpDefault
            // 
            this.rpDefault.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpNew,
            this.rpSave,
            this.rpTools,
            this.rpSearch,
            this.rpClose});
            this.rpDefault.Name = "rpDefault";
            this.rpDefault.Text = "Sales Quotation";
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
            this.rpSave.Name = "rpSave";
            this.rpSave.Text = "Save";
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
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 550);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1013, 31);
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.labelControl9.Location = new System.Drawing.Point(12, 203);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(81, 16);
            this.labelControl9.TabIndex = 26;
            this.labelControl9.Text = "Customer No.";
            // 
            // grdControlLines
            // 
            this.grdControlLines.Location = new System.Drawing.Point(12, 296);
            this.grdControlLines.MainView = this.grdViewLines;
            this.grdControlLines.MenuManager = this.ribbon;
            this.grdControlLines.Name = "grdControlLines";
            this.grdControlLines.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.ItemButtonEdit,
            this.QuantityTextEdit,
            this.repositoryItemButtonSalesQuoteTax,
            this.repositoryItemTextSalesQuoteDiscount});
            this.grdControlLines.Size = new System.Drawing.Size(989, 127);
            this.grdControlLines.TabIndex = 29;
            this.grdControlLines.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdViewLines});
            // 
            // grdViewLines
            // 
            this.grdViewLines.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridSalesQuoteLineId,
            this.gridSalesQuoteItemId,
            this.gridSalesQuoteSequence,
            this.gridSalesQuoteItemName,
            this.gridSalesQuoteItemDescription,
            this.gridSalesQuoteQuantity,
            this.gridSalesQuoteUnitPriceExclVAT,
            this.gridSalesQuoteUnitPriceInclVAT,
            this.gridSalesQuoteLineTotal,
            this.gridSalesQuoteGrossPrice,
            this.gridSalesQuoteDiscountPercentage,
            this.gridSalesQuoteDiscountAmount,
            this.gridSalesQuoteBarcode,
            this.gridColumnSalesQuotePriceLevelId,
            this.gridSalesQuotePriceLevel,
            this.gridSalesQuoteLotNoCode,
            this.gridSalesQuoteSerialNoCode,
            this.gridSalesQuoteSlipUOMId,
            this.gridSalesQuoteTaxId,
            this.gridSalesQuoteTaxCode,
            this.gridSalesQuoteTaxPercentage,
            this.gridSalesQuoteTaxAmount});
            this.grdViewLines.GridControl = this.grdControlLines;
            this.grdViewLines.Name = "grdViewLines";
            this.grdViewLines.OptionsView.ColumnAutoWidth = false;
            this.grdViewLines.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.grdViewLines.OptionsView.ShowGroupPanel = false;
            // 
            // gridSalesQuoteLineId
            // 
            this.gridSalesQuoteLineId.Caption = "Line Id";
            this.gridSalesQuoteLineId.FieldName = "line_id";
            this.gridSalesQuoteLineId.Name = "gridSalesQuoteLineId";
            // 
            // gridSalesQuoteItemId
            // 
            this.gridSalesQuoteItemId.Caption = "Item Id";
            this.gridSalesQuoteItemId.FieldName = "item_id";
            this.gridSalesQuoteItemId.Name = "gridSalesQuoteItemId";
            this.gridSalesQuoteItemId.OptionsColumn.AllowEdit = false;
            this.gridSalesQuoteItemId.OptionsColumn.AllowFocus = false;
            this.gridSalesQuoteItemId.OptionsColumn.ReadOnly = true;
            // 
            // gridSalesQuoteSequence
            // 
            this.gridSalesQuoteSequence.Caption = "Seq.";
            this.gridSalesQuoteSequence.FieldName = "sequence";
            this.gridSalesQuoteSequence.Name = "gridSalesQuoteSequence";
            this.gridSalesQuoteSequence.OptionsColumn.AllowEdit = false;
            this.gridSalesQuoteSequence.Visible = true;
            this.gridSalesQuoteSequence.VisibleIndex = 0;
            this.gridSalesQuoteSequence.Width = 35;
            // 
            // gridSalesQuoteItemName
            // 
            this.gridSalesQuoteItemName.Caption = "Item Name";
            this.gridSalesQuoteItemName.ColumnEdit = this.ItemButtonEdit;
            this.gridSalesQuoteItemName.FieldName = "name";
            this.gridSalesQuoteItemName.Name = "gridSalesQuoteItemName";
            this.gridSalesQuoteItemName.Visible = true;
            this.gridSalesQuoteItemName.VisibleIndex = 1;
            this.gridSalesQuoteItemName.Width = 100;
            // 
            // ItemButtonEdit
            // 
            this.ItemButtonEdit.AutoHeight = false;
            this.ItemButtonEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.ItemButtonEdit.Name = "ItemButtonEdit";
            this.ItemButtonEdit.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.GridItemEditButtonClick);
            // 
            // gridSalesQuoteItemDescription
            // 
            this.gridSalesQuoteItemDescription.Caption = "Description";
            this.gridSalesQuoteItemDescription.FieldName = "description";
            this.gridSalesQuoteItemDescription.Name = "gridSalesQuoteItemDescription";
            this.gridSalesQuoteItemDescription.OptionsColumn.AllowEdit = false;
            this.gridSalesQuoteItemDescription.Visible = true;
            this.gridSalesQuoteItemDescription.VisibleIndex = 2;
            this.gridSalesQuoteItemDescription.Width = 150;
            // 
            // gridSalesQuoteQuantity
            // 
            this.gridSalesQuoteQuantity.Caption = "Quantity";
            this.gridSalesQuoteQuantity.ColumnEdit = this.QuantityTextEdit;
            this.gridSalesQuoteQuantity.FieldName = "quantity";
            this.gridSalesQuoteQuantity.Name = "gridSalesQuoteQuantity";
            this.gridSalesQuoteQuantity.Visible = true;
            this.gridSalesQuoteQuantity.VisibleIndex = 3;
            // 
            // QuantityTextEdit
            // 
            this.QuantityTextEdit.AutoHeight = false;
            this.QuantityTextEdit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.QuantityTextEdit.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.QuantityTextEdit.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.QuantityTextEdit.Name = "QuantityTextEdit";
            this.QuantityTextEdit.NullValuePrompt = "Quantity";
            this.QuantityTextEdit.NullValuePromptShowForEmptyValue = true;
            this.QuantityTextEdit.EditValueChanged += new System.EventHandler(this.QuantityTextEdit_EditValueChanged);
            // 
            // gridSalesQuoteUnitPriceExclVAT
            // 
            this.gridSalesQuoteUnitPriceExclVAT.Caption = "Unit Price";
            this.gridSalesQuoteUnitPriceExclVAT.FieldName = "defaultpricebeforetax";
            this.gridSalesQuoteUnitPriceExclVAT.Name = "gridSalesQuoteUnitPriceExclVAT";
            this.gridSalesQuoteUnitPriceExclVAT.OptionsColumn.AllowEdit = false;
            this.gridSalesQuoteUnitPriceExclVAT.Visible = true;
            this.gridSalesQuoteUnitPriceExclVAT.VisibleIndex = 4;
            this.gridSalesQuoteUnitPriceExclVAT.Width = 105;
            // 
            // gridSalesQuoteUnitPriceInclVAT
            // 
            this.gridSalesQuoteUnitPriceInclVAT.Caption = "Unit Price Incl. VAT";
            this.gridSalesQuoteUnitPriceInclVAT.FieldName = "defaultpriceaftertax";
            this.gridSalesQuoteUnitPriceInclVAT.Name = "gridSalesQuoteUnitPriceInclVAT";
            this.gridSalesQuoteUnitPriceInclVAT.OptionsColumn.AllowEdit = false;
            this.gridSalesQuoteUnitPriceInclVAT.Width = 105;
            // 
            // gridSalesQuoteLineTotal
            // 
            this.gridSalesQuoteLineTotal.Caption = "Line Total";
            this.gridSalesQuoteLineTotal.FieldName = "line_total";
            this.gridSalesQuoteLineTotal.Name = "gridSalesQuoteLineTotal";
            this.gridSalesQuoteLineTotal.OptionsColumn.AllowEdit = false;
            this.gridSalesQuoteLineTotal.Visible = true;
            this.gridSalesQuoteLineTotal.VisibleIndex = 5;
            // 
            // gridSalesQuoteGrossPrice
            // 
            this.gridSalesQuoteGrossPrice.Caption = "Gross Price";
            this.gridSalesQuoteGrossPrice.FieldName = "gross_price";
            this.gridSalesQuoteGrossPrice.Name = "gridSalesQuoteGrossPrice";
            this.gridSalesQuoteGrossPrice.OptionsColumn.AllowEdit = false;
            this.gridSalesQuoteGrossPrice.Visible = true;
            this.gridSalesQuoteGrossPrice.VisibleIndex = 6;
            // 
            // gridSalesQuoteDiscountPercentage
            // 
            this.gridSalesQuoteDiscountPercentage.Caption = "Discount (%)";
            this.gridSalesQuoteDiscountPercentage.ColumnEdit = this.repositoryItemTextSalesQuoteDiscount;
            this.gridSalesQuoteDiscountPercentage.FieldName = "discount_percentage";
            this.gridSalesQuoteDiscountPercentage.Name = "gridSalesQuoteDiscountPercentage";
            this.gridSalesQuoteDiscountPercentage.Visible = true;
            this.gridSalesQuoteDiscountPercentage.VisibleIndex = 7;
            // 
            // repositoryItemTextSalesQuoteDiscount
            // 
            this.repositoryItemTextSalesQuoteDiscount.AutoHeight = false;
            this.repositoryItemTextSalesQuoteDiscount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemTextSalesQuoteDiscount.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemTextSalesQuoteDiscount.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.repositoryItemTextSalesQuoteDiscount.Name = "repositoryItemTextSalesQuoteDiscount";
            this.repositoryItemTextSalesQuoteDiscount.EditValueChanged += new System.EventHandler(this.repositoryItemTextSalesQuoteDiscount_EditValueChanged);
            // 
            // gridSalesQuoteDiscountAmount
            // 
            this.gridSalesQuoteDiscountAmount.Caption = "Discount (Amount)";
            this.gridSalesQuoteDiscountAmount.FieldName = "discount_amount";
            this.gridSalesQuoteDiscountAmount.Name = "gridSalesQuoteDiscountAmount";
            this.gridSalesQuoteDiscountAmount.OptionsColumn.AllowEdit = false;
            this.gridSalesQuoteDiscountAmount.Visible = true;
            this.gridSalesQuoteDiscountAmount.VisibleIndex = 8;
            this.gridSalesQuoteDiscountAmount.Width = 100;
            // 
            // gridSalesQuoteBarcode
            // 
            this.gridSalesQuoteBarcode.Caption = "Bar Code";
            this.gridSalesQuoteBarcode.FieldName = "bar_code";
            this.gridSalesQuoteBarcode.Name = "gridSalesQuoteBarcode";
            this.gridSalesQuoteBarcode.Visible = true;
            this.gridSalesQuoteBarcode.VisibleIndex = 9;
            // 
            // gridColumnSalesQuotePriceLevelId
            // 
            this.gridColumnSalesQuotePriceLevelId.Caption = "Price Level Id";
            this.gridColumnSalesQuotePriceLevelId.FieldName = "price_level_id";
            this.gridColumnSalesQuotePriceLevelId.Name = "gridColumnSalesQuotePriceLevelId";
            // 
            // gridSalesQuotePriceLevel
            // 
            this.gridSalesQuotePriceLevel.Caption = "Price Level";
            this.gridSalesQuotePriceLevel.FieldName = "price_level";
            this.gridSalesQuotePriceLevel.Name = "gridSalesQuotePriceLevel";
            this.gridSalesQuotePriceLevel.Visible = true;
            this.gridSalesQuotePriceLevel.VisibleIndex = 10;
            // 
            // gridSalesQuoteLotNoCode
            // 
            this.gridSalesQuoteLotNoCode.Caption = "Lot No.";
            this.gridSalesQuoteLotNoCode.FieldName = "lot_no_code";
            this.gridSalesQuoteLotNoCode.Name = "gridSalesQuoteLotNoCode";
            this.gridSalesQuoteLotNoCode.Visible = true;
            this.gridSalesQuoteLotNoCode.VisibleIndex = 11;
            // 
            // gridSalesQuoteSerialNoCode
            // 
            this.gridSalesQuoteSerialNoCode.Caption = "Serial No.";
            this.gridSalesQuoteSerialNoCode.FieldName = "serial_no_code";
            this.gridSalesQuoteSerialNoCode.Name = "gridSalesQuoteSerialNoCode";
            this.gridSalesQuoteSerialNoCode.Visible = true;
            this.gridSalesQuoteSerialNoCode.VisibleIndex = 12;
            this.gridSalesQuoteSerialNoCode.Width = 90;
            // 
            // gridSalesQuoteSlipUOMId
            // 
            this.gridSalesQuoteSlipUOMId.Caption = "UOM Code";
            this.gridSalesQuoteSlipUOMId.FieldName = "slip_uom_id";
            this.gridSalesQuoteSlipUOMId.Name = "gridSalesQuoteSlipUOMId";
            this.gridSalesQuoteSlipUOMId.Visible = true;
            this.gridSalesQuoteSlipUOMId.VisibleIndex = 13;
            // 
            // gridSalesQuoteTaxId
            // 
            this.gridSalesQuoteTaxId.Caption = "Tax Id";
            this.gridSalesQuoteTaxId.FieldName = "tax_id";
            this.gridSalesQuoteTaxId.Name = "gridSalesQuoteTaxId";
            // 
            // gridSalesQuoteTaxCode
            // 
            this.gridSalesQuoteTaxCode.Caption = "Tax Code";
            this.gridSalesQuoteTaxCode.ColumnEdit = this.repositoryItemButtonSalesQuoteTax;
            this.gridSalesQuoteTaxCode.FieldName = "tax_code";
            this.gridSalesQuoteTaxCode.Name = "gridSalesQuoteTaxCode";
            this.gridSalesQuoteTaxCode.Visible = true;
            this.gridSalesQuoteTaxCode.VisibleIndex = 14;
            // 
            // repositoryItemButtonSalesQuoteTax
            // 
            this.repositoryItemButtonSalesQuoteTax.AutoHeight = false;
            this.repositoryItemButtonSalesQuoteTax.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemButtonSalesQuoteTax.Name = "repositoryItemButtonSalesQuoteTax";
            this.repositoryItemButtonSalesQuoteTax.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repositoryItemButtonSalesQuoteTax_ButtonClick);
            // 
            // gridSalesQuoteTaxPercentage
            // 
            this.gridSalesQuoteTaxPercentage.Caption = "Tax (%)";
            this.gridSalesQuoteTaxPercentage.FieldName = "tax_percentage";
            this.gridSalesQuoteTaxPercentage.Name = "gridSalesQuoteTaxPercentage";
            this.gridSalesQuoteTaxPercentage.OptionsColumn.AllowEdit = false;
            this.gridSalesQuoteTaxPercentage.Visible = true;
            this.gridSalesQuoteTaxPercentage.VisibleIndex = 15;
            // 
            // gridSalesQuoteTaxAmount
            // 
            this.gridSalesQuoteTaxAmount.Caption = "Tax (Amount)";
            this.gridSalesQuoteTaxAmount.FieldName = "tax_amount";
            this.gridSalesQuoteTaxAmount.Name = "gridSalesQuoteTaxAmount";
            this.gridSalesQuoteTaxAmount.OptionsColumn.AllowEdit = false;
            this.gridSalesQuoteTaxAmount.Visible = true;
            this.gridSalesQuoteTaxAmount.VisibleIndex = 16;
            // 
            // txtCustomerNo
            // 
            this.txtCustomerNo.Location = new System.Drawing.Point(156, 201);
            this.txtCustomerNo.MenuManager = this.ribbon;
            this.txtCustomerNo.Name = "txtCustomerNo";
            this.txtCustomerNo.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtCustomerNo.Properties.Appearance.Options.UseFont = true;
            this.txtCustomerNo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtCustomerNo.Properties.NullValuePrompt = "Customer No.";
            this.txtCustomerNo.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtCustomerNo.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.txtCustomerNo.Size = new System.Drawing.Size(283, 22);
            this.txtCustomerNo.TabIndex = 25;
            this.txtCustomerNo.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtCustomer_ButtonClick);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.labelControl1.Location = new System.Drawing.Point(12, 229);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(37, 16);
            this.labelControl1.TabIndex = 32;
            this.labelControl1.Text = "Name";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.labelControl2.Location = new System.Drawing.Point(12, 255);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(91, 16);
            this.labelControl2.TabIndex = 33;
            this.labelControl2.Text = "Contact Person";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(156, 226);
            this.txtCustomerName.MenuManager = this.ribbon;
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtCustomerName.Properties.Appearance.Options.UseFont = true;
            this.txtCustomerName.Properties.NullValuePrompt = "Customer Name";
            this.txtCustomerName.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtCustomerName.Size = new System.Drawing.Size(283, 22);
            this.txtCustomerName.TabIndex = 34;
            // 
            // txtDocumentDate
            // 
            this.txtDocumentDate.EditValue = new System.DateTime(2017, 7, 10, 0, 50, 30, 721);
            this.txtDocumentDate.Location = new System.Drawing.Point(718, 175);
            this.txtDocumentDate.MenuManager = this.ribbon;
            this.txtDocumentDate.Name = "txtDocumentDate";
            this.txtDocumentDate.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtDocumentDate.Properties.Appearance.Options.UseFont = true;
            this.txtDocumentDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDocumentDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDocumentDate.Properties.NullValuePrompt = "Document Date";
            this.txtDocumentDate.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtDocumentDate.Size = new System.Drawing.Size(283, 22);
            this.txtDocumentDate.TabIndex = 36;
            // 
            // txtContactPerson
            // 
            this.txtContactPerson.Location = new System.Drawing.Point(156, 252);
            this.txtContactPerson.MenuManager = this.ribbon;
            this.txtContactPerson.Name = "txtContactPerson";
            this.txtContactPerson.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtContactPerson.Properties.Appearance.Options.UseFont = true;
            this.txtContactPerson.Size = new System.Drawing.Size(283, 22);
            this.txtContactPerson.TabIndex = 37;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.labelControl3.Location = new System.Drawing.Point(557, 178);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(93, 16);
            this.labelControl3.TabIndex = 38;
            this.labelControl3.Text = "Document Date";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.labelControl4.Location = new System.Drawing.Point(557, 203);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(77, 16);
            this.labelControl4.TabIndex = 39;
            this.labelControl4.Text = "Posting Date";
            // 
            // txtPostingDate
            // 
            this.txtPostingDate.EditValue = new System.DateTime(2017, 7, 10, 0, 50, 21, 604);
            this.txtPostingDate.Location = new System.Drawing.Point(718, 200);
            this.txtPostingDate.MenuManager = this.ribbon;
            this.txtPostingDate.Name = "txtPostingDate";
            this.txtPostingDate.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtPostingDate.Properties.Appearance.Options.UseFont = true;
            this.txtPostingDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtPostingDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtPostingDate.Properties.NullDate = new System.DateTime(2017, 7, 10, 0, 46, 18, 0);
            this.txtPostingDate.Properties.NullValuePrompt = "Posting Date";
            this.txtPostingDate.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtPostingDate.Size = new System.Drawing.Size(283, 22);
            this.txtPostingDate.TabIndex = 43;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.labelControl5.Location = new System.Drawing.Point(557, 229);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(37, 16);
            this.labelControl5.TabIndex = 46;
            this.labelControl5.Text = "Status";
            // 
            // txtDocumentStatus
            // 
            this.txtDocumentStatus.Location = new System.Drawing.Point(718, 226);
            this.txtDocumentStatus.MenuManager = this.ribbon;
            this.txtDocumentStatus.Name = "txtDocumentStatus";
            this.txtDocumentStatus.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtDocumentStatus.Properties.Appearance.Options.UseFont = true;
            this.txtDocumentStatus.Size = new System.Drawing.Size(283, 22);
            this.txtDocumentStatus.TabIndex = 47;
            // 
            // txtDocumentNo
            // 
            this.txtDocumentNo.Location = new System.Drawing.Point(156, 175);
            this.txtDocumentNo.MenuManager = this.ribbon;
            this.txtDocumentNo.Name = "txtDocumentNo";
            this.txtDocumentNo.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtDocumentNo.Properties.Appearance.Options.UseFont = true;
            this.txtDocumentNo.Properties.NullValuePrompt = "Document No.";
            this.txtDocumentNo.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtDocumentNo.Size = new System.Drawing.Size(283, 22);
            this.txtDocumentNo.TabIndex = 50;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.labelControl6.Location = new System.Drawing.Point(12, 178);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(85, 16);
            this.labelControl6.TabIndex = 51;
            this.labelControl6.Text = "Document No.";
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.EditValue = 0D;
            this.txtTotalAmount.Location = new System.Drawing.Point(109, 446);
            this.txtTotalAmount.MenuManager = this.ribbon;
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtTotalAmount.Properties.Appearance.Options.UseFont = true;
            this.txtTotalAmount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtTotalAmount.Size = new System.Drawing.Size(154, 22);
            this.txtTotalAmount.TabIndex = 54;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.labelControl7.Location = new System.Drawing.Point(12, 449);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(80, 16);
            this.labelControl7.TabIndex = 57;
            this.labelControl7.Text = "Total Amount";
            // 
            // frmSalesQuotation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 581);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.txtTotalAmount);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.txtDocumentNo);
            this.Controls.Add(this.txtDocumentStatus);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.txtPostingDate);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtContactPerson);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.grdControlLines);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.txtCustomerNo);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.txtDocumentDate);
            this.Controls.Add(this.ribbon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSalesQuotation";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Sales Quotation";
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditSegment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEditNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdControlLines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdViewLines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemButtonEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityTextEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextSalesQuoteDiscount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonSalesQuoteTax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomerNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomerName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDocumentDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDocumentDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContactPerson.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPostingDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPostingDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDocumentStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDocumentNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalAmount.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpDefault;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpNew;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem barNew;
        private DevExpress.XtraBars.BarButtonItem barClose;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpClose;
        private DevExpress.XtraBars.BarEditItem barSearch;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchControl repositoryItemSearchControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpTools;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpSearch;
        private DevExpress.XtraBars.BarButtonItem barFirst;
        private DevExpress.XtraBars.BarButtonItem barPrevious;
        private DevExpress.XtraBars.BarButtonItem barNext;
        private DevExpress.XtraBars.BarButtonItem barLast;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barSave;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpSave;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraGrid.GridControl grdControlLines;
        private DevExpress.XtraGrid.Views.Grid.GridView grdViewLines;
        private DevExpress.XtraGrid.Columns.GridColumn gridSalesQuoteItemId;
        private DevExpress.XtraGrid.Columns.GridColumn gridSalesQuoteItemName;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEditSegment;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEditNumeric;
        private DevExpress.XtraEditors.ButtonEdit txtCustomerNo;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtCustomerName;
        private DevExpress.XtraEditors.DateEdit txtDocumentDate;
        private DevExpress.XtraEditors.TextEdit txtContactPerson;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.DateEdit txtPostingDate;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtDocumentStatus;
        private DevExpress.XtraEditors.TextEdit txtDocumentNo;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit ItemButtonEdit;
        private DevExpress.XtraGrid.Columns.GridColumn gridSalesQuoteItemDescription;
        private DevExpress.XtraGrid.Columns.GridColumn gridSalesQuoteQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn gridSalesQuoteUnitPriceExclVAT;
        private DevExpress.XtraGrid.Columns.GridColumn gridSalesQuoteUnitPriceInclVAT;
        private DevExpress.XtraEditors.TextEdit txtTotalAmount;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit QuantityTextEdit;
        private DevExpress.XtraGrid.Columns.GridColumn gridSalesQuoteLineTotal;
        private DevExpress.XtraGrid.Columns.GridColumn gridSalesQuoteLineId;
        private DevExpress.XtraGrid.Columns.GridColumn gridSalesQuoteGrossPrice;
        private DevExpress.XtraGrid.Columns.GridColumn gridSalesQuoteDiscountAmount;
        private DevExpress.XtraGrid.Columns.GridColumn gridSalesQuoteDiscountPercentage;
        private DevExpress.XtraGrid.Columns.GridColumn gridSalesQuoteBarcode;
        private DevExpress.XtraGrid.Columns.GridColumn gridSalesQuoteSequence;
        private DevExpress.XtraGrid.Columns.GridColumn gridSalesQuotePriceLevel;
        private DevExpress.XtraGrid.Columns.GridColumn gridSalesQuoteLotNoCode;
        private DevExpress.XtraGrid.Columns.GridColumn gridSalesQuoteSerialNoCode;
        private DevExpress.XtraGrid.Columns.GridColumn gridSalesQuoteSlipUOMId;
        private DevExpress.XtraGrid.Columns.GridColumn gridSalesQuoteTaxCode;
        private DevExpress.XtraGrid.Columns.GridColumn gridSalesQuoteTaxPercentage;
        private DevExpress.XtraGrid.Columns.GridColumn gridSalesQuoteTaxAmount;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonSalesQuoteTax;
        private DevExpress.XtraGrid.Columns.GridColumn gridSalesQuoteTaxId;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextSalesQuoteDiscount;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnSalesQuotePriceLevelId;
    }
}