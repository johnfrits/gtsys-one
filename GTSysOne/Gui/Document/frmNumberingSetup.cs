namespace GTSysOne.Gui.Document
{
    public partial class frmNumberingSetup : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        #region VARIABLE
        System.Data.DataTable dtRecord = null;
        bool changing = false;
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
        public static frmNumberingSetup p_instance = null;
        public static frmNumberingSetup Instance
        {
            get
            {
                if (p_instance == null)
                {
                    p_instance = new frmNumberingSetup();
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
        protected frmNumberingSetup()
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
                this.gridView.ShowingEditor += new System.ComponentModel.CancelEventHandler(this.SHOWINGEDITOR);
                this.gridView.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.CELLVALUECHANGED);
                this.repositoryItemLookUpEditSegment.EditValueChanged += new System.EventHandler(this.SEGMENTCHANGED);
            

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
                this.gridView.ShowingEditor -= new System.ComponentModel.CancelEventHandler(this.SHOWINGEDITOR);
                this.gridView.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.CELLVALUECHANGED);
                this.repositoryItemLookUpEditSegment.EditValueChanged -= new System.EventHandler(this.SEGMENTCHANGED);

                this.repositoryItemSearchControl1.ButtonClick -= new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.SEARCH_PRESSED);
            }
        }
        private void Mapping()
        {
            GTSysOne.Class.Utility.clsUtility.createlookup(this.lookUpEditCompany, GTSysOne.Class.Document.clsDoc_Company.ShowTable(GTSysOne.Class.Document.clsDoc_Company.Value(0, 0)), new string[] { "Name","Address","Owner" }, "id", "Name");
            GTSysOne.Class.Utility.clsUtility.createlookupRepository(this.repositoryItemLookUpEditSegment, GTSysOne.Class.Mapping.clsMap_NumberingSegment.ShowTable(GTSysOne.Class.Mapping.clsMap_NumberingSegment.Value(0, 0)), new string[] { "Name" }, "id", "Name");

            GTSysOne.Class.Utility.clsUtility.View(this.gridControl
               , this.gridView
               , 0
               , GTSysOne.Class.Slip.clsSlip_NumberingSetup.ShowTable(GTSysOne.Class.Slip.clsSlip_NumberingSetup.Value(0, 0, Id))
               , string.Empty
               , true);

            this.chkResetNumbering.Visible = false;

            dtRecord = new System.Data.DataTable();
            dtRecord = GTSysOne.Class.Document.clsDoc_NumberingSetup.ShowTable(GTSysOne.Class.Document.clsDoc_NumberingSetup.Value(0, 2, Id));
            if (dtRecord.Rows.Count > 0)
            {
                GTSysOne.Class.Utility.clsUtility.createlookup(this.lookUpEditFunction, GTSysOne.Class.MasterFile.clsMas_Function.ShowTable(GTSysOne.Class.MasterFile.clsMas_Function.Value(0, 1)), new string[] { "Name", "Module" }, "id", "Name");
            
                this.lookUpEditCompany.EditValue = dtRecord.Rows[0]["doc_sourced_company_id"];
                this.lookUpEditFunction.EditValue = dtRecord.Rows[0]["mas_sourced_function_id"];

                this.lookUpEditCompany.Enabled = false;
                this.lookUpEditFunction.Enabled = false;

                this.chkActive.Checked = !System.Convert.ToBoolean(dtRecord.Rows[0]["void"]);
               
                if (EnformStatus == GTSysOne.Gui.Document.frmNumberingSetup.enFormStatus.View)
                {
                    this.Enable(false);
                }
                else if (EnformStatus == GTSysOne.Gui.Document.frmNumberingSetup.enFormStatus.Edit)
                {
                    this.chkResetNumbering.Visible = true;
                }
            }
            if (EnformStatus == GTSysOne.Gui.Document.frmNumberingSetup.enFormStatus.Add)
            {
                GTSysOne.Class.Utility.clsUtility.createlookup(this.lookUpEditFunction, GTSysOne.Class.MasterFile.clsMas_Function.ShowTable(GTSysOne.Class.MasterFile.clsMas_Function.Value(0, 1, GTSysOne.Class.Utility.clsGlobal.Instance().COMPANYID)), new string[] { "Name", "Module" }, "id", "Name");
            
                this.Enable(true);
            }
        }
        private void Clear()
        {
            this.lookUpEditCompany.Text = string.Empty;
            this.lookUpEditCompany.EditValue = null;

            this.lookUpEditFunction.Text = string.Empty;
            this.lookUpEditFunction.EditValue = null;

            this.chkActive.Checked = false;

            this.chkResetNumbering.Checked = false;

            Id = string.Empty;

        }
        private void Enable(bool sw)
        {

            this.lookUpEditCompany.Enabled = sw;
            this.lookUpEditFunction.Enabled = sw;
            this.chkActive.Enabled = sw;

            this.barSave.Enabled = sw;
        }
        private void GridLayout(GTSysOne.Class.Utility.clsGlobal.GridLayout L)
        {
            GTSysOne.Class.Utility.clsUtility.Layout_Restore_Save(this.gridView, L, GTSysOne.Class.Utility.clsGlobal.Instance().GridLayoutLocation + "Document\\" , this.Name.Replace("frm", ""), this.gridControl);
        }
        private void FORM_LOAD(object sender, System.EventArgs e)
        {
            this.Mapping();
            this.EventHandler();
            GTSysOne.Class.Utility.clsUtility.Language(this, typeof(GTSysOne.Gui.Document.frmNumberingSetup).Assembly);
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
                string ResultId = System.Convert.ToString(GTSysOne.Class.Document.clsDoc_NumberingSetup.ScalarValue(GTSysOne.Class.Document.clsDoc_NumberingSetup.Value(0, 3, System.Convert.ToString((sender as DevExpress.XtraEditors.ButtonEdit).Text))));
                if (ResultId.CompareTo(string.Empty) != 0)
                {
                    EnformStatus = GTSysOne.Gui.Document.frmNumberingSetup.enFormStatus.Edit;
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
                    EnformStatus = GTSysOne.Gui.Document.frmNumberingSetup.enFormStatus.Add;
                    Id = string.Empty;
                    this.EventHandler(false);
                    this.Clear();
                    this.Mapping();
                    this.EventHandler(true);
                    break;
                case "barSave":
                    GTSysOne.Class.Utility.clsGlobal.Instance().Err.ClearErrors();
                    GTSysOne.Class.Utility.clsGlobal.Instance().No_Error_Result = true;
                    GTSysOne.Class.Utility.clsUtility.ValidateControl(this.lookUpEditCompany);
                    GTSysOne.Class.Utility.clsUtility.ValidateControl(this.lookUpEditFunction);
                    if (this.gridView.DataRowCount == 0)
                    {
                        GTSysOne.Class.Utility.clsUtility.GTSysMessageBox(new string[] { "No Data To Saved." }
                                    , GTSysOne.Class.Utility.clsGlobal.enMessageBoxButton.OK
                                    , GTSysOne.Class.Utility.clsGlobal.enMessageBoxIcon.Warning
                                    , "No Data");
                    }
                    if (GTSysOne.Class.Utility.clsGlobal.Instance().No_Error_Result && this.gridView.DataRowCount > 0)
                    {
                        Id = GTSysOne.Class.Document.clsDoc_NumberingSetup.Save(GTSysOne.Class.Document.clsDoc_NumberingSetup.Value(
                            (EnformStatus == GTSysOne.Gui.Document.frmNumberingSetup.enFormStatus.Add ? 1 : 2)
                            , 0
                            ,Id
                            ,string.Empty
                            ,"0"
                            , (this.chkActive.Checked ? "0" : "1")
                            ,"0"
                            , GTSysOne.Class.Utility.clsGlobal.Instance().COMPANYID
                            , GTSysOne.Class.Utility.clsGlobal.Instance().ESTABLISHMENTID
                            , GTSysOne.Class.Utility.clsGlobal.Instance().STATIONID
                            , System.Convert.ToString((int)GTSysOne.Class.Utility.clsGlobal.myFunction.NumberingSetup)
                            , GTSysOne.Class.Utility.clsGlobal.Instance().UserId
                            ,(this.chkResetNumbering.Checked ? "1" : string.Empty)
                            , System.Convert.ToString(this.lookUpEditCompany.EditValue)
                            , System.Convert.ToString(this.lookUpEditFunction.EditValue)
                            , "0"));

                        for (int ctr = 0; ctr < this.gridView.DataRowCount;ctr++)
                        {
                            System.Data.DataRow row = this.gridView.GetDataRow(ctr);
                            GTSysOne.Class.Slip.clsSlip_NumberingSetup.Save(    
                                GTSysOne.Class.Slip.clsSlip_NumberingSetup.Value((
                                System.Convert.ToString(row["id"]).IndexOf("NEWID()") > -1 ? 1 : 2)
                                , 0
                                , System.Convert.ToString(row["id"])
                                , "0"
                                , (System.Convert.ToBoolean(row["Void"]) ? "1" : "0")
                                , "0"
                                , GTSysOne.Class.Utility.clsGlobal.Instance().COMPANYID
                                , GTSysOne.Class.Utility.clsGlobal.Instance().ESTABLISHMENTID
                                , GTSysOne.Class.Utility.clsGlobal.Instance().STATIONID
                                , System.Convert.ToString((int)GTSysOne.Class.Utility.clsGlobal.myFunction.NumberingSetup)
                                , GTSysOne.Class.Utility.clsGlobal.Instance().UserId
                                , string.Empty
                                , Id
                                , System.Convert.ToString(row["map_sourced_numbering_segment_id"])
                                , System.Convert.ToInt32(row["Seq"])
                                , System.Convert.ToString(row["value"])
                                , System.Convert.ToString(row["separator"])
                                , System.Convert.ToString(row["firstnumeric"])
                                , System.Convert.ToString(row["lastnumeric"])
                                , "0"));
                        }
                        GTSysOne.Gui.Dashboard.Document.frmNumberingSetup.CallFromMain("Refresh", Id, false, 1, Id);
                        this.Clear();
                        this.Mapping();
                    }
                    break;
                case "barFirst":
                    ResultId = GTSysOne.Class.Utility.clsUtility.Navigator(Id, "2", GTSysOne.Class.Utility.clsGlobal.myFunction.NumberingSetup);
                    if (ResultId.CompareTo(string.Empty) != 0)
                    {
                        if (EnformStatus != GTSysOne.Gui.Document.frmNumberingSetup.enFormStatus.View)
                        {
                            EnformStatus = GTSysOne.Gui.Document.frmNumberingSetup.enFormStatus.Edit;
                        }
                        Id = ResultId;
                        this.EventHandler(false);
                        this.Mapping();
                        this.EventHandler(true);
                    }
                    break;
                case "barPrevious":
                    ResultId = GTSysOne.Class.Utility.clsUtility.Navigator(Id, "0", GTSysOne.Class.Utility.clsGlobal.myFunction.NumberingSetup);
                    if (ResultId.CompareTo(string.Empty) != 0)
                    {
                        if (EnformStatus != GTSysOne.Gui.Document.frmNumberingSetup.enFormStatus.View)
                        {
                            EnformStatus = GTSysOne.Gui.Document.frmNumberingSetup.enFormStatus.Edit;
                        }
                        Id = ResultId;
                        this.EventHandler(false);
                        this.Mapping();
                        this.EventHandler(true);
                    }
                    break;
                case "barNext":
                    ResultId = GTSysOne.Class.Utility.clsUtility.Navigator(Id, "1", GTSysOne.Class.Utility.clsGlobal.myFunction.NumberingSetup);
                    if (ResultId.CompareTo(string.Empty) != 0)
                    {
                        if (EnformStatus != GTSysOne.Gui.Document.frmNumberingSetup.enFormStatus.View)
                        {
                            EnformStatus = GTSysOne.Gui.Document.frmNumberingSetup.enFormStatus.Edit;
                        }
                        Id = ResultId;
                        this.EventHandler(false);
                        this.Mapping();
                        this.EventHandler(true);
                    }
                    break;
                case "barLast":
                    ResultId = GTSysOne.Class.Utility.clsUtility.Navigator(Id, "3", GTSysOne.Class.Utility.clsGlobal.myFunction.NumberingSetup);
                    if (ResultId.CompareTo(string.Empty) != 0)
                    {
                        if (EnformStatus != GTSysOne.Gui.Document.frmNumberingSetup.enFormStatus.View)
                        {
                            EnformStatus = GTSysOne.Gui.Document.frmNumberingSetup.enFormStatus.Edit;
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
        private void NEWROW(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            this.gridView.SetRowCellValue(e.RowHandle,"id","NEWID()"+System.Guid.NewGuid());
            this.gridView.SetRowCellValue(e.RowHandle, "void", false);
            this.gridView.SetRowCellValue(e.RowHandle, "seq", (this.gridView.RowCount - 1) + 1);
        }
        private void SEGMENTCHANGED(object sender, System.EventArgs e)
        {
            this.gridView.SetRowCellValue(this.gridView.FocusedRowHandle, "map_sourced_numbering_segment_id", (sender as DevExpress.XtraEditors.BaseEdit).EditValue);
            GTSysOne.Class.Utility.clsUtility.FocusLastNewRow(this.gridView, this.gridControl, "name");
        }
        private void SHOWINGEDITOR(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (this.gridView.FocusedColumn.FieldName == "value"
                && (System.Convert.ToString(this.gridView.GetRowCellValue(this.gridView.FocusedRowHandle, "map_sourced_numbering_segment_id")) == "2"
                || System.Convert.ToString(this.gridView.GetRowCellValue(this.gridView.FocusedRowHandle, "map_sourced_numbering_segment_id")) == "3"
                || System.Convert.ToString(this.gridView.GetRowCellValue(this.gridView.FocusedRowHandle, "map_sourced_numbering_segment_id")) == ""))
            {
                e.Cancel = true;
            }
            else if ((this.gridView.FocusedColumn.FieldName == "firstnumeric"
                || this.gridView.FocusedColumn.FieldName == "lastnumeric")
                && (System.Convert.ToString(this.gridView.GetRowCellValue(this.gridView.FocusedRowHandle, "map_sourced_numbering_segment_id")) == "1"
                 || System.Convert.ToString(this.gridView.GetRowCellValue(this.gridView.FocusedRowHandle, "map_sourced_numbering_segment_id")) == ""))
            {
                e.Cancel = true;
            }
            else if (this.gridView.FocusedColumn.FieldName == "separator"
                && (this.gridView.FocusedRowHandle == this.gridView.DataRowCount - 1
                || System.Convert.ToString(this.gridView.GetRowCellValue(this.gridView.FocusedRowHandle, "map_sourced_numbering_segment_id")) == ""))
            {
                e.Cancel = true;
            }
            else if (this.gridView.FocusedColumn.FieldName == "void"
                && System.Convert.ToString(this.gridView.GetRowCellValue(this.gridView.FocusedRowHandle, "map_sourced_numbering_segment_id")) == "")
            {
                e.Cancel = true;
            }
        }
        private void CELLVALUECHANGED(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (this.gridView.FocusedColumn.FieldName == "firstnumeric" && changing == false)
            {
                if (System.Convert.ToString(this.gridView.GetRowCellValue(this.gridView.FocusedRowHandle, "map_sourced_numbering_segment_id")) == "2"
                 || System.Convert.ToString(this.gridView.GetRowCellValue(this.gridView.FocusedRowHandle, "map_sourced_numbering_segment_id")) == "3")
                {
                    changing = true;
                    this.gridView.SetRowCellValue(this.gridView.FocusedRowHandle, "value", this.gridView.GetRowCellValue(this.gridView.FocusedRowHandle, "firstnumeric"));
                    changing = false;
                }
            }
            this.lblSampleResult.Text = string.Empty;
            for(int ctr = 0;ctr<this.gridView.DataRowCount;ctr++)
            {
                if((ctr + 1) == System.Convert.ToInt32(this.gridView.GetRowCellValue(ctr,"seq")))
                {
                    if (ctr < this.gridView.DataRowCount-1)
                    {
                        this.lblSampleResult.Text = this.lblSampleResult.Text + System.Convert.ToString(this.gridView.GetRowCellValue(ctr, "value")) + System.Convert.ToString(this.gridView.GetRowCellValue(ctr, "separator"));
                    }
                    else
                    {
                        this.lblSampleResult.Text = this.lblSampleResult.Text + System.Convert.ToString(this.gridView.GetRowCellValue(ctr, "value"));
                    }
                }
            }
        }

       

        
    }
}