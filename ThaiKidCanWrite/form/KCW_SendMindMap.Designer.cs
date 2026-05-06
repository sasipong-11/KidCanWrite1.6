namespace LDWordProcessor.form
{
    partial class KCW_SendMindMap
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.choose = new DevExpress.XtraEditors.SimpleButton();
            this.teachers_combo_box = new System.Windows.Forms.ComboBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.SuspendLayout();
            // 
            // choose
            // 
            //this.choose.BackColor = System.Drawing.Color.White;
            //this.choose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //this.choose.Location = new System.Drawing.Point(132, 142);
            //this.choose.Margin = new System.Windows.Forms.Padding(4);
            //this.choose.Name = "choose";
            //this.choose.Size = new System.Drawing.Size(100, 39);
            //this.choose.TabIndex = 2;
            //this.choose.Text = "ส่งงาน";
            //this.choose.UseVisualStyleBackColor = false;
            //this.choose.Click += new System.EventHandler(this.choose_Click);


            this.choose.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.choose.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.choose.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.choose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choose.Appearance.ForeColor = System.Drawing.Color.Black;
            this.choose.Appearance.Options.UseBackColor = true;
            this.choose.Appearance.Options.UseBorderColor = true;
            this.choose.Appearance.Options.UseFont = true;
            this.choose.Appearance.Options.UseForeColor = true;
            this.choose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.choose.ImageOptions.Image = global::LDWordProcessor.Properties.Resources.icon_ol_sent;
            this.choose.Location = new System.Drawing.Point(132, 142);
            this.choose.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.choose.Name = "choose";
            this.choose.Size = new System.Drawing.Size(119, 47);
            this.choose.TabIndex = 10;
            this.choose.Text = "ส่งงาน";
            this.choose.Click += new System.EventHandler(this.choose_Click);


            // 
            // teachers_combo_box
            // 
            this.teachers_combo_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teachers_combo_box.FormattingEnabled = true;
            this.teachers_combo_box.Location = new System.Drawing.Point(27, 78);
            this.teachers_combo_box.Margin = new System.Windows.Forms.Padding(4);
            this.teachers_combo_box.Name = "teachers_combo_box";
            this.teachers_combo_box.Size = new System.Drawing.Size(313, 33);
            this.teachers_combo_box.TabIndex = 3;
            this.teachers_combo_box.Text = "รายชื่อครู";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Browallia New", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.labelControl2.Location = new System.Drawing.Point(89, 16);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(189, 43);
            this.labelControl2.TabIndex = 17;
            this.labelControl2.Text = "เลือกครูผู้ตรวจงาน";
            // 
            // KCW_SendMindMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(362, 203);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.teachers_combo_box);
            this.Controls.Add(this.choose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(380, 250);
            this.MinimumSize = new System.Drawing.Size(380, 250);
            this.Name = "KCW_SendMindMap";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "เลือกครูผู้ตรวจงาน";
            this.TopMost = true;
            this.Load += new System.EventHandler(this._ChooseTeacher_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton choose;
        private System.Windows.Forms.ComboBox teachers_combo_box;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}