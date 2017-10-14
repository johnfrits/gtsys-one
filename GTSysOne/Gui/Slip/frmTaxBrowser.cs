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
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace GTSysOne.Gui.Slip
{
    public partial class frmTaxBrowser : DevExpress.XtraEditors.XtraForm
    {
        public DataRow selectedRow { get; set; }

        public frmTaxBrowser()
        {
            InitializeComponent();

            DialogResult = DialogResult.Cancel;

            GTSysOne.Class.Utility.clsUtility.View(this.grdControlTax, this.grdViewTax, 0
                         , GTSysOne.Class.MasterFile.clsMas_Tax.ShowTable(
                             GTSysOne.Class.MasterFile.clsMas_Tax.Value(0, 7, string.Empty, string.Empty, 
                                false, false,GTSysOne.Class.Utility.clsGlobal.Instance().COMPANYID))
                         , "id", true);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            selectedRow = grdViewTax.GetFocusedDataRow();

            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void grdViewTax_DoubleClick(object sender, EventArgs e)
        {
            GridView view = (GridView)sender;
            Point pt = view.GridControl.PointToClient(Control.MousePosition);
            DoRowDoubleClick(view, pt);
        }

        private void DoRowDoubleClick(GridView view, Point pt)
        {
            GridHitInfo info = view.CalcHitInfo(pt);
            if (info.InRow || info.InRowCell)
                btnOk_Click(new object(), new EventArgs());
        }
    }
}