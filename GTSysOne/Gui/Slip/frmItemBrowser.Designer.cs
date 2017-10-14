namespace GTSysOne.Gui.Slip
{
    partial class frmItemBrowser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmItemBrowser));
            this.txtDocumentNo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnOk = new DevExpress.XtraEditors.SimpleButton();
            this.grdViewItems = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.desc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.defaultpricebeforetax = new DevExpress.XtraGrid.Columns.GridColumn();
            this.defaultpriceaftertax = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdControlItems = new DevExpress.XtraGrid.GridControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtDocumentNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdViewItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdControlItems)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDocumentNo
            // 
            this.txtDocumentNo.Location = new System.Drawing.Point(389, 21);
            this.txtDocumentNo.Name = "txtDocumentNo";
            this.txtDocumentNo.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtDocumentNo.Properties.Appearance.Options.UseFont = true;
            this.txtDocumentNo.Size = new System.Drawing.Size(283, 22);
            this.txtDocumentNo.TabIndex = 51;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.labelControl9.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl9.Location = new System.Drawing.Point(300, 24);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(83, 16);
            this.labelControl9.TabIndex = 52;
            this.labelControl9.Text = "Search Name";
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
            // grdViewItems
            // 
            this.grdViewItems.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.id,
            this.name,
            this.desc,
            this.defaultpricebeforetax,
            this.defaultpriceaftertax});
            this.grdViewItems.GridControl = this.grdControlItems;
            this.grdViewItems.Name = "grdViewItems";
            this.grdViewItems.OptionsBehavior.Editable = false;
            this.grdViewItems.OptionsView.ShowGroupPanel = false;
            this.grdViewItems.DoubleClick += new System.EventHandler(this.grdViewItems_DoubleClick);
            // 
            // id
            // 
            this.id.Caption = "Id";
            this.id.FieldName = "id";
            this.id.Name = "id";
            // 
            // name
            // 
            this.name.Caption = "Name";
            this.name.FieldName = "name";
            this.name.Name = "name";
            this.name.Visible = true;
            this.name.VisibleIndex = 0;
            this.name.Width = 166;
            // 
            // desc
            // 
            this.desc.Caption = "Description";
            this.desc.FieldName = "desc1";
            this.desc.Name = "desc";
            this.desc.Visible = true;
            this.desc.VisibleIndex = 1;
            this.desc.Width = 166;
            // 
            // defaultpricebeforetax
            // 
            this.defaultpricebeforetax.Caption = "Unit Price Excl. VAT";
            this.defaultpricebeforetax.FieldName = "defaultpricebeforetax";
            this.defaultpricebeforetax.Name = "defaultpricebeforetax";
            this.defaultpricebeforetax.Visible = true;
            this.defaultpricebeforetax.VisibleIndex = 2;
            this.defaultpricebeforetax.Width = 105;
            // 
            // defaultpriceaftertax
            // 
            this.defaultpriceaftertax.Caption = "Unit Price Incl. VAT";
            this.defaultpriceaftertax.FieldName = "defaultpriceaftertax";
            this.defaultpriceaftertax.Name = "defaultpriceaftertax";
            this.defaultpriceaftertax.Visible = true;
            this.defaultpriceaftertax.VisibleIndex = 3;
            this.defaultpriceaftertax.Width = 105;
            // 
            // grdControlItems
            // 
            this.grdControlItems.Location = new System.Drawing.Point(1, 66);
            this.grdControlItems.MainView = this.grdViewItems;
            this.grdControlItems.Name = "grdControlItems";
            this.grdControlItems.Size = new System.Drawing.Size(682, 334);
            this.grdControlItems.TabIndex = 55;
            this.grdControlItems.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdViewItems});
            // 
            // frmItemBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.grdControlItems);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.txtDocumentNo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmItemBrowser";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Item Browser";
            ((System.ComponentModel.ISupportInitialize)(this.txtDocumentNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdViewItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdControlItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.TextEdit txtDocumentNo;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnOk;
        private DevExpress.XtraGrid.Views.Grid.GridView grdViewItems;
        private DevExpress.XtraGrid.GridControl grdControlItems;
        private DevExpress.XtraGrid.Columns.GridColumn id;
        private DevExpress.XtraGrid.Columns.GridColumn name;
        private DevExpress.XtraGrid.Columns.GridColumn desc;
        private DevExpress.XtraGrid.Columns.GridColumn defaultpricebeforetax;
        private DevExpress.XtraGrid.Columns.GridColumn defaultpriceaftertax;
    }
}