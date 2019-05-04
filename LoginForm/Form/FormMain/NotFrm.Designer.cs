namespace LoginForm
{
    partial class FrmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.pnlVer = new System.Windows.Forms.Panel();
            this.lblTimer = new System.Windows.Forms.Label();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnSup = new System.Windows.Forms.Button();
            this.btnSales = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlHoz = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.timeNow = new System.Windows.Forms.Timer(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlVer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlHoz.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlVer
            // 
            this.pnlVer.BackColor = System.Drawing.Color.AntiqueWhite;
            this.pnlVer.Controls.Add(this.lblTimer);
            this.pnlVer.Controls.Add(this.btnAbout);
            this.pnlVer.Controls.Add(this.btnSup);
            this.pnlVer.Controls.Add(this.btnSales);
            this.pnlVer.Controls.Add(this.btnHome);
            this.pnlVer.Controls.Add(this.panel2);
            this.pnlVer.Controls.Add(this.pictureBox1);
            this.pnlVer.Location = new System.Drawing.Point(-3, -2);
            this.pnlVer.Name = "pnlVer";
            this.pnlVer.Size = new System.Drawing.Size(237, 903);
            this.pnlVer.TabIndex = 0;
            // 
            // lblTimer
            // 
            this.lblTimer.BackColor = System.Drawing.Color.White;
            this.lblTimer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTimer.Font = new System.Drawing.Font("Tw Cen MT", 20F);
            this.lblTimer.Location = new System.Drawing.Point(-4, 825);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(233, 87);
            this.lblTimer.TabIndex = 6;
            this.lblTimer.Text = "HH:MM:SS";
            this.lblTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTimer.Click += new System.EventHandler(this.lblTimer_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.FlatAppearance.BorderSize = 0;
            this.btnAbout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAbout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.ForeColor = System.Drawing.Color.Black;
            this.btnAbout.Image = ((System.Drawing.Image)(resources.GetObject("btnAbout.Image")));
            this.btnAbout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbout.Location = new System.Drawing.Point(14, 429);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(214, 82);
            this.btnAbout.TabIndex = 5;
            this.btnAbout.Text = "About";
            this.btnAbout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnSup
            // 
            this.btnSup.BackColor = System.Drawing.Color.Transparent;
            this.btnSup.FlatAppearance.BorderSize = 0;
            this.btnSup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnSup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSup.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSup.ForeColor = System.Drawing.Color.Black;
            this.btnSup.Image = ((System.Drawing.Image)(resources.GetObject("btnSup.Image")));
            this.btnSup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSup.Location = new System.Drawing.Point(14, 349);
            this.btnSup.Name = "btnSup";
            this.btnSup.Size = new System.Drawing.Size(214, 74);
            this.btnSup.TabIndex = 4;
            this.btnSup.Text = "Supplier";
            this.btnSup.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSup.UseVisualStyleBackColor = false;
            this.btnSup.Click += new System.EventHandler(this.btnSup_Click);
            // 
            // btnSales
            // 
            this.btnSales.FlatAppearance.BorderSize = 0;
            this.btnSales.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSales.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSales.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSales.ForeColor = System.Drawing.Color.Black;
            this.btnSales.Image = ((System.Drawing.Image)(resources.GetObject("btnSales.Image")));
            this.btnSales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSales.Location = new System.Drawing.Point(15, 263);
            this.btnSales.Name = "btnSales";
            this.btnSales.Size = new System.Drawing.Size(211, 80);
            this.btnSales.TabIndex = 3;
            this.btnSales.Text = " Sales";
            this.btnSales.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSales.UseVisualStyleBackColor = true;
            this.btnSales.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnHome
            // 
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.Black;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(14, 172);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(214, 85);
            this.btnHome.TabIndex = 2;
            this.btnHome.Text = "Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.panel2.Location = new System.Drawing.Point(232, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(999, 75);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(237, 163);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnlHoz
            // 
            this.pnlHoz.BackColor = System.Drawing.Color.AntiqueWhite;
            this.pnlHoz.Controls.Add(this.lblTitle);
            this.pnlHoz.Location = new System.Drawing.Point(227, 67);
            this.pnlHoz.Name = "pnlHoz";
            this.pnlHoz.Size = new System.Drawing.Size(1011, 82);
            this.pnlHoz.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(232, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(483, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "The Warehouse Management, BroTeam Make It";
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(1113, -2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(125, 49);
            this.btnExit.TabIndex = 4;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.button5_Click);
            // 
            // timeNow
            // 
            this.timeNow.Tick += new System.EventHandler(this.timeNow_Tick);
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(234, 155);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(972, 746);
            this.panel4.TabIndex = 5;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(387, 7);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(205, 70);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Home";
            // 
            // FrmMain
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1202, 895);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlHoz);
            this.Controls.Add(this.pnlVer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.pnlVer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlHoz.ResumeLayout(false);
            this.pnlHoz.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlVer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlHoz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSales;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnSup;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Timer timeNow;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panel4;
    }
}