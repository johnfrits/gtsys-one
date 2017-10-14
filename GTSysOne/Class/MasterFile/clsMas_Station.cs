namespace GTSysOne.Class.MasterFile
{
    public struct clsMas_Station
    {
        #region Column
        static string[] Column = {   "operation" 
                                    ,"soperation"
                                    ,"id"
                                    ,"num"
                                    ,"void"
                                    ,"transmit"
                                    ,"doc_source_company_id"
                                    ,"mas_source_establishment_id"
                                    ,"mas_source_station_id"
                                    ,"mas_source_function_id"
                                    ,"doc_source_userid_id"
                                    ,"datecreate"
                                    ,"mas_sourced_establishment_id"
                                    ,"name"
                                    , "shortname"
                                    , "cpu"
                                    , "hqstation"
                                    , "running"
                                    , "startrunning"
                                    , "stoprunning"
                                    , "language"
                                    , "alloweditlinetotal"
                                    , "theme"
                                    , "showfavorites"
                                    , "autohidenavigation"
                                    , "showstats"
                                    , "autohidestats"
                                    , "showfunctions"
                                    , "NewPK"
                                 };
        #endregion
        #region Value
        public static object[] Value( int m_operation = 0
                                    , int m_soperation = 0
                                    , string m_id = ""
                                    , string m_num = ""
                                    , bool m_void = false
                                    , bool m_transmit = false
                                    , string m_doc_source_company_id = ""
                                    , string m_mas_source_establishment_id = ""
                                    , string m_mas_source_station_id = ""
                                    , string m_mas_source_function_id = ""
                                    , string m_doc_source_userid_id = ""
                                    , string m_datecreate = ""
                                    , string m_mas_sourced_establishment_id = ""
                                    , string m_name = ""
                                    , string m_shortname = ""
                                    , string m_cpu = ""
                                    , bool m_hqstation = false
                                    , bool m_running = false
                                    , string m_startrunning = ""
                                    , string m_stoprunning = ""
                                    , string m_language = ""
                                    , bool m_alloweditlinetotal = false
                                    , string m_theme = ""
                                    , bool m_showfavorites = false
                                    , bool m_autohidenavigation = false
                                    , bool m_showstats = false
                                    , bool m_autohidestats = false
                                    , bool m_showfunctions = false
                                    , string m_NewPK = "@NewPK"
                                    )
        {
            object[] s_Value = new object[29];
            s_Value[0] = m_operation;
            s_Value[1] = m_soperation;
            s_Value[2] = m_id;
            s_Value[3] = m_num;
            s_Value[4] = m_void;
            s_Value[5] = m_transmit;
            s_Value[6] = m_doc_source_company_id;
            s_Value[7] = m_mas_source_establishment_id;
            s_Value[8] = m_mas_source_station_id;
            s_Value[9] = m_mas_source_function_id;
            s_Value[10] = m_doc_source_userid_id;
            s_Value[11] = m_datecreate;
            s_Value[12] = m_mas_sourced_establishment_id;
            s_Value[13] = m_name;
            s_Value[14] = m_shortname;
            s_Value[15] = m_cpu;
            s_Value[16] = m_hqstation;
            s_Value[17] = m_running;
            s_Value[18] = m_startrunning;
            s_Value[19] = m_stoprunning;
            s_Value[20] = m_language;
            s_Value[21] = m_alloweditlinetotal;
            s_Value[22] = m_theme;
            s_Value[23] = m_showfavorites;
            s_Value[24] = m_autohidenavigation;
            s_Value[25] = m_showstats;
            s_Value[26] = m_autohidestats;
            s_Value[27] = m_showfunctions;
            s_Value[28] = m_NewPK;
            return s_Value;
        }
        #endregion
        public static string Save(object[] s_Value)
        {
            return (string)GTSysOne.Class.Utility.clsUtility.ManagedExecution(Column, s_Value, "sp_MasStation", System.Convert.ToInt32(s_Value[0]), 0);
        }
        public static System.Data.DataTable ShowTable(object[] s_Value)
        {
            return (System.Data.DataTable)GTSysOne.Class.Utility.clsUtility.ManagedExecution(Column, s_Value, "sp_MasStation", 0, 1);
        }
        public static object ScalarValue(object[] s_Value)
        {
            return GTSysOne.Class.Utility.clsUtility.ManagedExecution(Column, s_Value, "sp_MasStation", 0, 2);
        }
        public static System.Data.DataSet ShowDataSet(object[] s_Value)
        {
            return (System.Data.DataSet)GTSysOne.Class.Utility.clsUtility.ManagedExecution(Column, s_Value, "sp_MasStation", 0, 3);
        }
    }
}
