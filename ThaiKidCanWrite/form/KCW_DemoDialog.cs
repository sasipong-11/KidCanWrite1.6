using DevExpress.XtraEditors;
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
    public partial class KCW_DemoDialog : Form
    {
        #region natcha's add
        private TextBox tbInput;
        public KCW_DemoDialog()
        {
            InitializeComponent();

        }

        public TextBox TbInput1
        {
            get { return tbInput; }
            set { tbInput = value; }
        }

    

        public Panel DemoPanel
        {
            get { return panel1; }
            set { panel1 = value; }
        }

        //private void btnCancel_Click(object sender, EventArgs e)
        //{
        //    this.Close();
        //}

        //private void btnOK_Click(object sender, EventArgs e)
        //{
        //  //  KCW_MainForm form1 = (KCW_MainForm)this.Owner;
        //    //รอปรับ ส่วนใส่ข้อมูลใน textbox
        //   // form1.m4_input_12.Text = textDemo.Text;
        //   // this.Close();


        //    if (tbInput != null && !textDemo.Text.Equals(""))
        //    {
        //        tbInput.Text = textDemo.Text;
        //    }
        //    this.Close();
        //    // btnApply_Click(sender,e);

        //}

        //private void btnApply_Click(object sender, EventArgs e)
        //{
        //    KCW_MainForm form1 = (KCW_MainForm)this.Owner;
        //    form1.m4_input_12.Text = textDemo.Text;
        //   // form1.Text = textDemo.Text;
        //}

        #endregion natcha's add
    }
}
