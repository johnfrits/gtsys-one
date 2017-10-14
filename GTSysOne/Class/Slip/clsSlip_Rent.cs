namespace GTSysOne.Class.Slip
{
    public struct clsSlip_Rent
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
                                    ,"doc_sourced_doc_rent_id"
                                    ,"map_sourced_rent_type_id"
                                    ,"mas_sourced_fixedassets_id"
                                    ,"mas_sourced_driver_id"
                                    ,"date_out"
                                    ,"time_out"
                                    ,"expected_return_date"
                                    ,"date_return"
                                    ,"no_of_days"
                                    ,"daily_rate"
                                    ,"kmfrom"
                                    ,"kmto"
                                    ,"cdw"
                                    ,"dell_col_charge"
                                    ,"total"
                                    ,"mas_sourced_tax_id"
                                    ,"discount"
                                    ,"net_total"
                                    ,"NewPK"
                                 };
        #endregion
        #region Value
        public static object[] Value(int m_operation = 0
                                    , int m_soperation = 0
                                    , string m_id = ""
                                    , bool m_deleted = false
                                    , bool m_void = false
                                    , bool m_transmit = false
                                    , string m_doc_source_company_id = ""
                                    , string m_mas_source_establishment_id = ""
                                    , string m_mas_source_station_id = ""
                                    , string m_mas_source_function_id = ""
                                    , string m_doc_source_userid_id = ""
                                    , string m_datecreate = ""
                                    , string m_doc_sourced_doc_rent_id = ""
                                    , string m_map_sourced_rent_type_id = ""
                                    , string m_mas_sourced_fixedassets_id = ""
                                    , string m_mas_sourced_driver_id = ""
                                    , string m_date_out = ""
                                    , string m_time_out = ""
                                    , string m_expected_return_date = ""
                                    , string m_date_return = ""
                                    , string m_no_of_days = ""
                                    , string m_daily_rate = ""
                                    , string m_km_from = ""
                                    , string m_km_to = ""
                                    , string m_cdw = ""
                                    , string m_dell_col_charge = ""
                                    , string m_total = ""
                                    , string m_mas_sourced_tax_id = ""
                                    , string m_discount = ""
                                    , string m_net_total = ""
                                    , string m_NewPK = "@NewPK"
                                    )
        {
            object[] s_Value = new object[31];
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
            s_Value[12] = m_doc_sourced_doc_rent_id;
            s_Value[13] = m_map_sourced_rent_type_id;
            s_Value[14] = m_mas_sourced_fixedassets_id;
            s_Value[15] = m_mas_sourced_driver_id;
            s_Value[16] = m_date_out;
            s_Value[17] = m_time_out;
            s_Value[18] = m_expected_return_date;
            s_Value[19] = m_date_return;
            s_Value[20] = m_no_of_days;
            s_Value[21] = m_daily_rate;
            s_Value[22] = m_km_from;
            s_Value[23] = m_km_to;
            s_Value[24] = m_cdw;
            s_Value[25] = m_dell_col_charge;
            s_Value[26] = m_total;
            s_Value[27] = m_mas_sourced_tax_id;
            s_Value[28] = m_discount;
            s_Value[29] = m_net_total;
            s_Value[30] = m_NewPK;
            return s_Value;
        }
        #endregion
        public static string Save(object[] s_Value)
        {
            return (string)GTSysOne.Class.Utility.clsUtility.ManagedExecution(Column, s_Value, "sp_SlipRent", System.Convert.ToInt32(s_Value[0]), 0);
        }
        public static System.Data.DataTable ShowTable(object[] s_Value)
        {
            return (System.Data.DataTable)GTSysOne.Class.Utility.clsUtility.ManagedExecution(Column, s_Value, "sp_SlipRent", 0, 1);
        }
        public static object ScalarValue(object[] s_Value)
        {
            return GTSysOne.Class.Utility.clsUtility.ManagedExecution(Column, s_Value, "sp_SlipRent", 0, 2);
        }
        public static System.Data.DataSet ShowDataSet(object[] s_Value)
        {
            return (System.Data.DataSet)GTSysOne.Class.Utility.clsUtility.ManagedExecution(Column, s_Value, "sp_SlipRent", 0, 3);
        }
    }
}
