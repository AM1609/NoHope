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
    public partial class frmThuchi : Form
    {
        Connect connect = new Connect();
        DAO_Thuchi daotc = new DAO_Thuchi();
        DAO_Nhanvien daonv = new DAO_Nhanvien();
        private int user;
        public frmThuchi()
        {
            InitializeComponent();
        }
        public frmThuchi(int username)
        {
            InitializeComponent();
            this.user = username;
        }

        private void frmThuchi_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = daotc.getthuchi();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            DTO_Thuchi tc= new DTO_Thuchi(txtsp.Text, Convert.ToInt32(txtsoluong.Text), Convert.ToInt32(txtsotien.Text), DateTime.Now.ToShortDateString(), daonv.Nvdungca(user).ToString());
            daotc.themthuchi(tc);
            dataGridView1.DataSource = daotc.getthuchi();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = this.dataGridView1.CurrentCell.RowIndex;
            int c = 0;
            txtsp.Text = dataGridView1.Rows[r].Cells[c].Value.ToString();
            txtsoluong.Text = dataGridView1.Rows[r].Cells[c + 1].Value.ToString();
            txtsotien.Text = dataGridView1.Rows[r].Cells[c + 2].Value.ToString();
            
            return;
        }
    }
}
