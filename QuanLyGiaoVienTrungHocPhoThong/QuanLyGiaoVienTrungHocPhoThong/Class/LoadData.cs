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
            {
                cb.Items.Add(data.Rows[i].Field<string>(k));
            }
            return data;
        }

        //Phương thức trả về vị trí của dòng key tại cột k của dataTable
        public static int GetIndex(string key, DataTable data, int k = 0)
        {
            int n = data.Rows.Count;
            for (int i = 0; i < n; i++)
                if (key.Equals(data.Rows[i].Field<string>(k)))
                    return i;
            return -1;
        }
    }
}