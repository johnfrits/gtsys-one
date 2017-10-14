namespace GTSysOne.Gui.Document
{
    partial class frmUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUser));
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barSave = new DevExpress.XtraBars.BarButtonItem();
            this.barClose = new DevExpress.XtraBars.BarButtonItem();
            this.barFirst = new DevExpress.XtraBars.BarButtonItem();
            this.barPrevious = new DevExpress.XtraBars.BarButtonItem();
            this.barNext = new DevExpress.XtraBars.BarButtonItem();
            this.barLast = new DevExpress.XtraBars.BarButtonItem();
            this.barSeparator = new DevExpress.XtraBars.BarButtonItem();
            this.barSearch = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemSearchControl1 = new DevExpress.XtraEditors.Repository.RepositoryItemSearchControl();
            this.barNew = new DevExpress.XtraBars.BarButtonItem();
            this.rpUser = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpNew = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpSave = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpTools = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpSearch = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpClose = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStat = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.txtUserName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtPassword = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtConfirmPassword = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.lookUpEditCompany = new DevExpress.XtraEditors.LookUpEdit();
            this.chkActivate = new DevExpress.XtraEditors.CheckEdit();
            this.labelControlAccountType = new DevExpress.XtraEditors.LabelControl();
            this.lookUpEditAccountType = new DevExpress.XtraEditors.LookUpEdit();
            this.gridControlUserPrivileges = new DevExpress.XtraGrid.GridControl();
            this.gridViewUserPrivileges = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnVoid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnMapId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnAction = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnGrant = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraTabControlUser = new DevExpress.XtraTab.XtraTabControl();
            this.xTabPrivilege = new DevExpress.XtraTab.XtraTabPage();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.lookUpEditPrivilege = new DevExpress.XtraEditors.LookUpEdit();
            this.xTabCompanyAccess = new DevExpress.XtraTab.XtraTabPage();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.lookUpEditCompany2 = new DevExpress.XtraEditors.LookUpEdit();
            this.gridControlCompanyAccess = new DevExpress.XtraGrid.GridControl();
            this.gridViewCompanyAccess = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnCompanyId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnCompany = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnOwner = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xTabEstablishmentAccess = new DevExpress.XtraTab.XtraTabPage();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.lookUpEditEstablishment2 = new DevExpress.XtraEditors.LookUpEdit();
            this.gridControlEstablishment = new DevExpress.XtraGrid.GridControl();
            this.gridViewEstablishment = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnEstId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnEstablishment = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnShortName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.lookUpEditEstablishment = new DevExpress.XtraEditors.LookUpEdit();
            this.chkAdmin = new DevExpress.XtraEditors.CheckEdit();
            this.txtNumbering = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtConfirmPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditCompany.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkActivate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditAccountType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlUserPrivileges)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewUserPrivileges)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControlUser)).BeginInit();
            this.xtraTabControlUser.SuspendLayout();
            this.xTabPrivilege.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditPrivilege.Properties)).BeginInit();
            this.xTabCompanyAccess.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditCompany2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCompanyAccess)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCompanyAccess)).BeginInit();
            this.xTabEstablishmentAccess.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditEstablishment2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlEstablishment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEstablishment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditEstablishment.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAdmin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumbering.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl
            // 
            this.ribbonControl.ApplicationIcon = ((System.Drawing.Bitmap)(resources.GetObject("ribbonControl.ApplicationIcon")));
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem,
            this.barSave,
            this.barClose,
            this.barFirst,
            this.barPrevious,
            this.barNext,
            this.barLast,
            this.barSeparator,
            this.barSearch,
            this.barNew});
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.MaxItemId = 10;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rpUser});
            this.ribbonControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemSearchControl1});
            this.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbonControl.Size = new System.Drawing.Size(956, 143);
            this.ribbonControl.StatusBar = this.ribbonStat;
            // 
            // barSave
            // 
            this.barSave.Caption = "Save";
            this.barSave.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.barSave.Glyph = ((System.Drawing.Image)(resources.GetObject("barSave.Glyph")));
            this.barSave.Id = 1;
            this.barSave.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barSave.LargeGlyph")));
            this.barSave.LargeWidth = 100;
            this.barSave.Name = "barSave";
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
            // barFirst
            // 
            this.barFirst.Caption = "First";
            this.barFirst.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.barFirst.Glyph = ((System.Drawing.Image)(resources.GetObject("barFirst.Glyph")));
            this.barFirst.Id = 3;
            this.barFirst.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barFirst.LargeGlyph")));
            this.barFirst.LargeWidth = 70;
            this.barFirst.Name = "barFirst";
            // 
            // barPrevious
            // 
            this.barPrevious.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left;
            this.barPrevious.Caption = "Previous";
            this.barPrevious.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.barPrevious.Glyph = ((System.Drawing.Image)(resources.GetObject("barPrevious.Glyph")));
            this.barPrevious.Id = 4;
            this.barPrevious.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barPrevious.LargeGlyph")));
            this.barPrevious.LargeWidth = 70;
            this.barPrevious.Name = "barPrevious";
            this.barPrevious.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barNext
            // 
            this.barNext.Caption = "Next";
            this.barNext.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.barNext.Glyph = ((System.Drawing.Image)(resources.GetObject("barNext.Glyph")));
            this.barNext.Id = 5;
            this.barNext.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barNext.LargeGlyph")));
            this.barNext.LargeWidth = 70;
            this.barNext.Name = "barNext";
            // 
            // barLast
            // 
            this.barLast.Caption = "Last";
            this.barLast.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.barLast.Glyph = ((System.Drawing.Image)(resources.GetObject("barLast.Glyph")));
            this.barLast.Id = 6;
            this.barLast.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barLast.LargeGlyph")));
            this.barLast.LargeWidth = 70;
            this.barLast.Name = "barLast";
            // 
            // barSeparator
            // 
            this.barSeparator.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.barSeparator.Enabled = false;
            this.barSeparator.Glyph = ((System.Drawing.Image)(resources.GetObject("barSeparator.Glyph")));
            this.barSeparator.Id = 7;
            this.barSeparator.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barSeparator.LargeGlyph")));
            this.barSeparator.Name = "barSeparator";
            // 
            // barSearch
            // 
            this.barSearch.Caption = "Search";
            this.barSearch.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.barSearch.Edit = this.repositoryItemSearchControl1;
            this.barSearch.Id = 8;
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
            // barNew
            // 
            this.barNew.Caption = "New";
            this.barNew.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.barNew.Glyph = ((System.Drawing.Image)(resources.GetObject("barNew.Glyph")));
            this.barNew.Id = 9;
            this.barNew.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barNew.LargeGlyph")));
            this.barNew.LargeWidth = 100;
            this.barNew.Name = "barNew";
            // 
            // rpUser
            // 
            this.rpUser.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpNew,
            this.rpSave,
            this.rpTools,
            this.rpSearch,
            this.rpClose});
            this.rpUser.Name = "rpUser";
            this.rpUser.Text = "User";
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
            this.rpTools.ItemLinks.Add(this.barSeparator);
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
            // ribbonStat
            // 
            this.ribbonStat.Location = new System.Drawing.Point(0, 659);
            this.ribbonStat.Name = "ribbonStat";
            this.ribbonStat.Ribbon = this.ribbonControl;
            this.ribbonStat.Size = new System.Drawing.Size(956, 31);
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(179, 204);
            this.txtUserName.MenuManager = this.ribbonControl;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Properties.Appearance.Options.UseFont = true;
            this.txtUserName.Properties.NullValuePrompt = "Username";
            this.txtUserName.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtUserName.Size = new System.Drawing.Size(269, 22);
            this.txtUserName.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(22, 207);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(63, 16);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Username";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(22, 231);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(60, 16);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(179, 228);
            this.txtPassword.MenuManager = this.ribbonControl;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Properties.Appearance.Options.UseFont = true;
            this.txtPassword.Properties.UseSystemPasswordChar = true;
            this.txtPassword.Size = new System.Drawing.Size(269, 22);
            this.txtPassword.TabIndex = 4;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(22, 255);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(108, 16);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "Confirm Password";
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(179, 252);
            this.txtConfirmPassword.MenuManager = this.ribbonControl;
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPassword.Properties.Appearance.Options.UseFont = true;
            this.txtConfirmPassword.Properties.UseSystemPasswordChar = true;
            this.txtConfirmPassword.Size = new System.Drawing.Size(269, 22);
            this.txtConfirmPassword.TabIndex = 6;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Location = new System.Drawing.Point(468, 184);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(103, 16);
            this.labelControl4.TabIndex = 8;
            this.labelControl4.Text = "Default Company";
            // 
            // lookUpEditCompany
            // 
            this.lookUpEditCompany.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lookUpEditCompany.Location = new System.Drawing.Point(637, 181);
            this.lookUpEditCompany.MenuManager = this.ribbonControl;
            this.lookUpEditCompany.Name = "lookUpEditCompany";
            this.lookUpEditCompany.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lookUpEditCompany.Properties.Appearance.Options.UseFont = true;
            this.lookUpEditCompany.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditCompany.Properties.NullText = "";
            this.lookUpEditCompany.Properties.NullValuePrompt = "Company";
            this.lookUpEditCompany.Properties.NullValuePromptShowForEmptyValue = true;
            this.lookUpEditCompany.Size = new System.Drawing.Size(269, 22);
            this.lookUpEditCompany.TabIndex = 9;
            // 
            // chkActivate
            // 
            this.chkActivate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkActivate.Location = new System.Drawing.Point(637, 259);
            this.chkActivate.MenuManager = this.ribbonControl;
            this.chkActivate.Name = "chkActivate";
            this.chkActivate.Properties.Caption = "Activate";
            this.chkActivate.Size = new System.Drawing.Size(269, 19);
            this.chkActivate.TabIndex = 10;
            // 
            // labelControlAccountType
            // 
            this.labelControlAccountType.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControlAccountType.Location = new System.Drawing.Point(469, 234);
            this.labelControlAccountType.Name = "labelControlAccountType";
            this.labelControlAccountType.Size = new System.Drawing.Size(83, 16);
            this.labelControlAccountType.TabIndex = 12;
            this.labelControlAccountType.Text = "Account Type";
            // 
            // lookUpEditAccountType
            // 
            this.lookUpEditAccountType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lookUpEditAccountType.Location = new System.Drawing.Point(637, 229);
            this.lookUpEditAccountType.MenuManager = this.ribbonControl;
            this.lookUpEditAccountType.Name = "lookUpEditAccountType";
            this.lookUpEditAccountType.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lookUpEditAccountType.Properties.Appearance.Options.UseFont = true;
            this.lookUpEditAccountType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditAccountType.Properties.NullText = "";
            this.lookUpEditAccountType.Properties.NullValuePrompt = "Account Type";
            this.lookUpEditAccountType.Properties.NullValuePromptShowForEmptyValue = true;
            this.lookUpEditAccountType.Size = new System.Drawing.Size(269, 22);
            this.lookUpEditAccountType.TabIndex = 13;
            // 
            // gridControlUserPrivileges
            // 
            this.gridControlUserPrivileges.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlUserPrivileges.Location = new System.Drawing.Point(4, 43);
            this.gridControlUserPrivileges.MainView = this.gridViewUserPrivileges;
            this.gridControlUserPrivileges.MenuManager = this.ribbonControl;
            this.gridControlUserPrivileges.Name = "gridControlUserPrivileges";
            this.gridControlUserPrivileges.Size = new System.Drawing.Size(899, 259);
            this.gridControlUserPrivileges.TabIndex = 14;
            this.gridControlUserPrivileges.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewUserPrivileges});
            // 
            // gridViewUserPrivileges
            // 
            this.gridViewUserPrivileges.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnid,
            this.gridColumnVoid,
            this.gridColumnMapId,
            this.gridColumnAction,
            this.gridColumnGrant});
            this.gridViewUserPrivileges.GridControl = this.gridControlUserPrivileges;
            this.gridViewUserPrivileges.Name = "gridViewUserPrivileges";
            this.gridViewUserPrivileges.OptionsView.ColumnAutoWidth = false;
            this.gridViewUserPrivileges.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumnid
            // 
            this.gridColumnid.Caption = "id";
            this.gridColumnid.FieldName = "id";
            this.gridColumnid.Name = "gridColumnid";
            this.gridColumnid.OptionsColumn.AllowEdit = false;
            this.gridColumnid.OptionsColumn.AllowFocus = false;
            this.gridColumnid.OptionsColumn.ReadOnly = true;
            // 
            // gridColumnVoid
            // 
            this.gridColumnVoid.Caption = "Void";
            this.gridColumnVoid.FieldName = "Void";
            this.gridColumnVoid.Name = "gridColumnVoid";
            this.gridColumnVoid.Visible = true;
            this.gridColumnVoid.VisibleIndex = 0;
            // 
            // gridColumnMapId
            // 
            this.gridColumnMapId.Caption = "MapId";
            this.gridColumnMapId.FieldName = "MapId";
            this.gridColumnMapId.Name = "gridColumnMapId";
            this.gridColumnMapId.OptionsColumn.AllowEdit = false;
            this.gridColumnMapId.OptionsColumn.AllowFocus = false;
            this.gridColumnMapId.OptionsColumn.ReadOnly = true;
            // 
            // gridColumnAction
            // 
            this.gridColumnAction.Caption = "Action";
            this.gridColumnAction.FieldName = "Action";
            this.gridColumnAction.Name = "gridColumnAction";
            this.gridColumnAction.OptionsColumn.AllowEdit = false;
            this.gridColumnAction.OptionsColumn.AllowFocus = false;
            this.gridColumnAction.OptionsColumn.ReadOnly = true;
            this.gridColumnAction.Visible = true;
            this.gridColumnAction.VisibleIndex = 1;
            // 
            // gridColumnGrant
            // 
            this.gridColumnGrant.Caption = "Grant";
            this.gridColumnGrant.FieldName = "Grant";
            this.gridColumnGrant.Name = "gridColumnGrant";
            this.gridColumnGrant.Visible = true;
            this.gridColumnGrant.VisibleIndex = 2;
            // 
            // xtraTabControlUser
            // 
            this.xtraTabControlUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xtraTabControlUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.xtraTabControlUser.HeaderOrientation = DevExpress.XtraTab.TabOrientation.Horizontal;
            this.xtraTabControlUser.Location = new System.Drawing.Point(22, 312);
            this.xtraTabControlUser.Name = "xtraTabControlUser";
            this.xtraTabControlUser.SelectedTabPage = this.xTabPrivilege;
            this.xtraTabControlUser.Size = new System.Drawing.Size(915, 336);
            this.xtraTabControlUser.TabIndex = 16;
            this.xtraTabControlUser.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xTabPrivilege,
            this.xTabCompanyAccess,
            this.xTabEstablishmentAccess});
            // 
            // xTabPrivilege
            // 
            this.xTabPrivilege.Controls.Add(this.labelControl6);
            this.xTabPrivilege.Controls.Add(this.lookUpEditPrivilege);
            this.xTabPrivilege.Controls.Add(this.gridControlUserPrivileges);
            this.xTabPrivilege.Cursor = System.Windows.Forms.Cursors.Default;
            this.xTabPrivilege.Image = ((System.Drawing.Image)(resources.GetObject("xTabPrivilege.Image")));
            this.xTabPrivilege.Name = "xTabPrivilege";
            this.xTabPrivilege.PageEnabled = false;
            this.xTabPrivilege.Size = new System.Drawing.Size(909, 305);
            this.xTabPrivilege.Text = "User Privileges";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Location = new System.Drawing.Point(7, 13);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(60, 16);
            this.labelControl6.TabIndex = 16;
            this.labelControl6.Text = "Privileges";
            // 
            // lookUpEditPrivilege
            // 
            this.lookUpEditPrivilege.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lookUpEditPrivilege.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lookUpEditPrivilege.Location = new System.Drawing.Point(102, 10);
            this.lookUpEditPrivilege.MenuManager = this.ribbonControl;
            this.lookUpEditPrivilege.Name = "lookUpEditPrivilege";
            this.lookUpEditPrivilege.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lookUpEditPrivilege.Properties.Appearance.Options.UseFont = true;
            this.lookUpEditPrivilege.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditPrivilege.Properties.DropDownRows = 50;
            this.lookUpEditPrivilege.Properties.NullText = "";
            this.lookUpEditPrivilege.Properties.NullValuePrompt = "Privilige";
            this.lookUpEditPrivilege.Properties.NullValuePromptShowForEmptyValue = true;
            this.lookUpEditPrivilege.Size = new System.Drawing.Size(801, 22);
            this.lookUpEditPrivilege.TabIndex = 15;
            // 
            // xTabCompanyAccess
            // 
            this.xTabCompanyAccess.Controls.Add(this.labelControl7);
            this.xTabCompanyAccess.Controls.Add(this.lookUpEditCompany2);
            this.xTabCompanyAccess.Controls.Add(this.gridControlCompanyAccess);
            this.xTabCompanyAccess.Cursor = System.Windows.Forms.Cursors.Default;
            this.xTabCompanyAccess.Image = ((System.Drawing.Image)(resources.GetObject("xTabCompanyAccess.Image")));
            this.xTabCompanyAccess.Name = "xTabCompanyAccess";
            this.xTabCompanyAccess.PageEnabled = false;
            this.xTabCompanyAccess.Size = new System.Drawing.Size(909, 305);
            this.xTabCompanyAccess.Text = "Company Access";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Location = new System.Drawing.Point(7, 13);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(58, 16);
            this.labelControl7.TabIndex = 18;
            this.labelControl7.Text = "Company";
            // 
            // lookUpEditCompany2
            // 
            this.lookUpEditCompany2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lookUpEditCompany2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lookUpEditCompany2.Location = new System.Drawing.Point(102, 10);
            this.lookUpEditCompany2.MenuManager = this.ribbonControl;
            this.lookUpEditCompany2.Name = "lookUpEditCompany2";
            this.lookUpEditCompany2.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lookUpEditCompany2.Properties.Appearance.Options.UseFont = true;
            this.lookUpEditCompany2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditCompany2.Properties.NullText = "";
            this.lookUpEditCompany2.Properties.NullValuePrompt = "Company";
            this.lookUpEditCompany2.Properties.NullValuePromptShowForEmptyValue = true;
            this.lookUpEditCompany2.Size = new System.Drawing.Size(801, 22);
            this.lookUpEditCompany2.TabIndex = 17;
            // 
            // gridControlCompanyAccess
            // 
            this.gridControlCompanyAccess.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlCompanyAccess.Location = new System.Drawing.Point(4, 43);
            this.gridControlCompanyAccess.MainView = this.gridViewCompanyAccess;
            this.gridControlCompanyAccess.MenuManager = this.ribbonControl;
            this.gridControlCompanyAccess.Name = "gridControlCompanyAccess";
            this.gridControlCompanyAccess.Size = new System.Drawing.Size(899, 260);
            this.gridControlCompanyAccess.TabIndex = 15;
            this.gridControlCompanyAccess.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCompanyAccess});
            // 
            // gridViewCompanyAccess
            // 
            this.gridViewCompanyAccess.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumnCompanyId,
            this.gridColumnCompany,
            this.gridColumnAddress,
            this.gridColumnOwner,
            this.gridColumn4});
            this.gridViewCompanyAccess.GridControl = this.gridControlCompanyAccess;
            this.gridViewCompanyAccess.Name = "gridViewCompanyAccess";
            this.gridViewCompanyAccess.OptionsView.ColumnAutoWidth = false;
            this.gridViewCompanyAccess.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "id";
            this.gridColumn1.FieldName = "id";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.OptionsColumn.AllowFocus = false;
            this.gridColumn1.OptionsColumn.ReadOnly = true;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Void";
            this.gridColumn2.FieldName = "Void";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            // 
            // gridColumnCompanyId
            // 
            this.gridColumnCompanyId.Caption = "CompanyId";
            this.gridColumnCompanyId.FieldName = "CompanyId";
            this.gridColumnCompanyId.Name = "gridColumnCompanyId";
            this.gridColumnCompanyId.OptionsColumn.AllowEdit = false;
            this.gridColumnCompanyId.OptionsColumn.AllowFocus = false;
            this.gridColumnCompanyId.OptionsColumn.ReadOnly = true;
            // 
            // gridColumnCompany
            // 
            this.gridColumnCompany.Caption = "Company";
            this.gridColumnCompany.FieldName = "Company";
            this.gridColumnCompany.Name = "gridColumnCompany";
            this.gridColumnCompany.OptionsColumn.AllowEdit = false;
            this.gridColumnCompany.OptionsColumn.AllowFocus = false;
            this.gridColumnCompany.OptionsColumn.ReadOnly = true;
            this.gridColumnCompany.Visible = true;
            this.gridColumnCompany.VisibleIndex = 1;
            // 
            // gridColumnAddress
            // 
            this.gridColumnAddress.Caption = "Address";
            this.gridColumnAddress.FieldName = "Address";
            this.gridColumnAddress.Name = "gridColumnAddress";
            this.gridColumnAddress.OptionsColumn.AllowEdit = false;
            this.gridColumnAddress.OptionsColumn.AllowFocus = false;
            this.gridColumnAddress.OptionsColumn.ReadOnly = true;
            this.gridColumnAddress.Visible = true;
            this.gridColumnAddress.VisibleIndex = 2;
            // 
            // gridColumnOwner
            // 
            this.gridColumnOwner.Caption = "Owner";
            this.gridColumnOwner.FieldName = "Owner";
            this.gridColumnOwner.Name = "gridColumnOwner";
            this.gridColumnOwner.OptionsColumn.AllowEdit = false;
            this.gridColumnOwner.OptionsColumn.AllowFocus = false;
            this.gridColumnOwner.OptionsColumn.ReadOnly = true;
            this.gridColumnOwner.Visible = true;
            this.gridColumnOwner.VisibleIndex = 3;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Grant";
            this.gridColumn4.FieldName = "Grant";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 4;
            // 
            // xTabEstablishmentAccess
            // 
            this.xTabEstablishmentAccess.Controls.Add(this.labelControl8);
            this.xTabEstablishmentAccess.Controls.Add(this.lookUpEditEstablishment2);
            this.xTabEstablishmentAccess.Controls.Add(this.gridControlEstablishment);
            this.xTabEstablishmentAccess.Cursor = System.Windows.Forms.Cursors.Default;
            this.xTabEstablishmentAccess.Image = ((System.Drawing.Image)(resources.GetObject("xTabEstablishmentAccess.Image")));
            this.xTabEstablishmentAccess.Name = "xTabEstablishmentAccess";
            this.xTabEstablishmentAccess.PageEnabled = false;
            this.xTabEstablishmentAccess.Size = new System.Drawing.Size(909, 305);
            this.xTabEstablishmentAccess.Text = "Establishment Access";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Location = new System.Drawing.Point(7, 13);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(85, 16);
            this.labelControl8.TabIndex = 19;
            this.labelControl8.Text = "Establishment";
            // 
            // lookUpEditEstablishment2
            // 
            this.lookUpEditEstablishment2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lookUpEditEstablishment2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lookUpEditEstablishment2.Location = new System.Drawing.Point(102, 10);
            this.lookUpEditEstablishment2.MenuManager = this.ribbonControl;
            this.lookUpEditEstablishment2.Name = "lookUpEditEstablishment2";
            this.lookUpEditEstablishment2.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lookUpEditEstablishment2.Properties.Appearance.Options.UseFont = true;
            this.lookUpEditEstablishment2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditEstablishment2.Properties.NullText = "";
            this.lookUpEditEstablishment2.Properties.NullValuePrompt = "Establishment";
            this.lookUpEditEstablishment2.Properties.NullValuePromptShowForEmptyValue = true;
            this.lookUpEditEstablishment2.Size = new System.Drawing.Size(801, 22);
            this.lookUpEditEstablishment2.TabIndex = 18;
            // 
            // gridControlEstablishment
            // 
            this.gridControlEstablishment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlEstablishment.Location = new System.Drawing.Point(4, 43);
            this.gridControlEstablishment.MainView = this.gridViewEstablishment;
            this.gridControlEstablishment.MenuManager = this.ribbonControl;
            this.gridControlEstablishment.Name = "gridControlEstablishment";
            this.gridControlEstablishment.Size = new System.Drawing.Size(899, 260);
            this.gridControlEstablishment.TabIndex = 17;
            this.gridControlEstablishment.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewEstablishment});
            // 
            // gridViewEstablishment
            // 
            this.gridViewEstablishment.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn3,
            this.gridColumn5,
            this.gridColumnEstId,
            this.gridColumnEstablishment,
            this.gridColumn8,
            this.gridColumnShortName,
            this.gridColumn10});
            this.gridViewEstablishment.GridControl = this.gridControlEstablishment;
            this.gridViewEstablishment.Name = "gridViewEstablishment";
            this.gridViewEstablishment.OptionsView.ColumnAutoWidth = false;
            this.gridViewEstablishment.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "id";
            this.gridColumn3.FieldName = "id";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.OptionsColumn.AllowFocus = false;
            this.gridColumn3.OptionsColumn.ReadOnly = true;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Void";
            this.gridColumn5.FieldName = "Void";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 0;
            // 
            // gridColumnEstId
            // 
            this.gridColumnEstId.Caption = "EstId";
            this.gridColumnEstId.FieldName = "EstId";
            this.gridColumnEstId.Name = "gridColumnEstId";
            this.gridColumnEstId.OptionsColumn.AllowEdit = false;
            this.gridColumnEstId.OptionsColumn.AllowFocus = false;
            this.gridColumnEstId.OptionsColumn.ReadOnly = true;
            // 
            // gridColumnEstablishment
            // 
            this.gridColumnEstablishment.Caption = "Establishment";
            this.gridColumnEstablishment.FieldName = "Establishment";
            this.gridColumnEstablishment.Name = "gridColumnEstablishment";
            this.gridColumnEstablishment.OptionsColumn.AllowEdit = false;
            this.gridColumnEstablishment.OptionsColumn.AllowFocus = false;
            this.gridColumnEstablishment.OptionsColumn.ReadOnly = true;
            this.gridColumnEstablishment.Visible = true;
            this.gridColumnEstablishment.VisibleIndex = 1;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Address";
            this.gridColumn8.FieldName = "Address";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.OptionsColumn.AllowEdit = false;
            this.gridColumn8.OptionsColumn.AllowFocus = false;
            this.gridColumn8.OptionsColumn.ReadOnly = true;
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 2;
            // 
            // gridColumnShortName
            // 
            this.gridColumnShortName.Caption = "Short Name";
            this.gridColumnShortName.FieldName = "Short Name";
            this.gridColumnShortName.Name = "gridColumnShortName";
            this.gridColumnShortName.OptionsColumn.AllowEdit = false;
            this.gridColumnShortName.OptionsColumn.AllowFocus = false;
            this.gridColumnShortName.OptionsColumn.ReadOnly = true;
            this.gridColumnShortName.Visible = true;
            this.gridColumnShortName.VisibleIndex = 3;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "Grant";
            this.gridColumn10.FieldName = "Grant";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 4;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Location = new System.Drawing.Point(468, 208);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(130, 16);
            this.labelControl9.TabIndex = 17;
            this.labelControl9.Text = "Default Establishment";
            // 
            // lookUpEditEstablishment
            // 
            this.lookUpEditEstablishment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lookUpEditEstablishment.Location = new System.Drawing.Point(636, 206);
            this.lookUpEditEstablishment.MenuManager = this.ribbonControl;
            this.lookUpEditEstablishment.Name = "lookUpEditEstablishment";
            this.lookUpEditEstablishment.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lookUpEditEstablishment.Properties.Appearance.Options.UseFont = true;
            this.lookUpEditEstablishment.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditEstablishment.Properties.NullText = "";
            this.lookUpEditEstablishment.Properties.NullValuePrompt = "Company";
            this.lookUpEditEstablishment.Properties.NullValuePromptShowForEmptyValue = true;
            this.lookUpEditEstablishment.Size = new System.Drawing.Size(269, 22);
            this.lookUpEditEstablishment.TabIndex = 18;
            // 
            // chkAdmin
            // 
            this.chkAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkAdmin.Location = new System.Drawing.Point(637, 284);
            this.chkAdmin.MenuManager = this.ribbonControl;
            this.chkAdmin.Name = "chkAdmin";
            this.chkAdmin.Properties.Caption = "Admin";
            this.chkAdmin.Size = new System.Drawing.Size(269, 19);
            this.chkAdmin.TabIndex = 21;
            // 
            // txtNumbering
            // 
            this.txtNumbering.Location = new System.Drawing.Point(179, 179);
            this.txtNumbering.MenuManager = this.ribbonControl;
            this.txtNumbering.Name = "txtNumbering";
            this.txtNumbering.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumbering.Properties.Appearance.Options.UseFont = true;
            this.txtNumbering.Properties.NullValuePrompt = "Username";
            this.txtNumbering.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtNumbering.Size = new System.Drawing.Size(269, 22);
            this.txtNumbering.TabIndex = 24;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Location = new System.Drawing.Point(22, 182);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(66, 16);
            this.labelControl5.TabIndex = 25;
            this.labelControl5.Text = "Numbering";
            // 
            // frmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 690);
            this.Controls.Add(this.txtNumbering);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.chkAdmin);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.lookUpEditEstablishment);
            this.Controls.Add(this.xtraTabControlUser);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.lookUpEditAccountType);
            this.Controls.Add(this.ribbonStat);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.labelControlAccountType);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.chkActivate);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lookUpEditCompany);
            this.Controls.Add(this.ribbonControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmUser";
            this.Ribbon = this.ribbonControl;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStat;
            this.Text = "User";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtConfirmPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditCompany.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkActivate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditAccountType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlUserPrivileges)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewUserPrivileges)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControlUser)).EndInit();
            this.xtraTabControlUser.ResumeLayout(false);
            this.xTabPrivilege.ResumeLayout(false);
            this.xTabPrivilege.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditPrivilege.Properties)).EndInit();
            this.xTabCompanyAccess.ResumeLayout(false);
            this.xTabCompanyAccess.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditCompany2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCompanyAccess)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCompanyAccess)).EndInit();
            this.xTabEstablishmentAccess.ResumeLayout(false);
            this.xTabEstablishmentAccess.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditEstablishment2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlEstablishment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEstablishment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditEstablishment.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAdmin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumbering.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpUser;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpSave;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStat;
        private DevExpress.XtraBars.BarButtonItem barSave;
        private DevExpress.XtraBars.BarButtonItem barClose;
        private DevExpress.XtraBars.BarButtonItem barFirst;
        private DevExpress.XtraBars.BarButtonItem barPrevious;
        private DevExpress.XtraBars.BarButtonItem barNext;
        private DevExpress.XtraBars.BarButtonItem barLast;
        private DevExpress.XtraBars.BarButtonItem barSeparator;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpTools;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpClose;
        private DevExpress.XtraEditors.TextEdit txtUserName;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtPassword;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtConfirmPassword;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditCompany;
        private DevExpress.XtraEditors.CheckEdit chkActivate;
        private DevExpress.XtraEditors.LabelControl labelControlAccountType;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditAccountType;
        private DevExpress.XtraGrid.GridControl gridControlUserPrivileges;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewUserPrivileges;
        private DevExpress.XtraTab.XtraTabControl xtraTabControlUser;
        private DevExpress.XtraTab.XtraTabPage xTabPrivilege;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditPrivilege;
        private DevExpress.XtraTab.XtraTabPage xTabCompanyAccess;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditCompany2;
        private DevExpress.XtraGrid.GridControl gridControlCompanyAccess;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewCompanyAccess;
        private DevExpress.XtraTab.XtraTabPage xTabEstablishmentAccess;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditEstablishment2;
        private DevExpress.XtraGrid.GridControl gridControlEstablishment;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewEstablishment;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditEstablishment;
        private DevExpress.XtraBars.BarEditItem barSearch;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchControl repositoryItemSearchControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpSearch;
        private DevExpress.XtraBars.BarButtonItem barNew;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpNew;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnid;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnVoid;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnMapId;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnAction;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnGrant;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnCompanyId;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnCompany;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnAddress;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnOwner;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnEstId;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnEstablishment;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnShortName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraEditors.CheckEdit chkAdmin;
        private DevExpress.XtraEditors.TextEdit txtNumbering;
        private DevExpress.XtraEditors.LabelControl labelControl5;
    }
}