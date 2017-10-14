namespace GTSysOne.Gui.MasterFile
{
    public partial class frmRenter : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        #region VARIABLE
        System.Data.DataTable dtRecord = null;
        #endregion

        #region PROPERTY
        private static string p_Id = "";
        public string Id
        {
            get { return p_Id; }
            set { p_Id = value; }
        }

        private static bool p_UseDashboard = true;
        public bool UseDashboard
        {
            get { return p_UseDashboard; }
            set { p_UseDashboard = value; }
        }
        #endregion

        #region ENUM
        private static enFormStatus e;
        public enFormStatus EnformStatus
        {
            get { return e; }
            set { e = value; }
        }
        public enum enFormStatus
        {
            Add = 0,
            Edit = 1,
            View = 2,
        }

        private static enFormFunction f;
        public enFormFunction EnformFunction
        {
            get { return f; }
            set { f = value; }
        }
        public enum enFormFunction
        {
            Renter = 70005,
  
        }
        #endregion

        #region Constructor
        public static frmRenter p_instance = null;
        public static frmRenter Instance
        {
            get
            {
                if (p_instance == null)
                {
                    p_instance = new frmRenter();
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
        protected frmRenter()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.FORM_LOAD);
        }
        #endregion
        private void EventHandler(bool CreateProperties = true)
        {
            if (CreateProperties)
            {
                this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FORMCLOSING);
                this.barNew.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.CLICK);
                this.barSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.CLICK);
                this.barFirst.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.CLICK);
                this.barPrevious.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.CLICK);
                this.barNext.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.CLICK);
                this.barLast.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.CLICK);
                this.barClose.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.CLICK);


                this.repositoryItemSearchControl1.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.SEARCH_PRESSED);

                this.GridLayout(GTSysOne.Class.Utility.clsGlobal.GridLayout.Restore);
            }
            else
            {
                this.FormClosing -= new System.Windows.Forms.FormClosingEventHandler(this.FORMCLOSING);
                this.barNew.ItemClick -= new DevExpress.XtraBars.ItemClickEventHandler(this.CLICK);
                this.barSave.ItemClick -= new DevExpress.XtraBars.ItemClickEventHandler(this.CLICK);
                this.barFirst.ItemClick -= new DevExpress.XtraBars.ItemClickEventHandler(this.CLICK);
                this.barPrevious.ItemClick -= new DevExpress.XtraBars.ItemClickEventHandler(this.CLICK);
                this.barNext.ItemClick -= new DevExpress.XtraBars.ItemClickEventHandler(this.CLICK);
                this.barLast.ItemClick -= new DevExpress.XtraBars.ItemClickEventHandler(this.CLICK);
                this.barClose.ItemClick -= new DevExpress.XtraBars.ItemClickEventHandler(this.CLICK);


                this.repositoryItemSearchControl1.ButtonClick -= new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.SEARCH_PRESSED);
            }
        }
        private void Mapping()
        {
            dtRecord = new System.Data.DataTable();
            dtRecord = GTSysOne.Class.MasterFile.clsMas_Renter.ShowTable(GTSysOne.Class.MasterFile.clsMas_Renter.Value(0, 3
                , Id
                , string.Empty
                , false
                , false
                , GTSysOne.Class.Utility.clsGlobal.Instance().COMPANYID));
            if (dtRecord.Rows.Count > 0)
            {
                this.txtNumbering.Text = System.Convert.ToString(dtRecord.Rows[0]["num"]);

                this.txtRenterName.Text = System.Convert.ToString(dtRecord.Rows[0]["renter_name"]);
                this.textEditdob.Text = System.Convert.ToString(dtRecord.Rows[0]["dob"]);
                this.textEditpob.Text = System.Convert.ToString(dtRecord.Rows[0]["pob"]);
                this.textEditLicenseNo.Text = System.Convert.ToString(dtRecord.Rows[0]["license_no"]);
                this.textEditPlaceOfIssue.Text = System.Convert.ToString(dtRecord.Rows[0]["place_of_issue"]);
                this.textEditIssueDate.Text = System.Convert.ToString(dtRecord.Rows[0]["issue_date"]);
                this.textEditExpiryDate.Text = System.Convert.ToString(dtRecord.Rows[0]["expiry_date"]);
                this.txtTelephoneNumber.Text = System.Convert.ToString(dtRecord.Rows[0]["expiry_date"]);
                this.textEditExpiryDate.Text = System.Convert.ToString(dtRecord.Rows[0]["renter_tel"]);


                if (EnformStatus == GTSysOne.Gui.MasterFile.frmRenter.enFormStatus.View)
                {
                    this.Enable(false);
                }
            }
            if (EnformStatus == GTSysOne.Gui.MasterFile.frmRenter.enFormStatus.Add)
            {
                this.Enable(true);
                this.txtNumbering.Text = GTSysOne.Class.Utility.clsUtility.Numbering(GTSysOne.Class.Utility.clsGlobal.myFunction.Renter);
            }
            if (this.txtNumbering.Text.CompareTo(string.Empty) == 0)
            {
                this.txtNumbering.Enabled = true;
            }
            else
            {
                this.txtNumbering.Enabled = false;
            }
            if (EnformStatus == GTSysOne.Gui.MasterFile.frmRenter.enFormStatus.View)
            {
                this.txtNumbering.Enabled = false;
            }
        }
        private void Clear()
        {
            this.txtNumbering.Text = string.Empty;
            this.txtRenterName.Text = string.Empty;
            this.textEditdob.Text = string.Empty;
            this.textEditpob.Text = string.Empty;
            this.textEditLicenseNo.Text = string.Empty;
            this.textEditPlaceOfIssue.Text = string.Empty;
            this.textEditIssueDate.Text = string.Empty;
            this.textEditExpiryDate.Text = string.Empty;
            this.txtTelephoneNumber.Text = string.Empty;
            this.textEditExpiryDate.Text = string.Empty;
            Id = string.Empty;
        }
        private void Enable(bool sw)
        {
            this.txtNumbering.Enabled = sw;
            this.txtRenterName.Enabled = sw;
            this.textEditdob.Enabled = sw;
            this.textEditpob.Enabled = sw;
            this.textEditLicenseNo.Enabled = sw;
            this.textEditPlaceOfIssue.Enabled = sw;
            this.textEditIssueDate.Enabled = sw;
            this.textEditExpiryDate.Enabled = sw;
            this.txtTelephoneNumber.Enabled = sw;
            this.textEditExpiryDate.Enabled = sw;
            this.barSave.Enabled = sw;
        }
        private void GridLayout(GTSysOne.Class.Utility.clsGlobal.GridLayout L)
        {
            //GTSysOne.Class.Utility.clsUtility.Layout_Restore_Save(this.gridViewUserPrivileges, L, GTSysOne.Class.Utility.clsGlobal.Instance().GridLayoutLocation + "Document\\" + this.Name.Replace("frm", ""), "Privileges", this.gridControlUserPrivileges);
            //GTSysOne.Class.Utility.clsUtility.Layout_Restore_Save(this.gridViewCompanyAccess, L, GTSysOne.Class.Utility.clsGlobal.Instance().GridLayoutLocation + "Document\\" + this.Name.Replace("frm", ""), "CompanyAccess", this.gridControlCompanyAccess);
            //GTSysOne.Class.Utility.clsUtility.Layout_Restore_Save(this.gridViewEstablishment, L, GTSysOne.Class.Utility.clsGlobal.Instance().GridLayoutLocation + "Document\\" + this.Name.Replace("frm", ""), "Establishment", this.gridControlEstablishment);
        }
        private void FORM_LOAD(object sender, System.EventArgs e)
        {
            this.Mapping();
            this.EventHandler();
            GTSysOne.Class.Utility.clsUtility.Language(this, typeof(GTSysOne.Gui.MasterFile.frmRenter).Assembly);
        }
        private void FORMCLOSING(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            p_Id = string.Empty;
            Id = string.Empty;
            this.GridLayout(GTSysOne.Class.Utility.clsGlobal.GridLayout.Save);
        }
        private void SEARCH_PRESSED(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if ((sender as DevExpress.XtraEditors.ButtonEdit).Properties.Buttons.IndexOf(e.Button) == 1)
            {
                string ResultId = System.Convert.ToString(GTSysOne.Class.MasterFile.clsMas_Renter.ScalarValue(GTSysOne.Class.MasterFile.clsMas_Renter.Value(0
                    , 4
                    , System.Convert.ToString((sender as DevExpress.XtraEditors.ButtonEdit).Text)
                    , string.Empty
                    , false
                    , false
                    , GTSysOne.Class.Utility.clsGlobal.Instance().COMPANYID)));
                if (ResultId.CompareTo(string.Empty) != 0)
                {
                    EnformStatus = GTSysOne.Gui.MasterFile.frmRenter.enFormStatus.Edit;
                    Id = ResultId;
                    this.EventHandler(false);
                    this.Mapping();
                    this.EventHandler(true);
                }
            }
        }
        private void CLICK(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string ResultId = string.Empty;
            switch (e.Item.Name)
            {
                case "barNew":
                    GTSysOne.Class.Utility.clsGlobal.Instance().Err.ClearErrors();
                    GTSysOne.Class.Utility.clsGlobal.Instance().No_Error_Result = true;
                    EnformStatus = GTSysOne.Gui.MasterFile.frmRenter.enFormStatus.Add;
                    Id = string.Empty;
                    this.EventHandler(false);
                    this.Clear();
                    this.Mapping();
                    this.EventHandler(true);
                    break;
                case "barSave":
                    GTSysOne.Class.Utility.clsGlobal.Instance().Err.ClearErrors();
                    GTSysOne.Class.Utility.clsGlobal.Instance().No_Error_Result = true;
                    GTSysOne.Class.Utility.clsUtility.ValidateControl(this.txtNumbering);
                    GTSysOne.Class.Utility.clsUtility.ValidateControl(this.txtRenterName);
                    if (GTSysOne.Class.Utility.clsGlobal.Instance().No_Error_Result)
                    {

                        Id = GTSysOne.Class.MasterFile.clsMas_Renter.Save(
                            GTSysOne.Class.MasterFile.clsMas_Renter.Value(
                            (EnformStatus == GTSysOne.Gui.MasterFile.frmRenter.enFormStatus.Add ? 1 : 2)
                            , 0
                            , Id
                            , (EnformStatus == GTSysOne.Gui.MasterFile.frmRenter.enFormStatus.Add ? (this.txtNumbering.Enabled == false ? GTSysOne.Class.Utility.clsUtility.Numbering(GTSysOne.Class.Utility.clsGlobal.myFunction.Renter, true) : this.txtNumbering.Text) : this.txtNumbering.Text)
                            , false // (this.chkActive.Checked ? false : true)
                            , false
                            , GTSysOne.Class.Utility.clsGlobal.Instance().COMPANYID
                            , GTSysOne.Class.Utility.clsGlobal.Instance().ESTABLISHMENTID
                            , GTSysOne.Class.Utility.clsGlobal.Instance().STATIONID
                            , System.Convert.ToString((int)GTSysOne.Class.Utility.clsGlobal.myFunction.Renter)
                            , GTSysOne.Class.Utility.clsGlobal.Instance().UserId
                            , string.Empty
                            , this.txtRenterName.Text
                            , this.textEditdob.Text
                            , this.textEditpob.Text
                            , this.textEditLicenseNo.Text
                            , this.textEditPlaceOfIssue.Text
                            , this.textEditIssueDate.Text
                            , this.textEditExpiryDate.Text
                            , this.txtTelephoneNumber.Text
                            , "0"));

                            GTSysOne.Gui.Dashboard.MasterFile.frmRenter.CallFromMain("Refresh", Id, false, 1, Id);
                            this.Clear();
                            this.Mapping();
                    }
                    break;
                case "barFirst":
                    ResultId = GTSysOne.Class.Utility.clsUtility.Navigator(Id, "2", GTSysOne.Class.Utility.clsGlobal.myFunction.Renter);
                    if (ResultId.CompareTo(string.Empty) != 0)
                    {
                        if (EnformStatus != GTSysOne.Gui.MasterFile.frmRenter.enFormStatus.View)
                        {
                            EnformStatus = GTSysOne.Gui.MasterFile.frmRenter.enFormStatus.Edit;
                        }
                        Id = ResultId;
                        this.EventHandler(false);
                        this.Mapping();
                        this.EventHandler(true);
                    }
                    break;
                case "barPrevious":
                    ResultId = GTSysOne.Class.Utility.clsUtility.Navigator(Id, "0", GTSysOne.Class.Utility.clsGlobal.myFunction.Renter);
                    if (ResultId.CompareTo(string.Empty) != 0)
                    {
                        if (EnformStatus != GTSysOne.Gui.MasterFile.frmRenter.enFormStatus.View)
                        {
                            EnformStatus = GTSysOne.Gui.MasterFile.frmRenter.enFormStatus.Edit;
                        }
                        Id = ResultId;
                        this.EventHandler(false);
                        this.Mapping();
                        this.EventHandler(true);
                    }
                    break;
                case "barNext":
                    ResultId = GTSysOne.Class.Utility.clsUtility.Navigator(Id, "1", GTSysOne.Class.Utility.clsGlobal.myFunction.Renter);
                    if (ResultId.CompareTo(string.Empty) != 0)
                    {
                        if (EnformStatus != GTSysOne.Gui.MasterFile.frmRenter.enFormStatus.View)
                        {
                            EnformStatus = GTSysOne.Gui.MasterFile.frmRenter.enFormStatus.Edit;
                        }
                        Id = ResultId;
                        this.EventHandler(false);
                        this.Mapping();
                        this.EventHandler(true);
                    }
                    break;
                case "barLast":
                    ResultId = GTSysOne.Class.Utility.clsUtility.Navigator(Id, "3", GTSysOne.Class.Utility.clsGlobal.myFunction.Renter);
                    if (ResultId.CompareTo(string.Empty) != 0)
                    {
                        if (EnformStatus != GTSysOne.Gui.MasterFile.frmRenter.enFormStatus.View)
                        {
                            EnformStatus = GTSysOne.Gui.MasterFile.frmRenter.enFormStatus.Edit;
                        }
                        Id = ResultId;
                        this.EventHandler(false);
                        this.Mapping();
                        this.EventHandler(true);
                    }
                    break;
                case "barClose":
                    p_instance.Close();
                    break;
            }
        }


    }
}