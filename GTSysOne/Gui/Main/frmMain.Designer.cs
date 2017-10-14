namespace GTSysOne.Gui.Main
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            DevExpress.XtraBars.Navigation.AccordionContextButton accordionContextButton1 = new DevExpress.XtraBars.Navigation.AccordionContextButton();
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.popupMenuGTS = new DevExpress.XtraBars.PopupMenu(this.components);
            this.btnLookUpLanguage = new DevExpress.XtraBars.BarEditItem();
            this.repoLanguage = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.btnLicense = new DevExpress.XtraBars.BarButtonItem();
            this.btnLogOut = new DevExpress.XtraBars.BarButtonItem();
            this.btnAbout = new DevExpress.XtraBars.BarButtonItem();
            this.btnExit = new DevExpress.XtraBars.BarButtonItem();
            this.btnServer = new DevExpress.XtraBars.BarButtonItem();
            this.btnDatabase = new DevExpress.XtraBars.BarButtonItem();
            this.btnMemory = new DevExpress.XtraBars.BarButtonItem();
            this.Theme = new DevExpress.XtraBars.SkinRibbonGalleryBarItem();
            this.btnNavigationPane = new DevExpress.XtraBars.BarButtonItem();
            this.popupMenuNavigation = new DevExpress.XtraBars.PopupMenu(this.components);
            this.btnShowFavInNavPane = new DevExpress.XtraBars.BarButtonItem();
            this.btnAutoHideNavPane = new DevExpress.XtraBars.BarButtonItem();
            this.btnStats = new DevExpress.XtraBars.BarButtonItem();
            this.btnAutoHideStats = new DevExpress.XtraBars.BarCheckItem();
            this.btnFunctions = new DevExpress.XtraBars.BarEditItem();
            this.repoFunctions = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.btnUser = new DevExpress.XtraBars.BarButtonItem();
            this.btnLicenseStatus = new DevExpress.XtraBars.BarButtonItem();
            this.btnEstablishment = new DevExpress.XtraBars.BarButtonItem();
            this.btnStation = new DevExpress.XtraBars.BarButtonItem();
            this.btnCompany = new DevExpress.XtraBars.BarButtonItem();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemSearchControl1 = new DevExpress.XtraEditors.Repository.RepositoryItemSearchControl();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.navBarControlModulator = new DevExpress.XtraNavBar.NavBarControl();
            this.splitMainContainerControl = new DevExpress.XtraEditors.SplitContainerControl();
            this.splitSubMainContainerControl = new DevExpress.XtraEditors.SplitContainerControl();
            this.xtraTabControlMain = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPageStart = new DevExpress.XtraTab.XtraTabPage();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.lblGTSysWebsiteLink = new System.Windows.Forms.LinkLabel();
            this.accordionControlStatus = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.imgFunctionIcon16 = new System.Windows.Forms.ImageList(this.components);
            this.imgFunctionIcon32 = new System.Windows.Forms.ImageList(this.components);
            this.imgFunctionIcon24 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuGTS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoLanguage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuNavigation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoFunctions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControlModulator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitMainContainerControl)).BeginInit();
            this.splitMainContainerControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitSubMainContainerControl)).BeginInit();
            this.splitSubMainContainerControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControlMain)).BeginInit();
            this.xtraTabControlMain.SuspendLayout();
            this.xtraTabPageStart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControlStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ApplicationButtonDropDownControl = this.popupMenuGTS;
            this.ribbon.ApplicationIcon = ((System.Drawing.Bitmap)(resources.GetObject("ribbon.ApplicationIcon")));
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.btnServer,
            this.btnDatabase,
            this.btnMemory,
            this.Theme,
            this.btnExit,
            this.btnLookUpLanguage,
            this.btnLogOut,
            this.btnLicense,
            this.btnAbout,
            this.btnNavigationPane,
            this.btnShowFavInNavPane,
            this.btnAutoHideNavPane,
            this.btnStats,
            this.btnAutoHideStats,
            this.btnFunctions,
            this.btnUser,
            this.btnLicenseStatus,
            this.btnEstablishment,
            this.btnStation,
            this.btnCompany});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 42;
            this.ribbon.Name = "ribbon";
            this.ribbon.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repoLanguage,
            this.repoFunctions,
            this.repositoryItemTextEdit1,
            this.repositoryItemSearchControl1});
            this.ribbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbon.ShowQatLocationSelector = false;
            this.ribbon.ShowToolbarCustomizeItem = false;
            this.ribbon.Size = new System.Drawing.Size(1225, 49);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            this.ribbon.Toolbar.ShowCustomizeItem = false;
            this.ribbon.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // popupMenuGTS
            // 
            this.popupMenuGTS.ItemLinks.Add(this.btnLookUpLanguage);
            this.popupMenuGTS.ItemLinks.Add(this.btnLicense);
            this.popupMenuGTS.ItemLinks.Add(this.btnLogOut);
            this.popupMenuGTS.ItemLinks.Add(this.btnAbout);
            this.popupMenuGTS.ItemLinks.Add(this.btnExit);
            this.popupMenuGTS.MinWidth = 300;
            this.popupMenuGTS.Name = "popupMenuGTS";
            this.popupMenuGTS.Ribbon = this.ribbon;
            this.popupMenuGTS.ShowCaption = true;
            // 
            // btnLookUpLanguage
            // 
            this.btnLookUpLanguage.Caption = "Language";
            this.btnLookUpLanguage.Edit = this.repoLanguage;
            this.btnLookUpLanguage.Glyph = ((System.Drawing.Image)(resources.GetObject("btnLookUpLanguage.Glyph")));
            this.btnLookUpLanguage.Id = 11;
            this.btnLookUpLanguage.IEBehavior = true;
            this.btnLookUpLanguage.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnLookUpLanguage.LargeGlyph")));
            this.btnLookUpLanguage.Name = "btnLookUpLanguage";
            // 
            // repoLanguage
            // 
            this.repoLanguage.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;
            this.repoLanguage.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repoLanguage.DropDownRows = 10;
            this.repoLanguage.Name = "repoLanguage";
            this.repoLanguage.NullText = "";
            this.repoLanguage.NullValuePrompt = "Language";
            this.repoLanguage.NullValuePromptShowForEmptyValue = true;
            this.repoLanguage.PopupFormMinSize = new System.Drawing.Size(200, 0);
            // 
            // btnLicense
            // 
            this.btnLicense.Caption = "License";
            this.btnLicense.Glyph = ((System.Drawing.Image)(resources.GetObject("btnLicense.Glyph")));
            this.btnLicense.Id = 13;
            this.btnLicense.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnLicense.LargeGlyph")));
            this.btnLicense.Name = "btnLicense";
            // 
            // btnLogOut
            // 
            this.btnLogOut.Caption = "Log Out";
            this.btnLogOut.Glyph = ((System.Drawing.Image)(resources.GetObject("btnLogOut.Glyph")));
            this.btnLogOut.Id = 12;
            this.btnLogOut.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnLogOut.LargeGlyph")));
            this.btnLogOut.Name = "btnLogOut";
            // 
            // btnAbout
            // 
            this.btnAbout.Caption = "About";
            this.btnAbout.Glyph = ((System.Drawing.Image)(resources.GetObject("btnAbout.Glyph")));
            this.btnAbout.Id = 14;
            this.btnAbout.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnAbout.LargeGlyph")));
            this.btnAbout.Name = "btnAbout";
            // 
            // btnExit
            // 
            this.btnExit.Caption = "Exit";
            this.btnExit.Glyph = ((System.Drawing.Image)(resources.GetObject("btnExit.Glyph")));
            this.btnExit.Id = 9;
            this.btnExit.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnExit.LargeGlyph")));
            this.btnExit.Name = "btnExit";
            // 
            // btnServer
            // 
            this.btnServer.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.btnServer.Id = 1;
            this.btnServer.Name = "btnServer";
            // 
            // btnDatabase
            // 
            this.btnDatabase.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.btnDatabase.Id = 2;
            this.btnDatabase.Name = "btnDatabase";
            // 
            // btnMemory
            // 
            this.btnMemory.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.btnMemory.Id = 3;
            this.btnMemory.Name = "btnMemory";
            // 
            // Theme
            // 
            this.Theme.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.Theme.Caption = "Theme";
            this.Theme.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.Theme.Id = 5;
            this.Theme.Name = "Theme";
            // 
            // btnNavigationPane
            // 
            this.btnNavigationPane.ActAsDropDown = true;
            this.btnNavigationPane.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.btnNavigationPane.AllowAllUp = true;
            this.btnNavigationPane.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.btnNavigationPane.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.btnNavigationPane.DropDownControl = this.popupMenuNavigation;
            this.btnNavigationPane.Glyph = ((System.Drawing.Image)(resources.GetObject("btnNavigationPane.Glyph")));
            this.btnNavigationPane.Id = 15;
            this.btnNavigationPane.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnNavigationPane.LargeGlyph")));
            this.btnNavigationPane.Name = "btnNavigationPane";
            this.btnNavigationPane.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionInMenu;
            // 
            // popupMenuNavigation
            // 
            this.popupMenuNavigation.ItemLinks.Add(this.btnShowFavInNavPane);
            this.popupMenuNavigation.ItemLinks.Add(this.btnAutoHideNavPane);
            this.popupMenuNavigation.ItemLinks.Add(this.btnStats);
            this.popupMenuNavigation.ItemLinks.Add(this.btnAutoHideStats);
            this.popupMenuNavigation.ItemLinks.Add(this.btnFunctions);
            this.popupMenuNavigation.Name = "popupMenuNavigation";
            this.popupMenuNavigation.Ribbon = this.ribbon;
            // 
            // btnShowFavInNavPane
            // 
            this.btnShowFavInNavPane.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check;
            this.btnShowFavInNavPane.Caption = "Show Favorites In Navigation Pane";
            this.btnShowFavInNavPane.Id = 16;
            this.btnShowFavInNavPane.Name = "btnShowFavInNavPane";
            // 
            // btnAutoHideNavPane
            // 
            this.btnAutoHideNavPane.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check;
            this.btnAutoHideNavPane.Caption = "Auto-Hide Navigation";
            this.btnAutoHideNavPane.Id = 18;
            this.btnAutoHideNavPane.Name = "btnAutoHideNavPane";
            // 
            // btnStats
            // 
            this.btnStats.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check;
            this.btnStats.Caption = "Stats";
            this.btnStats.Id = 19;
            this.btnStats.Name = "btnStats";
            // 
            // btnAutoHideStats
            // 
            this.btnAutoHideStats.Caption = "Auto-Hide Stats";
            this.btnAutoHideStats.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.btnAutoHideStats.Id = 25;
            this.btnAutoHideStats.Name = "btnAutoHideStats";
            // 
            // btnFunctions
            // 
            this.btnFunctions.Caption = "Functions";
            this.btnFunctions.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.btnFunctions.Edit = this.repoFunctions;
            this.btnFunctions.Id = 28;
            this.btnFunctions.Name = "btnFunctions";
            // 
            // repoFunctions
            // 
            this.repoFunctions.AutoHeight = false;
            this.repoFunctions.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;
            this.repoFunctions.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.DropDown)});
            this.repoFunctions.DropDownItemHeight = 30;
            this.repoFunctions.DropDownRows = 50;
            this.repoFunctions.Name = "repoFunctions";
            this.repoFunctions.NullText = "";
            this.repoFunctions.NullValuePrompt = "Functions";
            this.repoFunctions.NullValuePromptShowForEmptyValue = true;
            // 
            // btnUser
            // 
            this.btnUser.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.btnUser.Id = 32;
            this.btnUser.Name = "btnUser";
            // 
            // btnLicenseStatus
            // 
            this.btnLicenseStatus.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.btnLicenseStatus.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.btnLicenseStatus.Id = 38;
            this.btnLicenseStatus.Name = "btnLicenseStatus";
            // 
            // btnEstablishment
            // 
            this.btnEstablishment.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.btnEstablishment.Id = 39;
            this.btnEstablishment.Name = "btnEstablishment";
            // 
            // btnStation
            // 
            this.btnStation.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.btnStation.Id = 40;
            this.btnStation.Name = "btnStation";
            // 
            // btnCompany
            // 
            this.btnCompany.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.btnCompany.Id = 41;
            this.btnCompany.Name = "btnCompany";
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
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
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ItemLinks.Add(this.btnServer);
            this.ribbonStatusBar.ItemLinks.Add(this.btnDatabase);
            this.ribbonStatusBar.ItemLinks.Add(this.btnUser);
            this.ribbonStatusBar.ItemLinks.Add(this.btnMemory);
            this.ribbonStatusBar.ItemLinks.Add(this.btnCompany);
            this.ribbonStatusBar.ItemLinks.Add(this.btnEstablishment);
            this.ribbonStatusBar.ItemLinks.Add(this.btnStation);
            this.ribbonStatusBar.ItemLinks.Add(this.btnLicenseStatus);
            this.ribbonStatusBar.ItemLinks.Add(this.Theme);
            this.ribbonStatusBar.ItemLinks.Add(this.btnNavigationPane);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 661);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1225, 31);
            // 
            // navBarControlModulator
            // 
            this.navBarControlModulator.ActiveGroup = null;
            this.navBarControlModulator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navBarControlModulator.HotTrackedGroupCursor = System.Windows.Forms.Cursors.Hand;
            this.navBarControlModulator.LinkInterval = 1;
            this.navBarControlModulator.Location = new System.Drawing.Point(0, 0);
            this.navBarControlModulator.LookAndFeel.SkinName = "Foggy";
            this.navBarControlModulator.Name = "navBarControlModulator";
            this.navBarControlModulator.NavigationPaneGroupClientHeight = 80;
            this.navBarControlModulator.OptionsNavPane.ExpandedWidth = 193;
            this.navBarControlModulator.OptionsNavPane.ShowGroupImageInHeader = true;
            this.navBarControlModulator.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.NavigationPane;
            this.navBarControlModulator.ShowIcons = DevExpress.Utils.DefaultBoolean.True;
            this.navBarControlModulator.Size = new System.Drawing.Size(193, 608);
            this.navBarControlModulator.StoreDefaultPaintStyleName = true;
            this.navBarControlModulator.TabIndex = 5;
            // 
            // splitMainContainerControl
            // 
            this.splitMainContainerControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitMainContainerControl.Location = new System.Drawing.Point(0, 49);
            this.splitMainContainerControl.Name = "splitMainContainerControl";
            this.splitMainContainerControl.Panel1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            this.splitMainContainerControl.Panel1.Controls.Add(this.navBarControlModulator);
            this.splitMainContainerControl.Panel2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            this.splitMainContainerControl.Panel2.Controls.Add(this.splitSubMainContainerControl);
            this.splitMainContainerControl.Size = new System.Drawing.Size(1225, 612);
            this.splitMainContainerControl.SplitterPosition = 197;
            this.splitMainContainerControl.TabIndex = 8;
            // 
            // splitSubMainContainerControl
            // 
            this.splitSubMainContainerControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitSubMainContainerControl.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.Panel2;
            this.splitSubMainContainerControl.Location = new System.Drawing.Point(0, 0);
            this.splitSubMainContainerControl.Name = "splitSubMainContainerControl";
            this.splitSubMainContainerControl.Panel1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            this.splitSubMainContainerControl.Panel1.Controls.Add(this.xtraTabControlMain);
            this.splitSubMainContainerControl.Panel2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            this.splitSubMainContainerControl.Panel2.Controls.Add(this.accordionControlStatus);
            this.splitSubMainContainerControl.Size = new System.Drawing.Size(1019, 608);
            this.splitSubMainContainerControl.SplitterPosition = 175;
            this.splitSubMainContainerControl.TabIndex = 0;
            // 
            // xtraTabControlMain
            // 
            this.xtraTabControlMain.AllowDrop = true;
            this.xtraTabControlMain.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xtraTabControlMain.Appearance.Options.UseFont = true;
            this.xtraTabControlMain.AppearancePage.Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xtraTabControlMain.AppearancePage.Header.Options.UseFont = true;
            this.xtraTabControlMain.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InActiveTabPageHeader;
            this.xtraTabControlMain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.xtraTabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControlMain.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControlMain.Name = "xtraTabControlMain";
            this.xtraTabControlMain.SelectedTabPage = this.xtraTabPageStart;
            this.xtraTabControlMain.Size = new System.Drawing.Size(835, 604);
            this.xtraTabControlMain.TabIndex = 0;
            this.xtraTabControlMain.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPageStart});
            // 
            // xtraTabPageStart
            // 
            this.xtraTabPageStart.Controls.Add(this.labelControl13);
            this.xtraTabPageStart.Controls.Add(this.labelControl11);
            this.xtraTabPageStart.Controls.Add(this.lblGTSysWebsiteLink);
            this.xtraTabPageStart.Cursor = System.Windows.Forms.Cursors.Default;
            this.xtraTabPageStart.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPageStart.Image")));
            this.xtraTabPageStart.Name = "xtraTabPageStart";
            this.xtraTabPageStart.ShowCloseButton = DevExpress.Utils.DefaultBoolean.False;
            this.xtraTabPageStart.Size = new System.Drawing.Size(829, 573);
            this.xtraTabPageStart.Text = "Start Page";
            // 
            // labelControl13
            // 
            this.labelControl13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl13.Location = new System.Drawing.Point(758, 556);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(66, 13);
            this.labelControl13.TabIndex = 15;
            this.labelControl13.Text = "for more info.";
            // 
            // labelControl11
            // 
            this.labelControl11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl11.Location = new System.Drawing.Point(599, 556);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(56, 13);
            this.labelControl11.TabIndex = 14;
            this.labelControl11.Text = "Please Visit ";
            // 
            // lblGTSysWebsiteLink
            // 
            this.lblGTSysWebsiteLink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGTSysWebsiteLink.AutoSize = true;
            this.lblGTSysWebsiteLink.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lblGTSysWebsiteLink.Location = new System.Drawing.Point(657, 556);
            this.lblGTSysWebsiteLink.Name = "lblGTSysWebsiteLink";
            this.lblGTSysWebsiteLink.Size = new System.Drawing.Size(97, 13);
            this.lblGTSysWebsiteLink.TabIndex = 13;
            this.lblGTSysWebsiteLink.TabStop = true;
            this.lblGTSysWebsiteLink.Text = "www.gtsys.com.jo";
            // 
            // accordionControlStatus
            // 
            this.accordionControlStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.accordionControlStatus.DistanceBetweenRootGroups = 1;
            this.accordionControlStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            accordionContextButton1.AnimationType = DevExpress.Utils.ContextAnimationType.SequenceAnimation;
            accordionContextButton1.Id = new System.Guid("0cac4f37-576f-4e6a-90a7-97082caa34ee");
            accordionContextButton1.Name = "AccordionContextButton";
            this.accordionControlStatus.ItemContextButtons.Add(accordionContextButton1);
            this.accordionControlStatus.Location = new System.Drawing.Point(0, 0);
            this.accordionControlStatus.LookAndFeel.SkinName = "VS2010";
            this.accordionControlStatus.Name = "accordionControlStatus";
            this.accordionControlStatus.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Hidden;
            this.accordionControlStatus.Size = new System.Drawing.Size(171, 604);
            this.accordionControlStatus.TabIndex = 0;
            // 
            // imgFunctionIcon16
            // 
            this.imgFunctionIcon16.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgFunctionIcon16.ImageStream")));
            this.imgFunctionIcon16.TransparentColor = System.Drawing.Color.Transparent;
            this.imgFunctionIcon16.Images.SetKeyName(0, "Tab.png");
            this.imgFunctionIcon16.Images.SetKeyName(1, "Favorites.png");
            this.imgFunctionIcon16.Images.SetKeyName(2, "User.png");
            this.imgFunctionIcon16.Images.SetKeyName(3, "License.png");
            this.imgFunctionIcon16.Images.SetKeyName(4, "Company.png");
            this.imgFunctionIcon16.Images.SetKeyName(5, "AllocationPattern.png");
            this.imgFunctionIcon16.Images.SetKeyName(6, "NumberingSetup.png");
            this.imgFunctionIcon16.Images.SetKeyName(7, "Establishment.png");
            this.imgFunctionIcon16.Images.SetKeyName(8, "Module.png");
            this.imgFunctionIcon16.Images.SetKeyName(9, "Station.png");
            this.imgFunctionIcon16.Images.SetKeyName(10, "Registration.png");
            this.imgFunctionIcon16.Images.SetKeyName(11, "Group.png");
            this.imgFunctionIcon16.Images.SetKeyName(12, "Employee.png");
            this.imgFunctionIcon16.Images.SetKeyName(13, "Country.png");
            this.imgFunctionIcon16.Images.SetKeyName(14, "Commission Code.png");
            this.imgFunctionIcon16.Images.SetKeyName(15, "TaxArea.png");
            this.imgFunctionIcon16.Images.SetKeyName(16, "PriceLevel.png");
            this.imgFunctionIcon16.Images.SetKeyName(17, "Region.png");
            // 
            // imgFunctionIcon32
            // 
            this.imgFunctionIcon32.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgFunctionIcon32.ImageStream")));
            this.imgFunctionIcon32.TransparentColor = System.Drawing.Color.Transparent;
            this.imgFunctionIcon32.Images.SetKeyName(0, "New.png");
            this.imgFunctionIcon32.Images.SetKeyName(1, "Refresh.png");
            this.imgFunctionIcon32.Images.SetKeyName(2, "Edit.png");
            this.imgFunctionIcon32.Images.SetKeyName(3, "View.png");
            // 
            // imgFunctionIcon24
            // 
            this.imgFunctionIcon24.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgFunctionIcon24.ImageStream")));
            this.imgFunctionIcon24.TransparentColor = System.Drawing.Color.Transparent;
            this.imgFunctionIcon24.Images.SetKeyName(0, "1.png");
            this.imgFunctionIcon24.Images.SetKeyName(1, "2.png");
            this.imgFunctionIcon24.Images.SetKeyName(2, "3.png");
            this.imgFunctionIcon24.Images.SetKeyName(3, "4.png");
            this.imgFunctionIcon24.Images.SetKeyName(4, "5.png");
            this.imgFunctionIcon24.Images.SetKeyName(5, "6.png");
            this.imgFunctionIcon24.Images.SetKeyName(6, "7.png");
            this.imgFunctionIcon24.Images.SetKeyName(7, "8.png");
            this.imgFunctionIcon24.Images.SetKeyName(8, "9.png");
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 692);
            this.Controls.Add(this.splitMainContainerControl);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmMain";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuGTS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoLanguage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuNavigation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoFunctions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControlModulator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitMainContainerControl)).EndInit();
            this.splitMainContainerControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitSubMainContainerControl)).EndInit();
            this.splitSubMainContainerControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControlMain)).EndInit();
            this.xtraTabControlMain.ResumeLayout(false);
            this.xtraTabPageStart.ResumeLayout(false);
            this.xtraTabPageStart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControlStatus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraNavBar.NavBarControl navBarControlModulator;
        private DevExpress.XtraEditors.SplitContainerControl splitMainContainerControl;
        private DevExpress.XtraEditors.SplitContainerControl splitSubMainContainerControl;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControlStatus;
        private DevExpress.XtraBars.BarButtonItem btnServer;
        private DevExpress.XtraBars.BarButtonItem btnDatabase;
        private DevExpress.XtraBars.BarButtonItem btnMemory;
        private DevExpress.XtraBars.SkinRibbonGalleryBarItem Theme;
        private System.Windows.Forms.ImageList imgFunctionIcon16;
        private DevExpress.XtraBars.PopupMenu popupMenuGTS;
        private DevExpress.XtraBars.BarEditItem btnLookUpLanguage;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repoLanguage;
        private DevExpress.XtraBars.BarButtonItem btnLicense;
        private DevExpress.XtraBars.BarButtonItem btnLogOut;
        private DevExpress.XtraBars.BarButtonItem btnAbout;
        private DevExpress.XtraBars.BarButtonItem btnExit;
        private DevExpress.XtraBars.BarButtonItem btnNavigationPane;
        private DevExpress.XtraBars.PopupMenu popupMenuNavigation;
        private DevExpress.XtraBars.BarButtonItem btnShowFavInNavPane;
        private DevExpress.XtraBars.BarButtonItem btnAutoHideNavPane;
        private DevExpress.XtraBars.BarButtonItem btnStats;
        private DevExpress.XtraBars.BarCheckItem btnAutoHideStats;
        private DevExpress.XtraBars.BarEditItem btnFunctions;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repoFunctions;
        private DevExpress.XtraTab.XtraTabControl xtraTabControlMain;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageStart;
        private System.Windows.Forms.ImageList imgFunctionIcon32;
        private System.Windows.Forms.ImageList imgFunctionIcon24;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchControl repositoryItemSearchControl1;
        private DevExpress.XtraBars.BarButtonItem btnUser;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private System.Windows.Forms.LinkLabel lblGTSysWebsiteLink;
        private DevExpress.XtraBars.BarButtonItem btnLicenseStatus;
        private DevExpress.XtraBars.BarButtonItem btnEstablishment;
        private DevExpress.XtraBars.BarButtonItem btnStation;
        private DevExpress.XtraBars.BarButtonItem btnCompany;
    }
}