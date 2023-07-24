using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;
using System.Data;

namespace DAO
{
    public class DAO_Qlca:Connect
    {
        public bool themca(DTO_Qlca hd)
        {
            try
            {
                conn.Open();
                String query = "INSERT INTO [dbo].[QLCA] ( [Tiendauca],[Doanhthu],[Tienchi],[Thoigianket],[Hoten]) VALUES (N'" +
                hd.Tiendauca + "', '" + hd.Doanhthu + "','" + hd.Tienchi + "','" + hd.Thoigianket + "','" + hd.Hoten + "')";
                SqlCommand command = new SqlCommand(query, conn);
                command.ExecuteNonQuery();
            }
            finally
            {
                conn.Close();
            }
            return false;
        }
        public string doanhthu(string dt)
        {
            string str = "select SUM(Tongtien) from HOADON where Thoigian='" + dt + "'";
            conn.Open();
            SqlCommand cmd = new SqlCommand(str, conn);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            while (reader.Read())
                str = reader.GetValue(0).ToString();
            reader.Close();
            conn.Close();
            return str;
        }
        public string tienchi(string dt)
        {
            string str = "select SUM(Sotien) from THUCHI where Thoigian='" + dt + "'";
            conn.Open();
            SqlCommand cmd = new SqlCommand(str, conn);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            while (reader.Read())
                str = reader.GetValue(0).ToString();
            reader.Close();
            conn.Close();
            return str;
        }
    }
}
