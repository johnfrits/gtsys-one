namespace GTSysOne.Gui.Main
{
    public partial class frmLogIn : DevExpress.XtraEditors.XtraForm
    {
        bool hasnoAccount = false;
        int Counter = 0;
        bool Continue = false;
        public frmLogIn()
        {
            InitializeComponent();
            this.Shown += new System.EventHandler(this.SHOWN);
            this.Load += new System.EventHandler(this.LOAD);
            this.btnOption.Click += new System.EventHandler(this.OPTION);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KEYDOWN);

            this.btnCancel.Click += new System.EventHandler(this.CANCEL);
            this.btnConnect.Click += new System.EventHandler(this.CONNECT);

            this.btnNewUser.Click += new System.EventHandler(this.NEWUSER);
            this.bgWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWorker_DoWork);
            this.bgWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.LOADERWORKER);
            this.bgWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.LOADERDONE);
            this.lnkCreateAdministrator.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CREATEACCOUNT);
            this.bgWorkerLogIn.DoWork += new System.ComponentModel.DoWorkEventHandler(this.WORKER);
            this.bgWorkerLogIn.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.WORKERCOMPLETE);
            this.tmrLogIn.Tick += new System.EventHandler(this.TIMER);

            this.chkPNLAccountShowPassword.CheckedChanged += new System.EventHandler(this.SHOWPASS);
            this.pnlDatabaseShowPassword.CheckedChanged += new System.EventHandler(this.SHOWPASSDATABASE);
            

            System.Data.DataTable dt = new System.Data.DataTable();
            dt.Columns.Add("Id", typeof(bool));
            dt.Columns.Add("Name", typeof(string));
            dt.Rows.Add(true, "SQL Server Authentication");
            dt.Rows.Add(false, "Windows Authentication");
            GTSysOne.Class.Utility.clsUtility.createlookup(this.lookupEditAuthentication, dt, new string[] { "Name" }, "Id", "Name");

           

            GTSysOne.Class.Utility.clsGlobal.Instance().LogInAction = GTSysOne.Class.Utility.clsGlobal.myloginAction.LogIn;
            GTSysOne.Class.Utility.clsGlobal.Instance().Login = false;

            this.KeyPreview = true;
        }
        private void SwitchPanel(bool pnlDatabase,bool pnlAccount)
        {
            this.pnlAccount.Visible = pnlAccount;
            this.pnlDatabase.Visible = pnlDatabase;
            if (pnlDatabase)
            {
                this.btnOption.Tag = "<<< Option";
                this.btnOption.Text = "<<< Option";
                GTSysOne.Class.Utility.clsGlobal.Instance().LogInAction = GTSysOne.Class.Utility.clsGlobal.myloginAction.Options;
            }
            else
            {
                this.btnOption.Tag = "Option >>>";
                this.btnOption.Text = "Option >>>";
                GTSysOne.Class.Utility.clsGlobal.Instance().LogInAction = GTSysOne.Class.Utility.clsGlobal.myloginAction.LogIn;
            }
        }
        private void SHOWN(object sender, System.EventArgs e)
        {
            switch(GTSysOne.Class.Utility.clsGlobal.Instance().Connected)
            {
                case false:
                    this.btnOption.Tag = "Option >>>";
                    this.btnOption.Text = "Option >>>";
                    GTSysOne.Class.Utility.clsGlobal.Instance().LogInAction = GTSysOne.Class.Utility.clsGlobal.myloginAction.Options;
                    this.btnOption.PerformClick();
                break;
                case true:
                GTSysOne.Class.Utility.clsUtility.createlookup(this.lookUpEditCompany, GTSysOne.Class.Document.clsDoc_Company.ShowTable(GTSysOne.Class.Document.clsDoc_Company.Value(0, 0)), new string[] { "Name", "Address", "Owner" }, "id", "Name");
            
                hasnoAccount = System.Convert.ToBoolean(GTSysOne.Class.Document.clsDoc_User.ScalarValue(GTSysOne.Class.Document.clsDoc_User.Value(0, 0)));
                this.lookUpEditCompany.Focus();
                this.lnkCreateAdministrator.Visible = hasnoAccount;
                break;
            }
           
        }
        private void OPTION(object sender,System.EventArgs e)
        {
            if (System.Convert.ToString(this.btnOption.Tag).CompareTo("<<< Option") == 0)
            {
                this.SwitchPanel(false, true);
            }
            else if (System.Convert.ToString(this.btnOption.Tag).CompareTo("Option >>>") == 0)
            {
                //if (!GTSysOne.Class.Utility.clsGlobal.Instance().Connected)
                //{
                //    this.SwitchPanel(true, false);
                //    GTSysOne.Class.Utility.clsGlobal.Instance().LogInAction = GTSysOne.Class.Utility.clsGlobal.myloginAction.Options;
                //}
                //else
                //{
                //    this.SwitchPanel(false, true);
                //}
                this.SwitchPanel(true, false);
            }
        }
        private void KEYDOWN(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.Enter)
            {
                if (this.txtUserName.ContainsFocus)
                {
                    this.txtUserPassword.Focus();
                }
                else if (this.txtUserPassword.ContainsFocus)
                {
                    this.btnConnect.Focus();
                }
                else if (this.btnConnect.ContainsFocus)
                {
                    this.btnConnect.PerformClick();
                }
            }
        }
        private void LOAD(object sender, System.EventArgs e)
        {
            GTSysOne.Class.Utility.clsUtility.FaidIn(this, 20);
            this.btnNewUser.Visible = GTSysOne.Class.Utility.clsGlobal.Instance().System_Is_In_Sleep_Mode;
            this.btnNewUser.Enabled = !GTSysOne.Class.Utility.clsGlobal.Instance().System_Is_In_Sleep_Mode;
        }
        private void CANCEL(object sender, System.EventArgs e)
        {
            GTSysOne.Class.Utility.clsGlobal.Instance().Login = false;
            this.Close();
        }
        private void CONNECT(object sender, System.EventArgs e)
        {
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            switch (GTSysOne.Class.Utility.clsGlobal.Instance().LogInAction)
            {
                case GTSysOne.Class.Utility.clsGlobal.myloginAction.LogIn:
                    switch (GTSysOne.Class.Utility.clsGlobal.Instance().System_Is_In_Sleep_Mode)
                    {
                        case true:
                            this.WakeUp();
                            break;
                        default:
                            this.tmrLogIn.Start();
                            break;
                    }
                    break;
                case GTSysOne.Class.Utility.clsGlobal.myloginAction.Options:
                    this.CheckConnection(true, GTSysOne.Class.Utility.clsUtility.UpdateConnectionFile(this.txtServerName.Text, this.txtDatabase.Text, this.txtLogIn.Text, this.txtPassword.Text));
                    break;
            }
            this.Cursor = System.Windows.Forms.Cursors.Default;
        }
        private void WakeUp()
        {
            switch ((this.txtUserName.Text.CompareTo(GTSysOne.Class.Utility.clsGlobal.Instance().UserName) == 0
                && this.txtPassword.Text.CompareTo(GTSysOne.Class.Utility.clsEncryption.JayDhreiZIP.Decrypt(GTSysOne.Class.Utility.clsGlobal.Instance().Password, "")) == 0))
            {
                case true:
                    GTSysOne.Class.Utility.clsGlobal.Instance().Login = true;
                    this.Close();
                    break;
                default:
                    GTSysOne.Class.Utility.clsUtility.GTSysMessageBox(new string[] { "Invalid User Name || Password." }, GTSysOne.Class.Utility.clsGlobal.enMessageBoxButton.OK, GTSysOne.Class.Utility.clsGlobal.enMessageBoxIcon.Error);
                    break;
            }
        }
        private void CheckConnection(bool fromconfiguration = false, bool canConnect = false)
        {
            GTSysOne.Class.Utility.clsGlobal.Instance().Connected = canConnect;
            if (canConnect)
            {
                
                GTSysOne.Class.Utility.clsUtility.createlookup(this.lookUpEditCompany, GTSysOne.Class.Document.clsDoc_Company.ShowTable(GTSysOne.Class.Document.clsDoc_Company.Value(0, 0)), new string[] { "Name", "Address", "Owner" }, "id", "Name");
                this.btnOption.Tag = "<<< Option";
                if (fromconfiguration)
                {
                    GTSysOne.Class.Utility.clsGlobal.Instance().CloseFromLogIn = true;
                    GTSysOne.Class.Utility.clsGlobal.Instance().LogOut = true;
                    this.Close();
                }
            }
            else
            {
                this.btnOption.Tag = "Option >>>";
            }
        }
        private bool LOGIN()
        {
            bool R = false;
            System.Data.DataSet du = GTSysOne.Class.Document.clsDoc_User.ShowDataSet(GTSysOne.Class.Document.clsDoc_User.Value(0, 1, this.txtUserName.Text, GTSysOne.Class.Utility.clsEncryption.JayDhreiZIP.Encrypt(this.txtUserPassword.Text, ""),"0","0","0",System.Convert.ToString(this.lookUpEditCompany.EditValue)));
            if (du.Tables[0].Rows.Count > 0)
            {
                Continue = true;
                GTSysOne.Class.Utility.clsUtility.QueueUserInfoAndAccount(du);
                if (!GTSysOne.Class.Utility.clsGlobal.Instance().AccountRunning)
                {
                    //GTSysOne.Class.Utility.clsGlobal.Instance().TriggerLog(this.Text, "Successfully Logged In", true, true);
                }
                R = !GTSysOne.Class.Utility.clsGlobal.Instance().AccountRunning;
            }
            else
            {
                //GTSysOne.Class.Utility.clsGlobal.Instance().TriggerLog(this.Text, (hasnoAccount ? "The system has no admin account." : "Logged In failed with entry Username: " + this.txtUsername.Text + " Password: " + this.txtPassword.Text));
                R = false;
            }
            return R;
        }
        private void TIMER(object sender, System.EventArgs e)
        {
            if (Counter < 50)
            {
                if (Counter >= 48)
                {
                    if (Counter == 48 && GTSysOne.Class.Utility.clsGlobal.Instance().Login)
                    {
                        //if (GTSysOne.Class.Utility.clsGlobal.Instance().RETAIL)
                        //{
                        //    Classes.Utility.LOAD_SEARCH_ENGINE();
                        //}
                        //else
                        //{
                        //    modGlobal.modGlobal.Instance().DoneLoadingAllItems = true;
                        //}
                        Counter = 50;
                    }
                    //if (GTSysOne.Class.Utility.clsGlobal.Instance().DoneLoadingAllItems && GTSysOne.Class.Utility.clsGlobal.Instance().Login)
                    //{
                    //    Counter = 50;
                    //}
                    //else 
                    else if (!GTSysOne.Class.Utility.clsGlobal.Instance().Login)
                    {
                        Counter = 50;
                    }
                    else
                    {
                        Counter = 49;
                    }
                }
                else
                {
                    if (Counter == 0)
                    {
                        this.ControlBox = false;
                        //this.pctrLogInLoading.Visible = true;
                        //this.label1.BringToFront();
                        //this.label1.Visible = true;
                    }
                    Counter += 1;
                    if (Counter == 5)
                    {
                        if (this.bgWorkerLogIn.IsBusy == false)
                        {
                            this.bgWorkerLogIn.RunWorkerAsync();
                        }
                        Counter = 0;
                    }
                }
            }
            else
            {
                tmrLogIn.Stop();
                GTSysOne.Class.Utility.clsGlobal.Instance().IsAccountRunningHanging = false;
                if (GTSysOne.Class.Utility.clsGlobal.Instance().Login)
                {
                    GTSysOne.Class.Utility.clsUtility.UpdateRunningAccount(1);
                    this.Close();
                }
                else
                {
                    Counter = 0;
                    this.ControlBox = true;
                    this.txtUserName.Focus();
                    //this.pctrLogInLoading.Visible = false;
                    //this.label1.Visible = false;
                    this.lnkCreateAdministrator.Visible = hasnoAccount;

                    GTSysOne.Class.Utility.clsUtility.GTSysMessageBox(new string[] { 
                        (hasnoAccount
                        ? GTSysOne.Class.Utility.clsGlobal.Instance().MainHeaderVersion
                        + " has no ADMIN account.\nPlease create account first by clicking link below."
                        : (GTSysOne.Class.Utility.clsGlobal.Instance().AccountRunning
                        ? (GTSysOne.Class.Utility.clsGlobal.Instance().Admin
                        ? GTSysOne.Class.Utility.clsGlobal.Instance().Message_AccountRunning
                        + "\nAnd because your an Administrator you can continue to Log In."
                        : GTSysOne.Class.Utility.clsGlobal.Instance().Message_AccountRunning)
                        : GTSysOne.Class.Utility.clsGlobal.Instance().Message_InvalidAccount))
                    
                        }
                        , GTSysOne.Class.Utility.clsGlobal.enMessageBoxButton.OK, (GTSysOne.Class.Utility.clsGlobal.Instance().AccountRunning
                        ? (GTSysOne.Class.Utility.clsGlobal.Instance().Admin ? GTSysOne.Class.Utility.clsGlobal.enMessageBoxIcon.Error : GTSysOne.Class.Utility.clsGlobal.enMessageBoxIcon.Error)
                        : GTSysOne.Class.Utility.clsGlobal.enMessageBoxIcon.Error));

                    if (GTSysOne.Class.Utility.clsGlobal.Instance().AccountRunning && GTSysOne.Class.Utility.clsGlobal.Instance().Admin)
                    {
                        GTSysOne.Class.Utility.clsUtility.UpdateRunningAccount(1);
                        GTSysOne.Class.Utility.clsGlobal.Instance().Login = true;
                        this.Close();
                    }
                    else if (GTSysOne.Class.Utility.clsGlobal.Instance().AccountRunning && !GTSysOne.Class.Utility.clsGlobal.Instance().Admin)
                    {
                        GTSysOne.Class.Utility.clsGlobal.Instance().IsAccountRunningHanging = true;
                    }
                }
                GTSysOne.Class.Utility.clsUtility.GarbageCollectors();
            }
        }
        private void WORKER(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            GTSysOne.Class.Utility.clsGlobal.Instance().Login = this.LOGIN();
            if (Continue)
            {
                //Classes.Utility.LOAD_ALL_ITEMS();
            }
        }
        private void WORKERCOMPLETE(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            Counter = 48;
        }
        private void bgWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
        }
        private void LOADERWORKER(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            this.prgLoadingInstance.Value += 1;
        }
        private void LOADERDONE(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            this.prgLoadingInstance.Value = this.prgLoadingInstance.Maximum;
            GTSysOne.Class.Utility.clsUtility.DisplayConnectionFile(this.txtServerName, this.txtDatabase, this.txtLogIn, this.txtPassword, this.lookupEditAuthentication);
        }
        private void CREATEACCOUNT(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            GTSysOne.Gui.Document.frmUser.Instance.EnformStatus = Gui.Document.frmUser.enFormStatus.Add;
            GTSysOne.Gui.Document.frmUser.Instance.FromLogIn = true;
            GTSysOne.Gui.Document.frmUser.Instance.ShowDialog(this);
            this.lookUpEditCompany.EditValue = GTSysOne.Gui.Document.frmUser.Instance.NewCompany;
            this.txtUserName.Text = GTSysOne.Gui.Document.frmUser.Instance.NewUserName;
            this.txtUserPassword.Text = GTSysOne.Gui.Document.frmUser.Instance.NewPassword;
            this.lnkCreateAdministrator.Visible = false;
            this.btnConnect.PerformClick();
            GTSysOne.Gui.Document.frmUser.Instance.Dispose();
        }
        private void NEWUSER(object sender, System.EventArgs e)
        {
            switch (GTSysOne.Class.Utility.clsUtility.GTSysMessageBox(new string[]{"Are you sure you want to Log Out and Log In again as a new user?"
                 ,"Note: System will restart.\nIf you continue all current transaction(s) will be close."}
                 , GTSysOne.Class.Utility.clsGlobal.enMessageBoxButton.YesNo, GTSysOne.Class.Utility.clsGlobal.enMessageBoxIcon.Question))
            {
                case System.Windows.Forms.DialogResult.Yes:
                    GTSysOne.Class.Utility.clsGlobal.Instance().CloseFromLogIn = true;
                    GTSysOne.Class.Utility.clsGlobal.Instance().LogOut = true;
                    this.Close();
                    break;
            }
        }

        private void SHOWPASS(object sender, System.EventArgs e)
        {
            if (this.chkPNLAccountShowPassword.Checked)
            {
                this.txtUserPassword.Properties.UseSystemPasswordChar = false;
            }
            else
            {
                this.txtUserPassword.Properties.UseSystemPasswordChar = true;
            }
        }
        private void SHOWPASSDATABASE(object sender, System.EventArgs e)
        {
            if (this.pnlDatabaseShowPassword.Checked)
            {
                this.txtPassword.Properties.UseSystemPasswordChar = false;
            }
            else
            {
                this.txtPassword.Properties.UseSystemPasswordChar = true;
            }
        }

        
    }
}