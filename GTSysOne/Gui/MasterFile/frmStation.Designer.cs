namespace GTSysOne.Gui.MasterFile
{
    partial class frmStation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStation));
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
            this.rpStation = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpNew = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpSave = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpTools = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpSearch = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpClose = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.txtNumbering = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtname = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtShortname = new DevExpress.XtraEditors.TextEdit();
            this.lookUpEditlanguage = new DevExpress.XtraEditors.LookUpEdit();
            this.lookUpEditTheme = new DevExpress.XtraEditors.LookUpEdit();
            this.chkAllowEditLineTotal = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.chkActive = new DevExpress.XtraEditors.CheckEdit();
            this.chkShowfavoritesInNavigation = new DevExpress.XtraEditors.CheckEdit();
            this.chkAutoHideNavigation = new DevExpress.XtraEditors.CheckEdit();
            this.chkShowStats = new DevExpress.XtraEditors.CheckEdit();
            this.chkAutoHideStats = new DevExpress.XtraEditors.CheckEdit();
            this.chkShowFunctions = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumbering.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtShortname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditlanguage.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditTheme.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAllowEditLineTotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkActive.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkShowfavoritesInNavigation.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAutoHideNavigation.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkShowStats.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAutoHideStats.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkShowFunctions.Properties)).BeginInit();
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
            this.rpStation});
            this.ribbon.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemSearchControl1});
            this.ribbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbon.Size = new System.Drawing.Size(1003, 143);
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
            // rpStation
            // 
            this.rpStation.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpNew,
            this.rpSave,
            this.rpTools,
            this.rpSearch,
            this.rpClose});
            this.rpStation.Name = "rpStation";
            this.rpStation.Text = "Station";
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
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 412);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1003, 31);
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.labelControl9.Location = new System.Drawing.Point(45, 189);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(66, 16);
            this.labelControl9.TabIndex = 26;
            this.labelControl9.Text = "Numbering";
            // 
            // txtNumbering
            // 
            this.txtNumbering.Location = new System.Drawing.Point(153, 186);
            this.txtNumbering.MenuManager = this.ribbon;
            this.txtNumbering.Name = "txtNumbering";
            this.txtNumbering.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtNumbering.Properties.Appearance.Options.UseFont = true;
            this.txtNumbering.Properties.NullValuePrompt = "Numbering";
            this.txtNumbering.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtNumbering.Size = new System.Drawing.Size(352, 22);
            this.txtNumbering.TabIndex = 25;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.labelControl1.Location = new System.Drawing.Point(45, 218);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(37, 16);
            this.labelControl1.TabIndex = 30;
            this.labelControl1.Text = "Name";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(153, 214);
            this.txtname.MenuManager = this.ribbon;
            this.txtname.Name = "txtname";
            this.txtname.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtname.Properties.Appearance.Options.UseFont = true;
            this.txtname.Properties.NullValuePrompt = "Numbering";
            this.txtname.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtname.Size = new System.Drawing.Size(352, 22);
            this.txtname.TabIndex = 29;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.labelControl2.Location = new System.Drawing.Point(45, 245);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(65, 16);
            this.labelControl2.TabIndex = 32;
            this.labelControl2.Text = "Shortname";
            // 
            // txtShortname
            // 
            this.txtShortname.Location = new System.Drawing.Point(153, 242);
            this.txtShortname.MenuManager = this.ribbon;
            this.txtShortname.Name = "txtShortname";
            this.txtShortname.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtShortname.Properties.Appearance.Options.UseFont = true;
            this.txtShortname.Properties.MaxLength = 4;
            this.txtShortname.Properties.NullValuePrompt = "Numbering";
            this.txtShortname.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtShortname.Size = new System.Drawing.Size(352, 22);
            this.txtShortname.TabIndex = 31;
            // 
            // lookUpEditlanguage
            // 
            this.lookUpEditlanguage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lookUpEditlanguage.Location = new System.Drawing.Point(153, 271);
            this.lookUpEditlanguage.MenuManager = this.ribbon;
            this.lookUpEditlanguage.Name = "lookUpEditlanguage";
            this.lookUpEditlanguage.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lookUpEditlanguage.Properties.Appearance.Options.UseFont = true;
            this.lookUpEditlanguage.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditlanguage.Properties.DropDownRows = 20;
            this.lookUpEditlanguage.Properties.NullText = "";
            this.lookUpEditlanguage.Properties.NullValuePrompt = "Language";
            this.lookUpEditlanguage.Properties.NullValuePromptShowForEmptyValue = true;
            this.lookUpEditlanguage.Size = new System.Drawing.Size(352, 22);
            this.lookUpEditlanguage.TabIndex = 33;
            // 
            // lookUpEditTheme
            // 
            this.lookUpEditTheme.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lookUpEditTheme.Location = new System.Drawing.Point(153, 298);
            this.lookUpEditTheme.MenuManager = this.ribbon;
            this.lookUpEditTheme.Name = "lookUpEditTheme";
            this.lookUpEditTheme.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lookUpEditTheme.Properties.Appearance.Options.UseFont = true;
            this.lookUpEditTheme.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditTheme.Properties.NullText = "";
            this.lookUpEditTheme.Properties.NullValuePrompt = "Theme";
            this.lookUpEditTheme.Properties.NullValuePromptShowForEmptyValue = true;
            this.lookUpEditTheme.Size = new System.Drawing.Size(352, 22);
            this.lookUpEditTheme.TabIndex = 34;
            // 
            // chkAllowEditLineTotal
            // 
            this.chkAllowEditLineTotal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkAllowEditLineTotal.Location = new System.Drawing.Point(552, 213);
            this.chkAllowEditLineTotal.MenuManager = this.ribbon;
            this.chkAllowEditLineTotal.Name = "chkAllowEditLineTotal";
            this.chkAllowEditLineTotal.Properties.Caption = "Allow Edit Line Total";
            this.chkAllowEditLineTotal.Size = new System.Drawing.Size(283, 19);
            this.chkAllowEditLineTotal.TabIndex = 35;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.labelControl3.Location = new System.Drawing.Point(45, 274);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(61, 16);
            this.labelControl3.TabIndex = 36;
            this.labelControl3.Text = "Language";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.labelControl4.Location = new System.Drawing.Point(45, 302);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(43, 16);
            this.labelControl4.TabIndex = 37;
            this.labelControl4.Text = "Theme";
            // 
            // chkActive
            // 
            this.chkActive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkActive.Location = new System.Drawing.Point(552, 183);
            this.chkActive.MenuManager = this.ribbon;
            this.chkActive.Name = "chkActive";
            this.chkActive.Properties.Caption = "Active";
            this.chkActive.Size = new System.Drawing.Size(283, 19);
            this.chkActive.TabIndex = 40;
            // 
            // chkShowfavoritesInNavigation
            // 
            this.chkShowfavoritesInNavigation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkShowfavoritesInNavigation.Location = new System.Drawing.Point(552, 242);
            this.chkShowfavoritesInNavigation.MenuManager = this.ribbon;
            this.chkShowfavoritesInNavigation.Name = "chkShowfavoritesInNavigation";
            this.chkShowfavoritesInNavigation.Properties.Caption = "Show Favorites in Navigation Pane";
            this.chkShowfavoritesInNavigation.Size = new System.Drawing.Size(283, 19);
            this.chkShowfavoritesInNavigation.TabIndex = 43;
            // 
            // chkAutoHideNavigation
            // 
            this.chkAutoHideNavigation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkAutoHideNavigation.Location = new System.Drawing.Point(552, 270);
            this.chkAutoHideNavigation.MenuManager = this.ribbon;
            this.chkAutoHideNavigation.Name = "chkAutoHideNavigation";
            this.chkAutoHideNavigation.Properties.Caption = "Auto Hide Navigation Pane";
            this.chkAutoHideNavigation.Size = new System.Drawing.Size(283, 19);
            this.chkAutoHideNavigation.TabIndex = 44;
            // 
            // chkShowStats
            // 
            this.chkShowStats.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkShowStats.Location = new System.Drawing.Point(552, 296);
            this.chkShowStats.MenuManager = this.ribbon;
            this.chkShowStats.Name = "chkShowStats";
            this.chkShowStats.Properties.Caption = "Show Stats";
            this.chkShowStats.Size = new System.Drawing.Size(283, 19);
            this.chkShowStats.TabIndex = 45;
            // 
            // chkAutoHideStats
            // 
            this.chkAutoHideStats.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkAutoHideStats.Location = new System.Drawing.Point(552, 323);
            this.chkAutoHideStats.MenuManager = this.ribbon;
            this.chkAutoHideStats.Name = "chkAutoHideStats";
            this.chkAutoHideStats.Properties.Caption = "Auto Hide Stats";
            this.chkAutoHideStats.Size = new System.Drawing.Size(283, 19);
            this.chkAutoHideStats.TabIndex = 46;
            // 
            // chkShowFunctions
            // 
            this.chkShowFunctions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkShowFunctions.Location = new System.Drawing.Point(552, 348);
            this.chkShowFunctions.MenuManager = this.ribbon;
            this.chkShowFunctions.Name = "chkShowFunctions";
            this.chkShowFunctions.Properties.Caption = "Show Functions";
            this.chkShowFunctions.Size = new System.Drawing.Size(283, 19);
            this.chkShowFunctions.TabIndex = 47;
            // 
            // frmStation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 443);
            this.Controls.Add(this.chkShowFunctions);
            this.Controls.Add(this.chkAutoHideStats);
            this.Controls.Add(this.chkShowStats);
            this.Controls.Add(this.chkAutoHideNavigation);
            this.Controls.Add(this.chkShowfavoritesInNavigation);
            this.Controls.Add(this.chkActive);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.chkAllowEditLineTotal);
            this.Controls.Add(this.lookUpEditTheme);
            this.Controls.Add(this.lookUpEditlanguage);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtShortname);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.txtNumbering);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmStation";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Station";
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumbering.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtShortname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditlanguage.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditTheme.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAllowEditLineTotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkActive.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkShowfavoritesInNavigation.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAutoHideNavigation.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkShowStats.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAutoHideStats.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkShowFunctions.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpStation;
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
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.TextEdit txtNumbering;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtname;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtShortname;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditlanguage;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditTheme;
        private DevExpress.XtraEditors.CheckEdit chkAllowEditLineTotal;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.CheckEdit chkActive;
        private DevExpress.XtraEditors.CheckEdit chkShowfavoritesInNavigation;
        private DevExpress.XtraEditors.CheckEdit chkAutoHideNavigation;
        private DevExpress.XtraEditors.CheckEdit chkShowStats;
        private DevExpress.XtraEditors.CheckEdit chkAutoHideStats;
        private DevExpress.XtraEditors.CheckEdit chkShowFunctions;
    }
}