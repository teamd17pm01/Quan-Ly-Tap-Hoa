using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DTO_Login;

namespace DAL_Login
{
    public class qal:Connection
    {
        public string getID(dto tv)
        {
            string id = "";
            try
            {   
                connection.Open();
                string sql = string.Format("SELECT *FROM tbl_user WHERE  name_user='{0}' and pass='{1}'", tv.Name, tv.Psw);
                SqlCommand cmd = new SqlCommand(sql, connection);
                SqlDataAdapter sqlData = new SqlDataAdapter(cmd);
                DataTable data = new DataTable();
                sqlData.Fill(data);
                if (data != null)
                {
                    foreach(DataRow d in data.Rows)
                    {
                        id = d["id_user"].ToString();                            
                    }
                }
              
            }
            catch (Exception)
            {
                
            }
            finally
            {
                connection.Close();
            }
            return id;
        }
        public bool KtTaiKhoan(dto tv)
        {
            try
            {
                LinQBaseDataContext context = new LinQBaseDataContext(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\phamh\source\repos\LoginForm\DAL_Login\QLlogin.mdf;Integrated Security=True");
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
            /*try
            {
                connection.Open();
                string sql = string.Format("SELECT *FROM tbl_user WHERE  user_name='{0}' and pass='{1}'",tv.User,tv.Psw);
                SqlCommand cmd = new SqlCommand(sql, connection);
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
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
            }*/
            return false;
        }
       
        public bool KiemTraTonTai(dto tv)
        {
            try
            {
                LinQBaseDataContext context = new LinQBaseDataContext(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\phamh\source\repos\LoginForm\DAL_Login\QLlogin.mdf;Integrated Security=True");
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
            /*try
            {
                connection.Open();
                string sql = string.Format("SELECT *FROM tbl_user WHERE  user_name='{0}'", tv.User);
                SqlCommand cmd = new SqlCommand(sql, connection);
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    return true;
                }
            }
            catch(Exception e)
            {

            }
            finally
            {
                connection.Close();
            }
            return false;*/
        }
        //Phan Quyen
        public string id_per(int id_user)
        {
            string id = "";
            try
            {
                connection.Open();
                string sql = string.Format("SELECT *FROM tbl_per_relationship WHERE id_user_rel={0}", id_user);
                SqlCommand cmd = new SqlCommand(sql, connection);
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataTable data = new DataTable();
                adapt.Fill(data);
                if (data != null)
                {
                    foreach(DataRow dr in data.Rows)
                    {
                        if (dr["suspended"].ToString() == "True")
                        {
                            id = dr["id_per_rel"].ToString(); 
                        }
                    }
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                connection.Close();
            }
            return id;
        }

        public bool Add(dto tv)
        {
           
            try
            {
                connection.Open();
                //string sql = string.Format("INSERT INTO tbl_user(name_user, user_name, pass) VALUES('{0}', '{1]', '{2}')",tv.Name,tv.User,tv.Psw);
                string sql = string.Format("INSERT INTO tbl_user(name_user,user_name,pass) VALUES('{0}', '{1}', '{2}')", tv.Name, tv.User, tv.Psw);
                SqlCommand cmd = new SqlCommand(sql, connection);
               // string sql2= string.Format("INSERT INTO tbl_per_relationship(id_user_rel, id_per_rel) VALUES('{0}', '{1}')", )
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
            /*
            try
            {
                connection.Open();
                string sql = string.Format("UPDATE tbl_user SET pass='{0}' WHERE user_name='{1}'", password,user);
                SqlCommand cmd = new SqlCommand(sql, connection);
                SqlDataReader read = cmd.ExecuteReader();

                if (read.Read())
                {
                    return true;
                }
            }
            catch(Exception e)
            {

            }
            finally
            {
                connection.Close();
            }
            */
            return false;
            
        }
        public bool addNewUser(dto tv)
        {
            string connect = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\phamh\source\repos\LoginForm\DAL_Login\QLlogin.mdf;Integrated Security=True";
                LinQBaseDataContext context = new LinQBaseDataContext(connect);
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
    }
}
