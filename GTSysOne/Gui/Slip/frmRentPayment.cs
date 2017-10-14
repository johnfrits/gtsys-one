using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraGrid.Columns;

namespace GTSysOne.Gui.Slip
{
    public partial class frmRentPayment : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public DataTable dt = new DataTable();
        double totalAmount = 0;
        bool post = false;
        bool changing = false;
        bool print = false;
        private bool isOk;
        private double grandTotal;
        private string id;
        private double remainder;
        private double payment;
        private bool isView = false;
        public bool Print
        {
            get { return print; }
            set { print = value; }
        }
        public bool IsView
        {
            get { return isView; }
            set { isView = value; }
        }
        public double Payment
        {
            get { return payment; }
            set { payment = value; }
        }
        public double Remainder
        {
            get { return remainder; }
            set { remainder = value; }
        }
        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public double GrandTotal
        {
            get { return grandTotal; }
            set { grandTotal = value; }
        }
        public bool IsOk
        {
            get { return isOk; }
            set { isOk = value; }
        }

        public frmRentPayment()
        {
            InitializeComponent();

        }
        private void frmRentPayment_Load(object sender, EventArgs e)
        {
            if (isView)
            {
                this.btnPost.Enabled = false;
                this.btnPrint.Enabled = false;
                this.btnDeleteRow.Enabled = false;

                GTSysOne.Class.Utility.clsUtility.View(this.gridControl, this.gridView, 0
                , GTSysOne.Class.Slip.clsSlip_RentPayment.ShowTable(
                    GTSysOne.Class.Slip.clsSlip_RentPayment.Value(0
                           , 0
                           , id
                           , false
                           , false
                           , false
                           , GTSysOne.Class.Utility.clsGlobal.Instance().COMPANYID
                           ))
                , "id", true);

                GTSysOne.Class.Utility.clsUtility.createlookupRepository(this.repositoryItemLookUpEditPaymentMode, GTSysOne.Class.Mapping.clsMap_PaymentMode.ShowTable(GTSysOne.Class.Mapping.clsMap_PaymentMode.Value(0, 0)), new string[] { "Name" }, "id", "Name");
                this.gridView.OptionsBehavior.Editable = false;


                if (gridView.DataRowCount > 0)
                {
                    for (int i = 0; i < gridView.DataRowCount; i++)
                    {
                        if (!(gridView.GetRowCellValue(i, "Amount") is DBNull))
                        {
                            totalAmount += Convert.ToDouble(this.gridView.GetRowCellValue(i, "Amount"));
                        }
                        this.textEditTotalAmount.Text = Convert.ToString(totalAmount);
                    }
                }
            }
            else
            {
                GTSysOne.Class.Utility.clsUtility.View(this.gridControl, this.gridView, 0
                , GTSysOne.Class.Slip.clsSlip_RentPayment.ShowTable(
                    GTSysOne.Class.Slip.clsSlip_RentPayment.Value(0
                           , 0
                           , "0"
                           , false
                           , false
                           , false
                           , GTSysOne.Class.Utility.clsGlobal.Instance().COMPANYID
                           ))
                , "id", true);

                GTSysOne.Class.Utility.clsUtility.createlookupRepository(this.repositoryItemLookUpEditPaymentMode, GTSysOne.Class.Mapping.clsMap_PaymentMode.ShowTable(GTSysOne.Class.Mapping.clsMap_PaymentMode.Value(0, 0)), new string[] { "Name" }, "id", "Name");
                KeyPreview = true;
                this.gridView.OptionsBehavior.Editable = true;
                this.textEditGrandTotal.Text = Convert.ToString(grandTotal);
                this.gridView.AddNewRow();

            }
        }

        private void gridView_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            this.gridView.SetRowCellValue(e.RowHandle, "id", "NEWID()" + System.Guid.NewGuid().ToString());

            if (this.textEditChange.Text != "0.00" && this.textEditAmountDue.Text == "0.00")
            {
                this.textEditChange.BackColor = Color.OrangeRed;
            }
        }

        private void gridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (this.gridView.FocusedColumn.FieldName == "Amount" && changing == false)
            {
                CheckedChanged();
                changing = true;
            }
        }
        private void gridView_RowCountChanged(object sender, EventArgs e)
        {
            CheckedChanged();
        }
        private void CheckedChanged()
        {
            if (!isView)
            {
                totalAmount = 0;
                if (gridView.DataRowCount > 0)
                {
                    for (int i = 0; i < gridView.DataRowCount; i++)
                    {
                        if (!(gridView.GetRowCellValue(i, "Amount") is DBNull))
                        {
                            totalAmount += Convert.ToDouble(this.gridView.GetRowCellValue(i, "Amount"));
                        }
                        this.textEditTotalAmount.Text = Convert.ToString(totalAmount);

                        //if total amount is greater the grandtotal give change
                        if (totalAmount >= grandTotal)
                        {
                            this.textEditAmountDue.Text = "0.00";
                            this.textEditChange.Text = Convert.ToString(totalAmount - grandTotal);
                            this.textEditChange.BackColor = Color.OrangeRed;
                        }
                        //if total amount is lesser calculate the amount due
                        if (totalAmount < grandTotal)
                        {
                            this.textEditChange.Text = "0.00";
                            this.textEditAmountDue.Text = Convert.ToString(grandTotal - totalAmount);
                            this.textEditChange.BackColor = Control.DefaultBackColor;
                        }
                    }
                }

                if (gridView.DataRowCount == 0)
                {
                    this.textEditAmountDue.Text = "0.00";
                    this.textEditChange.Text = "0.00";
                    this.textEditTotalAmount.Text = "0.00";
                    this.textEditChange.BackColor = Color.FromArgb(245, 245, 247);
                }
            }
        }
        private void repositoryItemButtonEditCreditCard_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            DevExpress.XtraEditors.ButtonEdit editor = sender as DevExpress.XtraEditors.ButtonEdit;
            DevExpress.XtraEditors.Controls.EditorButton Button = e.Button;

            if (editor.Properties.Buttons.IndexOf(e.Button) == 0)
            {
                using (var C = new GTSysOne.Gui.Main.frmGTSysList(GTSysOne.Class.Utility.clsGlobal.myFunction.Card))
                {
                    C.ShowDialog(this);
                    if (C.IS_OK)
                    {
                        this.gridView.SetRowCellValue(this.gridView.FocusedRowHandle, "DepositDate", System.Convert.ToString(GTSysOne.Class.Utility.clsUtility.SERVERDATE()));
                        this.gridView.SetRowCellValue(this.gridView.FocusedRowHandle, "CCId", C.GetData["id"]);
                        this.gridView.SetRowCellValue(this.gridView.FocusedRowHandle, "Card Type", C.GetData["Card Type"]);
                        C.Dispose();
                    }
                    else
                    {
                        C.Dispose();
                    }
                }
            }
            if (editor.Properties.Buttons.IndexOf(e.Button) == 1)
            {
                GTSysOne.Gui.MasterFile.frmCard.Instance.UseDashboard = false;
                GTSysOne.Gui.MasterFile.frmCard.Instance.EnformFunction = GTSysOne.Gui.MasterFile.frmCard.enFormFunction.Card;
                GTSysOne.Gui.MasterFile.frmCard.Instance.EnformStatus = GTSysOne.Gui.MasterFile.frmCard.enFormStatus.Add;
                GTSysOne.Gui.MasterFile.frmCard.Instance.Show();
            }
        }
        private void btnPost_Click(object sender, EventArgs e)
        {
            post = true;
            this.Close();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            print = true;
            this.Close();
        }

        private void btnDeleteRow_Click(object sender, EventArgs e)
        {
            this.gridView.DeleteSelectedRows();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmRentPayment_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                post = true;
                this.Close();
            }
            if (e.KeyCode == Keys.F2)
            {
                print = true;
                this.Close();
            }
            if (e.KeyCode == Keys.F3)
            {
                this.gridView.DeleteSelectedRows();
            }
            if (e.KeyCode == Keys.F4)
            {
                this.Close();
            }
        }

        private void frmRentPayment_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (gridView.DataRowCount > 0 && post || print)
            {
                isOk = true;
                foreach (GridColumn column in gridView.Columns)
                {
                    dt.Columns.Add(column.FieldName, column.ColumnType);
                }
                for (int i = 0; i < gridView.DataRowCount; i++)
                {
                    DataRow row = dt.NewRow();
                    foreach (GridColumn column in gridView.Columns)
                    {
                        row[column.FieldName] = gridView.GetRowCellValue(i, column);
                    }
                    dt.Rows.Add(row);
                }

                if (Convert.ToDouble(this.textEditChange.Text) > 0)
                {
                    Remainder = Convert.ToDouble(this.textEditChange.Text);
                }
                else
                {
                    Remainder = 0;
                }

                if (Convert.ToDouble(this.textEditTotalAmount.Text) > 0)
                {
                    Payment = Convert.ToDouble(this.textEditTotalAmount.Text);
                }
                else
                {
                    Payment = 0;
                }

                this.Dispose();
            }
        }

        private void gridView_ShowingEditor(object sender, CancelEventArgs e)
        {
            if (this.gridView.FocusedColumn.FieldName == "Card Type" 
                && (System.Convert.ToString(this.gridView.GetRowCellDisplayText(this.gridView.FocusedRowHandle, "PaymentMode")) == "Cash"))
            {
                e.Cancel = true;
            }
        }
    }
}