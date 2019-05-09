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
using ClassLibrary1;

namespace LoginForm
{
    public partial class FormDs : DevExpress.XtraEditors.XtraForm
    {
        bus func = new bus();
        public FormDs()
        {
            InitializeComponent();
            var linq = func.GetKho();
            Load_Kho(linq);
        }

        private void Load_Kho(IQueryable<tbl_kho> linq)
        {
          
           foreach(var k in linq)
            {
                ListViewItem item = new ListViewItem(k.MASP);
                item.SubItems.Add(k.TENSP);
                item.SubItems.Add(k.DONGIA.ToString());
                item.SubItems.Add(k.DONVI);
                item.SubItems.Add(Convert.ToString(k.SOLUONG));
                item.SubItems.Add(k.NGAYNHAP.ToString());
                item.SubItems.Add(k.NHACUNGCAP);
                item.SubItems.Add(k.MANHOM);
                item.SubItems.Add(k.GHICHU);
                lstDanhSachSanPham.Items.Add(item);
            }

        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormDs_Load(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtNhomSP_OnTextChange(object sender, EventArgs e)
        {
            
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                var linq = func.GetDSTheoNhomHang(txtNhomSP.text);
                lstDanhSachSanPham.Items.Clear();
                Load_Kho(linq);
            }
            catch
            {

                MessageBox.Show("Tìm Kiếm Bị Lỗi", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}