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
    public partial class frmNhanvien : Form
    {
        DAO_Nhanvien daonv = new DAO_Nhanvien();
        public frmNhanvien()
        {
            InitializeComponent();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            int txtgioitinh;
            if (cbNam.Checked== true)
                txtgioitinh = 1;
            else
                txtgioitinh =2;
            if (txtTenNV.Text.Trim().Length != 0)
            {
                DTO_Nhanvien nv = new DTO_Nhanvien(txtTenNV.Text, txtAddress.Text, txtPhone.Text, txttentk.Text, txtmatkhau.Text, txtngaysinh.Text, Convert.ToString(txtgioitinh), txtemail.Text, txtquyen.Text);
                daonv.themnhanvien(nv);
                dataGridView1.DataSource = daonv.getnhanvien();
            }
            txtManv.Clear();
            txtTenNV.Clear();
            txtAddress.Clear();
            txtPhone.Clear();
            txtmatkhau.Clear();
            txttentk.Clear();
            txtngaysinh.Clear();
            cbNam.Checked = false;
            cbNu.Checked = false;
            txtquyen.Clear();
            txtemail.Clear();
            txtTenNV.Focus();

        }

        

        private void btEdit_Click(object sender, EventArgs e)
        {
            int txtgioitinh;
            if (cbNam.Checked)
                txtgioitinh = 1;
            else
                txtgioitinh = 2;
            int a= Convert.ToInt32(txtManv);
            if (txtTenNV.Text.Trim().Length != 0)
            {
                DTO_Nhanvien nv = new DTO_Nhanvien(txtTenNV.Text, txtAddress.Text, txtPhone.Text, txttentk.Text, txtmatkhau.Text, txtngaysinh.Text, Convert.ToString(txtgioitinh), txtemail.Text, txtquyen.Text);
                daonv.suanhanvien(nv, a);
                dataGridView1.DataSource = daonv.getnhanvien();
            }
            txtManv.Clear();
            txtTenNV.Clear();
            txtAddress.Clear();
            txtPhone.Clear();
            txtmatkhau.Clear();
            txttentk.Clear();
            txtngaysinh.Clear();
            cbNam.Checked = false;
            cbNu.Checked = false;
            txtquyen.Clear();
            txtemail.Clear();
            txtTenNV.Focus();

        }

        private void btDel_Click(object sender, EventArgs e)
        {
            int ma = Convert.ToInt16(txtManv.Text);
            if (txtManv.Text.Trim().Length != 0)
            {
                daonv.xoanhanvien(ma);
                dataGridView1.DataSource = daonv.getnhanvien();
            }
            txtManv.Clear();
            txtTenNV.Clear();
            txtAddress.Clear();
            txtPhone.Clear();
            txtmatkhau.Clear();
            txttentk.Clear();
            txtngaysinh.Clear();
            cbNam.Checked = false;
            cbNu.Checked = false;
            txtquyen.Clear();
            txtemail.Clear();
            txtTenNV.Focus();

        }

        private void btrestart_Click(object sender, EventArgs e)
        {
            txtManv.Clear();
            txtTenNV.Clear();
            txtAddress.Clear();
            txtPhone.Clear();
            txtmatkhau.Clear();
            txttentk.Clear();
            txtngaysinh.Clear();
            cbNam.Checked= false;
            cbNu.Checked = false;
            txtquyen.Clear();
            txtemail.Clear();
        }

        private void frmNhanvien_Load(object sender, EventArgs e)
        {

            dataGridView1.DataSource = daonv.getnhanvien();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = this.dataGridView1.CurrentCell.RowIndex;
            int c = 0;
            txtManv.Text = dataGridView1.Rows[r].Cells[c].Value.ToString();
            txtTenNV.Text = dataGridView1.Rows[r].Cells[c + 1].Value.ToString();
            txtAddress.Text = dataGridView1.Rows[r].Cells[c + 2].Value.ToString();
            txtPhone.Text = dataGridView1.Rows[r].Cells[c + 3].Value.ToString();
            txttentk.Text = dataGridView1.Rows[r].Cells[c + 4].Value.ToString();
            txtmatkhau.Text = dataGridView1.Rows[r].Cells[c + 5].Value.ToString();
            txtngaysinh.Text = dataGridView1.Rows[r].Cells[c + 6].Value.ToString();
            if (dataGridView1.Rows[r].Cells[c + 5].Value.ToString()=="0")
            {
                cbNam.Checked= true;
            }
            else
                cbNu.Checked = true;
            txtemail.Text = dataGridView1.Rows[r].Cells[c + 8].Value.ToString();
            txtquyen.Text = dataGridView1.Rows[r].Cells[c + 9].Value.ToString();
            return;
        }
    }
}
