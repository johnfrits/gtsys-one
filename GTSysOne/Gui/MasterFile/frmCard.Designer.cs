namespace GTSysOne.Gui.MasterFile
{
    partial class frmCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCard));
            this.textEditCSC = new DevExpress.XtraEditors.TextEdit();
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barNew = new DevExpress.XtraBars.BarButtonItem();
            this.barClose = new DevExpress.XtraBars.BarButtonItem();
            this.barSearch = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemSearchControl1 = new DevExpress.XtraEditors.Repository.RepositoryItemSearchControl();
            this.barFirst = new DevExpress.XtraBars.BarButtonItem();
            this.barPrevious = new DevExpress.XtraBars.BarButtonItem();
            this.barNext = new DevExpress.XtraBars.BarButtonItem();
            this.barLast = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barSave = new DevExpress.XtraBars.BarButtonItem();
            this.rpDefault = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpNew = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpSave = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpTools = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpSearch = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpClose = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.textEditCreditCardNo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.textEditExpiryDate = new DevExpress.XtraEditors.TextEdit();
            this.txtNumbering = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.chkActive = new DevExpress.XtraEditors.CheckEdit();
            this.lookUpEditCardType = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditCSC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditCreditCardNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditExpiryDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumbering.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkActive.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditCardType.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // textEditCSC
            // 
            this.textEditCSC.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textEditCSC.Location = new System.Drawing.Point(601, 212);
            this.textEditCSC.MenuManager = this.ribbon;
            this.textEditCSC.Name = "textEditCSC";
            this.textEditCSC.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.textEditCSC.Properties.Appearance.Options.UseFont = true;
            this.textEditCSC.Properties.Mask.EditMask = "d";
            this.textEditCSC.Properties.NullValuePrompt = "This field is optional.";
            this.textEditCSC.Size = new System.Drawing.Size(283, 22);
            this.textEditCSC.TabIndex = 3;
            // 
            // ribbon
            // 
            this.ribbon.ApplicationIcon = ((System.Drawing.Bitmap)(resources.GetObject("ribbon.ApplicationIcon")));
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.barNew,
            this.barClose,
            this.barSearch,
            this.barFirst,
            this.barPrevious,
            this.barNext,
            this.barLast,
            this.barButtonItem1,
            this.barSave});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 10;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rpDefault});
            this.ribbon.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemSearchControl1});
            this.ribbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbon.Size = new System.Drawing.Size(932, 143);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // barNew
            // 
            this.barNew.Caption = "New";
            this.barNew.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.barNew.Glyph = ((System.Drawing.Image)(resources.GetObject("barNew.Glyph")));
            this.barNew.Id = 1;
            this.barNew.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barNew.LargeGlyph")));
            this.barNew.LargeWidth = 100;
            this.barNew.Name = "barNew";
            // 
            // barClose
            // 
            this.barClose.Caption = "Close";
            this.barClose.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.barClose.Glyph = ((System.Drawing.Image)(resources.GetObject("barClose.Glyph")));
            this.barClose.Id = 2;
            this.barClose.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barClose.LargeGlyph")));
            this.barClose.LargeWidth = 100;
            this.barClose.Name = "barClose";
            // 
            // barSearch
            // 
            this.barSearch.Caption = "Search";
            this.barSearch.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.barSearch.Edit = this.repositoryItemSearchControl1;
            this.barSearch.Id = 3;
            this.barSearch.Name = "barSearch";
            this.barSearch.Width = 200;
            // 
            // repositoryItemSearchControl1
            // 
            this.repositoryItemSearchControl1.AutoHeight = false;
            this.repositoryItemSearchControl1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.repositoryItemSearchControl1.Name = "repositoryItemSearchControl1";
            this.repositoryItemSearchControl1.ShowDefaultButtonsMode = DevExpress.XtraEditors.Repository.ShowDefaultButtonsMode.Always;
            // 
            // barFirst
            // 
            this.barFirst.Caption = "First";
            this.barFirst.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.barFirst.Glyph = ((System.Drawing.Image)(resources.GetObject("barFirst.Glyph")));
            this.barFirst.Id = 4;
            this.barFirst.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barFirst.LargeGlyph")));
            this.barFirst.LargeWidth = 70;
            this.barFirst.Name = "barFirst";
            // 
            // barPrevious
            // 
            this.barPrevious.Caption = "Previous";
            this.barPrevious.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.barPrevious.Glyph = ((System.Drawing.Image)(resources.GetObject("barPrevious.Glyph")));
            this.barPrevious.Id = 5;
            this.barPrevious.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barPrevious.LargeGlyph")));
            this.barPrevious.LargeWidth = 70;
            this.barPrevious.Name = "barPrevious";
            // 
            // barNext
            // 
            this.barNext.Caption = "Next";
            this.barNext.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.barNext.Glyph = ((System.Drawing.Image)(resources.GetObject("barNext.Glyph")));
            this.barNext.Id = 6;
            this.barNext.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barNext.LargeGlyph")));
            this.barNext.LargeWidth = 70;
            this.barNext.Name = "barNext";
            // 
            // barLast
            // 
            this.barLast.Caption = "Last";
            this.barLast.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.barLast.Glyph = ((System.Drawing.Image)(resources.GetObject("barLast.Glyph")));
            this.barLast.Id = 7;
            this.barLast.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barLast.LargeGlyph")));
            this.barLast.LargeWidth = 70;
            this.barLast.Name = "barLast";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.barButtonItem1.Enabled = false;
            this.barButtonItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.Glyph")));
            this.barButtonItem1.Id = 8;
            this.barButtonItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.LargeGlyph")));
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barSave
            // 
            this.barSave.Caption = "Save";
            this.barSave.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.barSave.Glyph = ((System.Drawing.Image)(resources.GetObject("barSave.Glyph")));
            this.barSave.Id = 9;
            this.barSave.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barSave.LargeGlyph")));
            this.barSave.LargeWidth = 100;
            this.barSave.Name = "barSave";
            // 
            // rpDefault
            // 
            this.rpDefault.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpNew,
            this.rpSave,
            this.rpTools,
            this.rpSearch,
            this.rpClose});
            this.rpDefault.Name = "rpDefault";
            this.rpDefault.Text = "Card";
            // 
            // rpNew
            // 
            this.rpNew.ItemLinks.Add(this.barNew);
            this.rpNew.Name = "rpNew";
            this.rpNew.Text = "New";
            // 
            // rpSave
            // 
            this.rpSave.ItemLinks.Add(this.barSave);
            this.rpSave.Name = "rpSave";
            this.rpSave.Text = "Save";
            // 
            // rpTools
            // 
            this.rpTools.ItemLinks.Add(this.barFirst);
            this.rpTools.ItemLinks.Add(this.barPrevious);
            this.rpTools.ItemLinks.Add(this.barButtonItem1);
            this.rpTools.ItemLinks.Add(this.barNext);
            this.rpTools.ItemLinks.Add(this.barLast);
            this.rpTools.Name = "rpTools";
            this.rpTools.Text = "Tools";
            // 
            // rpSearch
            // 
            this.rpSearch.ItemLinks.Add(this.barSearch);
            this.rpSearch.Name = "rpSearch";
            this.rpSearch.Text = "Search";
            // 
            // rpClose
            // 
            this.rpClose.ItemLinks.Add(this.barClose);
            this.rpClose.Name = "rpClose";
            this.rpClose.Text = "Close";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 325);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(932, 31);
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.labelControl2.Location = new System.Drawing.Point(38, 246);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(64, 16);
            this.labelControl2.TabIndex = 74;
            this.labelControl2.Text = "Card Type";
            // 
            // textEditCreditCardNo
            // 
            this.textEditCreditCardNo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textEditCreditCardNo.Location = new System.Drawing.Point(601, 184);
            this.textEditCreditCardNo.MenuManager = this.ribbon;
            this.textEditCreditCardNo.Name = "textEditCreditCardNo";
            this.textEditCreditCardNo.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.textEditCreditCardNo.Properties.Appearance.Options.UseFont = true;
            this.textEditCreditCardNo.Properties.NullValuePrompt = "Card No.";
            this.textEditCreditCardNo.Properties.NullValuePromptShowForEmptyValue = true;
            this.textEditCreditCardNo.Size = new System.Drawing.Size(283, 22);
            this.textEditCreditCardNo.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.labelControl1.Location = new System.Drawing.Point(38, 218);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(37, 16);
            this.labelControl1.TabIndex = 73;
            this.labelControl1.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtName.Location = new System.Drawing.Point(170, 212);
            this.txtName.MenuManager = this.ribbon;
            this.txtName.Name = "txtName";
            this.txtName.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtName.Properties.Appearance.Options.UseFont = true;
            this.txtName.Properties.NullValuePrompt = "Name";
            this.txtName.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtName.Size = new System.Drawing.Size(283, 22);
            this.txtName.TabIndex = 0;
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.labelControl3.Location = new System.Drawing.Point(482, 190);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(53, 16);
            this.labelControl3.TabIndex = 76;
            this.labelControl3.Text = "Card No.";
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.labelControl4.Location = new System.Drawing.Point(482, 218);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(27, 16);
            this.labelControl4.TabIndex = 78;
            this.labelControl4.Text = "CSC";
            // 
            // labelControl5
            // 
            this.labelControl5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.labelControl5.Location = new System.Drawing.Point(482, 246);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(69, 16);
            this.labelControl5.TabIndex = 79;
            this.labelControl5.Text = "Expiry Date";
            // 
            // textEditExpiryDate
            // 
            this.textEditExpiryDate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textEditExpiryDate.Location = new System.Drawing.Point(601, 240);
            this.textEditExpiryDate.MenuManager = this.ribbon;
            this.textEditExpiryDate.Name = "textEditExpiryDate";
            this.textEditExpiryDate.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.textEditExpiryDate.Properties.Appearance.Options.UseFont = true;
            this.textEditExpiryDate.Properties.Mask.BeepOnError = true;
            this.textEditExpiryDate.Properties.Mask.EditMask = "d";
            this.textEditExpiryDate.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
            this.textEditExpiryDate.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.textEditExpiryDate.Properties.NullValuePrompt = "Expiry Date";
            this.textEditExpiryDate.Properties.NullValuePromptShowForEmptyValue = true;
            this.textEditExpiryDate.Size = new System.Drawing.Size(283, 22);
            this.textEditExpiryDate.TabIndex = 4;
            // 
            // txtNumbering
            // 
            this.txtNumbering.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtNumbering.Location = new System.Drawing.Point(170, 184);
            this.txtNumbering.MenuManager = this.ribbon;
            this.txtNumbering.Name = "txtNumbering";
            this.txtNumbering.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtNumbering.Properties.Appearance.Options.UseFont = true;
            this.txtNumbering.Properties.Mask.EditMask = "f";
            this.txtNumbering.Properties.NullValuePrompt = "Numbering";
            this.txtNumbering.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtNumbering.Size = new System.Drawing.Size(283, 22);
            this.txtNumbering.TabIndex = 83;
            // 
            // labelControl6
            // 
            this.labelControl6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.labelControl6.Location = new System.Drawing.Point(38, 190);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(66, 16);
            this.labelControl6.TabIndex = 82;
            this.labelControl6.Text = "Numbering";
            // 
            // chkActive
            // 
            this.chkActive.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.chkActive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkActive.Location = new System.Drawing.Point(601, 268);
            this.chkActive.MenuManager = this.ribbon;
            this.chkActive.Name = "chkActive";
            this.chkActive.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkActive.Properties.Appearance.Options.UseFont = true;
            this.chkActive.Properties.Caption = "Active";
            this.chkActive.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkActive.Size = new System.Drawing.Size(283, 20);
            this.chkActive.TabIndex = 84;
            // 
            // lookUpEditCardType
            // 
            this.lookUpEditCardType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lookUpEditCardType.Location = new System.Drawing.Point(170, 240);
            this.lookUpEditCardType.MenuManager = this.ribbon;
            this.lookUpEditCardType.Name = "lookUpEditCardType";
            this.lookUpEditCardType.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lookUpEditCardType.Properties.Appearance.Options.UseFont = true;
            this.lookUpEditCardType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditCardType.Properties.NullText = "";
            this.lookUpEditCardType.Size = new System.Drawing.Size(283, 22);
            this.lookUpEditCardType.TabIndex = 87;
            // 
            // frmCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 356);
            this.Controls.Add(this.lookUpEditCardType);
            this.Controls.Add(this.chkActive);
            this.Controls.Add(this.txtNumbering);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.textEditExpiryDate);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.textEditCSC);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.textEditCreditCardNo);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.ribbon);
            this.Name = "frmCard";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Card";
            ((System.ComponentModel.ISupportInitialize)(this.textEditCSC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditCreditCardNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditExpiryDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumbering.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkActive.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditCardType.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit textEditCSC;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.BarButtonItem barNew;
        private DevExpress.XtraBars.BarButtonItem barClose;
        private DevExpress.XtraBars.BarEditItem barSearch;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchControl repositoryItemSearchControl1;
        private DevExpress.XtraBars.BarButtonItem barFirst;
        private DevExpress.XtraBars.BarButtonItem barPrevious;
        private DevExpress.XtraBars.BarButtonItem barNext;
        private DevExpress.XtraBars.BarButtonItem barLast;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barSave;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpDefault;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpNew;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpSave;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpTools;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpSearch;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpClose;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit textEditCreditCardNo;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit textEditExpiryDate;
        private DevExpress.XtraEditors.TextEdit txtNumbering;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.CheckEdit chkActive;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditCardType;

    }
}