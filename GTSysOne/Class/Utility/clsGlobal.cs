namespace GTSysOne.Class.Utility
{
    public class clsGlobal
    {
        #region Constructor
        protected static clsGlobal G;
        protected clsGlobal() { }
        public static clsGlobal Instance()
        {
            G = new clsGlobal();
            return G;
        }
        #endregion

        #region Declared Variable
        private static System.Data.DataTable p_Table_Printer_Settings;
        public System.Data.DataTable Table_Printer_Settings
        {
            get { return p_Table_Printer_Settings; }
            set { p_Table_Printer_Settings = value; }
        }


        public static string PRINTER_RENT_REPORT = "70000";



        private static System.Data.SqlClient.SqlConnection p_Connection = new System.Data.SqlClient.SqlConnection();
        private static System.Data.SqlClient.SqlDataAdapter p_DataAdapter;
        private static string p_ConnectionString;

        private static string p_ConnectionLogIn;
        private static string p_ConnectionPassword;

        private static bool p_OptimizeConnection = true;
        private static string p_NewPK = "@NewPK";
        private static bool p_Personalize_Designer;
        private static string p_Personalize_Designer_Error;
        private static bool p_Restart = false;
        private static string p_Fix_System_Password;

        private static string p_MainHeaderVersion = "GTS™";//"GTS™   |  [Version: " + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString() + " - "
        //+ System.IO.File.GetLastWriteTime(System.IO.Directory.GetCurrentDirectory() + @"\\" + Classes.Utility.ExecutableName()).Day.ToString()
        //+ ".0." + System.IO.File.GetLastWriteTime(System.IO.Directory.GetCurrentDirectory() + @"\\" + Classes.Utility.ExecutableName()).Month.ToString()
        //+ ".0." + System.IO.File.GetLastWriteTime(System.IO.Directory.GetCurrentDirectory() + @"\\" + Classes.Utility.ExecutableName()).Year.ToString().Substring(2, 2).ToString() + "] ";


        private static System.Data.DataTable p_Table_Printer;
        private static bool p_Connected;
        private static string p_ConnectionDetails;
        private static bool p_Login;
        private static bool p_LogOut;
        private static bool p_CloseFromLogIn;



        private static string p_COLICENSE;
        private static string p_ESTABLISHMENTLICENSE;

        private static string p_ESTABLISHMENTCPU;
        private static string p_STATIONCPU;

        private static int p_CO_USAGE;
        private static int p_EST_USAGE;
        private static int p_STAT_USAGE;

        private static string p_LICENSEID;
        private static string p_COMPANYID;
        private static string p_ESTABLISHMENTID;
        private static string p_STATIONID;


        private static string p_CONAME;
        private static string p_ESTABLISHMENTNAME;
        private static string p_ESTABLISHMENTSHORTNAME;
        private static string p_STATIONNAME;
        private static string p_STATIONSHORTNAME;

        private static bool p_STATIONRUNNING;
        private static string p_LANGUAGE;
        private static bool p_ALLOW_EDIT_LINE_TOTAL;
        private static string p_THEME;
        private static bool p_STATIONisHQ;


        private static string p_LICENSETYPE;
        private static string[] p_MODULE;
        private static int p_TOTALCOMPANY;
        private static int p_TOTALESTABLISHMENT;
        private static int p_TOTALSTATION;
        private static int p_TRIALDAYS;
        private static string p_DATECREATE;
        private static string p_SUBSCRIPTIONEXPIRED;
        private static string p_CLIENTNO;
        
        private static string p_LicenseDisplay;

        private static bool p_System_Is_In_Sleep_Mode;

        private static string p_Message_InvalidAccount = "Sorry, we didn't recognize your sign-in details.\nPlease check you username and password, then try again.";

        private static string p_userName;
        private static string p_password;

        private static bool p_IsAccountRunningHanging;
        private static bool p_AccountRunning;
        private static bool p_Admin;

        private static string p_UserId;

        private static string p_Message_AccountRunning = "You cannot log on from this action because you are connected from two others Unit.\nTo log on from this station, log off from one of the other Unit.";

        private static System.Data.DataTable p_Module;

        private static System.Data.DataTable p_Function;

        private static bool p_No_Error_Result;

        private static string p_GridLayoutLocation = System.IO.Directory.GetCurrentDirectory() + "\\GridLayout\\";

        private static System.Data.DataTable p_ThemesList;

        private static DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider p_Err = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider();

        private static string p_CompanyWebsite = "http://gtsys.com.jo/";

        private static string p_CurrentFunctionSelected;

        private static string p_CultureInformation;


        private static System.Data.DataTable p_CompanyAccess;
        private static System.Data.DataTable p_EstablishmentAccess;
        private static System.Data.DataTable p_Privilege;

        private static bool p_Commit = false;


        private static bool p_Allow_To_Add_Company;
        private static bool p_Allow_To_Edit_Company;
        private static bool p_Allow_To_View_Company;
        private static bool p_Allow_To_Void_Company;
        private static bool p_Allow_To_Changed_Theme;
        private static bool p_Allow_To_Changed_Language;

        private static bool p_ShutDownSystem = false;

        private static bool p_Allow_To_Add_User;
        private static bool p_Allow_To_Edit_User;
        private static bool p_Allow_To_View_User;
        private static bool p_Allow_To_Void_User;


        private static bool p_Allow_To_Add_NumberingSetup;
        private static bool p_Allow_To_Edit_NumberingSetup;
        private static bool p_Allow_To_View_NumberingSetup;
        private static bool p_Allow_To_Void_NumberingSetup;

        private static bool p_Allow_To_Add_Country;
        private static bool p_Allow_To_Edit_Country;
        private static bool p_Allow_To_View_Country;
        private static bool p_Allow_To_Void_Country;

        private static bool p_Allow_To_Add_Station;
        private static bool p_Allow_To_Edit_Station;
        private static bool p_Allow_To_View_Station;
        private static bool p_Allow_To_Void_Station;

        private static bool p_Allow_To_Add_Establishment;
        private static bool p_Allow_To_Edit_Establishment;
        private static bool p_Allow_To_View_Establishment;
        private static bool p_Allow_To_Void_Establishment;

        private static bool p_Allow_To_Add_Allocation_Pattern;
        private static bool p_Allow_To_Edit_Allocation_Pattern;
        private static bool p_Allow_To_View_Allocation_Pattern;
        private static bool p_Allow_To_Void_Allocation_Pattern;


        private static bool p_Allow_To_Add_Group;
        private static bool p_Allow_To_Edit_Group;
        private static bool p_Allow_To_View_Group;
        private static bool p_Allow_To_Void_Group;

        private static bool p_Allow_To_Add_Region;
        private static bool p_Allow_To_Edit_Region;
        private static bool p_Allow_To_View_Region;
        private static bool p_Allow_To_Void_Region;

        private static bool p_Allow_To_Add_Price_Level;
        private static bool p_Allow_To_Edit_Price_Level;
        private static bool p_Allow_To_View_Price_Level;
        private static bool p_Allow_To_Void_Price_Level;


        private static bool p_Allow_To_Add_Tax_Area;
        private static bool p_Allow_To_Edit_Tax_Area;
        private static bool p_Allow_To_View_Tax_Area;
        private static bool p_Allow_To_Void_Tax_Area;


        private static bool p_Show_Favorites;
        private static bool p_Auto_Hide_Navigation;
        private static bool p_Show_Stats;
        private static bool p_Auto_Hide_Stats;
        private static bool p_Show_Functions;

        /// <summary>
        /// Sales Quotation
        /// </summary>
        private static bool p_Allow_To_Add_Sales_Quotation;
        private static bool p_Allow_To_Edit_Sales_Quotation;
        private static bool p_Allow_To_View_Sales_Quotation;

        /// <summary>
        /// Sales Order
        /// </summary>
        private static bool p_Allow_To_Add_Sales_Order;
        private static bool p_Allow_To_Edit_Sales_Order;
        private static bool p_Allow_To_View_Sales_Order;

        private static System.Data.DataTable p_FullItemList;

        /// <summary>
        /// Identity Type
        ///Created by: Johnfrits Rejaba
        ///Date: August 22, 2017
        /// </summary>
        private static bool p_Allow_To_Add_Identy_Type;
        private static bool p_Allow_To_Edit_Identy_Type;
        private static bool p_Allow_To_View_Identy_Type;
        private static bool p_Allow_To_Void_Identy_Type;

        /// <summary>
        /// Car Model
        ///Created by: Johnfrits Rejaba
        ///Date: August 23, 2017
        /// </summary>
        private static bool p_Allow_To_Add_Car_Model;
        private static bool p_Allow_To_Edit_Car_Model;
        private static bool p_Allow_To_View_Car_Model;
        private static bool p_Allow_To_Void_Car_Model;

        /// <summary>
        /// Car Color
        ///Created by: Johnfrits Rejaba
        ///Date: August 23, 2017
        /// </summary>
        private static bool p_Allow_To_Add_Car_Color;
        private static bool p_Allow_To_Edit_Car_Color;
        private static bool p_Allow_To_View_Car_Color;
        private static bool p_Allow_To_Void_Car_Color;

        /// <summary>
        /// Car Type
        ///Created by: Johnfrits Rejaba
        ///Date: August 24, 2017
        /// </summary>
        private static bool p_Allow_To_Add_Car_Type;
        private static bool p_Allow_To_Edit_Car_Type;
        private static bool p_Allow_To_View_Car_Type;
        private static bool p_Allow_To_Void_Car_Type;


        /// <summary>
        /// Rent
        ///Created by: Johnfrits Rejaba
        ///Date: August 26, 2017
        /// </summary>
        private static bool p_Allow_To_Add_Rent;
        private static bool p_Allow_To_Edit_Rent;
        private static bool p_Allow_To_View_Rent;
        private static bool p_Allow_To_Void_Rent;


        /// <summary>
        /// Renter
        ///Created by: Johnfrits Rejaba
        ///Date: September 5, 2017
        /// </summary>
        private static bool p_Allow_To_Add_Renter;
        private static bool p_Allow_To_Edit_Renter;
        private static bool p_Allow_To_View_Renter;
        private static bool p_Allow_To_Void_Renter;

        /// <summary>
        /// Driver
        ///Created by: Johnfrits Rejaba
        ///Date: September 5, 2017
        /// </summary>
        private static bool p_Allow_To_Add_Driver;
        private static bool p_Allow_To_Edit_Driver;
        private static bool p_Allow_To_View_Driver;
        private static bool p_Allow_To_Void_Driver;

        /// <summary>
        /// Tax
        ///Created by: Johnfrits Rejaba
        ///Date: September 5, 2017
        /// </summary>
        private static bool p_Allow_To_Add_Tax;
        private static bool p_Allow_To_Edit_Tax;
        private static bool p_Allow_To_View_Tax;
        private static bool p_Allow_To_Void_Tax;

        /// <summary>
        /// Fixed Assets
        ///Created by: Johnfrits Rejaba
        ///Date: September 5, 2017
        /// </summary>
        private static bool p_Allow_To_Add_Fixed_Assets;
        private static bool p_Allow_To_Edit_Fixed_Assets;
        private static bool p_Allow_To_View_Fixed_Assets;
        private static bool p_Allow_To_Void_Fixed_Assets;

        /// <summary>
        /// Credit Card
        ///Created by: Johnfrits Rejaba
        ///Date: September 5, 2017
        /// </summary>
        private static bool p_Allow_To_Add_Credit_Card;
        private static bool p_Allow_To_Edit_Credit_Card;
        private static bool p_Allow_To_View_Credit_Card;
        private static bool p_Allow_To_Void_Credit_Card;
        #endregion

        #region Property


        public bool Allow_To_Add_Company
        {
            get { return p_Allow_To_Add_Company; }
            set { p_Allow_To_Add_Company = value; }
        }
        public bool Allow_To_Edit_Company
        {
            get { return p_Allow_To_Edit_Company; }
            set { p_Allow_To_Edit_Company = value; }
        }
        public bool Allow_To_View_Company
        {
            get { return p_Allow_To_View_Company; }
            set { p_Allow_To_View_Company = value; }
        }
        public bool Allow_To_Void_Company
        {
            get { return p_Allow_To_Void_Company; }
            set { p_Allow_To_Void_Company = value; }
        }
        public bool Allow_To_Changed_Theme
        {
            get { return p_Allow_To_Changed_Theme; }
            set { p_Allow_To_Changed_Theme = value; }
        }
        public bool Allow_To_Changed_Language
        {
            get { return p_Allow_To_Changed_Language; }
            set { p_Allow_To_Changed_Language = value; }
        }


        public bool Allow_To_Add_User
        {
            get { return p_Allow_To_Add_User; }
            set { p_Allow_To_Add_User = value; }
        }
        public bool Allow_To_Edit_User
        {
            get { return p_Allow_To_Edit_User; }
            set { p_Allow_To_Edit_User = value; }
        }
        public bool Allow_To_View_User
        {
            get { return p_Allow_To_View_User; }
            set { p_Allow_To_View_User = value; }
        }
        public bool Allow_To_Void_User
        {
            get { return p_Allow_To_Void_User; }
            set { p_Allow_To_Void_User = value; }
        }



        public bool Allow_To_Add_NumberingSetup
        {
            get { return p_Allow_To_Add_NumberingSetup; }
            set { p_Allow_To_Add_NumberingSetup = value; }
        }
        public bool Allow_To_Edit_NumberingSetup
        {
            get { return p_Allow_To_Edit_NumberingSetup; }
            set { p_Allow_To_Edit_NumberingSetup = value; }
        }
        public bool Allow_To_View_NumberingSetup
        {
            get { return p_Allow_To_View_NumberingSetup; }
            set { p_Allow_To_View_NumberingSetup = value; }
        }
        public bool Allow_To_Void_NumberingSetup
        {
            get { return p_Allow_To_Void_NumberingSetup; }
            set { p_Allow_To_Void_NumberingSetup = value; }
        }


        public bool Allow_To_Add_Country
        {
            get { return p_Allow_To_Add_Country; }
            set { p_Allow_To_Add_Country = value; }
        }
        public bool Allow_To_Edit_Country
        {
            get { return p_Allow_To_Edit_Country; }
            set { p_Allow_To_Edit_Country = value; }
        }
        public bool Allow_To_View_Country
        {
            get { return p_Allow_To_View_Country; }
            set { p_Allow_To_View_Country = value; }
        }
        public bool Allow_To_Void_Country
        {
            get { return p_Allow_To_Void_Country; }
            set { p_Allow_To_Void_Country = value; }
        }

        public bool Commit
        {
            get { return p_Commit; }
            set { p_Commit = value; }
        }

        public bool Allow_To_Add_Station
        {
            get { return p_Allow_To_Add_Station; }
            set { p_Allow_To_Add_Station = value; }
        }
        public bool Allow_To_Edit_Station
        {
            get { return p_Allow_To_Edit_Station; }
            set { p_Allow_To_Edit_Station = value; }
        }
        public bool Allow_To_View_Station
        {
            get { return p_Allow_To_View_Station; }
            set { p_Allow_To_View_Station = value; }
        }
        public bool Allow_To_Void_Station
        {
            get { return p_Allow_To_Void_Station; }
            set { p_Allow_To_Void_Station = value; }
        }


        public bool Allow_To_Add_Establishment
        {
            get { return p_Allow_To_Add_Establishment; }
            set { p_Allow_To_Add_Establishment = value; }
        }
        public bool Allow_To_Edit_Establishment
        {
            get { return p_Allow_To_Edit_Establishment; }
            set { p_Allow_To_Edit_Establishment = value; }
        }
        public bool Allow_To_View_Establishment
        {
            get { return p_Allow_To_View_Establishment; }
            set { p_Allow_To_View_Establishment = value; }
        }
        public bool Allow_To_Void_Establishment
        {
            get { return p_Allow_To_Void_Establishment; }
            set { p_Allow_To_Void_Establishment = value; }
        }


        public bool Allow_To_Add_Allocation_Pattern
        {
            get { return p_Allow_To_Add_Allocation_Pattern; }
            set { p_Allow_To_Add_Allocation_Pattern = value; }
        }
        public bool Allow_To_Edit_Allocation_Pattern
        {
            get { return p_Allow_To_Edit_Allocation_Pattern; }
            set { p_Allow_To_Edit_Allocation_Pattern = value; }
        }
        public bool Allow_To_View_Allocation_Pattern
        {
            get { return p_Allow_To_View_Allocation_Pattern; }
            set { p_Allow_To_View_Allocation_Pattern = value; }
        }
        public bool Allow_To_Void_Allocation_Pattern
        {
            get { return p_Allow_To_Void_Allocation_Pattern; }
            set { p_Allow_To_Void_Allocation_Pattern = value; }
        }


        public bool Allow_To_Add_Group
        {
            get { return p_Allow_To_Add_Group; }
            set { p_Allow_To_Add_Group = value; }
        }
        public bool Allow_To_Edit_Group
        {
            get { return p_Allow_To_Edit_Group; }
            set { p_Allow_To_Edit_Group = value; }
        }
        public bool Allow_To_View_Group
        {
            get { return p_Allow_To_View_Group; }
            set { p_Allow_To_View_Group = value; }
        }
        public bool Allow_To_Void_Group
        {
            get { return p_Allow_To_Void_Group; }
            set { p_Allow_To_Void_Group = value; }
        }


        public bool Allow_To_Add_Region
        {
            get { return p_Allow_To_Add_Region; }
            set { p_Allow_To_Add_Region = value; }
        }
        public bool Allow_To_Edit_Region
        {
            get { return p_Allow_To_Edit_Region; }
            set { p_Allow_To_Edit_Region = value; }
        }
        public bool Allow_To_View_Region
        {
            get { return p_Allow_To_View_Region; }
            set { p_Allow_To_View_Region = value; }
        }
        public bool Allow_To_Void_Region
        {
            get { return p_Allow_To_Void_Region; }
            set { p_Allow_To_Void_Region = value; }
        }


        public bool Allow_To_Add_Price_Level
        {
            get { return p_Allow_To_Add_Price_Level; }
            set { p_Allow_To_Add_Price_Level = value; }
        }
        public bool Allow_To_Edit_Price_Level
        {
            get { return p_Allow_To_Edit_Price_Level; }
            set { p_Allow_To_Edit_Price_Level = value; }
        }
        public bool Allow_To_View_Price_Level
        {
            get { return p_Allow_To_View_Price_Level; }
            set { p_Allow_To_View_Price_Level = value; }
        }
        public bool Allow_To_Void_Price_Level
        {
            get { return p_Allow_To_Void_Price_Level; }
            set { p_Allow_To_Void_Price_Level = value; }
        }


        public bool Allow_To_Add_Tax_Area
        {
            get { return p_Allow_To_Add_Tax_Area; }
            set { p_Allow_To_Add_Tax_Area = value; }
        }
        public bool Allow_To_Edit_Tax_Area
        {
            get { return p_Allow_To_Edit_Tax_Area; }
            set { p_Allow_To_Edit_Tax_Area = value; }
        }
        public bool Allow_To_View_Tax_Area
        {
            get { return p_Allow_To_View_Tax_Area; }
            set { p_Allow_To_View_Tax_Area = value; }
        }
        public bool Allow_To_Void_Tax_Area
        {
            get { return p_Allow_To_Void_Tax_Area; }
            set { p_Allow_To_Void_Tax_Area = value; }
        }



        public bool Show_Favorites
        {
            get { return p_Show_Favorites; }
            set { p_Show_Favorites = value; }
        }
        public bool Auto_Hide_Navigation
        {
            get { return p_Auto_Hide_Navigation; }
            set { p_Auto_Hide_Navigation = value; }
        }
        public bool Show_Stats
        {
            get { return p_Show_Stats; }
            set { p_Show_Stats = value; }
        }
        public bool Auto_Hide_Stats
        {
            get { return p_Auto_Hide_Stats; }
            set { p_Auto_Hide_Stats = value; }
        }
        public bool Show_Functions
        {
            get { return p_Show_Functions; }
            set { p_Show_Functions = value; }
        }

        public bool ShutDownSystem
        {
            get { return p_ShutDownSystem; }
            set { p_ShutDownSystem = value; }
        }

        public System.Data.SqlClient.SqlConnection Connection
        {
            get { return p_Connection; }
            set { p_Connection = value; }
        }
        public System.Data.SqlClient.SqlDataAdapter DataAdapter
        {
            get { return p_DataAdapter; }
            set { p_DataAdapter = value; }
        }
        public string ConnectionString
        {
            get { return p_ConnectionString; }
            set { p_ConnectionString = value; }
        }

        public string ConnectionLogIn
        {
            get { return p_ConnectionLogIn; }
            set { p_ConnectionLogIn = value; }
        }
        public string ConnectionPassword
        {
            get { return p_ConnectionPassword; }
            set { p_ConnectionPassword = value; }
        }

        public bool OptimizeConnection
        {
            get { return p_OptimizeConnection; }
            set { p_OptimizeConnection = value; }
        }
        public string NewPK
        {
            get { return p_NewPK; }
            set { p_NewPK = value; }
        }
        public bool Personalize_Designer
        {
            get { return p_Personalize_Designer; }
            set { p_Personalize_Designer = value; }
        }
        public string Personalize_Designer_Error
        {
            get { return p_Personalize_Designer_Error; }
            set { p_Personalize_Designer_Error = value; }
        }
        public bool Restart
        {
            get { return p_Restart; }
            set { p_Restart = value; }
        }
        public string Fix_System_Password
        {
            get { return p_Fix_System_Password; }
            set { p_Fix_System_Password = value; }
        }
        public string MainHeaderVersion
        {
            get { return p_MainHeaderVersion; }
            set { p_MainHeaderVersion = value; }
        }

        
        public System.Data.DataTable Table_Printer
        {
            get { return p_Table_Printer; }
            set { p_Table_Printer = value; }
        }

        public bool Connected
        {
            get { return p_Connected; }
            set { p_Connected = value; }
        }
        public string ConnectionDetails
        {
            get { return p_ConnectionDetails; }
            set { p_ConnectionDetails = value; }
        }
        public bool Login
        {
            get { return p_Login; }
            set { p_Login = value; }
        }
        public bool LogOut
        {
            get { return p_LogOut; }
            set { p_LogOut = value; }
        }
        public bool CloseFromLogIn
        {
            get { return p_CloseFromLogIn; }
            set { p_CloseFromLogIn = value; }
        }


        public string COLICENSE
        {
            get { return p_COLICENSE; }
            set { p_COLICENSE = value; }
        }
        public string ESTABLISHMENTLICENSE
        {
            get { return p_ESTABLISHMENTLICENSE; }
            set { p_ESTABLISHMENTLICENSE = value; }
        }

        public string ESTABLISHMENTCPU
        {
            get { return p_ESTABLISHMENTCPU; }
            set { p_ESTABLISHMENTCPU = value; }
        }
        public string STATIONCPU
        {
            get { return p_STATIONCPU; }
            set { p_STATIONCPU = value; }
        }


        public int CO_USAGE
        {
            get { return p_CO_USAGE; }
            set { p_CO_USAGE = value; }
        }
        public int EST_USAGE
        {
            get { return p_EST_USAGE; }
            set { p_EST_USAGE = value; }
        }
        public int STAT_USAGE
        {
            get { return p_STAT_USAGE; }
            set { p_STAT_USAGE = value; }
        }

        public string LICENSEID
        {
            get { return p_LICENSEID; }
            set { p_LICENSEID = value; }
        }
        public string COMPANYID
        {
            get { return p_COMPANYID; }
            set { p_COMPANYID = value; }
        }
        public string ESTABLISHMENTID
        {
            get { return p_ESTABLISHMENTID; }
            set { p_ESTABLISHMENTID = value; }
        }
        public string STATIONID
        {
            get { return p_STATIONID; }
            set { p_STATIONID = value; }
        }


        public string CONAME
        {
            get { return p_CONAME; }
            set { p_CONAME = value; }
        }
        public string ESTABLISHMENTNAME
        {
            get { return p_ESTABLISHMENTNAME; }
            set { p_ESTABLISHMENTNAME = value; }
        }
        public string ESTABLISHMENTSHORTNAME
        {
            get { return p_ESTABLISHMENTSHORTNAME; }
            set { p_ESTABLISHMENTSHORTNAME = value; }
        }
        public string STATIONNAME
        {
            get { return p_STATIONNAME; }
            set { p_STATIONNAME = value; }
        }
        public string STATIONSHORTNAME
        {
            get { return p_STATIONSHORTNAME; }
            set { p_STATIONSHORTNAME = value; }
        }


        public bool STATIONRUNNING
        {
            get { return p_STATIONRUNNING; }
            set { p_STATIONRUNNING = value; }
        }
        public string LANGUAGE
        {
            get { return p_LANGUAGE; }
            set { p_LANGUAGE = value; }
        }
        public bool ALLOW_EDIT_LINE_TOTAL
        {
            get { return p_ALLOW_EDIT_LINE_TOTAL; }
            set { p_ALLOW_EDIT_LINE_TOTAL = value; }
        }
        public string THEME
        {
            get { return p_THEME; }
            set { p_THEME = value; }
        }
        public bool STATIONisHQ
        {
            get { return p_STATIONisHQ; }
            set { p_STATIONisHQ = value; }
        }

        public string LICENSETYPE
        {
            get { return p_LICENSETYPE; }
            set { p_LICENSETYPE = value; }
        }
        public string[] MODULE
        {
            get { return p_MODULE; }
            set { p_MODULE = value; }
        }
        public int TOTALCOMPANY
        {
            get { return p_TOTALCOMPANY; }
            set { p_TOTALCOMPANY = value; }
        }
        public int TOTALESTABLISHMENT
        {
            get { return p_TOTALESTABLISHMENT; }
            set { p_TOTALESTABLISHMENT = value; }
        }
        public int TOTALSTATION
        {
            get { return p_TOTALSTATION; }
            set { p_TOTALSTATION = value; }
        }
        public int TRIALDAYS
        {
            get { return p_TRIALDAYS; }
            set { p_TRIALDAYS = value; }
        }
        public string DATECREATE
        {
            get { return p_DATECREATE; }
            set { p_DATECREATE = value; }
        }
        public string SUBSCRIPTIONEXPIRED
        {
            get { return p_SUBSCRIPTIONEXPIRED; }
            set { p_SUBSCRIPTIONEXPIRED = value; }
        }

        public string CLIENTNO
        {
            get { return p_CLIENTNO; }
            set { p_CLIENTNO = value; }
        }
       
        
        public string LicenseDisplay
        {
            get { return p_LicenseDisplay; }
            set { p_LicenseDisplay = value; }
        }


        public bool System_Is_In_Sleep_Mode
        {
            get { return p_System_Is_In_Sleep_Mode; }
            set { p_System_Is_In_Sleep_Mode = value; }
        }

        public string Message_InvalidAccount
        {
            get { return p_Message_InvalidAccount; }
            set { p_Message_InvalidAccount = value; }
        }

        public string UserName
        {
            get { return p_userName; }
            set { p_userName = value; }
        }
        public string Password
        {
            get { return p_password; }
            set { p_password = value; }
        }

        public bool IsAccountRunningHanging
        {
            get { return p_IsAccountRunningHanging; }
            set { p_IsAccountRunningHanging = value; }
        }

        public bool AccountRunning
        {
            get { return p_AccountRunning; }
            set { p_AccountRunning = value; }
        }

        public bool Admin
        {
            get { return p_Admin; }
            set { p_Admin = value; }
        }

        public string Message_AccountRunning
        {
            get { return p_Message_AccountRunning; }
            set { p_Message_AccountRunning = value; }
        }

        public System.Data.DataTable Module
        {
            get { return p_Module; }
            set { p_Module = value; }
        }

        public System.Data.DataTable Function
        {
            get { return p_Function; }
            set { p_Function = value; }
        }
        public bool No_Error_Result
        {
            get { return p_No_Error_Result; }
            set { p_No_Error_Result = value; }
        }
        public string GridLayoutLocation
        {
            get { return p_GridLayoutLocation; }
            set { p_GridLayoutLocation = value; }
        }


        public System.Data.DataTable ThemesList
        {
            get { return p_ThemesList; }
            set { p_ThemesList = value; }
        }

        public DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider Err
        {
            get { return p_Err; }
            set { p_Err = value; }
        }

        public string UserId
        {
            get { return p_UserId; }
            set { p_UserId = value; }
        }

        public string CompanyWebsite
        {
            get { return p_CompanyWebsite; }
            set { p_CompanyWebsite = value; }
        }


        public string CurrentFunctionSelected
        {
            get { return p_CurrentFunctionSelected; }
            set { p_CurrentFunctionSelected = value; }
        }

        public string CultureInformation
        {
            get { return p_CultureInformation; }
            set { p_CultureInformation = value; }
        }

        public System.Data.DataTable CompanyAccess
        {
            get { return p_CompanyAccess; }
            set { p_CompanyAccess = value; }
        }
        public System.Data.DataTable EstablishmentAccess
        {
            get { return p_EstablishmentAccess; }
            set { p_EstablishmentAccess = value; }
        }
        public System.Data.DataTable Privilege
        {
            get { return p_Privilege; }
            set { p_Privilege = value; }
        }

        /// <summary>
        /// Sales Quote
        /// </summary>
        public bool Allow_To_Add_Sales_Quotation
        {
            get { return p_Allow_To_Add_Sales_Quotation; }
            set { p_Allow_To_Add_Sales_Quotation = value; }
        }

        public bool Allow_To_Edit_Sales_Quotation
        {
            get { return p_Allow_To_Edit_Sales_Quotation; }
            set { p_Allow_To_Edit_Sales_Quotation = value; }
        }

        public bool Allow_To_View_Sales_Quotation
        {
            get { return p_Allow_To_View_Sales_Quotation; }
            set { p_Allow_To_View_Sales_Quotation = value; }
        }

        /// <summary>
        /// Sales Order
        /// </summary>
        public bool Allow_To_Add_Sales_Order
        {
            get { return p_Allow_To_Add_Sales_Order; }
            set { p_Allow_To_Add_Sales_Order = value; }
        }

        public bool Allow_To_Edit_Sales_Order
        {
            get { return p_Allow_To_Edit_Sales_Order; }
            set { p_Allow_To_Edit_Sales_Order = value; }
        }

        public bool Allow_To_View_Sales_Order
        {
            get { return p_Allow_To_View_Sales_Order; }
            set { p_Allow_To_View_Sales_Order = value; }
        }

        public System.Data.DataTable FullItemList
        {
            get { return p_FullItemList; }
            set { p_FullItemList = value; }
        }

        /// <summary>
        /// Identity Type
        ///Created by: Johnfrits Rejaba
        ///Date: August 22, 2017
        /// </summary>
        public bool Allow_To_Add_Identity_Type
        {
            get { return p_Allow_To_Add_Identy_Type; }
            set { p_Allow_To_Add_Identy_Type = value; }
        }

        public bool Allow_To_Edit_Identy_Type
        {
            get { return p_Allow_To_Edit_Identy_Type; }
            set { p_Allow_To_Edit_Identy_Type = value; }
        }

        public bool Allow_To_View_Identy_Type
        {
            get { return p_Allow_To_View_Identy_Type; }
            set { p_Allow_To_View_Identy_Type = value; }
        }
        public bool Allow_To_Void_Identy_Type
        {
            get { return p_Allow_To_Void_Identy_Type; }
            set { p_Allow_To_Void_Identy_Type = value; }
        }

        /// <summary>
        /// Car Model
        ///Created by: Johnfrits Rejaba
        ///Date: August 23, 2017
        /// </summary>
        public bool Allow_To_Add_Car_Model
        {
            get { return p_Allow_To_Add_Car_Model; }
            set { p_Allow_To_Add_Car_Model = value; }
        }

        public bool Allow_To_Edit_Car_Model
        {
            get { return p_Allow_To_Edit_Car_Model; }
            set { p_Allow_To_Edit_Car_Model = value; }
        }

        public bool Allow_To_View_Car_Model
        {
            get { return p_Allow_To_View_Car_Model; }
            set { p_Allow_To_View_Car_Model = value; }
        }
        public bool Allow_To_Void_Car_Model
        {
            get { return p_Allow_To_Void_Car_Model; }
            set { p_Allow_To_Void_Car_Model = value; }
        }

        /// <summary>
        /// Car Color
        ///Created by: Johnfrits Rejaba
        ///Date: August 23, 2017
        /// </summary>
        public bool Allow_To_Add_Car_Color
        {
            get { return p_Allow_To_Add_Car_Color; }
            set { p_Allow_To_Add_Car_Color = value; }
        }

        public bool Allow_To_Edit_Car_Color
        {
            get { return p_Allow_To_Edit_Car_Color; }
            set { p_Allow_To_Edit_Car_Color = value; }
        }

        public bool Allow_To_View_Car_Color
        {
            get { return p_Allow_To_View_Car_Color; }
            set { p_Allow_To_View_Car_Color = value; }
        }
        public bool Allow_To_Void_Car_Color
        {
            get { return p_Allow_To_Void_Car_Color; }
            set { p_Allow_To_Void_Car_Color = value; }
        }

        /// <summary>
        /// Car Type
        ///Created by: Johnfrits Rejaba
        ///Date: August 24, 2017
        /// </summary>
        public bool Allow_To_Add_Car_Type
        {
            get { return p_Allow_To_Add_Car_Type; }
            set { p_Allow_To_Add_Car_Type = value; }
        }

        public bool Allow_To_Edit_Car_Type
        {
            get { return p_Allow_To_Edit_Car_Type; }
            set { p_Allow_To_Edit_Car_Type = value; }
        }

        public bool Allow_To_View_Car_Type
        {
            get { return p_Allow_To_View_Car_Type; }
            set { p_Allow_To_View_Car_Type = value; }
        }
        public bool Allow_To_Void_Car_Type
        {
            get { return p_Allow_To_Void_Car_Type; }
            set { p_Allow_To_Void_Car_Type = value; }
        }

        /// <summary>
        /// Rent
        ///Created by: Johnfrits Rejaba
        ///Date: August 26, 2017
        /// </summary>
        public bool Allow_To_Add_Rent
        {
            get { return p_Allow_To_Add_Rent; }
            set { p_Allow_To_Add_Rent = value; }
        }

        public bool Allow_To_Edit_Rent
        {
            get { return p_Allow_To_Edit_Rent; }
            set { p_Allow_To_Edit_Rent = value; }
        }

        public bool Allow_To_View_Rent
        {
            get { return p_Allow_To_View_Rent; }
            set { p_Allow_To_View_Rent = value; }
        }
        public bool Allow_To_Void_Rent
        {
            get { return p_Allow_To_Void_Rent; }
            set { p_Allow_To_Void_Rent = value; }
        }


        /// <summary>
        /// Renter
        ///Created by: Johnfrits Rejaba
        ///Date: August 26, 2017
        /// </summary>
        public bool Allow_To_Add_Renter
        {
            get { return p_Allow_To_Add_Renter; }
            set { p_Allow_To_Add_Renter = value; }
        }

        public bool Allow_To_Edit_Renter
        {
            get { return p_Allow_To_Edit_Renter; }
            set { p_Allow_To_Edit_Renter = value; }
        }

        public bool Allow_To_View_Renter
        {
            get { return p_Allow_To_View_Renter; }
            set { p_Allow_To_View_Renter = value; }
        }
        public bool Allow_To_Void_Renter
        {
            get { return p_Allow_To_Void_Renter; }
            set { p_Allow_To_Void_Renter = value; }
        }

        /// <summary>
        /// Driver
        ///Created by: Johnfrits Rejaba
        ///Date: August 26, 2017
        /// </summary>
        public bool Allow_To_Add_Driver
        {
            get { return p_Allow_To_Add_Driver; }
            set { p_Allow_To_Add_Driver = value; }
        }

        public bool Allow_To_Edit_Driver
        {
            get { return p_Allow_To_Edit_Driver; }
            set { p_Allow_To_Edit_Driver = value; }
        }

        public bool Allow_To_View_Driver
        {
            get { return p_Allow_To_View_Driver; }
            set { p_Allow_To_View_Driver = value; }
        }
        public bool Allow_To_Void_Driver
        {
            get { return p_Allow_To_Void_Driver; }
            set { p_Allow_To_Void_Driver = value; }
        }

        /// <summary>
        /// Tax
        ///Created by: Johnfrits Rejaba
        ///Date: August 26, 2017
        /// </summary>
        public bool Allow_To_Add_Tax
        {
            get { return p_Allow_To_Add_Tax; }
            set { p_Allow_To_Add_Tax = value; }
        }

        public bool Allow_To_Edit_Tax
        {
            get { return p_Allow_To_Edit_Tax; }
            set { p_Allow_To_Edit_Tax = value; }
        }

        public bool Allow_To_View_Tax
        {
            get { return p_Allow_To_View_Tax; }
            set { p_Allow_To_View_Tax = value; }
        }
        public bool Allow_To_Void_Tax
        {
            get { return p_Allow_To_Void_Tax; }
            set { p_Allow_To_Void_Tax = value; }
        }

        /// <summary>
        /// Fixed Assets
        ///Created by: Johnfrits Rejaba
        ///Date: August 26, 2017
        /// </summary>
        public bool Allow_To_Add_Fixed_Assets
        {
            get { return p_Allow_To_Add_Fixed_Assets; }
            set { p_Allow_To_Add_Fixed_Assets = value; }
        }

        public bool Allow_To_Edit_Fixed_Assets
        {
            get { return p_Allow_To_Edit_Fixed_Assets; }
            set { p_Allow_To_Edit_Fixed_Assets = value; }
        }

        public bool Allow_To_View_Fixed_Assets
        {
            get { return p_Allow_To_View_Fixed_Assets; }
            set { p_Allow_To_View_Fixed_Assets = value; }
        }
        public bool Allow_To_Void_Fixed_Assets
        {
            get { return p_Allow_To_Void_Fixed_Assets; }
            set { p_Allow_To_Void_Fixed_Assets = value; }
        }

        /// <summary>
        /// Credit Card
        ///Created by: Johnfrits Rejaba
        ///Date: August 26, 2017
        /// </summary>
        public bool Allow_To_Add_Credit_Card
        {
            get { return p_Allow_To_Add_Credit_Card; }
            set { p_Allow_To_Add_Credit_Card = value; }
        }

        public bool Allow_To_Edit_Credit_Card
        {
            get { return p_Allow_To_Edit_Credit_Card; }
            set { p_Allow_To_Edit_Credit_Card = value; }
        }

        public bool Allow_To_View_Credit_Card
        {
            get { return p_Allow_To_View_Credit_Card; }
            set { p_Allow_To_View_Credit_Card = value; }
        }
        public bool Allow_To_Void_Credit_Card
        {
            get { return p_Allow_To_Void_Credit_Card; }
            set { p_Allow_To_Void_Credit_Card = value; }
        }
        #endregion


        private static string p_EstablishmentGroups;
        public string EstablishmentGroups
        {
            get { return p_EstablishmentGroups; }
            set { p_EstablishmentGroups = value; }
        }

        private static bool p_Use_Per_Misc_Code = true;

        private static int p_WeightedBarcodeLength = 13;
        private static int p_WeightedBarcodeControlNumber = 21;

        private static int p_MiscCodeStart = 2;
        private static int p_MiscCodeLength = 4;

        private static int p_WholeNumberStart = 6;
        private static int p_WholeNumberLength = 3;

        private static int p_DecimalNumberStart = 9;
        private static int p_DecimalNumberLength = 3;

        private static bool p_Use_Whole_And_Decimal_As_Price = false;



        public bool Use_Per_Misc_Code
        {
            get { return p_Use_Per_Misc_Code; }
            set { p_Use_Per_Misc_Code = value; }
        }

        public int WeightedBarcodeLength
        {
            get { return p_WeightedBarcodeLength; }
            set { p_WeightedBarcodeLength = value; }
        }
        public int WeightedBarcodeControlNumber
        {
            get { return p_WeightedBarcodeControlNumber; }
            set { p_WeightedBarcodeControlNumber = value; }
        }


        public int MiscCodeStart
        {
            get { return p_MiscCodeStart; }
            set { p_MiscCodeStart = value; }
        }
        public int MiscCodeLength
        {
            get { return p_MiscCodeLength; }
            set { p_MiscCodeLength = value; }
        }

        public int WholeNumberStart
        {
            get { return p_WholeNumberStart; }
            set { p_WholeNumberStart = value; }
        }
        public int WholeNumberLength
        {
            get { return p_WholeNumberLength; }
            set { p_WholeNumberLength = value; }
        }


        public int DecimalNumberStart
        {
            get { return p_DecimalNumberStart; }
            set { p_DecimalNumberStart = value; }
        }
        public int DecimalNumberLength
        {
            get { return p_DecimalNumberLength; }
            set { p_DecimalNumberLength = value; }
        }


        public bool Use_Whole_And_Decimal_As_Price
        {
            get { return p_Use_Whole_And_Decimal_As_Price; }
            set { p_Use_Whole_And_Decimal_As_Price = value; }
        }


        #region ENUM
        private static enMessageBoxButton MBB;
        public enMessageBoxButton sMessageBoxButton
        {
            get { return MBB; }
            set { MBB = value; }
        }
        public enum enMessageBoxButton
        {
            YesNo = 0,
            YesNoCancel = 1,
            OK = 2,
        }
        #endregion

        #region ENUM
        private static enMessageBoxIcon MBI;
        public enMessageBoxIcon sMessageBoxIcon
        {
            get { return MBI; }
            set { MBI = value; }
        }
        public enum enMessageBoxIcon
        {
            Information = 0,
            Warning = 1,
            Error = 2,
            Stop = 3,
            Question = 4,
        }
        #endregion

        #region ENUM
        private static myloginAction entryMode;
        public myloginAction LogInAction
        {
            get { return entryMode; }
            set { entryMode = value; }
        }
        public enum myloginAction : int
        {
            LogIn = 0,
            Options = 1
        }
        #endregion

        #region ENUM
        private static myLicenseStatus licenseMode;
        public myLicenseStatus LicenseAction
        {
            get { return licenseMode; }
            set { licenseMode = value; }
        }
        public enum myLicenseStatus : int
        {
            UnLicensed = 0,
            Trial = 1,
            FullVersion = 2,
            AlmostExpiredSubscription = 3,
            ExpiredSubscription = 4,
            JustClose = 5,
            LicenseModified = 6,
            TrialExpired = 7,
            DeactivatedLSEU = 8,
            Copyright = 9,
            Demo = 10
        }
        #endregion

        #region ENUM
        private static myFunction sFunction;
        public myFunction GTSysFunction
        {
            get { return sFunction; }
            set { sFunction = value; }
        }
        /// <summary>
        /// Identity Type
        ///Created by: Johnfrits Rejaba
        ///Date: August 22, 2017
        ///Added Identity to myFuntion
        ///Date: August 23, 2017
        ///Added Car Model to myFuntion
        ///Date: August 24, 2017
        ///Added Car Color to myFuntion
        ///Date: August 26, 2017
        ///Added Rent to myFuntion
        ///Date: Sept 5, 2017
        ///Added Renter to myFuntion
        ///Date: Sept 5, 2017
        ///Added Driver to myFuntion
        ///Date: Sept 5, 2017
        ///Added Tax to myFuntion
        /// </summary>
        public enum myFunction : int
        {
              NumberingSetup = 1
            , Group = 2
            , Company = 3
            , Country = 4
            , License = 6
            , User = 7
            , AllocationPattern = 8
            , Establishment = 10
            , Station = 12
            , Registration = 13
            , Region = 14
            , PriceLevel = 15
            , TaxArea = 16
            , SalesQuotation = 20000
            , SalesOrder = 20001          
            , Item_Master = 1018
            , IdentityType = 70000
            , CarModel = 70001
            , CarColor = 70002
            , CarType = 70003
            , Rent = 70004
            , Renter = 70005
            , Driver = 70006
            , Tax = 70007
            , FixedAssets = 70008
            , Card = 70009
        }
        #endregion

        #region ENUM
        private static GridLayout l;
        public GridLayout Layout
        {
            get { return l; }
            set { l = value; }
        }
        public enum GridLayout
        {
            Save = 0,
            Restore = 1
        }
        #endregion

    }
}
