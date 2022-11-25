using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;// tai khoan
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyGiaoVienTrungHocPhoThong.ConnectSQL
{
    internal class Modify
    {
        public static string insert = "INSERT INTO {0} VALUES ({1})";
        public static string select = "SELECT * FROM {0}";
        SqlCommand command;
        DataTable dataTable = new DataTable();

        public Modify() 
        {
        }
        SqlCommand sqlCommand; // đùng để truy vấn các câu lệnh insert, update, delet,...
        SqlDataReader dataReader; // dùng để đọc dử liệu trong bảng

        public List<TaiKhoan> TaiKhoans(string query)
        {
            List<TaiKhoan> taiKhoans = new List<TaiKhoan>();

            using (SqlConnection sqlConnection = Connection.getConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    taiKhoans.Add(new TaiKhoan(dataReader.GetString(0), dataReader.GetString(1)));
                }
                sqlConnection.Close();

            }
            return taiKhoans;
        }       

        public void Command(string query)
        {
            using (SqlConnection connect = Connection.getConnection())
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
