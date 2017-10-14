namespace GTSysOne.Gui.Document
{
    partial class frmNumberingSetup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNumberingSetup));
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
            this.rpNumberingSetup = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpNew = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpSave = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpTools = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpSearch = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpClose = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnvoid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnmap_sourced_numbering_segment_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEditSegment = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gridColumnseq = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEditNumeric = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.gridColumnValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnseparator = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnfirstnumeric = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lookUpEditCompany = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lookUpEditFunction = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.lblSampleResult = new DevExpress.XtraEditors.LabelControl();
            this.chkActive = new DevExpress.XtraEditors.CheckEdit();
            this.chkResetNumbering = new DevExpress.XtraEditors.CheckEdit();
            this.gridColumnlastnumeric = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditSegment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEditNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditCompany.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditFunction.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkActive.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkResetNumbering.Properties)).BeginInit();
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
            this.barSave});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 10;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rpNumberingSetup});
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
            // rpNumberingSetup
            // 
            this.rpNumberingSetup.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpNew,
            this.rpSave,
            this.rpTools,
            this.rpSearch,
            this.rpClose});
            this.rpNumberingSetup.Name = "rpNumberingSetup";
            this.rpNumberingSetup.Text = "Numbering Setup";
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
            // gridControl
            // 
            this.gridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl.Location = new System.Drawing.Point(12, 232);
            this.gridControl.MainView = this.gridView;
            this.gridControl.MenuManager = this.ribbon;
            this.gridControl.Name = "gridControl";
            this.gridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEditSegment,
            this.repositoryItemTextEditNumeric});
            this.gridControl.Size = new System.Drawing.Size(989, 307);
            this.gridControl.TabIndex = 2;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnid,
            this.gridColumnvoid,
            this.gridColumnmap_sourced_numbering_segment_id,
            this.gridColumnname,
            this.gridColumnseq,
            this.gridColumnValue,
            this.gridColumnseparator,
            this.gridColumnfirstnumeric,
            this.gridColumn1});
            this.gridView.GridControl = this.gridControl;
            this.gridView.Name = "gridView";
            this.gridView.OptionsView.ColumnAutoWidth = false;
            this.gridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumnid
            // 
            this.gridColumnid.Caption = "Id";
            this.gridColumnid.FieldName = "id";
            this.gridColumnid.Name = "gridColumnid";
            this.gridColumnid.OptionsColumn.AllowEdit = false;
            this.gridColumnid.OptionsColumn.AllowFocus = false;
            this.gridColumnid.OptionsColumn.ReadOnly = true;
            // 
            // gridColumnvoid
            // 
            this.gridColumnvoid.Caption = "Void";
            this.gridColumnvoid.FieldName = "void";
            this.gridColumnvoid.Name = "gridColumnvoid";
            this.gridColumnvoid.Visible = true;
            this.gridColumnvoid.VisibleIndex = 0;
            // 
            // gridColumnmap_sourced_numbering_segment_id
            // 
            this.gridColumnmap_sourced_numbering_segment_id.Caption = "map_sourced_numbering_segment_id";
            this.gridColumnmap_sourced_numbering_segment_id.FieldName = "map_sourced_numbering_segment_id";
            this.gridColumnmap_sourced_numbering_segment_id.Name = "gridColumnmap_sourced_numbering_segment_id";
            this.gridColumnmap_sourced_numbering_segment_id.OptionsColumn.AllowEdit = false;
            this.gridColumnmap_sourced_numbering_segment_id.OptionsColumn.AllowFocus = false;
            this.gridColumnmap_sourced_numbering_segment_id.OptionsColumn.ReadOnly = true;
            // 
            // gridColumnname
            // 
            this.gridColumnname.Caption = "Segment";
            this.gridColumnname.ColumnEdit = this.repositoryItemLookUpEditSegment;
            this.gridColumnname.FieldName = "name";
            this.gridColumnname.Name = "gridColumnname";
            this.gridColumnname.Visible = true;
            this.gridColumnname.VisibleIndex = 2;
            this.gridColumnname.Width = 142;
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
            // gridColumnseq
            // 
            this.gridColumnseq.Caption = "Seq";
            this.gridColumnseq.ColumnEdit = this.repositoryItemTextEditNumeric;
            this.gridColumnseq.FieldName = "seq";
            this.gridColumnseq.Name = "gridColumnseq";
            this.gridColumnseq.OptionsColumn.AllowEdit = false;
            this.gridColumnseq.OptionsColumn.AllowFocus = false;
            this.gridColumnseq.OptionsColumn.ReadOnly = true;
            this.gridColumnseq.Visible = true;
            this.gridColumnseq.VisibleIndex = 1;
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
            // gridColumnValue
            // 
            this.gridColumnValue.Caption = "Value";
            this.gridColumnValue.FieldName = "value";
            this.gridColumnValue.Name = "gridColumnValue";
            this.gridColumnValue.Visible = true;
            this.gridColumnValue.VisibleIndex = 3;
            this.gridColumnValue.Width = 127;
            // 
            // gridColumnseparator
            // 
            this.gridColumnseparator.Caption = "Separator";
            this.gridColumnseparator.FieldName = "separator";
            this.gridColumnseparator.Name = "gridColumnseparator";
            this.gridColumnseparator.Visible = true;
            this.gridColumnseparator.VisibleIndex = 4;
            this.gridColumnseparator.Width = 86;
            // 
            // gridColumnfirstnumeric
            // 
            this.gridColumnfirstnumeric.Caption = "First Numeric";
            this.gridColumnfirstnumeric.ColumnEdit = this.repositoryItemTextEditNumeric;
            this.gridColumnfirstnumeric.FieldName = "firstnumeric";
            this.gridColumnfirstnumeric.Name = "gridColumnfirstnumeric";
            this.gridColumnfirstnumeric.Visible = true;
            this.gridColumnfirstnumeric.VisibleIndex = 5;
            this.gridColumnfirstnumeric.Width = 81;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Last Numeric";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 6;
            // 
            // lookUpEditCompany
            // 
            this.lookUpEditCompany.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lookUpEditCompany.Location = new System.Drawing.Point(131, 181);
            this.lookUpEditCompany.MenuManager = this.ribbon;
            this.lookUpEditCompany.Name = "lookUpEditCompany";
            this.lookUpEditCompany.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lookUpEditCompany.Properties.Appearance.Options.UseFont = true;
            this.lookUpEditCompany.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditCompany.Properties.DropDownRows = 15;
            this.lookUpEditCompany.Properties.NullText = "";
            this.lookUpEditCompany.Properties.NullValuePrompt = "Company";
            this.lookUpEditCompany.Properties.NullValuePromptShowForEmptyValue = true;
            this.lookUpEditCompany.Size = new System.Drawing.Size(315, 22);
            this.lookUpEditCompany.TabIndex = 3;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.labelControl1.Location = new System.Drawing.Point(14, 209);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(50, 16);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "Function";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.labelControl2.Location = new System.Drawing.Point(12, 184);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(58, 16);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "Company";
            // 
            // lookUpEditFunction
            // 
            this.lookUpEditFunction.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lookUpEditFunction.Location = new System.Drawing.Point(131, 206);
            this.lookUpEditFunction.MenuManager = this.ribbon;
            this.lookUpEditFunction.Name = "lookUpEditFunction";
            this.lookUpEditFunction.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lookUpEditFunction.Properties.Appearance.Options.UseFont = true;
            this.lookUpEditFunction.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditFunction.Properties.DropDownRows = 25;
            this.lookUpEditFunction.Properties.NullText = "";
            this.lookUpEditFunction.Properties.NullValuePrompt = "Function";
            this.lookUpEditFunction.Properties.NullValuePromptShowForEmptyValue = true;
            this.lookUpEditFunction.Size = new System.Drawing.Size(315, 22);
            this.lookUpEditFunction.TabIndex = 7;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.labelControl3.Location = new System.Drawing.Point(529, 208);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(89, 16);
            this.labelControl3.TabIndex = 8;
            this.labelControl3.Text = "Sample Result";
            // 
            // lblSampleResult
            // 
            this.lblSampleResult.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblSampleResult.Location = new System.Drawing.Point(641, 208);
            this.lblSampleResult.Name = "lblSampleResult";
            this.lblSampleResult.Size = new System.Drawing.Size(25, 16);
            this.lblSampleResult.TabIndex = 9;
            this.lblSampleResult.Text = "*****";
            // 
            // chkActive
            // 
            this.chkActive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkActive.Location = new System.Drawing.Point(529, 183);
            this.chkActive.MenuManager = this.ribbon;
            this.chkActive.Name = "chkActive";
            this.chkActive.Properties.Caption = "Active";
            this.chkActive.Size = new System.Drawing.Size(230, 19);
            this.chkActive.TabIndex = 12;
            // 
            // chkResetNumbering
            // 
            this.chkResetNumbering.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkResetNumbering.Location = new System.Drawing.Point(12, 158);
            this.chkResetNumbering.MenuManager = this.ribbon;
            this.chkResetNumbering.Name = "chkResetNumbering";
            this.chkResetNumbering.Properties.Appearance.BackColor = System.Drawing.Color.Yellow;
            this.chkResetNumbering.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkResetNumbering.Properties.Appearance.Options.UseBackColor = true;
            this.chkResetNumbering.Properties.Appearance.Options.UseFont = true;
            this.chkResetNumbering.Properties.Caption = "I Need To Reset The numbering Because I Change The Numbering";
            this.chkResetNumbering.Size = new System.Drawing.Size(459, 20);
            this.chkResetNumbering.TabIndex = 19;
            this.chkResetNumbering.Visible = false;
            // 
            // gridColumnlastnumeric
            // 
            this.gridColumnlastnumeric.Caption = "Last Numeric";
            this.gridColumnlastnumeric.ColumnEdit = this.repositoryItemTextEditNumeric;
            this.gridColumnlastnumeric.FieldName = "lastnumeric";
            this.gridColumnlastnumeric.Name = "gridColumnlastnumeric";
            this.gridColumnlastnumeric.Visible = true;
            this.gridColumnlastnumeric.VisibleIndex = 6;
            this.gridColumnlastnumeric.Width = 85;
            // 
            // frmNumberingSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 581);
            this.Controls.Add(this.chkResetNumbering);
            this.Controls.Add(this.chkActive);
            this.Controls.Add(this.lblSampleResult);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.lookUpEditFunction);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.lookUpEditCompany);
            this.Controls.Add(this.gridControl);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmNumberingSetup";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Numbering Setup";
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditSegment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEditNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditCompany.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditFunction.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkActive.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkResetNumbering.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpNumberingSetup;
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
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnid;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnvoid;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnmap_sourced_numbering_segment_id;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnname;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEditSegment;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnseq;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnValue;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnseparator;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnfirstnumeric;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEditNumeric;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditCompany;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditFunction;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl lblSampleResult;
        private DevExpress.XtraEditors.CheckEdit chkActive;
        private DevExpress.XtraEditors.CheckEdit chkResetNumbering;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnlastnumeric;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
    }
}