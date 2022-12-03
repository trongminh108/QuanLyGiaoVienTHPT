using QuanLyGiaoVienTrungHocPhoThong.Class;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyGiaoVienTrungHocPhoThong.ConnectSQL
{
    internal class SQLcmd
    {
        private List<string> col;
        private string insert = "INSERT INTO {0} VALUES ({1})";
        private string select = "SELECT * FROM {0}";
        private string update = "UPDATE {0} SET {1} WHERE {2}";
        private string delete = "DELETE FROM {0} WHERE {1}";
        public static string[] columnsGV = { "magiaovien", "hoten", "mabomon", "loaigiaovien", "cmnd_cccd", 
            "ngaysinh", "gioitinh", "sdt", "email", "luong" };

        Modify modify;
        public SQLcmd()
        {
            col = new List<string>();
            modify = new Modify();
        }

        private string getValues()
        {
            string res = "";
            for (int i = 0; i < col.Count-1; i++)
                res += string.Format("N'{0}',", col[i].ToString());
            if (col.Count > 0)
                res += string.Format("N'{0}'", col[col.Count-1].ToString());
            return res;
        }

        public void Add(string s)
        {
            col.Add(s);
        }

        private void Add(GiaoVien gv)
        {
            col.Add(gv.MaGV);
            col.Add(gv.HoTen);
            col.Add(gv.NamSinh);
            col.Add(gv.MaMon);
            col.Add(gv.GioiTinh);
            col.Add(gv.Luong);
            col.Add(gv.MaTruongBM);
            col.Add(gv.Sdt);
            col.Add(gv.Email);
        }

        public void Insert_Command(string tableName)
        {
            string values = getValues();
            string query = string.Format(insert, tableName, values);
            modify.Command(query);
        }

        public void Delete_Command(string key)
        {
            string query = string.Format(delete, key);
            modify.Command(query);
        }

        public DataTable Select_Command(string tableName)
        {
            string query = string.Format(select, tableName);
            try
            {
                return modify.getDataTable(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return (new DataTable());
            }
        }

        public string[] getColumnsNames(string tableName)
        {
            DataTable dt = this.Select_Command(tableName);
            string[] res = new string[dt.Columns.Count];
            for (int i = 0; i < dt.Columns.Count; i++)
                res[i] = dt.Columns[i].ColumnName.ToString();
            return res;
        }

        public string getUpdateValues(string tableName)
        {
            string res = "";
            string[] columns = getColumnsNames(tableName);
            string set = "{0} = N'{1}'";
            for (int i = 0; i < columns.Length - 1; i++)
                res += string.Format(set, columns[i], col[i]) + ",";
            if (col.Count > 0)
                res += string.Format(set, columns[columns.Length-1], col[columns.Length - 1]);
            return res;
        }

        public void Update_Command(string tableName, string key)
        {
            string values = getUpdateValues(tableName);
            string query = string.Format(update, tableName, values, string.Format("magv='{0}'", key));
            modify.Command(query);
        }

    }
}
