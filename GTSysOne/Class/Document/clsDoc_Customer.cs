using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTSysOne.Class.Document
{
    public struct clsDoc_Customer
    {
        #region Column
        static string[] Column = {
                                     "operation"
                                    , "soperation"
                                    , "id"
                                    , "num"
                                    , "deleted"
                                    , "void"
                                    , "transmit"
                                    , "doc_source_company_id"
                                    , "mas_source_establishment_id"
                                    , "mas_source_station_id"
                                    , "mas_source_function_id"
                                    , "doc_source_userid_id"
                                    , "datecreate"
                                    , "mas_sourced_mas_group_id"
                                    , "recordtype"
                                    , "name"
                                    , "first"
                                    , "middle"
                                    , "last"
                                    , "vatno"
                                    , "tel1"
                                    , "tel2"
                                    , "mobile"
                                    , "fax"
                                    , "email"
                                    , "website"
                                    , "accountsreceivable"
                                    , "downpaymentclearingaccount"
                                    , "downpaymentinterimaccount"
                                    , "accountbalance"
                                    , "deliveries"
                                    , "orders"
                                    , "opportunities"
                                    , "license_no"
                                    , "place_of_issue"
                                    , "issue_date"
                                    , "expiry_date"
                                    , "map_sourced_nationality_id"
	                                , "mas_sourced_identity_id"
	                                , "date_of_birth"					
	                                , "place_of_birth"					
                                    , "NewPK"
                                };
        #endregion

        #region Value
        public static object[] Value(int m_operation = 0
                                    , int m_soperation = 0
                                    , string m_id = ""
                                    , string m_num = ""
                                    , bool m_delete = false
                                    , bool m_void = false
                                    , bool m_transmit = false
                                    , string m_doc_source_company_id = ""
                                    , string m_mas_source_establishment_id = ""
                                    , string m_mas_source_station_id = ""
                                    , string m_mas_source_function_id = ""
                                    , string m_doc_source_userid_id = ""
                                    , string m_datecreate = ""
                                    , string m_mas_sourced_mas_group_id = ""
                                    , string m_recordtype = ""
                                    , string m_name = ""
                                    , string m_first = ""
                                    , string m_middle = ""
                                    , string m_last = ""
                                    , string m_vatno = ""
                                    , string m_tel1 = ""
                                    , string m_tel2 = ""
                                    , string m_mobile = ""
                                    , string m_fax = ""
                                    , string m_email = ""
                                    , string m_website = ""
                                    , string m_accountsreceivable = ""
                                    , string m_downpaymentclearingaccount = ""
                                    , string m_downpaymentinterimaccount = ""
                                    , int m_accountbalance = 0
                                    , int m_deliveries = 0
                                    , int m_orders = 0
                                    , int m_oppurtunities = 0
                                    , string m_license_no = ""
                                    , string m_place_of_issue = ""
                                    , string m_issue_date = ""
                                    , string m_expiry_date = ""
                                    , string m_map_sourced_nationality_id = ""
	                                , string m_mas_sourced_identity_id = ""
	                                , string m_date_of_birth = ""					
	                                , string m_place_of_birth = ""			
	                                , string m_address = ""				
                                    , string m_NewPK = "@NewPK")
        {
            object[] s_Value = new object[42];
            s_Value[0] = m_operation;
            s_Value[1] = m_soperation;
            s_Value[2] = m_id;
            s_Value[3] = m_num;
            s_Value[4] = m_delete;
            s_Value[5] = m_void;
            s_Value[6] = m_transmit;
            s_Value[7] = m_doc_source_company_id;
            s_Value[8] = m_mas_source_establishment_id;
            s_Value[9] = m_mas_source_station_id;
            s_Value[10] = m_mas_source_function_id;
            s_Value[11] = m_doc_source_userid_id;
            s_Value[12] = m_datecreate;
            s_Value[13] = m_mas_sourced_mas_group_id;
            s_Value[14] = m_recordtype;
            s_Value[15] = m_name;
            s_Value[16] = m_first;
            s_Value[17] = m_middle;
            s_Value[18] = m_last;
            s_Value[19] = m_vatno;
            s_Value[20] = m_tel1;
            s_Value[21] = m_tel2;
            s_Value[22] = m_mobile;
            s_Value[23] = m_fax;
            s_Value[24] = m_email;
            s_Value[25] = m_website;
            s_Value[26] = m_accountsreceivable;
            s_Value[27] = m_downpaymentclearingaccount;
            s_Value[28] = m_downpaymentinterimaccount;
            s_Value[29] = m_accountbalance;
            s_Value[30] = m_deliveries;
            s_Value[31] = m_orders;
            s_Value[32] = m_license_no;
            s_Value[33] = m_place_of_issue;
            s_Value[34] = m_issue_date;
            s_Value[35] = m_expiry_date;
            s_Value[36] = m_map_sourced_nationality_id;
	        s_Value[37] = m_mas_sourced_identity_id;
	        s_Value[38] = m_date_of_birth;					
	        s_Value[39] = m_place_of_birth;
            s_Value[40] = m_address;		
            s_Value[41] = m_NewPK;

            return s_Value;
        }
        #endregion

        public static System.Data.DataTable ShowTable(object[] s_Value)
        {
            return (System.Data.DataTable)GTSysOne.Class.Utility.clsUtility.ManagedExecution(Column, s_Value, "sp_DocCustomer", 0, 1);
        }
    }
}
