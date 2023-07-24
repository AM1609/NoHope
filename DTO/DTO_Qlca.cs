using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Qlca
    {
        private string hoten, thoigianket;
        private float doanhthu, tienchi;
        private int tiendauca;

        public string Hoten { get => hoten; set => hoten = value; }

        public string Thoigianket { get => thoigianket; set => thoigianket = value; }
        public float Doanhthu { get => doanhthu; set => doanhthu = value; }
        public float Tienchi { get => tienchi; set => tienchi = value; }
        public int Tiendauca { get => tiendauca; set => tiendauca = value; }
        public DTO_Qlca(int tiendauca, float doanhthu, float tienchi, string thoigianket, string hoten)
        {
            this.Tiendauca = tiendauca;
            this.Doanhthu = doanhthu;
            this.Tienchi = tienchi;

            this.Thoigianket = thoigianket;
            this.Hoten = hoten;
        }
    }
}
