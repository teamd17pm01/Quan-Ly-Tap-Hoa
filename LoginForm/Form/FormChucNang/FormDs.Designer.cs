namespace LoginForm
{
    partial class FormDs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDs));
            this.lstDanhSachSanPham = new System.Windows.Forms.ListView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtNhomSP = new Bunifu.Framework.UI.BunifuTextbox();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstDanhSachSanPham
            // 
            this.lstDanhSachSanPham.Location = new System.Drawing.Point(496, 12);
            this.lstDanhSachSanPham.Name = "lstDanhSachSanPham";
            this.lstDanhSachSanPham.Size = new System.Drawing.Size(1408, 729);
            this.lstDanhSachSanPham.TabIndex = 0;
            this.lstDanhSachSanPham.UseCompatibleStateImageBehavior = false;
            this.lstDanhSachSanPham.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Location = new System.Drawing.Point(475, -3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(16, 744);
            this.panel2.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Location = new System.Drawing.Point(1, 731);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(489, 10);
            this.panel3.TabIndex = 5;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Bahnschrift", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(25, 69);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(450, 51);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "Tìm Kiếm Theo Nhóm Sản Phẩm: ";
            this.bunifuCustomLabel1.Click += new System.EventHandler(this.bunifuCustomLabel1_Click);
            // 
            // txtNhomSP
            // 
            this.txtNhomSP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(81)))), ((int)(((byte)(97)))));
            this.txtNhomSP.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtNhomSP.BackgroundImage")));
            this.txtNhomSP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtNhomSP.Font = new System.Drawing.Font("Yu Gothic UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhomSP.ForeColor = System.Drawing.Color.White;
            this.txtNhomSP.Icon = ((System.Drawing.Image)(resources.GetObject("txtNhomSP.Icon")));
            this.txtNhomSP.Location = new System.Drawing.Point(31, 134);
            this.txtNhomSP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNhomSP.Name = "txtNhomSP";
            this.txtNhomSP.Size = new System.Drawing.Size(428, 65);
            this.txtNhomSP.TabIndex = 3;
            this.txtNhomSP.text = "";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.panel4);
            this.groupControl1.Controls.Add(this.bunifuCustomLabel1);
            this.groupControl1.Controls.Add(this.txtNhomSP);
            this.groupControl1.Location = new System.Drawing.Point(-6, -3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(489, 741);
            this.groupControl1.TabIndex = 8;
            this.groupControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl1_Paint);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Silver;
            this.panel4.Location = new System.Drawing.Point(6, 331);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(488, 1);
            this.panel4.TabIndex = 5;
            // 
            // FormDs
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1916, 765);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lstDanhSachSanPham);
            this.Name = "FormDs";
            this.Text = "Danh Sách Sản Phẩm";
            this.Load += new System.EventHandler(this.FormDs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstDanhSachSanPham;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuTextbox txtNhomSP;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Panel panel4;
    }
}