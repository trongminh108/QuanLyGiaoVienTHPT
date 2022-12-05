/**/using QuanLyGiaoVienTrungHocPhoThong.ConnectSQL;
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
    public partial class FormThemThongTinGiaoVien : Form
    {
        private DataTable dataBoMon;
        private DataTable dataHang;
        public FormThemThongTinGiaoVien()
        {
            InitializeComponent();
        }

        private void FormThemThongTinGiaoVien_Load(object sender, EventArgs e)
        {
            txtMaGV.Focus();
            txtMaLop.Enabled = false;
            txtNgayNhanLop.Enabled = false;
            rbtnKhong.Checked = true;
            rbtnNam.Checked = true;
            rbtnTBMkhong.Checked = true;

            dtpNgaySinh.Format = DateTimePickerFormat.Custom;
            dtpNgaySinh.CustomFormat = "dd/MM/yyyy";

            dataBoMon = LoadComboBox("bomon", cbBoMon, 1);
            cbBoMon.SelectedIndex = 0;

            dataHang = LoadComboBox("loaigiaovien", cbHang, 0);
            cbHang.SelectedIndex = 0;
        }

        private DataTable LoadComboBox(string tableName, ComboBox cb, int k)
        {
            DataTable data = (new SQLcmd()).Select_Command(tableName);
            for (int i = 0; i < data.Rows.Count; i++)
                cb.Items.Add(data.Rows[i].Field<string>(k));
            return data;
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
            openFile.Filter = "PNG|*.png|JPG|*.jpg|All File (*.*)|*.*";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                picHinhThe.SizeMode = PictureBoxSizeMode.Zoom;
                picHinhThe.Image = Image.FromFile(openFile.FileName);
            }
        }

        public string ConvertDate(string date)
        {
            string res = "";
            string[] arr = date.Split('/');
            res = arr[1] + "/" + arr[0] + "/" + arr[2];
            return res;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            SQLcmd addGV = new SQLcmd();
            addGV.Add(txtMaGV.Text);
            addGV.Add(txtHoten.Text);
            addGV.Add(dataBoMon.Rows[cbBoMon.SelectedIndex].Field<string>(0));
            addGV.Add(cbHang.Text);
            addGV.Add(txtCMND.Text);
            addGV.Add(ConvertDate(dtpNgaySinh.Text));
            if (rbtnNam.Checked)
                addGV.Add("Nam");
            else
                addGV.Add("Nữ");
            
            addGV.Add(txtSDT.Text);
            addGV.Add(txtEmail.Text);
            float hsl;
            bool isNum = float.TryParse(txtHeSoLuong.Text, out hsl);
            if (!isNum)
                hsl = 1;
            addGV.Add((int)(hsl * 1490) + "");
            try
            {
                addGV.Insert_Command("giaovien");
                MessageForm msgF = new MessageForm("Thêm thành công!", "Thêm giáo viên");
                msgF.ShowDialog();
                //MessageBox.Show("Insert successful!");
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
