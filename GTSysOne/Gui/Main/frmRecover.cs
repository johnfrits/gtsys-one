namespace GTSysOne.Gui.Main
{
    public partial class frmRecover : DevExpress.XtraEditors.XtraForm
    {
        bool OkSystemPassword = false;
        bool OKConnection = false;
        public frmRecover()
        {
            InitializeComponent();
            this.btnPrevious.Click += new System.EventHandler(this.CLICK);
            this.btnNext.Click += new System.EventHandler(this.CLICK);
            this.btnClose.Click += new System.EventHandler(this.CLICK);
            this.btnVerify.Click += new System.EventHandler(this.CLICK);
            this.btnVerifyPassword.Click += new System.EventHandler(this.CLICK);

            this.xTabControlMain.TabPages.Remove(this.xTabEstablishment);
            this.xTabControlMain.TabPages.Remove(this.xTabStation);

            GTSysOne.Class.Utility.clsUtility.View(this.gridControlEstablishment
                        , this.gridViewEstablishment, 0
                        , GTSysOne.Class.MasterFile.clsMas_Establishment.ShowTable(GTSysOne.Class.MasterFile.clsMas_Establishment.Value(0, 0))
                        , "ESTId", true);

            GTSysOne.Class.Utility.clsUtility.View(this.gridControlStation
                        , this.gridViewStation, 0
                        , GTSysOne.Class.MasterFile.clsMas_Station.ShowTable(GTSysOne.Class.MasterFile.clsMas_Station.Value(0,2))
                        , "StationId", true);
            this.radSetup.SelectedIndex = -1;

            System.Data.DataTable dt = new System.Data.DataTable();
            dt.Columns.Add("Id", typeof(bool));
            dt.Columns.Add("Name", typeof(string));
            dt.Rows.Add(true, "SQL Server Authentication");
            dt.Rows.Add(false, "Windows Authentication");
            GTSysOne.Class.Utility.clsUtility.createlookup(this.lookUpEditAuthentication, dt, new string[] { "Name" }, "Id", "Name");

            this.lblGTSysWebsiteLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.GTSLINK);
            
        }
        private void CLICK(object sender, System.EventArgs e)
        {
            GTSysOne.Class.Utility.clsGlobal.Instance().Err.ClearErrors();
            GTSysOne.Class.Utility.clsGlobal.Instance().No_Error_Result = true;
            DevExpress.XtraEditors.SimpleButton btn = sender as DevExpress.XtraEditors.SimpleButton;
            switch (btn.Name)
            {
                case "btnPrevious":
                    #region
                    this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
                    this.radSetup.SelectedIndex = -1;
                    switch (this.xTabControlMain.SelectedTabPage.Name)
                    {
                        case "xTabEstablishment":
                            this.NextTab(this.xTabGTSysOneServerSide, this.xTabEstablishment);
                            break;
                        case "xTabStation":
                            this.NextTab(this.xTabGTSysOneServerSide, this.xTabStation);
                            break;
                    }
                    this.Cursor = System.Windows.Forms.Cursors.Default;
                    #endregion
                    break;
                case "btnNext":
                    #region
                    this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
                    switch (this.xTabControlMain.SelectedTabPage.Name)
                    {
                        case "xTabGTSysOneServerSide":
                            this.CheckConnection();
                            if (GTSysOne.Class.Utility.clsGlobal.Instance().No_Error_Result && OKConnection && OkSystemPassword)
                            {
                                switch (this.radSetup.SelectedIndex)
                                {
                                    case 0:
                                        this.NextTab(this.xTabStation, this.xTabGTSysOneServerSide);
                                        break;
                                    case 1:
                                        this.NextTab(this.xTabEstablishment, this.xTabGTSysOneServerSide);
                                        break;
                                    case 2:
                                        this.NextTab(this.xTabStation, this.xTabGTSysOneServerSide);
                                        break;
                                }
                            }
                            break;
                        case "xTabEstablishment":
                                GTSysOne.Class.MasterFile.clsMas_Establishment.Save(GTSysOne.Class.MasterFile.clsMas_Establishment.Value(
                                                  2
                                                , 2
                                                , System.Convert.ToString(this.gridViewEstablishment.GetRowCellValue(this.gridViewEstablishment.FocusedRowHandle, "ESTId"))
                                                , string.Empty
                                                , false
                                                , false
                                                , GTSysOne.Class.Utility.clsGlobal.Instance().COMPANYID
                                                , GTSysOne.Class.Utility.clsGlobal.Instance().ESTABLISHMENTID
                                                , GTSysOne.Class.Utility.clsGlobal.Instance().STATIONID
                                                , System.Convert.ToString((int)GTSysOne.Class.Utility.clsGlobal.myFunction.Establishment)
                                                , GTSysOne.Class.Utility.clsGlobal.Instance().UserId
                                                , System.Convert.ToString(GTSysOne.Class.Utility.clsUtility.SERVERDATE())
                                                , GTSysOne.Class.Utility.clsGlobal.Instance().COMPANYID
                                                , string.Empty
                                                , string.Empty
                                                , string.Empty
                                                , string.Empty
                                                , string.Empty
                                                , GTSysOne.Class.Utility.clsGlobal.Instance().STATIONCPU
                                                , false
                                                , "0"));
                                if (System.Convert.ToString(this.gridViewEstablishment.GetRowCellValue(this.gridViewEstablishment.FocusedRowHandle, "StationId")) != "")
                                {
                                    GTSysOne.Class.MasterFile.clsMas_Station.Save(
                                        GTSysOne.Class.MasterFile.clsMas_Station.Value(2
                                                , 2
                                                , System.Convert.ToString(this.gridViewEstablishment.GetRowCellValue(this.gridViewEstablishment.FocusedRowHandle, "StationId"))
                                                , string.Empty
                                                , false
                                                , false
                                                , GTSysOne.Class.Utility.clsGlobal.Instance().COMPANYID
                                                , GTSysOne.Class.Utility.clsGlobal.Instance().ESTABLISHMENTID
                                                , GTSysOne.Class.Utility.clsGlobal.Instance().STATIONID
                                                , System.Convert.ToString((int)GTSysOne.Class.Utility.clsGlobal.myFunction.Station)
                                                , GTSysOne.Class.Utility.clsGlobal.Instance().UserId
                                                , System.Convert.ToString(GTSysOne.Class.Utility.clsUtility.SERVERDATE())
                                                , GTSysOne.Class.Utility.clsGlobal.Instance().ESTABLISHMENTID
                                                , string.Empty
                                                , string.Empty
                                                , GTSysOne.Class.Utility.clsGlobal.Instance().STATIONCPU
                                                , true
                                                , false
                                                , string.Empty
                                                , string.Empty
                                                , string.Empty
                                                , false
                                                , string.Empty
                                                , false
                                                , false
                                                , false
                                                , false
                                                , false
                                                , "0"));
                                }
                            this.Cursor = System.Windows.Forms.Cursors.Default;
                            this.Close();
                            break;
                        case "xTabStation":
                            GTSysOne.Class.MasterFile.clsMas_Station.Save(GTSysOne.Class.MasterFile.clsMas_Station.Value(
                                                 2
                                               , 2
                                               , System.Convert.ToString(this.gridViewStation.GetRowCellValue(this.gridViewStation.FocusedRowHandle, "StationId"))
                                               , string.Empty
                                               , false
                                               , false
                                               , GTSysOne.Class.Utility.clsGlobal.Instance().COMPANYID
                                               , GTSysOne.Class.Utility.clsGlobal.Instance().ESTABLISHMENTID
                                               , GTSysOne.Class.Utility.clsGlobal.Instance().STATIONID
                                               , System.Convert.ToString((int)GTSysOne.Class.Utility.clsGlobal.myFunction.Station)
                                               , GTSysOne.Class.Utility.clsGlobal.Instance().UserId
                                               , System.Convert.ToString(GTSysOne.Class.Utility.clsUtility.SERVERDATE())
                                               , GTSysOne.Class.Utility.clsGlobal.Instance().ESTABLISHMENTID
                                               , string.Empty
                                               , string.Empty
                                               , GTSysOne.Class.Utility.clsGlobal.Instance().STATIONCPU
                                               , true
                                               , false
                                               , string.Empty
                                               , string.Empty
                                               , string.Empty
                                               , false
                                               , string.Empty
                                               , false
                                               , false
                                               , false
                                               , false
                                               , false
                                               , "0"));
                            this.Cursor = System.Windows.Forms.Cursors.Default;
                            this.Close();
                            break;
                    }
                    this.Cursor = System.Windows.Forms.Cursors.Default;
                    #endregion
                    break;
                case "btnVerifyPassword":
                    this.CheckConnection();
                    break;
                case "btnVerify":
                    this.CheckKey();
                    break;
                case "btnClose":
                    this.Close();
                    break;
            }
        }
        private void NextTab(DevExpress.XtraTab.XtraTabPage AddTab, DevExpress.XtraTab.XtraTabPage RemoveTab)
        {
            this.xTabControlMain.TabPages.Add(AddTab);
            this.xTabControlMain.TabPages.Remove(RemoveTab);
        }
        private void CheckConnection()
        {
            GTSysOne.Class.Utility.clsUtility.ValidateControl(this.txtServerName);
            GTSysOne.Class.Utility.clsUtility.ValidateControl(this.txtDatabase);
            GTSysOne.Class.Utility.clsUtility.ValidateControl(this.lookUpEditAuthentication);
            GTSysOne.Class.Utility.clsUtility.ValidateControl(this.txtLogin);
            GTSysOne.Class.Utility.clsUtility.ValidateControl(this.txtPassword);
            OKConnection = GTSysOne.Class.Utility.clsUtility.TestConnection("Data Source = " + this.txtServerName.Text + ";Initial Catalog = " + this.txtDatabase.Text + ";Persist Security Info = " + this.lookUpEditAuthentication.EditValue + ";User ID = " + this.txtLogin.Text + ";Password = " + this.txtPassword.Text + " ");
            if(OKConnection)
            {
                this.btnVerifyPassword.Image = this.btnCorrect.Image;
            }
            else
            {
                this.btnVerifyPassword.Image = this.btnError.Image;
            }
            this.CheckKey();
        }
        private void CheckKey()
        {
            GTSysOne.Class.Utility.clsUtility.ValidateControl(this.txtGTSysOneUnifiedKey);
            if (this.txtGTSysOneUnifiedKey.Text == GTSysOne.Class.Utility.clsGlobal.Instance().Fix_System_Password)
            {
                OkSystemPassword = true;
                this.btnVerify.Image = this.btnCorrect.Image;
            }
            else
            {
                OkSystemPassword = false;
                this.btnVerify.Image = this.btnError.Image;
            }
        }

        private void GTSLINK(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.ProcessStartInfo sInfo = new System.Diagnostics.ProcessStartInfo(GTSysOne.Class.Utility.clsGlobal.Instance().CompanyWebsite);
            System.Diagnostics.Process.Start(sInfo);
        }

    }
}