using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Sanpham
    {
        private string tencf, dongia, mota, hinh, loai, ngaycn;

        public string TenCf { get => tencf; set => tencf = value; }
        public string DonGia { get => dongia; set => dongia = value; }
        public string MoTa { get => mota; set => mota = value; }
        public string HinhMinhHoa { get => hinh; set => hinh = value; }
        public string MaLoai { get => loai; set => loai = value; }
        public string NgayCapNhat { get => ngaycn; set => ngaycn = value; }
        public DTO_Sanpham(string tencf, string dongia, string mota, string hinh, string loai, string ngaycn)
        {

            this.TenCf = tencf;
            this.DonGia = dongia;
            this.MoTa = mota;
            this.HinhMinhHoa = hinh;
            this.MaLoai = loai;
            this.NgayCapNhat = ngaycn;
        }
    }
}
