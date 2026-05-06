using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LDWordProcessor.form
{
    public partial class KCW_WorkSend : Form
    {
        private JArray works1 = new JArray();
        private JArray works2 = new JArray();
        public KCW_WorkSend()
        {
            InitializeComponent();
        }

        private void _Send_Load(object sender, EventArgs e)
        {
            try { 
                BasicReq.BReq http = new BasicReq.BReq();
                int uid = Program.AuthUser.UserID;
                string result = http.HttpGet(Program.host_api + "waiting?uid=" + uid);
                JObject data = JObject.Parse(result);
                string status = data.SelectToken("status").ToString();
                if (status.Equals("ok"))
                {
                    works1 = (JArray)data.SelectToken("works");
                }
                result = http.HttpGet(Program.host_api + "success?uid=" + uid);
                data = JObject.Parse(result);
                status = data.SelectToken("status").ToString();
                if (status.Equals("ok"))
                {
                    works2 = (JArray)data.SelectToken("works");
                }
                AddItemToList();
            }
            catch (Exception er)
            {
                MessageBox.Show("กรุณาต่ออินเทอร์เน็ต", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void  AddItemToList(){
            send_list.Controls.Clear();
            FlowLayoutPanel flp = new FlowLayoutPanel();
            flp.AutoScroll = true;
            flp.Dock = System.Windows.Forms.DockStyle.None;
            flp.AutoSize = true;
            flp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            flp.Location = new System.Drawing.Point(0, 10);
            flp.Name = "fLayoutPnl";
            flp.Dock = DockStyle.Fill;
            foreach (JObject item in works1)
            {
                string name = "เรื่อง " + item.GetValue("subject").ToString();
                string createdate = item.GetValue("sent_datetime").ToString();
                Button b = new Button();
                b.Size = new Size(475, 45);
                b.Text = name + " (" + createdate + ")";
                b.BackgroundImageLayout = ImageLayout.None;
                b.Image = global::LDWordProcessor.Properties.Resources.sign_check_off;
                b.ImageAlign = ContentAlignment.MiddleLeft;
                b.BackColor = Color.White;
                b.Tag = item.GetValue("data").ToString();
                b.Click += new EventHandler(SelectItem1);
                flp.Controls.Add(b);
            }
            foreach (JObject item in works2)
            {
                string name = "เรื่อง " + item.GetValue("subject").ToString();
                string createdate = item.GetValue("sent_datetime").ToString();
                Button b = new Button();
                b.Size = new Size(475, 45);
                b.Text = name + " (" + createdate + ")";
                b.BackgroundImageLayout = ImageLayout.None;
                b.Image = global::LDWordProcessor.Properties.Resources.sign_check_on;
                b.ImageAlign = ContentAlignment.MiddleLeft;
                b.BackColor = Color.White;
                b.Tag = item.GetValue("id").ToString();
                b.Click += new EventHandler(SelectItem2);
                flp.Controls.Add(b);
            }
            send_list.Controls.Add(flp);
        }

        private void SelectItem1(object sender, EventArgs e)
        {
            Button bb = (Button)sender;
                 try
            {
                System.Diagnostics.Process.Start(@"https://view.officeapps.live.com/op/embed.aspx?src=" + Program.host + bb.Tag);
            }
            catch (Exception er)
            {
                Console.WriteLine("{0} Exception caught.", er);
            }
        }
        private void SelectItem2(object sender, EventArgs e)
        {
            Button bb = (Button)sender;
            try
            {
                System.Diagnostics.Process.Start(Program.host + @"apis/viewdetail/" + bb.Tag);
            }
            catch (Exception er)
            {
                Console.WriteLine("{0} Exception caught.", er);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
