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
    public partial class frmRentCash : DevExpress.XtraEditors.XtraForm
    {
        public DataTable dt = new DataTable();
        bool changing = false;
        private double totalCash;

        public double TotalCash
        {
            get { return totalCash; }
            set { totalCash = value; }
        }
        private bool isOk;
        public bool OK
        {
            get { return isOk; }
        }

        public frmRentCash()
        {
            InitializeComponent();

            GTSysOne.Class.Utility.clsUtility.View(this.gridControl, this.gridView, 0
              , GTSysOne.Class.Slip.clsSlip_RentCash.ShowTable(
                  GTSysOne.Class.Slip.clsSlip_RentCash.Value(0
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
                    totalCash += Convert.ToDouble(gridView.GetRowCellValue(i, "Cash"));
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