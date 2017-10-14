namespace GTSysOne.Gui.Document
{
    public partial class frmCompany : DevExpress.XtraBars.Ribbon.RibbonForm
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
        public static frmCompany p_instance = null;
        public static frmCompany Instance
        {
            get
            {
                if (p_instance == null)
                {
                    p_instance = new frmCompany();
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
        protected frmCompany()
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
            GTSysOne.Class.Utility.clsUtility.createlookup(this.lookUpEditCountry, GTSysOne.Class.Document.clsDoc_Country.ShowTable(GTSysOne.Class.Document.clsDoc_Country.Value(0, 0)), new string[] { "Name"}, "id", "Name");
            GTSysOne.Class.Utility.clsUtility.createlookup(this.lookUpEditDateFormat, GTSysOne.Class.Mapping.clsMap_DateFormat.ShowTable(GTSysOne.Class.Mapping.clsMap_DateFormat.Value(0, 0)), new string[] { "Name"}, "id", "Name");
            dtRecord = new System.Data.DataTable();
            dtRecord = GTSysOne.Class.Document.clsDoc_Company.ShowTable(GTSysOne.Class.Document.clsDoc_Company.Value(0, 4, Id));//mao ra ni pag kuha sa data
            if(dtRecord.Rows.Count > 0)
            {
                this.txtNumbering.Text = System.Convert.ToString(dtRecord.Rows[0]["num"]);
                

                this.txtName.Text = System.Convert.ToString(dtRecord.Rows[0]["name"]);
                this.txtAddress.Text = System.Convert.ToString(dtRecord.Rows[0]["address"]);
                this.txtWebsite.Text = System.Convert.ToString(dtRecord.Rows[0]["website"]);
                this.txtContactNo.Text = System.Convert.ToString(dtRecord.Rows[0]["telephone"]);
                this.txtEmail.Text = System.Convert.ToString(dtRecord.Rows[0]["email"]);
                this.txtOwner.Text = System.Convert.ToString(dtRecord.Rows[0]["owner"]);

                this.chkActive.Checked = !System.Convert.ToBoolean(dtRecord.Rows[0]["void"]);
                this.lookUpEditCountry.EditValue = dtRecord.Rows[0]["doc_sourced_country_id"];

                this.lookUpEditDateFormat.EditValue = dtRecord.Rows[0]["map_sourced_dateformat_id"];



                if (EnformStatus == GTSysOne.Gui.Document.frmCompany.enFormStatus.View)
                {
                    this.Enable(false);
                }
            }
            if (EnformStatus == GTSysOne.Gui.Document.frmCompany.enFormStatus.Add)
            {
                this.Enable(true);
                this.txtNumbering.Text = GTSysOne.Class.Utility.clsUtility.Numbering(GTSysOne.Class.Utility.clsGlobal.myFunction.Company);
            }
            if (this.txtNumbering.Text.CompareTo(string.Empty) == 0)
            {
                this.txtNumbering.Enabled = true;
            }
            else
            {
                this.txtNumbering.Enabled = false;
            }
            if (EnformStatus == GTSysOne.Gui.Document.frmCompany.enFormStatus.View)
            {
                this.txtNumbering.Enabled = false;
            }
        }
        private void Clear()
        {
            this.txtNumbering.Text = string.Empty;
            this.txtName.Text = string.Empty;
            this.txtAddress.Text = string.Empty;
            this.txtWebsite.Text = string.Empty;
            this.txtContactNo.Text = string.Empty;
            this.txtEmail.Text = string.Empty;
            this.txtOwner.Text = string.Empty;

            this.lookUpEditCountry.Text = string.Empty;
            this.lookUpEditCountry.EditValue = null;

            this.lookUpEditDateFormat.Text = string.Empty;
            this.lookUpEditDateFormat.EditValue = null;

            this.chkActive.Checked = false;

            Id = string.Empty;
        }
        private void Enable(bool sw)
        {
           
            this.txtName.Enabled = sw;
            this.txtAddress.Enabled = sw;
            this.txtWebsite.Enabled = sw;
            this.txtContactNo.Enabled = sw;
            this.txtEmail.Enabled = sw;
            this.txtOwner.Enabled = sw;

            this.lookUpEditCountry.Enabled = sw;

            this.lookUpEditDateFormat.Enabled = sw;
            this.chkActive.Enabled = sw;

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
            GTSysOne.Class.Utility.clsUtility.Language(this, typeof(GTSysOne.Gui.Document.frmCompany).Assembly);
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
                string ResultId = System.Convert.ToString(GTSysOne.Class.Document.clsDoc_Company.ScalarValue(GTSysOne.Class.Document.clsDoc_Company.Value(0, 2, System.Convert.ToString((sender as DevExpress.XtraEditors.ButtonEdit).Text))));
                if (ResultId.CompareTo(string.Empty) != 0)
                {
                    EnformStatus = GTSysOne.Gui.Document.frmCompany.enFormStatus.Edit;
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
                    EnformStatus = GTSysOne.Gui.Document.frmCompany.enFormStatus.Add;
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
                    GTSysOne.Class.Utility.clsUtility.ValidateControl(this.txtName);
                    GTSysOne.Class.Utility.clsUtility.ValidateControl(this.lookUpEditDateFormat);
                    if (GTSysOne.Class.Utility.clsGlobal.Instance().No_Error_Result)
                    {
                        Id = GTSysOne.Class.Document.clsDoc_Company.Save(GTSysOne.Class.Document.clsDoc_Company.Value(
                            (EnformStatus == GTSysOne.Gui.Document.frmCompany.enFormStatus.Add ? 1 : 2)//1 is insert 2 upddate
                            ,0
                            ,Id
                            ,(EnformStatus == GTSysOne.Gui.Document.frmCompany.enFormStatus.Add ? (this.txtNumbering.Enabled == false ? GTSysOne.Class.Utility.clsUtility.Numbering(GTSysOne.Class.Utility.clsGlobal.myFunction.Company, true) : this.txtNumbering.Text) : this.txtNumbering.Text)// please analyze this line,this is how to create dynamic numbering
                            ,"0"
                            ,(this.chkActive.Checked ? "0" : "1")
                            ,"0"
                            , GTSysOne.Class.Utility.clsGlobal.Instance().COMPANYID
                            , GTSysOne.Class.Utility.clsGlobal.Instance().ESTABLISHMENTID
                            , GTSysOne.Class.Utility.clsGlobal.Instance().STATIONID
                            , System.Convert.ToString((int)GTSysOne.Class.Utility.clsGlobal.myFunction.Company)
                            , GTSysOne.Class.Utility.clsGlobal.Instance().UserId
                            , string.Empty /// until here is the default of class doc ok? all class should be like this
                            , GTSysOne.Class.Utility.clsGlobal.Instance().LICENSEID
                            , System.Convert.ToString(this.lookUpEditCountry.EditValue)
                            , System.Convert.ToString(this.lookUpEditDateFormat.EditValue)
                            , this.txtName.Text
                            , this.txtAddress.Text
                            , this.txtWebsite.Text
                            , this.txtContactNo.Text
                            , this.txtEmail.Text
                            , this.txtOwner.Text
                            , "0"
                            ));
                        GTSysOne.Gui.Dashboard.Document.frmCompany.CallFromMain("Refresh", Id, false, 1, Id);
                        this.Clear();
                        this.Mapping();
                    }
                    break;
                case "barFirst":
                    ResultId = GTSysOne.Class.Utility.clsUtility.Navigator(Id, "2", GTSysOne.Class.Utility.clsGlobal.myFunction.Company);
                    if (ResultId.CompareTo(string.Empty) != 0)
                    {
                        if (EnformStatus != GTSysOne.Gui.Document.frmCompany.enFormStatus.View)
                        {
                            EnformStatus = GTSysOne.Gui.Document.frmCompany.enFormStatus.Edit;
                        }
                        Id = ResultId;
                        this.EventHandler(false);
                        this.Mapping();
                        this.EventHandler(true);
                    }
                    break;
                case "barPrevious":
                    ResultId = GTSysOne.Class.Utility.clsUtility.Navigator(Id, "0", GTSysOne.Class.Utility.clsGlobal.myFunction.Company);
                    if (ResultId.CompareTo(string.Empty) != 0)
                    {
                        if (EnformStatus != GTSysOne.Gui.Document.frmCompany.enFormStatus.View)
                        {
                            EnformStatus = GTSysOne.Gui.Document.frmCompany.enFormStatus.Edit;
                        }
                        Id = ResultId;
                        this.EventHandler(false);
                        this.Mapping();
                        this.EventHandler(true);
                    }
                    break;
                case "barNext":
                    ResultId = GTSysOne.Class.Utility.clsUtility.Navigator(Id, "1", GTSysOne.Class.Utility.clsGlobal.myFunction.Company);
                    if (ResultId.CompareTo(string.Empty) != 0)
                    {
                        if (EnformStatus != GTSysOne.Gui.Document.frmCompany.enFormStatus.View)
                        {
                            EnformStatus = GTSysOne.Gui.Document.frmCompany.enFormStatus.Edit;
                        }
                        Id = ResultId;
                        this.EventHandler(false);
                        this.Mapping();
                        this.EventHandler(true);
                    }
                    break;
                case "barLast":
                    ResultId = GTSysOne.Class.Utility.clsUtility.Navigator(Id, "3", GTSysOne.Class.Utility.clsGlobal.myFunction.Company);
                    if (ResultId.CompareTo(string.Empty) != 0)
                    {
                        if (EnformStatus != GTSysOne.Gui.Document.frmCompany.enFormStatus.View)
                        {
                            EnformStatus = GTSysOne.Gui.Document.frmCompany.enFormStatus.Edit;
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