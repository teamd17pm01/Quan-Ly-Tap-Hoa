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
using System.IO;
using BUS_QAL;
using Telerik.WinControls.UI;


namespace LoginForm
{
    public partial class frmChiTietSP :DevExpress.XtraEditors.XtraForm
    {
        bus func = new bus();
        public frmChiTietSP()
        {
            InitializeComponent();  
            Load_DsNhom();
            load_DSchitiet();
        }

        private void radListView1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Method Create
        /// </summary>

        //điều chỉnh lại column của rad listview
        private void Load_DsNhom()
        {
            var item = func.GetDSChiTiet("Load_DsNhom");
            lstDSNhom.AllowEdit = false;
            lstDSNhom.AllowRemove = false;
            lstDSNhom.DataSource = item;

        }    
        //LOAD DANH SACH CHI TIET
        private void load_DSchitiet()
        {
            var item = func.GetDSChiTiet("load_DSchitiet");
            lstDanhSach.AllowEdit = false;
            lstDanhSach.AllowRemove = false;
            lstDanhSach.DataSource = item;

        }


           //METHOD CỦA SYSTEM

            //ĐIỀU CHỈNH TÊN CỘT CHO DANH SÁCH NHÓM
        private void lstDSNhom_ColumnCreating(object sender, ListViewColumnCreatingEventArgs e)
        {
            if (e.Column.FieldName == "MANHOM")
            {
                e.Column.HeaderText = "Mã Nhóm";
            }
            if (e.Column.FieldName == "TENNHOM")
            {
                e.Column.HeaderText = "Tên Nhóm";
            }
            if (e.Column.FieldName == "SOLUONG")
            {
                e.Column.HeaderText = "Số Lượng";
            }
        }
            //Điều Chỉnh Tên Cột Cho Danh Sách Sản Phẩm
        private void lstDanhSach_ColumnCreating(object sender, ListViewColumnCreatingEventArgs e)
        {
            if (e.Column.FieldName == "MASP")
            {
                e.Column.HeaderText = "Mã Sản Phẩm";
            }
            if (e.Column.FieldName == "TENSP")
            {
                e.Column.HeaderText = "Tên Sản Phẩm";
            }
            if (e.Column.FieldName == "MOTA")
            {
                e.Column.HeaderText = "Mô Tả";
            }
            if (e.Column.FieldName == "MANHOM")
            {
                e.Column.HeaderText = "Mã Nhóm";
            }
        }

        private void ItemSort_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            
        }

        private void radDropDownList1_SelectedIndexChanged_3(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            MessageBox.Show("Tạm thời chưa thực hiện được", "Thông Báo", MessageBoxButtons.OK);
        }

        private void lstDanhSach_SelectedItemsChanged(object sender, EventArgs e)
        {
            ListViewSelectedItemCollection item = lstDanhSach.SelectedItems;
            foreach (ListViewDataItem it in item)
            {
               
                    txtSTT.Text = it[0].ToString();
                    txtMa.Text = it[1].ToString().Trim();
                    txtNameSP.Text = it[2].ToString();
                    txtMota.Text = it[3].ToString();
                    txtMaNhom.Text = it[4].ToString().Trim();
                    //MessageBox.Show("" + txtMaNhom.Text + " " + txtMa.Text);
                    try
                    {
     
                        Bitmap anh = new Bitmap(Application.StartupPath + "\\Picture\\" + txtMaNhom.Text + "\\" + txtMa.Text + ".jpg");
                        pic.Image = (Image)anh;
                    }
                    catch
                    {
                        MessageBox.Show("Chưa Có Hình Ảnh !!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                
            }

        
        //Điều chỉnh lại column của rad listview
    }
}