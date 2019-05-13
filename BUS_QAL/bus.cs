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

        /// <summary>
        /// DANH SACH KHO CHI TIET
        /// </summary>
        /// <returns></returns>
        public IQueryable GetDSChiTiet(string type)
        {
            return data.Load_DSChiTiet(type);
        }
        
        //DANH SACH NHAP HANG
        public IQueryable GetDSNhapHang(string type)
        {
            return data.Load_DsNhapHang(type);
        }

        ///TOOL
        //Ban Hang
        public IQueryable<tbl_kho> Load_ThongTin(string text,string ques)
        {
            return data.Load_ForFormMuaHang(text, ques);
        }
        //Cap Nhap Lai So Luong
        public bool Update_SoLuongMuaHang(string ma,int soluong)
        {
            return data.UpdateSoLuong(ma, soluong);
        }

        //Nhap Kho
        public bool NhapSanPham(InforSanPham infor)
        {
            return data.Add_SanPham(infor);
        }
        //Xoa San Pham
        public bool XoaSanPham(string masp)
        {
            return data.Delete_SanPham(masp);
        }
        //Update_Sp
        public bool UpdateSanPham(InforSanPham infor)
        {
            return data.Update_SanPham(infor);
        }

        //Load_DS
        public IQueryable<tbl_nhacungcap> Load_DSNhaCC()
        {
            return data.Load_NhaCungCap();
        }
    }
}
