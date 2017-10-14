namespace GTSysOne.Gui.Dashboard.MasterFile
{
    public partial class frmIdentityType : GTSysOne.Gui.Main.frmDashboard
    {
        private static string Search;
        private static frmIdentityType p_instance = null;
       
        public static frmIdentityType Instance
        {
            get
            {
                if (p_instance == null) p_instance = new frmIdentityType();
                p_instance.TopLevel = false;
                p_instance.Visible = true;
                p_instance.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                p_instance.Dock = System.Windows.Forms.DockStyle.Fill;
                p_instance.BringToFront();
       
                return p_instance;
            }
        }
        protected frmIdentityType()
        {
            InitializeComponent();
            this.contextMenuDashBoard.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(EVENT_HANDLE_MENUITEM_CLICK);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FORM_CLOSING);
            GTSysOne.Class.Utility.clsUtility.View(this.gridControlDashboard, this.gridViewDashboard, 0
                        , GTSysOne.Class.MasterFile.clsMas_IdentityType.ShowTable(GTSysOne.Class.MasterFile.clsMas_IdentityType.Value(0, 0
                        , Search
                        , string.Empty
                        , false
                        , false
                        , GTSysOne.Class.Utility.clsGlobal.Instance().COMPANYID))
                        , "id", true);
            ((System.Windows.Forms.ContextMenuStrip)this.contextMenuDashBoard).Items["cmsNew"].Visible = GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_Add_Identity_Type;
            ((System.Windows.Forms.ContextMenuStrip)this.contextMenuDashBoard).Items["cmsEdit"].Visible = GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_Edit_Identy_Type;
            ((System.Windows.Forms.ContextMenuStrip)this.contextMenuDashBoard).Items["cmsView"].Visible = GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_View_Identy_Type;

            GTSysOne.Class.Utility.clsUtility.Layout_Restore_Save(this.gridViewDashboard, GTSysOne.Class.Utility.clsGlobal.GridLayout.Restore, GTSysOne.Class.Utility.clsGlobal.Instance().GridLayoutLocation + "Dashboard\\Document\\", this.Name.Replace("frm", ""), this.gridControlDashboard);
        }

        private void EVENT_HANDLE_MENUITEM_CLICK(object sender, System.Windows.Forms.ToolStripItemClickedEventArgs e)
        {
            if (((System.Windows.Forms.ContextMenuStrip)this.contextMenuDashBoard).Items["cmsNew"].Selected)
            {
                GTSysOne.Gui.Main.frmMain.CALLFROMDASHBOARD(GTSysOne.Class.Utility.clsGlobal.myFunction.IdentityType, System.Convert.ToString(((System.Windows.Forms.ContextMenuStrip)this.contextMenuDashBoard).Items["cmsNew"].Tag));
            }
            else if (((System.Windows.Forms.ContextMenuStrip)this.contextMenuDashBoard).Items["cmsEdit"].Selected)
            {
                GTSysOne.Gui.Main.frmMain.CALLFROMDASHBOARD(GTSysOne.Class.Utility.clsGlobal.myFunction.IdentityType, System.Convert.ToString(((System.Windows.Forms.ContextMenuStrip)this.contextMenuDashBoard).Items["cmsEdit"].Tag));
            }
            else if (((System.Windows.Forms.ContextMenuStrip)this.contextMenuDashBoard).Items["cmsView"].Selected)
            {
                GTSysOne.Gui.Main.frmMain.CALLFROMDASHBOARD(GTSysOne.Class.Utility.clsGlobal.myFunction.IdentityType, System.Convert.ToString(((System.Windows.Forms.ContextMenuStrip)this.contextMenuDashBoard).Items["cmsView"].Tag));
            }
            else if (((System.Windows.Forms.ContextMenuStrip)this.contextMenuDashBoard).Items["cmsClose"].Selected)
            {
                GTSysOne.Gui.Main.frmMain.CALLFROMDASHBOARD(GTSysOne.Class.Utility.clsGlobal.myFunction.IdentityType, System.Convert.ToString(((System.Windows.Forms.ContextMenuStrip)this.contextMenuDashBoard).Items["cmsClose"].Tag));
            }
            else if (((System.Windows.Forms.ContextMenuStrip)this.contextMenuDashBoard).Items["cmsRefresh"].Selected)
            {
                GTSysOne.Class.Utility.clsUtility.View(this.gridControlDashboard, this.gridViewDashboard, 0
                    , GTSysOne.Class.MasterFile.clsMas_IdentityType.ShowTable(GTSysOne.Class.MasterFile.clsMas_IdentityType.Value(0
                    , 0
                    , Search
                    , string.Empty
                    , false
                    , false
                    , GTSysOne.Class.Utility.clsGlobal.Instance().COMPANYID))
                    , "id", true);
            }
        }
        public static void CallFromMain(string Caption, string search = "", bool IsNew = true, int e = 0, string Id = "")
        {
            switch (Caption)
            {
                case "New":
                case "cmsNew":
                    GTSysOne.Gui.MasterFile.frmIdentityType.Instance.EnformStatus = Gui.MasterFile.frmIdentityType.enFormStatus.Add;
                    GTSysOne.Gui.MasterFile.frmIdentityType.Instance.Show();
                    break;
                case "Edit":
                case "cmsEdit":
                    GTSysOne.Gui.MasterFile.frmIdentityType.Instance.EnformStatus = Gui.MasterFile.frmIdentityType.enFormStatus.Edit;
                    GTSysOne.Gui.MasterFile.frmIdentityType.Instance.Id = System.Convert.ToString(Instance.gridViewDashboard.GetRowCellValue(Instance.gridViewDashboard.FocusedRowHandle, "id"));
                    GTSysOne.Gui.MasterFile.frmIdentityType.Instance.Show();
                    break;
                case "View":
                case "cmsView":
                    GTSysOne.Gui.MasterFile.frmIdentityType.Instance.EnformStatus = Gui.MasterFile.frmIdentityType.enFormStatus.View;
                    GTSysOne.Gui.MasterFile.frmIdentityType.Instance.Id = System.Convert.ToString(Instance.gridViewDashboard.GetRowCellValue(Instance.gridViewDashboard.FocusedRowHandle, "id"));
                    GTSysOne.Gui.MasterFile.frmIdentityType.Instance.Show();
                    break;
                case "Search":
                case "Refresh":
                    Search = search;
                    GTSysOne.Class.Utility.clsUtility.View(Instance.gridControlDashboard
                    , Instance.gridViewDashboard, e
                    , GTSysOne.Class.MasterFile.clsMas_IdentityType.ShowTable(GTSysOne.Class.MasterFile.clsMas_IdentityType.Value(0
                    , 0
                    , Search
                    , string.Empty
                    , false
                    , false
                    , GTSysOne.Class.Utility.clsGlobal.Instance().COMPANYID))
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
            if (GTSysOne.Gui.MasterFile.frmIdentityType.p_instance != null)
            {
                GTSysOne.Gui.MasterFile.frmIdentityType.p_instance.Close();
            }
            GTSysOne.Class.Utility.clsUtility.Layout_Restore_Save(this.gridViewDashboard, GTSysOne.Class.Utility.clsGlobal.GridLayout.Save, GTSysOne.Class.Utility.clsGlobal.Instance().GridLayoutLocation + "Dashboard\\Document\\", this.Name.Replace("frm", ""), this.gridControlDashboard);
        }
    }
}