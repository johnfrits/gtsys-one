namespace GTSysOne.Gui.Dashboard.Document
{
    public partial class frmCompany : GTSysOne.Gui.Main.frmDashboard
    {
        private static string Search;
        private static frmCompany p_instance = null;
        public static frmCompany Instance
        {
            get
            {
                if (p_instance == null) p_instance = new frmCompany();
                p_instance.TopLevel = false;
                p_instance.Visible = true;
                p_instance.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                p_instance.Dock = System.Windows.Forms.DockStyle.Fill;
                p_instance.BringToFront();
                return p_instance;
            }
        }
        protected frmCompany()
        {
            InitializeComponent();
            this.contextMenuDashBoard.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(EVENT_HANDLE_MENUITEM_CLICK);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FORM_CLOSING);
            GTSysOne.Class.Utility.clsUtility.View(this.gridControlDashboard, this.gridViewDashboard, 0
                         , GTSysOne.Class.Document.clsDoc_Company.ShowTable(GTSysOne.Class.Document.clsDoc_Company.Value(0, 1, Search))
                         , "id", true);

            ((System.Windows.Forms.ContextMenuStrip)this.contextMenuDashBoard).Items["cmsNew"].Visible = GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_Add_Company;
            ((System.Windows.Forms.ContextMenuStrip)this.contextMenuDashBoard).Items["cmsEdit"].Visible = GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_Edit_Company;
            ((System.Windows.Forms.ContextMenuStrip)this.contextMenuDashBoard).Items["cmsView"].Visible = GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_View_Company;




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
                    , GTSysOne.Class.Document.clsDoc_Company.ShowTable(GTSysOne.Class.Document.clsDoc_Company.Value(0, 1, Search))
                    , "id", true);
            }
        }
        public static void CallFromMain(string Caption, string search = "", bool IsNew = true, int e = 0, string Id = "")
        {
            switch (Caption)
            {
                case "New":
                case "cmsNew":
                    if (GTSysOne.Class.Utility.clsGlobal.Instance().TOTALCOMPANY >= System.Convert.ToInt32(GTSysOne.Class.Document.clsDoc_Company.ScalarValue(GTSysOne.Class.Document.clsDoc_Company.Value(0,5))))
                    {
                        GTSysOne.Gui.Document.frmCompany.Instance.EnformStatus = Gui.Document.frmCompany.enFormStatus.Add;
                        GTSysOne.Gui.Document.frmCompany.Instance.Show();
                    }
                    else
                    {
                        GTSysOne.Class.Utility.clsUtility.GTSysMessageBox(new string[]{"Cannot Create New Company."
                                ,"You Are Now Exceeding based on your license company limit."
                                ,"Please Contact GTS for more Information." }
                                , GTSysOne.Class.Utility.clsGlobal.enMessageBoxButton.OK
                                , GTSysOne.Class.Utility.clsGlobal.enMessageBoxIcon.Information
                                ,"License Exceed");
                    }
                    break;
                case "Edit":
                case "cmsEdit":
                    GTSysOne.Gui.Document.frmCompany.Instance.EnformStatus = Gui.Document.frmCompany.enFormStatus.Edit;
                    GTSysOne.Gui.Document.frmCompany.Instance.Id = System.Convert.ToString(Instance.gridViewDashboard.GetRowCellValue(Instance.gridViewDashboard.FocusedRowHandle, "id"));
                    GTSysOne.Gui.Document.frmCompany.Instance.Show();
                    break;
                case "View":
                case "cmsView":
                    GTSysOne.Gui.Document.frmCompany.Instance.EnformStatus = Gui.Document.frmCompany.enFormStatus.View;
                    GTSysOne.Gui.Document.frmCompany.Instance.Id = System.Convert.ToString(Instance.gridViewDashboard.GetRowCellValue(Instance.gridViewDashboard.FocusedRowHandle, "id"));
                    GTSysOne.Gui.Document.frmCompany.Instance.Show();
                    break;
                case "Search":
                case "Refresh":
                    Search = search;
                    GTSysOne.Class.Utility.clsUtility.View(Instance.gridControlDashboard
                    , Instance.gridViewDashboard, e
                    , GTSysOne.Class.Document.clsDoc_Company.ShowTable(GTSysOne.Class.Document.clsDoc_Company.Value(0, 1, Search))
                    , Id
                    , IsNew);
                    break;
                case "Close":
                case "cmsClose":
                    Instance.Close();
                    break;
            }
        }
        private void FORM_CLOSING(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            if (GTSysOne.Gui.Document.frmCompany.p_instance != null)
            {
                GTSysOne.Gui.Document.frmCompany.p_instance.Close();
            }
            GTSysOne.Class.Utility.clsUtility.Layout_Restore_Save(this.gridViewDashboard, GTSysOne.Class.Utility.clsGlobal.GridLayout.Save, GTSysOne.Class.Utility.clsGlobal.Instance().GridLayoutLocation + "Dashboard\\Document\\", this.Name.Replace("frm", ""), this.gridControlDashboard);
        }
    }
}