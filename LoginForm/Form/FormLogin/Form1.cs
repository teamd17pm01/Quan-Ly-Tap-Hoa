using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BUS_QAL;
using DTO_Login;
using System.Threading;
using System.Data.SqlClient;
using DevExpress.XtraSplashScreen;
using Bunifu.Framework.UI;

namespace LoginForm
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {

        public static string id;
        public bus b = new bus();
        Thread t;
        FrmMain2 frm;
        public Form1()
        {

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }



        public void btnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }
        private void load_Splash()
        {
            t = new Thread(new ThreadStart(Splash));
            t.Start();
            string str = string.Empty;
            for (int i = 0; i < 20000; i++)
            {
                str += i.ToString();
            }
            t.Abort();
        }

        private void Splash()
        {
            SplashScreen.SplashForm frm = new SplashScreen.SplashForm();
            frm.AppName = "Login";
            frm.Text = "Form";
            Application.Run(frm);
        }

     

        private void txtName_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void txtPass_OnValueChanged(object sender, EventArgs e)
        {
           
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmForgotPassWord frmForgot = new FrmForgotPassWord();
            frmForgot.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn Muốn Thoát!!!", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRegister frm = new frmRegister();
            frm.Show();
        }
        private void Login()
        {
            dto thongtin = new dto(txtName.Text, txtPass.Text);    //thong tin de tim kiem tra ton tai
            dto thongtin2 = new dto(txtName.Text);                  //Thong tin de kiem tra 
            if (txtName.Text != "" && txtPass.Text != "")
            {
                if (b.KiemTraAccountTonTai(thongtin2))
                {
                    if (b.KiemTraAccount(thongtin))
                    {
                        load_Splash();
                        frm = new FrmMain2();
                        frm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Sai Mật Khẩu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Tai Khoan Khong Ton Tai!!!", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            else
            {
                MessageBox.Show("Moi Nhap Day Du !!!", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login();
            }
        }
    }
}
