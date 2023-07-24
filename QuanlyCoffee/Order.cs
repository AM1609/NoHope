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
    public partial class frmOrder : Form
    {
        Connect connect = new Connect();
        DAO_CTHoadon daocthd = new DAO_CTHoadon();
        DAO_HDBan daohdban = new DAO_HDBan();
        DAO_Sanpham daosanpham = new DAO_Sanpham();
        DAO_Nhanvien daonhanvien = new DAO_Nhanvien();
        
        int b = 0;
        private int username;
        private int vitriban;
        public frmOrder()
        {
            InitializeComponent();
        }
        public frmOrder(int username,int vitri)
        {
            InitializeComponent();
            this.username = username;
            this.vitriban = vitri;
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (cbTensp.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn sản phẩm");
                return;
            }
            if (txtSoluong.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập số lượng");
                return;
            }
            txtthanhtien.Clear();
            int a = Convert.ToInt32(txtdongia.Text) * Convert.ToInt32(txtSoluong.Text);
            txtthanhtien.Text = Convert.ToString(a.ToString());
            
            DTO_CTHoadon hdd = new DTO_CTHoadon(vitriban, cbTensp.Text, Convert.ToInt32(txtSoluong.Text), Convert.ToInt32(txtdongia.Text), Convert.ToInt32(txtthanhtien.Text));
            daocthd.themchitiethd(hdd);
            dataGridView1.DataSource = daocthd.getchitiethd(vitriban);
            if (daocthd.checkban(vitriban) == "Có người")
            {
                int i = 0, tam = 0;
                while (dataGridView1.Rows[i].Cells[3].Value != null)
                {
                    tam += Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value);
                    i++;
                }
                txttong.Text = tam.ToString();
            }
        }
        
        private void frmOrder_Load(object sender, EventArgs e)
        {
            
            lbban.Text = Convert.ToString(vitriban);
            lbtennv.Text = daonhanvien.Nvdungca(Convert.ToInt32(username));
            DataTable dt = new DataTable();
            SqlCommand command = new SqlCommand("Select TenCf From COFFEE", connect.conn);
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            da.Fill(ds, "TenCf");
            dt = ds.Tables["TenCf"];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cbTensp.Items.Add(dt.Rows[i].ItemArray[0].ToString());
            }
            txtNgayban.Text = DateTime.Now.ToShortDateString();

            dataGridView1.DataSource = daocthd.getchitiethd(vitriban);
            if(daocthd.checkban(vitriban)=="Có người")
            {
                int i = 0,tam=0;
                while(dataGridView1.Rows[i].Cells[3].Value!=null)
                {
                    tam += Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value);
                    i++;
                }
                txttong.Text = tam.ToString();
            }
        }
        public static string CreateKey(string tiento)
        {
            string key = tiento;
            string[] partsDay;
            partsDay = DateTime.Now.ToShortDateString().Split('/');
            //Ví dụ 07/08/2009
            string d = String.Format("{0}{1}{2}", partsDay[0], partsDay[1], partsDay[2]);
            key = key + d;
            string[] partsTime;
            partsTime = DateTime.Now.ToLongTimeString().Split(':');
            //Ví dụ 7:08:03 PM hoặc 7:08:03 AM
            if (partsTime[2].Substring(3, 2) == "PM")
                partsTime[0] = ConvertTimeTo24(partsTime[0]);
            if (partsTime[2].Substring(3, 2) == "AM")
                if (partsTime[0].Length == 1)
                    partsTime[0] = "0" + partsTime[0];
            //Xóa ký tự trắng và PM hoặc AM
            partsTime[2] = partsTime[2].Remove(2, 3);
            string t;
            t = String.Format("_{0}{1}{2}", partsTime[0], partsTime[1], partsTime[2]);
            key = key + t;
            return key;
        }
        public static string ConvertTimeTo24(string hour)
        {
            string h = "";
            switch (hour)
            {
                case "1":
                    h = "13";
                    break;
                case "2":
                    h = "14";
                    break;
                case "3":
                    h = "15";
                    break;
                case "4":
                    h = "16";
                    break;
                case "5":
                    h = "17";
                    break;
                case "6":
                    h = "18";
                    break;
                case "7":
                    h = "19";
                    break;
                case "8":
                    h = "20";
                    break;
                case "9":
                    h = "21";
                    break;
                case "10":
                    h = "22";
                    break;
                case "11":
                    h = "23";
                    break;
                case "12":
                    h = "0";
                    break;
            }
            return h;
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows[0].Cells[0].Value == null)
            {
                MessageBox.Show("Chưa có sản phẩm được thêm vào");
                return;
            }

            int r = this.dataGridView1.CurrentCell.RowIndex;
            int c = this.dataGridView1.CurrentCell.ColumnIndex;

            b = b - Convert.ToInt32(dataGridView1.Rows[Convert.ToInt16(dataGridView1.CurrentCell.RowIndex.ToString())].Cells[3].Value.ToString());
            txttong.Text = Convert.ToString(b);
            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(item.Index);
            }
            if (daocthd.checkban(vitriban) == "Có người")
            {
                int i = 0, tam = 0;
                while (dataGridView1.Rows[i].Cells[3].Value != null)
                {
                    tam += Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value);
                    i++;
                }
                txttong.Text = tam.ToString();
            }
        }

        private void btlammoi_Click(object sender, EventArgs e)
        {
            daocthd.lammoi(vitriban);
            txtSoluong.Clear();
            txtthanhtien.Clear();
            txtdongia.Clear();
            txttong.Clear();
        }

        private void btthanhtoan_Click(object sender, EventArgs e)
        {
            int a=0;
            
            for (int i = 0; i < dataGridView1.RowCount-1; i++)
            {
                a += Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value);
            }
            MessageBox.Show("Tổng hóa đơn là "+a+". Bạn có chắc là muốn thanh toán");
            DTO_HDBan hd = new DTO_HDBan(CreateKey("HD"), a.ToString(), vitriban.ToString(), txtNgayban.Text, lbtennv.Text);
            daohdban.themhd(hd);
            this.Close();
            daocthd.xoacthoadon(vitriban);
            txtSoluong.Clear();
            txtthanhtien.Clear();
            txtdongia.Clear();
            txttong.Clear();
        }

        private void cbTensp_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str;
            if (cbTensp.Text == "")
            {
                txtdongia.Text = "";
                txtthanhtien.Text = "";
            }
            else
            {
                str = "SELECT Dongia FROM COFFEE WHERE TenCf ='" + cbTensp.SelectedItem + "'";
                connect.conn.Open();
                SqlCommand cmd = new SqlCommand(str, connect.conn);
                SqlDataReader reader;
                reader = cmd.ExecuteReader();
                while (reader.Read())
                    str = reader.GetValue(0).ToString();
                reader.Close();
                connect.conn.Close();
                txtdongia.Text = str;
            }
        }

        private void txtSoluong_TextChanged(object sender, EventArgs e)
        {
            if (txtSoluong.Text == "")
            {

                txtthanhtien.Text = "";
            }
            else
            {
                try
                {
                    int a = Convert.ToInt32(txtdongia.Text) * Convert.ToInt32(txtSoluong.Text);
                    txtthanhtien.Text = Convert.ToString(a);
                }
                catch { }
            }
        }

        
    }
}
