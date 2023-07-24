using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Phanloai
    {
        private string  maloai, tenloai;
       
        public string Maloai { get => maloai; set => maloai = value; }
        public string Tenloai { get => tenloai; set => tenloai = value; }
        public DTO_Phanloai( string maloai, string tenloai)
        {
            
            this.Maloai = maloai;
            this.Tenloai = tenloai;
        }
    }
}
