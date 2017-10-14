namespace GTSysOne.Gui.Main
{
    public partial class frmSplash : DevExpress.XtraSplashScreen.SplashScreen
    {
        #region Variables
        int Counter = 0;
        int CounterFinisher = 0;
        bool RunAlready = false;
        System.Data.ConnectionState conConnectionState;
        #endregion
        public frmSplash()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.LOAD);
            this.Shown += new System.EventHandler(this.SHOWN);
            this.bgWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.CONDOWORK);
            this.bgWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.CONDOWORKCOMPLETED);
            this.bgWorkerCheckedLicense.DoWork += new System.ComponentModel.DoWorkEventHandler(this.LICWORK);
            this.bgWorkerCheckedLicense.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.LICWORKCOMPLETED);
            this.tmrFlash.Tick += new System.EventHandler(this.TIMER);
            this.tmrFinisher.Tick += new System.EventHandler(this.TIMER_FINISHER);
        }
        #region Overrides

        public override void ProcessCommand(System.Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion

        public enum SplashScreenCommand
        {
        }
        private void LOAD(object sender,System.EventArgs e)
        {
            GTSysOne.Class.Utility.clsUtility.FaidIn(this,50);
        }
        private void SHOWN(object sender, System.EventArgs e)
        {
            this.labelControl1.Text = "Copyright© 2017 - " + System.DateTime.Now.Year.ToString() + " All Rights Reserved." + GTSysOne.Class.Utility.clsGlobal.Instance().MainHeaderVersion;
            this.tmrFlash.Start();
        }

        private void TIMER(object sender, System.EventArgs e)
        {
            if (Counter < 100)
            {
                if (!this.bgWorker.IsBusy)
                {
                    Counter += 1;
                    if (Counter > 70)
                    {
                        Counter = 71;
                        this.tmrFlash.Stop();
                    }
                    switch (Counter)
                    {
                        #region INIT
                        case 1:
                            this.labelControl2.Text = "Starting.";
                            break;
                        case 2:
                            this.labelControl2.Text = "Starting..";
                            break;
                        case 3:
                            this.labelControl2.Text = "Starting...";
                            break;
                        case 4:
                            this.labelControl2.Text = "Starting.";
                            break;
                        case 5:
                            this.labelControl2.Text = "Starting..";
                            break;
                        case 6:
                            this.labelControl2.Text = "Starting... Idris is Handsome... ";
                            break;
                        #endregion

                        case 9:
                            this.labelControl2.Text = "Encrypting Connection....";
                            break;
                        case 10:
                            GTSysOne.Class.Utility.clsGlobal.Instance().ConnectionString = GTSysOne.Class.Utility.clsUtility.GetConnectionFile();
                            break;
                        case 12:
                            this.labelControl2.Text = "Reading LogIn...";
                            break;
                        case 14:
                            try
                            {
                                string[] FirstRound = GTSysOne.Class.Utility.clsGlobal.Instance().ConnectionString.Split('=');
                                string[] SecondRound = FirstRound[4].Split(';');
                                GTSysOne.Class.Utility.clsGlobal.Instance().ConnectionLogIn = SecondRound[0];
                            }
                            catch { }
                            break;
                        case 16:
                            this.labelControl2.Text = "Reading Password...";
                            break;
                        case 18:
                            string[] NextRound = GTSysOne.Class.Utility.clsGlobal.Instance().ConnectionString.Split('=');
                            if (NextRound.Length >= 6)
                            {
                                GTSysOne.Class.Utility.clsGlobal.Instance().ConnectionPassword = NextRound[5];
                            }
                            break;
                        case 29:
                            this.labelControl2.Text = "Reading Printer Installed...";
                            break;
                        case 30:
                            GTSysOne.Class.Utility.clsUtility.PrinterInstalled();
                            break;
                        case 39:
                            this.labelControl2.Text = "Fix System Password...";
                            break;
                        case 40:
                            this.labelControl2.Text = "Fix System Password...";
                            break;
                        case 49:
                            GTSysOne.Class.Utility.clsGlobal.Instance().Fix_System_Password = "gtsidris@" + System.DateTime.Now.Year;
                            break;
                        case 50:
                            break;
                        case 59:
                            this.labelControl2.Text = "Scanning CPU...";
                            break;
                        case 60:
                            GTSysOne.Class.Utility.clsGlobal.Instance().STATIONCPU = GTSysOne.Class.Utility.clsUtility.GetCPUID();
                            break;
                        case 65:
                            this.labelControl2.Text = "Load All Theme Skin...";
                            break;
                        case 66:
                            GTSysOne.Class.Utility.clsGlobal.Instance().ThemesList = GTSysOne.Class.Utility.clsUtility.LoadAllTheme();
                            break;
                        case 67:
                            this.labelControl2.Text = "Diagnose Connection...";
                            break;
                        case 70:
                            this.bgWorker.RunWorkerAsync();
                            break;
                    }
                }
            }
            else
            {
                conConnectionState = System.Data.ConnectionState.Closed;
                this.tmrFlash.Stop();
                GTSysOne.Class.Utility.clsUtility.GarbageCollectors();
                this.Close();
            }
        }
        private void CONDOWORK(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            if (RunAlready == false)
            {
                GTSysOne.Class.Utility.clsUtility.OpenConnection();
                conConnectionState = GTSysOne.Class.Utility.clsGlobal.Instance().Connection.State;
                RunAlready = true;
            }
        }
        private void CONDOWORKCOMPLETED(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            RunAlready = false;
            if (System.Data.ConnectionState.Open != conConnectionState)
            {
                GTSysOne.Class.Utility.clsGlobal.Instance().Connected = false;
                this.labelControl2.Text = "Finish with error.";
                this.tmrFlash.Stop();
                this.tmrFinisher.Stop();
                this.Hide();
                using (var frm = new GTSysOne.Gui.Main.frmLogIn())
                {
                    frm.ShowDialog();
                    frm.Dispose();
                }
                if (!GTSysOne.Class.Utility.clsGlobal.Instance().Login)
                {
                    GTSysOne.Class.Utility.clsGlobal.Instance().LogOut = true;
                }
                conConnectionState = System.Data.ConnectionState.Closed;
                GTSysOne.Class.Utility.clsUtility.GarbageCollectors();
                this.Close();
            }
            else
            {
                this.tmrFinisher.Start();
            }
        }
        private void TIMER_FINISHER(object sender, System.EventArgs e)
        {
            if (CounterFinisher < 100)
            {
                if (!this.bgWorkerCheckedLicense.IsBusy)
                {
                    CounterFinisher += 1;
                    if (CounterFinisher > 60)
                    {
                        CounterFinisher = 99;
                    }
                    switch (CounterFinisher)
                    {
                        case 9:
                            this.labelControl2.Text = "Collecting Connection Details...";
                            break;
                        case 10:
                            GTSysOne.Class.Utility.clsGlobal.Instance().ConnectionDetails = "Server:" + GTSysOne.Class.Utility.clsGlobal.Instance().Connection.DataSource + "." + GTSysOne.Class.Utility.clsGlobal.Instance().Connection.ServerVersion + " Database:" + GTSysOne.Class.Utility.clsGlobal.Instance().Connection.Database;
                            break;
                        case 11:
                            GTSysOne.Class.Utility.clsGlobal.Instance().Connected = true;
                            break;

                        case 19:
                            this.labelControl2.Text = "Setup Module...";
                            break;
                        case 20:
                            GTSysOne.Class.Utility.clsGlobal.Instance().Module = GTSysOne.Class.Utility.clsUtility.GetModule();
                            break;

                        case 26:
                            this.marqueeProgressBarControl1.Text = "Setup Properties Connection...";
                            break;
                        case 27:
                            GTSysOne.Class.Utility.clsUtility.DEFAULT_CONNECTION_SETTINGS(GTSysOne.Class.Utility.clsGlobal.Instance().Connection.ConnectionString);
                            break;


                        case 22:
                            this.labelControl2.Text = "Setup Culture...";
                            break;
                        case 23:
                            GTSysOne.Class.Utility.clsGlobal.Instance().CultureInformation = "en";
                            break;

                        case 35:
                            this.labelControl2.Text = "Setup Theme Gallery...";
                            GTSysOne.Class.Utility.clsGlobal.Instance().THEME = "McSkin";
                            break;
                        case 37:
                            GTSysOne.Class.Utility.clsGlobal.Instance().THEME = System.Convert.ToString(GTSysOne.Class.MasterFile.clsMas_Station.ScalarValue(GTSysOne.Class.MasterFile.clsMas_Station.Value(0, 3, GTSysOne.Class.Utility.clsGlobal.Instance().STATIONCPU)));
                            break;

                        case 39:
                            this.labelControl2.Text = "Setup Function...";
                            break;
                        case 40:
                            GTSysOne.Class.Utility.clsGlobal.Instance().Function = GTSysOne.Class.Utility.clsUtility.GetFunction();
                            //modGlobal.modGlobal.Instance().LANGUAGELIST = Classes.clsCompanySetup.Get(Classes.clsCompanySetup.strParValCompanySetup(0, 8));
                            break;
                        case 59:
                            this.labelControl2.Text = "Checking License status...";
                            break;
                        case 60:
                            this.bgWorkerCheckedLicense.RunWorkerAsync();
                            break;
                    }
                }
            }
            else
            {
                this.labelControl2.Text = "Finish.";
                this.tmrFinisher.Stop();
                this.tmrFlash.Start();
            }
        }
        private void LICWORK(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            if (RunAlready == false)
            {
                GTSysOne.Class.Utility.clsUtility.CheckLicensed();
                RunAlready = true;
            }
        }
        private void LICWORKCOMPLETED(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            RunAlready = false;
            CounterFinisher = 100;
            Counter = 100;
        }
    }
}