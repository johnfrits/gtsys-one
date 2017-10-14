namespace GTSysOne.Gui.Main
{
    public partial class frmDashboard : DevExpress.XtraEditors.XtraForm
    {
        public frmDashboard()
        {
            InitializeComponent();
            p_instance = this;
            this.gridControlDashboard.ContextMenuStrip = this.contextMenuDashBoard;
            this.contextMenuDashBoard.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(EVENT_HANDLE_MENUITEM_CLICK);
            this.SOHTML.Click += new System.EventHandler(this.SO_A_Click);
            this.AHTML.Click += new System.EventHandler(this.SO_A_Click);
            this.SOCSV.Click += new System.EventHandler(this.SO_A_Click);
            this.ACSV.Click += new System.EventHandler(this.SO_A_Click);
            this.SOMS7.Click += new System.EventHandler(this.SO_A_Click);
            this.AMS7.Click += new System.EventHandler(this.SO_A_Click);
            this.SOMS.Click += new System.EventHandler(this.SO_A_Click);
            this.AMS.Click += new System.EventHandler(this.SO_A_Click);
            this.SORTF.Click += new System.EventHandler(this.SO_A_Click);
            this.ARTF.Click += new System.EventHandler(this.SO_A_Click);
            this.SOPDF.Click += new System.EventHandler(this.SO_A_Click);
            this.APDF.Click += new System.EventHandler(this.SO_A_Click);
            this.SOMHT.Click += new System.EventHandler(this.SO_A_Click);
            this.AMHT.Click += new System.EventHandler(this.SO_A_Click);
            this.SOText.Click += new System.EventHandler(this.SO_A_Click);
            this.AText.Click += new System.EventHandler(this.SO_A_Click);
        }
        private void EVENT_HANDLE_MENUITEM_CLICK(object sender, System.EventArgs e)
        {
            if (((System.Windows.Forms.ContextMenuStrip)this.contextMenuDashBoard).Items["cmsPrint"].Selected)
            {
                this.gridControlDashboard.Print();
            }
            else if (((System.Windows.Forms.ContextMenuStrip)this.contextMenuDashBoard).Items["cmsPrintPreview"].Selected)
            {
                this.gridControlDashboard.ShowPrintPreview();
            }
        }
        private void SO_A_Click(object sender, System.EventArgs e)
        {
          GTSysOne.Class.Utility.clsUtility.ShowSaveFileDialog(this.gridControlDashboard,(System.Windows.Forms.ToolStripMenuItem)sender, this);
        }
    }
}