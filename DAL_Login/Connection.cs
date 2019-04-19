using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL_Login
{
    public class Connection
    {
       protected SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\phamh\\source\\repos\\LoginForm\\LoginForm\\QLlogin.mdf;Integrated Security=True");
    }
}
