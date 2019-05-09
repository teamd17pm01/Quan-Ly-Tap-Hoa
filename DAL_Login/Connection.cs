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
       protected SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-16PLU27\SQLEXPRESS;Initial Catalog=LoginForm;Integrated Security=True");
    }
}
