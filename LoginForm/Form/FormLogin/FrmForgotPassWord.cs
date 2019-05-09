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
    public partial class FrmForgotPassWord : DevExpress.XtraEditors.XtraForm
    {
        public FrmForgotPassWord()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        bus func = new bus();
        dto thongtin;
        dto thongtin2;
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            
            string len = txtPassword.Text; //Lay chieu dai
            thongtin = new dto(txtUsername.Text, txtPassword.Text);
            thongtin2 = new dto(txtUsername.Text);

            if (txtUsername.Text != "" && txtPassword.Text != "" && txtConfirm.Text != "")
            {
                if (txtPassword.Text == txtConfirm.Text)
                {
                    if (len.Length > 3)
                    {
                        if (func.KiemTraAccountTonTai(thongtin2))
                        {
                            try
                            {
                                func.ResetPassWord(thongtin);
                                MessageBox.Show("thanh Cong");
                            }
                            catch
                            {
                                MessageBox.Show("That Bai");
                            }
                              //  MessageBox.Show("Password đã được Reset", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                           
                        }
                        else
                        {
                            MessageBox.Show("Tài khoản không tồn tại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu phải có độ dài từ 3 kí tự trở lên", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Mật khẩu không trùng nhau", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Xin nhập đầy đủ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void FrmForgotPassWord_Load(object sender, EventArgs e)
        {

        }

        private void pnExit_MouseHover(object sender, EventArgs e)
        {
           
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnOut_MouseHover(object sender, EventArgs e)
        {
            btnOut.BackColor=Color.Red;
        }

        private void btnOut_MouseLeave(object sender, EventArgs e)
        {
            btnOut.BackColor = Color.SkyBlue;
        }
    }
}
