namespace GTSysOne.Gui.Document
{
    public partial class frmUser : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        #region VARIABLE
        System.Data.DataTable dtUserRecord = null;
        string PrivilegeId = string.Empty;
        public bool FromLogIn = false;
        public string NewCompany = string.Empty;
        public string NewUserName = string.Empty;
        public string NewPassword = string.Empty;
        #endregion

        #region PROPERTY
        private static string p_Id = "";
        public string Id
        {
            get { return p_Id; }
            set { p_Id = value; }
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
        #endregion

        #region Constructor
        public static frmUser p_instance = null;
        public static frmUser Instance
        {
            get
            {
                if (p_instance == null)
                {
                    p_instance = new frmUser();
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
        protected frmUser()
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

                this.lookUpEditEstablishment.EditValueChanged += new System.EventHandler(this.VALUE);
                this.lookUpEditEstablishment2.EditValueChanged += new System.EventHandler(this.VALUE);
                this.lookUpEditCompany.EditValueChanged += new System.EventHandler(this.VALUE);
                this.lookUpEditCompany2.EditValueChanged += new System.EventHandler(this.VALUE);
                this.lookUpEditAccountType.EditValueChanged += new System.EventHandler(this.VALUE);
                this.lookUpEditPrivilege.EditValueChanged += new System.EventHandler(this.VALUE);

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

                this.lookUpEditEstablishment.EditValueChanged -= new System.EventHandler(this.VALUE);
                this.lookUpEditEstablishment2.EditValueChanged -= new System.EventHandler(this.VALUE);
                this.lookUpEditCompany.EditValueChanged -= new System.EventHandler(this.VALUE);
                this.lookUpEditCompany2.EditValueChanged -= new System.EventHandler(this.VALUE);
                this.lookUpEditAccountType.EditValueChanged -= new System.EventHandler(this.VALUE);
                this.lookUpEditPrivilege.EditValueChanged -= new System.EventHandler(this.VALUE);

                this.repositoryItemSearchControl1.ButtonClick -= new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.SEARCH_PRESSED);
            }
        }


        private void Mapping()
        {
            GTSysOne.Class.Utility.clsUtility.createlookup(this.lookUpEditCompany, GTSysOne.Class.Document.clsDoc_Company.ShowTable(GTSysOne.Class.Document.clsDoc_Company.Value(0, 0)), new string[] { "Name", "Address", "Owner" }, "id", "Name");
            GTSysOne.Class.Utility.clsUtility.createlookup(this.lookUpEditCompany2, GTSysOne.Class.Document.clsDoc_Company.ShowTable(GTSysOne.Class.Document.clsDoc_Company.Value(0, 0)), new string[] { "Name", "Address", "Owner" }, "id", "Name");

            GTSysOne.Class.Utility.clsUtility.createlookup(this.lookUpEditEstablishment, GTSysOne.Class.MasterFile.clsMas_Establishment.ShowTable(GTSysOne.Class.MasterFile.clsMas_Establishment.Value(0, 2)), new string[] { "Name", "ShortName","Address" }, "id", "Name");
            GTSysOne.Class.Utility.clsUtility.createlookup(this.lookUpEditEstablishment2, GTSysOne.Class.MasterFile.clsMas_Establishment.ShowTable(GTSysOne.Class.MasterFile.clsMas_Establishment.Value(0, 2)), new string[] { "Name", "ShortName","Address" }, "id", "Name");

            System.Data.DataTable dt = new System.Data.DataTable();
            dt.Columns.Add("id",typeof(string));
            dt.Columns.Add("Name", typeof(string));
            dt.Rows.Add("0", "Customize");
            dt.Rows.Add("1", "From User Group");
            GTSysOne.Class.Utility.clsUtility.createlookup(this.lookUpEditAccountType, dt, new string[] { "Name" }, "id", "Name");

            GTSysOne.Class.Utility.clsUtility.View(this.gridControlCompanyAccess
                , this.gridViewCompanyAccess
                ,0
                ,GTSysOne.Class.Slip.clsSlip_UserCompanyAccess.ShowTable(GTSysOne.Class.Slip.clsSlip_UserCompanyAccess.Value(0,0,Id))
                ,string.Empty
                ,true);

            GTSysOne.Class.Utility.clsUtility.View(this.gridControlEstablishment
                , this.gridViewEstablishment
                , 0
                , GTSysOne.Class.Slip.clsSlip_UserEstablishmentAccess.ShowTable(GTSysOne.Class.Slip.clsSlip_UserEstablishmentAccess.Value(0, 0, Id))
                , string.Empty
                , true);

            dtUserRecord = new System.Data.DataTable();
            dtUserRecord = GTSysOne.Class.Document.clsDoc_User.ShowTable(GTSysOne.Class.Document.clsDoc_User.Value(0, 3, Id));

            if (dtUserRecord.Rows.Count > 0)
            {
                PrivilegeId = System.Convert.ToString(dtUserRecord.Rows[0]["doc_sourced_user_privilege"]);

                this.txtNumbering.Text = System.Convert.ToString(dtUserRecord.Rows[0]["num"]);

                this.txtUserName.Text = System.Convert.ToString(dtUserRecord.Rows[0]["uname"]);
                this.txtPassword.Text = GTSysOne.Class.Utility.clsEncryption.JayDhreiZIP.Decrypt(System.Convert.ToString(dtUserRecord.Rows[0]["passtext"]),"");
                this.txtConfirmPassword.Text = GTSysOne.Class.Utility.clsEncryption.JayDhreiZIP.Decrypt(System.Convert.ToString(dtUserRecord.Rows[0]["passtext"]),"");
                this.chkActivate.Checked = !System.Convert.ToBoolean(dtUserRecord.Rows[0]["void"]);
                this.chkAdmin.Checked = System.Convert.ToBoolean(dtUserRecord.Rows[0]["admin"]);

                this.lookUpEditCompany.EditValue = dtUserRecord.Rows[0]["defcompany"];
                this.lookUpEditEstablishment.EditValue = dtUserRecord.Rows[0]["defestablishment"];
                this.lookUpEditAccountType.EditValue = dtUserRecord.Rows[0]["accounttype"];

                if(this.lookUpEditCompany.EditValue != null)
                {
                    this.xTabCompanyAccess.PageEnabled = true;
                }
                if (this.lookUpEditEstablishment.EditValue != null)
                {
                    this.xTabEstablishmentAccess.PageEnabled = true;
                }
                if (this.lookUpEditAccountType.EditValue != null)
                {
                    this.xTabPrivilege.PageEnabled = true;
                }
                this.lookUpEditAccountType.Enabled = false;
                switch (System.Convert.ToString(this.lookUpEditAccountType.EditValue))
                {
                    case "0":
                        GTSysOne.Class.Utility.clsUtility.createlookup(this.lookUpEditPrivilege, GTSysOne.Class.Mapping.clsMap_Privilege.ShowTable(GTSysOne.Class.Mapping.clsMap_Privilege.Value(0, 0)), new string[] { "Name" }, "id", "Name");
                        break;
                    case "1":
                        GTSysOne.Class.Utility.clsUtility.createlookup(this.lookUpEditPrivilege, GTSysOne.Class.Document.clsDoc_UserPrivilege.ShowTable(GTSysOne.Class.Document.clsDoc_UserPrivilege.Value(0, 0)), new string[] { "Name" }, "id", "Name");
                        break;
                }
                this.xtraTabControlUser.SelectedTabPage = this.xTabPrivilege;
                if (EnformStatus == GTSysOne.Gui.Document.frmUser.enFormStatus.Add)
                {
                    this.Enable(true);
                    this.xTabPrivilege.PageEnabled = false;
                    this.xTabCompanyAccess.PageEnabled = false;
                    this.xTabEstablishmentAccess.PageEnabled = false;
                    this.gridViewUserPrivileges.OptionsBehavior.ReadOnly = false;
                    this.gridViewCompanyAccess.OptionsBehavior.ReadOnly = false;
                    this.gridViewEstablishment.OptionsBehavior.ReadOnly = false;
                }
                else if (EnformStatus == GTSysOne.Gui.Document.frmUser.enFormStatus.View)
                {
                    this.Enable(false);
                }
            }
            if (EnformStatus == GTSysOne.Gui.Document.frmUser.enFormStatus.Add)
            {
                this.Enable(true);
                this.xTabPrivilege.PageEnabled = false;
                this.xTabCompanyAccess.PageEnabled = false;
                this.xTabEstablishmentAccess.PageEnabled = false;
                this.gridViewUserPrivileges.OptionsBehavior.ReadOnly = false;
                this.gridViewCompanyAccess.OptionsBehavior.ReadOnly = false;
                this.gridViewEstablishment.OptionsBehavior.ReadOnly = false;
                this.txtNumbering.Text = GTSysOne.Class.Utility.clsUtility.Numbering(GTSysOne.Class.Utility.clsGlobal.myFunction.User);
            }
            if (this.txtNumbering.Text.CompareTo(string.Empty) == 0)
            {
                this.txtNumbering.Enabled = true;
            }
            else
            {
                this.txtNumbering.Enabled = false;
            }
            if (EnformStatus == GTSysOne.Gui.Document.frmUser.enFormStatus.View)
            {
                this.txtNumbering.Enabled = false;
            }
            GTSysOne.Class.Utility.clsUtility.View(this.gridControlUserPrivileges
                , this.gridViewUserPrivileges
                , 0
                , GTSysOne.Class.Slip.clsSlip_UserPrivilege.ShowTable(GTSysOne.Class.Slip.clsSlip_UserPrivilege.Value(0, 0, PrivilegeId))
                , string.Empty
                , true);
        }
        private void Clear()
        {
            this.txtNumbering.Text = string.Empty;
            this.txtUserName.Text = string.Empty;
            this.txtPassword.Text = string.Empty;
            this.txtConfirmPassword.Text = string.Empty;

            this.lookUpEditCompany.Text = string.Empty;
            this.lookUpEditCompany.EditValue = null;
            this.lookUpEditCompany2.Text = string.Empty;
            this.lookUpEditCompany2.EditValue = null;
            this.lookUpEditEstablishment.Text = string.Empty;
            this.lookUpEditEstablishment.EditValue = null;
            this.lookUpEditEstablishment2.Text = string.Empty;
            this.lookUpEditEstablishment2.EditValue = null;

            this.lookUpEditAccountType.Text = string.Empty;
            this.lookUpEditAccountType.EditValue = null;

            this.lookUpEditPrivilege.Text = string.Empty;
            this.lookUpEditPrivilege.EditValue = null;

            this.chkActivate.Checked = false;
            this.chkAdmin.Checked = false;
            Id = string.Empty;
            PrivilegeId = string.Empty;
        }
        private void Enable(bool sw)
        {
            
            this.txtUserName.Enabled = sw;
            this.txtPassword.Enabled = sw;
            this.txtConfirmPassword.Enabled = sw;

            this.lookUpEditCompany.Enabled = sw;
            this.lookUpEditCompany2.Enabled = sw;
            this.lookUpEditEstablishment.Enabled = sw;
            this.lookUpEditEstablishment2.Enabled = sw;

            this.lookUpEditAccountType.Enabled = sw;

            this.lookUpEditPrivilege.Enabled = sw;

            this.chkActivate.Enabled = sw;
            this.chkAdmin.Enabled = sw;

            this.gridViewUserPrivileges.OptionsBehavior.ReadOnly = !sw;
            this.gridViewCompanyAccess.OptionsBehavior.ReadOnly = !sw;
            this.gridViewEstablishment.OptionsBehavior.ReadOnly = !sw;

            this.barSave.Enabled = sw;
        }
        private void GridLayout(GTSysOne.Class.Utility.clsGlobal.GridLayout L)
        {
            GTSysOne.Class.Utility.clsUtility.Layout_Restore_Save(this.gridViewUserPrivileges, L, GTSysOne.Class.Utility.clsGlobal.Instance().GridLayoutLocation + "Document\\"+this.Name.Replace("frm", ""), "Privileges" , this.gridControlUserPrivileges);
            GTSysOne.Class.Utility.clsUtility.Layout_Restore_Save(this.gridViewCompanyAccess, L, GTSysOne.Class.Utility.clsGlobal.Instance().GridLayoutLocation + "Document\\" + this.Name.Replace("frm", ""), "CompanyAccess", this.gridControlCompanyAccess);
            GTSysOne.Class.Utility.clsUtility.Layout_Restore_Save(this.gridViewEstablishment, L, GTSysOne.Class.Utility.clsGlobal.Instance().GridLayoutLocation + "Document\\" + this.Name.Replace("frm", ""), "Establishment", this.gridControlEstablishment);
        }
        private void FORM_LOAD(object sender, System.EventArgs e)
        {
            this.Mapping();
            this.EventHandler();
            GTSysOne.Class.Utility.clsUtility.Language(this, typeof(GTSysOne.Gui.Document.frmUser).Assembly);
            if(FromLogIn)
            {
                this.chkActivate.Checked = true;
                this.chkActivate.Enabled = false;

                this.chkAdmin.Checked = true;
                this.chkAdmin.Enabled = false;
            }
        }
        private void FORMCLOSING(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            p_Id = string.Empty;
            Id = string.Empty;
            this.GridLayout(GTSysOne.Class.Utility.clsGlobal.GridLayout.Save);
        }
        private void CLICK(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string ResultId = string.Empty;
            switch(e.Item.Name)
            {
                case "barNew":
                    GTSysOne.Class.Utility.clsGlobal.Instance().Err.ClearErrors();
                    GTSysOne.Class.Utility.clsGlobal.Instance().No_Error_Result = true;
                    EnformStatus = GTSysOne.Gui.Document.frmUser.enFormStatus.Add;
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
                    GTSysOne.Class.Utility.clsUtility.ValidateControl(this.txtUserName);
                    GTSysOne.Class.Utility.clsUtility.ValidateControl(this.txtPassword);
                    GTSysOne.Class.Utility.clsUtility.ValidateControl(this.txtConfirmPassword);
                    GTSysOne.Class.Utility.clsUtility.ValidateControl(this.lookUpEditCompany);
                    GTSysOne.Class.Utility.clsUtility.ValidateControl(this.lookUpEditEstablishment);
                    GTSysOne.Class.Utility.clsUtility.ValidateControl(this.lookUpEditAccountType);

                    if (System.Convert.ToString(GTSysOne.Class.Document.clsDoc_User.ScalarValue(GTSysOne.Class.Document.clsDoc_User.Value(0, 5,Id, this.txtUserName.Text))).CompareTo(string.Empty) != 0)
                    {
                        GTSysOne.Class.Utility.clsUtility.ValidateControl(this.txtUserName, "Duplicate Username",true);
                        GTSysOne.Class.Utility.clsGlobal.Instance().No_Error_Result = false;
                    }

                    if (this.txtPassword.Text != this.txtConfirmPassword.Text)
                    {
                        GTSysOne.Class.Utility.clsUtility.ValidateControl(this.txtPassword,"Confirmed Password",true);
                        GTSysOne.Class.Utility.clsUtility.ValidateControl(this.txtConfirmPassword, "Confirmed Password",true);
                        GTSysOne.Class.Utility.clsGlobal.Instance().No_Error_Result = false;
                    }

                    if (this.txtPassword.Text == this.txtConfirmPassword.Text && GTSysOne.Class.Utility.clsGlobal.Instance().No_Error_Result)
                    {
                        PrivilegeId = GTSysOne.Class.Document.clsDoc_UserPrivilege.Save(GTSysOne.Class.Document.clsDoc_UserPrivilege.Value(
                                    (EnformStatus == GTSysOne.Gui.Document.frmUser.enFormStatus.Add ? 1 : 2)
                                    , 0
                                    , PrivilegeId
                                    ,string.Empty
                                    ,"0"
                                    ,"0"
                                    ,"0"
                                    , GTSysOne.Class.Utility.clsGlobal.Instance().COMPANYID
                                    , GTSysOne.Class.Utility.clsGlobal.Instance().ESTABLISHMENTID
                                    , GTSysOne.Class.Utility.clsGlobal.Instance().STATIONID
                                    , System.Convert.ToString((int)GTSysOne.Class.Utility.clsGlobal.myFunction.User)
                                    , GTSysOne.Class.Utility.clsGlobal.Instance().UserId
                                    ,string.Empty
                                    ,this.txtUserName.Text
                                    ,false
                                    ,"0"
                                    ));

                        for(int ctr = 0;ctr<this.gridViewUserPrivileges.DataRowCount;ctr++)
                        {
                            System.Data.DataRow row = this.gridViewUserPrivileges.GetDataRow(ctr);
                            GTSysOne.Class.Slip.clsSlip_UserPrivilege.Save(GTSysOne.Class.Slip.clsSlip_UserPrivilege.Value(
                                (System.Convert.ToString(row["id"]).IndexOf("NEWID()") > -1 ? 1 : 2)
                                ,0
                                , System.Convert.ToString(row["id"])
                                ,"0"
                                ,(System.Convert.ToBoolean(row["Void"]) ? "1" : "0")
                                ,"0"
                                , GTSysOne.Class.Utility.clsGlobal.Instance().COMPANYID
                                , GTSysOne.Class.Utility.clsGlobal.Instance().ESTABLISHMENTID
                                , GTSysOne.Class.Utility.clsGlobal.Instance().STATIONID
                                , System.Convert.ToString((int)GTSysOne.Class.Utility.clsGlobal.myFunction.User)
                                , GTSysOne.Class.Utility.clsGlobal.Instance().UserId
                                , string.Empty
                                , PrivilegeId
                                , System.Convert.ToInt32(row["MapId"])
                                , System.Convert.ToBoolean(row["Grant"])
                                ,"0"));
                        }

                        Id = GTSysOne.Class.Document.clsDoc_User.Save(
                           GTSysOne.Class.Document.clsDoc_User.Value(
                           (EnformStatus == GTSysOne.Gui.Document.frmUser.enFormStatus.Add ? 1 : 2)
                           ,0
                           ,Id
                           , (EnformStatus == GTSysOne.Gui.Document.frmUser.enFormStatus.Add ? (this.txtNumbering.Enabled == false ? GTSysOne.Class.Utility.clsUtility.Numbering(GTSysOne.Class.Utility.clsGlobal.myFunction.User, true) : this.txtNumbering.Text) : this.txtNumbering.Text)
                           ,"0"
                           ,(this.chkActivate.Checked ? "0" : "1")
                           ,"0"
                           ,GTSysOne.Class.Utility.clsGlobal.Instance().COMPANYID
                           ,GTSysOne.Class.Utility.clsGlobal.Instance().ESTABLISHMENTID
                           ,GTSysOne.Class.Utility.clsGlobal.Instance().STATIONID
                           ,System.Convert.ToString((int)GTSysOne.Class.Utility.clsGlobal.myFunction.User)
                           ,GTSysOne.Class.Utility.clsGlobal.Instance().UserId
                           ,string.Empty
                           ,GTSysOne.Class.Utility.clsGlobal.Instance().COMPANYID
                           , PrivilegeId
                           , this.txtUserName.Text
                           , GTSysOne.Class.Utility.clsEncryption.JayDhreiZIP.Encrypt(this.txtPassword.Text,"")
                           , string.Empty
                           , false
                           , System.Convert.ToString(this.lookUpEditCompany.EditValue)
                           , System.Convert.ToString(this.lookUpEditEstablishment.EditValue)
                           , System.Convert.ToString(this.lookUpEditAccountType.EditValue)
                           , this.chkAdmin.Checked
                           ,"0"
                           ));

                       for (int ctr = 0; ctr < this.gridViewCompanyAccess.DataRowCount; ctr++)
                       {
                           System.Data.DataRow row = this.gridViewCompanyAccess.GetDataRow(ctr);
                           GTSysOne.Class.Slip.clsSlip_UserCompanyAccess.Save(GTSysOne.Class.Slip.clsSlip_UserCompanyAccess.Value(
                               (System.Convert.ToString(row["id"]).IndexOf("NEWID()") > -1 ? 1 : 2)
                               , 0
                               , System.Convert.ToString(row["id"])
                               , "0"
                               , (System.Convert.ToBoolean(row["Void"]) ? "1" : "0")
                               , "0"
                               , GTSysOne.Class.Utility.clsGlobal.Instance().COMPANYID
                               , GTSysOne.Class.Utility.clsGlobal.Instance().ESTABLISHMENTID
                               , GTSysOne.Class.Utility.clsGlobal.Instance().STATIONID
                               , System.Convert.ToString((int)GTSysOne.Class.Utility.clsGlobal.myFunction.User)
                               , GTSysOne.Class.Utility.clsGlobal.Instance().UserId
                               , string.Empty
                               , Id
                               , System.Convert.ToString(row["CompanyId"])
                               , System.Convert.ToBoolean(row["Grant"])
                               , "0"));
                       }

                       for (int ctr = 0; ctr < this.gridViewEstablishment.DataRowCount; ctr++)
                       {
                           System.Data.DataRow row = this.gridViewEstablishment.GetDataRow(ctr);
                           GTSysOne.Class.Slip.clsSlip_UserEstablishmentAccess.Save(GTSysOne.Class.Slip.clsSlip_UserEstablishmentAccess.Value(
                               (System.Convert.ToString(row["id"]).IndexOf("NEWID()") > -1 ? 1 : 2)
                               , 0
                               , System.Convert.ToString(row["id"])
                               , "0"
                               , (System.Convert.ToBoolean(row["Void"]) ? "1" : "0")
                               , "0"
                               , GTSysOne.Class.Utility.clsGlobal.Instance().COMPANYID
                               , GTSysOne.Class.Utility.clsGlobal.Instance().ESTABLISHMENTID
                               , GTSysOne.Class.Utility.clsGlobal.Instance().STATIONID
                               , System.Convert.ToString((int)GTSysOne.Class.Utility.clsGlobal.myFunction.User)
                               , GTSysOne.Class.Utility.clsGlobal.Instance().UserId
                               , string.Empty
                               , Id
                               , System.Convert.ToString(row["EstId"])
                               , System.Convert.ToBoolean(row["Grant"])
                               , "0"));
                       }
                       if (FromLogIn)
                       {
                           NewCompany = System.Convert.ToString(this.lookUpEditCompany.EditValue);
                           NewUserName = this.txtUserName.Text;
                           NewPassword = this.txtPassword.Text;
                           p_instance.Close();
                       }
                       else
                       {
                           GTSysOne.Gui.Dashboard.Document.frmUser.CallFromMain("Refresh", Id, false, 1, Id);
                           this.Clear();
                           this.Mapping();
                       }
                    }
                    break;
                case "barFirst":
                    ResultId = GTSysOne.Class.Utility.clsUtility.Navigator(Id, "2", GTSysOne.Class.Utility.clsGlobal.myFunction.User);
                    if (ResultId.CompareTo(string.Empty) != 0)
                    {
                        if (EnformStatus != GTSysOne.Gui.Document.frmUser.enFormStatus.View)
                        {
                            EnformStatus = GTSysOne.Gui.Document.frmUser.enFormStatus.Edit;
                        }
                        Id = ResultId;
                        this.EventHandler(false);
                        this.Mapping();
                        this.EventHandler(true);
                    }
                    break;
                case "barPrevious":
                    ResultId = GTSysOne.Class.Utility.clsUtility.Navigator(Id, "0", GTSysOne.Class.Utility.clsGlobal.myFunction.User);
                    if (ResultId.CompareTo(string.Empty) != 0)
                    {
                        if (EnformStatus != GTSysOne.Gui.Document.frmUser.enFormStatus.View)
                        {
                            EnformStatus = GTSysOne.Gui.Document.frmUser.enFormStatus.Edit;
                        }
                        Id = ResultId;
                        this.EventHandler(false);
                        this.Mapping();
                        this.EventHandler(true);
                    }
                    break;
                case "barNext":
                    ResultId = GTSysOne.Class.Utility.clsUtility.Navigator(Id, "1", GTSysOne.Class.Utility.clsGlobal.myFunction.User);
                    if (ResultId.CompareTo(string.Empty) != 0)
                    {
                        if (EnformStatus != GTSysOne.Gui.Document.frmUser.enFormStatus.View)
                        {
                            EnformStatus = GTSysOne.Gui.Document.frmUser.enFormStatus.Edit;
                        }
                        Id = ResultId;
                        this.EventHandler(false);
                        this.Mapping();
                        this.EventHandler(true);
                    }
                    break;
                case "barLast":
                    ResultId = GTSysOne.Class.Utility.clsUtility.Navigator(Id, "3",GTSysOne.Class.Utility.clsGlobal.myFunction.User);
                    if (ResultId.CompareTo(string.Empty) != 0)
                    {
                        if (EnformStatus != GTSysOne.Gui.Document.frmUser.enFormStatus.View)
                        {
                            EnformStatus = GTSysOne.Gui.Document.frmUser.enFormStatus.Edit;
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
        private void SEARCH_PRESSED(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if ((sender as DevExpress.XtraEditors.ButtonEdit).Properties.Buttons.IndexOf(e.Button) == 1)
            {
                string ResultId = System.Convert.ToString(GTSysOne.Class.Document.clsDoc_User.ScalarValue(GTSysOne.Class.Document.clsDoc_User.Value(0, 4, System.Convert.ToString((sender as DevExpress.XtraEditors.ButtonEdit).Text))));
                if (ResultId.CompareTo(string.Empty) != 0)
                {
                    EnformStatus = GTSysOne.Gui.Document.frmUser.enFormStatus.Edit;
                    Id = ResultId;
                    this.EventHandler(false);
                    this.Mapping();
                    this.EventHandler(true);
                }
            }
        }
        private void VALUE(object sender, System.EventArgs e)
        {
            DevExpress.XtraEditors.LookUpEdit L = sender as DevExpress.XtraEditors.LookUpEdit;
            switch(L.Name)
            {
                case "lookUpEditAccountType":
                    this.xTabPrivilege.PageEnabled = true;
                    this.xtraTabControlUser.SelectedTabPage = this.xTabPrivilege;
                    switch (System.Convert.ToString(this.lookUpEditAccountType.EditValue))
                    {
                        case "0":
                            GTSysOne.Class.Utility.clsUtility.createlookup(this.lookUpEditPrivilege, GTSysOne.Class.Mapping.clsMap_Privilege.ShowTable(GTSysOne.Class.Mapping.clsMap_Privilege.Value(0, 0)), new string[] { "Name" }, "id", "Name");  
                            break;
                        case "1":
                            GTSysOne.Class.Utility.clsUtility.createlookup(this.lookUpEditPrivilege, GTSysOne.Class.Document.clsDoc_UserPrivilege.ShowTable(GTSysOne.Class.Document.clsDoc_UserPrivilege.Value(0, 0)), new string[] { "User" }, "id", "User");
                            break;
                    }
                    GTSysOne.Class.Utility.clsUtility.View(this.gridControlUserPrivileges
                            , this.gridViewUserPrivileges
                            , 0
                            , GTSysOne.Class.Slip.clsSlip_UserPrivilege.ShowTable(GTSysOne.Class.Slip.clsSlip_UserPrivilege.Value(0, 0, string.Empty, "1"))
                            , string.Empty
                            , true);
                    break;
                case "lookUpEditPrivilege":
                    switch (System.Convert.ToString(this.lookUpEditAccountType.EditValue))
                    {
                        case "0":
                            System.Data.DataTable dt = (System.Data.DataTable)this.gridControlUserPrivileges.DataSource;
                            if (dt.Select(@" MapId = " + this.lookUpEditPrivilege.EditValue + @"  ").Length == 0)
                            {
                                dt.Rows.Add("NEWID()" + System.Guid.NewGuid(), false, this.lookUpEditPrivilege.EditValue, this.lookUpEditPrivilege.Text, true);
                                dt.AcceptChanges();
                            }
                            break;
                        case "1":
                            GTSysOne.Class.Utility.clsUtility.View(this.gridControlUserPrivileges
                            , this.gridViewUserPrivileges
                            , 0
                            , GTSysOne.Class.Slip.clsSlip_UserPrivilege.ShowTable(GTSysOne.Class.Slip.clsSlip_UserPrivilege.Value(0, 0, System.Convert.ToString(this.lookUpEditPrivilege.EditValue),"1"))
                            , string.Empty
                            , true);
                            break;
                    }
                    break;
                case "lookUpEditCompany":
                    this.xTabCompanyAccess.PageEnabled = true;
                    this.xtraTabControlUser.SelectedTabPage = this.xTabCompanyAccess;
                    System.Data.DataTable dtC = (System.Data.DataTable)this.gridControlCompanyAccess.DataSource;
                    if (dtC.Select(@" CompanyId = '" + this.lookUpEditCompany.EditValue + @"'  ").Length == 0 && this.lookUpEditCompany.EditValue != null)
                    {
                        dtC.Rows.Add("NEWID()" + System.Guid.NewGuid()
                            , false
                            , this.lookUpEditCompany.EditValue
                            , this.lookUpEditCompany.GetColumnValue("Name")
                            , this.lookUpEditCompany.GetColumnValue("Address")
                            , this.lookUpEditCompany.GetColumnValue("Owner")
                            , true);
                        dtC.AcceptChanges();
                    }
                    break;
                case "lookUpEditCompany2":
                    System.Data.DataTable dtC2 = (System.Data.DataTable)this.gridControlCompanyAccess.DataSource;
                    if (dtC2.Select(@" CompanyId = '" + this.lookUpEditCompany2.EditValue + @"'  ").Length == 0 && this.lookUpEditCompany2.EditValue != null)
                    {
                        dtC2.Rows.Add("NEWID()" + System.Guid.NewGuid()
                            , false
                            , this.lookUpEditCompany2.EditValue
                            , this.lookUpEditCompany2.GetColumnValue("Name")
                            , this.lookUpEditCompany2.GetColumnValue("Address")
                            , this.lookUpEditCompany2.GetColumnValue("Owner")
                            , true);
                        dtC2.AcceptChanges();
                    }
                    break;
                case "lookUpEditEstablishment":
                    this.xTabEstablishmentAccess.PageEnabled = true;
                    this.xtraTabControlUser.SelectedTabPage = this.xTabEstablishmentAccess;
                    System.Data.DataTable dtE = (System.Data.DataTable)this.gridControlEstablishment.DataSource;
                    if (dtE.Select(@" EstId = '" + this.lookUpEditEstablishment.EditValue + @"'  ").Length == 0 && this.lookUpEditEstablishment.EditValue != null)
                    {
                        dtE.Rows.Add("NEWID()" + System.Guid.NewGuid()
                             , false
                            , this.lookUpEditEstablishment.EditValue
                            , this.lookUpEditEstablishment.GetColumnValue("Name")
                            , this.lookUpEditEstablishment.GetColumnValue("Address")
                            , this.lookUpEditEstablishment.GetColumnValue("ShortName")
                            , true);
                        dtE.AcceptChanges();
                    }
                    break;
                case "lookUpEditEstablishment2":
                    System.Data.DataTable dtE2 = (System.Data.DataTable)this.gridControlEstablishment.DataSource;
                    if (dtE2.Select(@" EstId = '" + this.lookUpEditEstablishment2.EditValue + @"'  ").Length == 0 && this.lookUpEditEstablishment2.EditValue != null)
                    {
                        dtE2.Rows.Add("NEWID()" + System.Guid.NewGuid()
                             , false
                            , this.lookUpEditEstablishment2.EditValue
                            , this.lookUpEditEstablishment2.GetColumnValue("Name")
                            , this.lookUpEditEstablishment2.GetColumnValue("Address")
                            , this.lookUpEditEstablishment2.GetColumnValue("ShortName")
                            , true);
                        dtE2.AcceptChanges();
                    }
                    break;
            }
        }
    }
}