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
            dgvDSGV.ReadOnly = true;
        }

        public string ConvertDate(string date)
        {
            string res = "";
            string[] arr = date.Split('/');
            res = arr[1] + "/" + arr[0] + "/" + arr[2];
            return res;
        }

        private void LoadData()
        {
            string query = "SELECT magv, hoten, " +
                "FORMAT (namsinh, 'dd/MM/yyyy') as date, " +
                "mamon, gioitinh, luong, matruongbm, sdt, email FROM giaovien";
            Modify modify = new Modify();
            DataTable dt = modify.getDataTable(query);
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
