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
    public partial class FormThemThongTinGiaoVien : Form
    {
        public FormThemThongTinGiaoVien()
        {
            InitializeComponent();
            txtMaLop.Enabled = false;
            txtNgayNhanLop.Enabled = false;
            rbtnKhong.Checked = true;
            rbtnNam.Checked = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            foreach (Control con in gpbThongTin1.Controls)
                if (con is TextBox)
                    con.ResetText();
            foreach (Control con in gpbThongTin2.Controls)
                if (con is TextBox)
                    con.ResetText();
        }

        private void btnThemHinhThe_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Title = "Thêm ảnh thẻ";
            openFile.Filter = "JPG|*.jpg|All File|*.*";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                picHinhThe.SizeMode = PictureBoxSizeMode.StretchImage;
                picHinhThe.Image = Image.FromFile(openFile.FileName);
            }
        }

        private string getValue(string s, string c)
        {
            return string.Format("'{0}'", s) + c;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            Modify modify = new Modify();
            string value = "";
            string c = ",";
            value += getValue(txtMaGV.Text, c);
            value += getValue(txtHoten.Text, c);
            //sửa lại thành date time picker - mm/dd/yyyy
            value += getValue(txtNamSinh.Text, c);
            value += getValue(txtBoMon.Text, c);
            if (rbtnNam.Checked)
                value += getValue("Nam", c);
            else
                value += getValue("Nữ", c);
            value += getValue(int.Parse(txtHeSoLuong.Text)*100+"", c);
            value += getValue("null", c);
            value += getValue(txtSDT.Text, c);
            value += getValue(txtEmail.Text, "");
            try
            {
                string query = string.Format(Modify.insert, "giaovien", value);
                modify.Command(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            MessageBox.Show("Insert successful!");
        }

        private void rbtnCo_CheckedChanged(object sender, EventArgs e)
        {
            txtMaLop.Enabled = true;
            txtNgayNhanLop.Enabled = true;
        }

        private void rbtnKhong_CheckedChanged(object sender, EventArgs e)
        {
            txtMaLop.Enabled = false;
            txtNgayNhanLop.Enabled = false;
        }
    }
}
