using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using System.Net;
using LDWordProcessor.db;
using System.IO;
using NLog;
using Newtonsoft.Json;

namespace LDWordProcessor.form
{
    public partial class KCW_FromCreateMindmap : Form
    {
        private JArray masters;
        private JArray maps;
        private Logger logger = LogManager.GetCurrentClassLogger();
        nectec.VajaTTS ttsButton = new nectec.VajaTTS();

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
                logger.Error("Missing image asset: " + assetPath);
                throw new FileNotFoundException("Missing image asset", assetPath);
            }

            return Image.FromFile(assetPath);
        }

        private string LoadRequiredText(string relativePath)
        {
            string assetPath = ResolveAssetPath(relativePath);
            if (!File.Exists(assetPath))
            {
                logger.Error("Missing text asset: " + assetPath);
                throw new FileNotFoundException("Missing text asset", assetPath);
            }

            return File.ReadAllText(assetPath);
        }

        public KCW_FromCreateMindmap()
        {
            InitializeComponent();

           

        }

        private void KCW_PreNewDoc_Load(object sender, EventArgs e)
        {
            btnBack.Hide();
            btnCreateMindmap.Hide();
            btnNext.Hide();

            if (Program.isPractice)
            {
                string path = ResolveAssetPath(@"data\masters_photo.json");

                // เช็กก่อนว่าไฟล์มีอยู่จริง
                if (File.Exists(path))
                {
                    string jsonContent = File.ReadAllText(path);

                    // ลอง parse อย่างปลอดภัย
                    if (!string.IsNullOrWhiteSpace(jsonContent) && jsonContent.TrimStart().StartsWith("{"))
                    {
                        JObject data = JObject.Parse(jsonContent);
                        string status = data.SelectToken("status")?.ToString();

                        if (status == "ok")
                        {
                            masters = (JArray)data.SelectToken("masters");
                            AddPictureToTabPanel();
                        }
                        else
                        {
                            // status ไม่ใช่ ok (แต่อย่าแสดง error)
                            // คุณอาจ log เงียบ ๆ หรือปล่อยผ่าน
                        }
                    }
                }
                // ถ้าไฟล์ไม่มี หรือข้อมูลไม่ครบก็ไม่ทำอะไร
                // จะไม่มี MessageBox เด้ง
            }
            else
            {
                temp_picture.BackgroundImage = null;
                AddMindMapToTabPanel();
            }

            this.Refresh();
        }


        private void AddPictureToTabPanel()
        {

            //read select picture
            nectec.VajaTTS ttsSelectPic = new nectec.VajaTTS();
            string text = "เลือกโจทย์รูปภาพ";
            byte[] utf8Bytes;
            utf8Bytes = Encoding.UTF8.GetBytes(text);
            byte[] unicodeBytes = Encoding.Convert(Encoding.UTF8, Encoding.Unicode, utf8Bytes);
            ttsSelectPic.Text = Encoding.Unicode.GetString(unicodeBytes);
            ttsSelectPic.Volume = 100;
            ttsSelectPic.PlayButton();



            lbTitle.Text = "เลือกโจทย์รูปภาพ";
            list_picture.Controls.Clear();

            FlowLayoutPanel flp = new FlowLayoutPanel();
            flp.AutoScroll = true;
            flp.Dock = System.Windows.Forms.DockStyle.None;
            flp.AutoSize = true;
            flp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            flp.Location = new System.Drawing.Point(0, 10);
            flp.Name = "fLayoutPnl";
            flp.Dock = DockStyle.Fill;
            //var wc = new WebClient();
            foreach (JObject item in masters)
            {
                string id = item.GetValue("id").ToString();
                string photo = item.GetValue("photo_thumbnail").ToString();
                Button b = new Button();
               // b.Size = new Size(230, 160);
                b.Size = new Size(245, 180);
                
                //string image_url = String.Concat(Program.host, photo);
                //Image myimage = Image.FromStream(wc.OpenRead(image_url));

                //get Images in project(offline)
                string image_url = String.Concat(@"Images\masters\", photo);
                Image myimage = LoadRequiredImage(image_url);

                b.BackgroundImage = myimage;
                b.BackgroundImageLayout = ImageLayout.Stretch;
                b.Tag = item; //natcha 26102020
                b.Click += new EventHandler(SelectPicture);
                b.MouseHover += new System.EventHandler(this.readPicture);
                flp.Controls.Add(b);
            }
            list_picture.Controls.Add(flp);
        }

        

        private void readPicture(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            JObject master = (JObject)b.Tag;
            string read = master.GetValue("name").ToString();
            byte[] utf8Bytes;
            utf8Bytes = Encoding.UTF8.GetBytes(read);
            byte[] unicodeBytes = Encoding.Convert(Encoding.UTF8, Encoding.Unicode, utf8Bytes);
            ttsButton.Text = Encoding.Unicode.GetString(unicodeBytes);
            ttsButton.Volume = 100;
            ttsButton.PlayButton();
        }



        private void AddMindMapToTabPanel()
        {
            lbTitle.Text = "เลือกรูปแบบ Mind Map";
            list_picture.Controls.Clear();

            FlowLayoutPanel flp = new FlowLayoutPanel();
            flp.AutoScroll = true;
            flp.Dock = System.Windows.Forms.DockStyle.None;
            flp.AutoSize = true;
            flp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            flp.Location = new System.Drawing.Point(0, 10);
            flp.Name = "fLayoutPnl";
            flp.Dock = DockStyle.Fill;
            //var wc = new WebClient();
            BasicReq.BReq http = new BasicReq.BReq();

            int uid = Program.AuthUser.UserID;
            try {
                // string result = http.HttpGet(Program.host_api + "mindmap?uid=" + uid);
                // JObject data = JObject.Parse(result);
                JObject data = JObject.Parse(LoadRequiredText(@"data\masters_map.json"));

                string status = data.SelectToken("status").ToString();
                if (status.Equals("ok"))
                {
                    maps = (JArray)data.SelectToken("maps");
                    foreach (JObject item in maps)
                    {
                        string id = item.GetValue("id").ToString();
                        string photo = item.GetValue("image_preview").ToString();
                        Button b = new Button();
                       // b.Size = new Size(225, 160);
                        b.Size = new Size(245, 180);

                        //string image_url = String.Concat(Program.host, photo);
                       // Image myimage = Image.FromStream(wc.OpenRead(image_url));
                        string image_url = String.Concat(@"Images\maps\", photo);
                        Image myimage = LoadRequiredImage(image_url);
                        b.BackgroundImage = myimage;
                        b.BackgroundImageLayout = ImageLayout.Stretch;
                        b.Tag = item;
                        b.Click += new EventHandler(SelectMindMap);
                        flp.Controls.Add(b);
                    }
                    list_picture.Controls.Add(flp);
                }
            }catch (Exception er)
            {
                logger.Error("Load mindmap selection failed: " + er.ToString());
                MessageBox.Show("ไม่สามารถโหลดรายการ Mind Map ได้\n" + er.Message, "โหลดข้อมูลไม่สำเร็จ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void SelectPicture(object sender, EventArgs e)
        {

           

            btnNext.Show();
            Button b = (Button)sender;
            JObject master = (JObject)b.Tag;
            //var wc = new WebClient();
            string photo = master.SelectToken("photo_thumbnail").ToString();
           // string image_url = String.Concat(Program.host, photo);
           // Image myimage = Image.FromStream(wc.OpenRead(image_url));
            string image_url = String.Concat(@"Images\masters\", photo);
            Image myimage = LoadRequiredImage(image_url);
            temp_picture.BackgroundImage = myimage;
            temp_picture.BackgroundImageLayout = ImageLayout.Stretch;
            Program.SelectPicture = master;
        }
        private void SelectMindMap(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            JObject map = (JObject)b.Tag;
            Program.SelectMap = map;
            temp_map.BackgroundImageLayout = ImageLayout.Stretch;
            btnCreateMindmap.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            btnNext.Show();
            btnBack.Hide();
            btnCreateMindmap.Hide();
            AddPictureToTabPanel();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            lbTitle.Text = "เลือกรูปแบบ Mind Map";
            btnNext.Hide();
            btnBack.Show();
            AddMindMapToTabPanel();
        }

        private void btnCreateMindmap_Click(object sender, EventArgs e)
        {
            if (!Program.isPractice)
            {
                Program.SelectPicture = null;
            }
            DialogResult = DialogResult.Yes;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void list_picture_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
