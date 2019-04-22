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

namespace LoginForm
{
    public partial class FrmMain : DevExpress.XtraEditors.XtraForm
    {
        public FrmMain()
        {
            InitializeComponent();
            timeNow.Start();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            change_color(Color.Red, Color.FromArgb(255, 128, 128), Color.FromArgb(192, 0, 0), Color.White, btnSales.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblTimer_Click(object sender, EventArgs e)
        {

        }

        private void timeNow_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            lblTimer.Text = dt.ToString("hh:mm:ss");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            change_color(Color.AntiqueWhite, Color.FromArgb(255, 224, 192),Color.FromArgb(255, 128, 0) , Color.Black, btnHome.Text);
        }
        //Thay Doi Hien Thi
        private void change_color(Color theme, Color Down,Color Over,Color colorFont,string title)
        {
            pnlVer.BackColor = theme;
            pnlHoz.BackColor = theme;
            
            //Thay Doi Mau Button, Hover Va Active button
            btnAbout.BackColor = theme;
            btnAbout.ForeColor = colorFont;
            btnAbout.FlatAppearance.MouseDownBackColor = Down;
            btnAbout.FlatAppearance.MouseOverBackColor = Over;
            btnHome.BackColor = theme;
            btnHome.ForeColor = colorFont;
            btnHome.FlatAppearance.MouseDownBackColor = Down;
            btnHome.FlatAppearance.MouseOverBackColor = Over;
            btnSup.BackColor = theme;
            btnSup.ForeColor = colorFont;
            btnSup.FlatAppearance.MouseDownBackColor = Down;
            btnSup.FlatAppearance.MouseOverBackColor = Over;
            btnSales.BackColor = theme;
            btnSales.ForeColor = colorFont;
            btnSales.FlatAppearance.MouseDownBackColor = Down;
            btnSales.FlatAppearance.MouseOverBackColor = Over;

            lblTitle.Text = title;
            lblTitle.ForeColor = colorFont;
        }

        private void btnSup_Click(object sender, EventArgs e)
        {
            change_color(Color.Indigo, Color.BlueViolet, Color.Orchid, Color.White, btnSup.Text);
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            change_color(Color.Navy, Color.DodgerBlue, Color.DeepSkyBlue, Color.White, btnAbout.Text);
        }
    }
}