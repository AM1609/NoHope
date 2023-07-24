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
namespace QuanlyCoffee
{
    public partial class frmLogin : Form
    {
        Connect connect = new Connect();
        public static string ID_USER = "";
        DAO_Nhanvien nv = new DAO_Nhanvien();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        private string GetiD(string username, string pass)
        {
            string idkh = "";
            try
            {
                connect.conn.Open();
                SqlCommand cmd = new SqlCommand("Select Manv,TenDN,MatKhau From NHANVIEN Where TenDN='" + username + "' and MatKhau='" + pass + "'", connect.conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        idkh = dr["MaNV"].ToString();
                    }
                }
            }
            
            //catch (Exception)
            //{
            //    MessageBox.Show("           Lỗi xảy ra khi truy vấn dữ liệu hoặc kết nối với server thất bại !\n                       Xin kiểm tra đường dẫn trong Connect(DAO)");
            //}
            finally
            {
                connect.conn.Close();
            }
            return idkh;
        }
        private void btDangnhap_Click(object sender, EventArgs e)
        {
            ID_USER = GetiD(txtUsername.Text, txtPassword.Text);
            
            if (ID_USER != "")
            {
                frmMain fmain = new frmMain(Convert.ToInt32(ID_USER));
                fmain.Show();
                this.Hide();
                
            }
            else
                MessageBox.Show("Sai tài khoản hoặc mật khẩu");
            
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void cbhienmk_CheckedChanged(object sender, EventArgs e)
        {
            if (cbhienmk.Checked)
            {
                this.txtPassword.PasswordChar = '\0';
            }
            else
                this.txtPassword.PasswordChar = '*';
        }
    }
}
