using QuanLyGiaoVienTrungHocPhoThong.ConnectSQL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyGiaoVienTrungHocPhoThong.Class
{
    internal class LoadData
    {
        public static DataTable LoadComboBox(string tableName, ComboBox cb, int k)
        {
            DataTable data = (new SQLcmd()).Select_Command(tableName);
            for (int i = 0; i < data.Rows.Count; i++)
                cb.Items.Add(data.Rows[i].Field<string>(k));
            return data;
        }
    }
}