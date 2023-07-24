using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Kho
    {
        private string tensp, soluong, dongia, donvi;

        public string Tensp { get => tensp; set => tensp = value; }
        public string Soluong { get => soluong; set => soluong = value; }
        public string Dongia { get => dongia; set => dongia = value; }
        public string Donvi { get => donvi; set => donvi = value; }
        public DTO_Kho(string tensp, string soluong, string dongia, string donvi)
        {

            this.Tensp = tensp;
            this.Soluong = soluong;
            this.Dongia = dongia;
            this.Donvi = donvi;

        }
    }
}
