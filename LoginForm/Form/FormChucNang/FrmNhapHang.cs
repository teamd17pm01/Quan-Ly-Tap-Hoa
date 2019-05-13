using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BUS_QAL;
using DTO_Login;

namespace LoginForm
{
    public partial class FrmNhapHang : DevExpress.XtraEditors.XtraForm
    {
        bus func = new bus();
        public FrmNhapHang()
        {
            InitializeComponent();
            Load_DSNhapHang();
            Load_DSBanHang();
        }

        //Method Create
        private void Load_DSNhapHang()
        {
            var item = func.GetDSNhapHang("Load_DSNhapHang");
            lstDanhSachNhapHang.AllowEdit = true;
            lstDanhSachNhapHang.AllowRemove = false;
            lstDanhSachNhapHang.DataSource = item;
        }

        private void Load_DSBanHang()
        {
            var item = func.GetDSNhapHang("Load_DSBanHang");
            lstDanhSachBan.AllowEdit = true;
            lstDanhSachBan.AllowRemove = false;
            lstDanhSachBan.DataSource = item;
        }
        //Method Create
        private void lstDanhSachNhapHang_ColumnCreating(object sender, Telerik.WinControls.UI.ListViewColumnCreatingEventArgs e)
        {
            if (e.Column.FieldName == "MAHD")
            {
                e.Column.HeaderText = "Mã Hóa Đơn";
            }
            if (e.Column.FieldName == "MASP")
            {
                e.Column.HeaderText = "Mã Sản Phẩm";
            }
            if (e.Column.FieldName == "TENSP")
            {
                e.Column.HeaderText = "Tên Sản Phẩm";
            }
            if (e.Column.FieldName == "NGAYNHAP")
            {
                e.Column.HeaderText = "Ngày Nhập";
            }
            if (e.Column.FieldName == "SOLUONG")
            {
                e.Column.HeaderText = "Số Lượng";
            }
            if (e.Column.FieldName == "TONGTIEN")
            {
                e.Column.HeaderText = "Tổng Tiền";
            }
        }

        private void TimKiem_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            MessageBox.Show("Chưa Cập Nhật Chức Năng Này", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}