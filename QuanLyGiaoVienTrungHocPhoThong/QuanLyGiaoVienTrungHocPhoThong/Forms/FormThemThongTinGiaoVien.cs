/**/using QuanLyGiaoVienTrungHocPhoThong.Class;
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
    public partial class FormThemThongTinGiaoVien : Form
    {
        private DataTable dataBoMon;
        private DataTable dataHang;
        private DataTable dataLop;

        public FormThemThongTinGiaoVien()
        {
            InitializeComponent();
        }

        private void FormThemThongTinGiaoVien_Load(object sender, EventArgs e)
        {
            txtMaGV.Focus();
            cbMaLop.Enabled = false;
            dtpNgayNhanLop.Enabled = false;
            rbtnKhong.Checked = true;
            rbtnNam.Checked = true;
            rbtnTBMkhong.Checked = true;

            dtpNgaySinh.Format = DateTimePickerFormat.Custom;
            dtpNgaySinh.CustomFormat = "dd/MM/yyyy";

            dataBoMon = LoadData.LoadComboBox("bomon", cbBoMon, 1);
            cbBoMon.SelectedIndex = 0;

            dataHang = LoadData.LoadComboBox("loaigiaovien", cbHang, 0);
            cbHang.SelectedIndex = 0;

            dataLop = LoadData.LoadComboBox("lop", cbMaLop, 0);
            cbMaLop.SelectedIndex = 0;
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
            string[] arr = date.Split('/');
            string res = arr[1] + "/" + arr[0] + "/" + arr[2];
            return res;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                //Thêm tài khoản cho giáo viên
                SQLcmd addTK = new SQLcmd();
                addTK.Add(txtEmail.Text);
                addTK.Add(txtMaGV.Text);
                addTK.Add(txtCMND.Text);
                addTK.Insert_Command("taikhoan");

                //Thêm giáo viên
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
                addGV.Add((int)(hsl * 1490000) + "");
                addGV.Insert_Command("giaovien");

                //Thêm ảnh thẻ cho giáo viên
                if (picHinhThe.Image != null)
                {
                    (new SQLcmd()).Insert_Image(txtMaGV.Text, picHinhThe.Image, "hinhanh");
                }

                //Nếu giáo viên có chủ nhiệm sẽ thêm dữ liệu vào bảng giảng dạy
                if (rbtnCo.Checked)
                {
                    SQLcmd addGiangDay = new SQLcmd();
                    addGiangDay.Add(txtMaGV.Text);
                    addGiangDay.Add(cbMaLop.Text);
                    addGiangDay.Add(ConvertDate(dtpNgaySinh.Text));
                    addGiangDay.Insert_Command("giangday");

                    // Thêm thông tin giáo viên
                    SQLcmd addLop = new SQLcmd();
                    addLop.Add(cbMaLop.Text);
                    addLop.Add(txtMaGV.Text);
                    addLop.Update_Command("lop", cbMaLop.Text);
                }
                MessageForm msgF = new MessageForm("Thêm thành công!", "Thêm giáo viên", MessageForm.typeOK);
                msgF.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageForm msgF = new MessageForm("Thêm không thành công!\n" + ex.Message, "Thêm giáo viên", MessageForm.typeOK);
                msgF.ShowDialog();
            }
        }

        private void rbtnCo_CheckedChanged(object sender, EventArgs e)
        {
            cbMaLop.Enabled = true;
            dtpNgayNhanLop.Enabled = true;
        }

        private void rbtnKhong_CheckedChanged(object sender, EventArgs e)
        {
            cbMaLop.Enabled = false;
            dtpNgayNhanLop.Enabled = false;
        }
    }
}