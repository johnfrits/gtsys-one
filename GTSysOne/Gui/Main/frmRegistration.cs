namespace GTSysOne.Gui.Main
{
    public partial class frmRegistration : DevExpress.XtraEditors.XtraForm
    {
        public frmRegistration()
        {
            InitializeComponent();
            this.btnPrevious.Click += new System.EventHandler(this.CLICK);
            this.btnNext.Click += new System.EventHandler(this.CLICK);
            this.btnClose.Click += new System.EventHandler(this.CLICK);

            this.btnEditCompany.ButtonPressed += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.PRESSED);
            this.btnLoadFile.ButtonPressed += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.PRESSED);

           


            this.xTabControlMain.TabPages.Remove(this.xTabCompany);
            this.xTabControlMain.TabPages.Remove(this.xTabEstablishment);
            this.xTabControlMain.TabPages.Remove(this.xTabStation);
            this.xTabControlMain.TabPages.Remove(this.xTabLoadFile);

            this.radSetup.SelectedIndex = -1;

            GTSysOne.Class.Utility.clsUtility.createlookup(this.lookUpEditCompanyStation
                , GTSysOne.Class.Document.clsDoc_Company.ShowTable(GTSysOne.Class.Document.clsDoc_Company.Value(0, 0))
                , new string[] { "Name" }, "id", "Name");

            

            GTSysOne.Class.Utility.clsUtility.createlookup(this.lookUpEditTheme
                 , GTSysOne.Class.Utility.clsGlobal.Instance().ThemesList
                 , new string[] { "Name" }, "Id", "Name");

            switch (System.Convert.ToInt32(GTSysOne.Class.Document.clsDoc_Lcg.ScalarValue(GTSysOne.Class.Document.clsDoc_Lcg.Value(0, 2))))
            {
                case 0:

                    this.radSetup.Properties.Items[0].Enabled = true;
                    this.radSetup.Properties.Items[1].Enabled = false;
                    this.radSetup.Properties.Items[2].Enabled = false;

                    break;
                default:

                    this.radSetup.Properties.Items[0].Enabled = false;
                    this.radSetup.Properties.Items[0].Description = "Note: License Already Applied";
                    this.radSetup.Properties.Items[1].Enabled = true;
                    this.radSetup.Properties.Items[2].Enabled = true;

                    break;
            }
            this.lblGTSysWebsiteLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.GTSLINK);

            this.lookUpEditCompanyStation.EditValueChanged += new System.EventHandler(this.COMPANYSTATCHANGED);
        }

        private void CLICK(object sender, System.EventArgs e)
        {
            GTSysOne.Class.Utility.clsGlobal.Instance().No_Error_Result = true;
            GTSysOne.Class.Utility.clsGlobal.Instance().Err.ClearErrors();
            DevExpress.XtraEditors.SimpleButton btn = sender as DevExpress.XtraEditors.SimpleButton;
            switch(btn.Name)
            {
                case "btnPrevious":
                    #region
                    this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
                    switch (this.xTabControlMain.SelectedTabPage.Name)
                    {
                        case "xTabCompany":
                            switch (this.radSetup.SelectedIndex)
                            {
                                case 0://HQ
                                case 1://EST
                                    this.NextTab(this.xTabSetupType, this.xTabCompany);
                                    this.radSetup.SelectedIndex = -1;
                                    break;
                            }
                            break;
                        case "xTabEstablishment":
                            switch (this.radSetup.SelectedIndex)
                            {
                                case 0://HQ
                                case 1://EST
                                    this.NextTab(this.xTabCompany, this.xTabEstablishment);
                                    break;
                            }
                            break;
                        case "xTabStation":
                            switch (this.radSetup.SelectedIndex)
                            {
                                case 0://HQ
                                case 1://EST
                                    this.NextTab(this.xTabEstablishment, this.xTabStation);
                                    break;
                                case 2://STAT
                                    this.NextTab(this.xTabSetupType, this.xTabStation);
                                    this.radSetup.SelectedIndex = -1;
                                    break;
                            }
                            break;
                        case "xTabLoadFile":
                            switch (this.radSetup.SelectedIndex)
                            {
                                case 0://HQ
                                    this.NextTab(this.xTabStation, this.xTabLoadFile);
                                    break;
                                case 1://EST
                                    if (this.chkIDontWantToAddStation.Checked)
                                    {
                                        this.NextTab(this.xTabEstablishment, this.xTabLoadFile);
                                    }
                                    else
                                    {
                                        this.NextTab(this.xTabStation, this.xTabLoadFile);
                                    }
                                    break;
                            }
                            break;
                    }
                    this.Cursor = System.Windows.Forms.Cursors.Default;
                    #endregion
                    break;
                case "btnNext":
                    this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
                    switch(this.xTabControlMain.SelectedTabPage.Name)
                    {
                        case "xTabSetupType":
                            switch(this.radSetup.SelectedIndex)
                            {
                                case 0://HQ
                                case 1://EST
                                    this.NextTab(this.xTabCompany, this.xTabSetupType);
                                    break;
                                case 2://STAT
                                    this.lookUpEditEstablishmentStation.Enabled = true;
                                    this.lookUpEditCompanyStation.Enabled = true;
                                    this.NextTab(this.xTabStation, this.xTabSetupType);
                                    break;
                            }
                            break;
                        case "xTabCompany":
                            GTSysOne.Class.Utility.clsUtility.ValidateControl(this.btnEditCompany);
                            this.chkIDontWantToAddStation.Checked = false;
                            switch (this.radSetup.SelectedIndex)
                            {
                                case 0://HQ
                                    if (this.btnEditCompany.Tag != null)
                                    {
                                        this.chkIDontWantToAddStation.Enabled = false;
                                        this.NextTab(this.xTabEstablishment, this.xTabCompany);
                                    }
                                    break;
                                case 1://EST
                                    if (this.btnEditCompany.Tag != null)
                                    {
                                        this.chkIDontWantToAddStation.Enabled = true;
                                        this.NextTab(this.xTabEstablishment, this.xTabCompany);
                                    }
                                    break;
                            }
                            break;
                        case "xTabEstablishment":
                            GTSysOne.Class.Utility.clsUtility.ValidateControl(this.txtEstablishmentName);
                            if (this.txtEstablishmentName.Text.CompareTo(string.Empty) != 0)
                            {
                                this.lookUpEditEstablishmentStation.Enabled = true;
                                this.lookUpEditCompanyStation.Enabled = true;
                                switch (this.radSetup.SelectedIndex)
                                {
                                    case 0://HQ
                                        this.lookUpEditEstablishmentStation.Enabled = false;
                                        this.lookUpEditCompanyStation.Enabled = false;
                                        this.NextTab(this.xTabStation, this.xTabEstablishment);
                                        break;
                                    case 1://EST
                                        if (this.chkIDontWantToAddStation.Checked)
                                        {
                                            this.NextTab(this.xTabLoadFile, this.xTabEstablishment);
                                        }
                                        else
                                        {
                                            //this.lookUpEditEstablishmentStation.Enabled = false;
                                            //this.lookUpEditCompanyStation.Enabled = false;
                                            this.NextTab(this.xTabStation, this.xTabEstablishment);
                                        }
                                        break;
                                    case 2:
                                        this.lookUpEditEstablishmentStation.Enabled = true;
                                        this.lookUpEditCompanyStation.Enabled = true;
                                        break;
                                }
                            }
                            break;
                        case "xTabStation":
                            GTSysOne.Class.Utility.clsUtility.ValidateControl(this.txtStationName);
                            switch (this.radSetup.SelectedIndex)
                            {
                                case 0://HQ
                                case 1://EST
                                    if (this.txtStationName.Text.CompareTo(string.Empty) != 0)
                                    {
                                        this.NextTab(this.xTabLoadFile, this.xTabStation);
                                    }
                                    break;
                                case 2://STAT
                                    GTSysOne.Class.Utility.clsUtility.ValidateControl(this.lookUpEditEstablishmentStation);
                                    GTSysOne.Class.Utility.clsUtility.ValidateControl(this.lookUpEditCompanyStation);
                                    if (this.lookUpEditEstablishmentStation.EditValue != null 
                                        && this.lookUpEditCompanyStation.EditValue != null
                                        && this.txtStationName.Text.CompareTo(string.Empty) != 0)
                                    {
                                        //this.NextTab(this.xTabLoadFile, this.xTabStation);
                                        //Add Station
                                        GTSysOne.Class.MasterFile.clsMas_Station.Save(GTSysOne.Class.MasterFile.clsMas_Station.Value(
                                              1
                                            , 0
                                            , string.Empty
                                            , string.Empty
                                            , false
                                            , false
                                            , System.Convert.ToString(this.lookUpEditCompanyStation.EditValue)
                                            , System.Convert.ToString(this.lookUpEditEstablishmentStation.EditValue)
                                            , GTSysOne.Class.Utility.clsGlobal.Instance().STATIONID
                                            , System.Convert.ToString((int)GTSysOne.Class.Utility.clsGlobal.myFunction.Station)
                                            , GTSysOne.Class.Utility.clsGlobal.Instance().UserId
                                            , System.Convert.ToString(GTSysOne.Class.Utility.clsUtility.SERVERDATE())
                                            , System.Convert.ToString(this.lookUpEditEstablishmentStation.EditValue)
                                            , this.txtStationName.Text
                                            , this.txtStationShortName.Text
                                            , GTSysOne.Class.Utility.clsGlobal.Instance().STATIONCPU
                                            , true
                                            , false
                                            , string.Empty
                                            , string.Empty
                                            , string.Empty
                                            , false
                                            , System.Convert.ToString(this.lookUpEditTheme.EditValue)
                                            , false
                                            , false
                                            , false
                                            , false
                                            , false
                                            , "0"));
                                        this.Close();
                                    }
                                    break;
                            }
                            break;
                        case "xTabLoadFile"://Finish Here....
                            GTSysOne.Class.Utility.clsUtility.ValidateControl(this.btnLoadFile);
                            if (this.btnLoadFile.Text.CompareTo(string.Empty) != 0)
                            {
                                switch (this.radSetup.SelectedIndex)
                                {
                                    case 0://HQ
                                        //Add HQ
                                        GTSysOne.Class.Utility.clsGlobal.Instance().UserId = "DEF";
                                        string LICENSEId = string.Empty;
                                        string ESTABLISHMENTId = string.Empty;
                                        string STATIONId = string.Empty;
                                        LICENSEId = GTSysOne.Class.Document.clsDoc_Lcg.Save(GTSysOne.Class.Document.clsDoc_Lcg.Value(
                                             1
                                            ,0
                                            ,string.Empty
                                            ,string.Empty
                                            ,false
                                            ,false
                                            ,false
                                            ,System.Convert.ToString(this.btnEditCompany.Tag)
                                            ,GTSysOne.Class.Utility.clsGlobal.Instance().ESTABLISHMENTID
                                            ,GTSysOne.Class.Utility.clsGlobal.Instance().STATIONID
                                            ,System.Convert.ToString((int)GTSysOne.Class.Utility.clsGlobal.myFunction.License)
                                            ,GTSysOne.Class.Utility.clsGlobal.Instance().UserId
                                            , System.Convert.ToString(GTSysOne.Class.Utility.clsUtility.SERVERDATE())
                                            ,System.Convert.ToString(this.btnLoadFile.Text)
                                            ,string.Empty
                                            ,"0"));

                                        //Add Establishment
                                        ESTABLISHMENTId = GTSysOne.Class.MasterFile.clsMas_Establishment.Save(
                                            GTSysOne.Class.MasterFile.clsMas_Establishment.Value(
                                              1
                                            , 0
                                            , string.Empty
                                            , string.Empty
                                            , false,false
                                            , System.Convert.ToString(this.btnEditCompany.Tag)
                                            , GTSysOne.Class.Utility.clsGlobal.Instance().ESTABLISHMENTID
                                            , GTSysOne.Class.Utility.clsGlobal.Instance().STATIONID
                                            , System.Convert.ToString((int)GTSysOne.Class.Utility.clsGlobal.myFunction.Establishment)
                                            , GTSysOne.Class.Utility.clsGlobal.Instance().UserId
                                            , System.Convert.ToString(GTSysOne.Class.Utility.clsUtility.SERVERDATE())
                                            , System.Convert.ToString(this.btnEditCompany.Tag)
                                            , this.txtEstablishmentName.Text
                                            , this.txtEstablishmentShortName.Text
                                            , this.txtEstablsihmentAddress.Text
                                            , string.Empty
                                            , ""
                                            , GTSysOne.Class.Utility.clsGlobal.Instance().STATIONCPU
                                            , false
                                            , "0"));

                                        //Add Station
                                        STATIONId = GTSysOne.Class.MasterFile.clsMas_Station.Save(GTSysOne.Class.MasterFile.clsMas_Station.Value(
                                              1
                                            , 0
                                            , string.Empty
                                            , string.Empty
                                            , false
                                            , false
                                            , System.Convert.ToString(this.btnEditCompany.Tag)
                                            , ESTABLISHMENTId
                                            , GTSysOne.Class.Utility.clsGlobal.Instance().STATIONID
                                            , System.Convert.ToString((int)GTSysOne.Class.Utility.clsGlobal.myFunction.Station)
                                            , GTSysOne.Class.Utility.clsGlobal.Instance().UserId
                                            , System.Convert.ToString(GTSysOne.Class.Utility.clsUtility.SERVERDATE())
                                            , ESTABLISHMENTId
                                            , this.txtStationName.Text
                                            , this.txtStationShortName.Text
                                            , GTSysOne.Class.Utility.clsGlobal.Instance().STATIONCPU
                                            , true
                                            , false
                                            , string.Empty
                                            , string.Empty
                                            , string.Empty
                                            , false
                                            , System.Convert.ToString(this.lookUpEditTheme.EditValue)
                                            , false
                                            , false
                                            , false
                                            , false
                                            , false
                                            , "0"));

                                        GTSysOne.Class.Utility.clsGlobal.Instance().STATIONID = STATIONId;
                                        //UPDATE LCG
                                        GTSysOne.Class.Document.clsDoc_Lcg.Save(GTSysOne.Class.Document.clsDoc_Lcg.Value(
                                              2
                                            , 0
                                            , LICENSEId
                                            , string.Empty
                                            , false
                                            , false
                                            , false
                                            , System.Convert.ToString(this.btnEditCompany.Tag)
                                            , ESTABLISHMENTId
                                            , GTSysOne.Class.Utility.clsGlobal.Instance().STATIONID
                                            , System.Convert.ToString((int)GTSysOne.Class.Utility.clsGlobal.myFunction.License)
                                            , GTSysOne.Class.Utility.clsGlobal.Instance().UserId
                                            , System.Convert.ToString(GTSysOne.Class.Utility.clsUtility.SERVERDATE())
                                            , System.Convert.ToString(this.btnLoadFile.Text)
                                            , string.Empty
                                            , "0"));


                                        string[] DecryptedKeys = GTSysOne.Class.Utility.clsEncryption.JayDhreiZIP.Decrypt(this.btnLoadFile.Text, "").Split('*');
                                        string CONTROL = GTSysOne.Class.Utility.clsEncryption.JayDhreiZIP.Encrypt(DecryptedKeys[0]
                                                                + "*" + DecryptedKeys[1]
                                                                + "*" + DecryptedKeys[2]
                                                                + "*" + DecryptedKeys[3]
                                                                + "*" + DecryptedKeys[4]
                                                                + "*" + DecryptedKeys[5]
                                                                + "*" + DecryptedKeys[6]
                                                                + "*" + DecryptedKeys[7]
                                                                + "*" + DecryptedKeys[8]
                                                                + "*" + ESTABLISHMENTId , "");
                                        //UPDATE EST
                                        GTSysOne.Class.MasterFile.clsMas_Establishment.Save(GTSysOne.Class.MasterFile.clsMas_Establishment.Value(
                                              2
                                            , 0
                                            , ESTABLISHMENTId
                                            , string.Empty
                                            , false
                                            , false
                                            , System.Convert.ToString(this.btnEditCompany.Tag)
                                            , ESTABLISHMENTId
                                            , GTSysOne.Class.Utility.clsGlobal.Instance().STATIONID
                                            , System.Convert.ToString((int)GTSysOne.Class.Utility.clsGlobal.myFunction.Establishment)
                                            , GTSysOne.Class.Utility.clsGlobal.Instance().UserId
                                            , System.Convert.ToString(GTSysOne.Class.Utility.clsUtility.SERVERDATE())
                                            , System.Convert.ToString(this.btnEditCompany.Tag)
                                            , this.txtEstablishmentName.Text
                                            , this.txtEstablishmentShortName.Text
                                            , this.txtEstablsihmentAddress.Text
                                            , string.Empty
                                            , CONTROL
                                            , GTSysOne.Class.Utility.clsGlobal.Instance().STATIONCPU
                                            , false
                                            , "0"));

                                        //UPDATE COMPANY SOURCE LICENSE
                                        GTSysOne.Class.Document.clsDoc_Company.Save(GTSysOne.Class.Document.clsDoc_Company.Value(2,1
                                            ,System.Convert.ToString(this.btnEditCompany.Tag) , LICENSEId));

                                        GTSysOne.Class.Utility.clsGlobal.Instance().LicenseAction = GTSysOne.Class.Utility.clsGlobal.myLicenseStatus.Trial;
                                        this.Cursor = System.Windows.Forms.Cursors.Default;
                                        break;
                                    case 1://EST
                                        //Add Establishment
                                        try
                                        {
                                            string[] EST = GTSysOne.Class.Utility.clsEncryption.JayDhreiZIP.Decrypt(this.btnLoadFile.Text, "").Split('*');
                                            if (this.chkIDontWantToAddStation.Checked)
                                            {
                                                //UPDATE EST
                                                GTSysOne.Class.MasterFile.clsMas_Establishment.Save(GTSysOne.Class.MasterFile.clsMas_Establishment.Value(
                                                      2
                                                    , 2
                                                    , System.Convert.ToString(EST[9])
                                                    , string.Empty
                                                    , false
                                                    , false
                                                    , System.Convert.ToString(this.btnEditCompany.Tag)
                                                    , System.Convert.ToString(EST[9])
                                                    , GTSysOne.Class.Utility.clsGlobal.Instance().STATIONID
                                                    , System.Convert.ToString((int)GTSysOne.Class.Utility.clsGlobal.myFunction.Establishment)
                                                    , GTSysOne.Class.Utility.clsGlobal.Instance().UserId
                                                    , System.Convert.ToString(GTSysOne.Class.Utility.clsUtility.SERVERDATE())
                                                    , System.Convert.ToString(this.btnEditCompany.Tag)
                                                    , this.txtEstablishmentName.Text
                                                    , this.txtEstablishmentShortName.Text
                                                    , this.txtEstablsihmentAddress.Text
                                                    , string.Empty
                                                    , string.Empty
                                                    , GTSysOne.Class.Utility.clsGlobal.Instance().STATIONCPU
                                                    , false
                                                    , "0"));
                                            }
                                            else
                                            {
                                                //UPDATE EST
                                               string NewEstablishmentId = GTSysOne.Class.MasterFile.clsMas_Establishment.Save(GTSysOne.Class.MasterFile.clsMas_Establishment.Value(
                                                      2
                                                    , 2
                                                    , System.Convert.ToString(EST[9])
                                                    , string.Empty
                                                    , false
                                                    , false
                                                    , System.Convert.ToString(this.btnEditCompany.Tag)
                                                    , System.Convert.ToString(EST[9])
                                                    , GTSysOne.Class.Utility.clsGlobal.Instance().STATIONID
                                                    , System.Convert.ToString((int)GTSysOne.Class.Utility.clsGlobal.myFunction.Establishment)
                                                    , GTSysOne.Class.Utility.clsGlobal.Instance().UserId
                                                    , System.Convert.ToString(GTSysOne.Class.Utility.clsUtility.SERVERDATE())
                                                    , System.Convert.ToString(this.btnEditCompany.Tag)
                                                    , this.txtEstablishmentName.Text
                                                    , this.txtEstablishmentShortName.Text
                                                    , this.txtEstablsihmentAddress.Text
                                                    , string.Empty
                                                    , string.Empty
                                                    , GTSysOne.Class.Utility.clsGlobal.Instance().STATIONCPU
                                                    , false
                                                    , "0"));

                                                //Add Station
                                                GTSysOne.Class.MasterFile.clsMas_Station.Save(GTSysOne.Class.MasterFile.clsMas_Station.Value(
                                                      1
                                                    , 0
                                                    , string.Empty
                                                    , string.Empty
                                                    , false
                                                    , false
                                                    , System.Convert.ToString(this.btnEditCompany.Tag)
                                                    , NewEstablishmentId
                                                    , GTSysOne.Class.Utility.clsGlobal.Instance().STATIONID
                                                    , System.Convert.ToString((int)GTSysOne.Class.Utility.clsGlobal.myFunction.Station)
                                                    , GTSysOne.Class.Utility.clsGlobal.Instance().UserId
                                                    , System.Convert.ToString(GTSysOne.Class.Utility.clsUtility.SERVERDATE())
                                                    , NewEstablishmentId
                                                    , this.txtStationName.Text
                                                    , this.txtStationShortName.Text
                                                    , GTSysOne.Class.Utility.clsGlobal.Instance().STATIONCPU
                                                    , false
                                                    , false
                                                    , string.Empty
                                                    , string.Empty
                                                    , string.Empty
                                                    , false
                                                    , System.Convert.ToString(this.lookUpEditTheme.EditValue)
                                                    , false
                                                    , false
                                                    , false
                                                    , false
                                                    , false
                                                    , "0"));
                                            }
                                        }
                                        catch (System.Exception idris)
                                        {
                                            GTSysOne.Class.Utility.clsUtility.GTSysMessageBox(new string[] 
                                            { "Problem with your Provide License,Please ask another License From Head Office."
                                            , "Please Contact GTS™ for more Info."
                                            , idris.Message}
                                            , GTSysOne.Class.Utility.clsGlobal.enMessageBoxButton.OK
                                            , GTSysOne.Class.Utility.clsGlobal.enMessageBoxIcon.Warning
                                            , "Please Take note Of The Following.");
                                        }
                                        break;
                                    case 2://STAT

                                        break;
                                }
                                this.Close();
                            }
                            break;
                    }
                    this.Cursor = System.Windows.Forms.Cursors.Default;
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

        private void PRESSED(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            DevExpress.XtraEditors.ButtonEdit B = sender as DevExpress.XtraEditors.ButtonEdit;
            switch(e.Button.Kind)
            {
                case DevExpress.XtraEditors.Controls.ButtonPredefines.DropDown:
                    switch(B.Name)
                    {
                        case "btnEditCompany":
                            using (var C = new GTSysOne.Gui.Main.frmGTSysList(GTSysOne.Class.Utility.clsGlobal.myFunction.Company))
                            {
                                C.ShowDialog(this);
                                if(C.IS_OK)
                                {
                                    this.btnEditCompany.Tag = C.GetData["id"];
                                    this.btnEditCompany.Text = System.Convert.ToString(C.GetData["Name"]);
                                    C.Dispose();
                                }
                                else
                                {
                                    C.Dispose();
                                }
                            }
                        break;
                    }
                    break;
                case DevExpress.XtraEditors.Controls.ButtonPredefines.Plus:
                    break;
                case DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis:
                    switch (B.Name)
                    {
                        case "btnLoadFile":
                            this.btnLoadFile.Text = this.ReadLKFLRFFile();
                            this.btnLoadFile.Tag = this.btnLoadFile.Text;
                            if (this.btnLoadFile.Text.CompareTo("Cancel") == 0 || this.btnLoadFile.Text.CompareTo("") == 0)
                            {
                                this.btnLoadFile.Text = string.Empty;
                            }
                            break;
                    }
                    break;
            }
        }
        private string ReadLKFLRFFile()
        {
            string values = string.Empty;
            string[] TxtLine = new string[7];
            int ctr = 0;
            System.Windows.Forms.OpenFileDialog theDialog = new System.Windows.Forms.OpenFileDialog();
            theDialog.Title = "Open Text File";
            theDialog.Filter = "{LKF} Files|*.lkf";
            theDialog.InitialDirectory = @"C:\Desktop";
            if (theDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string HQ = "";
                string Store = "";
                switch(this.radSetup.SelectedIndex)
                {
                    case 0:
                        try
                        {
                            HQ = (theDialog.SafeFileName).ToString().Substring((theDialog.SafeFileName).ToString().Length - 12);
                        }
                        catch { }
                        break;
                    case 1:
                        try
                        {
                            Store = (theDialog.SafeFileName).ToString().Substring((theDialog.SafeFileName).ToString().Length - 9);
                        }
                        catch { }
                        break;
                }


                if (HQ.CompareTo("GTSysOne.lkf") == 0 && this.radSetup.SelectedIndex == 0)
                {
                    goto idris;
                }
                else if (Store.CompareTo("ESTAB.lkf") == 0 && this.radSetup.SelectedIndex == 1)
                {
                    goto idris;
                }
                else
                {
                    goto jayrose;
                }
            idris:
                try
                {
                    string filename = theDialog.SafeFileName;
                    using (System.IO.StreamReader sr = new System.IO.StreamReader(theDialog.OpenFile()))
                    {
                        System.String line;
                        while ((line = sr.ReadLine()) != null && ctr < 9)
                        {
                            TxtLine[ctr] = line.Trim();
                            ctr++;
                        }
                        sr.Dispose();
                    }
                    string[] arrLicenceKeys = TxtLine[1].ToString().Split('*');
                    values = arrLicenceKeys[1].ToString();
                }
                catch
                {
                    GTSysOne.Class.Utility.clsUtility.GTSysMessageBox(new string[] 
                    { "License File has been modified. Please Purchase another license." }
                        , GTSysOne.Class.Utility.clsGlobal.enMessageBoxButton.OK
                        , GTSysOne.Class.Utility.clsGlobal.enMessageBoxIcon.Error
                        , "Modified");
                    values = "Cancel";
                }
            }
            else
            {
                values = "Cancel";
            }
        jayrose:
            return values;
        }
        private void GTSLINK(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.ProcessStartInfo sInfo = new System.Diagnostics.ProcessStartInfo(GTSysOne.Class.Utility.clsGlobal.Instance().CompanyWebsite);
            System.Diagnostics.Process.Start(sInfo);
        }

        private void COMPANYSTATCHANGED(object sender, System.EventArgs e)
        {
            GTSysOne.Class.Utility.clsUtility.createlookup(this.lookUpEditEstablishmentStation
                , GTSysOne.Class.MasterFile.clsMas_Establishment.ShowTable(GTSysOne.Class.MasterFile.clsMas_Establishment.Value(0, 4, System.Convert.ToString(this.lookUpEditCompanyStation.EditValue)))
                , new string[] { "Name", "ShortName", "Address" }, "id", "Name");
        }
    }
}