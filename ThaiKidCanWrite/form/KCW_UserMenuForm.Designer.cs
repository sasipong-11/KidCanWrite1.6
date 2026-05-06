namespace LDWordProcessor
{
    partial class UserMenuForm
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
            DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::LDWordProcessor.SplashScreen1), true, true);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserMenuForm));
            this.lbName = new DevExpress.XtraEditors.LabelControl();
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.btnPreNewDoc = new DevExpress.XtraEditors.SimpleButton();
            this.btnNewDoc = new DevExpress.XtraEditors.SimpleButton();
            this.btnWorkList = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.Appearance.Font = new System.Drawing.Font("Browallia New", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.lbName.Appearance.Options.UseFont = true;
            this.lbName.Appearance.Options.UseForeColor = true;
            this.lbName.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.lbName.Location = new System.Drawing.Point(407, 167);
            this.lbName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(300, 56);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "เด็กชาย สมชาย เรียนดี";
            // 
            // btnExit
            // 
            this.btnExit.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.btnExit.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.btnExit.Appearance.Font = new System.Drawing.Font("Browallia New", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Appearance.Options.UseBackColor = true;
            this.btnExit.Appearance.Options.UseBorderColor = true;
            this.btnExit.Appearance.Options.UseFont = true;
            this.btnExit.Appearance.Options.UseForeColor = true;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExit.ImageOptions.Image = global::LDWordProcessor.Properties.Resources.menu_4;
            this.btnExit.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnExit.Location = new System.Drawing.Point(823, 324);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(167, 110);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "ปิดโปรแกรม";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            this.btnExit.MouseHover += new System.EventHandler(this.btnExit_MouseHover);
            // 
            // btnPreNewDoc
            // 
            this.btnPreNewDoc.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btnPreNewDoc.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.btnPreNewDoc.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.btnPreNewDoc.Appearance.Font = new System.Drawing.Font("Browallia New", 19.5F);
            this.btnPreNewDoc.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnPreNewDoc.Appearance.Options.UseBackColor = true;
            this.btnPreNewDoc.Appearance.Options.UseBorderColor = true;
            this.btnPreNewDoc.Appearance.Options.UseFont = true;
            this.btnPreNewDoc.Appearance.Options.UseForeColor = true;
            this.btnPreNewDoc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPreNewDoc.ImageOptions.Image = global::LDWordProcessor.Properties.Resources.menu_1;
            this.btnPreNewDoc.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnPreNewDoc.Location = new System.Drawing.Point(441, 325);
            this.btnPreNewDoc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPreNewDoc.Name = "btnPreNewDoc";
            this.btnPreNewDoc.Size = new System.Drawing.Size(167, 110);
            this.btnPreNewDoc.TabIndex = 17;
            this.btnPreNewDoc.Text = "ฝึกสร้างประโยค";
            this.btnPreNewDoc.Click += new System.EventHandler(this.btnPreNewDoc_Click);
            this.btnPreNewDoc.MouseHover += new System.EventHandler(this.btnPreNewDoc_MouseHover);
            // 
            // btnNewDoc
            // 
            this.btnNewDoc.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btnNewDoc.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.btnNewDoc.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.btnNewDoc.Appearance.Font = new System.Drawing.Font("Browallia New", 19.5F);
            this.btnNewDoc.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnNewDoc.Appearance.Options.UseBackColor = true;
            this.btnNewDoc.Appearance.Options.UseBorderColor = true;
            this.btnNewDoc.Appearance.Options.UseFont = true;
            this.btnNewDoc.Appearance.Options.UseForeColor = true;
            this.btnNewDoc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNewDoc.ImageOptions.Image = global::LDWordProcessor.Properties.Resources.menu_2;
            this.btnNewDoc.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnNewDoc.Location = new System.Drawing.Point(629, 325);
            this.btnNewDoc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNewDoc.Name = "btnNewDoc";
            this.btnNewDoc.Size = new System.Drawing.Size(167, 110);
            this.btnNewDoc.TabIndex = 18;
            this.btnNewDoc.Text = "สร้างประโยค";
            this.btnNewDoc.Click += new System.EventHandler(this.btnNewDoc_Click);
            this.btnNewDoc.MouseHover += new System.EventHandler(this.btnNewDoc_MouseHover);
            // 
            // btnWorkList
            // 
            this.btnWorkList.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btnWorkList.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.btnWorkList.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.btnWorkList.Appearance.Font = new System.Drawing.Font("Browallia New", 19.5F);
            this.btnWorkList.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnWorkList.Appearance.Options.UseBackColor = true;
            this.btnWorkList.Appearance.Options.UseBorderColor = true;
            this.btnWorkList.Appearance.Options.UseFont = true;
            this.btnWorkList.Appearance.Options.UseForeColor = true;
            this.btnWorkList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnWorkList.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnWorkList.ImageOptions.Image")));
            this.btnWorkList.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnWorkList.Location = new System.Drawing.Point(607, 473);
            this.btnWorkList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnWorkList.Name = "btnWorkList";
            this.btnWorkList.Size = new System.Drawing.Size(167, 110);
            this.btnWorkList.TabIndex = 20;
            this.btnWorkList.Text = "เอกสารที่ส่งแล้ว";
            this.btnWorkList.Visible = false;
            this.btnWorkList.Click += new System.EventHandler(this.btnWorkList_Click);
            // 
            // UserMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1348, 721);
            this.Controls.Add(this.btnWorkList);
            this.Controls.Add(this.btnNewDoc);
            this.Controls.Add(this.btnPreNewDoc);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lbName);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ระบบบริการช่วยเขียนภาษาไทยตามจินตภาพ (KidCanWrite)";
            this.Load += new System.EventHandler(this.UserMenuForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lbName;
        private DevExpress.XtraEditors.SimpleButton btnExit;
        private DevExpress.XtraEditors.SimpleButton btnPreNewDoc;
        private DevExpress.XtraEditors.SimpleButton btnNewDoc;
        private DevExpress.XtraEditors.SimpleButton btnWorkList;
    }
}