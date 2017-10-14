namespace GTSysOne.Class.Utility
{
    public class clsExecution
    {
        public clsExecution() : base() { }
        private System.Data.SqlClient.SqlCommand Command = null;
        private System.Data.SqlClient.SqlTransaction Transaction;
        private System.Data.SqlClient.SqlDataAdapter DataAdapter;
        private System.Data.SqlClient.SqlDataReader DataReader;
        private System.Data.DataTable DataTables = null;
        private System.Data.DataSet DataSets = null;
        private object ScalarValue;

        public void Disposed()
        {
            if (Command != null)
            {
                Command.Dispose();
            }
            if (Transaction != null)
            {
                Transaction.Dispose();
            }
        }
        public object Fetched(string[] ColumnName, object[] Value, string ProcedureName, System.Data.CommandType CommandType = System.Data.CommandType.StoredProcedure, int Return = 0)
        {
            switch (Return)
            {
                case 1:
                    DataTables = new System.Data.DataTable();
                    DataReader = (Execute(ColumnName, Value, ProcedureName, CommandType, Return) ? DataReader : null);
                    switch (GTSysOne.Class.Utility.clsGlobal.Instance().Personalize_Designer)
                    {
                        case true:
                            switch (GTSysOne.Class.Utility.clsGlobal.Instance().Personalize_Designer_Error)
                            {
                                case "Valid Query":
                                    DataTables.Load(DataReader);
                                    break;
                            }
                            break;
                        default:
                            DataTables.Load(DataReader);
                            break;
                    }
                    break;
                case 2:
                    ScalarValue = (Execute(ColumnName, Value, ProcedureName, CommandType, Return) ? ScalarValue : null);
                    break;
                case 3:
                    DataSets = new System.Data.DataSet();
                    DataAdapter = (Execute(ColumnName, Value, ProcedureName, CommandType, Return) ? DataAdapter : null);
                    DataAdapter.Fill(DataSets);
                    GTSysOne.Class.Utility.clsGlobal.Instance().DataAdapter = DataAdapter;
                    break;
            }
            Disposed();
            if (Return == 1)
            {
                return DataTables;
            }
            else if (Return == 2)
            {
                return ScalarValue;
            }
            else
            {
                return DataSets;
            }
        }
        public bool Execute(string[] ColumnName, object[] Value, string ProcedureName, System.Data.CommandType CommandType = System.Data.CommandType.StoredProcedure, int Return = 0)
        {
            bool ok = true;
            switch (GTSysOne.Class.Utility.clsGlobal.Instance().OptimizeConnection)
            {
                case true:
                    InnerExecute(ColumnName, Value, ProcedureName, CommandType, Return);
                    break;
                case false:
                    try
                    {
                        InnerExecute(ColumnName, Value, ProcedureName, CommandType, Return);
                    }
                    catch
                    {

                    }
                    break;
            }
            return ok;
        }
        private void InnerExecute(string[] ColumnName, object[] Value, string ProcedureName, System.Data.CommandType CommandType = System.Data.CommandType.StoredProcedure, int Return = 0)
        {
            GTSysOne.Class.Utility.clsUtility.OpenConnection();
            Command = new System.Data.SqlClient.SqlCommand();
            Command.Connection = GTSysOne.Class.Utility.clsGlobal.Instance().Connection;
            Command.CommandText = ProcedureName;
            Command.CommandType = CommandType;
            Transaction = GTSysOne.Class.Utility.clsGlobal.Instance().Connection.BeginTransaction();
            Command.Transaction = Transaction;
            Command.Parameters.Clear();
            for (int C = 0; C <= Value.Length - 1; C++)
            {
                switch (ColumnName[C])
                {
                    case "NewPK":
                        Command.Parameters.Add("NewPK", System.Data.SqlDbType.NVarChar, 200).Direction = System.Data.ParameterDirection.Output;
                        break;
                    default:
                        Command.Parameters.AddWithValue(ColumnName[C], Value[C]);
                        break;
                }
            }
            switch (Return)
            {
                case 0://Saving || Updating. For more Info Visit Idris.com
                    Command.ExecuteNonQuery();
                    GTSysOne.Class.Utility.clsGlobal.Instance().NewPK = GTSysOne.Class.Utility.clsUtility.NulloEmptyString(Command.Parameters["NewPK"].Value);
                    GTSysOne.Class.Utility.clsGlobal.Instance().Commit = true;
                    break;
                case 1:// Execution With One Table With Execution And Muliple Rows And Columns.
                    switch (GTSysOne.Class.Utility.clsGlobal.Instance().Personalize_Designer)
                    {
                        case true:
                            try
                            {
                                DataReader = Command.ExecuteReader(System.Data.CommandBehavior.SequentialAccess);
                                GTSysOne.Class.Utility.clsGlobal.Instance().Personalize_Designer_Error = "Valid Query";
                            }
                            catch (System.Exception IDRIS)
                            {
                                GTSysOne.Class.Utility.clsGlobal.Instance().Personalize_Designer_Error = "Invalid Query\n" + IDRIS.Message;
                            }
                            break;
                        case false:
                            DataReader = Command.ExecuteReader(System.Data.CommandBehavior.SequentialAccess);
                            break;
                    }
                    break;
                case 2://Execution With One Data.One Column And Rows. ex. Max,Count,Min....
                    ScalarValue = Command.ExecuteScalar();
                    break;
                case 3:
                    DataAdapter = new System.Data.SqlClient.SqlDataAdapter(Command);
                    break;
            }
            switch(GTSysOne.Class.Utility.clsGlobal.Instance().Commit)
            {
                case true:
                    Transaction.Commit();
                    GTSysOne.Class.Utility.clsGlobal.Instance().Commit = false;
                    break;
            }
            Transaction.Dispose();
        }
    }
}
