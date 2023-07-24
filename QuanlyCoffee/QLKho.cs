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
using DTO;

namespace QuanlyCoffee
{
    public partial class frmQLKho : Form
    {
        DAO_Kho daosp = new DAO_Kho();
        public frmQLKho()
        {
            InitializeComponent();
        }

        private void frmQLKho_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = daosp.getKho();
        }

        private void btthem_Click(object sender, EventArgs e)
        {
            if (txtTenSP.Text.Trim().Length != 0)
            {
                DTO_Kho sp = new DTO_Kho( txtTenSP.Text, txtSl.Text, txtdongia.Text, txtdonvi.Text);
                daosp.themkho(sp);
                dataGridView1.DataSource = daosp.getKho();
            }
            txtMaSP.Clear();
            txtTenSP.Clear();
            txtSl.Clear();
            txtdongia.Clear();
            txtdonvi.Clear();
            txtMaSP.Focus();
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            int ma = Convert.ToInt16(txtMaSP.Text);
            if (txtMaSP.Text.Trim().Length != 0)
            {
                daosp.xoakho(txtMaSP.Text);
                dataGridView1.DataSource = daosp.getKho();
            }
            txtMaSP.Clear();
            txtTenSP.Clear();
            txtSl.Clear();
            txtdonvi.Clear();
            txtdongia.Clear();
            txtMaSP.Focus();
        }

        private void btsua_Click(object sender, EventArgs e)
        {
            if (txtMaSP.Text.Trim().Length != 0)
            {
                DTO_Kho sp = new DTO_Kho(txtTenSP.Text, txtSl.Text, txtdongia.Text, txtdonvi.Text);
                daosp.suakho(sp, txtMaSP.Text);
                dataGridView1.DataSource = daosp.getKho();
            }
            txtMaSP.Clear();
            txtTenSP.Clear();
            txtSl.Clear();
            txtdonvi.Clear();
            txtdongia.Clear();
            txtMaSP.Focus();
        }

        private void btkhoitao_Click(object sender, EventArgs e)
        {
            txtMaSP.Clear();
            txtTenSP.Clear();
            txtSl.Clear();
            txtdonvi.Clear();
            txtdongia.Clear();
            txtMaSP.Focus();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = this.dataGridView1.CurrentCell.RowIndex;
            int c = 0;
            txtMaSP.Text = dataGridView1.Rows[r].Cells[c].Value.ToString();
            txtTenSP.Text = dataGridView1.Rows[r].Cells[c + 1].Value.ToString();
            txtSl.Text = dataGridView1.Rows[r].Cells[c + 2].Value.ToString();
            txtdongia.Text = dataGridView1.Rows[r].Cells[c + 3].Value.ToString();
            txtdonvi.Text = dataGridView1.Rows[r].Cells[c + 4].Value.ToString();
            return;
        }
    }
}
