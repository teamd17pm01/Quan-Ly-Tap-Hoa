namespace LoginForm
{
    partial class frmNhaCungCap
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
            this.grDSNCC = new DevExpress.XtraEditors.GroupControl();
            this.imgNCC = new System.Windows.Forms.PictureBox();
            this.lstDSNCC = new System.Windows.Forms.ListView();
            this.Ma = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ten = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DiaChi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SoLuongChiNhanh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SoLuongMatHangCungCap = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.grDSNCC)).BeginInit();
            this.grDSNCC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgNCC)).BeginInit();
            this.SuspendLayout();
            // 
            // grDSNCC
            // 
            this.grDSNCC.Controls.Add(this.imgNCC);
            this.grDSNCC.Controls.Add(this.lstDSNCC);
            this.grDSNCC.Location = new System.Drawing.Point(3, 1);
            this.grDSNCC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grDSNCC.Name = "grDSNCC";
            this.grDSNCC.Size = new System.Drawing.Size(1910, 760);
            this.grDSNCC.TabIndex = 1;
            this.grDSNCC.Text = "Danh sách nhà cung cấp";
            // 
            // imgNCC
            // 
            this.imgNCC.Location = new System.Drawing.Point(1282, 35);
            this.imgNCC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.imgNCC.Name = "imgNCC";
            this.imgNCC.Size = new System.Drawing.Size(618, 280);
            this.imgNCC.TabIndex = 1;
            this.imgNCC.TabStop = false;
            // 
            // lstDSNCC
            // 
            this.lstDSNCC.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Ma,
            this.Ten,
            this.DiaChi,
            this.SoLuongChiNhanh,
            this.SoLuongMatHangCungCap});
            this.lstDSNCC.Location = new System.Drawing.Point(8, 35);
            this.lstDSNCC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstDSNCC.Name = "lstDSNCC";
            this.lstDSNCC.Size = new System.Drawing.Size(1266, 717);
            this.lstDSNCC.TabIndex = 0;
            this.lstDSNCC.UseCompatibleStateImageBehavior = false;
            this.lstDSNCC.View = System.Windows.Forms.View.Details;
            // 
            // Ma
            // 
            this.Ma.Text = "Mã nhà cung cấp";
            this.Ma.Width = 100;
            // 
            // Ten
            // 
            this.Ten.Text = "Tên nhà cung cấp";
            this.Ten.Width = 150;
            // 
            // DiaChi
            // 
            this.DiaChi.Text = "Địa chỉ";
            this.DiaChi.Width = 200;
            // 
            // SoLuongChiNhanh
            // 
            this.SoLuongChiNhanh.Text = "Số lượng chi nhánh";
            this.SoLuongChiNhanh.Width = 222;
            // 
            // SoLuongMatHangCungCap
            // 
            this.SoLuongMatHangCungCap.Text = "Số lượng mặt hàng cung cấp";
            this.SoLuongMatHangCungCap.Width = 249;
            // 
            // frmNhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(73)))), ((int)(((byte)(88)))));
            this.ClientSize = new System.Drawing.Size(1916, 765);
            this.Controls.Add(this.grDSNCC);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmNhaCungCap";
            this.Text = "Nhà cung cấp";
            ((System.ComponentModel.ISupportInitialize)(this.grDSNCC)).EndInit();
            this.grDSNCC.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgNCC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.GroupControl grDSNCC;
        private System.Windows.Forms.ListView lstDSNCC;
        private System.Windows.Forms.PictureBox imgNCC;
        private System.Windows.Forms.ColumnHeader Ma;
        private System.Windows.Forms.ColumnHeader Ten;
        private System.Windows.Forms.ColumnHeader DiaChi;
        private System.Windows.Forms.ColumnHeader SoLuongChiNhanh;
        private System.Windows.Forms.ColumnHeader SoLuongMatHangCungCap;
    }
}