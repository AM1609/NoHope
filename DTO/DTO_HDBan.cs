using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_HDBan
    {
        private string madh, tongtien, vitri, thoigian, hoten;

        public string MaHD { get => madh; set => madh = value; }
        
        public string Tongtien { get => tongtien; set => tongtien = value; }

        public string Vitriban { get => vitri; set => vitri = value; }
        public string Thoigian { get => thoigian; set => thoigian = value; }
        public string Hoten { get => hoten; set => hoten = value; }
        public DTO_HDBan(string madh, string tongtien, string vitri, string thoigian, string hoten)
        {

            this.MaHD = madh;
            
            this.Tongtien = tongtien;

            this.Vitriban = vitri;
            this.Thoigian = thoigian;
            this.Hoten = hoten;

        }
    }
}
