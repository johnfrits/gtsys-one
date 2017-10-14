namespace GTSysOne.Class.Slip
{
    public struct clsSlip_IMUnitOfMeasure
    {
        #region Column
        static string[] Column = {   "operation" 
                                    ,"soperation"
                                    ,"id"
                                    ,"deleted"
                                    ,"void"
                                    ,"transmit"
                                    ,"doc_source_company_id"
                                    ,"mas_source_establishment_id"
                                    ,"mas_source_station_id"
                                    ,"mas_source_function_id"
                                    ,"doc_source_userid_id"
                                    ,"datecreate"
                                    ,"mas_sourced_itemmaster_id"
                                    ,"mas_sourced_pricelevel_id"
                                    ,"mas_sourced_currency_id"
                                    ,"mas_sourced_unitofmeasure_id"
                                    ,"barcode"
                                    ,"multiplier"
                                    ,"price"
                                    ,"focprice"
                                    ,"customizelabel"
                                    ,"color"
                                    ,"useforposbuttonscreen"
                                    ,"seq"
                                    ,"NewPK"
                                 };
        #endregion
        #region Value
        public static object[] Value( int m_operation = 0
                                    , int m_soperation = 0
                                    , string m_id = ""
                                    , string m_deleted = ""
                                    , string m_void = ""
                                    , string m_transmit = ""
                                    , string m_doc_source_company_id = ""
                                    , string m_mas_source_establishment_id = ""
                                    , string m_mas_source_station_id = ""
                                    , string m_mas_source_function_id = ""
                                    , string m_doc_source_userid_id = ""
                                    , string m_datecreate = ""
                                    , string m_mas_sourced_itemmaster_id = ""
                                    , string m_mas_sourced_pricelevel_id = ""
                                    , string m_mas_sourced_currency_id = ""
                                    , string m_mas_sourced_unitofmeasure_id = ""
                                    , string m_barcode = ""
                                    , double m_multiplier = 0.000
                                    , double m_price = 0.000
                                    , double m_focprice = 0.000
                                    , string m_customizelabel = ""
                                    , string m_color = ""
                                    , bool m_useforposbuttonscreen = false
                                    , int  m_seq = 0
                                    , string m_NewPK = "@NewPK"
                                    )
        {
            object[] s_Value = new object[25];
            s_Value[0] = m_operation;
            s_Value[1] = m_soperation;
            s_Value[2] = m_id;
            s_Value[3] = m_deleted;
            s_Value[4] = m_void;
            s_Value[5] = m_transmit;
            s_Value[6] = m_doc_source_company_id;
            s_Value[7] = m_mas_source_establishment_id;
            s_Value[8] = m_mas_source_station_id;
            s_Value[9] = m_mas_source_function_id;
            s_Value[10] = m_doc_source_userid_id;
            s_Value[11] = m_datecreate;
            s_Value[12] = m_mas_sourced_itemmaster_id;
            s_Value[13] = m_mas_sourced_pricelevel_id;
            s_Value[14] = m_mas_sourced_currency_id;
            s_Value[15] = m_mas_sourced_unitofmeasure_id;
            s_Value[16] = m_barcode;
            s_Value[17] = m_multiplier;
            s_Value[18] = m_price;
            s_Value[19] = m_focprice;
            s_Value[20] = m_customizelabel;
            s_Value[21] = m_color;
            s_Value[22] = m_useforposbuttonscreen;
            s_Value[23] = m_seq;
            s_Value[24] = m_NewPK;
            return s_Value;
        }
        #endregion
        public static string Save(object[] s_Value)
        {
            return (string)GTSysOne.Class.Utility.clsUtility.ManagedExecution(Column, s_Value, "sp_SlipIMUnitOfMeasure", System.Convert.ToInt32(s_Value[0]), 0);
        }
        public static System.Data.DataTable ShowTable(object[] s_Value)
        {
            return (System.Data.DataTable)GTSysOne.Class.Utility.clsUtility.ManagedExecution(Column, s_Value, "sp_SlipIMUnitOfMeasure", 0, 1);
        }
        public static object ScalarValue(object[] s_Value)
        {
            return GTSysOne.Class.Utility.clsUtility.ManagedExecution(Column, s_Value, "sp_SlipIMUnitOfMeasure", 0, 2);
        }
        public static System.Data.DataSet ShowDataSet(object[] s_Value)
        {
            return (System.Data.DataSet)GTSysOne.Class.Utility.clsUtility.ManagedExecution(Column, s_Value, "sp_SlipIMUnitOfMeasure", 0, 3);
        }
    }
}
