using LDWordProcessor.form;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LDWordProcessor
{
    public partial class UserMenuForm : Form
    {

        public UserMenuForm()
        {
            InitializeComponent();
        }

        nectec.VajaTTS ttsButton = new nectec.VajaTTS();
        byte[] utf8Bytes;
        // ฟังก์ชันอ่านออกเสียงปุ่มด้วย vaja 
        private void readButton(String buttonInfo)
        {
            byte[] utf8Bytes;
            utf8Bytes = Encoding.UTF8.GetBytes(buttonInfo);
            byte[] unicodeBytes = Encoding.Convert(Encoding.UTF8, Encoding.Unicode, utf8Bytes);
            ttsButton.Text = Encoding.Unicode.GetString(unicodeBytes);
            ttsButton.Volume = 100;
            ttsButton.PlayButton();
        }

        

        private void UserMenuForm_Load(object sender, EventArgs e)
        {
            lbName.Text = Program.AuthUser.Firstname + " " + Program.AuthUser.Surname;
            this.Refresh();
        }

        private void btnPreNewDoc_Click(object sender, EventArgs e)
        {
            Program.isPractice = true;
            DialogResult = DialogResult.OK;
        }

        private void btnNewDoc_Click(object sender, EventArgs e)
        {
            Program.isPractice = false;
            DialogResult = DialogResult.OK;
        }

        private void btnWorkList_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPreNewDoc_MouseHover(object sender, EventArgs e)
        {
            readButton("ฝึกสร้างประโยค");
        }

        private void btnNewDoc_MouseHover(object sender, EventArgs e)
        {
            readButton("สร้างประโยค");
        }

        private void btnExit_MouseHover(object sender, EventArgs e)
        {
            readButton("ปิดโปรแกรม");
        }
    }
}
