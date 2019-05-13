namespace LoginForm
{
    partial class frmChiTietSP
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
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn1 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 0", "STT");
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn2 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 1", "Mã SP");
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn3 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 2", "Tên SP");
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn4 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 3", "Mô Tả");
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn5 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 4", "Mã Nhóm");
            Telerik.WinControls.UI.RadListDataItem radListDataItem1 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem2 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn6 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 0", "Mã Nhóm");
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn7 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 1", "Tên Nhóm");
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn8 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 2", "Số Lượng");
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.radLabel6 = new Telerik.WinControls.UI.RadLabel();
            this.txtMaNhom = new Telerik.WinControls.UI.RadTextBox();
            this.txtSTT = new System.Windows.Forms.TextBox();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.txtMota = new System.Windows.Forms.TextBox();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.txtNameSP = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.txtMa = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.pic = new DevExpress.XtraEditors.PictureEdit();
            this.lstDanhSach = new Telerik.WinControls.UI.RadListView();
            this.radThemeManager1 = new Telerik.WinControls.RadThemeManager();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.radDropDownList1 = new Telerik.WinControls.UI.RadDropDownList();
            this.radLabel5 = new Telerik.WinControls.UI.RadLabel();
            this.lstDSNhom = new Telerik.WinControls.UI.RadListView();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNhom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNameSP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstDanhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstDSNhom)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.radLabel6);
            this.groupControl1.Controls.Add(this.txtMaNhom);
            this.groupControl1.Controls.Add(this.txtSTT);
            this.groupControl1.Controls.Add(this.radLabel4);
            this.groupControl1.Controls.Add(this.txtMota);
            this.groupControl1.Controls.Add(this.radLabel3);
            this.groupControl1.Controls.Add(this.txtNameSP);
            this.groupControl1.Controls.Add(this.radLabel2);
            this.groupControl1.Controls.Add(this.txtMa);
            this.groupControl1.Controls.Add(this.radLabel1);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1338, 279);
            this.groupControl1.TabIndex = 9;
            this.groupControl1.Text = "Thông tin sản phẩm";
            // 
            // radLabel6
            // 
            this.radLabel6.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.radLabel6.ForeColor = System.Drawing.Color.Black;
            this.radLabel6.Location = new System.Drawing.Point(576, 173);
            this.radLabel6.Name = "radLabel6";
            this.radLabel6.Size = new System.Drawing.Size(108, 31);
            this.radLabel6.TabIndex = 4;
            this.radLabel6.Text = "Mã nhóm:";
            // 
            // txtMaNhom
            // 
            this.txtMaNhom.Location = new System.Drawing.Point(684, 177);
            this.txtMaNhom.Name = "txtMaNhom";
            this.txtMaNhom.Size = new System.Drawing.Size(104, 27);
            this.txtMaNhom.TabIndex = 2;
            // 
            // txtSTT
            // 
            this.txtSTT.Enabled = false;
            this.txtSTT.Location = new System.Drawing.Point(196, 55);
            this.txtSTT.Name = "txtSTT";
            this.txtSTT.Size = new System.Drawing.Size(60, 27);
            this.txtSTT.TabIndex = 5;
            // 
            // radLabel4
            // 
            this.radLabel4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.radLabel4.ForeColor = System.Drawing.Color.Black;
            this.radLabel4.Location = new System.Drawing.Point(140, 55);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(50, 31);
            this.radLabel4.TabIndex = 2;
            this.radLabel4.Text = "STT:";
            // 
            // txtMota
            // 
            this.txtMota.Location = new System.Drawing.Point(684, 49);
            this.txtMota.Multiline = true;
            this.txtMota.Name = "txtMota";
            this.txtMota.Size = new System.Drawing.Size(594, 93);
            this.txtMota.TabIndex = 4;
            // 
            // radLabel3
            // 
            this.radLabel3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.radLabel3.ForeColor = System.Drawing.Color.Black;
            this.radLabel3.Location = new System.Drawing.Point(606, 49);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(72, 31);
            this.radLabel3.TabIndex = 3;
            this.radLabel3.Text = "Mô tả:";
            // 
            // txtNameSP
            // 
            this.txtNameSP.Location = new System.Drawing.Point(196, 178);
            this.txtNameSP.Name = "txtNameSP";
            this.txtNameSP.Size = new System.Drawing.Size(287, 27);
            this.txtNameSP.TabIndex = 1;
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.radLabel2.ForeColor = System.Drawing.Color.Black;
            this.radLabel2.Location = new System.Drawing.Point(38, 173);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(152, 31);
            this.radLabel2.TabIndex = 2;
            this.radLabel2.Text = "Tên Sản Phẩm:";
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(196, 116);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(141, 27);
            this.txtMa.TabIndex = 0;
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.radLabel1.ForeColor = System.Drawing.Color.Black;
            this.radLabel1.Location = new System.Drawing.Point(43, 111);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(147, 31);
            this.radLabel1.TabIndex = 1;
            this.radLabel1.Text = "Mã Sản Phẩm:";
            // 
            // pic
            // 
            this.pic.Cursor = System.Windows.Forms.Cursors.Default;
            this.pic.Location = new System.Drawing.Point(1356, 12);
            this.pic.Name = "pic";
            this.pic.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pic.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pic.Size = new System.Drawing.Size(548, 279);
            this.pic.TabIndex = 11;
            // 
            // lstDanhSach
            // 
            listViewDetailColumn1.HeaderText = "STT";
            listViewDetailColumn1.Width = 130F;
            listViewDetailColumn2.HeaderText = "Mã SP";
            listViewDetailColumn2.Width = 140F;
            listViewDetailColumn3.HeaderText = "Tên SP";
            listViewDetailColumn3.Width = 300F;
            listViewDetailColumn4.HeaderText = "Mô Tả";
            listViewDetailColumn4.Width = 230F;
            listViewDetailColumn5.HeaderText = "Mã Nhóm";
            this.lstDanhSach.Columns.AddRange(new Telerik.WinControls.UI.ListViewDetailColumn[] {
            listViewDetailColumn1,
            listViewDetailColumn2,
            listViewDetailColumn3,
            listViewDetailColumn4,
            listViewDetailColumn5});
            this.lstDanhSach.Font = new System.Drawing.Font("Lucida Sans Typewriter", 15F, System.Drawing.FontStyle.Bold);
            this.lstDanhSach.ItemSpacing = -1;
            this.lstDanhSach.Location = new System.Drawing.Point(12, 297);
            this.lstDanhSach.Name = "lstDanhSach";
            this.lstDanhSach.Padding = new System.Windows.Forms.Padding(10);
            this.lstDanhSach.Size = new System.Drawing.Size(981, 456);
            this.lstDanhSach.TabIndex = 12;
            this.lstDanhSach.ThemeName = "ControlDefault";
            this.lstDanhSach.ViewType = Telerik.WinControls.UI.ListViewType.DetailsView;
            this.lstDanhSach.SelectedItemsChanged += new System.EventHandler(this.lstDanhSach_SelectedItemsChanged);
            this.lstDanhSach.ColumnCreating += new Telerik.WinControls.UI.ListViewColumnCreatingEventHandler(this.lstDanhSach_ColumnCreating);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.radDropDownList1);
            this.groupControl2.Controls.Add(this.radLabel5);
            this.groupControl2.Location = new System.Drawing.Point(1620, 297);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(284, 456);
            this.groupControl2.TabIndex = 14;
            this.groupControl2.Text = "groupControl2";
            // 
            // radDropDownList1
            // 
            radListDataItem1.Text = "Tên Nhóm";
            radListDataItem2.Text = "Số Lượng";
            this.radDropDownList1.Items.Add(radListDataItem1);
            this.radDropDownList1.Items.Add(radListDataItem2);
            this.radDropDownList1.Location = new System.Drawing.Point(6, 95);
            this.radDropDownList1.Name = "radDropDownList1";
            this.radDropDownList1.Size = new System.Drawing.Size(187, 27);
            this.radDropDownList1.TabIndex = 2;
            this.radDropDownList1.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.radDropDownList1_SelectedIndexChanged_3);
            // 
            // radLabel5
            // 
            this.radLabel5.Font = new System.Drawing.Font("Yu Gothic Medium", 15F, System.Drawing.FontStyle.Bold);
            this.radLabel5.ForeColor = System.Drawing.Color.White;
            this.radLabel5.Location = new System.Drawing.Point(6, 59);
            this.radLabel5.Name = "radLabel5";
            this.radLabel5.Size = new System.Drawing.Size(84, 30);
            this.radLabel5.TabIndex = 1;
            this.radLabel5.Text = "Sort By:";
            // 
            // lstDSNhom
            // 
            listViewDetailColumn6.HeaderText = "Mã Nhóm";
            listViewDetailColumn7.HeaderText = "Tên Nhóm";
            listViewDetailColumn8.HeaderText = "Số Lượng";
            this.lstDSNhom.Columns.AddRange(new Telerik.WinControls.UI.ListViewDetailColumn[] {
            listViewDetailColumn6,
            listViewDetailColumn7,
            listViewDetailColumn8});
            this.lstDSNhom.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 15F, System.Drawing.FontStyle.Bold);
            this.lstDSNhom.ItemSpacing = -1;
            this.lstDSNhom.Location = new System.Drawing.Point(999, 297);
            this.lstDSNhom.Name = "lstDSNhom";
            this.lstDSNhom.Padding = new System.Windows.Forms.Padding(10);
            this.lstDSNhom.Size = new System.Drawing.Size(615, 456);
            this.lstDSNhom.TabIndex = 13;
            this.lstDSNhom.ViewType = Telerik.WinControls.UI.ListViewType.DetailsView;
            this.lstDSNhom.ColumnCreating += new Telerik.WinControls.UI.ListViewColumnCreatingEventHandler(this.lstDSNhom_ColumnCreating);
            // 
            // frmChiTietSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1916, 765);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.lstDSNhom);
            this.Controls.Add(this.lstDanhSach);
            this.Controls.Add(this.pic);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmChiTietSP";
            this.Text = "frmChiTietSP";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNhom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNameSP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstDanhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstDSNhom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.PictureEdit pic;
        private Telerik.WinControls.UI.RadListView lstDanhSach;
        private Telerik.WinControls.RadThemeManager radThemeManager1;
        private System.Windows.Forms.TextBox txtMota;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadTextBox txtNameSP;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadTextBox txtMa;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private System.Windows.Forms.TextBox txtSTT;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private Telerik.WinControls.UI.RadDropDownList radDropDownList1;
        private Telerik.WinControls.UI.RadLabel radLabel5;
        private Telerik.WinControls.UI.RadListView lstDSNhom;
        private Telerik.WinControls.UI.RadLabel radLabel6;
        private Telerik.WinControls.UI.RadTextBox txtMaNhom;
    }
}