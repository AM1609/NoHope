using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Nhanvien
    {
        private string hoten, diachi, dt , tendn, mk, ngaysinh, gioitinh, email, quyen;
        public string Hoten { get => hoten; set => hoten = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public string Dienthoai { get => dt; set => dt = value; }
        public string TenDN { get => tendn; set => tendn = value; }
        public string Matkhau { get => mk; set => mk = value; }
        public string Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
        public string GioiTinh { get => gioitinh; set => gioitinh = value; }
        public string Email { get => email; set => email = value; }
        public string Quyen { get => quyen; set => quyen = value; }
        public DTO_Nhanvien(string hoten, string diachi, string dt, string tendn, string mk, string ngaysinh, string gioitinh, string email, string quyen)
        {
            this.Hoten = hoten;
            this.Diachi = diachi;
            this.Dienthoai = dt;
            this.TenDN = tendn;
            this.Matkhau = mk;
            this.Ngaysinh = ngaysinh;
            this.GioiTinh = gioitinh;
            this.Email = email;
            this.Quyen = quyen;
            
        }
    }
}
