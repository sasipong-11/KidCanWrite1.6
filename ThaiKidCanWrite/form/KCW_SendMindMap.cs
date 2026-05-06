using java.lang;
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
    public partial class KCW_SendMindMap : Form
    {
        HttpsService http = new HttpsService();
        JArray teachers;
        string teacher_id;
        public KCW_SendMindMap()
        {
            InitializeComponent();
        }

        private void _ChooseTeacher_Load(object sender, EventArgs e)
        {
            try { 
                string result = http.HttpGet("teacher?uid=" + Program.AuthUser.UserID);
                JObject data = JObject.Parse(result);
                string status = data.SelectToken("status").ToString();
                if (status.Equals("ok"))
                {
                    teachers = (JArray)data.SelectToken("teachers");
                    int i = 0;
                    foreach (JObject item in teachers)
                    {
                        string id = item.GetValue("uid").ToString();
                        string name = item.GetValue("name").ToString();
                        teachers_combo_box.Items.Insert(i++, name);
                    }
                //dropDown.Add
                }
            }
            catch (System.Exception er)
            {
                MessageBox.Show("กรุณาต่ออินเทอร์เน็ต", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void choose_Click(object sender, EventArgs e)
        {
            int currentMyComboBoxIndex = teachers_combo_box.SelectedIndex;
            if (currentMyComboBoxIndex > -1)
            {
                int i = 0;
                foreach (JObject item in teachers)
                {
                    if (currentMyComboBoxIndex == i++)
                    {
                        string id = item.GetValue("uid").ToString();
                        teacher_id = id;
                        Program.answer.send = teacher_id;
                        DialogResult = DialogResult.OK;
                        break;
                    }
                }
            }
            else
            {
                MessageBox.Show("กรุณาเลือกครูผู้ตรวจงาน");
            }
        }
    }
}
