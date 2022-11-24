using QuanLyGiaoVienTrungHocPhoThong.ConnectSQL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyGiaoVienTrungHocPhoThong
{
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
        }

        private void Test_Load(object sender, EventArgs e)
        {
            Modify modify = new Modify();
            string query = string.Format(Modify.select, "bomon");
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.DataSource = modify.getDataTable(query);
            DataTable dt = (new Modify()).getDataTable(query);

            label1.Text = "";
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                label1.Text += dt.Rows[i].Field<string>(1) + "\n";
            }
            label1.Text += dt.Rows.Count;
        }
    }
}
