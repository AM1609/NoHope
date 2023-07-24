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
    public class DAO_Kho:Connect
    {
        public DataTable getKho()
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("Select * from [KHO]", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "KHO");
            conn.Close();
            dt = ds.Tables["KHO"];
            return dt;
        }
        public bool themkho(DTO_Kho hd)
        {
            try
            {
                conn.Open();
                String query = "INSERT INTO [dbo].[KHO] ( [Tensp], [Soluong], [Dongia], [Donvi]) VALUES (N'" +
                hd.Tensp + "', '" + hd.Soluong + "','" + hd.Dongia + "','" + hd.Donvi + "')";
                SqlCommand command = new SqlCommand(query, conn);
                command.ExecuteNonQuery();
            }
            finally
            {
                conn.Close();
            }
            return false;
        }
        public bool suakho(DTO_Kho nv, string masp)
        {
            try
            {
                conn.Open();
                String query = "UPDATE [dbo].[KHO] SET [Tensp]=N'" + nv.Tensp + "', [Soluong]=N'" + nv.Soluong + "', [Dongia]='" + nv.Dongia + "', [Donvi]='" + nv.Donvi + "' Where [Masp]='" + masp + "'";
                SqlCommand command = new SqlCommand(query, conn);
                command.ExecuteNonQuery();
            }
            finally
            {
                conn.Close();
            }
            return false;
        }
        public bool xoakho(string hd)
        {
            try
            {
                conn.Open();
                String query = "DELETE FROM [dbo].[KHO] WHERE [Masp]='" + hd + "'";
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
