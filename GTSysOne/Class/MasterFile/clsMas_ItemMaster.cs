namespace GTSysOne.Class.MasterFile
{
    public struct clsMas_ItemMaster
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
                                    ,"mas_sourced_brand_id"
                                    ,"mas_sourced_style_id"
                                    ,"doc_sourced_supplier_id"
                                    ,"mas_sourced_dccs_id"
                                    ,"doc_sourced_country_id"
                                    ,"mas_sourced_currency_id"
                                    ,"mas_sourced_agegroup_id"
                                    ,"mas_sourced_color_id"
                                    ,"mas_sourced_size_id"
                                    ,"mas_sourced_unitofmeasure_id"
                                    ,"mas_sourced_season_id"
                                    ,"mas_sourced_tax_id"
                                    ,"mas_sourced_commissioncode_id"
                                    ,"mas_sourced_attributes_id"
                                    ,"mas_sourced_gendergroup_id"
                                    ,"mas_sourced_defunitofmeasure_id"
                                    ,"mas_sourced_exchangerate_id"
                                    ,"mas_sourced_group_id"
                                    ,"name"
                                    ,"upc"
                                    ,"alu"
                                    ,"misccode"
                                    ,"desc1"
                                    ,"desc2"
                                    ,"desc3"
                                    ,"desc4"
                                    ,"leadtime"
                                    ,"ordercost"
                                    ,"articlenumber"
                                    ,"corporatemin"
                                    ,"corporatemax"
                                    ,"foccost"
                                    ,"commissionamount"
                                    ,"status"
                                    ,"type"
                                    ,"used"
                                    , "image"
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
                                    , string m_mas_sourced_brand_id = ""
                                    , string m_mas_sourced_style_id = ""
                                    , string m_doc_sourced_supplier_id = ""
                                    , string m_mas_sourced_dccs_id = ""
                                    , string m_doc_sourced_country_id = ""
                                    , string m_mas_sourced_currency_id = ""
                                    , string m_mas_sourced_agegroup_id = ""
                                    , string m_mas_sourced_color_id = ""
                                    , string m_mas_sourced_size_id = ""
                                    , string m_mas_sourced_unitofmeasure_id = ""
                                    , string m_mas_sourced_season_id = ""
                                    , string m_mas_sourced_tax_id = ""
                                    , string m_mas_sourced_commissioncode_id = ""
                                    , string m_mas_sourced_attributes_id = ""
                                    , string m_mas_sourced_gendergroup_id = ""
                                    , string m_mas_sourced_defunitofmeasure_id = ""
                                    , string m_mas_sourced_exchangerate_id = ""
                                    , string m_mas_sourced_group_id = ""
                                    , string m_name = ""
                                    , string m_upc = ""
                                    , string m_alu = ""
                                    , string m_misccode = ""
                                    , string m_desc1 = ""
                                    , string m_desc2 = ""
                                    , string m_desc3 = ""
                                    , string m_desc4 = ""
                                    , int m_leadtime = 0
                                    , double m_ordercost = 0.000
                                    , string m_articlenumber = ""
                                    , double m_corporatemin = 0.000
                                    , double m_corporatemax = 0.000
                                    , double m_foccost = 0.000
                                    , double m_commissionamount = 0.000
                                    , int m_status = 0
                                    , int m_type = 0
                                    , int m_used = 0
                                    , string m_image = ""
                                    , string m_NewPK = "@NewPK"
                                    )
        {
            object[] s_Value = new object[50];
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
            s_Value[12] = m_mas_sourced_brand_id;
            s_Value[13] = m_mas_sourced_style_id;
            s_Value[14] = m_doc_sourced_supplier_id;
            s_Value[15] = m_mas_sourced_dccs_id;
            s_Value[16] = m_doc_sourced_country_id;
            s_Value[17] = m_mas_sourced_currency_id;
            s_Value[18] = m_mas_sourced_agegroup_id;
            s_Value[19] = m_mas_sourced_color_id;
            s_Value[20] = m_mas_sourced_size_id;
            s_Value[21] = m_mas_sourced_unitofmeasure_id;
            s_Value[22] = m_mas_sourced_season_id;
            s_Value[23] = m_mas_sourced_tax_id;
            s_Value[24] = m_mas_sourced_commissioncode_id;
            s_Value[25] = m_mas_sourced_attributes_id;
            s_Value[26] = m_mas_sourced_gendergroup_id;
            s_Value[27] = m_mas_sourced_defunitofmeasure_id;
            s_Value[28] = m_mas_sourced_exchangerate_id;
            s_Value[29] = m_mas_sourced_group_id;
            s_Value[30] = m_name;
            s_Value[31] = m_upc;
            s_Value[32] = m_alu;
            s_Value[33] = m_misccode;
            s_Value[34] = m_desc1;
            s_Value[35] = m_desc2;
            s_Value[36] = m_desc3;
            s_Value[37] = m_desc4;
            s_Value[38] = m_leadtime;
            s_Value[39] = m_ordercost;
            s_Value[40] = m_articlenumber;
            s_Value[41] = m_corporatemin;
            s_Value[42] = m_corporatemax;
            s_Value[43] = m_foccost;
            s_Value[44] = m_commissionamount;
            s_Value[45] = m_status;
            s_Value[46] = m_type;
            s_Value[47] = m_used;
            s_Value[48] = m_image;
            s_Value[49] = m_NewPK;
            return s_Value;
        }
        #endregion
        public static string Save(object[] s_Value)
        {
            return (string)GTSysOne.Class.Utility.clsUtility.ManagedExecution(Column, s_Value, "sp_MasItemMaster", System.Convert.ToInt32(s_Value[0]), 0);
        }
        public static System.Data.DataTable ShowTable(object[] s_Value)
        {
            return (System.Data.DataTable)GTSysOne.Class.Utility.clsUtility.ManagedExecution(Column, s_Value, "sp_MasItemMaster", 0, 1);
        }
        public static object ScalarValue(object[] s_Value)
        {
            return GTSysOne.Class.Utility.clsUtility.ManagedExecution(Column, s_Value, "sp_MasItemMaster", 0, 2);
        }
        public static System.Data.DataSet ShowDataSet(object[] s_Value)
        {
            return (System.Data.DataSet)GTSysOne.Class.Utility.clsUtility.ManagedExecution(Column, s_Value, "sp_MasItemMaster", 0, 3);
        }
    }
}
