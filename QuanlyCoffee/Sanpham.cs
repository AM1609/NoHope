using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;

namespace QuanlyCoffee
{
    public partial class frmSanpham : Form
    {
        DAO_Sanpham daosp = new DAO_Sanpham();
        public frmSanpham()
        {
            InitializeComponent();
        }

        private void frmSanpham_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = daosp.getSanpham();

        }

        private void btthem_Click(object sender, EventArgs e)
        {

        }

        private void btxoa_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = this.dataGridView1.CurrentCell.RowIndex;
            int c = 0;
            txtmasp.Text = dataGridView1.Rows[r].Cells[c].Value.ToString();
            txtTenSP.Text = dataGridView1.Rows[r].Cells[c + 1].Value.ToString();
            txtdongia.Text = dataGridView1.Rows[r].Cells[c + 2].Value.ToString();
            txtMota.Text = dataGridView1.Rows[r].Cells[c + 3].Value.ToString();
            txtHinhminhhoa.Text = dataGridView1.Rows[r].Cells[c + 4].Value.ToString();
            Maloai.Text = dataGridView1.Rows[r].Cells[c + 5].Value.ToString();
            dtcapnhat.Text = dataGridView1.Rows[r].Cells[c + 6].Value.ToString();
            return;
        }
    }
}
