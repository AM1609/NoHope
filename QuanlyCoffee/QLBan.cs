using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using DAO;
namespace QuanlyCoffee
{
    public partial class frmQLBan : Form
    {
        private int username;
        DAO_CTHoadon daoban = new DAO_CTHoadon();
        public frmQLBan()
        {
            InitializeComponent();
        }
        public frmQLBan(int username)
        {
            InitializeComponent();
            this.username = username;
        }
        private Form currentFormChild;
        private void OpenChildForm(Form ChildForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            panel1.Controls.Add(ChildForm);
            panel1.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();


        }
        private void btn1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmOrder(username, 1));
            string a = "Có người";
            if (daoban.checkban(1) == a)
                btn1.BackColor = Color.Red;
            else
                btn1.BackColor = Color.White;


        }

        private void btn2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmOrder(username, 2));
            string a = "Có người";
            if (daoban.checkban(2) == a)
                btn2.BackColor = Color.Red;
            else
                btn2.BackColor = Color.White;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmOrder(username, 3));
            string a = "Có người";
            if (daoban.checkban(3) == a)
                btn3.BackColor = Color.Red;
            else
                btn3.BackColor = Color.White;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmOrder(username, 4));
            string a = "Có người";
            if (daoban.checkban(4) == a)
                btn4.BackColor = Color.Red;
            else
                btn4.BackColor = Color.White;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmOrder(username, 5));
            string a = "Có người";
            if (daoban.checkban(5) == a)
                btn5.BackColor = Color.Red;
            else
                btn5.BackColor = Color.White;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmOrder(username, 6));
            string a = "Có người";
            if (daoban.checkban(6) == a)
                btn6.BackColor = Color.Red;
            else
                btn6.BackColor = Color.White;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmOrder(username, 7));
            string a = "Có người";
            if (daoban.checkban(7) == a)
                btn7.BackColor = Color.Red;
            else
                btn7.BackColor = Color.White;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmOrder(username, 8));
            string a = "Có người";
            if (daoban.checkban(8) == a)
                btn8.BackColor = Color.Red;
            else
                btn8.BackColor = Color.White;
        }

        private void frmQLBan_Load(object sender, EventArgs e)
        {
            string a = "Có người";
            if (daoban.checkban(1) == a)
                btn1.BackColor = Color.Red;
            else
                btn1.BackColor = Color.White;
            if (daoban.checkban(2) == a)
                btn2.BackColor = Color.Red;
            else
                btn2.BackColor = Color.White;
            if (daoban.checkban(3) == a)
                btn3.BackColor = Color.Red;
            else
                btn3.BackColor = Color.White;
            if (daoban.checkban(4) == a)
                btn4.BackColor = Color.Red;
            else
                btn4.BackColor = Color.White;
            if (daoban.checkban(5) == a)
                btn5.BackColor = Color.Red;
            else
                btn5.BackColor = Color.White;
            if (daoban.checkban(6) == a)
                btn6.BackColor = Color.Red;
            else
                btn6.BackColor = Color.White;
            if (daoban.checkban(7) == a)
                btn7.BackColor = Color.Red;
            else
                btn7.BackColor = Color.White;
            if (daoban.checkban(8) == a)
                btn8.BackColor = Color.Red;
            else
                btn8.BackColor = Color.White;
        }
    }
}
