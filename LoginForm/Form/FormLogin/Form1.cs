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
        public Form1()
        {
            t = new Thread(new ThreadStart(Splash));
            t.Start();

            string str = string.Empty;
            for (int i = 0; i < 30000; i++)
            {
                str += i.ToString();
            }
            t.Abort();
            
            InitializeComponent();
        }

        private void labelControl2_Click(object sender, EventArgs e)
        {
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn Muốn Thoát!!!", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }



        private void btnLogin_Click(object sender, EventArgs e)
        {
            dto thongtin = new dto(txtName.Text, txtPass.Text);    //thong tin de tim kiem tra ton tai
            dto thongtin2 = new dto(txtName.Text);                  //Thong tin de kiem tra 
            id = b.idthanhvien(thongtin);
            if (txtName.Text != "" && txtPass.Text != "")
            {
                if (b.KiemTraAccountTonTai(thongtin2))
                {
                    if (b.KiemTraAccount(thongtin))
                    {
                        t = new Thread(new ThreadStart(Splash));
                        t.Start();
                        string str = string.Empty;
                        for (int i = 0; i < 30000; i++)
                        {
                            str += i.ToString();
                        }
                        t.Abort();
                        MessageBox.Show("ID Của User Là : "+id, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        MessageBox.Show("Sai Mật Khẩu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Tai Khoan Khong Ton Tai!!!","Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            else
            {
                MessageBox.Show("Moi Nhap Day Du !!!","Thong Bao",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void Splash()
        {
            SplashScreen.SplashForm frm = new SplashScreen.SplashForm();
            frm.AppName = "Login";
            frm.Text = "Form";
            Application.Run(frm);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng của ID này là : " + b.Permission(int.Parse(id)));
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtName_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void metro_OnValueChanged(object sender, EventArgs e)
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
    }
}
