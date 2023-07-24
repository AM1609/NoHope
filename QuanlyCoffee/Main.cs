using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanlyCoffee
{
    public partial class frmMain : Form
    {
        private int username;
        public frmMain()
        {
            InitializeComponent();
        }
        public frmMain(int user)
        {
            InitializeComponent();
            this.username = user;
        }
        private bool CheckExistForm(string name)
        {
            bool check = false;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name == name)
                {
                    check = true;
                    break;
                }
            }
            return check;
        }

        private void ActiveChildForm(string name)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name == name)
                {
                    frm.Activate();
                    break;
                }
            }
        }
        private void CloseChildForm(string name)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name == name)
                {
                    frm.Close();
                    break;
                }
            }
        }
        private Form currentFormChild;
        private void OpenChildForm(Form ChildForm)
        {
            if(currentFormChild!=null)
            {
                currentFormChild.Close();
            }
            currentFormChild = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            panelbody.Controls.Add(ChildForm);
            panelbody.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();


        }
        private void btnsanpham_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmSanpham());
        }

        private void btnThuchi_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmThuchi(username));
        }

        private void btnThanhtoan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmThanhtoan());
        }

        private void btnCa_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmQLca(username));
        }

        private void btnThongke_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmThongke());
        }

        private void btnKho_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmQLKho());
        }

        private void btnNhanvien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmNhanvien());
        }

        private void btnDangxuat_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn đăng xuất ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                this.Close();
                frmLogin login = new frmLogin();
                login.Show();
            }
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmOrder());
        }

        private void btnBan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmQLBan(username));
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if(username!=1)
            {
                btnNhanvien.Enabled= false;
                btnThongke.Enabled = false;
                btnSanpham.Enabled = false;
            }
        }

        
    }
}
