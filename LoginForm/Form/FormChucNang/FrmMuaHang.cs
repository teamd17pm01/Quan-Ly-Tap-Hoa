using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using Telerik.WinControls;
using BUS_QAL;
using ClassLibrary1;

namespace LoginForm
{
    public partial class FrmMuaHang : Telerik.WinControls.UI.RadForm
    {
        bus func = new bus();
        public FrmMuaHang()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            try
            {
                if (!func.Update_SoLuongMuaHang(txtMaSP.Text, Convert.ToInt32(txtSoLuong.Text)))
                {
                    MessageBox.Show("Đã Thanh Toán", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Thanh Toán Hỏng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("ERROR!!!","WARNING",MessageBoxButtons.OK,MessageBoxIcon.Stop);
            }
        }

        private void txtTenSanPham_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                IQueryable<tbl_kho> linq = func.Load_ThongTin("DonGia", txtTenSanPham.Text);
                foreach (var item in linq)
                {
                    txtDonGia.Text = item.DONGIA.ToString();
                    txtMaSP.Text = item.MASP.ToString();
                }
            }
            catch (Exception)
            {


            }
        }

        private void txtTongTien_TextChanged(object sender, EventArgs e)
        {
            
        }

      

        private void txtSoLuong_KeyUp(object sender, KeyPressEventArgs e)
        {
           
        }

        private void radButton2_Click(object sender, EventArgs e)
        {
            txtTongTien.Text = Convert.ToString(Convert.ToDecimal(txtSoLuong.Text) * Convert.ToDecimal(txtDonGia.Text));
            if (decimal.Parse(txtTongTien.Text) > decimal.Parse(txtTienNhan.Text))
            {
                MessageBox.Show("Không Đủ Tiền","Thông Báo");
            }
            else
            {
                txtTienThua.Text = Convert.ToString(Convert.ToDecimal(txtTienNhan.Text) - Convert.ToDecimal(txtTongTien.Text));
            }
        }
    }
}
