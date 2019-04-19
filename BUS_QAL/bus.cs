using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_Login;
using DAL_Login;
using System.Data;

namespace BUS_QAL
{
    public class bus
    {
        private qal data = new qal();
        public string idthanhvien(dto tv)
        {
            return data.getID(tv);
        }
        public bool Find(dto tv)
        {
            return data.KtTonTai(tv);
        }
        public bool Find2(dto tv)
        {
            return data.KiemTraTaiKhoan(tv);
        }
        public string Permission(int id)
        {
            return data.id_per(id);
        }
        public bool AddTv(dto tv)
        {
            return data.Add2(tv);
        }
        public bool ResetPassWord(string a,string b)
        {
            return data.UpdatePassword(a, b);
        }
    }
}
