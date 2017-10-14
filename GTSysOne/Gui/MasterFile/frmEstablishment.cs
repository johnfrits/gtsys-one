namespace GTSysOne.Gui.MasterFile
{
    public partial class frmEstablishment : DevExpress.XtraBars.Ribbon.RibbonForm
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
        public static frmEstablishment p_instance = null;
        public static frmEstablishment Instance
        {
            get
            {
                if (p_instance == null)
                {
                    p_instance = new frmEstablishment();
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
        protected frmEstablishment()
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
                this.barCopy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.CLICK);

                this.repositoryItemLookUpEditStatus.EditValueChanged += new System.EventHandler(this.STATUS);
                this.repositoryItemLookUpEditGroup.EditValueChanged += new System.EventHandler(this.GROUP);
                this.repositoryItemLookUpEditCountry.EditValueChanged += new System.EventHandler(this.COUNTRY);
                this.repositoryItemLookUpEditRegion.EditValueChanged += new System.EventHandler(this.REGION);
                this.repositoryItemLookUpEditTaxArea.EditValueChanged += new System.EventHandler(this.TAXAREA);
                this.repositoryItemLookUpEditAllocationPattern.EditValueChanged += new System.EventHandler(this.AP);
                this.repositoryItemLookUpEditPriceLevel.EditValueChanged += new System.EventHandler(this.PL);

                this.gridView.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.CELLVALUECHANGING);
                this.gridView.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.NEWROW);

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
                this.barCopy.ItemClick -= new DevExpress.XtraBars.ItemClickEventHandler(this.CLICK);



                this.repositoryItemLookUpEditStatus.EditValueChanged -= new System.EventHandler(this.STATUS);
                this.repositoryItemLookUpEditGroup.EditValueChanged -= new System.EventHandler(this.GROUP);
                this.repositoryItemLookUpEditCountry.EditValueChanged -= new System.EventHandler(this.COUNTRY);
                this.repositoryItemLookUpEditRegion.EditValueChanged -= new System.EventHandler(this.REGION);
                this.repositoryItemLookUpEditTaxArea.EditValueChanged -= new System.EventHandler(this.TAXAREA);
                this.repositoryItemLookUpEditAllocationPattern.EditValueChanged -= new System.EventHandler(this.AP);
                this.repositoryItemLookUpEditPriceLevel.EditValueChanged -= new System.EventHandler(this.PL);

                this.gridView.CellValueChanging -= new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.CELLVALUECHANGING);
                this.gridView.InitNewRow -= new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.NEWROW);
                this.repositoryItemSearchControl1.ButtonClick -= new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.SEARCH_PRESSED);
            }
        }
        private void STATUS(object sender, System.EventArgs e)
        {
            this.gridView.SetRowCellValue(this.gridView.FocusedRowHandle, "MAPSTATId", (sender as DevExpress.XtraEditors.BaseEdit).EditValue);
            GTSysOne.Class.Utility.clsUtility.FocusLastNewRow(this.gridView, this.gridControl, "Establishment Status");
        }
        private void GROUP(object sender, System.EventArgs e)
        {
            this.gridView.SetRowCellValue(this.gridView.FocusedRowHandle, "GRPId", (sender as DevExpress.XtraEditors.BaseEdit).EditValue);
            GTSysOne.Class.Utility.clsUtility.FocusLastNewRow(this.gridView, this.gridControl, "Group");
        }
        private void COUNTRY(object sender, System.EventArgs e)
        {
            this.gridView.SetRowCellValue(this.gridView.FocusedRowHandle, "COUNTId", (sender as DevExpress.XtraEditors.BaseEdit).EditValue);
            GTSysOne.Class.Utility.clsUtility.FocusLastNewRow(this.gridView, this.gridControl, "Country");
        }
        private void REGION(object sender, System.EventArgs e)
        {
            this.gridView.SetRowCellValue(this.gridView.FocusedRowHandle, "REGId", (sender as DevExpress.XtraEditors.BaseEdit).EditValue);
            GTSysOne.Class.Utility.clsUtility.FocusLastNewRow(this.gridView, this.gridControl, "Region");
        }
        private void TAXAREA(object sender, System.EventArgs e)
        {
            this.gridView.SetRowCellValue(this.gridView.FocusedRowHandle, "TAId", (sender as DevExpress.XtraEditors.BaseEdit).EditValue);
            GTSysOne.Class.Utility.clsUtility.FocusLastNewRow(this.gridView, this.gridControl, "TaxArea");
        }
        private void AP(object sender, System.EventArgs e)
        {
            this.gridView.SetRowCellValue(this.gridView.FocusedRowHandle, "APId", (sender as DevExpress.XtraEditors.BaseEdit).EditValue);
            GTSysOne.Class.Utility.clsUtility.FocusLastNewRow(this.gridView, this.gridControl, "Allocation Pattern");
        }
        private void PL(object sender, System.EventArgs e)
        {
            this.gridView.SetRowCellValue(this.gridView.FocusedRowHandle, "PLId", (sender as DevExpress.XtraEditors.BaseEdit).EditValue);
            GTSysOne.Class.Utility.clsUtility.FocusLastNewRow(this.gridView, this.gridControl, "Price Level");
        }
        private void NEWROW(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            this.gridView.SetRowCellValue(e.RowHandle, "id", "NEWID()" + System.Guid.NewGuid().ToString());
            this.gridView.SetRowCellValue(e.RowHandle, "Active", false);
            this.gridView.SetRowCellValue(e.RowHandle, "Void", false);
        }

        private void Mapping()
        {
            GTSysOne.Class.Utility.clsUtility.createlookup(this.lookUpEditCompany, GTSysOne.Class.Document.clsDoc_Company.ShowTable(GTSysOne.Class.Document.clsDoc_Company.Value(0, 0)), new string[] { "Name", "Address", "Owner" }, "id", "Name");
            
            GTSysOne.Class.Utility.clsUtility.createlookupRepository(this.repositoryItemLookUpEditStatus, GTSysOne.Class.Mapping.clsMap_EstablishmentStatus.ShowTable(GTSysOne.Class.Mapping.clsMap_EstablishmentStatus.Value(0, 0)), new string[] { "Name" }, "id", "Name");
            GTSysOne.Class.Utility.clsUtility.createlookupRepository(this.repositoryItemLookUpEditGroup, GTSysOne.Class.MasterFile.clsMas_Group.ShowTable(GTSysOne.Class.MasterFile.clsMas_Group.Value(0, 0)), new string[] { "Name" }, "id", "Name");
            GTSysOne.Class.Utility.clsUtility.createlookupRepository(this.repositoryItemLookUpEditCountry, GTSysOne.Class.Document.clsDoc_Country.ShowTable(GTSysOne.Class.Document.clsDoc_Country.Value(0, 0)), new string[] { "Name" }, "id", "Name");
            GTSysOne.Class.Utility.clsUtility.createlookupRepository(this.repositoryItemLookUpEditRegion, GTSysOne.Class.MasterFile.clsMas_Region.ShowTable(GTSysOne.Class.MasterFile.clsMas_Region.Value(0, 0)), new string[] { "Name" }, "id", "Name");
            GTSysOne.Class.Utility.clsUtility.createlookupRepository(this.repositoryItemLookUpEditTaxArea, GTSysOne.Class.MasterFile.clsMas_TaxArea.ShowTable(GTSysOne.Class.MasterFile.clsMas_TaxArea.Value(0, 0)), new string[] { "Name" }, "id", "Name");
            GTSysOne.Class.Utility.clsUtility.createlookupRepository(this.repositoryItemLookUpEditAllocationPattern, GTSysOne.Class.MasterFile.clsMas_AllocationPattern.ShowTable(GTSysOne.Class.MasterFile.clsMas_AllocationPattern.Value(0, 0)), new string[] { "Name" }, "id", "Name");
            GTSysOne.Class.Utility.clsUtility.createlookupRepository(this.repositoryItemLookUpEditPriceLevel, GTSysOne.Class.MasterFile.clsMas_PriceLevel.ShowTable(GTSysOne.Class.MasterFile.clsMas_PriceLevel.Value(0, 0)), new string[] { "Name" }, "id", "Name");

            GTSysOne.Class.Utility.clsUtility.View(this.gridControl
               , this.gridView
               , 0
               , GTSysOne.Class.Slip.clsSlip_EstablishmentSettings.ShowTable(GTSysOne.Class.Slip.clsSlip_EstablishmentSettings.Value(0, 0, Id))
               , string.Empty
               , true);

            dtRecord = new System.Data.DataTable();
            dtRecord = GTSysOne.Class.MasterFile.clsMas_Establishment.ShowTable(GTSysOne.Class.MasterFile.clsMas_Establishment.Value(0, 6, Id));
            if (dtRecord.Rows.Count > 0)
            {
                this.txtNumbering.Text = System.Convert.ToString(dtRecord.Rows[0]["num"]);
                this.txtName.Text = System.Convert.ToString(dtRecord.Rows[0]["name"]);
                this.txtShortName.Text = System.Convert.ToString(dtRecord.Rows[0]["shortname"]);
                this.txtAddress.Text = System.Convert.ToString(dtRecord.Rows[0]["address"]);
                this.chkVirtual.Checked = System.Convert.ToBoolean((System.DBNull.Value == dtRecord.Rows[0]["virtual"] ? false : dtRecord.Rows[0]["virtual"]));
                this.chkActive.Checked = !System.Convert.ToBoolean(dtRecord.Rows[0]["void"]);

                this.lookUpEditCompany.EditValue = dtRecord.Rows[0]["doc_sourced_company_id"];

                this.chkVirtual.Enabled = false;
                
            }
            if (EnformStatus == GTSysOne.Gui.MasterFile.frmEstablishment.enFormStatus.Add)
            {
                this.Enable(true);
                this.txtNumbering.Text = GTSysOne.Class.Utility.clsUtility.Numbering(GTSysOne.Class.Utility.clsGlobal.myFunction.Establishment);
                if (GTSysOne.Class.Utility.clsGlobal.Instance().TOTALESTABLISHMENT 
                    < System.Convert.ToInt32(GTSysOne.Class.MasterFile.clsMas_Establishment.ScalarValue(
                    GTSysOne.Class.MasterFile.clsMas_Establishment.Value(0, 9))))
                {
                    this.chkVirtual.Checked = true;
                    this.chkVirtual.Enabled = false;
                }
            }
            if (this.txtNumbering.Text.CompareTo(string.Empty) == 0)
            {
                this.txtNumbering.Enabled = true;
            }
            else
            {
                this.txtNumbering.Enabled = false;
            }
            if (EnformStatus == GTSysOne.Gui.MasterFile.frmEstablishment.enFormStatus.View)
            {
                this.Enable(false);
                this.txtNumbering.Enabled = false;
                if (!this.chkVirtual.Checked)
                {
                    this.barCopy.Enabled = true;
                }
            }
        }
        private void Clear()
        {
            this.txtName.Text = string.Empty;
            this.txtShortName.Text = string.Empty;
            this.txtAddress.Text = string.Empty;
            this.chkVirtual.Checked = false;
            this.chkActive.Checked = true;
            this.lookUpEditCompany.EditValue = null;
            this.lookUpEditCompany.Text = string.Empty;
            Id = string.Empty;
        }
        private void Enable(bool sw)
        {
            this.txtName.Enabled = sw;
            this.txtShortName.Enabled = sw;
            this.txtAddress.Enabled = sw;
            this.chkVirtual.Enabled = sw;
            this.chkActive.Enabled = sw;
            this.lookUpEditCompany.Enabled = sw;
            this.barSave.Enabled = sw;
            this.gridView.OptionsBehavior.ReadOnly = !sw;
        }
        private void GridLayout(GTSysOne.Class.Utility.clsGlobal.GridLayout L)
        {
            GTSysOne.Class.Utility.clsUtility.Layout_Restore_Save(this.gridView, L, GTSysOne.Class.Utility.clsGlobal.Instance().GridLayoutLocation + "MasterFile\\", this.Name.Replace("frm", ""), this.gridControl);
            //GTSysOne.Class.Utility.clsUtility.Layout_Restore_Save(this.gridViewCompanyAccess, L, GTSysOne.Class.Utility.clsGlobal.Instance().GridLayoutLocation + "Document\\" + this.Name.Replace("frm", ""), "CompanyAccess", this.gridControlCompanyAccess);
            //GTSysOne.Class.Utility.clsUtility.Layout_Restore_Save(this.gridViewEstablishment, L, GTSysOne.Class.Utility.clsGlobal.Instance().GridLayoutLocation + "Document\\" + this.Name.Replace("frm", ""), "Establishment", this.gridControlEstablishment);
        }
        private void FORM_LOAD(object sender, System.EventArgs e)
        {
            this.Mapping();
            this.EventHandler();
            GTSysOne.Class.Utility.clsUtility.Language(this, typeof(GTSysOne.Gui.MasterFile.frmEstablishment).Assembly);
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
                string ResultId = System.Convert.ToString(GTSysOne.Class.MasterFile.clsMas_Establishment.ScalarValue(GTSysOne.Class.MasterFile.clsMas_Establishment.Value(0, 7, System.Convert.ToString((sender as DevExpress.XtraEditors.ButtonEdit).Text))));
                if (ResultId.CompareTo(string.Empty) != 0)
                {
                    EnformStatus = GTSysOne.Gui.MasterFile.frmEstablishment.enFormStatus.Edit;
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
                    EnformStatus = GTSysOne.Gui.MasterFile.frmEstablishment.enFormStatus.Add;
                    Id = string.Empty;
                    this.EventHandler(false);
                    this.Clear();
                    this.Mapping();
                    this.EventHandler(true);
                    break;
                case "barCopy":
                    #region DOWNLOAD
                    this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
                    System.Windows.Forms.FolderBrowserDialog f = new System.Windows.Forms.FolderBrowserDialog();
                    this.Cursor = System.Windows.Forms.Cursors.Default;
                    if (f.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
                        if (!System.IO.File.Exists(@f.SelectedPath + "\\" + this.txtName.Text + "ESTAB.lkf"))
                        {
                            using (System.IO.TextWriter tw = new System.IO.StreamWriter(@f.SelectedPath + "\\" + this.txtName.Text + "ESTAB.lkf", true))
                            {
                                tw.WriteLine("-----****************Measure what can be measured....*******************--------------");
                                tw.WriteLine("License Key*" + System.Convert.ToString(dtRecord.Rows[0]["control"]));
                                tw.WriteLine("-----****************And make measurable what cannot be measured....*******************--------------");
                                tw.Dispose();
                                tw.Close();
                                System.IO.File.SetAttributes(@f.SelectedPath + "\\" + this.txtName.Text + "ESTAB.lkf", System.IO.FileAttributes.ReadOnly);

                            }
                            GTSysOne.Class.Utility.clsUtility.GTSysMessageBox(new string[] { "Save Establishment License Location " + @f.SelectedPath + "\\" + this.txtName.Text + "ESTAB.lkf" }
                                , GTSysOne.Class.Utility.clsGlobal.enMessageBoxButton.OK
                                , GTSysOne.Class.Utility.clsGlobal.enMessageBoxIcon.Information
                                , "Establishment License");
                            this.Cursor = System.Windows.Forms.Cursors.Default;
                        }
                        else
                        {
                            this.Cursor = System.Windows.Forms.Cursors.Default;
                            GTSysOne.Class.Utility.clsUtility.GTSysMessageBox(new string[] { "LKF File Name Already exist to this Location. Please Place it on another Location" }
                                , GTSysOne.Class.Utility.clsGlobal.enMessageBoxButton.OK
                                , GTSysOne.Class.Utility.clsGlobal.enMessageBoxIcon.Warning
                                , "Establishment License");
                        }
                    }
                    f.Dispose();
                    this.Cursor = System.Windows.Forms.Cursors.Default;
                    #endregion
                    break;
                case "barSave":
                    GTSysOne.Class.Utility.clsGlobal.Instance().Err.ClearErrors();
                    GTSysOne.Class.Utility.clsGlobal.Instance().No_Error_Result = true;
                    GTSysOne.Class.Utility.clsUtility.ValidateControl(this.txtName);
                    GTSysOne.Class.Utility.clsUtility.ValidateControl(this.lookUpEditCompany);

                    if (this.gridView.DataRowCount == 0 && GTSysOne.Class.Utility.clsGlobal.Instance().No_Error_Result)
                    {
                        GTSysOne.Class.Utility.clsUtility.GTSysMessageBox(new string[] { "No Data To Saved." }
                                    , GTSysOne.Class.Utility.clsGlobal.enMessageBoxButton.OK
                                    , GTSysOne.Class.Utility.clsGlobal.enMessageBoxIcon.Warning
                                    , "No Data");
                        GTSysOne.Class.Utility.clsGlobal.Instance().No_Error_Result = false;
                    }

                    if (GTSysOne.Class.Utility.clsGlobal.Instance().No_Error_Result && this.gridView.DataRowCount > 0)
                    {
                        
                        Id = GTSysOne.Class.MasterFile.clsMas_Establishment.Save(GTSysOne.Class.MasterFile.clsMas_Establishment.Value(
                            (EnformStatus == GTSysOne.Gui.MasterFile.frmEstablishment.enFormStatus.Add ? 1 : 2)
                            , (EnformStatus == GTSysOne.Gui.MasterFile.frmEstablishment.enFormStatus.Add ? 1 : 3)
                            , Id
                            , (EnformStatus == GTSysOne.Gui.MasterFile.frmEstablishment.enFormStatus.Add ? (this.txtNumbering.Enabled == false ? GTSysOne.Class.Utility.clsUtility.Numbering(GTSysOne.Class.Utility.clsGlobal.myFunction.Establishment, true) : this.txtNumbering.Text) : this.txtNumbering.Text)
                            , (this.chkActive.Checked ? false:true)
                            , false
                            , GTSysOne.Class.Utility.clsGlobal.Instance().COMPANYID
                            , GTSysOne.Class.Utility.clsGlobal.Instance().ESTABLISHMENTID
                            , GTSysOne.Class.Utility.clsGlobal.Instance().STATIONID
                            , System.Convert.ToString((int)GTSysOne.Class.Utility.clsGlobal.myFunction.Establishment)
                            , GTSysOne.Class.Utility.clsGlobal.Instance().UserId
                            , System.Convert.ToString(GTSysOne.Class.Utility.clsUtility.SERVERDATE())
                            , System.Convert.ToString(this.lookUpEditCompany.EditValue)
                            , this.txtName.Text
                            , this.txtShortName.Text
                            , this.txtAddress.Text
                            , string.Empty
                            , string.Empty
                            , string.Empty
                            , this.chkVirtual.Checked
                            , "0"));

                        if(EnformStatus == GTSysOne.Gui.MasterFile.frmEstablishment.enFormStatus.Add)
                        {
                            string[] DecryptedKeys = GTSysOne.Class.Utility.clsEncryption.JayDhreiZIP.Decrypt(GTSysOne.Class.Utility.clsGlobal.Instance().COLICENSE, "").Split('*');
                            string CONTROL = GTSysOne.Class.Utility.clsEncryption.JayDhreiZIP.Encrypt(DecryptedKeys[0]
                                                    + "*" + DecryptedKeys[1]
                                                    + "*" + DecryptedKeys[2]
                                                    + "*" + DecryptedKeys[3]
                                                    + "*" + DecryptedKeys[4]
                                                    + "*" + DecryptedKeys[5]
                                                    + "*" + DecryptedKeys[6]
                                                    + "*" + DecryptedKeys[7]
                                                    + "*" + DecryptedKeys[8]
                                                    + "*" + Id, "");
                            //UPDATE EST
                            GTSysOne.Class.MasterFile.clsMas_Establishment.Save(GTSysOne.Class.MasterFile.clsMas_Establishment.Value(
                                  2
                                , 0
                                , Id
                                , string.Empty
                                , false
                                , false
                                , GTSysOne.Class.Utility.clsGlobal.Instance().COMPANYID
                                , GTSysOne.Class.Utility.clsGlobal.Instance().ESTABLISHMENTID
                                , GTSysOne.Class.Utility.clsGlobal.Instance().STATIONID
                                , System.Convert.ToString((int)GTSysOne.Class.Utility.clsGlobal.myFunction.Establishment)
                                , GTSysOne.Class.Utility.clsGlobal.Instance().UserId
                                , System.Convert.ToString(GTSysOne.Class.Utility.clsUtility.SERVERDATE())
                                , System.Convert.ToString(this.lookUpEditCompany.EditValue)
                                , this.txtName.Text
                                , this.txtShortName.Text
                                , this.txtAddress.Text
                                , string.Empty
                                , CONTROL
                                , string.Empty
                                , this.chkVirtual.Checked
                                , "0"));
                        }


                        for (int ctr = 0; ctr < this.gridView.DataRowCount; ctr++)
                        {
                            System.Data.DataRow row = this.gridView.GetDataRow(ctr);
                            GTSysOne.Class.Slip.clsSlip_EstablishmentSettings.Save(
                                GTSysOne.Class.Slip.clsSlip_EstablishmentSettings.Value((
                                System.Convert.ToString(row["id"]).IndexOf("NEWID()") > -1 ? 1 : 2)
                                , 0
                                , System.Convert.ToString(row["id"])
                                , "0"
                                , (System.Convert.ToBoolean(row["Void"]) ? "1" : "0")
                                , "0"
                                , GTSysOne.Class.Utility.clsGlobal.Instance().COMPANYID
                                , GTSysOne.Class.Utility.clsGlobal.Instance().ESTABLISHMENTID
                                , GTSysOne.Class.Utility.clsGlobal.Instance().STATIONID
                                , System.Convert.ToString((int)GTSysOne.Class.Utility.clsGlobal.myFunction.Establishment)
                                , GTSysOne.Class.Utility.clsGlobal.Instance().UserId
                                , string.Empty
                                , System.Convert.ToString(row["Area"])
                                , Id
                                , System.Convert.ToString(row["MAPSTATId"])
                                , System.Convert.ToString(row["GRPId"])
                                , System.Convert.ToString(row["COUNTId"])
                                , System.Convert.ToString(row["REGId"])
                                , System.Convert.ToString(row["TAId"])
                                , System.Convert.ToString(row["APId"])
                                , System.Convert.ToString(row["PLId"])
                                , (System.Convert.ToBoolean(row["Active"]) ? "1": "0")
                                , "0"));
                        }

                        GTSysOne.Gui.Dashboard.MasterFile.frmEstablishment.CallFromMain("Refresh", Id, false, 1, Id);
                        this.Clear();
                        this.Mapping();
                    }
                    break;
                case "barFirst":
                    ResultId = GTSysOne.Class.Utility.clsUtility.Navigator(Id, "2", GTSysOne.Class.Utility.clsGlobal.myFunction.Establishment);
                    if (ResultId.CompareTo(string.Empty) != 0)
                    {
                        if (EnformStatus != GTSysOne.Gui.MasterFile.frmEstablishment.enFormStatus.View)
                        {
                            EnformStatus = GTSysOne.Gui.MasterFile.frmEstablishment.enFormStatus.Edit;
                        }
                        Id = ResultId;
                        this.EventHandler(false);
                        this.Mapping();
                        this.EventHandler(true);
                    }
                    break;
                case "barPrevious":
                    ResultId = GTSysOne.Class.Utility.clsUtility.Navigator(Id, "0", GTSysOne.Class.Utility.clsGlobal.myFunction.Establishment);
                    if (ResultId.CompareTo(string.Empty) != 0)
                    {
                        if (EnformStatus != GTSysOne.Gui.MasterFile.frmEstablishment.enFormStatus.View)
                        {
                            EnformStatus = GTSysOne.Gui.MasterFile.frmEstablishment.enFormStatus.Edit;
                        }
                        Id = ResultId;
                        this.EventHandler(false);
                        this.Mapping();
                        this.EventHandler(true);
                    }
                    break;
                case "barNext":
                    ResultId = GTSysOne.Class.Utility.clsUtility.Navigator(Id, "1", GTSysOne.Class.Utility.clsGlobal.myFunction.Establishment);
                    if (ResultId.CompareTo(string.Empty) != 0)
                    {
                        if (EnformStatus != GTSysOne.Gui.MasterFile.frmEstablishment.enFormStatus.View)
                        {
                            EnformStatus = GTSysOne.Gui.MasterFile.frmEstablishment.enFormStatus.Edit;
                        }
                        Id = ResultId;
                        this.EventHandler(false);
                        this.Mapping();
                        this.EventHandler(true);
                    }
                    break;
                case "barLast":
                    ResultId = GTSysOne.Class.Utility.clsUtility.Navigator(Id, "3", GTSysOne.Class.Utility.clsGlobal.myFunction.Establishment);
                    if (ResultId.CompareTo(string.Empty) != 0)
                    {
                        if (EnformStatus != GTSysOne.Gui.MasterFile.frmEstablishment.enFormStatus.View)
                        {
                            EnformStatus = GTSysOne.Gui.MasterFile.frmEstablishment.enFormStatus.Edit;
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

        private void CELLVALUECHANGING(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GTSysOne.Class.Utility.clsUtility.SINGLESELECTION_CHECKBOXCOLUMN(sender, e, "Active");
        }
    }
}