/**/using QuanLyGiaoVienTrungHocPhoThong.ConnectSQL;
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
        private DataTable dataBoMon;
        public FormThemThongTinGiaoVien()
        {
            InitializeComponent();
            txtMaLop.Enabled = false;
            txtNgayNhanLop.Enabled = false;
            rbtnKhong.Checked = true;
            rbtnNam.Checked = true;

            dtpNamSinh.Format = DateTimePickerFormat.Custom;  
            dtpNamSinh.CustomFormat = "dd/MM/yyyy";
            
            LoadComboBoxBoMon();
            cbBoMon.SelectedIndex = 0;
        }

        private void LoadComboBoxBoMon()
        {
            dataBoMon = (new SQLcmd()).Select_Command("bomon");
            for (int i = 0; i < dataBoMon.Rows.Count; i++)
                cbBoMon.Items.Add(dataBoMon.Rows[i].Field<string>(1));
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
            openFile.Filter = "JPG|*.jpg|All File (*.*)|*.*";
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

        public string ConvertDate(string date)
        {
            string res = "";
            string[] arr = date.Split('/');
            res = arr[1] + "/" + arr[0] + "/" + arr[2];
            return res;
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            SQLcmd addGV = new SQLcmd();
            addGV.Add(txtMaGV.Text);
            addGV.Add(txtHoten.Text);
            addGV.Add(ConvertDate(dtpNamSinh.Text));
            addGV.Add(dataBoMon.Rows[cbBoMon.SelectedIndex].Field<string>(0));
            if (rbtnNam.Checked)
                addGV.Add("Nam");
            else
                addGV.Add("Nữ");
            float hsl = float.Parse(txtHeSoLuong.Text);
            addGV.Add((int)(hsl * 1490) + "");
            addGV.Add("null");
            addGV.Add(txtSDT.Text);
            addGV.Add(txtEmail.Text);
            try
            {
                addGV.Insert_Command("giaovien");
                MessageBox.Show("Insert successful!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
