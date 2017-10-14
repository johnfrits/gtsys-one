namespace GTSysOne.Gui.Main
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        #region VARIABLE
        bool NavSelected = false;
        #endregion

        #region CONSTRUCTOR
        private static frmMain p_instance = null;
        public static frmMain Instance
        {
            get
            {
                if (p_instance == null) p_instance = new frmMain();
                p_instance.BringToFront();
                return p_instance;
            }
        }
        protected frmMain()
        {
            InitializeComponent();
            this.ribbon.Minimized = true;
            this.Shown += new System.EventHandler(this.SHOWNFORM);    
        }
        #endregion

        public static void FUNCTION_CLICKED(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Instance.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            Instance.NavSelected = true;
            Instance.FunctionCall(System.Convert.ToInt32(e.Link.Item.Tag));
            Instance.btnFunctions.EditValue = System.Convert.ToInt32(e.Link.Item.Tag);
            Instance.NavSelected = false;
            Instance.Cursor = System.Windows.Forms.Cursors.Default;
        }
        private void Functions(object sender, System.EventArgs e)
        {
            if (Instance.NavSelected == false)
            {
                Instance.FunctionCall(System.Convert.ToInt32((sender as DevExpress.XtraEditors.BaseEdit).EditValue));
            }
        }
        private void FunctionCall(int F)
        {
            switch (F)
            {
                case 7:
                    GTSysOne.Class.Utility.clsUtility.AddTab(Instance.xtraTabControlMain, GTSysOne.Gui.Dashboard.Document.frmUser.Instance, System.Convert.ToString(F), Instance.imgFunctionIcon16, F);
                    break;
                case 3://diri i load ang dashboard
                    GTSysOne.Class.Utility.clsUtility.AddTab(Instance.xtraTabControlMain, GTSysOne.Gui.Dashboard.Document.frmCompany.Instance, System.Convert.ToString(F), Instance.imgFunctionIcon16, F);
                    break;
                case 6:
                    GTSysOne.Gui.Main.frmLicense.Instance.ShowDialog(Instance);
                    if (GTSysOne.Class.Utility.clsGlobal.Instance().LogOut)
                    {
                        Instance.Close();
                    }
                    break;
                case 1:
                    GTSysOne.Class.Utility.clsUtility.AddTab(Instance.xtraTabControlMain, GTSysOne.Gui.Dashboard.Document.frmNumberingSetup.Instance, System.Convert.ToString(F), Instance.imgFunctionIcon16, F);
                    break;
                case 4:
                    GTSysOne.Class.Utility.clsUtility.AddTab(Instance.xtraTabControlMain, GTSysOne.Gui.Dashboard.Document.frmCountry.Instance, System.Convert.ToString(F), Instance.imgFunctionIcon16, F);
                    break;
                case 12:
                    GTSysOne.Class.Utility.clsUtility.AddTab(Instance.xtraTabControlMain, GTSysOne.Gui.Dashboard.MasterFile.frmStation.Instance, System.Convert.ToString(F), Instance.imgFunctionIcon16, F);
                    break;
                case 8:
                    GTSysOne.Class.Utility.clsUtility.AddTab(Instance.xtraTabControlMain, GTSysOne.Gui.Dashboard.MasterFile.frmAllocationPattern.Instance, System.Convert.ToString(F), Instance.imgFunctionIcon16, F);
                    break;
                case 2:
                    GTSysOne.Class.Utility.clsUtility.AddTab(Instance.xtraTabControlMain, GTSysOne.Gui.Dashboard.MasterFile.frmGroup.Instance, System.Convert.ToString(F), Instance.imgFunctionIcon16, F);
                    break;
                case 14:
                    GTSysOne.Class.Utility.clsUtility.AddTab(Instance.xtraTabControlMain, GTSysOne.Gui.Dashboard.MasterFile.frmRegion.Instance, System.Convert.ToString(F), Instance.imgFunctionIcon16, F);
                    break;
                case 15:
                    GTSysOne.Class.Utility.clsUtility.AddTab(Instance.xtraTabControlMain, GTSysOne.Gui.Dashboard.MasterFile.frmPriceLevel.Instance, System.Convert.ToString(F), Instance.imgFunctionIcon16, F);
                    break;
                case 16:
                    GTSysOne.Class.Utility.clsUtility.AddTab(Instance.xtraTabControlMain, GTSysOne.Gui.Dashboard.MasterFile.frmTaxArea.Instance, System.Convert.ToString(F), Instance.imgFunctionIcon16, F);
                    break;
                case 10:
                    GTSysOne.Class.Utility.clsUtility.AddTab(Instance.xtraTabControlMain, GTSysOne.Gui.Dashboard.MasterFile.frmEstablishment.Instance, System.Convert.ToString(F), Instance.imgFunctionIcon16, F);
                    break;
                case 20000:
                    GTSysOne.Class.Utility.clsUtility.AddTab(Instance.xtraTabControlMain, GTSysOne.Gui.Dashboard.Document.frmSalesQuotation.Instance, System.Convert.ToString(F), Instance.imgFunctionIcon16, F);
                    break;
                case 20001:
                    GTSysOne.Class.Utility.clsUtility.AddTab(Instance.xtraTabControlMain, GTSysOne.Gui.Dashboard.Document.frmSalesOrder.Instance, System.Convert.ToString(F), Instance.imgFunctionIcon16, F);
                    break;
                //Created by: Johnfrits Rejaba
                //Date: August 22, 2017
                //Identity Type
                case 70000:
                    GTSysOne.Class.Utility.clsUtility.AddTab(Instance.xtraTabControlMain, GTSysOne.Gui.Dashboard.MasterFile.frmIdentityType.Instance, System.Convert.ToString(F), Instance.imgFunctionIcon16, F);
                    break;
                //Created by: Johnfrits Rejaba
                //Date: August 22, 2017
                //Car Model
                case 70001:
                    GTSysOne.Class.Utility.clsUtility.AddTab(Instance.xtraTabControlMain, GTSysOne.Gui.Dashboard.MasterFile.frmCarModel.Instance, System.Convert.ToString(F), Instance.imgFunctionIcon16, F);
                    break;
                //Created by: Johnfrits Rejaba
                //Date: August 24, 2017
                //Car Color
                case 70002:
                    GTSysOne.Class.Utility.clsUtility.AddTab(Instance.xtraTabControlMain, GTSysOne.Gui.Dashboard.MasterFile.frmCarColor.Instance, System.Convert.ToString(F), Instance.imgFunctionIcon16, F);
                    break;
                //Created by: Johnfrits Rejaba
                //Date: August 24, 2017
                //Car Type
                case 70003:
                    GTSysOne.Class.Utility.clsUtility.AddTab(Instance.xtraTabControlMain, GTSysOne.Gui.Dashboard.MasterFile.frmCarType.Instance, System.Convert.ToString(F), Instance.imgFunctionIcon16, F);
                    break;
                //Created by: Johnfrits Rejaba
                //Date: August 24, 2017
                //Car Type
                case 70004:
                    GTSysOne.Class.Utility.clsUtility.AddTab(Instance.xtraTabControlMain, GTSysOne.Gui.Dashboard.Document.frmRent.Instance, System.Convert.ToString(F), Instance.imgFunctionIcon16, F);
                    break;

            }
        }

        private void PAGEADD(GTSysOne.Class.Utility.clsGlobal.myFunction Function)
        {
            this.ribbon.Pages.Clear();
            DevExpress.XtraBars.Ribbon.RibbonPage P = null;
            if (this.PAGENOTEXIST(System.Convert.ToString(Function)))
            {
                switch (Function)
                {
                    case GTSysOne.Class.Utility.clsGlobal.myFunction.User:
                        this.PAGE(Function, System.Convert.ToString((int)Function) + "*User", P, "User");
                        break;
                    case GTSysOne.Class.Utility.clsGlobal.myFunction.Company:
                        this.PAGE(Function, System.Convert.ToString((int)Function) + "*Company", P, "Company");
                        break;
                    case GTSysOne.Class.Utility.clsGlobal.myFunction.NumberingSetup:
                        this.PAGE(Function, System.Convert.ToString((int)Function) + "*NumberingSetup", P, "NumberingSetup");
                        break;
                    case GTSysOne.Class.Utility.clsGlobal.myFunction.Country:
                        this.PAGE(Function, System.Convert.ToString((int)Function) + "*Country", P, "Country");
                        break;
                    case GTSysOne.Class.Utility.clsGlobal.myFunction.Station:
                        this.PAGE(Function, System.Convert.ToString((int)Function) + "*Station", P, "Station");
                        break;
                    case GTSysOne.Class.Utility.clsGlobal.myFunction.AllocationPattern:
                        this.PAGE(Function, System.Convert.ToString((int)Function) + "*AllocationPattern", P, "AllocationPattern");
                        break;
                    case GTSysOne.Class.Utility.clsGlobal.myFunction.Group:
                        this.PAGE(Function, System.Convert.ToString((int)Function) + "*Group", P, "Group");
                        break;
                    case GTSysOne.Class.Utility.clsGlobal.myFunction.Region:
                        this.PAGE(Function, System.Convert.ToString((int)Function) + "*Region", P, "Region");
                        break;
                    case GTSysOne.Class.Utility.clsGlobal.myFunction.PriceLevel:
                        this.PAGE(Function, System.Convert.ToString((int)Function) + "*PriceLevel", P, "PriceLevel");
                        break;
                    case GTSysOne.Class.Utility.clsGlobal.myFunction.TaxArea:
                        this.PAGE(Function, System.Convert.ToString((int)Function) + "*TaxArea", P, "TaxArea");
                        break;
                    case GTSysOne.Class.Utility.clsGlobal.myFunction.Establishment:
                        this.PAGE(Function, System.Convert.ToString((int)Function) + "*Establishment", P, "Establishment");
                        break;
                    case GTSysOne.Class.Utility.clsGlobal.myFunction.SalesQuotation:
                        this.PAGE(Function, System.Convert.ToString((int)Function) + "*SalesQuotation", P, "SalesQuotation");
                        break;
                    case GTSysOne.Class.Utility.clsGlobal.myFunction.SalesOrder:
                        this.PAGE(Function, System.Convert.ToString((int)Function) + "*SalesOrder", P, "SalesOrder");
                        break;
                    //Created by: Johnfrits Rejaba
                    //Date: August 22, 2017
                    //Identity Type
                    case GTSysOne.Class.Utility.clsGlobal.myFunction.IdentityType:
                        this.PAGE(Function, System.Convert.ToString((int)Function) + "*IdentityType", P, "IdentityType");
                        break;
                    //Created by: Johnfrits Rejaba
                    //Date: August 23, 2017
                    //Car Model
                    case GTSysOne.Class.Utility.clsGlobal.myFunction.CarModel:
                        this.PAGE(Function, System.Convert.ToString((int)Function) + "*CarModel", P, "CarModel");
                        break;
                    //Created by: Johnfrits Rejaba
                    //Date: August 24, 2017
                    //Car Color
                    case GTSysOne.Class.Utility.clsGlobal.myFunction.CarColor:
                        this.PAGE(Function, System.Convert.ToString((int)Function) + "*CarColor", P, "CarColor");
                        break;
                    //Created by: Johnfrits Rejaba
                    //Date: August 24, 2017
                    //Car Type
                    case GTSysOne.Class.Utility.clsGlobal.myFunction.CarType:
                        this.PAGE(Function, System.Convert.ToString((int)Function) + "*CarType", P, "CarType");
                        break;
                    //Created by: Johnfrits Rejaba
                    //Date: August 24, 2017
                    //Rent
                    case GTSysOne.Class.Utility.clsGlobal.myFunction.Rent:
                        this.PAGE(Function, System.Convert.ToString((int)Function) + "*Rent", P, "Rent");
                        break;
                    //Created by: Johnfrits Rejaba
                    //Date: August 24, 2017
                    //Fixed Assets
                    case GTSysOne.Class.Utility.clsGlobal.myFunction.FixedAssets:
                        this.PAGE(Function, System.Convert.ToString((int)Function) + "*FixedAssets", P, "FixedAssets");
                        break;
                }
                this.GROUPADD(Function, (int)Function);
            }
            else
            {
                P = new DevExpress.XtraBars.Ribbon.RibbonPage();
                P.Name = System.Convert.ToString((int)Function);
                this.ribbon.SelectedPage = P;
            }
            this.STATUS(Function);
        }
        private void GROUPADD(GTSysOne.Class.Utility.clsGlobal.myFunction Function,int Tag)
        {
            switch (Function)
            {
                case GTSysOne.Class.Utility.clsGlobal.myFunction.User:
                    #region
                    if (GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_Add_User || GTSysOne.Class.Utility.clsGlobal.Instance().Admin)
                    {
                        this.GROUP(System.Convert.ToString(Function), System.Convert.ToString(Tag) + "*New", "New", new string[] { "New" }, 0);
                    }

                    if (GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_Edit_User || GTSysOne.Class.Utility.clsGlobal.Instance().Admin)
                    {
                        this.GROUP(System.Convert.ToString(Function), System.Convert.ToString(Tag) + "*Edit", "Edit", new string[] { "Edit" }, 0);
                    }

                    if (GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_View_User || GTSysOne.Class.Utility.clsGlobal.Instance().Admin)
                    {
                        this.GROUP(System.Convert.ToString(Function), System.Convert.ToString(Tag) + "*View", "View", new string[] { "View" }, 0);
                    }

                    this.GROUP(System.Convert.ToString(Function), System.Convert.ToString(Tag) + "*Refresh", "Refresh", new string[] { "Refresh" }, 1);

                    this.GROUP(System.Convert.ToString(Function), System.Convert.ToString(Tag) + "*Search", "Search", new string[] { "Search" }, 2);
                    #endregion
                    break;
                case GTSysOne.Class.Utility.clsGlobal.myFunction.Company:
                    #region
                    if (GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_Add_Company) ///diri magamit ang global na security kato gehimo nato
                    {
                        this.GROUP(System.Convert.ToString(Function), System.Convert.ToString(Tag) + "*New", "New", new string[] { "New" }, 0);
                    }
                    //mao ni mag create ug button sa top new,EditView
                    if (GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_Edit_Company)
                    {
                        this.GROUP(System.Convert.ToString(Function), System.Convert.ToString(Tag) + "*Edit", "Edit", new string[] { "Edit" }, 0);
                    }

                    if (GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_View_Company)
                    {
                        this.GROUP(System.Convert.ToString(Function), System.Convert.ToString(Tag) + "*View", "View", new string[] { "View" }, 0);
                    }

                    this.GROUP(System.Convert.ToString(Function), System.Convert.ToString(Tag) + "*Refresh", "Refresh", new string[] { "Refresh" }, 1);

                    this.GROUP(System.Convert.ToString(Function), System.Convert.ToString(Tag) + "*Search", "Search", new string[] { "Search" }, 2);
                    #endregion
                    break;
                case GTSysOne.Class.Utility.clsGlobal.myFunction.NumberingSetup:
                    #region
                    if (GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_Add_NumberingSetup)
                    {
                        this.GROUP(System.Convert.ToString(Function), System.Convert.ToString(Tag) + "*New", "New", new string[] { "New" }, 0);
                    }

                    if (GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_Edit_NumberingSetup)
                    {
                        this.GROUP(System.Convert.ToString(Function), System.Convert.ToString(Tag) + "*Edit", "Edit", new string[] { "Edit" }, 0);
                    }

                    if (GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_View_NumberingSetup)
                    {
                        this.GROUP(System.Convert.ToString(Function), System.Convert.ToString(Tag) + "*View", "View", new string[] { "View" }, 0);
                    }

                    this.GROUP(System.Convert.ToString(Function), System.Convert.ToString(Tag) + "*Refresh", "Refresh", new string[] { "Refresh" }, 1);

                    this.GROUP(System.Convert.ToString(Function), System.Convert.ToString(Tag) + "*Search", "Search", new string[] { "Search" }, 2);
                    #endregion
                    break;
                case GTSysOne.Class.Utility.clsGlobal.myFunction.Country:
                    #region
                    if (GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_Add_Country)
                    {
                        this.GROUP(System.Convert.ToString(Function), System.Convert.ToString(Tag) + "*New", "New", new string[] { "New" }, 0);
                    }

                    if (GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_Edit_Country)
                    {
                        this.GROUP(System.Convert.ToString(Function), System.Convert.ToString(Tag) + "*Edit", "Edit", new string[] { "Edit" }, 0);
                    }

                    if (GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_View_Country)
                    {
                        this.GROUP(System.Convert.ToString(Function), System.Convert.ToString(Tag) + "*View", "View", new string[] { "View" }, 0);
                    }

                    this.GROUP(System.Convert.ToString(Function), System.Convert.ToString(Tag) + "*Refresh", "Refresh", new string[] { "Refresh" }, 1);

                    this.GROUP(System.Convert.ToString(Function), System.Convert.ToString(Tag) + "*Search", "Search", new string[] { "Search" }, 2);
                    #endregion
                    break;
                case GTSysOne.Class.Utility.clsGlobal.myFunction.Station:
                    #region
                    if (GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_Add_Station)
                    {
                        this.GROUP(System.Convert.ToString(Function), System.Convert.ToString(Tag) + "*New", "New", new string[] { "New" }, 0);
                    }

                    if (GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_Edit_Station)
                    {
                        this.GROUP(System.Convert.ToString(Function), System.Convert.ToString(Tag) + "*Edit", "Edit", new string[] { "Edit" }, 0);
                    }

                    if (GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_View_Station)
                    {
                        this.GROUP(System.Convert.ToString(Function), System.Convert.ToString(Tag) + "*View", "View", new string[] { "View" }, 0);
                    }

                    this.GROUP(System.Convert.ToString(Function), System.Convert.ToString(Tag) + "*Refresh", "Refresh", new string[] { "Refresh" }, 1);

                    this.GROUP(System.Convert.ToString(Function), System.Convert.ToString(Tag) + "*Search", "Search", new string[] { "Search" }, 2);
                    #endregion
                    break;
                case GTSysOne.Class.Utility.clsGlobal.myFunction.AllocationPattern:
                    #region
                    if (GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_Add_Allocation_Pattern)
                    {
                        this.GROUP(System.Convert.ToString(Function), System.Convert.ToString(Tag) + "*New", "New", new string[] { "New" }, 0);
                    }

                    if (GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_Edit_Allocation_Pattern)
                    {
                        this.GROUP(System.Convert.ToString(Function), System.Convert.ToString(Tag) + "*Edit", "Edit", new string[] { "Edit" }, 0);
                    }

                    if (GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_View_Allocation_Pattern)
                    {
                        this.GROUP(System.Convert.ToString(Function), System.Convert.ToString(Tag) + "*View", "View", new string[] { "View" }, 0);
                    }

                    this.GROUP(System.Convert.ToString(Function), System.Convert.ToString(Tag) + "*Refresh", "Refresh", new string[] { "Refresh" }, 1);

                    this.GROUP(System.Convert.ToString(Function), System.Convert.ToString(Tag) + "*Search", "Search", new string[] { "Search" }, 2);
                    #endregion
                    break;
                case GTSysOne.Class.Utility.clsGlobal.myFunction.Group:
                    #region
                    if (GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_Add_Group)
                    {
                        this.GROUP(System.Convert.ToString(Function), System.Convert.ToString(Tag) + "*New", "New", new string[] { "New" }, 0);
                    }

                    if (GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_Edit_Group)
                    {
                        this.GROUP(System.Convert.ToString(Function), System.Convert.ToString(Tag) + "*Edit", "Edit", new string[] { "Edit" }, 0);
                    }

                    if (GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_View_Group)
                    {
                        this.GROUP(System.Convert.ToString(Function), System.Convert.ToString(Tag) + "*View", "View", new string[] { "View" }, 0);
                    }

                    this.GROUP(System.Convert.ToString(Function), System.Convert.ToString(Tag) + "*Refresh", "Refresh", new string[] { "Refresh" }, 1);

                    this.GROUP(System.Convert.ToString(Function), System.Convert.ToString(Tag) + "*Search", "Search", new string[] { "Search" }, 2);
                    #endregion
                    break;
                case GTSysOne.Class.Utility.clsGlobal.myFunction.Region:
                    #region
                    if (GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_Add_Region)
                    {
                        this.GROUP(System.Convert.ToString(Function), System.Convert.ToString(Tag) + "*New", "New", new string[] { "New" }, 0);
                    }

                    if (GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_Edit_Region)
                    {
                        this.GROUP(System.Convert.ToString(Function), System.Convert.ToString(Tag) + "*Edit", "Edit", new string[] { "Edit" }, 0);
                    }

                    if (GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_View_Region)
                    {
                        this.GROUP(System.Convert.ToString(Function), System.Convert.ToString(Tag) + "*View", "View", new string[] { "View" }, 0);
                    }

                    this.GROUP(System.Convert.ToString(Function), System.Convert.ToString(Tag) + "*Refresh", "Refresh", new string[] { "Refresh" }, 1);

                    this.GROUP(System.Convert.ToString(Function), System.Convert.ToString(Tag) + "*Search", "Search", new string[] { "Search" }, 2);
                    #endregion
                    break;
                case GTSysOne.Class.Utility.clsGlobal.myFunction.PriceLevel:
                    #region
                    if (GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_Add_Price_Level)
                    {
                        this.GROUP(System.Convert.ToString(Function), System.Convert.ToString(Tag) + "*New", "New", new string[] { "New" }, 0);
                    }

                    if (GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_Edit_Price_Level)
                    {
                        this.GROUP(System.Convert.ToString(Function), System.Convert.ToString(Tag) + "*Edit", "Edit", new string[] { "Edit" }, 0);
                    }

                    if (GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_View_Price_Level)
                    {
                        this.GROUP(System.Convert.ToString(Function), System.Convert.ToString(Tag) + "*View", "View", new string[] { "View" }, 0);
                    }

                    this.GROUP(System.Convert.ToString(Function), System.Convert.ToString(Tag) + "*Refresh", "Refresh", new string[] { "Refresh" }, 1);

                    this.GROUP(System.Convert.ToString(Function), System.Convert.ToString(Tag) + "*Search", "Search", new string[] { "Search" }, 2);
                    #endregion
                    break;
                case GTSysOne.Class.Utility.clsGlobal.myFunction.TaxArea:
                    #region
                    if (GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_Add_Tax_Area)
                    {
                        this.GROUP(System.Convert.ToString(Function), System.Convert.ToString(Tag) + "*New", "New", new string[] { "New" }, 0);
                    }

                    if (GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_Edit_Tax_Area)
                    {
                        this.GROUP(System.Convert.ToString(Function), System.Convert.ToString(Tag) + "*Edit", "Edit", new string[] { "Edit" }, 0);
                    }

                    if (GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_View_Tax_Area)
                    {
                        this.GROUP(System.Convert.ToString(Function), System.Convert.ToString(Tag) + "*View", "View", new string[] { "View" }, 0);
                    }

                    this.GROUP(System.Convert.ToString(Function), System.Convert.ToString(Tag) + "*Refresh", "Refresh", new string[] { "Refresh" }, 1);

                    this.GROUP(System.Convert.ToString(Function), System.Convert.ToString(Tag) + "*Search", "Search", new string[] { "Search" }, 2);
                    #endregion
                    break;
                case GTSysOne.Class.Utility.clsGlobal.myFunction.Establishment:
                    #region
                    if (GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_Add_Establishment)
                    {
                        this.GROUP(System.Convert.ToString(Function), System.Convert.ToString(Tag) + "*New", "New", new string[] { "New" }, 0);
                    }

                    if (GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_Edit_Establishment)
                    {
                        this.GROUP(System.Convert.ToString(Function), System.Convert.ToString(Tag) + "*Edit", "Edit", new string[] { "Edit" }, 0);
                    }

                    if (GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_View_Establishment)
                    {
                        this.GROUP(System.Convert.ToString(Function), System.Convert.ToString(Tag) + "*View", "View", new string[] { "View" }, 0);
                    }

                    this.GROUP(System.Convert.ToString(Function), System.Convert.ToString(Tag) + "*Refresh", "Refresh", new string[] { "Refresh" }, 1);

                    this.GROUP(System.Convert.ToString(Function), System.Convert.ToString(Tag) + "*Search", "Search", new string[] { "Search" }, 2);
                    #endregion
                    break;
                case GTSysOne.Class.Utility.clsGlobal.myFunction.SalesQuotation:
                    #region SalesQuotation
                    if (GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_Add_Sales_Quotation)
                        this.GROUP(System.Convert.ToString(Function), System.Convert.ToString(Tag) + "*New", "New", new string[] { "New" }, 0);

                    if (GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_Edit_Sales_Quotation)
                        this.GROUP(System.Convert.ToString(Function), System.Convert.ToString(Tag) + "*Edit", "Edit", new string[] { "Edit" }, 0);

                    if (GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_View_Sales_Quotation)
                        this.GROUP(System.Convert.ToString(Function), System.Convert.ToString(Tag) + "*View", "View", new string[] { "View" }, 0);

                    this.GROUP(System.Convert.ToString(Function), System.Convert.ToString(Tag) + "*Refresh", "Refresh", new string[] { "Refresh" }, 1);

                    this.GROUP(System.Convert.ToString(Function), System.Convert.ToString(Tag) + "*Search", "Search", new string[] { "Search" }, 2);
                    #endregion
                    break;
                case GTSysOne.Class.Utility.clsGlobal.myFunction.SalesOrder:
                    #region SalesOrder
                    if (GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_Add_Sales_Order)
                        this.GROUP(System.Convert.ToString(Function), System.Convert.ToString(Tag) + "*New", "New", new string[] { "New" }, 0);

                    if (GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_Edit_Sales_Order)
                        this.GROUP(System.Convert.ToString(Function), System.Convert.ToString(Tag) + "*Edit", "Edit", new string[] { "Edit" }, 0);

                    if (GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_View_Sales_Order)
                        this.GROUP(System.Convert.ToString(Function), System.Convert.ToString(Tag) + "*View", "View", new string[] { "View" }, 0);

                    this.GROUP(System.Convert.ToString(Function), System.Convert.ToString(Tag) + "*Refresh", "Refresh", new string[] { "Refresh" }, 1);

                    this.GROUP(System.Convert.ToString(Function), System.Convert.ToString(Tag) + "*Search", "Search", new string[] { "Search" }, 2);
                    #endregion
                    break;
                //Created by: Johnfrits Rejaba
                //Date: August 22, 2017
                //Identity Type
                case GTSysOne.Class.Utility.clsGlobal.myFunction.IdentityType:
                    #region IdentityType
                    if (GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_Add_Identity_Type)
                        this.GROUP(System.Convert.ToString(Function), System.Convert.ToString(Tag) + "*New", "New", new string[] { "New" }, 0);

                    if (GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_Edit_Identy_Type)
                        this.GROUP(System.Convert.ToString(Function), System.Convert.ToString(Tag) + "*Edit", "Edit", new string[] { "Edit" }, 0);

                    if (GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_View_Identy_Type)
                        this.GROUP(System.Convert.ToString(Function), System.Convert.ToString(Tag) + "*View", "View", new string[] { "View" }, 0);

                    this.GROUP(System.Convert.ToString(Function), System.Convert.ToString(Tag) + "*Refresh", "Refresh", new string[] { "Refresh" }, 1);

                    this.GROUP(System.Convert.ToString(Function), System.Convert.ToString(Tag) + "*Search", "Search", new string[] { "Search" }, 2);
                    #endregion
                    break;
                //Created by: Johnfrits Rejaba
                //Date: August 23, 2017
                //Car Model
                case GTSysOne.Class.Utility.clsGlobal.myFunction.CarModel:
                    #region Car Model
                    if (GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_Add_Car_Model)
                        this.GROUP(System.Convert.ToString(Function), System.Convert.ToString(Tag) + "*New", "New", new string[] { "New" }, 0);

                    if (GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_Edit_Car_Model)
                        this.GROUP(System.Convert.ToString(Function), System.Convert.ToString(Tag) + "*Edit", "Edit", new string[] { "Edit" }, 0);

                    if (GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_View_Car_Model)
                        this.GROUP(System.Convert.ToString(Function), System.Convert.ToString(Tag) + "*View", "View", new string[] { "View" }, 0);

                    this.GROUP(System.Convert.ToString(Function), System.Convert.ToString(Tag) + "*Refresh", "Refresh", new string[] { "Refresh" }, 1);

                    this.GROUP(System.Convert.ToString(Function), System.Convert.ToString(Tag) + "*Search", "Search", new string[] { "Search" }, 2);
                    #endregion
                    break;
                //Created by: Johnfrits Rejaba
                //Date: August 24, 2017
                //Car Color
                case GTSysOne.Class.Utility.clsGlobal.myFunction.CarColor:
                    #region Car Color
                    if (GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_Add_Car_Color)
                        this.GROUP(System.Convert.ToString(Function), System.Convert.ToString(Tag) + "*New", "New", new string[] { "New" }, 0);

                    if (GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_Edit_Car_Color)
                        this.GROUP(System.Convert.ToString(Function), System.Convert.ToString(Tag) + "*Edit", "Edit", new string[] { "Edit" }, 0);

                    if (GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_View_Car_Color)
                        this.GROUP(System.Convert.ToString(Function), System.Convert.ToString(Tag) + "*View", "View", new string[] { "View" }, 0);

                    this.GROUP(System.Convert.ToString(Function), System.Convert.ToString(Tag) + "*Refresh", "Refresh", new string[] { "Refresh" }, 1);

                    this.GROUP(System.Convert.ToString(Function), System.Convert.ToString(Tag) + "*Search", "Search", new string[] { "Search" }, 2);
                    #endregion
                    break;
                //Created by: Johnfrits Rejaba
                //Date: August 24, 2017
                //Car Color
                case GTSysOne.Class.Utility.clsGlobal.myFunction.CarType:
                    #region Car Type
                    if (GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_Add_Car_Type)
                        this.GROUP(System.Convert.ToString(Function), System.Convert.ToString(Tag) + "*New", "New", new string[] { "New" }, 0);

                    if (GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_Edit_Car_Type)
                        this.GROUP(System.Convert.ToString(Function), System.Convert.ToString(Tag) + "*Edit", "Edit", new string[] { "Edit" }, 0);

                    if (GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_View_Car_Type)
                        this.GROUP(System.Convert.ToString(Function), System.Convert.ToString(Tag) + "*View", "View", new string[] { "View" }, 0);

                    this.GROUP(System.Convert.ToString(Function), System.Convert.ToString(Tag) + "*Refresh", "Refresh", new string[] { "Refresh" }, 1);

                    this.GROUP(System.Convert.ToString(Function), System.Convert.ToString(Tag) + "*Search", "Search", new string[] { "Search" }, 2);
                    #endregion
                    break;
                //Created by: Johnfrits Rejaba
                //Date: August 26, 2017
                //Rent
                case GTSysOne.Class.Utility.clsGlobal.myFunction.Rent:
                    #region Car Type
                    if (GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_Add_Rent)
                        this.GROUP(System.Convert.ToString(Function), System.Convert.ToString(Tag) + "*New", "New", new string[] { "New" }, 0);

                    if (GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_Edit_Rent)
                        this.GROUP(System.Convert.ToString(Function), System.Convert.ToString(Tag) + "*Edit", "Edit", new string[] { "Edit" }, 0);

                    if (GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_View_Rent)
                        this.GROUP(System.Convert.ToString(Function), System.Convert.ToString(Tag) + "*View", "View", new string[] { "View" }, 0);

                    this.GROUP(System.Convert.ToString(Function), System.Convert.ToString(Tag) + "*Refresh", "Refresh", new string[] { "Refresh" }, 1);

                    this.GROUP(System.Convert.ToString(Function), System.Convert.ToString(Tag) + "*Search", "Search", new string[] { "Search" }, 2);
                    #endregion
                    break;
                //Created by: Johnfrits Rejaba
                //Date: August 26, 2017
                //Fixed Assets
                case GTSysOne.Class.Utility.clsGlobal.myFunction.FixedAssets:
                    #region Fixed Assets
                    if (GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_Add_Fixed_Assets)
                        this.GROUP(System.Convert.ToString(Function), System.Convert.ToString(Tag) + "*New", "New", new string[] { "New" }, 0);

                    if (GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_Edit_Fixed_Assets)
                        this.GROUP(System.Convert.ToString(Function), System.Convert.ToString(Tag) + "*Edit", "Edit", new string[] { "Edit" }, 0);

                    if (GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_View_Fixed_Assets)
                        this.GROUP(System.Convert.ToString(Function), System.Convert.ToString(Tag) + "*View", "View", new string[] { "View" }, 0);

                    this.GROUP(System.Convert.ToString(Function), System.Convert.ToString(Tag) + "*Refresh", "Refresh", new string[] { "Refresh" }, 1);

                    this.GROUP(System.Convert.ToString(Function), System.Convert.ToString(Tag) + "*Search", "Search", new string[] { "Search" }, 2);
                    #endregion
                    break;
            }
        }
        private void PAGE(GTSysOne.Class.Utility.clsGlobal.myFunction Function,string sTag,DevExpress.XtraBars.Ribbon.RibbonPage P,string Text)
        {
            P = new DevExpress.XtraBars.Ribbon.RibbonPage();
            P.Tag = sTag;
            P.Name = System.Guid.NewGuid().ToString();
            P.Text = Text;
            this.ribbon.Pages.Add(P);
            this.ribbon.SelectedPage = P;
        }
        private void GROUP(string Page,string sTag,string Group,string[] Button,int EditorType)
        {
            DevExpress.XtraBars.BarButtonItem B = null;
            DevExpress.XtraBars.BarEditItem BE = null;

            DevExpress.XtraBars.Ribbon.RibbonPageGroup PC = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            PC.Name = System.Guid.NewGuid().ToString();
            PC.Tag = sTag;
            PC.Text = Group;

            for(int ctr=0;ctr < Button.Length;ctr++)
            {
                switch(EditorType)
                {
                    case 0://BarButtonitem
                    case 1://BarButtonitem
                        B = new DevExpress.XtraBars.BarButtonItem();
                        B.Name = System.Convert.ToString(System.Guid.NewGuid());
                        B.Tag = sTag;
                        B.Caption = System.Convert.ToString(Button[ctr]);
                        B.LargeGlyph = this.imgFunctionIcon32.Images[System.Convert.ToString(Button[ctr]) + ".png"];
                        B.SmallWithoutTextWidth = 150;
                        B.SmallWithTextWidth = 150;
                        B.LargeWidth = 100;
                        B.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(GTSysOne.Gui.Main.frmMain.BUTTON_ITEMCLICK);
                        PC.ItemLinks.Add(B);
                        break;
                    case 2://BarEditItem
                        BE = new DevExpress.XtraBars.BarEditItem();
                        BE.Name = System.Convert.ToString(System.Guid.NewGuid());
                        BE.Tag = sTag;
                        BE.Caption = System.Convert.ToString(Button[ctr]);
                        BE.SmallWithoutTextWidth = 150;
                        BE.SmallWithTextWidth = 150;
                        DevExpress.XtraEditors.Repository.RepositoryItemSearchControl RISC = new DevExpress.XtraEditors.Repository.RepositoryItemSearchControl();
                        RISC.ShowDefaultButtonsMode = DevExpress.XtraEditors.Repository.ShowDefaultButtonsMode.Always;
                        RISC.Name = System.Convert.ToString(System.Guid.NewGuid());
                        RISC.Tag = sTag;
                        BE.Edit = RISC;
                        BE.Width = 200;
                        RISC.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.SEARCH_PRESSED);
                        PC.ItemLinks.Add(BE);
                        break;
                }
            }

            this.ribbon.Pages[Page].Groups.Add(PC);
        }
        private bool PAGENOTEXIST(string Name)
        {
            bool No = true;
            for (int ctr = 0; ctr < this.ribbon.Pages.Count;ctr++)
            {
                if(this.ribbon.Pages[ctr].Name == Name)
                {
                    No = false;
                }
            }
            return No;
        }
        private void STATUS(GTSysOne.Class.Utility.clsGlobal.myFunction Function)
        {
            this.accordionControlStatus.Elements.Clear();
            DevExpress.XtraBars.Navigation.AccordionControlElement AG = null;
            DevExpress.XtraBars.Navigation.AccordionControlElement AI = null;
            switch(Function)
            {
                case GTSysOne.Class.Utility.clsGlobal.myFunction.User:
                    System.Data.DataTable dtUser = GTSysOne.Class.Document.clsDoc_User.ShowTable(GTSysOne.Class.Document.clsDoc_User.Value(0, 6));

                    AG = new DevExpress.XtraBars.Navigation.AccordionControlElement();
                    AG.Style = DevExpress.XtraBars.Navigation.ElementStyle.Group;
                
                    AG.Text = "Total User - " + System.Convert.ToInt32(dtUser.Rows[0]["Total"]);

                    AI = new DevExpress.XtraBars.Navigation.AccordionControlElement();
                    AI.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
                    AI.Text = "Active - " + dtUser.Rows[1]["Total"];
                    AG.Elements.Add(AI);

                    AI = new DevExpress.XtraBars.Navigation.AccordionControlElement();
                    AI.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
                    AI.Text = "InActive - " + dtUser.Rows[2]["Total"];
                    AG.Elements.Add(AI);
                    AG.Expanded = true;

                    this.accordionControlStatus.Elements.Add(AG);

                    break;
                case GTSysOne.Class.Utility.clsGlobal.myFunction.Company:
                    System.Data.DataTable dtCompany = GTSysOne.Class.Document.clsDoc_Company.ShowTable(GTSysOne.Class.Document.clsDoc_Company.Value(0,3));

                    AG = new DevExpress.XtraBars.Navigation.AccordionControlElement();
                    AG.Style = DevExpress.XtraBars.Navigation.ElementStyle.Group;
                    AG.Text = "Total Company - " + System.Convert.ToInt32(dtCompany.Rows[0]["Total"]);

                    AI = new DevExpress.XtraBars.Navigation.AccordionControlElement();
                    AI.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
                    AI.Text = "Active - " + dtCompany.Rows[1]["Total"];
                    AG.Elements.Add(AI);

                    AI = new DevExpress.XtraBars.Navigation.AccordionControlElement();
                    AI.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
                    AI.Text = "InActive - " + dtCompany.Rows[2]["Total"];
                    AG.Elements.Add(AI);
                    AG.Expanded = true;

                    this.accordionControlStatus.Elements.Add(AG);

                    break;
                case GTSysOne.Class.Utility.clsGlobal.myFunction.NumberingSetup:
                    System.Data.DataTable dtNumberingSetup = GTSysOne.Class.Document.clsDoc_NumberingSetup.ShowTable(GTSysOne.Class.Document.clsDoc_NumberingSetup.Value(0, 1));

                    AG = new DevExpress.XtraBars.Navigation.AccordionControlElement();
                    AG.Style = DevExpress.XtraBars.Navigation.ElementStyle.Group;
                    AG.Text = "Total Numbering Setup - " + System.Convert.ToInt32(dtNumberingSetup.Rows[0]["Total"]);

                    AI = new DevExpress.XtraBars.Navigation.AccordionControlElement();
                    AI.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
                    AI.Text = "Active - " + dtNumberingSetup.Rows[1]["Total"];
                    AG.Elements.Add(AI);

                    AI = new DevExpress.XtraBars.Navigation.AccordionControlElement();
                    AI.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
                    AI.Text = "InActive - " + dtNumberingSetup.Rows[2]["Total"];
                    AG.Elements.Add(AI);
                    AG.Expanded = true;

                    this.accordionControlStatus.Elements.Add(AG);
                    break;
                case GTSysOne.Class.Utility.clsGlobal.myFunction.Country:
                    System.Data.DataTable dtCountry = GTSysOne.Class.Document.clsDoc_Country.ShowTable(GTSysOne.Class.Document.clsDoc_Country.Value(0, 3));

                    AG = new DevExpress.XtraBars.Navigation.AccordionControlElement();
                    AG.Style = DevExpress.XtraBars.Navigation.ElementStyle.Group;
                    AG.Text = "Total Country - " + System.Convert.ToInt32(dtCountry.Rows[0]["Total"]);

                    AI = new DevExpress.XtraBars.Navigation.AccordionControlElement();
                    AI.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
                    AI.Text = "Active - " + dtCountry.Rows[1]["Total"];
                    AG.Elements.Add(AI);

                    AI = new DevExpress.XtraBars.Navigation.AccordionControlElement();
                    AI.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
                    AI.Text = "InActive - " + dtCountry.Rows[2]["Total"];
                    AG.Elements.Add(AI);
                    AG.Expanded = true;

                    this.accordionControlStatus.Elements.Add(AG);
                    break;
                case GTSysOne.Class.Utility.clsGlobal.myFunction.Station:
                    System.Data.DataTable dtStation = GTSysOne.Class.MasterFile.clsMas_Station.ShowTable(GTSysOne.Class.MasterFile.clsMas_Station.Value(0, 5));

                    AG = new DevExpress.XtraBars.Navigation.AccordionControlElement();
                    AG.Style = DevExpress.XtraBars.Navigation.ElementStyle.Group;
                    AG.Text = "Total Station - " + System.Convert.ToInt32(dtStation.Rows[0]["Total"]);

                    AI = new DevExpress.XtraBars.Navigation.AccordionControlElement();
                    AI.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
                    AI.Text = "Active - " + dtStation.Rows[1]["Total"];
                    AG.Elements.Add(AI);

                    AI = new DevExpress.XtraBars.Navigation.AccordionControlElement();
                    AI.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
                    AI.Text = "InActive - " + dtStation.Rows[2]["Total"];
                    AG.Elements.Add(AI);
                    AG.Expanded = true;

                    this.accordionControlStatus.Elements.Add(AG);
                    break;
                case GTSysOne.Class.Utility.clsGlobal.myFunction.AllocationPattern:
                    System.Data.DataTable dtAllocationPattern = GTSysOne.Class.MasterFile.clsMas_AllocationPattern.ShowTable(GTSysOne.Class.MasterFile.clsMas_AllocationPattern.Value(0, 2));

                    AG = new DevExpress.XtraBars.Navigation.AccordionControlElement();
                    AG.Style = DevExpress.XtraBars.Navigation.ElementStyle.Group;
                    AG.Text = "Total Allocation Pattern - " + System.Convert.ToInt32(dtAllocationPattern.Rows[0]["Total"]);

                    AI = new DevExpress.XtraBars.Navigation.AccordionControlElement();
                    AI.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
                    AI.Text = "Active - " + dtAllocationPattern.Rows[1]["Total"];
                    AG.Elements.Add(AI);

                    AI = new DevExpress.XtraBars.Navigation.AccordionControlElement();
                    AI.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
                    AI.Text = "InActive - " + dtAllocationPattern.Rows[2]["Total"];
                    AG.Elements.Add(AI);
                    AG.Expanded = true;

                    this.accordionControlStatus.Elements.Add(AG);
                    break;
                case GTSysOne.Class.Utility.clsGlobal.myFunction.Group:
                    System.Data.DataTable dtGroup = GTSysOne.Class.MasterFile.clsMas_Group.ShowTable(GTSysOne.Class.MasterFile.clsMas_Group.Value(0, 2));

                    AG = new DevExpress.XtraBars.Navigation.AccordionControlElement();
                    AG.Style = DevExpress.XtraBars.Navigation.ElementStyle.Group;
                    AG.Text = "Total Group - " + System.Convert.ToInt32(dtGroup.Rows[0]["Total"]);

                    AI = new DevExpress.XtraBars.Navigation.AccordionControlElement();
                    AI.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
                    AI.Text = "Active - " + dtGroup.Rows[1]["Total"];
                    AG.Elements.Add(AI);

                    AI = new DevExpress.XtraBars.Navigation.AccordionControlElement();
                    AI.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
                    AI.Text = "InActive - " + dtGroup.Rows[2]["Total"];
                    AG.Elements.Add(AI);
                    AG.Expanded = true;

                    this.accordionControlStatus.Elements.Add(AG);
                    break;
                case GTSysOne.Class.Utility.clsGlobal.myFunction.Region:
                    System.Data.DataTable dtRegion = GTSysOne.Class.MasterFile.clsMas_Region.ShowTable(GTSysOne.Class.MasterFile.clsMas_Region.Value(0, 2));

                    AG = new DevExpress.XtraBars.Navigation.AccordionControlElement();
                    AG.Style = DevExpress.XtraBars.Navigation.ElementStyle.Group;
                    AG.Text = "Total Region - " + System.Convert.ToInt32(dtRegion.Rows[0]["Total"]);

                    AI = new DevExpress.XtraBars.Navigation.AccordionControlElement();
                    AI.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
                    AI.Text = "Active - " + dtRegion.Rows[1]["Total"];
                    AG.Elements.Add(AI);

                    AI = new DevExpress.XtraBars.Navigation.AccordionControlElement();
                    AI.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
                    AI.Text = "InActive - " + dtRegion.Rows[2]["Total"];
                    AG.Elements.Add(AI);
                    AG.Expanded = true;

                    this.accordionControlStatus.Elements.Add(AG);
                    break;
                case GTSysOne.Class.Utility.clsGlobal.myFunction.PriceLevel:
                    System.Data.DataTable dtPriceLevel = GTSysOne.Class.MasterFile.clsMas_PriceLevel.ShowTable(GTSysOne.Class.MasterFile.clsMas_PriceLevel.Value(0, 2));

                    AG = new DevExpress.XtraBars.Navigation.AccordionControlElement();
                    AG.Style = DevExpress.XtraBars.Navigation.ElementStyle.Group;
                    AG.Text = "Total Price Level - " + System.Convert.ToInt32(dtPriceLevel.Rows[0]["Total"]);

                    AI = new DevExpress.XtraBars.Navigation.AccordionControlElement();
                    AI.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
                    AI.Text = "Active - " + dtPriceLevel.Rows[1]["Total"];
                    AG.Elements.Add(AI);

                    AI = new DevExpress.XtraBars.Navigation.AccordionControlElement();
                    AI.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
                    AI.Text = "InActive - " + dtPriceLevel.Rows[2]["Total"];
                    AG.Elements.Add(AI);
                    AG.Expanded = true;

                    this.accordionControlStatus.Elements.Add(AG);
                    break;
                case GTSysOne.Class.Utility.clsGlobal.myFunction.TaxArea:
                    System.Data.DataTable dtTaxArea = GTSysOne.Class.MasterFile.clsMas_TaxArea.ShowTable(GTSysOne.Class.MasterFile.clsMas_TaxArea.Value(0, 2));

                    AG = new DevExpress.XtraBars.Navigation.AccordionControlElement();
                    AG.Style = DevExpress.XtraBars.Navigation.ElementStyle.Group;
                    AG.Text = "Total Tax Area - " + System.Convert.ToInt32(dtTaxArea.Rows[0]["Total"]);

                    AI = new DevExpress.XtraBars.Navigation.AccordionControlElement();
                    AI.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
                    AI.Text = "Active - " + dtTaxArea.Rows[1]["Total"];
                    AG.Elements.Add(AI);

                    AI = new DevExpress.XtraBars.Navigation.AccordionControlElement();
                    AI.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
                    AI.Text = "InActive - " + dtTaxArea.Rows[2]["Total"];
                    AG.Elements.Add(AI);
                    AG.Expanded = true;

                    this.accordionControlStatus.Elements.Add(AG);
                    break;
                case GTSysOne.Class.Utility.clsGlobal.myFunction.Establishment:
                    System.Data.DataTable dtEstablishment = GTSysOne.Class.MasterFile.clsMas_Establishment.ShowTable(GTSysOne.Class.MasterFile.clsMas_Establishment.Value(0, 8));

                    AG = new DevExpress.XtraBars.Navigation.AccordionControlElement();
                    AG.Style = DevExpress.XtraBars.Navigation.ElementStyle.Group;
                    AG.Text = "Total Establishment - " + System.Convert.ToInt32(dtEstablishment.Rows[0]["Total"]);

                    AI = new DevExpress.XtraBars.Navigation.AccordionControlElement();
                    AI.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
                    AI.Text = "Active - " + dtEstablishment.Rows[1]["Total"];
                    AG.Elements.Add(AI);

                    AI = new DevExpress.XtraBars.Navigation.AccordionControlElement();
                    AI.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
                    AI.Text = "InActive - " + dtEstablishment.Rows[2]["Total"];
                    AG.Elements.Add(AI);
                    AG.Expanded = true;

                    this.accordionControlStatus.Elements.Add(AG);
                    break;
                //Created by: Johnfrits Rejaba
                //Date: August 22, 2017
                //Identity Type
                case GTSysOne.Class.Utility.clsGlobal.myFunction.IdentityType:
                    System.Data.DataTable dtIdentityType = GTSysOne.Class.MasterFile.clsMas_IdentityType
                        .ShowTable(GTSysOne.Class.MasterFile.clsMas_IdentityType.Value(0, 2
                        , string.Empty
                        , string.Empty
                        , false
                        , false
                        , GTSysOne.Class.Utility.clsGlobal.Instance().COMPANYID));

                    AG = new DevExpress.XtraBars.Navigation.AccordionControlElement();
                    AG.Style = DevExpress.XtraBars.Navigation.ElementStyle.Group;
                    AG.Text = "Total Identity Type - " + System.Convert.ToInt32(dtIdentityType.Rows[0]["Total"]);

                    AI = new DevExpress.XtraBars.Navigation.AccordionControlElement();
                    AI.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
                    AI.Text = "Active - " + dtIdentityType.Rows[1]["Total"];
                    AG.Elements.Add(AI);

                    AI = new DevExpress.XtraBars.Navigation.AccordionControlElement();
                    AI.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
                    AI.Text = "InActive - " + dtIdentityType.Rows[2]["Total"];
                    AG.Elements.Add(AI);
                    AG.Expanded = true;

                    this.accordionControlStatus.Elements.Add(AG);
                    break;
                //Created by: Johnfrits Rejaba
                //Date: August 23, 2017
                //Car Model
                case GTSysOne.Class.Utility.clsGlobal.myFunction.CarModel:
                    System.Data.DataTable dtCarModel = GTSysOne.Class.MasterFile.clsMas_CarModel
                        .ShowTable(GTSysOne.Class.MasterFile.clsMas_CarModel.Value(0, 2
                        , string.Empty
                        , string.Empty
                        , false
                        , false
                        , GTSysOne.Class.Utility.clsGlobal.Instance().COMPANYID));

                    AG = new DevExpress.XtraBars.Navigation.AccordionControlElement();
                    AG.Style = DevExpress.XtraBars.Navigation.ElementStyle.Group;
                    AG.Text = "Total Car Model - " + System.Convert.ToInt32(dtCarModel.Rows[0]["Total"]);

                    AI = new DevExpress.XtraBars.Navigation.AccordionControlElement();
                    AI.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
                    AI.Text = "Active - " + dtCarModel.Rows[1]["Total"];
                    AG.Elements.Add(AI);

                    AI = new DevExpress.XtraBars.Navigation.AccordionControlElement();
                    AI.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
                    AI.Text = "InActive - " + dtCarModel.Rows[2]["Total"];
                    AG.Elements.Add(AI);
                    AG.Expanded = true;

                    this.accordionControlStatus.Elements.Add(AG);
                    break;
                //Created by: Johnfrits Rejaba
                //Date: August 23, 2017
                //Car Color
                case GTSysOne.Class.Utility.clsGlobal.myFunction.CarColor:
                    System.Data.DataTable dtCarColor = GTSysOne.Class.MasterFile.clsMas_CarColor
                        .ShowTable(GTSysOne.Class.MasterFile.clsMas_CarColor.Value(0, 2
                        , string.Empty
                        , string.Empty
                        , false
                        , false
                        , GTSysOne.Class.Utility.clsGlobal.Instance().COMPANYID));

                    AG = new DevExpress.XtraBars.Navigation.AccordionControlElement();
                    AG.Style = DevExpress.XtraBars.Navigation.ElementStyle.Group;
                    AG.Text = "Total Car Color - " + System.Convert.ToInt32(dtCarColor.Rows[0]["Total"]);

                    AI = new DevExpress.XtraBars.Navigation.AccordionControlElement();
                    AI.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
                    AI.Text = "Active - " + dtCarColor.Rows[1]["Total"];
                    AG.Elements.Add(AI);

                    AI = new DevExpress.XtraBars.Navigation.AccordionControlElement();
                    AI.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
                    AI.Text = "InActive - " + dtCarColor.Rows[2]["Total"];
                    AG.Elements.Add(AI);
                    AG.Expanded = true;

                    this.accordionControlStatus.Elements.Add(AG);
                    break;
                //Created by: Johnfrits Rejaba
                //Date: August 23, 2017
                //Car Type
                case GTSysOne.Class.Utility.clsGlobal.myFunction.CarType:
                    System.Data.DataTable dtCarType = GTSysOne.Class.MasterFile.clsMas_CarColor
                        .ShowTable(GTSysOne.Class.MasterFile.clsMas_CarColor.Value(0, 2
                        , string.Empty
                        , string.Empty
                        , false
                        , false
                        , GTSysOne.Class.Utility.clsGlobal.Instance().COMPANYID));

                    AG = new DevExpress.XtraBars.Navigation.AccordionControlElement();
                    AG.Style = DevExpress.XtraBars.Navigation.ElementStyle.Group;
                    AG.Text = "Total Car Color - " + System.Convert.ToInt32(dtCarType.Rows[0]["Total"]);

                    AI = new DevExpress.XtraBars.Navigation.AccordionControlElement();
                    AI.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
                    AI.Text = "Active - " + dtCarType.Rows[1]["Total"];
                    AG.Elements.Add(AI);

                    AI = new DevExpress.XtraBars.Navigation.AccordionControlElement();
                    AI.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
                    AI.Text = "InActive - " + dtCarType.Rows[2]["Total"];
                    AG.Elements.Add(AI);
                    AG.Expanded = true;

                    this.accordionControlStatus.Elements.Add(AG);
                    break;
                //Created by: Johnfrits Rejaba
                //Date: August 23, 2017
                //Rent
                case GTSysOne.Class.Utility.clsGlobal.myFunction.Rent:
                    System.Data.DataTable dtRent = GTSysOne.Class.Document.clsDoc_Rent
                        .ShowTable(GTSysOne.Class.Document.clsDoc_Rent.Value(0, 1
                        , string.Empty
                        , string.Empty
                        , false
                        , false
                        , false
                        , GTSysOne.Class.Utility.clsGlobal.Instance().COMPANYID));

                    AG = new DevExpress.XtraBars.Navigation.AccordionControlElement();
                    AG.Style = DevExpress.XtraBars.Navigation.ElementStyle.Group;
                    AG.Text = "Total Rent - " + System.Convert.ToInt32(dtRent.Rows[0]["Total"]);

                    AI = new DevExpress.XtraBars.Navigation.AccordionControlElement();
                    AI.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
                    AI.Text = "Active - " + dtRent.Rows[1]["Total"];
                    AG.Elements.Add(AI);

                    AI = new DevExpress.XtraBars.Navigation.AccordionControlElement();
                    AI.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
                    AI.Text = "InActive - " + dtRent.Rows[2]["Total"];
                    AG.Elements.Add(AI);
                    AG.Expanded = true;

                    this.accordionControlStatus.Elements.Add(AG);
                    break;

                //Created by: Johnfrits Rejaba
                //Date: August 23, 2017
                //Fixed ssets
                case GTSysOne.Class.Utility.clsGlobal.myFunction.FixedAssets:
                    System.Data.DataTable dtFixedAssets = GTSysOne.Class.MasterFile.clsMas_FixedAssets
                        .ShowTable(GTSysOne.Class.MasterFile.clsMas_FixedAssets.Value(0, 2
                        , string.Empty
                        , string.Empty
                        , false
                        , false
                        , GTSysOne.Class.Utility.clsGlobal.Instance().COMPANYID));

                    AG = new DevExpress.XtraBars.Navigation.AccordionControlElement();
                    AG.Style = DevExpress.XtraBars.Navigation.ElementStyle.Group;
                    AG.Text = "Total Fixed Assets- " + System.Convert.ToInt32(dtFixedAssets.Rows[0]["Total"]);

                    AI = new DevExpress.XtraBars.Navigation.AccordionControlElement();
                    AI.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
                    AI.Text = "Active - " + dtFixedAssets.Rows[1]["Total"];
                    AG.Elements.Add(AI);

                    AI = new DevExpress.XtraBars.Navigation.AccordionControlElement();
                    AI.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
                    AI.Text = "InActive - " + dtFixedAssets.Rows[2]["Total"];
                    AG.Elements.Add(AI);
                    AG.Expanded = true;

                    this.accordionControlStatus.Elements.Add(AG);
                    break;
            }
        }

        private void LOGIN()
        {
            using (var frm = new GTSysOne.Gui.Main.frmLogIn())
            {
                frm.ShowDialog(this);
                frm.Dispose();
            }
            GTSysOne.Class.Utility.clsGlobal.Instance().CloseFromLogIn = false;
            switch (GTSysOne.Class.Utility.clsGlobal.Instance().Login)
            {
                case true:
                    switch (GTSysOne.Class.Utility.clsGlobal.Instance().System_Is_In_Sleep_Mode)
                    {
                        case true:
                            GTSysOne.Class.Utility.clsGlobal.Instance().System_Is_In_Sleep_Mode = false;
                           GTSysOne.Class.Utility.clsUtility.FaidIn(null, 20, true);
                            break;
                        default:
                            this.ACCESS();
                            break;
                    }
                    GTSysOne.Class.Utility.clsUtility.GarbageCollectors();
                    break;
                default:
                    GTSysOne.Class.Utility.clsGlobal.Instance().CloseFromLogIn = true;
                    this.Close();
                    break;
            }
        }
        private void ACCESS()
        {
            this.Activated += new System.EventHandler(this.ACTIVATED);
            this.xtraTabControlMain.CloseButtonClick += new System.EventHandler(this.TABPAGE_XBUTTON);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FORMCLOSING);
            this.xtraTabControlMain.SelectedPageChanged += new DevExpress.XtraTab.TabPageChangedEventHandler(this.PAGE_CHANGED);
            this.btnLicense.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.DROPMENU);
            this.btnAbout.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.DROPMENU);
            this.btnLogOut.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.DROPMENU);
            this.btnExit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.DROPMENU);

            #region STATUS
            this.btnServer.Caption = "Server:" + GTSysOne.Class.Utility.clsGlobal.Instance().Connection.DataSource + " (SQL Server " + GTSysOne.Class.Utility.clsGlobal.Instance().Connection.ServerVersion + " - " + GTSysOne.Class.Utility.clsGlobal.Instance().ConnectionLogIn + ")";
            this.btnDatabase.Caption = "Dbase:" + GTSysOne.Class.Utility.clsGlobal.Instance().Connection.Database;
            this.btnUser.Caption = "User:" + GTSysOne.Class.Utility.clsGlobal.Instance().UserName;
            this.btnMemory.Caption = "Memory:" + GTSysOne.Class.Utility.clsUtility.MemoryUsage().ToString("n1") + " MB";

            this.btnCompany.Caption = "Co.:" + GTSysOne.Class.Utility.clsGlobal.Instance().CONAME;
            this.btnEstablishment.Caption = "Est.:" + GTSysOne.Class.Utility.clsGlobal.Instance().ESTABLISHMENTNAME;
            this.btnStation.Caption = "Stn.:" + GTSysOne.Class.Utility.clsGlobal.Instance().STATIONNAME;

            this.btnLicenseStatus.Caption = "License Stat:" + (GTSysOne.Class.Utility.clsGlobal.Instance().LICENSETYPE == "T" ? "Trial Version" : (GTSysOne.Class.Utility.clsGlobal.Instance().LICENSETYPE == "D" ? "Demo Version" : "Full Version"));
            #endregion

            #region LANGUAGE
            GTSysOne.Class.Utility.clsUtility.createlookupRepository(this.repoLanguage,GTSysOne.Class.Mapping.clsMap_Language.ShowTable(GTSysOne.Class.Mapping.clsMap_Language.Value(0,0)),new string[]{"Name"},"id","Name");
            this.btnLookUpLanguage.EditValue = GTSysOne.Class.Utility.clsGlobal.Instance().LANGUAGE;
            this.btnLookUpLanguage.EditValueChanged += new System.EventHandler(this.LANGUAGE);
            #endregion

            #region STATUS MENU
            this.btnShowFavInNavPane.Down = GTSysOne.Class.Utility.clsGlobal.Instance().Show_Favorites;
            this.btnAutoHideNavPane.Down = GTSysOne.Class.Utility.clsGlobal.Instance().Auto_Hide_Navigation;
            this.btnStats.Down = GTSysOne.Class.Utility.clsGlobal.Instance().Show_Stats;
            this.btnAutoHideStats.Down = GTSysOne.Class.Utility.clsGlobal.Instance().Auto_Hide_Stats;
            this.btnFunctions.Visibility = (GTSysOne.Class.Utility.clsGlobal.Instance().Show_Functions ? DevExpress.XtraBars.BarItemVisibility.Always : DevExpress.XtraBars.BarItemVisibility.Never);
            this.repoFunctions.EditValueChanged += new System.EventHandler(this.Functions);
            GTSysOne.Class.Utility.clsUtility.createlookupRepository(this.repoFunctions, GTSysOne.Class.Utility.clsGlobal.Instance().Function, new string[] { "Name" }, "id", "Name");
            
            #endregion

            #region MODULATOR
            GTSysOne.Class.Utility.clsUtility.Modulator(this.navBarControlModulator, this.imgFunctionIcon16, this.imgFunctionIcon24);
            #endregion
        }

        public static void CALLFROMDASHBOARD(GTSysOne.Class.Utility.clsGlobal.myFunction Function,string Caption,string Search = "")
        {
            switch (Caption)
            {
                case "New":
                case "cmsNew":
                case "Edit":
                case "cmsEdit":
                case "View":
                case "cmsView":
                case "Close":
                case "cmsClose":
                    switch(Function)
                    {
                        case GTSysOne.Class.Utility.clsGlobal.myFunction.User:
                            GTSysOne.Gui.Dashboard.Document.frmUser.CallFromMain(Caption);
                            break;
                        case GTSysOne.Class.Utility.clsGlobal.myFunction.Company:
                            GTSysOne.Gui.Dashboard.Document.frmCompany.CallFromMain(Caption);
                            break;
                        case GTSysOne.Class.Utility.clsGlobal.myFunction.NumberingSetup:
                            GTSysOne.Gui.Dashboard.Document.frmNumberingSetup.CallFromMain(Caption);
                            break;
                        case GTSysOne.Class.Utility.clsGlobal.myFunction.Country:
                            GTSysOne.Gui.Dashboard.Document.frmCountry.CallFromMain(Caption);
                            break;
                        case GTSysOne.Class.Utility.clsGlobal.myFunction.Station:
                            GTSysOne.Gui.Dashboard.MasterFile.frmStation.CallFromMain(Caption);
                            break;
                        case GTSysOne.Class.Utility.clsGlobal.myFunction.AllocationPattern:
                            GTSysOne.Gui.Dashboard.MasterFile.frmAllocationPattern.CallFromMain(Caption);
                            break;
                        case GTSysOne.Class.Utility.clsGlobal.myFunction.Group:
                            GTSysOne.Gui.Dashboard.MasterFile.frmGroup.CallFromMain(Caption);
                            break;
                        case GTSysOne.Class.Utility.clsGlobal.myFunction.Region:
                            GTSysOne.Gui.Dashboard.MasterFile.frmRegion.CallFromMain(Caption);
                            break;
                        case GTSysOne.Class.Utility.clsGlobal.myFunction.PriceLevel:
                            GTSysOne.Gui.Dashboard.MasterFile.frmPriceLevel.CallFromMain(Caption);
                            break;
                        case GTSysOne.Class.Utility.clsGlobal.myFunction.TaxArea:
                            GTSysOne.Gui.Dashboard.MasterFile.frmTaxArea.CallFromMain(Caption);
                            break;
                        case GTSysOne.Class.Utility.clsGlobal.myFunction.Establishment:
                            GTSysOne.Gui.Dashboard.MasterFile.frmEstablishment.CallFromMain(Caption);
                            break;
                        case GTSysOne.Class.Utility.clsGlobal.myFunction.SalesQuotation:
                            GTSysOne.Gui.Dashboard.Document.frmSalesQuotation.CallFromMain(Caption);
                            break;
                        case GTSysOne.Class.Utility.clsGlobal.myFunction.SalesOrder:
                            GTSysOne.Gui.Dashboard.Document.frmSalesOrder.CallFromMain(Caption);
                            break;
                        //Created by: Johnfrits Rejaba
                        //Date: August 22, 2017
                        //Identity Type
                        case GTSysOne.Class.Utility.clsGlobal.myFunction.IdentityType:
                            GTSysOne.Gui.Dashboard.MasterFile.frmIdentityType.CallFromMain(Caption);
                            break;
                        //Created by: Johnfrits Rejaba
                        //Date: August 23, 2017
                        //Car Model
                        case GTSysOne.Class.Utility.clsGlobal.myFunction.CarModel:
                            GTSysOne.Gui.Dashboard.MasterFile.frmCarModel.CallFromMain(Caption);
                            break;
                        //Created by: Johnfrits Rejaba
                        //Date: August 24, 2017
                        //Car Color
                        case GTSysOne.Class.Utility.clsGlobal.myFunction.CarColor:
                            GTSysOne.Gui.Dashboard.MasterFile.frmCarColor.CallFromMain(Caption);
                            break;
                        //Created by: Johnfrits Rejaba
                        //Date: August 24, 2017
                        //Car Type
                        case GTSysOne.Class.Utility.clsGlobal.myFunction.CarType:
                            GTSysOne.Gui.Dashboard.MasterFile.frmCarType.CallFromMain(Caption);
                            break;
                        //Created by: Johnfrits Rejaba
                        //Date: August 26, 2017
                        //Rent
                        case GTSysOne.Class.Utility.clsGlobal.myFunction.Rent:
                            GTSysOne.Gui.Dashboard.Document.frmRent.CallFromMain(Caption);
                            break;
                    }
                    break;
                case "Search":
                case "Refresh":
                    switch (Function)
                    {
                        case GTSysOne.Class.Utility.clsGlobal.myFunction.User:
                            GTSysOne.Gui.Dashboard.Document.frmUser.CallFromMain(Caption, Search);
                            break;
                        case GTSysOne.Class.Utility.clsGlobal.myFunction.Company:
                            GTSysOne.Gui.Dashboard.Document.frmCompany.CallFromMain(Caption, Search);
                            break;
                        case GTSysOne.Class.Utility.clsGlobal.myFunction.NumberingSetup:
                            GTSysOne.Gui.Dashboard.Document.frmNumberingSetup.CallFromMain(Caption, Search);
                            break;
                        case GTSysOne.Class.Utility.clsGlobal.myFunction.Country:
                            GTSysOne.Gui.Dashboard.Document.frmCountry.CallFromMain(Caption, Search);
                            break;
                        case GTSysOne.Class.Utility.clsGlobal.myFunction.Station:
                            GTSysOne.Gui.Dashboard.MasterFile.frmStation.CallFromMain(Caption, Search);
                            break;
                        case GTSysOne.Class.Utility.clsGlobal.myFunction.AllocationPattern:
                            GTSysOne.Gui.Dashboard.MasterFile.frmAllocationPattern.CallFromMain(Caption, Search);
                            break;
                        case GTSysOne.Class.Utility.clsGlobal.myFunction.Group:
                            GTSysOne.Gui.Dashboard.MasterFile.frmGroup.CallFromMain(Caption, Search);
                            break;
                        case GTSysOne.Class.Utility.clsGlobal.myFunction.Region:
                            GTSysOne.Gui.Dashboard.MasterFile.frmRegion.CallFromMain(Caption, Search);
                            break;
                        case GTSysOne.Class.Utility.clsGlobal.myFunction.PriceLevel:
                            GTSysOne.Gui.Dashboard.MasterFile.frmPriceLevel.CallFromMain(Caption, Search);
                            break;
                        case GTSysOne.Class.Utility.clsGlobal.myFunction.TaxArea:
                            GTSysOne.Gui.Dashboard.MasterFile.frmTaxArea.CallFromMain(Caption, Search);
                            break;
                        case GTSysOne.Class.Utility.clsGlobal.myFunction.Establishment:
                            GTSysOne.Gui.Dashboard.MasterFile.frmEstablishment.CallFromMain(Caption, Search);
                            break;
                        //Created by: Johnfrits Rejaba
                        //Date: August 22, 2017
                        //Identity Type
                        case GTSysOne.Class.Utility.clsGlobal.myFunction.IdentityType:
                            GTSysOne.Gui.Dashboard.MasterFile.frmIdentityType.CallFromMain(Caption, Search);
                            break;
                        //Created by: Johnfrits Rejaba
                        //Date: August 23, 2017
                        //Car Model
                        case GTSysOne.Class.Utility.clsGlobal.myFunction.CarModel:
                            GTSysOne.Gui.Dashboard.MasterFile.frmCarModel.CallFromMain(Caption, Search);
                            break;
                        //Created by: Johnfrits Rejaba
                        //Date: August 23, 2017
                        //Car Color
                        case GTSysOne.Class.Utility.clsGlobal.myFunction.CarColor:
                            GTSysOne.Gui.Dashboard.MasterFile.frmCarColor.CallFromMain(Caption, Search);
                            break;
                        //Created by: Johnfrits Rejaba
                        //Date: August 23, 2017
                        //Car Type
                        case GTSysOne.Class.Utility.clsGlobal.myFunction.CarType:
                            GTSysOne.Gui.Dashboard.MasterFile.frmCarType.CallFromMain(Caption, Search);
                            break;
                        //Created by: Johnfrits Rejaba
                        //Date: August 23, 2017
                        //Rent
                        case GTSysOne.Class.Utility.clsGlobal.myFunction.Rent:
                            GTSysOne.Gui.Dashboard.Document.frmRent.CallFromMain(Caption, Search);
                            break;
                    }
                    Instance.STATUS(Function);
                    break;
            }
        }
        public static void BUTTON_ITEMCLICK(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CALLFROMDASHBOARD(
                (GTSysOne.Class.Utility.clsGlobal.myFunction)System.Convert.ToInt32(System.Convert.ToString(e.Link.Item.Tag).Split('*')[0])
                , System.Convert.ToString(e.Link.Item.Tag).Split('*')[1]);
        }
        private void SEARCH_PRESSED(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if ((sender as DevExpress.XtraEditors.ButtonEdit).Properties.Buttons.IndexOf(e.Button) == 1)
            {
                CALLFROMDASHBOARD((GTSysOne.Class.Utility.clsGlobal.myFunction)System.Convert.ToInt32(System.Convert.ToString((sender as DevExpress.XtraEditors.ButtonEdit).Properties.Tag).Split('*')[0])
                , System.Convert.ToString((sender as DevExpress.XtraEditors.ButtonEdit).Properties.Tag).Split('*')[1]
                , (sender as DevExpress.XtraEditors.ButtonEdit).Text);
            }
        }

        private void SHOWNFORM(object sender, System.EventArgs e)
        {
            this.LOGIN();
        }

        private void PAGE_CHANGED(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            GTSysOne.Class.Utility.clsGlobal.Instance().CurrentFunctionSelected = e.Page.Name;
            this.PAGEADD((GTSysOne.Class.Utility.clsGlobal.myFunction)System.Convert.ToInt32(e.Page.Tag));
            if (GTSysOne.Class.Utility.clsGlobal.Instance().CurrentFunctionSelected.CompareTo("xtraTabPageStart") == 0)
            {
                this.ribbon.Minimized = true;
            }
            else
            {
                this.ribbon.Minimized = false;
            }
        }

        private void FORMCLOSING(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            switch (GTSysOne.Class.Utility.clsGlobal.Instance().LogOut)
            {
                case true:
                    switch (GTSysOne.Class.Utility.clsGlobal.Instance().CloseFromLogIn)
                    {
                        case true:
                            GTSysOne.Class.Utility.clsUtility.UpdateRunningAccount(0);
                            break;
                        default:
                            switch (GTSysOne.Class.Utility.clsUtility.GTSysMessageBox(new string[] { "Are you sure you want to Log Out?" }
                                    , GTSysOne.Class.Utility.clsGlobal.enMessageBoxButton.YesNo
                                    , GTSysOne.Class.Utility.clsGlobal.enMessageBoxIcon.Question
                                    , "Confirmation"))
                            {
                                case System.Windows.Forms.DialogResult.No:
                                    e.Cancel = true;
                                    GTSysOne.Class.Utility.clsGlobal.Instance().LogOut = false;
                                    break;
                                case System.Windows.Forms.DialogResult.Yes:
                                    GTSysOne.Class.Utility.clsUtility.UpdateRunningAccount(0);
                                    break;
                            }
                            break;
                    }
                    break;
                default:
                    switch (GTSysOne.Class.Utility.clsGlobal.Instance().ShutDownSystem)
                    {
                        case true:
                            GTSysOne.Class.Utility.clsUtility.UpdateRunningAccount(0);
                            break;
                        default:
                            switch (GTSysOne.Class.Utility.clsUtility.GTSysMessageBox(new string[] { "Are you sure you want to Exit?" }
                                    , GTSysOne.Class.Utility.clsGlobal.enMessageBoxButton.YesNo
                                    , GTSysOne.Class.Utility.clsGlobal.enMessageBoxIcon.Question
                                    , "Confirmation"))
                            {
                                case System.Windows.Forms.DialogResult.No:
                                    e.Cancel = true;
                                    switch (GTSysOne.Class.Utility.clsGlobal.Instance().CloseFromLogIn)
                                    {
                                        case true:
                                            this.LOGIN();
                                            break;
                                    }
                                    break;
                                case System.Windows.Forms.DialogResult.Yes:
                                    GTSysOne.Class.Utility.clsUtility.UpdateRunningAccount(0);
                                    break;
                            }
                            break;
                    }
                    break;
            }
            if(e.Cancel == false)
            {
                if (GTSysOne.Class.Utility.clsGlobal.Instance().THEME != DevExpress.LookAndFeel.UserLookAndFeel.Default.ActiveSkinName && GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_Changed_Theme)
                {
                    this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
                    GTSysOne.Class.MasterFile.clsMas_Station.Save(GTSysOne.Class.MasterFile.clsMas_Station.Value(2, 3, GTSysOne.Class.Utility.clsGlobal.Instance().STATIONID, DevExpress.LookAndFeel.UserLookAndFeel.Default.ActiveSkinName));
                    this.Cursor = System.Windows.Forms.Cursors.Default;
                }
                if (GTSysOne.Class.Utility.clsGlobal.Instance().LANGUAGE != System.Convert.ToString(this.btnLookUpLanguage.EditValue) && GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_Changed_Language)
                {
                    this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
                    GTSysOne.Class.MasterFile.clsMas_Station.Save(GTSysOne.Class.MasterFile.clsMas_Station.Value(2, 4, GTSysOne.Class.Utility.clsGlobal.Instance().STATIONID, System.Convert.ToString(this.btnLookUpLanguage.EditValue)));
                    this.Cursor = System.Windows.Forms.Cursors.Default;
                }
            }
        }
        private void TABPAGE_XBUTTON(object sender, System.EventArgs e)
        {
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            DevExpress.XtraTab.ViewInfo.ClosePageButtonEventArgs arg = e as DevExpress.XtraTab.ViewInfo.ClosePageButtonEventArgs;
            DevExpress.XtraBars.Ribbon.RibbonPage P  = new DevExpress.XtraBars.Ribbon.RibbonPage();
            P.Name = System.Convert.ToString((GTSysOne.Class.Utility.clsGlobal.myFunction)System.Convert.ToInt32((arg.Page as DevExpress.XtraTab.XtraTabPage).Tag));   
            this.ribbon.Pages.Remove(P);P.Dispose();
            System.Windows.Forms.Form frm = (System.Windows.Forms.Form)(arg.Page as DevExpress.XtraTab.XtraTabPage).Controls[0];
            frm.Close();frm.Dispose();
            (arg.Page as DevExpress.XtraTab.XtraTabPage).Controls.Clear();
            this.xtraTabControlMain.TabPages.Remove((arg.Page as DevExpress.XtraTab.XtraTabPage));    
            (arg.Page as DevExpress.XtraTab.XtraTabPage).Dispose();
            arg = null;
            this.Cursor = System.Windows.Forms.Cursors.Default;
        }
        private void ACTIVATED(object sender, System.EventArgs e)
        {
            this.btnMemory.Caption = "Memory:" + GTSysOne.Class.Utility.clsUtility.MemoryUsage().ToString("n1") + " MB";
        }
        private void LANGUAGE(object sender, System.EventArgs e)
        {
            object p = this.btnLookUpLanguage.EditValue;   
        }
        private void DROPMENU(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            switch(e.Item.Name)
            {
                case "btnLicense":
                    GTSysOne.Gui.Main.frmLicense.Instance.ShowDialog(Instance);
                    if (GTSysOne.Class.Utility.clsGlobal.Instance().LogOut)
                    {
                        Instance.Close();
                    }
                    break;
                case "btnAbout":

                    break;
                case "btnLogOut":
                    GTSysOne.Class.Utility.clsGlobal.Instance().LogOut = true;
                    Instance.Close();
                    break;
                case "btnExit":
                    Instance.Close();
                    break;
            }
        }

        
    }
}