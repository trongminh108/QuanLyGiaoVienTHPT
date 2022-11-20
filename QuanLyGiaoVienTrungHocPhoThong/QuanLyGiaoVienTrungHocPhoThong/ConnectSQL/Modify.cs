using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyGiaoVienTrungHocPhoThong.ConnectSQL
{
    internal class Modify
    {
        public static string insert = "INSERT INTO {0} VALUES ({1})";
        SqlCommand command;
        SqlConnection connect;
        DataTable dataTable = new DataTable();

        public Modify() { }

        public void Command(string query)
        {
            using (connect = Connection.getConnection())
            {
                connect.Open();
                command = new SqlCommand(query, connect);
                command.ExecuteNonQuery();
                connect.Close();
            }
        }

        public DataTable getDataTable(string query)
        {
            using (SqlConnection connect = Connection.getConnection())
            {
                connect.Open();
                command = new SqlCommand(query, connect);
                dataTable.Load(command.ExecuteReader());
                return dataTable;
            }
        }
    }
}
