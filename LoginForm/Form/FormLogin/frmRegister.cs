using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO_Login;
using BUS_QAL;

namespace LoginForm
{
    public partial class frmRegister : DevExpress.XtraEditors.XtraForm
    {
        public frmRegister()
        {
            InitializeComponent();
        }
        bus func;
        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }
        frmRegister frm;
        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn Muốn Hủy!!!", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                frm = new frmRegister();
                this.Hide();
            }
        }

        //Dang ki
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (ckKiemtra.Checked)
            {
                if (txtPassword.Text != "" && txtPasswordComfirm.Text != "" && txtUserName.Text != "")
                {
                    if (txtPassword.Text == txtPasswordComfirm.Text)
                    {
                        dto thongtin = new dto(txtName.Text, txtUserName.Text, txtPassword.Text);
                        func = new bus();
                        if (func.AddTv(thongtin))
                        {
                            
                            MessageBox.Show("Đăng kí thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                        else
                        {
                            MessageBox.Show("Đăng kí thất bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu không giống nhau !", "Thông Báo");
                    }
                }
                else
                {
                    MessageBox.Show("Mời bạn nhập đầy đủ !!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Mời Bạn Nhập Mọi Thứ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }

        private void Load_Data()
        {

        }
        private void txtPasswordComfirm_OnValueChanged(object sender, EventArgs e)
        {
            
        }

        private void frmRegister_Load(object sender, EventArgs e)
        {

        }

        private void ckKiemtra_CheckedChanged(object sender, EventArgs e)
        {
            if (ckKiemtra.Checked)
            {
                ckKiemtra.ForeColor = Color.Blue;
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("????", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }

        private void txtPasswordComfirm_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox2_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void txtName_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox1_OnValueChanged_1(object sender, EventArgs e)
        {

        }
    }
}
