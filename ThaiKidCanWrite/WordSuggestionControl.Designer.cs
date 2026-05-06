namespace LDWordProcessor
{
    partial class WordSuggestionControl
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
            this.lbWordSuggest = new DevExpress.XtraEditors.ListBoxControl();
            this.splitterControl1 = new DevExpress.XtraEditors.SplitterControl();
            ((System.ComponentModel.ISupportInitialize)(this.lbWordSuggest)).BeginInit();
            this.SuspendLayout();
            // 
            // lbWordSuggest
            // 
            this.lbWordSuggest.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbWordSuggest.Appearance.Options.UseFont = true;
            this.lbWordSuggest.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbWordSuggest.Location = new System.Drawing.Point(3, 3);
            this.lbWordSuggest.Name = "lbWordSuggest";
            this.lbWordSuggest.Size = new System.Drawing.Size(215, 154);
            this.lbWordSuggest.TabIndex = 4;
            this.lbWordSuggest.Click += new System.EventHandler(this.lbWordSuggest_Click);
            this.lbWordSuggest.DoubleClick += new System.EventHandler(this.lbWordSuggest_DoubleClick);
            // 
            // splitterControl1
            // 
            this.splitterControl1.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.splitterControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitterControl1.Location = new System.Drawing.Point(3, 157);
            this.splitterControl1.Name = "splitterControl1";
            this.splitterControl1.Size = new System.Drawing.Size(215, 5);
            this.splitterControl1.TabIndex = 6;
            this.splitterControl1.TabStop = false;
            // 
            // WordSuggestionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.splitterControl1);
            this.Controls.Add(this.lbWordSuggest);
            this.Name = "WordSuggestionControl";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Size = new System.Drawing.Size(221, 542);
            ((System.ComponentModel.ISupportInitialize)(this.lbWordSuggest)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.ListBoxControl lbWordSuggest;
        private DevExpress.XtraEditors.SplitterControl splitterControl1;


    }
}
