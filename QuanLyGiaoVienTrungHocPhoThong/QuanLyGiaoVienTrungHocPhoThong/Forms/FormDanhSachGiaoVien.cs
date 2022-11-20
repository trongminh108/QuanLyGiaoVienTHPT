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

namespace QuanLyGiaoVienTrungHocPhoThong.Forms2
{
    public partial class FormDanhSachGiaoVien : Form
    {
        public FormDanhSachGiaoVien()
        {
            InitializeComponent();
            dgvDSGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void LoadData()
        {
            string query = "SELECT * FROM giaovien";
            Modify modify = new Modify();
            dgvDSGV.DataSource = modify.getDataTable(query);
            int numCol = dgvDSGV.ColumnCount;
            string[] dsgv = {"Mã GV", "Họ và tên", "Năm sinh",
            "Mã bộ môn", "Giới tính", "Lương", "Mã TBM", "SĐT", "Email"};
            for (int i = 0; i < numCol; i++)
            {
                dgvDSGV.Columns[i].HeaderText = dsgv[i];
            }
        }

        private void FormDanhSachGiaoVien_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
