using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Login
{
    public class InforSanPham
    {
        private string masp;
        private string tensp;
        private int soluong;
        private decimal dongia;
        private string donvi;
        private string nhacc;
        private string nhomsp;
        private string ghichu;


        public string Masp { get => masp; set => masp = value; }
        public string Tensp { get => tensp; set => tensp = value; }
        public int Soluong { get => soluong; set => soluong = value; }
        public decimal Dongia { get => dongia; set => dongia = value; }
        public string Donvi { get => donvi; set => donvi = value; }
        public string Nhacc { get => nhacc; set => nhacc = value; }
        public string Nhomsp { get => nhomsp; set => nhomsp = value; }
        public string Ghichu { get => ghichu; set => ghichu = value; }

        public InforSanPham()
        {

        }
    }
}
