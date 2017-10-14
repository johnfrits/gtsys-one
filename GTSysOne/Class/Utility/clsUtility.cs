using System.Data;
using DevExpress.XtraReports.UI;
namespace GTSysOne.Class.Utility
{
    public struct clsUtility
    {
        [System.Runtime.InteropServices.DllImport("User32.dll", SetLastError = true)]
        static extern void SwitchToThisWindow(System.IntPtr hWnd, bool fAltTab);

        [System.Runtime.InteropServices.DllImport("kernel32.dll", EntryPoint = "SetProcessWorkingSetSize", ExactSpelling = true, CharSet = System.Runtime.InteropServices.CharSet.Ansi, SetLastError = true)]
        private static extern int SetProcessWorkingSetSize(System.IntPtr Process, int minimumWorkingSetSize, int maximumWorkingSetSize);

        static int checkedRowIndex = -1;
        static bool IsRepeat = false;

        public static int OpenConnection()
        {
            int R = 0;
            CloseConnection();
            GTSysOne.Class.Utility.clsGlobal.Instance().Connection.ConnectionString = GTSysOne.Class.Utility.clsGlobal.Instance().ConnectionString;
            switch (GTSysOne.Class.Utility.clsGlobal.Instance().OptimizeConnection)
            {
                case true:
                    GTSysOne.Class.Utility.clsGlobal.Instance().Connection.Open();
                    R = 1;
                    break;
                case false:
                    try
                    {
                        GTSysOne.Class.Utility.clsGlobal.Instance().Connection.Open();
                        R = 1;
                    }
                    catch
                    {
                        R = 0;
                    }
                    break;
            }
            return R;
        }
        public static int CloseConnection()
        {
            switch (GTSysOne.Class.Utility.clsGlobal.Instance().Connection.State)
            {
                case System.Data.ConnectionState.Open:
                    GTSysOne.Class.Utility.clsGlobal.Instance().Connection.Close();
                    break;
            }
            return 0;
        }
        public static object ManagedExecution(string[] ColumnName, object[] Value, string ProcedureName, int Operation, int Return = 0)
        {
            GTSysOne.Class.Utility.clsExecution E = new GTSysOne.Class.Utility.clsExecution();
            dynamic D = null;
            switch (Operation)
            {
                case 0://Select Statement Either ExecuteScalar || ExecuteReader
                    D = E.Fetched(ColumnName, Value, ProcedureName, System.Data.CommandType.StoredProcedure, Return);
                    break;
                default:
                    E.Execute(ColumnName, Value, ProcedureName);
                    D = GTSysOne.Class.Utility.clsGlobal.Instance().NewPK;
                    break;
            }
            E.Disposed();
            GarbageCollectors();
            return D;
        }

        public static string GetConnectionFile()
        {
            string R = string.Empty;
            string AppPath = System.Windows.Forms.Application.ExecutablePath + ".config";
            System.Configuration.ExeConfigurationFileMap AppMap = new System.Configuration.ExeConfigurationFileMap { ExeConfigFilename = AppPath };
            System.Configuration.Configuration JHAYROSE = System.Configuration.ConfigurationManager.OpenMappedExeConfiguration(AppMap, System.Configuration.ConfigurationUserLevel.None);
            try
            {
                R = GTSysOne.Class.Utility.clsEncryption.JayDhreiZIP.Decrypt(System.Configuration.ConfigurationManager.AppSettings["MyConnectionString"], "");
            }
            catch
            {
                R = System.Configuration.ConfigurationManager.AppSettings["MyConnectionString"];
            }
            return R;
        }
        public static bool UpdateConnectionFile(string DataSource, string Database, string Username, string Password, string Authentication = "True")
        {
            bool C = true;
            Database = (Database.CompareTo(string.Empty) == 0 ? "EMPTY DATABASE" : Database);
            string NewConnection = "Data Source = " + DataSource + ";Initial Catalog = " + Database + ";Persist Security Info = " + Authentication + ";User ID = " + Username + ";Password = " + Password + " ";
            System.Data.SqlClient.SqlConnection Con = new System.Data.SqlClient.SqlConnection(NewConnection);
            try
            {
                Con.Open();

                GTSysOne.Class.Utility.clsGlobal.Instance().ConnectionString = NewConnection;

                string AppPath = System.Windows.Forms.Application.ExecutablePath + ".config";
                System.Configuration.ExeConfigurationFileMap AppMap = new System.Configuration.ExeConfigurationFileMap { ExeConfigFilename = AppPath };
                System.Configuration.Configuration JHAYROSE = System.Configuration.ConfigurationManager.OpenMappedExeConfiguration(AppMap, System.Configuration.ConfigurationUserLevel.None);

                System.Security.Permissions.FileIOPermission F = new System.Security.Permissions.FileIOPermission(System.Security.Permissions.FileIOPermissionAccess.Read, AppPath);

                F.AddPathList(System.Security.Permissions.FileIOPermissionAccess.Write | System.Security.Permissions.FileIOPermissionAccess.Read | System.Security.Permissions.FileIOPermissionAccess.AllAccess, AppPath);

                System.IO.File.SetAttributes(AppPath, System.IO.FileAttributes.Normal);

                JHAYROSE.AppSettings.Settings["MyConnectionString"].Value = GTSysOne.Class.Utility.clsEncryption.JayDhreiZIP.Encrypt(NewConnection, "");
                JHAYROSE.AppSettings.Settings["JHAYROSE"].Value = GTSysOne.Class.Utility.clsEncryption.JayDhreiZIP.Encrypt("0", "");
                JHAYROSE.AppSettings.Settings["DATAS"].Value = GTSysOne.Class.Utility.clsEncryption.JayDhreiZIP.Encrypt(DataSource, "");
                JHAYROSE.AppSettings.Settings["INITCAT"].Value = GTSysOne.Class.Utility.clsEncryption.JayDhreiZIP.Encrypt(Database, "");
                JHAYROSE.AppSettings.Settings["AUTH"].Value = GTSysOne.Class.Utility.clsEncryption.JayDhreiZIP.Encrypt(Authentication, "");
                JHAYROSE.AppSettings.Settings["IDRIS"].Value = GTSysOne.Class.Utility.clsEncryption.JayDhreiZIP.Encrypt(Username, "");
                JHAYROSE.AppSettings.Settings["ROSALES"].Value = GTSysOne.Class.Utility.clsEncryption.JayDhreiZIP.Encrypt(Password, "");

                JHAYROSE.Save(System.Configuration.ConfigurationSaveMode.Modified);

                System.IO.File.SetAttributes(AppPath, System.IO.FileAttributes.ReadOnly);

                DevExpress.XtraEditors.XtraMessageBox.Show("Successfully Connected.", "Done", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);

                Con.Close();

                C = true;
            }
            catch (System.Exception e)
            {
                C = false;
                DevExpress.XtraEditors.XtraMessageBox.Show(e.Message, "Fail", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            finally
            {
                Con.Dispose();
            }
            return C;
        }
        public static int DisplayConnectionFile(DevExpress.XtraEditors.TextEdit DataSource, DevExpress.XtraEditors.TextEdit Database, DevExpress.XtraEditors.TextEdit UserName, DevExpress.XtraEditors.TextEdit Password, DevExpress.XtraEditors.LookUpEdit Authentication)
        {
            try
            {
                string AppPath = System.Windows.Forms.Application.ExecutablePath + ".config";
                System.Configuration.ExeConfigurationFileMap AppMap = new System.Configuration.ExeConfigurationFileMap { ExeConfigFilename = AppPath };
                System.Configuration.Configuration JHAYROSE = System.Configuration.ConfigurationManager.OpenMappedExeConfiguration(AppMap, System.Configuration.ConfigurationUserLevel.None);
                DataSource.Text = GTSysOne.Class.Utility.clsEncryption.JayDhreiZIP.Decrypt(JHAYROSE.AppSettings.Settings["DATAS"].Value, "");
                Database.Text = GTSysOne.Class.Utility.clsEncryption.JayDhreiZIP.Decrypt(JHAYROSE.AppSettings.Settings["INITCAT"].Value, "");
                Authentication.EditValue = GTSysOne.Class.Utility.clsEncryption.JayDhreiZIP.Decrypt(JHAYROSE.AppSettings.Settings["AUTH"].Value, "");
                UserName.Text = GTSysOne.Class.Utility.clsEncryption.JayDhreiZIP.Decrypt(JHAYROSE.AppSettings.Settings["IDRIS"].Value, "");
                Password.Text = GTSysOne.Class.Utility.clsEncryption.JayDhreiZIP.Decrypt(JHAYROSE.AppSettings.Settings["ROSALES"].Value, "");
            }
            catch
            {
                DataSource.Text = string.Empty;
                Database.Text = string.Empty;
                Authentication.EditValue = false;
                UserName.Text = string.Empty;
                Password.Text = string.Empty;
            }
            return 0;
        }
        public static bool TestConnection(string NewConnection)
        {
            bool Connected =false;
            System.Data.SqlClient.SqlConnection Con = new System.Data.SqlClient.SqlConnection(NewConnection);
            try
            {
                Con.Open();
                Connected = true;
            }
            catch 
            {
                Connected = false;
            }
            finally
            {
                Con.Close();
                Con.Dispose();
            }
            return Connected;
        }
        
        
        public static int GarbageCollectors()
        {
            System.GC.Collect();
            System.GC.WaitForPendingFinalizers();
            System.GC.Collect();
            if (System.Environment.OSVersion.Platform == System.PlatformID.Win32NT)
            {
                SetProcessWorkingSetSize(System.Diagnostics.Process.GetCurrentProcess().Handle, -1, -1);
            }
            return 0;
        }
        public static string NulloEmptyString(object I)
        {
            if (I == System.DBNull.Value)
            {
                return "";
            }
            else if (I == null)
            {
                return "";
            }
            else
            {
                return System.Convert.ToString(I);
            }
        }
        public static bool NullToValue(object o)
        {
            bool val = false;
            try
            {
                val = System.Convert.ToBoolean(o);
            }
            catch
            {
                val = false;
            }
            return val;
        }

        public static int View(DevExpress.XtraGrid.GridControl GC, DevExpress.XtraGrid.Views.Grid.GridView GV, int e, System.Data.DataTable D, string Id, bool New)
        {
            switch (New)
            {
                case true:
                    GC.DataSource = D;
                    break;
                case false:
                    System.Data.DataTable T = new System.Data.DataTable();
                    T = (System.Data.DataTable)GC.DataSource;
                    System.Data.DataRow R = T.NewRow();
                    int index = 0;
                    switch (e)
                    {
                        case 1:
                            System.Data.DataRow[] DR = T.Select(" Id = '" + Id + "' ");
                            if (DR.Length > 0)
                            {
                                if (T.Rows.IndexOf(DR[0]) >= 0)
                                {
                                    index = T.Rows.IndexOf(DR[0]);
                                    T.Rows.RemoveAt(T.Rows.IndexOf(DR[0]));
                                }
                            }
                            break;
                    }
                    foreach (System.Data.DataRow i in D.Rows)
                    {
                        R.ItemArray = i.ItemArray;
                        T.Rows.InsertAt(R, index);
                    }
                    GC.RefreshDataSource();
                    GV.FocusedRowHandle = index;
                    break;
            }
            D.Dispose();
            return 0;
        }
        public static DevExpress.XtraEditors.LookUpEdit createlookup(DevExpress.XtraEditors.LookUpEdit le, System.Data.DataTable dt, string[] input, string value, string display)
        {
            System.Collections.Generic.List<string> field = new System.Collections.Generic.List<string>(input);
            le.Properties.DataSource = dt;
            le.Properties.ValueMember = value.ToString();
            le.Properties.DisplayMember = display.ToString();
            DevExpress.XtraEditors.Controls.LookUpColumnInfoCollection col = le.Properties.Columns;
            col.Clear();
            col = le.Properties.Columns;
            foreach (string columnField in field)
            {
                col.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo(columnField.ToString()));
            }
            le.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            le.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete;
            le.Properties.AutoSearchColumnIndex = 1;
            field.Clear();
            return le;
        }
        public static DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit createlookupRepository(DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit le, DataTable dt, string[] input, string value, string display)
        {
            System.Collections.Generic.List<string> field = new System.Collections.Generic.List<string>(input);
            le.DataSource = dt;
            le.ValueMember = value.ToString();
            le.DisplayMember = display.ToString();
            DevExpress.XtraEditors.Controls.LookUpColumnInfoCollection col = le.Columns;
            col.Clear();
            col = le.Columns;
            foreach (string columnField in field)
            {
                col.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo(columnField.ToString()));
            }
            le.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            le.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete;
            le.AutoSearchColumnIndex = 1;
            field.Clear();
            return le;
        }
        public static bool InstanceRunning()
        {
            bool s = false;
            using (System.Management.ManagementObjectSearcher mos = new System.Management.ManagementObjectSearcher())
            {
                mos.Query.QueryString = @"SELECT * FROM Win32_Process WHERE Name = '" + System.Diagnostics.Process.GetCurrentProcess().MainModule.ModuleName + @"'";
                if (mos.Get().Count > 1)
                {
                    s = true;
                    System.Diagnostics.Process[] proc = System.Diagnostics.Process.GetProcessesByName(System.Diagnostics.Process.GetCurrentProcess().MainModule.ModuleName.Replace(".exe", ""));
                    if (proc.Length > 0)
                    {
                        SwitchToThisWindow(proc[0].MainWindowHandle, true);
                    }
                }
                mos.Dispose();
            }
            return s;
        }
        public static int FaidIn(System.Windows.Forms.Form f, int sleep, bool IsMultipleForms = false)
        {
            if (IsMultipleForms)
            {
                for (int index = System.Windows.Forms.Application.OpenForms.Count - 1; index >= 0; index--)
                {
                    for (int i = 0; i <= 50; i++)
                    {
                        System.Windows.Forms.Application.OpenForms[index].Opacity = i * 0.02;
                        System.Windows.Forms.Application.DoEvents();
                        System.Threading.Thread.Sleep(sleep);
                    }
                }
            }
            else
            {
                for (int i = 0; i <= 50; i++)
                {
                    f.Opacity = i * 0.02;
                    System.Windows.Forms.Application.DoEvents();
                    System.Threading.Thread.Sleep(sleep);
                }
            }
            return 0;
        }
        public static string GetCPUID()
        {
            string cpuInfo = string.Empty;
            try
            {
                System.Management.ManagementObjectSearcher mos = new System.Management.ManagementObjectSearcher("SELECT SerialNumber FROM Win32_BaseBoard");
                System.Management.ManagementObjectCollection moc = mos.Get();
                foreach (System.Management.ManagementObject mo in moc)
                {
                    cpuInfo = mo["SerialNumber"].ToString();
                }
                System.Management.ManagementClass mb2 = new System.Management.ManagementClass("Win32_ComputerSystem");
                System.Management.ManagementObjectCollection mob2 = mb2.GetInstances();
                foreach (System.Management.ManagementObject mof in mob2)
                {
                    cpuInfo += mof.Properties["Name"].Value.ToString().Trim();
                    break;
                }
            }
            catch
            {
                cpuInfo = "Restart";
                GTSysOne.Class.Utility.clsUtility.GTSysMessageBox(new string[]{"Theres a Problem With your Operating System for getting CPUID"},GTSysOne.Class.Utility.clsGlobal.enMessageBoxButton.OK,GTSysOne.Class.Utility.clsGlobal.enMessageBoxIcon.Error);
            }
            return cpuInfo;
        }
        public static System.Data.DataTable PrinterInstalled()
        {
            System.Data.DataTable d = new System.Data.DataTable();
            d.Columns.Add("Name", typeof(string));
            d.Columns.Add("Status", typeof(string));
            for (int i = 0; i < System.Drawing.Printing.PrinterSettings.InstalledPrinters.Count; i++)
            {
                d.Rows.Add(System.Drawing.Printing.PrinterSettings.InstalledPrinters[i].ToString(), (PrinterStatus(System.Drawing.Printing.PrinterSettings.InstalledPrinters[i].ToString()) ? "Online" : "WorkOffline"));
            }
            GTSysOne.Class.Utility.clsGlobal.Instance().Table_Printer = d;
            return d;
        }
        public static bool PrinterStatus(string printerName, DevExpress.XtraEditors.LabelControl Type = null, DevExpress.XtraEditors.LabelControl Location = null, DevExpress.XtraEditors.LabelControl Comment = null)
        {
            bool online = false;
            System.Management.ManagementScope scope = new System.Management.ManagementScope(System.Management.ManagementPath.DefaultPath);
            scope.Connect();
            System.Management.SelectQuery query = new System.Management.SelectQuery("select Name from Win32_Printer where Name = '" + printerName + "'");
            System.Management.ManagementClass m = new System.Management.ManagementClass("Win32_Printer");
            System.Management.ManagementObjectSearcher obj = new System.Management.ManagementObjectSearcher(scope, query);
            using (System.Management.ManagementObjectCollection printers = m.GetInstances())
            {
                foreach (System.Management.ManagementObject printer in printers)
                {
                    if (printer != null)
                    {
                        if (printer["Name"].ToString().ToLower().Equals(printerName.ToLower()))
                        {
                            if (Type != null)
                            {
                                Type.Text = (printer["DriverName"] == null ? "" : System.Convert.ToString(printer["DriverName"]));
                                Location.Text = (printer["PortName"] == null ? "" : System.Convert.ToString(printer["PortName"]));
                                Comment.Text = (printer["Comment"] == null ? "" : System.Convert.ToString(printer["Comment"]));
                            }
                            if (printer["WorkOffline"].ToString().ToLower().Equals("true") || printer["PrinterStatus"].Equals(7))
                            {
                                online = false;
                                break;
                            }
                            else
                            {
                                online = true;
                                break;
                            }
                        }
                    }
                    else
                    {
                        
                        break;
                    }
                }
                printers.Dispose();
            }
            m.Dispose();
            return online;
        }
        public static System.Windows.Forms.DialogResult GTSysMessageBox(string[] errorlist,GTSysOne.Class.Utility.clsGlobal.enMessageBoxButton  Button,GTSysOne.Class.Utility.clsGlobal.enMessageBoxIcon Icon,string Header = "Error")
        {
            System.Windows.Forms.DialogResult DR = new System.Windows.Forms.DialogResult();
            using (var F = new GTSysOne.Gui.Main.frmMessageBox(errorlist, Button, Icon, Header))
            {
                F.ShowDialog();
                F.Dispose();
                DR = F.DR;
            }
            return DR;
        }

        public static string CheckLicensed()
        {
            switch (System.Convert.ToInt32(GTSysOne.Class.Document.clsDoc_Lcg.ScalarValue(GTSysOne.Class.Document.clsDoc_Lcg.Value(0, 0))))
            {
                case 1://have license
                    switch (System.Convert.ToInt32(GTSysOne.Class.MasterFile.clsMas_Establishment.ScalarValue(GTSysOne.Class.MasterFile.clsMas_Establishment.Value(0, 1))))
                    {
                        case 1://database not copyrighted or modified
                            string pass = "Pass";
                            System.Data.DataTable license = GTSysOne.Class.MasterFile.clsMas_Station.ShowTable(GTSysOne.Class.MasterFile.clsMas_Station.Value(0, 0, GTSysOne.Class.Utility.clsGlobal.Instance().STATIONCPU));
                            switch (license.Rows.Count)
                            {
                                case 0:
                                    GTSysOne.Class.Utility.clsGlobal.Instance().LicenseAction = GTSysOne.Class.Utility.clsGlobal.myLicenseStatus.Copyright;
                                    break;
                                default:
                                    switch(System.Convert.ToInt32(license.Rows[0]["VOIDSTAT"]))
                                    {
                                        case 0:
                                            try
                                            {
                                                #region Writing
                                                GTSysOne.Class.Utility.clsGlobal.Instance().COLICENSE = System.Convert.ToString(license.Rows[0]["LCONTROL"]);
                                                GTSysOne.Class.Utility.clsGlobal.Instance().ESTABLISHMENTLICENSE = System.Convert.ToString(license.Rows[0]["ECONTROL"]);

                                                GTSysOne.Class.Utility.clsGlobal.Instance().ESTABLISHMENTCPU = System.Convert.ToString(license.Rows[0]["ESTCPU"]);
                                                GTSysOne.Class.Utility.clsGlobal.Instance().STATIONCPU = System.Convert.ToString(license.Rows[0]["STATCPU"]);

                                                GTSysOne.Class.Utility.clsGlobal.Instance().CO_USAGE = System.Convert.ToInt32(license.Rows[0]["CO_USAGE"]);
                                                GTSysOne.Class.Utility.clsGlobal.Instance().EST_USAGE = System.Convert.ToInt32(license.Rows[0]["EST_USAGE"]);
                                                GTSysOne.Class.Utility.clsGlobal.Instance().STAT_USAGE = System.Convert.ToInt32(license.Rows[0]["STAT_USAGE"]);

                                                GTSysOne.Class.Utility.clsGlobal.Instance().LICENSEID = System.Convert.ToString(license.Rows[0]["LICID"]);
                                                GTSysOne.Class.Utility.clsGlobal.Instance().COMPANYID = System.Convert.ToString(license.Rows[0]["COID"]);
                                                GTSysOne.Class.Utility.clsGlobal.Instance().ESTABLISHMENTID = System.Convert.ToString(license.Rows[0]["ESTID"]);
                                                GTSysOne.Class.Utility.clsGlobal.Instance().STATIONID = System.Convert.ToString(license.Rows[0]["STATID"]);

                                                GTSysOne.Class.Utility.clsGlobal.Instance().CONAME = System.Convert.ToString(license.Rows[0]["CONAME"]);
                                                GTSysOne.Class.Utility.clsGlobal.Instance().ESTABLISHMENTNAME = System.Convert.ToString(license.Rows[0]["ENAME"]);
                                                GTSysOne.Class.Utility.clsGlobal.Instance().ESTABLISHMENTSHORTNAME = System.Convert.ToString(license.Rows[0]["ESHORTNAME"]);
                                                GTSysOne.Class.Utility.clsGlobal.Instance().STATIONNAME = System.Convert.ToString(license.Rows[0]["UNAME"]);
                                                GTSysOne.Class.Utility.clsGlobal.Instance().STATIONSHORTNAME = System.Convert.ToString(license.Rows[0]["USHORTNAME"]);

                                                GTSysOne.Class.Utility.clsGlobal.Instance().STATIONRUNNING = System.Convert.ToBoolean(license.Rows[0]["Running"]);
                                                GTSysOne.Class.Utility.clsGlobal.Instance().LANGUAGE = System.Convert.ToString(license.Rows[0]["LANG"]);
                                                GTSysOne.Class.Utility.clsGlobal.Instance().ALLOW_EDIT_LINE_TOTAL = System.Convert.ToBoolean(license.Rows[0]["ALLOWEDITLINETOTAL"]);
                                                GTSysOne.Class.Utility.clsGlobal.Instance().THEME = System.Convert.ToString(license.Rows[0]["THEME"]);
                                                GTSysOne.Class.Utility.clsGlobal.Instance().STATIONisHQ = System.Convert.ToBoolean(license.Rows[0]["HQ"]);


                                                GTSysOne.Class.Utility.clsGlobal.Instance().Show_Favorites = GTSysOne.Class.Utility.clsUtility.NullToValue(license.Rows[0]["showfavorites"]);
                                                GTSysOne.Class.Utility.clsGlobal.Instance().Auto_Hide_Navigation = GTSysOne.Class.Utility.clsUtility.NullToValue(license.Rows[0]["autohidenavigation"]);
                                                GTSysOne.Class.Utility.clsGlobal.Instance().Show_Stats = GTSysOne.Class.Utility.clsUtility.NullToValue(license.Rows[0]["showstats"]);
                                                GTSysOne.Class.Utility.clsGlobal.Instance().Auto_Hide_Stats = GTSysOne.Class.Utility.clsUtility.NullToValue(license.Rows[0]["autohidestats"]);
                                                GTSysOne.Class.Utility.clsGlobal.Instance().Show_Functions = GTSysOne.Class.Utility.clsUtility.NullToValue(license.Rows[0]["showfunctions"]);



                                                string[] xKEY = GTSysOne.Class.Utility.clsEncryption.JayDhreiZIP.Decrypt(System.Convert.ToString(license.Rows[0]["ECONTROL"]), "").Split('*');
                                                GTSysOne.Class.Utility.clsGlobal.Instance().LICENSETYPE = System.Convert.ToString(xKEY[0]);
                                                GTSysOne.Class.Utility.clsGlobal.Instance().MODULE = System.Convert.ToString(xKEY[1]).Split(',');
                                                GTSysOne.Class.Utility.clsGlobal.Instance().TOTALCOMPANY = System.Convert.ToInt32(xKEY[2]);
                                                GTSysOne.Class.Utility.clsGlobal.Instance().TOTALESTABLISHMENT = System.Convert.ToInt32(xKEY[3]);
                                                GTSysOne.Class.Utility.clsGlobal.Instance().TOTALSTATION = System.Convert.ToInt32(xKEY[4]);
                                                GTSysOne.Class.Utility.clsGlobal.Instance().DATECREATE = System.Convert.ToString(xKEY[5]);
                                                GTSysOne.Class.Utility.clsGlobal.Instance().TRIALDAYS = System.Convert.ToInt32(xKEY[6]);
                                                GTSysOne.Class.Utility.clsGlobal.Instance().SUBSCRIPTIONEXPIRED = System.Convert.ToString(xKEY[7]);
                                                GTSysOne.Class.Utility.clsGlobal.Instance().CLIENTNO = System.Convert.ToString(xKEY[8]);

                                                #endregion

                                                #region Validation of Days
                                                string[] subscription = GTSysOne.Class.Utility.clsGlobal.Instance().SUBSCRIPTIONEXPIRED.Split('-');
                                                System.DateTime tempSubscription = new System.DateTime(System.Convert.ToInt32(subscription[0]), System.Convert.ToInt32(subscription[1]), System.Convert.ToInt32(subscription[2]));
                                                switch (GTSysOne.Class.Utility.clsGlobal.Instance().TRIALDAYS)
                                                {
                                                    case 0:
                                                        switch (GTSysOne.Class.Utility.clsGlobal.Instance().LICENSETYPE)
                                                        {
                                                            case "D":
                                                                GTSysOne.Class.Utility.clsGlobal.Instance().LicenseDisplay = "  Demo Version™";
                                                                GTSysOne.Class.Utility.clsGlobal.Instance().LicenseAction = GTSysOne.Class.Utility.clsGlobal.myLicenseStatus.Demo;
                                                                break;
                                                            default:
                                                                System.TimeSpan TimeRemainFull = tempSubscription.Subtract(System.Convert.ToDateTime(GTSysOne.Class.Utility.clsUtility.SERVERDATE()));
                                                                if (TimeRemainFull.Days < 30 && TimeRemainFull.Days >= 0)
                                                                {
                                                                    GTSysOne.Class.Utility.clsGlobal.Instance().LicenseAction = GTSysOne.Class.Utility.clsGlobal.myLicenseStatus.AlmostExpiredSubscription;
                                                                    GTSysOne.Class.Utility.clsGlobal.Instance().LicenseDisplay = "  [ Maximum 30 Days Remaining of Subscription and it will expire on  " + GTSysOne.Class.Utility.clsGlobal.Instance().SUBSCRIPTIONEXPIRED + "]";
                                                                }
                                                                else if (TimeRemainFull.Days <= 0)
                                                                {
                                                                    GTSysOne.Class.Utility.clsGlobal.Instance().LicenseAction = GTSysOne.Class.Utility.clsGlobal.myLicenseStatus.ExpiredSubscription;
                                                                    GTSysOne.Class.Utility.clsGlobal.Instance().LicenseDisplay = "  [ Subscription Expired :" + GTSysOne.Class.Utility.clsGlobal.Instance().SUBSCRIPTIONEXPIRED.ToString() + "]";
                                                                }
                                                                else
                                                                {
                                                                    GTSysOne.Class.Utility.clsGlobal.Instance().LicenseAction = GTSysOne.Class.Utility.clsGlobal.myLicenseStatus.FullVersion;
                                                                    GTSysOne.Class.Utility.clsGlobal.Instance().LicenseDisplay = "  Licensed™";
                                                                }
                                                                break;
                                                        }
                                                        break;
                                                    default:
                                                        string[] CreatedDateTime = GTSysOne.Class.Utility.clsGlobal.Instance().DATECREATE.Split('-');
                                                        System.DateTime tempCreatedDateTime = new System.DateTime(System.Convert.ToInt32(CreatedDateTime[0]), System.Convert.ToInt32(CreatedDateTime[1]), System.Convert.ToInt32(CreatedDateTime[2]));
                                                        System.TimeSpan TimeRemainTrial = tempCreatedDateTime.AddDays(GTSysOne.Class.Utility.clsGlobal.Instance().TRIALDAYS).Subtract(System.Convert.ToDateTime(GTSysOne.Class.Utility.clsUtility.SERVERDATE()));
                                                        if (TimeRemainTrial.Days >= 0)
                                                        {
                                                            if (TimeRemainTrial.Days >= 0 || TimeRemainTrial.Hours >= 0)
                                                            {
                                                                if (TimeRemainTrial.Hours > 0 || TimeRemainTrial.Minutes > 0)
                                                                {
                                                                    GTSysOne.Class.Utility.clsGlobal.Instance().LicenseAction = GTSysOne.Class.Utility.clsGlobal.myLicenseStatus.Trial;
                                                                    GTSysOne.Class.Utility.clsGlobal.Instance().LicenseDisplay = "  [ " + GTSysOne.Class.Utility.clsGlobal.Instance().LicenseAction + " Version With " + TimeRemainTrial.Days + " day" + (TimeRemainTrial.Days > 1 ? "s" : "") + "," + TimeRemainTrial.Hours + " hour" + (TimeRemainTrial.Hours > 1 ? "s" : "") + " and " + TimeRemainTrial.Minutes + " minute" + (TimeRemainTrial.Minutes > 1 ? "s" : "") + " remaining. Please contact Global Technology System for more info. ]";
                                                                }
                                                                else
                                                                {
                                                                    GTSysOne.Class.Utility.clsGlobal.Instance().LicenseAction = GTSysOne.Class.Utility.clsGlobal.myLicenseStatus.TrialExpired;
                                                                    //GTSysOne.Class.Utility.clsGlobal.Instance().canAdd = true;
                                                                    //GTSysOne.Class.Utility.clsGlobal.Instance().canEdit = true;
                                                                }
                                                            }
                                                            else
                                                            {
                                                                GTSysOne.Class.Utility.clsGlobal.Instance().LicenseAction = GTSysOne.Class.Utility.clsGlobal.myLicenseStatus.TrialExpired;
                                                                //GTSysOne.Class.Utility.clsGlobal.Instance().canAdd = true;
                                                                //GTSysOne.Class.Utility.clsGlobal.Instance().canEdit = true;
                                                            }
                                                        }
                                                        else
                                                        {
                                                            GTSysOne.Class.Utility.clsGlobal.Instance().LicenseAction = GTSysOne.Class.Utility.clsGlobal.myLicenseStatus.TrialExpired;
                                                            //modGlobal.modGlobal.Instance().canAdd = true;
                                                            //modGlobal.modGlobal.Instance().canEdit = true;
                                                        }
                                                        break;
                                                }
                                                #endregion

                                                #region Valid
                                                switch (pass)
                                                {
                                                    case "Fail Edition":
                                                    case "Fail Key Type":
                                                        GTSysOne.Class.Utility.clsGlobal.Instance().LicenseAction = GTSysOne.Class.Utility.clsGlobal.myLicenseStatus.Copyright;
                                                        break;
                                                    default:
                                                        pass = "Welcome";
                                                        break;
                                                }
                                                #endregion

                                                GTSysOne.Class.Utility.clsUtility.UPDATERUNNINGCPU(true);
                                            }
                                            catch (System.Exception idris)
                                            {
                                                GTSysOne.Class.Utility.clsUtility.GTSysMessageBox(new string[]
                                                    { "Theres Something Trouble With Your License."
                                                    , @"Either your License was an old version or Your GTSysOne 
                                                        Software is a new version but license is old
                                                        .Please contact GTS for assistance."
                                                    , "Please Select Recover Button"
                                                    , "Additional Error Message:\n" + idris.Message }
                                                    , GTSysOne.Class.Utility.clsGlobal.enMessageBoxButton.OK
                                                    , GTSysOne.Class.Utility.clsGlobal.enMessageBoxIcon.Stop
                                                    , "License is Down");
                                                GTSysOne.Class.Utility.clsGlobal.Instance().LicenseAction = GTSysOne.Class.Utility.clsGlobal.myLicenseStatus.Copyright;
                                            }
                                            break;
                                        case 1:
                                        case 2:
                                        case 3:
                                        case 4:
                                            GTSysOne.Class.Utility.clsGlobal.Instance().LicenseAction = GTSysOne.Class.Utility.clsGlobal.myLicenseStatus.DeactivatedLSEU;
                                            break;
                                    }
                                    break;
                            }
                            break;
                        case 0:
                            GTSysOne.Class.Utility.clsGlobal.Instance().LicenseAction = GTSysOne.Class.Utility.clsGlobal.myLicenseStatus.Copyright;
                            break;
                    }
                    break;
                case 0:
                    GTSysOne.Class.Utility.clsGlobal.Instance().LicenseAction = GTSysOne.Class.Utility.clsGlobal.myLicenseStatus.UnLicensed;
                    break;
            }
            return "";
        }
        public static string Proceed()
        {
            switch (GTSysOne.Class.Utility.clsGlobal.Instance().LicenseAction)
            {
                case GTSysOne.Class.Utility.clsGlobal.myLicenseStatus.UnLicensed:
                case GTSysOne.Class.Utility.clsGlobal.myLicenseStatus.Copyright:
                    if (!IsRepeat)
                    {
                        switch (GTSysOne.Class.Utility.clsGlobal.Instance().LicenseAction)
                        {
                            case GTSysOne.Class.Utility.clsGlobal.myLicenseStatus.Copyright:
                                GTSysOne.Class.Utility.clsUtility.GTSysMessageBox(new string[] 
                                    { "If Your License Provided From Head Quarter,You Need To Click 'Register' Button And Select Establishment"
                                    , "If Your Station Was Reformat or Change Hardware, Just Click 'Recover' Button And Select Your Station Before"
                                    , "If Your Station Was Not Registered Since From the Beginning Just Click 'Register' Button And Select Station"
                                    , "If Your License Was Not From HQ Else You Are Copying of Database Which Was Prohibited."
                                    , "This program is protected by law as described by help/about."
                                    , "Please Contact GTS™ for more Info." }
                                    , GTSysOne.Class.Utility.clsGlobal.enMessageBoxButton.OK
                                    , GTSysOne.Class.Utility.clsGlobal.enMessageBoxIcon.Warning
                                    , "Please Take note Of The Following.");
                                GTSysOne.Class.Utility.clsGlobal.Instance().LicenseAction = GTSysOne.Class.Utility.clsGlobal.Instance().LicenseAction;
                                break;
                            case GTSysOne.Class.Utility.clsGlobal.myLicenseStatus.UnLicensed:
                                GTSysOne.Class.Utility.clsUtility.GTSysMessageBox(new string[] { "GTSysOne Server has no license detected.", "'Register' - This is the first time purchase the GTSysOne Software.", "'Recover' - In case you reformat your Machine and restore database again", "For More Informtion.Please Contact GTS™ for more Info." }, GTSysOne.Class.Utility.clsGlobal.enMessageBoxButton.OK, GTSysOne.Class.Utility.clsGlobal.enMessageBoxIcon.Information, "No License.");
                                GTSysOne.Class.Utility.clsGlobal.Instance().LicenseAction = GTSysOne.Class.Utility.clsGlobal.Instance().LicenseAction;
                                break;
                        }
                    }
                    using (var frmRR = new GTSysOne.Gui.Main.frmRegister_Recover())
                    {
                        frmRR.ShowDialog();
                        switch (frmRR.Choices)
                        {
                            case 1:
                                #region REGISTER
                                frmRR.Dispose();
                                using (var frmRegu = new GTSysOne.Gui.Main.frmRegistration())
                                {
                                    frmRegu.ShowDialog();
                                    frmRegu.Dispose();
                                    IsRepeat = true;
                                    CheckLicensed();
                                    Proceed();
                                }
                                #endregion
                                break;
                            case 2:
                                frmRR.Dispose();
                                using (var frmRec = new GTSysOne.Gui.Main.frmRecover())
                                {
                                    frmRec.ShowDialog();
                                    frmRec.Dispose();
                                    IsRepeat = true;
                                    CheckLicensed();
                                    Proceed();
                                }
                                break;
                            case 3:
                                frmRR.Dispose();
                                GTSysOne.Class.Utility.clsGlobal.Instance().LicenseAction = GTSysOne.Class.Utility.clsGlobal.myLicenseStatus.JustClose;
                                break;
                        }
                    }
                    break;
                case GTSysOne.Class.Utility.clsGlobal.myLicenseStatus.TrialExpired:
                    if (GTSysOne.Class.Utility.clsUtility.GTSysMessageBox(new string[] { "Your Trial Version already expired would you like to Purchase Full Version?" }, GTSysOne.Class.Utility.clsGlobal.enMessageBoxButton.YesNo, GTSysOne.Class.Utility.clsGlobal.enMessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No)
                    {
                        GTSysOne.Class.Utility.clsGlobal.Instance().LicenseAction = GTSysOne.Class.Utility.clsGlobal.myLicenseStatus.JustClose;
                    }
                    else
                    {
                        GTSysOne.Gui.Main.frmLicense.Instance.ShowDialog();
                        GTSysOne.Class.Utility.clsGlobal.Instance().LogOut = false;
                        CheckLicensed();
                        Proceed();
                    }
                    break;
                case GTSysOne.Class.Utility.clsGlobal.myLicenseStatus.LicenseModified:
                    GTSysOne.Class.Utility.clsUtility.GTSysMessageBox(new string[] { "The License you've entered was modified by some anonymous,Please try Again" }, GTSysOne.Class.Utility.clsGlobal.enMessageBoxButton.OK, GTSysOne.Class.Utility.clsGlobal.enMessageBoxIcon.Warning, "Licensed Modified!");
                    using (var frmReg = new GTSysOne.Gui.Main.frmRegistration())
                    {
                        frmReg.ShowDialog();
                        frmReg.Dispose();
                        if (GTSysOne.Class.Utility.clsGlobal.Instance().LicenseAction == GTSysOne.Class.Utility.clsGlobal.myLicenseStatus.Trial)
                        {
                            CheckLicensed();
                            Proceed();
                        }
                        else
                        {
                            GTSysOne.Class.Utility.clsGlobal.Instance().LicenseAction = GTSysOne.Class.Utility.clsGlobal.myLicenseStatus.JustClose;
                        } 
                    }
                    break;
                case GTSysOne.Class.Utility.clsGlobal.myLicenseStatus.DeactivatedLSEU:
                    GTSysOne.Class.Utility.clsUtility.GTSysMessageBox(new string[] { "Opps!! Your Unit | PC is belong to the following Company,Establishment or Unit.\nWhich currently deactivated.", "Please contact GTS Production for more info." }, GTSysOne.Class.Utility.clsGlobal.enMessageBoxButton.OK, GTSysOne.Class.Utility.clsGlobal.enMessageBoxIcon.Warning, "Company,Establishment,Unit");
                    GTSysOne.Class.Utility.clsGlobal.Instance().LicenseAction = GTSysOne.Class.Utility.clsGlobal.myLicenseStatus.JustClose;
                    break;
                case GTSysOne.Class.Utility.clsGlobal.myLicenseStatus.JustClose:
                    GTSysOne.Class.Utility.clsGlobal.Instance().LicenseAction = GTSysOne.Class.Utility.clsGlobal.myLicenseStatus.JustClose;
                    break;
                case GTSysOne.Class.Utility.clsGlobal.myLicenseStatus.Demo:
                case GTSysOne.Class.Utility.clsGlobal.myLicenseStatus.Trial:
                case GTSysOne.Class.Utility.clsGlobal.myLicenseStatus.FullVersion:
                case GTSysOne.Class.Utility.clsGlobal.myLicenseStatus.AlmostExpiredSubscription:
                case GTSysOne.Class.Utility.clsGlobal.myLicenseStatus.ExpiredSubscription:
                    GTSysOne.Class.Utility.clsGlobal.Instance().LicenseAction = GTSysOne.Class.Utility.clsGlobal.Instance().LicenseAction;
                    break;
            }
            return "";
        }
        public static string UPDATERUNNINGCPU(bool stats)
        {
            GTSysOne.Class.Utility.clsGlobal.Instance().NewPK = 
                GTSysOne.Class.MasterFile.clsMas_Station.Save(GTSysOne.Class.MasterFile.clsMas_Station.Value(2, 1
                           , GTSysOne.Class.Utility.clsGlobal.Instance().STATIONCPU
                           , ""
                           , false
                           , false
                           , ""
                           , ""
                           , ""
                           , ""
                           , ""
                           , ""
                           , ""
                           , ""
                           , ""
                           , ""
                           , false
                           , stats
                           , ""
                           , ""
                           , ""
                           , false
                           , ""
                           , false
                           , false
                           , false
                           , false
                           , false
                           , "0"));
            return GTSysOne.Class.Utility.clsGlobal.Instance().NewPK;
        }
        public static string SERVERDATE()
        {
            return System.Convert.ToString(GTSysOne.Class.MasterFile.clsMas_Station.ScalarValue(GTSysOne.Class.MasterFile.clsMas_Station.Value(0,1,GTSysOne.Class.Utility.clsGlobal.Instance().COMPANYID)));
        }

        public static System.Data.DataTable GetModule()
        {
            return (System.Data.DataTable)GTSysOne.Class.Mapping.clsMap_Module.ShowTable(GTSysOne.Class.Mapping.clsMap_Module.Value(0,0));
        }
        public static System.Data.DataTable GetFunction()
        {
            return (System.Data.DataTable)GTSysOne.Class.MasterFile.clsMas_Function.ShowTable(GTSysOne.Class.MasterFile.clsMas_Function.Value(0, 0));
        }
        public static int Modulator(DevExpress.XtraNavBar.NavBarControl N, System.Windows.Forms.ImageList IL, System.Windows.Forms.ImageList ILarge)
        {
            DevExpress.XtraNavBar.NavBarGroup G = null;
            DevExpress.XtraNavBar.NavBarItem I = null;
            for (int ctr = 0; ctr < GTSysOne.Class.Utility.clsGlobal.Instance().Module.Rows.Count;ctr++)
            {
                if (ModulatorSecurity(System.Convert.ToString(GTSysOne.Class.Utility.clsGlobal.Instance().Module.Rows[ctr]["id"])))
                {
                    G = new DevExpress.XtraNavBar.NavBarGroup();
                    G.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.SmallIconsText;
                    G.Name = System.Convert.ToString(GTSysOne.Class.Utility.clsGlobal.Instance().Module.Rows[ctr]["id"]);
                    G.Caption = System.Convert.ToString(GTSysOne.Class.Utility.clsGlobal.Instance().Module.Rows[ctr]["Name"]);
                    G.LargeImage = ILarge.Images[System.Convert.ToString(GTSysOne.Class.Utility.clsGlobal.Instance().Module.Rows[ctr]["id"]) + ".png"];
                    System.Data.DataRow[] Row = GTSysOne.Class.Utility.clsGlobal.Instance().Function.Select(" MapId = '" + GTSysOne.Class.Utility.clsGlobal.Instance().Module.Rows[ctr]["id"] + @"'");
                    if (Row.Length > 0)
                    {
                        System.Data.DataTable dtFunction = Row.CopyToDataTable();
                        for (int sctr = 0; sctr < dtFunction.Rows.Count; sctr++)
                        {
                            I = new DevExpress.XtraNavBar.NavBarItem();
                            I.Name = System.Convert.ToString(dtFunction.Rows[sctr]["id"]);
                            I.Tag = dtFunction.Rows[sctr]["id"];
                            if (GTSysOne.Class.Utility.clsGlobal.Instance().Admin && System.Convert.ToString(dtFunction.Rows[sctr]["id"]) == "7")
                            {
                                I.Visible = true;
                            }
                            else
                            {
                                I.Visible = PrivilegeValidator(GTSysOne.Class.Utility.clsGlobal.Instance().Privilege.Rows.Find("9999" + System.Convert.ToString(dtFunction.Rows[sctr]["id"])));
                            }
                            I.Caption = System.Convert.ToString(dtFunction.Rows[sctr]["name"]);
                            I.SmallImage = IL.Images[System.Convert.ToString(dtFunction.Rows[sctr]["name"]) + ".png"];
                            I.LinkPressed += new DevExpress.XtraNavBar.NavBarLinkEventHandler(GTSysOne.Gui.Main.frmMain.FUNCTION_CLICKED);
                            G.ItemLinks.Add(I);
                        }
                    }
                    N.Groups.Add(G);
                }
            }
            return 0;
        }
        private static bool ModulatorSecurity(string Sw)
        {
            bool Grant = false;
            for (int ctr = 0; ctr < GTSysOne.Class.Utility.clsGlobal.Instance().MODULE.Length; ctr++)
            {
                if (System.Convert.ToString(GTSysOne.Class.Utility.clsGlobal.Instance().MODULE[ctr]) == Sw)
                {
                    Grant = true;
                    break;
                }
            }
            return Grant;
        }
        public static int AddAccordion(DevExpress.XtraBars.Navigation.AccordionControl A ,string[] Element)
        {
            for (int ctr = 0; ctr < Element.Length;ctr++)
            {
               // A.Elements.Add()
            }
            return 0;
        }
        public static string Navigator(string Id, string IncrementType = "2", GTSysOne.Class.Utility.clsGlobal.myFunction F = GTSysOne.Class.Utility.clsGlobal.myFunction.User)
        {
            string Result = string.Empty;
            Result = System.Convert.ToString(GTSysOne.Class.Slip.clsSlip_Sequence.ScalarValue(
                GTSysOne.Class.Slip.clsSlip_Sequence.Value(0,0,Id,"0","0","0"
                , GTSysOne.Class.Utility.clsGlobal.Instance().COMPANYID
                , GTSysOne.Class.Utility.clsGlobal.Instance().ESTABLISHMENTID
                , GTSysOne.Class.Utility.clsGlobal.Instance().STATIONID
                , System.Convert.ToString((int)F)
                , GTSysOne.Class.Utility.clsGlobal.Instance().UserId
                , IncrementType
                , System.Convert.ToString((int)F)
                , 0)));
            return Result;
        }

        public static string Numbering(GTSysOne.Class.Utility.clsGlobal.myFunction F,bool Final = false, string MultipleSegment = "N/A")
        {
            GTSysOne.Class.Utility.clsGlobal.Instance().Commit = Final;
            return System.Convert.ToString(GTSysOne.Class.Document.clsDoc_NumberingSetup.ScalarValue(
                GTSysOne.Class.Document.clsDoc_NumberingSetup.Value(0
                , 4
                , MultipleSegment
                , string.Empty
                , (Final ? "1" : "0")
                , "0"
                , "0"
                , GTSysOne.Class.Utility.clsGlobal.Instance().COMPANYID
                , GTSysOne.Class.Utility.clsGlobal.Instance().ESTABLISHMENTID
                , GTSysOne.Class.Utility.clsGlobal.Instance().STATIONID
                , System.Convert.ToString((int)F)
                , GTSysOne.Class.Utility.clsGlobal.Instance().UserId
                , string.Empty
                , GTSysOne.Class.Utility.clsGlobal.Instance().COMPANYID
                , System.Convert.ToString((int)F)
                )
                ));
        }


        public static int Language(System.Windows.Forms.Control C,System.Reflection.Assembly A)
        {
            System.Resources.ResourceManager ResourceMan = new System.Resources.ResourceManager("GTSysOne.Res.Jay", A);
            System.Globalization.CultureInfo CultureInf = System.Globalization.CultureInfo.CreateSpecificCulture(GTSysOne.Class.Utility.clsGlobal.Instance().CultureInformation);
            //exitToolStripMenuItem.Text = ResourceMan.GetString("Exit_menu", CultureInf);

            return 0;
        }


        public static int UpdateRunningAccount(int Stat = 0)
        {
            GTSysOne.Class.Document.clsDoc_User.Save(GTSysOne.Class.Document.clsDoc_User.Value(2, 1, GTSysOne.Class.Utility.clsGlobal.Instance().UserId, "", System.Convert.ToString(Stat)));
            return 0;
        }

        public static int QueueUserInfoAndAccount(System.Data.DataSet d)
        {
            GTSysOne.Class.Utility.clsGlobal.Instance().UserId = System.Convert.ToString(d.Tables[0].Rows[0]["UserId"]);
            GTSysOne.Class.Utility.clsGlobal.Instance().UserName = System.Convert.ToString(d.Tables[0].Rows[0]["Uname"]);
            GTSysOne.Class.Utility.clsGlobal.Instance().Password = System.Convert.ToString(d.Tables[0].Rows[0]["Password"]);
            GTSysOne.Class.Utility.clsGlobal.Instance().Admin = System.Convert.ToBoolean(d.Tables[0].Rows[0]["admin"]);
            GTSysOne.Class.Utility.clsGlobal.Instance().COMPANYID = System.Convert.ToString(d.Tables[0].Rows[0]["CompanyId"]);
            if (GTSysOne.Class.Utility.clsGlobal.Instance().LANGUAGE == "")
            {
                System.Convert.ToString(d.Tables[0].Rows[0]["Language"]);
            }

            GTSysOne.Class.Utility.clsGlobal.Instance().CompanyAccess = d.Tables[1];
            GTSysOne.Class.Utility.clsGlobal.Instance().EstablishmentAccess = d.Tables[2];
            GTSysOne.Class.Utility.clsGlobal.Instance().Privilege = d.Tables[3];

            System.Data.DataColumn[] dpk = new System.Data.DataColumn[1];
            dpk[0] = GTSysOne.Class.Utility.clsGlobal.Instance().Privilege.Columns["map_sourced_action_id"];
            GTSysOne.Class.Utility.clsGlobal.Instance().Privilege.PrimaryKey = dpk;

            GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_Add_Company = PrivilegeValidator(GTSysOne.Class.Utility.clsGlobal.Instance().Privilege.Rows.Find(1));
            GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_Edit_Company = PrivilegeValidator(GTSysOne.Class.Utility.clsGlobal.Instance().Privilege.Rows.Find(2));
            GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_View_Company = PrivilegeValidator(GTSysOne.Class.Utility.clsGlobal.Instance().Privilege.Rows.Find(3));
            GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_Void_Company = PrivilegeValidator(GTSysOne.Class.Utility.clsGlobal.Instance().Privilege.Rows.Find(4));

            GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_Changed_Theme = PrivilegeValidator(GTSysOne.Class.Utility.clsGlobal.Instance().Privilege.Rows.Find(5));
            GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_Changed_Language = PrivilegeValidator(GTSysOne.Class.Utility.clsGlobal.Instance().Privilege.Rows.Find(6));

            GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_Add_User = PrivilegeValidator(GTSysOne.Class.Utility.clsGlobal.Instance().Privilege.Rows.Find(7));
            GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_Edit_User = PrivilegeValidator(GTSysOne.Class.Utility.clsGlobal.Instance().Privilege.Rows.Find(8));
            GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_View_User = PrivilegeValidator(GTSysOne.Class.Utility.clsGlobal.Instance().Privilege.Rows.Find(9));
            GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_Void_User = PrivilegeValidator(GTSysOne.Class.Utility.clsGlobal.Instance().Privilege.Rows.Find(10));

            GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_Add_NumberingSetup = PrivilegeValidator(GTSysOne.Class.Utility.clsGlobal.Instance().Privilege.Rows.Find(11));
            GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_Edit_NumberingSetup = PrivilegeValidator(GTSysOne.Class.Utility.clsGlobal.Instance().Privilege.Rows.Find(12));
            GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_View_NumberingSetup = PrivilegeValidator(GTSysOne.Class.Utility.clsGlobal.Instance().Privilege.Rows.Find(13));
            GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_Void_NumberingSetup = PrivilegeValidator(GTSysOne.Class.Utility.clsGlobal.Instance().Privilege.Rows.Find(14));

            GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_Add_Country = PrivilegeValidator(GTSysOne.Class.Utility.clsGlobal.Instance().Privilege.Rows.Find(15));
            GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_Edit_Country = PrivilegeValidator(GTSysOne.Class.Utility.clsGlobal.Instance().Privilege.Rows.Find(16));
            GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_View_Country = PrivilegeValidator(GTSysOne.Class.Utility.clsGlobal.Instance().Privilege.Rows.Find(17));
            GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_Void_Country = PrivilegeValidator(GTSysOne.Class.Utility.clsGlobal.Instance().Privilege.Rows.Find(18));

            GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_Add_Station = false;// PrivilegeValidator(GTSysOne.Class.Utility.clsGlobal.Instance().Privilege.Rows.Find(19));
            GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_Edit_Station = PrivilegeValidator(GTSysOne.Class.Utility.clsGlobal.Instance().Privilege.Rows.Find(20));
            GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_View_Station = PrivilegeValidator(GTSysOne.Class.Utility.clsGlobal.Instance().Privilege.Rows.Find(21));
            GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_Void_Station = PrivilegeValidator(GTSysOne.Class.Utility.clsGlobal.Instance().Privilege.Rows.Find(22));

            GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_Add_Establishment = PrivilegeValidator(GTSysOne.Class.Utility.clsGlobal.Instance().Privilege.Rows.Find(23));
            GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_Edit_Establishment = PrivilegeValidator(GTSysOne.Class.Utility.clsGlobal.Instance().Privilege.Rows.Find(24));
            GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_View_Establishment = PrivilegeValidator(GTSysOne.Class.Utility.clsGlobal.Instance().Privilege.Rows.Find(25));
            GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_Void_Establishment = PrivilegeValidator(GTSysOne.Class.Utility.clsGlobal.Instance().Privilege.Rows.Find(26));


            GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_Add_Allocation_Pattern = PrivilegeValidator(GTSysOne.Class.Utility.clsGlobal.Instance().Privilege.Rows.Find(27));
            GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_Edit_Allocation_Pattern = PrivilegeValidator(GTSysOne.Class.Utility.clsGlobal.Instance().Privilege.Rows.Find(28));
            GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_View_Allocation_Pattern = PrivilegeValidator(GTSysOne.Class.Utility.clsGlobal.Instance().Privilege.Rows.Find(29));
            GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_Void_Allocation_Pattern = PrivilegeValidator(GTSysOne.Class.Utility.clsGlobal.Instance().Privilege.Rows.Find(30));

            GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_Add_Group = PrivilegeValidator(GTSysOne.Class.Utility.clsGlobal.Instance().Privilege.Rows.Find(31));
            GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_Edit_Group = PrivilegeValidator(GTSysOne.Class.Utility.clsGlobal.Instance().Privilege.Rows.Find(32));
            GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_View_Group = PrivilegeValidator(GTSysOne.Class.Utility.clsGlobal.Instance().Privilege.Rows.Find(33));
            GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_Void_Group = PrivilegeValidator(GTSysOne.Class.Utility.clsGlobal.Instance().Privilege.Rows.Find(34));

            GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_Add_Region = PrivilegeValidator(GTSysOne.Class.Utility.clsGlobal.Instance().Privilege.Rows.Find(35));
            GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_Edit_Region = PrivilegeValidator(GTSysOne.Class.Utility.clsGlobal.Instance().Privilege.Rows.Find(36));
            GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_View_Region = PrivilegeValidator(GTSysOne.Class.Utility.clsGlobal.Instance().Privilege.Rows.Find(37));
            GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_Void_Region = PrivilegeValidator(GTSysOne.Class.Utility.clsGlobal.Instance().Privilege.Rows.Find(38));

            GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_Add_Price_Level = PrivilegeValidator(GTSysOne.Class.Utility.clsGlobal.Instance().Privilege.Rows.Find(39));
            GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_Edit_Price_Level = PrivilegeValidator(GTSysOne.Class.Utility.clsGlobal.Instance().Privilege.Rows.Find(40));
            GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_View_Price_Level = PrivilegeValidator(GTSysOne.Class.Utility.clsGlobal.Instance().Privilege.Rows.Find(41));
            GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_Void_Price_Level = PrivilegeValidator(GTSysOne.Class.Utility.clsGlobal.Instance().Privilege.Rows.Find(42));


            GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_Add_Tax_Area = PrivilegeValidator(GTSysOne.Class.Utility.clsGlobal.Instance().Privilege.Rows.Find(43));
            GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_Edit_Tax_Area = PrivilegeValidator(GTSysOne.Class.Utility.clsGlobal.Instance().Privilege.Rows.Find(44));
            GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_View_Tax_Area = PrivilegeValidator(GTSysOne.Class.Utility.clsGlobal.Instance().Privilege.Rows.Find(45));
            GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_Void_Tax_Area = PrivilegeValidator(GTSysOne.Class.Utility.clsGlobal.Instance().Privilege.Rows.Find(46));

            // Sales Quotation
            GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_Add_Sales_Quotation = PrivilegeValidator(GTSysOne.Class.Utility.clsGlobal.Instance().Privilege.Rows.Find(20000));
            GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_Edit_Sales_Quotation = PrivilegeValidator(GTSysOne.Class.Utility.clsGlobal.Instance().Privilege.Rows.Find(20001));
            GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_View_Sales_Quotation = PrivilegeValidator(GTSysOne.Class.Utility.clsGlobal.Instance().Privilege.Rows.Find(20002));

            // Sales Order
            GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_Add_Sales_Order = PrivilegeValidator(GTSysOne.Class.Utility.clsGlobal.Instance().Privilege.Rows.Find(20003));
            GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_Edit_Sales_Order = PrivilegeValidator(GTSysOne.Class.Utility.clsGlobal.Instance().Privilege.Rows.Find(20004));
            GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_View_Sales_Order = PrivilegeValidator(GTSysOne.Class.Utility.clsGlobal.Instance().Privilege.Rows.Find(20005));

            //Created by: Johnfrits Rejaba
            //Date: August 23, 2017
            //Identity Type
            GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_Add_Identity_Type = PrivilegeValidator(GTSysOne.Class.Utility.clsGlobal.Instance().Privilege.Rows.Find(70000));
            GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_Edit_Identy_Type = PrivilegeValidator(GTSysOne.Class.Utility.clsGlobal.Instance().Privilege.Rows.Find(70001));
            GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_View_Identy_Type = PrivilegeValidator(GTSysOne.Class.Utility.clsGlobal.Instance().Privilege.Rows.Find(70002));
            GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_Void_Identy_Type = PrivilegeValidator(GTSysOne.Class.Utility.clsGlobal.Instance().Privilege.Rows.Find(70003));

            //Created by: Johnfrits Rejaba
            //Date: August 23, 2017
            //Car Model
            GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_Add_Car_Model = PrivilegeValidator(GTSysOne.Class.Utility.clsGlobal.Instance().Privilege.Rows.Find(70004));
            GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_Edit_Car_Model = PrivilegeValidator(GTSysOne.Class.Utility.clsGlobal.Instance().Privilege.Rows.Find(70005));
            GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_View_Car_Model = PrivilegeValidator(GTSysOne.Class.Utility.clsGlobal.Instance().Privilege.Rows.Find(70006));
            GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_Void_Car_Model = PrivilegeValidator(GTSysOne.Class.Utility.clsGlobal.Instance().Privilege.Rows.Find(70007));

            //Created by: Johnfrits Rejaba
            //Date: August 23, 2017
            //Car Color
            GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_Add_Car_Color = PrivilegeValidator(GTSysOne.Class.Utility.clsGlobal.Instance().Privilege.Rows.Find(70008));
            GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_Edit_Car_Color = PrivilegeValidator(GTSysOne.Class.Utility.clsGlobal.Instance().Privilege.Rows.Find(70009));
            GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_View_Car_Color = PrivilegeValidator(GTSysOne.Class.Utility.clsGlobal.Instance().Privilege.Rows.Find(70010));
            GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_Void_Car_Color = PrivilegeValidator(GTSysOne.Class.Utility.clsGlobal.Instance().Privilege.Rows.Find(70011));

            //Created by: Johnfrits Rejaba
            //Date: August 24, 2017
            //Car Type
            GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_Add_Car_Type = PrivilegeValidator(GTSysOne.Class.Utility.clsGlobal.Instance().Privilege.Rows.Find(70012));
            GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_Edit_Car_Type = PrivilegeValidator(GTSysOne.Class.Utility.clsGlobal.Instance().Privilege.Rows.Find(70013));
            GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_View_Car_Type = PrivilegeValidator(GTSysOne.Class.Utility.clsGlobal.Instance().Privilege.Rows.Find(70014));
            GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_Void_Car_Type = PrivilegeValidator(GTSysOne.Class.Utility.clsGlobal.Instance().Privilege.Rows.Find(70015));

            //Created by: Johnfrits Rejaba
            //Date: August 24, 2017
            //Rent
            GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_Add_Rent = PrivilegeValidator(GTSysOne.Class.Utility.clsGlobal.Instance().Privilege.Rows.Find(70016));
            GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_Edit_Rent = PrivilegeValidator(GTSysOne.Class.Utility.clsGlobal.Instance().Privilege.Rows.Find(70017));
            GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_View_Rent = PrivilegeValidator(GTSysOne.Class.Utility.clsGlobal.Instance().Privilege.Rows.Find(70018));
            GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_Void_Rent = PrivilegeValidator(GTSysOne.Class.Utility.clsGlobal.Instance().Privilege.Rows.Find(70019));

            //Created by: Johnfrits Rejaba
            //Date: August 24, 2017
            //Renter
            GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_Add_Renter = PrivilegeValidator(GTSysOne.Class.Utility.clsGlobal.Instance().Privilege.Rows.Find(70020));
            GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_Edit_Renter = PrivilegeValidator(GTSysOne.Class.Utility.clsGlobal.Instance().Privilege.Rows.Find(70021));
            GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_View_Renter = PrivilegeValidator(GTSysOne.Class.Utility.clsGlobal.Instance().Privilege.Rows.Find(70022));
            GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_Void_Renter = PrivilegeValidator(GTSysOne.Class.Utility.clsGlobal.Instance().Privilege.Rows.Find(70023));

            //Created by: Johnfrits Rejaba
            //Date: September 5, 2017
            //Driver
            GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_Add_Driver = PrivilegeValidator(GTSysOne.Class.Utility.clsGlobal.Instance().Privilege.Rows.Find(70024));
            GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_Edit_Driver = PrivilegeValidator(GTSysOne.Class.Utility.clsGlobal.Instance().Privilege.Rows.Find(70025));
            GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_View_Driver = PrivilegeValidator(GTSysOne.Class.Utility.clsGlobal.Instance().Privilege.Rows.Find(70026));
            GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_Void_Driver = PrivilegeValidator(GTSysOne.Class.Utility.clsGlobal.Instance().Privilege.Rows.Find(70027));

            //Created by: Johnfrits Rejaba
            //Date: September 5, 2017
            //Tax
            GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_Add_Tax = PrivilegeValidator(GTSysOne.Class.Utility.clsGlobal.Instance().Privilege.Rows.Find(70028));
            GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_Edit_Tax = PrivilegeValidator(GTSysOne.Class.Utility.clsGlobal.Instance().Privilege.Rows.Find(70029));
            GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_View_Tax = PrivilegeValidator(GTSysOne.Class.Utility.clsGlobal.Instance().Privilege.Rows.Find(70030));
            GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_Void_Tax = PrivilegeValidator(GTSysOne.Class.Utility.clsGlobal.Instance().Privilege.Rows.Find(70031));


            //Created by: Johnfrits Rejaba
            //Date: September 5, 2017
            //Fixed Assets
            GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_Add_Fixed_Assets = PrivilegeValidator(GTSysOne.Class.Utility.clsGlobal.Instance().Privilege.Rows.Find(70032));
            GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_Edit_Fixed_Assets = PrivilegeValidator(GTSysOne.Class.Utility.clsGlobal.Instance().Privilege.Rows.Find(70033));
            GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_View_Fixed_Assets = PrivilegeValidator(GTSysOne.Class.Utility.clsGlobal.Instance().Privilege.Rows.Find(70034));
            GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_Void_Fixed_Assets = PrivilegeValidator(GTSysOne.Class.Utility.clsGlobal.Instance().Privilege.Rows.Find(70035));

            //Created by: Johnfrits Rejaba
            //Date: September 5, 2017
            //Credit Card
            GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_Add_Credit_Card = PrivilegeValidator(GTSysOne.Class.Utility.clsGlobal.Instance().Privilege.Rows.Find(70036));
            GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_Add_Credit_Card = PrivilegeValidator(GTSysOne.Class.Utility.clsGlobal.Instance().Privilege.Rows.Find(70037));
            GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_Add_Credit_Card = PrivilegeValidator(GTSysOne.Class.Utility.clsGlobal.Instance().Privilege.Rows.Find(70038));
            GTSysOne.Class.Utility.clsGlobal.Instance().Allow_To_Add_Credit_Card = PrivilegeValidator(GTSysOne.Class.Utility.clsGlobal.Instance().Privilege.Rows.Find(70039));

            //FullItemList();

            GTSysOne.Class.Utility.clsUtility.INITIALIZE_REPORT(GTSysOne.Class.Utility.clsGlobal.myFunction.Rent
                , new GTSysOne.Gui.Report.XrptFile.xrptRent()
                , "xrptRent"
                , "1-1---1-1-1---1--1~1");    //initialize report during log in here//


            return 0;
        }
        public static int InventorySettings() 
        {
            System.Data.DataTable dtRecord = GTSysOne.Class.MasterFile.clsMas_InventorySettings.ShowTable(GTSysOne.Class.MasterFile.clsMas_InventorySettings.Value(0, 1, string.Empty, string.Empty, false, false, GTSysOne.Class.Utility.clsGlobal.Instance().COMPANYID));
            if (dtRecord.Rows.Count > 0)
            {

                GTSysOne.Class.Utility.clsGlobal.Instance().Use_Per_Misc_Code = System.Convert.ToBoolean(System.Convert.ToInt32(dtRecord.Select(" map_sourced_inventory_settings_id = '1000' ")[0]["value"]));

                GTSysOne.Class.Utility.clsGlobal.Instance().WeightedBarcodeLength = System.Convert.ToInt32(dtRecord.Select(" map_sourced_inventory_settings_id = '1001' ")[0]["value"]);
                GTSysOne.Class.Utility.clsGlobal.Instance().WeightedBarcodeControlNumber = System.Convert.ToInt32(dtRecord.Select(" map_sourced_inventory_settings_id = '1002' ")[0]["value"]);

                GTSysOne.Class.Utility.clsGlobal.Instance().MiscCodeStart = System.Convert.ToInt32(dtRecord.Select(" map_sourced_inventory_settings_id = '1003' ")[0]["value"]);
                GTSysOne.Class.Utility.clsGlobal.Instance().MiscCodeLength = System.Convert.ToInt32(dtRecord.Select(" map_sourced_inventory_settings_id = '1004' ")[0]["value"]);

                GTSysOne.Class.Utility.clsGlobal.Instance().WholeNumberStart = System.Convert.ToInt32(dtRecord.Select(" map_sourced_inventory_settings_id = '1005' ")[0]["value"]);
                GTSysOne.Class.Utility.clsGlobal.Instance().WholeNumberLength = System.Convert.ToInt32(dtRecord.Select(" map_sourced_inventory_settings_id = '1006' ")[0]["value"]);

                GTSysOne.Class.Utility.clsGlobal.Instance().DecimalNumberStart = System.Convert.ToInt32(dtRecord.Select(" map_sourced_inventory_settings_id = '1007' ")[0]["value"]);
                GTSysOne.Class.Utility.clsGlobal.Instance().DecimalNumberLength = System.Convert.ToInt32(dtRecord.Select(" map_sourced_inventory_settings_id = '1008' ")[0]["value"]);

                GTSysOne.Class.Utility.clsGlobal.Instance().Use_Whole_And_Decimal_As_Price = System.Convert.ToBoolean(System.Convert.ToInt32(dtRecord.Select(" map_sourced_inventory_settings_id = '1009' ")[0]["value"]));

            }
            return 0;
        }
        public static System.Data.DataTable ScanBarcode(string Barcode, string Warehouse, string PriceLevel)
        {
            System.Data.DataTable dt = new System.Data.DataTable();
            if (Barcode.Length >= GTSysOne.Class.Utility.clsGlobal.Instance().WeightedBarcodeLength)
            {
                if (System.Convert.ToString(GTSysOne.Class.Utility.clsGlobal.Instance().WeightedBarcodeControlNumber)
                    == Barcode.Substring(0, System.Convert.ToString(GTSysOne.Class.Utility.clsGlobal.Instance()
                    .WeightedBarcodeControlNumber).Length))
                {

                    double dblWholeNumberQntyPrice = double.Parse(Barcode.Substring(GTSysOne.Class.Utility.clsGlobal.Instance().WholeNumberStart, GTSysOne.Class.Utility.clsGlobal.Instance().WholeNumberLength));
                    double dblDecimalNumberQntyPrice = double.Parse("." + Barcode.Substring(GTSysOne.Class.Utility.clsGlobal.Instance().DecimalNumberStart, GTSysOne.Class.Utility.clsGlobal.Instance().DecimalNumberLength));

                    dt = GTSysOne.Class.MasterFile.clsMas_ItemMaster
                        .ShowTable(GTSysOne.Class.MasterFile
                        .clsMas_ItemMaster
                        .Value(0, 9, Barcode.Substring(GTSysOne.Class.Utility.clsGlobal.Instance().MiscCodeStart
                        , GTSysOne.Class.Utility.clsGlobal.Instance().MiscCodeLength), (GTSysOne.Class.Utility.clsGlobal.Instance().Use_Per_Misc_Code ? "1" : string.Empty)
                        , false
                        , false
                        , GTSysOne.Class.Utility.clsGlobal.Instance().COMPANYID
                        , GTSysOne.Class.Utility.clsGlobal.Instance().ESTABLISHMENTID
                        , GTSysOne.Class.Utility.clsGlobal.Instance().STATIONID
                        , System.Convert.ToString((int)GTSysOne.Class.Utility.clsGlobal.myFunction.Item_Master)
                        , GTSysOne.Class.Utility.clsGlobal.Instance().UserId
                        , string.Empty
                        , (GTSysOne.Class.Utility.clsGlobal.Instance().Use_Whole_And_Decimal_As_Price ? "1" : "2")
                        , "1"
                        , System.Convert.ToString(dblWholeNumberQntyPrice + dblDecimalNumberQntyPrice)
                        , GTSysOne.Class.Utility.clsGlobal.Instance().EstablishmentGroups
                        , PriceLevel
                        , Warehouse
                        , Barcode
                        ));
                }
                else
                {
                    dt = GTSysOne.Class.MasterFile.clsMas_ItemMaster
                        .ShowTable(GTSysOne.Class.MasterFile
                        .clsMas_ItemMaster
                        .Value(0, 9, Barcode, string.Empty
                        , false
                        , false
                        , GTSysOne.Class.Utility.clsGlobal.Instance().COMPANYID
                        , GTSysOne.Class.Utility.clsGlobal.Instance().ESTABLISHMENTID
                        , GTSysOne.Class.Utility.clsGlobal.Instance().STATIONID
                        , System.Convert.ToString((int)GTSysOne.Class.Utility.clsGlobal.myFunction.Item_Master)
                        , GTSysOne.Class.Utility.clsGlobal.Instance().UserId
                        , string.Empty
                        , string.Empty
                        , string.Empty
                        , string.Empty
                        , GTSysOne.Class.Utility.clsGlobal.Instance().EstablishmentGroups
                        , PriceLevel
                        , Warehouse
                        , Barcode
                        ));
                }
            }
            else
            {
                dt = GTSysOne.Class.MasterFile.clsMas_ItemMaster
                        .ShowTable(GTSysOne.Class.MasterFile
                        .clsMas_ItemMaster
                        .Value(0, 9, Barcode, string.Empty
                        , false
                        , false
                        , GTSysOne.Class.Utility.clsGlobal.Instance().COMPANYID
                        , GTSysOne.Class.Utility.clsGlobal.Instance().ESTABLISHMENTID
                        , GTSysOne.Class.Utility.clsGlobal.Instance().STATIONID
                        , System.Convert.ToString((int)GTSysOne.Class.Utility.clsGlobal.myFunction.Item_Master)
                        , GTSysOne.Class.Utility.clsGlobal.Instance().UserId
                        , string.Empty
                        , string.Empty
                        , string.Empty
                        , string.Empty
                        , GTSysOne.Class.Utility.clsGlobal.Instance().EstablishmentGroups
                        , PriceLevel
                        , Warehouse
                        , Barcode
                        ));
            }
            return dt;
        }


        private static bool PrivilegeValidator(System.Data.DataRow row)
        {
            bool Grant = false;
            if (row != null)
            {
                Grant = (bool)row["granted"];
            }
            return Grant;
        }

     
        public static int ValidateControl(DevExpress.XtraEditors.BaseEdit Control,string ErrorText = "Field Required To Fill",bool SpecialError = false)
        {
            if (Control.Text == string.Empty || SpecialError)
            {
                GTSysOne.Class.Utility.clsGlobal.Instance().Err.SetIconAlignment(Control, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
                GTSysOne.Class.Utility.clsGlobal.Instance().Err.SetError(Control, ErrorText);
                GTSysOne.Class.Utility.clsGlobal.Instance().No_Error_Result = false;
            }
            return 0;
        }
        public static DevExpress.XtraGrid.Views.Base.BaseView Layout_Restore_Save(DevExpress.XtraGrid.Views.Base.BaseView view,GTSysOne.Class.Utility.clsGlobal.GridLayout layout, string Location, string Function, DevExpress.XtraGrid.GridControl grid)
        {
            switch (layout)
            {
                case GTSysOne.Class.Utility.clsGlobal.GridLayout.Save:
                    try
                    {
                        if (!System.IO.Directory.Exists(Location + "\\" + Function))
                        {
                            System.IO.Directory.CreateDirectory(Location + "\\" + Function);
                        }
                        (grid.FocusedView as DevExpress.XtraGrid.Views.Grid.GridView).ActiveFilterString = string.Empty;
                        view.SaveLayoutToXml(Location + "\\" + Function + "\\Slip" + Function);
                    }
                    catch { }
                    break;
                case GTSysOne.Class.Utility.clsGlobal.GridLayout.Restore:
                    try
                    {
                        view.RestoreLayoutFromXml(Location + "\\" + Function + "\\Slip" + Function);
                    }
                    catch { }
                    break;
            }
            return view;
        }
        public static DevExpress.XtraGrid.GridControl Export(DevExpress.XtraGrid.GridControl grid, string ExportType)
        {
            DevExpress.XtraGrid.GridControl retGrid = grid;
            if (ExportType.Substring(0, 2).CompareTo("SO") == 0)
            {
                try
                {
                    DevExpress.XtraGrid.Views.Grid.GridView gv = grid.FocusedView as DevExpress.XtraGrid.Views.Grid.GridView;
                    string ids = "";
                    int[] RowHandles = gv.GetSelectedRows();
                    foreach (int i in RowHandles)
                    {
                        if (ids.CompareTo("") != 0) ids += ", ";
                        ids += "'" + gv.GetRowCellValue(i, gv.Columns["id"]).ToString() + "'";
                    }
                    if (ids.CompareTo("") != 0)
                    {
                        gv.ActiveFilterString = "[id] in (" + ids + ")";
                    }
                }
                catch { }
            }
            return retGrid;
        }
        public static string ShowSaveFileDialog(DevExpress.XtraGrid.GridControl grid,System.Windows.Forms.ToolStripMenuItem t, System.Windows.Forms.Control c)
        {
            System.Windows.Forms.SaveFileDialog d = new System.Windows.Forms.SaveFileDialog();
            d.Title = "Export To " + t.Text;
            d.FileName = /*name + " " +*/ t.Text;
            d.Filter = t.Tag.ToString();
            if (d.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                c.Cursor = System.Windows.Forms.Cursors.WaitCursor;
                GTSysOne.Class.Utility.clsUtility.Export(grid,t.Name);
                switch (t.Name)
                {
                    case "SOHTML":
                    case "AHTML":
                        grid.ExportToHtml(d.FileName);
                        break;
                    case "SOCSV":
                    case "ACSV":
                        grid.ExportToCsv(d.FileName);
                        break;
                    case "SOMS7":
                    case "AMS7":
                        grid.ExportToXlsx(d.FileName);
                        break;
                    case "SOMS":
                    case "AMS":
                        grid.ExportToXls(d.FileName);
                        break;
                    case "SORTF":
                    case "ARTF":
                        grid.ExportToRtf(d.FileName);
                        break;
                    case "SOPDF":
                    case "APDF":
                        grid.ExportToPdf(d.FileName);
                        break;
                    case "SOMHT":
                    case "AMHT":
                        grid.ExportToMht(d.FileName);
                        break;
                    case "SOText":
                    case "AText":
                        grid.ExportToText(d.FileName);
                        break;
                }
                (grid.FocusedView as DevExpress.XtraGrid.Views.Grid.GridView).ActiveFilterString = string.Empty;
                c.Cursor = System.Windows.Forms.Cursors.Default;
            }
            d.Dispose();
            d = null;
            return "";
        }
        public static int AddTab(DevExpress.XtraTab.XtraTabControl Parent, System.Windows.Forms.Form Child, string Name, System.Windows.Forms.ImageList IL,int Tag)
        {
            bool Exist = false;
            int Index = 0;
            for(int ctr=0;ctr<Parent.TabPages.Count;ctr++)
            {
                if (Parent.TabPages[ctr].Name == Name)
                {
                    Exist = true;
                    Index = ctr;
                }
            }
            if(Exist)
            {
                Parent.SelectedTabPageIndex = Index;
            }
            else
            {
                DevExpress.XtraTab.XtraTabPage P = new DevExpress.XtraTab.XtraTabPage();
                P.Name = Name;
                P.Cursor = System.Windows.Forms.Cursors.Default;
                P.Text = Child.Name.Replace("frm", "");
                P.Tag = Tag;
                P.ShowCloseButton = DevExpress.Utils.DefaultBoolean.True;
                P.Image = IL.Images[P.Text + ".png"];
                P.Controls.Add(Child);
                Parent.TabPages.Add(P);
                Parent.SelectedTabPage = P;
            }
            return 0;
        }
        public static System.Data.DataTable LoadAllTheme()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Id", typeof(string));
            dt.Columns.Add("Name", typeof(string));
            foreach (DevExpress.Skins.SkinContainer cnt in DevExpress.Skins.SkinManager.Default.Skins)
            {
                dt.Rows.Add(cnt.SkinName, cnt.SkinName);
            }
            return dt;
        }
        public static double MemoryUsage()
        {
            double memsize = 0.0;
            System.Diagnostics.PerformanceCounter PC = new System.Diagnostics.PerformanceCounter();
            PC.CategoryName = "Process";
            PC.CounterName = "Working Set - Private";
            PC.InstanceName = System.Diagnostics.Process.GetCurrentProcess().ProcessName;
            memsize = PC.NextValue() / 1000000;
            PC.Close();
            PC.Dispose();
            return memsize;
        }
        public static object FocusLastNewRow(DevExpress.XtraGrid.Views.Grid.GridView view, DevExpress.XtraGrid.GridControl grid, string colFocus = "")
        {
            try
            {
                if (view.GetDataRow(view.FocusedRowHandle).RowState == System.Data.DataRowState.Unchanged)
                {
                    view.GetDataRow(view.FocusedRowHandle).SetAdded();
                }
            }
            catch { }
            try
            {
                view.SortInfo.ClearSorting();
                view.MoveLast();
                view.FocusedRowHandle = DevExpress.XtraGrid.GridControl.NewItemRowHandle;
                DevExpress.XtraGrid.Views.Base.ColumnView vw = (DevExpress.XtraGrid.Views.Base.ColumnView)grid.FocusedView;
                vw.FocusedColumn = view.Columns[colFocus];
                view.TopRowIndex = view.RowCount;
                view.Focus();
            }
            catch { }
            return null;
        }
        public static object SINGLESELECTION_CHECKBOXCOLUMN(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e, string CheckBoxColumn)
        {
            DevExpress.XtraGrid.Views.Grid.GridView view = sender as DevExpress.XtraGrid.Views.Grid.GridView;
            if (e.Column.FieldName.CompareTo(CheckBoxColumn) == 0 )
            {
                if ((bool)e.Value)
                {
                    int rowHandle = view.GetRowHandle(checkedRowIndex);
                    view.SetRowCellValue(rowHandle, e.Column.FieldName, false);
                    checkedRowIndex = view.GetDataSourceRowIndex(e.RowHandle);
                }
            }
            return null;
        }

        public static int FullItemList()
        {
            GTSysOne.Class.Utility.clsGlobal.Instance().FullItemList = GTSysOne.Class.MasterFile.clsMas_ItemMaster.ShowTable(GTSysOne
                .Class.MasterFile.clsMas_ItemMaster.Value(0
                   , 6, string.Empty, string.Empty, false, false, GTSysOne
                   .Class.Utility.clsGlobal.Instance().COMPANYID));

            return 0;
        }
        public static int DEFAULT_CONNECTION_SETTINGS(string con)
        {
            GTSysOne.Properties.Settings.Default.IdrisConnectionString = con;
            return 0;
        }
        public static int BUILDRELATIONSHIP(ref DataSet sDATASET, int tableindex, string tablename, string relationName, string parentcolumn, string childColumn)
        {
            if (sDATASET.Tables[tableindex].Rows.Count == 0)
            {
                int columnCounts = sDATASET.Tables[tableindex].Columns.Count;
                object[] row = new object[columnCounts];
                for (int columnIndex = 0; columnIndex < columnCounts; columnIndex++)
                {
                    row[columnIndex] = null;
                }
                sDATASET.Tables[tableindex].Rows.Add(row);
            }
            sDATASET.Tables[tableindex].TableName = tablename;
            System.Data.DataRelation dr = new System.Data.DataRelation(relationName, sDATASET.Tables[0].Columns[parentcolumn], sDATASET.Tables[tableindex].Columns[childColumn]);
            sDATASET.Relations.Add(dr);
            return 0;
        }



        static int noofcopies = 1;

        public class Report
        {
            private DevExpress.XtraReports.UI.XtraReport _RPT = null;
            public DevExpress.XtraReports.UI.XtraReport RPT
            {
                set { _RPT = value; }
                get { return _RPT; }
            }


            private string _printer = null;
            public string Printer
            {
                set { _printer = value; }
                get { return _printer; }
            }


            private string _layout = null;
            public string Layout
            {
                set { _layout = value; }
                get { return _layout; }
            }


            private int _copies = 1;
            public int Copies
            {
                set { _copies = value; }
                get { return _copies; }
            }


            private bool _usepreviewonly = false;
            public bool UsePreviewOnly
            {
                set { _usepreviewonly = value; }
                get { return _usepreviewonly; }
            }


        }

        public static System.Collections.Generic.Dictionary<string, Report> Rent = new System.Collections.Generic.Dictionary<string, Report>();


        public static int INITIALIZE_REPORT(GTSysOne.Class.Utility.clsGlobal.myFunction F, DevExpress.XtraReports.UI.XtraReport RPT, string ReportName, string PrintArea)
        {
            int function = (int)F;
            string type = "0";
            System.Collections.Generic.Dictionary<string, Report> Reports = new System.Collections.Generic.Dictionary<string, Report>();
            switch (F)
            {
                case GTSysOne.Class.Utility.clsGlobal.myFunction.Rent:
                    Reports = Rent;
                    type = GTSysOne.Class.Utility.clsGlobal.PRINTER_RENT_REPORT;
                    break;
                //case GTSysOne.Class.Utility.clsGlobal.myFunction.General_Journal:
                //    Reports = JournalReport;
                //    type = GTSysOne.Class.Utility.clsGlobal.PRINTER_JOURNAL_REPORT;
                //    break;
                //case GTSysOne.Class.Utility.clsGlobal.myFunction.Employee:
                //    Reports = EmployeeReport;
                //    type = GTSysOne.Class.Utility.clsGlobal.PRINTER_EMPLOYEE_REPORT;
                //    break;
                //case GTSysOne.Class.Utility.clsGlobal.myFunction.Sales_Blanket_Agreement:
                //    Reports = ARSalesBlanketAgreementReport;
                //    type = GTSysOne.Class.Utility.clsGlobal.PRINTER_AR_SALES_BLANKET_AGREEMENT;
                //    break;
                //case GTSysOne.Class.Utility.clsGlobal.myFunction.Finance_Reports:
                //    switch (ReportName)
                //    {
                //        case "xrptFinanceBalanceSheet":
                //            Reports = FinanceBalanceSheetReport;
                //            type = GTSysOne.Class.Utility.clsGlobal.PRINTER_FINANCE_BALANCE_SHEET_REPORT;
                //            break;
                //        case "xrptFinanceProfitAndLoss":
                //            Reports = FinanceProfitAndLossReport;
                //            type = GTSysOne.Class.Utility.clsGlobal.PRINTER_FINANCE_PROFIT_AND_LOSS_REPORT;
                //            break;
                //        case "xrptFinanceTrialBalance":
                //            Reports = FinanceTrialBalanceReport;
                //            type = GTSysOne.Class.Utility.clsGlobal.PRINTER_FINANCE_TRIAL_BALANCE_REPORT;
                //            break;
                //    }
                //    break;
            }
            Reports[ReportName] = new Report();
            Reports[ReportName].RPT = RPT;
//            System.Collections.Generic.Dictionary<string, Report>.KeyCollection keyColl = Reports.Keys;
//            foreach (string name in keyColl)
//            {
//                System.Data.DataRow[] Val
//                    = GTSysOne.Class.Utility.clsGlobal.Instance()
//                    .Table_Printer_Settings
//                    .Select(@" type = '" + type + @"'  AND  mas_sourced_station_id = '" + GTSysOne.Class.Utility.clsGlobal.Instance().STATIONID + @"' 
//                        AND  mas_sourced_printerarea_id = '" + PrintArea + @"' 
//                        AND  mas_sourced_function_id = '" + function + @"' ");
//                switch (Val.Length)
//                {
//                    case 0:
//                        break;
//                    default:
//                        Reports[name].Printer = System.Convert.ToString(Val[0]["printer"]);
//                        Reports[name].Layout = System.Convert.ToString(Val[0]["layout"]);
//                        Reports[name].Copies = System.Convert.ToInt32(Val[0]["copies"]);
//                        Reports[name].UsePreviewOnly = System.Convert.ToBoolean(Val[0]["usepreviewonly"]);
//                        switch (Reports[name].UsePreviewOnly)
//                        {
//                            case true:
//                                Reports[name].Printer = "N/A";
//                                break;
//                        }
//                        if (Reports[name].Layout.CompareTo("N/A") != 0)
//                        {
//                            try
//                            {
//                                Reports[name].RPT.LoadLayout(Reports[name].Layout);
//                            }
//                            catch
//                            {
//                                GTSysOne.Class.Utility.clsUtility.GTSysMessageBox(new string[] { "Please Contact Administrator", "The design loaded is not intended for this report", "Or either this design was not in proper location", "Please check this design:", System.IO.Path.GetFileName(Reports[name].Layout) }
//                                        , GTSysOne.Class.Utility.clsGlobal.enMessageBoxButton.OK
//                                        , GTSysOne.Class.Utility.clsGlobal.enMessageBoxIcon.Warning
//                                        , "Printer Info...");
//                            }
//                        }
//                        break;
//                }
//                Val = null;
//            }
            return 0;
        }
        public static int PRINT(GTSysOne.Class.Utility.clsGlobal.myFunction F, string ReportName, DataSet d, string[,] arrProperties = null, string[,] parameters = null, string[] filterInfo = null)
        {
            switch (d.Tables.Count)
            {
                case 0:
                    GTSysOne.Class.Utility.clsUtility.GTSysMessageBox(new string[] { "No Record(s) to be Previewed or Print" }
                                                                 , GTSysOne.Class.Utility.clsGlobal.enMessageBoxButton.OK
                                                                 , GTSysOne.Class.Utility.clsGlobal.enMessageBoxIcon.Information
                                                                 , "Printer Info...");
                    break;
                default:
                    switch (d.Tables[0].Rows.Count)
                    {
                        case 0:
                            GTSysOne.Class.Utility.clsUtility.GTSysMessageBox(new string[] { "No Record(s) to be Previewed or Print" }
                                                                  , GTSysOne.Class.Utility.clsGlobal.enMessageBoxButton.OK
                                                                  , GTSysOne.Class.Utility.clsGlobal.enMessageBoxIcon.Information
                                                                  , "Printer Info...");
                            break;
                        default:
                            try
                            {
                                System.Collections.Generic.Dictionary<string, Report> Reports = new System.Collections.Generic.Dictionary<string, Report>();
                                switch (F)
                                {
                                    case GTSysOne.Class.Utility.clsGlobal.myFunction.Rent:
                                        Reports = Rent;
                                        break;
                                    //case GTSysOne.Class.Utility.clsGlobal.myFunction.General_Journal:
                                    //    Reports = JournalReport;
                                    //    break;
                                    //case GTSysOne.Class.Utility.clsGlobal.myFunction.Employee:
                                    //    Reports = EmployeeReport;
                                    //    break;
                                    //case GTSysOne.Class.Utility.clsGlobal.myFunction.Sales_Blanket_Agreement:
                                    //    Reports = ARSalesBlanketAgreementReport;
                                    //    break;
                                    //case GTSysOne.Class.Utility.clsGlobal.myFunction.Finance_Reports:
                                    //    switch (ReportName)
                                    //    {
                                    //        case "xrptFinanceBalanceSheet":
                                    //            Reports = FinanceBalanceSheetReport;
                                    //            break;
                                    //        case "xrptFinanceProfitAndLoss":
                                    //            Reports = FinanceProfitAndLossReport;
                                    //            break;
                                    //        case "xrptFinanceTrialBalance":
                                    //            Reports = FinanceTrialBalanceReport;
                                    //            break;
                                    //    }
                                    //    break;
                                }

                                #region LOAD PARAMETERS SUCH AS title,Description
                                for (int i = 0; i < parameters.GetLength(0); i++)
                                {
                                    Reports[ReportName].RPT.Parameters[parameters[i, 0]].Value = parameters[i, 1];
                                }
                                #endregion

                                #region LOAD DATASET FROM DATABASE...
                                Reports[ReportName].RPT.GetType().GetProperty(arrProperties[0, 0].ToString()).SetValue(Reports[ReportName].RPT, d, null);
                                #endregion

                                #region BUILD REPORT
                                Reports[ReportName].RPT.CreateDocument();
                                #endregion

                                #region DONE!!! AND DISPLAY
                                string Printer = System.Convert.ToString(Reports[ReportName].Printer);
                                switch (Printer)
                                {
                                    case null:
                                    case "N/A":
                                        GTSysOne.Class.Utility.clsUtility.GTSysMessageBox(new string[] { "No default printer assign yet." }
                                        , GTSysOne.Class.Utility.clsGlobal.enMessageBoxButton.OK
                                        , GTSysOne.Class.Utility.clsGlobal.enMessageBoxIcon.Error
                                        , "Printer Info...");
                                        Reports[ReportName].RPT.ShowPreviewDialog();
                                        break;
                                    default:
                                        switch (PrinterStatus(Printer))
                                        {
                                            case true: //UNIDENTIFIED SOMETIMES ERROR DUE TO NETWORK, SO THAT THERES A TRY CATCH
                                                try
                                                {
                                                    noofcopies = System.Convert.ToInt32(Reports[ReportName].Copies);
                                                    Reports[ReportName].RPT.PrintingSystem.StartPrint += new DevExpress.XtraPrinting.PrintDocumentEventHandler(EVENT_PRINTING_SYSTEM_START_PRINT);
                                                    Reports[ReportName].RPT.Print(Reports[ReportName].Printer);
                                                }
                                                catch (System.Exception idris)
                                                {
                                                    GTSysOne.Class.Utility.clsUtility.GTSysMessageBox(new string[] { "Printer currently Offline or Not Working", idris.Message }
                                                        , GTSysOne.Class.Utility.clsGlobal.enMessageBoxButton.OK
                                                        , GTSysOne.Class.Utility.clsGlobal.enMessageBoxIcon.Error
                                                        , "Printer Info...");
                                                    Reports[ReportName].RPT.ShowPreviewDialog();
                                                }
                                                break;
                                            default:
                                                GTSysOne.Class.Utility.clsUtility.GTSysMessageBox(new string[] { "Printer currently Offline or Not Working" }
                                                        , GTSysOne.Class.Utility.clsGlobal.enMessageBoxButton.OK
                                                        , GTSysOne.Class.Utility.clsGlobal.enMessageBoxIcon.Error
                                                        , "Printer Info...");
                                                Reports[ReportName].RPT.ShowPreviewDialog();
                                                break;
                                        }
                                        break;
                                }
                                #endregion

                            }
                            catch
                            {
                                GTSysOne.Class.Utility.clsUtility.GTSysMessageBox(new string[] { "Please Contact Administrator", "The design loaded is not intended for this report", "Or either this design was not in proper location", "Please check this design:", ReportName }
                                                                   , GTSysOne.Class.Utility.clsGlobal.enMessageBoxButton.OK
                                                                   , GTSysOne.Class.Utility.clsGlobal.enMessageBoxIcon.Warning
                                                                   , "Printer Info...");
                            }
                            break;
                    }
                    break;
            }
            return 0;
        }
        

        private static void EVENT_PRINTING_SYSTEM_START_PRINT(object sender, DevExpress.XtraPrinting.PrintDocumentEventArgs e)
        {
            e.PrintDocument.PrinterSettings.Copies = (short)noofcopies;
        }
    
    

    }


   






    public struct clsEncryption
    {
        public sealed class JayDhreiZIP
        {
            private JayDhreiZIP()
            {
            }
            // This constant string is used as a "salt" value for the PasswordDeriveBytes function calls.
            // This size of the IV (in bytes) must = (keysize / 8).  Default keysize is 256, so the IV must be
            // 32 bytes long.  Using a 16 character string here gives us 32 bytes when converted to a byte array.
            //please dont modify this code it may cause unwanted behavior
            private const string initVector = "JHAYROSEBROSALES";
            // This constant is used to determine the keysize of the encryption algorithm.
            private const int keysize = 256;
            public static string Encrypt(string plainText, string passPhrase)
            {
                byte[] initVectorBytes = System.Text.Encoding.UTF8.GetBytes(initVector);
                byte[] plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
                System.Security.Cryptography.PasswordDeriveBytes password = new System.Security.Cryptography.PasswordDeriveBytes(passPhrase, null);
                byte[] keyBytes = password.GetBytes(keysize / 8);
                System.Security.Cryptography.RijndaelManaged symmetricKey = new System.Security.Cryptography.RijndaelManaged();
                symmetricKey.Mode = System.Security.Cryptography.CipherMode.CBC;
                System.Security.Cryptography.ICryptoTransform encryptor = symmetricKey.CreateEncryptor(keyBytes, initVectorBytes);
                System.IO.MemoryStream memoryStream = new System.IO.MemoryStream();
                System.Security.Cryptography.CryptoStream cryptoStream = new System.Security.Cryptography.CryptoStream(memoryStream, encryptor, System.Security.Cryptography.CryptoStreamMode.Write);
                cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length);
                cryptoStream.FlushFinalBlock();
                byte[] cipherTextBytes = memoryStream.ToArray();
                memoryStream.Close();
                cryptoStream.Close();
                return System.Convert.ToBase64String(cipherTextBytes);
            }
            public static string Decrypt(string cipherText, string passPhrase)
            {
                byte[] initVectorBytes = System.Text.Encoding.ASCII.GetBytes(initVector);
                byte[] cipherTextBytes = System.Convert.FromBase64String(cipherText);
                System.Security.Cryptography.PasswordDeriveBytes password = new System.Security.Cryptography.PasswordDeriveBytes(passPhrase, null);
                byte[] keyBytes = password.GetBytes(keysize / 8);
                System.Security.Cryptography.RijndaelManaged symmetricKey = new System.Security.Cryptography.RijndaelManaged();
                symmetricKey.Mode = System.Security.Cryptography.CipherMode.CBC;
                System.Security.Cryptography.ICryptoTransform decryptor = symmetricKey.CreateDecryptor(keyBytes, initVectorBytes);
                System.IO.MemoryStream memoryStream = new System.IO.MemoryStream(cipherTextBytes);
                System.Security.Cryptography.CryptoStream cryptoStream = new System.Security.Cryptography.CryptoStream(memoryStream, decryptor, System.Security.Cryptography.CryptoStreamMode.Read);
                byte[] plainTextBytes = new byte[cipherTextBytes.Length];
                int decryptedByteCount = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length);
                memoryStream.Close();
                cryptoStream.Close();
                return System.Text.Encoding.UTF8.GetString(plainTextBytes, 0, decryptedByteCount);
            }
        }



    }
}
