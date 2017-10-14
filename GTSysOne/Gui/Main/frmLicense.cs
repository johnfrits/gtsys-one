namespace GTSysOne.Gui.Main
{
    public partial class frmLicense : DevExpress.XtraEditors.XtraForm
    {

        public static frmLicense p_instance = null;
        public static frmLicense Instance
        {
            get
            {
                if (p_instance == null)
                {
                    p_instance = new frmLicense();
                }
                else
                {
                    if (p_instance.WindowState == System.Windows.Forms.FormWindowState.Minimized)
                    {
                        p_instance.WindowState = System.Windows.Forms.FormWindowState.Normal;
                    }
                }
                p_instance.TopLevel = true;
                p_instance.BringToFront();
                return p_instance;
            }
        }
        protected frmLicense()
        {
            InitializeComponent();
            this.btnUpgrade.Click += new System.EventHandler(this.CLICK);
            this.btnOk.Click += new System.EventHandler(this.CLICK);
            this.btnClose.Click += new System.EventHandler(this.CLICK);
            this.btnClose2.Click += new System.EventHandler(this.CLICK);
            this.btnLoadFile.ButtonPressed += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.PRESSED);
            this.lblGTSysWebsiteLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.GTSLINK);

            this.lblLicenseNo.Text = GTSysOne.Class.Utility.clsGlobal.Instance().CLIENTNO;
            this.lblLicenseType.Text = (GTSysOne.Class.Utility.clsGlobal.Instance().LICENSETYPE == "T" ? "Trial Version" : (GTSysOne.Class.Utility.clsGlobal.Instance().LICENSETYPE == "D" ? "Demo Version" : "Full Version"));
            this.lblSubscriptionEnd.Text = GTSysOne.Class.Utility.clsGlobal.Instance().SUBSCRIPTIONEXPIRED;
            this.lblLicenseCreated.Text = GTSysOne.Class.Utility.clsGlobal.Instance().DATECREATE;
            this.lblTrialDays.Text = System.Convert.ToString(GTSysOne.Class.Utility.clsGlobal.Instance().TRIALDAYS);
            this.lblTotalCompany.Text = System.Convert.ToString(GTSysOne.Class.Utility.clsGlobal.Instance().TOTALCOMPANY);
            this.lblTotalEstablishment.Text = System.Convert.ToString(GTSysOne.Class.Utility.clsGlobal.Instance().TOTALESTABLISHMENT);
            this.lblConcurrentStation.Text =System.Convert.ToString(GTSysOne.Class.Utility.clsGlobal.Instance().TOTALSTATION);

            for (int ctr = 0; ctr < GTSysOne.Class.Utility.clsGlobal.Instance().MODULE.Length; ctr++)
            {
                if (System.Convert.ToString(GTSysOne.Class.Utility.clsGlobal.Instance().MODULE[ctr]) == "1")
                {
                    this.chkGL.Checked = true;
                }
                else if (System.Convert.ToString(GTSysOne.Class.Utility.clsGlobal.Instance().MODULE[ctr]) == "2")
                {
                    this.chkAR.Checked = true;
                }
                else if (System.Convert.ToString(GTSysOne.Class.Utility.clsGlobal.Instance().MODULE[ctr]) == "3")
                {
                    this.chkAP.Checked = true;
                }
                else if (System.Convert.ToString(GTSysOne.Class.Utility.clsGlobal.Instance().MODULE[ctr]) == "4")
                {
                    this.chkinv.Checked = true;
                }
                else if (System.Convert.ToString(GTSysOne.Class.Utility.clsGlobal.Instance().MODULE[ctr]) == "5")
                {
                    this.chkFleet.Checked = true;
                }
                else if (System.Convert.ToString(GTSysOne.Class.Utility.clsGlobal.Instance().MODULE[ctr]) == "6")
                {
                    this.chkCollaboration.Checked = true;
                }
                else if (System.Convert.ToString(GTSysOne.Class.Utility.clsGlobal.Instance().MODULE[ctr]) == "7")
                {
                    this.chkRent.Checked = true;
                }
                else if (System.Convert.ToString(GTSysOne.Class.Utility.clsGlobal.Instance().MODULE[ctr]) == "8")
                {
                    this.chkBanking.Checked = true;
                }
                else if (System.Convert.ToString(GTSysOne.Class.Utility.clsGlobal.Instance().MODULE[ctr]) == "9")
                {
                    this.chkDefault.Checked = true;
                }
            }
        }
        private void PRESSED(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            DevExpress.XtraEditors.ButtonEdit B = sender as DevExpress.XtraEditors.ButtonEdit;
            switch (e.Button.Kind)
            {
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
            string[] TxtLine = new string[8];
            int ctr = 0;
            System.Windows.Forms.OpenFileDialog theDialog = new System.Windows.Forms.OpenFileDialog();
            theDialog.Title = "Open Text File";
            theDialog.Filter = "{LKF} Files|*.lkf";
            theDialog.InitialDirectory = @"C:\Desktop";
            if (theDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string HQ = "";
                try
                {
                    HQ = (theDialog.SafeFileName).ToString().Substring((theDialog.SafeFileName).ToString().Length - 12);
                }
                catch { }
                if (HQ.CompareTo("GTSysOne.lkf") == 0)
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
                    GTSysOne.Class.Utility.clsUtility.GTSysMessageBox(new string[] { "License File has been modified. Please Purchase another license." }
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
        private void CLICK(object sender, System.EventArgs e)
        {
            DevExpress.XtraEditors.SimpleButton b = sender as DevExpress.XtraEditors.SimpleButton;
            switch(b.Name)
            {
                case "btnUpgrade":
                    if (this.btnLoadFile.Text != string.Empty)
                    {
                        GTSysOne.Class.Document.clsDoc_Lcg.Save(GTSysOne.Class.Document.clsDoc_Lcg.Value(
                                             2
                                            , 0
                                            , GTSysOne.Class.Utility.clsGlobal.Instance().LICENSEID
                                            , string.Empty
                                            , false
                                            , false
                                            , false
                                            , GTSysOne.Class.Utility.clsGlobal.Instance().COMPANYID
                                            , GTSysOne.Class.Utility.clsGlobal.Instance().ESTABLISHMENTID
                                            , GTSysOne.Class.Utility.clsGlobal.Instance().STATIONID
                                            , System.Convert.ToString((int)GTSysOne.Class.Utility.clsGlobal.myFunction.License)
                                            , GTSysOne.Class.Utility.clsGlobal.Instance().UserId
                                            , string.Empty
                                            , System.Convert.ToString(this.btnLoadFile.Text)
                                            , string.Empty
                                            , "0"));
                        System.Data.DataTable dtEsta = GTSysOne.Class.MasterFile.clsMas_Establishment.ShowTable(GTSysOne.Class.MasterFile.clsMas_Establishment.Value(0,3));
                        for(int ctr =0;ctr < dtEsta.Rows.Count;ctr++)
                        {
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
                                                    + "*" + dtEsta.Rows[ctr]["id"], "");
                            //UPDATE EST
                            GTSysOne.Class.MasterFile.clsMas_Establishment.Save(GTSysOne.Class.MasterFile.clsMas_Establishment.Value(
                                  2
                                , 0
                                , System.Convert.ToString(dtEsta.Rows[ctr]["id"])
                                , string.Empty
                                , false
                                , false
                                , GTSysOne.Class.Utility.clsGlobal.Instance().COMPANYID
                                , GTSysOne.Class.Utility.clsGlobal.Instance().ESTABLISHMENTID
                                , GTSysOne.Class.Utility.clsGlobal.Instance().STATIONID
                                , System.Convert.ToString((int)GTSysOne.Class.Utility.clsGlobal.myFunction.Establishment)
                                , GTSysOne.Class.Utility.clsGlobal.Instance().UserId
                                , string.Empty
                                , string.Empty
                                , System.Convert.ToString(dtEsta.Rows[ctr]["name"])
                                , System.Convert.ToString(dtEsta.Rows[ctr]["shortname"])
                                , System.Convert.ToString(dtEsta.Rows[ctr]["address"])
                                , string.Empty
                                , CONTROL
                                , System.Convert.ToString(dtEsta.Rows[ctr]["cpu"])
                                , System.Convert.ToBoolean(dtEsta.Rows[ctr]["virtual"])
                                , "0"));
                        }
                        GTSysOne.Class.Utility.clsGlobal.Instance().LogOut = true;
                        this.Close();
                    }
                    break;
                case "btnOk":
                    if(GTSysOne.Class.Utility.clsUtility.GTSysMessageBox(new string[] {"Note: You request "
                        ,this.txtTotalCompany.Text + " Total Number of Company" 
                        ,this.txtTotalEstablishment.Text + " Total Number of Establishment"
                        ,"If you agree Click YES otherwise NO."
                        }
                        ,GTSysOne.Class.Utility.clsGlobal.enMessageBoxButton.YesNo
                        ,GTSysOne.Class.Utility.clsGlobal.enMessageBoxIcon.Question
                        ,"Request") == System.Windows.Forms.DialogResult.Yes)
                    {
                        System.Windows.Forms.FolderBrowserDialog fd = new System.Windows.Forms.FolderBrowserDialog();
                        if (fd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        {
                            if (!System.IO.File.Exists(@fd.SelectedPath + "\\(" + GTSysOne.Class.Utility.clsGlobal.Instance().CLIENTNO + ")RequestGTSYONE.lrf"))
                            {
                                using (System.IO.TextWriter tw = new System.IO.StreamWriter(@fd.SelectedPath + "\\(" + GTSysOne.Class.Utility.clsGlobal.Instance().CLIENTNO + ")RequestGTSYONE.lrf", true))
                                {
                                    tw.WriteLine("-----****************Measure what can be measure....*******************--------------");
                                    tw.WriteLine("License Key*" +GTSysOne.Class.Utility.clsEncryption.JayDhreiZIP.Encrypt(GTSysOne.Class.Utility.clsGlobal.Instance().COLICENSE, ""));
                                    tw.WriteLine("Customer#:" + GTSysOne.Class.Utility.clsGlobal.Instance().CLIENTNO);
                                    tw.WriteLine("CPUID:" + GTSysOne.Class.Utility.clsGlobal.Instance().STATIONCPU + ":" + this.txtTotalCompany.Text + ":" + this.txtTotalEstablishment.Text);
                                    tw.WriteLine("-----****************And make measurable what cannot be measured....*******************--------------");
                                    tw.Dispose();
                                    tw.Close();
                                    System.IO.File.SetAttributes(@fd.SelectedPath + "\\(" + GTSysOne.Class.Utility.clsGlobal.Instance().CLIENTNO + ")RequestGTSYONE.lrf", System.IO.FileAttributes.ReadOnly);

                                }
                                GTSysOne.Class.Utility.clsUtility.GTSysMessageBox(new string[] 
                                    {"Save License location " + @fd.SelectedPath + "\\(" + GTSysOne.Class.Utility.clsGlobal.Instance().CLIENTNO + ")RequestGTSYONE.lrf"
                                    }
                                    , GTSysOne.Class.Utility.clsGlobal.enMessageBoxButton.OK
                                    , GTSysOne.Class.Utility.clsGlobal.enMessageBoxIcon.Information
                                    , "License");
                            }
                            else
                            {
                                GTSysOne.Class.Utility.clsUtility.GTSysMessageBox(new string[] 
                                    {"File name already exist to this location."
                                    ,"Please place it on another location."
                                    }
                                    , GTSysOne.Class.Utility.clsGlobal.enMessageBoxButton.OK
                                    , GTSysOne.Class.Utility.clsGlobal.enMessageBoxIcon.Warning
                                    , "License");
                            }
                        }
                    }
                    break;
                case "btnClose":
                case "btnClose2":
                    this.Close();
                    break;
            }
        }
        private void GTSLINK(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.ProcessStartInfo sInfo = new System.Diagnostics.ProcessStartInfo(GTSysOne.Class.Utility.clsGlobal.Instance().CompanyWebsite);
            System.Diagnostics.Process.Start(sInfo);
        }
    }
}