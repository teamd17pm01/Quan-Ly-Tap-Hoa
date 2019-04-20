namespace LoginForm
{
    partial class frmRegister
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.ckKiemtra = new System.Windows.Forms.CheckBox();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.txtName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnDangKi = new System.Windows.Forms.Button();
            this.txtUserName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtPasswordComfirm = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(694, 148);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(28, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 77);
            this.label1.TabIndex = 0;
            this.label1.Text = "Register";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Maroon;
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancel.Location = new System.Drawing.Point(354, 604);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(184, 59);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 727);
            this.splitter1.TabIndex = 9;
            this.splitter1.TabStop = false;
            // 
            // ckKiemtra
            // 
            this.ckKiemtra.AutoSize = true;
            this.ckKiemtra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckKiemtra.Location = new System.Drawing.Point(38, 537);
            this.ckKiemtra.Name = "ckKiemtra";
            this.ckKiemtra.Size = new System.Drawing.Size(323, 24);
            this.ckKiemtra.TabIndex = 5;
            this.ckKiemtra.Text = "Chúng tôi đồng ý với điều khoản này";
            this.ckKiemtra.UseVisualStyleBackColor = true;
            this.ckKiemtra.CheckedChanged += new System.EventHandler(this.ckKiemtra_CheckedChanged);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(388, 540);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(23, 21);
            this.simpleButton1.TabIndex = 10;
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // txtName
            // 
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.Silver;
            this.txtName.HintForeColor = System.Drawing.Color.Silver;
            this.txtName.HintText = "họ và tên";
            this.txtName.isPassword = false;
            this.txtName.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.txtName.LineIdleColor = System.Drawing.Color.Silver;
            this.txtName.LineMouseHoverColor = System.Drawing.Color.Silver;
            this.txtName.LineThickness = 1;
            this.txtName.Location = new System.Drawing.Point(41, 174);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(514, 66);
            this.txtName.TabIndex = 11;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtName.OnValueChanged += new System.EventHandler(this.txtName_OnValueChanged);
            // 
            // btnDangKi
            // 
            this.btnDangKi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnDangKi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDangKi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangKi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDangKi.Location = new System.Drawing.Point(38, 604);
            this.btnDangKi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDangKi.Name = "btnDangKi";
            this.btnDangKi.Size = new System.Drawing.Size(188, 59);
            this.btnDangKi.TabIndex = 6;
            this.btnDangKi.Text = "Đăng kí";
            this.btnDangKi.UseVisualStyleBackColor = false;
            this.btnDangKi.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.Color.White;
            this.txtUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.ForeColor = System.Drawing.Color.Silver;
            this.txtUserName.HintForeColor = System.Drawing.Color.Silver;
            this.txtUserName.HintText = "họ và tên";
            this.txtUserName.isPassword = false;
            this.txtUserName.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.txtUserName.LineIdleColor = System.Drawing.Color.Silver;
            this.txtUserName.LineMouseHoverColor = System.Drawing.Color.Silver;
            this.txtUserName.LineThickness = 1;
            this.txtUserName.Location = new System.Drawing.Point(41, 261);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(514, 66);
            this.txtUserName.TabIndex = 12;
            this.txtUserName.Text = "User Name";
            this.txtUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.White;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.Silver;
            this.txtPassword.HintForeColor = System.Drawing.Color.Silver;
            this.txtPassword.HintText = "họ và tên";
            this.txtPassword.isPassword = false;
            this.txtPassword.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.txtPassword.LineIdleColor = System.Drawing.Color.Silver;
            this.txtPassword.LineMouseHoverColor = System.Drawing.Color.Silver;
            this.txtPassword.LineThickness = 1;
            this.txtPassword.Location = new System.Drawing.Point(41, 346);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(514, 66);
            this.txtPassword.TabIndex = 13;
            this.txtPassword.Text = "Password";
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtPasswordComfirm
            // 
            this.txtPasswordComfirm.BackColor = System.Drawing.Color.White;
            this.txtPasswordComfirm.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPasswordComfirm.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordComfirm.ForeColor = System.Drawing.Color.Silver;
            this.txtPasswordComfirm.HintForeColor = System.Drawing.Color.Silver;
            this.txtPasswordComfirm.HintText = "họ và tên";
            this.txtPasswordComfirm.isPassword = false;
            this.txtPasswordComfirm.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.txtPasswordComfirm.LineIdleColor = System.Drawing.Color.Silver;
            this.txtPasswordComfirm.LineMouseHoverColor = System.Drawing.Color.Silver;
            this.txtPasswordComfirm.LineThickness = 1;
            this.txtPasswordComfirm.Location = new System.Drawing.Point(41, 432);
            this.txtPasswordComfirm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPasswordComfirm.Name = "txtPasswordComfirm";
            this.txtPasswordComfirm.Size = new System.Drawing.Size(514, 66);
            this.txtPasswordComfirm.TabIndex = 14;
            this.txtPasswordComfirm.Text = "Comfirm Password";
            this.txtPasswordComfirm.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPasswordComfirm.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox1_OnValueChanged_1);
            // 
            // frmRegister
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(647, 727);
            this.Controls.Add(this.txtPasswordComfirm);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.ckKiemtra);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDangKi);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.Load += new System.EventHandler(this.frmRegister_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.CheckBox ckKiemtra;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtName;

        
        private System.Windows.Forms.Button btnDangKi;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtUserName;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPassword;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPasswordComfirm;
    }
}