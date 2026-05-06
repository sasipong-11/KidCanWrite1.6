namespace LDWordProcessor.form
{
    partial class KCW_ConfirmForm
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
            this.bttOk = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.bttCancle = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // bttOk
            // 
            this.bttOk.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.bttOk.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.bttOk.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.bttOk.Appearance.Font = new System.Drawing.Font("Browallia New", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttOk.Appearance.ForeColor = System.Drawing.Color.Black;
            this.bttOk.Appearance.Options.UseBackColor = true;
            this.bttOk.Appearance.Options.UseBorderColor = true;
            this.bttOk.Appearance.Options.UseFont = true;
            this.bttOk.Appearance.Options.UseForeColor = true;
            this.bttOk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bttOk.ImageOptions.Image = global::LDWordProcessor.Properties.Resources.icon_yes;
            this.bttOk.Location = new System.Drawing.Point(80, 117);
            this.bttOk.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.bttOk.Name = "bttOk";
            this.bttOk.Size = new System.Drawing.Size(119, 47);
            this.bttOk.TabIndex = 10;
            this.bttOk.Text = "ใช่";
            this.bttOk.Click += new System.EventHandler(this.bttOk_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Browallia New", 16F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.labelControl2.Location = new System.Drawing.Point(69, 39);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(296, 36);
            this.labelControl2.TabIndex = 17;
            this.labelControl2.Text = "ต้องการยกเลิกข้อมูลในหน้านี้หรือไม่";
            // 
            // bttCancle
            // 
            this.bttCancle.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.bttCancle.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.bttCancle.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.bttCancle.Appearance.Font = new System.Drawing.Font("Browallia New", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttCancle.Appearance.ForeColor = System.Drawing.Color.Black;
            this.bttCancle.Appearance.Options.UseBackColor = true;
            this.bttCancle.Appearance.Options.UseBorderColor = true;
            this.bttCancle.Appearance.Options.UseFont = true;
            this.bttCancle.Appearance.Options.UseForeColor = true;
            this.bttCancle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bttCancle.ImageOptions.Image = global::LDWordProcessor.Properties.Resources.icon_no;
            this.bttCancle.Location = new System.Drawing.Point(245, 117);
            this.bttCancle.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.bttCancle.Name = "bttCancle";
            this.bttCancle.Size = new System.Drawing.Size(119, 47);
            this.bttCancle.TabIndex = 10;
            this.bttCancle.Text = "ไม่ใช่";
            this.bttCancle.Click += new System.EventHandler(this.bttCancle_Click);
            // 
            // KCW_ConfirmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(449, 197);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.bttCancle);
            this.Controls.Add(this.bttOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(467, 244);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(467, 244);
            this.Name = "KCW_ConfirmForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton bttOk;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton bttCancle;
    }
}