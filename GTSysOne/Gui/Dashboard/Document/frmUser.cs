namespace GTSysOne.Gui.Dashboard.Document
{
    public partial class frmUser : GTSysOne.Gui.Main.frmDashboard
    {
        private static string Search;
        private static frmUser p_instance = null;
        public static frmUser Instance
        {
            get
            {
                if (p_instance == null) p_instance = new frmUser();
                p_instance.TopLevel = false;
                p_instance.Visible = true;
                p_instance.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                p_instance.Dock = System.Windows.Forms.DockStyle.Fill;
                p_instance.BringToFront();
                return p_instance;
            }
        }
        protected frmUser()
        {
            InitializeComponent();
            this.contextMenuDashBoard.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(EVENT_HANDLE_MENUITEM_CLICK);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FORM_CLOSING);
            GTSysOne.Class.Utility.clsUtility.View(this.gridControlDashboard , this.gridViewDashboard, 0
                         , GTSysOne.Class.Document.clsDoc_User.ShowTable(GTSysOne.Class.Document.clsDoc_User.Value(0, 2, Search))
                         , "id", true);
            if (!GTSysOne.Class.Utility.clsGlobal.Instance().Admin)
            {
                ((System.Windows.Forms.ContextMenuStrip)this.contextMenuDashBoard).Items["cmsNew"].Visible = GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_Add_User;
                ((System.Windows.Forms.ContextMenuStrip)this.contextMenuDashBoard).Items["cmsEdit"].Visible = GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_Edit_User;
                ((System.Windows.Forms.ContextMenuStrip)this.contextMenuDashBoard).Items["cmsView"].Visible = GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_View_User;
            }


            GTSysOne.Class.Utility.clsUtility.Layout_Restore_Save(this.gridViewDashboard, GTSysOne.Class.Utility.clsGlobal.GridLayout.Restore, GTSysOne.Class.Utility.clsGlobal.Instance().GridLayoutLocation + "Dashboard\\Document\\", this.Name.Replace("frm", ""), this.gridControlDashboard);
        }
        private void EVENT_HANDLE_MENUITEM_CLICK(object sender, System.EventArgs e)
        {
            if (((System.Windows.Forms.ContextMenuStrip)this.contextMenuDashBoard).Items["cmsNew"].Selected)
            {
                GTSysOne.Gui.Main.frmMain.CALLFROMDASHBOARD(GTSysOne.Class.Utility.clsGlobal.myFunction.User, System.Convert.ToString(((System.Windows.Forms.ContextMenuStrip)this.contextMenuDashBoard).Items["cmsNew"].Tag));
            }
            else if (((System.Windows.Forms.ContextMenuStrip)this.contextMenuDashBoard).Items["cmsEdit"].Selected)
            {
                GTSysOne.Gui.Main.frmMain.CALLFROMDASHBOARD(GTSysOne.Class.Utility.clsGlobal.myFunction.User, System.Convert.ToString(((System.Windows.Forms.ContextMenuStrip)this.contextMenuDashBoard).Items["cmsEdit"].Tag));
            }
            else if (((System.Windows.Forms.ContextMenuStrip)this.contextMenuDashBoard).Items["cmsView"].Selected)
            {
                GTSysOne.Gui.Main.frmMain.CALLFROMDASHBOARD(GTSysOne.Class.Utility.clsGlobal.myFunction.User, System.Convert.ToString(((System.Windows.Forms.ContextMenuStrip)this.contextMenuDashBoard).Items["cmsView"].Tag));
            }
            else if (((System.Windows.Forms.ContextMenuStrip)this.contextMenuDashBoard).Items["cmsClose"].Selected)
            {
                GTSysOne.Gui.Main.frmMain.CALLFROMDASHBOARD(GTSysOne.Class.Utility.clsGlobal.myFunction.User, System.Convert.ToString(((System.Windows.Forms.ContextMenuStrip)this.contextMenuDashBoard).Items["cmsClose"].Tag));
            }
            else if (((System.Windows.Forms.ContextMenuStrip)this.contextMenuDashBoard).Items["cmsRefresh"].Selected)
            {
                GTSysOne.Class.Utility.clsUtility.View(this.gridControlDashboard , this.gridViewDashboard, 0
                    , GTSysOne.Class.Document.clsDoc_User.ShowTable(GTSysOne.Class.Document.clsDoc_User.Value(0, 2, Search))
                    , "id", true);
            }
        }
        public static void CallFromMain(string Caption,string search = "",bool IsNew = true,int e = 0,string Id = "")
        {
            switch (Caption)
            {
                case "New":
                case "cmsNew":
                    GTSysOne.Gui.Document.frmUser.Instance.EnformStatus = Gui.Document.frmUser.enFormStatus.Add;
                    GTSysOne.Gui.Document.frmUser.Instance.Show();
                    break;
                case "Edit":
                case "cmsEdit":
                    GTSysOne.Gui.Document.frmUser.Instance.EnformStatus = Gui.Document.frmUser.enFormStatus.Edit;
                    GTSysOne.Gui.Document.frmUser.Instance.Id = System.Convert.ToString(Instance.gridViewDashboard.GetRowCellValue(Instance.gridViewDashboard.FocusedRowHandle, "id"));
                    GTSysOne.Gui.Document.frmUser.Instance.Show();
                    break;
                case "View":
                case "cmsView":
                    GTSysOne.Gui.Document.frmUser.Instance.EnformStatus = Gui.Document.frmUser.enFormStatus.View;
                    GTSysOne.Gui.Document.frmUser.Instance.Id = System.Convert.ToString(Instance.gridViewDashboard.GetRowCellValue(Instance.gridViewDashboard.FocusedRowHandle, "id"));
                    GTSysOne.Gui.Document.frmUser.Instance.Show();
                    break;
                case "Search":
                case "Refresh":
                    Search = search;
                    GTSysOne.Class.Utility.clsUtility.View(Instance.gridControlDashboard
                    , Instance.gridViewDashboard, e
                    , GTSysOne.Class.Document.clsDoc_User.ShowTable(GTSysOne.Class.Document.clsDoc_User.Value(0, 2, Search))
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
            if (GTSysOne.Gui.Document.frmUser.p_instance != null)
            {
                GTSysOne.Gui.Document.frmUser.p_instance.Close();
            }
            GTSysOne.Class.Utility.clsUtility.Layout_Restore_Save(this.gridViewDashboard, GTSysOne.Class.Utility.clsGlobal.GridLayout.Save, GTSysOne.Class.Utility.clsGlobal.Instance().GridLayoutLocation + "Dashboard\\Document\\", this.Name.Replace("frm", ""), this.gridControlDashboard);
        }
    }
}