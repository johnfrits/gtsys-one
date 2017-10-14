using DevExpress.XtraGrid.Views.Grid;
using GTSysOne.Gui.Slip;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace GTSysOne.Gui.Document
{
    public partial class frmRent : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        #region VARIABLE
        private DataTable dtRecordDeposit = null;
        private DataTable dtRecordPayment = null;
        private DataTable dtRecord = null;
        DateTime dateOut;
        DateTime dateReturn;
        bool changing = false;
        string slip_id;
        //bool loadDriver = false;
        double noOfDays = 0;
        double totalCalculatedDailyrate = 0;
        double kmTaked = 0;
        double kmFrom = 0;
        double kmTo = 0;
        double dailyRate = 0;
        double cdw = 0;
        double dellcolcharge = 0;
        double total = 0;
        double tax = 0;
        double discount = 0;
        double nettotal = 0;
        double grandTotal = 0;
        double remainder = 0;
        double payment = 0;
        double currentDeposit = 0;
        bool print = false;
        bool isdelete = false;
        bool isvoid = false;
        #endregion

        #region PROPERTY
        private static string p_Id = "";
        public string Id
        {
            get { return p_Id; }
            set { p_Id = value; }
        }
        private double kmPerDay;

        public double Kmperday
        {
            get { return kmPerDay; }
            set { kmPerDay = value; }
        }

        private double perDayOverdue;

        public double PerDayOverdue
        {
            get { return perDayOverdue; }
            set { perDayOverdue = value; }
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
        public static frmRent p_instance = null;
        public static frmRent Instance
        {
            get
            {
                if (p_instance == null)
                {
                    p_instance = new frmRent();
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
        protected frmRent()
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
                this.barPayment.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.CLICK);
                this.barDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.CLICK);
                this.barPrint.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.CLICK);
                this.barVoid.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.CLICK);
                this.repositoryItemSearchControl1.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.SEARCH_PRESSED);

                this.gridView.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.NEWROW);
                this.gridView.ShowingEditor += new System.ComponentModel.CancelEventHandler(this.SHOWINGEDITOR);
                this.gridView.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.CELLVALUECHANGED);
                this.repositoryItemLookUpEditAddDriver.EditValueChanged += new System.EventHandler(this.DRIVERCHANGED);
                this.repositoryItemLookUpEditTax.EditValueChanged += new System.EventHandler(this.TAXCHANGED);
                this.repositoryItemLookUpEditRentType.EditValueChanged += new System.EventHandler(this.RENTTYPECHANGED);
                this.buttonEditRenter.ButtonPressed += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.BUTTONPRESSEDRENTER);
                this.buttonEditDeposit.ButtonPressed += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.BUTTONPRESSEDDEPOSIT);
                this.repositoryItemLookUpEditAddDriver.ButtonPressed += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.BUTTONPRESSEDRIVER);
                this.repositoryItemLookUpEditTax.ButtonPressed += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.BUTTONPRESSEDTAX);
                this.repositoryItemButtonEditCar.ButtonPressed += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.BUTTONPRESSEDCAR);
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
                this.barPayment.ItemClick -= new DevExpress.XtraBars.ItemClickEventHandler(this.CLICK);
                this.barDelete.ItemClick -= new DevExpress.XtraBars.ItemClickEventHandler(this.CLICK);
                this.barVoid.ItemClick -= new DevExpress.XtraBars.ItemClickEventHandler(this.CLICK);
                this.barPrint.ItemClick -= new DevExpress.XtraBars.ItemClickEventHandler(this.CLICK);
                this.gridView.InitNewRow -= new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.NEWROW);
                this.gridView.ShowingEditor -= new System.ComponentModel.CancelEventHandler(this.SHOWINGEDITOR);
                this.gridView.CellValueChanged -= new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.CELLVALUECHANGED);
                this.repositoryItemLookUpEditAddDriver.EditValueChanged -= new System.EventHandler(this.DRIVERCHANGED);
                this.repositoryItemLookUpEditTax.EditValueChanged -= new System.EventHandler(this.TAXCHANGED);
                this.repositoryItemLookUpEditRentType.EditValueChanged -= new System.EventHandler(this.RENTTYPECHANGED);
                this.repositoryItemSearchControl1.ButtonClick -= new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.SEARCH_PRESSED);
                this.repositoryItemLookUpEditAddDriver.ButtonPressed -= new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.BUTTONPRESSEDRIVER);
                this.buttonEditRenter.ButtonPressed -= new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.BUTTONPRESSEDRENTER);
                this.buttonEditDeposit.ButtonPressed -= new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.BUTTONPRESSEDDEPOSIT);
                this.repositoryItemLookUpEditTax.ButtonPressed -= new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.BUTTONPRESSEDTAX);
                this.repositoryItemButtonEditCar.ButtonPressed -= new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.BUTTONPRESSEDCAR);

            }
        }
        private void Mapping()
        {
            GTSysOne.Class.Utility.clsUtility.createlookupRepository(this.repositoryItemLookUpEditRentType, GTSysOne.Class.Mapping.clsMap_RentType.ShowTable(GTSysOne.Class.Mapping.clsMap_RentType.Value(0, 0)), new string[] { "Name" }, "id", "Name");
            GTSysOne.Class.Utility.clsUtility.createlookup(this.lookUpEditStatus, GTSysOne.Class.Mapping.clsMap_RentStatus.ShowTable(GTSysOne.Class.Mapping.clsMap_RentStatus.Value(0, 0)), new string[] { "Name" }, "id", "Name");
            //GTSysOne.Class.Utility.clsUtility.createlookup(this.lookUpEditExchangeRate, GTSysOne.Class.MasterFile.clsMas_ExchangeRate.ShowTable(GTSysOne.Class.MasterFile.clsMas_ExchangeRate.Value(0, 1
            //    , string.Empty
            //    , string.Empty
            //    , false
            //    , false
            //    , GTSysOne.Class.Utility.clsGlobal.Instance().COMPANYID
            //    )), new string[] { "Name" }, "id", "Name");
            //tax
            GTSysOne.Class.Utility.clsUtility.createlookupRepository(Instance.repositoryItemLookUpEditTax, GTSysOne.Class.MasterFile.clsMas_Tax.ShowTable(GTSysOne.Class.MasterFile.clsMas_Tax.Value(0, 0
                , string.Empty
                , string.Empty
                , false
                , false
                , GTSysOne.Class.Utility.clsGlobal.Instance().COMPANYID
                )), new string[] { "Name", "Percentage" }, "id", "Percentage");

            //adddriver
            GTSysOne.Class.Utility.clsUtility.createlookupRepository(this.repositoryItemLookUpEditAddDriver, GTSysOne.Class.MasterFile.clsMas_Driver.ShowTable(GTSysOne.Class.MasterFile.clsMas_Driver.Value(0,
                0
                , string.Empty
                , string.Empty
                , false
                , false
                , GTSysOne.Class.Utility.clsGlobal.Instance().COMPANYID
                )), new string[] { "Name" }, "id", "Name");

            GTSysOne.Gui.Document.frmRent.LOADLOOKUP(GTSysOne.Class.Utility.clsGlobal.myFunction.Driver, "repositoryItemLookUpEditAddDriver");
            this.repositoryItemLookUpEditAddDriver.Buttons[1].Visible = GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_Add_Driver;

            GTSysOne.Gui.Document.frmRent.LOADLOOKUP(GTSysOne.Class.Utility.clsGlobal.myFunction.Tax, "repositoryItemLookUpEditTax");
            this.repositoryItemLookUpEditTax.Buttons[0].Visible = GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_Add_Tax;

            GTSysOne.Class.Utility.clsUtility.View(this.gridControl, this.gridView, 0
           , GTSysOne.Class.Slip.clsSlip_Rent.ShowTable(GTSysOne.Class.Slip.clsSlip_Rent.Value(0
           , 0
           , Id
           , false
           , false
           , false
           , GTSysOne.Class.Utility.clsGlobal.Instance().COMPANYID)), string.Empty, true);


            dtRecord = new System.Data.DataTable();
            dtRecord = GTSysOne.Class.Document.clsDoc_Rent.ShowTable(GTSysOne.Class.Document.clsDoc_Rent.Value(0
                , 2
                , Id
                , string.Empty
                , false
                , false
                , false
                , GTSysOne.Class.Utility.clsGlobal.Instance().COMPANYID));
            if (dtRecord.Rows.Count > 0)
            {
                this.textEditNumbering.Text = Convert.ToString(dtRecord.Rows[0]["num"]);
                isvoid = Convert.ToBoolean(dtRecord.Rows[0]["void"]);
                this.textEditIdentityNumber.Text = Convert.ToString(dtRecord.Rows[0]["identity_number"]);
                this.lookUpEditStatus.EditValue = Convert.ToInt32(dtRecord.Rows[0]["map_sourced_statusrent_id"]);
                this.dateEditDocDate.EditValue = Convert.ToDateTime(dtRecord.Rows[0]["doc_date"]);
                this.dateEditDueDate.EditValue = Convert.ToDateTime(dtRecord.Rows[0]["due_date"]);
                this.dateEditPostDate.EditValue = Convert.ToDateTime(dtRecord.Rows[0]["post_date"]);
                this.textEditTotalPay.Text = Convert.ToString(dtRecord.Rows[0]["payment"]);
                double getRemainder = Convert.ToDouble(dtRecord.Rows[0]["remainder"]);

                //retrieve customer
                string customerid = Convert.ToString(dtRecord.Rows[0]["doc_sourced_customer_id"]);
                dtRecord = new System.Data.DataTable();
                dtRecord = GTSysOne.Class.Document.clsDoc_Customer.ShowTable(GTSysOne.Class.Document.clsDoc_Customer.Value(0, 501
                    , customerid
                    , string.Empty
                    , false
                    , false
                    , false
                    , GTSysOne.Class.Utility.clsGlobal.Instance().COMPANYID));

                this.buttonEditRenter.Text = Convert.ToString(dtRecord.Rows[0]["name"]);
                this.buttonEditRenter.Tag = Convert.ToString(dtRecord.Rows[0]["id"]);
                this.txtCountry.Text = Convert.ToString(dtRecord.Rows[0]["Country"]);
                this.txtCurrency.Text = Convert.ToString(dtRecord.Rows[0]["Currency"]);
                this.txtExchangeRate.Text = Convert.ToString(dtRecord.Rows[0]["ExchangeRate"]);

                //totaldeposit
                dtRecord = new System.Data.DataTable();
                dtRecord = GTSysOne.Class.Slip.clsSlip_RentDeposit.ShowTable(GTSysOne.Class.Slip.clsSlip_RentDeposit.Value(0, 1
                    , Id
                    , false
                    , false
                    , false
                    , GTSysOne.Class.Utility.clsGlobal.Instance().COMPANYID));
                this.buttonEditDeposit.Text = Convert.ToString(dtRecord.Rows[0]["Deposit"]);

                if (getRemainder > 0)
                {
                    this.textEditChange.Text = Convert.ToString(getRemainder);
                    this.textEditGrandTotal.Text = "0.00";
                }
                else
                {
                    double getGrandTotal = Convert.ToDouble(this.textEditGrandTotal.Text);
                    double previousBalance = getGrandTotal - Convert.ToDouble(this.textEditTotalPay.Text);

                    if (previousBalance > 0)
                    {
                        this.textEditPreviousBalance.Text = Convert.ToString(previousBalance);
                        this.textEditGrandTotal.Text = this.textEditPreviousBalance.Text;
                    }
        
                }


                if (EnformStatus == GTSysOne.Gui.Document.frmRent.enFormStatus.View)
                {
                    this.Enable(false);
                }
            }

            if (EnformStatus == GTSysOne.Gui.Document.frmRent.enFormStatus.Add)
            {
                this.Enable(true);
                this.barVoid.Enabled = false;
                this.barDelete.Enabled = false;
                this.barPrint.Enabled = false;
                this.textEditNumbering.Text = GTSysOne.Class.Utility.clsUtility.Numbering(GTSysOne.Class.Utility.clsGlobal.myFunction.Rent);
                this.lookUpEditStatus.EditValue = 1;
            }
            if (this.textEditNumbering.Text.CompareTo(string.Empty) == 0)
            {
                this.textEditNumbering.Enabled = true;
            }
            else
            {
                this.textEditNumbering.Enabled = false;
            }
            if (EnformStatus == GTSysOne.Gui.Document.frmRent.enFormStatus.Edit)
            {
                if (this.textEditPreviousBalance.Text == "0.00" && this.textEditGrandTotal.Text == "0.00")
                {
                    lookUpEditStatus.EditValue = 3;
                }
                else
                {
                    lookUpEditStatus.EditValue = 2;
                }
                this.Enable(true);

                try
                {
                    DateTime gDateout = Convert.ToDateTime(this.gridView.GetRowCellDisplayText(this.gridView.FocusedRowHandle, "DateOut"));
                    this.repositoryItemDateEditExpectedReturnDate.MinValue = gDateout;
                    this.repositoryItemDateEditReturnDate.MinValue = gDateout;
                }
                catch
                {

                }
            }
            if (EnformStatus == GTSysOne.Gui.Document.frmRent.enFormStatus.View)
            {
                this.textEditNumbering.Enabled = false;
            }

        }
        private void Clear()
        {
            this.buttonEditRenter.Tag = string.Empty;
            this.buttonEditRenter.Text = string.Empty;
            this.textEditIdentityNumber.Text = string.Empty;
            this.buttonEditDeposit.Text = string.Empty;
            this.textEditTotalPay.Text = string.Empty;
            this.textEditChange.Text = string.Empty;
            this.textEditPreviousBalance.Text = string.Empty;
            this.txtRTInsurance.Text = string.Empty;
            this.textEditGrandTotal.Text = string.Empty;
            this.textEditNumbering.Text = string.Empty;
            this.txtCountry.Text = string.Empty;
            this.txtCurrency.Text = string.Empty;
            this.txtExchangeRate.Text = string.Empty;
            this.dateEditPostDate.EditValue = DBNull.Value;
            this.dateEditDueDate.EditValue = DBNull.Value;
            this.dateEditDocDate.EditValue = DBNull.Value;
            Id = string.Empty;
        }
        private void Enable(bool sw)
        {
            this.barSave.Enabled = sw;
            this.buttonEditRenter.Enabled = sw;
            this.buttonEditDeposit.Enabled = sw;
            this.gridView.OptionsBehavior.Editable = sw;
            this.textEditIdentityNumber.ReadOnly = !sw;
            this.buttonEditRenter.ReadOnly = !sw;
            this.dateEditDueDate.Enabled = sw;
            this.dateEditPostDate.Enabled = sw;
            this.txtRTInsurance.Enabled = sw;
            this.dateEditDocDate.Enabled = sw;
            this.lookUpEditStatus.Enabled = sw;
            this.txtCountry.Enabled = sw;
            this.txtCurrency.Enabled = sw;
            this.txtExchangeRate.Enabled = sw;
        }
        private void GridLayout(GTSysOne.Class.Utility.clsGlobal.GridLayout L)
        {
            GTSysOne.Class.Utility.clsUtility.Layout_Restore_Save(this.gridView, L, GTSysOne.Class.Utility.clsGlobal.Instance().GridLayoutLocation + "Document\\", this.Name.Replace("frm", ""), this.gridControl);
        }
        private void FORM_LOAD(object sender, System.EventArgs e)
        {
            this.Mapping();
            this.EventHandler();
            GTSysOne.Class.Utility.clsUtility.Language(this, typeof(GTSysOne.Gui.Document.frmRent).Assembly);
            kmPerDay = 200;
            perDayOverdue = .30;
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
                string ResultId = System.Convert.ToString(GTSysOne.Class.Document.clsDoc_Rent.ScalarValue(GTSysOne.Class.Document.clsDoc_Rent.Value(0, 3, System.Convert.ToString((sender as DevExpress.XtraEditors.ButtonEdit).Text))));
                if (ResultId.CompareTo(string.Empty) != 0)
                {
                    EnformStatus = GTSysOne.Gui.Document.frmRent.enFormStatus.Edit;
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
                    EnformStatus = GTSysOne.Gui.Document.frmRent.enFormStatus.Add;
                    Id = string.Empty;
                    this.EventHandler(false);
                    this.Clear();
                    this.Mapping();
                    this.EventHandler(true);
                    break;
                case "barSave":
                    PAY();
                    break;
                case "barPayment":
                    PAYMENTCLICK();
                    break;
                case "barDelete":
                    if (DialogResult.Yes == GTSysOne.Class.Utility.clsUtility.GTSysMessageBox(new string[] { "The rent will be deleted. " }
                        , GTSysOne.Class.Utility.clsGlobal.enMessageBoxButton.YesNo
                        , GTSysOne.Class.Utility.clsGlobal.enMessageBoxIcon.Warning
                        , "Delete Rent ?")) isvoid = true;
                    else isvoid = false;
                    break;
                case "barVoid":
                    if (!isvoid)
                    {
                        if (DialogResult.Yes == GTSysOne.Class.Utility.clsUtility.GTSysMessageBox(new string[] { "The rent will be void." }
                            , GTSysOne.Class.Utility.clsGlobal.enMessageBoxButton.YesNo
                            , GTSysOne.Class.Utility.clsGlobal.enMessageBoxIcon.Warning
                            , "Void")) isvoid = true;
                        else isvoid = false;
                    }
                    else if (isvoid)
                    {
                        if (DialogResult.Yes == GTSysOne.Class.Utility.clsUtility.GTSysMessageBox(new string[] { "The rent is void. Activate it again?" }
                           , GTSysOne.Class.Utility.clsGlobal.enMessageBoxButton.YesNo
                           , GTSysOne.Class.Utility.clsGlobal.enMessageBoxIcon.Warning
                           , "Activate")) isvoid = false;
                        else isvoid = true;
                    }
                  
                    break;
                case "barPrint":
                    print = true;
                    PRINT();
                    break;
                case "barFirst":
                    ResultId = GTSysOne.Class.Utility.clsUtility.Navigator(Id, "2", GTSysOne.Class.Utility.clsGlobal.myFunction.Rent);
                    if (ResultId.CompareTo(string.Empty) != 0)
                    {
                        if (EnformStatus != GTSysOne.Gui.Document.frmRent.enFormStatus.View)
                        {
                            EnformStatus = GTSysOne.Gui.Document.frmRent.enFormStatus.Edit;
                        }
                        Id = ResultId;
                        this.EventHandler(false);
                        this.Mapping();
                        this.EventHandler(true);
                    }
                    break;
                case "barPrevious":
                    ResultId = GTSysOne.Class.Utility.clsUtility.Navigator(Id, "0", GTSysOne.Class.Utility.clsGlobal.myFunction.Rent);
                    if (ResultId.CompareTo(string.Empty) != 0)
                    {
                        if (EnformStatus != GTSysOne.Gui.Document.frmRent.enFormStatus.View)
                        {
                            EnformStatus = GTSysOne.Gui.Document.frmRent.enFormStatus.Edit;
                        }
                        Id = ResultId;
                        this.EventHandler(false);
                        this.Mapping();
                        this.EventHandler(true);
                    }
                    break;
                case "barNext":
                    ResultId = GTSysOne.Class.Utility.clsUtility.Navigator(Id, "1", GTSysOne.Class.Utility.clsGlobal.myFunction.Rent);
                    if (ResultId.CompareTo(string.Empty) != 0)
                    {
                        if (EnformStatus != GTSysOne.Gui.Document.frmRent.enFormStatus.View)
                        {
                            EnformStatus = GTSysOne.Gui.Document.frmRent.enFormStatus.Edit;
                        }
                        Id = ResultId;
                        this.EventHandler(false);
                        this.Mapping();
                        this.EventHandler(true);
                    }
                    break;
                case "barLast":
                    ResultId = GTSysOne.Class.Utility.clsUtility.Navigator(Id, "3", GTSysOne.Class.Utility.clsGlobal.myFunction.Rent);
                    if (ResultId.CompareTo(string.Empty) != 0)
                    {
                        if (EnformStatus != GTSysOne.Gui.Document.frmRent.enFormStatus.View)
                        {
                            EnformStatus = GTSysOne.Gui.Document.frmRent.enFormStatus.Edit;
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
        private void PAYMENTCLICK()
        {

            GTSysOne.Class.Utility.clsGlobal.Instance().Err.ClearErrors();
            GTSysOne.Class.Utility.clsGlobal.Instance().No_Error_Result = true;
            GTSysOne.Class.Utility.clsUtility.ValidateControl(this.textEditIdentityNumber);
            GTSysOne.Class.Utility.clsUtility.ValidateControl(this.buttonEditRenter);
            GTSysOne.Class.Utility.clsUtility.ValidateControl(this.lookUpEditStatus);
            GTSysOne.Class.Utility.clsUtility.ValidateControl(this.dateEditDocDate);
            GTSysOne.Class.Utility.clsUtility.ValidateControl(this.dateEditPostDate);
            GTSysOne.Class.Utility.clsUtility.ValidateControl(this.dateEditDueDate);

            if (this.gridView.DataRowCount == 0)
            {
                GTSysOne.Class.Utility.clsUtility.GTSysMessageBox(new string[] { "No car on the list." }
                            , GTSysOne.Class.Utility.clsGlobal.enMessageBoxButton.OK
                            , GTSysOne.Class.Utility.clsGlobal.enMessageBoxIcon.Warning
                            , "No Data");
            }

            if (Convert.ToDouble(this.textEditGrandTotal.Text) > 0 && GTSysOne.Class.Utility.clsGlobal.Instance().No_Error_Result)
            {
                using (var form = new GTSysOne.Gui.Slip.frmRentPayment())
                {
                    if (EnformStatus == GTSysOne.Gui.Document.frmRent.enFormStatus.View) form.IsView = true;

                    form.GrandTotal = Convert.ToDouble(this.textEditGrandTotal.Text);
                    form.Id = Id;
                    form.ShowDialog(this);

                    if (form.IsOk)
                    {
                        dtRecordPayment = form.dt;
                        remainder += form.Remainder;
                        payment = form.Payment;
                        print = form.Print;
                        PAY();

                    }
                }
            }
        }

        private void PAY()
        {
            GTSysOne.Class.Utility.clsGlobal.Instance().Err.ClearErrors();
            GTSysOne.Class.Utility.clsGlobal.Instance().No_Error_Result = true;
            GTSysOne.Class.Utility.clsUtility.ValidateControl(this.textEditIdentityNumber);
            GTSysOne.Class.Utility.clsUtility.ValidateControl(this.buttonEditRenter);
            GTSysOne.Class.Utility.clsUtility.ValidateControl(this.lookUpEditStatus);
            GTSysOne.Class.Utility.clsUtility.ValidateControl(this.dateEditDocDate);
            GTSysOne.Class.Utility.clsUtility.ValidateControl(this.dateEditPostDate);
            GTSysOne.Class.Utility.clsUtility.ValidateControl(this.dateEditDueDate);
            if (this.gridView.DataRowCount == 0)
            {
                GTSysOne.Class.Utility.clsUtility.GTSysMessageBox(new string[] { "No car on the list." }
                            , GTSysOne.Class.Utility.clsGlobal.enMessageBoxButton.OK
                            , GTSysOne.Class.Utility.clsGlobal.enMessageBoxIcon.Warning
                            , "No Data");
            }

            if (GTSysOne.Class.Utility.clsGlobal.Instance().No_Error_Result && this.gridView.DataRowCount > 0)
            {
                Id = GTSysOne.Class.Document.clsDoc_Rent.Save(GTSysOne.Class.Document.clsDoc_Rent.Value(
                    (EnformStatus == GTSysOne.Gui.Document.frmRent.enFormStatus.Add ? 1 : 2)
                    , 0
                    , Id
                    , this.textEditNumbering.Text
                    , isdelete
                    , isvoid
                    , false
                    , GTSysOne.Class.Utility.clsGlobal.Instance().COMPANYID
                    , GTSysOne.Class.Utility.clsGlobal.Instance().ESTABLISHMENTID
                    , GTSysOne.Class.Utility.clsGlobal.Instance().STATIONID
                    , System.Convert.ToString((int)GTSysOne.Class.Utility.clsGlobal.myFunction.Rent)
                    , GTSysOne.Class.Utility.clsGlobal.Instance().UserId
                    , System.Convert.ToString(GTSysOne.Class.Utility.clsUtility.SERVERDATE())
                    , Convert.ToString(this.dateEditPostDate.EditValue)
                    , Convert.ToString(this.dateEditDueDate.EditValue)
                    , Convert.ToString(this.dateEditDocDate.EditValue)
                    , Convert.ToString(this.buttonEditRenter.Tag)
                    , Convert.ToString(this.textEditIdentityNumber.Text)
                    , Convert.ToString(payment)
                    , Convert.ToString(remainder)
                    , Convert.ToString(this.lookUpEditStatus.EditValue)
                    , "0"
                    ));

                for (int ctr = 0; ctr < this.gridView.DataRowCount; ctr++)
                {
                    System.Data.DataRow row = this.gridView.GetDataRow(ctr);
                    string slipId = GTSysOne.Class.Slip.clsSlip_Rent.Save(
                        GTSysOne.Class.Slip.clsSlip_Rent.Value((
                        System.Convert.ToString(row["id"]).IndexOf("NEWID()") > -1 ? 1 : 2)
                        , 0
                        , System.Convert.ToString(row["id"])
                        , (System.Convert.ToBoolean(row["deleted"]) ? true : false)
                        , (System.Convert.ToBoolean(row["void"]) ? true : false)
                        , false
                        , GTSysOne.Class.Utility.clsGlobal.Instance().COMPANYID
                        , GTSysOne.Class.Utility.clsGlobal.Instance().ESTABLISHMENTID
                        , GTSysOne.Class.Utility.clsGlobal.Instance().STATIONID
                        , System.Convert.ToString((int)GTSysOne.Class.Utility.clsGlobal.myFunction.Rent)
                        , GTSysOne.Class.Utility.clsGlobal.Instance().UserId
                        , System.Convert.ToString(GTSysOne.Class.Utility.clsUtility.SERVERDATE())
                        , Id
                        , System.Convert.ToString(row["RTId"])
                        , System.Convert.ToString(row["CId"])
                        , System.Convert.ToString(row["DId"])
                        , System.Convert.ToString(row["DateOut"])
                        , System.Convert.ToString(row["TimeOut"])
                        , System.Convert.ToString(row["ExpectedReturnDate"])
                        , System.Convert.ToString(row["DateReturn"])
                        , System.Convert.ToString(row["NoOfDays"])
                        , System.Convert.ToString(row["DailyRate"])
                        , System.Convert.ToString(row["KMFrom"])
                        , System.Convert.ToString(row["KMTo"])
                        , System.Convert.ToString(row["CDW"])
                        , System.Convert.ToString(row["Dell/Col/Charge"])
                        , System.Convert.ToString(row["Total"])
                        , System.Convert.ToString(row["TId"])
                        , System.Convert.ToString(row["Discount"])
                        , System.Convert.ToString(row["NetTotal"])
                        , "0"));
                }

                if (dtRecordPayment != null)
                {
                    foreach (DataRow row in dtRecordPayment.Rows)
                    {
                        GTSysOne.Class.Slip.clsSlip_RentPayment.Save(
                        GTSysOne.Class.Slip.clsSlip_RentPayment.Value((
                        System.Convert.ToString(row["id"]).IndexOf("NEWID()") > -1 ? 1 : 2)
                        , 0
                        , System.Convert.ToString(row["id"])
                        , false
                        , false
                        , false
                        , GTSysOne.Class.Utility.clsGlobal.Instance().COMPANYID
                        , GTSysOne.Class.Utility.clsGlobal.Instance().ESTABLISHMENTID
                        , GTSysOne.Class.Utility.clsGlobal.Instance().STATIONID
                        , System.Convert.ToString((int)GTSysOne.Class.Utility.clsGlobal.myFunction.Rent)
                        , GTSysOne.Class.Utility.clsGlobal.Instance().UserId
                        , System.Convert.ToString(GTSysOne.Class.Utility.clsUtility.SERVERDATE())
                        , Id
                        , System.Convert.ToString(row["CCId"])
                        , System.Convert.ToString(row["PaymentMode"])
                        , System.Convert.ToString(row["Amount"])
                        , System.Convert.ToString(row["DepositDate"])
                        , "0"
                        ));
                    }
                }

                if (dtRecordDeposit != null)
                {
                    foreach (DataRow row in dtRecordDeposit.Rows)
                    {
                        GTSysOne.Class.Slip.clsSlip_RentDeposit.Save(
                        GTSysOne.Class.Slip.clsSlip_RentDeposit.Value((
                        System.Convert.ToString(row["id"]).IndexOf("NEWID()") > -1 ? 1 : 2)
                        , 0
                        , System.Convert.ToString(row["id"])
                        , false
                        , false
                        , false
                        , GTSysOne.Class.Utility.clsGlobal.Instance().COMPANYID
                        , GTSysOne.Class.Utility.clsGlobal.Instance().ESTABLISHMENTID
                        , GTSysOne.Class.Utility.clsGlobal.Instance().STATIONID
                        , System.Convert.ToString((int)GTSysOne.Class.Utility.clsGlobal.myFunction.Rent)
                        , GTSysOne.Class.Utility.clsGlobal.Instance().UserId
                        , System.Convert.ToString(GTSysOne.Class.Utility.clsUtility.SERVERDATE())
                        , Id
                        , System.Convert.ToString(row["Deposit"])
                        , "0"
                        ));
                    }
                }

                PRINT();
           
                if (EnformStatus == GTSysOne.Gui.Document.frmRent.enFormStatus.Add)
                {

                    GTSysOne.Class.Utility.clsUtility.GTSysMessageBox(new string[] { "Car Rent Added" }
                        , GTSysOne.Class.Utility.clsGlobal.enMessageBoxButton.OK
                        , GTSysOne.Class.Utility.clsGlobal.enMessageBoxIcon.Information
                        , "Success");

                    this.Enable(false);
                }

                if (EnformStatus == GTSysOne.Gui.Document.frmRent.enFormStatus.Edit)
                {

                    GTSysOne.Class.Utility.clsUtility.GTSysMessageBox(new string[] { "Car Rent Updated" }
                        , GTSysOne.Class.Utility.clsGlobal.enMessageBoxButton.OK
                        , GTSysOne.Class.Utility.clsGlobal.enMessageBoxIcon.Information
                        , "Success");
                }

                GTSysOne.Gui.Dashboard.Document.frmRent.CallFromMain("Refresh", Id, false, 1, Id);

            }
        }
        private void PRINT()
        {
            if (print)
            {
                dtRecord = new System.Data.DataTable();
                dtRecord = GTSysOne.Class.Slip.clsSlip_Rent.ShowTable(GTSysOne.Class.Slip.clsSlip_Rent.Value(0, 1, Id));
                if (dtRecord.Rows.Count > 0)
                {
                    for (int ctr = 0; ctr < this.dtRecord.Rows.Count; ++ctr)
                    {
                        slip_id = Convert.ToString(dtRecord.Rows[ctr]["id"]);

                        GTSysOne.Class.Utility.clsUtility.PRINT(GTSysOne.Class.Utility.clsGlobal.myFunction.Rent
                          , "xrptRent"
                          , GTSysOne.Class.Document.clsDoc_Rent.ShowDataSet(
                              GTSysOne.Class.Document.clsDoc_Rent.Value(0, 4, Id
                                      , string.Empty
                                      , false
                                      , false
                                      , false
                                      , GTSysOne.Class.Utility.clsGlobal.Instance().COMPANYID
                                      , GTSysOne.Class.Utility.clsGlobal.Instance().ESTABLISHMENTID
                                      , GTSysOne.Class.Utility.clsGlobal.Instance().STATIONID
                                      , System.Convert.ToString((int)GTSysOne.Class.Utility.clsGlobal.myFunction.Rent)
                                      , GTSysOne.Class.Utility.clsGlobal.Instance().UserId
                                      , string.Empty
                                      , string.Empty
                                      , string.Empty
                                      , string.Empty
                                      , slip_id))
                          , new string[,] { { "DATASET", "" } }
                          , new string[,] { { "Description", "Rent And Its Details" }, { "ReportTitle", "Rent" } }
                          , new string[] { "" }
                          );
                    }
                }
            }
        }
        public static void LOADLOOKUP(GTSysOne.Class.Utility.clsGlobal.myFunction F, string LookUpName, bool s = false, string e = "")
        {
            switch (F)
            {
                case GTSysOne.Class.Utility.clsGlobal.myFunction.Driver:
                    GTSysOne.Class.Utility.clsUtility.createlookupRepository(Instance.repositoryItemLookUpEditAddDriver
                        , GTSysOne.Class.MasterFile.clsMas_Driver.ShowTable(GTSysOne.Class.MasterFile.clsMas_Driver.Value(0, 0
                        , string.Empty
                        , string.Empty
                        , false
                        , false
                        , GTSysOne.Class.Utility.clsGlobal.Instance().COMPANYID
                        )), new string[] { "Name" }, "id", "Name");
                    break;
                case GTSysOne.Class.Utility.clsGlobal.myFunction.Tax:
                    GTSysOne.Class.Utility.clsUtility.createlookupRepository(Instance.repositoryItemLookUpEditTax
                        , GTSysOne.Class.MasterFile.clsMas_Tax.ShowTable(GTSysOne.Class.MasterFile.clsMas_Tax.Value(0, 0
                        , string.Empty
                        , string.Empty
                        , false
                        , false
                        , GTSysOne.Class.Utility.clsGlobal.Instance().COMPANYID
                        )), new string[] { "Name", "Percentage" }, "id", "Percentage");
                    break;

            }
        }
        private void NEWROW(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            this.gridView.SetRowCellValue(e.RowHandle, "id", "NEWID()" + System.Guid.NewGuid().ToString());
            this.gridView.SetRowCellValue(e.RowHandle, "void", false);
            this.gridView.SetRowCellValue(e.RowHandle, "deleted", false);

            this.gridView.SetRowCellValue(this.gridView.FocusedRowHandle, "DateOut", System.Convert.ToDateTime(GTSysOne.Class.Utility.clsUtility.SERVERDATE()));
            this.gridView.SetRowCellValue(this.gridView.FocusedRowHandle, "TimeOut", System.Convert.ToDateTime(GTSysOne.Class.Utility.clsUtility.SERVERDATE()));

            DateTime gDateout = Convert.ToDateTime(this.gridView.GetRowCellDisplayText(this.gridView.FocusedRowHandle, "DateOut"));

            this.repositoryItemDateEditExpectedReturnDate.MinValue = gDateout;
            this.repositoryItemDateEditReturnDate.MinValue = gDateout;
            noOfDays = 0;
            totalCalculatedDailyrate = 0;
            kmTaked = 0;
            cdw = 0;
            dellcolcharge = 0;
            total = 0;
            tax = 0;
            discount = 0;
            nettotal = 0;
            grandTotal = 0;

        }
        private void DRIVERCHANGED(object sender, System.EventArgs e)
        {
            this.gridView.SetRowCellValue(this.gridView.FocusedRowHandle, "DId", (sender as DevExpress.XtraEditors.BaseEdit).EditValue);
            // GTSysOne.Class.Utility.clsUtility.FocusLastNewRow(this.gridView, this.gridControl, "AddDriver");
        }
        private void TAXCHANGED(object sender, System.EventArgs e)
        {
            this.gridView.SetRowCellValue(this.gridView.FocusedRowHandle, "TId", (sender as DevExpress.XtraEditors.BaseEdit).EditValue);
            //   GTSysOne.Class.Utility.clsUtility.FocusLastNewRow(this.gridView, this.gridControl, "Tax");
        }
        private void RENTTYPECHANGED(object sender, System.EventArgs e)
        {
            this.gridView.SetRowCellValue(this.gridView.FocusedRowHandle, "RTId", (sender as DevExpress.XtraEditors.BaseEdit).EditValue);
            //this.repositoryItemDateEditReturnDate.MinValue = System.Convert.ToDateTime(GTSysOne.Class.Utility.clsUtility.SERVERDATE());
        }

        private void BUTTONPRESSEDRENTER(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            DevExpress.XtraEditors.ButtonEdit editor = sender as DevExpress.XtraEditors.ButtonEdit;
            DevExpress.XtraEditors.Controls.EditorButton Button = e.Button;

            if (editor.Properties.Buttons.IndexOf(e.Button) == 0)
            {
                using (var C = new GTSysOne.Gui.Slip.frmCustomerBrowser())
                {
                    C.ShowDialog(this);
                    if (C.OK)
                    {
                        this.buttonEditRenter.Tag = C.selectedRow["id"];
                        this.buttonEditRenter.Text = C.selectedRow["Name"].ToString();
                        this.txtCountry.Text = C.selectedRow["Country"].ToString();
                        this.txtCurrency.Text = C.selectedRow["Currency"].ToString();
                        this.txtExchangeRate.Text = C.selectedRow["ExchangeRate"].ToString();
                        C.Dispose();
                    }
                    else
                    {
                        C.Dispose();
                    }
                }
            }
        }

        private void BUTTONPRESSEDCAR(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            DevExpress.XtraEditors.ButtonEdit editor = sender as DevExpress.XtraEditors.ButtonEdit;
            DevExpress.XtraEditors.Controls.EditorButton Button = e.Button;

            if (editor.Properties.Buttons.IndexOf(e.Button) == 0)
            {

                using (var C = new GTSysOne.Gui.Slip.frmCarBrowser())
                {
                    C.ShowDialog(this);
                    if (C.OK)
                    {
                        try
                        {
                            this.gridView.SetRowCellValue(this.gridView.FocusedRowHandle, "CId", Convert.ToString(C.selectedRow["id"]));
                            this.gridView.SetRowCellValue(this.gridView.FocusedRowHandle, "Car", Convert.ToString(C.selectedRow["Name"]));
                            C.Dispose();
                        }
                        catch
                        {

                        }
                    }
                    else
                    {
                        C.Dispose();
                    }
                }
            }
        }

        private void BUTTONPRESSEDDEPOSIT(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            DevExpress.XtraEditors.ButtonEdit editor = sender as DevExpress.XtraEditors.ButtonEdit;
            DevExpress.XtraEditors.Controls.EditorButton Button = e.Button;

            if (editor.Properties.Buttons.IndexOf(e.Button) == 0)
            {
                using (var C = new GTSysOne.Gui.Slip.frmRentSlipDeposit())
                {
                    C.Id = Id;
                    C.ShowDialog(this);

                    if (C.OK)
                    {
                        double gctotal = Convert.ToDouble(this.textEditGrandTotal.Text);
                        if ((gctotal != 0 && C.TotalDeposit1 > gctotal))
                        {
                            GTSysOne.Class.Utility.clsUtility.GTSysMessageBox(new string[] { "Deposit is greater than grand total." }
                           , GTSysOne.Class.Utility.clsGlobal.enMessageBoxButton.OK
                           , GTSysOne.Class.Utility.clsGlobal.enMessageBoxIcon.Warning
                           , "Try Again");
                        }
                        else
                        {
                            this.dtRecordDeposit = C.dt;

                            if (EnformStatus == GTSysOne.Gui.Document.frmRent.enFormStatus.Add)
                            {
                                this.buttonEditDeposit.Text = Convert.ToString(C.TotalDeposit1);
                            }

                            if (EnformStatus == GTSysOne.Gui.Document.frmRent.enFormStatus.Edit)
                            {
                                currentDeposit = Convert.ToDouble(this.buttonEditDeposit.Text);
                                this.buttonEditDeposit.Text = Convert.ToString(currentDeposit + C.TotalDeposit1);
                            }
                        }

                        C.Dispose();
                    }
                    else
                    {
                        C.Dispose();
                    }
                }
            }
        }

        private void BUTTONPRESSEDRIVER(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            DevExpress.XtraEditors.ButtonEdit editor = sender as DevExpress.XtraEditors.ButtonEdit;
            DevExpress.XtraEditors.Controls.EditorButton Button = e.Button;

            if (editor.Properties.Buttons.IndexOf(e.Button) == 1)
            {
                GTSysOne.Gui.MasterFile.frmDriver.Instance.UseDashboard = false;
                GTSysOne.Gui.MasterFile.frmDriver.Instance.EnformFunction = GTSysOne.Gui.MasterFile.frmDriver.enFormFunction.Driver;
                GTSysOne.Gui.MasterFile.frmDriver.Instance.EnformStatus = GTSysOne.Gui.MasterFile.frmDriver.enFormStatus.Add;
                GTSysOne.Gui.MasterFile.frmDriver.Instance.Show();
            }
        }
        private void BUTTONPRESSEDTAX(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            DevExpress.XtraEditors.ButtonEdit editor = sender as DevExpress.XtraEditors.ButtonEdit;
            DevExpress.XtraEditors.Controls.EditorButton Button = e.Button;

            if (editor.Properties.Buttons.IndexOf(e.Button) == 0)
            {
                GTSysOne.Gui.MasterFile.frmTax.Instance.UseDashboard = false;
                GTSysOne.Gui.MasterFile.frmTax.Instance.EnformFunction = GTSysOne.Gui.MasterFile.frmTax.enFormFunction.Tax;
                GTSysOne.Gui.MasterFile.frmTax.Instance.EnformStatus = GTSysOne.Gui.MasterFile.frmTax.enFormStatus.Add;
                GTSysOne.Gui.MasterFile.frmTax.Instance.Show();
            }

        }


        private void SHOWINGEDITOR(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (this.gridView.FocusedColumn.FieldName == "KMFrom" && (System.Convert.ToString(this.gridView.GetRowCellValue(this.gridView.FocusedRowHandle, "RTId")) == "1"))
            {
                e.Cancel = true;
            }
            if (this.gridView.FocusedColumn.FieldName == "KMTo"
                && (System.Convert.ToString(this.gridView.GetRowCellValue(this.gridView.FocusedRowHandle, "RTId")) == "1"))
            {
                e.Cancel = true;
            }
            //if (this.gridView.FocusedColumn.FieldName == "DailyRate"
            //   && (System.Convert.ToString(this.gridView.GetRowCellValue(this.gridView.FocusedRowHandle, "RTId")) == "2"))
            //{
            //    e.Cancel = true;
            //}
        }
        private void CELLVALUECHANGED(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (this.gridView.FocusedColumn.FieldName == "void" && changing == false)
            {
                changing = true;
                if (Convert.ToBoolean(this.gridView.GetRowCellValue(this.gridView.FocusedRowHandle, "Void")) == false)
                {
                    this.gridView.SetRowCellValue(this.gridView.FocusedRowHandle, "Void", false);
                }
                if (Convert.ToBoolean(this.gridView.GetRowCellValue(this.gridView.FocusedRowHandle, "Void")) == true)
                {
                    this.gridView.SetRowCellValue(this.gridView.FocusedRowHandle, "Void", true);
                }

                changing = false;
            }

            if (this.gridView.FocusedColumn.FieldName == "NoOfDays" && changing == false)
            {
                changing = true;

                if (!(this.gridView.GetRowCellValue(this.gridView.FocusedRowHandle, "NoOfDays") is DBNull))
                {

                    if (Convert.ToString(this.gridView.GetRowCellDisplayText(this.gridView.FocusedRowHandle, "NoOfDays")).Length > 0)
                    {
                        noOfDays = Convert.ToDouble(this.gridView.GetRowCellDisplayText(this.gridView.FocusedRowHandle, "NoOfDays"));
                        DateTime dtOut = Convert.ToDateTime(this.gridView.GetRowCellDisplayText(this.gridView.FocusedRowHandle, "DateOut"));
                        dtOut = dtOut.AddDays(noOfDays);
                        this.gridView.SetRowCellValue(this.gridView.FocusedRowHandle, "DateReturn", System.Convert.ToDateTime(dtOut));

                    }

                    changing = false;
                }
            }

            if ((this.gridView.FocusedColumn.FieldName == "DateOut" ||
                this.gridView.FocusedColumn.FieldName == "DateReturn" ||
                this.gridView.FocusedColumn.FieldName == "DailyRate" ||
                this.gridView.FocusedColumn.FieldName == "CDW" ||
                this.gridView.FocusedColumn.FieldName == "KMFrom" ||
                this.gridView.FocusedColumn.FieldName == "KMTo" ||
                this.gridView.FocusedColumn.FieldName == "Dell/Col/Charge" ||
                this.gridView.FocusedColumn.FieldName == "Tax" ||
                this.gridView.FocusedColumn.FieldName == "Discount")
                && changing == false)
            {
                changing = true;

                if (!(this.gridView.GetRowCellValue(this.gridView.FocusedRowHandle, "DateOut") is DBNull) ||
                   !(this.gridView.GetRowCellValue(this.gridView.FocusedRowHandle, "DateReturn") is DBNull))
                {
                    if (Convert.ToString(this.gridView.GetRowCellDisplayText(this.gridView.FocusedRowHandle, "DateOut")).Length > 0)
                    {
                        dateOut = Convert.ToDateTime(this.gridView.GetRowCellDisplayText(this.gridView.FocusedRowHandle, "DateOut"));
                        this.repositoryItemDateEditExpectedReturnDate.MinValue = dateOut;
                        this.repositoryItemDateEditReturnDate.MinValue = dateOut;
                    }
                    if (Convert.ToString(this.gridView.GetRowCellDisplayText(this.gridView.FocusedRowHandle, "DateReturn")).Length > 0)
                    {
                        dateReturn = Convert.ToDateTime(this.gridView.GetRowCellDisplayText(this.gridView.FocusedRowHandle, "DateReturn"));
                        noOfDays = Convert.ToDouble(dateReturn.Subtract(dateOut).Days);
                        this.gridView.SetRowCellValue(this.gridView.FocusedRowHandle, "NoOfDays", Convert.ToString(noOfDays));
                    }
                }

                if (!(this.gridView.GetRowCellValue(this.gridView.FocusedRowHandle, "DailyRate") is DBNull))
                {
                    if (Convert.ToString(this.gridView.GetRowCellDisplayText(this.gridView.FocusedRowHandle, "DailyRate")).Length > 0)
                    {
                        dailyRate = Convert.ToDouble(this.gridView.GetRowCellDisplayText(this.gridView.FocusedRowHandle, "DailyRate"));
                    }

                    totalCalculatedDailyrate = noOfDays * dailyRate;
                }

                if (!(this.gridView.GetRowCellValue(this.gridView.FocusedRowHandle, "KMFrom") is DBNull) &&
                    !(this.gridView.GetRowCellValue(this.gridView.FocusedRowHandle, "KMTo") is DBNull))
                {
                    if (!(System.Convert.ToString(this.gridView.GetRowCellValue(this.gridView.FocusedRowHandle, "RTId")) == "1"))
                    {
                        if (Convert.ToString(this.gridView.GetRowCellDisplayText(this.gridView.FocusedRowHandle, "KMFrom")).Length > 0)
                        {
                            kmFrom = Convert.ToDouble(this.gridView.GetRowCellDisplayText(this.gridView.FocusedRowHandle, "KMFrom"));
                        }
                        if (Convert.ToString(this.gridView.GetRowCellDisplayText(this.gridView.FocusedRowHandle, "KMTo")).Length > 0)
                        {
                            kmTo = Convert.ToDouble(this.gridView.GetRowCellDisplayText(this.gridView.FocusedRowHandle, "KMTo"));
                        }

                    }
                }

                if (!(this.gridView.GetRowCellValue(this.gridView.FocusedRowHandle, "Dell/Col/Charge") is DBNull))
                {
                    if (Convert.ToString(this.gridView.GetRowCellDisplayText(this.gridView.FocusedRowHandle, "Dell/Col/Charge")).Length > 0)
                    {
                        dellcolcharge = Convert.ToDouble(this.gridView.GetRowCellDisplayText(this.gridView.FocusedRowHandle, "Dell/Col/Charge"));
                    }
                }

                if (!(this.gridView.GetRowCellValue(this.gridView.FocusedRowHandle, "Discount") is DBNull))
                {
                    if (Convert.ToString(this.gridView.GetRowCellDisplayText(this.gridView.FocusedRowHandle, "Discount")).Length > 0)
                    {
                        discount = Convert.ToDouble(this.gridView.GetRowCellDisplayText(this.gridView.FocusedRowHandle, "Discount"));
                    }
                }
                if (!(this.gridView.GetRowCellValue(this.gridView.FocusedRowHandle, "Tax") is DBNull))
                {
                    if (Convert.ToString(this.gridView.GetRowCellDisplayText(this.gridView.FocusedRowHandle, "Tax")).Length > 0)
                    {
                        tax = Convert.ToDouble(this.gridView.GetRowCellDisplayText(this.gridView.FocusedRowHandle, "Tax"));
                    }

                }

                kmTaked = kmTo - kmFrom;
                double calculatedTotalKMPerDay = noOfDays * Kmperday;

                if (kmTaked > calculatedTotalKMPerDay)
                {
                    double kmCharged = kmTaked - calculatedTotalKMPerDay;
                    totalCalculatedDailyrate += kmCharged * PerDayOverdue;
                }
                if (dellcolcharge > 0)
                {
                    totalCalculatedDailyrate = totalCalculatedDailyrate + dellcolcharge;
                }
            
                total = totalCalculatedDailyrate;
                
                this.gridView.SetRowCellValue(this.gridView.FocusedRowHandle, "Total", total);

                nettotal = (total - (total * tax / 100)) - discount;
                this.gridView.SetRowCellValue(this.gridView.FocusedRowHandle, "NetTotal", nettotal);

                CheckChanged();
                changing = false;
            }
        }

        private void gridView_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            GridView currentView = sender as GridView;
            if (e.Column.FieldName == "KMFrom")
            {
                string value = Convert.ToString(currentView.GetRowCellValue(e.RowHandle, "RTId"));
                if (value == "1")
                    e.Appearance.BackColor = Color.Gray;
            }
            if (e.Column.FieldName == "KMTo")
            {
                string value = Convert.ToString(currentView.GetRowCellValue(e.RowHandle, "RTId"));
                if (value == "1")
                    e.Appearance.BackColor = Color.Gray;
            }
            //if (e.Column.FieldName == "DailyRate")
            //{
            //    string value = Convert.ToString(currentView.GetRowCellValue(e.RowHandle, "RTId"));
            //    if (value == "2")
            //        e.Appearance.BackColor = Color.Gray;
            //}
        }

        private void gridView_RowCountChanged(object sender, EventArgs e)
        {
            CheckChanged();
        }
        private void CheckChanged()
        {
            cdw = 0;
            for (int i = 0; i < this.gridView.DataRowCount; i++)
            {
                if (!(gridView.GetRowCellValue(i, "CDW") is DBNull))
                {
                    cdw += Convert.ToDouble(this.gridView.GetRowCellDisplayText(i, "CDW"));
                }
            }
            this.txtRTInsurance.Text = Convert.ToString(cdw);

            if (!(this.gridView.GetRowCellValue(this.gridView.FocusedRowHandle, "NetTotal") is DBNull))
            {
                grandTotal = 0;
                if (this.gridView.DataRowCount > 0)
                {
                    if (Convert.ToBoolean(this.gridView.GetRowCellValue(this.gridView.FocusedRowHandle, "void")) == false)
                    {
                        for (int i = 0; i < this.gridView.DataRowCount; i++)
                        {
                            if (!(gridView.GetRowCellValue(i, "NetTotal") is DBNull))
                            {
                                grandTotal += Convert.ToDouble(this.gridView.GetRowCellDisplayText(i, "NetTotal"));
                            }
                        }
                        this.textEditGrandTotal.Text = Convert.ToString(grandTotal);
                    }
                }
                if (EnformStatus == GTSysOne.Gui.Document.frmRent.enFormStatus.Edit)
                {
                    double tpay = Convert.ToDouble(textEditTotalPay.Text);
                    double tdeposit = Convert.ToDouble(buttonEditDeposit.Text);
                    double gtotal = Convert.ToDouble(textEditGrandTotal.Text);
                    double change = Convert.ToDouble(textEditChange.Text);
                    //do this

                    if (tpay > gtotal)
                    {
                        double prechange = tpay - gtotal;

                        this.textEditChange.Text = Convert.ToString(prechange);
                        this.textEditGrandTotal.Text = "0.00";
                    }
                    if (gtotal > tdeposit)
                    {
                        double preptotal = gtotal - (tdeposit + tpay);

                        if (preptotal > 0)
                        {
                            this.textEditGrandTotal.Text = Convert.ToString(preptotal);
                            this.textEditChange.Text = "0.00";
                        }
                    }
                    if (tdeposit > gtotal)
                    {
                        this.textEditChange.Text = Convert.ToString((tdeposit + tpay) - gtotal);
                        this.textEditGrandTotal.Text = "0.00";
                    }

                }

                //if (tdeposit > 0 && gtotal > 0)
                //{
                //    if (tdeposit > gtotal)
                //    {
                //        double tchange = Convert.ToDouble(tdeposit - gtotal);
                //        double prechange = Convert.ToDouble(this.textEditChange.Text);
                //        this.textEditChange.Text = Convert.ToString(tchange + prechange);
                //        remainder = Convert.ToDouble(this.textEditChange.Text);
                //        this.textEditGrandTotal.Text = "0.00";
                //    }
                //}

                if (gridView.DataRowCount == 0)
                {
                    this.textEditGrandTotal.Text = "0.00";
                }
            }
        }

        private void buttonEditDeposit_EditValueChanged(object sender, EventArgs e)
        {
            if (EnformStatus == GTSysOne.Gui.Document.frmRent.enFormStatus.Edit)
            {
                if (Convert.ToDouble(this.textEditGrandTotal.Text) > 0 && Convert.ToDouble(this.buttonEditDeposit.Text) > 0)
                {
                    double deposit = Convert.ToDouble(this.buttonEditDeposit.Text);
                    double gtotal = Convert.ToDouble(this.textEditGrandTotal.Text);
                    double gchange = Convert.ToDouble(this.textEditChange.Text);

                    if (gtotal > deposit)
                        this.textEditGrandTotal.Text = Convert.ToString(gtotal - deposit);
                    this.textEditChange.Text = "0.00";

                    if (deposit > gtotal)
                    {
                        this.textEditChange.Text = Convert.ToString(gchange + (deposit - gtotal));
                        this.textEditGrandTotal.Text = "0.00";
                    }
                }

            }

            if (EnformStatus == GTSysOne.Gui.Document.frmRent.enFormStatus.Add)
            {
                if (Convert.ToDouble(this.textEditGrandTotal.Text) > 0 && Convert.ToDouble(this.buttonEditDeposit.Text) > 0)
                {
                    double deposit = Convert.ToDouble(buttonEditDeposit.Text);
                    this.textEditGrandTotal.Text = Convert.ToString(grandTotal - deposit);
                }
            }
        }
    }
}