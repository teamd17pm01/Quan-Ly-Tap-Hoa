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
        //UCDanhSach ds;
        FormDs ds;
        frmChiTietSP chitiet;
        public FrmMain2()
        {
            InitializeComponent();
            // Handling the QueryControl event that will populate all automatically generated Documents
            this.tabbedView1.QueryControl += tabbedView1_QueryControl;
        }

        private void ribbon_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAdd_ItemClick(object sender, ItemClickEventArgs e)
        {

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
        }

        private void FrmMain2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private bool CheckExistForm(string nameform)
        {
            //bool check = false;
            foreach(var frm in this.MdiChildren)
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
    }
}