using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAO
{
    public class Connect
    {
        public SqlConnection conn = new SqlConnection(@"Data Source=DOANH-PC\SQLEXPRESS;Initial Catalog=QLCoffeeWF;Integrated Security=True");
    }
}
//đường dẫn ở phẩn Connection String ở Properties của database và hãy xóa những khoảng trắng trong đường dẫn
//Tài khoản :Lu
//Mật khẩu :1

