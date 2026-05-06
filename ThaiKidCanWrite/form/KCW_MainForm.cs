using DevExpress.XtraEditors;
using DevExpress.XtraRichEdit;
using LDWordProcessor.controls;
using LDWordProcessor.genius;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;
using NLog;
using LDWordProcessor.db;
using System.Collections;
using System.IO;
using DevExpress.XtraBars;
using System.Diagnostics;
using DevExpress.XtraRichEdit.API.Native;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Ribbon.ViewInfo;

namespace LDWordProcessor.form
{
    public partial class KCW_MainForm : Form
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        private WebClient wc = new WebClient();
        private Mapinput DTMapInput = new Mapinput();
        RichEditControl richEdit;
        private System.Windows.Forms.TextBox tbSelect;
        //private Label labelSelect;
        private DevExpress.XtraEditors.SimpleButton buttonSelect;
        private Panel mapPhotoSelect;

        private RichEditHelper iRichHelper, iRichHelper_reader;
        private TextReader textReader, textReader_reader;
        private Trie.LongLexTo Tokenizer;
        private List<DocumentPage2> documentPage2 = new List<DocumentPage2>();
        private DocumentPage2 documentPageCurrent = new DocumentPage2();

        private string MindMapType = "M1";
        private string CurrentPage = "MM";

        static int VALIDATION_DELAY = 500;
        System.Threading.Timer timer = null;

        private string[] suggestWord;
        private string[] status;
        private string oldWord = "";

        // private string helpFile = "D:\\help.chm";
        //private string helpFile = Environment.CurrentDirectory + "\\data\\help.pdf";
        //Environment.CurrentDirectory + "\\help.chm";
        private Process helpProcID;
        private const string helpHeader = "KidCanWrite";
        private int ReaderSpeed;

        private string ResolveAssetPath(string relativePath)
        {
            string[] candidatePaths =
            {
                Path.Combine(Application.StartupPath, relativePath),
                Path.Combine(Environment.CurrentDirectory, relativePath)
            };

            foreach (string candidatePath in candidatePaths)
            {
                if (File.Exists(candidatePath))
                {
                    return candidatePath;
                }
            }

            return candidatePaths[0];
        }

        private Image LoadRequiredImage(string relativePath)
        {
            string assetPath = ResolveAssetPath(relativePath);
            if (!File.Exists(assetPath))
            {
                logger.Error("Missing image asset: {0}", assetPath);
                throw new FileNotFoundException("Missing image asset", assetPath);
            }

            return Image.FromFile(assetPath);
        }


        public KCW_MainForm()
        {
            InitializeComponent();
            iRichHelper = new RichEditHelper(richEdit1);
            textReader = new TextReader(iRichHelper);

            iRichHelper_reader = new RichEditHelper(richEditReader);
            textReader_reader = new TextReader(iRichHelper_reader);
            textReader_reader.Stopped += new EventHandler(reader_Stopped);

            richEditReader.Document.DefaultParagraphProperties.LineSpacingType = ParagraphLineSpacing.Multiple;
            richEditReader.Document.DefaultParagraphProperties.LineSpacing = 30;
            richEditReader.Document.DefaultParagraphProperties.LineSpacingMultiplier = 30;


            logger.Debug("Main Program");
            logger.Debug("Mode Practice :" + Program.isPractice);
            logger.Debug("Select Mindmap :" + Program.SelectMap);
            logger.Debug("Select Picture :" + Program.SelectPicture);
            init();
            showMindmap();
            logger.Debug("Ready");


            Tokenizer = new Trie.LongLexTo("Self");
            if (System.IO.File.Exists("lexitron.txt"))
            {
                System.IO.StreamReader unknownFile = System.IO.File.OpenText("lexitron.txt");
                Tokenizer.addDict(unknownFile);
            }

            

            barTgRead.EditValue = false;
            

        }

        

        // Start - Code การเพิ่มฟังก์ชันการอ่านออกเสียงปุ่มด้วย vaja สำหรับ kidcanread version 1.6

        bool statusRead = true;
        bool barBttMindmap_read = false;
        bool barBttOutline_read = false;
        bool barBttToggleWS_read = false;
        bool barBttToggleWP_read = false;
        bool barBttReading_read = false;
        bool barTgRead_read = false;
        bool tbVoiceSpeed_read = false;
        //bool barBttHelp_read = false;

        nectec.VajaTTS ttsButton = new nectec.VajaTTS();
       
        byte[] utf8Bytes;

        private void barTgRead_EditValueChanged(object sender, EventArgs e)
        {
            if (statusRead){
                statusRead = false;
                ttsButton.Stop();
            }else{
                statusRead = true;
                ttsButton.Stop();
            }
        }

        // Event การเลื่อนเมาส์ไปชี้ที่ปุ่มที่จะอ่านออกเสียง
        private void ribbonMainControl_MouseMove(object sender, MouseEventArgs e){
           RibbonHitInfo hitInfo = ribbonMainControl.CalcHitInfo(e.Location);

            if (hitInfo.InItem == false || hitInfo.Item == null){
                barBttMindmap_read = false;
                barBttOutline_read = false;
                barBttToggleWS_read = false;
                barBttToggleWP_read = false;
                barBttReading_read = false;
                barTgRead_read = false;
                tbVoiceSpeed_read = false;
                //barBttHelp_read = false;
                return;
            }      
            //ปุ่ม Mindmap
            if (hitInfo.Item == barBttMindmap.Links[0]){
                if (!barBttMindmap_read && statusRead){
                    readButton(hitInfo.Item.GetSuperTip().ToString());
                    
                }
                barBttMindmap_read = true;
            }
            else{
                barBttMindmap_read = false;
            }
            // ปุ่ม Outline
            if (hitInfo.Item == barBttOutline.Links[0]){
                if (!barBttOutline_read && statusRead)
                {
                    readButton(hitInfo.Item.GetSuperTip().ToString());

                }
                barBttOutline_read = true;
            }
            else{
                barBttOutline_read = false;
            }
            // ปุ่ม Word search
            if (hitInfo.Item == barBttToggleWS.Links[0])
            {
                if (!barBttToggleWS_read && statusRead)
                {
                    readButton(hitInfo.Item.GetSuperTip().ToString());

                }
                barBttToggleWS_read = true;
            }
            else
            {
                barBttToggleWS_read = false;
            }
            // ปุ่ม Word perdiction
            if (hitInfo.Item == barBttToggleWP.Links[0])
            {
                if (!barBttToggleWP_read && statusRead)
                {
                    readButton(hitInfo.Item.GetSuperTip().ToString());

                }
                barBttToggleWP_read = true;
            }
            else
            {
                barBttToggleWP_read = false;
            }
            // ปุ่ม Read
            if (hitInfo.Item == barBttReading.Links[0])
            {
                if (!barBttReading_read && statusRead)
                {
                    readButton(hitInfo.Item.GetSuperTip().ToString());

                }
                barBttReading_read = true;
            }
            else
            {
                barBttReading_read = false;
            }
            // ปุ่ม เปิดปิดการอ่าน
            if (hitInfo.Item == barTgRead.Links[0])
            {
                if (!barTgRead_read && statusRead )
                {
                    readButton("เปิดปิดการอ่านออกเสียงปุ่ม");

                }
                barTgRead_read = true;
            }
            else
            {
                barTgRead_read = false;
            }
            // ปุ่ม Voice speed
            if (hitInfo.Item == tbVoiceSpeed.Links[0])
            {
                if (!barTgRead_read && statusRead)
                {
                    readButton("ปรับค่าความเร็วในการอ่านออกเสียง");

                }
                tbVoiceSpeed_read = true;
            }
            else
            {
                tbVoiceSpeed_read = false;
            }
            // ปุ่ม Help
            //if (hitInfo.Item == barBttHelp.Links[0])
            //{
                //if (!barBttHelp_read && statusRead)
                //{
                    //readButton("แสดงคู่มือการใช้งานโปรแกรม");

                //}
                //barBttHelp_read = true;
            //}
            //else
            //{
              //  barBttHelp_read = false;
            //}
        }

        // ฟังก์ชันอ่านออกเสียงปุ่มด้วย vaja 
        private void readButton(String buttonInfo){
            byte[] utf8Bytes;
            utf8Bytes = Encoding.UTF8.GetBytes(buttonInfo);
            byte[] unicodeBytes = Encoding.Convert(Encoding.UTF8, Encoding.Unicode, utf8Bytes);
            ttsButton.Text = Encoding.Unicode.GetString(unicodeBytes);
            ttsButton.Volume = 100;
            ttsButton.PlayButton();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {

            RibbonControl ribbon = sender as RibbonControl;
            RibbonHitInfo hi = ribbon.CalcHitInfo(
            PointToClient(MousePosition));
            this.Text = hi.HitTest.ToString();
            if (hi.Item != null)
            {
                if (hi.Item.ItemId == barBttMindmap.Id && !barBttMindmap_read)
                {
                    nectec.VajaTTS tts = new nectec.VajaTTS();
                    byte[] utf8Bytes;
                    utf8Bytes = Encoding.UTF8.GetBytes("หน้าแผนผัง2");
                    byte[] unicodeBytes = Encoding.Convert(Encoding.UTF8, Encoding.Unicode, utf8Bytes);
                    ttsButton.Text = Encoding.Unicode.GetString(unicodeBytes);
                    ttsButton.Volume = 100;
                    ttsButton.Play();
                    barBttMindmap_read = true;
                }
                
                if (hi.Item.ItemId == barBttOutline.Id && !barBttOutline_read)
                {
                    nectec.VajaTTS tts = new nectec.VajaTTS();
                    byte[] utf8Bytes;
                    utf8Bytes = Encoding.UTF8.GetBytes("หน้าเรียบเรียง2");
                    byte[] unicodeBytes = Encoding.Convert(Encoding.UTF8, Encoding.Unicode, utf8Bytes);
                    ttsButton.Text = Encoding.Unicode.GetString(unicodeBytes);
                    ttsButton.Volume = 100;
                    ttsButton.Play();
                    barBttOutline_read = true;
                }              
            }

            /** nectec.VajaTTS tts = new nectec.VajaTTS();
             byte[] utf8Bytes;

             //RibbonControl ribbon = sender as RibbonControl;

             Point cursosPosition2 = PointToClient(new Point(Cursor.Position.X, Cursor.Position.Y));
             utf8Bytes = Encoding.UTF8.GetBytes("ไม่ใช่");
             if (sender == barBttMindmap) {
                 utf8Bytes = Encoding.UTF8.GetBytes("หน้าแผนผัง");
             }
             
             byte[] unicodeBytes = Encoding.Convert(Encoding.UTF8, Encoding.Unicode, utf8Bytes);
             tts.Text = Encoding.Unicode.GetString(unicodeBytes);
             tts.Volume = 100;
             tts.Play();  **/
        }

        private void btnSaveOutline_MouseHover(object sender, EventArgs e)
        {
            if (statusRead)
            readButton("แปลงลงเอกสาร");
        }

        private void btnBackOutline_MouseHover(object sender, EventArgs e)
        {
            if (statusRead)
                readButton("ย้อนกลับ");
        }

        private void btnSaveEditWord_MouseHover(object sender, EventArgs e)
        {
            if (statusRead)
                readButton("บันทึก");
        }

        private void btnBackEditWord_MouseHover(object sender, EventArgs e)
        {
            if (statusRead)
                readButton("ยกเลิก");
        }

        // End - Code การเพิ่มฟังก์ชันการอ่านออกเสียงปุ่มด้วย vaja

        private void timerReader_Tick(object sender, EventArgs e)
        {
            // Hide Popup
            richEditReader.Visible = false;
            panelReader.Visible = false;
            barBttReading.Enabled = true;
            timerReader.Enabled = false;
        }

        void reader_Stopped(object sender, EventArgs e)
        {
            timerReader.Enabled = true;
        }


        #region Init

        private void KCW_MainForm_Load(object sender, EventArgs e)
        {
            docPnMindmap.HideImmediately();
            docPnEditWord.HideImmediately();
            docPnOutline.HideImmediately();
            barBttToggleWS.LargeGlyph = Properties.Resources.icon_ws_off;
            barBttToggleWS.Tag = "off";
            barBttToggleWP.Enabled = false;
            barBttToggleWP.LargeGlyph = Properties.Resources.icon_wp_off;
            barBttToggleWP.Tag = "off";
            this.Refresh();
            ribbonGroupFormat.Visible = true;
            ribbonGroupFunction.Visible = true;
            richEditReader.Visible = false;
            panelReader.Visible = false;
        }

       private void init()
        {
            try
            {
                // Clear Text
                richEdit1.Text = "";
                m1_input_1.Clear();
                m1_input_2.Clear();
                m1_input_3.Clear();
                m1_input_4.Clear();
                m1_input_5.Clear();
                m1_input_6.Clear();
                m1_input_7.Clear();
                m1_input_8.Clear();
                m1_input_9.Clear();
                m1_input_10.Clear();
                m1_input_11.Clear();
                m1_input_12.Clear();
                m2_input_1.Clear();
                m2_input_2.Clear();
                m2_input_3.Clear();
                m2_input_4.Clear();
                m2_input_5.Clear();
                m2_input_6.Clear();
                m2_input_7.Clear();
                m2_input_8.Clear();
                m2_input_9.Clear();
                m2_input_10.Clear();
                m2_input_11.Clear();
                m2_input_12.Clear();
                m3_input_1.Clear();
                m3_input_2.Clear();
                m3_input_3.Clear();
                m3_input_4.Clear();
                m3_input_5.Clear();
                m3_input_6.Clear();
                m3_input_7.Clear();
                m3_input_8.Clear();
                m3_input_9.Clear();
                m3_input_10.Clear();
                m3_input_11.Clear();
                m3_input_12.Clear();
                m4_input_1.Clear();
                m4_input_2.Clear();
                m4_input_3.Clear();
                m4_input_4.Clear();
                m4_input_5.Clear();
                m4_input_6.Clear();
                m4_input_7.Clear();
                m4_input_8.Clear();
                m4_input_9.Clear();
                m4_input_10.Clear();
                m4_input_11.Clear();
                m4_input_12.Clear();

                hideMindmap();
                hideOutline();
                hideEditWord();

                docPnMindmap.HideImmediately();
                docPnOutline.HideImmediately();
                docPnEditWord.HideImmediately();

                // bg mindmap
                string photo = Program.SelectMap.GetValue("image").ToString();
                string image_url = String.Concat(@"Images\maps\", photo);
                Image myimage = LoadRequiredImage(image_url);
                // type map
                MindMapType = Program.SelectMap.SelectToken("code").ToString();
                if (MindMapType == "M1")
                {
                pnMainMindmap1.Show();
                pnMainMindmap1.BackgroundImage = myimage;
                m1_input_title.Show();

                m1_label_rp_1.Text = "";
                m1_label_rp_2.Text = "";
                m1_label_rp_3.Text = "";
                m1_label_rp_4.Text = "";
                m1_label_rp_5.Text = "";
                m1_label_rp_6.Text = "";
                m1_label_rp_7.Text = "";
                m1_label_rp_8.Text = "";
                m1_label_rp_9.Text = "";
                m1_label_rp_10.Text = "";
                m1_label_rp_11.Text = "";
                m1_label_rp_12.Text = "";
                if (Program.isPractice)
                {
                    photo = Program.SelectPicture.GetValue("photo_thumbnail").ToString();
                    //image_url = String.Concat(Program.host, photo);
                    //myimage = Image.FromStream(wc.OpenRead(image_url));
                    image_url = String.Concat(@"Images\masters\", photo);
                    myimage = LoadRequiredImage(image_url);


                    wordSearchControler.Location = new System.Drawing.Point(1, 122);
                    autoCompleteControler.Location = new System.Drawing.Point(-1, 122);
                    pnVerb.Location = new System.Drawing.Point(7, 127);
                    pnVerb.Size = new Size(329, 330);
                    listVerb.Size = new Size(302, 330);
                    pnImageEditWord.BackgroundImage = myimage;
                    map1_photo.BackgroundImage = myimage;
                    pnImageShow3.Visible = true;
                    pnImageShow1.BackgroundImage = myimage;
                    pnImageShow2.BackgroundImage = myimage;
                    pnImageShow3.BackgroundImage = myimage;
                    m1_input_title.Hide();
                    m1_input_title.Text = Program.SelectPicture.GetValue("name").ToString();
                    m1_label_1.Text = "1. " + Program.SelectPicture.GetValue("q1").ToString();
                    m1_label_2.Text = "2. " + Program.SelectPicture.GetValue("q2").ToString();
                    m1_label_3.Text = "3. " + Program.SelectPicture.GetValue("q3").ToString();
                    m1_label_4.Text = "4. " + Program.SelectPicture.GetValue("q4").ToString();
                    m1_label_5.Text = "5. " + Program.SelectPicture.GetValue("q5").ToString();
                    m1_label_6.Text = "6. " + Program.SelectPicture.GetValue("q6").ToString();
                    m1_label_7.Text = "7. " + Program.SelectPicture.GetValue("q7").ToString();
                    m1_label_8.Text = "8. " + Program.SelectPicture.GetValue("q8").ToString();
                    m1_label_9.Text = "9. " + Program.SelectPicture.GetValue("q9").ToString();
                    m1_label_10.Text = "10. " + Program.SelectPicture.GetValue("q10").ToString();
                    m1_label_11.Text = "11. " + Program.SelectPicture.GetValue("q11").ToString();
                    m1_label_12.Text = "12. " + Program.SelectPicture.GetValue("q12").ToString();

                    m1_label_rp_1.Text = Program.SelectPicture.GetValue("reply_q1").ToString();
                    m1_label_rp_2.Text = Program.SelectPicture.GetValue("reply_q2").ToString();
                    m1_label_rp_3.Text = Program.SelectPicture.GetValue("reply_q3").ToString();
                    m1_label_rp_4.Text = Program.SelectPicture.GetValue("reply_q4").ToString();
                    m1_label_rp_5.Text = Program.SelectPicture.GetValue("reply_q5").ToString();
                    m1_label_rp_6.Text = Program.SelectPicture.GetValue("reply_q6").ToString();
                    m1_label_rp_7.Text = Program.SelectPicture.GetValue("reply_q7").ToString();
                    m1_label_rp_8.Text = Program.SelectPicture.GetValue("reply_q8").ToString();
                    m1_label_rp_9.Text = Program.SelectPicture.GetValue("reply_q9").ToString();
                    m1_label_rp_10.Text = Program.SelectPicture.GetValue("reply_q10").ToString();
                    m1_label_rp_11.Text = Program.SelectPicture.GetValue("reply_q11").ToString();
                    m1_label_rp_12.Text = Program.SelectPicture.GetValue("reply_q12").ToString();
                }

                DTMapInput.map_type = MindMapType;
                DTMapInput.input_title = m1_input_title;
                DTMapInput.picture = map1_photo;
                DTMapInput.picture_top = map1_photo;
                DTMapInput.map_panel = pnMainMindmap1;
                DTMapInput.input_1 = m1_input_1;
                DTMapInput.input_2 = m1_input_2;
                DTMapInput.input_3 = m1_input_3;
                DTMapInput.input_4 = m1_input_4;
                DTMapInput.input_5 = m1_input_5;
                DTMapInput.input_6 = m1_input_6;
                DTMapInput.input_7 = m1_input_7;
                DTMapInput.input_8 = m1_input_8;
                DTMapInput.input_9 = m1_input_9;
                DTMapInput.input_10 = m1_input_10;
                DTMapInput.input_11 = m1_input_11;
                DTMapInput.input_12 = m1_input_12;
                DTMapInput.label_1 = m1_label_1;
                DTMapInput.label_2 = m1_label_2;
                DTMapInput.label_3 = m1_label_3;
                DTMapInput.label_4 = m1_label_4;
                DTMapInput.label_5 = m1_label_5;
                DTMapInput.label_6 = m1_label_6;
                DTMapInput.label_7 = m1_label_7;
                DTMapInput.label_8 = m1_label_8;
                DTMapInput.label_9 = m1_label_9;
                DTMapInput.label_10 = m1_label_10;
                DTMapInput.label_11 = m1_label_11;
                DTMapInput.label_12 = m1_label_12;
            }
            else if (MindMapType == "M2")
            {
                pnMainMindmap2.Show();
                pnMainMindmap2.BackgroundImage = myimage;
                m2_input_title.Show();

                m2_label_rp_1.Text = "";
                m2_label_rp_2.Text = "";
                m2_label_rp_3.Text = "";
                m2_label_rp_4.Text = "";
                m2_label_rp_5.Text = "";
                m2_label_rp_6.Text = "";
                m2_label_rp_7.Text = "";
                m2_label_rp_8.Text = "";
                m2_label_rp_9.Text = "";
                m2_label_rp_10.Text = "";
                m2_label_rp_11.Text = "";
                m2_label_rp_12.Text = "";

                if (Program.isPractice)
                {
                    photo = Program.SelectPicture.GetValue("photo_thumbnail").ToString();
                    //image_url = String.Concat(Program.host, photo);
                    //myimage = System.Drawing.Image.FromStream(wc.OpenRead(image_url));
                    image_url = String.Concat(@"Images\masters\", photo);
                    myimage = LoadRequiredImage(image_url);
                    wordSearchControler.Location = new System.Drawing.Point(1, 122);
                    autoCompleteControler.Location = new System.Drawing.Point(-1, 122);
                    pnVerb.Location = new System.Drawing.Point(7, 127);
                    pnVerb.Size = new Size(329, 330);
                    listVerb.Size = new Size(302, 330);

                    pnImageEditWord.BackgroundImage = myimage;
                    pnImageShow3.Visible = true;
                    map2_photo.BackgroundImage = myimage;
                    pnImageShow1.BackgroundImage = myimage;
                    pnImageShow2.BackgroundImage = myimage;
                    pnImageShow3.BackgroundImage = myimage;

                    m2_input_title.Hide();
                    m2_input_title.Text = Program.SelectPicture.GetValue("name").ToString();
                    m2_label_1.Text = "1. " + Program.SelectPicture.GetValue("q1").ToString();
                    m2_label_2.Text = "2. " + Program.SelectPicture.GetValue("q2").ToString();
                    m2_label_3.Text = "3. " + Program.SelectPicture.GetValue("q3").ToString();
                    m2_label_4.Text = "4. " + Program.SelectPicture.GetValue("q4").ToString();
                    m2_label_5.Text = "5. " + Program.SelectPicture.GetValue("q5").ToString();
                    m2_label_6.Text = "6. " + Program.SelectPicture.GetValue("q6").ToString();
                    m2_label_7.Text = "7. " + Program.SelectPicture.GetValue("q7").ToString();
                    m2_label_8.Text = "8. " + Program.SelectPicture.GetValue("q8").ToString();
                    m2_label_9.Text = "9. " + Program.SelectPicture.GetValue("q9").ToString();
                    m2_label_10.Text = "10. " + Program.SelectPicture.GetValue("q10").ToString();
                    m2_label_11.Text = "11. " + Program.SelectPicture.GetValue("q11").ToString();
                    m2_label_12.Text = "12. " + Program.SelectPicture.GetValue("q12").ToString();

                    m2_label_rp_1.Text = Program.SelectPicture.GetValue("reply_q1").ToString();
                    m2_label_rp_2.Text = Program.SelectPicture.GetValue("reply_q2").ToString();
                    m2_label_rp_3.Text = Program.SelectPicture.GetValue("reply_q3").ToString();
                    m2_label_rp_4.Text = Program.SelectPicture.GetValue("reply_q4").ToString();
                    m2_label_rp_5.Text = Program.SelectPicture.GetValue("reply_q5").ToString();
                    m2_label_rp_6.Text = Program.SelectPicture.GetValue("reply_q6").ToString();
                    m2_label_rp_7.Text = Program.SelectPicture.GetValue("reply_q7").ToString();
                    m2_label_rp_8.Text = Program.SelectPicture.GetValue("reply_q8").ToString();
                    m2_label_rp_9.Text = Program.SelectPicture.GetValue("reply_q9").ToString();
                    m2_label_rp_10.Text = Program.SelectPicture.GetValue("reply_q10").ToString();
                    m2_label_rp_11.Text = Program.SelectPicture.GetValue("reply_q11").ToString();
                    m2_label_rp_12.Text = Program.SelectPicture.GetValue("reply_q12").ToString();
                }
                DTMapInput.map_type = MindMapType;
                DTMapInput.input_title = m2_input_title;
                DTMapInput.picture = map2_photo;
                DTMapInput.picture_top = map2_photo;
                DTMapInput.map_panel = pnMainMindmap2;
                DTMapInput.input_1 = m2_input_1;
                DTMapInput.input_2 = m2_input_2;
                DTMapInput.input_3 = m2_input_3;
                DTMapInput.input_4 = m2_input_4;
                DTMapInput.input_5 = m2_input_5;
                DTMapInput.input_6 = m2_input_6;
                DTMapInput.input_7 = m2_input_7;
                DTMapInput.input_8 = m2_input_8;
                DTMapInput.input_9 = m2_input_9;
                DTMapInput.input_10 = m2_input_10;
                DTMapInput.input_11 = m2_input_11;
                DTMapInput.input_12 = m2_input_12;
                DTMapInput.label_1 = m2_label_1;
                DTMapInput.label_2 = m2_label_2;
                DTMapInput.label_3 = m2_label_3;
                DTMapInput.label_4 = m2_label_4;
                DTMapInput.label_5 = m2_label_5;
                DTMapInput.label_6 = m2_label_6;
                DTMapInput.label_7 = m2_label_7;
                DTMapInput.label_8 = m2_label_8;
                DTMapInput.label_9 = m2_label_9;
                DTMapInput.label_10 = m2_label_10;
                DTMapInput.label_11 = m2_label_11;
                DTMapInput.label_12 = m2_label_12;
            }
            else if (MindMapType == "M3")
            {
                pnMainMindmap3.Show();
                pnMainMindmap3.BackgroundImage = myimage;
                m3_input_title.Show();

                m3_label_rp_1.Text = "";
                m3_label_rp_2.Text = "";
                m3_label_rp_3.Text = "";
                m3_label_rp_4.Text = "";
                m3_label_rp_5.Text = "";
                m3_label_rp_6.Text = "";
                m3_label_rp_7.Text = "";
                m3_label_rp_8.Text = "";
                m3_label_rp_9.Text = "";
                m3_label_rp_10.Text = "";
                m3_label_rp_11.Text = "";
                m3_label_rp_12.Text = "";

                if (Program.isPractice)
                {
                    photo = Program.SelectPicture.GetValue("photo_thumbnail").ToString();
                   // image_url = String.Concat(Program.host, photo);
                   // myimage = Image.FromStream(wc.OpenRead(image_url));
                    image_url = String.Concat(@"Images\masters\", photo);
                    myimage = LoadRequiredImage(image_url);
                    wordSearchControler.Location = new System.Drawing.Point(1, 122);
                    autoCompleteControler.Location = new System.Drawing.Point(-1, 122);
                    pnVerb.Location = new System.Drawing.Point(7, 127);
                    pnVerb.Size = new Size(329, 330);
                    listVerb.Size = new Size(302, 330);
                    pnImageEditWord.BackgroundImage = myimage;
                    pnImageShow3.Visible = true;
                    map3_photo.BackgroundImage = myimage;
                    pnImageShow1.BackgroundImage = myimage;
                    pnImageShow2.BackgroundImage = myimage;
                    pnImageShow3.BackgroundImage = myimage;
                    m3_input_title.Hide();
                    m3_input_title.Text = Program.SelectPicture.GetValue("name").ToString();
                    m3_label_1.Text = "1. " + Program.SelectPicture.GetValue("q1").ToString();
                    m3_label_2.Text = "2. " + Program.SelectPicture.GetValue("q2").ToString();
                    m3_label_3.Text = "3. " + Program.SelectPicture.GetValue("q3").ToString();
                    m3_label_4.Text = "4. " + Program.SelectPicture.GetValue("q4").ToString();
                    m3_label_5.Text = "5. " + Program.SelectPicture.GetValue("q5").ToString();
                    m3_label_6.Text = "6. " + Program.SelectPicture.GetValue("q6").ToString();
                    m3_label_7.Text = "7. " + Program.SelectPicture.GetValue("q7").ToString();
                    m3_label_8.Text = "8. " + Program.SelectPicture.GetValue("q8").ToString();
                    m3_label_9.Text = "9. " + Program.SelectPicture.GetValue("q9").ToString();
                    m3_label_10.Text = "10. " + Program.SelectPicture.GetValue("q10").ToString();
                    m3_label_11.Text = "11. " + Program.SelectPicture.GetValue("q11").ToString();
                    m3_label_12.Text = "12. " + Program.SelectPicture.GetValue("q12").ToString();

                    m3_label_rp_1.Text = Program.SelectPicture.GetValue("reply_q1").ToString();
                    m3_label_rp_2.Text = Program.SelectPicture.GetValue("reply_q2").ToString();
                    m3_label_rp_3.Text = Program.SelectPicture.GetValue("reply_q3").ToString();
                    m3_label_rp_4.Text = Program.SelectPicture.GetValue("reply_q4").ToString();
                    m3_label_rp_5.Text = Program.SelectPicture.GetValue("reply_q5").ToString();
                    m3_label_rp_6.Text = Program.SelectPicture.GetValue("reply_q6").ToString();
                    m3_label_rp_7.Text = Program.SelectPicture.GetValue("reply_q7").ToString();
                    m3_label_rp_8.Text = Program.SelectPicture.GetValue("reply_q8").ToString();
                    m3_label_rp_9.Text = Program.SelectPicture.GetValue("reply_q9").ToString();
                    m3_label_rp_10.Text = Program.SelectPicture.GetValue("reply_q10").ToString();
                    m3_label_rp_11.Text = Program.SelectPicture.GetValue("reply_q11").ToString();
                    m3_label_rp_12.Text = Program.SelectPicture.GetValue("reply_q12").ToString();
                }
                DTMapInput.map_type = MindMapType;
                DTMapInput.input_title = m3_input_title;
                DTMapInput.picture = map3_photo;
                DTMapInput.picture_top = map3_photo;
                DTMapInput.map_panel = pnMainMindmap3;
                DTMapInput.input_1 = m3_input_1;
                DTMapInput.input_2 = m3_input_2;
                DTMapInput.input_3 = m3_input_3;
                DTMapInput.input_4 = m3_input_4;
                DTMapInput.input_5 = m3_input_5;
                DTMapInput.input_6 = m3_input_6;
                DTMapInput.input_7 = m3_input_7;
                DTMapInput.input_8 = m3_input_8;
                DTMapInput.input_9 = m3_input_9;
                DTMapInput.input_10 = m3_input_10;
                DTMapInput.input_11 = m3_input_11;
                DTMapInput.input_12 = m3_input_12;
                DTMapInput.label_1 = m3_label_1;
                DTMapInput.label_2 = m3_label_2;
                DTMapInput.label_3 = m3_label_3;
                DTMapInput.label_4 = m3_label_4;
                DTMapInput.label_5 = m3_label_5;
                DTMapInput.label_6 = m3_label_6;
                DTMapInput.label_7 = m3_label_7;
                DTMapInput.label_8 = m3_label_8;
                DTMapInput.label_9 = m3_label_9;
                DTMapInput.label_10 = m3_label_10;
                DTMapInput.label_11 = m3_label_11;
                DTMapInput.label_12 = m3_label_12;
            }
            else if (MindMapType == "M4")
            {
                pnMainMindmap4.Show();
                pnMainMindmap4.BackgroundImage = myimage;
                m4_input_title.Show();

                m4_label_rp_1.Text = "";
                m4_label_rp_2.Text = "";
                m4_label_rp_3.Text = "";
                m4_label_rp_4.Text = "";
                m4_label_rp_5.Text = "";
                m4_label_rp_6.Text = "";
                m4_label_rp_7.Text = "";
                m4_label_rp_8.Text = "";
                m4_label_rp_9.Text = "";
                m4_label_rp_10.Text = "";
                m4_label_rp_11.Text = "";
                m4_label_rp_12.Text = "";

                if (Program.isPractice)
                {
                    photo = Program.SelectPicture.GetValue("photo_thumbnail").ToString();
                   // image_url = String.Concat(Program.host, photo);
                    //myimage = Image.FromStream(wc.OpenRead(image_url));
                    image_url = String.Concat(@"Images\masters\", photo);
                    myimage = LoadRequiredImage(image_url);
                    wordSearchControler.Location = new Point(1, 122);
                    autoCompleteControler.Location = new Point(-1, 122);
                    pnVerb.Location = new Point(7, 127);
                    pnVerb.Size = new Size(329, 330);
                    listVerb.Size = new Size(302, 330);
                    pnImageEditWord.BackgroundImage = myimage;
                    pnImageShow3.Visible = true;
                    map4_photo.BackgroundImage = myimage;
                    pnImageShow1.BackgroundImage = myimage;
                    pnImageShow2.BackgroundImage = myimage;
                    pnImageShow3.BackgroundImage = myimage;
                    m4_input_title.Hide();
                    m4_input_title.Text = Program.SelectPicture.GetValue("name").ToString();
                    m4_label_1.Text = "1. " + Program.SelectPicture.GetValue("q1").ToString();
                    m4_label_2.Text = "2. " + Program.SelectPicture.GetValue("q2").ToString();
                    m4_label_3.Text = "3. " + Program.SelectPicture.GetValue("q3").ToString();
                    m4_label_4.Text = "4. " + Program.SelectPicture.GetValue("q4").ToString();
                    m4_label_5.Text = "5. " + Program.SelectPicture.GetValue("q5").ToString();
                    m4_label_6.Text = "6. " + Program.SelectPicture.GetValue("q6").ToString();
                    m4_label_7.Text = "7. " + Program.SelectPicture.GetValue("q7").ToString();
                    m4_label_8.Text = "8. " + Program.SelectPicture.GetValue("q8").ToString();
                    m4_label_9.Text = "9. " + Program.SelectPicture.GetValue("q9").ToString();
                    m4_label_10.Text = "10. " + Program.SelectPicture.GetValue("q10").ToString();
                    m4_label_11.Text = "11. " + Program.SelectPicture.GetValue("q11").ToString();
                    m4_label_12.Text = "12. " + Program.SelectPicture.GetValue("q12").ToString();

                    m4_label_rp_1.Text = Program.SelectPicture.GetValue("reply_q1").ToString();
                    m4_label_rp_2.Text = Program.SelectPicture.GetValue("reply_q2").ToString();
                    m4_label_rp_3.Text = Program.SelectPicture.GetValue("reply_q3").ToString();
                    m4_label_rp_4.Text = Program.SelectPicture.GetValue("reply_q4").ToString();
                    m4_label_rp_5.Text = Program.SelectPicture.GetValue("reply_q5").ToString();
                    m4_label_rp_6.Text = Program.SelectPicture.GetValue("reply_q6").ToString();
                    m4_label_rp_7.Text = Program.SelectPicture.GetValue("reply_q7").ToString();
                    m4_label_rp_8.Text = Program.SelectPicture.GetValue("reply_q8").ToString();
                    m4_label_rp_9.Text = Program.SelectPicture.GetValue("reply_q9").ToString();
                    m4_label_rp_10.Text = Program.SelectPicture.GetValue("reply_q10").ToString();
                    m4_label_rp_11.Text = Program.SelectPicture.GetValue("reply_q11").ToString();
                    m4_label_rp_12.Text = Program.SelectPicture.GetValue("reply_q12").ToString();
                }
                DTMapInput.map_type = MindMapType;
                DTMapInput.input_title = m4_input_title;
                DTMapInput.picture = map4_photo;
                DTMapInput.picture_top = map4_photo;
                DTMapInput.map_panel = pnMainMindmap4;
                DTMapInput.input_1 = m4_input_1;
                DTMapInput.input_2 = m4_input_2;
                DTMapInput.input_3 = m4_input_3;
                DTMapInput.input_4 = m4_input_4;
                DTMapInput.input_5 = m4_input_5;
                DTMapInput.input_6 = m4_input_6;
                DTMapInput.input_7 = m4_input_7;
                DTMapInput.input_8 = m4_input_8;
                DTMapInput.input_9 = m4_input_9;
                DTMapInput.input_10 = m4_input_10;
                DTMapInput.input_11 = m4_input_11;
                DTMapInput.input_12 = m4_input_12;
                DTMapInput.label_1 = m4_label_1;
                DTMapInput.label_2 = m4_label_2;
                DTMapInput.label_3 = m4_label_3;
                DTMapInput.label_4 = m4_label_4;
                DTMapInput.label_5 = m4_label_5;
                DTMapInput.label_6 = m4_label_6;
                DTMapInput.label_7 = m4_label_7;
                DTMapInput.label_8 = m4_label_8;
                DTMapInput.label_9 = m4_label_9;
                DTMapInput.label_10 = m4_label_10;
                DTMapInput.label_11 = m4_label_11;
                DTMapInput.label_12 = m4_label_12;
                }
            }
            catch (Exception ex)
            {
                logger.Error("Mindmap initialization failed: " + ex.ToString());
                MessageBox.Show("ไม่สามารถโหลดโจทย์รูปภาพได้\n" + ex.Message, "โหลดโจทย์ไม่สำเร็จ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion Init

        #region FormViewControl
        private void showMindmap()
        {

            

            // Confirm Back Page 
            if (CurrentPage != "MM")
            {
                DialogResult ret;
                KCW_ConfirmForm usrMenu = new KCW_ConfirmForm();
                ret = usrMenu.ShowDialog();
                if (ret == DialogResult.Cancel)
                {
                    return;
                }
            }

            CurrentPage = "MM";
            wordSearchControler.TrackPage = Page.Mindmap;
            hideOutline();
            hideEditWord();
            ShowBtnReadQuestion();
            docPnOutline.HideImmediately();
            docPnEditWord.HideImmediately();
            barBttMindmap.LargeGlyph = Properties.Resources.icon_mm_on;
            barBttOutline.LargeGlyph = Properties.Resources.icon_ol_off;

            if (barBttToggleWS.Tag == "off")
            {
                barBttToggleWS.LargeGlyph = Properties.Resources.icon_ws_off;
                docPnMindmap.HideImmediately();
            }
            else
            {
                barBttToggleWS.LargeGlyph = Properties.Resources.icon_ws_on;
                docPnMindmap.Show();
            }

            ribbonGroupFormat.Visible = true;
            ribbonGroupFunction.Visible = true;
            ribbonGroupTool.Visible = false;
            barBttToggleWP.Enabled = false;


            if (MindMapType == "M1")
                pnMainMindmap1.Show();
            else if (MindMapType == "M2")
                pnMainMindmap2.Show();
            else if (MindMapType == "M3")
                pnMainMindmap3.Show();
            else if (MindMapType == "M4")
                pnMainMindmap4.Show();

            
            pnMainMindmap.Show();

            

        }
        private void showOutline()
        {
            CurrentPage = "OL";
            wordSearchControler.TrackPage = Page.Outline;

            hideMindmap();
            hideEditWord();

            docPnMindmap.HideImmediately();
            docPnEditWord.HideImmediately();
            docPnOutline.Show();

            barBttMindmap.LargeGlyph = Properties.Resources.icon_mm_off;
            barBttOutline.LargeGlyph = Properties.Resources.icon_ol_on;

            ribbonGroupFormat.Visible = false;
            ribbonGroupFunction.Visible = false;
            ribbonGroupTool.Visible = true;
            richEditReader.Visible = false;
            panelReader.Visible = false;

            pnOutline.Show();
        }
        private void showEditWord()
        {
            CurrentPage = "EW";
            wordSearchControler.TrackPage = Page.Editword;

            hideMindmap();
            hideOutline();

            barBttToggleWP.LargeGlyph = Properties.Resources.icon_wp_on;
            barBttToggleWP.Tag = "on";
            barBttToggleWP.Enabled = true;

            barBttToggleWS.Tag = "off";
            barBttToggleWS.LargeGlyph = Properties.Resources.icon_ws_off;
            docPnMindmap.HideImmediately();

            docPnOutline.HideImmediately();
            docPnEditWord.Show();

            barBttMindmap.LargeGlyph = Properties.Resources.icon_mm_off;
            barBttOutline.LargeGlyph = Properties.Resources.icon_ol_off;

            ribbonGroupFormat.Visible = false;
            ribbonGroupFunction.Visible = true;//test
            ribbonGroupTool.Visible = false;
            autoCompleteControler.Clear();
            pnEditWord.Show();
        }
        private void hideMindmap()
        {
            pnMainMindmap.Hide();
            pnMainMindmap1.Hide();
            pnMainMindmap2.Hide();
            pnMainMindmap3.Hide();
            pnMainMindmap4.Hide();
        }
        private void hideOutline()
        {
            pnOutline.Hide();
        }
        private void hideEditWord()
        {
            pnEditWord.Hide();
        }
        #endregion

        #region FormMindmap

        private void bttSaveMindmap_Click(object sender, EventArgs e)
        {
            if (CurrentPage == "OL")
            {
                return;
            }
            // save page mindmap
            if (!saveMindmap()) return;
            showOutline();

        }
        private bool saveMindmap()
        {
            if (!checkInputMindmap())
            {
                return false;
            }
            string mid = "0";
            string mapid = "0";

            if (Program.SelectPicture != null)
                mid = Program.SelectPicture.GetValue("id").ToString();
            if (Program.SelectMap != null)
                mapid = Program.SelectMap.GetValue("id").ToString();

            int width = DTMapInput.map_panel.Size.Width;
            int height = DTMapInput.map_panel.Size.Height;
            HideBtnReadQuestion();
            using (Bitmap bm = new Bitmap(width, height))
            {
                DTMapInput.map_panel.DrawToBitmap(bm, new Rectangle(0, 0, width, height));
                try
                {
                    bm.Save(Environment.CurrentDirectory + @"\temp-mindmap.png", ImageFormat.Png);
                }
                catch { }
            }

            if (Program.isPractice)
            {
                Program.answer.q1 = Program.SelectPicture.GetValue("reply_q1").ToString() + DTMapInput.input_1.Text;
                Program.answer.q2 = Program.SelectPicture.GetValue("reply_q2").ToString() + DTMapInput.input_2.Text;
                Program.answer.q3 = Program.SelectPicture.GetValue("reply_q3").ToString() + DTMapInput.input_3.Text;
                Program.answer.q4 = Program.SelectPicture.GetValue("reply_q4").ToString() + DTMapInput.input_4.Text;
                Program.answer.q5 = Program.SelectPicture.GetValue("reply_q5").ToString() + DTMapInput.input_5.Text;
                Program.answer.q6 = Program.SelectPicture.GetValue("reply_q6").ToString() + DTMapInput.input_6.Text;
                Program.answer.q7 = Program.SelectPicture.GetValue("reply_q7").ToString() + DTMapInput.input_7.Text;
                Program.answer.q8 = Program.SelectPicture.GetValue("reply_q8").ToString() + DTMapInput.input_8.Text;
                Program.answer.q9 = Program.SelectPicture.GetValue("reply_q9").ToString() + DTMapInput.input_9.Text;
                Program.answer.q10 = Program.SelectPicture.GetValue("reply_q10").ToString() + DTMapInput.input_10.Text;
                Program.answer.q11 = Program.SelectPicture.GetValue("reply_q11").ToString() + DTMapInput.input_11.Text;
                Program.answer.q12 = Program.SelectPicture.GetValue("reply_q12").ToString() + DTMapInput.input_12.Text;
            }
            else
            {
                Program.answer.q1 = DTMapInput.input_1.Text;
                Program.answer.q2 = DTMapInput.input_2.Text;
                Program.answer.q3 = DTMapInput.input_3.Text;
                Program.answer.q4 = DTMapInput.input_4.Text;
                Program.answer.q5 = DTMapInput.input_5.Text;
                Program.answer.q6 = DTMapInput.input_6.Text;
                Program.answer.q7 = DTMapInput.input_7.Text;
                Program.answer.q8 = DTMapInput.input_8.Text;
                Program.answer.q9 = DTMapInput.input_9.Text;
                Program.answer.q10 = DTMapInput.input_10.Text;
                Program.answer.q11 = DTMapInput.input_11.Text;
                Program.answer.q12 = DTMapInput.input_12.Text;
            }
            Program.answer.title = DTMapInput.input_title.Text;
            Program.answer.mid = mid;
            Program.answer.mapid = mapid;

            //  Gen Outline
            tbOutlineTitle.Text = DTMapInput.input_title.Text;
            Program.Sentence = new string[] { Program.answer.q1, Program.answer.q2, Program.answer.q3, Program.answer.q4, Program.answer.q5, Program.answer.q6, Program.answer.q7, Program.answer.q8, Program.answer.q9, Program.answer.q10, Program.answer.q11, Program.answer.q12 };
            genOutline();
            showOutline();
            return true;
        }
        private bool checkInputMindmap()
        {
            bool complete = true;
            if (DTMapInput.input_title.Text.Equals("") && !Program.isPractice)
            {
                DTMapInput.input_title.Focus(); complete = false;
            }
            else if (DTMapInput.input_1.Text.Equals(""))
            {
                DTMapInput.input_1.Focus(); complete = false;
            }
            else if (DTMapInput.input_2.Text.Equals(""))
            {
                DTMapInput.input_2.Focus(); complete = false;
            }
            else if (DTMapInput.input_3.Text.Equals(""))
            {
                DTMapInput.input_3.Focus(); complete = false;
            }
            else if (DTMapInput.input_4.Text.Equals(""))
            {
                DTMapInput.input_4.Focus(); complete = false;
            }
            else if (DTMapInput.input_5.Text.Equals(""))
            {
                DTMapInput.input_5.Focus(); complete = false;
            }
            else if (DTMapInput.input_6.Text.Equals(""))
            {
                DTMapInput.input_6.Focus(); complete = false;
            }
            else if (DTMapInput.input_7.Text.Equals(""))
            {
                DTMapInput.input_7.Focus(); complete = false;
            }
            else if (DTMapInput.input_8.Text.Equals(""))
            {
                DTMapInput.input_8.Focus(); complete = false;
            }
            else if (DTMapInput.input_9.Text.Equals(""))
            {
                DTMapInput.input_9.Focus(); complete = false;
            }
            else if (DTMapInput.input_10.Text.Equals(""))
            {
                DTMapInput.input_10.Focus(); complete = false;
            }
            else if (DTMapInput.input_11.Text.Equals(""))
            {
                DTMapInput.input_11.Focus(); complete = false;
            }
            else if (DTMapInput.input_12.Text.Equals(""))
            {
                DTMapInput.input_12.Focus(); complete = false;
            }

            else if (!Program.isPractice)
            {
                if (DTMapInput.input_title.Text.Equals(""))
                {
                    DTMapInput.input_title.Focus(); complete = false;
                }
            }
            //natcha
           // if (!complete)
           // {
             //   MessageBox.Show("กรุณากรอกข้อมูลให้ครบ", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //}

            complete = true;


            return complete;
        }

        KCW_DemoDialog dlg;
        private void input_Click(object sender, EventArgs e)
        {
            try
            {
                tbSelect = (System.Windows.Forms.TextBox)sender;
                string[] words = new string[2];
                #region natcha's add 
                //if (dlg == null)
                //{
                //    dlg = new DemoDialog();
                //    dlg.Owner = this;
                //    dlg.FormClosed += new FormClosedEventHandler(dlgDemo_FormClose);
                //    dlg.DemoText = tbSelect.Text;
                //    words = tbSelect.Name.Split('_');
                //    dlg.Text = (this.Controls.Find(MindMapType.ToLower() + "_label_" + words[2], true).FirstOrDefault() as Label).Text;

                //    words = null;
                //    dlg.Show();
                //}
                //else
                //{
                //    dlg.Activate();
                //}
                //dlg.TbInput1 = (TextBox)sender;

                //vaja read
                textReader.Speed = ReaderSpeed;
                textReader.ReadAllTextNoSelect(tbSelect.Text);

                #endregion natcha's add 
                wordSearchControler.TbInput = (System.Windows.Forms.TextBox)sender;

                var font = tbSelect.Font;
                var color = tbSelect.ForeColor;
                barFont.EditValue = font.FontFamily.Name;
                barFontSize.EditValue = font.Size;
            }
            catch
            {
            }
        }

        //private void label_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        labelSelect = (Label)sender;
        //        //string temp = "";

        //        textReader.Speed = ReaderSpeed;
        //        textReader.ReadAllTextNoSelect(labelSelect.Text);
        //    }
        //    catch
        //    {
        //    }
        //}

        private void btnReadQuestion_Click(object sender, EventArgs e)
        {
            try
            {
                buttonSelect = (DevExpress.XtraEditors.SimpleButton)sender;
                string[] words = new string[2];
                words = buttonSelect.Name.Split('_');
                textReader.Speed = ReaderSpeed;
                textReader.ReadAllTextNoSelect((this.Controls.Find(MindMapType.ToLower() + "_label_" + words[2], true).FirstOrDefault() as Label).Text);
            }
            catch { }
        }

        private void mapPhoto_Click(object sender, EventArgs e)
        {
            
                if (Program.isPractice)
                {
                    mapPhotoSelect = (Panel)sender;
                    if (dlg == null)
                    {
                        dlg = new KCW_DemoDialog();
                        dlg.Owner = this;
                        dlg.StartPosition = FormStartPosition.CenterParent;
                        dlg.FormClosed += new FormClosedEventHandler(dlgDemo_FormClose);
                        dlg.DemoPanel.BackgroundImage = mapPhotoSelect.BackgroundImage;
                        dlg.ShowDialog();
                    }
                    else
                    {
                        dlg.Activate();
                    }
                }
                           
        }
        

        void dlgDemo_FormClose(object sender, FormClosedEventArgs e)
        {
            dlg = null;
        }

        #endregion

        #region FormOutline_Event
        public Button bTemp { get; set; }

        private void bttBackOutline_Click(object sender, EventArgs e)
        {
            showMindmap();
        }
        private void bttSaveOutline_Click(object sender, EventArgs e)
        {
            if (!checkSentence()) { return; }
            NewDocument();
            CurrentFile = LDFileManager.CreateFileItem(1);
            bool _save = SaveDocument();
            logger.Debug(_save);
        }
        

        private void listOutlineWord_DragOver(object sender, DragEventArgs e)
        {
            base.OnDragOver(e);
            // is another dragable
            if (((Button)e.Data.GetData(typeof(Button))).Parent != null && ((Button)e.Data.GetData(typeof(Button))).Parent.Name == "listWord1")
            {
                FlowLayoutPanel p = (FlowLayoutPanel)(sender as Button).Parent;
                //Current Position             
                int myIndex = p.Controls.GetChildIndex((sender as Button));
                //Dragged to control to location of next picturebox
                Button q = (Button)e.Data.GetData(typeof(Button));
                p.Controls.SetChildIndex(q, myIndex);

            }


        }
        private void lisOutlinetWord_MouseDown(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left) //Only when mouse is clicked
            {
                // button.Location = new Point(e.X,e.Y);

                base.OnMouseDown(e);
                DoDragDrop(sender, DragDropEffects.Move);
            }
            if (e.Button == MouseButtons.Right) //Only when mouse is clicked
            {
                base.OnMouseClick(e);
                listOutlineWord_click(sender, e);
            }
        }
        private void listOutlineWord_click(object sender, EventArgs e)
        {
            Font font = new Font("Browallia New", 15f);
            contextMenuStrip.Items.Clear();
            ToolStripMenuItem toolStripMenuItem1 = new ToolStripMenuItem("อ่าน");
            toolStripMenuItem1.Font = font;
            toolStripMenuItem1.Image = LDWordProcessor.Properties.Resources.speaker_on;
            contextMenuStrip.Items.Add(toolStripMenuItem1);
            ToolStripMenuItem toolStripMenuItem2 = new ToolStripMenuItem("แก้ไข");
            toolStripMenuItem2.Font = font;
            toolStripMenuItem2.Image = LDWordProcessor.Properties.Resources.icon_edit;
            contextMenuStrip.Items.Add(toolStripMenuItem2);
            bTemp = (Button)sender;
            if (bTemp.Tag.Equals("verb"))
            {
                ToolStripMenuItem toolStripMenuItem3 = new ToolStripMenuItem("ลบ");
                toolStripMenuItem3.Font = font;
                toolStripMenuItem3.Image = LDWordProcessor.Properties.Resources.icon_move_remove;
                contextMenuStrip.Items.Add(toolStripMenuItem3);
            }
            contextMenuStrip.Show((Button)sender, new Point(this.Location.X + 8, this.Location.Y + 50));
            contextMenuStrip.ItemClicked -= new ToolStripItemClickedEventHandler(listOutlineWordMenu_ItemClicked);
            contextMenuStrip.ItemClicked += new ToolStripItemClickedEventHandler(listOutlineWordMenu_ItemClicked);
        }
        private void listOutlineVerb_click(object sender, MouseEventArgs e)
        {
            Font font = new Font("Browallia New", 18f);
            Button button_master = (Button)sender;
            Button button = new Button();
            using (Graphics cg = this.CreateGraphics())
            {
                button.Font = font;
                SizeF size = cg.MeasureString(button_master.Text, button.Font);
                button.Width = (int)size.Width + 40;
                button.Height = 40;
                button.Tag = "verb";
                button.FlatStyle = FlatStyle.Flat;
                button.BackColor = Color.White;
                button.Text = button_master.Text;
                button.ForeColor = Color.Black;
                button.MouseDown += new MouseEventHandler(lisOutlinetWord_MouseDown);
                button.DragOver += new DragEventHandler(listOutlineWord_DragOver);
                button.Click += new EventHandler(listOutlineWord_click);
                button.AllowDrop = true;
                listWord1.Controls.Add(button);
            }
        }
        private void listOutlineWordMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            ToolStripItem item = e.ClickedItem;
            int index = contextMenuStrip.Items.IndexOf(item);
            if (index == 0) // speak
            {
                textReader.ReadText(bTemp.Text);
            }
            else if (index == 1) // edit
            {
                label1.Text = "แก้ไขข้อความ     ข้อความเดิม : " + bTemp.Text;
                richEdit1.Text = bTemp.Text;
                showEditWord();
            }
            else if (index == 2) // remove
            {
                listWord1.Controls.Remove(bTemp);
            }
        }

        #endregion

        #region FormOutline_Event_Verb

        private void tbVerbFilter_TextChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.TextBox origin = sender as System.Windows.Forms.TextBox;
            if (!origin.ContainsFocus)
                return;

            DisposeTimer_VerbFilter();
            timer = new System.Threading.Timer(TimerElapsed_VerbFilter, null, VALIDATION_DELAY, VALIDATION_DELAY);
        }

        private void TimerElapsed_VerbFilter(Object obj)
        {
            LookupAction_VerbFilter();
            DisposeTimer_VerbFilter();
        }

        private void DisposeTimer_VerbFilter()
        {
            if (timer != null)
            {
                timer.Dispose();
                timer = null;
            }
        }

        private void LookupAction_VerbFilter()
        {
            this.Invoke(new Action(() =>
            {
                listVerb.Controls.Clear();
                Font font = new Font("Browallia New", 18f);
                int i = 0;
                string[] verbs = GetVerbs();
                if (tbVerbFilter.Text.Length > 0)
                {
                    foreach (string verb in verbs.Where(x => x.Contains(tbVerbFilter.Text)).ToArray())
                    {
                        Button button = new Button() { BackColor = Color.White, Font = font, Text = verb, Name = i++.ToString(), Tag = "verb", Size = new Size(200, 34) };
                        button.MouseClick += new MouseEventHandler(listOutlineVerb_click);
                        listVerb.Controls.Add(button);
                    }
                }
                else
                {
                    foreach (string verb1 in verbs)
                    {
                        Button button = new Button() { BackColor = Color.White, Font = font, Text = verb1, Name = i++.ToString(), Tag = "verb", Size = new Size(200, 34) };
                        button.MouseClick += new MouseEventHandler(listOutlineVerb_click);
                        listVerb.Controls.Add(button);
                    }
                }
            }
            ));
        }

        #endregion

        #region FormOutline_Function

        private static string[] GetVerbs()
        {
            // คำเชื่อม
            string[] verbs = new string[20] { " ", "ก็", "ก่อน", "กับ", "กำลัง", "จึง", "เช่น", "ซึ่ง", "ด้วย", "แต่", "แต่ว่า", "ถ้า", "ถึง", "ที่", "เพราะ", "เมื่อ", "และ", "หรือ", "เหมือน", "อัน" };
            return verbs;
        }
        private void genOutline()
        {
            listVerb.Controls.Clear();
            listWord.Controls.Clear();
            listWord1.Controls.Clear();

            listWord.AllowDrop = true;
            listWord1.AllowDrop = true;
            listWord.DragEnter += panel_DragEnter;
            listWord1.DragEnter += panel_DragEnter;
            //listWord.DragDrop += panel_DragDrop;

            listWord1.DragDrop -= panel_DragDrop;
            listWord1.DragDrop += panel_DragDrop;
            // listWord1.DragDrop += new System.Windows.Forms.DragEventHandler(panel_DragDrop); 

            Font font = new Font("Browallia New", 18f);
            int i = 0;
            foreach (string verb in GetVerbs())
            {
                Button button = new Button() { BackColor = Color.White, Font = font, Text = verb, Name = i++.ToString(), Tag = "verb", Size = new Size(200, 34) };
                button.MouseClick += new MouseEventHandler(listOutlineVerb_click);
                listVerb.Controls.Add(button);
            }

            // ประโยค
            logger.Debug("Outline Sentence");
            foreach (string sentence in Program.Sentence)
            {
                logger.Debug(sentence);
                Button button = new Button();
                using (Graphics cg = this.CreateGraphics())
                {
                    button.Font = font;
                    SizeF size = cg.MeasureString(sentence, button.Font);
                    if (40 + (int)size.Width > 400)
                    {
                        int Height = (int)Math.Ceiling(size.Width / 400);
                        button.Width = 400;
                        button.Height = 40 * Height;
                    }
                    else
                    {
                        button.Width = (int)size.Width + 40;
                        button.Height = 40;
                    }
                    button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                    // button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(203)))), ((int)(((byte)(206)))));
                    button.BackColor = Color.White;

                    button.FlatStyle = FlatStyle.Flat;
                    button.ForeColor = Color.Black;
                    button.Text = sentence;
                    button.Tag = "sentence";

                    button.MouseDown += new MouseEventHandler(lisOutlinetWord_MouseDown);
                    button.DragOver += new DragEventHandler(listOutlineWord_DragOver);
                    button.Click += new EventHandler(bttBackOutline_Click);
                    button.AllowDrop = true;

                    listWord.Controls.Add(button);
                    //listWord1.Controls.Add(button);
                }
            }

        }
        void panel_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }
        void panel_DragDrop(object sender, DragEventArgs e)
        {
            
            if (((Button)e.Data.GetData(typeof(Button))).Parent != null && ((Button)e.Data.GetData(typeof(Button))).Parent.Name == "listWord")
            {
                Font font = new Font("Browallia New", 18f);
                Button button_master = (Button)e.Data.GetData(typeof(Button));
                button_master.Enabled = false;
                button_master.BackColor = Color.LightGray;

                Button button = new Button();
                using (Graphics cg = this.CreateGraphics())
                {
                    button.Font = font;
                    SizeF size = cg.MeasureString(button_master.Text, button.Font);
                    button.Width = (int)size.Width + 40;
                    button.Height = 40;
                    button.Tag = "sentence";
                    button.FlatStyle = FlatStyle.Flat;
                    button.BackColor = Color.White;
                    button.Text = button_master.Text;
                    button.ForeColor = Color.Black;
                    button.MouseDown += new MouseEventHandler(lisOutlinetWord_MouseDown);
                    button.DragOver += new DragEventHandler(listOutlineWord_DragOver);
                    button.Click += new EventHandler(listOutlineWord_click);
                    button.AllowDrop = true;
                    listWord1.Controls.Add(button);
                }
            }

        }

        public void NewDocument()
        {
            //reset file ignore cache
            richEdit = new RichEditControl();
            Image myimage = Image.FromFile(Environment.CurrentDirectory + @"\temp-mindmap.png");
            Program.answer.title = tbOutlineTitle.Text;
            string title = Program.answer.title;
            string sentent = "<ul style='margin-top: 0;'>";
            string content = "";
            foreach (Control c in listWord1.Controls)
            {
                sentent += "<li>" + c.Text + "</li>";
                content += c.Text;
            }
            sentent += "</ul>";
            //string ul = "<h4 style='margin-bottom: 0;margin-left: 10px;'> " + Program.answer.q1 + "</h4 style='margin-bottom: 0;margin-left: 10px;'> <ul style='margin-top: 0;'><li>" + Program.answer.q2 + "</li><li>" + Program.answer.q3 + "</li><li>" + Program.answer.q4 + "</li><li>" + Program.answer.q5 + "</li></ul>";
            //string ul2 = "<h4 style='margin-bottom: 0;margin-left: 10px;'> " + Program.answer.q6 + "</h4 style='margin-bottom: 0;margin-left: 10px;'> <ul style='margin-top: 0;'><li>" + Program.answer.q7 + "</li><li>" + Program.answer.q8 + "</li><li>" + Program.answer.q9 + "</li></ul>";
            //string ul3 = "<h4 style='margin-bottom: 0;margin-left: 10px;'> " + Program.answer.q10 + "</h4 style='margin-bottom: 0;margin-left: 10px;'> <ul style='margin-top: 0;'><li>" + Program.answer.q11 + "</li><li>" + Program.answer.q12 + "</li></ul>";
            string ul = "<ul style='margin-top: 0;'><li> " + Program.answer.q1 + "</li><li>" + Program.answer.q2 + "</li><li>" + Program.answer.q3 + "</li><li>" + Program.answer.q4 + "</li><li>" + Program.answer.q5 + "</li></ul>";
            string ul2 = "<ul style='margin-top: 0;'><li> " + Program.answer.q6 + "</li><li>" + Program.answer.q7 + "</li><li>" + Program.answer.q8 + "</li><li>" + Program.answer.q9 + "</li></ul>";
            string ul3 = "<ul style='margin-top: 0;'><li> " + Program.answer.q10 + "</li><li>" + Program.answer.q11 + "</li><li>" + Program.answer.q12 + "</li></ul>";
            string table = "<div style='text-align: center'><br><br><h3>" + title + "</h3><br></div><div style='text-align: left'><table style='width: 100%;' border='1'><tr><td width='40%' style='vertical-align:top;'>" + ul + ul2 + ul3 + "</td> <td width='60%' style='vertical-align:top'>" + sentent + "</td></tr></table></div><div><br><br><h3 style='text-align: center'>" + title + "</h3><p>&nbsp;&nbsp;&nbsp;&nbsp;" + content + "</p></div>";
            
            Image mimageResize = ResizeImage(myimage, 630, 370);
            richEdit.Document.InsertImage(richEdit.Document.CaretPosition, mimageResize);
            richEdit.Document.InsertHtmlText(richEdit.Document.CaretPosition, table);
        }
        public static Bitmap ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }

        private void HideBtnReadQuestion()
        {
            (this.Controls.Find(MindMapType + "_btn_1", true).FirstOrDefault() as DevExpress.XtraEditors.SimpleButton).Hide();
            (this.Controls.Find(MindMapType + "_btn_2", true).FirstOrDefault() as DevExpress.XtraEditors.SimpleButton).Hide();
            (this.Controls.Find(MindMapType + "_btn_3", true).FirstOrDefault() as DevExpress.XtraEditors.SimpleButton).Hide();
            (this.Controls.Find(MindMapType + "_btn_4", true).FirstOrDefault() as DevExpress.XtraEditors.SimpleButton).Hide();
            (this.Controls.Find(MindMapType + "_btn_5", true).FirstOrDefault() as DevExpress.XtraEditors.SimpleButton).Hide();
            (this.Controls.Find(MindMapType + "_btn_6", true).FirstOrDefault() as DevExpress.XtraEditors.SimpleButton).Hide();
            (this.Controls.Find(MindMapType + "_btn_7", true).FirstOrDefault() as DevExpress.XtraEditors.SimpleButton).Hide();
            (this.Controls.Find(MindMapType + "_btn_8", true).FirstOrDefault() as DevExpress.XtraEditors.SimpleButton).Hide();
            (this.Controls.Find(MindMapType + "_btn_9", true).FirstOrDefault() as DevExpress.XtraEditors.SimpleButton).Hide();
            (this.Controls.Find(MindMapType + "_btn_10", true).FirstOrDefault() as DevExpress.XtraEditors.SimpleButton).Hide();
            (this.Controls.Find(MindMapType + "_btn_11", true).FirstOrDefault() as DevExpress.XtraEditors.SimpleButton).Hide();
            (this.Controls.Find(MindMapType + "_btn_12", true).FirstOrDefault() as DevExpress.XtraEditors.SimpleButton).Hide();


            //for (int i = 1; i <= 6; i++)
            //{
            //    (this.Controls.Find(MindMapType + "_btn_" + i.ToString(), true).FirstOrDefault() as DevExpress.XtraEditors.SimpleButton).Hide();
            //}


        }

        private void ShowBtnReadQuestion()
        {
            for (int i = 1; i <= 12; i++)
            {
                (this.Controls.Find(MindMapType + "_btn_" + i.ToString(), true).FirstOrDefault() as DevExpress.XtraEditors.SimpleButton).Show();
            }
        }

        private bool SaveDocument()
        {
            logger.Debug("Save Document");
            string fileName = CurrentFile.Name;
            string fileNameGenAuto = CurrentFile.NameGenAuto;

            richEdit.Options.DocumentSaveOptions.DefaultFileName = CurrentFile.Path;
            richEdit.Options.DocumentSaveOptions.DefaultFormat = DocumentFormat.OpenXml;
            if (richEdit.SaveDocument())
            {
                string saveFile = richEdit.Options.DocumentSaveOptions.CurrentFileName;
                if (saveFile.Length > 0)
                {
                    if (CurrentFile.IsNew)
                    {
                        int file_id = LDFileManager.SaveDocumentAs(1, saveFile);
                        LDFileBinding f = new LDFileBinding();
                        f.FileID = file_id;
                        f.UserID = 1;
                        f.Path = saveFile;
                        f.NameGenAuto = fileNameGenAuto;
                        f.LastModified = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                        f.IsNew = false;
                        CurrentFile = f;
                    }
                    else
                    {
                        CurrentFile.LastModified = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                        LDFileManager.SaveDocument(CurrentFile);
                    }
                }
                logger.Debug(saveFile);
                return true;
            }
            else
            {
                return false;
            }
        }
        private void tbVoiceSpeed_EditValueChanged(object sender, EventArgs e)
        {
            int speed;
            if (Int32.TryParse(tbVoiceSpeed.EditValue.ToString(), out speed))
            {
                ReaderSpeed = speed;

            }
        }
        #endregion

        #region FormEditWord

        private class DocumentPage2
        {
            public RichEditControl richEdit;
            public RichEditHelper iRichHelper;
            public LDFileBinding currentFile;
            public LDUserTypeIdler userTypeIdler;
            public PageBasedRichEditView view;
        }
        public LDFileBinding CurrentFile
        {
            get
            {
                return documentPageCurrent.currentFile;
            }
            set
            {
                documentPageCurrent.currentFile = value;
            }
        }

        private void btnSaveEditWord_Click(object sender, EventArgs e)
        {
            if (richEdit1.Text.Trim().Length == 0)
            {
                MessageBox.Show("กรุณากรอกข้อมูลก่อนบันทึก", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bTemp.Text = richEdit1.Text.Replace("\r\n", " ");
            using (Graphics cg = this.CreateGraphics())
            {
                SizeF size = cg.MeasureString(bTemp.Text, bTemp.Font);
                if (40 + (int)size.Width > 400)
                {
                    int Height = (int)Math.Ceiling(size.Width / 400);
                    bTemp.Width = 400;
                    bTemp.Height = 40 * Height;
                }
                else
                {
                    bTemp.Width = (int)size.Width + 40;
                    bTemp.Height = 40;
                }
            }
            bTemp.Refresh();
            showOutline();
        }
        private void btnBackEditWord_Click(object sender, EventArgs e)
        {
            showOutline();
        }

        private void richEdit_TextChanged(object sender, EventArgs e)
        {
            RichEditControl origin = sender as RichEditControl;
            if (!origin.ContainsFocus)
                return;

            DisposeTimer_RichEdit();
            timer = new System.Threading.Timer(TimerElapsed_RichEdit, null, VALIDATION_DELAY, VALIDATION_DELAY);

        }

        private void TimerElapsed_RichEdit(Object obj)
        {
            LookupAction_RichEdit();
            DisposeTimer_RichEdit();
        }

        private void DisposeTimer_RichEdit()
        {
            if (timer != null)
            {
                timer.Dispose();
                timer = null;
            }
        }

        private void LookupAction_RichEdit()
        {
            this.Invoke(new Action(() =>
            {
                string newInput = iRichHelper.GetLastTextInput();
                if (newInput.Length > 0)
                {
                    //segment new input
                    LDWordSegment ws = new LDWordSegment();
                    string newWord = ws.GetLastThaiWord(newInput);

                    if (newWord.Equals(newInput))
                    {
                        ArrayList typeList;
                        int begin, end, type;
                        Tokenizer.wordInstance(newInput);

                        typeList = Tokenizer.getTypeList();
                        begin = Tokenizer.first();
                        int i = 0;
                        String result = "";
                        while (Tokenizer.hasNext())
                        {
                            end = Tokenizer.next();
                            type = (short)typeList[i];
                            result = newInput.Substring(begin, end - begin);
                            begin = end;
                        }
                        newWord = result;
                    }

                    int countList = autoCompleteControler.ListCount(newWord, 1);
                    if (countList <= 2)
                    {
                        string ret = LongLexTo.spellChkWordString(newWord);
                        splitData(ret);
                        if (checkStatusWord() == 1)
                        {
                            newWord = suggestWord[suggestWord.Length - 1];
                        }
                    }
                    logger.Debug("{0}-{1}", newWord, newInput);
                    autoCompleteControler.ListSuggest(newWord, 1);
                }
                else
                {
                    autoCompleteControler.Clear();
                }
            }
            ));
        }

        public void splitData(string splt)
        {
            // char[] delimiterChars = { ' ', ',', '.', ':', '\t' };
            char[] delimiterChars = { '|' };

            //  string text = "one\ttwo three:four,five six seven";
            //   System.Console.WriteLine("Original text: '{0}'", splt);

            string[] words = splt.Split(delimiterChars);
            suggestWord = new string[words.Length / 2];
            status = new string[words.Length / 2];
            //  System.Console.WriteLine("{0} words in text:", words.Length);
            int counts = 0;
            for (int i = 0; i < words.Length - 1; i++)
            {
                // Console.WriteLine("word-->{0}", words[i]);
                //   if (i % 2 == 0)
                // {
                suggestWord[counts] = words[i];
                // }
                //else if (i / 2 == 1)
                //{
                status[counts] = words[i + 1];
                //}
                //Console.WriteLine("sugg-->{0}", suggestWord[counts]);
                // Console.WriteLine("status-->{0}", status[counts]);
                counts++;
                i++;

            }
        }

        public int checkStatusWord()
        {
            //for(int i=0
            //  suggestWord 
            int chk;
            if ((status[status.Length - 1] == "0") || status.Length > 1)
            {
                chk = 1;
            }
            else
            {
                chk = 0;
            }
            return chk;
        }

        private void autoCompleteControler_SelectWordSuggestEvent(string sWordStart, string sWordComplete, WordSuggestType wordSuggestType)
        {
            //  Console.WriteLine("sWordStart-->" + sWordStart);
            // Console.WriteLine("sWordComplete-->" + sWordComplete);
            oldWord = sWordComplete;
            if (wordSuggestType == WordSuggestType.AutoComplete)
            {
                //   Console.WriteLine("sWordStart-->" + sWordStart);
                String sub_complete = sWordComplete.Substring(sWordStart.Length);
                // Console.WriteLine("sub_complete-->" + sub_complete);
                iRichHelper.InsertText(sub_complete);
                //CurrentUser.SelectCompletion(CurrentFile.FileID, sWordStart, sWordComplete);
                autoCompleteControler.ListSuggest(sWordComplete);
            }
            else if (wordSuggestType == WordSuggestType.Prediction)
            {
                iRichHelper.InsertText(sWordComplete);
                //CurrentUser.SelectPrediction(CurrentFile.FileID, sWordStart, sWordComplete);
                //  Console.WriteLine("sWordComplete-->" + sWordComplete);
                LDWordSegment ws = new LDWordSegment();
                string newSentence = iRichHelper.GetLastTextInput();
                //   Console.WriteLine("newSentence-->" + newSentence);
                string newWord = ws.GetLastThaiWord(newSentence);
                autoCompleteControler.ListSuggest(newWord);
            }
            else if (wordSuggestType == WordSuggestType.None)
            {
                iRichHelper.InsertText(sWordComplete);
            }

            richEdit1.Focus();
        }

        #endregion

        #region BarItemMenu

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            showMindmap();
        }

        private void barButtonItem1_ItemHover(object sender, EventArgs e)
        {
            nectec.VajaTTS tts = new nectec.VajaTTS();
            byte[] utf8Bytes = Encoding.UTF8.GetBytes("หน้าแผนผัง");
            byte[] unicodeBytes = Encoding.Convert(Encoding.UTF8, Encoding.Unicode, utf8Bytes);
            tts.Text = Encoding.Unicode.GetString(unicodeBytes);
            tts.Volume = 100;
            tts.Play();
        }


        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bttSaveMindmap_Click(sender, e);
        }
        private void barFont_EditValueChanged(object sender, EventArgs e)
        {
            string fontname = ((DevExpress.XtraBars.BarEditItem)(sender)).EditValue.ToString();
            tbSelect.Font = new Font(fontname, tbSelect.Font.Size);
        }
        private void barFontSize_EditValueChanged(object sender, EventArgs e)
        {
            float size = float.Parse(((DevExpress.XtraBars.BarEditItem)(sender)).EditValue.ToString(), CultureInfo.InvariantCulture.NumberFormat);
            tbSelect.Font = new Font(tbSelect.Font.FontFamily.Name, size);
        }
        private void colorPicker_EditValueChanged(object sender, EventArgs e)
        {
            Color color = System.Drawing.ColorTranslator.FromHtml("#" + ((System.Drawing.Color)(((DevExpress.XtraBars.BarEditItem)(sender)).EditValue)).Name);
            tbSelect.ForeColor = color;
        }
        private void barBttToggleWS_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (barBttToggleWS.Tag == "off")
            {
                docPnMindmap.Show();
                barBttToggleWS.LargeGlyph = Properties.Resources.icon_ws_on;
                barBttToggleWS.Tag = "on";
                if (barBttToggleWP.Tag == "on")
                {
                    docPnEditWord.HideImmediately();
                    barBttToggleWP.LargeGlyph = Properties.Resources.icon_wp_off;
                    barBttToggleWP.Tag = "off";
                }
            }
            else
            {
                docPnMindmap.HideImmediately();
                barBttToggleWS.LargeGlyph = Properties.Resources.icon_ws_off;
                barBttToggleWS.Tag = "off";
            }
            this.Refresh();
        }
        private void barBttToggleWP_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (barBttToggleWP.Tag == "off")
            {
                docPnEditWord.Show();
                barBttToggleWP.LargeGlyph = Properties.Resources.icon_wp_on;
                barBttToggleWP.Tag = "on";
                if (barBttToggleWS.Tag == "on")
                {
                    docPnMindmap.HideImmediately();
                    barBttToggleWS.LargeGlyph = Properties.Resources.icon_ws_off;
                    barBttToggleWS.Tag = "off";
                }
            }
            else
            {
                docPnEditWord.HideImmediately();
                barBttToggleWP.LargeGlyph = Properties.Resources.icon_wp_off;
                barBttToggleWP.Tag = "off";
                // docPnMindmap.Show();
                //barBttToggleWS.LargeGlyph = Properties.Resources.icon_ws_on;
                //barBttToggleWS.Tag = "on";
            }
            this.Refresh();
        }


        private void barBttReading_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            richEditReader.Text = "";
            richEditReader.Visible = true;
            panelReader.Visible = true;
            barBttReading.Enabled = false;
            textReader_reader.Speed = ReaderSpeed;
            string temp = "";
            foreach (Control c in listWord1.Controls)
            {
                temp += c.Text;
            }


            if (temp.Length > 0 && !string.IsNullOrWhiteSpace(temp))
            {
                richEditReader.Visible = true;
                panelReader.Visible = true;
                richEditReader.Text = temp;
                textReader_reader.ReadAllText(temp);
            }
            else
            {
                richEditReader.Visible = false;
                panelReader.Visible = false;
                barBttReading.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        

        private void ribbonMainControl_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_MouseHover_1(object sender, EventArgs e)
        {

        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void tbVoiceSpeed_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void autoCompleteControler_Load(object sender, EventArgs e)
        {

        }

        private bool checkSentence()
        {
            bool complete = true;
            string temp = "";
            foreach (Control c in listWord1.Controls)
            {
                temp += c.Text;
            }
            //natcha
            if (temp.Equals(""))
            {
                complete = false;
                MessageBox.Show("กรูณาแต่งประโยคให้ครบ", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // complete = true;


            return complete;
        }

        //private void barBttHelp_ItemClick(object sender, ItemClickEventArgs e)
        //{
          //  if (File.Exists(helpFile))
            //{
              //  Process process = new Process();
                //ProcessStartInfo startInfo = new ProcessStartInfo();
                //process.StartInfo = startInfo;

//                startInfo.FileName = @helpFile;
  //              process.Start();


            //}
                /*
            {
                TopMost = false;
                uint hWnd = PInvoke.WinUser32.FindWindow("HH Parent", helpHeader);
                if (hWnd > 0) //If found
                {
                    PInvoke.WinUser32.SetForegroundWindow(hWnd);
                }
                else
                {
                    helpProcID = Process.Start(helpFile);
                }
            }*/
           // else
            //{
              //  MessageBox.Show("Not Found Help File!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            
        //}

       




        #endregion



    }
}
