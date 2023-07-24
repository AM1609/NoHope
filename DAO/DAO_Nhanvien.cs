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
    public class DAO_Nhanvien : Connect
    {
        public DataTable getnhanvien()
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("Select * from [Nhanvien]", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "Nhanvien");
            conn.Close();
            dt = ds.Tables["Nhanvien"];
            return dt;
        }
        public bool themnhanvien(DTO_Nhanvien nv)
        {
            try
            {
                conn.Open();
                String query = "INSERT INTO [dbo].[Nhanvien] ([Hoten],[Diachi],[Dienthoai],[TenDN],[MatKhau],[NgaySinh],[GioiTinh],[Email],[Quyen]) VALUES ('" + nv.Hoten + "',N'" +
                nv.Diachi + "', N'" + nv.Dienthoai + "','" + nv.TenDN + "','" + nv.Matkhau + "','" + nv.Ngaysinh + "','" + nv.GioiTinh + "','" + nv.Email + "','" + nv.Quyen + "')";
                SqlCommand command = new SqlCommand(query, conn);
                command.ExecuteNonQuery();
            }
            finally
            {
                conn.Close();
            }
            return false;
        }
        public bool suanhanvien(DTO_Nhanvien nv,int manv)
        {
            try
            {
                conn.Open();
                String query = "UPDATE [dbo].[Nhanvien] SET [Hoten]=N'" + nv.Hoten + "', [Diachi]=N'" + nv.Diachi + "', [Dienthoai]='" + nv.Dienthoai + "' , [TenDN]='" + nv.TenDN + "' , [Matkhau]='" + nv.Matkhau + "', [Ngaysinh]='" + nv.Ngaysinh + "', [GioiTinh]='" + nv.GioiTinh + "', [Email]='" + nv.Email + "', [Quyen]='" + nv.Quyen + "'  Where [MaNV]='" + manv + "'";
                SqlCommand command = new SqlCommand(query, conn);
                command.ExecuteNonQuery();
            }
            finally
            {
                conn.Close();
            }
            return false;
        }

        public bool xoanhanvien(int manv)
        {
            try
            {
                conn.Open();
                String query = "DELETE FROM [dbo].[Nhanvien] WHERE [MaNV]='" + manv + "'";
                SqlCommand command = new SqlCommand(query, conn);
                command.ExecuteNonQuery();
            }
            finally
            {
                conn.Close();
            }
            return false;
        }
        public string Nvdungca(int tennv)
        {
            string str = "SELECT Hoten FROM NHANVIEN WHERE Manv ='" + tennv + "'";
            conn.Open();
            SqlCommand cmd = new SqlCommand(str,conn);
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
