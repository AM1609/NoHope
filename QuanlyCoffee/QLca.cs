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
    public partial class frmQLca : Form
    {
        DAO_Qlca daoca = new DAO_Qlca();
        DAO_Nhanvien daonv = new DAO_Nhanvien();
        private int user = 0;
        public frmQLca()
        {
            InitializeComponent();
        }
        public frmQLca(int username)
        {
            InitializeComponent();
            this.user = username;
        }

        private void btnnhap_Click(object sender, EventArgs e)
        {
            lbdauca.Text = txtdauca.Text;
            txtdauca.Visible = false;
            btnnhap.Visible = false;
            
        }

        private void btnketca_Click(object sender, EventArgs e)
        {
            int a = 0;
            a = Convert.ToInt32(txtcuoica.Text) - (Convert.ToInt32(txtdauca.Text)+ Convert.ToInt32(lbtienchi.Text) + Convert.ToInt32(lbdoanhthu.Text));
            if(a==0)
            {
                MessageBox.Show("Chênh lệch 0đ.");
            }
            else
            {
                a *= -1;
                MessageBox.Show("Chênh lệch " + a + "đ");
            }
            DTO_Qlca ca = new DTO_Qlca(Convert.ToInt32(txtdauca.Text), Convert.ToInt32(lbdoanhthu.Text), Convert.ToInt32(lbtienchi.Text), DateTime.Now.ToShortDateString(), daonv.Nvdungca(user));
            daoca.themca(ca);
        }

        private void frmQLca_Load(object sender, EventArgs e)
        {
            lbtienchi.Text = daoca.tienchi(DateTime.Now.ToShortDateString());
            lbdoanhthu.Text = daoca.doanhthu(DateTime.Now.ToShortDateString());
        }
    }
}
