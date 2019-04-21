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
        public bool KiemTraAccountTonTai(dto tv)
        {
            return data.KiemTraTonTai(tv);
        }
        public bool KiemTraAccount(dto tv)
        {
            return data.KtTaiKhoan(tv);
        }
        public string Permission(int id)
        {
            return data.id_per(id);
        }
        public bool AddTv(dto tv)
        {
            return data.addNewUser(tv);
        }
        public bool ResetPassWord(dto tv)
        {
            return data.UpdatePassword(tv);
        }
    }
}
