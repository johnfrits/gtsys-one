namespace GTSysOne.Gui.Slip
{
    partial class frmTaxBrowser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTaxBrowser));
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnOk = new DevExpress.XtraEditors.SimpleButton();
            this.grdViewTax = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnTaxId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnTaxCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnTaxName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdControlTax = new DevExpress.XtraGrid.GridControl();
            this.gridColumnTaxPercentage = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdViewTax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdControlTax)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(581, 421);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(91, 28);
            this.btnCancel.TabIndex = 54;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Location = new System.Drawing.Point(484, 421);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(91, 28);
            this.btnOk.TabIndex = 53;
            this.btnOk.Text = "Ok";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // grdViewTax
            // 
            this.grdViewTax.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnTaxId,
            this.gridColumnTaxCode,
            this.gridColumnTaxName,
            this.gridColumnTaxPercentage});
            this.grdViewTax.GridControl = this.grdControlTax;
            this.grdViewTax.Name = "grdViewTax";
            this.grdViewTax.OptionsBehavior.Editable = false;
            this.grdViewTax.OptionsView.ShowGroupPanel = false;
            this.grdViewTax.DoubleClick += new System.EventHandler(this.grdViewTax_DoubleClick);
            // 
            // gridColumnTaxId
            // 
            this.gridColumnTaxId.Caption = "Id";
            this.gridColumnTaxId.FieldName = "id";
            this.gridColumnTaxId.Name = "gridColumnTaxId";
            // 
            // gridColumnTaxCode
            // 
            this.gridColumnTaxCode.Caption = "Tax Code";
            this.gridColumnTaxCode.FieldName = "num";
            this.gridColumnTaxCode.Name = "gridColumnTaxCode";
            this.gridColumnTaxCode.Visible = true;
            this.gridColumnTaxCode.VisibleIndex = 0;
            // 
            // gridColumnTaxName
            // 
            this.gridColumnTaxName.Caption = "Tax Name";
            this.gridColumnTaxName.FieldName = "name";
            this.gridColumnTaxName.Name = "gridColumnTaxName";
            this.gridColumnTaxName.Visible = true;
            this.gridColumnTaxName.VisibleIndex = 1;
            // 
            // grdControlTax
            // 
            this.grdControlTax.Dock = System.Windows.Forms.DockStyle.Top;
            this.grdControlTax.Location = new System.Drawing.Point(0, 0);
            this.grdControlTax.MainView = this.grdViewTax;
            this.grdControlTax.Name = "grdControlTax";
            this.grdControlTax.Size = new System.Drawing.Size(684, 399);
            this.grdControlTax.TabIndex = 55;
            this.grdControlTax.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdViewTax});
            // 
            // gridColumnTaxPercentage
            // 
            this.gridColumnTaxPercentage.Caption = "Tax %";
            this.gridColumnTaxPercentage.FieldName = "percentage";
            this.gridColumnTaxPercentage.Name = "gridColumnTaxPercentage";
            this.gridColumnTaxPercentage.Visible = true;
            this.gridColumnTaxPercentage.VisibleIndex = 2;
            // 
            // frmTaxBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.grdControlTax);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTaxBrowser";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tax Browser";
            ((System.ComponentModel.ISupportInitialize)(this.grdViewTax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdControlTax)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnOk;
        private DevExpress.XtraGrid.Views.Grid.GridView grdViewTax;
        private DevExpress.XtraGrid.GridControl grdControlTax;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnTaxId;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnTaxCode;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnTaxName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnTaxPercentage;
    }
}