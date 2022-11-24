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

        public void Insert_Command(string tableName)
        {
            string values = getValues();
            string query = string.Format(insert, tableName, values);
            modify.Command(query);
        }

        public void Update_Command(string tableName, string key)
        {

        }

        public void Delete_Command(string key)
        {

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

    }
}
