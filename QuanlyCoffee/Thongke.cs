using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DAO;
using DTO;

namespace QuanlyCoffee
{
    public partial class frmThongke : Form
    {
        Connect connect = new Connect();
        DAO_HDBan daohd = new DAO_HDBan();
        public frmThongke()
        {
            InitializeComponent();
        }

        private void bttinh_Click(object sender, EventArgs e)
        {
            if (txtngaybd.Text == "" || txtngaykt.Text == "")
            {
                MessageBox.Show("Chua nhap ngay bat dau hoac ngay ket thuc");
            }
            else
            {
                connect.conn.Open();
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("Select * from [HOADON] Where [Thoigian] BETWEEN'" + Convert.ToDateTime(txtngaybd.Text) + "'AND'" + Convert.ToDateTime(txtngaykt.Text) + "'", connect.conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds, "Hoadon");
                connect.conn.Close();
                dt = ds.Tables["Hoadon"];
                dataGridView1.DataSource = dt;

                int a = 0;
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    a += Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value);
                }
                lbtien.Text = Convert.ToString(a.ToString()) + "vnd";
            }
        }

        private void frmThongke_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = daohd.gethd();
            
        }
    }
}
