using QuanLyGiaoVienTrungHocPhoThong.Class;
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

namespace QuanLyGiaoVienTrungHocPhoThong.Forms
{
    public partial class FormBoMon : Form
    {
        private DataTable dataGiaoVien;

        public FormBoMon()
        {
            InitializeComponent();
            dgvBoMon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBoMon.ReadOnly = true;
            dataGiaoVien = Class.LoadData.LoadComboBox("giaovien", cbMaTruongBoMon, 0);
        }

        public void LoadData()
        {
            string[] colNames = { "Mã BM", "Tên Bộ Môn", "Trưởng Bộ Môn" };
            double[] colSize = { 0.2, 0.31, 0.4 };
            int width = dgvBoMon.Width;
            dgvBoMon.DataSource = (new SQLcmd()).Select_Command("bomon");
            for (int i = 0; i < dgvBoMon.Columns.Count; i++)
            {
                dgvBoMon.Columns[i].Width = (int)(width * colSize[i]);
                dgvBoMon.Columns[i].HeaderText = colNames[i];
            }
        }

        private void FormBoMon_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvBoMon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int i = dgvBoMon.SelectedRows[0].Index;
                if (i >= 0 && i < dgvBoMon.RowCount - 1)
                {
                    txtMaBoMon.Text = dgvBoMon[0, i].Value.ToString();
                    txtBoMon.Text = dgvBoMon[1, i].Value.ToString();
                    cbMaTruongBoMon.Text = dgvBoMon[2, i].Value.ToString();
                }
            }
        }

        private void btnThemBoMon_Click(object sender, EventArgs e)
        {
            if (txtMaBoMon.Text != "" && txtBoMon.Text != "" && cbMaTruongBoMon.Text != "")
            {
                MessageForm msgInfor = new MessageForm("Bạn có muốn thêm bộ môn này không?", "Thông báo", "YesNo", MessageForm.Question);
                msgInfor.ShowDialog();
                if (msgInfor.getAnswer() == DialogResult.Yes)
                {
                    SQLcmd addBoMon = new SQLcmd();
                    addBoMon.Add(txtMaBoMon.Text);
                    addBoMon.Add(txtBoMon.Text);
                    addBoMon.Add(cbMaTruongBoMon.Text);
                    try
                    {
                        addBoMon.Insert_Command("bomon");
                        MessageForm msgForm = new MessageForm("Thêm bộ môn thành công!", "Thêm bộ môn", "OK", MessageForm.Infor);
                        msgForm.ShowDialog();
                        LoadData();
                    }
                    catch (Exception ex)
                    {
                        MessageForm msgForm = new MessageForm("Thêm bộ môn thất bại!\n" + ex.Message, "Thêm bộ môn", "OK", MessageForm.Error);
                        msgForm.ShowDialog();
                    }
                }
            }
        }

        private void btnCapNhatBoMon_Click(object sender, EventArgs e)
        {
            if (txtMaBoMon.Text != "" && txtBoMon.Text != "" && cbMaTruongBoMon.Text != "")
            {
                MessageForm msgInfor = new MessageForm("Bạn có muốn sửa bộ môn này không?", "Thông báo", "YesNo", MessageForm.Question);
                msgInfor.ShowDialog();
                if (msgInfor.getAnswer() == DialogResult.Yes)
                {
                    int i = dgvBoMon.SelectedRows[0].Index;
                    if (i >= 0 && i < dgvBoMon.RowCount - 1)
                    {
                        SQLcmd editBoMon = new SQLcmd();
                        editBoMon.Add(dgvBoMon[0, i].Value.ToString());
                        editBoMon.Add(dgvBoMon[1, i].Value.ToString());
                        editBoMon.Add(cbMaTruongBoMon.Text);
                        try
                        {
                            editBoMon.Update_Command("bomon", dgvBoMon[0, i].Value.ToString());
                            MessageForm msgForm = new MessageForm("Sửa bộ môn thành công!", "Sửa bộ môn", "OK", MessageForm.Infor);
                            msgForm.ShowDialog();
                            LoadData();
                        }
                        catch (Exception ex)
                        {
                            MessageForm msgForm = new MessageForm("Sửa bộ môn thất bại!\n" + ex.Message, "Sửa bộ môn", "OK", MessageForm.Error);
                            msgForm.ShowDialog();
                        }
                    }
                }
            }
        }

        private void btnXoaBoMon_Click(object sender, EventArgs e)
        {
            MessageForm msgInfor = new MessageForm("Bạn có muốn xóa bộ môn này không?", "Thông báo", "YesNo", MessageForm.Question);
            msgInfor.ShowDialog();
            if (msgInfor.getAnswer() == DialogResult.Yes)
            {
                int i = dgvBoMon.SelectedRows[0].Index;
                try
                {
                    (new SQLcmd()).Delete_Command("bomon", dgvBoMon[0, i].Value.ToString());
                    LoadData();
                }
                catch (Exception ex)
                {
                    string mess = @"Xóa bộ môn {0} thất bại do còn giáo viên dạy môn {0}";
                    MessageForm msgForm = new MessageForm(string.Format(mess, dgvBoMon[1, i].Value), "Xóa bộ môn", "OK", MessageForm.Error);
                    msgForm.ShowDialog();
                }
            }
        }

        private void dgvBoMon_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                btnXoaBoMon_Click(sender, new EventArgs());
                ChangeForm.OpenForm(new FormBoMon());
                this.Close();
            }
        }
    }
}