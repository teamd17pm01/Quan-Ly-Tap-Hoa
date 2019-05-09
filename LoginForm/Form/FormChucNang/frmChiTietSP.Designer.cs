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
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn1 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 0", "STT");
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn2 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 1", "Mã SP");
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn3 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 2", "Tên SP");
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn4 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 3", "Mô Tả");
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn5 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 0", "Mã Nhóm");
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn6 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 1", "Tên Nhóm");
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.pic = new DevExpress.XtraEditors.PictureEdit();
            this.lstDanhSach = new Telerik.WinControls.UI.RadListView();
            this.radThemeManager1 = new Telerik.WinControls.RadThemeManager();
            this.lstNhomsp = new Telerik.WinControls.UI.RadListView();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstDanhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstNhomsp)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1338, 279);
            this.groupControl1.TabIndex = 9;
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
            listViewDetailColumn3.Width = 500F;
            listViewDetailColumn4.HeaderText = "Mô Tả";
            listViewDetailColumn4.Width = 230F;
            this.lstDanhSach.Columns.AddRange(new Telerik.WinControls.UI.ListViewDetailColumn[] {
            listViewDetailColumn1,
            listViewDetailColumn2,
            listViewDetailColumn3,
            listViewDetailColumn4});
            this.lstDanhSach.Font = new System.Drawing.Font("Lucida Sans Typewriter", 15F, System.Drawing.FontStyle.Bold);
            this.lstDanhSach.ItemSpacing = -1;
            this.lstDanhSach.Location = new System.Drawing.Point(12, 297);
            this.lstDanhSach.Name = "lstDanhSach";
            this.lstDanhSach.Size = new System.Drawing.Size(981, 456);
            this.lstDanhSach.TabIndex = 12;
            this.lstDanhSach.ThemeName = "ControlDefault";
            this.lstDanhSach.ViewType = Telerik.WinControls.UI.ListViewType.DetailsView;
            // 
            // lstNhomsp
            // 
            listViewDetailColumn5.HeaderText = "Mã Nhóm";
            listViewDetailColumn5.Width = 150F;
            listViewDetailColumn6.HeaderText = "Tên Nhóm";
            this.lstNhomsp.Columns.AddRange(new Telerik.WinControls.UI.ListViewDetailColumn[] {
            listViewDetailColumn5,
            listViewDetailColumn6});
            this.lstNhomsp.Font = new System.Drawing.Font("Lucida Sans Typewriter", 15F, System.Drawing.FontStyle.Bold);
            this.lstNhomsp.ItemSpacing = -1;
            this.lstNhomsp.Location = new System.Drawing.Point(999, 297);
            this.lstNhomsp.Name = "lstNhomsp";
            this.lstNhomsp.Size = new System.Drawing.Size(351, 456);
            this.lstNhomsp.TabIndex = 13;
            this.lstNhomsp.ViewType = Telerik.WinControls.UI.ListViewType.DetailsView;
            this.lstNhomsp.SelectedItemChanged += new System.EventHandler(this.radListView1_SelectedItemChanged);
            // 
            // frmChiTietSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1916, 765);
            this.Controls.Add(this.lstNhomsp);
            this.Controls.Add(this.lstDanhSach);
            this.Controls.Add(this.pic);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmChiTietSP";
            this.Text = "frmChiTietSP";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstDanhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstNhomsp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.PictureEdit pic;
        private Telerik.WinControls.UI.RadListView lstDanhSach;
        private Telerik.WinControls.RadThemeManager radThemeManager1;
        private Telerik.WinControls.UI.RadListView lstNhomsp;
    }
}