namespace LDWordProcessor
{
    partial class ReaderContrl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReaderContrl));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnPlay = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnStop = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnIncFont = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnDecFont = new DevExpress.XtraBars.BarLargeButtonItem();
            this.chkAutoClose = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.btnClose = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl2 = new DevExpress.XtraBars.BarDockControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.memoInput = new DevExpress.XtraEditors.MemoEdit();
            this.lbText = new DevExpress.XtraEditors.LabelControl();
            this.repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoInput.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.AllowCustomization = false;
            this.barManager1.AllowItemAnimatedHighlighting = false;
            this.barManager1.AllowMoveBarOnToolbar = false;
            this.barManager1.AllowQuickCustomization = false;
            this.barManager1.AllowShowToolbarsPopup = false;
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControl1);
            this.barManager1.DockControls.Add(this.barDockControl2);
            this.barManager1.Form = this.panelControl1;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnPlay,
            this.btnStop,
            this.btnClose,
            this.btnIncFont,
            this.btnDecFont,
            this.chkAutoClose});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 10;
            this.barManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1,
            this.repositoryItemPictureEdit1});
            // 
            // bar2
            // 
            this.bar2.BarItemHorzIndent = 15;
            this.bar2.BarName = "Main Menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.FloatLocation = new System.Drawing.Point(591, 142);
            this.bar2.FloatSize = new System.Drawing.Size(700, 200);
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnPlay, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnStop),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnIncFont, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnDecFont),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.chkAutoClose, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.Caption),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnClose, true)});
            this.bar2.OptionsBar.DisableClose = true;
            this.bar2.OptionsBar.DisableCustomization = true;
            this.bar2.OptionsBar.DrawDragBorder = false;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnPlay
            // 
            this.btnPlay.Caption = "อ่าน";
            this.btnPlay.Glyph = ((System.Drawing.Image)(resources.GetObject("btnPlay.Glyph")));
            this.btnPlay.Id = 0;
            this.btnPlay.ItemAppearance.Normal.Font = new System.Drawing.Font("5011_thE_Little_Uki_noworry", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnPlay.ItemAppearance.Normal.Options.UseFont = true;
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPlay_ItemClick);
            // 
            // btnStop
            // 
            this.btnStop.Caption = "หยุด";
            this.btnStop.Glyph = ((System.Drawing.Image)(resources.GetObject("btnStop.Glyph")));
            this.btnStop.Id = 1;
            this.btnStop.ItemAppearance.Normal.Font = new System.Drawing.Font("5011_thE_Little_Uki_noworry", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnStop.ItemAppearance.Normal.Options.UseFont = true;
            this.btnStop.Name = "btnStop";
            this.btnStop.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnStop.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnStop_ItemClick);
            // 
            // btnIncFont
            // 
            this.btnIncFont.Caption = "เพิ่มขนาดตัวอักษร";
            this.btnIncFont.Glyph = ((System.Drawing.Image)(resources.GetObject("btnIncFont.Glyph")));
            this.btnIncFont.Id = 3;
            this.btnIncFont.ItemAppearance.Normal.Font = new System.Drawing.Font("5011_thE_Little_Uki_noworry", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnIncFont.ItemAppearance.Normal.Options.UseFont = true;
            this.btnIncFont.Name = "btnIncFont";
            this.btnIncFont.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnIncFont.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnIncFont_ItemClick);
            // 
            // btnDecFont
            // 
            this.btnDecFont.Caption = "ลดขนาดตัวอักษร";
            this.btnDecFont.Glyph = ((System.Drawing.Image)(resources.GetObject("btnDecFont.Glyph")));
            this.btnDecFont.Id = 4;
            this.btnDecFont.ItemAppearance.Normal.Font = new System.Drawing.Font("5011_thE_Little_Uki_noworry", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnDecFont.ItemAppearance.Normal.Options.UseFont = true;
            this.btnDecFont.Name = "btnDecFont";
            this.btnDecFont.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnDecFont.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDecFont_ItemClick);
            // 
            // chkAutoClose
            // 
            this.chkAutoClose.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.chkAutoClose.Edit = this.repositoryItemCheckEdit1;
            this.chkAutoClose.EditValue = true;
            this.chkAutoClose.Id = 8;
            this.chkAutoClose.ItemAppearance.Normal.Font = new System.Drawing.Font("5011_thE_Little_Uki_noworry", 15.75F, System.Drawing.FontStyle.Bold);
            this.chkAutoClose.ItemAppearance.Normal.Options.UseFont = true;
            this.chkAutoClose.Name = "chkAutoClose";
            this.chkAutoClose.Width = 124;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.repositoryItemCheckEdit1.Appearance.Font = new System.Drawing.Font("5011_thE_Little_Uki_noworry", 15.75F, System.Drawing.FontStyle.Bold);
            this.repositoryItemCheckEdit1.Appearance.Options.UseBackColor = true;
            this.repositoryItemCheckEdit1.Appearance.Options.UseFont = true;
            this.repositoryItemCheckEdit1.AutoWidth = true;
            this.repositoryItemCheckEdit1.Caption = "ปิดอัตโนมัติ";
            this.repositoryItemCheckEdit1.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            this.repositoryItemCheckEdit1.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            this.repositoryItemCheckEdit1.NullText = " ";
            // 
            // btnClose
            // 
            this.btnClose.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.btnClose.Caption = "ปิด";
            this.btnClose.Glyph = ((System.Drawing.Image)(resources.GetObject("btnClose.Glyph")));
            this.btnClose.Id = 2;
            this.btnClose.ItemAppearance.Normal.Font = new System.Drawing.Font("5011_thE_Little_Uki_noworry", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnClose.ItemAppearance.Normal.Options.UseFont = true;
            this.btnClose.Name = "btnClose";
            this.btnClose.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnClose.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnClose_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.barDockControlTop.Size = new System.Drawing.Size(1154, 70);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 186);
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.barDockControlBottom.Size = new System.Drawing.Size(1154, 0);
            // 
            // barDockControl1
            // 
            this.barDockControl1.CausesValidation = false;
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl1.Location = new System.Drawing.Point(0, 70);
            this.barDockControl1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.barDockControl1.Size = new System.Drawing.Size(0, 116);
            // 
            // barDockControl2
            // 
            this.barDockControl2.CausesValidation = false;
            this.barDockControl2.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl2.Location = new System.Drawing.Point(1154, 70);
            this.barDockControl2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.barDockControl2.Size = new System.Drawing.Size(0, 116);
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.Font = new System.Drawing.Font("5011_thE_Little_Uki_noworry", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelControl1.Appearance.Options.UseFont = true;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.memoInput);
            this.panelControl1.Controls.Add(this.lbText);
            this.panelControl1.Controls.Add(this.barDockControl1);
            this.panelControl1.Controls.Add(this.barDockControl2);
            this.panelControl1.Controls.Add(this.barDockControlBottom);
            this.panelControl1.Controls.Add(this.barDockControlTop);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(123, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1154, 186);
            this.panelControl1.TabIndex = 22;
            // 
            // memoInput
            // 
            this.memoInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.memoInput.EditValue = "สามัคคี  มีความรู้ คู่ปัญญา คงรักษาความเป็นไทย ใส่ใจเทคโนโลยี";
            this.memoInput.Location = new System.Drawing.Point(0, 70);
            this.memoInput.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.memoInput.MenuManager = this.barManager1;
            this.memoInput.Name = "memoInput";
            this.memoInput.Properties.Appearance.Font = new System.Drawing.Font("5011_thE_Little_Uki_noworry", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.memoInput.Properties.Appearance.Options.UseFont = true;
            this.memoInput.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.memoInput.Properties.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.memoInput.Size = new System.Drawing.Size(1154, 61);
            this.memoInput.TabIndex = 21;
            // 
            // lbText
            // 
            this.lbText.AllowHtmlString = true;
            this.lbText.Appearance.Font = new System.Drawing.Font("5011_thE_Little_Uki_noworry", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbText.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lbText.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.lbText.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.lbText.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbText.Location = new System.Drawing.Point(0, 131);
            this.lbText.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.lbText.Name = "lbText";
            this.lbText.Size = new System.Drawing.Size(1154, 55);
            this.lbText.TabIndex = 22;
            this.lbText.Text = "<color=\'red\'>สามัคคี</color> มีความรู้ คู่ปัญญา คงรักษาความเป็นไทย ใส่ใจเทคโนโลยี" +
                "";
            // 
            // repositoryItemPictureEdit1
            // 
            this.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1";
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlRight.Location = new System.Drawing.Point(2, 2);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 64);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(2, 2);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 0);
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(0, 0);
            this.pictureEdit1.MenuManager = this.barManager1;
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(123, 186);
            this.pictureEdit1.TabIndex = 21;
            // 
            // ReaderContrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.pictureEdit1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("5011_thE_Little_Uki_noworry", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "ReaderContrl";
            this.Size = new System.Drawing.Size(1277, 186);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.memoInput.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarLargeButtonItem btnPlay;
        private DevExpress.XtraBars.BarLargeButtonItem btnStop;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarLargeButtonItem btnClose;
        private DevExpress.XtraBars.BarLargeButtonItem btnIncFont;
        private DevExpress.XtraBars.BarLargeButtonItem btnDecFont;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private DevExpress.XtraBars.BarDockControl barDockControl2;
        private DevExpress.XtraBars.BarEditItem chkAutoClose;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        public DevExpress.XtraEditors.LabelControl lbText;
        private DevExpress.XtraEditors.MemoEdit memoInput;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
    }
}
