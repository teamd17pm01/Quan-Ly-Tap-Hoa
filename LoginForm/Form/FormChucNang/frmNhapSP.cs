using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_QAL;
using DTO_Login;

namespace LoginForm
{
    public partial class frmNhapSP : Form
    {
        bus func = new bus();
        InforSanPham infor;
        public frmNhapSP()
        {
            InitializeComponent();
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                infor = new InforSanPham()
                {
                    Masp = txtMaSP.Text,
                    Tensp = txtTenSP.Text,
                    Dongia = Convert.ToDecimal(txtDonGia.Text),
                    Donvi = txtDonViTinh.Text,
                    Soluong = Convert.ToInt32(txtSoLuong.Text),
                    Nhacc = txtNhaCungCap.Text,
                    Nhomsp = txtNhomSP.Text,
                    Ghichu = txtGhiChu.Text
                };
                if (func.NhapSanPham(infor))
                {
                    MessageBox.Show("Thêm Sản Phẩm Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Thêm Sản Phẩm Thất Bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show("Mời Bạn Nhập Đầy Đủ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}
