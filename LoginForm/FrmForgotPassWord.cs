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
    public partial class FrmForgotPassWord : Form
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
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            string len = txtPassword.Text;
            thongtin = new dto(txtUsername.Text, txtPassword.Text);
            if (txtUsername.Text != "" && txtPassword.Text != "" && txtConfirm.Text != "")
            {
                if (txtPassword.Text == txtConfirm.Text)
                {
                   
                    if (len.Length > 3)
                    {
                        if (func.Find2(thongtin))
                        {
                            MessageBox.Show("Password đã được Reset", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            func.ResetPassWord(txtPassword.Text, txtUsername.Text);
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
            Application.Exit();
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
