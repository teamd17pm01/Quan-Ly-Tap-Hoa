namespace LoginForm
{
    partial class FrmNhapHang
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
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn1 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 0", "Mã Hóa Đơn");
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn2 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 1", "Mã Sản Phẩm");
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn3 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 2", "Tên Sản Phẩm");
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn4 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 3", "Ngày Nhập");
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn5 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 4", "Số Lượng");
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn6 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 5", "Tổng Tiền");
            Telerik.WinControls.UI.RadListDataItem radListDataItem1 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem2 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem3 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem4 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem5 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem6 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn7 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 0", "Mã Hóa Đơn");
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn8 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 1", "Mã Sản Phẩm");
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn9 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 2", "Tên Sản Phẩm");
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn10 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 3", "Ngày Nhập");
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn11 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 4", "Số Lượng");
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn12 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 5", "Tổng Tiền");
            this.lstDanhSachNhapHang = new Telerik.WinControls.UI.RadListView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.TimKiem = new Telerik.WinControls.UI.RadDropDownList();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.radDropDownList1 = new Telerik.WinControls.UI.RadDropDownList();
            this.lstDanhSachBan = new Telerik.WinControls.UI.RadListView();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.lstDanhSachNhapHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TimKiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstDanhSachBan)).BeginInit();
            this.SuspendLayout();
            // 
            // lstDanhSachNhapHang
            // 
            listViewDetailColumn1.HeaderText = "Mã Hóa Đơn";
            listViewDetailColumn1.Width = 300F;
            listViewDetailColumn2.HeaderText = "Mã Sản Phẩm";
            listViewDetailColumn2.Width = 300F;
            listViewDetailColumn3.HeaderText = "Tên Sản Phẩm";
            listViewDetailColumn3.Width = 500F;
            listViewDetailColumn4.HeaderText = "Ngày Nhập";
            listViewDetailColumn4.Width = 300F;
            listViewDetailColumn5.HeaderText = "Số Lượng";
            listViewDetailColumn6.HeaderText = "Tổng Tiền";
            this.lstDanhSachNhapHang.Columns.AddRange(new Telerik.WinControls.UI.ListViewDetailColumn[] {
            listViewDetailColumn1,
            listViewDetailColumn2,
            listViewDetailColumn3,
            listViewDetailColumn4,
            listViewDetailColumn5,
            listViewDetailColumn6});
            this.lstDanhSachNhapHang.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstDanhSachNhapHang.ItemSpacing = -1;
            this.lstDanhSachNhapHang.Location = new System.Drawing.Point(6, 36);
            this.lstDanhSachNhapHang.Name = "lstDanhSachNhapHang";
            this.lstDanhSachNhapHang.Size = new System.Drawing.Size(1474, 323);
            this.lstDanhSachNhapHang.TabIndex = 0;
            this.lstDanhSachNhapHang.ViewType = Telerik.WinControls.UI.ListViewType.DetailsView;
            this.lstDanhSachNhapHang.ColumnCreating += new Telerik.WinControls.UI.ListViewColumnCreatingEventHandler(this.lstDanhSachNhapHang_ColumnCreating);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.TimKiem);
            this.groupControl1.Controls.Add(this.lstDanhSachNhapHang);
            this.groupControl1.Controls.Add(this.bunifuCustomLabel1);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1892, 365);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Danh Sách Hàng Đã Nhập";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(1486, 36);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(136, 36);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "Sort By:";
            // 
            // TimKiem
            // 
            radListDataItem1.Text = "Mã Hóa Đơn";
            radListDataItem2.Text = "Số Lượng";
            radListDataItem3.Text = "Tiền";
            this.TimKiem.Items.Add(radListDataItem1);
            this.TimKiem.Items.Add(radListDataItem2);
            this.TimKiem.Items.Add(radListDataItem3);
            this.TimKiem.Location = new System.Drawing.Point(1492, 75);
            this.TimKiem.Name = "TimKiem";
            this.TimKiem.Size = new System.Drawing.Size(260, 27);
            this.TimKiem.TabIndex = 1;
            this.TimKiem.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.TimKiem_SelectedIndexChanged);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.radDropDownList1);
            this.groupControl2.Controls.Add(this.lstDanhSachBan);
            this.groupControl2.Controls.Add(this.bunifuCustomLabel2);
            this.groupControl2.Location = new System.Drawing.Point(12, 398);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1892, 355);
            this.groupControl2.TabIndex = 2;
            this.groupControl2.Text = "Danh Sách Hàng Đã Bán";
            // 
            // radDropDownList1
            // 
            radListDataItem4.Text = "Mã Hóa Đơn";
            radListDataItem5.Text = "Số Lượng";
            radListDataItem6.Text = "Tiền";
            this.radDropDownList1.Items.Add(radListDataItem4);
            this.radDropDownList1.Items.Add(radListDataItem5);
            this.radDropDownList1.Items.Add(radListDataItem6);
            this.radDropDownList1.Location = new System.Drawing.Point(1492, 75);
            this.radDropDownList1.Name = "radDropDownList1";
            this.radDropDownList1.Size = new System.Drawing.Size(260, 27);
            this.radDropDownList1.TabIndex = 1;
            // 
            // lstDanhSachBan
            // 
            listViewDetailColumn7.HeaderText = "Mã Hóa Đơn";
            listViewDetailColumn7.Width = 300F;
            listViewDetailColumn8.HeaderText = "Mã Sản Phẩm";
            listViewDetailColumn8.Width = 300F;
            listViewDetailColumn9.HeaderText = "Tên Sản Phẩm";
            listViewDetailColumn9.Width = 500F;
            listViewDetailColumn10.HeaderText = "Ngày Nhập";
            listViewDetailColumn10.Width = 300F;
            listViewDetailColumn11.HeaderText = "Số Lượng";
            listViewDetailColumn12.HeaderText = "Tổng Tiền";
            this.lstDanhSachBan.Columns.AddRange(new Telerik.WinControls.UI.ListViewDetailColumn[] {
            listViewDetailColumn7,
            listViewDetailColumn8,
            listViewDetailColumn9,
            listViewDetailColumn10,
            listViewDetailColumn11,
            listViewDetailColumn12});
            this.lstDanhSachBan.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstDanhSachBan.ItemSpacing = -1;
            this.lstDanhSachBan.Location = new System.Drawing.Point(6, 36);
            this.lstDanhSachBan.Name = "lstDanhSachBan";
            this.lstDanhSachBan.Size = new System.Drawing.Size(1474, 313);
            this.lstDanhSachBan.TabIndex = 0;
            this.lstDanhSachBan.ViewType = Telerik.WinControls.UI.ListViewType.DetailsView;
            this.lstDanhSachBan.ColumnCreating += new Telerik.WinControls.UI.ListViewColumnCreatingEventHandler(this.lstDanhSachNhapHang_ColumnCreating);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(1486, 36);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(136, 36);
            this.bunifuCustomLabel2.TabIndex = 0;
            this.bunifuCustomLabel2.Text = "Sort By:";
            // 
            // FrmNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1916, 765);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "FrmNhapHang";
            this.Text = "FrmNhapHang";
            ((System.ComponentModel.ISupportInitialize)(this.lstDanhSachNhapHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TimKiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstDanhSachBan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadListView lstDanhSachNhapHang;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private Telerik.WinControls.UI.RadDropDownList TimKiem;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Telerik.WinControls.UI.RadDropDownList radDropDownList1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private Telerik.WinControls.UI.RadListView lstDanhSachBan;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
    }
}