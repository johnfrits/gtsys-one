namespace GTSysOne.Gui.MasterFile
{
    partial class frmFixedAssets
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFixedAssets));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
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
            this.txtNumber = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnCMId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnCTId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnCCId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnCarName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnCarModel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEditCarModel = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gridColumnCarType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEditCarType = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gridColumnCarColor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEditCarColor = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gridColumnPlateNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEditPlateNumber = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemTextEditCarName = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.textEditSearchName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.lookUpEditType = new DevExpress.XtraEditors.LookUpEdit();
            this.lookUpEditMajorType = new DevExpress.XtraEditors.LookUpEdit();
            this.lookUpEditPropertyType = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.btnGroup = new DevExpress.XtraEditors.ButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditCarModel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditCarType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditCarColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEditPlateNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEditCarName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditSearchName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditMajorType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditPropertyType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGroup.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(201, 244);
            this.txtName.MenuManager = this.ribbon;
            this.txtName.Name = "txtName";
            this.txtName.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtName.Properties.Appearance.Options.UseFont = true;
            this.txtName.Properties.NullValuePrompt = "Name";
            this.txtName.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtName.Size = new System.Drawing.Size(293, 22);
            this.txtName.TabIndex = 50;
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
            this.ribbon.Size = new System.Drawing.Size(1001, 143);
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
            this.rpDefault.Text = "Fixed Assets";
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
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 582);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1001, 31);
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(201, 208);
            this.txtNumber.MenuManager = this.ribbon;
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtNumber.Properties.Appearance.Options.UseFont = true;
            this.txtNumber.Properties.NullValuePrompt = "Number";
            this.txtNumber.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtNumber.Properties.ReadOnly = true;
            this.txtNumber.Size = new System.Drawing.Size(293, 22);
            this.txtNumber.TabIndex = 48;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.labelControl9.Location = new System.Drawing.Point(38, 183);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(113, 16);
            this.labelControl9.TabIndex = 49;
            this.labelControl9.Text = "Fixed Asset Group:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.labelControl1.Location = new System.Drawing.Point(38, 247);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(40, 16);
            this.labelControl1.TabIndex = 51;
            this.labelControl1.Text = "Name:";
            // 
            // gridControl
            // 
            this.gridControl.Location = new System.Drawing.Point(23, 326);
            this.gridControl.MainView = this.gridView;
            this.gridControl.Name = "gridControl";
            this.gridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEditPlateNumber,
            this.repositoryItemLookUpEditCarModel,
            this.repositoryItemLookUpEditCarType,
            this.repositoryItemLookUpEditCarColor,
            this.repositoryItemTextEditCarName});
            this.gridControl.Size = new System.Drawing.Size(951, 245);
            this.gridControl.TabIndex = 56;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnid,
            this.gridColumnCMId,
            this.gridColumnCTId,
            this.gridColumnCCId,
            this.gridColumnCarName,
            this.gridColumnCarModel,
            this.gridColumnCarType,
            this.gridColumnCarColor,
            this.gridColumnPlateNumber});
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
            // 
            // gridColumnCMId
            // 
            this.gridColumnCMId.Caption = "gridColumnCMId";
            this.gridColumnCMId.FieldName = "CMId";
            this.gridColumnCMId.Name = "gridColumnCMId";
            // 
            // gridColumnCTId
            // 
            this.gridColumnCTId.Caption = "gridColumnCTId";
            this.gridColumnCTId.FieldName = "CTId";
            this.gridColumnCTId.Name = "gridColumnCTId";
            // 
            // gridColumnCCId
            // 
            this.gridColumnCCId.Caption = "gridColumnCCId";
            this.gridColumnCCId.FieldName = "CCId";
            this.gridColumnCCId.Name = "gridColumnCCId";
            // 
            // gridColumnCarName
            // 
            this.gridColumnCarName.Caption = "Car Name";
            this.gridColumnCarName.FieldName = "CarName";
            this.gridColumnCarName.Name = "gridColumnCarName";
            this.gridColumnCarName.Visible = true;
            this.gridColumnCarName.VisibleIndex = 0;
            this.gridColumnCarName.Width = 148;
            // 
            // gridColumnCarModel
            // 
            this.gridColumnCarModel.Caption = "Car Model";
            this.gridColumnCarModel.ColumnEdit = this.repositoryItemLookUpEditCarModel;
            this.gridColumnCarModel.FieldName = "CarModel";
            this.gridColumnCarModel.Name = "gridColumnCarModel";
            this.gridColumnCarModel.Visible = true;
            this.gridColumnCarModel.VisibleIndex = 1;
            this.gridColumnCarModel.Width = 188;
            // 
            // repositoryItemLookUpEditCarModel
            // 
            this.repositoryItemLookUpEditCarModel.AutoHeight = false;
            this.repositoryItemLookUpEditCarModel.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemLookUpEditCarModel.Name = "repositoryItemLookUpEditCarModel";
            this.repositoryItemLookUpEditCarModel.NullText = "";
            // 
            // gridColumnCarType
            // 
            this.gridColumnCarType.Caption = "Car Type";
            this.gridColumnCarType.ColumnEdit = this.repositoryItemLookUpEditCarType;
            this.gridColumnCarType.FieldName = "CarType";
            this.gridColumnCarType.Name = "gridColumnCarType";
            this.gridColumnCarType.Visible = true;
            this.gridColumnCarType.VisibleIndex = 2;
            this.gridColumnCarType.Width = 158;
            // 
            // repositoryItemLookUpEditCarType
            // 
            this.repositoryItemLookUpEditCarType.AutoHeight = false;
            this.repositoryItemLookUpEditCarType.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemLookUpEditCarType.Name = "repositoryItemLookUpEditCarType";
            this.repositoryItemLookUpEditCarType.NullText = "";
            // 
            // gridColumnCarColor
            // 
            this.gridColumnCarColor.Caption = "Car Color";
            this.gridColumnCarColor.ColumnEdit = this.repositoryItemLookUpEditCarColor;
            this.gridColumnCarColor.FieldName = "CarColor";
            this.gridColumnCarColor.Name = "gridColumnCarColor";
            this.gridColumnCarColor.Visible = true;
            this.gridColumnCarColor.VisibleIndex = 3;
            this.gridColumnCarColor.Width = 160;
            // 
            // repositoryItemLookUpEditCarColor
            // 
            this.repositoryItemLookUpEditCarColor.AutoHeight = false;
            this.repositoryItemLookUpEditCarColor.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemLookUpEditCarColor.Name = "repositoryItemLookUpEditCarColor";
            this.repositoryItemLookUpEditCarColor.NullText = "";
            // 
            // gridColumnPlateNumber
            // 
            this.gridColumnPlateNumber.Caption = "Plate Number";
            this.gridColumnPlateNumber.ColumnEdit = this.repositoryItemTextEditPlateNumber;
            this.gridColumnPlateNumber.FieldName = "PlateNumber";
            this.gridColumnPlateNumber.Name = "gridColumnPlateNumber";
            this.gridColumnPlateNumber.Visible = true;
            this.gridColumnPlateNumber.VisibleIndex = 4;
            this.gridColumnPlateNumber.Width = 276;
            // 
            // repositoryItemTextEditPlateNumber
            // 
            this.repositoryItemTextEditPlateNumber.AutoHeight = false;
            this.repositoryItemTextEditPlateNumber.Name = "repositoryItemTextEditPlateNumber";
            // 
            // repositoryItemTextEditCarName
            // 
            this.repositoryItemTextEditCarName.AutoHeight = false;
            this.repositoryItemTextEditCarName.Name = "repositoryItemTextEditCarName";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.labelControl2.Location = new System.Drawing.Point(38, 211);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(51, 16);
            this.labelControl2.TabIndex = 57;
            this.labelControl2.Text = "Number:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.labelControl3.Location = new System.Drawing.Point(38, 275);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(86, 16);
            this.labelControl3.TabIndex = 58;
            this.labelControl3.Text = "Search Name:";
            // 
            // textEditSearchName
            // 
            this.textEditSearchName.Location = new System.Drawing.Point(201, 272);
            this.textEditSearchName.MenuManager = this.ribbon;
            this.textEditSearchName.Name = "textEditSearchName";
            this.textEditSearchName.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.textEditSearchName.Properties.Appearance.Options.UseFont = true;
            this.textEditSearchName.Properties.NullValuePrompt = "Search Name";
            this.textEditSearchName.Properties.NullValuePromptShowForEmptyValue = true;
            this.textEditSearchName.Size = new System.Drawing.Size(293, 22);
            this.textEditSearchName.TabIndex = 59;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.labelControl4.Location = new System.Drawing.Point(547, 211);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(72, 16);
            this.labelControl4.TabIndex = 62;
            this.labelControl4.Text = "Major Type:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.labelControl5.Location = new System.Drawing.Point(547, 183);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(35, 16);
            this.labelControl5.TabIndex = 61;
            this.labelControl5.Text = "Type:";
            // 
            // lookUpEditType
            // 
            this.lookUpEditType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lookUpEditType.Location = new System.Drawing.Point(645, 180);
            this.lookUpEditType.MenuManager = this.ribbon;
            this.lookUpEditType.Name = "lookUpEditType";
            this.lookUpEditType.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lookUpEditType.Properties.Appearance.Options.UseFont = true;
            this.lookUpEditType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditType.Properties.DropDownRows = 25;
            this.lookUpEditType.Properties.NullText = "";
            this.lookUpEditType.Properties.NullValuePrompt = "Type";
            this.lookUpEditType.Properties.NullValuePromptShowForEmptyValue = true;
            this.lookUpEditType.Size = new System.Drawing.Size(292, 22);
            this.lookUpEditType.TabIndex = 63;
            // 
            // lookUpEditMajorType
            // 
            this.lookUpEditMajorType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lookUpEditMajorType.Location = new System.Drawing.Point(645, 208);
            this.lookUpEditMajorType.MenuManager = this.ribbon;
            this.lookUpEditMajorType.Name = "lookUpEditMajorType";
            this.lookUpEditMajorType.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lookUpEditMajorType.Properties.Appearance.Options.UseFont = true;
            this.lookUpEditMajorType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditMajorType.Properties.DropDownRows = 25;
            this.lookUpEditMajorType.Properties.NullText = "";
            this.lookUpEditMajorType.Properties.NullValuePrompt = "Major Type";
            this.lookUpEditMajorType.Properties.NullValuePromptShowForEmptyValue = true;
            this.lookUpEditMajorType.Size = new System.Drawing.Size(292, 22);
            this.lookUpEditMajorType.TabIndex = 64;
            // 
            // lookUpEditPropertyType
            // 
            this.lookUpEditPropertyType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lookUpEditPropertyType.Location = new System.Drawing.Point(645, 236);
            this.lookUpEditPropertyType.MenuManager = this.ribbon;
            this.lookUpEditPropertyType.Name = "lookUpEditPropertyType";
            this.lookUpEditPropertyType.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lookUpEditPropertyType.Properties.Appearance.Options.UseFont = true;
            this.lookUpEditPropertyType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditPropertyType.Properties.DropDownRows = 25;
            this.lookUpEditPropertyType.Properties.NullText = "";
            this.lookUpEditPropertyType.Properties.NullValuePrompt = "Property Type";
            this.lookUpEditPropertyType.Properties.NullValuePromptShowForEmptyValue = true;
            this.lookUpEditPropertyType.Size = new System.Drawing.Size(292, 22);
            this.lookUpEditPropertyType.TabIndex = 65;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.labelControl6.Location = new System.Drawing.Point(547, 239);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(89, 16);
            this.labelControl6.TabIndex = 66;
            this.labelControl6.Text = "Property Type:";
            // 
            // btnGroup
            // 
            this.btnGroup.Location = new System.Drawing.Point(201, 182);
            this.btnGroup.MenuManager = this.ribbon;
            this.btnGroup.Name = "btnGroup";
            this.btnGroup.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("btnGroup.Properties.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.btnGroup.Properties.ReadOnly = true;
            this.btnGroup.Size = new System.Drawing.Size(293, 22);
            this.btnGroup.TabIndex = 69;
            // 
            // frmFixedAssets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 613);
            this.Controls.Add(this.btnGroup);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.lookUpEditPropertyType);
            this.Controls.Add(this.lookUpEditMajorType);
            this.Controls.Add(this.lookUpEditType);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.textEditSearchName);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.gridControl);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.ribbon);
            this.Name = "frmFixedAssets";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Fixed Assets";
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditCarModel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditCarType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditCarColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEditPlateNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEditCarName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditSearchName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditMajorType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditPropertyType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGroup.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtName;
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
        private DevExpress.XtraBars.Ribbon.RibbonPage rpDefault;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpNew;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpSave;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpTools;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpSearch;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpClose;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraEditors.TextEdit txtNumber;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnid;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnCMId;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnCTId;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnCCId;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit textEditSearchName;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditType;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditMajorType;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditPropertyType;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnCarModel;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnCarType;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnCarColor;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnPlateNumber;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEditPlateNumber;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEditCarModel;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEditCarType;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEditCarColor;
        private DevExpress.XtraEditors.ButtonEdit btnGroup;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnCarName;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEditCarName;

    }
}