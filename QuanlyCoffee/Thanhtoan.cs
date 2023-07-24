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
    public partial class frmThanhtoan : Form
    {
        Connect connect = new Connect();
        DAO_HDBan daohd = new DAO_HDBan();
        public frmThanhtoan()
        {
            InitializeComponent();
        }

        private void frmThanhtoan_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = daohd.gethd();

        }

        private void bttimkiem_Click(object sender, EventArgs e)
        {
            if (txtmahd.Text == "" && txtngayban.Text == "")
            {
                MessageBox.Show("Chua nhap ma hoa don hoac ngay ban");
            }
            else
            {
                if (txtmahd.Text == "")
                {
                    DataTable dt = new DataTable();
                    SqlCommand cmd = new SqlCommand("Select * from [HOADON] Where [Thoigian]='" + Convert.ToDateTime(txtngayban.Text) + "'", connect.conn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Hoadon");
                    connect.conn.Close();
                    dt = ds.Tables["Hoadon"];
                    dataGridView1.DataSource = dt;

                }
                else
                {
                    DataTable dt = new DataTable();
                    SqlCommand cmd = new SqlCommand("Select * from [HOADON] Where [MaHD]='" + txtmahd.Text + "'", connect.conn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Hoadon");
                    connect.conn.Close();
                    dt = ds.Tables["Hoadon"];
                    dataGridView1.DataSource = dt;
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = this.dataGridView1.CurrentCell.RowIndex;
            int c = 0;
            txtxemmahd.Text = dataGridView1.Rows[r].Cells[c].Value.ToString();
            txtxemtongtien.Text = dataGridView1.Rows[r].Cells[c + 1].Value.ToString();
            txtban.Text = dataGridView1.Rows[r].Cells[c + 2].Value.ToString();
            txtxemngayban.Text = dataGridView1.Rows[r].Cells[c + 3].Value.ToString();
            txtxemtennv.Text = dataGridView1.Rows[r].Cells[c + 4].Value.ToString();
            return;
        }
    }
}
