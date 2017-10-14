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
    public partial class frmRentSlipInsurance : DevExpress.XtraEditors.XtraForm
    {
        public DataTable dt = new DataTable();
        private double TotalInsurance;
        private bool isOk;

        public double TotalInsurance1
        {
            get { return TotalInsurance; }
            set { TotalInsurance = value; }
        }

        public bool OK
        {
            get { return isOk; }
        }
        public frmRentSlipInsurance()
        {
            InitializeComponent();

            GTSysOne.Class.Utility.clsUtility.View(this.gridControl, this.gridView, 0
                     , GTSysOne.Class.Slip.clsSlip_RentInsurance.ShowTable(
                         GTSysOne.Class.Slip.clsSlip_RentInsurance.Value(0
                                , 0
                                , string.Empty
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

        private void frmRentSlipInsurance_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (gridView.DataRowCount > 0)
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

                    for (int i = 0; i <= gridView.DataRowCount; i++)
                    {
                        TotalInsurance1 += Convert.ToDouble(gridView.GetRowCellValue(i, "Insurance"));
                    }
                    this.Dispose();
                }
            }
            catch
            {
                TotalInsurance1 = 0;
            }
          
        }
    }
}