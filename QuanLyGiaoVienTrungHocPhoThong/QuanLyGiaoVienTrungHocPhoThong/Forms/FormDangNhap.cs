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
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
            ReadData();
        }

        private void lblQuenMK_Click(object sender, EventArgs e)
        {
            FormQuenMatKhau qmk = new FormQuenMatKhau();
            qmk.ShowDialog();
        }
        Modify modify = new Modify();
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string tentk = txtTK.Text;
            string matkhau = txtMK.Text;
            if (tentk.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản!");
            }
            else if (matkhau.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!");
            }
            else
            {
                string query = "Select * from Taikhoan where TenTaikhoan='" + tentk + "'and MatKhau='" + matkhau + "'";
                if (modify.TaiKhoans(query).Count != 0)
                {
                    SaveData();
                    this.Hide();
                    FormMain fmn = new FormMain();
                    fmn.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Tên tài khoản hoặc mật khẩu không đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void ReadData()
        {
            if (Properties.Settings.Default.TaiKhoan != string.Empty)
            {
                if (Properties.Settings.Default.GhiNho == "true")
                {
                    txtTK.Text = Properties.Settings.Default.TaiKhoan;
                    txtMK.Text = Properties.Settings.Default.MatKhau;
                    chkGhiNho.Checked = true;
                }
                else
                {
                    txtTK.Focus();
                }
            }
        }

        private void SaveData()
        {
            if (chkGhiNho.Checked)
            {
                Properties.Settings.Default.TaiKhoan = this.txtTK.Text;
                Properties.Settings.Default.MatKhau = this.txtMK.Text;
                Properties.Settings.Default.GhiNho = "true";
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.TaiKhoan = this.txtTK.Text;
                Properties.Settings.Default.MatKhau = "";
                Properties.Settings.Default.GhiNho = "false";
                Properties.Settings.Default.Save();
            }
        }
    }
}
