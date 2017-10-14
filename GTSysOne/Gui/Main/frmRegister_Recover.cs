namespace GTSysOne.Gui.Main
{
    public partial class frmRegister_Recover : DevExpress.XtraEditors.XtraForm
    {
        public int Choices = 3;
        public frmRegister_Recover()
        {
            InitializeComponent();
            this.btnRegister.Click += new System.EventHandler(this.CLICK);
            this.btnRecover.Click += new System.EventHandler(this.CLICK);
            this.btnCancel.Click += new System.EventHandler(this.CLICK);
        }
        private void CLICK(object sender, System.EventArgs e)
        {
            DevExpress.XtraEditors.SimpleButton b = sender as DevExpress.XtraEditors.SimpleButton;
            switch (b.Name)
            {
                case "btnRegister":
                    Choices = 1;
                    break;
                case "btnRecover":
                    Choices = 2;
                    break;
                case "btnCancel":
                    Choices = 3;
                    break;
            }
            this.Close();
        }
    }
}