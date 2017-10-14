using GTSysOne.Gui.Slip;
using System;
using System.Data;
using System.Windows.Forms;

namespace GTSysOne.Gui.Document
{
    public partial class frmSalesQuotation : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        #region VARIABLE
        System.Data.DataSet dsRecord = null;
        DataTable dtLines;
        string CustomerID;
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
        public static frmSalesQuotation p_instance = null;
        public static frmSalesQuotation Instance
        {
            get
            {
                if (p_instance == null)
                {
                    p_instance = new frmSalesQuotation();
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
        protected frmSalesQuotation()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.FORM_LOAD);

            txtTotalAmount.Enabled = false;
            InitItems();
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
            // lookup's
            //GTSysOne.Class.Utility.clsUtility.createlookupRepository(repositoryItemLookUpSalesQuoteTaxId,
            //                                                            GTSysOne.Class.MasterFile.clsMas_Tax.ShowTable(
            //                                                                GTSysOne.Class.MasterFile.clsMas_Tax.Value(
            //                                                                    0, 6, string.Empty, string.Empty, false, false,
            //                                                                    GTSysOne.Class.Utility.clsGlobal.Instance().COMPANYID)),
            //                                                            new string[] { "Name" },
            //                                                            "id",
            //                                                            "Name");

            dsRecord = new DataSet();
            dsRecord = Class.Document.clsDoc_SalesQuotation.ShowDataSet(Class.Document.clsDoc_SalesQuotation.Value(0, 2, Id));

            if (dsRecord.Tables[0].Rows.Count > 0)
            {
                CustomerID = dsRecord.Tables[0].Rows[0]["customer_id"].ToString();
                txtDocumentNo.Text = dsRecord.Tables[0].Rows[0]["document_no"].ToString();
                txtCustomerNo.Text = dsRecord.Tables[0].Rows[0]["customer_no"].ToString();
                txtCustomerName.Text = dsRecord.Tables[0].Rows[0]["customer_name"].ToString();
                txtContactPerson.Text = dsRecord.Tables[0].Rows[0]["contact_person"].ToString();
                txtDocumentDate.Text = dsRecord.Tables[0].Rows[0]["document_date"].ToString();
                txtPostingDate.Text = Convert.ToDateTime(dsRecord.Tables[0].Rows[0]["posting_date"]).ToShortDateString();
                txtDocumentStatus.Text = dsRecord.Tables[0].Rows[0]["status"].ToString();
                txtTotalAmount.Text = dsRecord.Tables[0].Rows[0]["total_amount_incl_vat"].ToString();

                dtLines = dsRecord.Tables[1];
                grdControlLines.DataSource = dtLines;
            }

            if (EnformStatus == enFormStatus.Add)
            {
                Enable(true);
                txtDocumentNo.Text = Class.Utility.clsUtility.Numbering(Class.Utility.clsGlobal.myFunction.SalesQuotation);
            }

            if (string.IsNullOrWhiteSpace(txtDocumentNo.Text))
                txtDocumentNo.ReadOnly = false;
            else
                txtDocumentNo.ReadOnly = true;

            if (EnformStatus == enFormStatus.View)
                ReadOnly(true);

        }

        private void Clear()
        {
            Id = string.Empty;
            CustomerID = string.Empty;

            txtDocumentNo.Text = string.Empty;
            txtCustomerNo.Text = string.Empty;
            txtCustomerName.Text = string.Empty;
            txtContactPerson.Text = string.Empty;
            txtDocumentDate.Text = DateTime.Now.ToShortDateString();
            txtPostingDate.Text = DateTime.Now.ToShortDateString();
            txtTotalAmount.Text = "0";

            InitItems();
        }

        private void Enable(bool sw)
        {
            txtDocumentNo.Enabled = sw;
            txtCustomerNo.Enabled = sw;
            txtCustomerName.Enabled = sw;
            txtContactPerson.Enabled = sw;
            txtDocumentDate.Enabled = sw;
            txtPostingDate.Enabled = sw;

            grdControlLines.Enabled = sw;
        }

        private void ReadOnly(bool readOnly)
        {
            txtDocumentNo.ReadOnly = readOnly;
            txtCustomerNo.ReadOnly = readOnly;
            txtCustomerName.ReadOnly = readOnly;
            txtContactPerson.ReadOnly = readOnly;
            txtDocumentDate.ReadOnly = readOnly;
            txtPostingDate.ReadOnly = readOnly;

            grdControlLines.Enabled = !readOnly;
        }

        private void GridLayout(GTSysOne.Class.Utility.clsGlobal.GridLayout L)
        {
            //GTSysOne.Class.Utility.clsUtility.Layout_Restore_Save(this.gridViewUserPrivileges, L, GTSysOne.Class.Utility.clsGlobal.Instance().GridLayoutLocation + "Document\\" + this.Name.Replace("frm", ""), "Privileges", this.gridControlUserPrivileges);
            //GTSysOne.Class.Utility.clsUtility.Layout_Restore_Save(this.gridViewCompanyAccess, L, GTSysOne.Class.Utility.clsGlobal.Instance().GridLayoutLocation + "Document\\" + this.Name.Replace("frm", ""), "CompanyAccess", this.gridControlCompanyAccess);
            //GTSysOne.Class.Utility.clsUtility.Layout_Restore_Save(this.gridViewEstablishment, L, GTSysOne.Class.Utility.clsGlobal.Instance().GridLayoutLocation + "Document\\" + this.Name.Replace("frm", ""), "Establishment", this.gridControlEstablishment);
        }
        private void FORM_LOAD(object sender, System.EventArgs e)
        {
            txtDocumentStatus.Text = "Open";
            txtDocumentStatus.Enabled = false;

            this.Mapping();
            this.EventHandler();
            GTSysOne.Class.Utility.clsUtility.Language(this, typeof(GTSysOne.Gui.Document.frmSalesQuotation).Assembly);
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
                string ResultId = System.Convert.ToString(GTSysOne.Class.Document.clsDoc_SalesQuotation.ScalarValue(GTSysOne.Class.Document.clsDoc_SalesQuotation.Value(0, 4, System.Convert.ToString((sender as DevExpress.XtraEditors.ButtonEdit).Text))));
                if (ResultId.CompareTo(string.Empty) != 0)
                {
                    EnformStatus = GTSysOne.Gui.Document.frmSalesQuotation.enFormStatus.Edit;
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
                    EnformStatus = GTSysOne.Gui.Document.frmSalesQuotation.enFormStatus.Add;
                    Id = string.Empty;
                    this.EventHandler(false);
                    this.Clear();
                    this.Mapping();
                    this.EventHandler(true);
                    break;
                case "barSave":
                    GTSysOne.Class.Utility.clsGlobal.Instance().Err.ClearErrors();
                    GTSysOne.Class.Utility.clsGlobal.Instance().No_Error_Result = true;
                    GTSysOne.Class.Utility.clsUtility.ValidateControl(txtDocumentNo);
                    GTSysOne.Class.Utility.clsUtility.ValidateControl(txtCustomerNo);
                    GTSysOne.Class.Utility.clsUtility.ValidateControl(txtCustomerName);
                    GTSysOne.Class.Utility.clsUtility.ValidateControl(txtDocumentDate);
                    GTSysOne.Class.Utility.clsUtility.ValidateControl(txtPostingDate);

                    foreach (DataRow line in dtLines.Rows)
                    {
                        if (line["quantity"] == DBNull.Value)
                        {
                            GTSysOne.Class.Utility.clsUtility.GTSysMessageBox(new string[] { "Specify the quantity." }
                                    , GTSysOne.Class.Utility.clsGlobal.enMessageBoxButton.OK
                                    , GTSysOne.Class.Utility.clsGlobal.enMessageBoxIcon.Warning
                                    , "Quantity");

                            return;
                        }
                    }

                    if (GTSysOne.Class.Utility.clsGlobal.Instance().No_Error_Result)
                    {
                        Id = GTSysOne.Class.Document.clsDoc_SalesQuotation.Save(
                                GTSysOne.Class.Document.clsDoc_SalesQuotation.Value(
                                        (EnformStatus == GTSysOne.Gui.Document.frmSalesQuotation.enFormStatus.Add ? 1 : 2)
                                    , 0
                                    , Id
                                    , (EnformStatus == GTSysOne.Gui.Document.frmSalesQuotation.enFormStatus.Add ?
                                                    (!txtDocumentNo.Enabled ? GTSysOne.Class.Utility.clsUtility.Numbering(GTSysOne.Class.Utility.clsGlobal.myFunction.SalesQuotation, true) : txtDocumentNo.Text) :
                                                    txtDocumentNo.Text)
                                    , false
                                    , false
                                    , false
                                    , GTSysOne.Class.Utility.clsGlobal.Instance().COMPANYID
                                    , GTSysOne.Class.Utility.clsGlobal.Instance().ESTABLISHMENTID
                                    , GTSysOne.Class.Utility.clsGlobal.Instance().STATIONID
                                    , Convert.ToString((int)GTSysOne.Class.Utility.clsGlobal.myFunction.SalesQuotation)
                                    , GTSysOne.Class.Utility.clsGlobal.Instance().UserId
                                    , string.Empty
                                    , CustomerID
                                    , txtCustomerName.Text
                                    , txtPostingDate.Text
                                    , txtDocumentDate.Text
                                    , "Open"
                                    , Convert.ToDouble(txtTotalAmount.Text)
                                ));

                        // Save the lines                   
                        foreach (DataRow lineRow in dtLines.Rows)
                        {
                            GTSysOne.Class.Slip.clsSlip_SalesQuotation.Save(
                                GTSysOne.Class.Slip.clsSlip_SalesQuotation.Value(
                                      (string.IsNullOrWhiteSpace(lineRow["line_id"].ToString()) ? 1 : 2)
                                    , 0
                                    , (string.IsNullOrWhiteSpace(lineRow["line_id"].ToString()) ?
                                        GTSysOne.Class.Utility.clsUtility.Numbering(
                                            GTSysOne.Class.Utility.clsGlobal.myFunction.SalesQuotation, true) :
                                        lineRow["line_id"].ToString())
                                    , false
                                    , false
                                    , false
                                    , GTSysOne.Class.Utility.clsGlobal.Instance().COMPANYID
                                    , GTSysOne.Class.Utility.clsGlobal.Instance().ESTABLISHMENTID
                                    , GTSysOne.Class.Utility.clsGlobal.Instance().STATIONID
                                    , Convert.ToString((int)GTSysOne.Class.Utility.clsGlobal.myFunction.SalesQuotation)
                                    , GTSysOne.Class.Utility.clsGlobal.Instance().UserId
                                    , string.Empty
                                    , Id
                                    , (string)lineRow["item_id"]
                                    , Convert.ToInt32(lineRow["quantity"])
                                    , Convert.ToDouble(lineRow["line_total"])
                                    ));
                        }

                        GTSysOne.Gui.Dashboard.Document.frmSalesQuotation.CallFromMain("Refresh", Id, false, 1, Id);
                        this.Clear();
                        this.Mapping();
                    }
                    break;
                case "barFirst":
                    ResultId = GTSysOne.Class.Utility.clsUtility.Navigator(Id, "2", GTSysOne.Class.Utility.clsGlobal.myFunction.User);
                    if (ResultId.CompareTo(string.Empty) != 0)
                    {
                        if (EnformStatus != GTSysOne.Gui.Document.frmSalesQuotation.enFormStatus.View)
                        {
                            EnformStatus = GTSysOne.Gui.Document.frmSalesQuotation.enFormStatus.Edit;
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
                        if (EnformStatus != GTSysOne.Gui.Document.frmSalesQuotation.enFormStatus.View)
                        {
                            EnformStatus = GTSysOne.Gui.Document.frmSalesQuotation.enFormStatus.Edit;
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
                        if (EnformStatus != GTSysOne.Gui.Document.frmSalesQuotation.enFormStatus.View)
                        {
                            EnformStatus = GTSysOne.Gui.Document.frmSalesQuotation.enFormStatus.Edit;
                        }
                        Id = ResultId;
                        this.EventHandler(false);
                        this.Mapping();
                        this.EventHandler(true);
                    }
                    break;
                case "barLast":
                    ResultId = GTSysOne.Class.Utility.clsUtility.Navigator(Id, "3", GTSysOne.Class.Utility.clsGlobal.myFunction.User);
                    if (ResultId.CompareTo(string.Empty) != 0)
                    {
                        if (EnformStatus != GTSysOne.Gui.Document.frmSalesQuotation.enFormStatus.View)
                        {
                            EnformStatus = GTSysOne.Gui.Document.frmSalesQuotation.enFormStatus.Edit;
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

        private void txtCustomer_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
           //// frmCustomerBrowse1r frm = new frmCustomerBrowse1r();
           // if (frm.ShowDialog(this) == DialogResult.OK)
           // {
           //     CustomerID = frm.selectedRow["id"].ToString();
           //     txtCustomerNo.Text = frm.selectedRow["num"].ToString();
           //     txtCustomerName.Text = frm.selectedRow["name"].ToString();
           //     txtContactPerson.Text = frm.selectedRow["contact_person"].ToString();
           // }
        }

        private void GridItemEditButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            frmItemBrowser frm = new frmItemBrowser();

            if (frm.ShowDialog(this) == DialogResult.OK)
            {
                DataRow rowItem = dtLines.NewRow();

                rowItem["item_id"] = frm.selectedRow["id"];
                rowItem["name"] = frm.selectedRow["name"];
                rowItem["quantity"] = 1;
                rowItem["description"] = frm.selectedRow["desc1"];
                rowItem["defaultpricebeforetax"] = Convert.ToDouble(frm.selectedRow["defaultpricebeforetax"]);
                rowItem["defaultpriceaftertax"] = Convert.ToDouble(frm.selectedRow["defaultpriceaftertax"]);
                rowItem["line_total"] = Convert.ToDouble(rowItem["quantity"]) * Convert.ToDouble(frm.selectedRow["defaultpricebeforetax"]);
                rowItem["gross_price"] = Convert.ToDouble(rowItem["quantity"]) * Convert.ToDouble(frm.selectedRow["defaultpricebeforetax"]);
                dtLines.Rows.Add(rowItem);

                txtTotalAmount.EditValue = dtLines.Compute("SUM(line_total)", "");
            }
        }

        private void QuantityTextEdit_EditValueChanged(object sender, EventArgs e)
        {
            DataRow selectedRow = grdViewLines.GetFocusedDataRow();
            if (selectedRow == null)
            {
                Class.Utility.clsUtility.GTSysMessageBox(new string[] { "Select an item first before applying quantity in the selected line." }
                                    , Class.Utility.clsGlobal.enMessageBoxButton.OK
                                    , Class.Utility.clsGlobal.enMessageBoxIcon.Warning
                                    , "Line Item");

                return;
            }

            double unitPrice = Convert.ToDouble(selectedRow["defaultpricebeforetax"]);
            double qty = Convert.ToDouble(((DevExpress.XtraEditors.TextEdit)sender).Text);

            selectedRow["quantity"] = qty;
            selectedRow["line_total"] = (qty * unitPrice);
            selectedRow["gross_price"] = (qty * unitPrice);            

            if (!(selectedRow["discount_percentage"] == DBNull.Value))
                selectedRow["discount_amount"] = Convert.ToDouble(selectedRow["line_total"]) * Math.Round((Convert.ToDouble(selectedRow["discount_percentage"]) / 100), 2);

            txtTotalAmount.EditValue = dtLines.Compute("SUM(line_total)", "");
        }

        private void repositoryItemTextSalesQuoteDiscount_EditValueChanged(object sender, EventArgs e)
        {
            DataRow selectedRow = grdViewLines.GetFocusedDataRow();
            if (dtLines.Rows.Count == 0)
            {
                Class.Utility.clsUtility.GTSysMessageBox(new string[] { "Can't input a discount if the line is empty." }
                                    , Class.Utility.clsGlobal.enMessageBoxButton.OK
                                    , Class.Utility.clsGlobal.enMessageBoxIcon.Warning
                                    , "Lines Empty");

                return;
            }

            double unitPrice = Convert.ToDouble(selectedRow["defaultpricebeforetax"]);
            double qty = Convert.ToDouble(selectedRow["quantity"]);
            double lineTotal = qty * unitPrice;

            selectedRow["discount_amount"] =
                lineTotal * 
                (Math.Round(Convert.ToDouble(((DevExpress.XtraEditors.TextEdit)sender).Text) / 100,2));
            selectedRow["line_total"] = lineTotal - Convert.ToDouble(selectedRow["discount_amount"]);
            selectedRow["gross_price"] = selectedRow["line_total"];
        }

        private void repositoryItemButtonSalesQuoteTax_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            frmTaxBrowser frm = new frmTaxBrowser();
            
            if (dtLines.Rows.Count == 0)
            {
                Class.Utility.clsUtility.GTSysMessageBox(new string[] { "Can't input a TAX if the lines is empty." }
                                    , Class.Utility.clsGlobal.enMessageBoxButton.OK
                                    , Class.Utility.clsGlobal.enMessageBoxIcon.Warning
                                    , "Lines Empty");
                return;
            }

            if (frm.ShowDialog(this) == DialogResult.OK)
            {
                DataRow selectedRow = grdViewLines.GetFocusedDataRow();

                if (selectedRow == null)
                {
                    Class.Utility.clsUtility.GTSysMessageBox(new string[] { "Select an item first before applying TAX in the selected line." }
                                    , Class.Utility.clsGlobal.enMessageBoxButton.OK
                                    , Class.Utility.clsGlobal.enMessageBoxIcon.Warning
                                    , "Line Item");

                    return;
                }

                selectedRow["tax_id"] = frm.selectedRow["id"];
                selectedRow["tax_code"] = frm.selectedRow["num"];
                selectedRow["tax_percentage"] = frm.selectedRow["percentage"];
                selectedRow["tax_amount"] = Math.Round(Convert.ToDouble(selectedRow["line_total"]) * (Convert.ToDouble(frm.selectedRow["percentage"]) / 100), 2);
            }
        }

        #region Methods

        private void InitItems()
        {
            dtLines = new DataTable();

            dtLines.Columns.Add("line_id");
            dtLines.Columns.Add("item_id");
            dtLines.Columns.Add("name");
            dtLines.Columns.Add("description");
            dtLines.Columns.Add("quantity", typeof(double));
            dtLines.Columns.Add("defaultpricebeforetax", typeof(double));
            dtLines.Columns.Add("defaultpriceaftertax", typeof(double));
            dtLines.Columns.Add("line_total", typeof(double));
            dtLines.Columns.Add("gross_price", typeof(double));
            dtLines.Columns.Add("discount_percentage", typeof(double));
            dtLines.Columns.Add("discount_amount", typeof(double));
            dtLines.Columns.Add("bar_code");
            dtLines.Columns.Add("price_level_id");
            dtLines.Columns.Add("price_level");
            dtLines.Columns.Add("lot_no_code");
            dtLines.Columns.Add("serial_no_code");
            dtLines.Columns.Add("slip_uom_id");
            dtLines.Columns.Add("tax_id");
            dtLines.Columns.Add("tax_code");
            dtLines.Columns.Add("tax_percentage");
            dtLines.Columns.Add("tax_amount");

            grdControlLines.DataSource = dtLines;
        }

        #endregion
    }
}