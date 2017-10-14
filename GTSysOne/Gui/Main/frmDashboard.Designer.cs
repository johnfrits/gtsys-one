namespace GTSysOne.Gui.Main
{
    partial class frmDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private static frmDashboard p_instance = null;
        public static frmDashboard DInstance
        {
            get
            {
                if (p_instance == null) p_instance = new frmDashboard();
                p_instance.BringToFront();
                return p_instance;
            }
        }
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gridControlDashboard = new DevExpress.XtraGrid.GridControl();
            this.gridViewDashboard = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.contextMenuDashBoard = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsNew = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsView = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cmsExport = new System.Windows.Forms.ToolStripMenuItem();
            this.selectedOnlyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SOHTML = new System.Windows.Forms.ToolStripMenuItem();
            this.SOCSV = new System.Windows.Forms.ToolStripMenuItem();
            this.SOMS7 = new System.Windows.Forms.ToolStripMenuItem();
            this.SOMS = new System.Windows.Forms.ToolStripMenuItem();
            this.SORTF = new System.Windows.Forms.ToolStripMenuItem();
            this.SOPDF = new System.Windows.Forms.ToolStripMenuItem();
            this.SOMHT = new System.Windows.Forms.ToolStripMenuItem();
            this.SOText = new System.Windows.Forms.ToolStripMenuItem();
            this.allToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AHTML = new System.Windows.Forms.ToolStripMenuItem();
            this.ACSV = new System.Windows.Forms.ToolStripMenuItem();
            this.AMS7 = new System.Windows.Forms.ToolStripMenuItem();
            this.AMS = new System.Windows.Forms.ToolStripMenuItem();
            this.ARTF = new System.Windows.Forms.ToolStripMenuItem();
            this.APDF = new System.Windows.Forms.ToolStripMenuItem();
            this.AMHT = new System.Windows.Forms.ToolStripMenuItem();
            this.AText = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsPrint = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsPrintPreview = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cmsClose = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDashboard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDashboard)).BeginInit();
            this.contextMenuDashBoard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControlDashboard
            // 
            this.gridControlDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlDashboard.Location = new System.Drawing.Point(0, 0);
            this.gridControlDashboard.MainView = this.gridViewDashboard;
            this.gridControlDashboard.Name = "gridControlDashboard";
            this.gridControlDashboard.Size = new System.Drawing.Size(568, 170);
            this.gridControlDashboard.TabIndex = 1;
            this.gridControlDashboard.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDashboard});
            // 
            // gridViewDashboard
            // 
            this.gridViewDashboard.GridControl = this.gridControlDashboard;
            this.gridViewDashboard.Name = "gridViewDashboard";
            this.gridViewDashboard.OptionsBehavior.Editable = false;
            this.gridViewDashboard.OptionsView.ColumnAutoWidth = false;
            this.gridViewDashboard.OptionsView.ShowGroupPanel = false;
            // 
            // contextMenuDashBoard
            // 
            this.contextMenuDashBoard.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsNew,
            this.cmsEdit,
            this.cmsView,
            this.cmsRefresh,
            this.toolStripSeparator1,
            this.cmsExport,
            this.cmsPrint,
            this.cmsPrintPreview,
            this.toolStripSeparator2,
            this.cmsClose});
            this.contextMenuDashBoard.Name = "contextMenuDashBoard";
            this.contextMenuDashBoard.Size = new System.Drawing.Size(153, 214);
            // 
            // cmsNew
            // 
            this.cmsNew.Name = "cmsNew";
            this.cmsNew.Size = new System.Drawing.Size(152, 22);
            this.cmsNew.Tag = "cmsNew";
            this.cmsNew.Text = "New";
            // 
            // cmsEdit
            // 
            this.cmsEdit.Name = "cmsEdit";
            this.cmsEdit.Size = new System.Drawing.Size(152, 22);
            this.cmsEdit.Tag = "cmsEdit";
            this.cmsEdit.Text = "Edit";
            // 
            // cmsView
            // 
            this.cmsView.Name = "cmsView";
            this.cmsView.Size = new System.Drawing.Size(152, 22);
            this.cmsView.Tag = "cmsView";
            this.cmsView.Text = "View";
            // 
            // cmsRefresh
            // 
            this.cmsRefresh.Name = "cmsRefresh";
            this.cmsRefresh.Size = new System.Drawing.Size(152, 22);
            this.cmsRefresh.Tag = "cmsRefresh";
            this.cmsRefresh.Text = "Refresh";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // cmsExport
            // 
            this.cmsExport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectedOnlyToolStripMenuItem,
            this.allToolStripMenuItem});
            this.cmsExport.Name = "cmsExport";
            this.cmsExport.Size = new System.Drawing.Size(152, 22);
            this.cmsExport.Tag = "cmsExport";
            this.cmsExport.Text = "Export";
            // 
            // selectedOnlyToolStripMenuItem
            // 
            this.selectedOnlyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SOHTML,
            this.SOCSV,
            this.SOMS7,
            this.SOMS,
            this.SORTF,
            this.SOPDF,
            this.SOMHT,
            this.SOText});
            this.selectedOnlyToolStripMenuItem.Name = "selectedOnlyToolStripMenuItem";
            this.selectedOnlyToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.selectedOnlyToolStripMenuItem.Text = "Selected Only";
            // 
            // SOHTML
            // 
            this.SOHTML.Name = "SOHTML";
            this.SOHTML.Size = new System.Drawing.Size(206, 22);
            this.SOHTML.Tag = "HTML Documents|*.html";
            this.SOHTML.Text = "HTML Document";
            // 
            // SOCSV
            // 
            this.SOCSV.Name = "SOCSV";
            this.SOCSV.Size = new System.Drawing.Size(206, 22);
            this.SOCSV.Tag = "CSV files (*.csv)|*.csv";
            this.SOCSV.Text = "CSV Document";
            // 
            // SOMS7
            // 
            this.SOMS7.Name = "SOMS7";
            this.SOMS7.Size = new System.Drawing.Size(206, 22);
            this.SOMS7.Tag = "Microsoft Excel|*.xlsx";
            this.SOMS7.Text = "MS Excel 2007 Document";
            // 
            // SOMS
            // 
            this.SOMS.Name = "SOMS";
            this.SOMS.Size = new System.Drawing.Size(206, 22);
            this.SOMS.Tag = "Microsoft Excel|*.xls";
            this.SOMS.Text = "MS Excel Doument";
            // 
            // SORTF
            // 
            this.SORTF.Name = "SORTF";
            this.SORTF.Size = new System.Drawing.Size(206, 22);
            this.SORTF.Tag = "RTF Files|*.rtf";
            this.SORTF.Text = "RTF Document";
            // 
            // SOPDF
            // 
            this.SOPDF.Name = "SOPDF";
            this.SOPDF.Size = new System.Drawing.Size(206, 22);
            this.SOPDF.Tag = "PDF Files|*.pdf";
            this.SOPDF.Text = "PDF Document";
            // 
            // SOMHT
            // 
            this.SOMHT.Name = "SOMHT";
            this.SOMHT.Size = new System.Drawing.Size(206, 22);
            this.SOMHT.Tag = "MHT Files|*.mht";
            this.SOMHT.Text = "MHT Document";
            // 
            // SOText
            // 
            this.SOText.Name = "SOText";
            this.SOText.Size = new System.Drawing.Size(206, 22);
            this.SOText.Tag = "Text Files|*.txt";
            this.SOText.Text = "Text Document";
            // 
            // allToolStripMenuItem
            // 
            this.allToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AHTML,
            this.ACSV,
            this.AMS7,
            this.AMS,
            this.ARTF,
            this.APDF,
            this.AMHT,
            this.AText});
            this.allToolStripMenuItem.Name = "allToolStripMenuItem";
            this.allToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.allToolStripMenuItem.Text = "All";
            // 
            // AHTML
            // 
            this.AHTML.Name = "AHTML";
            this.AHTML.Size = new System.Drawing.Size(206, 22);
            this.AHTML.Tag = "HTML Documents|*.html";
            this.AHTML.Text = "HTML Document";
            // 
            // ACSV
            // 
            this.ACSV.Name = "ACSV";
            this.ACSV.Size = new System.Drawing.Size(206, 22);
            this.ACSV.Tag = "CSV files (*.csv)|*.csv";
            this.ACSV.Text = "CSV Document";
            // 
            // AMS7
            // 
            this.AMS7.Name = "AMS7";
            this.AMS7.Size = new System.Drawing.Size(206, 22);
            this.AMS7.Tag = "Microsoft Excel|*.xlsx";
            this.AMS7.Text = "MS Excel 2007 Document";
            // 
            // AMS
            // 
            this.AMS.Name = "AMS";
            this.AMS.Size = new System.Drawing.Size(206, 22);
            this.AMS.Tag = "Microsoft Excel|*.xls";
            this.AMS.Text = "MS Excel Doument";
            // 
            // ARTF
            // 
            this.ARTF.Name = "ARTF";
            this.ARTF.Size = new System.Drawing.Size(206, 22);
            this.ARTF.Tag = "RTF Files|*.rtf";
            this.ARTF.Text = "RTF Document";
            // 
            // APDF
            // 
            this.APDF.Name = "APDF";
            this.APDF.Size = new System.Drawing.Size(206, 22);
            this.APDF.Tag = "PDF Files|*.pdf";
            this.APDF.Text = "PDF Document";
            // 
            // AMHT
            // 
            this.AMHT.Name = "AMHT";
            this.AMHT.Size = new System.Drawing.Size(206, 22);
            this.AMHT.Tag = "MHT Files|*.mht";
            this.AMHT.Text = "MHT Document";
            // 
            // AText
            // 
            this.AText.Name = "AText";
            this.AText.Size = new System.Drawing.Size(206, 22);
            this.AText.Tag = "Text Files|*.txt";
            this.AText.Text = "Text Document";
            // 
            // cmsPrint
            // 
            this.cmsPrint.Name = "cmsPrint";
            this.cmsPrint.Size = new System.Drawing.Size(152, 22);
            this.cmsPrint.Tag = "cmsPrint";
            this.cmsPrint.Text = "Print";
            // 
            // cmsPrintPreview
            // 
            this.cmsPrintPreview.Name = "cmsPrintPreview";
            this.cmsPrintPreview.Size = new System.Drawing.Size(152, 22);
            this.cmsPrintPreview.Tag = "cmsPrintPreview";
            this.cmsPrintPreview.Text = "Print Preview";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
            this.toolStripSeparator2.Visible = false;
            // 
            // cmsClose
            // 
            this.cmsClose.Name = "cmsClose";
            this.cmsClose.Size = new System.Drawing.Size(152, 22);
            this.cmsClose.Tag = "cmsClose";
            this.cmsClose.Text = "Close";
            this.cmsClose.Visible = false;
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.Panel2;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.gridControlDashboard);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(568, 261);
            this.splitContainerControl1.SplitterPosition = 86;
            this.splitContainerControl1.TabIndex = 2;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 261);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "frmDashboard";
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDashboard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDashboard)).EndInit();
            this.contextMenuDashBoard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ContextMenuStrip contextMenuDashBoard;
        private System.Windows.Forms.ToolStripMenuItem cmsNew;
        private System.Windows.Forms.ToolStripMenuItem cmsEdit;
        private System.Windows.Forms.ToolStripMenuItem cmsView;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem cmsExport;
        private System.Windows.Forms.ToolStripMenuItem selectedOnlyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SOHTML;
        private System.Windows.Forms.ToolStripMenuItem SOCSV;
        private System.Windows.Forms.ToolStripMenuItem SOMS7;
        private System.Windows.Forms.ToolStripMenuItem SOMS;
        private System.Windows.Forms.ToolStripMenuItem SORTF;
        private System.Windows.Forms.ToolStripMenuItem SOPDF;
        private System.Windows.Forms.ToolStripMenuItem SOMHT;
        private System.Windows.Forms.ToolStripMenuItem SOText;
        private System.Windows.Forms.ToolStripMenuItem allToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AHTML;
        private System.Windows.Forms.ToolStripMenuItem ACSV;
        private System.Windows.Forms.ToolStripMenuItem AMS7;
        private System.Windows.Forms.ToolStripMenuItem AMS;
        private System.Windows.Forms.ToolStripMenuItem ARTF;
        private System.Windows.Forms.ToolStripMenuItem APDF;
        private System.Windows.Forms.ToolStripMenuItem AMHT;
        private System.Windows.Forms.ToolStripMenuItem AText;
        private System.Windows.Forms.ToolStripMenuItem cmsPrint;
        private System.Windows.Forms.ToolStripMenuItem cmsPrintPreview;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        public System.Windows.Forms.ToolStripMenuItem cmsClose;
        public DevExpress.XtraGrid.GridControl gridControlDashboard;
        public DevExpress.XtraGrid.Views.Grid.GridView gridViewDashboard;
        public System.Windows.Forms.ToolStripMenuItem cmsRefresh;
        public DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
    }
}