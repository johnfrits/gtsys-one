namespace GTSysOne.Gui.Main
{
    partial class frmLogIn
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogIn));
            this.txtServerName = new DevExpress.XtraEditors.TextEdit();
            this.txtDatabase = new DevExpress.XtraEditors.TextEdit();
            this.txtLogIn = new DevExpress.XtraEditors.TextEdit();
            this.txtPassword = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.lookupEditAuthentication = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtUserPassword = new DevExpress.XtraEditors.TextEdit();
            this.txtUserName = new DevExpress.XtraEditors.TextEdit();
            this.lookUpEditCompany = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.pnlAccount = new DevExpress.XtraEditors.PanelControl();
            this.chkPNLAccountShowPassword = new DevExpress.XtraEditors.CheckEdit();
            this.lnkCreateAdministrator = new System.Windows.Forms.LinkLabel();
            this.pnlDatabase = new DevExpress.XtraEditors.PanelControl();
            this.pnlDatabaseShowPassword = new DevExpress.XtraEditors.CheckEdit();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnHelp = new DevExpress.XtraEditors.SimpleButton();
            this.btnOption = new DevExpress.XtraEditors.SimpleButton();
            this.btnConnect = new DevExpress.XtraEditors.SimpleButton();
            this.btnNewUser = new DevExpress.XtraEditors.SimpleButton();
            this.tmrLogIn = new System.Windows.Forms.Timer(this.components);
            this.bgWorkerLogIn = new System.ComponentModel.BackgroundWorker();
            this.prgLoadingInstance = new System.Windows.Forms.ProgressBar();
            this.bgWorker = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.txtServerName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDatabase.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLogIn.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookupEditAuthentication.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditCompany.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlAccount)).BeginInit();
            this.pnlAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkPNLAccountShowPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlDatabase)).BeginInit();
            this.pnlDatabase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlDatabaseShowPassword.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtServerName
            // 
            this.txtServerName.Location = new System.Drawing.Point(119, 5);
            this.txtServerName.Name = "txtServerName";
            this.txtServerName.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServerName.Properties.Appearance.Options.UseFont = true;
            this.txtServerName.Properties.NullValuePrompt = "Server name";
            this.txtServerName.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtServerName.Size = new System.Drawing.Size(325, 22);
            this.txtServerName.TabIndex = 0;
            // 
            // txtDatabase
            // 
            this.txtDatabase.Location = new System.Drawing.Point(119, 28);
            this.txtDatabase.Name = "txtDatabase";
            this.txtDatabase.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDatabase.Properties.Appearance.Options.UseFont = true;
            this.txtDatabase.Properties.NullValuePrompt = "Database";
            this.txtDatabase.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtDatabase.Size = new System.Drawing.Size(325, 22);
            this.txtDatabase.TabIndex = 1;
            // 
            // txtLogIn
            // 
            this.txtLogIn.Location = new System.Drawing.Point(119, 78);
            this.txtLogIn.Name = "txtLogIn";
            this.txtLogIn.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogIn.Properties.Appearance.Options.UseFont = true;
            this.txtLogIn.Properties.NullValuePrompt = "Login";
            this.txtLogIn.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtLogIn.Size = new System.Drawing.Size(325, 22);
            this.txtLogIn.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(119, 102);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Properties.Appearance.Options.UseFont = true;
            this.txtPassword.Properties.UseSystemPasswordChar = true;
            this.txtPassword.Size = new System.Drawing.Size(325, 22);
            this.txtPassword.TabIndex = 3;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(11, 8);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(80, 16);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Server name:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(11, 32);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(63, 16);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Database:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(11, 79);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(36, 16);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Login:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Location = new System.Drawing.Point(11, 102);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(63, 16);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "Password:";
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(8, -1);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(184, 54);
            this.pictureEdit1.TabIndex = 8;
            // 
            // lookupEditAuthentication
            // 
            this.lookupEditAuthentication.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lookupEditAuthentication.Location = new System.Drawing.Point(119, 51);
            this.lookupEditAuthentication.Name = "lookupEditAuthentication";
            this.lookupEditAuthentication.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lookupEditAuthentication.Properties.Appearance.Options.UseFont = true;
            this.lookupEditAuthentication.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookupEditAuthentication.Properties.NullText = "";
            this.lookupEditAuthentication.Properties.NullValuePrompt = "Authentication";
            this.lookupEditAuthentication.Properties.NullValuePromptShowForEmptyValue = true;
            this.lookupEditAuthentication.Size = new System.Drawing.Size(325, 22);
            this.lookupEditAuthentication.TabIndex = 9;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Location = new System.Drawing.Point(11, 53);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(86, 16);
            this.labelControl5.TabIndex = 10;
            this.labelControl5.Text = "Authentication:";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Location = new System.Drawing.Point(12, 80);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(63, 16);
            this.labelControl6.TabIndex = 14;
            this.labelControl6.Text = "Password:";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Location = new System.Drawing.Point(12, 56);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(66, 16);
            this.labelControl7.TabIndex = 13;
            this.labelControl7.Text = "Username:";
            // 
            // txtUserPassword
            // 
            this.txtUserPassword.Location = new System.Drawing.Point(120, 80);
            this.txtUserPassword.Name = "txtUserPassword";
            this.txtUserPassword.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserPassword.Properties.Appearance.Options.UseFont = true;
            this.txtUserPassword.Properties.UseSystemPasswordChar = true;
            this.txtUserPassword.Size = new System.Drawing.Size(325, 22);
            this.txtUserPassword.TabIndex = 12;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(120, 55);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Properties.Appearance.Options.UseFont = true;
            this.txtUserName.Properties.NullValuePrompt = "Username";
            this.txtUserName.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtUserName.Size = new System.Drawing.Size(325, 22);
            this.txtUserName.TabIndex = 11;
            // 
            // lookUpEditCompany
            // 
            this.lookUpEditCompany.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lookUpEditCompany.Location = new System.Drawing.Point(120, 20);
            this.lookUpEditCompany.Name = "lookUpEditCompany";
            this.lookUpEditCompany.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lookUpEditCompany.Properties.Appearance.Options.UseFont = true;
            this.lookUpEditCompany.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditCompany.Properties.NullText = "";
            this.lookUpEditCompany.Properties.NullValuePrompt = "Select Company";
            this.lookUpEditCompany.Properties.NullValuePromptShowForEmptyValue = true;
            this.lookUpEditCompany.Size = new System.Drawing.Size(325, 22);
            this.lookUpEditCompany.TabIndex = 15;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Location = new System.Drawing.Point(12, 21);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(61, 16);
            this.labelControl8.TabIndex = 16;
            this.labelControl8.Text = "Company:";
            // 
            // pnlAccount
            // 
            this.pnlAccount.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnlAccount.Controls.Add(this.chkPNLAccountShowPassword);
            this.pnlAccount.Controls.Add(this.lnkCreateAdministrator);
            this.pnlAccount.Controls.Add(this.txtUserPassword);
            this.pnlAccount.Controls.Add(this.labelControl8);
            this.pnlAccount.Controls.Add(this.txtUserName);
            this.pnlAccount.Controls.Add(this.lookUpEditCompany);
            this.pnlAccount.Controls.Add(this.labelControl7);
            this.pnlAccount.Controls.Add(this.labelControl6);
            this.pnlAccount.Location = new System.Drawing.Point(7, 54);
            this.pnlAccount.Name = "pnlAccount";
            this.pnlAccount.Size = new System.Drawing.Size(462, 148);
            this.pnlAccount.TabIndex = 17;
            // 
            // chkPNLAccountShowPassword
            // 
            this.chkPNLAccountShowPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkPNLAccountShowPassword.Location = new System.Drawing.Point(120, 106);
            this.chkPNLAccountShowPassword.Name = "chkPNLAccountShowPassword";
            this.chkPNLAccountShowPassword.Properties.Caption = "Show Password";
            this.chkPNLAccountShowPassword.Size = new System.Drawing.Size(190, 19);
            this.chkPNLAccountShowPassword.TabIndex = 18;
            // 
            // lnkCreateAdministrator
            // 
            this.lnkCreateAdministrator.AutoSize = true;
            this.lnkCreateAdministrator.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkCreateAdministrator.Location = new System.Drawing.Point(121, 129);
            this.lnkCreateAdministrator.Name = "lnkCreateAdministrator";
            this.lnkCreateAdministrator.Size = new System.Drawing.Size(332, 13);
            this.lnkCreateAdministrator.TabIndex = 17;
            this.lnkCreateAdministrator.TabStop = true;
            this.lnkCreateAdministrator.Text = "Have A Nice Day!!! Please Click me to Create Administrator Account";
            this.lnkCreateAdministrator.Visible = false;
            // 
            // pnlDatabase
            // 
            this.pnlDatabase.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnlDatabase.Controls.Add(this.pnlDatabaseShowPassword);
            this.pnlDatabase.Controls.Add(this.lookupEditAuthentication);
            this.pnlDatabase.Controls.Add(this.txtServerName);
            this.pnlDatabase.Controls.Add(this.labelControl5);
            this.pnlDatabase.Controls.Add(this.txtDatabase);
            this.pnlDatabase.Controls.Add(this.txtLogIn);
            this.pnlDatabase.Controls.Add(this.labelControl4);
            this.pnlDatabase.Controls.Add(this.txtPassword);
            this.pnlDatabase.Controls.Add(this.labelControl3);
            this.pnlDatabase.Controls.Add(this.labelControl1);
            this.pnlDatabase.Controls.Add(this.labelControl2);
            this.pnlDatabase.Location = new System.Drawing.Point(7, 54);
            this.pnlDatabase.Name = "pnlDatabase";
            this.pnlDatabase.Size = new System.Drawing.Size(462, 148);
            this.pnlDatabase.TabIndex = 18;
            this.pnlDatabase.Visible = false;
            // 
            // pnlDatabaseShowPassword
            // 
            this.pnlDatabaseShowPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlDatabaseShowPassword.Location = new System.Drawing.Point(119, 126);
            this.pnlDatabaseShowPassword.Name = "pnlDatabaseShowPassword";
            this.pnlDatabaseShowPassword.Properties.Caption = "Show Password";
            this.pnlDatabaseShowPassword.Size = new System.Drawing.Size(145, 19);
            this.pnlDatabaseShowPassword.TabIndex = 19;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(221, 212);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 27);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "Cancel";
            // 
            // btnHelp
            // 
            this.btnHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHelp.Image = ((System.Drawing.Image)(resources.GetObject("btnHelp.Image")));
            this.btnHelp.Location = new System.Drawing.Point(297, 212);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(75, 27);
            this.btnHelp.TabIndex = 20;
            this.btnHelp.Text = "Help";
            // 
            // btnOption
            // 
            this.btnOption.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOption.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOption.Image = ((System.Drawing.Image)(resources.GetObject("btnOption.Image")));
            this.btnOption.Location = new System.Drawing.Point(373, 212);
            this.btnOption.Name = "btnOption";
            this.btnOption.Size = new System.Drawing.Size(96, 27);
            this.btnOption.TabIndex = 21;
            this.btnOption.Tag = "Option >>>";
            this.btnOption.Text = "Options >>>";
            // 
            // btnConnect
            // 
            this.btnConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConnect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConnect.Image = ((System.Drawing.Image)(resources.GetObject("btnConnect.Image")));
            this.btnConnect.Location = new System.Drawing.Point(118, 212);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(102, 27);
            this.btnConnect.TabIndex = 22;
            this.btnConnect.Text = "Connect";
            // 
            // btnNewUser
            // 
            this.btnNewUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNewUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewUser.Image = ((System.Drawing.Image)(resources.GetObject("btnNewUser.Image")));
            this.btnNewUser.Location = new System.Drawing.Point(8, 212);
            this.btnNewUser.Name = "btnNewUser";
            this.btnNewUser.Size = new System.Drawing.Size(92, 27);
            this.btnNewUser.TabIndex = 23;
            this.btnNewUser.Text = "New User";
            // 
            // prgLoadingInstance
            // 
            this.prgLoadingInstance.Location = new System.Drawing.Point(211, 30);
            this.prgLoadingInstance.Name = "prgLoadingInstance";
            this.prgLoadingInstance.Size = new System.Drawing.Size(256, 23);
            this.prgLoadingInstance.TabIndex = 24;
            this.prgLoadingInstance.Visible = false;
            // 
            // frmLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 251);
            this.Controls.Add(this.prgLoadingInstance);
            this.Controls.Add(this.btnNewUser);
            this.Controls.Add(this.pnlAccount);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.btnOption);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.pnlDatabase);
            this.Controls.Add(this.pictureEdit1);
            this.DoubleBuffered = true;
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogIn";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Security™";
            ((System.ComponentModel.ISupportInitialize)(this.txtServerName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDatabase.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLogIn.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookupEditAuthentication.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditCompany.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlAccount)).EndInit();
            this.pnlAccount.ResumeLayout(false);
            this.pnlAccount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkPNLAccountShowPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlDatabase)).EndInit();
            this.pnlDatabase.ResumeLayout(false);
            this.pnlDatabase.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlDatabaseShowPassword.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtServerName;
        private DevExpress.XtraEditors.TextEdit txtDatabase;
        private DevExpress.XtraEditors.TextEdit txtLogIn;
        private DevExpress.XtraEditors.TextEdit txtPassword;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.LookUpEdit lookupEditAuthentication;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtUserPassword;
        private DevExpress.XtraEditors.TextEdit txtUserName;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditCompany;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.PanelControl pnlAccount;
        private DevExpress.XtraEditors.PanelControl pnlDatabase;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnHelp;
        private DevExpress.XtraEditors.SimpleButton btnOption;
        private DevExpress.XtraEditors.SimpleButton btnConnect;
        private DevExpress.XtraEditors.CheckEdit chkPNLAccountShowPassword;
        private System.Windows.Forms.LinkLabel lnkCreateAdministrator;
        private DevExpress.XtraEditors.CheckEdit pnlDatabaseShowPassword;
        private DevExpress.XtraEditors.SimpleButton btnNewUser;
        private System.Windows.Forms.Timer tmrLogIn;
        private System.ComponentModel.BackgroundWorker bgWorkerLogIn;
        private System.Windows.Forms.ProgressBar prgLoadingInstance;
        private System.ComponentModel.BackgroundWorker bgWorker;
    }
}