using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_CTHoadon
    {
        public DTO_CTHoadon(int maban, string tencf, int soluong,float dongia, float thanhtien)
        {
            this.Maban = maban;
            this.TenCf = tencf;
            this.Soluong = soluong;
            this.Dongia = dongia;
            this.Thanhtien = thanhtien;
        }
        //public DTO_CTHoadon(DataRow row)
        //{
        //    this.Maban = (int)row["maban"];
        //    this.Masp = (int)row["masp"];
        //    this.Soluong = (int)row["soluong"];
        //}
        private int maban,soluong;
        private float dongia,thanhtien;
        private string tencf;
        public int Maban { get => maban; set => maban = value; }

        public int Soluong { get => soluong; set => soluong = value; }
        public float Dongia { get => dongia; set => dongia = value; }
        public float Thanhtien { get => thanhtien; set => thanhtien = value; }
        public string TenCf { get => tencf; set => tencf = value; }
    }
}
