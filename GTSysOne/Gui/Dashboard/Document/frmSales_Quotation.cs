using System.Data;

namespace GTSysOne.Gui.Dashboard.Document
{
    public partial class frmSalesQuotation : GTSysOne.Gui.Main.frmDashboard
    {
        private static DataRow selectedRow;

        private static string Search;        
        private static frmSalesQuotation p_instance = null;
        public static frmSalesQuotation Instance
        {
            get
            {
                if (p_instance == null) p_instance = new frmSalesQuotation();
                p_instance.TopLevel = false;
                p_instance.Visible = true;
                p_instance.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                p_instance.Dock = System.Windows.Forms.DockStyle.Fill;
                p_instance.BringToFront();
                return p_instance;
            }
        }

        protected frmSalesQuotation()
        {
            InitializeComponent();
            this.contextMenuDashBoard.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(EVENT_HANDLE_MENUITEM_CLICK);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FORM_CLOSING);
            GTSysOne.Class.Utility.clsUtility.View(this.gridControlDashboard, this.gridViewDashboard, 0
                         , GTSysOne.Class.Document.clsDoc_SalesQuotation.ShowTable(
                             GTSysOne.Class.Document.clsDoc_SalesQuotation.Value(
                                 0, 0, string.Empty, string.Empty, false, false, false, GTSysOne.Class.Utility.clsGlobal.Instance().COMPANYID))
                         , "id", true);

            ((System.Windows.Forms.ContextMenuStrip)this.contextMenuDashBoard).Items["cmsNew"].Visible = GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_Add_Sales_Quotation;
            ((System.Windows.Forms.ContextMenuStrip)this.contextMenuDashBoard).Items["cmsEdit"].Visible = GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_Edit_Sales_Quotation;
            ((System.Windows.Forms.ContextMenuStrip)this.contextMenuDashBoard).Items["cmsView"].Visible = GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_View_Sales_Quotation;

            GTSysOne.Class.Utility.clsUtility.Layout_Restore_Save(this.gridViewDashboard, GTSysOne.Class.Utility.clsGlobal.GridLayout.Restore, GTSysOne.Class.Utility.clsGlobal.Instance().GridLayoutLocation + "Dashboard\\Document\\", this.Name.Replace("frm", ""), this.gridControlDashboard);
        }

        private void EVENT_HANDLE_MENUITEM_CLICK(object sender, System.EventArgs e)
        {
            if (((System.Windows.Forms.ContextMenuStrip)this.contextMenuDashBoard).Items["cmsNew"].Selected)
            {
                GTSysOne.Gui.Main.frmMain.CALLFROMDASHBOARD(GTSysOne.Class.Utility.clsGlobal.myFunction.Company, System.Convert.ToString(((System.Windows.Forms.ContextMenuStrip)this.contextMenuDashBoard).Items["cmsNew"].Tag));
            }
            else if (((System.Windows.Forms.ContextMenuStrip)this.contextMenuDashBoard).Items["cmsEdit"].Selected)
            {
                GTSysOne.Gui.Main.frmMain.CALLFROMDASHBOARD(GTSysOne.Class.Utility.clsGlobal.myFunction.Company, System.Convert.ToString(((System.Windows.Forms.ContextMenuStrip)this.contextMenuDashBoard).Items["cmsEdit"].Tag));
            }
            else if (((System.Windows.Forms.ContextMenuStrip)this.contextMenuDashBoard).Items["cmsView"].Selected)
            {
                GTSysOne.Gui.Main.frmMain.CALLFROMDASHBOARD(GTSysOne.Class.Utility.clsGlobal.myFunction.Company, System.Convert.ToString(((System.Windows.Forms.ContextMenuStrip)this.contextMenuDashBoard).Items["cmsView"].Tag));
            }
            else if (((System.Windows.Forms.ContextMenuStrip)this.contextMenuDashBoard).Items["cmsClose"].Selected)
            {
                GTSysOne.Gui.Main.frmMain.CALLFROMDASHBOARD(GTSysOne.Class.Utility.clsGlobal.myFunction.Company, System.Convert.ToString(((System.Windows.Forms.ContextMenuStrip)this.contextMenuDashBoard).Items["cmsClose"].Tag));
            }
            else if (((System.Windows.Forms.ContextMenuStrip)this.contextMenuDashBoard).Items["cmsRefresh"].Selected)
            {
                GTSysOne.Class.Utility.clsUtility.View(this.gridControlDashboard, this.gridViewDashboard, 0
                    , GTSysOne.Class.Document.clsDoc_SalesQuotation.ShowTable(GTSysOne.Class.Document.clsDoc_SalesQuotation.Value(0, 1, Search))
                    , "id", true);
            }
        }

        public static void CallFromMain(string Caption, string search = "", bool IsNew = true, int e = 0, string Id = "")
        {
            switch (Caption)
            {
                case "New":
                case "cmsNew":
                    GTSysOne.Gui.Document.frmSalesQuotation.Instance.EnformStatus = Gui.Document.frmSalesQuotation.enFormStatus.Add;
                    GTSysOne.Gui.Document.frmSalesQuotation.Instance.Show();
                    break;
                case "Edit":
                case "cmsEdit":
                    GTSysOne.Gui.Document.frmSalesQuotation.Instance.EnformStatus = Gui.Document.frmSalesQuotation.enFormStatus.Edit;
                    //GTSysOne.Gui.Document.frmSalesQuotation.Instance.Id = System.Convert.ToString(Instance.gridViewDashboard.GetRowCellValue(Instance.gridViewDashboard.FocusedRowHandle, "id"));

                    selectedRow = Instance.gridViewDashboard.GetFocusedDataRow();
                    GTSysOne.Gui.Document.frmSalesQuotation.Instance.Id = selectedRow["id"].ToString();
                    GTSysOne.Gui.Document.frmSalesQuotation.Instance.Show();
                    break;
                case "View":
                case "cmsView":
                    GTSysOne.Gui.Document.frmSalesQuotation.Instance.EnformStatus = Gui.Document.frmSalesQuotation.enFormStatus.View;                    

                    selectedRow = Instance.gridViewDashboard.GetFocusedDataRow();
                    GTSysOne.Gui.Document.frmSalesQuotation.Instance.Id = selectedRow["id"].ToString();
                    GTSysOne.Gui.Document.frmSalesQuotation.Instance.Show();
                    break;
                case "Search":
                case "Refresh":
                    GTSysOne.Class.Utility.clsUtility.View(Instance.gridControlDashboard
                    , Instance.gridViewDashboard, e
                    , GTSysOne.Class.Document.clsDoc_SalesQuotation.ShowTable(GTSysOne.Class.Document.clsDoc_SalesQuotation.Value(
                                 0, 0, string.Empty, string.Empty, false, false, false, GTSysOne.Class.Utility.clsGlobal.Instance().COMPANYID))
                    , "id"
                    , true);
                    break;
                case "Close":
                case "cmsClose":
                    Instance.Close();
                    break;
            }
        }

        private void FORM_CLOSING(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            if (GTSysOne.Gui.Document.frmSalesQuotation.p_instance != null)
            {
                GTSysOne.Gui.Document.frmSalesQuotation.p_instance.Close();
            }
            GTSysOne.Class.Utility.clsUtility.Layout_Restore_Save(this.gridViewDashboard, GTSysOne.Class.Utility.clsGlobal.GridLayout.Save, GTSysOne.Class.Utility.clsGlobal.Instance().GridLayoutLocation + "Dashboard\\Document\\", this.Name.Replace("frm", ""), this.gridControlDashboard);
        }
    }
}