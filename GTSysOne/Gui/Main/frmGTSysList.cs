namespace GTSysOne.Gui.Main
{
    public partial class frmGTSysList : DevExpress.XtraEditors.XtraForm
    {
        public bool p_isOk = false;
        public System.Collections.ArrayList MultipleRows = new System.Collections.ArrayList();
        System.Data.DataTable D = null;
        GTSysOne.Class.Utility.clsGlobal.myFunction F;
        int sOperation = 0;
        public frmGTSysList(GTSysOne.Class.Utility.clsGlobal.myFunction sF, int ssOperation = 0)
        {
            InitializeComponent();
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FORMCLOSING);
            this.btnSearch.Click += new System.EventHandler(this.CLICK);
            F = sF;
            sOperation = ssOperation;
            this.Search(F); this.KeyPreview = true;
            this.gridControlList.DoubleClick += new System.EventHandler(this.DOUBLECLICK);
            this.gridViewList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EVENT_SLIP_REMOVE_ENTRY_NOTES);
            GTSysOne.Class.Utility.clsUtility.Layout_Restore_Save(this.gridViewList, GTSysOne.Class.Utility.clsGlobal.GridLayout.Restore, GTSysOne.Class.Utility.clsGlobal.Instance().GridLayoutLocation + "Main\\" + this.Name.Replace("frm", "") + "\\", F.ToString() + sOperation.ToString(), this.gridControlList);
        }
        private void FORMCLOSING(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            GTSysOne.Class.Utility.clsUtility.Layout_Restore_Save(this.gridViewList, GTSysOne.Class.Utility.clsGlobal.GridLayout.Save, GTSysOne.Class.Utility.clsGlobal.Instance().GridLayoutLocation + "Main\\" + this.Name.Replace("frm", "") + "\\", F.ToString() + sOperation.ToString(), this.gridControlList);
        }
        private void CLICK(object sender, System.EventArgs e)
        {
            this.Search(F);
        }
        private void Search(GTSysOne.Class.Utility.clsGlobal.myFunction xF)
        {
            switch (xF)
            {
                //case GTSysOne.Class.Utility.clsGlobal.myFunction.Finance_Reports:
                //    switch (sOperation)
                //    {
                //        case 3:
                //            D = GTSysOne.Class.Slip.clsSlip_Period.ShowTable(GTSysOne.Class.Slip.clsSlip_Period.Value(0, sOperation
                //                , this.txtSearch.Text, "0", "0", "0", GTSysOne.Class.Utility.clsGlobal.Instance().COMPANYID));
                //            break;
                //    }
                //    break;
                case GTSysOne.Class.Utility.clsGlobal.myFunction.Company:
                    switch (sOperation)
                    {
                        case 0:
                            D = GTSysOne.Class.Document.clsDoc_Company.ShowTable(GTSysOne.Class.Document.clsDoc_Company.Value(0, 0
                                , this.txtSearch.Text));
                            break;
                    }
                    break;
                case GTSysOne.Class.Utility.clsGlobal.myFunction.Establishment:
                    switch (sOperation)
                    {
                        case 0:
                            D = GTSysOne.Class.MasterFile.clsMas_Establishment.ShowTable(GTSysOne.Class.MasterFile.clsMas_Establishment.Value(0
                                , 5, this.txtSearch.Text
                                , string.Empty
                                , false
                                , false
                                , GTSysOne.Class.Utility.clsGlobal.Instance().COMPANYID));
                            break;
                    }
                    break;
                case GTSysOne.Class.Utility.clsGlobal.myFunction.Driver:
                    switch (sOperation)
                    {
                        case 0:
                            D = GTSysOne.Class.MasterFile.clsMas_Driver.ShowTable(GTSysOne.Class.MasterFile.clsMas_Driver.Value(0
                                , 0, this.txtSearch.Text
                                , string.Empty
                                , false
                                , false
                                , GTSysOne.Class.Utility.clsGlobal.Instance().COMPANYID));
                            break;
                    }
                    break;
                case GTSysOne.Class.Utility.clsGlobal.myFunction.Group:
                    switch (sOperation)
                    {
                        case 0:
                            D = GTSysOne.Class.MasterFile.clsMas_Group.ShowTable(GTSysOne.Class.MasterFile.clsMas_Group.Value(0
                                , 500, this.txtSearch.Text
                                , string.Empty
                                , false
                                , false
                                , GTSysOne.Class.Utility.clsGlobal.Instance().COMPANYID));
                            break;
                    }
                    break;
                case GTSysOne.Class.Utility.clsGlobal.myFunction.Card:
                    switch (sOperation)
                    {
                        case 0:
                            D = GTSysOne.Class.MasterFile.clsMas_Card.ShowTable(GTSysOne.Class.MasterFile.clsMas_Card.Value(0
                                , 1, this.txtSearch.Text
                                , string.Empty
                                , false
                                , false
                                , GTSysOne.Class.Utility.clsGlobal.Instance().COMPANYID));
                            break;
                    }
                    break;
                //case GTSysOne.Class.Utility.clsGlobal.myFunction.Renter:
                //    switch (sOperation)
                //    {
                //        case 0:
                //            if (this.txtSearch.Text == string.Empty)
                //            {
                //                D = GTSysOne.Class.MasterFile.clsMas_Renter.ShowTable(GTSysOne.Class.MasterFile.clsMas_Renter.Value(0
                //                , 0, this.txtSearch.Text
                //                , string.Empty
                //                , false
                //                , false
                //                , GTSysOne.Class.Utility.clsGlobal.Instance().COMPANYID));
                //            }
                //            else
                //            {
                //                D = GTSysOne.Class.MasterFile.clsMas_Renter.ShowTable(GTSysOne.Class.MasterFile.clsMas_Renter.Value(0
                //                , 1
                //                , string.Empty
                //                , string.Empty
                //                , false
                //                , false
                //                , GTSysOne.Class.Utility.clsGlobal.Instance().COMPANYID
                //                , string.Empty
                //                , string.Empty
                //                , string.Empty
                //                , string.Empty
                //                , string.Empty
                //                , this.txtSearch.Text));
                //            }
                        
                //            break;
                //    }
                //    break;
                case GTSysOne.Class.Utility.clsGlobal.myFunction.Tax:
                    switch (sOperation)
                    {
                        case 0:
                            D = GTSysOne.Class.MasterFile.clsMas_Tax.ShowTable(GTSysOne.Class.MasterFile.clsMas_Tax.Value(0
                                , 0, this.txtSearch.Text
                                , string.Empty
                                , false
                                , false
                                , GTSysOne.Class.Utility.clsGlobal.Instance().COMPANYID));
                            break;
                    }
                    break;
                case GTSysOne.Class.Utility.clsGlobal.myFunction.FixedAssets:
                    switch (sOperation)
                    {
                        case 0:
                            D = GTSysOne.Class.Slip.clsSlip_FixedAssets.ShowTable(GTSysOne.Class.Slip.clsSlip_FixedAssets.Value(0
                                , 1, this.txtSearch.Text
                                , false
                                , false
                                , false
                                , GTSysOne.Class.Utility.clsGlobal.Instance().COMPANYID));
                            break;
                    }
                    break;
                //case GTSysOne.Class.Utility.clsGlobal.myFunction.Division:
                //    switch (sOperation)
                //    {
                //        case 0:
                //            D = GTSysOne.Class.MasterFile.clsMas_Division.ShowTable(GTSysOne.Class.MasterFile.clsMas_Division.Value(0, 0
                //                , this.txtSearch.Text
                //                , string.Empty
                //                , false
                //                , false
                //                , GTSysOne.Class.Utility.clsGlobal.Instance().COMPANYID));
                //            break;
                //    }
                //    break;
                case GTSysOne.Class.Utility.clsGlobal.myFunction.Region:
                    switch (sOperation)
                    {
                        case 0:
                            D = GTSysOne.Class.MasterFile.clsMas_Region.ShowTable(GTSysOne.Class.MasterFile.clsMas_Region.Value(0, 0
                                , this.txtSearch.Text
                                , string.Empty
                                , false
                                , false
                                , GTSysOne.Class.Utility.clsGlobal.Instance().COMPANYID));
                            break;
                    }
                    break;
                //case GTSysOne.Class.Utility.clsGlobal.myFunction.Department:
                //    switch (sOperation)
                //    {
                //        case 0:
                //            D = GTSysOne.Class.MasterFile.clsMas_Department.ShowTable(GTSysOne.Class.MasterFile.clsMas_Department.Value(0, 0
                //                , this.txtSearch.Text
                //                , string.Empty
                //                , false
                //                , false
                //                , GTSysOne.Class.Utility.clsGlobal.Instance().COMPANYID));
                //            break;
                //    }
                //    break;
                //case GTSysOne.Class.Utility.clsGlobal.myFunction.Chart_Of_Account:
                //    switch (sOperation)
                //    {
                //        case 11:
                //            //D = GTSysOne.Class.MasterFile.clsMas_ChartOfAccount.ShowTable(GTSysOne.Class.MasterFile.clsMas_ChartOfAccount.Value(0
                //            //    , 11, this.txtSearch.Text, string.Empty, false, false
                //            //    , GTSysOne.Class.Utility.clsGlobal.Instance().COMPANYID));
                //            D = GTSysOne.Class.Utility.clsGlobal.Instance().COAFULLLIST;
                //            break;
                //    }
                //    break;
                //case GTSysOne.Class.Utility.clsGlobal.myFunction.Bank:
                //    switch (sOperation)
                //    {
                //        case 5:
                //            D = GTSysOne.Class.MasterFile.clsMas_Bank.ShowTable(GTSysOne.Class.MasterFile.clsMas_Bank.Value(0, 5, this.txtSearch.Text, string.Empty, false, false, GTSysOne.Class.Utility.clsGlobal.Instance().COMPANYID));
                //            break;
                //    }
                //    break;
                //case GTSysOne.Class.Utility.clsGlobal.myFunction.Customer:
                //    switch (sOperation)
                //    {
                //        case 1:
                //            D = GTSysOne.Class.Document.clsDoc_Customer.ShowTable(GTSysOne.Class.Document.clsDoc_Customer.Value(0, 1, this.txtSearch.Text, string.Empty, false, false, false, GTSysOne.Class.Utility.clsGlobal.Instance().COMPANYID));
                //            break;

                //    }
                //    break;
                //case GTSysOne.Class.Utility.clsGlobal.myFunction.Supplier:
                //    switch (sOperation)
                //    {
                //        case 1:
                //            D = GTSysOne.Class.Document.clsDoc_Supplier.ShowTable(GTSysOne.Class.Document.clsDoc_Supplier.Value(0, 1, this.txtSearch.Text, string.Empty, false, false, false, GTSysOne.Class.Utility.clsGlobal.Instance().COMPANYID));
                //            break;

                //    }
                //    break;
                //case GTSysOne.Class.Utility.clsGlobal.myFunction.Unit_Of_Measure:
                //    switch (sOperation)
                //    {
                //        case 5:
                //            D = GTSysOne.Class.MasterFile.clsMas_UnitOfMeasure.ShowTable(GTSysOne.Class.MasterFile.clsMas_UnitOfMeasure.Value(0, 5, this.txtSearch.Text, string.Empty, false, false, GTSysOne.Class.Utility.clsGlobal.Instance().COMPANYID));
                //            break;

                //    }
                //    break;
                //case GTSysOne.Class.Utility.clsGlobal.myFunction.Item_Scale:
                //    switch (sOperation)
                //    {
                //        case 5:
                //            D = GTSysOne.Class.MasterFile.clsMas_ItemScale.ShowTable(GTSysOne.Class.MasterFile.clsMas_ItemScale.Value(0, 0
                //                 , this.txtSearch.Text
                //                 , string.Empty
                //                 , false
                //                 , false
                //                 , GTSysOne.Class.Utility.clsGlobal.Instance().COMPANYID));
                //            break;

                //    }
                //    break;
                case GTSysOne.Class.Utility.clsGlobal.myFunction.Item_Master:
                    this.gridViewList.OptionsSelection.MultiSelect = true;
                    switch (sOperation)
                    {
                        default:
                            D = GTSysOne.Class.Utility.clsGlobal.Instance().FullItemList;
                            break;

                    }

                    break;
            }
            GTSysOne.Class.Utility.clsUtility.View(this.gridControlList, this.gridViewList, 0, D, "id", true);
        }

        public bool IS_OK
        {
            get { return p_isOk; }
        }
        public System.Data.DataRow GetData
        {
            get
            {
                System.Data.DataTable dt = new System.Data.DataTable();
                dt.Columns.Add("return_value", typeof(string));
                System.Data.DataRow dr = dt.NewRow();
                dr[0] = "";
                if (this.IS_OK)
                {
                    return this.gridViewList.GetDataRow(this.gridViewList.FocusedRowHandle);
                }
                else
                {
                    return dr;
                }
            }
        }
        private void KEYDOWN(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.Escape)
            {
                this.p_isOk = false;
                this.Close();
            }
        }
        private void EVENT_SLIP_REMOVE_ENTRY_NOTES(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.Enter)
            {

                if (this.gridViewList.RowCount < 1) return;
                if (this.gridViewList.FocusedRowHandle < 0)
                {
                    this.gridViewList.FocusedRowHandle = 0;
                    this.p_isOk = true;
                    this.Hide();
                }
                else
                {
                    switch (F)
                    {
                        case GTSysOne.Class.Utility.clsGlobal.myFunction.Item_Master:
                            for (int i = 0; i < this.gridViewList.SelectedRowsCount; i++)
                            {
                                if (this.gridViewList.GetSelectedRows()[i] >= 0)
                                {
                                    MultipleRows.Add(this.gridViewList.GetDataRow(this.gridViewList.GetSelectedRows()[i]));
                                }
                            }
                            this.Close();
                            break;
                        default:
                            this.p_isOk = true;
                            this.Hide();
                            break;
                    }
                }
            }
        }
        private void DOUBLECLICK(object sender, System.EventArgs e)
        {
            if (this.gridViewList.RowCount < 1) return;
            if (this.gridViewList.FocusedRowHandle < 0) return;
            this.p_isOk = true;
            this.Hide();
        }

    }
}