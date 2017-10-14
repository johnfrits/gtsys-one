namespace GTSysOne.Class.Mapping
{
    public struct clsMap_RentStatus
    {
        #region Column
        static string[] Column = {    "operation" 
                                    , "soperation"
                                    , "id"
                                    , "name"
                                    , "transmit"
                                    , "NewPK"
                                 };
        #endregion
        #region Value
        public static object[] Value(int m_operation = 0
                                    , int m_soperation = 0
                                    , string m_id = ""
                                    , string m_name = ""
                                    , string m_transmit = ""
                                    , string m_NewPK = "@NewPK"
                                    )
        {
            object[] s_Value = new object[6];
            s_Value[0] = m_operation;
            s_Value[1] = m_soperation;
            s_Value[2] = m_id;
            s_Value[3] = m_name;
            s_Value[4] = m_transmit;
            s_Value[5] = m_NewPK;
            return s_Value;
        }
        #endregion
        public static System.Data.DataTable ShowTable(object[] s_Value)
        {
            return (System.Data.DataTable)GTSysOne.Class.Utility.clsUtility.ManagedExecution(Column, s_Value, "sp_MapRentStatus", 0, 1);
        }
        public static object ScalarValue(object[] s_Value)
        {
            return GTSysOne.Class.Utility.clsUtility.ManagedExecution(Column, s_Value, "sp_MapRentStatus", 0, 2);
        }
        public static System.Data.DataSet ShowDataSet(object[] s_Value)
        {
            return (System.Data.DataSet)GTSysOne.Class.Utility.clsUtility.ManagedExecution(Column, s_Value, "sp_MapRentStatus", 0, 3);
        }
    }
}
