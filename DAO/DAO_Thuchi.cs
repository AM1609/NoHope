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
    public class DAO_Thuchi:Connect
    {
        public DataTable getthuchi()
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("Select * from [THUCHI]", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "Sanpham");
            conn.Close();
            dt = ds.Tables["Sanpham"];
            return dt;
        }
        public bool themthuchi(DTO_Thuchi hd)
        {
            try
            {
                conn.Open();
                String query = "INSERT INTO [dbo].[THUCHI] ( [Sanpham],[Soluong],[Sotien],[Thoigian],[Hoten]) VALUES (N'" +
                hd.Sanpham + "', '" + hd.Soluong + "','" + hd.Sotien + "','" + hd.Thoigian + "','" + hd.Hoten + "')";
                SqlCommand command = new SqlCommand(query, conn);
                command.ExecuteNonQuery();
            }
            finally
            {
                conn.Close();
            }
            return false;
        }
        public bool xoathuchi(string hd)
        {
            try
            {
                conn.Open();
                String query = "DELETE FROM [dbo].[THUCHI] WHERE [Masp]='" + hd + "'";
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
