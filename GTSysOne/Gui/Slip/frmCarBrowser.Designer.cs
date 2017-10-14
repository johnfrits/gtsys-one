namespace GTSysOne.Gui.Slip
{
    partial class frmCarBrowser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCarBrowser));
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnCarType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnCarModel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnCarColor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnPlateNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
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
            this.gridControl.Size = new System.Drawing.Size(673, 358);
            this.gridControl.TabIndex = 7;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnid,
            this.gridColumnName,
            this.gridColumnCarType,
            this.gridColumnCarModel,
            this.gridColumnCarColor,
            this.gridColumnPlateNumber});
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
            this.gridColumnName.Width = 122;
            // 
            // gridColumnCarType
            // 
            this.gridColumnCarType.Caption = "Car Type";
            this.gridColumnCarType.FieldName = "CarType";
            this.gridColumnCarType.Name = "gridColumnCarType";
            this.gridColumnCarType.OptionsColumn.AllowEdit = false;
            this.gridColumnCarType.Visible = true;
            this.gridColumnCarType.VisibleIndex = 1;
            this.gridColumnCarType.Width = 126;
            // 
            // gridColumnCarModel
            // 
            this.gridColumnCarModel.Caption = "Car Model";
            this.gridColumnCarModel.FieldName = "CarModel";
            this.gridColumnCarModel.Name = "gridColumnCarModel";
            this.gridColumnCarModel.OptionsColumn.AllowEdit = false;
            this.gridColumnCarModel.Visible = true;
            this.gridColumnCarModel.VisibleIndex = 2;
            this.gridColumnCarModel.Width = 140;
            // 
            // gridColumnCarColor
            // 
            this.gridColumnCarColor.Caption = "Car Color";
            this.gridColumnCarColor.FieldName = "CarColor";
            this.gridColumnCarColor.Name = "gridColumnCarColor";
            this.gridColumnCarColor.OptionsColumn.AllowEdit = false;
            this.gridColumnCarColor.Visible = true;
            this.gridColumnCarColor.VisibleIndex = 3;
            this.gridColumnCarColor.Width = 127;
            // 
            // gridColumnPlateNumber
            // 
            this.gridColumnPlateNumber.Caption = "Plate Number";
            this.gridColumnPlateNumber.FieldName = "PlateNumber";
            this.gridColumnPlateNumber.Name = "gridColumnPlateNumber";
            this.gridColumnPlateNumber.OptionsColumn.AllowEdit = false;
            this.gridColumnPlateNumber.Visible = true;
            this.gridColumnPlateNumber.VisibleIndex = 4;
            this.gridColumnPlateNumber.Width = 137;
            // 
            // frmCarBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 382);
            this.Controls.Add(this.gridControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCarBrowser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Car Browser";
            this.Load += new System.EventHandler(this.frmCarBrowser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public DevExpress.XtraGrid.GridControl gridControl;
        public DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnid;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnCarType;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnCarModel;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnCarColor;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnPlateNumber;
    }
}