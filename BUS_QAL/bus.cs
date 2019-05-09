using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_Login;
using DAL_Login;
using System.Data;
using ClassLibrary1;

namespace BUS_QAL
{
    public class bus
    {
        private qal data = new qal();
       
        public bool KiemTraAccountTonTai(dto tv)
        {
            return data.KiemTraTonTai(tv);
        }
        public bool KiemTraAccount(dto tv)
        {
            return data.KtTaiKhoan(tv);
        }
        
        public bool AddTv(dto tv)
        {
            return data.addNewUser(tv);
        }
        public bool ResetPassWord(dto tv)
        {
            return data.UpdatePassword(tv);
        }

        //Form Main
        /// <summary>
        /// Danh Sach Kho
        /// </summary>
        /// <returns></returns>
        public IQueryable<tbl_kho> GetKho()
        {
            var dat = data.Load_Kho();
            return dat;
        }
        public IQueryable<tbl_kho> GetDSTheoNhomHang(string nhom)
        {
            return data.TimKiemNhomHang(nhom);
        }
    }
}
