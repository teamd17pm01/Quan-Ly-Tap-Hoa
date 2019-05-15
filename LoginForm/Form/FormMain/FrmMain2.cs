using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace LoginForm
{
    public partial class FrmMain2 : DevExpress.XtraBars.Ribbon.RibbonForm
    {

        public delegate void DeleteBtn(bool ques);
        public delegate void DelegateSave();
        public delegate void DelegateCopy(FrmMain2 frm);
        public delegate void ReloadDs();

        //UCDanhSach ds;
        FormDs ds;
        frmChiTietSP chitiet;
        FrmNhapHang nhaphang;
        frmNhapSP toolNhapSP;
        frmNhaCungCap nhacc;
        FrmMain2 main;
        InforUser frmInfor;
        FrmMuaHang frmmuahang;

        DeleteBtn methodDel; //delegates
        DelegateCopy methodCopy; //Delegates Copy object Main
        DelegateSave methodSave;
        ReloadDs relod;

        public FrmMain2()
        {
            InitializeComponent();
            // Handling the QueryControl event that will populate all automatically generated Documents
            this.tabbedView1.QueryControl += tabbedView1_QueryControl;
        }

        //Methods were Created
        
        //Methods were Created

        //Methods were created by .net frameworks
        private void ribbon_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_ItemClick(object sender, ItemClickEventArgs e)
        {
            toolNhapSP = new frmNhapSP();
            toolNhapSP.ShowDialog();
        }

        private void FrmMain2_Load(object sender, EventArgs e)
        {

        }

        // Assigning a required content for each auto generated Document
        void tabbedView1_QueryControl(object sender, DevExpress.XtraBars.Docking2010.Views.QueryControlEventArgs e)
        {

        }

        private void btnDsKho_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!CheckExistForm("FormDs"))
            {
                ds = new FormDs();
                ds.MdiParent = this;
                ds.Show();
            }
            methodDel = new DeleteBtn(ds.delete_item);
            methodDel(false);
        }

        private void FrmMain2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private bool CheckExistForm(string nameform)
        {
            //bool check = false;
            foreach (var frm in this.MdiChildren)
            {
                if (frm.Name == nameform)
                {
                    frm.Activate();
                    return true;
                }
            }

            return false;
        }

        private void barStaticItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            Application.Exit();
        }

        private void btnChiTiet_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!CheckExistForm("frmChiTietSP"))
            {
                chitiet = new frmChiTietSP();
                chitiet.MdiParent = this;
                chitiet.Show();
            }
        }

        private void btnDanhSachNhap_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!CheckExistForm("FrmNhapHang"))
            {
                nhaphang = new FrmNhapHang();
                nhaphang.MdiParent = this;
                nhaphang.Show();
            }
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void btnKtTon_ItemClick(object sender, ItemClickEventArgs e)
        {
            
            MessageBox.Show("Chức Năng Chưa Được Cập Nhật", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnDel_ItemClick(object sender, ItemClickEventArgs e)
        {
            MessageBox.Show("Mời Chọn Sản Phẩm Cần Xóa Bên Dưới Danh Sách", "Yêu Cầu", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            if (!CheckExistForm("FormDs"))
            {
                ds = new FormDs();
                ds.MdiParent = this;
                ds.Show();
            }
            //delegate Turn on button Delete
            methodDel = new DeleteBtn(ds.delete_item);
            methodDel(true);

            //Copy FrmMain
            methodCopy = new DelegateCopy(ds.FormA);
            methodCopy(this);
        }
        public void turn_On_btnSave(bool ques)
        {
            btnSave.Enabled = ques;
        }
        
        //Method CỦA SYSTEM
        private void btnDSNhaCungCap_ItemClick(object sender, ItemClickEventArgs e)
        {
            nhacc = new frmNhaCungCap();
            nhacc.MdiParent = this;
            nhacc.Show();
        }
        //Delegate
        private void btnSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            methodSave = new DelegateSave(ds.save_method);
            methodSave();
        }

        private void btnHuy_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                relod = new ReloadDs(ds.reload_ListView);
                relod();
                MessageBox.Show("Đã Hủy Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch
            {
                MessageBox.Show("ERROR!!!","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Stop);
            }
        }

        private void btnChiTietNCC_ItemClick(object sender, ItemClickEventArgs e)
        {
            MessageBox.Show("Chức Năng Chưa Được Cập Nhật", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void btnInfor_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!CheckExistForm("FrmNhapHang"))
            {
                frmInfor = new InforUser();
                frmInfor.MdiParent = this;
                frmInfor.Show();
            }
        }

        private void btnMuaBan_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!CheckExistForm("FrmNhapHang")) {
                frmmuahang = new FrmMuaHang();
                frmmuahang.ShowDialog();
            }
        }

        private void btnUpt_ItemClick(object sender, ItemClickEventArgs e)
        {
            MessageBox.Show("Mời Chọn Sản Phẩm Cần Sửa Bên Dưới Danh Sách", "Yêu Cầu", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            if (!CheckExistForm("FormDs"))
            {
                ds = new FormDs();
                ds.MdiParent = this;
                ds.Show();
            }
            //delegate Turn on button Delete
            methodDel = new DeleteBtn(ds.delete_item);
            methodDel(true);

            //Copy FrmMain
            methodCopy = new DelegateCopy(ds.FormA);
            methodCopy(this);
        }
    }
}