namespace GTSysOne.Gui.Document
{
    public partial class frmCountry : DevExpress.XtraBars.Ribbon.RibbonForm
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
        public static frmCountry p_instance = null;
        public static frmCountry Instance
        {
            get
            {
                if (p_instance == null)
                {
                    p_instance = new frmCountry();
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
        protected frmCountry()
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
            GTSysOne.Class.Utility.clsUtility.createlookup(this.lookUpEditLanguage, GTSysOne.Class.Mapping.clsMap_Language.ShowTable(GTSysOne.Class.Mapping.clsMap_Language.Value(0, 0)), new string[] { "Name" }, "id", "Name");
            GTSysOne.Class.Utility.clsUtility.createlookup(this.lookUpEditNationality, GTSysOne.Class.Mapping.clsMap_Nationality.ShowTable(GTSysOne.Class.Mapping.clsMap_Nationality.Value(0, 0)), new string[] { "Name" }, "id", "Name");
            dtRecord = new System.Data.DataTable();
            dtRecord = GTSysOne.Class.Document.clsDoc_Country.ShowTable(GTSysOne.Class.Document.clsDoc_Country.Value(0, 4, Id));

            if (dtRecord.Rows.Count > 0)
            {
                this.txtNumbering.Text = System.Convert.ToString(dtRecord.Rows[0]["num"]);
                this.txtName.Text = System.Convert.ToString(dtRecord.Rows[0]["name"]);

                this.lookUpEditLanguage.EditValue = dtRecord.Rows[0]["map_sourced_language_id"];
                this.lookUpEditNationality.EditValue = dtRecord.Rows[0]["map_sourced_nationality_id"];

                if (EnformStatus == GTSysOne.Gui.Document.frmCountry.enFormStatus.Add)
                {
                    this.Enable(true);
                }
                else if (EnformStatus == GTSysOne.Gui.Document.frmCountry.enFormStatus.View)
                {
                    this.Enable(false);
                }
            }
            if (EnformStatus == GTSysOne.Gui.Document.frmCountry.enFormStatus.Add)
            {
                this.Enable(true);
                this.txtNumbering.Text = GTSysOne.Class.Utility.clsUtility.Numbering(GTSysOne.Class.Utility.clsGlobal.myFunction.Country);
            }
            if (this.txtNumbering.Text.CompareTo(string.Empty) == 0)
            {
                this.txtNumbering.Enabled = true;
            }
            else
            {
                this.txtNumbering.Enabled = false;
            }
            if (EnformStatus == GTSysOne.Gui.Document.frmCountry.enFormStatus.View)
            {
                this.txtNumbering.Enabled = false;
            }
        }
        private void Clear()
        {
            this.txtNumbering.Text = string.Empty;
            this.txtName.Text = string.Empty;

            this.lookUpEditLanguage.EditValue =null;
            this.lookUpEditNationality.EditValue = null;

            this.lookUpEditLanguage.Text = string.Empty;
            this.lookUpEditNationality.Text = string.Empty;

            Id = string.Empty;
        }
        private void Enable(bool sw)
        {
            
            this.txtName.Enabled = sw;

            this.lookUpEditLanguage.Enabled = sw;
            this.lookUpEditNationality.Enabled = sw;

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
            GTSysOne.Class.Utility.clsUtility.Language(this, typeof(GTSysOne.Gui.Document.frmCountry).Assembly);
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
                string ResultId = System.Convert.ToString(GTSysOne.Class.Document.clsDoc_Country.ScalarValue(GTSysOne.Class.Document.clsDoc_Country.Value(0, 2, System.Convert.ToString((sender as DevExpress.XtraEditors.ButtonEdit).Text))));
                if (ResultId.CompareTo(string.Empty) != 0)
                {
                    EnformStatus = GTSysOne.Gui.Document.frmCountry.enFormStatus.Edit;
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
                    EnformStatus = GTSysOne.Gui.Document.frmCountry.enFormStatus.Add;
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
                    GTSysOne.Class.Utility.clsUtility.ValidateControl(this.lookUpEditLanguage);
                    GTSysOne.Class.Utility.clsUtility.ValidateControl(this.lookUpEditNationality);
                    if (GTSysOne.Class.Utility.clsGlobal.Instance().No_Error_Result)
                    {
                        Id = GTSysOne.Class.Document.clsDoc_Country.Save(
                           GTSysOne.Class.Document.clsDoc_Country.Value(
                           (EnformStatus == GTSysOne.Gui.Document.frmCountry.enFormStatus.Add ? 1 : 2)
                           , 0
                           , Id
                           , (EnformStatus == GTSysOne.Gui.Document.frmCountry.enFormStatus.Add ? (this.txtNumbering.Enabled == false ? GTSysOne.Class.Utility.clsUtility.Numbering(GTSysOne.Class.Utility.clsGlobal.myFunction.Country, true) : this.txtNumbering.Text) : this.txtNumbering.Text)
                           , false
                           , false
                           , false
                           , GTSysOne.Class.Utility.clsGlobal.Instance().COMPANYID
                           , GTSysOne.Class.Utility.clsGlobal.Instance().ESTABLISHMENTID
                           , GTSysOne.Class.Utility.clsGlobal.Instance().STATIONID
                           , System.Convert.ToString((int)GTSysOne.Class.Utility.clsGlobal.myFunction.Country)
                           , GTSysOne.Class.Utility.clsGlobal.Instance().UserId
                           , string.Empty
                           , this.txtName.Text
                           , System.Convert.ToString(this.lookUpEditNationality.EditValue)
                           , System.Convert.ToString(this.lookUpEditLanguage.EditValue)
                           , "0"));
                        GTSysOne.Gui.Dashboard.Document.frmCountry.CallFromMain("Refresh", Id, false, 1, Id);
                        this.Clear();
                        this.Mapping();
                    }
                    break;
                case "barFirst":
                    ResultId = GTSysOne.Class.Utility.clsUtility.Navigator(Id, "2", GTSysOne.Class.Utility.clsGlobal.myFunction.Country);
                    if (ResultId.CompareTo(string.Empty) != 0)
                    {
                        if (EnformStatus != GTSysOne.Gui.Document.frmCountry.enFormStatus.View)
                        {
                            EnformStatus = GTSysOne.Gui.Document.frmCountry.enFormStatus.Edit;
                        }
                        Id = ResultId;
                        this.EventHandler(false);
                        this.Mapping();
                        this.EventHandler(true);
                    }
                    break;
                case "barPrevious":
                    ResultId = GTSysOne.Class.Utility.clsUtility.Navigator(Id, "0", GTSysOne.Class.Utility.clsGlobal.myFunction.Country);
                    if (ResultId.CompareTo(string.Empty) != 0)
                    {
                        if (EnformStatus != GTSysOne.Gui.Document.frmCountry.enFormStatus.View)
                        {
                            EnformStatus = GTSysOne.Gui.Document.frmCountry.enFormStatus.Edit;
                        }
                        Id = ResultId;
                        this.EventHandler(false);
                        this.Mapping();
                        this.EventHandler(true);
                    }
                    break;
                case "barNext":
                    ResultId = GTSysOne.Class.Utility.clsUtility.Navigator(Id, "1", GTSysOne.Class.Utility.clsGlobal.myFunction.Country);
                    if (ResultId.CompareTo(string.Empty) != 0)
                    {
                        if (EnformStatus != GTSysOne.Gui.Document.frmCountry.enFormStatus.View)
                        {
                            EnformStatus = GTSysOne.Gui.Document.frmCountry.enFormStatus.Edit;
                        }
                        Id = ResultId;
                        this.EventHandler(false);
                        this.Mapping();
                        this.EventHandler(true);
                    }
                    break;
                case "barLast":
                    ResultId = GTSysOne.Class.Utility.clsUtility.Navigator(Id, "3", GTSysOne.Class.Utility.clsGlobal.myFunction.Country);
                    if (ResultId.CompareTo(string.Empty) != 0)
                    {
                        if (EnformStatus != GTSysOne.Gui.Document.frmCountry.enFormStatus.View)
                        {
                            EnformStatus = GTSysOne.Gui.Document.frmCountry.enFormStatus.Edit;
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