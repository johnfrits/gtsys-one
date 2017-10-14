namespace GTSysOne.Gui.Slip
{
    partial class frmRentSlipDeposit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRentSlipDeposit));
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnDeposit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEditDeposit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEditDeposit)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl
            // 
            this.gridControl.Location = new System.Drawing.Point(12, 12);
            this.gridControl.MainView = this.gridView;
            this.gridControl.Name = "gridControl";
            this.gridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEditDeposit});
            this.gridControl.Size = new System.Drawing.Size(412, 299);
            this.gridControl.TabIndex = 4;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnid,
            this.gridColumnDeposit});
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
            // gridColumnDeposit
            // 
            this.gridColumnDeposit.Caption = "Deposit";
            this.gridColumnDeposit.ColumnEdit = this.repositoryItemTextEditDeposit;
            this.gridColumnDeposit.FieldName = "Deposit";
            this.gridColumnDeposit.Name = "gridColumnDeposit";
            this.gridColumnDeposit.Visible = true;
            this.gridColumnDeposit.VisibleIndex = 0;
            this.gridColumnDeposit.Width = 394;
            // 
            // repositoryItemTextEditDeposit
            // 
            this.repositoryItemTextEditDeposit.AutoHeight = false;
            this.repositoryItemTextEditDeposit.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemTextEditDeposit.Mask.EditMask = "n2";
            this.repositoryItemTextEditDeposit.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.repositoryItemTextEditDeposit.Name = "repositoryItemTextEditDeposit";
            // 
            // frmRentSlipDeposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 325);
            this.Controls.Add(this.gridControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRentSlipDeposit";
            this.Text = "Deposit";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmRentSlipDeposit_FormClosing);
            this.Load += new System.EventHandler(this.frmRentSlipDeposit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEditDeposit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn gridColumnid;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnDeposit;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEditDeposit;
        public DevExpress.XtraGrid.GridControl gridControl;
        public DevExpress.XtraGrid.Views.Grid.GridView gridView;
    }
}