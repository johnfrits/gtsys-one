namespace GTSysOne.Gui.MasterFile
{
    public partial class frmStation : DevExpress.XtraBars.Ribbon.RibbonForm
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
        public static frmStation p_instance = null;
        public static frmStation Instance
        {
            get
            {
                if (p_instance == null)
                {
                    p_instance = new frmStation();
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
        protected frmStation()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.FORM_LOAD);
            this.rpNew.Visible = GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_Add_Station;
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
            GTSysOne.Class.Utility.clsUtility.createlookup(this.lookUpEditlanguage, GTSysOne.Class.Mapping.clsMap_Language.ShowTable(GTSysOne.Class.Mapping.clsMap_Language.Value(0, 0)), new string[] { "Name" }, "id", "Name");
            GTSysOne.Class.Utility.clsUtility.createlookup(this.lookUpEditTheme,GTSysOne.Class.Utility.clsGlobal.Instance().ThemesList, new string[] { "Name"}, "Id", "Name");
            dtRecord = new System.Data.DataTable();
            dtRecord = GTSysOne.Class.MasterFile.clsMas_Station.ShowTable(GTSysOne.Class.MasterFile.clsMas_Station.Value(0, 6, Id));
            if (dtRecord.Rows.Count > 0)
            {
                this.txtNumbering.Text = System.Convert.ToString(dtRecord.Rows[0]["num"]);

                this.txtname.Text = System.Convert.ToString(dtRecord.Rows[0]["name"]);
                this.txtShortname.Text = System.Convert.ToString(dtRecord.Rows[0]["shortname"]);

                this.chkActive.Checked = !System.Convert.ToBoolean(dtRecord.Rows[0]["void"]);
                
                this.chkAllowEditLineTotal.Checked = System.Convert.ToBoolean(dtRecord.Rows[0]["alloweditlinetotal"]);

                if (System.Convert.ToString(dtRecord.Rows[0]["language"]) != "")
                {
                    this.lookUpEditlanguage.EditValue = System.Convert.ToInt32(dtRecord.Rows[0]["language"]);
                }

                this.chkShowfavoritesInNavigation.Checked = GTSysOne.Class.Utility.clsUtility.NullToValue(dtRecord.Rows[0]["showfavorites"]);
                this.chkAutoHideNavigation.Checked = GTSysOne.Class.Utility.clsUtility.NullToValue(dtRecord.Rows[0]["autohidenavigation"]);
                this.chkShowStats.Checked = GTSysOne.Class.Utility.clsUtility.NullToValue(dtRecord.Rows[0]["showstats"]);
                this.chkAutoHideStats.Checked = GTSysOne.Class.Utility.clsUtility.NullToValue(dtRecord.Rows[0]["autohidestats"]);
                this.chkShowFunctions.Checked = GTSysOne.Class.Utility.clsUtility.NullToValue(dtRecord.Rows[0]["showfunctions"]);



                this.lookUpEditTheme.EditValue = dtRecord.Rows[0]["theme"];

                if (System.Convert.ToBoolean(dtRecord.Rows[0]["hqstation"]))
                {
                    this.chkActive.Enabled = false;
                }
                if (EnformStatus == GTSysOne.Gui.MasterFile.frmStation.enFormStatus.View)
                {
                    this.Enable(false);
                }
            }
            if (EnformStatus == GTSysOne.Gui.MasterFile.frmStation.enFormStatus.Add)
            {
                this.Enable(true);
                this.txtNumbering.Text = GTSysOne.Class.Utility.clsUtility.Numbering(GTSysOne.Class.Utility.clsGlobal.myFunction.Station);
            }
            if (this.txtNumbering.Text.CompareTo(string.Empty) == 0)
            {
                this.txtNumbering.Enabled = true;
            }
            else
            {
                this.txtNumbering.Enabled = false;
            }
            if (EnformStatus == GTSysOne.Gui.MasterFile.frmStation.enFormStatus.View)
            {
                this.txtNumbering.Enabled = false;
            }
        }
        private void Clear()
        {
            this.txtname.Text = string.Empty;
            this.txtShortname.Text = string.Empty;

            this.lookUpEditlanguage.EditValue = null ;
            this.lookUpEditlanguage.Text = string.Empty;

            this.lookUpEditTheme.EditValue = null;
            this.lookUpEditTheme.Text = string.Empty;

            this.chkActive.Checked = true;
            this.chkAllowEditLineTotal.Checked = false;

            this.chkShowfavoritesInNavigation.Checked = false;
            this.chkAutoHideNavigation.Checked = false;
            this.chkShowStats.Checked = false;
            this.chkAutoHideStats.Checked = false;
            this.chkShowFunctions.Checked = false;


            Id = string.Empty;
        }
        private void Enable(bool sw)
        {
            
            this.txtname.Enabled = sw;
            this.txtShortname.Enabled = sw;

            this.lookUpEditlanguage.Enabled = sw;

            this.lookUpEditTheme.Enabled = sw;

            this.chkAllowEditLineTotal.Enabled = sw;

            this.chkShowfavoritesInNavigation.Enabled = sw;
            this.chkAutoHideNavigation.Enabled = sw;
            this.chkShowStats.Enabled = sw;
            this.chkAutoHideStats.Enabled = sw;
            this.chkShowFunctions.Enabled = sw;


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
            GTSysOne.Class.Utility.clsUtility.Language(this, typeof(GTSysOne.Gui.MasterFile.frmStation).Assembly);
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
                string ResultId = System.Convert.ToString(GTSysOne.Class.MasterFile.clsMas_Station.ScalarValue(GTSysOne.Class.MasterFile.clsMas_Station.Value(0, 7, System.Convert.ToString((sender as DevExpress.XtraEditors.ButtonEdit).Text))));
                if (ResultId.CompareTo(string.Empty) != 0)
                {
                    EnformStatus = GTSysOne.Gui.MasterFile.frmStation.enFormStatus.Edit;
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
                    EnformStatus = GTSysOne.Gui.MasterFile.frmStation.enFormStatus.Add;
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
                    GTSysOne.Class.Utility.clsUtility.ValidateControl(this.txtname);
                    GTSysOne.Class.Utility.clsUtility.ValidateControl(this.txtShortname);
                    if (GTSysOne.Class.Utility.clsGlobal.Instance().No_Error_Result)
                    {
                        Id = GTSysOne.Class.MasterFile.clsMas_Station.Save(
                            GTSysOne.Class.MasterFile.clsMas_Station.Value(
                            (EnformStatus == GTSysOne.Gui.MasterFile.frmStation.enFormStatus.Add ? 1 : 2)
                            , 0
                            , Id
                            , (EnformStatus == GTSysOne.Gui.MasterFile.frmStation.enFormStatus.Add ? (this.txtNumbering.Enabled == false ? GTSysOne.Class.Utility.clsUtility.Numbering(GTSysOne.Class.Utility.clsGlobal.myFunction.Station, true) : this.txtNumbering.Text) : this.txtNumbering.Text)
                            , (this.chkActive.Checked ? false : true)
                            , false
                            , GTSysOne.Class.Utility.clsGlobal.Instance().COMPANYID
                            , GTSysOne.Class.Utility.clsGlobal.Instance().ESTABLISHMENTID
                            , GTSysOne.Class.Utility.clsGlobal.Instance().STATIONID
                            , System.Convert.ToString((int)GTSysOne.Class.Utility.clsGlobal.myFunction.Station)
                            , GTSysOne.Class.Utility.clsGlobal.Instance().UserId
                            , string.Empty
                            , string.Empty
                            ,this.txtname.Text
                            ,this.txtShortname.Text
                            ,string.Empty
                            ,false,false
                            ,string.Empty
                            ,string.Empty
                            ,System.Convert.ToString(this.lookUpEditlanguage.EditValue)
                            ,this.chkAllowEditLineTotal.Checked
                            , System.Convert.ToString(this.lookUpEditTheme.EditValue)
                            , this.chkShowfavoritesInNavigation.Checked
                            , this.chkAutoHideNavigation.Checked
                            , this.chkShowStats.Checked
                            , this.chkAutoHideStats.Checked
                            , this.chkShowFunctions.Checked
                            ,"0" ));

                        if (GTSysOne.Class.Utility.clsGlobal.Instance().THEME.CompareTo(System.Convert.ToString(this.lookUpEditTheme.EditValue)) != 0)
                        {
                            GTSysOne.Class.Utility.clsGlobal.Instance().THEME = System.Convert.ToString(this.lookUpEditTheme.EditValue);
                            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle(GTSysOne.Class.Utility.clsGlobal.Instance().THEME);
                        }

                        GTSysOne.Gui.Dashboard.MasterFile.frmStation.CallFromMain("Refresh", Id, false, 1, Id);
                        this.Clear();
                        this.Mapping();
                    }
                    break;
                case "barFirst":
                    ResultId = GTSysOne.Class.Utility.clsUtility.Navigator(Id, "2", GTSysOne.Class.Utility.clsGlobal.myFunction.Station);
                    if (ResultId.CompareTo(string.Empty) != 0)
                    {
                        if (EnformStatus != GTSysOne.Gui.MasterFile.frmStation.enFormStatus.View)
                        {
                            EnformStatus = GTSysOne.Gui.MasterFile.frmStation.enFormStatus.Edit;
                        }
                        Id = ResultId;
                        this.EventHandler(false);
                        this.Mapping();
                        this.EventHandler(true);
                    }
                    break;
                case "barPrevious":
                    ResultId = GTSysOne.Class.Utility.clsUtility.Navigator(Id, "0", GTSysOne.Class.Utility.clsGlobal.myFunction.Station);
                    if (ResultId.CompareTo(string.Empty) != 0)
                    {
                        if (EnformStatus != GTSysOne.Gui.MasterFile.frmStation.enFormStatus.View)
                        {
                            EnformStatus = GTSysOne.Gui.MasterFile.frmStation.enFormStatus.Edit;
                        }
                        Id = ResultId;
                        this.EventHandler(false);
                        this.Mapping();
                        this.EventHandler(true);
                    }
                    break;
                case "barNext":
                    ResultId = GTSysOne.Class.Utility.clsUtility.Navigator(Id, "1", GTSysOne.Class.Utility.clsGlobal.myFunction.Station);
                    if (ResultId.CompareTo(string.Empty) != 0)
                    {
                        if (EnformStatus != GTSysOne.Gui.MasterFile.frmStation.enFormStatus.View)
                        {
                            EnformStatus = GTSysOne.Gui.MasterFile.frmStation.enFormStatus.Edit;
                        }
                        Id = ResultId;
                        this.EventHandler(false);
                        this.Mapping();
                        this.EventHandler(true);
                    }
                    break;
                case "barLast":
                    ResultId = GTSysOne.Class.Utility.clsUtility.Navigator(Id, "3", GTSysOne.Class.Utility.clsGlobal.myFunction.Station);
                    if (ResultId.CompareTo(string.Empty) != 0)
                    {
                        if (EnformStatus != GTSysOne.Gui.MasterFile.frmStation.enFormStatus.View)
                        {
                            EnformStatus = GTSysOne.Gui.MasterFile.frmStation.enFormStatus.Edit;
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