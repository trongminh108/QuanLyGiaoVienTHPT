using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyGiaoVienTrungHocPhoThong.ConnectSQL
{
    internal class Connection
    {
        private static string stringConnection =
            "Data Source=TRONGMINH;Initial Catalog=QLGV;Integrated Security=True";
        public static SqlConnection getConnection()
        {
            return new SqlConnection(stringConnection);
        }
    }
}
