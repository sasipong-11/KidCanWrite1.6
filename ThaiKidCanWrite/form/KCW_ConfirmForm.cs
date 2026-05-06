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
    public partial class KCW_ConfirmForm : Form
    {
        public KCW_ConfirmForm()
        {
            InitializeComponent();
        }

        private void bttOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
        }

        private void bttCancle_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
