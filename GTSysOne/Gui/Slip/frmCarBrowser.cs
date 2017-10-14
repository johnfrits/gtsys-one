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
    public partial class frmCarBrowser : DevExpress.XtraEditors.XtraForm
    {
        public DataRow selectedRow { get; set; }

        private bool isOk;
        public bool OK
        {
            get { return isOk; }
        }   

        public frmCarBrowser()
        {
            InitializeComponent();
        }

        private void frmCarBrowser_Load(object sender, EventArgs e)
        {
            GTSysOne.Class.Utility.clsUtility.View(this.gridControl, this.gridView, 0
                 , GTSysOne.Class.MasterFile.clsMas_FixedAssets.ShowTable(
                     GTSysOne.Class.MasterFile.clsMas_FixedAssets.Value(0
                            , 5
                            , string.Empty
                            , string.Empty
                            , false
                            , false
                            , GTSysOne.Class.Utility.clsGlobal.Instance().COMPANYID))
                 , "id", true);
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            selectedRow = gridView.GetFocusedDataRow();
            isOk = true;
            this.Hide();
        }
        private void gridView_DoubleClick(object sender, EventArgs e)
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