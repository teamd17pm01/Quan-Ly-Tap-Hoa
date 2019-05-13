namespace LoginForm
{
    partial class InforUser
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
            this.richEditControl1 = new DevExpress.XtraRichEdit.RichEditControl();
            this.richEditControl2 = new DevExpress.XtraRichEdit.RichEditControl();
            this.textInfor = new DevExpress.XtraRichEdit.RichEditControl();
            this.SuspendLayout();
            // 
            // richEditControl1
            // 
            this.richEditControl1.Location = new System.Drawing.Point(145, 89);
            this.richEditControl1.Name = "richEditControl1";
            this.richEditControl1.Size = new System.Drawing.Size(8, 8);
            this.richEditControl1.TabIndex = 0;
            this.richEditControl1.Text = "richEditControl1";
            // 
            // richEditControl2
            // 
            this.richEditControl2.Location = new System.Drawing.Point(590, 146);
            this.richEditControl2.Name = "richEditControl2";
            this.richEditControl2.Size = new System.Drawing.Size(8, 8);
            this.richEditControl2.TabIndex = 1;
            this.richEditControl2.Text = "richEditControl2";
            // 
            // textInfor
            // 
            this.textInfor.Location = new System.Drawing.Point(12, 12);
            this.textInfor.Name = "textInfor";
            this.textInfor.Size = new System.Drawing.Size(1904, 750);
            this.textInfor.TabIndex = 2;
            this.textInfor.Text = "richEditControl3";
            this.textInfor.Click += new System.EventHandler(this.richEditControl3_Click);
            // 
            // InforUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1916, 765);
            this.Controls.Add(this.textInfor);
            this.Controls.Add(this.richEditControl2);
            this.Controls.Add(this.richEditControl1);
            this.Name = "InforUser";
            this.Text = "InforUser";
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraRichEdit.RichEditControl richEditControl1;
        private DevExpress.XtraRichEdit.RichEditControl richEditControl2;
        private DevExpress.XtraRichEdit.RichEditControl textInfor;
    }
}