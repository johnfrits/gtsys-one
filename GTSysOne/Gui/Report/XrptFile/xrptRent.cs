
namespace GTSysOne.Gui.Report.XrptFile
{
    public partial class xrptRent : DevExpress.XtraReports.UI.XtraReport
    {
        private System.Data.DataSet p_DATASET = null;
        public System.Data.DataSet DATASET
        {
            get
            {
                return p_DATASET;
            }
            set
            {
                this.p_DATASET = value;
                System.Data.DataSet sDATASET = new System.Data.DataSet();
                sDATASET = this.p_DATASET;
                sDATASET.EnforceConstraints = false;
                sDATASET.DataSetName = "DS";
                sDATASET.Tables[0].TableName = "dtent";
                GTSysOne.Class.Utility.clsUtility.BUILDRELATIONSHIP(ref sDATASET, 1, "dtRentDetails", "dtRent_dtRentDetails", "id", "id");
                this.DataSource = sDATASET;
                //this.DataAdapter = modGlobal.modGlobal.Instance().Global_DataAdapter;
                this.DataMember = sDATASET.Tables[0].TableName;
            }
        }
        public xrptRent()
        {
            InitializeComponent();
            //if (System.IO.File.Exists(GTSysOne.Class.Utility.clsGlobal.Instance().CompanyLogo))
            //{  
            //    this.xrCompanyLogo.Image = new System.Drawing.Bitmap(GTSysOne.Class.Utility.clsUtility.LoadDisposableImage(GTSysOne.Class.Utility.clsGlobal.Instance().CompanyLogo));
            //}
            this.Parameters["CompanyName"].Value = "";// GTSysOne.Class.Utility.clsGlobal.Instance().CompanyName;
            this.Parameters["Address"].Value = "";// GTSysOne.Class.Utility.clsGlobal.Instance().CompanyAddress;
            this.Parameters["Website"].Value = "";// GTSysOne.Class.Utility.clsGlobal.Instance().CompanyWebsite;
            this.Parameters["Telephone"].Value = "";//GTSysOne.Class.Utility.clsGlobal.Instance().CompanyTelephone;
            this.Parameters["Email"].Value = "";// GTSysOne.Class.Utility.clsGlobal.Instance().CompanyEmail;
            this.Parameters["Owner"].Value = "";// GTSysOne.Class.Utility.clsGlobal.Instance().CompanyOwner;

            /// diri ang logo ana
            /// 
            //pag merge diri sa server naa na siyay log, once naay picture box
        }

    }
}
