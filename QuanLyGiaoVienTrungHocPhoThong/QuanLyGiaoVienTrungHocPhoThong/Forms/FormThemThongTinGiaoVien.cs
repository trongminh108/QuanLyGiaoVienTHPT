/**/using QuanLyGiaoVienTrungHocPhoThong.Class;
using QuanLyGiaoVienTrungHocPhoThong.ConnectSQL;
using QuanLyGiaoVienTrungHocPhoThong.ConstraintCheck;
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
using static System.Net.Mime.MediaTypeNames;
using Image = System.Drawing.Image;

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
            picHinhThe.Image = null;
            txtMaGV.Focus();
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
                string maBM = dataBoMon.Rows[cbBoMon.SelectedIndex]["mabomon"].ToString();
                if (!KiemTraThongTin.KiemTraMaGV(txtMaGV.Text, maBM))
                    throw new Exception("Mã giáo viên không hợp lệ, vui lòng nhập lại!\r" +
                        "Mã GV phải bao gồm 1 ký tự và 3 chữ số!\r" +
                        "Mã của giáo viên " + cbBoMon.Text +
                        " phải có kí tự đầu phải là: " + maBM[0]);
                if (!KiemTraThongTin.KiemTraSDT(txtSDT.Text))
                    throw new Exception("Số điện thoại không hợp lệ, vui lòng nhập lại!");
                if (!KiemTraThongTin.KiemTraEmail(txtEmail.Text))
                    throw new Exception("Email không hợp lệ, vui lòng nhập lại!");
                if (!KiemTraThongTin.KiemTraCMND_CCCD(txtCMND.Text))
                    throw new Exception("CMND/CCCD không hợp lệ, vui lòng nhập lại!\r" +
                        "CMND/CCCD phải là dãy số dài từ 9/12 chữ số");
                if (!KiemTraThongTin.KiemTraHSL(txtHeSoLuong.Text, cbHang.Text))
                    throw new Exception("Hệ số lương và hạng GV không hợp lệ!\r" +
                        "GV hạng 1 có HSL từ 4.4 -> 6.78\r" +
                        "GV hạng 2 có HSL từ 4.0 -> 6.38\r " +
                        "GV hạng 3 có HSL từ 2.34 -> 4.38\r");
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
                float hsl = float.Parse(txtHeSoLuong.Text);
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
                    // nếu giáo viên đã giảng dạy lớp
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

                MessageForm msg = new MessageForm("Thêm thành công!", "Thêm giáo viên", MessageForm.typeOK, MessageForm.Infor);
                msg.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageForm msgF = new MessageForm("Thêm GV thất bại!\n" + ex.Message, "Thêm giáo viên", MessageForm.typeOK, MessageForm.Error);
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

        private void cbBoMon_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = cbBoMon.SelectedIndex;
            if (i >= 0)
            {
                if (txtMaGV.Text == "")
                    txtMaGV.Text = dataBoMon.Rows[i][0].ToString()[0] + "";
                else
                {
                    string tmp = txtMaGV.Text;
                    txtMaGV.Text = dataBoMon.Rows[i][0].ToString()[0] + tmp.Substring(1);
                }
            }
        }

        private void cbHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbHang.SelectedIndex == 0)
                txtHeSoLuong.Text = 4.4 + "";
            else if (cbHang.SelectedIndex == 1)
                txtHeSoLuong.Text = 4.0 + "";
            else if (cbHang.SelectedIndex == 2)
                txtHeSoLuong.Text = 2.34 + "";
        }
    }
}