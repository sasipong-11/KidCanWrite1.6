
namespace ThaiKidCanWriteLauncher
{
    partial class LauncherForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LauncherForm));
            this.panelLogin = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelConfirmLicense = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.labelChkLc = new System.Windows.Forms.Label();
            this.panelConfirmTrial = new System.Windows.Forms.Panel();
            this.labelTrial = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.b4Lc = new Bround();
            this.b4Cancle = new Bround();
            this.b4OK = new Bround();
            this.b3Cancle = new Bround();
            this.trTelNo = new Tround();
            this.trName = new Tround();
            this.trEmail = new Tround();
            this.b2Trial = new Bround();
            this.trOrg = new Tround();
            this.trLC = new Tround();
            this.b2Cancle = new Bround();
            this.b2OK = new Bround();
            this.panelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelConfirmLicense.SuspendLayout();
            this.panelConfirmTrial.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLogin
            // 
            this.panelLogin.Controls.Add(this.label6);
            this.panelLogin.Controls.Add(this.trTelNo);
            this.panelLogin.Controls.Add(this.label1);
            this.panelLogin.Controls.Add(this.label5);
            this.panelLogin.Controls.Add(this.trName);
            this.panelLogin.Controls.Add(this.trEmail);
            this.panelLogin.Controls.Add(this.b2Trial);
            this.panelLogin.Controls.Add(this.label4);
            this.panelLogin.Controls.Add(this.label3);
            this.panelLogin.Controls.Add(this.label2);
            this.panelLogin.Controls.Add(this.trOrg);
            this.panelLogin.Controls.Add(this.trLC);
            this.panelLogin.Controls.Add(this.b2Cancle);
            this.panelLogin.Controls.Add(this.b2OK);
            this.panelLogin.Location = new System.Drawing.Point(199, 6);
            this.panelLogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(500, 231);
            this.panelLogin.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label4.Location = new System.Drawing.Point(63, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(392, 19);
            this.label4.TabIndex = 20;
            this.label4.Text = "กรุณาใส่ License code และ หน่วยงาน เพื่อตรวจสอบข้อมูล";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.Location = new System.Drawing.Point(3, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 19);
            this.label3.TabIndex = 19;
            this.label3.Text = "หน่วยงาน";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(3, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 19);
            this.label2.TabIndex = 18;
            this.label2.Text = "License code";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(3, 24);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(190, 190);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panelConfirmLicense
            // 
            this.panelConfirmLicense.Controls.Add(this.button1);
            this.panelConfirmLicense.Controls.Add(this.b3Cancle);
            this.panelConfirmLicense.Controls.Add(this.labelChkLc);
            this.panelConfirmLicense.Location = new System.Drawing.Point(199, 240);
            this.panelConfirmLicense.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelConfirmLicense.Name = "panelConfirmLicense";
            this.panelConfirmLicense.Size = new System.Drawing.Size(500, 231);
            this.panelConfirmLicense.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.OrangeRed;
            this.button1.Location = new System.Drawing.Point(375, 200);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 28);
            this.button1.TabIndex = 10;
            this.button1.Text = "ยกเลิก License Code";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.bround1_Click);
            // 
            // labelChkLc
            // 
            this.labelChkLc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.labelChkLc.Location = new System.Drawing.Point(49, 56);
            this.labelChkLc.Name = "labelChkLc";
            this.labelChkLc.Size = new System.Drawing.Size(423, 53);
            this.labelChkLc.TabIndex = 1;
            this.labelChkLc.Text = "กำลังตรวจสอบ License code กรุณารอสักครู่ ...";
            this.labelChkLc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelConfirmTrial
            // 
            this.panelConfirmTrial.Controls.Add(this.b4Lc);
            this.panelConfirmTrial.Controls.Add(this.b4Cancle);
            this.panelConfirmTrial.Controls.Add(this.b4OK);
            this.panelConfirmTrial.Controls.Add(this.labelTrial);
            this.panelConfirmTrial.Location = new System.Drawing.Point(199, 474);
            this.panelConfirmTrial.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelConfirmTrial.Name = "panelConfirmTrial";
            this.panelConfirmTrial.Size = new System.Drawing.Size(500, 231);
            this.panelConfirmTrial.TabIndex = 2;
            // 
            // labelTrial
            // 
            this.labelTrial.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.labelTrial.Location = new System.Drawing.Point(42, 56);
            this.labelTrial.Name = "labelTrial";
            this.labelTrial.Size = new System.Drawing.Size(423, 53);
            this.labelTrial.TabIndex = 2;
            this.labelTrial.Text = "เหลือเวลาทดลองใช้ 30 วัน";
            this.labelTrial.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(3, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 19);
            this.label1.TabIndex = 24;
            this.label1.Text = "ชื่อ - นามสกุล";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label5.Location = new System.Drawing.Point(3, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 19);
            this.label5.TabIndex = 23;
            this.label5.Text = "E-Mail";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label6.Location = new System.Drawing.Point(3, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 19);
            this.label6.TabIndex = 26;
            this.label6.Text = "เบอร์โทรติดต่อ";
            // 
            // b4Lc
            // 
            this.b4Lc.BackColor = System.Drawing.Color.RoyalBlue;
            this.b4Lc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b4Lc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.b4Lc.ForeColor = System.Drawing.Color.White;
            this.b4Lc.Location = new System.Drawing.Point(6, 178);
            this.b4Lc.Name = "b4Lc";
            this.b4Lc.Size = new System.Drawing.Size(164, 32);
            this.b4Lc.TabIndex = 13;
            this.b4Lc.Text = "ใส่ License code";
            this.b4Lc.UseVisualStyleBackColor = false;
            this.b4Lc.Click += new System.EventHandler(this.b4Lc_Click);
            // 
            // b4Cancle
            // 
            this.b4Cancle.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.b4Cancle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b4Cancle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.b4Cancle.ForeColor = System.Drawing.Color.White;
            this.b4Cancle.Location = new System.Drawing.Point(384, 178);
            this.b4Cancle.Name = "b4Cancle";
            this.b4Cancle.Size = new System.Drawing.Size(98, 32);
            this.b4Cancle.TabIndex = 12;
            this.b4Cancle.Text = "ยกเลิก";
            this.b4Cancle.UseVisualStyleBackColor = false;
            this.b4Cancle.Click += new System.EventHandler(this.b4Cancle_Click);
            // 
            // b4OK
            // 
            this.b4OK.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.b4OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b4OK.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.b4OK.ForeColor = System.Drawing.Color.White;
            this.b4OK.Location = new System.Drawing.Point(266, 178);
            this.b4OK.Name = "b4OK";
            this.b4OK.Size = new System.Drawing.Size(98, 32);
            this.b4OK.TabIndex = 11;
            this.b4OK.Text = "ตกลง";
            this.b4OK.UseVisualStyleBackColor = false;
            this.b4OK.Click += new System.EventHandler(this.b4OK_Click);
            // 
            // b3Cancle
            // 
            this.b3Cancle.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.b3Cancle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b3Cancle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.b3Cancle.ForeColor = System.Drawing.Color.White;
            this.b3Cancle.Location = new System.Drawing.Point(202, 178);
            this.b3Cancle.Name = "b3Cancle";
            this.b3Cancle.Size = new System.Drawing.Size(98, 32);
            this.b3Cancle.TabIndex = 9;
            this.b3Cancle.Text = "ยกเลิก";
            this.b3Cancle.UseVisualStyleBackColor = false;
            this.b3Cancle.Click += new System.EventHandler(this.b3Cancle_Click);
            // 
            // trTelNo
            // 
            this.trTelNo.BackColor = System.Drawing.Color.Cyan;
            this.trTelNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.trTelNo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.trTelNo.Location = new System.Drawing.Point(113, 116);
            this.trTelNo.Name = "trTelNo";
            this.trTelNo.Size = new System.Drawing.Size(368, 20);
            this.trTelNo.TabIndex = 4;
            // 
            // trName
            // 
            this.trName.BackColor = System.Drawing.Color.Cyan;
            this.trName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.trName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.trName.Location = new System.Drawing.Point(113, 35);
            this.trName.Name = "trName";
            this.trName.Size = new System.Drawing.Size(368, 20);
            this.trName.TabIndex = 1;
            // 
            // trEmail
            // 
            this.trEmail.BackColor = System.Drawing.Color.Cyan;
            this.trEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.trEmail.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.trEmail.Location = new System.Drawing.Point(113, 61);
            this.trEmail.Name = "trEmail";
            this.trEmail.Size = new System.Drawing.Size(368, 20);
            this.trEmail.TabIndex = 2;
            // 
            // b2Trial
            // 
            this.b2Trial.BackColor = System.Drawing.Color.ForestGreen;
            this.b2Trial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b2Trial.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.b2Trial.ForeColor = System.Drawing.Color.White;
            this.b2Trial.Location = new System.Drawing.Point(6, 178);
            this.b2Trial.Name = "b2Trial";
            this.b2Trial.Size = new System.Drawing.Size(164, 32);
            this.b2Trial.TabIndex = 8;
            this.b2Trial.Text = "ทดลองใช้ (30 วัน)";
            this.b2Trial.UseVisualStyleBackColor = false;
            this.b2Trial.Click += new System.EventHandler(this.b2Trial_Click);
            // 
            // trOrg
            // 
            this.trOrg.BackColor = System.Drawing.Color.Cyan;
            this.trOrg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.trOrg.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.trOrg.Location = new System.Drawing.Point(113, 89);
            this.trOrg.Name = "trOrg";
            this.trOrg.Size = new System.Drawing.Size(368, 20);
            this.trOrg.TabIndex = 3;
            // 
            // trLC
            // 
            this.trLC.BackColor = System.Drawing.Color.Cyan;
            this.trLC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.trLC.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.trLC.Location = new System.Drawing.Point(113, 143);
            this.trLC.Name = "trLC";
            this.trLC.Size = new System.Drawing.Size(368, 20);
            this.trLC.TabIndex = 5;
            // 
            // b2Cancle
            // 
            this.b2Cancle.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.b2Cancle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b2Cancle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.b2Cancle.ForeColor = System.Drawing.Color.White;
            this.b2Cancle.Location = new System.Drawing.Point(384, 178);
            this.b2Cancle.Name = "b2Cancle";
            this.b2Cancle.Size = new System.Drawing.Size(98, 32);
            this.b2Cancle.TabIndex = 7;
            this.b2Cancle.Text = "ยกเลิก";
            this.b2Cancle.UseVisualStyleBackColor = false;
            this.b2Cancle.Click += new System.EventHandler(this.b2Cancle_Click);
            // 
            // b2OK
            // 
            this.b2OK.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.b2OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b2OK.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.b2OK.ForeColor = System.Drawing.Color.White;
            this.b2OK.Location = new System.Drawing.Point(266, 178);
            this.b2OK.Name = "b2OK";
            this.b2OK.Size = new System.Drawing.Size(98, 32);
            this.b2OK.TabIndex = 6;
            this.b2OK.Text = "ตกลง";
            this.b2OK.UseVisualStyleBackColor = false;
            this.b2OK.Click += new System.EventHandler(this.b2OK_Click);
            // 
            // LauncherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(705, 240);
            this.Controls.Add(this.panelConfirmTrial);
            this.Controls.Add(this.panelConfirmLicense);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "LauncherForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ระบบตรวจสอบ License ระบบบริการช่วยเขียนภาษาไทยตามจินตภาพ (KidCanWrite)";
            this.Shown += new System.EventHandler(this.LauncherForm_Shown);
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelConfirmLicense.ResumeLayout(false);
            this.panelConfirmTrial.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLogin;
        private Bround b2Trial;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Tround trOrg;
        private Tround trLC;
        private Bround b2Cancle;
        private Bround b2OK;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelConfirmLicense;
        private System.Windows.Forms.Panel panelConfirmTrial;
        private Bround b3Cancle;
        private System.Windows.Forms.Label labelChkLc;
        private Bround b4Lc;
        private Bround b4Cancle;
        private Bround b4OK;
        private System.Windows.Forms.Label labelTrial;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private Tround trTelNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private Tround trName;
        private Tround trEmail;
    }
}

