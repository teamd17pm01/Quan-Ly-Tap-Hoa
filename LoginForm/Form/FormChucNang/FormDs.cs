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
        public string key;
        bus func = new bus();
        FrmMain2 frmMain;
        public FormDs()
        {
            InitializeComponent();
            var linq = func.GetKho();
            Load_Kho(linq);
        }

        //METHOD CREATE
        private void Load_Kho(IQueryable<tbl_kho> linq)
        {

            foreach (var k in linq)
            {
                
                ListViewItem item = new ListViewItem(k.MASP);
                item.SubItems.Add(k.TENSP);
                item.SubItems.Add(k.DONGIA.ToString());
                item.SubItems.Add(k.DONVI);
                item.SubItems.Add(Convert.ToString(k.SOLUONG));
                item.SubItems.Add(k.MANCC);
                item.SubItems.Add(k.MANHOM);
                item.SubItems.Add(k.GHICHU);
                lstDanhSachSanPham.Items.Add(item);
            }

        }

        public void delete_item(bool ques)                      //Delegates Cho Việc Xóa
        {
            btnDel.Enabled = ques;
        }
        public void FormA(FrmMain2 frm)
        {
            frmMain = frm;
        }
        public void save_method()
        {
            try
            {
                
                if (func.XoaSanPham(key))
                {
                    reload_ListView();
                    MessageBox.Show("Lưu Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Lưu Thất Bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            catch
            {
                MessageBox.Show("ERROR!!!");
            }
        }
        public void reload_ListView()
        {
            var linq = func.GetKho();
            lstDanhSachSanPham.Items.Clear();
            Load_Kho(linq);
        }
        //METHOD CỦA SYSTEM
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNhomSP.text != "")
                {
                    var linq = func.GetDSTheoNhomHang(txtNhomSP.text);
                    lstDanhSachSanPham.Items.Clear();
                    Load_Kho(linq);
                }
                else
                {
                    MessageBox.Show("Vui Lòng Nhập Nhóm Cần Tìm", "Thông Báo");
                    lstDanhSachSanPham.Items.Clear();
                    var linq = func.GetKho();
                    Load_Kho(linq);
                }
            }
            catch
            {

                MessageBox.Show("Tìm Kiếm Bị Lỗi", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void lstDanhSachSanPham_MouseHover(object sender, EventArgs e)
        {


        }
      
        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                ListViewItem item = lstDanhSachSanPham.SelectedItems[0];
                key = item.SubItems[0].Text;
                lstDanhSachSanPham.Items.Remove(item);
                frmMain.turn_On_btnSave(true);
                MessageBox.Show("Đã Xóa", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }
            catch (Exception)
            {
                MessageBox.Show("Xóa Thất Bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }
        }
    }
}