using System.Drawing;

namespace LDWordProcessor.form
{
    partial class KCW_MainForm
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

        int _ScreenWidth = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width;
        int _ScreenHeight = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height;
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::LDWordProcessor.SplashScreen1), true, true);
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipItem toolTipItem1 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip2 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipItem toolTipItem2 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip3 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipItem toolTipItem3 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip4 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipItem toolTipItem4 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip5 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipItem toolTipItem5 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip6 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem1 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem6 = new DevExpress.Utils.ToolTipItem();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KCW_MainForm));
            this.ribbonMainControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barBttMindmap = new DevExpress.XtraBars.BarButtonItem();
            this.barBttOutline = new DevExpress.XtraBars.BarButtonItem();
            this.barColorPicker = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemColorEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemColorEdit();
            this.barBttToggleWS = new DevExpress.XtraBars.BarButtonItem();
            this.barBttToggleWP = new DevExpress.XtraBars.BarButtonItem();
            this.barFont = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemComboBox2 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.barFontSize = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemComboBox3 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.barBttReading = new DevExpress.XtraBars.BarButtonItem();
            //this.barBttHelp = new DevExpress.XtraBars.BarButtonItem();
            this.tbVoiceSpeed = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemTrackBar1 = new DevExpress.XtraEditors.Repository.RepositoryItemTrackBar();
            this.barEditItem1 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemToggleSwitch1 = new DevExpress.XtraEditors.Repository.RepositoryItemToggleSwitch();
            this.barTgRead = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemToggleSwitch2 = new DevExpress.XtraEditors.Repository.RepositoryItemToggleSwitch();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonGroupLayout = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonGroupFormat = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonGroupFunction = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonGroupTool = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonGroupSetting = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.repositoryItemSpinEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.docPnMindmap = new DevExpress.XtraBars.Docking.DockPanel();
            this.controlContainer3 = new DevExpress.XtraBars.Docking.ControlContainer();
            this.wordSearchControler = new LDWordProcessor.WordSearchControler();
            this.pnImageShow1 = new System.Windows.Forms.Panel();
            this.btnSaveMindmap = new System.Windows.Forms.Button();
            this.docPnEditWord = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.autoCompleteControler = new LDWordProcessor.form.AutoCompleteControler();
            this.pnImageShow2 = new System.Windows.Forms.Panel();
            this.docPnOutline = new DevExpress.XtraBars.Docking.DockPanel();
            this.controlContainer1 = new DevExpress.XtraBars.Docking.ControlContainer();
            this.pnImageShow3 = new System.Windows.Forms.Panel();
            this.pnVerb = new System.Windows.Forms.Panel();
            this.tbVerbFilter = new System.Windows.Forms.TextBox();
            this.listVerb = new System.Windows.Forms.FlowLayoutPanel();
            this.lbVerb = new System.Windows.Forms.Label();
            this.btnSentOutline = new System.Windows.Forms.Button();
            this.btnSaveOutline = new System.Windows.Forms.Button();
            this.btnBackOutline = new System.Windows.Forms.Button();
            this.btnSaveEditWord = new DevExpress.XtraEditors.SimpleButton();
            this.btnBackEditWord = new DevExpress.XtraEditors.SimpleButton();
            this.pnMainMindmap = new System.Windows.Forms.Panel();
            this.pnMainMindmap4 = new System.Windows.Forms.Panel();
            this.m4_label_rp_9 = new System.Windows.Forms.Label();
            this.m4_label_rp_8 = new System.Windows.Forms.Label();
            this.m4_label_rp_12 = new System.Windows.Forms.Label();
            this.m4_label_rp_11 = new System.Windows.Forms.Label();
            this.m4_label_rp_7 = new System.Windows.Forms.Label();
            this.m4_label_rp_10 = new System.Windows.Forms.Label();
            this.m4_label_rp_6 = new System.Windows.Forms.Label();
            this.m4_label_rp_5 = new System.Windows.Forms.Label();
            this.m4_label_rp_4 = new System.Windows.Forms.Label();
            this.m4_label_rp_3 = new System.Windows.Forms.Label();
            this.m4_label_rp_2 = new System.Windows.Forms.Label();
            this.m4_label_rp_1 = new System.Windows.Forms.Label();
            this.m4_input_5 = new ZBobb.AlphaBlendTextBox();
            this.m4_input_4 = new ZBobb.AlphaBlendTextBox();
            this.m4_input_3 = new ZBobb.AlphaBlendTextBox();
            this.m4_input_2 = new ZBobb.AlphaBlendTextBox();
            this.m4_input_12 = new ZBobb.AlphaBlendTextBox();
            this.m4_input_9 = new ZBobb.AlphaBlendTextBox();
            this.m4_input_11 = new ZBobb.AlphaBlendTextBox();
            this.m4_input_8 = new ZBobb.AlphaBlendTextBox();
            this.m4_input_7 = new ZBobb.AlphaBlendTextBox();
            this.m4_input_10 = new ZBobb.AlphaBlendTextBox();
            this.m4_input_1 = new ZBobb.AlphaBlendTextBox();
            this.m4_input_6 = new ZBobb.AlphaBlendTextBox();
            this.m4_label_11 = new System.Windows.Forms.Label();
            this.m4_label_8 = new System.Windows.Forms.Label();
            this.m4_label_9 = new System.Windows.Forms.Label();
            this.m4_label_7 = new System.Windows.Forms.Label();
            this.m4_label_6 = new System.Windows.Forms.Label();
            this.m4_label_12 = new System.Windows.Forms.Label();
            this.m4_label_10 = new System.Windows.Forms.Label();
            this.m4_label_5 = new System.Windows.Forms.Label();
            this.m4_label_4 = new System.Windows.Forms.Label();
            this.m4_label_3 = new System.Windows.Forms.Label();
            this.m4_label_2 = new System.Windows.Forms.Label();
            this.m4_label_1 = new System.Windows.Forms.Label();
            this.m4_btn_1 = new DevExpress.XtraEditors.SimpleButton();
            this.m4_btn_2 = new DevExpress.XtraEditors.SimpleButton();
            this.m4_btn_3 = new DevExpress.XtraEditors.SimpleButton();
            this.m4_btn_4 = new DevExpress.XtraEditors.SimpleButton();
            this.m4_btn_5 = new DevExpress.XtraEditors.SimpleButton();
            this.m4_btn_6 = new DevExpress.XtraEditors.SimpleButton();
            this.m4_btn_7 = new DevExpress.XtraEditors.SimpleButton();
            this.m4_btn_8 = new DevExpress.XtraEditors.SimpleButton();
            this.m4_btn_9 = new DevExpress.XtraEditors.SimpleButton();
            this.m4_btn_10 = new DevExpress.XtraEditors.SimpleButton();
            this.m4_btn_11 = new DevExpress.XtraEditors.SimpleButton();
            this.m4_btn_12 = new DevExpress.XtraEditors.SimpleButton();
            this.map4_photo = new System.Windows.Forms.Panel();
            this.m4_input_title = new ZBobb.AlphaBlendTextBox();
            this.pnMainMindmap3 = new System.Windows.Forms.Panel();
            this.m3_label_rp_5 = new System.Windows.Forms.Label();
            this.m3_label_rp_4 = new System.Windows.Forms.Label();
            this.m3_label_rp_3 = new System.Windows.Forms.Label();
            this.m3_label_rp_12 = new System.Windows.Forms.Label();
            this.m3_label_rp_11 = new System.Windows.Forms.Label();
            this.m3_label_rp_9 = new System.Windows.Forms.Label();
            this.m3_label_rp_8 = new System.Windows.Forms.Label();
            this.m3_label_rp_7 = new System.Windows.Forms.Label();
            this.m3_label_rp_2 = new System.Windows.Forms.Label();
            this.m3_label_rp_10 = new System.Windows.Forms.Label();
            this.m3_label_rp_6 = new System.Windows.Forms.Label();
            this.m3_label_rp_1 = new System.Windows.Forms.Label();
            this.m3_input_5 = new ZBobb.AlphaBlendTextBox();
            this.m3_input_4 = new ZBobb.AlphaBlendTextBox();
            this.m3_input_3 = new ZBobb.AlphaBlendTextBox();
            this.m3_input_2 = new ZBobb.AlphaBlendTextBox();
            this.m3_input_12 = new ZBobb.AlphaBlendTextBox();
            this.m3_input_9 = new ZBobb.AlphaBlendTextBox();
            this.m3_input_11 = new ZBobb.AlphaBlendTextBox();
            this.m3_input_8 = new ZBobb.AlphaBlendTextBox();
            this.m3_input_7 = new ZBobb.AlphaBlendTextBox();
            this.m3_input_10 = new ZBobb.AlphaBlendTextBox();
            this.m3_input_1 = new ZBobb.AlphaBlendTextBox();
            this.m3_input_6 = new ZBobb.AlphaBlendTextBox();
            this.m3_label_11 = new System.Windows.Forms.Label();
            this.m3_label_8 = new System.Windows.Forms.Label();
            this.m3_label_9 = new System.Windows.Forms.Label();
            this.m3_label_7 = new System.Windows.Forms.Label();
            this.m3_label_6 = new System.Windows.Forms.Label();
            this.m3_label_12 = new System.Windows.Forms.Label();
            this.m3_label_10 = new System.Windows.Forms.Label();
            this.m3_label_5 = new System.Windows.Forms.Label();
            this.m3_label_4 = new System.Windows.Forms.Label();
            this.m3_label_3 = new System.Windows.Forms.Label();
            this.m3_label_2 = new System.Windows.Forms.Label();
            this.m3_label_1 = new System.Windows.Forms.Label();
            this.m3_btn_1 = new DevExpress.XtraEditors.SimpleButton();
            this.m3_btn_2 = new DevExpress.XtraEditors.SimpleButton();
            this.m3_btn_3 = new DevExpress.XtraEditors.SimpleButton();
            this.m3_btn_4 = new DevExpress.XtraEditors.SimpleButton();
            this.m3_btn_5 = new DevExpress.XtraEditors.SimpleButton();
            this.m3_btn_6 = new DevExpress.XtraEditors.SimpleButton();
            this.m3_btn_7 = new DevExpress.XtraEditors.SimpleButton();
            this.m3_btn_8 = new DevExpress.XtraEditors.SimpleButton();
            this.m3_btn_9 = new DevExpress.XtraEditors.SimpleButton();
            this.m3_btn_10 = new DevExpress.XtraEditors.SimpleButton();
            this.m3_btn_11 = new DevExpress.XtraEditors.SimpleButton();
            this.m3_btn_12 = new DevExpress.XtraEditors.SimpleButton();
            this.map3_photo = new System.Windows.Forms.Panel();
            this.m3_input_title = new ZBobb.AlphaBlendTextBox();
            this.pnMainMindmap2 = new System.Windows.Forms.Panel();
            this.m2_label_rp_12 = new System.Windows.Forms.Label();
            this.m2_label_rp_11 = new System.Windows.Forms.Label();
            this.m2_label_rp_10 = new System.Windows.Forms.Label();
            this.m2_label_rp_9 = new System.Windows.Forms.Label();
            this.m2_label_rp_8 = new System.Windows.Forms.Label();
            this.m2_label_rp_7 = new System.Windows.Forms.Label();
            this.m2_label_rp_6 = new System.Windows.Forms.Label();
            this.m2_label_rp_5 = new System.Windows.Forms.Label();
            this.m2_label_rp_4 = new System.Windows.Forms.Label();
            this.m2_label_rp_3 = new System.Windows.Forms.Label();
            this.m2_label_rp_2 = new System.Windows.Forms.Label();
            this.m2_label_rp_1 = new System.Windows.Forms.Label();
            this.m2_input_5 = new ZBobb.AlphaBlendTextBox();
            this.m2_input_4 = new ZBobb.AlphaBlendTextBox();
            this.m2_input_3 = new ZBobb.AlphaBlendTextBox();
            this.m2_input_2 = new ZBobb.AlphaBlendTextBox();
            this.m2_input_12 = new ZBobb.AlphaBlendTextBox();
            this.m2_input_9 = new ZBobb.AlphaBlendTextBox();
            this.m2_input_11 = new ZBobb.AlphaBlendTextBox();
            this.m2_input_8 = new ZBobb.AlphaBlendTextBox();
            this.m2_input_7 = new ZBobb.AlphaBlendTextBox();
            this.m2_input_10 = new ZBobb.AlphaBlendTextBox();
            this.m2_input_1 = new ZBobb.AlphaBlendTextBox();
            this.m2_input_6 = new ZBobb.AlphaBlendTextBox();
            this.m2_label_11 = new System.Windows.Forms.Label();
            this.m2_label_8 = new System.Windows.Forms.Label();
            this.m2_label_9 = new System.Windows.Forms.Label();
            this.m2_label_7 = new System.Windows.Forms.Label();
            this.m2_label_6 = new System.Windows.Forms.Label();
            this.m2_label_12 = new System.Windows.Forms.Label();
            this.m2_label_10 = new System.Windows.Forms.Label();
            this.m2_label_5 = new System.Windows.Forms.Label();
            this.m2_label_4 = new System.Windows.Forms.Label();
            this.m2_label_3 = new System.Windows.Forms.Label();
            this.m2_label_2 = new System.Windows.Forms.Label();
            this.m2_label_1 = new System.Windows.Forms.Label();
            this.m2_btn_1 = new DevExpress.XtraEditors.SimpleButton();
            this.m2_btn_2 = new DevExpress.XtraEditors.SimpleButton();
            this.m2_btn_3 = new DevExpress.XtraEditors.SimpleButton();
            this.m2_btn_4 = new DevExpress.XtraEditors.SimpleButton();
            this.m2_btn_5 = new DevExpress.XtraEditors.SimpleButton();
            this.m2_btn_6 = new DevExpress.XtraEditors.SimpleButton();
            this.m2_btn_7 = new DevExpress.XtraEditors.SimpleButton();
            this.m2_btn_8 = new DevExpress.XtraEditors.SimpleButton();
            this.m2_btn_9 = new DevExpress.XtraEditors.SimpleButton();
            this.m2_btn_10 = new DevExpress.XtraEditors.SimpleButton();
            this.m2_btn_11 = new DevExpress.XtraEditors.SimpleButton();
            this.m2_btn_12 = new DevExpress.XtraEditors.SimpleButton();
            this.map2_photo = new System.Windows.Forms.Panel();
            this.m2_input_title = new ZBobb.AlphaBlendTextBox();
            this.pnMainMindmap1 = new System.Windows.Forms.Panel();
            this.m1_input_5 = new ZBobb.AlphaBlendTextBox();
            this.m1_input_4 = new ZBobb.AlphaBlendTextBox();
            this.m1_input_3 = new ZBobb.AlphaBlendTextBox();
            this.m1_input_2 = new ZBobb.AlphaBlendTextBox();
            this.m1_input_12 = new ZBobb.AlphaBlendTextBox();
            this.m1_input_9 = new ZBobb.AlphaBlendTextBox();
            this.m1_input_11 = new ZBobb.AlphaBlendTextBox();
            this.m1_input_8 = new ZBobb.AlphaBlendTextBox();
            this.m1_input_7 = new ZBobb.AlphaBlendTextBox();
            this.m1_input_10 = new ZBobb.AlphaBlendTextBox();
            this.m1_input_1 = new ZBobb.AlphaBlendTextBox();
            this.m1_input_6 = new ZBobb.AlphaBlendTextBox();
            this.m1_label_11 = new System.Windows.Forms.Label();
            this.m1_label_8 = new System.Windows.Forms.Label();
            this.m1_label_9 = new System.Windows.Forms.Label();
            this.m1_label_7 = new System.Windows.Forms.Label();
            this.m1_label_6 = new System.Windows.Forms.Label();
            this.m1_label_12 = new System.Windows.Forms.Label();
            this.m1_label_10 = new System.Windows.Forms.Label();
            this.m1_label_5 = new System.Windows.Forms.Label();
            this.m1_label_4 = new System.Windows.Forms.Label();
            this.m1_label_3 = new System.Windows.Forms.Label();
            this.m1_label_2 = new System.Windows.Forms.Label();
            this.m1_label_rp_12 = new System.Windows.Forms.Label();
            this.m1_label_rp_11 = new System.Windows.Forms.Label();
            this.m1_label_rp_10 = new System.Windows.Forms.Label();
            this.m1_label_rp_9 = new System.Windows.Forms.Label();
            this.m1_label_rp_8 = new System.Windows.Forms.Label();
            this.m1_label_rp_7 = new System.Windows.Forms.Label();
            this.m1_label_rp_6 = new System.Windows.Forms.Label();
            this.m1_label_rp_5 = new System.Windows.Forms.Label();
            this.m1_label_rp_4 = new System.Windows.Forms.Label();
            this.m1_label_rp_3 = new System.Windows.Forms.Label();
            this.m1_label_rp_2 = new System.Windows.Forms.Label();
            this.m1_label_rp_1 = new System.Windows.Forms.Label();
            this.m1_btn_1 = new DevExpress.XtraEditors.SimpleButton();
            this.m1_btn_2 = new DevExpress.XtraEditors.SimpleButton();
            this.m1_btn_3 = new DevExpress.XtraEditors.SimpleButton();
            this.m1_btn_4 = new DevExpress.XtraEditors.SimpleButton();
            this.m1_btn_5 = new DevExpress.XtraEditors.SimpleButton();
            this.m1_btn_6 = new DevExpress.XtraEditors.SimpleButton();
            this.m1_btn_7 = new DevExpress.XtraEditors.SimpleButton();
            this.m1_btn_8 = new DevExpress.XtraEditors.SimpleButton();
            this.m1_btn_9 = new DevExpress.XtraEditors.SimpleButton();
            this.m1_btn_10 = new DevExpress.XtraEditors.SimpleButton();
            this.m1_btn_11 = new DevExpress.XtraEditors.SimpleButton();
            this.m1_btn_12 = new DevExpress.XtraEditors.SimpleButton();
            this.m1_label_1 = new System.Windows.Forms.Label();
            this.map1_photo = new System.Windows.Forms.Panel();
            this.m1_input_title = new ZBobb.AlphaBlendTextBox();
            this.pnEditWord = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.richEdit1 = new DevExpress.XtraRichEdit.RichEditControl();
            this.pnImageEditWord = new System.Windows.Forms.Panel();
            this.pnOutline = new System.Windows.Forms.Panel();
            this.richEditReader = new DevExpress.XtraRichEdit.RichEditControl();
            this.panelReader = new System.Windows.Forms.Panel();
            this.tbOutlineTitle = new System.Windows.Forms.TextBox();
            this.listWord1 = new System.Windows.Forms.FlowLayoutPanel();
            this.listWord = new System.Windows.Forms.FlowLayoutPanel();
            this.pnMain = new System.Windows.Forms.Panel();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.PopupMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.timerReader = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonMainControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemColorEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTrackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemToggleSwitch1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemToggleSwitch2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            this.docPnMindmap.SuspendLayout();
            this.controlContainer3.SuspendLayout();
            this.docPnEditWord.SuspendLayout();
            this.dockPanel1_Container.SuspendLayout();
            this.docPnOutline.SuspendLayout();
            this.controlContainer1.SuspendLayout();
            this.pnVerb.SuspendLayout();
            this.pnMainMindmap.SuspendLayout();
            this.pnMainMindmap4.SuspendLayout();
            this.map4_photo.SuspendLayout();
            this.pnMainMindmap3.SuspendLayout();
            this.map3_photo.SuspendLayout();
            this.pnMainMindmap2.SuspendLayout();
            this.map2_photo.SuspendLayout();
            this.pnMainMindmap1.SuspendLayout();
            this.map1_photo.SuspendLayout();
            this.pnEditWord.SuspendLayout();
            this.pnOutline.SuspendLayout();
            this.pnMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonMainControl
            // 
            this.ribbonMainControl.ExpandCollapseItem.Id = 0;
            this.ribbonMainControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonMainControl.ExpandCollapseItem,
            this.ribbonMainControl.SearchEditItem,
            this.barBttMindmap,
            this.barBttOutline,
            this.barColorPicker,
            this.barBttToggleWS,
            this.barBttToggleWP,
            this.barFont,
            this.barFontSize,
            this.barBttReading,
            //this.barBttHelp,
            this.tbVoiceSpeed,
            this.barEditItem1,
            this.barTgRead});
            this.ribbonMainControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonMainControl.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.ribbonMainControl.MaxItemId = 53;
            this.ribbonMainControl.Name = "ribbonMainControl";
            //this.ribbonMainControl.PageHeaderItemLinks.Add(this.barBttHelp);
            this.ribbonMainControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonMainControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemSpinEdit1,
            this.repositoryItemColorEdit1,
            this.repositoryItemComboBox1,
            this.repositoryItemComboBox2,
            this.repositoryItemComboBox3,
            this.repositoryItemTrackBar1,
            this.repositoryItemToggleSwitch1,
            this.repositoryItemToggleSwitch2});
            this.ribbonMainControl.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.ShowOnMultiplePages;
            this.ribbonMainControl.ShowToolbarCustomizeItem = false;
            this.ribbonMainControl.Size = new System.Drawing.Size(1540, 145);
            this.ribbonMainControl.Toolbar.ShowCustomizeItem = false;
            this.ribbonMainControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            this.ribbonMainControl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ribbonMainControl_MouseMove);
            // 
            // barBttMindmap
            // 
            ////sasipong 24-05-2567 manu thai//
            //this.barBttMindmap.Caption = " MindMap ";
            this.barBttMindmap.Caption = " แม่แบบแผนที่ความคิด ";
            this.barBttMindmap.Id = 34;
            this.barBttMindmap.ImageOptions.LargeImage = global::LDWordProcessor.Properties.Resources.icon_mm_on;
            //this.barBttMindmap.LargeWidth = 65;
            this.barBttMindmap.LargeWidth = 120;
            this.barBttMindmap.Name = "barBttMindmap";
            this.barBttMindmap.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            //toolTipItem1.Text = "MindMap";
            toolTipItem1.Text = "แม่แบบแผนที่ความคิด";

            superToolTip1.Items.Add(toolTipItem1);
            this.barBttMindmap.SuperTip = superToolTip1;
            this.barBttMindmap.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barBttOutline
            // 
            //this.barBttOutline.Caption = "Outline";
            this.barBttOutline.Caption = "เรียบเรียงประโยค";
            this.barBttOutline.Id = 35;
            this.barBttOutline.ImageOptions.LargeImage = global::LDWordProcessor.Properties.Resources.icon_ol_on;
            //this.barBttOutline.LargeWidth = 65;
            this.barBttOutline.LargeWidth = 120;
            this.barBttOutline.Name = "barBttOutline";
            this.barBttOutline.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            //toolTipItem2.Text = "Outline";
            toolTipItem2.Text = "เรียบเรียงประโยค";

            superToolTip2.Items.Add(toolTipItem2);
            this.barBttOutline.SuperTip = superToolTip2;
            this.barBttOutline.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem4_ItemClick);
            // 
            // barColorPicker
            // 
            this.barColorPicker.Edit = this.repositoryItemColorEdit1;
            this.barColorPicker.Id = 39;
            this.barColorPicker.Name = "barColorPicker";
            this.barColorPicker.EditValueChanged += new System.EventHandler(this.colorPicker_EditValueChanged);
            // 
            // repositoryItemColorEdit1
            // 
            this.repositoryItemColorEdit1.AutoHeight = false;
            this.repositoryItemColorEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemColorEdit1.Name = "repositoryItemColorEdit1";
            // 
            // barBttToggleWS
            // 
            //this.barBttToggleWS.Caption = "Thai Word Search";
            this.barBttToggleWS.Caption = "ค้นหาศัพท์ไทย";
            this.barBttToggleWS.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.barBttToggleWS.Id = 40;
            this.barBttToggleWS.ImageOptions.LargeImage = global::LDWordProcessor.Properties.Resources.icon_ws_on;
            this.barBttToggleWS.LargeWidth = 100;
            this.barBttToggleWS.Name = "barBttToggleWS";
            this.barBttToggleWS.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            toolTipItem3.Text = "ค้นหาศัพท์ไทย";
            //toolTipItem3.Text = "Thai Word Search";
            superToolTip3.Items.Add(toolTipItem3);
            this.barBttToggleWS.SuperTip = superToolTip3;
            this.barBttToggleWS.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBttToggleWS_ItemClick);
            // 
            // barBttToggleWP
            // 
            //this.barBttToggleWP.Caption = "Thai Word Prediction";
            this.barBttToggleWP.Caption = "เลือกศัพท์ไทย";
            this.barBttToggleWP.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.barBttToggleWP.Id = 40;
            this.barBttToggleWP.ImageOptions.LargeImage = global::LDWordProcessor.Properties.Resources.icon_ws_on;
            this.barBttToggleWP.LargeWidth = 100;
            this.barBttToggleWP.Name = "barBttToggleWP";
            this.barBttToggleWP.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            toolTipItem4.Text = "เลือกศัพท์ไทย";
            //toolTipItem4.Text = "Thai Word Prediction";
            superToolTip4.Items.Add(toolTipItem4);
            this.barBttToggleWP.SuperTip = superToolTip4;
            this.barBttToggleWP.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBttToggleWP_ItemClick);
            // 
            // barFont
            // 
            this.barFont.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.barFont.Edit = this.repositoryItemComboBox2;
            this.barFont.EditWidth = 120;
            this.barFont.Id = 47;
            this.barFont.Name = "barFont";
            this.barFont.VisibleWhenVertical = true;
            this.barFont.EditValueChanged += new System.EventHandler(this.barFont_EditValueChanged);
            // 
            // repositoryItemComboBox2
            // 
            this.repositoryItemComboBox2.AutoHeight = false;
            this.repositoryItemComboBox2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox2.Items.AddRange(new object[] {
            "Angsana New",
            "Cordia New",
            "Arial",
            "Browallia New",
            "Times New Roman"});
            this.repositoryItemComboBox2.Name = "repositoryItemComboBox2";
            // 
            // barFontSize
            // 
            this.barFontSize.Edit = this.repositoryItemComboBox3;
            this.barFontSize.Id = 48;
            this.barFontSize.Name = "barFontSize";
            this.barFontSize.EditValueChanged += new System.EventHandler(this.barFontSize_EditValueChanged);
            // 
            // repositoryItemComboBox3
            // 
            this.repositoryItemComboBox3.AutoHeight = false;
            this.repositoryItemComboBox3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox3.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16"});
            this.repositoryItemComboBox3.Name = "repositoryItemComboBox3";
            // 
            // barBttReading
            // 
            //this.barBttReading.Caption = "Read";
            this.barBttReading.Caption = "อ่านประโยค";
            this.barBttReading.Id = 49;
            this.barBttReading.ImageOptions.LargeImage = global::LDWordProcessor.Properties.Resources.icon_readall;
            this.barBttReading.LargeWidth = 65;
            this.barBttReading.Name = "barBttReading";
            this.barBttReading.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            toolTipItem5.Text = "อ่านประโยค";
            superToolTip5.Items.Add(toolTipItem5);
            this.barBttReading.SuperTip = superToolTip5;
            this.barBttReading.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBttReading_ItemClick);
            // 
            // barBttHelp
            // 
            //this.barBttHelp.Caption = "คู่มือ";
            //this.barBttHelp.Description = "แสดงคู่มือการใช้งานโปรแกรม";
            //this.barBttHelp.Hint = "แสดงคู่มือการใช้งานโปรแกรม";
            //this.barBttHelp.Id = 24;
            //this.barBttHelp.ImageOptions.Image = global::LDWordProcessor.Properties.Resources.icon_help;
            //this.barBttHelp.ImageOptions.ImageIndex = 8;
            //this.barBttHelp.ImageOptions.LargeImage = global::LDWordProcessor.Properties.Resources.icon_help;
            //this.barBttHelp.ImageOptions.LargeImageIndex = 8;
            //this.barBttHelp.LargeWidth = 30;
            //this.barBttHelp.Name = "barBttHelp";
            //this.barBttHelp.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            //this.barBttHelp.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBttHelp_ItemClick);
            // 
            // tbVoiceSpeed
            // 
            this.tbVoiceSpeed.Caption = "ความเร็ว";
            this.tbVoiceSpeed.Edit = this.repositoryItemTrackBar1;
            this.tbVoiceSpeed.EditValue = ((short)(0));
            this.tbVoiceSpeed.EditWidth = 200;
            this.tbVoiceSpeed.Id = 50;
            this.tbVoiceSpeed.Name = "tbVoiceSpeed";
            toolTipTitleItem1.Text = "ความเร็ว";
            toolTipItem6.LeftIndent = 6;
            toolTipItem6.Text = "ปรับค่าความเร็วในการอ่านออกเสียง";
            superToolTip6.Items.Add(toolTipTitleItem1);
            superToolTip6.Items.Add(toolTipItem6);
            this.tbVoiceSpeed.SuperTip = superToolTip6;
            this.tbVoiceSpeed.EditValueChanged += new System.EventHandler(this.tbVoiceSpeed_EditValueChanged);
            this.tbVoiceSpeed.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.tbVoiceSpeed_ItemClick);
            // 
            // repositoryItemTrackBar1
            // 
            this.repositoryItemTrackBar1.LabelAppearance.Options.UseTextOptions = true;
            this.repositoryItemTrackBar1.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.repositoryItemTrackBar1.Minimum = -10;
            this.repositoryItemTrackBar1.Name = "repositoryItemTrackBar1";
            this.repositoryItemTrackBar1.TickFrequency = 2;
            // 
            // barEditItem1
            // 
            this.barEditItem1.Caption = "barEditItem1";
            this.barEditItem1.Edit = this.repositoryItemToggleSwitch1;
            this.barEditItem1.Id = 51;
            this.barEditItem1.Name = "barEditItem1";
            // 
            // repositoryItemToggleSwitch1
            // 
            this.repositoryItemToggleSwitch1.AutoHeight = false;
            this.repositoryItemToggleSwitch1.Name = "repositoryItemToggleSwitch1";
            this.repositoryItemToggleSwitch1.OffText = "Off";
            this.repositoryItemToggleSwitch1.OnText = "On";
            // 
            // barTgRead
            // 
            this.barTgRead.Caption = "อ่านออกเสียงปุ่ม";
            this.barTgRead.Edit = this.repositoryItemToggleSwitch2;
            this.barTgRead.Id = 52;
            this.barTgRead.Name = "barTgRead";
            this.barTgRead.EditValueChanged += new System.EventHandler(this.barTgRead_EditValueChanged);
            // 
            // repositoryItemToggleSwitch2
            // 
            this.repositoryItemToggleSwitch2.AutoHeight = false;
            this.repositoryItemToggleSwitch2.Name = "repositoryItemToggleSwitch2";
            this.repositoryItemToggleSwitch2.OffText = "Off";
            this.repositoryItemToggleSwitch2.OnText = "On";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonGroupLayout,
            this.ribbonGroupFormat,
            this.ribbonGroupFunction,
            this.ribbonGroupTool,
            this.ribbonGroupSetting});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // ribbonGroupLayout
            // 
            this.ribbonGroupLayout.ItemLinks.Add(this.barBttMindmap);
            this.ribbonGroupLayout.ItemLinks.Add(this.barBttOutline);
            this.ribbonGroupLayout.Name = "ribbonGroupLayout";
            this.ribbonGroupLayout.ShowCaptionButton = false;
            this.ribbonGroupLayout.Text = "             Layout          ";
            // 
            // ribbonGroupFormat
            // 
            this.ribbonGroupFormat.ItemLinks.Add(this.barFont, true, "", "", true);
            this.ribbonGroupFormat.ItemLinks.Add(this.barFontSize);
            this.ribbonGroupFormat.ItemLinks.Add(this.barColorPicker, true, "", "", true);
            this.ribbonGroupFormat.Name = "ribbonGroupFormat";
            this.ribbonGroupFormat.ShowCaptionButton = false;
            this.ribbonGroupFormat.Text = "Format";
            // 
            // ribbonGroupFunction
            // 
            this.ribbonGroupFunction.AllowTextClipping = false;
            this.ribbonGroupFunction.ItemLinks.Add(this.barBttToggleWS);
            this.ribbonGroupFunction.ItemLinks.Add(this.barBttToggleWP);
            this.ribbonGroupFunction.Name = "ribbonGroupFunction";
            this.ribbonGroupFunction.ShowCaptionButton = false;
            this.ribbonGroupFunction.Text = "Function";
            // 
            // ribbonGroupTool
            // 
            this.ribbonGroupTool.AllowTextClipping = false;
            this.ribbonGroupTool.ItemLinks.Add(this.barBttReading);
            this.ribbonGroupTool.ItemLinks.Add(this.tbVoiceSpeed, true);
            this.ribbonGroupTool.Name = "ribbonGroupTool";
            this.ribbonGroupTool.ShowCaptionButton = false;
            this.ribbonGroupTool.Text = "Tools";
            // 
            // ribbonGroupSetting
            // 
            this.ribbonGroupSetting.ItemLinks.Add(this.barTgRead);
            this.ribbonGroupSetting.Name = "ribbonGroupSetting";
            this.ribbonGroupSetting.Text = "Setting";
            // 
            // repositoryItemSpinEdit1
            // 
            this.repositoryItemSpinEdit1.AutoHeight = false;
            this.repositoryItemSpinEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1";
            // 
            // repositoryItemComboBox1
            // 
            this.repositoryItemComboBox1.AutoHeight = false;
            this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            // 
            // dockManager1
            // 
            this.dockManager1.Form = this;
            this.dockManager1.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.docPnMindmap,
            this.docPnEditWord,
            this.docPnOutline});
            this.dockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl"});
            // 
            // docPnMindmap
            // 
            this.docPnMindmap.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.docPnMindmap.Appearance.Options.UseBackColor = true;
            this.docPnMindmap.Controls.Add(this.controlContainer3);
            this.docPnMindmap.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right;
            this.docPnMindmap.ID = new System.Guid("e365b8c6-799c-4d77-912a-ea8910138926");
            this.docPnMindmap.Location = new System.Drawing.Point(1240, 145);
            this.docPnMindmap.Margin = new System.Windows.Forms.Padding(4);
            this.docPnMindmap.Name = "docPnMindmap";
            this.docPnMindmap.Options.ShowAutoHideButton = false;
            this.docPnMindmap.Options.ShowCloseButton = false;
            this.docPnMindmap.Options.ShowMaximizeButton = false;
            this.docPnMindmap.OriginalSize = new System.Drawing.Size(300, 200);
            this.docPnMindmap.Size = new System.Drawing.Size(300, 693);
            this.docPnMindmap.Text = "ค้นหาศัพท์ไทย";
            // 
            // controlContainer3
            // 
            this.controlContainer3.Controls.Add(this.wordSearchControler);
            this.controlContainer3.Controls.Add(this.pnImageShow1);
            this.controlContainer3.Controls.Add(this.btnSaveMindmap);
            this.controlContainer3.Location = new System.Drawing.Point(7, 25);
            this.controlContainer3.Margin = new System.Windows.Forms.Padding(4);
            this.controlContainer3.Name = "controlContainer3";
            this.controlContainer3.Size = new System.Drawing.Size(288, 663);
            this.controlContainer3.TabIndex = 0;
            // 
            // wordSearchControler
            // 
            this.wordSearchControler.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wordSearchControler.AutoScroll = true;
            this.wordSearchControler.Location = new System.Drawing.Point(1, 4);
            this.wordSearchControler.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.wordSearchControler.Name = "wordSearchControler";
            this.wordSearchControler.Size = new System.Drawing.Size(292, 572);
            this.wordSearchControler.TabIndex = 4;
            this.wordSearchControler.TbInput = null;
            this.wordSearchControler.TrackPage = LDWordProcessor.Page.None;
            this.wordSearchControler.SelectWordSuggestEvent += new LDWordProcessor.SelectWordSuggestEventHandler(this.autoCompleteControler_SelectWordSuggestEvent);
            // 
            // pnImageShow1
            // 
            this.pnImageShow1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnImageShow1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnImageShow1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnImageShow1.Location = new System.Drawing.Point(1, 6);
            this.pnImageShow1.Margin = new System.Windows.Forms.Padding(4);
            this.pnImageShow1.Name = "pnImageShow1";
            this.pnImageShow1.Size = new System.Drawing.Size(310, 133);
            this.pnImageShow1.TabIndex = 0;
            // 
            // btnSaveMindmap
            // 
            this.btnSaveMindmap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveMindmap.Font = new System.Drawing.Font("Browallia New", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnSaveMindmap.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveMindmap.Location = new System.Drawing.Point(102, 318);
            this.btnSaveMindmap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSaveMindmap.Name = "btnSaveMindmap";
            this.btnSaveMindmap.Size = new System.Drawing.Size(113, 47);
            this.btnSaveMindmap.TabIndex = 10;
            this.btnSaveMindmap.Text = "ถัดไป";
            this.btnSaveMindmap.UseVisualStyleBackColor = true;
            this.btnSaveMindmap.Visible = false;
            // 
            // docPnEditWord
            // 
            this.docPnEditWord.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.docPnEditWord.Appearance.Options.UseBackColor = true;
            this.docPnEditWord.Controls.Add(this.dockPanel1_Container);
            this.docPnEditWord.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right;
            this.docPnEditWord.ID = new System.Guid("e681bf61-d013-4920-9bd6-f963fa74f62f");
            this.docPnEditWord.Location = new System.Drawing.Point(940, 145);
            this.docPnEditWord.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.docPnEditWord.Name = "docPnEditWord";
            this.docPnEditWord.Options.FloatOnDblClick = false;
            this.docPnEditWord.Options.ShowAutoHideButton = false;
            this.docPnEditWord.Options.ShowCloseButton = false;
            this.docPnEditWord.Options.ShowMaximizeButton = false;
            this.docPnEditWord.OriginalSize = new System.Drawing.Size(300, 200);
            this.docPnEditWord.Size = new System.Drawing.Size(300, 693);
            this.docPnEditWord.Text = "เลือกศัพท์ไทย";
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.autoCompleteControler);
            this.dockPanel1_Container.Controls.Add(this.pnImageShow2);
            this.dockPanel1_Container.Location = new System.Drawing.Point(7, 25);
            this.dockPanel1_Container.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(288, 663);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // autoCompleteControler
            // 
            this.autoCompleteControler.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.autoCompleteControler.AutoScroll = true;
            this.autoCompleteControler.Location = new System.Drawing.Point(-1, 4);
            this.autoCompleteControler.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.autoCompleteControler.Name = "autoCompleteControler";
            this.autoCompleteControler.NumOfComplete = 35;
            this.autoCompleteControler.NumOfPredict = 35;
            this.autoCompleteControler.RtSelect = null;
            this.autoCompleteControler.Size = new System.Drawing.Size(296, 572);
            this.autoCompleteControler.TabIndex = 12;
            this.autoCompleteControler.TbSelect = null;
            this.autoCompleteControler.SelectWordSuggestEvent += new LDWordProcessor.SelectWordSuggestEventHandler(this.autoCompleteControler_SelectWordSuggestEvent);
            this.autoCompleteControler.Load += new System.EventHandler(this.autoCompleteControler_Load);
            // 
            // pnImageShow2
            // 
            this.pnImageShow2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnImageShow2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnImageShow2.Location = new System.Drawing.Point(-1, 7);
            this.pnImageShow2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnImageShow2.Name = "pnImageShow2";
            this.pnImageShow2.Size = new System.Drawing.Size(310, 133);
            this.pnImageShow2.TabIndex = 0;
            // 
            // docPnOutline
            // 
            this.docPnOutline.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.docPnOutline.Appearance.Options.UseBackColor = true;
            this.docPnOutline.Controls.Add(this.controlContainer1);
            this.docPnOutline.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right;
            this.docPnOutline.ID = new System.Guid("6c9f3125-f141-44b0-affd-973313ef6838");
            this.docPnOutline.ImeMode = System.Windows.Forms.ImeMode.On;
            this.docPnOutline.Location = new System.Drawing.Point(640, 145);
            this.docPnOutline.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.docPnOutline.Name = "docPnOutline";
            this.docPnOutline.Options.FloatOnDblClick = false;
            this.docPnOutline.Options.ShowAutoHideButton = false;
            this.docPnOutline.Options.ShowCloseButton = false;
            this.docPnOutline.Options.ShowMaximizeButton = false;
            this.docPnOutline.OriginalSize = new System.Drawing.Size(300, 200);
            this.docPnOutline.Size = new System.Drawing.Size(300, 693);
            this.docPnOutline.Text = "คำเชื่อม";
            // 
            // controlContainer1
            // 
            this.controlContainer1.Controls.Add(this.pnImageShow3);
            this.controlContainer1.Controls.Add(this.pnVerb);
            this.controlContainer1.Controls.Add(this.btnSentOutline);
            this.controlContainer1.Controls.Add(this.btnSaveOutline);
            this.controlContainer1.Controls.Add(this.btnBackOutline);
            this.controlContainer1.Location = new System.Drawing.Point(7, 25);
            this.controlContainer1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.controlContainer1.Name = "controlContainer1";
            this.controlContainer1.Size = new System.Drawing.Size(288, 663);
            this.controlContainer1.TabIndex = 0;
            // 
            // pnImageShow3
            // 
            this.pnImageShow3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnImageShow3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnImageShow3.Location = new System.Drawing.Point(5, 6);
            this.pnImageShow3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnImageShow3.Name = "pnImageShow3";
            this.pnImageShow3.Size = new System.Drawing.Size(310, 133);
            this.pnImageShow3.TabIndex = 0;
            this.pnImageShow3.Visible = false;
            // 
            // pnVerb
            // 
            this.pnVerb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnVerb.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnVerb.Controls.Add(this.tbVerbFilter);
            this.pnVerb.Controls.Add(this.listVerb);
            this.pnVerb.Controls.Add(this.lbVerb);
            this.pnVerb.Location = new System.Drawing.Point(7, 6);
            this.pnVerb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnVerb.Name = "pnVerb";
            this.pnVerb.Size = new System.Drawing.Size(329, 517);
            this.pnVerb.TabIndex = 17;
            // 
            // tbVerbFilter
            // 
            this.tbVerbFilter.BackColor = System.Drawing.Color.Black;
            this.tbVerbFilter.Font = new System.Drawing.Font("Browallia New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tbVerbFilter.ForeColor = System.Drawing.Color.White;
            this.tbVerbFilter.Location = new System.Drawing.Point(1, 7);
            this.tbVerbFilter.Margin = new System.Windows.Forms.Padding(4);
            this.tbVerbFilter.Name = "tbVerbFilter";
            this.tbVerbFilter.Size = new System.Drawing.Size(278, 45);
            this.tbVerbFilter.TabIndex = 56;
            this.tbVerbFilter.TextChanged += new System.EventHandler(this.tbVerbFilter_TextChanged);
            // 
            // listVerb
            // 
            this.listVerb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listVerb.AutoScroll = true;
            this.listVerb.BackColor = System.Drawing.Color.White;
            this.listVerb.Location = new System.Drawing.Point(1, 54);
            this.listVerb.Margin = new System.Windows.Forms.Padding(4);
            this.listVerb.Name = "listVerb";
            this.listVerb.Size = new System.Drawing.Size(302, 457);
            this.listVerb.TabIndex = 1;
            this.listVerb.TabStop = true;
            // 
            // lbVerb
            // 
            this.lbVerb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbVerb.AutoSize = true;
            this.lbVerb.BackColor = System.Drawing.Color.Transparent;
            this.lbVerb.Font = new System.Drawing.Font("Browallia New", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVerb.ForeColor = System.Drawing.Color.DimGray;
            this.lbVerb.Location = new System.Drawing.Point(129, -20);
            this.lbVerb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbVerb.Name = "lbVerb";
            this.lbVerb.Size = new System.Drawing.Size(65, 30);
            this.lbVerb.TabIndex = 55;
            this.lbVerb.Text = "คำเชื่อม";
            // 
            // btnSentOutline
            // 
            this.btnSentOutline.BackColor = System.Drawing.Color.Transparent;
            this.btnSentOutline.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.btnSentOutline.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnSentOutline.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSentOutline.Font = new System.Drawing.Font("Browallia New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnSentOutline.Image = global::LDWordProcessor.Properties.Resources.icon_ol_sent;
            this.btnSentOutline.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSentOutline.Location = new System.Drawing.Point(36, 634);
            this.btnSentOutline.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSentOutline.Name = "btnSentOutline";
            this.btnSentOutline.Size = new System.Drawing.Size(259, 50);
            this.btnSentOutline.TabIndex = 4;
            this.btnSentOutline.Text = "ส่งงาน";
            this.btnSentOutline.UseVisualStyleBackColor = false;
            this.btnSentOutline.Visible = false;
            // 
            // btnSaveOutline
            // 
            this.btnSaveOutline.BackColor = System.Drawing.Color.Transparent;
            this.btnSaveOutline.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.btnSaveOutline.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnSaveOutline.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveOutline.Font = new System.Drawing.Font("Browallia New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnSaveOutline.Image = global::LDWordProcessor.Properties.Resources.icon_ol_doc;
            this.btnSaveOutline.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveOutline.Location = new System.Drawing.Point(36, 585);
            this.btnSaveOutline.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSaveOutline.Name = "btnSaveOutline";
            this.btnSaveOutline.Size = new System.Drawing.Size(259, 50);
            this.btnSaveOutline.TabIndex = 2;
            this.btnSaveOutline.Text = "แปลงลงเอกสาร";
            this.btnSaveOutline.UseVisualStyleBackColor = false;
            this.btnSaveOutline.Click += new System.EventHandler(this.bttSaveOutline_Click);
            this.btnSaveOutline.MouseHover += new System.EventHandler(this.btnSaveOutline_MouseHover);
            // 
            // btnBackOutline
            // 
            this.btnBackOutline.BackColor = System.Drawing.Color.Transparent;
            this.btnBackOutline.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.btnBackOutline.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnBackOutline.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackOutline.Font = new System.Drawing.Font("Browallia New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnBackOutline.Image = global::LDWordProcessor.Properties.Resources.icon_ol_back;
            this.btnBackOutline.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBackOutline.Location = new System.Drawing.Point(36, 683);
            this.btnBackOutline.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBackOutline.Name = "btnBackOutline";
            this.btnBackOutline.Size = new System.Drawing.Size(259, 50);
            this.btnBackOutline.TabIndex = 3;
            this.btnBackOutline.Text = "ย้อนกลับ";
            this.btnBackOutline.UseVisualStyleBackColor = false;
            this.btnBackOutline.Click += new System.EventHandler(this.bttBackOutline_Click);
            this.btnBackOutline.MouseHover += new System.EventHandler(this.btnBackOutline_MouseHover);
            // 
            // btnSaveEditWord
            // 
            this.btnSaveEditWord.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btnSaveEditWord.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.btnSaveEditWord.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.btnSaveEditWord.Appearance.Font = new System.Drawing.Font("Browallia New", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveEditWord.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnSaveEditWord.Appearance.Options.UseBackColor = true;
            this.btnSaveEditWord.Appearance.Options.UseBorderColor = true;
            this.btnSaveEditWord.Appearance.Options.UseFont = true;
            this.btnSaveEditWord.Appearance.Options.UseForeColor = true;
            this.btnSaveEditWord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSaveEditWord.ImageOptions.Image = global::LDWordProcessor.Properties.Resources.icon_edit_save;
            this.btnSaveEditWord.Location = new System.Drawing.Point(1067, 480);
            this.btnSaveEditWord.Margin = new System.Windows.Forms.Padding(5);
            this.btnSaveEditWord.Name = "btnSaveEditWord";
            this.btnSaveEditWord.Size = new System.Drawing.Size(151, 47);
            this.btnSaveEditWord.TabIndex = 20;
            this.btnSaveEditWord.Text = "บันทึก";
            this.btnSaveEditWord.Click += new System.EventHandler(this.btnSaveEditWord_Click);
            this.btnSaveEditWord.MouseHover += new System.EventHandler(this.btnSaveEditWord_MouseHover);
            // 
            // btnBackEditWord
            // 
            this.btnBackEditWord.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btnBackEditWord.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.btnBackEditWord.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.btnBackEditWord.Appearance.Font = new System.Drawing.Font("Browallia New", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackEditWord.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnBackEditWord.Appearance.Options.UseBackColor = true;
            this.btnBackEditWord.Appearance.Options.UseBorderColor = true;
            this.btnBackEditWord.Appearance.Options.UseFont = true;
            this.btnBackEditWord.Appearance.Options.UseForeColor = true;
            this.btnBackEditWord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBackEditWord.ImageOptions.Image = global::LDWordProcessor.Properties.Resources.icon_edit_cancel;
            this.btnBackEditWord.Location = new System.Drawing.Point(891, 480);
            this.btnBackEditWord.Margin = new System.Windows.Forms.Padding(5);
            this.btnBackEditWord.Name = "btnBackEditWord";
            this.btnBackEditWord.Size = new System.Drawing.Size(151, 47);
            this.btnBackEditWord.TabIndex = 10;
            this.btnBackEditWord.Text = "ยกเลิก";
            this.btnBackEditWord.Click += new System.EventHandler(this.btnBackEditWord_Click);
            this.btnBackEditWord.MouseHover += new System.EventHandler(this.btnBackEditWord_MouseHover);
            // 
            // pnMainMindmap
            // 
            this.pnMainMindmap.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnMainMindmap.BackColor = System.Drawing.Color.White;
            this.pnMainMindmap.Controls.Add(this.pnMainMindmap4);
            this.pnMainMindmap.Controls.Add(this.pnMainMindmap3);
            this.pnMainMindmap.Controls.Add(this.pnMainMindmap2);
            this.pnMainMindmap.Controls.Add(this.pnMainMindmap1);
            this.pnMainMindmap.Location = new System.Drawing.Point(-350, -7);
            this.pnMainMindmap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnMainMindmap.Name = "pnMainMindmap";
            this.pnMainMindmap.Size = new System.Drawing.Size(1320, 708);
            this.pnMainMindmap.TabIndex = 2;
            // 
            // pnMainMindmap4
            // 
            this.pnMainMindmap4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnMainMindmap4.BackColor = System.Drawing.Color.Gray;
            this.pnMainMindmap4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnMainMindmap4.BackgroundImage")));
            this.pnMainMindmap4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnMainMindmap4.Controls.Add(this.m4_label_rp_9);
            this.pnMainMindmap4.Controls.Add(this.m4_label_rp_8);
            this.pnMainMindmap4.Controls.Add(this.m4_label_rp_12);
            this.pnMainMindmap4.Controls.Add(this.m4_label_rp_11);
            this.pnMainMindmap4.Controls.Add(this.m4_label_rp_7);
            this.pnMainMindmap4.Controls.Add(this.m4_label_rp_10);
            this.pnMainMindmap4.Controls.Add(this.m4_label_rp_6);
            this.pnMainMindmap4.Controls.Add(this.m4_label_rp_5);
            this.pnMainMindmap4.Controls.Add(this.m4_label_rp_4);
            this.pnMainMindmap4.Controls.Add(this.m4_label_rp_3);
            this.pnMainMindmap4.Controls.Add(this.m4_label_rp_2);
            this.pnMainMindmap4.Controls.Add(this.m4_label_rp_1);
            this.pnMainMindmap4.Controls.Add(this.m4_input_5);
            this.pnMainMindmap4.Controls.Add(this.m4_input_4);
            this.pnMainMindmap4.Controls.Add(this.m4_input_3);
            this.pnMainMindmap4.Controls.Add(this.m4_input_2);
            this.pnMainMindmap4.Controls.Add(this.m4_input_12);
            this.pnMainMindmap4.Controls.Add(this.m4_input_9);
            this.pnMainMindmap4.Controls.Add(this.m4_input_11);
            this.pnMainMindmap4.Controls.Add(this.m4_input_8);
            this.pnMainMindmap4.Controls.Add(this.m4_input_7);
            this.pnMainMindmap4.Controls.Add(this.m4_input_10);
            this.pnMainMindmap4.Controls.Add(this.m4_input_1);
            this.pnMainMindmap4.Controls.Add(this.m4_input_6);
            this.pnMainMindmap4.Controls.Add(this.m4_label_11);
            this.pnMainMindmap4.Controls.Add(this.m4_label_8);
            this.pnMainMindmap4.Controls.Add(this.m4_label_9);
            this.pnMainMindmap4.Controls.Add(this.m4_label_7);
            this.pnMainMindmap4.Controls.Add(this.m4_label_6);
            this.pnMainMindmap4.Controls.Add(this.m4_label_12);
            this.pnMainMindmap4.Controls.Add(this.m4_label_10);
            this.pnMainMindmap4.Controls.Add(this.m4_label_5);
            this.pnMainMindmap4.Controls.Add(this.m4_label_4);
            this.pnMainMindmap4.Controls.Add(this.m4_label_3);
            this.pnMainMindmap4.Controls.Add(this.m4_label_2);
            this.pnMainMindmap4.Controls.Add(this.m4_label_1);
            this.pnMainMindmap4.Controls.Add(this.m4_btn_1);
            this.pnMainMindmap4.Controls.Add(this.m4_btn_2);
            this.pnMainMindmap4.Controls.Add(this.m4_btn_3);
            this.pnMainMindmap4.Controls.Add(this.m4_btn_4);
            this.pnMainMindmap4.Controls.Add(this.m4_btn_5);
            this.pnMainMindmap4.Controls.Add(this.m4_btn_6);
            this.pnMainMindmap4.Controls.Add(this.m4_btn_7);
            this.pnMainMindmap4.Controls.Add(this.m4_btn_8);
            this.pnMainMindmap4.Controls.Add(this.m4_btn_9);
            this.pnMainMindmap4.Controls.Add(this.m4_btn_10);
            this.pnMainMindmap4.Controls.Add(this.m4_btn_11);
            this.pnMainMindmap4.Controls.Add(this.m4_btn_12);
            this.pnMainMindmap4.Controls.Add(this.map4_photo);
            this.pnMainMindmap4.Location = new System.Drawing.Point(1, 1);
            this.pnMainMindmap4.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.pnMainMindmap4.Name = "pnMainMindmap4";
            this.pnMainMindmap4.Size = new System.Drawing.Size(1319, 700);
            this.pnMainMindmap4.TabIndex = 5;
            // 
            // m4_label_rp_9
            // 
            this.m4_label_rp_9.BackColor = System.Drawing.Color.Transparent;
            this.m4_label_rp_9.Font = new System.Drawing.Font("Browallia New", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m4_label_rp_9.ForeColor = System.Drawing.Color.Black;
            this.m4_label_rp_9.Location = new System.Drawing.Point(152, 500);
            this.m4_label_rp_9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.m4_label_rp_9.Name = "m4_label_rp_9";
            this.m4_label_rp_9.Size = new System.Drawing.Size(121, 33);
            this.m4_label_rp_9.TabIndex = 45;
            this.m4_label_rp_9.Text = "9";
            this.m4_label_rp_9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.m4_label_rp_9.UseCompatibleTextRendering = true;
            // 
            // m4_label_rp_8
            // 
            this.m4_label_rp_8.BackColor = System.Drawing.Color.Transparent;
            this.m4_label_rp_8.Font = new System.Drawing.Font("Browallia New", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m4_label_rp_8.ForeColor = System.Drawing.Color.Black;
            this.m4_label_rp_8.Location = new System.Drawing.Point(99, 341);
            this.m4_label_rp_8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.m4_label_rp_8.Name = "m4_label_rp_8";
            this.m4_label_rp_8.Size = new System.Drawing.Size(121, 33);
            this.m4_label_rp_8.TabIndex = 45;
            this.m4_label_rp_8.Text = "8";
            this.m4_label_rp_8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.m4_label_rp_8.UseCompatibleTextRendering = true;
            // 
            // m4_label_rp_12
            // 
            this.m4_label_rp_12.BackColor = System.Drawing.Color.Transparent;
            this.m4_label_rp_12.Font = new System.Drawing.Font("Browallia New", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m4_label_rp_12.ForeColor = System.Drawing.Color.Black;
            this.m4_label_rp_12.Location = new System.Drawing.Point(813, 79);
            this.m4_label_rp_12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.m4_label_rp_12.Name = "m4_label_rp_12";
            this.m4_label_rp_12.Size = new System.Drawing.Size(121, 33);
            this.m4_label_rp_12.TabIndex = 45;
            this.m4_label_rp_12.Text = "12";
            this.m4_label_rp_12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.m4_label_rp_12.UseCompatibleTextRendering = true;
            // 
            // m4_label_rp_11
            // 
            this.m4_label_rp_11.BackColor = System.Drawing.Color.Transparent;
            this.m4_label_rp_11.Font = new System.Drawing.Font("Browallia New", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m4_label_rp_11.ForeColor = System.Drawing.Color.Black;
            this.m4_label_rp_11.Location = new System.Drawing.Point(320, 75);
            this.m4_label_rp_11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.m4_label_rp_11.Name = "m4_label_rp_11";
            this.m4_label_rp_11.Size = new System.Drawing.Size(121, 33);
            this.m4_label_rp_11.TabIndex = 45;
            this.m4_label_rp_11.Text = "11";
            this.m4_label_rp_11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.m4_label_rp_11.UseCompatibleTextRendering = true;
            // 
            // m4_label_rp_7
            // 
            this.m4_label_rp_7.BackColor = System.Drawing.Color.Transparent;
            this.m4_label_rp_7.Font = new System.Drawing.Font("Browallia New", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m4_label_rp_7.ForeColor = System.Drawing.Color.Black;
            this.m4_label_rp_7.Location = new System.Drawing.Point(147, 193);
            this.m4_label_rp_7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.m4_label_rp_7.Name = "m4_label_rp_7";
            this.m4_label_rp_7.Size = new System.Drawing.Size(121, 33);
            this.m4_label_rp_7.TabIndex = 45;
            this.m4_label_rp_7.Text = "7";
            this.m4_label_rp_7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.m4_label_rp_7.UseCompatibleTextRendering = true;
            // 
            // m4_label_rp_10
            // 
            this.m4_label_rp_10.BackColor = System.Drawing.Color.Transparent;
            this.m4_label_rp_10.Font = new System.Drawing.Font("Browallia New", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m4_label_rp_10.ForeColor = System.Drawing.Color.Black;
            this.m4_label_rp_10.Location = new System.Drawing.Point(579, 100);
            this.m4_label_rp_10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.m4_label_rp_10.Name = "m4_label_rp_10";
            this.m4_label_rp_10.Size = new System.Drawing.Size(121, 33);
            this.m4_label_rp_10.TabIndex = 45;
            this.m4_label_rp_10.Text = "10";
            this.m4_label_rp_10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.m4_label_rp_10.UseCompatibleTextRendering = true;
            // 
            // m4_label_rp_6
            // 
            this.m4_label_rp_6.BackColor = System.Drawing.Color.Transparent;
            this.m4_label_rp_6.Font = new System.Drawing.Font("Browallia New", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m4_label_rp_6.ForeColor = System.Drawing.Color.Black;
            this.m4_label_rp_6.Location = new System.Drawing.Point(311, 330);
            this.m4_label_rp_6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.m4_label_rp_6.Name = "m4_label_rp_6";
            this.m4_label_rp_6.Size = new System.Drawing.Size(121, 33);
            this.m4_label_rp_6.TabIndex = 45;
            this.m4_label_rp_6.Text = "6";
            this.m4_label_rp_6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.m4_label_rp_6.UseCompatibleTextRendering = true;
            // 
            // m4_label_rp_5
            // 
            this.m4_label_rp_5.BackColor = System.Drawing.Color.Transparent;
            this.m4_label_rp_5.Font = new System.Drawing.Font("Browallia New", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m4_label_rp_5.ForeColor = System.Drawing.Color.Black;
            this.m4_label_rp_5.Location = new System.Drawing.Point(999, 527);
            this.m4_label_rp_5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.m4_label_rp_5.Name = "m4_label_rp_5";
            this.m4_label_rp_5.Size = new System.Drawing.Size(121, 33);
            this.m4_label_rp_5.TabIndex = 45;
            this.m4_label_rp_5.Text = "5";
            this.m4_label_rp_5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.m4_label_rp_5.UseCompatibleTextRendering = true;
            // 
            // m4_label_rp_4
            // 
            this.m4_label_rp_4.BackColor = System.Drawing.Color.Transparent;
            this.m4_label_rp_4.Font = new System.Drawing.Font("Browallia New", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m4_label_rp_4.ForeColor = System.Drawing.Color.Black;
            this.m4_label_rp_4.Location = new System.Drawing.Point(1049, 396);
            this.m4_label_rp_4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.m4_label_rp_4.Name = "m4_label_rp_4";
            this.m4_label_rp_4.Size = new System.Drawing.Size(121, 33);
            this.m4_label_rp_4.TabIndex = 45;
            this.m4_label_rp_4.Text = "4";
            this.m4_label_rp_4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.m4_label_rp_4.UseCompatibleTextRendering = true;
            // 
            // m4_label_rp_3
            // 
            this.m4_label_rp_3.BackColor = System.Drawing.Color.Transparent;
            this.m4_label_rp_3.Font = new System.Drawing.Font("Browallia New", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m4_label_rp_3.ForeColor = System.Drawing.Color.Black;
            this.m4_label_rp_3.Location = new System.Drawing.Point(1048, 276);
            this.m4_label_rp_3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.m4_label_rp_3.Name = "m4_label_rp_3";
            this.m4_label_rp_3.Size = new System.Drawing.Size(121, 33);
            this.m4_label_rp_3.TabIndex = 45;
            this.m4_label_rp_3.Text = "3";
            this.m4_label_rp_3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.m4_label_rp_3.UseCompatibleTextRendering = true;
            // 
            // m4_label_rp_2
            // 
            this.m4_label_rp_2.BackColor = System.Drawing.Color.Transparent;
            this.m4_label_rp_2.Font = new System.Drawing.Font("Browallia New", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m4_label_rp_2.ForeColor = System.Drawing.Color.Black;
            this.m4_label_rp_2.Location = new System.Drawing.Point(1009, 165);
            this.m4_label_rp_2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.m4_label_rp_2.Name = "m4_label_rp_2";
            this.m4_label_rp_2.Size = new System.Drawing.Size(121, 33);
            this.m4_label_rp_2.TabIndex = 45;
            this.m4_label_rp_2.Text = "2";
            this.m4_label_rp_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.m4_label_rp_2.UseCompatibleTextRendering = true;
            // 
            // m4_label_rp_1
            // 
            this.m4_label_rp_1.BackColor = System.Drawing.Color.Transparent;
            this.m4_label_rp_1.Font = new System.Drawing.Font("Browallia New", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m4_label_rp_1.ForeColor = System.Drawing.Color.Black;
            this.m4_label_rp_1.Location = new System.Drawing.Point(849, 329);
            this.m4_label_rp_1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.m4_label_rp_1.Name = "m4_label_rp_1";
            this.m4_label_rp_1.Size = new System.Drawing.Size(121, 47);
            this.m4_label_rp_1.TabIndex = 45;
            this.m4_label_rp_1.Text = "1";
            this.m4_label_rp_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.m4_label_rp_1.UseCompatibleTextRendering = true;
            // 
            // m4_input_5
            // 
            this.m4_input_5.BackAlpha = 0;
            this.m4_input_5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.m4_input_5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.m4_input_5.Font = new System.Drawing.Font("Browallia New", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.m4_input_5.ForeColor = System.Drawing.Color.Black;
            this.m4_input_5.Location = new System.Drawing.Point(996, 553);
            this.m4_input_5.Margin = new System.Windows.Forms.Padding(4);
            this.m4_input_5.Name = "m4_input_5";
            this.m4_input_5.Size = new System.Drawing.Size(127, 34);
            this.m4_input_5.TabIndex = 5;
            this.m4_input_5.Text = "5";
            this.m4_input_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.m4_input_5.WordWrap = false;
            this.m4_input_5.MouseCaptureChanged += new System.EventHandler(this.input_Click);
            // 
            // m4_input_4
            // 
            this.m4_input_4.BackAlpha = 0;
            this.m4_input_4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.m4_input_4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.m4_input_4.Font = new System.Drawing.Font("Browallia New", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.m4_input_4.ForeColor = System.Drawing.Color.Black;
            this.m4_input_4.Location = new System.Drawing.Point(1049, 423);
            this.m4_input_4.Margin = new System.Windows.Forms.Padding(4);
            this.m4_input_4.Name = "m4_input_4";
            this.m4_input_4.Size = new System.Drawing.Size(123, 34);
            this.m4_input_4.TabIndex = 4;
            this.m4_input_4.Text = "4";
            this.m4_input_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.m4_input_4.WordWrap = false;
            this.m4_input_4.MouseCaptureChanged += new System.EventHandler(this.input_Click);
            // 
            // m4_input_3
            // 
            this.m4_input_3.BackAlpha = 0;
            this.m4_input_3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.m4_input_3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.m4_input_3.Font = new System.Drawing.Font("Browallia New", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.m4_input_3.ForeColor = System.Drawing.Color.Black;
            this.m4_input_3.Location = new System.Drawing.Point(1047, 303);
            this.m4_input_3.Margin = new System.Windows.Forms.Padding(4);
            this.m4_input_3.Name = "m4_input_3";
            this.m4_input_3.Size = new System.Drawing.Size(127, 34);
            this.m4_input_3.TabIndex = 3;
            this.m4_input_3.Text = "3";
            this.m4_input_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.m4_input_3.WordWrap = false;
            this.m4_input_3.MouseCaptureChanged += new System.EventHandler(this.input_Click);
            // 
            // m4_input_2
            // 
            this.m4_input_2.BackAlpha = 0;
            this.m4_input_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.m4_input_2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.m4_input_2.Font = new System.Drawing.Font("Browallia New", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.m4_input_2.ForeColor = System.Drawing.Color.Black;
            this.m4_input_2.Location = new System.Drawing.Point(1009, 192);
            this.m4_input_2.Margin = new System.Windows.Forms.Padding(4);
            this.m4_input_2.Name = "m4_input_2";
            this.m4_input_2.Size = new System.Drawing.Size(127, 34);
            this.m4_input_2.TabIndex = 2;
            this.m4_input_2.Text = "2";
            this.m4_input_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.m4_input_2.WordWrap = false;
            this.m4_input_2.MouseCaptureChanged += new System.EventHandler(this.input_Click);
            // 
            // m4_input_12
            // 
            this.m4_input_12.BackAlpha = 0;
            this.m4_input_12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.m4_input_12.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.m4_input_12.Font = new System.Drawing.Font("Browallia New", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.m4_input_12.ForeColor = System.Drawing.Color.Black;
            this.m4_input_12.Location = new System.Drawing.Point(809, 107);
            this.m4_input_12.Margin = new System.Windows.Forms.Padding(4);
            this.m4_input_12.Name = "m4_input_12";
            this.m4_input_12.Size = new System.Drawing.Size(127, 34);
            this.m4_input_12.TabIndex = 12;
            this.m4_input_12.Text = "12";
            this.m4_input_12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.m4_input_12.WordWrap = false;
            this.m4_input_12.MouseCaptureChanged += new System.EventHandler(this.input_Click);
            // 
            // m4_input_9
            // 
            this.m4_input_9.BackAlpha = 0;
            this.m4_input_9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.m4_input_9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.m4_input_9.Font = new System.Drawing.Font("Browallia New", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.m4_input_9.ForeColor = System.Drawing.Color.Black;
            this.m4_input_9.Location = new System.Drawing.Point(151, 527);
            this.m4_input_9.Margin = new System.Windows.Forms.Padding(4);
            this.m4_input_9.Name = "m4_input_9";
            this.m4_input_9.Size = new System.Drawing.Size(127, 34);
            this.m4_input_9.TabIndex = 9;
            this.m4_input_9.Text = "9";
            this.m4_input_9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.m4_input_9.WordWrap = false;
            this.m4_input_9.MouseCaptureChanged += new System.EventHandler(this.input_Click);
            // 
            // m4_input_11
            // 
            this.m4_input_11.BackAlpha = 0;
            this.m4_input_11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.m4_input_11.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.m4_input_11.Font = new System.Drawing.Font("Browallia New", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.m4_input_11.ForeColor = System.Drawing.Color.Black;
            this.m4_input_11.Location = new System.Drawing.Point(317, 102);
            this.m4_input_11.Margin = new System.Windows.Forms.Padding(4);
            this.m4_input_11.Name = "m4_input_11";
            this.m4_input_11.Size = new System.Drawing.Size(127, 34);
            this.m4_input_11.TabIndex = 11;
            this.m4_input_11.Text = "11";
            this.m4_input_11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.m4_input_11.WordWrap = false;
            this.m4_input_11.MouseCaptureChanged += new System.EventHandler(this.input_Click);
            // 
            // m4_input_8
            // 
            this.m4_input_8.BackAlpha = 0;
            this.m4_input_8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.m4_input_8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.m4_input_8.Font = new System.Drawing.Font("Browallia New", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.m4_input_8.ForeColor = System.Drawing.Color.Black;
            this.m4_input_8.Location = new System.Drawing.Point(97, 367);
            this.m4_input_8.Margin = new System.Windows.Forms.Padding(4);
            this.m4_input_8.Name = "m4_input_8";
            this.m4_input_8.Size = new System.Drawing.Size(127, 34);
            this.m4_input_8.TabIndex = 8;
            this.m4_input_8.Text = "8";
            this.m4_input_8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.m4_input_8.WordWrap = false;
            this.m4_input_8.MouseCaptureChanged += new System.EventHandler(this.input_Click);
            // 
            // m4_input_7
            // 
            this.m4_input_7.BackAlpha = 0;
            this.m4_input_7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.m4_input_7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.m4_input_7.Font = new System.Drawing.Font("Browallia New", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.m4_input_7.ForeColor = System.Drawing.Color.Black;
            this.m4_input_7.Location = new System.Drawing.Point(145, 219);
            this.m4_input_7.Margin = new System.Windows.Forms.Padding(4);
            this.m4_input_7.Name = "m4_input_7";
            this.m4_input_7.Size = new System.Drawing.Size(127, 34);
            this.m4_input_7.TabIndex = 7;
            this.m4_input_7.Text = "7";
            this.m4_input_7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.m4_input_7.WordWrap = false;
            this.m4_input_7.MouseCaptureChanged += new System.EventHandler(this.input_Click);
            // 
            // m4_input_10
            // 
            this.m4_input_10.BackAlpha = 0;
            this.m4_input_10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.m4_input_10.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.m4_input_10.Font = new System.Drawing.Font("Browallia New", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.m4_input_10.ForeColor = System.Drawing.Color.Black;
            this.m4_input_10.Location = new System.Drawing.Point(576, 135);
            this.m4_input_10.Margin = new System.Windows.Forms.Padding(4);
            this.m4_input_10.Name = "m4_input_10";
            this.m4_input_10.Size = new System.Drawing.Size(128, 34);
            this.m4_input_10.TabIndex = 10;
            this.m4_input_10.Text = "10";
            this.m4_input_10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.m4_input_10.WordWrap = false;
            this.m4_input_10.MouseCaptureChanged += new System.EventHandler(this.input_Click);
            // 
            // m4_input_1
            // 
            this.m4_input_1.BackAlpha = 0;
            this.m4_input_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.m4_input_1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.m4_input_1.Font = new System.Drawing.Font("Browallia New", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.m4_input_1.ForeColor = System.Drawing.Color.Black;
            this.m4_input_1.Location = new System.Drawing.Point(847, 372);
            this.m4_input_1.Margin = new System.Windows.Forms.Padding(4);
            this.m4_input_1.Name = "m4_input_1";
            this.m4_input_1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.m4_input_1.Size = new System.Drawing.Size(128, 34);
            this.m4_input_1.TabIndex = 1;
            this.m4_input_1.Text = "1";
            this.m4_input_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.m4_input_1.WordWrap = false;
            this.m4_input_1.MouseCaptureChanged += new System.EventHandler(this.input_Click);
            // 
            // m4_input_6
            // 
            this.m4_input_6.BackAlpha = 0;
            this.m4_input_6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.m4_input_6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.m4_input_6.Font = new System.Drawing.Font("Browallia New", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.m4_input_6.ForeColor = System.Drawing.Color.Black;
            this.m4_input_6.Location = new System.Drawing.Point(307, 369);
            this.m4_input_6.Margin = new System.Windows.Forms.Padding(4);
            this.m4_input_6.Name = "m4_input_6";
            this.m4_input_6.Size = new System.Drawing.Size(128, 34);
            this.m4_input_6.TabIndex = 6;
            this.m4_input_6.Text = "6";
            this.m4_input_6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.m4_input_6.WordWrap = false;
            this.m4_input_6.MouseCaptureChanged += new System.EventHandler(this.input_Click);
            // 
            // m4_label_11
            // 
            this.m4_label_11.BackColor = System.Drawing.Color.Transparent;
            this.m4_label_11.Font = new System.Drawing.Font("Browallia New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m4_label_11.ForeColor = System.Drawing.Color.DimGray;
            this.m4_label_11.Location = new System.Drawing.Point(355, 28);
            this.m4_label_11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.m4_label_11.Name = "m4_label_11";
            this.m4_label_11.Size = new System.Drawing.Size(450, 51);
            this.m4_label_11.TabIndex = 42;
            this.m4_label_11.Text = "11. มุมมองของภาพ";
            // 
            // m4_label_8
            // 
            this.m4_label_8.BackColor = System.Drawing.Color.Transparent;
            this.m4_label_8.Font = new System.Drawing.Font("Browallia New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m4_label_8.ForeColor = System.Drawing.Color.DimGray;
            this.m4_label_8.Location = new System.Drawing.Point(111, 265);
            this.m4_label_8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.m4_label_8.Name = "m4_label_8";
            this.m4_label_8.Size = new System.Drawing.Size(209, 80);
            this.m4_label_8.TabIndex = 41;
            this.m4_label_8.Text = "8. อารมณ์";
            // 
            // m4_label_9
            // 
            this.m4_label_9.BackColor = System.Drawing.Color.Transparent;
            this.m4_label_9.Font = new System.Drawing.Font("Browallia New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m4_label_9.ForeColor = System.Drawing.Color.DimGray;
            this.m4_label_9.Location = new System.Drawing.Point(187, 567);
            this.m4_label_9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.m4_label_9.Name = "m4_label_9";
            this.m4_label_9.Size = new System.Drawing.Size(257, 91);
            this.m4_label_9.TabIndex = 40;
            this.m4_label_9.Text = "9. ภาพพื้นหลัง";
            // 
            // m4_label_7
            // 
            this.m4_label_7.BackColor = System.Drawing.Color.Transparent;
            this.m4_label_7.Font = new System.Drawing.Font("Browallia New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m4_label_7.ForeColor = System.Drawing.Color.DimGray;
            this.m4_label_7.Location = new System.Drawing.Point(181, 145);
            this.m4_label_7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.m4_label_7.Name = "m4_label_7";
            this.m4_label_7.Size = new System.Drawing.Size(364, 55);
            this.m4_label_7.TabIndex = 38;
            this.m4_label_7.Text = "7. ที่ไหน";
            // 
            // m4_label_6
            // 
            this.m4_label_6.BackColor = System.Drawing.Color.Transparent;
            this.m4_label_6.Font = new System.Drawing.Font("Browallia New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m4_label_6.ForeColor = System.Drawing.Color.DimGray;
            this.m4_label_6.Location = new System.Drawing.Point(307, 421);
            this.m4_label_6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.m4_label_6.Name = "m4_label_6";
            this.m4_label_6.Size = new System.Drawing.Size(170, 128);
            this.m4_label_6.TabIndex = 37;
            this.m4_label_6.Text = "6. การเคลื่อนไหว";
            // 
            // m4_label_12
            // 
            this.m4_label_12.BackColor = System.Drawing.Color.Transparent;
            this.m4_label_12.Font = new System.Drawing.Font("Browallia New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m4_label_12.ForeColor = System.Drawing.Color.DimGray;
            this.m4_label_12.Location = new System.Drawing.Point(859, 33);
            this.m4_label_12.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.m4_label_12.Name = "m4_label_12";
            this.m4_label_12.Size = new System.Drawing.Size(449, 68);
            this.m4_label_12.TabIndex = 36;
            this.m4_label_12.Text = "12. เสียง";
            // 
            // m4_label_10
            // 
            this.m4_label_10.BackColor = System.Drawing.Color.Transparent;
            this.m4_label_10.Font = new System.Drawing.Font("Browallia New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m4_label_10.ForeColor = System.Drawing.Color.DimGray;
            this.m4_label_10.Location = new System.Drawing.Point(599, 191);
            this.m4_label_10.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.m4_label_10.Name = "m4_label_10";
            this.m4_label_10.Size = new System.Drawing.Size(265, 79);
            this.m4_label_10.TabIndex = 35;
            this.m4_label_10.Text = "10. เมื่อไหร่";
            // 
            // m4_label_5
            // 
            this.m4_label_5.BackColor = System.Drawing.Color.Transparent;
            this.m4_label_5.Font = new System.Drawing.Font("Browallia New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m4_label_5.ForeColor = System.Drawing.Color.DimGray;
            this.m4_label_5.Location = new System.Drawing.Point(996, 593);
            this.m4_label_5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.m4_label_5.Name = "m4_label_5";
            this.m4_label_5.Size = new System.Drawing.Size(302, 97);
            this.m4_label_5.TabIndex = 34;
            this.m4_label_5.Text = "5. จำนวน";
            // 
            // m4_label_4
            // 
            this.m4_label_4.BackColor = System.Drawing.Color.Transparent;
            this.m4_label_4.Font = new System.Drawing.Font("Browallia New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m4_label_4.ForeColor = System.Drawing.Color.DimGray;
            this.m4_label_4.Location = new System.Drawing.Point(1046, 455);
            this.m4_label_4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.m4_label_4.Name = "m4_label_4";
            this.m4_label_4.Size = new System.Drawing.Size(269, 80);
            this.m4_label_4.TabIndex = 33;
            this.m4_label_4.Text = "4. รูปร่าง";
            // 
            // m4_label_3
            // 
            this.m4_label_3.BackColor = System.Drawing.Color.Transparent;
            this.m4_label_3.Font = new System.Drawing.Font("Browallia New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m4_label_3.ForeColor = System.Drawing.Color.DimGray;
            this.m4_label_3.Location = new System.Drawing.Point(961, 237);
            this.m4_label_3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.m4_label_3.Name = "m4_label_3";
            this.m4_label_3.Size = new System.Drawing.Size(347, 92);
            this.m4_label_3.TabIndex = 32;
            this.m4_label_3.Text = "3. ขนาด";
            // 
            // m4_label_2
            // 
            this.m4_label_2.BackColor = System.Drawing.Color.Transparent;
            this.m4_label_2.Font = new System.Drawing.Font("Browallia New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m4_label_2.ForeColor = System.Drawing.Color.DimGray;
            this.m4_label_2.Location = new System.Drawing.Point(1009, 118);
            this.m4_label_2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.m4_label_2.Name = "m4_label_2";
            this.m4_label_2.Size = new System.Drawing.Size(310, 54);
            this.m4_label_2.TabIndex = 31;
            this.m4_label_2.Text = "2. สี";
            // 
            // m4_label_1
            // 
            this.m4_label_1.BackColor = System.Drawing.Color.Transparent;
            this.m4_label_1.Font = new System.Drawing.Font("Browallia New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m4_label_1.ForeColor = System.Drawing.Color.DimGray;
            this.m4_label_1.Location = new System.Drawing.Point(845, 431);
            this.m4_label_1.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.m4_label_1.Name = "m4_label_1";
            this.m4_label_1.Size = new System.Drawing.Size(140, 118);
            this.m4_label_1.TabIndex = 30;
            this.m4_label_1.Text = "1. อะไร";
            // 
            // m4_btn_1
            // 
            this.m4_btn_1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.m4_btn_1.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.m4_btn_1.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.m4_btn_1.Appearance.Font = new System.Drawing.Font("Browallia New", 19.8F);
            this.m4_btn_1.Appearance.ForeColor = System.Drawing.Color.Transparent;
            this.m4_btn_1.Appearance.Options.UseBackColor = true;
            this.m4_btn_1.Appearance.Options.UseBorderColor = true;
            this.m4_btn_1.Appearance.Options.UseFont = true;
            this.m4_btn_1.Appearance.Options.UseForeColor = true;
            this.m4_btn_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.m4_btn_1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.m4_btn_1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.m4_btn_1.ImageOptions.Image = global::LDWordProcessor.Properties.Resources.icon_speaker;
            this.m4_btn_1.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.m4_btn_1.Location = new System.Drawing.Point(795, 431);
            this.m4_btn_1.Margin = new System.Windows.Forms.Padding(12, 9, 12, 9);
            this.m4_btn_1.Name = "m4_btn_1";
            this.m4_btn_1.Size = new System.Drawing.Size(49, 46);
            this.m4_btn_1.TabIndex = 25;
            this.m4_btn_1.Text = "อ่านคำถาม";
            this.m4_btn_1.Click += new System.EventHandler(this.btnReadQuestion_Click);
            // 
            // m4_btn_2
            // 
            this.m4_btn_2.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.m4_btn_2.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.m4_btn_2.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.m4_btn_2.Appearance.Font = new System.Drawing.Font("Browallia New", 19.8F);
            this.m4_btn_2.Appearance.ForeColor = System.Drawing.Color.Transparent;
            this.m4_btn_2.Appearance.Options.UseBackColor = true;
            this.m4_btn_2.Appearance.Options.UseBorderColor = true;
            this.m4_btn_2.Appearance.Options.UseFont = true;
            this.m4_btn_2.Appearance.Options.UseForeColor = true;
            this.m4_btn_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.m4_btn_2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.m4_btn_2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.m4_btn_2.ImageOptions.Image = global::LDWordProcessor.Properties.Resources.icon_speaker;
            this.m4_btn_2.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.m4_btn_2.Location = new System.Drawing.Point(960, 118);
            this.m4_btn_2.Margin = new System.Windows.Forms.Padding(12, 9, 12, 9);
            this.m4_btn_2.Name = "m4_btn_2";
            this.m4_btn_2.Size = new System.Drawing.Size(49, 46);
            this.m4_btn_2.TabIndex = 25;
            this.m4_btn_2.Text = "อ่านคำถาม";
            this.m4_btn_2.Click += new System.EventHandler(this.btnReadQuestion_Click);
            // 
            // m4_btn_3
            // 
            this.m4_btn_3.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.m4_btn_3.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.m4_btn_3.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.m4_btn_3.Appearance.Font = new System.Drawing.Font("Browallia New", 19.8F);
            this.m4_btn_3.Appearance.ForeColor = System.Drawing.Color.Transparent;
            this.m4_btn_3.Appearance.Options.UseBackColor = true;
            this.m4_btn_3.Appearance.Options.UseBorderColor = true;
            this.m4_btn_3.Appearance.Options.UseFont = true;
            this.m4_btn_3.Appearance.Options.UseForeColor = true;
            this.m4_btn_3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.m4_btn_3.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.m4_btn_3.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.m4_btn_3.ImageOptions.Image = global::LDWordProcessor.Properties.Resources.icon_speaker;
            this.m4_btn_3.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.m4_btn_3.Location = new System.Drawing.Point(910, 232);
            this.m4_btn_3.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.m4_btn_3.Name = "m4_btn_3";
            this.m4_btn_3.Size = new System.Drawing.Size(49, 46);
            this.m4_btn_3.TabIndex = 25;
            this.m4_btn_3.Text = "อ่านคำถาม";
            this.m4_btn_3.Click += new System.EventHandler(this.btnReadQuestion_Click);
            // 
            // m4_btn_4
            // 
            this.m4_btn_4.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.m4_btn_4.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.m4_btn_4.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.m4_btn_4.Appearance.Font = new System.Drawing.Font("Browallia New", 19.8F);
            this.m4_btn_4.Appearance.ForeColor = System.Drawing.Color.Transparent;
            this.m4_btn_4.Appearance.Options.UseBackColor = true;
            this.m4_btn_4.Appearance.Options.UseBorderColor = true;
            this.m4_btn_4.Appearance.Options.UseFont = true;
            this.m4_btn_4.Appearance.Options.UseForeColor = true;
            this.m4_btn_4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.m4_btn_4.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.m4_btn_4.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.m4_btn_4.ImageOptions.Image = global::LDWordProcessor.Properties.Resources.icon_speaker;
            this.m4_btn_4.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.m4_btn_4.Location = new System.Drawing.Point(995, 455);
            this.m4_btn_4.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.m4_btn_4.Name = "m4_btn_4";
            this.m4_btn_4.Size = new System.Drawing.Size(49, 46);
            this.m4_btn_4.TabIndex = 25;
            this.m4_btn_4.Text = "อ่านคำถาม";
            this.m4_btn_4.Click += new System.EventHandler(this.btnReadQuestion_Click);
            // 
            // m4_btn_5
            // 
            this.m4_btn_5.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.m4_btn_5.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.m4_btn_5.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.m4_btn_5.Appearance.Font = new System.Drawing.Font("Browallia New", 19.8F);
            this.m4_btn_5.Appearance.ForeColor = System.Drawing.Color.Transparent;
            this.m4_btn_5.Appearance.Options.UseBackColor = true;
            this.m4_btn_5.Appearance.Options.UseBorderColor = true;
            this.m4_btn_5.Appearance.Options.UseFont = true;
            this.m4_btn_5.Appearance.Options.UseForeColor = true;
            this.m4_btn_5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.m4_btn_5.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.m4_btn_5.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.m4_btn_5.ImageOptions.Image = global::LDWordProcessor.Properties.Resources.icon_speaker;
            this.m4_btn_5.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.m4_btn_5.Location = new System.Drawing.Point(947, 593);
            this.m4_btn_5.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.m4_btn_5.Name = "m4_btn_5";
            this.m4_btn_5.Size = new System.Drawing.Size(49, 46);
            this.m4_btn_5.TabIndex = 25;
            this.m4_btn_5.Text = "อ่านคำถาม";
            this.m4_btn_5.Click += new System.EventHandler(this.btnReadQuestion_Click);
            // 
            // m4_btn_6
            // 
            this.m4_btn_6.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.m4_btn_6.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.m4_btn_6.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.m4_btn_6.Appearance.Font = new System.Drawing.Font("Browallia New", 19.8F);
            this.m4_btn_6.Appearance.ForeColor = System.Drawing.Color.Transparent;
            this.m4_btn_6.Appearance.Options.UseBackColor = true;
            this.m4_btn_6.Appearance.Options.UseBorderColor = true;
            this.m4_btn_6.Appearance.Options.UseFont = true;
            this.m4_btn_6.Appearance.Options.UseForeColor = true;
            this.m4_btn_6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.m4_btn_6.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.m4_btn_6.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.m4_btn_6.ImageOptions.Image = global::LDWordProcessor.Properties.Resources.icon_speaker;
            this.m4_btn_6.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.m4_btn_6.Location = new System.Drawing.Point(257, 421);
            this.m4_btn_6.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.m4_btn_6.Name = "m4_btn_6";
            this.m4_btn_6.Size = new System.Drawing.Size(49, 46);
            this.m4_btn_6.TabIndex = 25;
            this.m4_btn_6.Text = "อ่านคำถาม";
            this.m4_btn_6.Click += new System.EventHandler(this.btnReadQuestion_Click);
            // 
            // m4_btn_7
            // 
            this.m4_btn_7.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.m4_btn_7.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.m4_btn_7.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.m4_btn_7.Appearance.Font = new System.Drawing.Font("Browallia New", 19.8F);
            this.m4_btn_7.Appearance.ForeColor = System.Drawing.Color.Transparent;
            this.m4_btn_7.Appearance.Options.UseBackColor = true;
            this.m4_btn_7.Appearance.Options.UseBorderColor = true;
            this.m4_btn_7.Appearance.Options.UseFont = true;
            this.m4_btn_7.Appearance.Options.UseForeColor = true;
            this.m4_btn_7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.m4_btn_7.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.m4_btn_7.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.m4_btn_7.ImageOptions.Image = global::LDWordProcessor.Properties.Resources.icon_speaker;
            this.m4_btn_7.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.m4_btn_7.Location = new System.Drawing.Point(132, 145);
            this.m4_btn_7.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.m4_btn_7.Name = "m4_btn_7";
            this.m4_btn_7.Size = new System.Drawing.Size(49, 46);
            this.m4_btn_7.TabIndex = 25;
            this.m4_btn_7.Text = "อ่านคำถาม";
            this.m4_btn_7.Click += new System.EventHandler(this.btnReadQuestion_Click);
            // 
            // m4_btn_8
            // 
            this.m4_btn_8.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.m4_btn_8.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.m4_btn_8.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.m4_btn_8.Appearance.Font = new System.Drawing.Font("Browallia New", 19.8F);
            this.m4_btn_8.Appearance.ForeColor = System.Drawing.Color.Transparent;
            this.m4_btn_8.Appearance.Options.UseBackColor = true;
            this.m4_btn_8.Appearance.Options.UseBorderColor = true;
            this.m4_btn_8.Appearance.Options.UseFont = true;
            this.m4_btn_8.Appearance.Options.UseForeColor = true;
            this.m4_btn_8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.m4_btn_8.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.m4_btn_8.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.m4_btn_8.ImageOptions.Image = global::LDWordProcessor.Properties.Resources.icon_speaker;
            this.m4_btn_8.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.m4_btn_8.Location = new System.Drawing.Point(61, 268);
            this.m4_btn_8.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.m4_btn_8.Name = "m4_btn_8";
            this.m4_btn_8.Size = new System.Drawing.Size(49, 46);
            this.m4_btn_8.TabIndex = 25;
            this.m4_btn_8.Text = "อ่านคำถาม";
            this.m4_btn_8.Click += new System.EventHandler(this.btnReadQuestion_Click);
            // 
            // m4_btn_9
            // 
            this.m4_btn_9.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.m4_btn_9.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.m4_btn_9.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.m4_btn_9.Appearance.Font = new System.Drawing.Font("Browallia New", 19.8F);
            this.m4_btn_9.Appearance.ForeColor = System.Drawing.Color.Transparent;
            this.m4_btn_9.Appearance.Options.UseBackColor = true;
            this.m4_btn_9.Appearance.Options.UseBorderColor = true;
            this.m4_btn_9.Appearance.Options.UseFont = true;
            this.m4_btn_9.Appearance.Options.UseForeColor = true;
            this.m4_btn_9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.m4_btn_9.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.m4_btn_9.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.m4_btn_9.ImageOptions.Image = global::LDWordProcessor.Properties.Resources.icon_speaker;
            this.m4_btn_9.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.m4_btn_9.Location = new System.Drawing.Point(137, 567);
            this.m4_btn_9.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.m4_btn_9.Name = "m4_btn_9";
            this.m4_btn_9.Size = new System.Drawing.Size(49, 46);
            this.m4_btn_9.TabIndex = 25;
            this.m4_btn_9.Text = "อ่านคำถาม";
            this.m4_btn_9.Click += new System.EventHandler(this.btnReadQuestion_Click);
            // 
            // m4_btn_10
            // 
            this.m4_btn_10.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.m4_btn_10.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.m4_btn_10.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.m4_btn_10.Appearance.Font = new System.Drawing.Font("Browallia New", 19.8F);
            this.m4_btn_10.Appearance.ForeColor = System.Drawing.Color.Transparent;
            this.m4_btn_10.Appearance.Options.UseBackColor = true;
            this.m4_btn_10.Appearance.Options.UseBorderColor = true;
            this.m4_btn_10.Appearance.Options.UseFont = true;
            this.m4_btn_10.Appearance.Options.UseForeColor = true;
            this.m4_btn_10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.m4_btn_10.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.m4_btn_10.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.m4_btn_10.ImageOptions.Image = global::LDWordProcessor.Properties.Resources.icon_speaker;
            this.m4_btn_10.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.m4_btn_10.Location = new System.Drawing.Point(549, 191);
            this.m4_btn_10.Margin = new System.Windows.Forms.Padding(12, 9, 12, 9);
            this.m4_btn_10.Name = "m4_btn_10";
            this.m4_btn_10.Size = new System.Drawing.Size(49, 46);
            this.m4_btn_10.TabIndex = 25;
            this.m4_btn_10.Text = "อ่านคำถาม";
            this.m4_btn_10.Click += new System.EventHandler(this.btnReadQuestion_Click);
            // 
            // m4_btn_11
            // 
            this.m4_btn_11.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.m4_btn_11.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.m4_btn_11.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.m4_btn_11.Appearance.Font = new System.Drawing.Font("Browallia New", 19.8F);
            this.m4_btn_11.Appearance.ForeColor = System.Drawing.Color.Transparent;
            this.m4_btn_11.Appearance.Options.UseBackColor = true;
            this.m4_btn_11.Appearance.Options.UseBorderColor = true;
            this.m4_btn_11.Appearance.Options.UseFont = true;
            this.m4_btn_11.Appearance.Options.UseForeColor = true;
            this.m4_btn_11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.m4_btn_11.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.m4_btn_11.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.m4_btn_11.ImageOptions.Image = global::LDWordProcessor.Properties.Resources.icon_speaker;
            this.m4_btn_11.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.m4_btn_11.Location = new System.Drawing.Point(298, 28);
            this.m4_btn_11.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.m4_btn_11.Name = "m4_btn_11";
            this.m4_btn_11.Size = new System.Drawing.Size(49, 46);
            this.m4_btn_11.TabIndex = 25;
            this.m4_btn_11.Text = "อ่านคำถาม";
            this.m4_btn_11.Click += new System.EventHandler(this.btnReadQuestion_Click);
            // 
            // m4_btn_12
            // 
            this.m4_btn_12.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.m4_btn_12.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.m4_btn_12.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.m4_btn_12.Appearance.Font = new System.Drawing.Font("Browallia New", 19.8F);
            this.m4_btn_12.Appearance.ForeColor = System.Drawing.Color.Transparent;
            this.m4_btn_12.Appearance.Options.UseBackColor = true;
            this.m4_btn_12.Appearance.Options.UseBorderColor = true;
            this.m4_btn_12.Appearance.Options.UseFont = true;
            this.m4_btn_12.Appearance.Options.UseForeColor = true;
            this.m4_btn_12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.m4_btn_12.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.m4_btn_12.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.m4_btn_12.ImageOptions.Image = global::LDWordProcessor.Properties.Resources.icon_speaker;
            this.m4_btn_12.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.m4_btn_12.Location = new System.Drawing.Point(809, 33);
            this.m4_btn_12.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.m4_btn_12.Name = "m4_btn_12";
            this.m4_btn_12.Size = new System.Drawing.Size(49, 46);
            this.m4_btn_12.TabIndex = 25;
            this.m4_btn_12.Text = "อ่านคำถาม";
            this.m4_btn_12.Click += new System.EventHandler(this.btnReadQuestion_Click);
            // 
            // map4_photo
            // 
            this.map4_photo.BackColor = System.Drawing.Color.Transparent;
            this.map4_photo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.map4_photo.Controls.Add(this.m4_input_title);
            this.map4_photo.Font = new System.Drawing.Font("Browallia New", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.map4_photo.Location = new System.Drawing.Point(485, 284);
            this.map4_photo.Margin = new System.Windows.Forms.Padding(4);
            this.map4_photo.Name = "map4_photo";
            this.map4_photo.Size = new System.Drawing.Size(299, 218);
            this.map4_photo.TabIndex = 29;
            this.map4_photo.Click += new System.EventHandler(this.mapPhoto_Click);
            // 
            // m4_input_title
            // 
            this.m4_input_title.BackAlpha = 0;
            this.m4_input_title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.m4_input_title.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.m4_input_title.Font = new System.Drawing.Font("Browallia New", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m4_input_title.Location = new System.Drawing.Point(8, 36);
            this.m4_input_title.Margin = new System.Windows.Forms.Padding(4);
            this.m4_input_title.Multiline = true;
            this.m4_input_title.Name = "m4_input_title";
            this.m4_input_title.ReadOnly = true;
            this.m4_input_title.Size = new System.Drawing.Size(285, 133);
            this.m4_input_title.TabIndex = 0;
            this.m4_input_title.TabStop = false;
            this.m4_input_title.Text = "ชื่อเรื่อง";
            this.m4_input_title.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.m4_input_title.MouseCaptureChanged += new System.EventHandler(this.input_Click);
            // 
            // pnMainMindmap3
            // 
            this.pnMainMindmap3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnMainMindmap3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnMainMindmap3.BackgroundImage")));
            this.pnMainMindmap3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnMainMindmap3.Controls.Add(this.m3_label_rp_5);
            this.pnMainMindmap3.Controls.Add(this.m3_label_rp_4);
            this.pnMainMindmap3.Controls.Add(this.m3_label_rp_3);
            this.pnMainMindmap3.Controls.Add(this.m3_label_rp_12);
            this.pnMainMindmap3.Controls.Add(this.m3_label_rp_11);
            this.pnMainMindmap3.Controls.Add(this.m3_label_rp_9);
            this.pnMainMindmap3.Controls.Add(this.m3_label_rp_8);
            this.pnMainMindmap3.Controls.Add(this.m3_label_rp_7);
            this.pnMainMindmap3.Controls.Add(this.m3_label_rp_2);
            this.pnMainMindmap3.Controls.Add(this.m3_label_rp_10);
            this.pnMainMindmap3.Controls.Add(this.m3_label_rp_6);
            this.pnMainMindmap3.Controls.Add(this.m3_label_rp_1);
            this.pnMainMindmap3.Controls.Add(this.m3_input_5);
            this.pnMainMindmap3.Controls.Add(this.m3_input_4);
            this.pnMainMindmap3.Controls.Add(this.m3_input_3);
            this.pnMainMindmap3.Controls.Add(this.m3_input_2);
            this.pnMainMindmap3.Controls.Add(this.m3_input_12);
            this.pnMainMindmap3.Controls.Add(this.m3_input_9);
            this.pnMainMindmap3.Controls.Add(this.m3_input_11);
            this.pnMainMindmap3.Controls.Add(this.m3_input_8);
            this.pnMainMindmap3.Controls.Add(this.m3_input_7);
            this.pnMainMindmap3.Controls.Add(this.m3_input_10);
            this.pnMainMindmap3.Controls.Add(this.m3_input_1);
            this.pnMainMindmap3.Controls.Add(this.m3_input_6);
            this.pnMainMindmap3.Controls.Add(this.m3_label_11);
            this.pnMainMindmap3.Controls.Add(this.m3_label_8);
            this.pnMainMindmap3.Controls.Add(this.m3_label_9);
            this.pnMainMindmap3.Controls.Add(this.m3_label_7);
            this.pnMainMindmap3.Controls.Add(this.m3_label_6);
            this.pnMainMindmap3.Controls.Add(this.m3_label_12);
            this.pnMainMindmap3.Controls.Add(this.m3_label_10);
            this.pnMainMindmap3.Controls.Add(this.m3_label_5);
            this.pnMainMindmap3.Controls.Add(this.m3_label_4);
            this.pnMainMindmap3.Controls.Add(this.m3_label_3);
            this.pnMainMindmap3.Controls.Add(this.m3_label_2);
            this.pnMainMindmap3.Controls.Add(this.m3_label_1);
            this.pnMainMindmap3.Controls.Add(this.m3_btn_1);
            this.pnMainMindmap3.Controls.Add(this.m3_btn_2);
            this.pnMainMindmap3.Controls.Add(this.m3_btn_3);
            this.pnMainMindmap3.Controls.Add(this.m3_btn_4);
            this.pnMainMindmap3.Controls.Add(this.m3_btn_5);
            this.pnMainMindmap3.Controls.Add(this.m3_btn_6);
            this.pnMainMindmap3.Controls.Add(this.m3_btn_7);
            this.pnMainMindmap3.Controls.Add(this.m3_btn_8);
            this.pnMainMindmap3.Controls.Add(this.m3_btn_9);
            this.pnMainMindmap3.Controls.Add(this.m3_btn_10);
            this.pnMainMindmap3.Controls.Add(this.m3_btn_11);
            this.pnMainMindmap3.Controls.Add(this.m3_btn_12);
            this.pnMainMindmap3.Controls.Add(this.map3_photo);
            this.pnMainMindmap3.Location = new System.Drawing.Point(1, 2);
            this.pnMainMindmap3.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.pnMainMindmap3.Name = "pnMainMindmap3";
            this.pnMainMindmap3.Size = new System.Drawing.Size(1319, 700);
            this.pnMainMindmap3.TabIndex = 4;
            // 
            // m3_label_rp_5
            // 
            this.m3_label_rp_5.BackColor = System.Drawing.Color.Transparent;
            this.m3_label_rp_5.Font = new System.Drawing.Font("Browallia New", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m3_label_rp_5.ForeColor = System.Drawing.Color.Black;
            this.m3_label_rp_5.Location = new System.Drawing.Point(839, 555);
            this.m3_label_rp_5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.m3_label_rp_5.Name = "m3_label_rp_5";
            this.m3_label_rp_5.Size = new System.Drawing.Size(129, 43);
            this.m3_label_rp_5.TabIndex = 44;
            this.m3_label_rp_5.Text = "5";
            this.m3_label_rp_5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.m3_label_rp_5.UseCompatibleTextRendering = true;
            // 
            // m3_label_rp_4
            // 
            this.m3_label_rp_4.BackColor = System.Drawing.Color.Transparent;
            this.m3_label_rp_4.Font = new System.Drawing.Font("Browallia New", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m3_label_rp_4.ForeColor = System.Drawing.Color.Black;
            this.m3_label_rp_4.Location = new System.Drawing.Point(1063, 484);
            this.m3_label_rp_4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.m3_label_rp_4.Name = "m3_label_rp_4";
            this.m3_label_rp_4.Size = new System.Drawing.Size(129, 43);
            this.m3_label_rp_4.TabIndex = 44;
            this.m3_label_rp_4.Text = "4";
            this.m3_label_rp_4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.m3_label_rp_4.UseCompatibleTextRendering = true;
            // 
            // m3_label_rp_3
            // 
            this.m3_label_rp_3.BackColor = System.Drawing.Color.Transparent;
            this.m3_label_rp_3.Font = new System.Drawing.Font("Browallia New", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m3_label_rp_3.ForeColor = System.Drawing.Color.Black;
            this.m3_label_rp_3.Location = new System.Drawing.Point(1101, 281);
            this.m3_label_rp_3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.m3_label_rp_3.Name = "m3_label_rp_3";
            this.m3_label_rp_3.Size = new System.Drawing.Size(129, 30);
            this.m3_label_rp_3.TabIndex = 44;
            this.m3_label_rp_3.Text = "3";
            this.m3_label_rp_3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.m3_label_rp_3.UseCompatibleTextRendering = true;
            // 
            // m3_label_rp_12
            // 
            this.m3_label_rp_12.BackColor = System.Drawing.Color.Transparent;
            this.m3_label_rp_12.Font = new System.Drawing.Font("Browallia New", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m3_label_rp_12.ForeColor = System.Drawing.Color.Black;
            this.m3_label_rp_12.Location = new System.Drawing.Point(761, 53);
            this.m3_label_rp_12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.m3_label_rp_12.Name = "m3_label_rp_12";
            this.m3_label_rp_12.Size = new System.Drawing.Size(129, 43);
            this.m3_label_rp_12.TabIndex = 44;
            this.m3_label_rp_12.Text = "12";
            this.m3_label_rp_12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.m3_label_rp_12.UseCompatibleTextRendering = true;
            // 
            // m3_label_rp_11
            // 
            this.m3_label_rp_11.BackColor = System.Drawing.Color.Transparent;
            this.m3_label_rp_11.Font = new System.Drawing.Font("Browallia New", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m3_label_rp_11.ForeColor = System.Drawing.Color.Black;
            this.m3_label_rp_11.Location = new System.Drawing.Point(423, 52);
            this.m3_label_rp_11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.m3_label_rp_11.Name = "m3_label_rp_11";
            this.m3_label_rp_11.Size = new System.Drawing.Size(129, 43);
            this.m3_label_rp_11.TabIndex = 44;
            this.m3_label_rp_11.Text = "11";
            this.m3_label_rp_11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.m3_label_rp_11.UseCompatibleTextRendering = true;
            // 
            // m3_label_rp_9
            // 
            this.m3_label_rp_9.BackColor = System.Drawing.Color.Transparent;
            this.m3_label_rp_9.Font = new System.Drawing.Font("Browallia New", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m3_label_rp_9.ForeColor = System.Drawing.Color.Black;
            this.m3_label_rp_9.Location = new System.Drawing.Point(136, 485);
            this.m3_label_rp_9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.m3_label_rp_9.Name = "m3_label_rp_9";
            this.m3_label_rp_9.Size = new System.Drawing.Size(129, 43);
            this.m3_label_rp_9.TabIndex = 44;
            this.m3_label_rp_9.Text = "9";
            this.m3_label_rp_9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.m3_label_rp_9.UseCompatibleTextRendering = true;
            // 
            // m3_label_rp_8
            // 
            this.m3_label_rp_8.BackColor = System.Drawing.Color.Transparent;
            this.m3_label_rp_8.Font = new System.Drawing.Font("Browallia New", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m3_label_rp_8.ForeColor = System.Drawing.Color.Black;
            this.m3_label_rp_8.Location = new System.Drawing.Point(93, 266);
            this.m3_label_rp_8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.m3_label_rp_8.Name = "m3_label_rp_8";
            this.m3_label_rp_8.Size = new System.Drawing.Size(129, 43);
            this.m3_label_rp_8.TabIndex = 44;
            this.m3_label_rp_8.Text = "8";
            this.m3_label_rp_8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.m3_label_rp_8.UseCompatibleTextRendering = true;
            // 
            // m3_label_rp_7
            // 
            this.m3_label_rp_7.BackColor = System.Drawing.Color.Transparent;
            this.m3_label_rp_7.Font = new System.Drawing.Font("Browallia New", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m3_label_rp_7.ForeColor = System.Drawing.Color.Black;
            this.m3_label_rp_7.Location = new System.Drawing.Point(175, 107);
            this.m3_label_rp_7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.m3_label_rp_7.Name = "m3_label_rp_7";
            this.m3_label_rp_7.Size = new System.Drawing.Size(129, 43);
            this.m3_label_rp_7.TabIndex = 44;
            this.m3_label_rp_7.Text = "7";
            this.m3_label_rp_7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.m3_label_rp_7.UseCompatibleTextRendering = true;
            // 
            // m3_label_rp_2
            // 
            this.m3_label_rp_2.BackColor = System.Drawing.Color.Transparent;
            this.m3_label_rp_2.Font = new System.Drawing.Font("Browallia New", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m3_label_rp_2.ForeColor = System.Drawing.Color.Black;
            this.m3_label_rp_2.Location = new System.Drawing.Point(959, 97);
            this.m3_label_rp_2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.m3_label_rp_2.Name = "m3_label_rp_2";
            this.m3_label_rp_2.Size = new System.Drawing.Size(129, 43);
            this.m3_label_rp_2.TabIndex = 44;
            this.m3_label_rp_2.Text = "2";
            this.m3_label_rp_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.m3_label_rp_2.UseCompatibleTextRendering = true;
            // 
            // m3_label_rp_10
            // 
            this.m3_label_rp_10.BackColor = System.Drawing.Color.Transparent;
            this.m3_label_rp_10.Font = new System.Drawing.Font("Browallia New", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m3_label_rp_10.ForeColor = System.Drawing.Color.Black;
            this.m3_label_rp_10.Location = new System.Drawing.Point(567, 207);
            this.m3_label_rp_10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.m3_label_rp_10.Name = "m3_label_rp_10";
            this.m3_label_rp_10.Size = new System.Drawing.Size(181, 43);
            this.m3_label_rp_10.TabIndex = 44;
            this.m3_label_rp_10.Text = "10";
            this.m3_label_rp_10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.m3_label_rp_10.UseCompatibleTextRendering = true;
            // 
            // m3_label_rp_6
            // 
            this.m3_label_rp_6.BackColor = System.Drawing.Color.Transparent;
            this.m3_label_rp_6.Font = new System.Drawing.Font("Browallia New", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m3_label_rp_6.ForeColor = System.Drawing.Color.Black;
            this.m3_label_rp_6.Location = new System.Drawing.Point(351, 298);
            this.m3_label_rp_6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.m3_label_rp_6.Name = "m3_label_rp_6";
            this.m3_label_rp_6.Size = new System.Drawing.Size(181, 43);
            this.m3_label_rp_6.TabIndex = 44;
            this.m3_label_rp_6.Text = "6";
            this.m3_label_rp_6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.m3_label_rp_6.UseCompatibleTextRendering = true;
            // 
            // m3_label_rp_1
            // 
            this.m3_label_rp_1.BackColor = System.Drawing.Color.Transparent;
            this.m3_label_rp_1.Font = new System.Drawing.Font("Browallia New", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m3_label_rp_1.ForeColor = System.Drawing.Color.Black;
            this.m3_label_rp_1.Location = new System.Drawing.Point(811, 304);
            this.m3_label_rp_1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.m3_label_rp_1.Name = "m3_label_rp_1";
            this.m3_label_rp_1.Size = new System.Drawing.Size(181, 43);
            this.m3_label_rp_1.TabIndex = 44;
            this.m3_label_rp_1.Text = "1";
            this.m3_label_rp_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.m3_label_rp_1.UseCompatibleTextRendering = true;
            // 
            // m3_input_5
            // 
            this.m3_input_5.BackAlpha = 0;
            this.m3_input_5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.m3_input_5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.m3_input_5.Font = new System.Drawing.Font("Browallia New", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.m3_input_5.ForeColor = System.Drawing.Color.Black;
            this.m3_input_5.Location = new System.Drawing.Point(839, 604);
            this.m3_input_5.Margin = new System.Windows.Forms.Padding(4);
            this.m3_input_5.Multiline = true;
            this.m3_input_5.Name = "m3_input_5";
            this.m3_input_5.Size = new System.Drawing.Size(129, 55);
            this.m3_input_5.TabIndex = 5;
            this.m3_input_5.Text = "5";
            this.m3_input_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.m3_input_5.WordWrap = false;
            this.m3_input_5.MouseCaptureChanged += new System.EventHandler(this.input_Click);
            // 
            // m3_input_4
            // 
            this.m3_input_4.BackAlpha = 0;
            this.m3_input_4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.m3_input_4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.m3_input_4.Font = new System.Drawing.Font("Browallia New", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.m3_input_4.ForeColor = System.Drawing.Color.Black;
            this.m3_input_4.Location = new System.Drawing.Point(1064, 529);
            this.m3_input_4.Margin = new System.Windows.Forms.Padding(4);
            this.m3_input_4.Multiline = true;
            this.m3_input_4.Name = "m3_input_4";
            this.m3_input_4.Size = new System.Drawing.Size(129, 63);
            this.m3_input_4.TabIndex = 4;
            this.m3_input_4.Text = "4";
            this.m3_input_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.m3_input_4.WordWrap = false;
            this.m3_input_4.MouseCaptureChanged += new System.EventHandler(this.input_Click);
            // 
            // m3_input_3
            // 
            this.m3_input_3.BackAlpha = 0;
            this.m3_input_3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.m3_input_3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.m3_input_3.Font = new System.Drawing.Font("Browallia New", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.m3_input_3.ForeColor = System.Drawing.Color.Black;
            this.m3_input_3.Location = new System.Drawing.Point(1101, 314);
            this.m3_input_3.Margin = new System.Windows.Forms.Padding(4);
            this.m3_input_3.Multiline = true;
            this.m3_input_3.Name = "m3_input_3";
            this.m3_input_3.Size = new System.Drawing.Size(129, 63);
            this.m3_input_3.TabIndex = 3;
            this.m3_input_3.Text = "3";
            this.m3_input_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.m3_input_3.WordWrap = false;
            this.m3_input_3.MouseCaptureChanged += new System.EventHandler(this.input_Click);
            // 
            // m3_input_2
            // 
            this.m3_input_2.BackAlpha = 0;
            this.m3_input_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.m3_input_2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.m3_input_2.Font = new System.Drawing.Font("Browallia New", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.m3_input_2.ForeColor = System.Drawing.Color.Black;
            this.m3_input_2.Location = new System.Drawing.Point(959, 143);
            this.m3_input_2.Margin = new System.Windows.Forms.Padding(4);
            this.m3_input_2.Multiline = true;
            this.m3_input_2.Name = "m3_input_2";
            this.m3_input_2.Size = new System.Drawing.Size(129, 60);
            this.m3_input_2.TabIndex = 2;
            this.m3_input_2.Text = "2";
            this.m3_input_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.m3_input_2.WordWrap = false;
            this.m3_input_2.MouseCaptureChanged += new System.EventHandler(this.input_Click);
            // 
            // m3_input_12
            // 
            this.m3_input_12.BackAlpha = 0;
            this.m3_input_12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.m3_input_12.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.m3_input_12.Font = new System.Drawing.Font("Browallia New", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.m3_input_12.ForeColor = System.Drawing.Color.Black;
            this.m3_input_12.Location = new System.Drawing.Point(761, 97);
            this.m3_input_12.Margin = new System.Windows.Forms.Padding(4);
            this.m3_input_12.Multiline = true;
            this.m3_input_12.Name = "m3_input_12";
            this.m3_input_12.Size = new System.Drawing.Size(129, 55);
            this.m3_input_12.TabIndex = 12;
            this.m3_input_12.Text = "12";
            this.m3_input_12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.m3_input_12.WordWrap = false;
            this.m3_input_12.MouseCaptureChanged += new System.EventHandler(this.input_Click);
            // 
            // m3_input_9
            // 
            this.m3_input_9.BackAlpha = 0;
            this.m3_input_9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.m3_input_9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.m3_input_9.Font = new System.Drawing.Font("Browallia New", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.m3_input_9.ForeColor = System.Drawing.Color.Black;
            this.m3_input_9.Location = new System.Drawing.Point(137, 532);
            this.m3_input_9.Margin = new System.Windows.Forms.Padding(4);
            this.m3_input_9.Multiline = true;
            this.m3_input_9.Name = "m3_input_9";
            this.m3_input_9.Size = new System.Drawing.Size(129, 57);
            this.m3_input_9.TabIndex = 9;
            this.m3_input_9.Text = "9";
            this.m3_input_9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.m3_input_9.WordWrap = false;
            this.m3_input_9.MouseCaptureChanged += new System.EventHandler(this.input_Click);
            // 
            // m3_input_11
            // 
            this.m3_input_11.BackAlpha = 0;
            this.m3_input_11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.m3_input_11.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.m3_input_11.Font = new System.Drawing.Font("Browallia New", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.m3_input_11.ForeColor = System.Drawing.Color.Black;
            this.m3_input_11.Location = new System.Drawing.Point(423, 97);
            this.m3_input_11.Margin = new System.Windows.Forms.Padding(4);
            this.m3_input_11.Multiline = true;
            this.m3_input_11.Name = "m3_input_11";
            this.m3_input_11.Size = new System.Drawing.Size(129, 64);
            this.m3_input_11.TabIndex = 11;
            this.m3_input_11.Text = "11";
            this.m3_input_11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.m3_input_11.WordWrap = false;
            this.m3_input_11.MouseCaptureChanged += new System.EventHandler(this.input_Click);
            // 
            // m3_input_8
            // 
            this.m3_input_8.BackAlpha = 0;
            this.m3_input_8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.m3_input_8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.m3_input_8.Font = new System.Drawing.Font("Browallia New", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.m3_input_8.ForeColor = System.Drawing.Color.Black;
            this.m3_input_8.Location = new System.Drawing.Point(95, 311);
            this.m3_input_8.Margin = new System.Windows.Forms.Padding(4);
            this.m3_input_8.Multiline = true;
            this.m3_input_8.Name = "m3_input_8";
            this.m3_input_8.Size = new System.Drawing.Size(129, 64);
            this.m3_input_8.TabIndex = 8;
            this.m3_input_8.Text = "8";
            this.m3_input_8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.m3_input_8.WordWrap = false;
            this.m3_input_8.MouseCaptureChanged += new System.EventHandler(this.input_Click);
            // 
            // m3_input_7
            // 
            this.m3_input_7.BackAlpha = 0;
            this.m3_input_7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.m3_input_7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.m3_input_7.Font = new System.Drawing.Font("Browallia New", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.m3_input_7.ForeColor = System.Drawing.Color.Black;
            this.m3_input_7.Location = new System.Drawing.Point(175, 154);
            this.m3_input_7.Margin = new System.Windows.Forms.Padding(4);
            this.m3_input_7.Multiline = true;
            this.m3_input_7.Name = "m3_input_7";
            this.m3_input_7.Size = new System.Drawing.Size(129, 57);
            this.m3_input_7.TabIndex = 7;
            this.m3_input_7.Text = "7";
            this.m3_input_7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.m3_input_7.WordWrap = false;
            this.m3_input_7.MouseCaptureChanged += new System.EventHandler(this.input_Click);
            // 
            // m3_input_10
            // 
            this.m3_input_10.BackAlpha = 0;
            this.m3_input_10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.m3_input_10.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.m3_input_10.Font = new System.Drawing.Font("Browallia New", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.m3_input_10.ForeColor = System.Drawing.Color.Black;
            this.m3_input_10.Location = new System.Drawing.Point(579, 268);
            this.m3_input_10.Margin = new System.Windows.Forms.Padding(4);
            this.m3_input_10.Multiline = true;
            this.m3_input_10.Name = "m3_input_10";
            this.m3_input_10.Size = new System.Drawing.Size(156, 71);
            this.m3_input_10.TabIndex = 10;
            this.m3_input_10.Text = "10";
            this.m3_input_10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.m3_input_10.WordWrap = false;
            this.m3_input_10.MouseCaptureChanged += new System.EventHandler(this.input_Click);
            // 
            // m3_input_1
            // 
            this.m3_input_1.BackAlpha = 0;
            this.m3_input_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.m3_input_1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.m3_input_1.Font = new System.Drawing.Font("Browallia New", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.m3_input_1.ForeColor = System.Drawing.Color.Black;
            this.m3_input_1.Location = new System.Drawing.Point(817, 367);
            this.m3_input_1.Margin = new System.Windows.Forms.Padding(4);
            this.m3_input_1.Multiline = true;
            this.m3_input_1.Name = "m3_input_1";
            this.m3_input_1.Size = new System.Drawing.Size(169, 76);
            this.m3_input_1.TabIndex = 1;
            this.m3_input_1.Text = "1";
            this.m3_input_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.m3_input_1.WordWrap = false;
            this.m3_input_1.MouseCaptureChanged += new System.EventHandler(this.input_Click);
            // 
            // m3_input_6
            // 
            this.m3_input_6.BackAlpha = 0;
            this.m3_input_6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.m3_input_6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.m3_input_6.Font = new System.Drawing.Font("Browallia New", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.m3_input_6.ForeColor = System.Drawing.Color.Black;
            this.m3_input_6.Location = new System.Drawing.Point(364, 356);
            this.m3_input_6.Margin = new System.Windows.Forms.Padding(4);
            this.m3_input_6.Multiline = true;
            this.m3_input_6.Name = "m3_input_6";
            this.m3_input_6.Size = new System.Drawing.Size(156, 79);
            this.m3_input_6.TabIndex = 6;
            this.m3_input_6.Text = "6";
            this.m3_input_6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.m3_input_6.WordWrap = false;
            this.m3_input_6.MouseCaptureChanged += new System.EventHandler(this.input_Click);
            // 
            // m3_label_11
            // 
            this.m3_label_11.BackColor = System.Drawing.Color.Transparent;
            this.m3_label_11.Font = new System.Drawing.Font("Browallia New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.m3_label_11.ForeColor = System.Drawing.Color.DimGray;
            this.m3_label_11.Location = new System.Drawing.Point(333, 1);
            this.m3_label_11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.m3_label_11.Name = "m3_label_11";
            this.m3_label_11.Size = new System.Drawing.Size(333, 76);
            this.m3_label_11.TabIndex = 42;
            this.m3_label_11.Text = "11. มุมมองของภาพ";
            // 
            // m3_label_8
            // 
            this.m3_label_8.BackColor = System.Drawing.Color.Transparent;
            this.m3_label_8.Font = new System.Drawing.Font("Browallia New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.m3_label_8.ForeColor = System.Drawing.Color.DimGray;
            this.m3_label_8.Location = new System.Drawing.Point(67, 379);
            this.m3_label_8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.m3_label_8.Name = "m3_label_8";
            this.m3_label_8.Size = new System.Drawing.Size(227, 85);
            this.m3_label_8.TabIndex = 41;
            this.m3_label_8.Text = "8. อารมณ์";
            // 
            // m3_label_9
            // 
            this.m3_label_9.BackColor = System.Drawing.Color.Transparent;
            this.m3_label_9.Font = new System.Drawing.Font("Browallia New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.m3_label_9.ForeColor = System.Drawing.Color.DimGray;
            this.m3_label_9.Location = new System.Drawing.Point(80, 601);
            this.m3_label_9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.m3_label_9.Name = "m3_label_9";
            this.m3_label_9.Size = new System.Drawing.Size(400, 60);
            this.m3_label_9.TabIndex = 40;
            this.m3_label_9.Text = "9. ภาพพื้นหลัง";
            // 
            // m3_label_7
            // 
            this.m3_label_7.BackColor = System.Drawing.Color.Transparent;
            this.m3_label_7.Font = new System.Drawing.Font("Browallia New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.m3_label_7.ForeColor = System.Drawing.Color.DimGray;
            this.m3_label_7.Location = new System.Drawing.Point(123, 68);
            this.m3_label_7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.m3_label_7.Name = "m3_label_7";
            this.m3_label_7.Size = new System.Drawing.Size(306, 45);
            this.m3_label_7.TabIndex = 38;
            this.m3_label_7.Text = "7. ที่ไหน";
            // 
            // m3_label_6
            // 
            this.m3_label_6.BackColor = System.Drawing.Color.Transparent;
            this.m3_label_6.Font = new System.Drawing.Font("Browallia New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.m3_label_6.ForeColor = System.Drawing.Color.DimGray;
            this.m3_label_6.Location = new System.Drawing.Point(357, 443);
            this.m3_label_6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.m3_label_6.Name = "m3_label_6";
            this.m3_label_6.Size = new System.Drawing.Size(188, 86);
            this.m3_label_6.TabIndex = 37;
            this.m3_label_6.Text = "6. การเคลื่อนไหว";
            // 
            // m3_label_12
            // 
            this.m3_label_12.BackColor = System.Drawing.Color.Transparent;
            this.m3_label_12.Font = new System.Drawing.Font("Browallia New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.m3_label_12.ForeColor = System.Drawing.Color.DimGray;
            this.m3_label_12.Location = new System.Drawing.Point(720, 1);
            this.m3_label_12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.m3_label_12.Name = "m3_label_12";
            this.m3_label_12.Size = new System.Drawing.Size(439, 48);
            this.m3_label_12.TabIndex = 36;
            this.m3_label_12.Text = "12. เสียง";
            // 
            // m3_label_10
            // 
            this.m3_label_10.BackColor = System.Drawing.Color.Transparent;
            this.m3_label_10.Font = new System.Drawing.Font("Browallia New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.m3_label_10.ForeColor = System.Drawing.Color.DimGray;
            this.m3_label_10.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.m3_label_10.Location = new System.Drawing.Point(588, 159);
            this.m3_label_10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.m3_label_10.Name = "m3_label_10";
            this.m3_label_10.Size = new System.Drawing.Size(358, 48);
            this.m3_label_10.TabIndex = 35;
            this.m3_label_10.Text = "10. เมื่อไหร่";
            // 
            // m3_label_5
            // 
            this.m3_label_5.BackColor = System.Drawing.Color.Transparent;
            this.m3_label_5.Font = new System.Drawing.Font("Browallia New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.m3_label_5.ForeColor = System.Drawing.Color.DimGray;
            this.m3_label_5.Location = new System.Drawing.Point(1029, 602);
            this.m3_label_5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.m3_label_5.Name = "m3_label_5";
            this.m3_label_5.Size = new System.Drawing.Size(282, 89);
            this.m3_label_5.TabIndex = 34;
            this.m3_label_5.Text = "5. จำนวน";
            // 
            // m3_label_4
            // 
            this.m3_label_4.BackColor = System.Drawing.Color.Transparent;
            this.m3_label_4.Font = new System.Drawing.Font("Browallia New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.m3_label_4.ForeColor = System.Drawing.Color.DimGray;
            this.m3_label_4.Location = new System.Drawing.Point(1075, 406);
            this.m3_label_4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.m3_label_4.Name = "m3_label_4";
            this.m3_label_4.Size = new System.Drawing.Size(223, 78);
            this.m3_label_4.TabIndex = 33;
            this.m3_label_4.Text = "4. รูปร่าง";
            // 
            // m3_label_3
            // 
            this.m3_label_3.BackColor = System.Drawing.Color.Transparent;
            this.m3_label_3.Font = new System.Drawing.Font("Browallia New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.m3_label_3.ForeColor = System.Drawing.Color.DimGray;
            this.m3_label_3.Location = new System.Drawing.Point(1047, 198);
            this.m3_label_3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.m3_label_3.Name = "m3_label_3";
            this.m3_label_3.Size = new System.Drawing.Size(267, 86);
            this.m3_label_3.TabIndex = 32;
            this.m3_label_3.Text = "3. ขนาด";
            // 
            // m3_label_2
            // 
            this.m3_label_2.BackColor = System.Drawing.Color.Transparent;
            this.m3_label_2.Font = new System.Drawing.Font("Browallia New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.m3_label_2.ForeColor = System.Drawing.Color.DimGray;
            this.m3_label_2.Location = new System.Drawing.Point(982, 54);
            this.m3_label_2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.m3_label_2.Name = "m3_label_2";
            this.m3_label_2.Size = new System.Drawing.Size(327, 81);
            this.m3_label_2.TabIndex = 31;
            this.m3_label_2.Text = "2. สี";
            // 
            // m3_label_1
            // 
            this.m3_label_1.BackColor = System.Drawing.Color.Transparent;
            this.m3_label_1.Font = new System.Drawing.Font("Browallia New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.m3_label_1.ForeColor = System.Drawing.Color.DimGray;
            this.m3_label_1.Location = new System.Drawing.Point(808, 212);
            this.m3_label_1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.m3_label_1.Name = "m3_label_1";
            this.m3_label_1.Size = new System.Drawing.Size(176, 86);
            this.m3_label_1.TabIndex = 30;
            this.m3_label_1.Text = "1. อะไร";
            // 
            // m3_btn_1
            // 
            this.m3_btn_1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.m3_btn_1.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.m3_btn_1.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.m3_btn_1.Appearance.Font = new System.Drawing.Font("Browallia New", 19.8F);
            this.m3_btn_1.Appearance.ForeColor = System.Drawing.Color.Transparent;
            this.m3_btn_1.Appearance.Options.UseBackColor = true;
            this.m3_btn_1.Appearance.Options.UseBorderColor = true;
            this.m3_btn_1.Appearance.Options.UseFont = true;
            this.m3_btn_1.Appearance.Options.UseForeColor = true;
            this.m3_btn_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.m3_btn_1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.m3_btn_1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.m3_btn_1.ImageOptions.Image = global::LDWordProcessor.Properties.Resources.icon_speaker;
            this.m3_btn_1.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.m3_btn_1.Location = new System.Drawing.Point(759, 212);
            this.m3_btn_1.Margin = new System.Windows.Forms.Padding(12, 9, 12, 9);
            this.m3_btn_1.Name = "m3_btn_1";
            this.m3_btn_1.Size = new System.Drawing.Size(49, 46);
            this.m3_btn_1.TabIndex = 25;
            this.m3_btn_1.Text = "อ่านคำถาม";
            this.m3_btn_1.Click += new System.EventHandler(this.btnReadQuestion_Click);
            // 
            // m3_btn_2
            // 
            this.m3_btn_2.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.m3_btn_2.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.m3_btn_2.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.m3_btn_2.Appearance.Font = new System.Drawing.Font("Browallia New", 19.8F);
            this.m3_btn_2.Appearance.ForeColor = System.Drawing.Color.Transparent;
            this.m3_btn_2.Appearance.Options.UseBackColor = true;
            this.m3_btn_2.Appearance.Options.UseBorderColor = true;
            this.m3_btn_2.Appearance.Options.UseFont = true;
            this.m3_btn_2.Appearance.Options.UseForeColor = true;
            this.m3_btn_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.m3_btn_2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.m3_btn_2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.m3_btn_2.ImageOptions.Image = global::LDWordProcessor.Properties.Resources.icon_speaker;
            this.m3_btn_2.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.m3_btn_2.Location = new System.Drawing.Point(927, 54);
            this.m3_btn_2.Margin = new System.Windows.Forms.Padding(12, 9, 12, 9);
            this.m3_btn_2.Name = "m3_btn_2";
            this.m3_btn_2.Size = new System.Drawing.Size(49, 46);
            this.m3_btn_2.TabIndex = 25;
            this.m3_btn_2.Text = "อ่านคำถาม";
            this.m3_btn_2.Click += new System.EventHandler(this.btnReadQuestion_Click);
            // 
            // m3_btn_3
            // 
            this.m3_btn_3.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.m3_btn_3.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.m3_btn_3.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.m3_btn_3.Appearance.Font = new System.Drawing.Font("Browallia New", 19.8F);
            this.m3_btn_3.Appearance.ForeColor = System.Drawing.Color.Transparent;
            this.m3_btn_3.Appearance.Options.UseBackColor = true;
            this.m3_btn_3.Appearance.Options.UseBorderColor = true;
            this.m3_btn_3.Appearance.Options.UseFont = true;
            this.m3_btn_3.Appearance.Options.UseForeColor = true;
            this.m3_btn_3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.m3_btn_3.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.m3_btn_3.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.m3_btn_3.ImageOptions.Image = global::LDWordProcessor.Properties.Resources.icon_speaker;
            this.m3_btn_3.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.m3_btn_3.Location = new System.Drawing.Point(998, 208);
            this.m3_btn_3.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.m3_btn_3.Name = "m3_btn_3";
            this.m3_btn_3.Size = new System.Drawing.Size(49, 46);
            this.m3_btn_3.TabIndex = 25;
            this.m3_btn_3.Text = "อ่านคำถาม";
            this.m3_btn_3.Click += new System.EventHandler(this.btnReadQuestion_Click);
            // 
            // m3_btn_4
            // 
            this.m3_btn_4.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.m3_btn_4.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.m3_btn_4.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.m3_btn_4.Appearance.Font = new System.Drawing.Font("Browallia New", 19.8F);
            this.m3_btn_4.Appearance.ForeColor = System.Drawing.Color.Transparent;
            this.m3_btn_4.Appearance.Options.UseBackColor = true;
            this.m3_btn_4.Appearance.Options.UseBorderColor = true;
            this.m3_btn_4.Appearance.Options.UseFont = true;
            this.m3_btn_4.Appearance.Options.UseForeColor = true;
            this.m3_btn_4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.m3_btn_4.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.m3_btn_4.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.m3_btn_4.ImageOptions.Image = global::LDWordProcessor.Properties.Resources.icon_speaker;
            this.m3_btn_4.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.m3_btn_4.Location = new System.Drawing.Point(1025, 405);
            this.m3_btn_4.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.m3_btn_4.Name = "m3_btn_4";
            this.m3_btn_4.Size = new System.Drawing.Size(49, 46);
            this.m3_btn_4.TabIndex = 25;
            this.m3_btn_4.Text = "อ่านคำถาม";
            this.m3_btn_4.Click += new System.EventHandler(this.btnReadQuestion_Click);
            // 
            // m3_btn_5
            // 
            this.m3_btn_5.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.m3_btn_5.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.m3_btn_5.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.m3_btn_5.Appearance.Font = new System.Drawing.Font("Browallia New", 19.8F);
            this.m3_btn_5.Appearance.ForeColor = System.Drawing.Color.Transparent;
            this.m3_btn_5.Appearance.Options.UseBackColor = true;
            this.m3_btn_5.Appearance.Options.UseBorderColor = true;
            this.m3_btn_5.Appearance.Options.UseFont = true;
            this.m3_btn_5.Appearance.Options.UseForeColor = true;
            this.m3_btn_5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.m3_btn_5.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.m3_btn_5.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.m3_btn_5.ImageOptions.Image = global::LDWordProcessor.Properties.Resources.icon_speaker;
            this.m3_btn_5.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.m3_btn_5.Location = new System.Drawing.Point(974, 598);
            this.m3_btn_5.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.m3_btn_5.Name = "m3_btn_5";
            this.m3_btn_5.Size = new System.Drawing.Size(49, 46);
            this.m3_btn_5.TabIndex = 25;
            this.m3_btn_5.Text = "อ่านคำถาม";
            this.m3_btn_5.Click += new System.EventHandler(this.btnReadQuestion_Click);
            // 
            // m3_btn_6
            // 
            this.m3_btn_6.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.m3_btn_6.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.m3_btn_6.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.m3_btn_6.Appearance.Font = new System.Drawing.Font("Browallia New", 19.8F);
            this.m3_btn_6.Appearance.ForeColor = System.Drawing.Color.Transparent;
            this.m3_btn_6.Appearance.Options.UseBackColor = true;
            this.m3_btn_6.Appearance.Options.UseBorderColor = true;
            this.m3_btn_6.Appearance.Options.UseFont = true;
            this.m3_btn_6.Appearance.Options.UseForeColor = true;
            this.m3_btn_6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.m3_btn_6.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.m3_btn_6.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.m3_btn_6.ImageOptions.Image = global::LDWordProcessor.Properties.Resources.icon_speaker;
            this.m3_btn_6.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.m3_btn_6.Location = new System.Drawing.Point(307, 443);
            this.m3_btn_6.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.m3_btn_6.Name = "m3_btn_6";
            this.m3_btn_6.Size = new System.Drawing.Size(49, 46);
            this.m3_btn_6.TabIndex = 25;
            this.m3_btn_6.Text = "อ่านคำถาม";
            this.m3_btn_6.Click += new System.EventHandler(this.btnReadQuestion_Click);
            // 
            // m3_btn_7
            // 
            this.m3_btn_7.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.m3_btn_7.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.m3_btn_7.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.m3_btn_7.Appearance.Font = new System.Drawing.Font("Browallia New", 19.8F);
            this.m3_btn_7.Appearance.ForeColor = System.Drawing.Color.Transparent;
            this.m3_btn_7.Appearance.Options.UseBackColor = true;
            this.m3_btn_7.Appearance.Options.UseBorderColor = true;
            this.m3_btn_7.Appearance.Options.UseFont = true;
            this.m3_btn_7.Appearance.Options.UseForeColor = true;
            this.m3_btn_7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.m3_btn_7.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.m3_btn_7.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.m3_btn_7.ImageOptions.Image = global::LDWordProcessor.Properties.Resources.icon_speaker;
            this.m3_btn_7.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.m3_btn_7.Location = new System.Drawing.Point(73, 62);
            this.m3_btn_7.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.m3_btn_7.Name = "m3_btn_7";
            this.m3_btn_7.Size = new System.Drawing.Size(49, 46);
            this.m3_btn_7.TabIndex = 25;
            this.m3_btn_7.Text = "อ่านคำถาม";
            this.m3_btn_7.Click += new System.EventHandler(this.btnReadQuestion_Click);
            // 
            // m3_btn_8
            // 
            this.m3_btn_8.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.m3_btn_8.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.m3_btn_8.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.m3_btn_8.Appearance.Font = new System.Drawing.Font("Browallia New", 19.8F);
            this.m3_btn_8.Appearance.ForeColor = System.Drawing.Color.Transparent;
            this.m3_btn_8.Appearance.Options.UseBackColor = true;
            this.m3_btn_8.Appearance.Options.UseBorderColor = true;
            this.m3_btn_8.Appearance.Options.UseFont = true;
            this.m3_btn_8.Appearance.Options.UseForeColor = true;
            this.m3_btn_8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.m3_btn_8.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.m3_btn_8.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.m3_btn_8.ImageOptions.Image = global::LDWordProcessor.Properties.Resources.icon_speaker;
            this.m3_btn_8.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.m3_btn_8.Location = new System.Drawing.Point(17, 376);
            this.m3_btn_8.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.m3_btn_8.Name = "m3_btn_8";
            this.m3_btn_8.Size = new System.Drawing.Size(49, 46);
            this.m3_btn_8.TabIndex = 25;
            this.m3_btn_8.Text = "อ่านคำถาม";
            this.m3_btn_8.Click += new System.EventHandler(this.btnReadQuestion_Click);
            // 
            // m3_btn_9
            // 
            this.m3_btn_9.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.m3_btn_9.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.m3_btn_9.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.m3_btn_9.Appearance.Font = new System.Drawing.Font("Browallia New", 19.8F);
            this.m3_btn_9.Appearance.ForeColor = System.Drawing.Color.Transparent;
            this.m3_btn_9.Appearance.Options.UseBackColor = true;
            this.m3_btn_9.Appearance.Options.UseBorderColor = true;
            this.m3_btn_9.Appearance.Options.UseFont = true;
            this.m3_btn_9.Appearance.Options.UseForeColor = true;
            this.m3_btn_9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.m3_btn_9.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.m3_btn_9.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.m3_btn_9.ImageOptions.Image = global::LDWordProcessor.Properties.Resources.icon_speaker;
            this.m3_btn_9.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.m3_btn_9.Location = new System.Drawing.Point(31, 598);
            this.m3_btn_9.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.m3_btn_9.Name = "m3_btn_9";
            this.m3_btn_9.Size = new System.Drawing.Size(49, 46);
            this.m3_btn_9.TabIndex = 25;
            this.m3_btn_9.Text = "อ่านคำถาม";
            this.m3_btn_9.Click += new System.EventHandler(this.btnReadQuestion_Click);
            // 
            // m3_btn_10
            // 
            this.m3_btn_10.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.m3_btn_10.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.m3_btn_10.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.m3_btn_10.Appearance.Font = new System.Drawing.Font("Browallia New", 19.8F);
            this.m3_btn_10.Appearance.ForeColor = System.Drawing.Color.Transparent;
            this.m3_btn_10.Appearance.Options.UseBackColor = true;
            this.m3_btn_10.Appearance.Options.UseBorderColor = true;
            this.m3_btn_10.Appearance.Options.UseFont = true;
            this.m3_btn_10.Appearance.Options.UseForeColor = true;
            this.m3_btn_10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.m3_btn_10.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.m3_btn_10.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.m3_btn_10.ImageOptions.Image = global::LDWordProcessor.Properties.Resources.icon_speaker;
            this.m3_btn_10.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.m3_btn_10.Location = new System.Drawing.Point(539, 156);
            this.m3_btn_10.Margin = new System.Windows.Forms.Padding(12, 9, 12, 9);
            this.m3_btn_10.Name = "m3_btn_10";
            this.m3_btn_10.Size = new System.Drawing.Size(49, 46);
            this.m3_btn_10.TabIndex = 25;
            this.m3_btn_10.Text = "อ่านคำถาม";
            this.m3_btn_10.Click += new System.EventHandler(this.btnReadQuestion_Click);
            // 
            // m3_btn_11
            // 
            this.m3_btn_11.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.m3_btn_11.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.m3_btn_11.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.m3_btn_11.Appearance.Font = new System.Drawing.Font("Browallia New", 19.8F);
            this.m3_btn_11.Appearance.ForeColor = System.Drawing.Color.Transparent;
            this.m3_btn_11.Appearance.Options.UseBackColor = true;
            this.m3_btn_11.Appearance.Options.UseBorderColor = true;
            this.m3_btn_11.Appearance.Options.UseFont = true;
            this.m3_btn_11.Appearance.Options.UseForeColor = true;
            this.m3_btn_11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.m3_btn_11.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.m3_btn_11.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.m3_btn_11.ImageOptions.Image = global::LDWordProcessor.Properties.Resources.icon_speaker;
            this.m3_btn_11.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.m3_btn_11.Location = new System.Drawing.Point(284, 1);
            this.m3_btn_11.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.m3_btn_11.Name = "m3_btn_11";
            this.m3_btn_11.Size = new System.Drawing.Size(49, 46);
            this.m3_btn_11.TabIndex = 25;
            this.m3_btn_11.Text = "อ่านคำถาม";
            this.m3_btn_11.Click += new System.EventHandler(this.btnReadQuestion_Click);
            // 
            // m3_btn_12
            // 
            this.m3_btn_12.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.m3_btn_12.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.m3_btn_12.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.m3_btn_12.Appearance.Font = new System.Drawing.Font("Browallia New", 19.8F);
            this.m3_btn_12.Appearance.ForeColor = System.Drawing.Color.Transparent;
            this.m3_btn_12.Appearance.Options.UseBackColor = true;
            this.m3_btn_12.Appearance.Options.UseBorderColor = true;
            this.m3_btn_12.Appearance.Options.UseFont = true;
            this.m3_btn_12.Appearance.Options.UseForeColor = true;
            this.m3_btn_12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.m3_btn_12.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.m3_btn_12.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.m3_btn_12.ImageOptions.Image = global::LDWordProcessor.Properties.Resources.icon_speaker;
            this.m3_btn_12.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.m3_btn_12.Location = new System.Drawing.Point(667, 1);
            this.m3_btn_12.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.m3_btn_12.Name = "m3_btn_12";
            this.m3_btn_12.Size = new System.Drawing.Size(49, 46);
            this.m3_btn_12.TabIndex = 25;
            this.m3_btn_12.Text = "อ่านคำถาม";
            this.m3_btn_12.Click += new System.EventHandler(this.btnReadQuestion_Click);
            // 
            // map3_photo
            // 
            this.map3_photo.BackColor = System.Drawing.Color.Transparent;
            this.map3_photo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.map3_photo.Controls.Add(this.m3_input_title);
            this.map3_photo.Font = new System.Drawing.Font("Browallia New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.map3_photo.Location = new System.Drawing.Point(543, 415);
            this.map3_photo.Margin = new System.Windows.Forms.Padding(4);
            this.map3_photo.Name = "map3_photo";
            this.map3_photo.Size = new System.Drawing.Size(225, 170);
            this.map3_photo.TabIndex = 0;
            this.map3_photo.Click += new System.EventHandler(this.mapPhoto_Click);
            // 
            // m3_input_title
            // 
            this.m3_input_title.BackAlpha = 0;
            this.m3_input_title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.m3_input_title.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.m3_input_title.Font = new System.Drawing.Font("Browallia New", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m3_input_title.Location = new System.Drawing.Point(23, 17);
            this.m3_input_title.Margin = new System.Windows.Forms.Padding(4);
            this.m3_input_title.Multiline = true;
            this.m3_input_title.Name = "m3_input_title";
            this.m3_input_title.ReadOnly = true;
            this.m3_input_title.Size = new System.Drawing.Size(179, 107);
            this.m3_input_title.TabIndex = 0;
            this.m3_input_title.Text = "ชื่อเรื่อง";
            this.m3_input_title.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.m3_input_title.MouseCaptureChanged += new System.EventHandler(this.input_Click);
            // 
            // pnMainMindmap2
            // 
            this.pnMainMindmap2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnMainMindmap2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnMainMindmap2.BackgroundImage")));
            this.pnMainMindmap2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnMainMindmap2.Controls.Add(this.m2_label_rp_12);
            this.pnMainMindmap2.Controls.Add(this.m2_label_rp_11);
            this.pnMainMindmap2.Controls.Add(this.m2_label_rp_10);
            this.pnMainMindmap2.Controls.Add(this.m2_label_rp_9);
            this.pnMainMindmap2.Controls.Add(this.m2_label_rp_8);
            this.pnMainMindmap2.Controls.Add(this.m2_label_rp_7);
            this.pnMainMindmap2.Controls.Add(this.m2_label_rp_6);
            this.pnMainMindmap2.Controls.Add(this.m2_label_rp_5);
            this.pnMainMindmap2.Controls.Add(this.m2_label_rp_4);
            this.pnMainMindmap2.Controls.Add(this.m2_label_rp_3);
            this.pnMainMindmap2.Controls.Add(this.m2_label_rp_2);
            this.pnMainMindmap2.Controls.Add(this.m2_label_rp_1);
            this.pnMainMindmap2.Controls.Add(this.m2_input_5);
            this.pnMainMindmap2.Controls.Add(this.m2_input_4);
            this.pnMainMindmap2.Controls.Add(this.m2_input_3);
            this.pnMainMindmap2.Controls.Add(this.m2_input_2);
            this.pnMainMindmap2.Controls.Add(this.m2_input_12);
            this.pnMainMindmap2.Controls.Add(this.m2_input_9);
            this.pnMainMindmap2.Controls.Add(this.m2_input_11);
            this.pnMainMindmap2.Controls.Add(this.m2_input_8);
            this.pnMainMindmap2.Controls.Add(this.m2_input_7);
            this.pnMainMindmap2.Controls.Add(this.m2_input_10);
            this.pnMainMindmap2.Controls.Add(this.m2_input_1);
            this.pnMainMindmap2.Controls.Add(this.m2_input_6);
            this.pnMainMindmap2.Controls.Add(this.m2_label_11);
            this.pnMainMindmap2.Controls.Add(this.m2_label_8);
            this.pnMainMindmap2.Controls.Add(this.m2_label_9);
            this.pnMainMindmap2.Controls.Add(this.m2_label_7);
            this.pnMainMindmap2.Controls.Add(this.m2_label_6);
            this.pnMainMindmap2.Controls.Add(this.m2_label_12);
            this.pnMainMindmap2.Controls.Add(this.m2_label_10);
            this.pnMainMindmap2.Controls.Add(this.m2_label_5);
            this.pnMainMindmap2.Controls.Add(this.m2_label_4);
            this.pnMainMindmap2.Controls.Add(this.m2_label_3);
            this.pnMainMindmap2.Controls.Add(this.m2_label_2);
            this.pnMainMindmap2.Controls.Add(this.m2_label_1);
            this.pnMainMindmap2.Controls.Add(this.m2_btn_1);
            this.pnMainMindmap2.Controls.Add(this.m2_btn_2);
            this.pnMainMindmap2.Controls.Add(this.m2_btn_3);
            this.pnMainMindmap2.Controls.Add(this.m2_btn_4);
            this.pnMainMindmap2.Controls.Add(this.m2_btn_5);
            this.pnMainMindmap2.Controls.Add(this.m2_btn_6);
            this.pnMainMindmap2.Controls.Add(this.m2_btn_7);
            this.pnMainMindmap2.Controls.Add(this.m2_btn_8);
            this.pnMainMindmap2.Controls.Add(this.m2_btn_9);
            this.pnMainMindmap2.Controls.Add(this.m2_btn_10);
            this.pnMainMindmap2.Controls.Add(this.m2_btn_11);
            this.pnMainMindmap2.Controls.Add(this.m2_btn_12);
            this.pnMainMindmap2.Controls.Add(this.map2_photo);
            this.pnMainMindmap2.Location = new System.Drawing.Point(1, 2);
            this.pnMainMindmap2.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.pnMainMindmap2.Name = "pnMainMindmap2";
            this.pnMainMindmap2.Size = new System.Drawing.Size(1319, 700);
            this.pnMainMindmap2.TabIndex = 3;
            // 
            // m2_label_rp_12
            // 
            this.m2_label_rp_12.BackColor = System.Drawing.Color.Transparent;
            this.m2_label_rp_12.Font = new System.Drawing.Font("Browallia New", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m2_label_rp_12.ForeColor = System.Drawing.Color.Black;
            this.m2_label_rp_12.Location = new System.Drawing.Point(231, 572);
            this.m2_label_rp_12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.m2_label_rp_12.Name = "m2_label_rp_12";
            this.m2_label_rp_12.Size = new System.Drawing.Size(181, 23);
            this.m2_label_rp_12.TabIndex = 43;
            this.m2_label_rp_12.Text = "12";
            this.m2_label_rp_12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.m2_label_rp_12.UseCompatibleTextRendering = true;
            // 
            // m2_label_rp_11
            // 
            this.m2_label_rp_11.BackColor = System.Drawing.Color.Transparent;
            this.m2_label_rp_11.Font = new System.Drawing.Font("Browallia New", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m2_label_rp_11.ForeColor = System.Drawing.Color.Black;
            this.m2_label_rp_11.Location = new System.Drawing.Point(112, 389);
            this.m2_label_rp_11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.m2_label_rp_11.Name = "m2_label_rp_11";
            this.m2_label_rp_11.Size = new System.Drawing.Size(181, 23);
            this.m2_label_rp_11.TabIndex = 43;
            this.m2_label_rp_11.Text = "11";
            this.m2_label_rp_11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.m2_label_rp_11.UseCompatibleTextRendering = true;
            // 
            // m2_label_rp_10
            // 
            this.m2_label_rp_10.BackColor = System.Drawing.Color.Transparent;
            this.m2_label_rp_10.Font = new System.Drawing.Font("Browallia New", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m2_label_rp_10.ForeColor = System.Drawing.Color.Black;
            this.m2_label_rp_10.Location = new System.Drawing.Point(359, 391);
            this.m2_label_rp_10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.m2_label_rp_10.Name = "m2_label_rp_10";
            this.m2_label_rp_10.Size = new System.Drawing.Size(181, 23);
            this.m2_label_rp_10.TabIndex = 43;
            this.m2_label_rp_10.Text = "10";
            this.m2_label_rp_10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.m2_label_rp_10.UseCompatibleTextRendering = true;
            // 
            // m2_label_rp_9
            // 
            this.m2_label_rp_9.BackColor = System.Drawing.Color.Transparent;
            this.m2_label_rp_9.Font = new System.Drawing.Font("Browallia New", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m2_label_rp_9.ForeColor = System.Drawing.Color.Black;
            this.m2_label_rp_9.Location = new System.Drawing.Point(484, 57);
            this.m2_label_rp_9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.m2_label_rp_9.Name = "m2_label_rp_9";
            this.m2_label_rp_9.Size = new System.Drawing.Size(181, 23);
            this.m2_label_rp_9.TabIndex = 43;
            this.m2_label_rp_9.Text = "9";
            this.m2_label_rp_9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.m2_label_rp_9.UseCompatibleTextRendering = true;
            // 
            // m2_label_rp_8
            // 
            this.m2_label_rp_8.BackColor = System.Drawing.Color.Transparent;
            this.m2_label_rp_8.Font = new System.Drawing.Font("Browallia New", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m2_label_rp_8.ForeColor = System.Drawing.Color.Black;
            this.m2_label_rp_8.Location = new System.Drawing.Point(139, 60);
            this.m2_label_rp_8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.m2_label_rp_8.Name = "m2_label_rp_8";
            this.m2_label_rp_8.Size = new System.Drawing.Size(181, 23);
            this.m2_label_rp_8.TabIndex = 43;
            this.m2_label_rp_8.Text = "8";
            this.m2_label_rp_8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.m2_label_rp_8.UseCompatibleTextRendering = true;
            // 
            // m2_label_rp_7
            // 
            this.m2_label_rp_7.BackColor = System.Drawing.Color.Transparent;
            this.m2_label_rp_7.Font = new System.Drawing.Font("Browallia New", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m2_label_rp_7.ForeColor = System.Drawing.Color.Black;
            this.m2_label_rp_7.Location = new System.Drawing.Point(121, 203);
            this.m2_label_rp_7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.m2_label_rp_7.Name = "m2_label_rp_7";
            this.m2_label_rp_7.Size = new System.Drawing.Size(181, 23);
            this.m2_label_rp_7.TabIndex = 43;
            this.m2_label_rp_7.Text = "7";
            this.m2_label_rp_7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.m2_label_rp_7.UseCompatibleTextRendering = true;
            // 
            // m2_label_rp_6
            // 
            this.m2_label_rp_6.BackColor = System.Drawing.Color.Transparent;
            this.m2_label_rp_6.Font = new System.Drawing.Font("Browallia New", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m2_label_rp_6.ForeColor = System.Drawing.Color.Black;
            this.m2_label_rp_6.Location = new System.Drawing.Point(351, 212);
            this.m2_label_rp_6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.m2_label_rp_6.Name = "m2_label_rp_6";
            this.m2_label_rp_6.Size = new System.Drawing.Size(181, 23);
            this.m2_label_rp_6.TabIndex = 43;
            this.m2_label_rp_6.Text = "6";
            this.m2_label_rp_6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.m2_label_rp_6.UseCompatibleTextRendering = true;
            // 
            // m2_label_rp_5
            // 
            this.m2_label_rp_5.BackColor = System.Drawing.Color.Transparent;
            this.m2_label_rp_5.Font = new System.Drawing.Font("Browallia New", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m2_label_rp_5.ForeColor = System.Drawing.Color.Black;
            this.m2_label_rp_5.Location = new System.Drawing.Point(845, 497);
            this.m2_label_rp_5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.m2_label_rp_5.Name = "m2_label_rp_5";
            this.m2_label_rp_5.Size = new System.Drawing.Size(181, 23);
            this.m2_label_rp_5.TabIndex = 43;
            this.m2_label_rp_5.Text = "5";
            this.m2_label_rp_5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.m2_label_rp_5.UseCompatibleTextRendering = true;
            // 
            // m2_label_rp_4
            // 
            this.m2_label_rp_4.BackColor = System.Drawing.Color.Transparent;
            this.m2_label_rp_4.Font = new System.Drawing.Font("Browallia New", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m2_label_rp_4.ForeColor = System.Drawing.Color.Black;
            this.m2_label_rp_4.Location = new System.Drawing.Point(1064, 449);
            this.m2_label_rp_4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.m2_label_rp_4.Name = "m2_label_rp_4";
            this.m2_label_rp_4.Size = new System.Drawing.Size(181, 23);
            this.m2_label_rp_4.TabIndex = 43;
            this.m2_label_rp_4.Text = "4";
            this.m2_label_rp_4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.m2_label_rp_4.UseCompatibleTextRendering = true;
            // 
            // m2_label_rp_3
            // 
            this.m2_label_rp_3.BackColor = System.Drawing.Color.Transparent;
            this.m2_label_rp_3.Font = new System.Drawing.Font("Browallia New", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m2_label_rp_3.ForeColor = System.Drawing.Color.Black;
            this.m2_label_rp_3.Location = new System.Drawing.Point(1065, 129);
            this.m2_label_rp_3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.m2_label_rp_3.Name = "m2_label_rp_3";
            this.m2_label_rp_3.Size = new System.Drawing.Size(181, 23);
            this.m2_label_rp_3.TabIndex = 43;
            this.m2_label_rp_3.Text = "3";
            this.m2_label_rp_3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.m2_label_rp_3.UseCompatibleTextRendering = true;
            // 
            // m2_label_rp_2
            // 
            this.m2_label_rp_2.BackColor = System.Drawing.Color.Transparent;
            this.m2_label_rp_2.Font = new System.Drawing.Font("Browallia New", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m2_label_rp_2.ForeColor = System.Drawing.Color.Black;
            this.m2_label_rp_2.Location = new System.Drawing.Point(825, 89);
            this.m2_label_rp_2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.m2_label_rp_2.Name = "m2_label_rp_2";
            this.m2_label_rp_2.Size = new System.Drawing.Size(181, 23);
            this.m2_label_rp_2.TabIndex = 43;
            this.m2_label_rp_2.Text = "2";
            this.m2_label_rp_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.m2_label_rp_2.UseCompatibleTextRendering = true;
            // 
            // m2_label_rp_1
            // 
            this.m2_label_rp_1.BackColor = System.Drawing.Color.Transparent;
            this.m2_label_rp_1.Font = new System.Drawing.Font("Browallia New", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m2_label_rp_1.ForeColor = System.Drawing.Color.Black;
            this.m2_label_rp_1.Location = new System.Drawing.Point(909, 288);
            this.m2_label_rp_1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.m2_label_rp_1.Name = "m2_label_rp_1";
            this.m2_label_rp_1.Size = new System.Drawing.Size(181, 23);
            this.m2_label_rp_1.TabIndex = 43;
            this.m2_label_rp_1.Text = "1";
            this.m2_label_rp_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.m2_label_rp_1.UseCompatibleTextRendering = true;
            // 
            // m2_input_5
            // 
            this.m2_input_5.BackAlpha = 0;
            this.m2_input_5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.m2_input_5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.m2_input_5.Font = new System.Drawing.Font("Browallia New", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.m2_input_5.ForeColor = System.Drawing.Color.Black;
            this.m2_input_5.Location = new System.Drawing.Point(857, 523);
            this.m2_input_5.Margin = new System.Windows.Forms.Padding(4);
            this.m2_input_5.Name = "m2_input_5";
            this.m2_input_5.Size = new System.Drawing.Size(159, 34);
            this.m2_input_5.TabIndex = 5;
            this.m2_input_5.Text = "5";
            this.m2_input_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.m2_input_5.WordWrap = false;
            this.m2_input_5.MouseCaptureChanged += new System.EventHandler(this.input_Click);
            // 
            // m2_input_4
            // 
            this.m2_input_4.BackAlpha = 0;
            this.m2_input_4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.m2_input_4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.m2_input_4.Font = new System.Drawing.Font("Browallia New", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.m2_input_4.ForeColor = System.Drawing.Color.Black;
            this.m2_input_4.Location = new System.Drawing.Point(1072, 474);
            this.m2_input_4.Margin = new System.Windows.Forms.Padding(4);
            this.m2_input_4.Name = "m2_input_4";
            this.m2_input_4.Size = new System.Drawing.Size(167, 34);
            this.m2_input_4.TabIndex = 4;
            this.m2_input_4.Text = "4";
            this.m2_input_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.m2_input_4.WordWrap = false;
            this.m2_input_4.MouseCaptureChanged += new System.EventHandler(this.input_Click);
            // 
            // m2_input_3
            // 
            this.m2_input_3.BackAlpha = 0;
            this.m2_input_3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.m2_input_3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.m2_input_3.Font = new System.Drawing.Font("Browallia New", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.m2_input_3.ForeColor = System.Drawing.Color.Black;
            this.m2_input_3.Location = new System.Drawing.Point(1077, 153);
            this.m2_input_3.Margin = new System.Windows.Forms.Padding(4);
            this.m2_input_3.Name = "m2_input_3";
            this.m2_input_3.Size = new System.Drawing.Size(160, 34);
            this.m2_input_3.TabIndex = 3;
            this.m2_input_3.Text = "3";
            this.m2_input_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.m2_input_3.WordWrap = false;
            this.m2_input_3.MouseCaptureChanged += new System.EventHandler(this.input_Click);
            // 
            // m2_input_2
            // 
            this.m2_input_2.BackAlpha = 0;
            this.m2_input_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.m2_input_2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.m2_input_2.Font = new System.Drawing.Font("Browallia New", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.m2_input_2.ForeColor = System.Drawing.Color.Black;
            this.m2_input_2.Location = new System.Drawing.Point(833, 113);
            this.m2_input_2.Margin = new System.Windows.Forms.Padding(4);
            this.m2_input_2.Name = "m2_input_2";
            this.m2_input_2.Size = new System.Drawing.Size(167, 34);
            this.m2_input_2.TabIndex = 2;
            this.m2_input_2.Text = "2";
            this.m2_input_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.m2_input_2.WordWrap = false;
            this.m2_input_2.MouseCaptureChanged += new System.EventHandler(this.input_Click);
            // 
            // m2_input_12
            // 
            this.m2_input_12.BackAlpha = 0;
            this.m2_input_12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.m2_input_12.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.m2_input_12.Font = new System.Drawing.Font("Browallia New", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.m2_input_12.ForeColor = System.Drawing.Color.Black;
            this.m2_input_12.Location = new System.Drawing.Point(243, 597);
            this.m2_input_12.Margin = new System.Windows.Forms.Padding(4);
            this.m2_input_12.Name = "m2_input_12";
            this.m2_input_12.Size = new System.Drawing.Size(156, 34);
            this.m2_input_12.TabIndex = 12;
            this.m2_input_12.Text = "12";
            this.m2_input_12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.m2_input_12.WordWrap = false;
            this.m2_input_12.MouseCaptureChanged += new System.EventHandler(this.input_Click);
            // 
            // m2_input_9
            // 
            this.m2_input_9.BackAlpha = 0;
            this.m2_input_9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.m2_input_9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.m2_input_9.Font = new System.Drawing.Font("Browallia New", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.m2_input_9.ForeColor = System.Drawing.Color.Black;
            this.m2_input_9.Location = new System.Drawing.Point(492, 81);
            this.m2_input_9.Margin = new System.Windows.Forms.Padding(4);
            this.m2_input_9.Name = "m2_input_9";
            this.m2_input_9.Size = new System.Drawing.Size(168, 34);
            this.m2_input_9.TabIndex = 9;
            this.m2_input_9.Text = "9";
            this.m2_input_9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.m2_input_9.WordWrap = false;
            this.m2_input_9.MouseCaptureChanged += new System.EventHandler(this.input_Click);
            // 
            // m2_input_11
            // 
            this.m2_input_11.BackAlpha = 0;
            this.m2_input_11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.m2_input_11.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.m2_input_11.Font = new System.Drawing.Font("Browallia New", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.m2_input_11.ForeColor = System.Drawing.Color.Black;
            this.m2_input_11.Location = new System.Drawing.Point(121, 412);
            this.m2_input_11.Margin = new System.Windows.Forms.Padding(4);
            this.m2_input_11.Name = "m2_input_11";
            this.m2_input_11.Size = new System.Drawing.Size(164, 34);
            this.m2_input_11.TabIndex = 11;
            this.m2_input_11.Text = "11";
            this.m2_input_11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.m2_input_11.WordWrap = false;
            this.m2_input_11.MouseCaptureChanged += new System.EventHandler(this.input_Click);
            // 
            // m2_input_8
            // 
            this.m2_input_8.BackAlpha = 0;
            this.m2_input_8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.m2_input_8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.m2_input_8.Font = new System.Drawing.Font("Browallia New", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.m2_input_8.ForeColor = System.Drawing.Color.Black;
            this.m2_input_8.Location = new System.Drawing.Point(151, 84);
            this.m2_input_8.Margin = new System.Windows.Forms.Padding(4);
            this.m2_input_8.Name = "m2_input_8";
            this.m2_input_8.Size = new System.Drawing.Size(161, 34);
            this.m2_input_8.TabIndex = 8;
            this.m2_input_8.Text = "8";
            this.m2_input_8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.m2_input_8.WordWrap = false;
            this.m2_input_8.MouseCaptureChanged += new System.EventHandler(this.input_Click);
            // 
            // m2_input_7
            // 
            this.m2_input_7.BackAlpha = 0;
            this.m2_input_7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.m2_input_7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.m2_input_7.Font = new System.Drawing.Font("Browallia New", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.m2_input_7.ForeColor = System.Drawing.Color.Black;
            this.m2_input_7.Location = new System.Drawing.Point(129, 224);
            this.m2_input_7.Margin = new System.Windows.Forms.Padding(4);
            this.m2_input_7.Name = "m2_input_7";
            this.m2_input_7.Size = new System.Drawing.Size(167, 34);
            this.m2_input_7.TabIndex = 7;
            this.m2_input_7.Text = "7";
            this.m2_input_7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.m2_input_7.WordWrap = false;
            this.m2_input_7.MouseCaptureChanged += new System.EventHandler(this.input_Click);
            // 
            // m2_input_10
            // 
            this.m2_input_10.BackAlpha = 0;
            this.m2_input_10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.m2_input_10.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.m2_input_10.Font = new System.Drawing.Font("Browallia New", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.m2_input_10.ForeColor = System.Drawing.Color.Black;
            this.m2_input_10.Location = new System.Drawing.Point(364, 416);
            this.m2_input_10.Margin = new System.Windows.Forms.Padding(4);
            this.m2_input_10.Name = "m2_input_10";
            this.m2_input_10.Size = new System.Drawing.Size(173, 34);
            this.m2_input_10.TabIndex = 10;
            this.m2_input_10.Text = "10";
            this.m2_input_10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.m2_input_10.WordWrap = false;
            this.m2_input_10.MouseCaptureChanged += new System.EventHandler(this.input_Click);
            // 
            // m2_input_1
            // 
            this.m2_input_1.BackAlpha = 0;
            this.m2_input_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.m2_input_1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.m2_input_1.Font = new System.Drawing.Font("Browallia New", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.m2_input_1.ForeColor = System.Drawing.Color.Black;
            this.m2_input_1.Location = new System.Drawing.Point(921, 316);
            this.m2_input_1.Margin = new System.Windows.Forms.Padding(4);
            this.m2_input_1.Name = "m2_input_1";
            this.m2_input_1.Size = new System.Drawing.Size(156, 34);
            this.m2_input_1.TabIndex = 1;
            this.m2_input_1.Text = "1";
            this.m2_input_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.m2_input_1.WordWrap = false;
            this.m2_input_1.MouseCaptureChanged += new System.EventHandler(this.input_Click);
            // 
            // m2_input_6
            // 
            this.m2_input_6.BackAlpha = 0;
            this.m2_input_6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.m2_input_6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.m2_input_6.Font = new System.Drawing.Font("Browallia New", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.m2_input_6.ForeColor = System.Drawing.Color.Black;
            this.m2_input_6.Location = new System.Drawing.Point(363, 234);
            this.m2_input_6.Margin = new System.Windows.Forms.Padding(4);
            this.m2_input_6.Name = "m2_input_6";
            this.m2_input_6.Size = new System.Drawing.Size(156, 34);
            this.m2_input_6.TabIndex = 6;
            this.m2_input_6.Text = "6";
            this.m2_input_6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.m2_input_6.WordWrap = false;
            this.m2_input_6.MouseCaptureChanged += new System.EventHandler(this.input_Click);
            // 
            // m2_label_11
            // 
            this.m2_label_11.BackColor = System.Drawing.Color.Transparent;
            this.m2_label_11.Font = new System.Drawing.Font("Browallia New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.m2_label_11.ForeColor = System.Drawing.Color.DimGray;
            this.m2_label_11.Location = new System.Drawing.Point(87, 464);
            this.m2_label_11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.m2_label_11.Name = "m2_label_11";
            this.m2_label_11.Size = new System.Drawing.Size(292, 86);
            this.m2_label_11.TabIndex = 42;
            this.m2_label_11.Text = "11. มุมมองของภาพ";
            // 
            // m2_label_8
            // 
            this.m2_label_8.BackColor = System.Drawing.Color.Transparent;
            this.m2_label_8.Font = new System.Drawing.Font("Browallia New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.m2_label_8.ForeColor = System.Drawing.Color.DimGray;
            this.m2_label_8.Location = new System.Drawing.Point(128, 7);
            this.m2_label_8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.m2_label_8.Name = "m2_label_8";
            this.m2_label_8.Size = new System.Drawing.Size(373, 50);
            this.m2_label_8.TabIndex = 41;
            this.m2_label_8.Text = "8. อารมณ์";
            // 
            // m2_label_9
            // 
            this.m2_label_9.BackColor = System.Drawing.Color.Transparent;
            this.m2_label_9.Font = new System.Drawing.Font("Browallia New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.m2_label_9.ForeColor = System.Drawing.Color.DimGray;
            this.m2_label_9.Location = new System.Drawing.Point(547, 129);
            this.m2_label_9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.m2_label_9.Name = "m2_label_9";
            this.m2_label_9.Size = new System.Drawing.Size(267, 86);
            this.m2_label_9.TabIndex = 40;
            this.m2_label_9.Text = "9. ภาพพื้นหลัง";
            // 
            // m2_label_7
            // 
            this.m2_label_7.BackColor = System.Drawing.Color.Transparent;
            this.m2_label_7.Font = new System.Drawing.Font("Browallia New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.m2_label_7.ForeColor = System.Drawing.Color.DimGray;
            this.m2_label_7.Location = new System.Drawing.Point(115, 277);
            this.m2_label_7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.m2_label_7.Name = "m2_label_7";
            this.m2_label_7.Size = new System.Drawing.Size(213, 86);
            this.m2_label_7.TabIndex = 38;
            this.m2_label_7.Text = "7. ที่ไหน";
            // 
            // m2_label_6
            // 
            this.m2_label_6.BackColor = System.Drawing.Color.Transparent;
            this.m2_label_6.Font = new System.Drawing.Font("Browallia New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.m2_label_6.ForeColor = System.Drawing.Color.DimGray;
            this.m2_label_6.Location = new System.Drawing.Point(416, 283);
            this.m2_label_6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.m2_label_6.Name = "m2_label_6";
            this.m2_label_6.Size = new System.Drawing.Size(182, 86);
            this.m2_label_6.TabIndex = 37;
            this.m2_label_6.Text = "6. การเคลื่อนไหว";
            // 
            // m2_label_12
            // 
            this.m2_label_12.BackColor = System.Drawing.Color.Transparent;
            this.m2_label_12.Font = new System.Drawing.Font("Browallia New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.m2_label_12.ForeColor = System.Drawing.Color.DimGray;
            this.m2_label_12.Location = new System.Drawing.Point(460, 586);
            this.m2_label_12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.m2_label_12.Name = "m2_label_12";
            this.m2_label_12.Size = new System.Drawing.Size(253, 95);
            this.m2_label_12.TabIndex = 36;
            this.m2_label_12.Text = "12. เสียง";
            // 
            // m2_label_10
            // 
            this.m2_label_10.BackColor = System.Drawing.Color.Transparent;
            this.m2_label_10.Font = new System.Drawing.Font("Browallia New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.m2_label_10.ForeColor = System.Drawing.Color.DimGray;
            this.m2_label_10.Location = new System.Drawing.Point(565, 449);
            this.m2_label_10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.m2_label_10.Name = "m2_label_10";
            this.m2_label_10.Size = new System.Drawing.Size(240, 87);
            this.m2_label_10.TabIndex = 35;
            this.m2_label_10.Text = "10. เมื่อไหร่";
            // 
            // m2_label_5
            // 
            this.m2_label_5.BackColor = System.Drawing.Color.Transparent;
            this.m2_label_5.Font = new System.Drawing.Font("Browallia New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.m2_label_5.ForeColor = System.Drawing.Color.DimGray;
            this.m2_label_5.Location = new System.Drawing.Point(824, 572);
            this.m2_label_5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.m2_label_5.Name = "m2_label_5";
            this.m2_label_5.Size = new System.Drawing.Size(240, 97);
            this.m2_label_5.TabIndex = 34;
            this.m2_label_5.Text = "5. จำนวน";
            // 
            // m2_label_4
            // 
            this.m2_label_4.BackColor = System.Drawing.Color.Transparent;
            this.m2_label_4.Font = new System.Drawing.Font("Browallia New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.m2_label_4.ForeColor = System.Drawing.Color.DimGray;
            this.m2_label_4.Location = new System.Drawing.Point(1107, 533);
            this.m2_label_4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.m2_label_4.Name = "m2_label_4";
            this.m2_label_4.Size = new System.Drawing.Size(208, 119);
            this.m2_label_4.TabIndex = 33;
            this.m2_label_4.Text = "4. รูปร่าง";
            // 
            // m2_label_3
            // 
            this.m2_label_3.BackColor = System.Drawing.Color.Transparent;
            this.m2_label_3.Font = new System.Drawing.Font("Browallia New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.m2_label_3.ForeColor = System.Drawing.Color.DimGray;
            this.m2_label_3.Location = new System.Drawing.Point(1096, 46);
            this.m2_label_3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.m2_label_3.Name = "m2_label_3";
            this.m2_label_3.Size = new System.Drawing.Size(219, 83);
            this.m2_label_3.TabIndex = 32;
            this.m2_label_3.Text = "3. ขนาด";
            // 
            // m2_label_2
            // 
            this.m2_label_2.BackColor = System.Drawing.Color.Transparent;
            this.m2_label_2.Font = new System.Drawing.Font("Browallia New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.m2_label_2.ForeColor = System.Drawing.Color.DimGray;
            this.m2_label_2.Location = new System.Drawing.Point(793, 15);
            this.m2_label_2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.m2_label_2.Name = "m2_label_2";
            this.m2_label_2.Size = new System.Drawing.Size(248, 77);
            this.m2_label_2.TabIndex = 31;
            this.m2_label_2.Text = "2. สี";
            // 
            // m2_label_1
            // 
            this.m2_label_1.BackColor = System.Drawing.Color.Transparent;
            this.m2_label_1.Font = new System.Drawing.Font("Browallia New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.m2_label_1.ForeColor = System.Drawing.Color.DimGray;
            this.m2_label_1.Location = new System.Drawing.Point(1140, 267);
            this.m2_label_1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.m2_label_1.Name = "m2_label_1";
            this.m2_label_1.Size = new System.Drawing.Size(175, 83);
            this.m2_label_1.TabIndex = 30;
            this.m2_label_1.Text = "1. อะไร";
            // 
            // m2_btn_1
            // 
            this.m2_btn_1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.m2_btn_1.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.m2_btn_1.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.m2_btn_1.Appearance.Font = new System.Drawing.Font("Browallia New", 19.8F);
            this.m2_btn_1.Appearance.ForeColor = System.Drawing.Color.Transparent;
            this.m2_btn_1.Appearance.Options.UseBackColor = true;
            this.m2_btn_1.Appearance.Options.UseBorderColor = true;
            this.m2_btn_1.Appearance.Options.UseFont = true;
            this.m2_btn_1.Appearance.Options.UseForeColor = true;
            this.m2_btn_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.m2_btn_1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.m2_btn_1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.m2_btn_1.ImageOptions.Image = global::LDWordProcessor.Properties.Resources.icon_speaker;
            this.m2_btn_1.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.m2_btn_1.Location = new System.Drawing.Point(1091, 267);
            this.m2_btn_1.Margin = new System.Windows.Forms.Padding(12, 9, 12, 9);
            this.m2_btn_1.Name = "m2_btn_1";
            this.m2_btn_1.Size = new System.Drawing.Size(49, 46);
            this.m2_btn_1.TabIndex = 25;
            this.m2_btn_1.Text = "อ่านคำถาม";
            this.m2_btn_1.Click += new System.EventHandler(this.btnReadQuestion_Click);
            // 
            // m2_btn_2
            // 
            this.m2_btn_2.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.m2_btn_2.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.m2_btn_2.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.m2_btn_2.Appearance.Font = new System.Drawing.Font("Browallia New", 19.8F);
            this.m2_btn_2.Appearance.ForeColor = System.Drawing.Color.Transparent;
            this.m2_btn_2.Appearance.Options.UseBackColor = true;
            this.m2_btn_2.Appearance.Options.UseBorderColor = true;
            this.m2_btn_2.Appearance.Options.UseFont = true;
            this.m2_btn_2.Appearance.Options.UseForeColor = true;
            this.m2_btn_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.m2_btn_2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.m2_btn_2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.m2_btn_2.ImageOptions.Image = global::LDWordProcessor.Properties.Resources.icon_speaker;
            this.m2_btn_2.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.m2_btn_2.Location = new System.Drawing.Point(749, 10);
            this.m2_btn_2.Margin = new System.Windows.Forms.Padding(12, 9, 12, 9);
            this.m2_btn_2.Name = "m2_btn_2";
            this.m2_btn_2.Size = new System.Drawing.Size(49, 46);
            this.m2_btn_2.TabIndex = 25;
            this.m2_btn_2.Text = "อ่านคำถาม";
            this.m2_btn_2.Click += new System.EventHandler(this.btnReadQuestion_Click);
            // 
            // m2_btn_3
            // 
            this.m2_btn_3.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.m2_btn_3.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.m2_btn_3.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.m2_btn_3.Appearance.Font = new System.Drawing.Font("Browallia New", 19.8F);
            this.m2_btn_3.Appearance.ForeColor = System.Drawing.Color.Transparent;
            this.m2_btn_3.Appearance.Options.UseBackColor = true;
            this.m2_btn_3.Appearance.Options.UseBorderColor = true;
            this.m2_btn_3.Appearance.Options.UseFont = true;
            this.m2_btn_3.Appearance.Options.UseForeColor = true;
            this.m2_btn_3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.m2_btn_3.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.m2_btn_3.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.m2_btn_3.ImageOptions.Image = global::LDWordProcessor.Properties.Resources.icon_speaker;
            this.m2_btn_3.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.m2_btn_3.Location = new System.Drawing.Point(1040, 46);
            this.m2_btn_3.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.m2_btn_3.Name = "m2_btn_3";
            this.m2_btn_3.Size = new System.Drawing.Size(49, 46);
            this.m2_btn_3.TabIndex = 25;
            this.m2_btn_3.Text = "อ่านคำถาม";
            this.m2_btn_3.Click += new System.EventHandler(this.btnReadQuestion_Click);
            // 
            // m2_btn_4
            // 
            this.m2_btn_4.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.m2_btn_4.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.m2_btn_4.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.m2_btn_4.Appearance.Font = new System.Drawing.Font("Browallia New", 19.8F);
            this.m2_btn_4.Appearance.ForeColor = System.Drawing.Color.Transparent;
            this.m2_btn_4.Appearance.Options.UseBackColor = true;
            this.m2_btn_4.Appearance.Options.UseBorderColor = true;
            this.m2_btn_4.Appearance.Options.UseFont = true;
            this.m2_btn_4.Appearance.Options.UseForeColor = true;
            this.m2_btn_4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.m2_btn_4.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.m2_btn_4.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.m2_btn_4.ImageOptions.Image = global::LDWordProcessor.Properties.Resources.icon_speaker;
            this.m2_btn_4.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.m2_btn_4.Location = new System.Drawing.Point(1056, 533);
            this.m2_btn_4.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.m2_btn_4.Name = "m2_btn_4";
            this.m2_btn_4.Size = new System.Drawing.Size(49, 46);
            this.m2_btn_4.TabIndex = 25;
            this.m2_btn_4.Text = "อ่านคำถาม";
            this.m2_btn_4.Click += new System.EventHandler(this.btnReadQuestion_Click);
            // 
            // m2_btn_5
            // 
            this.m2_btn_5.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.m2_btn_5.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.m2_btn_5.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.m2_btn_5.Appearance.Font = new System.Drawing.Font("Browallia New", 19.8F);
            this.m2_btn_5.Appearance.ForeColor = System.Drawing.Color.Transparent;
            this.m2_btn_5.Appearance.Options.UseBackColor = true;
            this.m2_btn_5.Appearance.Options.UseBorderColor = true;
            this.m2_btn_5.Appearance.Options.UseFont = true;
            this.m2_btn_5.Appearance.Options.UseForeColor = true;
            this.m2_btn_5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.m2_btn_5.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.m2_btn_5.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.m2_btn_5.ImageOptions.Image = global::LDWordProcessor.Properties.Resources.icon_speaker;
            this.m2_btn_5.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.m2_btn_5.Location = new System.Drawing.Point(773, 572);
            this.m2_btn_5.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.m2_btn_5.Name = "m2_btn_5";
            this.m2_btn_5.Size = new System.Drawing.Size(49, 46);
            this.m2_btn_5.TabIndex = 25;
            this.m2_btn_5.Text = "อ่านคำถาม";
            this.m2_btn_5.Click += new System.EventHandler(this.btnReadQuestion_Click);
            // 
            // m2_btn_6
            // 
            this.m2_btn_6.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.m2_btn_6.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.m2_btn_6.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.m2_btn_6.Appearance.Font = new System.Drawing.Font("Browallia New", 19.8F);
            this.m2_btn_6.Appearance.ForeColor = System.Drawing.Color.Transparent;
            this.m2_btn_6.Appearance.Options.UseBackColor = true;
            this.m2_btn_6.Appearance.Options.UseBorderColor = true;
            this.m2_btn_6.Appearance.Options.UseFont = true;
            this.m2_btn_6.Appearance.Options.UseForeColor = true;
            this.m2_btn_6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.m2_btn_6.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.m2_btn_6.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.m2_btn_6.ImageOptions.Image = global::LDWordProcessor.Properties.Resources.icon_speaker;
            this.m2_btn_6.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.m2_btn_6.Location = new System.Drawing.Point(363, 283);
            this.m2_btn_6.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.m2_btn_6.Name = "m2_btn_6";
            this.m2_btn_6.Size = new System.Drawing.Size(49, 46);
            this.m2_btn_6.TabIndex = 25;
            this.m2_btn_6.Text = "อ่านคำถาม";
            this.m2_btn_6.Click += new System.EventHandler(this.btnReadQuestion_Click);
            // 
            // m2_btn_7
            // 
            this.m2_btn_7.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.m2_btn_7.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.m2_btn_7.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.m2_btn_7.Appearance.Font = new System.Drawing.Font("Browallia New", 19.8F);
            this.m2_btn_7.Appearance.ForeColor = System.Drawing.Color.Transparent;
            this.m2_btn_7.Appearance.Options.UseBackColor = true;
            this.m2_btn_7.Appearance.Options.UseBorderColor = true;
            this.m2_btn_7.Appearance.Options.UseFont = true;
            this.m2_btn_7.Appearance.Options.UseForeColor = true;
            this.m2_btn_7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.m2_btn_7.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.m2_btn_7.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.m2_btn_7.ImageOptions.Image = global::LDWordProcessor.Properties.Resources.icon_speaker;
            this.m2_btn_7.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.m2_btn_7.Location = new System.Drawing.Point(64, 272);
            this.m2_btn_7.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.m2_btn_7.Name = "m2_btn_7";
            this.m2_btn_7.Size = new System.Drawing.Size(49, 46);
            this.m2_btn_7.TabIndex = 25;
            this.m2_btn_7.Text = "อ่านคำถาม";
            this.m2_btn_7.Click += new System.EventHandler(this.btnReadQuestion_Click);
            // 
            // m2_btn_8
            // 
            this.m2_btn_8.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.m2_btn_8.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.m2_btn_8.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.m2_btn_8.Appearance.Font = new System.Drawing.Font("Browallia New", 19.8F);
            this.m2_btn_8.Appearance.ForeColor = System.Drawing.Color.Transparent;
            this.m2_btn_8.Appearance.Options.UseBackColor = true;
            this.m2_btn_8.Appearance.Options.UseBorderColor = true;
            this.m2_btn_8.Appearance.Options.UseFont = true;
            this.m2_btn_8.Appearance.Options.UseForeColor = true;
            this.m2_btn_8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.m2_btn_8.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.m2_btn_8.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.m2_btn_8.ImageOptions.Image = global::LDWordProcessor.Properties.Resources.icon_speaker;
            this.m2_btn_8.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.m2_btn_8.Location = new System.Drawing.Point(77, 4);
            this.m2_btn_8.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.m2_btn_8.Name = "m2_btn_8";
            this.m2_btn_8.Size = new System.Drawing.Size(49, 46);
            this.m2_btn_8.TabIndex = 25;
            this.m2_btn_8.Text = "อ่านคำถาม";
            this.m2_btn_8.Click += new System.EventHandler(this.btnReadQuestion_Click);
            // 
            // m2_btn_9
            // 
            this.m2_btn_9.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.m2_btn_9.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.m2_btn_9.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.m2_btn_9.Appearance.Font = new System.Drawing.Font("Browallia New", 19.8F);
            this.m2_btn_9.Appearance.ForeColor = System.Drawing.Color.Transparent;
            this.m2_btn_9.Appearance.Options.UseBackColor = true;
            this.m2_btn_9.Appearance.Options.UseBorderColor = true;
            this.m2_btn_9.Appearance.Options.UseFont = true;
            this.m2_btn_9.Appearance.Options.UseForeColor = true;
            this.m2_btn_9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.m2_btn_9.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.m2_btn_9.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.m2_btn_9.ImageOptions.Image = global::LDWordProcessor.Properties.Resources.icon_speaker;
            this.m2_btn_9.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.m2_btn_9.Location = new System.Drawing.Point(496, 125);
            this.m2_btn_9.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.m2_btn_9.Name = "m2_btn_9";
            this.m2_btn_9.Size = new System.Drawing.Size(49, 46);
            this.m2_btn_9.TabIndex = 25;
            this.m2_btn_9.Text = "อ่านคำถาม";
            this.m2_btn_9.Click += new System.EventHandler(this.btnReadQuestion_Click);
            // 
            // m2_btn_10
            // 
            this.m2_btn_10.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.m2_btn_10.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.m2_btn_10.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.m2_btn_10.Appearance.Font = new System.Drawing.Font("Browallia New", 19.8F);
            this.m2_btn_10.Appearance.ForeColor = System.Drawing.Color.Transparent;
            this.m2_btn_10.Appearance.Options.UseBackColor = true;
            this.m2_btn_10.Appearance.Options.UseBorderColor = true;
            this.m2_btn_10.Appearance.Options.UseFont = true;
            this.m2_btn_10.Appearance.Options.UseForeColor = true;
            this.m2_btn_10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.m2_btn_10.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.m2_btn_10.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.m2_btn_10.ImageOptions.Image = global::LDWordProcessor.Properties.Resources.icon_speaker;
            this.m2_btn_10.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.m2_btn_10.Location = new System.Drawing.Point(513, 446);
            this.m2_btn_10.Margin = new System.Windows.Forms.Padding(12, 9, 12, 9);
            this.m2_btn_10.Name = "m2_btn_10";
            this.m2_btn_10.Size = new System.Drawing.Size(49, 46);
            this.m2_btn_10.TabIndex = 25;
            this.m2_btn_10.Text = "อ่านคำถาม";
            this.m2_btn_10.Click += new System.EventHandler(this.btnReadQuestion_Click);
            // 
            // m2_btn_11
            // 
            this.m2_btn_11.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.m2_btn_11.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.m2_btn_11.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.m2_btn_11.Appearance.Font = new System.Drawing.Font("Browallia New", 19.8F);
            this.m2_btn_11.Appearance.ForeColor = System.Drawing.Color.Transparent;
            this.m2_btn_11.Appearance.Options.UseBackColor = true;
            this.m2_btn_11.Appearance.Options.UseBorderColor = true;
            this.m2_btn_11.Appearance.Options.UseFont = true;
            this.m2_btn_11.Appearance.Options.UseForeColor = true;
            this.m2_btn_11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.m2_btn_11.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.m2_btn_11.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.m2_btn_11.ImageOptions.Image = global::LDWordProcessor.Properties.Resources.icon_speaker;
            this.m2_btn_11.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.m2_btn_11.Location = new System.Drawing.Point(36, 461);
            this.m2_btn_11.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.m2_btn_11.Name = "m2_btn_11";
            this.m2_btn_11.Size = new System.Drawing.Size(49, 46);
            this.m2_btn_11.TabIndex = 25;
            this.m2_btn_11.Text = "อ่านคำถาม";
            this.m2_btn_11.Click += new System.EventHandler(this.btnReadQuestion_Click);
            // 
            // m2_btn_12
            // 
            this.m2_btn_12.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.m2_btn_12.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.m2_btn_12.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.m2_btn_12.Appearance.Font = new System.Drawing.Font("Browallia New", 19.8F);
            this.m2_btn_12.Appearance.ForeColor = System.Drawing.Color.Transparent;
            this.m2_btn_12.Appearance.Options.UseBackColor = true;
            this.m2_btn_12.Appearance.Options.UseBorderColor = true;
            this.m2_btn_12.Appearance.Options.UseFont = true;
            this.m2_btn_12.Appearance.Options.UseForeColor = true;
            this.m2_btn_12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.m2_btn_12.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.m2_btn_12.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.m2_btn_12.ImageOptions.Image = global::LDWordProcessor.Properties.Resources.icon_speaker;
            this.m2_btn_12.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.m2_btn_12.Location = new System.Drawing.Point(409, 582);
            this.m2_btn_12.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.m2_btn_12.Name = "m2_btn_12";
            this.m2_btn_12.Size = new System.Drawing.Size(49, 46);
            this.m2_btn_12.TabIndex = 25;
            this.m2_btn_12.Text = "อ่านคำถาม";
            this.m2_btn_12.Click += new System.EventHandler(this.btnReadQuestion_Click);
            // 
            // map2_photo
            // 
            this.map2_photo.BackColor = System.Drawing.Color.Transparent;
            this.map2_photo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.map2_photo.Controls.Add(this.m2_input_title);
            this.map2_photo.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.map2_photo.Location = new System.Drawing.Point(601, 276);
            this.map2_photo.Margin = new System.Windows.Forms.Padding(4);
            this.map2_photo.Name = "map2_photo";
            this.map2_photo.Size = new System.Drawing.Size(224, 143);
            this.map2_photo.TabIndex = 29;
            this.map2_photo.Click += new System.EventHandler(this.mapPhoto_Click);
            // 
            // m2_input_title
            // 
            this.m2_input_title.BackAlpha = 0;
            this.m2_input_title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.m2_input_title.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.m2_input_title.Font = new System.Drawing.Font("Browallia New", 16.2F);
            this.m2_input_title.ForeColor = System.Drawing.Color.Black;
            this.m2_input_title.Location = new System.Drawing.Point(5, 32);
            this.m2_input_title.Margin = new System.Windows.Forms.Padding(4);
            this.m2_input_title.Multiline = true;
            this.m2_input_title.Name = "m2_input_title";
            this.m2_input_title.ReadOnly = true;
            this.m2_input_title.Size = new System.Drawing.Size(216, 89);
            this.m2_input_title.TabIndex = 0;
            this.m2_input_title.TabStop = false;
            this.m2_input_title.Text = "ชื่อเรื่อง";
            this.m2_input_title.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.m2_input_title.MouseCaptureChanged += new System.EventHandler(this.input_Click);
            // 
            // pnMainMindmap1
            // 
            this.pnMainMindmap1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnMainMindmap1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnMainMindmap1.BackgroundImage")));
            this.pnMainMindmap1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnMainMindmap1.Controls.Add(this.m1_input_5);
            this.pnMainMindmap1.Controls.Add(this.m1_input_4);
            this.pnMainMindmap1.Controls.Add(this.m1_input_3);
            this.pnMainMindmap1.Controls.Add(this.m1_input_2);
            this.pnMainMindmap1.Controls.Add(this.m1_input_12);
            this.pnMainMindmap1.Controls.Add(this.m1_input_9);
            this.pnMainMindmap1.Controls.Add(this.m1_input_11);
            this.pnMainMindmap1.Controls.Add(this.m1_input_8);
            this.pnMainMindmap1.Controls.Add(this.m1_input_7);
            this.pnMainMindmap1.Controls.Add(this.m1_input_10);
            this.pnMainMindmap1.Controls.Add(this.m1_input_1);
            this.pnMainMindmap1.Controls.Add(this.m1_input_6);
            this.pnMainMindmap1.Controls.Add(this.m1_label_11);
            this.pnMainMindmap1.Controls.Add(this.m1_label_8);
            this.pnMainMindmap1.Controls.Add(this.m1_label_9);
            this.pnMainMindmap1.Controls.Add(this.m1_label_7);
            this.pnMainMindmap1.Controls.Add(this.m1_label_6);
            this.pnMainMindmap1.Controls.Add(this.m1_label_12);
            this.pnMainMindmap1.Controls.Add(this.m1_label_10);
            this.pnMainMindmap1.Controls.Add(this.m1_label_5);
            this.pnMainMindmap1.Controls.Add(this.m1_label_4);
            this.pnMainMindmap1.Controls.Add(this.m1_label_3);
            this.pnMainMindmap1.Controls.Add(this.m1_label_2);
            this.pnMainMindmap1.Controls.Add(this.m1_label_rp_12);
            this.pnMainMindmap1.Controls.Add(this.m1_label_rp_11);
            this.pnMainMindmap1.Controls.Add(this.m1_label_rp_10);
            this.pnMainMindmap1.Controls.Add(this.m1_label_rp_9);
            this.pnMainMindmap1.Controls.Add(this.m1_label_rp_8);
            this.pnMainMindmap1.Controls.Add(this.m1_label_rp_7);
            this.pnMainMindmap1.Controls.Add(this.m1_label_rp_6);
            this.pnMainMindmap1.Controls.Add(this.m1_label_rp_5);
            this.pnMainMindmap1.Controls.Add(this.m1_label_rp_4);
            this.pnMainMindmap1.Controls.Add(this.m1_label_rp_3);
            this.pnMainMindmap1.Controls.Add(this.m1_label_rp_2);
            this.pnMainMindmap1.Controls.Add(this.m1_label_rp_1);
            this.pnMainMindmap1.Controls.Add(this.m1_btn_1);
            this.pnMainMindmap1.Controls.Add(this.m1_btn_2);
            this.pnMainMindmap1.Controls.Add(this.m1_btn_3);
            this.pnMainMindmap1.Controls.Add(this.m1_btn_4);
            this.pnMainMindmap1.Controls.Add(this.m1_btn_5);
            this.pnMainMindmap1.Controls.Add(this.m1_btn_6);
            this.pnMainMindmap1.Controls.Add(this.m1_btn_7);
            this.pnMainMindmap1.Controls.Add(this.m1_btn_8);
            this.pnMainMindmap1.Controls.Add(this.m1_btn_9);
            this.pnMainMindmap1.Controls.Add(this.m1_btn_10);
            this.pnMainMindmap1.Controls.Add(this.m1_btn_11);
            this.pnMainMindmap1.Controls.Add(this.m1_btn_12);
            this.pnMainMindmap1.Controls.Add(this.m1_label_1);
            this.pnMainMindmap1.Controls.Add(this.map1_photo);
            this.pnMainMindmap1.Location = new System.Drawing.Point(1, 2);
            this.pnMainMindmap1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnMainMindmap1.Name = "pnMainMindmap1";
            this.pnMainMindmap1.Size = new System.Drawing.Size(1319, 700);
            this.pnMainMindmap1.TabIndex = 2;
            // 
            // m1_input_5
            // 
            this.m1_input_5.BackAlpha = 0;
            this.m1_input_5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.m1_input_5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.m1_input_5.Font = new System.Drawing.Font("Browallia New", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m1_input_5.ForeColor = System.Drawing.Color.Black;
            this.m1_input_5.Location = new System.Drawing.Point(1092, 608);
            this.m1_input_5.Margin = new System.Windows.Forms.Padding(4);
            this.m1_input_5.Name = "m1_input_5";
            this.m1_input_5.Size = new System.Drawing.Size(201, 34);
            this.m1_input_5.TabIndex = 5;
            this.m1_input_5.Text = "5";
            this.m1_input_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.m1_input_5.WordWrap = false;
            this.m1_input_5.MouseCaptureChanged += new System.EventHandler(this.input_Click);
            // 
            // m1_input_4
            // 
            this.m1_input_4.BackAlpha = 0;
            this.m1_input_4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.m1_input_4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.m1_input_4.Font = new System.Drawing.Font("Browallia New", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m1_input_4.ForeColor = System.Drawing.Color.Black;
            this.m1_input_4.Location = new System.Drawing.Point(1088, 497);
            this.m1_input_4.Margin = new System.Windows.Forms.Padding(4);
            this.m1_input_4.Name = "m1_input_4";
            this.m1_input_4.Size = new System.Drawing.Size(209, 34);
            this.m1_input_4.TabIndex = 4;
            this.m1_input_4.Text = "4";
            this.m1_input_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.m1_input_4.WordWrap = false;
            this.m1_input_4.MouseCaptureChanged += new System.EventHandler(this.input_Click);
            // 
            // m1_input_3
            // 
            this.m1_input_3.BackAlpha = 0;
            this.m1_input_3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.m1_input_3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.m1_input_3.Font = new System.Drawing.Font("Browallia New", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m1_input_3.ForeColor = System.Drawing.Color.Black;
            this.m1_input_3.Location = new System.Drawing.Point(1089, 188);
            this.m1_input_3.Margin = new System.Windows.Forms.Padding(4);
            this.m1_input_3.Name = "m1_input_3";
            this.m1_input_3.Size = new System.Drawing.Size(208, 34);
            this.m1_input_3.TabIndex = 3;
            this.m1_input_3.Text = "3";
            this.m1_input_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.m1_input_3.WordWrap = false;
            this.m1_input_3.MouseCaptureChanged += new System.EventHandler(this.input_Click);
            // 
            // m1_input_2
            // 
            this.m1_input_2.BackAlpha = 0;
            this.m1_input_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.m1_input_2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.m1_input_2.Font = new System.Drawing.Font("Browallia New", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m1_input_2.ForeColor = System.Drawing.Color.Black;
            this.m1_input_2.Location = new System.Drawing.Point(1089, 86);
            this.m1_input_2.Margin = new System.Windows.Forms.Padding(4);
            this.m1_input_2.Name = "m1_input_2";
            this.m1_input_2.Size = new System.Drawing.Size(209, 34);
            this.m1_input_2.TabIndex = 2;
            this.m1_input_2.Text = "2";
            this.m1_input_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.m1_input_2.WordWrap = false;
            this.m1_input_2.MouseCaptureChanged += new System.EventHandler(this.input_Click);
            // 
            // m1_input_12
            // 
            this.m1_input_12.BackAlpha = 0;
            this.m1_input_12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.m1_input_12.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.m1_input_12.Font = new System.Drawing.Font("Browallia New", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m1_input_12.ForeColor = System.Drawing.Color.Black;
            this.m1_input_12.Location = new System.Drawing.Point(37, 601);
            this.m1_input_12.Margin = new System.Windows.Forms.Padding(4);
            this.m1_input_12.Name = "m1_input_12";
            this.m1_input_12.Size = new System.Drawing.Size(201, 34);
            this.m1_input_12.TabIndex = 12;
            this.m1_input_12.Text = "12";
            this.m1_input_12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.m1_input_12.WordWrap = false;
            this.m1_input_12.MouseCaptureChanged += new System.EventHandler(this.input_Click);
            // 
            // m1_input_9
            // 
            this.m1_input_9.BackAlpha = 0;
            this.m1_input_9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.m1_input_9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.m1_input_9.Font = new System.Drawing.Font("Browallia New", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m1_input_9.ForeColor = System.Drawing.Color.Black;
            this.m1_input_9.Location = new System.Drawing.Point(35, 276);
            this.m1_input_9.Margin = new System.Windows.Forms.Padding(4);
            this.m1_input_9.Name = "m1_input_9";
            this.m1_input_9.Size = new System.Drawing.Size(199, 34);
            this.m1_input_9.TabIndex = 9;
            this.m1_input_9.Text = "9";
            this.m1_input_9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.m1_input_9.WordWrap = false;
            this.m1_input_9.MouseCaptureChanged += new System.EventHandler(this.input_Click);
            // 
            // m1_input_11
            // 
            this.m1_input_11.BackAlpha = 0;
            this.m1_input_11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.m1_input_11.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.m1_input_11.Font = new System.Drawing.Font("Browallia New", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m1_input_11.ForeColor = System.Drawing.Color.Black;
            this.m1_input_11.Location = new System.Drawing.Point(39, 427);
            this.m1_input_11.Margin = new System.Windows.Forms.Padding(4);
            this.m1_input_11.Name = "m1_input_11";
            this.m1_input_11.Size = new System.Drawing.Size(204, 34);
            this.m1_input_11.TabIndex = 11;
            this.m1_input_11.Text = "11";
            this.m1_input_11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.m1_input_11.WordWrap = false;
            this.m1_input_11.MouseCaptureChanged += new System.EventHandler(this.input_Click);
            // 
            // m1_input_8
            // 
            this.m1_input_8.BackAlpha = 0;
            this.m1_input_8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.m1_input_8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.m1_input_8.Font = new System.Drawing.Font("Browallia New", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m1_input_8.ForeColor = System.Drawing.Color.Black;
            this.m1_input_8.Location = new System.Drawing.Point(31, 166);
            this.m1_input_8.Margin = new System.Windows.Forms.Padding(4);
            this.m1_input_8.Name = "m1_input_8";
            this.m1_input_8.Size = new System.Drawing.Size(200, 34);
            this.m1_input_8.TabIndex = 8;
            this.m1_input_8.Text = "8";
            this.m1_input_8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.m1_input_8.WordWrap = false;
            this.m1_input_8.MouseCaptureChanged += new System.EventHandler(this.input_Click);
            // 
            // m1_input_7
            // 
            this.m1_input_7.BackAlpha = 0;
            this.m1_input_7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.m1_input_7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.m1_input_7.Font = new System.Drawing.Font("Browallia New", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m1_input_7.ForeColor = System.Drawing.Color.Black;
            this.m1_input_7.Location = new System.Drawing.Point(37, 71);
            this.m1_input_7.Margin = new System.Windows.Forms.Padding(4);
            this.m1_input_7.Name = "m1_input_7";
            this.m1_input_7.Size = new System.Drawing.Size(199, 34);
            this.m1_input_7.TabIndex = 7;
            this.m1_input_7.Text = "7";
            this.m1_input_7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.m1_input_7.WordWrap = false;
            this.m1_input_7.MouseCaptureChanged += new System.EventHandler(this.input_Click);
            // 
            // m1_input_10
            // 
            this.m1_input_10.BackAlpha = 0;
            this.m1_input_10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.m1_input_10.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.m1_input_10.Font = new System.Drawing.Font("Browallia New", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m1_input_10.ForeColor = System.Drawing.Color.Black;
            this.m1_input_10.Location = new System.Drawing.Point(313, 516);
            this.m1_input_10.Margin = new System.Windows.Forms.Padding(4);
            this.m1_input_10.Name = "m1_input_10";
            this.m1_input_10.Size = new System.Drawing.Size(233, 34);
            this.m1_input_10.TabIndex = 10;
            this.m1_input_10.Text = "10";
            this.m1_input_10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.m1_input_10.WordWrap = false;
            this.m1_input_10.MouseCaptureChanged += new System.EventHandler(this.input_Click);
            // 
            // m1_input_1
            // 
            this.m1_input_1.BackAlpha = 0;
            this.m1_input_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.m1_input_1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.m1_input_1.Font = new System.Drawing.Font("Browallia New", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m1_input_1.ForeColor = System.Drawing.Color.Black;
            this.m1_input_1.Location = new System.Drawing.Point(897, 351);
            this.m1_input_1.Margin = new System.Windows.Forms.Padding(4);
            this.m1_input_1.Name = "m1_input_1";
            this.m1_input_1.Size = new System.Drawing.Size(207, 34);
            this.m1_input_1.TabIndex = 1;
            this.m1_input_1.Text = "1";
            this.m1_input_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.m1_input_1.WordWrap = false;
            this.m1_input_1.MouseCaptureChanged += new System.EventHandler(this.input_Click);
            // 
            // m1_input_6
            // 
            this.m1_input_6.BackAlpha = 0;
            this.m1_input_6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.m1_input_6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.m1_input_6.Font = new System.Drawing.Font("Browallia New", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m1_input_6.ForeColor = System.Drawing.Color.Black;
            this.m1_input_6.Location = new System.Drawing.Point(363, 167);
            this.m1_input_6.Margin = new System.Windows.Forms.Padding(4);
            this.m1_input_6.Name = "m1_input_6";
            this.m1_input_6.Size = new System.Drawing.Size(217, 34);
            this.m1_input_6.TabIndex = 6;
            this.m1_input_6.Text = "6";
            this.m1_input_6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.m1_input_6.WordWrap = false;
            this.m1_input_6.MouseCaptureChanged += new System.EventHandler(this.input_Click);
            // 
            // m1_label_11
            // 
            this.m1_label_11.BackColor = System.Drawing.Color.Transparent;
            this.m1_label_11.Font = new System.Drawing.Font("Browallia New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m1_label_11.ForeColor = System.Drawing.Color.DimGray;
            this.m1_label_11.Location = new System.Drawing.Point(297, 384);
            this.m1_label_11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.m1_label_11.Name = "m1_label_11";
            this.m1_label_11.Size = new System.Drawing.Size(253, 91);
            this.m1_label_11.TabIndex = 42;
            this.m1_label_11.Text = "11. มุมมองของภาพ ";
            // 
            // m1_label_8
            // 
            this.m1_label_8.BackColor = System.Drawing.Color.Transparent;
            this.m1_label_8.Font = new System.Drawing.Font("Browallia New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m1_label_8.ForeColor = System.Drawing.Color.DimGray;
            this.m1_label_8.Location = new System.Drawing.Point(56, 203);
            this.m1_label_8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.m1_label_8.Name = "m1_label_8";
            this.m1_label_8.Size = new System.Drawing.Size(373, 46);
            this.m1_label_8.TabIndex = 41;
            this.m1_label_8.Text = "8. อารมณ์";
            // 
            // m1_label_9
            // 
            this.m1_label_9.BackColor = System.Drawing.Color.Transparent;
            this.m1_label_9.Font = new System.Drawing.Font("Browallia New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m1_label_9.ForeColor = System.Drawing.Color.DimGray;
            this.m1_label_9.Location = new System.Drawing.Point(73, 324);
            this.m1_label_9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.m1_label_9.Name = "m1_label_9";
            this.m1_label_9.Size = new System.Drawing.Size(400, 37);
            this.m1_label_9.TabIndex = 40;
            this.m1_label_9.Text = "9. ภาพพื้นหลัง";
            // 
            // m1_label_7
            // 
            this.m1_label_7.BackColor = System.Drawing.Color.Transparent;
            this.m1_label_7.Font = new System.Drawing.Font("Browallia New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m1_label_7.ForeColor = System.Drawing.Color.DimGray;
            this.m1_label_7.Location = new System.Drawing.Point(276, 25);
            this.m1_label_7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.m1_label_7.Name = "m1_label_7";
            this.m1_label_7.Size = new System.Drawing.Size(399, 62);
            this.m1_label_7.TabIndex = 38;
            this.m1_label_7.Text = "7. ที่ไหน";
            // 
            // m1_label_6
            // 
            this.m1_label_6.BackColor = System.Drawing.Color.Transparent;
            this.m1_label_6.Font = new System.Drawing.Font("Browallia New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m1_label_6.ForeColor = System.Drawing.Color.DimGray;
            this.m1_label_6.Location = new System.Drawing.Point(623, 105);
            this.m1_label_6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.m1_label_6.Name = "m1_label_6";
            this.m1_label_6.Size = new System.Drawing.Size(350, 62);
            this.m1_label_6.TabIndex = 37;
            this.m1_label_6.Text = "6. การเคลื่อนไหว";
            // 
            // m1_label_12
            // 
            this.m1_label_12.BackColor = System.Drawing.Color.Transparent;
            this.m1_label_12.Font = new System.Drawing.Font("Browallia New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m1_label_12.ForeColor = System.Drawing.Color.DimGray;
            this.m1_label_12.Location = new System.Drawing.Point(296, 612);
            this.m1_label_12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.m1_label_12.Name = "m1_label_12";
            this.m1_label_12.Size = new System.Drawing.Size(310, 85);
            this.m1_label_12.TabIndex = 36;
            this.m1_label_12.Text = "12. เสียง";
            // 
            // m1_label_10
            // 
            this.m1_label_10.BackColor = System.Drawing.Color.Transparent;
            this.m1_label_10.Font = new System.Drawing.Font("Browallia New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m1_label_10.ForeColor = System.Drawing.Color.DimGray;
            this.m1_label_10.Location = new System.Drawing.Point(599, 533);
            this.m1_label_10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.m1_label_10.Name = "m1_label_10";
            this.m1_label_10.Size = new System.Drawing.Size(347, 79);
            this.m1_label_10.TabIndex = 35;
            this.m1_label_10.Text = "10. เมื่อไหร่";
            // 
            // m1_label_5
            // 
            this.m1_label_5.BackColor = System.Drawing.Color.Transparent;
            this.m1_label_5.Font = new System.Drawing.Font("Browallia New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m1_label_5.ForeColor = System.Drawing.Color.DimGray;
            this.m1_label_5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m1_label_5.Location = new System.Drawing.Point(996, 652);
            this.m1_label_5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.m1_label_5.Name = "m1_label_5";
            this.m1_label_5.Size = new System.Drawing.Size(319, 55);
            this.m1_label_5.TabIndex = 34;
            this.m1_label_5.Text = "5. จำนวน";
            // 
            // m1_label_4
            // 
            this.m1_label_4.BackColor = System.Drawing.Color.Transparent;
            this.m1_label_4.Font = new System.Drawing.Font("Browallia New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m1_label_4.ForeColor = System.Drawing.Color.DimGray;
            this.m1_label_4.Location = new System.Drawing.Point(1052, 397);
            this.m1_label_4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.m1_label_4.Name = "m1_label_4";
            this.m1_label_4.Size = new System.Drawing.Size(267, 78);
            this.m1_label_4.TabIndex = 33;
            this.m1_label_4.Text = "4. รูปร่าง";
            // 
            // m1_label_3
            // 
            this.m1_label_3.BackColor = System.Drawing.Color.Transparent;
            this.m1_label_3.Font = new System.Drawing.Font("Browallia New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m1_label_3.ForeColor = System.Drawing.Color.DimGray;
            this.m1_label_3.Location = new System.Drawing.Point(1053, 234);
            this.m1_label_3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.m1_label_3.Name = "m1_label_3";
            this.m1_label_3.Size = new System.Drawing.Size(266, 86);
            this.m1_label_3.TabIndex = 32;
            this.m1_label_3.Text = "3. ขนาด";
            // 
            // m1_label_2
            // 
            this.m1_label_2.BackColor = System.Drawing.Color.Transparent;
            this.m1_label_2.Font = new System.Drawing.Font("Browallia New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m1_label_2.ForeColor = System.Drawing.Color.DimGray;
            this.m1_label_2.Location = new System.Drawing.Point(1013, 13);
            this.m1_label_2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.m1_label_2.Name = "m1_label_2";
            this.m1_label_2.Size = new System.Drawing.Size(316, 44);
            this.m1_label_2.TabIndex = 31;
            this.m1_label_2.Text = "2. สี";
            // 
            // m1_label_rp_12
            // 
            this.m1_label_rp_12.BackColor = System.Drawing.Color.Transparent;
            this.m1_label_rp_12.Font = new System.Drawing.Font("Browallia New", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m1_label_rp_12.ForeColor = System.Drawing.Color.Black;
            this.m1_label_rp_12.Location = new System.Drawing.Point(48, 580);
            this.m1_label_rp_12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.m1_label_rp_12.Name = "m1_label_rp_12";
            this.m1_label_rp_12.Size = new System.Drawing.Size(181, 23);
            this.m1_label_rp_12.TabIndex = 30;
            this.m1_label_rp_12.Text = "12";
            this.m1_label_rp_12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.m1_label_rp_12.UseCompatibleTextRendering = true;
            // 
            // m1_label_rp_11
            // 
            this.m1_label_rp_11.BackColor = System.Drawing.Color.Transparent;
            this.m1_label_rp_11.Font = new System.Drawing.Font("Browallia New", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m1_label_rp_11.ForeColor = System.Drawing.Color.Black;
            this.m1_label_rp_11.Location = new System.Drawing.Point(49, 406);
            this.m1_label_rp_11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.m1_label_rp_11.Name = "m1_label_rp_11";
            this.m1_label_rp_11.Size = new System.Drawing.Size(181, 23);
            this.m1_label_rp_11.TabIndex = 30;
            this.m1_label_rp_11.Text = "11";
            this.m1_label_rp_11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.m1_label_rp_11.UseCompatibleTextRendering = true;
            // 
            // m1_label_rp_10
            // 
            this.m1_label_rp_10.BackColor = System.Drawing.Color.Transparent;
            this.m1_label_rp_10.Font = new System.Drawing.Font("Browallia New", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m1_label_rp_10.ForeColor = System.Drawing.Color.Black;
            this.m1_label_rp_10.Location = new System.Drawing.Point(323, 495);
            this.m1_label_rp_10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.m1_label_rp_10.Name = "m1_label_rp_10";
            this.m1_label_rp_10.Size = new System.Drawing.Size(215, 23);
            this.m1_label_rp_10.TabIndex = 30;
            this.m1_label_rp_10.Text = "10";
            this.m1_label_rp_10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.m1_label_rp_10.UseCompatibleTextRendering = true;
            // 
            // m1_label_rp_9
            // 
            this.m1_label_rp_9.BackColor = System.Drawing.Color.Transparent;
            this.m1_label_rp_9.Font = new System.Drawing.Font("Browallia New", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m1_label_rp_9.ForeColor = System.Drawing.Color.Black;
            this.m1_label_rp_9.Location = new System.Drawing.Point(37, 255);
            this.m1_label_rp_9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.m1_label_rp_9.Name = "m1_label_rp_9";
            this.m1_label_rp_9.Size = new System.Drawing.Size(193, 23);
            this.m1_label_rp_9.TabIndex = 30;
            this.m1_label_rp_9.Text = "9";
            this.m1_label_rp_9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.m1_label_rp_9.UseCompatibleTextRendering = true;
            // 
            // m1_label_rp_8
            // 
            this.m1_label_rp_8.BackColor = System.Drawing.Color.Transparent;
            this.m1_label_rp_8.Font = new System.Drawing.Font("Browallia New", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m1_label_rp_8.ForeColor = System.Drawing.Color.Black;
            this.m1_label_rp_8.Location = new System.Drawing.Point(33, 144);
            this.m1_label_rp_8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.m1_label_rp_8.Name = "m1_label_rp_8";
            this.m1_label_rp_8.Size = new System.Drawing.Size(193, 23);
            this.m1_label_rp_8.TabIndex = 30;
            this.m1_label_rp_8.Text = "8";
            this.m1_label_rp_8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.m1_label_rp_8.UseCompatibleTextRendering = true;
            // 
            // m1_label_rp_7
            // 
            this.m1_label_rp_7.BackColor = System.Drawing.Color.Transparent;
            this.m1_label_rp_7.Font = new System.Drawing.Font("Browallia New", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m1_label_rp_7.ForeColor = System.Drawing.Color.Black;
            this.m1_label_rp_7.Location = new System.Drawing.Point(39, 53);
            this.m1_label_rp_7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.m1_label_rp_7.Name = "m1_label_rp_7";
            this.m1_label_rp_7.Size = new System.Drawing.Size(193, 23);
            this.m1_label_rp_7.TabIndex = 30;
            this.m1_label_rp_7.Text = "7";
            this.m1_label_rp_7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.m1_label_rp_7.UseCompatibleTextRendering = true;
            // 
            // m1_label_rp_6
            // 
            this.m1_label_rp_6.BackColor = System.Drawing.Color.Transparent;
            this.m1_label_rp_6.Font = new System.Drawing.Font("Browallia New", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m1_label_rp_6.ForeColor = System.Drawing.Color.Black;
            this.m1_label_rp_6.Location = new System.Drawing.Point(375, 144);
            this.m1_label_rp_6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.m1_label_rp_6.Name = "m1_label_rp_6";
            this.m1_label_rp_6.Size = new System.Drawing.Size(193, 23);
            this.m1_label_rp_6.TabIndex = 30;
            this.m1_label_rp_6.Text = "6";
            this.m1_label_rp_6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.m1_label_rp_6.UseCompatibleTextRendering = true;
            // 
            // m1_label_rp_5
            // 
            this.m1_label_rp_5.BackColor = System.Drawing.Color.Transparent;
            this.m1_label_rp_5.Font = new System.Drawing.Font("Browallia New", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m1_label_rp_5.ForeColor = System.Drawing.Color.Black;
            this.m1_label_rp_5.Location = new System.Drawing.Point(1095, 585);
            this.m1_label_rp_5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.m1_label_rp_5.Name = "m1_label_rp_5";
            this.m1_label_rp_5.Size = new System.Drawing.Size(193, 23);
            this.m1_label_rp_5.TabIndex = 30;
            this.m1_label_rp_5.Text = "5";
            this.m1_label_rp_5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.m1_label_rp_5.UseCompatibleTextRendering = true;
            // 
            // m1_label_rp_4
            // 
            this.m1_label_rp_4.BackColor = System.Drawing.Color.Transparent;
            this.m1_label_rp_4.Font = new System.Drawing.Font("Browallia New", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m1_label_rp_4.ForeColor = System.Drawing.Color.Black;
            this.m1_label_rp_4.Location = new System.Drawing.Point(1096, 475);
            this.m1_label_rp_4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.m1_label_rp_4.Name = "m1_label_rp_4";
            this.m1_label_rp_4.Size = new System.Drawing.Size(193, 23);
            this.m1_label_rp_4.TabIndex = 30;
            this.m1_label_rp_4.Text = "4";
            this.m1_label_rp_4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.m1_label_rp_4.UseCompatibleTextRendering = true;
            // 
            // m1_label_rp_3
            // 
            this.m1_label_rp_3.BackColor = System.Drawing.Color.Transparent;
            this.m1_label_rp_3.Font = new System.Drawing.Font("Browallia New", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m1_label_rp_3.ForeColor = System.Drawing.Color.Black;
            this.m1_label_rp_3.Location = new System.Drawing.Point(1096, 164);
            this.m1_label_rp_3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.m1_label_rp_3.Name = "m1_label_rp_3";
            this.m1_label_rp_3.Size = new System.Drawing.Size(193, 23);
            this.m1_label_rp_3.TabIndex = 30;
            this.m1_label_rp_3.Text = "3";
            this.m1_label_rp_3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.m1_label_rp_3.UseCompatibleTextRendering = true;
            // 
            // m1_label_rp_2
            // 
            this.m1_label_rp_2.BackColor = System.Drawing.Color.Transparent;
            this.m1_label_rp_2.Font = new System.Drawing.Font("Browallia New", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m1_label_rp_2.ForeColor = System.Drawing.Color.Black;
            this.m1_label_rp_2.Location = new System.Drawing.Point(1097, 64);
            this.m1_label_rp_2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.m1_label_rp_2.Name = "m1_label_rp_2";
            this.m1_label_rp_2.Size = new System.Drawing.Size(193, 23);
            this.m1_label_rp_2.TabIndex = 30;
            this.m1_label_rp_2.Text = "2";
            this.m1_label_rp_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.m1_label_rp_2.UseCompatibleTextRendering = true;
            // 
            // m1_label_rp_1
            // 
            this.m1_label_rp_1.BackColor = System.Drawing.Color.Transparent;
            this.m1_label_rp_1.Font = new System.Drawing.Font("Browallia New", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m1_label_rp_1.ForeColor = System.Drawing.Color.Black;
            this.m1_label_rp_1.Location = new System.Drawing.Point(903, 324);
            this.m1_label_rp_1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.m1_label_rp_1.Name = "m1_label_rp_1";
            this.m1_label_rp_1.Size = new System.Drawing.Size(193, 23);
            this.m1_label_rp_1.TabIndex = 30;
            this.m1_label_rp_1.Text = "1";
            this.m1_label_rp_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.m1_label_rp_1.UseCompatibleTextRendering = true;
            // 
            // m1_btn_1
            // 
            this.m1_btn_1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.m1_btn_1.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.m1_btn_1.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.m1_btn_1.Appearance.Font = new System.Drawing.Font("Browallia New", 19.8F);
            this.m1_btn_1.Appearance.ForeColor = System.Drawing.Color.Transparent;
            this.m1_btn_1.Appearance.Options.UseBackColor = true;
            this.m1_btn_1.Appearance.Options.UseBorderColor = true;
            this.m1_btn_1.Appearance.Options.UseFont = true;
            this.m1_btn_1.Appearance.Options.UseForeColor = true;
            this.m1_btn_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.m1_btn_1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.m1_btn_1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.m1_btn_1.ImageOptions.Image = global::LDWordProcessor.Properties.Resources.icon_speaker;
            this.m1_btn_1.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.m1_btn_1.Location = new System.Drawing.Point(800, 401);
            this.m1_btn_1.Margin = new System.Windows.Forms.Padding(12, 9, 12, 9);
            this.m1_btn_1.Name = "m1_btn_1";
            this.m1_btn_1.Size = new System.Drawing.Size(50, 50);
            this.m1_btn_1.TabIndex = 25;
            this.m1_btn_1.Text = "อ่านคำถาม";
            this.m1_btn_1.Click += new System.EventHandler(this.btnReadQuestion_Click);
            // 
            // m1_btn_2
            // 
            this.m1_btn_2.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.m1_btn_2.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.m1_btn_2.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.m1_btn_2.Appearance.Font = new System.Drawing.Font("Browallia New", 19.8F);
            this.m1_btn_2.Appearance.ForeColor = System.Drawing.Color.Transparent;
            this.m1_btn_2.Appearance.Options.UseBackColor = true;
            this.m1_btn_2.Appearance.Options.UseBorderColor = true;
            this.m1_btn_2.Appearance.Options.UseFont = true;
            this.m1_btn_2.Appearance.Options.UseForeColor = true;
            this.m1_btn_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.m1_btn_2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.m1_btn_2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.m1_btn_2.ImageOptions.Image = global::LDWordProcessor.Properties.Resources.icon_speaker;
            this.m1_btn_2.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.m1_btn_2.Location = new System.Drawing.Point(961, 11);
            this.m1_btn_2.Margin = new System.Windows.Forms.Padding(12, 9, 12, 9);
            this.m1_btn_2.Name = "m1_btn_2";
            this.m1_btn_2.Size = new System.Drawing.Size(50, 50);
            this.m1_btn_2.TabIndex = 25;
            this.m1_btn_2.Text = "อ่านคำถาม";
            this.m1_btn_2.Click += new System.EventHandler(this.btnReadQuestion_Click);
            // 
            // m1_btn_3
            // 
            this.m1_btn_3.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.m1_btn_3.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.m1_btn_3.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.m1_btn_3.Appearance.Font = new System.Drawing.Font("Browallia New", 19.8F);
            this.m1_btn_3.Appearance.ForeColor = System.Drawing.Color.Transparent;
            this.m1_btn_3.Appearance.Options.UseBackColor = true;
            this.m1_btn_3.Appearance.Options.UseBorderColor = true;
            this.m1_btn_3.Appearance.Options.UseFont = true;
            this.m1_btn_3.Appearance.Options.UseForeColor = true;
            this.m1_btn_3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.m1_btn_3.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.m1_btn_3.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.m1_btn_3.ImageOptions.Image = global::LDWordProcessor.Properties.Resources.icon_speaker;
            this.m1_btn_3.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.m1_btn_3.Location = new System.Drawing.Point(1004, 234);
            this.m1_btn_3.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.m1_btn_3.Name = "m1_btn_3";
            this.m1_btn_3.Size = new System.Drawing.Size(50, 50);
            this.m1_btn_3.TabIndex = 25;
            this.m1_btn_3.Text = "อ่านคำถาม";
            this.m1_btn_3.Click += new System.EventHandler(this.btnReadQuestion_Click);
            // 
            // m1_btn_4
            // 
            this.m1_btn_4.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.m1_btn_4.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.m1_btn_4.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.m1_btn_4.Appearance.Font = new System.Drawing.Font("Browallia New", 19.8F);
            this.m1_btn_4.Appearance.ForeColor = System.Drawing.Color.Transparent;
            this.m1_btn_4.Appearance.Options.UseBackColor = true;
            this.m1_btn_4.Appearance.Options.UseBorderColor = true;
            this.m1_btn_4.Appearance.Options.UseFont = true;
            this.m1_btn_4.Appearance.Options.UseForeColor = true;
            this.m1_btn_4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.m1_btn_4.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.m1_btn_4.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.m1_btn_4.ImageOptions.Image = global::LDWordProcessor.Properties.Resources.icon_speaker;
            this.m1_btn_4.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.m1_btn_4.Location = new System.Drawing.Point(1006, 402);
            this.m1_btn_4.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.m1_btn_4.Name = "m1_btn_4";
            this.m1_btn_4.Size = new System.Drawing.Size(50, 50);
            this.m1_btn_4.TabIndex = 25;
            this.m1_btn_4.Text = "อ่านคำถาม";
            this.m1_btn_4.Click += new System.EventHandler(this.btnReadQuestion_Click);
            // 
            // m1_btn_5
            // 
            this.m1_btn_5.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.m1_btn_5.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.m1_btn_5.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.m1_btn_5.Appearance.Font = new System.Drawing.Font("Browallia New", 19.8F);
            this.m1_btn_5.Appearance.ForeColor = System.Drawing.Color.Transparent;
            this.m1_btn_5.Appearance.Options.UseBackColor = true;
            this.m1_btn_5.Appearance.Options.UseBorderColor = true;
            this.m1_btn_5.Appearance.Options.UseFont = true;
            this.m1_btn_5.Appearance.Options.UseForeColor = true;
            this.m1_btn_5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.m1_btn_5.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.m1_btn_5.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.m1_btn_5.ImageOptions.Image = global::LDWordProcessor.Properties.Resources.icon_speaker;
            this.m1_btn_5.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.m1_btn_5.Location = new System.Drawing.Point(947, 652);
            this.m1_btn_5.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.m1_btn_5.Name = "m1_btn_5";
            this.m1_btn_5.Size = new System.Drawing.Size(50, 50);
            this.m1_btn_5.TabIndex = 25;
            this.m1_btn_5.Text = "อ่านคำถาม";
            this.m1_btn_5.Click += new System.EventHandler(this.btnReadQuestion_Click);
            // 
            // m1_btn_6
            // 
            this.m1_btn_6.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.m1_btn_6.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.m1_btn_6.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.m1_btn_6.Appearance.Font = new System.Drawing.Font("Browallia New", 19.8F);
            this.m1_btn_6.Appearance.ForeColor = System.Drawing.Color.Transparent;
            this.m1_btn_6.Appearance.Options.UseBackColor = true;
            this.m1_btn_6.Appearance.Options.UseBorderColor = true;
            this.m1_btn_6.Appearance.Options.UseFont = true;
            this.m1_btn_6.Appearance.Options.UseForeColor = true;
            this.m1_btn_6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.m1_btn_6.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.m1_btn_6.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.m1_btn_6.ImageOptions.Image = global::LDWordProcessor.Properties.Resources.icon_speaker;
            this.m1_btn_6.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.m1_btn_6.Location = new System.Drawing.Point(573, 105);
            this.m1_btn_6.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.m1_btn_6.Name = "m1_btn_6";
            this.m1_btn_6.Size = new System.Drawing.Size(50, 50);
            this.m1_btn_6.TabIndex = 25;
            this.m1_btn_6.Text = "อ่านคำถาม";
            this.m1_btn_6.Click += new System.EventHandler(this.btnReadQuestion_Click);
            // 
            // m1_btn_7
            // 
            this.m1_btn_7.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.m1_btn_7.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.m1_btn_7.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.m1_btn_7.Appearance.Font = new System.Drawing.Font("Browallia New", 19.8F);
            this.m1_btn_7.Appearance.ForeColor = System.Drawing.Color.Transparent;
            this.m1_btn_7.Appearance.Options.UseBackColor = true;
            this.m1_btn_7.Appearance.Options.UseBorderColor = true;
            this.m1_btn_7.Appearance.Options.UseFont = true;
            this.m1_btn_7.Appearance.Options.UseForeColor = true;
            this.m1_btn_7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.m1_btn_7.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.m1_btn_7.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.m1_btn_7.ImageOptions.Image = global::LDWordProcessor.Properties.Resources.icon_speaker;
            this.m1_btn_7.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.m1_btn_7.Location = new System.Drawing.Point(227, 25);
            this.m1_btn_7.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.m1_btn_7.Name = "m1_btn_7";
            this.m1_btn_7.Size = new System.Drawing.Size(50, 50);
            this.m1_btn_7.TabIndex = 25;
            this.m1_btn_7.Text = "อ่านคำถาม";
            this.m1_btn_7.Click += new System.EventHandler(this.btnReadQuestion_Click);
            // 
            // m1_btn_8
            // 
            this.m1_btn_8.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.m1_btn_8.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.m1_btn_8.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.m1_btn_8.Appearance.Font = new System.Drawing.Font("Browallia New", 19.8F);
            this.m1_btn_8.Appearance.ForeColor = System.Drawing.Color.Transparent;
            this.m1_btn_8.Appearance.Options.UseBackColor = true;
            this.m1_btn_8.Appearance.Options.UseBorderColor = true;
            this.m1_btn_8.Appearance.Options.UseFont = true;
            this.m1_btn_8.Appearance.Options.UseForeColor = true;
            this.m1_btn_8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.m1_btn_8.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.m1_btn_8.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.m1_btn_8.ImageOptions.Image = global::LDWordProcessor.Properties.Resources.icon_speaker;
            this.m1_btn_8.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.m1_btn_8.Location = new System.Drawing.Point(7, 203);
            this.m1_btn_8.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.m1_btn_8.Name = "m1_btn_8";
            this.m1_btn_8.Size = new System.Drawing.Size(50, 50);
            this.m1_btn_8.TabIndex = 25;
            this.m1_btn_8.Text = "อ่านคำถาม";
            this.m1_btn_8.Click += new System.EventHandler(this.btnReadQuestion_Click);
            // 
            // m1_btn_9
            // 
            this.m1_btn_9.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.m1_btn_9.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.m1_btn_9.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.m1_btn_9.Appearance.Font = new System.Drawing.Font("Browallia New", 19.8F);
            this.m1_btn_9.Appearance.ForeColor = System.Drawing.Color.Transparent;
            this.m1_btn_9.Appearance.Options.UseBackColor = true;
            this.m1_btn_9.Appearance.Options.UseBorderColor = true;
            this.m1_btn_9.Appearance.Options.UseFont = true;
            this.m1_btn_9.Appearance.Options.UseForeColor = true;
            this.m1_btn_9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.m1_btn_9.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.m1_btn_9.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.m1_btn_9.ImageOptions.Image = global::LDWordProcessor.Properties.Resources.icon_speaker;
            this.m1_btn_9.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.m1_btn_9.Location = new System.Drawing.Point(24, 324);
            this.m1_btn_9.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.m1_btn_9.Name = "m1_btn_9";
            this.m1_btn_9.Size = new System.Drawing.Size(50, 50);
            this.m1_btn_9.TabIndex = 25;
            this.m1_btn_9.Text = "อ่านคำถาม";
            this.m1_btn_9.Click += new System.EventHandler(this.btnReadQuestion_Click);
            // 
            // m1_btn_10
            // 
            this.m1_btn_10.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.m1_btn_10.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.m1_btn_10.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.m1_btn_10.Appearance.Font = new System.Drawing.Font("Browallia New", 19.8F);
            this.m1_btn_10.Appearance.ForeColor = System.Drawing.Color.Transparent;
            this.m1_btn_10.Appearance.Options.UseBackColor = true;
            this.m1_btn_10.Appearance.Options.UseBorderColor = true;
            this.m1_btn_10.Appearance.Options.UseFont = true;
            this.m1_btn_10.Appearance.Options.UseForeColor = true;
            this.m1_btn_10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.m1_btn_10.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.m1_btn_10.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.m1_btn_10.ImageOptions.Image = global::LDWordProcessor.Properties.Resources.icon_speaker;
            this.m1_btn_10.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.m1_btn_10.Location = new System.Drawing.Point(549, 533);
            this.m1_btn_10.Margin = new System.Windows.Forms.Padding(12, 9, 12, 9);
            this.m1_btn_10.Name = "m1_btn_10";
            this.m1_btn_10.Size = new System.Drawing.Size(50, 50);
            this.m1_btn_10.TabIndex = 25;
            this.m1_btn_10.Text = "อ่านคำถาม";
            this.m1_btn_10.Click += new System.EventHandler(this.btnReadQuestion_Click);
            // 
            // m1_btn_11
            // 
            this.m1_btn_11.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.m1_btn_11.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.m1_btn_11.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.m1_btn_11.Appearance.Font = new System.Drawing.Font("Browallia New", 19.8F);
            this.m1_btn_11.Appearance.ForeColor = System.Drawing.Color.Transparent;
            this.m1_btn_11.Appearance.Options.UseBackColor = true;
            this.m1_btn_11.Appearance.Options.UseBorderColor = true;
            this.m1_btn_11.Appearance.Options.UseFont = true;
            this.m1_btn_11.Appearance.Options.UseForeColor = true;
            this.m1_btn_11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.m1_btn_11.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.m1_btn_11.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.m1_btn_11.ImageOptions.Image = global::LDWordProcessor.Properties.Resources.icon_speaker;
            this.m1_btn_11.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.m1_btn_11.Location = new System.Drawing.Point(248, 384);
            this.m1_btn_11.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.m1_btn_11.Name = "m1_btn_11";
            this.m1_btn_11.Size = new System.Drawing.Size(50, 50);
            this.m1_btn_11.TabIndex = 25;
            this.m1_btn_11.Text = "อ่านคำถาม";
            this.m1_btn_11.Click += new System.EventHandler(this.btnReadQuestion_Click);
            // 
            // m1_btn_12
            // 
            this.m1_btn_12.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.m1_btn_12.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.m1_btn_12.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.m1_btn_12.Appearance.Font = new System.Drawing.Font("Browallia New", 19.8F);
            this.m1_btn_12.Appearance.ForeColor = System.Drawing.Color.Transparent;
            this.m1_btn_12.Appearance.Options.UseBackColor = true;
            this.m1_btn_12.Appearance.Options.UseBorderColor = true;
            this.m1_btn_12.Appearance.Options.UseFont = true;
            this.m1_btn_12.Appearance.Options.UseForeColor = true;
            this.m1_btn_12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.m1_btn_12.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.m1_btn_12.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.m1_btn_12.ImageOptions.Image = global::LDWordProcessor.Properties.Resources.icon_speaker;
            this.m1_btn_12.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.m1_btn_12.Location = new System.Drawing.Point(247, 612);
            this.m1_btn_12.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.m1_btn_12.Name = "m1_btn_12";
            this.m1_btn_12.Size = new System.Drawing.Size(50, 50);
            this.m1_btn_12.TabIndex = 25;
            this.m1_btn_12.Text = "อ่านคำถาม";
            this.m1_btn_12.Click += new System.EventHandler(this.btnReadQuestion_Click);
            // 
            // m1_label_1
            // 
            this.m1_label_1.BackColor = System.Drawing.Color.Transparent;
            this.m1_label_1.Font = new System.Drawing.Font("Browallia New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m1_label_1.ForeColor = System.Drawing.Color.DimGray;
            this.m1_label_1.Location = new System.Drawing.Point(849, 401);
            this.m1_label_1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.m1_label_1.Name = "m1_label_1";
            this.m1_label_1.Size = new System.Drawing.Size(160, 97);
            this.m1_label_1.TabIndex = 30;
            this.m1_label_1.Text = "1. อะไร";
            // 
            // map1_photo
            // 
            this.map1_photo.BackColor = System.Drawing.Color.Transparent;
            this.map1_photo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.map1_photo.Controls.Add(this.m1_input_title);
            this.map1_photo.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.map1_photo.Location = new System.Drawing.Point(563, 273);
            this.map1_photo.Margin = new System.Windows.Forms.Padding(4);
            this.map1_photo.Name = "map1_photo";
            this.map1_photo.Size = new System.Drawing.Size(233, 145);
            this.map1_photo.TabIndex = 29;
            this.map1_photo.Click += new System.EventHandler(this.mapPhoto_Click);
            // 
            // m1_input_title
            // 
            this.m1_input_title.BackAlpha = 0;
            this.m1_input_title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.m1_input_title.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.m1_input_title.Font = new System.Drawing.Font("Browallia New", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m1_input_title.ForeColor = System.Drawing.Color.Black;
            this.m1_input_title.Location = new System.Drawing.Point(7, 23);
            this.m1_input_title.Margin = new System.Windows.Forms.Padding(4);
            this.m1_input_title.Multiline = true;
            this.m1_input_title.Name = "m1_input_title";
            this.m1_input_title.ReadOnly = true;
            this.m1_input_title.Size = new System.Drawing.Size(220, 112);
            this.m1_input_title.TabIndex = 0;
            this.m1_input_title.TabStop = false;
            this.m1_input_title.Text = "ชื่อเรื่อง";
            this.m1_input_title.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.m1_input_title.MouseCaptureChanged += new System.EventHandler(this.input_Click);
            // 
            // pnEditWord
            // 
            this.pnEditWord.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnEditWord.BackColor = System.Drawing.Color.White;
            this.pnEditWord.Controls.Add(this.label1);
            this.pnEditWord.Controls.Add(this.btnSaveEditWord);
            this.pnEditWord.Controls.Add(this.btnBackEditWord);
            this.pnEditWord.Controls.Add(this.richEdit1);
            this.pnEditWord.Controls.Add(this.pnImageEditWord);
            this.pnEditWord.Location = new System.Drawing.Point(-377, -7);
            this.pnEditWord.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnEditWord.Name = "pnEditWord";
            this.pnEditWord.Size = new System.Drawing.Size(1373, 708);
            this.pnEditWord.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Browallia New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(192, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 39);
            this.label1.TabIndex = 12;
            this.label1.Text = "แก้ไขข้อความ";
            // 
            // richEdit1
            // 
            this.richEdit1.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Simple;
            this.richEdit1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.richEdit1.Appearance.Text.Font = new System.Drawing.Font("Browallia New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richEdit1.Appearance.Text.Options.UseFont = true;
            this.richEdit1.DocumentViewDirection = DevExpress.XtraRichEdit.DocumentViewDirection.LeftToRight;
            this.richEdit1.LayoutUnit = DevExpress.XtraRichEdit.DocumentLayoutUnit.Pixel;
            this.richEdit1.Location = new System.Drawing.Point(191, 250);
            this.richEdit1.Margin = new System.Windows.Forms.Padding(4);
            this.richEdit1.MenuManager = this.ribbonMainControl;
            this.richEdit1.Name = "richEdit1";
            this.richEdit1.Options.DocumentSaveOptions.CurrentFormat = DevExpress.XtraRichEdit.DocumentFormat.OpenXml;
            this.richEdit1.Size = new System.Drawing.Size(1032, 188);
            this.richEdit1.TabIndex = 7;
            this.richEdit1.Text = "richEdit1";
            this.richEdit1.TextChanged += new System.EventHandler(this.richEdit_TextChanged);
            // 
            // pnImageEditWord
            // 
            this.pnImageEditWord.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnImageEditWord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnImageEditWord.Location = new System.Drawing.Point(560, 0);
            this.pnImageEditWord.Name = "pnImageEditWord";
            this.pnImageEditWord.Size = new System.Drawing.Size(296, 200);
            this.pnImageEditWord.TabIndex = 21;
            // 
            // pnOutline
            // 
            this.pnOutline.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnOutline.BackColor = System.Drawing.Color.White;
            this.pnOutline.Controls.Add(this.richEditReader);
            this.pnOutline.Controls.Add(this.panelReader);
            this.pnOutline.Controls.Add(this.tbOutlineTitle);
            this.pnOutline.Controls.Add(this.listWord1);
            this.pnOutline.Controls.Add(this.listWord);
            this.pnOutline.Location = new System.Drawing.Point(-370, -7);
            this.pnOutline.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnOutline.Name = "pnOutline";
            this.pnOutline.Size = new System.Drawing.Size(1360, 708);
            this.pnOutline.TabIndex = 7;
            // 
            // richEditReader
            // 
            this.richEditReader.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Simple;
            this.richEditReader.Appearance.Text.Font = new System.Drawing.Font("Browallia New", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richEditReader.Appearance.Text.Options.UseFont = true;
            this.richEditReader.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.richEditReader.DocumentViewDirection = DevExpress.XtraRichEdit.DocumentViewDirection.LeftToRight;
            this.richEditReader.LayoutUnit = DevExpress.XtraRichEdit.DocumentLayoutUnit.Pixel;
            this.richEditReader.Location = new System.Drawing.Point(208, 570);
            this.richEditReader.MenuManager = this.ribbonMainControl;
            this.richEditReader.Name = "richEditReader";
            this.richEditReader.Options.Behavior.Zooming = DevExpress.XtraRichEdit.DocumentCapability.Hidden;
            this.richEditReader.Options.HorizontalScrollbar.Visibility = DevExpress.XtraRichEdit.RichEditScrollbarVisibility.Hidden;
            this.richEditReader.Options.Layout.SimpleView.AllowTablesToExtendIntoMargins = false;
            this.richEditReader.Options.Layout.SimpleView.MatchHorizontalTableIndentsToTextEdge = false;
            this.richEditReader.Options.VerticalScrollbar.Visibility = DevExpress.XtraRichEdit.RichEditScrollbarVisibility.Hidden;
            this.richEditReader.Overtype = true;
            this.richEditReader.ReadOnly = true;
            this.richEditReader.Size = new System.Drawing.Size(937, 102);
            this.richEditReader.TabIndex = 0;
            // 
            // panelReader
            // 
            this.panelReader.BackgroundImage = global::LDWordProcessor.Properties.Resources.screen_reader;
            this.panelReader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelReader.Location = new System.Drawing.Point(191, 554);
            this.panelReader.Name = "panelReader";
            this.panelReader.Size = new System.Drawing.Size(977, 135);
            this.panelReader.TabIndex = 3;
            // 
            // tbOutlineTitle
            // 
            this.tbOutlineTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbOutlineTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbOutlineTitle.Font = new System.Drawing.Font("Browallia New", 20.25F);
            this.tbOutlineTitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tbOutlineTitle.Location = new System.Drawing.Point(191, 37);
            this.tbOutlineTitle.Margin = new System.Windows.Forms.Padding(4);
            this.tbOutlineTitle.Name = "tbOutlineTitle";
            this.tbOutlineTitle.Size = new System.Drawing.Size(977, 50);
            this.tbOutlineTitle.TabIndex = 2;
            this.tbOutlineTitle.Text = "หัวข้อ";
            this.tbOutlineTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // listWord1
            // 
            this.listWord1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listWord1.AutoScroll = true;
            this.listWord1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.listWord1.BackgroundImage = global::LDWordProcessor.Properties.Resources.screen;
            this.listWord1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.listWord1.Location = new System.Drawing.Point(191, 111);
            this.listWord1.Margin = new System.Windows.Forms.Padding(4);
            this.listWord1.Name = "listWord1";
            this.listWord1.Padding = new System.Windows.Forms.Padding(7, 31, 7, 31);
            this.listWord1.Size = new System.Drawing.Size(977, 431);
            this.listWord1.TabIndex = 1;
            this.listWord1.TabStop = true;
            // 
            // listWord
            // 
            this.listWord.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listWord.AutoScroll = true;
            this.listWord.BackColor = System.Drawing.SystemColors.ControlLight;
            this.listWord.BackgroundImage = global::LDWordProcessor.Properties.Resources.screen_word;
            this.listWord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.listWord.Location = new System.Drawing.Point(191, 554);
            this.listWord.Margin = new System.Windows.Forms.Padding(4);
            this.listWord.Name = "listWord";
            this.listWord.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.listWord.Size = new System.Drawing.Size(977, 135);
            this.listWord.TabIndex = 1;
            this.listWord.TabStop = true;

            //
            //fixSizeMindmap();
            //


            fixSizeMindmap();


            // 
            // pnMain
            // 
            this.pnMain.BackColor = System.Drawing.Color.White;
            this.pnMain.Controls.Add(this.pnOutline);
            this.pnMain.Controls.Add(this.pnMainMindmap);
            this.pnMain.Controls.Add(this.pnEditWord);
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.Font = new System.Drawing.Font("Browallia New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.pnMain.Location = new System.Drawing.Point(0, 145);
            this.pnMain.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.pnMain.Name = "pnMain";
            this.pnMain.TabIndex = 1;
            this.pnMain.Size = new System.Drawing.Size(640, 693);
            if (_ScreenWidth >= 1500)
            {
                this.pnMain.Size = new System.Drawing.Size(1600, 900);
            }
    
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(61, 4);
            // 
            // PopupMenu
            // 
            this.PopupMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PopupMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.PopupMenu.Name = "contextMenuStrip1";
            this.PopupMenu.Size = new System.Drawing.Size(61, 4);
            // 
            // timerReader
            // 
            this.timerReader.Interval = 1500;
            this.timerReader.Tick += new System.EventHandler(this.timerReader_Tick);
            
            // 
            // KCW_MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1540, 838);
            this.Controls.Add(this.pnMain);
            this.Controls.Add(this.docPnOutline);
            this.Controls.Add(this.docPnEditWord);
            this.Controls.Add(this.docPnMindmap);
            this.Controls.Add(this.ribbonMainControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.MinimumSize = new System.Drawing.Size(1533, 819);
            this.Name = "KCW_MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ระบบบริการช่วยเขียนภาษาไทยตามจินตภาพ (KidCanWrite)";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.KCW_MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonMainControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemColorEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTrackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemToggleSwitch1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemToggleSwitch2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            this.docPnMindmap.ResumeLayout(false);
            this.controlContainer3.ResumeLayout(false);
            this.docPnEditWord.ResumeLayout(false);
            this.dockPanel1_Container.ResumeLayout(false);
            this.docPnOutline.ResumeLayout(false);
            this.controlContainer1.ResumeLayout(false);
            this.pnVerb.ResumeLayout(false);
            this.pnVerb.PerformLayout();
            this.pnMainMindmap.ResumeLayout(false);
            this.pnMainMindmap4.ResumeLayout(false);
            this.pnMainMindmap4.PerformLayout();
            this.map4_photo.ResumeLayout(false);
            this.map4_photo.PerformLayout();
            this.pnMainMindmap3.ResumeLayout(false);
            this.pnMainMindmap3.PerformLayout();
            this.map3_photo.ResumeLayout(false);
            this.map3_photo.PerformLayout();
            this.pnMainMindmap2.ResumeLayout(false);
            this.pnMainMindmap2.PerformLayout();
            this.map2_photo.ResumeLayout(false);
            this.map2_photo.PerformLayout();
            this.pnMainMindmap1.ResumeLayout(false);
            this.pnMainMindmap1.PerformLayout();
            this.map1_photo.ResumeLayout(false);
            this.map1_photo.PerformLayout();
            this.pnEditWord.ResumeLayout(false);
            this.pnEditWord.PerformLayout();
            this.pnOutline.ResumeLayout(false);
            this.pnOutline.PerformLayout();
            this.pnMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();


            


        }


        //แก้ไขขนาดของ Mindmap เมื่อ resolution width >= 1500

        public void fixSizeMindmap()
        {
            //int _ScreenWidth = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width;
            //int _ScreenHeight = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height;


            //this.pnMain.BackColor = System.Drawing.Color.Blue;
            //this.pnMainMindmap.BackColor = System.Drawing.Color.Aqua;

            /**
            this.m1_input_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.m1_input_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.m1_input_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.m1_input_4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.m1_input_5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.m1_input_6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.m1_input_7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.m1_input_8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.m1_input_9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.m1_input_10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.m1_input_11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.m1_input_12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;


            //**/

            if (_ScreenWidth >= 1500)
            {

                this.pnEditWord.Location = new System.Drawing.Point(100, 100);
                this.pnEditWord.Size = new System.Drawing.Size(1600, 900);

                this.pnOutline.Location = new System.Drawing.Point(100, 50);
                this.pnOutline.Size = new System.Drawing.Size(1600, 900);

                this.pnMainMindmap.Size = new Size(1600, 900);
               this.pnMainMindmap.Location = new Point(-50, 50);

                // Mindmap 1
                this.pnMainMindmap1.Size = new Size(1600, 800);
                this.map1_photo.Size = new Size(273, 170);
                this.map1_photo.Location = new Point(650, 310);

                this.m1_input_1.Location = new System.Drawing.Point(1110, 380);
                this.m1_input_2.Location = new System.Drawing.Point(1340, 86);
                this.m1_input_3.Location = new System.Drawing.Point(1340, 205);
                this.m1_input_4.Location = new System.Drawing.Point(1340, 555);
                this.m1_input_5.Location = new System.Drawing.Point(1345, 685);
                this.m1_input_6.Location = new System.Drawing.Point(455, 177);
                this.m1_input_7.Location = new System.Drawing.Point(57, 71);
                this.m1_input_8.Location = new System.Drawing.Point(51, 173);
                this.m1_input_9.Location = new System.Drawing.Point(55, 300);
                this.m1_input_10.Location = new System.Drawing.Point(405, 575);
                this.m1_input_11.Location = new System.Drawing.Point(64, 475);
                this.m1_input_12.Location = new System.Drawing.Point(64, 675);

                this.m1_label_1.Location = new System.Drawing.Point(1030, 455);
                this.m1_label_2.Location = new System.Drawing.Point(1230, 20);
                this.m1_label_3.Location = new System.Drawing.Point(1280, 284);
                this.m1_label_4.Location = new System.Drawing.Point(1280, 500);
                this.m1_label_5.Location = new System.Drawing.Point(1280, 750);
                this.m1_label_6.Location = new System.Drawing.Point(500, 90);
                this.m1_label_7.Location = new System.Drawing.Point(80, 10);
                this.m1_label_8.Location = new System.Drawing.Point(60, 233);
                this.m1_label_9.Location = new System.Drawing.Point(60, 364);
                this.m1_label_10.Location = new System.Drawing.Point(680, 620);
                this.m1_label_11.Location = new System.Drawing.Point(340, 440);
                this.m1_label_12.Location = new System.Drawing.Point(340, 700);

                this.m1_btn_1.Location = new System.Drawing.Point(980, 455);
                this.m1_btn_2.Location = new System.Drawing.Point(1180, 20);
                this.m1_btn_3.Location = new System.Drawing.Point(1230, 284);
                this.m1_btn_4.Location = new System.Drawing.Point(1230, 500);
                this.m1_btn_5.Location = new System.Drawing.Point(1230, 750);
                this.m1_btn_6.Location = new System.Drawing.Point(450, 90);
                this.m1_btn_7.Location = new System.Drawing.Point(30, 10);
                this.m1_btn_8.Location = new System.Drawing.Point(10, 233);
                this.m1_btn_9.Location = new System.Drawing.Point(10, 364);
                this.m1_btn_10.Location = new System.Drawing.Point(630, 620);
                this.m1_btn_11.Location = new System.Drawing.Point(290, 440);
                this.m1_btn_12.Location = new System.Drawing.Point(290, 700);

                this.m1_label_rp_1.Location = new System.Drawing.Point(950, 455);
                this.m1_label_rp_2.Location = new System.Drawing.Point(1150, 20);
                this.m1_label_rp_3.Location = new System.Drawing.Point(1200, 284);
                this.m1_label_rp_4.Location = new System.Drawing.Point(1200, 500);
                this.m1_label_rp_5.Location = new System.Drawing.Point(1200, 750);
                this.m1_label_rp_6.Location = new System.Drawing.Point(500, 90);
                this.m1_label_rp_7.Location = new System.Drawing.Point(80, 10);
                this.m1_label_rp_8.Location = new System.Drawing.Point(56, 223);
                this.m1_label_rp_9.Location = new System.Drawing.Point(73, 324);
                this.m1_label_rp_10.Location = new System.Drawing.Point(599, 533);
                this.m1_label_rp_11.Location = new System.Drawing.Point(297, 384);
                this.m1_label_rp_12.Location = new System.Drawing.Point(296, 612);

                this.m1_label_rp_1.Hide();
                this.m1_label_rp_2.Hide();
                this.m1_label_rp_3.Hide();
                this.m1_label_rp_4.Hide();
                this.m1_label_rp_5.Hide();
                this.m1_label_rp_6.Hide();
                this.m1_label_rp_7.Hide();
                this.m1_label_rp_8.Hide();
                this.m1_label_rp_9.Hide();
                this.m1_label_rp_10.Hide();
                this.m1_label_rp_11.Hide();
                this.m1_label_rp_12.Hide();

                //Mindmap 2
                this.pnMainMindmap2.Size = new System.Drawing.Size(1600, 800);
                this.map2_photo.Size = new System.Drawing.Size(273, 170);
                this.map2_photo.Location = new System.Drawing.Point(750, 310);

                this.m2_input_1.Location = new System.Drawing.Point(1140, 340);
                this.m2_input_2.Location = new System.Drawing.Point(1033, 113);
                this.m2_input_3.Location = new System.Drawing.Point(1330, 153);
                this.m2_input_4.Location = new System.Drawing.Point(1320, 525);
                this.m2_input_5.Location = new System.Drawing.Point(1055, 583);
                this.m2_input_6.Location = new System.Drawing.Point(458, 254);
                this.m2_input_7.Location = new System.Drawing.Point(175, 240);
                this.m2_input_8.Location = new System.Drawing.Point(200, 84);
                this.m2_input_9.Location = new System.Drawing.Point(610, 81);
                this.m2_input_10.Location = new System.Drawing.Point(455, 460);
                this.m2_input_11.Location = new System.Drawing.Point(165, 460);
                this.m2_input_12.Location = new System.Drawing.Point(310, 670);

                this.m2_btn_1.Location = new System.Drawing.Point(1330, 310);
                this.m2_btn_2.Location = new System.Drawing.Point(980, 30);
                this.m2_btn_3.Location = new System.Drawing.Point(1280, 60);
                this.m2_btn_4.Location = new System.Drawing.Point(1270, 615);
                this.m2_btn_5.Location = new System.Drawing.Point(980, 673);
                this.m2_btn_6.Location = new System.Drawing.Point(458, 330);
                this.m2_btn_7.Location = new System.Drawing.Point(125, 310);
                this.m2_btn_8.Location = new System.Drawing.Point(77, 4);
                this.m2_btn_9.Location = new System.Drawing.Point(630, 145);
                this.m2_btn_10.Location = new System.Drawing.Point(613, 516);
                this.m2_btn_11.Location = new System.Drawing.Point(136, 521);
                this.m2_btn_12.Location = new System.Drawing.Point(509, 682);

                this.m2_label_1.Location = new System.Drawing.Point(1380, 310);
                this.m2_label_2.Location = new System.Drawing.Point(1030, 30);
                this.m2_label_3.Location = new System.Drawing.Point(1330, 60);
                this.m2_label_4.Location = new System.Drawing.Point(1320, 615);
                this.m2_label_5.Location = new System.Drawing.Point(1030, 673);
                this.m2_label_6.Location = new System.Drawing.Point(508, 330);
                this.m2_label_7.Location = new System.Drawing.Point(175, 310);
                this.m2_label_9.Location = new System.Drawing.Point(680, 145);
                this.m2_label_10.Location = new System.Drawing.Point(663, 516);
                this.m2_label_11.Location = new System.Drawing.Point(186, 521);
                this.m2_label_12.Location = new System.Drawing.Point(559, 682);

                this.m2_label_rp_1.Hide();
                this.m2_label_rp_2.Hide();
                this.m2_label_rp_3.Hide();
                this.m2_label_rp_4.Hide();
                this.m2_label_rp_5.Hide();
                this.m2_label_rp_6.Hide();
                this.m2_label_rp_7.Hide();
                this.m2_label_rp_8.Hide();
                this.m2_label_rp_9.Hide();
                this.m2_label_rp_10.Hide();
                this.m2_label_rp_11.Hide();
                this.m2_label_rp_12.Hide();

                //Mindmap 3
                this.pnMainMindmap3.Size = new System.Drawing.Size(1600, 800);
                this.map3_photo.Size = new System.Drawing.Size(273, 170);
                this.map3_photo.Location = new System.Drawing.Point(670, 460);

                this.m3_input_1.Location = new System.Drawing.Point(1010, 385);
                this.m3_input_2.Location = new System.Drawing.Point(1180, 143);
                this.m3_input_3.Location = new System.Drawing.Point(1345, 340);
                this.m3_input_4.Location = new System.Drawing.Point(1305, 580);
                this.m3_input_5.Location = new System.Drawing.Point(1030, 670);
                this.m3_input_6.Location = new System.Drawing.Point(460, 370);
                this.m3_input_7.Location = new System.Drawing.Point(225, 154);
                this.m3_input_8.Location = new System.Drawing.Point(125, 330);
                this.m3_input_9.Location = new System.Drawing.Point(180, 585);
                this.m3_input_10.Location = new System.Drawing.Point(720, 268);
                this.m3_input_11.Location = new System.Drawing.Point(525, 97);
                this.m3_input_12.Location = new System.Drawing.Point(935, 97);

                this.m3_btn_1.Location = new System.Drawing.Point(950, 250);
                this.m3_btn_2.Location = new System.Drawing.Point(1150, 54);
                this.m3_btn_3.Location = new System.Drawing.Point(1220, 240);
                this.m3_btn_4.Location = new System.Drawing.Point(1250, 450);
                this.m3_btn_5.Location = new System.Drawing.Point(1170, 700);
                this.m3_btn_6.Location = new System.Drawing.Point(400, 520);
                this.m3_btn_7.Location = new System.Drawing.Point(100, 70);
                this.m3_btn_8.Location = new System.Drawing.Point(40, 440);
                this.m3_btn_9.Location = new System.Drawing.Point(50, 690);
                this.m3_btn_10.Location = new System.Drawing.Point(650, 180);
                this.m3_btn_11.Location = new System.Drawing.Point(450, 10);
                this.m3_btn_12.Location = new System.Drawing.Point(850, 10);

                this.m3_label_1.Location = new System.Drawing.Point(1000, 250);
                this.m3_label_2.Location = new System.Drawing.Point(1200, 54);
                this.m3_label_3.Location = new System.Drawing.Point(1270, 240);
                this.m3_label_4.Location = new System.Drawing.Point(1300, 450);
                this.m3_label_5.Location = new System.Drawing.Point(1220, 700);
                this.m3_label_6.Location = new System.Drawing.Point(450, 529);
                this.m3_label_7.Location = new System.Drawing.Point(150, 70);
                this.m3_label_8.Location = new System.Drawing.Point(90, 440);
                this.m3_label_9.Location = new System.Drawing.Point(100, 690);
                this.m3_label_10.Location = new System.Drawing.Point(700, 180);
                this.m3_label_11.Location = new System.Drawing.Point(500, 10);
                this.m3_label_12.Location = new System.Drawing.Point(900, 10);

                this.m3_label_rp_1.Hide();
                this.m3_label_rp_2.Hide();
                this.m3_label_rp_3.Hide();
                this.m3_label_rp_4.Hide();
                this.m3_label_rp_5.Hide();
                this.m3_label_rp_6.Hide();
                this.m3_label_rp_7.Hide();
                this.m3_label_rp_8.Hide();
                this.m3_label_rp_9.Hide();
                this.m3_label_rp_10.Hide();
                this.m3_label_rp_11.Hide();
                this.m3_label_rp_12.Hide();

                //Mindmap 4
                this.pnMainMindmap4.Size = new System.Drawing.Size(1600, 800);
                this.map4_photo.Size = new System.Drawing.Size(300, 220);
                this.map4_photo.Location = new System.Drawing.Point(630, 370);

                this.m4_input_1.Location = new System.Drawing.Point(1045, 410);
                this.m4_input_2.Location = new System.Drawing.Point(1235, 210);
                this.m4_input_3.Location = new System.Drawing.Point(1285, 330);
                this.m4_input_4.Location = new System.Drawing.Point(1285, 470);
                this.m4_input_5.Location = new System.Drawing.Point(1220, 620);
                this.m4_input_6.Location = new System.Drawing.Point(390, 410);
                this.m4_input_7.Location = new System.Drawing.Point(190, 240);
                this.m4_input_8.Location = new System.Drawing.Point(130, 410);
                this.m4_input_9.Location = new System.Drawing.Point(195, 590);

                this.m4_input_10.Location = new System.Drawing.Point(715, 135);
                this.m4_input_11.Location = new System.Drawing.Point(400, 102);
                this.m4_input_12.Location = new System.Drawing.Point(1000, 107);

                this.m4_btn_1.Location = new System.Drawing.Point(1010, 500);
                this.m4_btn_2.Location = new System.Drawing.Point(1180, 144);
                this.m4_btn_3.Location = new System.Drawing.Point(1180, 290);
                this.m4_btn_4.Location = new System.Drawing.Point(1225, 530);
                this.m4_btn_5.Location = new System.Drawing.Point(1170, 680);
                this.m4_btn_6.Location = new System.Drawing.Point(340, 490);
                this.m4_btn_7.Location = new System.Drawing.Point(160, 180);
                this.m4_btn_8.Location = new System.Drawing.Point(100, 320);
                this.m4_btn_9.Location = new System.Drawing.Point(165, 650);

                this.m4_btn_10.Location = new System.Drawing.Point(685, 215);
                this.m4_btn_11.Location = new System.Drawing.Point(370, 40);
                this.m4_btn_12.Location = new System.Drawing.Point(970, 50);


                this.m4_label_1.Location = new System.Drawing.Point(1060, 500);
                this.m4_label_2.Location = new System.Drawing.Point(1230, 144);
                this.m4_label_3.Location = new System.Drawing.Point(1230, 290);
                this.m4_label_4.Location = new System.Drawing.Point(1275, 530);
                this.m4_label_5.Location = new System.Drawing.Point(1220, 680);
                this.m4_label_6.Location = new System.Drawing.Point(390, 490);
                this.m4_label_7.Location = new System.Drawing.Point(210, 180);
                this.m4_label_8.Location = new System.Drawing.Point(150, 320);
                this.m4_label_9.Location = new System.Drawing.Point(215, 650);
                this.m4_label_10.Location = new System.Drawing.Point(735, 215);
                this.m4_label_11.Location = new System.Drawing.Point(420, 40);
                this.m4_label_12.Location = new System.Drawing.Point(1020, 50);

                this.m4_label_rp_1.Hide();
                this.m4_label_rp_2.Hide();
                this.m4_label_rp_3.Hide();
                this.m4_label_rp_4.Hide();
                this.m4_label_rp_5.Hide();
                this.m4_label_rp_6.Hide();
                this.m4_label_rp_7.Hide();
                this.m4_label_rp_8.Hide();
                this.m4_label_rp_9.Hide();
                this.m4_label_rp_10.Hide();
                this.m4_label_rp_11.Hide();
                this.m4_label_rp_12.Hide();

            }

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonMainControl;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonGroupLayout;
        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private System.Windows.Forms.Panel pnMainMindmap;
        private System.Windows.Forms.Panel pnMainMindmap1;
        private DevExpress.XtraBars.Docking.DockPanel docPnEditWord;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private ZBobb.AlphaBlendTextBox m1_input_5;
        private ZBobb.AlphaBlendTextBox m1_input_4;
        private ZBobb.AlphaBlendTextBox m1_input_3;
        private ZBobb.AlphaBlendTextBox m1_input_2;
        private ZBobb.AlphaBlendTextBox m1_input_12;
        private ZBobb.AlphaBlendTextBox m1_input_9;
        private ZBobb.AlphaBlendTextBox m1_input_11;
        private ZBobb.AlphaBlendTextBox m1_input_8;
        private ZBobb.AlphaBlendTextBox m1_input_7;
        private ZBobb.AlphaBlendTextBox m1_input_10;
        private ZBobb.AlphaBlendTextBox m1_input_1;
        private ZBobb.AlphaBlendTextBox m1_input_6;
        private System.Windows.Forms.Label m1_label_11;
        private System.Windows.Forms.Label m1_label_8;
        private System.Windows.Forms.Label m1_label_9;
        private System.Windows.Forms.Label m1_label_7;
        private System.Windows.Forms.Label m1_label_6;
        private System.Windows.Forms.Label m1_label_12;
        private System.Windows.Forms.Label m1_label_10;
        private System.Windows.Forms.Label m1_label_5;
        private System.Windows.Forms.Label m1_label_4;
        private System.Windows.Forms.Label m1_label_3;
        private System.Windows.Forms.Label m1_label_2;
        private System.Windows.Forms.Panel map1_photo;
        private ZBobb.AlphaBlendTextBox m1_input_title;
        private System.Windows.Forms.Panel pnMainMindmap2;
        private ZBobb.AlphaBlendTextBox m2_input_5;
        private ZBobb.AlphaBlendTextBox m2_input_4;
        private ZBobb.AlphaBlendTextBox m2_input_3;
        private ZBobb.AlphaBlendTextBox m2_input_2;
        private ZBobb.AlphaBlendTextBox m2_input_12;
        private ZBobb.AlphaBlendTextBox m2_input_9;
        private ZBobb.AlphaBlendTextBox m2_input_11;
        private ZBobb.AlphaBlendTextBox m2_input_8;
        private ZBobb.AlphaBlendTextBox m2_input_7;
        private ZBobb.AlphaBlendTextBox m2_input_10;
        private ZBobb.AlphaBlendTextBox m2_input_1;
        private ZBobb.AlphaBlendTextBox m2_input_6;
        private System.Windows.Forms.Label m2_label_11;
        private System.Windows.Forms.Label m2_label_8;
        private System.Windows.Forms.Label m2_label_9;
        private System.Windows.Forms.Label m2_label_7;
        private System.Windows.Forms.Label m2_label_6;
        private System.Windows.Forms.Label m2_label_12;
        private System.Windows.Forms.Label m2_label_10;
        private System.Windows.Forms.Label m2_label_5;
        private System.Windows.Forms.Label m2_label_4;
        private System.Windows.Forms.Label m2_label_3;
        private System.Windows.Forms.Label m2_label_2;
        private System.Windows.Forms.Label m2_label_1;
        private System.Windows.Forms.Panel map2_photo;
        private ZBobb.AlphaBlendTextBox m2_input_title;
        private System.Windows.Forms.Panel pnMainMindmap3;
        private ZBobb.AlphaBlendTextBox m3_input_5;
        private ZBobb.AlphaBlendTextBox m3_input_4;
        private ZBobb.AlphaBlendTextBox m3_input_3;
        private ZBobb.AlphaBlendTextBox m3_input_2;
        private ZBobb.AlphaBlendTextBox m3_input_12;
        private ZBobb.AlphaBlendTextBox m3_input_9;
        private ZBobb.AlphaBlendTextBox m3_input_11;
        private ZBobb.AlphaBlendTextBox m3_input_8;
        private ZBobb.AlphaBlendTextBox m3_input_7;
        private ZBobb.AlphaBlendTextBox m3_input_10;
        private ZBobb.AlphaBlendTextBox m3_input_1;
        private ZBobb.AlphaBlendTextBox m3_input_6;
        private System.Windows.Forms.Label m3_label_11;
        private System.Windows.Forms.Label m3_label_8;
        private System.Windows.Forms.Label m3_label_9;
        private System.Windows.Forms.Label m3_label_7;
        private System.Windows.Forms.Label m3_label_6;
        private System.Windows.Forms.Label m3_label_12;
        private System.Windows.Forms.Label m3_label_10;
        private System.Windows.Forms.Label m3_label_5;
        private System.Windows.Forms.Label m3_label_4;
        private System.Windows.Forms.Label m3_label_3;
        private System.Windows.Forms.Label m3_label_2;
        private System.Windows.Forms.Label m3_label_1;
        private System.Windows.Forms.Panel map3_photo;
        private ZBobb.AlphaBlendTextBox m3_input_title;
        private System.Windows.Forms.Panel pnMainMindmap4;
        private ZBobb.AlphaBlendTextBox m4_input_5;
        private ZBobb.AlphaBlendTextBox m4_input_9;
        private ZBobb.AlphaBlendTextBox m4_input_11;
        private ZBobb.AlphaBlendTextBox m4_input_8;
        private ZBobb.AlphaBlendTextBox m4_input_7;
        private ZBobb.AlphaBlendTextBox m4_input_10;
        private ZBobb.AlphaBlendTextBox m4_input_1;
        private ZBobb.AlphaBlendTextBox m4_input_6;
        private System.Windows.Forms.Label m4_label_11;
        private System.Windows.Forms.Label m4_label_8;
        private System.Windows.Forms.Label m4_label_9;
        private System.Windows.Forms.Label m4_label_7;
        private System.Windows.Forms.Label m4_label_6;
        private System.Windows.Forms.Label m4_label_12;
        private System.Windows.Forms.Label m4_label_10;
        private System.Windows.Forms.Label m4_label_5;
        private System.Windows.Forms.Label m4_label_4;
        private System.Windows.Forms.Label m4_label_3;
        private System.Windows.Forms.Label m4_label_2;
        private System.Windows.Forms.Label m4_label_1;
        private System.Windows.Forms.Panel map4_photo;
        private ZBobb.AlphaBlendTextBox m4_input_title;
        private System.Windows.Forms.Panel pnEditWord;
        private DevExpress.XtraRichEdit.RichEditControl richEdit1;
        private System.Windows.Forms.Panel pnOutline;
        private System.Windows.Forms.FlowLayoutPanel listVerb;
        private System.Windows.Forms.FlowLayoutPanel listWord1;

        private System.Windows.Forms.Panel pnMain;
        private System.Windows.Forms.Panel pnImageShow2;
        private DevExpress.XtraEditors.SimpleButton btnSaveEditWord;
        private DevExpress.XtraEditors.SimpleButton btnBackEditWord;
        private System.Windows.Forms.Panel pnVerb;
        //private System.Windows.Forms.Button btnSaveEditWord;
        private DevExpress.XtraBars.Docking.DockPanel docPnOutline;
        private DevExpress.XtraBars.Docking.ControlContainer controlContainer1;
        private System.Windows.Forms.Panel pnImageShow3;
        private System.Windows.Forms.Label lbVerb;
        private System.Windows.Forms.FlowLayoutPanel listWord;
        private System.Windows.Forms.Button btnSentOutline;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonGroupFormat;
        private DevExpress.XtraBars.BarListItem barListItem1;
        private DevExpress.XtraBars.BarEditItem barEditItem3;
        private System.Windows.Forms.Button btnSaveOutline;
        private System.Windows.Forms.Button btnBackOutline;

        private DevExpress.XtraBars.BarButtonItem barBttMindmap;
        private DevExpress.XtraBars.BarButtonItem barBttOutline;
        private System.Windows.Forms.Button btnSaveMindmap;
        private DevExpress.XtraBars.Docking.DockPanel docPnMindmap;
        private DevExpress.XtraBars.Docking.ControlContainer controlContainer3;
        private System.Windows.Forms.Panel pnImageShow1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private WordSearchControler wordSearchControler;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit1;
        private DevExpress.XtraBars.BarEditItem barColorPicker;
        private DevExpress.XtraEditors.Repository.RepositoryItemColorEdit repositoryItemColorEdit1;
        private AutoCompleteControler autoCompleteControler;
        private System.Windows.Forms.ContextMenuStrip PopupMenu;
        private DevExpress.XtraBars.BarButtonItem barBttToggleWS;
        private DevExpress.XtraBars.BarButtonItem barBttToggleWP;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonGroupFunction;
        private DevExpress.XtraBars.BarEditItem barFont;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox2;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
        private DevExpress.XtraBars.BarEditItem barFontSize;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox3;
        private System.Windows.Forms.TextBox tbOutlineTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label m1_label_rp_1;
        private System.Windows.Forms.Label m1_label_1;
        private System.Windows.Forms.Label m1_label_rp_2;
        private System.Windows.Forms.Label m1_label_rp_3;
        private System.Windows.Forms.Label m1_label_rp_5;
        private System.Windows.Forms.Label m1_label_rp_4;
        private System.Windows.Forms.Label m1_label_rp_7;
        private System.Windows.Forms.Label m1_label_rp_6;
        private System.Windows.Forms.Label m1_label_rp_10;
        private System.Windows.Forms.Label m1_label_rp_9;
        private System.Windows.Forms.Label m1_label_rp_8;
        private System.Windows.Forms.Label m1_label_rp_12;
        private System.Windows.Forms.Label m1_label_rp_11;
        private System.Windows.Forms.Label m2_label_rp_3;
        private System.Windows.Forms.Label m2_label_rp_2;
        private System.Windows.Forms.Label m2_label_rp_1;
        private System.Windows.Forms.Label m2_label_rp_12;
        private System.Windows.Forms.Label m2_label_rp_11;
        private System.Windows.Forms.Label m2_label_rp_10;
        private System.Windows.Forms.Label m2_label_rp_9;
        private System.Windows.Forms.Label m2_label_rp_8;
        private System.Windows.Forms.Label m2_label_rp_7;
        private System.Windows.Forms.Label m2_label_rp_6;
        private System.Windows.Forms.Label m2_label_rp_5;
        private System.Windows.Forms.Label m2_label_rp_4;
        private System.Windows.Forms.Label m3_label_rp_1;
        private System.Windows.Forms.Label m3_label_rp_2;
        private System.Windows.Forms.Label m3_label_rp_5;
        private System.Windows.Forms.Label m3_label_rp_4;
        private System.Windows.Forms.Label m3_label_rp_3;
        private System.Windows.Forms.Label m3_label_rp_9;
        private System.Windows.Forms.Label m3_label_rp_8;
        private System.Windows.Forms.Label m3_label_rp_7;
        private System.Windows.Forms.Label m3_label_rp_6;
        private System.Windows.Forms.Label m3_label_rp_10;
        private System.Windows.Forms.Label m3_label_rp_12;
        private System.Windows.Forms.Label m3_label_rp_11;
        private System.Windows.Forms.Label m4_label_rp_1;
        private System.Windows.Forms.Label m4_label_rp_3;
        private System.Windows.Forms.Label m4_label_rp_2;
        private System.Windows.Forms.Label m4_label_rp_4;
        private System.Windows.Forms.Label m4_label_rp_5;
        private System.Windows.Forms.Label m4_label_rp_6;
        private System.Windows.Forms.Label m4_label_rp_9;
        private System.Windows.Forms.Label m4_label_rp_8;
        private System.Windows.Forms.Label m4_label_rp_11;
        private System.Windows.Forms.Label m4_label_rp_7;
        private System.Windows.Forms.Label m4_label_rp_10;
        private System.Windows.Forms.Label m4_label_rp_12;
        private DevExpress.XtraBars.BarButtonItem barBttReading;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonGroupTool;
        private System.Windows.Forms.TextBox tbVerbFilter;
       // private DevExpress.XtraBars.BarButtonItem barBttHelp;
        public ZBobb.AlphaBlendTextBox m4_input_4;
        public ZBobb.AlphaBlendTextBox m4_input_3;
        public ZBobb.AlphaBlendTextBox m4_input_2;
        public ZBobb.AlphaBlendTextBox m4_input_12;
        private DevExpress.XtraBars.BarEditItem tbVoiceSpeed;
        private DevExpress.XtraEditors.Repository.RepositoryItemTrackBar repositoryItemTrackBar1;
        private System.Windows.Forms.Panel pnImageEditWord;
        private DevExpress.XtraEditors.SimpleButton m4_btn_12;
        private DevExpress.XtraEditors.SimpleButton m4_btn_11;
        private DevExpress.XtraEditors.SimpleButton m4_btn_10;
        private DevExpress.XtraEditors.SimpleButton m4_btn_9;
        private DevExpress.XtraEditors.SimpleButton m4_btn_8;
        private DevExpress.XtraEditors.SimpleButton m4_btn_7;
        private DevExpress.XtraEditors.SimpleButton m4_btn_6;
        private DevExpress.XtraEditors.SimpleButton m4_btn_5;
        private DevExpress.XtraEditors.SimpleButton m4_btn_4;
        private DevExpress.XtraEditors.SimpleButton m4_btn_3;
        private DevExpress.XtraEditors.SimpleButton m4_btn_2;
        private DevExpress.XtraEditors.SimpleButton m4_btn_1;
        private DevExpress.XtraEditors.SimpleButton m3_btn_12;
        private DevExpress.XtraEditors.SimpleButton m3_btn_11;
        private DevExpress.XtraEditors.SimpleButton m3_btn_10;
        private DevExpress.XtraEditors.SimpleButton m3_btn_9;
        private DevExpress.XtraEditors.SimpleButton m3_btn_8;
        private DevExpress.XtraEditors.SimpleButton m3_btn_7;
        private DevExpress.XtraEditors.SimpleButton m3_btn_6;
        private DevExpress.XtraEditors.SimpleButton m3_btn_5;
        private DevExpress.XtraEditors.SimpleButton m3_btn_4;
        private DevExpress.XtraEditors.SimpleButton m3_btn_3;
        private DevExpress.XtraEditors.SimpleButton m3_btn_2;
        private DevExpress.XtraEditors.SimpleButton m3_btn_1;
        private DevExpress.XtraEditors.SimpleButton m2_btn_12;
        private DevExpress.XtraEditors.SimpleButton m2_btn_11;
        private DevExpress.XtraEditors.SimpleButton m2_btn_10;
        private DevExpress.XtraEditors.SimpleButton m2_btn_9;
        private DevExpress.XtraEditors.SimpleButton m2_btn_8;
        private DevExpress.XtraEditors.SimpleButton m2_btn_7;
        private DevExpress.XtraEditors.SimpleButton m2_btn_6;
        private DevExpress.XtraEditors.SimpleButton m2_btn_5;
        private DevExpress.XtraEditors.SimpleButton m2_btn_4;
        private DevExpress.XtraEditors.SimpleButton m2_btn_3;
        private DevExpress.XtraEditors.SimpleButton m2_btn_2;
        private DevExpress.XtraEditors.SimpleButton m2_btn_1;
        private DevExpress.XtraEditors.SimpleButton m1_btn_12;
        private DevExpress.XtraEditors.SimpleButton m1_btn_11;
        private DevExpress.XtraEditors.SimpleButton m1_btn_10;
        private DevExpress.XtraEditors.SimpleButton m1_btn_9;
        private DevExpress.XtraEditors.SimpleButton m1_btn_8;
        private DevExpress.XtraEditors.SimpleButton m1_btn_7;
        private DevExpress.XtraEditors.SimpleButton m1_btn_6;
        private DevExpress.XtraEditors.SimpleButton m1_btn_5;
        private DevExpress.XtraEditors.SimpleButton m1_btn_4;
        private DevExpress.XtraEditors.SimpleButton m1_btn_3;
        private DevExpress.XtraEditors.SimpleButton m1_btn_2;
        private DevExpress.XtraEditors.SimpleButton m1_btn_1;
        private DevExpress.XtraRichEdit.RichEditControl richEditReader;
        private System.Windows.Forms.Panel panelReader;
        private System.Windows.Forms.Timer timerReader;
        private DevExpress.XtraBars.BarEditItem barEditItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemToggleSwitch repositoryItemToggleSwitch1;
        private DevExpress.XtraBars.BarEditItem barTgRead;
        private DevExpress.XtraEditors.Repository.RepositoryItemToggleSwitch repositoryItemToggleSwitch2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonGroupSetting;
    }
}