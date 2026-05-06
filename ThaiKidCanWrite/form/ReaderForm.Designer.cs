namespace LDWordProcessor.form
{
    partial class ReaderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReaderForm));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnPlay = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnStop = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnPrev = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnNext = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnFont1 = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnFont2 = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnFont3 = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnClose = new DevExpress.XtraBars.BarLargeButtonItem();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.tkSpeed = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemTrackBar1 = new DevExpress.XtraEditors.Repository.RepositoryItemTrackBar();
            this.tkVolume = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemTrackBar2 = new DevExpress.XtraEditors.Repository.RepositoryItemTrackBar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl2 = new DevExpress.XtraBars.BarDockControl();
            this.btnPause = new DevExpress.XtraBars.BarLargeButtonItem();
            this.LargeImages = new DevExpress.Utils.ImageCollection(this.components);
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.richEdit = new DevExpress.XtraRichEdit.RichEditControl();
            this.panelDisplayMain = new DevExpress.XtraEditors.PanelControl();
            this.panelDispCtrl = new DevExpress.XtraEditors.PanelControl();
            this.lbText = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.reader = new LDWordProcessor.ReaderComponent(this.components);
            this.barLargeButtonItem1 = new DevExpress.XtraBars.BarLargeButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTrackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTrackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LargeImages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelDisplayMain)).BeginInit();
            this.panelDisplayMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelDispCtrl)).BeginInit();
            this.panelDispCtrl.SuspendLayout();
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
            this.bar2,
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControl1);
            this.barManager1.DockControls.Add(this.barDockControl2);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnPlay,
            this.btnStop,
            this.btnClose,
            this.btnNext,
            this.btnPause,
            this.btnPrev,
            this.tkSpeed,
            this.tkVolume,
            this.btnFont1,
            this.btnFont2,
            this.btnFont3});
            this.barManager1.LargeImages = this.LargeImages;
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 22;
            this.barManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1,
            this.repositoryItemPictureEdit1,
            this.repositoryItemTrackBar1,
            this.repositoryItemTrackBar2});
            // 
            // bar2
            // 
            this.bar2.BarItemHorzIndent = 5;
            this.bar2.BarName = "Main Menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.FloatLocation = new System.Drawing.Point(591, 142);
            this.bar2.FloatSize = new System.Drawing.Size(700, 200);
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnPlay, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnStop),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnPrev, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnNext),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnFont1, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnFont2, DevExpress.XtraBars.BarItemPaintStyle.Standard),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnFont3),
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
            this.btnPlay.Id = 0;
            this.btnPlay.ImageOptions.LargeImageIndex = 0;
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPlay_ItemClick);
            // 
            // btnStop
            // 
            this.btnStop.Caption = "หยุด";
            this.btnStop.Id = 1;
            this.btnStop.ImageOptions.LargeImageIndex = 2;
            this.btnStop.Name = "btnStop";
            this.btnStop.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnStop.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnStop_ItemClick);
            // 
            // btnPrev
            // 
            this.btnPrev.Caption = "อ่านประโยคก่อนหน้า";
            this.btnPrev.Id = 14;
            this.btnPrev.ImageOptions.LargeImageIndex = 4;
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPrev_ItemClick);
            // 
            // btnNext
            // 
            this.btnNext.Caption = "อ่านประโยคถัดไป";
            this.btnNext.Id = 10;
            this.btnNext.ImageOptions.LargeImageIndex = 3;
            this.btnNext.Name = "btnNext";
            this.btnNext.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNext_ItemClick);
            // 
            // btnFont1
            // 
            this.btnFont1.Caption = "เล็ก";
            this.btnFont1.Id = 17;
            this.btnFont1.ImageOptions.LargeImageIndex = 6;
            this.btnFont1.Name = "btnFont1";
            this.btnFont1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnFont1_ItemClick);
            // 
            // btnFont2
            // 
            this.btnFont2.Caption = "กลาง";
            this.btnFont2.Id = 19;
            this.btnFont2.ImageOptions.LargeImageIndex = 7;
            this.btnFont2.Name = "btnFont2";
            this.btnFont2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnFont2_ItemClick);
            // 
            // btnFont3
            // 
            this.btnFont3.Caption = "ใหญ่";
            this.btnFont3.Id = 20;
            this.btnFont3.ImageOptions.LargeImageIndex = 8;
            this.btnFont3.Name = "btnFont3";
            this.btnFont3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnFont3_ItemClick);
            // 
            // btnClose
            // 
            this.btnClose.Caption = "ย้อนกลับ";
            this.btnClose.Id = 2;
            this.btnClose.ImageOptions.LargeImageIndex = 5;
            this.btnClose.Name = "btnClose";
            this.btnClose.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnClose.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnClose_ItemClick);
            // 
            // bar1
            // 
            this.bar1.BarName = "Custom 3";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.tkSpeed, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.tkVolume, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Custom 3";
            // 
            // tkSpeed
            // 
            this.tkSpeed.Caption = "ความเร็ว";
            this.tkSpeed.Edit = this.repositoryItemTrackBar1;
            this.tkSpeed.EditValue = 0;
            this.tkSpeed.EditWidth = 264;
            this.tkSpeed.Id = 15;
            this.tkSpeed.Name = "tkSpeed";
            this.tkSpeed.EditValueChanged += new System.EventHandler(this.tkSpeed_EditValueChanged);
            // 
            // repositoryItemTrackBar1
            // 
            this.repositoryItemTrackBar1.LabelAppearance.Options.UseTextOptions = true;
            this.repositoryItemTrackBar1.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.repositoryItemTrackBar1.Minimum = -10;
            this.repositoryItemTrackBar1.Name = "repositoryItemTrackBar1";
            this.repositoryItemTrackBar1.TickFrequency = 2;
            // 
            // tkVolume
            // 
            this.tkVolume.Caption = "ความดัง";
            this.tkVolume.Edit = this.repositoryItemTrackBar2;
            this.tkVolume.EditValue = ((short)(100));
            this.tkVolume.EditWidth = 278;
            this.tkVolume.Id = 16;
            this.tkVolume.Name = "tkVolume";
            this.tkVolume.EditValueChanged += new System.EventHandler(this.tkVolume_EditValueChanged);
            // 
            // repositoryItemTrackBar2
            // 
            this.repositoryItemTrackBar2.LabelAppearance.Options.UseTextOptions = true;
            this.repositoryItemTrackBar2.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.repositoryItemTrackBar2.Maximum = 100;
            this.repositoryItemTrackBar2.Name = "repositoryItemTrackBar2";
            this.repositoryItemTrackBar2.TickFrequency = 10;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(5, 5);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.barDockControlTop.Size = new System.Drawing.Size(690, 112);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(5, 463);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.barDockControlBottom.Size = new System.Drawing.Size(690, 0);
            // 
            // barDockControl1
            // 
            this.barDockControl1.CausesValidation = false;
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl1.Location = new System.Drawing.Point(5, 117);
            this.barDockControl1.Manager = this.barManager1;
            this.barDockControl1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.barDockControl1.Size = new System.Drawing.Size(0, 346);
            // 
            // barDockControl2
            // 
            this.barDockControl2.CausesValidation = false;
            this.barDockControl2.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl2.Location = new System.Drawing.Point(695, 117);
            this.barDockControl2.Manager = this.barManager1;
            this.barDockControl2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.barDockControl2.Size = new System.Drawing.Size(0, 346);
            // 
            // btnPause
            // 
            this.btnPause.Caption = "หยุดชั่วคราว";
            this.btnPause.Id = 13;
            this.btnPause.ImageOptions.LargeImageIndex = 1;
            this.btnPause.Name = "btnPause";
            this.btnPause.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPause_ItemClick);
            // 
            // LargeImages
            // 
            this.LargeImages.ImageSize = new System.Drawing.Size(48, 48);
            this.LargeImages.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("LargeImages.ImageStream")));
            this.LargeImages.Images.SetKeyName(0, "button_blue_play.png");
            this.LargeImages.Images.SetKeyName(1, "button_blue_pause.png");
            this.LargeImages.Images.SetKeyName(2, "button_blue_stop.png");
            this.LargeImages.Images.SetKeyName(3, "button_blue_last.png");
            this.LargeImages.Images.SetKeyName(4, "button_blue_first.png");
            this.LargeImages.Images.SetKeyName(5, "gnome_edit_undo.png");
            this.LargeImages.Images.SetKeyName(6, "text_resize_small.png");
            this.LargeImages.Images.SetKeyName(7, "text_resize_medium.png");
            this.LargeImages.Images.SetKeyName(8, "text_resize_large.png");
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.repositoryItemCheckEdit1.Appearance.Options.UseBackColor = true;
            this.repositoryItemCheckEdit1.AutoWidth = true;
            this.repositoryItemCheckEdit1.Caption = "ปิดอัตโนมัติ";
            this.repositoryItemCheckEdit1.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            this.repositoryItemCheckEdit1.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            this.repositoryItemCheckEdit1.NullText = " ";
            // 
            // repositoryItemPictureEdit1
            // 
            this.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1";
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelControl1.Appearance.Options.UseFont = true;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.richEdit);
            this.panelControl1.Controls.Add(this.panelDisplayMain);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(5, 117);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(690, 346);
            this.panelControl1.TabIndex = 26;
            // 
            // richEdit
            // 
            this.richEdit.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Simple;
            this.richEdit.Appearance.Text.Font = new System.Drawing.Font("Angsana New", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.richEdit.Appearance.Text.Options.UseFont = true;
            this.richEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richEdit.DocumentViewDirection = DevExpress.XtraRichEdit.DocumentViewDirection.LeftToRight;
            this.richEdit.LayoutUnit = DevExpress.XtraRichEdit.DocumentLayoutUnit.Pixel;
            this.richEdit.Location = new System.Drawing.Point(0, 0);
            this.richEdit.MenuManager = this.barManager1;
            this.richEdit.Name = "richEdit";
            this.richEdit.Options.HorizontalRuler.Visibility = DevExpress.XtraRichEdit.RichEditRulerVisibility.Hidden;
            this.richEdit.Options.HorizontalScrollbar.Visibility = DevExpress.XtraRichEdit.RichEditScrollbarVisibility.Hidden;
            this.richEdit.Options.VerticalRuler.Visibility = DevExpress.XtraRichEdit.RichEditRulerVisibility.Hidden;
            this.richEdit.Options.VerticalScrollbar.Visibility = DevExpress.XtraRichEdit.RichEditScrollbarVisibility.Hidden;
            this.richEdit.ReadOnly = true;
            this.richEdit.Size = new System.Drawing.Size(690, 170);
            this.richEdit.TabIndex = 28;
            // 
            // panelDisplayMain
            // 
            this.panelDisplayMain.Controls.Add(this.panelDispCtrl);
            this.panelDisplayMain.Controls.Add(this.pictureEdit1);
            this.panelDisplayMain.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelDisplayMain.Location = new System.Drawing.Point(0, 170);
            this.panelDisplayMain.Name = "panelDisplayMain";
            this.panelDisplayMain.Size = new System.Drawing.Size(690, 176);
            this.panelDisplayMain.TabIndex = 27;
            this.panelDisplayMain.Visible = false;
            // 
            // panelDispCtrl
            // 
            this.panelDispCtrl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelDispCtrl.Controls.Add(this.lbText);
            this.panelDispCtrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDispCtrl.Location = new System.Drawing.Point(125, 2);
            this.panelDispCtrl.Name = "panelDispCtrl";
            this.panelDispCtrl.Size = new System.Drawing.Size(563, 172);
            this.panelDispCtrl.TabIndex = 28;
            // 
            // lbText
            // 
            this.lbText.AllowHtmlString = true;
            this.lbText.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbText.Appearance.Options.UseFont = true;
            this.lbText.Appearance.Options.UseTextOptions = true;
            this.lbText.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lbText.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.lbText.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.lbText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbText.Location = new System.Drawing.Point(0, 0);
            this.lbText.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.lbText.Name = "lbText";
            this.lbText.Size = new System.Drawing.Size(563, 153);
            this.lbText.TabIndex = 28;
            this.lbText.Text = "<color=\'red\'>สามัคคี</color> มีความรู้ คู่ปัญญา คงรักษาความเป็นไทย ใส่ใจเทคโนโลยี" +
    "";
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(2, 2);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(123, 172);
            this.pictureEdit1.TabIndex = 26;
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlRight.Location = new System.Drawing.Point(5, 117);
            this.barDockControlRight.Manager = null;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 346);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(5, 117);
            this.barDockControlLeft.Manager = null;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 346);
            // 
            // reader
            // 
            this.reader.IsPlaying = false;
            this.reader.Speed = 0;
            this.reader.Text = null;
            this.reader.Volume = 100;
            this.reader.WordChanged += new LDWordProcessor.nectec.TTSWordChangeEventHandler(this.reader_WordChanged);
            this.reader.Stopped += new System.EventHandler(this.reader_Stopped);
            // 
            // barLargeButtonItem1
            // 
            this.barLargeButtonItem1.Caption = "ย้อนกลับ";
            this.barLargeButtonItem1.Id = 2;
            this.barLargeButtonItem1.ImageOptions.LargeImageIndex = 5;
            this.barLargeButtonItem1.Name = "barLargeButtonItem1";
            this.barLargeButtonItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // ReaderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 468);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControl1);
            this.Controls.Add(this.barDockControl2);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReaderForm";
            this.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThaiWordProcessor";
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTrackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTrackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LargeImages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelDisplayMain)).EndInit();
            this.panelDisplayMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelDispCtrl)).EndInit();
            this.panelDispCtrl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarLargeButtonItem btnPlay;
        private DevExpress.XtraBars.BarLargeButtonItem btnStop;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraBars.BarLargeButtonItem btnClose;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private DevExpress.XtraBars.BarDockControl barDockControl2;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelDisplayMain;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraEditors.PanelControl panelDispCtrl;
        public DevExpress.XtraEditors.LabelControl lbText;
        private DevExpress.XtraBars.BarLargeButtonItem btnNext;
        private DevExpress.XtraBars.BarLargeButtonItem btnPrev;
        private DevExpress.Utils.ImageCollection LargeImages;
        private DevExpress.XtraBars.BarLargeButtonItem btnPause;
        private DevExpress.XtraRichEdit.RichEditControl richEdit;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarEditItem tkSpeed;
        private DevExpress.XtraEditors.Repository.RepositoryItemTrackBar repositoryItemTrackBar1;
        private DevExpress.XtraBars.BarEditItem tkVolume;
        private DevExpress.XtraEditors.Repository.RepositoryItemTrackBar repositoryItemTrackBar2;
        private DevExpress.XtraBars.BarLargeButtonItem btnFont1;
        private DevExpress.XtraBars.BarLargeButtonItem barLargeButtonItem1;
        private DevExpress.XtraBars.BarLargeButtonItem btnFont2;
        private DevExpress.XtraBars.BarLargeButtonItem btnFont3;
        private ReaderComponent reader;

    }
}