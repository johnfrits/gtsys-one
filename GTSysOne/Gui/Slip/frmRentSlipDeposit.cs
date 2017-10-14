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
    public partial class frmRentSlipDeposit : DevExpress.XtraEditors.XtraForm
    {
        public DataTable dt = new DataTable();
        private double TotalDeposit;
        private bool isOk;
        private string id;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        public double TotalDeposit1
        {
            get { return TotalDeposit; }
            set { TotalDeposit = value; }
        }

        public bool OK
        {
            get { return isOk; }
        }

        public frmRentSlipDeposit()
        {
            InitializeComponent();
        }

        private void frmRentSlipDeposit_Load(object sender, EventArgs e)
        {
            GTSysOne.Class.Utility.clsUtility.View(this.gridControl, this.gridView, 0
         , GTSysOne.Class.Slip.clsSlip_RentDeposit.ShowTable(
             GTSysOne.Class.Slip.clsSlip_RentDeposit.Value(0
                    , 0
                    , "0"
                    , false
                    , false
                    , false
                    , GTSysOne.Class.Utility.clsGlobal.Instance().COMPANYID))
         , "id", true);
        }
        private void gridView_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            this.gridView.SetRowCellValue(e.RowHandle, "id", "NEWID()" + System.Guid.NewGuid().ToString());
        }
       
        private void frmRentSlipDeposit_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (gridView.DataRowCount > 0)
            {
                isOk = true;

                for (int i = 0; i <= gridView.DataRowCount; i++)
                {
                    TotalDeposit1 += Convert.ToDouble(gridView.GetRowCellValue(i, "Deposit"));
                }

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
            }
        }

    }
}