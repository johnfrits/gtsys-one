using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;

namespace GTSysOne.Gui.Slip
{
    public partial class frmRentSlipCreditCardDetails : DevExpress.XtraEditors.XtraForm
    {
        public DataTable dt = new DataTable();
        private double totalPay;
        public double TotalPay
        {
            get { return totalPay; }
            set { totalPay = value; }
        }
        private bool isOk;
        public bool OK
        {
            get { return isOk; }
        }

        public frmRentSlipCreditCardDetails()
        {
            InitializeComponent();

            GTSysOne.Class.Utility.clsUtility.View(this.gridControl, this.gridView, 0
                  , GTSysOne.Class.Slip.clsSlip_RentCreditCardDetails.ShowTable(
                      GTSysOne.Class.Slip.clsSlip_RentCreditCardDetails.Value(0
                             , 0
                             , string.Empty
                             , string.Empty
                             , string.Empty
                             , string.Empty
                             , GTSysOne.Class.Utility.clsGlobal.Instance().COMPANYID))
                  , "id", true);
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (gridView.DataRowCount > 0)
            {
                isOk = true;

                for (int i = 0; i <= gridView.DataRowCount; i++)
                {
                    TotalPay += Convert.ToDouble(gridView.GetRowCellValue(i, "Value"));
                }

                foreach (GridColumn column in gridView.VisibleColumns)
                {
                    dt.Columns.Add(column.FieldName, column.ColumnType);
                }
                for (int i = 0; i < gridView.DataRowCount; i++)
                {
                    DataRow row = dt.NewRow();
                    foreach (GridColumn column in gridView.VisibleColumns)
                    {
                        row[column.FieldName] = gridView.GetRowCellValue(i, column);
                    }
                    dt.Rows.Add(row);
                }
                this.Dispose();
            }
        }

        private void gridView_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            this.gridView.SetRowCellValue(e.RowHandle, "id", "NEWID()" + System.Guid.NewGuid().ToString());
        }
    }
}