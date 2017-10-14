namespace GTSysOne.Gui.MasterFile
{
    partial class frmRenter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRenter));
            this.textEditLicenseNo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.textEditdob = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.textEditpob = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtTelephoneNumber = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtRenterName = new DevExpress.XtraEditors.TextEdit();
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
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.textEditPlaceOfIssue = new DevExpress.XtraEditors.TextEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.textEditIssueDate = new DevExpress.XtraEditors.TextEdit();
            this.labelControl16 = new DevExpress.XtraEditors.LabelControl();
            this.textEditExpiryDate = new DevExpress.XtraEditors.TextEdit();
            this.txtNumbering = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.textEditLicenseNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditdob.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditpob.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelephoneNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRenterName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditPlaceOfIssue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditIssueDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditExpiryDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumbering.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // textEditLicenseNo
            // 
            this.textEditLicenseNo.Location = new System.Drawing.Point(636, 196);
            this.textEditLicenseNo.Name = "textEditLicenseNo";
            this.textEditLicenseNo.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEditLicenseNo.Properties.Appearance.Options.UseFont = true;
            this.textEditLicenseNo.Properties.NullValuePrompt = "License No.";
            this.textEditLicenseNo.Properties.NullValuePromptShowForEmptyValue = true;
            this.textEditLicenseNo.Size = new System.Drawing.Size(250, 22);
            this.textEditLicenseNo.TabIndex = 5;
            // 
            // labelControl15
            // 
            this.labelControl15.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl15.Location = new System.Drawing.Point(519, 199);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(71, 16);
            this.labelControl15.TabIndex = 69;
            this.labelControl15.Text = "License No.";
            // 
            // textEditdob
            // 
            this.textEditdob.Location = new System.Drawing.Point(189, 252);
            this.textEditdob.Name = "textEditdob";
            this.textEditdob.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEditdob.Properties.Appearance.Options.UseFont = true;
            this.textEditdob.Properties.Mask.BeepOnError = true;
            this.textEditdob.Properties.Mask.EditMask = "D";
            this.textEditdob.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
            this.textEditdob.Properties.NullValuePrompt = "Date of Birth";
            this.textEditdob.Properties.NullValuePromptShowForEmptyValue = true;
            this.textEditdob.Size = new System.Drawing.Size(250, 22);
            this.textEditdob.TabIndex = 3;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Location = new System.Drawing.Point(64, 227);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(117, 16);
            this.labelControl8.TabIndex = 54;
            this.labelControl8.Text = "Telephone Number";
            // 
            // textEditpob
            // 
            this.textEditpob.Location = new System.Drawing.Point(189, 280);
            this.textEditpob.Name = "textEditpob";
            this.textEditpob.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEditpob.Properties.Appearance.Options.UseFont = true;
            this.textEditpob.Properties.NullValuePrompt = "Place of Birth";
            this.textEditpob.Properties.NullValuePromptShowForEmptyValue = true;
            this.textEditpob.Size = new System.Drawing.Size(250, 22);
            this.textEditpob.TabIndex = 4;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Location = new System.Drawing.Point(64, 286);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(78, 16);
            this.labelControl7.TabIndex = 49;
            this.labelControl7.Text = "Place of Birth";
            // 
            // txtTelephoneNumber
            // 
            this.txtTelephoneNumber.Location = new System.Drawing.Point(189, 224);
            this.txtTelephoneNumber.Name = "txtTelephoneNumber";
            this.txtTelephoneNumber.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelephoneNumber.Properties.Appearance.Options.UseFont = true;
            this.txtTelephoneNumber.Properties.NullValuePrompt = "Telephone Number";
            this.txtTelephoneNumber.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtTelephoneNumber.Size = new System.Drawing.Size(250, 22);
            this.txtTelephoneNumber.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(64, 197);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(80, 16);
            this.labelControl1.TabIndex = 29;
            this.labelControl1.Text = "Renter Name";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(64, 255);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(72, 16);
            this.labelControl3.TabIndex = 33;
            this.labelControl3.Text = "Date of Birth";
            // 
            // txtRenterName
            // 
            this.txtRenterName.Location = new System.Drawing.Point(189, 196);
            this.txtRenterName.Name = "txtRenterName";
            this.txtRenterName.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRenterName.Properties.Appearance.Options.UseFont = true;
            this.txtRenterName.Properties.NullValuePrompt = "Renter Name";
            this.txtRenterName.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtRenterName.Size = new System.Drawing.Size(250, 22);
            this.txtRenterName.TabIndex = 1;
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
            this.ribbon.Size = new System.Drawing.Size(972, 143);
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
            this.rpDefault.Text = "Renter";
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
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 371);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(972, 31);
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Location = new System.Drawing.Point(520, 258);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(64, 16);
            this.labelControl6.TabIndex = 53;
            this.labelControl6.Text = "Issue Date";
            // 
            // textEditPlaceOfIssue
            // 
            this.textEditPlaceOfIssue.Location = new System.Drawing.Point(637, 224);
            this.textEditPlaceOfIssue.Name = "textEditPlaceOfIssue";
            this.textEditPlaceOfIssue.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEditPlaceOfIssue.Properties.Appearance.Options.UseFont = true;
            this.textEditPlaceOfIssue.Properties.NullValuePrompt = "Place of Issue";
            this.textEditPlaceOfIssue.Properties.NullValuePromptShowForEmptyValue = true;
            this.textEditPlaceOfIssue.Size = new System.Drawing.Size(249, 22);
            this.textEditPlaceOfIssue.TabIndex = 6;
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl11.Location = new System.Drawing.Point(520, 230);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(84, 16);
            this.labelControl11.TabIndex = 61;
            this.labelControl11.Text = "Place of Issue";
            // 
            // textEditIssueDate
            // 
            this.textEditIssueDate.Location = new System.Drawing.Point(637, 252);
            this.textEditIssueDate.Name = "textEditIssueDate";
            this.textEditIssueDate.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEditIssueDate.Properties.Appearance.Options.UseFont = true;
            this.textEditIssueDate.Properties.Mask.BeepOnError = true;
            this.textEditIssueDate.Properties.Mask.EditMask = "D";
            this.textEditIssueDate.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
            this.textEditIssueDate.Properties.NullValuePrompt = "Issue Date";
            this.textEditIssueDate.Properties.NullValuePromptShowForEmptyValue = true;
            this.textEditIssueDate.Size = new System.Drawing.Size(249, 22);
            this.textEditIssueDate.TabIndex = 7;
            // 
            // labelControl16
            // 
            this.labelControl16.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl16.Location = new System.Drawing.Point(520, 286);
            this.labelControl16.Name = "labelControl16";
            this.labelControl16.Size = new System.Drawing.Size(69, 16);
            this.labelControl16.TabIndex = 71;
            this.labelControl16.Text = "Expiry Date";
            // 
            // textEditExpiryDate
            // 
            this.textEditExpiryDate.Location = new System.Drawing.Point(637, 280);
            this.textEditExpiryDate.Name = "textEditExpiryDate";
            this.textEditExpiryDate.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEditExpiryDate.Properties.Appearance.Options.UseFont = true;
            this.textEditExpiryDate.Properties.Mask.BeepOnError = true;
            this.textEditExpiryDate.Properties.Mask.EditMask = "D";
            this.textEditExpiryDate.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
            this.textEditExpiryDate.Properties.NullValuePrompt = "Expiry Date";
            this.textEditExpiryDate.Properties.NullValuePromptShowForEmptyValue = true;
            this.textEditExpiryDate.Size = new System.Drawing.Size(250, 22);
            this.textEditExpiryDate.TabIndex = 8;
            // 
            // txtNumbering
            // 
            this.txtNumbering.Location = new System.Drawing.Point(189, 168);
            this.txtNumbering.MenuManager = this.ribbon;
            this.txtNumbering.Name = "txtNumbering";
            this.txtNumbering.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtNumbering.Properties.Appearance.Options.UseFont = true;
            this.txtNumbering.Properties.NullValuePrompt = "Numbering";
            this.txtNumbering.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtNumbering.Size = new System.Drawing.Size(250, 22);
            this.txtNumbering.TabIndex = 0;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.labelControl2.Location = new System.Drawing.Point(64, 171);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(66, 16);
            this.labelControl2.TabIndex = 79;
            this.labelControl2.Text = "Numbering";
            // 
            // frmRenter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 402);
            this.Controls.Add(this.txtNumbering);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.textEditLicenseNo);
            this.Controls.Add(this.textEditExpiryDate);
            this.Controls.Add(this.labelControl15);
            this.Controls.Add(this.labelControl16);
            this.Controls.Add(this.textEditpob);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.textEditdob);
            this.Controls.Add(this.textEditIssueDate);
            this.Controls.Add(this.txtRenterName);
            this.Controls.Add(this.labelControl11);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.textEditPlaceOfIssue);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.txtTelephoneNumber);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.ribbon);
            this.Name = "frmRenter";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Renter";
            ((System.ComponentModel.ISupportInitialize)(this.textEditLicenseNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditdob.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditpob.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelephoneNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRenterName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditPlaceOfIssue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditIssueDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditExpiryDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumbering.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit textEditLicenseNo;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private DevExpress.XtraEditors.TextEdit textEditdob;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit textEditpob;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtTelephoneNumber;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtRenterName;
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
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit textEditPlaceOfIssue;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.TextEdit textEditIssueDate;
        private DevExpress.XtraEditors.LabelControl labelControl16;
        private DevExpress.XtraEditors.TextEdit textEditExpiryDate;
        private DevExpress.XtraEditors.TextEdit txtNumbering;
        private DevExpress.XtraEditors.LabelControl labelControl2;

    }
}