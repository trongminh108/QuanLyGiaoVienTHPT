﻿using QuanLyGiaoVienTrungHocPhoThong.ConnectSQL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyGiaoVienTrungHocPhoThong.Forms
{
    public partial class FormLop : Form
    {
        private DataTable dataGiaoVien;
        public FormLop()
        {
            InitializeComponent();
            dgvLop.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLop.ReadOnly = true;
            dataGiaoVien = Class.LoadData.LoadComboBox("giaovien", cbMaChuNhiem, 0);
        }

        // Load dữ liệu
        public void LoadData()
        {
            string[] colNames = { "Lớp", "Mã chủ nhiệm"};
            double[] colSize = { 0.3, 0.4};
            int width = dgvLop.Width;
            dgvLop.DataSource = (new SQLcmd()).Select_Command("lop");
            for (int i = 0; i < dgvLop.Columns.Count; i++)
            {
                dgvLop.Columns[i].Width = (int)(width * colSize[i]);
                dgvLop.Columns[i].HeaderText = colNames[i];
            }
        }

        private void FormLop_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        // Sự kiện
        private void btnThemLop_Click(object sender, EventArgs e)
        {
            if (txtLop.Text != "" || cbMaChuNhiem.Text != "")
            {
                MessageForm msgInfor = new MessageForm("Bạn có muốn thêm lớp này không?", "Thông báo", "YesNo", MessageForm.Question);
                msgInfor.ShowDialog();
                if (msgInfor.getAnswer() == DialogResult.Yes)
                {
                    SQLcmd addLop = new SQLcmd();
                    addLop.Add(txtLop.Text);
                    addLop.Add(cbMaChuNhiem.Text);
                    try
                    {
                        addLop.Insert_Command("lop");
                        MessageForm msgForm = new MessageForm("Thêm lớp thành công!", "Thêm lớp", "OK", MessageForm.Infor);
                        msgForm.ShowDialog();
                        LoadData();
                    }
                    catch (Exception ex)
                    {
                        MessageForm msgForm = new MessageForm("Thêm lớp thất bại!\n" + ex.Message, "Thêm lớp", "OK", MessageForm.Error);
                       msgForm.ShowDialog();
                    }
                }
            }
            else
            {
                MessageForm msgInfor = new MessageForm("Nhập lại lớp vì nó rỗng!", "Thông báo", "OK", MessageForm.Question);
                msgInfor.ShowDialog();
            }
        }

        private void btnCapNhatLop_Click(object sender, EventArgs e)
        {
            if (txtLop.Text != "" || cbMaChuNhiem.Text != "")
            {
                MessageForm msgInfor = new MessageForm("Bạn có muốn sửa lớp này không?", "Thông báo", "YesNo", MessageForm.Question);
                msgInfor.ShowDialog();
                if (msgInfor.getAnswer() == DialogResult.Yes)
                {
                    int i = dgvLop.SelectedRows[0].Index;
                    if (i >= 0 && i < dgvLop.RowCount - 1)
                    {
                        SQLcmd editLop = new SQLcmd();
                        editLop.Add(txtLop.Text);
                        editLop.Add(cbMaChuNhiem.Text);
                        try
                        {
                            editLop.Update_Command("lop", dgvLop[0, i].Value.ToString());
                            MessageForm msgForm = new MessageForm("Sửa lớp thành công!", "Sửa lớp", "OK", MessageForm.Infor);
                            msgForm.ShowDialog();
                            LoadData();
                        }
                        catch (Exception ex)
                        {
                            MessageForm msgForm = new MessageForm("Sửa lớp thất bại!\n" + ex.Message, "Sửa lớp", "OK", MessageForm.Error);
                            msgForm.ShowDialog();
                        }
                    }
                }
            }
            else
            {
                MessageForm msgInfor = new MessageForm("Nhập lại lớp vì nó rỗng!", "Thông báo", "OK", MessageForm.Question);
                msgInfor.ShowDialog();
            }
        }

        private void btnXoaLop_Click(object sender, EventArgs e)
        {
            MessageForm msgInfor = new MessageForm("Bạn có muốn xóa lớp này không?", "Thông báo", "YesNo", MessageForm.Question);
            msgInfor.ShowDialog();
            if (msgInfor.getAnswer() == DialogResult.Yes)
            {
                int i = dgvLop.SelectedRows[0].Index;
                try
                {
                    (new SQLcmd()).Delete_Command("lop", dgvLop[0, i].Value.ToString());
                    LoadData();
                }
                catch (Exception ex)
                {
                    string mess = @"Xóa lớp {0} thất bại do còn giáo viên dạy môn {0}";
                    MessageForm msgForm = new MessageForm(string.Format(mess, dgvLop[1, i].Value), "Xóa lớp", "OK", MessageForm.Error);
                    msgForm.ShowDialog();
                }
            }
        }

        private void dgvLop_MouseDoubleClick(object sender, MouseEventArgs e)
        {
                if (e.Button == MouseButtons.Left)
                {
                    int i = dgvLop.SelectedRows[0].Index;
                    if (i >= 0 && i < dgvLop.RowCount - 1)
                    {
                        txtLop.Text = dgvLop[0, i].Value.ToString();
                    }
                }
        }
    }
}
