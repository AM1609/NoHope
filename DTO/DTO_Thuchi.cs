using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Thuchi
    {
        private string hoten;
        private int sotien;
        private int soluong;
        private string sanpham;
        private string thoigian;

        public int Soluong { get => soluong; set => soluong = value; }
        public int Sotien { get => sotien; set => sotien = value; }
        public string Sanpham { get => sanpham; set => sanpham = value; }
        public string Thoigian { get => thoigian; set => thoigian = value; }
        public string Hoten { get => hoten; set => hoten = value; }
        public DTO_Thuchi(string sanpham, int soluong,int sotien, string thoigian, string hoten)
        {
            this.Sanpham = sanpham;
            this.Soluong = soluong;
            this.Sotien = sotien;
            this.Thoigian = thoigian;
            this.Hoten = hoten;
        }
    }
}
