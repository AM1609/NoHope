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
    public class DAO_HDBan : Connect
    {
        public DataTable gethd()
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("Select * from [HOADON]", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "HDBan");
            conn.Close();
            dt = ds.Tables["HDBan"];
            return dt;
        }
        public bool themhd(DTO_HDBan hd)
        {
            try
            {
                conn.Open();
                String query = "INSERT INTO [dbo].[HOADON] ( [MaHD], [Tongtien], [Vitriban], [Thoigian], [Hoten]) VALUES ('" +
                hd.MaHD + "','" + hd.Tongtien + "','" + hd.Vitriban + "','" + hd.Thoigian + "','" + hd.Hoten + "')";
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
