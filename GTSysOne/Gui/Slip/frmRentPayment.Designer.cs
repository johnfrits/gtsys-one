namespace GTSysOne.Gui.Slip
{
    partial class frmRentPayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRentPayment));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.repositoryItemSearchControl1 = new DevExpress.XtraEditors.Repository.RepositoryItemSearchControl();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnCCId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnPaymentMode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEditPaymentMode = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gridColumnCard = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEditCard = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridColumnAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEditAmount = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.gridColumndepositDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEditDepositDate = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.gridColumnlastnumeric = new DevExpress.XtraGrid.Columns.GridColumn();
            this.textEditGrandTotal = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.textEditTotalAmount = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.textEditAmountDue = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.textEditChange = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btnPost = new DevExpress.XtraEditors.SimpleButton();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnDeleteRow = new DevExpress.XtraEditors.SimpleButton();
            this.rpNumberingSetup = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditPaymentMode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEditAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDepositDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDepositDate.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditGrandTotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditTotalAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditAmountDue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditChange.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ApplicationIcon = ((System.Drawing.Bitmap)(resources.GetObject("ribbon.ApplicationIcon")));
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 13;
            this.ribbon.Name = "ribbon";
            this.ribbon.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemSearchControl1});
            this.ribbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbon.Size = new System.Drawing.Size(1015, 49);
            this.ribbon.StatusBar = this.ribbonStatusBar;
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
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 482);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1015, 31);
            // 
            // gridControl
            // 
            this.gridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl.Location = new System.Drawing.Point(18, 146);
            this.gridControl.MainView = this.gridView;
            this.gridControl.Name = "gridControl";
            this.gridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEditAmount,
            this.repositoryItemDateEditDepositDate,
            this.repositoryItemButtonEditCard,
            this.repositoryItemLookUpEditPaymentMode});
            this.gridControl.Size = new System.Drawing.Size(980, 243);
            this.gridControl.TabIndex = 57;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnid,
            this.gridColumnCCId,
            this.gridColumnPaymentMode,
            this.gridColumnCard,
            this.gridColumnAmount,
            this.gridColumndepositDate});
            this.gridView.GridControl = this.gridControl;
            this.gridView.Name = "gridView";
            this.gridView.OptionsView.ColumnAutoWidth = false;
            this.gridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView.OptionsView.ShowGroupPanel = false;
            this.gridView.ShowingEditor += new System.ComponentModel.CancelEventHandler(this.gridView_ShowingEditor);
            this.gridView.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gridView_InitNewRow);
            this.gridView.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView_CellValueChanged);
            this.gridView.RowCountChanged += new System.EventHandler(this.gridView_RowCountChanged);
            // 
            // gridColumnid
            // 
            this.gridColumnid.Caption = "Id";
            this.gridColumnid.FieldName = "id";
            this.gridColumnid.Name = "gridColumnid";
            // 
            // gridColumnCCId
            // 
            this.gridColumnCCId.Caption = "CCId";
            this.gridColumnCCId.FieldName = "CCId";
            this.gridColumnCCId.Name = "gridColumnCCId";
            // 
            // gridColumnPaymentMode
            // 
            this.gridColumnPaymentMode.Caption = "Payment Mode";
            this.gridColumnPaymentMode.ColumnEdit = this.repositoryItemLookUpEditPaymentMode;
            this.gridColumnPaymentMode.FieldName = "PaymentMode";
            this.gridColumnPaymentMode.Name = "gridColumnPaymentMode";
            this.gridColumnPaymentMode.Visible = true;
            this.gridColumnPaymentMode.VisibleIndex = 0;
            this.gridColumnPaymentMode.Width = 236;
            // 
            // repositoryItemLookUpEditPaymentMode
            // 
            this.repositoryItemLookUpEditPaymentMode.AutoHeight = false;
            this.repositoryItemLookUpEditPaymentMode.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEditPaymentMode.Name = "repositoryItemLookUpEditPaymentMode";
            this.repositoryItemLookUpEditPaymentMode.NullText = "";
            // 
            // gridColumnCard
            // 
            this.gridColumnCard.Caption = "Card";
            this.gridColumnCard.ColumnEdit = this.repositoryItemButtonEditCard;
            this.gridColumnCard.FieldName = "Card Type";
            this.gridColumnCard.Name = "gridColumnCard";
            this.gridColumnCard.Visible = true;
            this.gridColumnCard.VisibleIndex = 2;
            this.gridColumnCard.Width = 243;
            // 
            // repositoryItemButtonEditCard
            // 
            this.repositoryItemButtonEditCard.AutoHeight = false;
            this.repositoryItemButtonEditCard.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("repositoryItemButtonEditCard.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("repositoryItemButtonEditCard.Buttons1"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", null, null, true)});
            this.repositoryItemButtonEditCard.Name = "repositoryItemButtonEditCard";
            this.repositoryItemButtonEditCard.ReadOnly = true;
            this.repositoryItemButtonEditCard.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repositoryItemButtonEditCreditCard_ButtonClick);
            // 
            // gridColumnAmount
            // 
            this.gridColumnAmount.Caption = "Amount";
            this.gridColumnAmount.ColumnEdit = this.repositoryItemTextEditAmount;
            this.gridColumnAmount.FieldName = "Amount";
            this.gridColumnAmount.Name = "gridColumnAmount";
            this.gridColumnAmount.Visible = true;
            this.gridColumnAmount.VisibleIndex = 1;
            this.gridColumnAmount.Width = 259;
            // 
            // repositoryItemTextEditAmount
            // 
            this.repositoryItemTextEditAmount.AutoHeight = false;
            this.repositoryItemTextEditAmount.Mask.EditMask = "n2";
            this.repositoryItemTextEditAmount.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.repositoryItemTextEditAmount.Mask.UseMaskAsDisplayFormat = true;
            this.repositoryItemTextEditAmount.Name = "repositoryItemTextEditAmount";
            this.repositoryItemTextEditAmount.NullText = "0.00";
            this.repositoryItemTextEditAmount.NullValuePromptShowForEmptyValue = true;
            // 
            // gridColumndepositDate
            // 
            this.gridColumndepositDate.Caption = "Deposit Date";
            this.gridColumndepositDate.ColumnEdit = this.repositoryItemDateEditDepositDate;
            this.gridColumndepositDate.FieldName = "DepositDate";
            this.gridColumndepositDate.Name = "gridColumndepositDate";
            this.gridColumndepositDate.Visible = true;
            this.gridColumndepositDate.VisibleIndex = 3;
            this.gridColumndepositDate.Width = 221;
            // 
            // repositoryItemDateEditDepositDate
            // 
            this.repositoryItemDateEditDepositDate.AutoHeight = false;
            this.repositoryItemDateEditDepositDate.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEditDepositDate.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEditDepositDate.Name = "repositoryItemDateEditDepositDate";
            this.repositoryItemDateEditDepositDate.ReadOnly = true;
            // 
            // gridColumnlastnumeric
            // 
            this.gridColumnlastnumeric.Name = "gridColumnlastnumeric";
            // 
            // textEditGrandTotal
            // 
            this.textEditGrandTotal.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textEditGrandTotal.EditValue = "0";
            this.textEditGrandTotal.Location = new System.Drawing.Point(18, 433);
            this.textEditGrandTotal.MenuManager = this.ribbon;
            this.textEditGrandTotal.Name = "textEditGrandTotal";
            this.textEditGrandTotal.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEditGrandTotal.Properties.Appearance.Options.UseFont = true;
            this.textEditGrandTotal.Properties.Mask.EditMask = "n2";
            this.textEditGrandTotal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.textEditGrandTotal.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.textEditGrandTotal.Properties.NullValuePrompt = "Grand Total";
            this.textEditGrandTotal.Properties.NullValuePromptShowForEmptyValue = true;
            this.textEditGrandTotal.Properties.ReadOnly = true;
            this.textEditGrandTotal.Size = new System.Drawing.Size(214, 30);
            this.textEditGrandTotal.TabIndex = 88;
            // 
            // labelControl9
            // 
            this.labelControl9.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.labelControl9.Location = new System.Drawing.Point(18, 411);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(71, 16);
            this.labelControl9.TabIndex = 87;
            this.labelControl9.Text = "Grand Total";
            // 
            // textEditTotalAmount
            // 
            this.textEditTotalAmount.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textEditTotalAmount.EditValue = "0";
            this.textEditTotalAmount.Location = new System.Drawing.Point(679, 431);
            this.textEditTotalAmount.MenuManager = this.ribbon;
            this.textEditTotalAmount.Name = "textEditTotalAmount";
            this.textEditTotalAmount.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEditTotalAmount.Properties.Appearance.Options.UseFont = true;
            this.textEditTotalAmount.Properties.Mask.EditMask = "n2";
            this.textEditTotalAmount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.textEditTotalAmount.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.textEditTotalAmount.Properties.NullValuePrompt = "Grand Total";
            this.textEditTotalAmount.Properties.NullValuePromptShowForEmptyValue = true;
            this.textEditTotalAmount.Properties.ReadOnly = true;
            this.textEditTotalAmount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textEditTotalAmount.Size = new System.Drawing.Size(215, 30);
            this.textEditTotalAmount.TabIndex = 90;
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.labelControl1.Location = new System.Drawing.Point(679, 409);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(80, 16);
            this.labelControl1.TabIndex = 89;
            this.labelControl1.Text = "Total Amount";
            // 
            // textEditAmountDue
            // 
            this.textEditAmountDue.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textEditAmountDue.EditValue = "0.00";
            this.textEditAmountDue.Location = new System.Drawing.Point(238, 431);
            this.textEditAmountDue.MenuManager = this.ribbon;
            this.textEditAmountDue.Name = "textEditAmountDue";
            this.textEditAmountDue.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEditAmountDue.Properties.Appearance.Options.UseFont = true;
            this.textEditAmountDue.Properties.Mask.EditMask = "n2";
            this.textEditAmountDue.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.textEditAmountDue.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.textEditAmountDue.Properties.NullValuePrompt = "Grand Total";
            this.textEditAmountDue.Properties.NullValuePromptShowForEmptyValue = true;
            this.textEditAmountDue.Properties.ReadOnly = true;
            this.textEditAmountDue.Size = new System.Drawing.Size(214, 30);
            this.textEditAmountDue.TabIndex = 92;
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.labelControl2.Location = new System.Drawing.Point(238, 411);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(73, 16);
            this.labelControl2.TabIndex = 91;
            this.labelControl2.Text = "Amount Due";
            // 
            // textEditChange
            // 
            this.textEditChange.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textEditChange.EditValue = "0";
            this.textEditChange.Location = new System.Drawing.Point(458, 431);
            this.textEditChange.MenuManager = this.ribbon;
            this.textEditChange.Name = "textEditChange";
            this.textEditChange.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.textEditChange.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEditChange.Properties.Appearance.Options.UseBackColor = true;
            this.textEditChange.Properties.Appearance.Options.UseFont = true;
            this.textEditChange.Properties.Mask.EditMask = "n2";
            this.textEditChange.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.textEditChange.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.textEditChange.Properties.NullValuePrompt = "Grand Total";
            this.textEditChange.Properties.NullValuePromptShowForEmptyValue = true;
            this.textEditChange.Properties.ReadOnly = true;
            this.textEditChange.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textEditChange.Size = new System.Drawing.Size(214, 30);
            this.textEditChange.TabIndex = 94;
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(458, 411);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(47, 16);
            this.labelControl3.TabIndex = 93;
            this.labelControl3.Text = "Change";
            // 
            // btnPost
            // 
            this.btnPost.Image = ((System.Drawing.Image)(resources.GetObject("btnPost.Image")));
            this.btnPost.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnPost.Location = new System.Drawing.Point(18, 55);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(137, 73);
            this.btnPost.TabIndex = 95;
            this.btnPost.Text = "Post";
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnPrint.Location = new System.Drawing.Point(161, 55);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(137, 73);
            this.btnPrint.TabIndex = 96;
            this.btnPrint.Text = "Print | Post";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnClose.Location = new System.Drawing.Point(861, 55);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(137, 73);
            this.btnClose.TabIndex = 97;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDeleteRow
            // 
            this.btnDeleteRow.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteRow.Image")));
            this.btnDeleteRow.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnDeleteRow.Location = new System.Drawing.Point(304, 55);
            this.btnDeleteRow.Name = "btnDeleteRow";
            this.btnDeleteRow.Size = new System.Drawing.Size(137, 73);
            this.btnDeleteRow.TabIndex = 101;
            this.btnDeleteRow.Text = "Delete Row";
            this.btnDeleteRow.Click += new System.EventHandler(this.btnDeleteRow_Click);
            // 
            // rpNumberingSetup
            // 
            this.rpNumberingSetup.Name = "rpNumberingSetup";
            this.rpNumberingSetup.Text = "Payment";
            // 
            // frmRentPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 513);
            this.Controls.Add(this.btnDeleteRow);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnPost);
            this.Controls.Add(this.textEditChange);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.textEditAmountDue);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.textEditTotalAmount);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.textEditGrandTotal);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.gridControl);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmRentPayment";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Payment";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmRentPayment_FormClosing);
            this.Load += new System.EventHandler(this.frmRentPayment_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmRentPayment_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditPaymentMode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEditAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDepositDate.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDepositDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditGrandTotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditTotalAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditAmountDue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditChange.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchControl repositoryItemSearchControl1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnid;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnlastnumeric;
        private DevExpress.XtraEditors.TextEdit textEditGrandTotal;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.TextEdit textEditTotalAmount;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit textEditAmountDue;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit textEditChange;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnPaymentMode;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnAmount;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumndepositDate;
        private DevExpress.XtraEditors.SimpleButton btnPost;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEditAmount;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEditDepositDate;
        private DevExpress.XtraEditors.SimpleButton btnDeleteRow;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpNumberingSetup;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnCard;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEditCard;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEditPaymentMode;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnCCId;

    }
}