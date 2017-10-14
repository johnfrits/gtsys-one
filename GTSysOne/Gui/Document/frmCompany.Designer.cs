namespace GTSysOne.Gui.Document
{
    partial class frmCompany
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
            p_instance = null;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCompany));
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
            this.rpCompany = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpNew = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpSave = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpTools = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpSearch = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpClose = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.lookUpEditCountry = new DevExpress.XtraEditors.LookUpEdit();
            this.lookUpEditDateFormat = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.txtAddress = new DevExpress.XtraEditors.TextEdit();
            this.txtWebsite = new DevExpress.XtraEditors.TextEdit();
            this.txtContactNo = new DevExpress.XtraEditors.TextEdit();
            this.txtEmail = new DevExpress.XtraEditors.TextEdit();
            this.txtOwner = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.chkActive = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.txtNumbering = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditCountry.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditDateFormat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWebsite.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContactNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOwner.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkActive.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumbering.Properties)).BeginInit();
            this.SuspendLayout();
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
            this.rpCompany});
            this.ribbon.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemSearchControl1});
            this.ribbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbon.Size = new System.Drawing.Size(951, 143);
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
            // rpCompany
            // 
            this.rpCompany.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpNew,
            this.rpSave,
            this.rpTools,
            this.rpSearch,
            this.rpClose});
            this.rpCompany.Name = "rpCompany";
            this.rpCompany.Text = "Company";
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
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 384);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(951, 31);
            // 
            // lookUpEditCountry
            // 
            this.lookUpEditCountry.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lookUpEditCountry.Location = new System.Drawing.Point(552, 206);
            this.lookUpEditCountry.MenuManager = this.ribbon;
            this.lookUpEditCountry.Name = "lookUpEditCountry";
            this.lookUpEditCountry.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lookUpEditCountry.Properties.Appearance.Options.UseFont = true;
            this.lookUpEditCountry.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditCountry.Properties.NullText = "";
            this.lookUpEditCountry.Properties.NullValuePrompt = "Country";
            this.lookUpEditCountry.Properties.NullValuePromptShowForEmptyValue = true;
            this.lookUpEditCountry.Size = new System.Drawing.Size(283, 22);
            this.lookUpEditCountry.TabIndex = 6;
            // 
            // lookUpEditDateFormat
            // 
            this.lookUpEditDateFormat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lookUpEditDateFormat.Location = new System.Drawing.Point(552, 232);
            this.lookUpEditDateFormat.MenuManager = this.ribbon;
            this.lookUpEditDateFormat.Name = "lookUpEditDateFormat";
            this.lookUpEditDateFormat.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lookUpEditDateFormat.Properties.Appearance.Options.UseFont = true;
            this.lookUpEditDateFormat.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditDateFormat.Properties.NullText = "";
            this.lookUpEditDateFormat.Properties.NullValuePrompt = "Date Format";
            this.lookUpEditDateFormat.Properties.NullValuePromptShowForEmptyValue = true;
            this.lookUpEditDateFormat.Size = new System.Drawing.Size(283, 22);
            this.lookUpEditDateFormat.TabIndex = 7;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.labelControl1.Location = new System.Drawing.Point(438, 209);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(45, 16);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Country";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.labelControl2.Location = new System.Drawing.Point(438, 234);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(75, 16);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Date Format";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(131, 210);
            this.txtName.MenuManager = this.ribbon;
            this.txtName.Name = "txtName";
            this.txtName.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtName.Properties.Appearance.Options.UseFont = true;
            this.txtName.Properties.NullValuePrompt = "Name";
            this.txtName.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtName.Size = new System.Drawing.Size(283, 22);
            this.txtName.TabIndex = 0;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(131, 236);
            this.txtAddress.MenuManager = this.ribbon;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtAddress.Properties.Appearance.Options.UseFont = true;
            this.txtAddress.Size = new System.Drawing.Size(283, 22);
            this.txtAddress.TabIndex = 1;
            // 
            // txtWebsite
            // 
            this.txtWebsite.Location = new System.Drawing.Point(131, 263);
            this.txtWebsite.MenuManager = this.ribbon;
            this.txtWebsite.Name = "txtWebsite";
            this.txtWebsite.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtWebsite.Properties.Appearance.Options.UseFont = true;
            this.txtWebsite.Size = new System.Drawing.Size(283, 22);
            this.txtWebsite.TabIndex = 2;
            // 
            // txtContactNo
            // 
            this.txtContactNo.Location = new System.Drawing.Point(131, 290);
            this.txtContactNo.MenuManager = this.ribbon;
            this.txtContactNo.Name = "txtContactNo";
            this.txtContactNo.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtContactNo.Properties.Appearance.Options.UseFont = true;
            this.txtContactNo.Size = new System.Drawing.Size(283, 22);
            this.txtContactNo.TabIndex = 3;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(131, 317);
            this.txtEmail.MenuManager = this.ribbon;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtEmail.Properties.Appearance.Options.UseFont = true;
            this.txtEmail.Size = new System.Drawing.Size(283, 22);
            this.txtEmail.TabIndex = 4;
            // 
            // txtOwner
            // 
            this.txtOwner.Location = new System.Drawing.Point(131, 344);
            this.txtOwner.MenuManager = this.ribbon;
            this.txtOwner.Name = "txtOwner";
            this.txtOwner.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtOwner.Properties.Appearance.Options.UseFont = true;
            this.txtOwner.Size = new System.Drawing.Size(283, 22);
            this.txtOwner.TabIndex = 5;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.labelControl3.Location = new System.Drawing.Point(23, 213);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(37, 16);
            this.labelControl3.TabIndex = 12;
            this.labelControl3.Text = "Name";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.labelControl4.Location = new System.Drawing.Point(23, 242);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(51, 16);
            this.labelControl4.TabIndex = 13;
            this.labelControl4.Text = "Address";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.labelControl5.Location = new System.Drawing.Point(23, 269);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(50, 16);
            this.labelControl5.TabIndex = 14;
            this.labelControl5.Text = "Website";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.labelControl6.Location = new System.Drawing.Point(23, 293);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(69, 16);
            this.labelControl6.TabIndex = 15;
            this.labelControl6.Text = "Contact No.";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.labelControl7.Location = new System.Drawing.Point(23, 320);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(34, 16);
            this.labelControl7.TabIndex = 16;
            this.labelControl7.Text = "Email";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.labelControl8.Location = new System.Drawing.Point(23, 350);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(38, 16);
            this.labelControl8.TabIndex = 17;
            this.labelControl8.Text = "Owner";
            // 
            // chkActive
            // 
            this.chkActive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkActive.Location = new System.Drawing.Point(552, 278);
            this.chkActive.MenuManager = this.ribbon;
            this.chkActive.Name = "chkActive";
            this.chkActive.Properties.Caption = "Active";
            this.chkActive.Size = new System.Drawing.Size(283, 19);
            this.chkActive.TabIndex = 20;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.labelControl9.Location = new System.Drawing.Point(23, 185);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(66, 16);
            this.labelControl9.TabIndex = 24;
            this.labelControl9.Text = "Numbering";
            // 
            // txtNumbering
            // 
            this.txtNumbering.Location = new System.Drawing.Point(131, 182);
            this.txtNumbering.MenuManager = this.ribbon;
            this.txtNumbering.Name = "txtNumbering";
            this.txtNumbering.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtNumbering.Properties.Appearance.Options.UseFont = true;
            this.txtNumbering.Properties.NullValuePrompt = "Numbering";
            this.txtNumbering.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtNumbering.Size = new System.Drawing.Size(283, 22);
            this.txtNumbering.TabIndex = 23;
            // 
            // frmCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 415);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.txtNumbering);
            this.Controls.Add(this.chkActive);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtOwner);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtContactNo);
            this.Controls.Add(this.txtWebsite);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.lookUpEditDateFormat);
            this.Controls.Add(this.lookUpEditCountry);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCompany";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Company";
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditCountry.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditDateFormat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWebsite.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContactNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOwner.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkActive.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumbering.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpCompany;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpNew;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem barNew;
        private DevExpress.XtraBars.BarButtonItem barClose;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpClose;
        private DevExpress.XtraBars.BarEditItem barSearch;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchControl repositoryItemSearchControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpTools;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpSearch;
        private DevExpress.XtraBars.BarButtonItem barFirst;
        private DevExpress.XtraBars.BarButtonItem barPrevious;
        private DevExpress.XtraBars.BarButtonItem barNext;
        private DevExpress.XtraBars.BarButtonItem barLast;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barSave;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpSave;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditCountry;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditDateFormat;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraEditors.TextEdit txtAddress;
        private DevExpress.XtraEditors.TextEdit txtWebsite;
        private DevExpress.XtraEditors.TextEdit txtContactNo;
        private DevExpress.XtraEditors.TextEdit txtEmail;
        private DevExpress.XtraEditors.TextEdit txtOwner;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.CheckEdit chkActive;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.TextEdit txtNumbering;
    }
}