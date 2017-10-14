namespace GTSysOne.Gui.Main
{
    partial class frmRecover
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRecover));
            this.xTabControlMain = new DevExpress.XtraTab.XtraTabControl();
            this.xTabGTSysOneServerSide = new DevExpress.XtraTab.XtraTabPage();
            this.radSetup = new DevExpress.XtraEditors.RadioGroup();
            this.lookUpEditAuthentication = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.btnVerifyPassword = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtPassword = new DevExpress.XtraEditors.TextEdit();
            this.txtLogin = new DevExpress.XtraEditors.TextEdit();
            this.txtDatabase = new DevExpress.XtraEditors.TextEdit();
            this.txtServerName = new DevExpress.XtraEditors.TextEdit();
            this.btnCorrect = new DevExpress.XtraEditors.SimpleButton();
            this.btnError = new DevExpress.XtraEditors.SimpleButton();
            this.btnVerify = new DevExpress.XtraEditors.SimpleButton();
            this.lblGTSysWebsiteLink = new System.Windows.Forms.LinkLabel();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtGTSysOneUnifiedKey = new DevExpress.XtraEditors.TextEdit();
            this.xTabEstablishment = new DevExpress.XtraTab.XtraTabPage();
            this.gridControlEstablishment = new DevExpress.XtraGrid.GridControl();
            this.gridViewEstablishment = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnESTId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnStationId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnShortName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnSELECT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.xTabStation = new DevExpress.XtraTab.XtraTabPage();
            this.gridControlStation = new DevExpress.XtraGrid.GridControl();
            this.gridViewStation = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnNext = new DevExpress.XtraEditors.SimpleButton();
            this.btnPrevious = new DevExpress.XtraEditors.SimpleButton();
            this.repositoryItemCheckEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.xTabControlMain)).BeginInit();
            this.xTabControlMain.SuspendLayout();
            this.xTabGTSysOneServerSide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radSetup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditAuthentication.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLogin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDatabase.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtServerName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGTSysOneUnifiedKey.Properties)).BeginInit();
            this.xTabEstablishment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlEstablishment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEstablishment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            this.xTabStation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlStation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewStation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).BeginInit();
            this.SuspendLayout();
            // 
            // xTabControlMain
            // 
            this.xTabControlMain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.xTabControlMain.Location = new System.Drawing.Point(21, 93);
            this.xTabControlMain.Name = "xTabControlMain";
            this.xTabControlMain.SelectedTabPage = this.xTabGTSysOneServerSide;
            this.xTabControlMain.Size = new System.Drawing.Size(740, 286);
            this.xTabControlMain.TabIndex = 0;
            this.xTabControlMain.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xTabGTSysOneServerSide,
            this.xTabEstablishment,
            this.xTabStation});
            // 
            // xTabGTSysOneServerSide
            // 
            this.xTabGTSysOneServerSide.Controls.Add(this.radSetup);
            this.xTabGTSysOneServerSide.Controls.Add(this.lookUpEditAuthentication);
            this.xTabGTSysOneServerSide.Controls.Add(this.labelControl10);
            this.xTabGTSysOneServerSide.Controls.Add(this.btnVerifyPassword);
            this.xTabGTSysOneServerSide.Controls.Add(this.labelControl9);
            this.xTabGTSysOneServerSide.Controls.Add(this.labelControl8);
            this.xTabGTSysOneServerSide.Controls.Add(this.labelControl7);
            this.xTabGTSysOneServerSide.Controls.Add(this.labelControl6);
            this.xTabGTSysOneServerSide.Controls.Add(this.labelControl5);
            this.xTabGTSysOneServerSide.Controls.Add(this.txtPassword);
            this.xTabGTSysOneServerSide.Controls.Add(this.txtLogin);
            this.xTabGTSysOneServerSide.Controls.Add(this.txtDatabase);
            this.xTabGTSysOneServerSide.Controls.Add(this.txtServerName);
            this.xTabGTSysOneServerSide.Controls.Add(this.btnCorrect);
            this.xTabGTSysOneServerSide.Controls.Add(this.btnError);
            this.xTabGTSysOneServerSide.Controls.Add(this.btnVerify);
            this.xTabGTSysOneServerSide.Controls.Add(this.labelControl2);
            this.xTabGTSysOneServerSide.Controls.Add(this.txtGTSysOneUnifiedKey);
            this.xTabGTSysOneServerSide.Cursor = System.Windows.Forms.Cursors.Default;
            this.xTabGTSysOneServerSide.Image = ((System.Drawing.Image)(resources.GetObject("xTabGTSysOneServerSide.Image")));
            this.xTabGTSysOneServerSide.Name = "xTabGTSysOneServerSide";
            this.xTabGTSysOneServerSide.Size = new System.Drawing.Size(734, 255);
            this.xTabGTSysOneServerSide.Text = "GTSysOne Server Side";
            // 
            // radSetup
            // 
            this.radSetup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radSetup.Location = new System.Drawing.Point(158, 172);
            this.radSetup.Name = "radSetup";
            this.radSetup.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.radSetup.Properties.Appearance.Options.UseBackColor = true;
            this.radSetup.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.radSetup.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Server | Head Quarter"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Establishment  (such as Store,Branch)"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Station (such as Computer unit used by the users)")});
            this.radSetup.Size = new System.Drawing.Size(361, 78);
            this.radSetup.TabIndex = 1;
            // 
            // lookUpEditAuthentication
            // 
            this.lookUpEditAuthentication.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lookUpEditAuthentication.Location = new System.Drawing.Point(158, 90);
            this.lookUpEditAuthentication.Name = "lookUpEditAuthentication";
            this.lookUpEditAuthentication.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.lookUpEditAuthentication.Properties.Appearance.Options.UseFont = true;
            this.lookUpEditAuthentication.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditAuthentication.Properties.NullText = "";
            this.lookUpEditAuthentication.Properties.NullValuePrompt = "Authentication";
            this.lookUpEditAuthentication.Properties.NullValuePromptShowForEmptyValue = true;
            this.lookUpEditAuthentication.Size = new System.Drawing.Size(361, 24);
            this.lookUpEditAuthentication.TabIndex = 22;
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(23, 196);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(73, 13);
            this.labelControl10.TabIndex = 21;
            this.labelControl10.Text = "Recovery Type";
            // 
            // btnVerifyPassword
            // 
            this.btnVerifyPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerifyPassword.Image = ((System.Drawing.Image)(resources.GetObject("btnVerifyPassword.Image")));
            this.btnVerifyPassword.Location = new System.Drawing.Point(519, 141);
            this.btnVerifyPassword.Name = "btnVerifyPassword";
            this.btnVerifyPassword.Size = new System.Drawing.Size(26, 25);
            this.btnVerifyPassword.TabIndex = 20;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(26, 146);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(46, 13);
            this.labelControl9.TabIndex = 19;
            this.labelControl9.Text = "Password";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(26, 122);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(25, 13);
            this.labelControl8.TabIndex = 18;
            this.labelControl8.Text = "Login";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(26, 96);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(70, 13);
            this.labelControl7.TabIndex = 17;
            this.labelControl7.Text = "Authentication";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(26, 68);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(46, 13);
            this.labelControl6.TabIndex = 16;
            this.labelControl6.Text = "Database";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(26, 42);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(61, 13);
            this.labelControl5.TabIndex = 15;
            this.labelControl5.Text = "Server name";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(251, 142);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.txtPassword.Properties.Appearance.Options.UseFont = true;
            this.txtPassword.Properties.UseSystemPasswordChar = true;
            this.txtPassword.Size = new System.Drawing.Size(268, 24);
            this.txtPassword.TabIndex = 13;
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(251, 116);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.txtLogin.Properties.Appearance.Options.UseFont = true;
            this.txtLogin.Properties.NullValuePrompt = "Login";
            this.txtLogin.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtLogin.Size = new System.Drawing.Size(268, 24);
            this.txtLogin.TabIndex = 12;
            // 
            // txtDatabase
            // 
            this.txtDatabase.Location = new System.Drawing.Point(158, 63);
            this.txtDatabase.Name = "txtDatabase";
            this.txtDatabase.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.txtDatabase.Properties.Appearance.Options.UseFont = true;
            this.txtDatabase.Properties.NullValuePrompt = "Database";
            this.txtDatabase.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtDatabase.Size = new System.Drawing.Size(361, 24);
            this.txtDatabase.TabIndex = 11;
            // 
            // txtServerName
            // 
            this.txtServerName.Location = new System.Drawing.Point(158, 38);
            this.txtServerName.Name = "txtServerName";
            this.txtServerName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.txtServerName.Properties.Appearance.Options.UseFont = true;
            this.txtServerName.Properties.NullValuePrompt = "Server Name";
            this.txtServerName.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtServerName.Size = new System.Drawing.Size(361, 24);
            this.txtServerName.TabIndex = 10;
            // 
            // btnCorrect
            // 
            this.btnCorrect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCorrect.Image = ((System.Drawing.Image)(resources.GetObject("btnCorrect.Image")));
            this.btnCorrect.Location = new System.Drawing.Point(480, 219);
            this.btnCorrect.Name = "btnCorrect";
            this.btnCorrect.Size = new System.Drawing.Size(26, 25);
            this.btnCorrect.TabIndex = 9;
            this.btnCorrect.Visible = false;
            // 
            // btnError
            // 
            this.btnError.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnError.Image = ((System.Drawing.Image)(resources.GetObject("btnError.Image")));
            this.btnError.Location = new System.Drawing.Point(453, 219);
            this.btnError.Name = "btnError";
            this.btnError.Size = new System.Drawing.Size(26, 25);
            this.btnError.TabIndex = 8;
            this.btnError.Visible = false;
            // 
            // btnVerify
            // 
            this.btnVerify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerify.Image = ((System.Drawing.Image)(resources.GetObject("btnVerify.Image")));
            this.btnVerify.Location = new System.Drawing.Point(519, 10);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(26, 25);
            this.btnVerify.TabIndex = 7;
            // 
            // lblGTSysWebsiteLink
            // 
            this.lblGTSysWebsiteLink.AutoSize = true;
            this.lblGTSysWebsiteLink.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lblGTSysWebsiteLink.Location = new System.Drawing.Point(347, 427);
            this.lblGTSysWebsiteLink.Name = "lblGTSysWebsiteLink";
            this.lblGTSysWebsiteLink.Size = new System.Drawing.Size(97, 13);
            this.lblGTSysWebsiteLink.TabIndex = 6;
            this.lblGTSysWebsiteLink.TabStop = true;
            this.lblGTSysWebsiteLink.Text = "www.gtsys.com.jo";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(443, 427);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(66, 13);
            this.labelControl4.TabIndex = 5;
            this.labelControl4.Text = "for more info.";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(22, 427);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(325, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Note: For Unified Key please contact GTSysOne Administrator. Visit ";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(26, 14);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(107, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "GTSysOne Unified Key";
            // 
            // txtGTSysOneUnifiedKey
            // 
            this.txtGTSysOneUnifiedKey.Location = new System.Drawing.Point(158, 11);
            this.txtGTSysOneUnifiedKey.Name = "txtGTSysOneUnifiedKey";
            this.txtGTSysOneUnifiedKey.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGTSysOneUnifiedKey.Properties.Appearance.Options.UseFont = true;
            this.txtGTSysOneUnifiedKey.Properties.NullValuePrompt = "GTSysOne Unified Key";
            this.txtGTSysOneUnifiedKey.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtGTSysOneUnifiedKey.Properties.UseSystemPasswordChar = true;
            this.txtGTSysOneUnifiedKey.Size = new System.Drawing.Size(361, 24);
            this.txtGTSysOneUnifiedKey.TabIndex = 2;
            // 
            // xTabEstablishment
            // 
            this.xTabEstablishment.Controls.Add(this.gridControlEstablishment);
            this.xTabEstablishment.Image = ((System.Drawing.Image)(resources.GetObject("xTabEstablishment.Image")));
            this.xTabEstablishment.Name = "xTabEstablishment";
            this.xTabEstablishment.Size = new System.Drawing.Size(734, 255);
            this.xTabEstablishment.Text = "Establishment";
            // 
            // gridControlEstablishment
            // 
            this.gridControlEstablishment.Location = new System.Drawing.Point(5, 5);
            this.gridControlEstablishment.MainView = this.gridViewEstablishment;
            this.gridControlEstablishment.Name = "gridControlEstablishment";
            this.gridControlEstablishment.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.gridControlEstablishment.Size = new System.Drawing.Size(723, 246);
            this.gridControlEstablishment.TabIndex = 0;
            this.gridControlEstablishment.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewEstablishment});
            // 
            // gridViewEstablishment
            // 
            this.gridViewEstablishment.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnESTId,
            this.gridColumnStationId,
            this.gridColumnName,
            this.gridColumnShortName,
            this.gridColumnSELECT});
            this.gridViewEstablishment.GridControl = this.gridControlEstablishment;
            this.gridViewEstablishment.Name = "gridViewEstablishment";
            this.gridViewEstablishment.OptionsView.ColumnAutoWidth = false;
            this.gridViewEstablishment.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumnESTId
            // 
            this.gridColumnESTId.Caption = "ESTId";
            this.gridColumnESTId.FieldName = "ESTId";
            this.gridColumnESTId.Name = "gridColumnESTId";
            this.gridColumnESTId.OptionsColumn.AllowEdit = false;
            this.gridColumnESTId.OptionsColumn.AllowFocus = false;
            this.gridColumnESTId.OptionsColumn.ReadOnly = true;
            // 
            // gridColumnStationId
            // 
            this.gridColumnStationId.Caption = "StationId";
            this.gridColumnStationId.FieldName = "StationId";
            this.gridColumnStationId.Name = "gridColumnStationId";
            this.gridColumnStationId.OptionsColumn.AllowEdit = false;
            this.gridColumnStationId.OptionsColumn.AllowFocus = false;
            this.gridColumnStationId.OptionsColumn.ReadOnly = true;
            // 
            // gridColumnName
            // 
            this.gridColumnName.Caption = "Name";
            this.gridColumnName.FieldName = "Name";
            this.gridColumnName.Name = "gridColumnName";
            this.gridColumnName.OptionsColumn.AllowEdit = false;
            this.gridColumnName.OptionsColumn.AllowFocus = false;
            this.gridColumnName.OptionsColumn.ReadOnly = true;
            this.gridColumnName.Visible = true;
            this.gridColumnName.VisibleIndex = 0;
            this.gridColumnName.Width = 332;
            // 
            // gridColumnShortName
            // 
            this.gridColumnShortName.Caption = "ShortName";
            this.gridColumnShortName.FieldName = "ShortName";
            this.gridColumnShortName.Name = "gridColumnShortName";
            this.gridColumnShortName.OptionsColumn.AllowEdit = false;
            this.gridColumnShortName.OptionsColumn.AllowFocus = false;
            this.gridColumnShortName.OptionsColumn.ReadOnly = true;
            this.gridColumnShortName.Visible = true;
            this.gridColumnShortName.VisibleIndex = 1;
            this.gridColumnShortName.Width = 288;
            // 
            // gridColumnSELECT
            // 
            this.gridColumnSELECT.Caption = "SELECT";
            this.gridColumnSELECT.ColumnEdit = this.repositoryItemCheckEdit1;
            this.gridColumnSELECT.FieldName = "SELECT";
            this.gridColumnSELECT.Name = "gridColumnSELECT";
            this.gridColumnSELECT.Visible = true;
            this.gridColumnSELECT.VisibleIndex = 2;
            this.gridColumnSELECT.Width = 63;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // xTabStation
            // 
            this.xTabStation.Controls.Add(this.gridControlStation);
            this.xTabStation.Image = ((System.Drawing.Image)(resources.GetObject("xTabStation.Image")));
            this.xTabStation.Name = "xTabStation";
            this.xTabStation.Size = new System.Drawing.Size(734, 255);
            this.xTabStation.Text = "Station";
            // 
            // gridControlStation
            // 
            this.gridControlStation.Location = new System.Drawing.Point(5, 5);
            this.gridControlStation.MainView = this.gridViewStation;
            this.gridControlStation.Name = "gridControlStation";
            this.gridControlStation.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit2});
            this.gridControlStation.Size = new System.Drawing.Size(723, 246);
            this.gridControlStation.TabIndex = 1;
            this.gridControlStation.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewStation});
            // 
            // gridViewStation
            // 
            this.gridViewStation.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5});
            this.gridViewStation.GridControl = this.gridControlStation;
            this.gridViewStation.Name = "gridViewStation";
            this.gridViewStation.OptionsView.ColumnAutoWidth = false;
            this.gridViewStation.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "StationId";
            this.gridColumn2.FieldName = "StationId";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.OptionsColumn.AllowFocus = false;
            this.gridColumn2.OptionsColumn.ReadOnly = true;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Name";
            this.gridColumn3.FieldName = "Name";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.OptionsColumn.AllowFocus = false;
            this.gridColumn3.OptionsColumn.ReadOnly = true;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 0;
            this.gridColumn3.Width = 326;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "ShortName";
            this.gridColumn4.FieldName = "ShortName";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.OptionsColumn.AllowFocus = false;
            this.gridColumn4.OptionsColumn.ReadOnly = true;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 1;
            this.gridColumn4.Width = 295;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "SELECT";
            this.gridColumn5.ColumnEdit = this.repositoryItemCheckEdit2;
            this.gridColumn5.FieldName = "SELECT";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 2;
            this.gridColumn5.Width = 63;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("labelControl1.Appearance.Image")));
            this.labelControl1.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelControl1.Location = new System.Drawing.Point(255, 8);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(297, 32);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "      GTSysOne License Key Recovery";
            // 
            // btnClose
            // 
            this.btnClose.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Appearance.Options.UseFont = true;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Location = new System.Drawing.Point(643, 394);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(114, 30);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            // 
            // btnNext
            // 
            this.btnNext.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Appearance.Options.UseFont = true;
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.Location = new System.Drawing.Point(527, 394);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(114, 30);
            this.btnNext.TabIndex = 4;
            this.btnNext.Text = "Next >>";
            // 
            // btnPrevious
            // 
            this.btnPrevious.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.Appearance.Options.UseFont = true;
            this.btnPrevious.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrevious.Location = new System.Drawing.Point(411, 394);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(114, 30);
            this.btnPrevious.TabIndex = 3;
            this.btnPrevious.Text = "<<< Previous";
            // 
            // repositoryItemCheckEdit2
            // 
            this.repositoryItemCheckEdit2.AutoHeight = false;
            this.repositoryItemCheckEdit2.Name = "repositoryItemCheckEdit2";
            // 
            // frmRecover
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 443);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.xTabControlMain);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.lblGTSysWebsiteLink);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmRecover";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recover";
            ((System.ComponentModel.ISupportInitialize)(this.xTabControlMain)).EndInit();
            this.xTabControlMain.ResumeLayout(false);
            this.xTabGTSysOneServerSide.ResumeLayout(false);
            this.xTabGTSysOneServerSide.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radSetup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditAuthentication.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLogin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDatabase.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtServerName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGTSysOneUnifiedKey.Properties)).EndInit();
            this.xTabEstablishment.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlEstablishment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEstablishment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            this.xTabStation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlStation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewStation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xTabControlMain;
        private DevExpress.XtraTab.XtraTabPage xTabGTSysOneServerSide;
        private DevExpress.XtraTab.XtraTabPage xTabEstablishment;
        private DevExpress.XtraTab.XtraTabPage xTabStation;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnError;
        private DevExpress.XtraEditors.SimpleButton btnVerify;
        private System.Windows.Forms.LinkLabel lblGTSysWebsiteLink;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtGTSysOneUnifiedKey;
        private DevExpress.XtraEditors.RadioGroup radSetup;
        private DevExpress.XtraEditors.SimpleButton btnCorrect;
        private DevExpress.XtraEditors.SimpleButton btnVerifyPassword;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtPassword;
        private DevExpress.XtraEditors.TextEdit txtLogin;
        private DevExpress.XtraEditors.TextEdit txtDatabase;
        private DevExpress.XtraEditors.TextEdit txtServerName;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraGrid.GridControl gridControlEstablishment;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewEstablishment;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnESTId;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnStationId;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnShortName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnSELECT;
        private DevExpress.XtraGrid.GridControl gridControlStation;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewStation;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnNext;
        private DevExpress.XtraEditors.SimpleButton btnPrevious;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditAuthentication;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit2;
    }
}