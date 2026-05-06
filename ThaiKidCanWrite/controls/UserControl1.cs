using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LDWordProcessor
{
    public partial class UserControl1 : UserControl
    {
        Color defaultColor;
        public UserControl1(string label)
        {
            InitializeComponent();
            TextLbl.Text = label;
            defaultColor = this.BackColor;

            this.MouseEnter += new EventHandler(UserControl1_MouseEnter);
            this.MouseLeave += new EventHandler(UserControl1_MouseLeave);
            TextLbl.MouseEnter += new EventHandler(TextLbl_MouseEnter);
            TextLbl.MouseLeave += new EventHandler(TextLbl_MouseLeave);
            SpeakBtn.MouseEnter += new EventHandler(SpeakBtn_MouseEnter);
            SpeakBtn.MouseLeave += new EventHandler(SpeakBtn_MouseLeave);
        }

        void SpeakBtn_MouseLeave(object sender, EventArgs e)
        {
            UserControl1_MouseLeave(sender, e);
        }

        void SpeakBtn_MouseEnter(object sender, EventArgs e)
        {
            UserControl1_MouseEnter(sender, e);
        }

        void TextLbl_MouseLeave(object sender, EventArgs e)
        {
            UserControl1_MouseLeave(sender, e);
        }

        void TextLbl_MouseEnter(object sender, EventArgs e)
        {
            UserControl1_MouseEnter(sender, e);
        }

        void UserControl1_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = defaultColor;
        }

        void UserControl1_MouseEnter(object sender, EventArgs e)
        {
           // this.BackColor = Color.Aqua;
            this.BackColor = Color.LightBlue;
        }

        

    }
}