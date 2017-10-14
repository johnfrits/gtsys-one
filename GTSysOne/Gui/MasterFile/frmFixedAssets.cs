namespace GTSysOne.Gui.MasterFile
{
    public partial class frmFixedAssets : DevExpress.XtraBars.Ribbon.RibbonForm
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
        public static frmFixedAssets p_instance = null;
        public static frmFixedAssets Instance
        {
            get
            {
                if (p_instance == null)
                {
                    p_instance = new frmFixedAssets();
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
        protected frmFixedAssets()
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
                this.gridView.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.NEWROW);
                this.repositoryItemLookUpEditCarColor.EditValueChanged += new System.EventHandler(this.CARCOLORCHANGED);
                this.repositoryItemLookUpEditCarType.EditValueChanged += new System.EventHandler(this.CARTYPECHANGED);
                this.repositoryItemLookUpEditCarModel.EditValueChanged += new System.EventHandler(this.CARMODELCHANGED);
                this.btnGroup.ButtonPressed += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.BUTTONPRESSEDGROUP);
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

                this.gridView.InitNewRow -= new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.NEWROW);
                this.repositoryItemLookUpEditCarColor.EditValueChanged -= new System.EventHandler(this.CARCOLORCHANGED);
                this.repositoryItemLookUpEditCarType.EditValueChanged -= new System.EventHandler(this.CARTYPECHANGED);
                this.repositoryItemLookUpEditCarModel.EditValueChanged -= new System.EventHandler(this.CARMODELCHANGED);
                this.btnGroup.ButtonPressed -= new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.BUTTONPRESSEDGROUP);
                this.repositoryItemSearchControl1.ButtonClick -= new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.SEARCH_PRESSED);
            }
        }
        private void Mapping()
        {
            GTSysOne.Class.Utility.clsUtility.View(this.gridControl
            , this.gridView
            , 0
            , GTSysOne.Class.Slip.clsSlip_FixedAssets.ShowTable(GTSysOne.Class.Slip.clsSlip_FixedAssets.Value(0, 0, Id, false, false, false, GTSysOne.Class.Utility.clsGlobal.Instance().COMPANYID))
            , string.Empty
            , true);

            GTSysOne.Class.Utility.clsUtility.createlookupRepository(this.repositoryItemLookUpEditCarColor, GTSysOne.Class.MasterFile.clsMas_CarColor.ShowTable(GTSysOne.Class.MasterFile.clsMas_CarColor.Value(0
                , 0
                , string.Empty
                , string.Empty
                , false
                , false
                , GTSysOne.Class.Utility.clsGlobal.Instance().COMPANYID
                )), new string[] { "Car Color" }, "id", "Car Color");
            GTSysOne.Class.Utility.clsUtility.createlookupRepository(this.repositoryItemLookUpEditCarModel, GTSysOne.Class.MasterFile.clsMas_CarModel.ShowTable(GTSysOne.Class.MasterFile.clsMas_CarModel.Value(0
                , 0
                , string.Empty
                , string.Empty
                , false
                , false
                , GTSysOne.Class.Utility.clsGlobal.Instance().COMPANYID)), new string[] { "Car Model" }, "id", "Car Model");

            GTSysOne.Class.Utility.clsUtility.createlookupRepository(this.repositoryItemLookUpEditCarType, GTSysOne.Class.MasterFile.clsMas_CarType.ShowTable(GTSysOne.Class.MasterFile.clsMas_CarType.Value(0
                , 0
                , string.Empty
                , string.Empty
                , false
                , false
                , GTSysOne.Class.Utility.clsGlobal.Instance().COMPANYID)), new string[] { "Car Type" }, "id", "Car Type");

            dtRecord = new System.Data.DataTable();
            dtRecord = GTSysOne.Class.MasterFile.clsMas_FixedAssets.ShowTable(GTSysOne.Class.MasterFile.clsMas_FixedAssets.Value(0, 3
                , Id
                , string.Empty
                , false
                , false
                , GTSysOne.Class.Utility.clsGlobal.Instance().COMPANYID));

                this.Enable(true);

                if (dtRecord.Rows.Count > 0)
                {
                    this.textEditSearchName.Text = System.Convert.ToString(dtRecord.Rows[0]["search_name"]);
                    this.txtName.Text = System.Convert.ToString(dtRecord.Rows[0]["name"]);
                    string groupId = System.Convert.ToString(dtRecord.Rows[0]["mas_sourced_group_id"]);


                    dtRecord = new System.Data.DataTable();
                    dtRecord = GTSysOne.Class.MasterFile.clsMas_Group.ShowTable(GTSysOne.Class.MasterFile.clsMas_Group.Value(0, 3
                        , groupId
                        , string.Empty
                        , false
                        , false
                        , GTSysOne.Class.Utility.clsGlobal.Instance().COMPANYID));

                    this.btnGroup.Tag = System.Convert.ToString(dtRecord.Rows[0]["id"]);
                    this.btnGroup.Text = System.Convert.ToString(dtRecord.Rows[0]["name"]);
                    this.txtNumber.Text = System.Convert.ToString(dtRecord.Rows[0]["num"]);

                }

            if (EnformStatus == GTSysOne.Gui.MasterFile.frmFixedAssets.enFormStatus.View)
            {
                this.Enable(false);
            }
            if (EnformStatus == GTSysOne.Gui.MasterFile.frmFixedAssets.enFormStatus.Add)
            {
                this.Enable(true);
            }
        }
        private void Clear()
        {
            this.txtName.Text = string.Empty;
            this.btnGroup.Text = string.Empty;
            this.btnGroup.Tag = string.Empty;
            this.textEditSearchName.Text = string.Empty;
            this.txtNumber.Text = string.Empty;
            Id = string.Empty;
        }
        private void Enable(bool sw)
        {
            this.btnGroup.Enabled = sw;
            this.textEditSearchName.Enabled = sw;
            this.txtName.Enabled = sw;
            this.barSave.Enabled = sw;
            this.gridView.OptionsBehavior.Editable = sw;
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
            GTSysOne.Class.Utility.clsUtility.Language(this, typeof(GTSysOne.Gui.MasterFile.frmFixedAssets).Assembly);
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
                string ResultId = System.Convert.ToString(GTSysOne.Class.MasterFile.clsMas_FixedAssets.ScalarValue(GTSysOne.Class.MasterFile.clsMas_FixedAssets.Value(0
                    , 4
                    , System.Convert.ToString((sender as DevExpress.XtraEditors.ButtonEdit).Text)
                    , string.Empty
                    , false
                    , false
                    , GTSysOne.Class.Utility.clsGlobal.Instance().COMPANYID)));
                if (ResultId.CompareTo(string.Empty) != 0)
                {
                    EnformStatus = GTSysOne.Gui.MasterFile.frmFixedAssets.enFormStatus.Edit;
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
                    EnformStatus = GTSysOne.Gui.MasterFile.frmFixedAssets.enFormStatus.Add;
                    Id = string.Empty;
                    this.EventHandler(false);
                    this.Clear();
                    this.Mapping();
                    this.EventHandler(true);
                    break;
                case "barSave":
                    GTSysOne.Class.Utility.clsGlobal.Instance().Err.ClearErrors();
                    GTSysOne.Class.Utility.clsGlobal.Instance().No_Error_Result = true;
                    GTSysOne.Class.Utility.clsUtility.ValidateControl(this.btnGroup);
                    GTSysOne.Class.Utility.clsUtility.ValidateControl(this.txtNumber);
                    GTSysOne.Class.Utility.clsUtility.ValidateControl(this.txtName);
                    GTSysOne.Class.Utility.clsUtility.ValidateControl(this.textEditSearchName);
                    if (GTSysOne.Class.Utility.clsGlobal.Instance().No_Error_Result)
                    {
                        Id = GTSysOne.Class.MasterFile.clsMas_FixedAssets.Save(
                            GTSysOne.Class.MasterFile.clsMas_FixedAssets.Value(
                            (EnformStatus == GTSysOne.Gui.MasterFile.frmFixedAssets.enFormStatus.Add ? 1 : 2)
                            , 0
                            , Id
                            , (EnformStatus == GTSysOne.Gui.MasterFile.frmFixedAssets.enFormStatus.Add ? (this.txtNumber.Enabled == false ? GTSysOne.Class.Utility.clsUtility.Numbering(GTSysOne.Class.Utility.clsGlobal.myFunction.FixedAssets, true) : this.txtNumber.Text) : this.txtNumber.Text)
                            , false
                            , false
                            , GTSysOne.Class.Utility.clsGlobal.Instance().COMPANYID
                            , GTSysOne.Class.Utility.clsGlobal.Instance().ESTABLISHMENTID
                            , GTSysOne.Class.Utility.clsGlobal.Instance().STATIONID
                            , System.Convert.ToString((int)GTSysOne.Class.Utility.clsGlobal.myFunction.FixedAssets)
                            , GTSysOne.Class.Utility.clsGlobal.Instance().UserId
                            , string.Empty
                            , System.Convert.ToString(this.btnGroup.Tag)
                            , string.Empty
                            , this.txtName.Text
                            , this.textEditSearchName.Text
                            , "0"));


                        for (int ctr = 0; ctr < this.gridView.DataRowCount; ctr++)
                        {
                            System.Data.DataRow row = this.gridView.GetDataRow(ctr);

                            GTSysOne.Class.Slip.clsSlip_FixedAssets.Save(
                              GTSysOne.Class.Slip.clsSlip_FixedAssets.Value(
                              (EnformStatus == GTSysOne.Gui.MasterFile.frmFixedAssets.enFormStatus.Add ? 1 : 2)
                              , 0
                              , System.Convert.ToString(row["id"])
                              , false                              
                              , false
                              , false
                              , GTSysOne.Class.Utility.clsGlobal.Instance().COMPANYID
                              , GTSysOne.Class.Utility.clsGlobal.Instance().ESTABLISHMENTID
                              , GTSysOne.Class.Utility.clsGlobal.Instance().STATIONID
                              , System.Convert.ToString((int)GTSysOne.Class.Utility.clsGlobal.myFunction.FixedAssets)
                              , GTSysOne.Class.Utility.clsGlobal.Instance().UserId
                              , string.Empty
                              , Id
                              , System.Convert.ToString(row["CarName"])
                              , System.Convert.ToString(row["CMId"])
                              , System.Convert.ToString(row["CTId"])
                              , System.Convert.ToString(row["CCId"])
                              , System.Convert.ToString(row["PlateNumber"])
                              , "0"));
                        }
                          
                        GTSysOne.Gui.Dashboard.MasterFile.frmFixedAssets.CallFromMain("Refresh", Id, false, 1, Id);
                        this.Clear();
                        this.Mapping();
                    }
                    break;
                case "barFirst":
                    ResultId = GTSysOne.Class.Utility.clsUtility.Navigator(Id, "2", GTSysOne.Class.Utility.clsGlobal.myFunction.FixedAssets);
                    if (ResultId.CompareTo(string.Empty) != 0)
                    {
                        if (EnformStatus != GTSysOne.Gui.MasterFile.frmFixedAssets.enFormStatus.View)
                        {
                            EnformStatus = GTSysOne.Gui.MasterFile.frmFixedAssets.enFormStatus.Edit;
                        }
                        Id = ResultId;
                        this.EventHandler(false);
                        this.Mapping();
                        this.EventHandler(true);
                    }
                    break;
                case "barPrevious":
                    ResultId = GTSysOne.Class.Utility.clsUtility.Navigator(Id, "0", GTSysOne.Class.Utility.clsGlobal.myFunction.FixedAssets);
                    if (ResultId.CompareTo(string.Empty) != 0)
                    {
                        if (EnformStatus != GTSysOne.Gui.MasterFile.frmFixedAssets.enFormStatus.View)
                        {
                            EnformStatus = GTSysOne.Gui.MasterFile.frmFixedAssets.enFormStatus.Edit;
                        }
                        Id = ResultId;
                        this.EventHandler(false);
                        this.Mapping();
                        this.EventHandler(true);
                    }
                    break;
                case "barNext":
                    ResultId = GTSysOne.Class.Utility.clsUtility.Navigator(Id, "1", GTSysOne.Class.Utility.clsGlobal.myFunction.FixedAssets);
                    if (ResultId.CompareTo(string.Empty) != 0)
                    {
                        if (EnformStatus != GTSysOne.Gui.MasterFile.frmFixedAssets.enFormStatus.View)
                        {
                            EnformStatus = GTSysOne.Gui.MasterFile.frmFixedAssets.enFormStatus.Edit;
                        }
                        Id = ResultId;
                        this.EventHandler(false);
                        this.Mapping();
                        this.EventHandler(true);
                    }
                    break;
                case "barLast":
                    ResultId = GTSysOne.Class.Utility.clsUtility.Navigator(Id, "3", GTSysOne.Class.Utility.clsGlobal.myFunction.FixedAssets);
                    if (ResultId.CompareTo(string.Empty) != 0)
                    {
                        if (EnformStatus != GTSysOne.Gui.MasterFile.frmFixedAssets.enFormStatus.View)
                        {
                            EnformStatus = GTSysOne.Gui.MasterFile.frmFixedAssets.enFormStatus.Edit;
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
        private void BUTTONPRESSEDGROUP(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            DevExpress.XtraEditors.ButtonEdit editor = sender as DevExpress.XtraEditors.ButtonEdit;
            DevExpress.XtraEditors.Controls.EditorButton Button = e.Button;

            if (editor.Properties.Buttons.IndexOf(e.Button) == 0)
            {

                using (var C = new GTSysOne.Gui.Main.frmGTSysList(GTSysOne.Class.Utility.clsGlobal.myFunction.Group))
                {
                    C.ShowDialog(this);
                    if (C.IS_OK)
                    {
                        this.btnGroup.Tag = C.GetData["id"];
                        this.btnGroup.Text = System.Convert.ToString(C.GetData["Name"]);
                        this.txtNumber.Text = System.Convert.ToString(C.GetData["Number"]);
                        C.Dispose();
                    }
                    else
                    {
                        C.Dispose();
                    }
                }
            }
        }

        private void NEWROW(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            this.gridView.SetRowCellValue(e.RowHandle, "id", "NEWID()" + System.Guid.NewGuid().ToString());
        }

        private void CARMODELCHANGED(object sender, System.EventArgs e)
        {
            this.gridView.SetRowCellValue(this.gridView.FocusedRowHandle, "CMId", (sender as DevExpress.XtraEditors.BaseEdit).EditValue);
            GTSysOne.Class.Utility.clsUtility.FocusLastNewRow(this.gridView, this.gridControl, "CarModel");
        }
        private void CARTYPECHANGED(object sender, System.EventArgs e)
        {
            this.gridView.SetRowCellValue(this.gridView.FocusedRowHandle, "CTId", (sender as DevExpress.XtraEditors.BaseEdit).EditValue);
            GTSysOne.Class.Utility.clsUtility.FocusLastNewRow(this.gridView, this.gridControl, "CarType");
        }
        private void CARCOLORCHANGED(object sender, System.EventArgs e)
        {
            this.gridView.SetRowCellValue(this.gridView.FocusedRowHandle, "CCId", (sender as DevExpress.XtraEditors.BaseEdit).EditValue);
            GTSysOne.Class.Utility.clsUtility.FocusLastNewRow(this.gridView, this.gridControl, "CarColor");
        }


    }
}