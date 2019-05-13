using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DTO_Login;
using ClassLibrary1;
namespace DAL_Login
{
    public class qal : Connection
    {

        public bool KtTaiKhoan(dto tv)
        {
            try
            {
                LinQBaseDataContext context = new LinQBaseDataContext(connection);
                var linq = from person in context.tbl_users
                           where person.user_name == tv.User && person.pass == tv.Psw
                           select person;
                var list = linq.ToList();
                if (list.Count > 0)
                {
                    return true;
                }
            }
            catch
            {

            }
            return false;
        }

        public bool KiemTraTonTai(dto tv)
        {
            try
            {
                LinQBaseDataContext context = new LinQBaseDataContext(connection);
                var linq = from person in context.tbl_users
                           where person.user_name == tv.User
                           select person;
                var list = linq.ToList();
                if (list.Count > 0)
                {
                    return true;
                }
            }
            catch (Exception)
            {

            }
            return false;
        }
        public bool Add(dto tv)
        {

            try
            {
                connection.Open();
                string sql = string.Format("INSERT INTO tbl_user(name_user,user_name,pass) VALUES('{0}', '{1}', '{2}')", tv.Name, tv.User, tv.Psw);
                SqlCommand cmd = new SqlCommand(sql, connection);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                connection.Close();
            }
            return false;
        }
        public bool UpdatePassword(dto tv)
        {
            LinQBaseDataContext context = new LinQBaseDataContext();
            var linq = from person in context.tbl_users
                       where person.user_name == tv.User
                       select person;
            foreach (var user in linq)
            {
                user.pass = tv.Psw;
            }
            try
            {
                context.SubmitChanges();
                return true;
            }
            catch (Exception)
            {

            }

            return false;

        }
        public bool addNewUser(dto tv)
        {
            LinQBaseDataContext context = new LinQBaseDataContext(connection);
            tbl_user course = new tbl_user
            {
                name_user = tv.Name,
                user_name = tv.User,
                pass = tv.Psw,
            };
            context.tbl_users.InsertOnSubmit(course);

            try
            {
                context.SubmitChanges();
                return true;
            }
            catch
            {

            }
            return false;
        }



        //FORM MAIN
        ///Danh Sach Kho
        public IQueryable<tbl_kho> Load_Kho()
        {
            LinQBaseDataContext data = new LinQBaseDataContext(connection);
            var linq = from product in data.tbl_khos
                       select product;
            //var list = linq.ToList();
            return linq;
        }
        public IQueryable<tbl_kho> TimKiemNhomHang(string nhomHang)
        {
            LinQBaseDataContext data = new LinQBaseDataContext(connection);
            var linq = from product in data.tbl_khos
                       where product.MANHOM == nhomHang
                       select product;
            return linq;
        }


        //Danh Sach Chi Tiet
        public IQueryable Load_DSChiTiet(string type)
        {
            LinQBaseDataContext data = new LinQBaseDataContext(connection);
            switch (type)
            {
                case "Load_DsNhom":
                    var linq = from pro in data.tbl_nhomSPs
                               select new { pro.MANHOM, pro.TENNHOM, pro.SOLUONG };
                    return linq;
                case "load_DSchitiet":
                    var linq2 = from product in data.tbl_chitietsps
                                select new { product.STT, product.MASP, product.TENSP, product.MOTA, product.MANHOM };
                    return linq2;
            }
            return null;
        }


        //Danh SAch Nhap Hang
        public IQueryable Load_DsNhapHang(string type)
        {
            LinQBaseDataContext data = new LinQBaseDataContext(connection);
            switch (type)
            {
                case "Load_DSNhapHang":
                    var linq = from product in data.tbl_chitiethds
                               select new { product.MAHD, product.MASP, product.TENSP, product.NGAYNHAP, product.SOLUONG, product.TONGTIEN };
                    return linq;
                case "Load_DSBanHang":
                    var linq2 = from product in data.tbl_chitiethdbans
                                select new { product.MAHD, product.MASP, product.TENSP, product.NGAYNHAP, product.SOLUONG, product.TONGTIEN };
                    return linq2;
            }
            return null;
        }


        //TOOL
        //MUA SAN PHAM
        public IQueryable<tbl_kho> Load_ForFormMuaHang(string text, string ques)
        {
            LinQBaseDataContext data = new LinQBaseDataContext(connection);
            switch (text)
            {
                case "DonGia":
                    var linq = from product in data.tbl_khos
                               where product.TENSP == ques
                               select product;
                    return linq;
            }
            return null;
        }
        public bool UpdateSoLuong(string ma, int soluong)
        {
            try
            {
                LinQBaseDataContext data = new LinQBaseDataContext(connection);
                tbl_kho kho = data.tbl_khos.Single(tbl_kho => tbl_kho.TENSP == ma);
                kho.SOLUONG = kho.SOLUONG - soluong;
                data.SubmitChanges();
            }
            catch (Exception)
            {
            }
            return true;
        }
        // NHAP SAN PHAM
        public bool Add_SanPham(InforSanPham infor)
        {
            LinQBaseDataContext data = new LinQBaseDataContext(connection);
            try
            {
                tbl_kho kho = new tbl_kho();
                kho.MASP = infor.Masp;
                kho.TENSP = infor.Tensp;
                kho.DONGIA = infor.Dongia;
                kho.DONVI = infor.Donvi;
                kho.SOLUONG = infor.Soluong;
                kho.MANCC = infor.Nhacc;
                kho.MANHOM = infor.Nhomsp;
                kho.GHICHU = infor.Ghichu;
                data.tbl_khos.InsertOnSubmit(kho);
                data.SubmitChanges();
            }
            catch (Exception ex)
            {

            }
            return true;
        }

        //XOA SAN PHAM
        public bool Delete_SanPham(string masp)
        {
            try
            {
                LinQBaseDataContext data = new LinQBaseDataContext(connection);
                tbl_kho kho = data.tbl_khos.Single(tbl_kho => tbl_kho.MASP == masp);
                data.tbl_khos.DeleteOnSubmit(kho);
                data.SubmitChanges();
            }
            catch
            {

            }
            finally
            {
                
            }
            return false;
        }
        public bool Update_SanPham(InforSanPham infor)
        {
            try
            {
                LinQBaseDataContext data = new LinQBaseDataContext(connection);
                tbl_kho kho = data.tbl_khos.Single(tbl_kho => tbl_kho.MASP == infor.Masp);
                kho.TENSP = infor.Tensp;
                kho.DONGIA = infor.Dongia;
                kho.DONVI = infor.Donvi;
                kho.SOLUONG = infor.Soluong;
                kho.MANCC = infor.Nhacc;
                kho.MANHOM = infor.Nhomsp;
                kho.GHICHU = infor.Ghichu;
                data.SubmitChanges();
            }
            catch
            {

            }
            return false;
        }



        //DANH SACH NHA CUNG CAP
        public IQueryable<tbl_nhacungcap> Load_NhaCungCap()
        {
            LinQBaseDataContext data = new LinQBaseDataContext(connection);
            var linq = from product in data.tbl_nhacungcaps
                       select product;
            return linq;
        }
    }
}
