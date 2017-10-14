namespace GTSysOne.Gui.Slip
{
    partial class frmRentSlipInsurance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRentSlipInsurance));
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEditName = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemTextEditInsurance = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.gridColumnInsurance = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEditName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEditInsurance)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl
            // 
            this.gridControl.Location = new System.Drawing.Point(12, 12);
            this.gridControl.MainView = this.gridView;
            this.gridControl.Name = "gridControl";
            this.gridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEditName,
            this.repositoryItemTextEditInsurance});
            this.gridControl.Size = new System.Drawing.Size(533, 348);
            this.gridControl.TabIndex = 5;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnid,
            this.gridColumnName,
            this.gridColumnInsurance});
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
            this.gridColumnName.Width = 239;
            // 
            // repositoryItemTextEditName
            // 
            this.repositoryItemTextEditName.AutoHeight = false;
            this.repositoryItemTextEditName.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemTextEditName.Name = "repositoryItemTextEditName";
            // 
            // repositoryItemTextEditInsurance
            // 
            this.repositoryItemTextEditInsurance.AutoHeight = false;
            this.repositoryItemTextEditInsurance.Mask.EditMask = "n2";
            this.repositoryItemTextEditInsurance.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.repositoryItemTextEditInsurance.Name = "repositoryItemTextEditInsurance";
            // 
            // gridColumnInsurance
            // 
            this.gridColumnInsurance.Caption = "Insurance";
            this.gridColumnInsurance.ColumnEdit = this.repositoryItemTextEditInsurance;
            this.gridColumnInsurance.FieldName = "Insurance";
            this.gridColumnInsurance.Name = "gridColumnInsurance";
            this.gridColumnInsurance.Visible = true;
            this.gridColumnInsurance.VisibleIndex = 1;
            this.gridColumnInsurance.Width = 274;
            // 
            // frmRentSlipInsurance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 372);
            this.Controls.Add(this.gridControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRentSlipInsurance";
            this.Text = "Insurance";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmRentSlipInsurance_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEditName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEditInsurance)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public DevExpress.XtraGrid.GridControl gridControl;
        public DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnid;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnName;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEditName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnInsurance;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEditInsurance;
    }
}