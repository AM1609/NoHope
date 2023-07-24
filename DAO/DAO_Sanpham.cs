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
    public class DAO_Sanpham : Connect
    {
        public DataTable getSanpham()
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("Select * from [COFFEE]", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "Sanpham");
            conn.Close();
            dt = ds.Tables["Sanpham"];
            return dt;
        }

        public bool themSanpham(DTO_Sanpham sp)
        {
            try
            {
                conn.Open();
                String query = "INSERT INTO [dbo].[Sanpham] ([TenCf],[DonGia],[MoTa],[HinhMinhHoa],[MaLoai],[NgayCapNhat]) VALUES ('" + sp.TenCf + "',N'" +
                sp.DonGia + "', '" + sp.MoTa + "', '" + sp.HinhMinhHoa + "', '" + sp.MaLoai + "', '" + sp.NgayCapNhat + "')";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
            }
            finally
            {
                conn.Close();
            }
            return false;
        }
        public bool suaSanpham(DTO_Sanpham sp, int MaCf)
        {
            try
            {
                conn.Open();
                String query = "UPDATE [dbo].[Sanpham] SET [TenSP]=N'" + sp.TenCf + "', [Soluong]='" + sp.DonGia + "' , [Dongia]='" + sp.MoTa + "', [Dongia]='" + sp.HinhMinhHoa + "', [Dongia]='" + sp.MaLoai + "', [Dongia]='" + sp.NgayCapNhat + "' Where [MaSP]='" + MaCf + "'";
                SqlCommand command = new SqlCommand(query, conn);
                command.ExecuteNonQuery();
            }
            finally
            {
                conn.Close();
            }
            return false;
        }
        public bool xoaSanpham(int mahang)
        {
            try
            {
                conn.Open();
                String query = "DELETE FROM [dbo].[Sanpham] WHERE [MaSP]='" + mahang + "'";
                SqlCommand command = new SqlCommand(query, conn);
                command.ExecuteNonQuery();
            }
            finally
            {
                conn.Close();
            }
            return false;
        }
    }
}
