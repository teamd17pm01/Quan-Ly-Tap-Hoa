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
using ClassLibrary1;

namespace LoginForm
{
    public partial class frmNhaCungCap : Form
    {
        bus func = new bus();
        public frmNhaCungCap()
        {
            InitializeComponent();
            load_Ds();
        }
        //METHODS WERE CREATED
        private void load_Ds()
        {
            IQueryable<tbl_nhacungcap> linq = func.Load_DSNhaCC();
            foreach (var item in linq)
            {
                ListViewItem it = new ListViewItem(item.MANCC);
                it.SubItems.Add(item.TENNCC);
                it.SubItems.Add(item.DIACHI);
                it.SubItems.Add(Convert.ToString(item.SLCHINHANH));
                it.SubItems.Add(Convert.ToString(item.SLLOAIMATHANG));
                lstDSNCC.Items.Add(it);
            }
        }

        //METHODS WERE CREATED
    }
}
