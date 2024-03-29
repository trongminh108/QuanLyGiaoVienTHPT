﻿using QuanLyGiaoVienTrungHocPhoThong.Class;
using QuanLyGiaoVienTrungHocPhoThong.ConnectSQL;
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
            ChangeForm.pnChange = panelDesktopPane;
        }

        //Field
        private Form FormConHienTai;

        private void OpenChildForm(Form childForm)
        {
            if (FormConHienTai != null)
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
            OpenChildForm(new FormDanhSachGiaoVien(lblTitle));
            lblTitle.Text = btnDSGV.Text;
        }

        public void btnThem_Click(object sender, EventArgs e)
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

        private void btnLop_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormLop());
            lblTitle.Text = btnLop.Text;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (FormConHienTai != null)
            {
                FormConHienTai.Close();
            }
            lblTitle.Text = "Trường THPT Long Xuyên";
        }

        private void btnDangXuat_Click_1(object sender, EventArgs e)
        {
            MessageForm msgDangXuat = new MessageForm("Bạn có muốn đăng xuất không?", "Thông báo", "YesNo", MessageForm.Question);
            msgDangXuat.ShowDialog();
            if (msgDangXuat.getAnswer() == DialogResult.Yes)
            {
                this.Hide();
                FormDangNhap fdn = new FormDangNhap();
                fdn.ShowDialog();
                this.Close();
            }
        }

        //Size
        private void FormMain_Resize(object sender, EventArgs e)
        {
            Size FormSize = new Size(1280, 720);
            if (this.Width < FormSize.Width)
                this.Width = FormSize.Width;
            if (this.Height < FormSize.Height)
                this.Height = FormSize.Height;
            panelTitleBar.Width = this.Width - panelMenu.Width;
            lblTitle.Width = panelTitleBar.Width;
            panelMenu.Height = this.Height;
            panelDesktopPane.Width = this.Width - panelMenu.Width;
            panelDesktopPane.Height = this.Height - panelTitleBar.Height;
        }
    }
}