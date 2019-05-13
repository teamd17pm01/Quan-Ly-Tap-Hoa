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
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnDel = new DevExpress.XtraEditors.SimpleButton();
            this.btnTimKiem = new DevExpress.XtraEditors.SimpleButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtNhomSP = new Bunifu.Framework.UI.BunifuTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstDanhSachSanPham
            // 
            this.lstDanhSachSanPham.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader7,
            this.columnHeader9,
            this.columnHeader8});
            this.lstDanhSachSanPham.Location = new System.Drawing.Point(496, 12);
            this.lstDanhSachSanPham.Name = "lstDanhSachSanPham";
            this.lstDanhSachSanPham.Size = new System.Drawing.Size(1408, 729);
            this.lstDanhSachSanPham.TabIndex = 0;
            this.lstDanhSachSanPham.UseCompatibleStateImageBehavior = false;
            this.lstDanhSachSanPham.View = System.Windows.Forms.View.Details;
            this.lstDanhSachSanPham.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.lstDanhSachSanPham.MouseHover += new System.EventHandler(this.lstDanhSachSanPham_MouseHover);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "MASP";
            this.columnHeader1.Width = 70;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "TENSP";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "DONGIA";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "DON VI TINH";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "SO LUONG";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 90;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "NHA CUNG CAP";
            this.columnHeader7.Width = 140;
            // 
            // columnHeader9
            // 
            this.columnHeader9.DisplayIndex = 7;
            this.columnHeader9.Text = "Nhóm SP";
            this.columnHeader9.Width = 120;
            // 
            // columnHeader8
            // 
            this.columnHeader8.DisplayIndex = 6;
            this.columnHeader8.Text = "GHI CHU";
            this.columnHeader8.Width = 100;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Location = new System.Drawing.Point(475, -3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(15, 777);
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
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(25, 69);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(450, 51);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "Tìm Kiếm Theo Nhóm Sản Phẩm: ";
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupControl1.Controls.Add(this.btnDel);
            this.groupControl1.Controls.Add(this.btnTimKiem);
            this.groupControl1.Controls.Add(this.panel4);
            this.groupControl1.Controls.Add(this.bunifuCustomLabel1);
            this.groupControl1.Controls.Add(this.txtNhomSP);
            this.groupControl1.Location = new System.Drawing.Point(-6, -3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(489, 767);
            this.groupControl1.TabIndex = 8;
            // 
            // btnDel
            // 
            this.btnDel.Appearance.Font = new System.Drawing.Font("Segoe UI Black", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.Appearance.Options.UseFont = true;
            this.btnDel.Enabled = false;
            this.btnDel.Location = new System.Drawing.Point(6, 678);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(483, 78);
            this.btnDel.TabIndex = 7;
            this.btnDel.Text = "Delete Item";
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Appearance.Font = new System.Drawing.Font("Sitka Text", 13F, System.Drawing.FontStyle.Bold);
            this.btnTimKiem.Appearance.Options.UseFont = true;
            this.btnTimKiem.Location = new System.Drawing.Point(108, 243);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(245, 71);
            this.btnTimKiem.TabIndex = 6;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Silver;
            this.panel4.Location = new System.Drawing.Point(6, 331);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(488, 1);
            this.panel4.TabIndex = 5;
            // 
            // txtNhomSP
            // 
            this.txtNhomSP.AutoSize = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
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
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private DevExpress.XtraEditors.SimpleButton btnTimKiem;
        private DevExpress.XtraEditors.SimpleButton btnDel;
    }
}