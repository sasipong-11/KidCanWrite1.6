namespace LDWordProcessor
{
    partial class UserControl1
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
            this.TextLbl = new System.Windows.Forms.Label();
            this.SpeakBtn = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // TextLbl
            // 
            this.TextLbl.BackColor = System.Drawing.Color.Transparent;
            this.TextLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TextLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.TextLbl.Location = new System.Drawing.Point(4, 4);
            this.TextLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TextLbl.Name = "TextLbl";
            this.TextLbl.Size = new System.Drawing.Size(152, 22);
            this.TextLbl.TabIndex = 1;
            this.TextLbl.Text = "TextLbl";
            // 
            // SpeakBtn
            // 
            this.SpeakBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SpeakBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SpeakBtn.Image = global::LDWordProcessor.Properties.Resources.speaker_on;
            this.SpeakBtn.Location = new System.Drawing.Point(228, 1);
            this.SpeakBtn.Margin = new System.Windows.Forms.Padding(4);
            this.SpeakBtn.Name = "SpeakBtn";
            this.SpeakBtn.Size = new System.Drawing.Size(31, 25);
            this.SpeakBtn.TabIndex = 3;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.SpeakBtn);
            this.Controls.Add(this.TextLbl);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(288, 30);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label TextLbl;
        public DevExpress.XtraEditors.SimpleButton SpeakBtn;
    }
}
