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
        private Panel panelDesktopPane;
        private Label title;
        public FormDanhSachGiaoVien(Panel panel, Label title)
        {
            InitializeComponent();
            dgvDSGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDSGV.ReadOnly = true;
            this.panelDesktopPane = panel;
            this.title = title;
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

        private void dgvDSGV_DoubleClick(object sender, EventArgs e)
        {
            int i = dgvDSGV.SelectedRows[0].Index;
            if (i >= 0 && i < dgvDSGV.RowCount-1)
            {
                FormSuaThongTinGiaoVien childForm = new FormSuaThongTinGiaoVien(i, title);
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                panelDesktopPane.Controls.Add(childForm);
                panelDesktopPane.Tag = childForm;
                childForm.BringToFront();
                childForm.Show();
                this.Close();
            }
        }
    }
}
