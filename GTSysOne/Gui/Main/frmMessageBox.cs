namespace GTSysOne.Gui.Main
{
    public partial class frmMessageBox : DevExpress.XtraEditors.XtraForm
    {
        public System.Windows.Forms.DialogResult DR;
        GTSysOne.Class.Utility.clsGlobal.enMessageBoxButton bB;
        GTSysOne.Class.Utility.clsGlobal.enMessageBoxIcon iI;
        bool HasSelected = false;
        public frmMessageBox(string[] ErrorList,GTSysOne.Class.Utility.clsGlobal.enMessageBoxButton B,GTSysOne.Class.Utility.clsGlobal.enMessageBoxIcon I,string Header = "Error")
        {
            InitializeComponent();
            bB = B;
            iI = I;
            this.btnNo.Click += new System.EventHandler(this.CLICK);
            this.btnOK.Click += new System.EventHandler(this.CLICK);
            this.btnYes.Click += new System.EventHandler(this.CLICK);
            this.btnCancel.Click += new System.EventHandler(this.CLICK);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CLOSING);
            this.trError.NodeMouseHover += new System.Windows.Forms.TreeNodeMouseHoverEventHandler(this.NODE_MOUSEHOVER);
            this.lblHeader.Text = Header;
            this.trError.Nodes.Add("Parent", Header);
            for (int ctr = 0; ctr < ErrorList.Length;ctr++)
            {
                this.trError.Nodes["Parent"].Nodes.Add(ErrorList[ctr]);
            }
            this.trError.ExpandAll();  
            if (B == GTSysOne.Class.Utility.clsGlobal.enMessageBoxButton.OK)
            {
                this.btnOK.Location = this.btnNo.Location;
                this.btnYes.Visible = false;
                this.btnCancel.Visible = false;
                this.btnNo.Visible = false;
            }
            else if (B == GTSysOne.Class.Utility.clsGlobal.enMessageBoxButton.YesNo)
            {
                this.btnYes.Location = this.btnCancel.Location;
                this.btnOK.Visible = false;
                this.btnCancel.Visible = false;
            }
            else if (B == GTSysOne.Class.Utility.clsGlobal.enMessageBoxButton.YesNoCancel)
            {
                this.btnOK.Visible = false;
            }
            this.pctrIcons.Image = this.imgIcons32.Images[System.Convert.ToString(I)+".png"];
        }
        private void CLICK(object sender, System.EventArgs e)
        {
            DevExpress.XtraEditors.SimpleButton btn = sender as DevExpress.XtraEditors.SimpleButton;
            switch(btn.Name)
            {
                case "btnYes":
                    DR = System.Windows.Forms.DialogResult.Yes;
                    HasSelected = true;
                    break;
                case "btnCancel":
                    DR = System.Windows.Forms.DialogResult.Cancel;
                    HasSelected = true;
                    break;
                case "btnOK":
                    DR = System.Windows.Forms.DialogResult.OK;
                    HasSelected = true;
                    break;
                case "btnNo":
                    DR = System.Windows.Forms.DialogResult.No;
                    HasSelected = true;
                    break;
            }
            this.Close();
        }
        private void CLOSING(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            if(HasSelected == false)
            {
                e.Cancel = true;
            }
        }
        private void NODE_MOUSEHOVER(object sender, System.Windows.Forms.TreeNodeMouseHoverEventArgs e)
        {
            this.txtDetails.Text = e.Node.Text;
        }
    }
}