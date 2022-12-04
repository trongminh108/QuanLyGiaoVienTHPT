using QuanLyGiaoVienTrungHocPhoThong.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyGiaoVienTrungHocPhoThong.Forms2
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        //Field
        private Form FormConHienTai;
        private void OpenChildForm(Form childForm)
        {
            if(FormConHienTai != null)
            {
                FormConHienTai.Close();
            }
            FormConHienTai = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktopPane.Controls.Add(childForm);
            panelDesktopPane.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        // Sự kiện
        private void btnDSGV_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormDanhSachGiaoVien(panelDesktopPane, lblTitle));
            lblTitle.Text = btnDSGV.Text;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormThemThongTinGiaoVien());
            lblTitle.Text = btnThem.Text;
        }

        public void btnSua_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormSuaThongTinGiaoVien(0));
            lblTitle.Text = btnSua.Text;
        }

        private void btnThongTinGV_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormThongTin(0));
            lblTitle.Text = btnThongTinGV.Text;
        }

        private void btnBoMon_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormBoMon());
            lblTitle.Text = btnBoMon.Text;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (FormConHienTai != null)
            {
                FormConHienTai.Close();
            }
            lblTitle.Text = "Trường THPT Long Xuyên";
            MessageBox.Show(this.Width + ", " + this.Height);
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult traloi = MessageBox.Show("Bạn có muốn đăng xuất không?", "Thông báo", MessageBoxButtons.YesNo);
            if (traloi == DialogResult.Yes)
            {
                this.Hide();
                FormDangNhap fdn = new FormDangNhap();
                fdn.ShowDialog();
                this.Close();

            }
        }
    }
}
