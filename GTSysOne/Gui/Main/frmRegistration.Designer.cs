namespace GTSysOne.Gui.Main
{
    partial class frmRegistration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistration));
            this.xTabControlMain = new DevExpress.XtraTab.XtraTabControl();
            this.xTabSetupType = new DevExpress.XtraTab.XtraTabPage();
            this.radSetup = new DevExpress.XtraEditors.RadioGroup();
            this.xTabCompany = new DevExpress.XtraTab.XtraTabPage();
            this.btnEditCompany = new DevExpress.XtraEditors.ButtonEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.xTabEstablishment = new DevExpress.XtraTab.XtraTabPage();
            this.chkIDontWantToAddStation = new DevExpress.XtraEditors.CheckEdit();
            this.txtEstablsihmentAddress = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtEstablishmentShortName = new DevExpress.XtraEditors.TextEdit();
            this.txtEstablishmentName = new DevExpress.XtraEditors.TextEdit();
            this.xTabStation = new DevExpress.XtraTab.XtraTabPage();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.lookUpEditTheme = new DevExpress.XtraEditors.LookUpEdit();
            this.txtStationShortName = new DevExpress.XtraEditors.TextEdit();
            this.txtStationName = new DevExpress.XtraEditors.TextEdit();
            this.lookUpEditEstablishmentStation = new DevExpress.XtraEditors.LookUpEdit();
            this.lookUpEditCompanyStation = new DevExpress.XtraEditors.LookUpEdit();
            this.xTabLoadFile = new DevExpress.XtraTab.XtraTabPage();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btnLoadFile = new DevExpress.XtraEditors.ButtonEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnPrevious = new DevExpress.XtraEditors.SimpleButton();
            this.btnNext = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.lblGTSysWebsiteLink = new System.Windows.Forms.LinkLabel();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.xTabControlMain)).BeginInit();
            this.xTabControlMain.SuspendLayout();
            this.xTabSetupType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radSetup.Properties)).BeginInit();
            this.xTabCompany.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditCompany.Properties)).BeginInit();
            this.xTabEstablishment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkIDontWantToAddStation.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEstablsihmentAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEstablishmentShortName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEstablishmentName.Properties)).BeginInit();
            this.xTabStation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditTheme.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStationShortName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStationName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditEstablishmentStation.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditCompanyStation.Properties)).BeginInit();
            this.xTabLoadFile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnLoadFile.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // xTabControlMain
            // 
            this.xTabControlMain.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.xTabControlMain.Appearance.Options.UseFont = true;
            this.xTabControlMain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.xTabControlMain.Location = new System.Drawing.Point(21, 93);
            this.xTabControlMain.Name = "xTabControlMain";
            this.xTabControlMain.SelectedTabPage = this.xTabSetupType;
            this.xTabControlMain.Size = new System.Drawing.Size(740, 286);
            this.xTabControlMain.TabIndex = 0;
            this.xTabControlMain.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xTabSetupType,
            this.xTabCompany,
            this.xTabEstablishment,
            this.xTabStation,
            this.xTabLoadFile});
            // 
            // xTabSetupType
            // 
            this.xTabSetupType.Controls.Add(this.radSetup);
            this.xTabSetupType.Cursor = System.Windows.Forms.Cursors.Default;
            this.xTabSetupType.Image = ((System.Drawing.Image)(resources.GetObject("xTabSetupType.Image")));
            this.xTabSetupType.Name = "xTabSetupType";
            this.xTabSetupType.Size = new System.Drawing.Size(734, 255);
            this.xTabSetupType.Text = "Setup Type";
            // 
            // radSetup
            // 
            this.radSetup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radSetup.Location = new System.Drawing.Point(17, 14);
            this.radSetup.Name = "radSetup";
            this.radSetup.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.radSetup.Properties.Appearance.Options.UseBackColor = true;
            this.radSetup.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.radSetup.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Server | Head Quarter"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Establishment  (such as Store,Branch)"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Station (such as Computer unit used by the users)")});
            this.radSetup.Size = new System.Drawing.Size(531, 224);
            this.radSetup.TabIndex = 0;
            // 
            // xTabCompany
            // 
            this.xTabCompany.Controls.Add(this.btnEditCompany);
            this.xTabCompany.Controls.Add(this.labelControl2);
            this.xTabCompany.Cursor = System.Windows.Forms.Cursors.Default;
            this.xTabCompany.Image = ((System.Drawing.Image)(resources.GetObject("xTabCompany.Image")));
            this.xTabCompany.Name = "xTabCompany";
            this.xTabCompany.Size = new System.Drawing.Size(734, 255);
            this.xTabCompany.Text = "Company";
            // 
            // btnEditCompany
            // 
            this.btnEditCompany.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditCompany.Location = new System.Drawing.Point(114, 106);
            this.btnEditCompany.Name = "btnEditCompany";
            this.btnEditCompany.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.DropDown)});
            this.btnEditCompany.Properties.NullValuePrompt = "Please Select Company";
            this.btnEditCompany.Properties.NullValuePromptShowForEmptyValue = true;
            this.btnEditCompany.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.btnEditCompany.Size = new System.Drawing.Size(579, 20);
            this.btnEditCompany.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.labelControl2.Location = new System.Drawing.Point(45, 106);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(53, 15);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Company";
            // 
            // xTabEstablishment
            // 
            this.xTabEstablishment.Controls.Add(this.chkIDontWantToAddStation);
            this.xTabEstablishment.Controls.Add(this.txtEstablsihmentAddress);
            this.xTabEstablishment.Controls.Add(this.labelControl6);
            this.xTabEstablishment.Controls.Add(this.labelControl5);
            this.xTabEstablishment.Controls.Add(this.labelControl4);
            this.xTabEstablishment.Controls.Add(this.txtEstablishmentShortName);
            this.xTabEstablishment.Controls.Add(this.txtEstablishmentName);
            this.xTabEstablishment.Cursor = System.Windows.Forms.Cursors.Default;
            this.xTabEstablishment.Image = ((System.Drawing.Image)(resources.GetObject("xTabEstablishment.Image")));
            this.xTabEstablishment.Name = "xTabEstablishment";
            this.xTabEstablishment.Size = new System.Drawing.Size(734, 255);
            this.xTabEstablishment.Text = "Establishment";
            // 
            // chkIDontWantToAddStation
            // 
            this.chkIDontWantToAddStation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkIDontWantToAddStation.Location = new System.Drawing.Point(122, 189);
            this.chkIDontWantToAddStation.Name = "chkIDontWantToAddStation";
            this.chkIDontWantToAddStation.Properties.Caption = "I Dont want to Add station for this establishment right now";
            this.chkIDontWantToAddStation.Size = new System.Drawing.Size(331, 19);
            this.chkIDontWantToAddStation.TabIndex = 3;
            // 
            // txtEstablsihmentAddress
            // 
            this.txtEstablsihmentAddress.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtEstablsihmentAddress.Location = new System.Drawing.Point(122, 52);
            this.txtEstablsihmentAddress.Name = "txtEstablsihmentAddress";
            this.txtEstablsihmentAddress.Properties.NullValuePrompt = "Address";
            this.txtEstablsihmentAddress.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtEstablsihmentAddress.Size = new System.Drawing.Size(420, 106);
            this.txtEstablsihmentAddress.TabIndex = 1;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(19, 61);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(39, 13);
            this.labelControl6.TabIndex = 4;
            this.labelControl6.Text = "Address";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(19, 162);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(53, 13);
            this.labelControl5.TabIndex = 3;
            this.labelControl5.Text = "ShortName";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(19, 34);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(27, 13);
            this.labelControl4.TabIndex = 2;
            this.labelControl4.Text = "Name";
            // 
            // txtEstablishmentShortName
            // 
            this.txtEstablishmentShortName.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtEstablishmentShortName.Location = new System.Drawing.Point(122, 159);
            this.txtEstablishmentShortName.Name = "txtEstablishmentShortName";
            this.txtEstablishmentShortName.Properties.MaxLength = 4;
            this.txtEstablishmentShortName.Size = new System.Drawing.Size(420, 20);
            this.txtEstablishmentShortName.TabIndex = 2;
            // 
            // txtEstablishmentName
            // 
            this.txtEstablishmentName.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtEstablishmentName.Location = new System.Drawing.Point(122, 31);
            this.txtEstablishmentName.Name = "txtEstablishmentName";
            this.txtEstablishmentName.Properties.MaxLength = 100;
            this.txtEstablishmentName.Properties.NullValuePrompt = "Add Establishment Name";
            this.txtEstablishmentName.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtEstablishmentName.Size = new System.Drawing.Size(420, 20);
            this.txtEstablishmentName.TabIndex = 0;
            // 
            // xTabStation
            // 
            this.xTabStation.Controls.Add(this.labelControl12);
            this.xTabStation.Controls.Add(this.labelControl10);
            this.xTabStation.Controls.Add(this.labelControl9);
            this.xTabStation.Controls.Add(this.labelControl8);
            this.xTabStation.Controls.Add(this.labelControl7);
            this.xTabStation.Controls.Add(this.lookUpEditTheme);
            this.xTabStation.Controls.Add(this.txtStationShortName);
            this.xTabStation.Controls.Add(this.txtStationName);
            this.xTabStation.Controls.Add(this.lookUpEditEstablishmentStation);
            this.xTabStation.Controls.Add(this.lookUpEditCompanyStation);
            this.xTabStation.Cursor = System.Windows.Forms.Cursors.Default;
            this.xTabStation.Image = ((System.Drawing.Image)(resources.GetObject("xTabStation.Image")));
            this.xTabStation.Name = "xTabStation";
            this.xTabStation.Size = new System.Drawing.Size(734, 255);
            this.xTabStation.Text = "Station";
            // 
            // labelControl12
            // 
            this.labelControl12.Location = new System.Drawing.Point(59, 182);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(32, 13);
            this.labelControl12.TabIndex = 11;
            this.labelControl12.Text = "Theme";
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(59, 115);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(56, 13);
            this.labelControl10.TabIndex = 9;
            this.labelControl10.Text = "Short Name";
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(59, 93);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(27, 13);
            this.labelControl9.TabIndex = 8;
            this.labelControl9.Text = "Name";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(59, 159);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(66, 13);
            this.labelControl8.TabIndex = 7;
            this.labelControl8.Text = "Establishment";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(59, 137);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(45, 13);
            this.labelControl7.TabIndex = 6;
            this.labelControl7.Text = "Company";
            // 
            // lookUpEditTheme
            // 
            this.lookUpEditTheme.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lookUpEditTheme.Location = new System.Drawing.Point(180, 179);
            this.lookUpEditTheme.Name = "lookUpEditTheme";
            this.lookUpEditTheme.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditTheme.Properties.NullText = "";
            this.lookUpEditTheme.Size = new System.Drawing.Size(439, 20);
            this.lookUpEditTheme.TabIndex = 5;
            // 
            // txtStationShortName
            // 
            this.txtStationShortName.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtStationShortName.Location = new System.Drawing.Point(180, 112);
            this.txtStationShortName.Name = "txtStationShortName";
            this.txtStationShortName.Properties.MaxLength = 4;
            this.txtStationShortName.Size = new System.Drawing.Size(439, 20);
            this.txtStationShortName.TabIndex = 3;
            // 
            // txtStationName
            // 
            this.txtStationName.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtStationName.Location = new System.Drawing.Point(180, 90);
            this.txtStationName.Name = "txtStationName";
            this.txtStationName.Properties.NullValuePrompt = "Add Station Name";
            this.txtStationName.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtStationName.Size = new System.Drawing.Size(439, 20);
            this.txtStationName.TabIndex = 2;
            // 
            // lookUpEditEstablishmentStation
            // 
            this.lookUpEditEstablishmentStation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lookUpEditEstablishmentStation.Location = new System.Drawing.Point(180, 156);
            this.lookUpEditEstablishmentStation.Name = "lookUpEditEstablishmentStation";
            this.lookUpEditEstablishmentStation.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditEstablishmentStation.Properties.NullText = "";
            this.lookUpEditEstablishmentStation.Size = new System.Drawing.Size(439, 20);
            this.lookUpEditEstablishmentStation.TabIndex = 1;
            // 
            // lookUpEditCompanyStation
            // 
            this.lookUpEditCompanyStation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lookUpEditCompanyStation.Location = new System.Drawing.Point(180, 134);
            this.lookUpEditCompanyStation.Name = "lookUpEditCompanyStation";
            this.lookUpEditCompanyStation.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditCompanyStation.Properties.NullText = "";
            this.lookUpEditCompanyStation.Size = new System.Drawing.Size(439, 20);
            this.lookUpEditCompanyStation.TabIndex = 0;
            
            // 
            // xTabLoadFile
            // 
            this.xTabLoadFile.Controls.Add(this.labelControl3);
            this.xTabLoadFile.Controls.Add(this.btnLoadFile);
            this.xTabLoadFile.Cursor = System.Windows.Forms.Cursors.Default;
            this.xTabLoadFile.Image = ((System.Drawing.Image)(resources.GetObject("xTabLoadFile.Image")));
            this.xTabLoadFile.Name = "xTabLoadFile";
            this.xTabLoadFile.Size = new System.Drawing.Size(734, 255);
            this.xTabLoadFile.Text = "Load File";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(29, 105);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(47, 13);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "Browse...";
            // 
            // btnLoadFile
            // 
            this.btnLoadFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoadFile.Location = new System.Drawing.Point(91, 104);
            this.btnLoadFile.Name = "btnLoadFile";
            this.btnLoadFile.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.btnLoadFile.Properties.NullValuePrompt = "Please Browse GTSysOne License";
            this.btnLoadFile.Properties.NullValuePromptShowForEmptyValue = true;
            this.btnLoadFile.Size = new System.Drawing.Size(584, 20);
            this.btnLoadFile.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("labelControl1.Appearance.Image")));
            this.labelControl1.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelControl1.Location = new System.Drawing.Point(255, 8);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(301, 32);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "      GTSysOne License Key Activation";
            // 
            // btnPrevious
            // 
            this.btnPrevious.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.Appearance.Options.UseFont = true;
            this.btnPrevious.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrevious.Location = new System.Drawing.Point(411, 394);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(114, 30);
            this.btnPrevious.TabIndex = 0;
            this.btnPrevious.Text = "<<< Previous";
            // 
            // btnNext
            // 
            this.btnNext.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Appearance.Options.UseFont = true;
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.Location = new System.Drawing.Point(527, 394);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(114, 30);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "Next >>";
            // 
            // btnClose
            // 
            this.btnClose.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Appearance.Options.UseFont = true;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Location = new System.Drawing.Point(643, 394);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(114, 30);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            // 
            // lblGTSysWebsiteLink
            // 
            this.lblGTSysWebsiteLink.AutoSize = true;
            this.lblGTSysWebsiteLink.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lblGTSysWebsiteLink.Location = new System.Drawing.Point(44, 411);
            this.lblGTSysWebsiteLink.Name = "lblGTSysWebsiteLink";
            this.lblGTSysWebsiteLink.Size = new System.Drawing.Size(97, 13);
            this.lblGTSysWebsiteLink.TabIndex = 7;
            this.lblGTSysWebsiteLink.TabStop = true;
            this.lblGTSysWebsiteLink.Text = "www.gtsys.com.jo";
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(22, 411);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(22, 13);
            this.labelControl11.TabIndex = 8;
            this.labelControl11.Text = "Visit ";
            // 
            // labelControl13
            // 
            this.labelControl13.Location = new System.Drawing.Point(144, 411);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(66, 13);
            this.labelControl13.TabIndex = 9;
            this.labelControl13.Text = "for more info.";
            // 
            // frmRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 443);
            this.Controls.Add(this.labelControl13);
            this.Controls.Add(this.labelControl11);
            this.Controls.Add(this.lblGTSysWebsiteLink);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.xTabControlMain);
            this.DoubleBuffered = true;
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmRegistration";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration";
            ((System.ComponentModel.ISupportInitialize)(this.xTabControlMain)).EndInit();
            this.xTabControlMain.ResumeLayout(false);
            this.xTabSetupType.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radSetup.Properties)).EndInit();
            this.xTabCompany.ResumeLayout(false);
            this.xTabCompany.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditCompany.Properties)).EndInit();
            this.xTabEstablishment.ResumeLayout(false);
            this.xTabEstablishment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkIDontWantToAddStation.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEstablsihmentAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEstablishmentShortName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEstablishmentName.Properties)).EndInit();
            this.xTabStation.ResumeLayout(false);
            this.xTabStation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditTheme.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStationShortName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStationName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditEstablishmentStation.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditCompanyStation.Properties)).EndInit();
            this.xTabLoadFile.ResumeLayout(false);
            this.xTabLoadFile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnLoadFile.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xTabControlMain;
        private DevExpress.XtraTab.XtraTabPage xTabSetupType;
        private DevExpress.XtraTab.XtraTabPage xTabEstablishment;
        private DevExpress.XtraTab.XtraTabPage xTabStation;
        private DevExpress.XtraTab.XtraTabPage xTabLoadFile;
        private DevExpress.XtraEditors.RadioGroup radSetup;
        private DevExpress.XtraTab.XtraTabPage xTabCompany;
        private DevExpress.XtraEditors.ButtonEdit btnEditCompany;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.CheckEdit chkIDontWantToAddStation;
        private DevExpress.XtraEditors.MemoEdit txtEstablsihmentAddress;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtEstablishmentShortName;
        private DevExpress.XtraEditors.TextEdit txtEstablishmentName;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditTheme;
        private DevExpress.XtraEditors.TextEdit txtStationShortName;
        private DevExpress.XtraEditors.TextEdit txtStationName;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditEstablishmentStation;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditCompanyStation;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.ButtonEdit btnLoadFile;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnPrevious;
        private DevExpress.XtraEditors.SimpleButton btnNext;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private System.Windows.Forms.LinkLabel lblGTSysWebsiteLink;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl13;
    }
}