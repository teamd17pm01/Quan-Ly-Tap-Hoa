using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Login
{
    public class dto
    {
        string name;
        string psw;
        string user;
        //int id;

        public string Name { get => name; set => name = value; }
        public string Psw { get => psw; set => psw = value; }
        //public int Id { get => id; set => id = value; }
        public string User { get => user; set => user = value; }

        //public int Id { get => id; set => id = value; }

        public dto(string name,string user,string psw)
        {
            //this.Id = id;
            this.Name = name;
            this.User = user;
            this.Psw = psw;
            //this.Id=
        }
        public dto(string user,string psw)
        {
            this.User = user;
            this.Psw = psw;
        }
        public dto(string user)
        {
            this.User = user;
        }
    }
}
