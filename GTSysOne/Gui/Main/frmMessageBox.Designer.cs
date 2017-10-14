namespace GTSysOne.Gui.Main
{
    partial class frmMessageBox
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMessageBox));
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnYes = new DevExpress.XtraEditors.SimpleButton();
            this.btnNo = new DevExpress.XtraEditors.SimpleButton();
            this.txtDetails = new DevExpress.XtraEditors.MemoEdit();
            this.trError = new System.Windows.Forms.TreeView();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.lblHeader = new DevExpress.XtraEditors.LabelControl();
            this.pctrIcons = new DevExpress.XtraEditors.PictureEdit();
            this.imgIcons32 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.txtDetails.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrIcons.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(275, 228);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(117, 29);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            // 
            // btnYes
            // 
            this.btnYes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnYes.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnYes.Appearance.Options.UseFont = true;
            this.btnYes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnYes.Image = ((System.Drawing.Image)(resources.GetObject("btnYes.Image")));
            this.btnYes.Location = new System.Drawing.Point(157, 228);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(117, 29);
            this.btnYes.TabIndex = 1;
            this.btnYes.Text = "Yes";
            // 
            // btnNo
            // 
            this.btnNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNo.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnNo.Appearance.Options.UseFont = true;
            this.btnNo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNo.Image = ((System.Drawing.Image)(resources.GetObject("btnNo.Image")));
            this.btnNo.Location = new System.Drawing.Point(392, 228);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(117, 29);
            this.btnNo.TabIndex = 2;
            this.btnNo.Text = "No";
            // 
            // txtDetails
            // 
            this.txtDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDetails.Location = new System.Drawing.Point(1, 168);
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtDetails.Properties.Appearance.Options.UseFont = true;
            this.txtDetails.Properties.ReadOnly = true;
            this.txtDetails.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDetails.Size = new System.Drawing.Size(511, 96);
            this.txtDetails.TabIndex = 4;
            // 
            // trError
            // 
            this.trError.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trError.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.trError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trError.Location = new System.Drawing.Point(2, 48);
            this.trError.Name = "trError";
            this.trError.Size = new System.Drawing.Size(510, 118);
            this.trError.TabIndex = 5;
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnOK.Appearance.Options.UseFont = true;
            this.btnOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOK.Image = ((System.Drawing.Image)(resources.GetObject("btnOK.Image")));
            this.btnOK.Location = new System.Drawing.Point(39, 228);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(117, 29);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "OK";
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.lblHeader);
            this.panelControl1.Controls.Add(this.pctrIcons);
            this.panelControl1.Location = new System.Drawing.Point(2, -1);
            this.panelControl1.LookAndFeel.SkinMaskColor = System.Drawing.Color.White;
            this.panelControl1.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.White;
            this.panelControl1.LookAndFeel.SkinName = "McSkin";
            this.panelControl1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003;
            this.panelControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(510, 48);
            this.panelControl1.TabIndex = 7;
            // 
            // lblHeader
            // 
            this.lblHeader.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(75, 15);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(9, 15);
            this.lblHeader.TabIndex = 1;
            this.lblHeader.Text = "...";
            // 
            // pctrIcons
            // 
            this.pctrIcons.EditValue = ((object)(resources.GetObject("pctrIcons.EditValue")));
            this.pctrIcons.Location = new System.Drawing.Point(9, 5);
            this.pctrIcons.Name = "pctrIcons";
            this.pctrIcons.Properties.AllowFocused = false;
            this.pctrIcons.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pctrIcons.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pctrIcons.Size = new System.Drawing.Size(56, 38);
            this.pctrIcons.TabIndex = 0;
            // 
            // imgIcons32
            // 
            this.imgIcons32.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgIcons32.ImageStream")));
            this.imgIcons32.TransparentColor = System.Drawing.Color.Transparent;
            this.imgIcons32.Images.SetKeyName(0, "Error.png");
            this.imgIcons32.Images.SetKeyName(1, "Information.png");
            this.imgIcons32.Images.SetKeyName(2, "Question.png");
            this.imgIcons32.Images.SetKeyName(3, "Stop.png");
            this.imgIcons32.Images.SetKeyName(4, "Warning.png");
            // 
            // frmMessageBox
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 264);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.trError);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtDetails);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "frmMessageBox";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Copyright © 2017 -2017 All Rights Reserved. www.GTSys.Com.Jo";
            ((System.ComponentModel.ISupportInitialize)(this.txtDetails.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrIcons.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public DevExpress.XtraEditors.SimpleButton btnCancel;
        public DevExpress.XtraEditors.SimpleButton btnYes;
        public DevExpress.XtraEditors.SimpleButton btnNo;
        public DevExpress.XtraEditors.MemoEdit txtDetails;
        private System.Windows.Forms.TreeView trError;
        public DevExpress.XtraEditors.SimpleButton btnOK;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PictureEdit pctrIcons;
        private DevExpress.XtraEditors.LabelControl lblHeader;
        private System.Windows.Forms.ImageList imgIcons32;

    }
}