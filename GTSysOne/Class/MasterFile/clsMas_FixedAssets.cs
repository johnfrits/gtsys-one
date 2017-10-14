namespace GTSysOne.Class.MasterFile
{
    public struct clsMas_FixedAssets
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
                                    ,"mas_sourced_fagroup_id"
                                    ,"barcode"
                                    ,"class"
                                    ,"make"
                                    ,"model"
                                    ,"map_sourced_modelyear_id"
                                    ,"mas_sourced_color_id"
                                    ,"platenumber"
                                    ,"serialnumber"
                                    ,"insvendorcode"
                                    ,"insvendorname"
                                    ,"insvalue"
                                    ,"insissuedate"
                                    ,"insenddate"
                                    ,"insamount"
                                    ,"locnumber"
                                    ,"locname"
                                    ,"mas_sourced_department_id"
                                    ,"locroomNumber"
                                    ,"locgisrefnumber"
                                    ,"name"
                                    ,"NewPK"
                                 };
        #endregion
        #region Value
        public static object[] Value(int m_operation = 0
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
                                    , string m_mas_sourced_fagroup_id = ""
                                    , string m_barcode = ""
                                    , string m_class = ""
                                    , string m_make = ""
                                    , string m_model = ""
                                    , string m_map_sourced_modelyear_id = ""
                                    , string m_mas_sourced_color_id = ""
                                    , string m_plateNumber = ""
                                    , string m_serialNumber = ""
                                    , string m_insVendorCode = ""
                                    , string m_insVendorName = ""
                                    , double m_insvalue = 0.00
                                    , string m_insIssueDate = ""
                                    , string m_insEndDate = ""
                                    , double m_insAmount = 0.00
                                    , string m_locNumber = ""
                                    , string m_locName = ""
                                    , string m_mas_sourced_department_id = ""
                                    , string m_locRoomNumber = ""
                                    , string m_locGISRefNumber = ""
                                    , string m_name = ""
                                    , string m_NewPK = "@NewPK"
                                    )
        {
            object[] s_Value = new object[34];
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
            s_Value[12] = m_mas_sourced_fagroup_id;
            s_Value[13] = m_barcode;
            s_Value[14] = m_class;
            s_Value[15] = m_make;
            s_Value[16] = m_model;
            s_Value[17] = m_map_sourced_modelyear_id;
            s_Value[18] = m_mas_sourced_color_id;
            s_Value[19] = m_plateNumber;
            s_Value[20] = m_serialNumber;
            s_Value[21] = m_insVendorCode;
            s_Value[22] = m_insVendorName;
            s_Value[23] = m_insvalue;
            s_Value[24] = m_insIssueDate;
            s_Value[25] = m_insEndDate;
            s_Value[26] = m_insAmount;
            s_Value[27] = m_locNumber;
            s_Value[28] = m_locName;
            s_Value[29] = m_mas_sourced_department_id;
            s_Value[30] = m_locRoomNumber;
            s_Value[31] = m_locGISRefNumber;
            s_Value[32] = m_name;
            s_Value[33] = m_NewPK;
            return s_Value;
        }
        #endregion
        public static string Save(object[] s_Value)
        {
            return (string)GTSysOne.Class.Utility.clsUtility.ManagedExecution(Column, s_Value, "sp_MasFixedAssets", System.Convert.ToInt32(s_Value[0]), 0);
        }
        public static System.Data.DataTable ShowTable(object[] s_Value)
        {
            return (System.Data.DataTable)GTSysOne.Class.Utility.clsUtility.ManagedExecution(Column, s_Value, "sp_MasFixedAssets", 0, 1);
        }
        public static object ScalarValue(object[] s_Value)
        {
            return GTSysOne.Class.Utility.clsUtility.ManagedExecution(Column, s_Value, "sp_MasFixedAssets", 0, 2);
        }
        public static System.Data.DataSet ShowDataSet(object[] s_Value)
        {
            return (System.Data.DataSet)GTSysOne.Class.Utility.clsUtility.ManagedExecution(Column, s_Value, "sp_MasFixedAssets", 0, 3);
        }
    }
}
