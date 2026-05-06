namespace LDWordProcessor
{
    partial class UserControl2
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.prevBtn = new DevExpress.XtraEditors.SimpleButton();
            this.nextBtn = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // prevBtn
            // 
            this.prevBtn.Location = new System.Drawing.Point(7, 6);
            this.prevBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.prevBtn.Name = "prevBtn";
            this.prevBtn.Size = new System.Drawing.Size(87, 27);
            this.prevBtn.TabIndex = 5;
            this.prevBtn.Text = "<< ก่อนหน้า";
            // 
            // nextBtn
            // 
            this.nextBtn.Location = new System.Drawing.Point(127, 6);
            this.nextBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(87, 27);
            this.nextBtn.TabIndex = 4;
            this.nextBtn.Text = "ถัดไป >>";
            // 
            // UserControl2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.prevBtn);
            this.Controls.Add(this.nextBtn);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UserControl2";
            this.Size = new System.Drawing.Size(220, 40);
            this.ResumeLayout(false);

        }

        #endregion

        public DevExpress.XtraEditors.SimpleButton prevBtn;
        public DevExpress.XtraEditors.SimpleButton nextBtn;

    }
}
