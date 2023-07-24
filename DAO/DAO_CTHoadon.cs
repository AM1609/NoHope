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
    public class DAO_CTHoadon : Connect
    {
        public string checkmon(int dt)
        {
            
            string str = "select TenCf from COFFEE where Maban='" + dt + "'";
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
        public string checkban(int ban)
        {
            conn.Open();
            string a = "";
            string str = "SELECT TenCf FROM CTHOADON WHERE Maban ='" + ban + "'";
            SqlCommand cmd = new SqlCommand(str, conn);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (reader.GetValue(0).ToString() != null)
                {
                    a = reader.GetValue(0).ToString();
                    break;
                }
                else
                    a = "";
            }
            reader.Close();
            conn.Close();

            if (a != "")
            {
                a = "Có người";
                return a;
            }
            else
            {
                a = "Trống";
                return a;
            }
        }
        public DataTable getchitiethd(int ban)
        {
            conn.Open();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("Select TenCf, Soluong, Dongia, Thanhtien from [CTHOADON] where Maban='"+ban+"'", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "CTHoadon");
            conn.Close();
            dt = ds.Tables["CTHoadon"];
            return dt;
        }

        public bool themchitiethd(DTO_CTHoadon hd)
        {
            try
            {
                conn.Open();
                String query = "INSERT INTO [dbo].[CTHOADON] ( [Maban], [TenCf], [Soluong], [Dongia], [Thanhtien]) VALUES (N'" +
                hd.Maban + "', '" + hd.TenCf + "','" + hd.Soluong + "','" + hd.Dongia + "','" + hd.Thanhtien + "')";
                SqlCommand command = new SqlCommand(query, conn);
                command.ExecuteNonQuery();
            }
            finally
            {
                conn.Close();
            }
            return false;
        }
        public bool suacthd(DTO_CTHoadon nv, int maban)
        {
            try
            {
                conn.Open();
                String query = "UPDATE [dbo].[CTHOADON] SET [TenCf]=N'" + nv.TenCf + "', [Soluong]=N'" + nv.Soluong + "', [Dongia]='" + nv.Dongia + "' , [Thanhtien]='" + nv.Thanhtien + "'  Where [Maban]='" + maban + "'";
                SqlCommand command = new SqlCommand(query, conn);
                command.ExecuteNonQuery();
            }
            finally
            {
                conn.Close();
            }
            return false;
        }
        public bool xoacthoadon(int hd)
        {
            try
            {
                conn.Open();
                String query = "DELETE FROM [dbo].[CTHOADON] WHERE [Maban]='" + hd + "'";
                SqlCommand command = new SqlCommand(query, conn);
                command.ExecuteNonQuery();
            }
            finally
            {
                conn.Close();
            }
            return false;
        }
        public bool lammoi(int hd)
        {
            try
            {
                conn.Open();
                String query = "DELETE * FROM [dbo].[CTHOADON] WHERE [Maban]='" + hd + "'";
                SqlCommand command = new SqlCommand(query, conn);
                command.ExecuteNonQuery();
            }
            finally
            {
                conn.Close();
            }
            return false;
        }
        //public int bien(int dt)
        //{
        //    if (daocthd.checkban(vitriban) == "Có người")
        //    {
        //        string str = "select TenCf from CTHOADON where Maban='" + vitriban + "'";
        //        connect.conn.Open();
        //        SqlCommand cmd = new SqlCommand(str, connect.conn);
        //        SqlDataReader reader;
        //        reader = cmd.ExecuteReader();
        //        int i = 0, sl = 0, dongia = 0, thanhtien = 0;
        //        while (reader.Read())
        //        {
        //            while (reader.GetValue(i).ToString() != null)
        //            {
        //                if (reader.GetValue(i).ToString() == cbTenCf.Text)
        //                {
        //                    string strr = "select Soluong,Dongia, Thanhtien from CTHOADON where Maban='" + vitriban + "'";

        //                    SqlCommand cmd = new SqlCommand(strr, connect.conn);
        //                    SqlDataReader readerr;
        //                    readerr = cmdd.ExecuteReader();
        //                    while (reader.Read())
        //                    {
        //                        while (reader.GetValue(i).ToString() != null)
        //                        {
        //                            sl = Convert.ToInt32(reader.GetValue(0));
        //                            dongia = Convert.ToInt32(reader.GetValue(1));
        //                            thanhtien = Convert.ToInt32(reader.GetValue(2));
        //                        }
        //                    }
        //                }

        //            }
        //        }
        //        sl += Convert.ToInt32(txtSoluong.Text);
        //        dongia += Convert.ToInt32(txtdongia.Text);
        //        thanhtien += Convert.ToInt32(txtthanhtien.Text);
        //        DTO_CTHoadon hd = new DTO_CTHoadon(vitriban, cbTenCf.Text, sl, dongia, thanhtien);
        //        daocthd.suacthd(hd, vitriban);
        //        str = reader.GetValue(0).ToString();
        //        reader.Close();
        //        connect.conn.Close();
        //    }
        //    else
        //    {
        //        txtthanhtien.Clear();
        //        int a = Convert.ToInt32(txtdongia.Text) * Convert.ToInt32(txtSoluong.Text);
        //        b += a;
        //        txtthanhtien.Text = Convert.ToString(a.ToString());
        //        txttong.Text = Convert.ToString(b.ToString());
        //        DTO_CTHoadon hdd = new DTO_CTHoadon(vitriban, cbTenCf.Text, Convert.ToInt32(txtSoluong.Text), Convert.ToInt32(txtdongia.Text), Convert.ToInt32(txtthanhtien.Text));
        //        daocthd.themchitiethd(hdd);
        //        dataGridView1.DataSource = daocthd.getchitiethd(vitriban);
        //    }
        //}
    }
   
}
