using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NLog;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using LDWordProcessor.Class;

namespace LDWordProcessor
{
    public partial class LoginForm : Form
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle |= 0x02000000;   // WS_EX_COMPOSITED       
                return handleParam;
            }
        }

        //protected override void OnPaint(PaintEventArgs e)
        //{
        //    Graphics dc = e.Graphics;
        //    dc.DrawImageUnscaled(Background, 0, 0);
        //    base.OnPaint(e);
        //}
        //Bitmap Background, Backgroundtemp;
        //private void initialize()
        //{
        //    SetStyle(ControlStyles.UserPaint, true);
        //    SetStyle(ControlStyles.AllPaintingInWmPaint, true);
        //    SetStyle(ControlStyles.DoubleBuffer, true);
        //    Backgroundtemp = new Bitmap(Properties.Resources.rsz_login);
        //    Background = new Bitmap(Backgroundtemp, Backgroundtemp.Width, Backgroundtemp.Height);
        //}

        public LoginForm()
        {
            InitializeComponent();
            //initialize();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                    LDUserBinding user = new LDUserBinding();
                    user.UserID = 1;//(int)user_data.SelectToken("uid");
                    user.Firstname = "";// user_data.SelectToken("first_name").ToString();
                    user.Surname = "";// user_data.SelectToken("last_name").ToString();
                    user.Username = ""; //user_data.SelectToken("username").ToString();
                    user.Password = "password";
                    user.LastAccess = DateTime.Now.ToString("yyyy'-'MM'-'dd' 'HH':'mm':'ss");
                    bool s_user = LDUserManager.AddUser(user);
                    LDUserManager.SaveUser(user);
                    Program.AuthUser = user;
                    DialogResult = DialogResult.OK;
               
            }catch (Exception er)
            {
                MessageBox.Show("กรุณาต่ออินเทอร์เน็ต", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void LoginForm_Load(object sender, EventArgs e)
        {
        }

      

    }

}
