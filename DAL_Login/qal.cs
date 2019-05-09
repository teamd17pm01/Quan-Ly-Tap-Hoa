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
    public class qal:Connection
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
                if (list.Count>0)
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
            foreach(var user in linq)
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
                
            try {
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
    }
}
