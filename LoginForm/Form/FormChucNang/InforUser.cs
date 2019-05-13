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
    public partial class InforUser : DevExpress.XtraEditors.XtraForm
    {
        public InforUser()
        {
            InitializeComponent();
            Load_Form();
        }

        private void Load_Form()
        {
            textInfor.LoadDocument(@"C:\Users\phamh\source\repos\LoginForm\fileinfor.docx");
        }
        private void richEditControl3_Click(object sender, EventArgs e)
        {

        }
    }
}