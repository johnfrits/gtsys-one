﻿namespace GTSysOne.Class.Document
{
    public struct clsDoc_Country
    {
        #region Column
        static string[] Column = {   "operation" 
                                    ,"soperation"
                                    ,"id"
                                    ,"num"
                                    ,"deleted"
                                    ,"void"
                                    ,"transmit"
                                    ,"doc_source_company_id"
                                    ,"mas_source_establishment_id"
                                    ,"mas_source_station_id"
                                    ,"mas_source_function_id"
                                    ,"doc_source_userid_id"
                                    ,"datecreate"
                                    ,"name"
                                    ,"map_sourced_nationality_id"
                                    ,"map_sourced_language_id"
                                    ,"map_sourced_localization_id"
                                    ,"NewPK"
                                 };
        #endregion
        #region Value
        public static object[] Value(int m_operation = 0
                                    , int m_soperation = 0
                                    , string m_id = ""
                                    , string m_num = ""
                                    , bool m_deleted = false
                                    , bool m_void = false
                                    , bool m_transmit = false
                                    , string m_doc_source_company_id = ""
                                    , string m_mas_source_establishment_id = ""
                                    , string m_mas_source_station_id = ""
                                    , string m_mas_source_function_id = ""
                                    , string m_doc_source_userid_id = ""
                                    , string m_datecreate = ""
                                    , string m_name = ""
                                    , string m_map_sourced_nationality_id = ""
                                    , string m_map_sourced_language_id = ""
                                    , string m_map_sourced_localization_id = ""
                                    , string m_NewPK = "@NewPK"
                                    )
        {
            object[] s_Value = new object[18];
            s_Value[0] = m_operation;
            s_Value[1] = m_soperation;
            s_Value[2] = m_id;
            s_Value[3] = m_num;
            s_Value[4] = m_deleted;
            s_Value[5] = m_void;
            s_Value[6] = m_transmit;
            s_Value[7] = m_doc_source_company_id;
            s_Value[8] = m_mas_source_establishment_id;
            s_Value[9] = m_mas_source_station_id;
            s_Value[10] = m_mas_source_function_id;
            s_Value[11] = m_doc_source_userid_id;
            s_Value[12] = m_datecreate;
            s_Value[13] = m_name;
            s_Value[14] = m_map_sourced_nationality_id;
            s_Value[15] = m_map_sourced_language_id;
            s_Value[16] = m_map_sourced_localization_id;
            s_Value[17] = m_NewPK;
            return s_Value;
        }
        #endregion
        public static string Save(object[] s_Value)
        {
            return (string)GTSysOne.Class.Utility.clsUtility.ManagedExecution(Column, s_Value, "sp_DocCountry", System.Convert.ToInt32(s_Value[0]), 0);
        }
        public static System.Data.DataTable ShowTable(object[] s_Value)
        {
            return (System.Data.DataTable)GTSysOne.Class.Utility.clsUtility.ManagedExecution(Column, s_Value, "sp_DocCountry", 0, 1);
        }
        public static object ScalarValue(object[] s_Value)
        {
            return GTSysOne.Class.Utility.clsUtility.ManagedExecution(Column, s_Value, "sp_DocCountry", 0, 2);
        }
        public static System.Data.DataSet ShowDataSet(object[] s_Value)
        {
            return (System.Data.DataSet)GTSysOne.Class.Utility.clsUtility.ManagedExecution(Column, s_Value, "sp_DocCountry", 0, 3);
        }
    }
}
