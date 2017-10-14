namespace GTSysOne.Gui.Slip
{
    partial class frmRentSlipCreditCardDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRentSlipCreditCardDetails));
            this.btnPay = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEditName = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.gridColumnCardType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEditCardType = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.gridColumnCardNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEditCardNo = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.gridColumnExpiryDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEditExpiryDate = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.gridColumnValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEditValue = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEditName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEditCardType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEditCardNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEditExpiryDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEditValue)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPay
            // 
            this.btnPay.Location = new System.Drawing.Point(362, 216);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(153, 62);
            this.btnPay.TabIndex = 10;
            this.btnPay.Text = "Pay";
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // gridControl
            // 
            this.gridControl.Location = new System.Drawing.Point(12, 10);
            this.gridControl.MainView = this.gridView;
            this.gridControl.Name = "gridControl";
            this.gridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEditName,
            this.repositoryItemTextEditCardType,
            this.repositoryItemTextEditCardNo,
            this.repositoryItemTextEditExpiryDate,
            this.repositoryItemTextEditValue});
            this.gridControl.Size = new System.Drawing.Size(503, 200);
            this.gridControl.TabIndex = 13;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnid,
            this.gridColumnName,
            this.gridColumnCardType,
            this.gridColumnCardNo,
            this.gridColumnExpiryDate,
            this.gridColumnValue});
            this.gridView.GridControl = this.gridControl;
            this.gridView.Name = "gridView";
            this.gridView.OptionsView.ColumnAutoWidth = false;
            this.gridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView.OptionsView.ShowGroupPanel = false;
            this.gridView.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gridView_InitNewRow);
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
            this.gridColumnName.ColumnEdit = this.repositoryItemTextEditName;
            this.gridColumnName.FieldName = "Name";
            this.gridColumnName.Name = "gridColumnName";
            this.gridColumnName.Visible = true;
            this.gridColumnName.VisibleIndex = 0;
            this.gridColumnName.Width = 91;
            // 
            // repositoryItemTextEditName
            // 
            this.repositoryItemTextEditName.AutoHeight = false;
            this.repositoryItemTextEditName.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemTextEditName.Name = "repositoryItemTextEditName";
            // 
            // gridColumnCardType
            // 
            this.gridColumnCardType.Caption = "Card Type";
            this.gridColumnCardType.ColumnEdit = this.repositoryItemTextEditCardType;
            this.gridColumnCardType.FieldName = "CardType";
            this.gridColumnCardType.Name = "gridColumnCardType";
            this.gridColumnCardType.Visible = true;
            this.gridColumnCardType.VisibleIndex = 1;
            this.gridColumnCardType.Width = 111;
            // 
            // repositoryItemTextEditCardType
            // 
            this.repositoryItemTextEditCardType.AutoHeight = false;
            this.repositoryItemTextEditCardType.Name = "repositoryItemTextEditCardType";
            // 
            // gridColumnCardNo
            // 
            this.gridColumnCardNo.Caption = "Card No";
            this.gridColumnCardNo.ColumnEdit = this.repositoryItemTextEditCardNo;
            this.gridColumnCardNo.FieldName = "CardNo";
            this.gridColumnCardNo.Name = "gridColumnCardNo";
            this.gridColumnCardNo.Visible = true;
            this.gridColumnCardNo.VisibleIndex = 2;
            this.gridColumnCardNo.Width = 106;
            // 
            // repositoryItemTextEditCardNo
            // 
            this.repositoryItemTextEditCardNo.AutoHeight = false;
            this.repositoryItemTextEditCardNo.Name = "repositoryItemTextEditCardNo";
            // 
            // gridColumnExpiryDate
            // 
            this.gridColumnExpiryDate.Caption = "Expiry Date";
            this.gridColumnExpiryDate.ColumnEdit = this.repositoryItemTextEditExpiryDate;
            this.gridColumnExpiryDate.FieldName = "ExpiryDate";
            this.gridColumnExpiryDate.Name = "gridColumnExpiryDate";
            this.gridColumnExpiryDate.Visible = true;
            this.gridColumnExpiryDate.VisibleIndex = 3;
            this.gridColumnExpiryDate.Width = 91;
            // 
            // repositoryItemTextEditExpiryDate
            // 
            this.repositoryItemTextEditExpiryDate.AutoHeight = false;
            this.repositoryItemTextEditExpiryDate.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
            this.repositoryItemTextEditExpiryDate.Name = "repositoryItemTextEditExpiryDate";
            // 
            // gridColumnValue
            // 
            this.gridColumnValue.Caption = "Value";
            this.gridColumnValue.ColumnEdit = this.repositoryItemTextEditValue;
            this.gridColumnValue.FieldName = "Value";
            this.gridColumnValue.Name = "gridColumnValue";
            this.gridColumnValue.Visible = true;
            this.gridColumnValue.VisibleIndex = 4;
            this.gridColumnValue.Width = 86;
            // 
            // repositoryItemTextEditValue
            // 
            this.repositoryItemTextEditValue.AutoHeight = false;
            this.repositoryItemTextEditValue.Mask.EditMask = "n2";
            this.repositoryItemTextEditValue.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.repositoryItemTextEditValue.Name = "repositoryItemTextEditValue";
            // 
            // frmRentSlipCreditCardDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 290);
            this.Controls.Add(this.gridControl);
            this.Controls.Add(this.btnPay);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRentSlipCreditCardDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Credit Card Details";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEditName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEditCardType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEditCardNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEditExpiryDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEditValue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnPay;
        public DevExpress.XtraGrid.GridControl gridControl;
        public DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnid;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnName;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEditName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnCardType;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEditCardType;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnCardNo;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEditCardNo;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnExpiryDate;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEditExpiryDate;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnValue;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEditValue;

    }
}