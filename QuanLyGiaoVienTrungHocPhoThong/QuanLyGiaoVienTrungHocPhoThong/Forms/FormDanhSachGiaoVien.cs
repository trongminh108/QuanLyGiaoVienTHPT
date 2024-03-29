﻿using QuanLyGiaoVienTrungHocPhoThong.Class;
using QuanLyGiaoVienTrungHocPhoThong.ConnectSQL;
using QuanLyGiaoVienTrungHocPhoThong.Forms;
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
        private Label title;

        public FormDanhSachGiaoVien(Label title)
        {
            InitializeComponent();

            dgvDSGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDSGV.ReadOnly = true;
            this.title = title;
        }

        public void LoadDataByKeywords()
        {
            Modify modify = new Modify();
            string query = string.Format(@"SELECT * FROM GiaoVien WHERE hoten like N'%{0}%'", txtTimKiem.Text);
            dgvDSGV.DataSource = modify.getDataTable(query);
        }

        private void LoadData()
        {
            Modify modify = new Modify();
            string query = "SELECT gv.magiaovien, gv.hoten, bm.tenbomon," +
            "gv.loaigiaovien, FORMAT (gv.ngaysinh, 'dd/MM/yyyy') as NgaySinh," +
            "sdt, email, luong FROM GiaoVien gv, BoMon bm " +
            "WHERE gv.mabomon = bm.mabomon";

            string[] dsgv = {"Mã GV", "Họ Tên GV", "Bộ Môn", "Hạng GV", "Ngày Sinh",
                "SĐT", "Email", "Lương"};

            double[] ratio = { 0.1, 0.18, 0.1, 0.1, 0.1, 0.1, 0.2, 0.1 };
            dgvDSGV.DataSource = modify.getDataTable(query);
            int width = dgvDSGV.Width;
            int numCol = dgvDSGV.ColumnCount;
            for (int i = 0; i < numCol; i++)
            {
                dgvDSGV.Columns[i].HeaderText = dsgv[i];
                dgvDSGV.Columns[i].Width = (int)(ratio[i] * width);
            }
        }

        private void FormDanhSachGiaoVien_Load(object sender, EventArgs e)
        {
            LoadData();
            foreach (DataGridViewColumn c in dgvDSGV.Columns)
            {
                c.DefaultCellStyle.Font = new Font("Times New Romain", 12.25F, GraphicsUnit.Pixel);
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "")
                dgvDSGV.DataSource = (new SQLcmd()).Select_Command("giaovien");
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (txtTimKiem.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập ký tự!", "Thông báo");
            }
            else
            {
                dgvDSGV.DataSource = (new SQLcmd()).Select_Command("giaovien");
                LoadDataByKeywords();
            }
        }

        private void txtTimKiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtTimKiem.Text.Trim() != "")
            {
                btnTimKiem_Click(btnTimKiem, new EventArgs());
            }
        }

        private void btnThemGV_Click(object sender, EventArgs e)
        {
            ChangeForm.OpenForm(new FormThemThongTinGiaoVien());
            this.Close();
        }

        private void btnXoaGV_Click(object sender, EventArgs e)
        {
            int i = dgvDSGV.SelectedRows[0].Index;
            if (i >= 0 && i < dgvDSGV.RowCount - 1)
            {
                MessageForm msgForm = new MessageForm("Bạn chắc chắn xóa Giáo Viên này không?", "Thông tin", "YesNo", MessageForm.Question);
                msgForm.ShowDialog();
                if (msgForm.getAnswer() == DialogResult.Yes)
                {
                    try
                    {
                        string key = dgvDSGV.Rows[i].Cells[0].Value.ToString();
                        (new SQLcmd()).Delete_Command("giaovien", key);
                        (new SQLcmd()).Delete_Command("taikhoan", dgvDSGV.Rows[i].Cells["email"].Value.ToString());
                        (new SQLcmd()).Delete_Command("hinhanh", key);
                        MessageForm msgFormDel = new MessageForm("Xóa thành công Giáo Viên: " + dgvDSGV.Rows[i].Cells[1].Value.ToString(), "Thông tin", "OK", MessageForm.Infor);
                        msgFormDel.ShowDialog();
                        LoadData();
                    }
                    catch (Exception ex)
                    {
                        MessageForm msgFormDel = new MessageForm("Xóa thất bại Giáo Viên: "
                            + dgvDSGV.Rows[i].Cells[1].Value.ToString() + "!\n" +
                            "do giáo viên này đang là chủ nhiệm, bạn có muốn tiếp tục xóa không?", "Thông tin", MessageForm.typeYesNo, MessageForm.Error);
                        msgFormDel.ShowDialog();
                        if (msgFormDel.getAnswer() == DialogResult.Yes)
                        {
                            ChangeForm.OpenForm(new FormSuaThongTinGiaoVien(i, title));
                            this.Close();
                        }
                    }
                }
            }
            else
            {
                MessageForm msgForm = new MessageForm("Bạn cần chọn GV cần xóa!", "Thông tin", "OK", MessageForm.Infor);
                msgForm.ShowDialog();
            }
        }

        private void btnSuaGV_Click(object sender, EventArgs e)
        {
            int i = dgvDSGV.SelectedRows[0].Index;
            if (i >= 0 && i < dgvDSGV.RowCount - 1)
            {
                ChangeForm.OpenForm(new FormSuaThongTinGiaoVien(i, title));
                this.Close();
            }
            else
            {
                MessageForm msgForm = new MessageForm("Bạn cần chọn GV cần sửa!", "Thông tin", "OK", MessageForm.Infor);
                msgForm.ShowDialog();
            }
        }

        private void dgvDSGV_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                btnSuaGV_Click(sender, new EventArgs());
        }

        private void dgvDSGV_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                btnXoaGV_Click(sender, new EventArgs());
                ChangeForm.OpenForm(new FormDanhSachGiaoVien(title));
                this.Close();
            }
        }

        private void FormDanhSachGiaoVien_Resize(object sender, EventArgs e)
        {
            dgvDSGV.Width = this.Width - 50;
            dgvDSGV.Height = this.Height - 50 - dgvDSGV.Location.Y;
            FormDanhSachGiaoVien_Load(sender, new EventArgs());
        }
    }
}