using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyGiaoVienTrungHocPhoThong
{
    internal class ChuyenDoiSQLThoiGian
    {
        public String ThoiGian(String Tg)
        {
            //dddd, dd MMMM yyyy
            String s = "27/4/2010";
            s = Tg;
            return s;
            String month;

            int i = s.IndexOf("/");
            int j = s.LastIndexOf("/");

            month = s.Substring(i + 1, j - i - 1);
            MessageBox.Show(month);
        }
    }
}
