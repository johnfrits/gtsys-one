namespace GTSysOne.Gui.Slip
{
    partial class frmCustomerBrowser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomerBrowser));
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnLicenseNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnPlace = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnIssueDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnCountry = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnCurrency = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnExchangeRate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEditName = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemTextEditLicenseNo = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemTextEditPlaceofIssue = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemTextEditIssueDate = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemTextEditCountry = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemTextEditCurrency = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemTextEditExRate = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEditName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEditLicenseNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEditPlaceofIssue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEditIssueDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEditCountry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEditCurrency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEditExRate)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl
            // 
            this.gridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl.Location = new System.Drawing.Point(12, 12);
            this.gridControl.MainView = this.gridView;
            this.gridControl.Name = "gridControl";
            this.gridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEditName,
            this.repositoryItemTextEditLicenseNo,
            this.repositoryItemTextEditPlaceofIssue,
            this.repositoryItemTextEditIssueDate,
            this.repositoryItemTextEditCountry,
            this.repositoryItemTextEditCurrency,
            this.repositoryItemTextEditExRate});
            this.gridControl.Size = new System.Drawing.Size(671, 348);
            this.gridControl.TabIndex = 6;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnid,
            this.gridColumnName,
            this.gridColumnLicenseNo,
            this.gridColumnPlace,
            this.gridColumnIssueDate,
            this.gridColumnCountry,
            this.gridColumnCurrency,
            this.gridColumnExchangeRate});
            this.gridView.GridControl = this.gridControl;
            this.gridView.Name = "gridView";
            this.gridView.OptionsView.ColumnAutoWidth = false;
            this.gridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView.OptionsView.ShowGroupPanel = false;
            this.gridView.DoubleClick += new System.EventHandler(this.gridView_DoubleClick);
            // 
            // gridColumnid
            // 
            this.gridColumnid.Caption = "gridColumnid";
            this.gridColumnid.FieldName = "id";
            this.gridColumnid.Name = "gridColumnid";
            // 
            // gridColumnName
            // 
            this.gridColumnName.Caption = "Name";
            this.gridColumnName.FieldName = "Name";
            this.gridColumnName.Name = "gridColumnName";
            this.gridColumnName.OptionsColumn.AllowEdit = false;
            this.gridColumnName.Visible = true;
            this.gridColumnName.VisibleIndex = 0;
            this.gridColumnName.Width = 163;
            // 
            // gridColumnLicenseNo
            // 
            this.gridColumnLicenseNo.Caption = "License No.";
            this.gridColumnLicenseNo.FieldName = "LicenseNo";
            this.gridColumnLicenseNo.Name = "gridColumnLicenseNo";
            this.gridColumnLicenseNo.OptionsColumn.AllowEdit = false;
            this.gridColumnLicenseNo.Visible = true;
            this.gridColumnLicenseNo.VisibleIndex = 1;
            this.gridColumnLicenseNo.Width = 150;
            // 
            // gridColumnPlace
            // 
            this.gridColumnPlace.Caption = "Place Of Issue";
            this.gridColumnPlace.FieldName = "PlaceOfIssue";
            this.gridColumnPlace.Name = "gridColumnPlace";
            this.gridColumnPlace.OptionsColumn.AllowEdit = false;
            this.gridColumnPlace.Visible = true;
            this.gridColumnPlace.VisibleIndex = 2;
            this.gridColumnPlace.Width = 166;
            // 
            // gridColumnIssueDate
            // 
            this.gridColumnIssueDate.Caption = "Issue Date";
            this.gridColumnIssueDate.FieldName = "IssueDate";
            this.gridColumnIssueDate.Name = "gridColumnIssueDate";
            this.gridColumnIssueDate.OptionsColumn.AllowEdit = false;
            this.gridColumnIssueDate.Visible = true;
            this.gridColumnIssueDate.VisibleIndex = 3;
            this.gridColumnIssueDate.Width = 173;
            // 
            // gridColumnCountry
            // 
            this.gridColumnCountry.Caption = "Country";
            this.gridColumnCountry.FieldName = "Country";
            this.gridColumnCountry.Name = "gridColumnCountry";
            // 
            // gridColumnCurrency
            // 
            this.gridColumnCurrency.Caption = "Currency";
            this.gridColumnCurrency.FieldName = "Currency";
            this.gridColumnCurrency.Name = "gridColumnCurrency";
            // 
            // gridColumnExchangeRate
            // 
            this.gridColumnExchangeRate.Caption = "ExchangeRate";
            this.gridColumnExchangeRate.FieldName = "ExchangeRate";
            this.gridColumnExchangeRate.Name = "gridColumnExchangeRate";
            // 
            // repositoryItemTextEditName
            // 
            this.repositoryItemTextEditName.AutoHeight = false;
            this.repositoryItemTextEditName.Name = "repositoryItemTextEditName";
            // 
            // repositoryItemTextEditLicenseNo
            // 
            this.repositoryItemTextEditLicenseNo.AutoHeight = false;
            this.repositoryItemTextEditLicenseNo.Name = "repositoryItemTextEditLicenseNo";
            // 
            // repositoryItemTextEditPlaceofIssue
            // 
            this.repositoryItemTextEditPlaceofIssue.AutoHeight = false;
            this.repositoryItemTextEditPlaceofIssue.Name = "repositoryItemTextEditPlaceofIssue";
            // 
            // repositoryItemTextEditIssueDate
            // 
            this.repositoryItemTextEditIssueDate.AutoHeight = false;
            this.repositoryItemTextEditIssueDate.Name = "repositoryItemTextEditIssueDate";
            // 
            // repositoryItemTextEditCountry
            // 
            this.repositoryItemTextEditCountry.AutoHeight = false;
            this.repositoryItemTextEditCountry.Name = "repositoryItemTextEditCountry";
            // 
            // repositoryItemTextEditCurrency
            // 
            this.repositoryItemTextEditCurrency.AutoHeight = false;
            this.repositoryItemTextEditCurrency.Name = "repositoryItemTextEditCurrency";
            // 
            // repositoryItemTextEditExRate
            // 
            this.repositoryItemTextEditExRate.AutoHeight = false;
            this.repositoryItemTextEditExRate.Name = "repositoryItemTextEditExRate";
            // 
            // frmCustomerBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 371);
            this.Controls.Add(this.gridControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCustomerBrowser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerBrowser";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEditName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEditLicenseNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEditPlaceofIssue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEditIssueDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEditCountry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEditCurrency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEditExRate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public DevExpress.XtraGrid.GridControl gridControl;
        public DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnid;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnLicenseNo;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEditLicenseNo;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnPlace;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEditPlaceofIssue;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnIssueDate;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEditIssueDate;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnName;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEditName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnCountry;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnCurrency;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnExchangeRate;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEditCountry;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEditCurrency;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEditExRate;
    }
}