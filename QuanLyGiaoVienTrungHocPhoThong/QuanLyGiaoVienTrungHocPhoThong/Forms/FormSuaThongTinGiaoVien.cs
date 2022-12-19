using QuanLyGiaoVienTrungHocPhoThong.Class;
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

namespace QuanLyGiaoVienTrungHocPhoThong.Forms2
{
    public partial class FormSuaThongTinGiaoVien : Form
    {
        private DataTable dataBoMon;
        private DataTable dataHang;
        private DataTable dataMaLop;
        private DataTable dataGiaoVien;
        private DataRow dataRow;

        private int idx;
        private string key;

        public FormSuaThongTinGiaoVien(int i, Label title = null)
        {
            InitializeComponent();

            dataBoMon = LoadData.LoadComboBox("bomon", cbBoMon, 1);

            dataHang = LoadData.LoadComboBox("loaigiaovien", cbHang, 0);

            dataMaLop = LoadData.LoadComboBox("lop", cbMaLop, 0);
            cbMaLop.SelectedIndex = 0;

            this.idx = i;
            if (title != null)
                title.Text = "Sửa thông tin giáo viên";

            dataRow = (new SQLcmd()).Select_Command("giaovien").Rows[idx];
            txtMaGV.Focus();

            dataGiaoVien = Class.LoadData.LoadComboBox("giaovien", cbGiaoVien, 0);
            cbGiaoVien.SelectedIndex = idx;
        }

        public string ConvertDate(string date)
        {
            string res = "";
            string[] arr = date.Split('/');
            res = arr[1] + "/" + arr[0] + "/" + arr[2];
            return res;
        }

        private void FormSuaThongTinGiaoVien_Load(object sender, EventArgs e)
        {
            this.key = dataRow[0].ToString();
            txtMaGV.Text = dataRow[0].ToString();
            txtHoten.Text = dataRow[1].ToString();

            string maBM = dataRow[2].ToString();
            cbBoMon.SelectedIndex = Class.LoadData.GetIndex(maBM, dataBoMon);

            cbHang.SelectedIndex = Class.LoadData.GetIndex(dataRow[3].ToString(), dataHang);

            txtCMND.Text = dataRow[4].ToString();

            dtpNgaySinh.Value = DateTime.Parse(dataRow[5].ToString());

            if (dataRow[6].ToString().Equals("Nam"))
                rbtnNam.Checked = true;
            else
                rbtnNu.Checked = true;

            txtSDT.Text = dataRow[7].ToString();
            txtEmail.Text = dataRow[8].ToString();

            string luong = dataRow[9].ToString();
            float hsl;
            if (luong != "")
                hsl = float.Parse(luong) / 1490000;
            else
                hsl = (float)2.48;
            txtHeSoLuong.Text = hsl.ToString();

            DataRow rowBM = (new SQLcmd()).Find_Command("bomon", maBM);
            if (rowBM[2].ToString() == txtMaGV.Text)
                rbtnTBMco.Checked = true;
            else
                rbtnTBMkhong.Checked = true;
            DataRow row = (new SQLcmd()).Find_Command("hinhanh", dataRow[0].ToString());
            if (row != null)
                picHinhThe.Image = LoadImages.ConvertByteArrayToImage((byte[])row[1]);
            else
                picHinhThe.Image = null;

            // Nếu giáo viên là chủ nhiệm
            DataRow rowChuNhiem = (new SQLcmd()).Find_Command("giangday", dataRow[0].ToString());
            if (rowChuNhiem != null)
            {
                rbtnCo.Checked = true;
                cbMaLop.Text = rowChuNhiem[1].ToString();
                dtpNgayNhanLop.Value = DateTime.Parse(rowChuNhiem[2].ToString());
            }
            else
            {
                rbtnKhong.Checked = true;
                cbMaLop.Enabled = false;
                dtpNgayNhanLop.Enabled = false;
                if (rowChuNhiem != null)
                    dtpNgayNhanLop.Value = DateTime.Parse(ConvertDate(rowChuNhiem["ngaynhanlop"].ToString()));
            }
        }

        private void SuaTruongBoMon()
        {
            if (rbtnTBMco.Checked)
            {
                SQLcmd editBM = new SQLcmd();
                string maBM = dataBoMon.Rows
                    [Class.LoadData.GetIndex(cbBoMon.Text, dataBoMon, 1)]["mabomon"].ToString();
                editBM.Add(maBM);
                editBM.Add(cbBoMon.Text);
                editBM.Add(txtMaGV.Text);
                editBM.Update_Command("bomon", maBM);
            }
            else
            {
                DataRow rowBoMon = (new SQLcmd()).Find_Command("bomon", dataRow["mabomon"].ToString());
                if (rowBoMon != null)
                {
                    SQLcmd editBM = new SQLcmd();
                    string maBM = dataBoMon.Rows
                        [Class.LoadData.GetIndex(cbBoMon.Text, dataBoMon, 1)]["mabomon"].ToString();
                    editBM.Add(maBM);
                    editBM.Add(cbBoMon.Text);
                    editBM.Add("null");
                    editBM.Update_Command("bomon", maBM);
                }
            }
        }

        private void SuaChuNhiem()
        {
            if (rbtnCo.Checked)
            {
                // Nếu lớp X đã có chủ nhiệm
                DataRow rowLop = (new SQLcmd()).Find_Command("lop", cbMaLop.Text);
                if (rowLop[1].ToString() != "" && rowLop[1].ToString() != dataRow[0].ToString())
                {
                    MessageForm msg = new MessageForm("Lớp này đang có chủ nhiệm\r" +
                        "Bạn có muốn thay đổi không?", "Thông báo", MessageForm.typeYesNo, MessageForm.Question);
                    msg.ShowDialog();
                    if (msg.getAnswer() == DialogResult.Yes)
                    {
                        //Xóa giảng dạy
                        (new SQLcmd()).Delete_Command("giangday", rowLop["machunhiem"].ToString());
                    }
                    else
                        return;
                }
                //Nếu lớp X chưa có chủ nhiệm
                DataRow rowChuNhiem = (new SQLcmd()).Find_Command("giangday", dataRow[0].ToString());
                SQLcmd editChuNhiem = new SQLcmd();
                editChuNhiem.Add(txtMaGV.Text);
                editChuNhiem.Add(cbMaLop.Text);
                editChuNhiem.Add(ConvertDate(dtpNgayNhanLop.Text));
                if (rowChuNhiem != null)
                {
                    // Nếu giáo viên hiện tại đang là chủ nhiệm
                    editChuNhiem.Update_Command("giangday", rowChuNhiem[0].ToString());
                }
                else
                {
                    //Nếu giáo viên không đang là chủ nhiệm
                    editChuNhiem.Insert_Command("giangday");
                }
                SQLcmd suaLop = new SQLcmd();
                suaLop.Add(cbMaLop.Text);
                suaLop.Add(txtMaGV.Text);
                suaLop.Update_Command("lop", cbMaLop.Text);
                return;
            }
            SQLcmd xoaGiangDay = new SQLcmd();
            xoaGiangDay.Delete_Command("giangday", dataRow[0].ToString());
        }

        private void btnLuu_Click(object sender, EventArgs e)
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
                        "CMND/CCCD phải là dãy số dài 9/12 chữ số");
                if (!KiemTraThongTin.KiemTraHSL(txtHeSoLuong.Text, cbHang.Text))
                    throw new Exception("Hệ số lương và hạng GV không hợp lệ!\r" +
                        "GV hạng 1 có HSL từ 4.4 -> 6.78\r" +
                        "GV hạng 2 có HSL từ 4.0 -> 6.38\r " +
                        "GV hạng 3 có HSL từ 2.34 -> 4.38\r");

                //Sửa tài khoản cho giáo viên
                SQLcmd addTK = new SQLcmd();
                addTK.Add(txtEmail.Text);
                addTK.Add(txtMaGV.Text);
                addTK.Add(txtCMND.Text);
                addTK.Update_Command("taikhoan", dataRow[0].ToString());

                //Sửa giáo viên
                SQLcmd editGV = new SQLcmd();
                editGV.Add(txtMaGV.Text);
                editGV.Add(txtHoten.Text);
                editGV.Add(dataBoMon.Rows[cbBoMon.SelectedIndex][0].ToString());
                editGV.Add(cbHang.Text);
                editGV.Add(txtCMND.Text);
                editGV.Add(ConvertDate(dtpNgaySinh.Text));

                if (rbtnNam.Checked)
                    editGV.Add("Nam");
                else
                    editGV.Add("Nữ");

                editGV.Add(txtSDT.Text);
                editGV.Add(txtEmail.Text);
                float hsl = float.Parse(txtHeSoLuong.Text);
                editGV.Add((int)(hsl * 1490000) + "");
                editGV.Update_Command("giaovien", key);
                SuaTruongBoMon();
                SuaChuNhiem();

                if (picHinhThe.Image != null)
                {
                    (new SQLcmd()).Update_Image(txtMaGV.Text, picHinhThe.Image, "hinhanh");
                }
                MessageForm msgForm = new MessageForm("Sửa Giáo Viên thành công!", "Sửa Giáo Viên", "OK", MessageForm.Infor);
                msgForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageForm msgForm = new MessageForm("Sửa Giáo Viên thất bại!\n" + ex.Message, "Sửa Giáo Viên", "OK", MessageForm.Error);
                msgForm.ShowDialog();
            }
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

        private void CheckChuNhiem()
        {
            if (rbtnCo.Checked)
            {
                cbMaLop.Enabled = true;
                dtpNgayNhanLop.Enabled = true;
            }
        }

        private void rbtnCo_CheckedChanged(object sender, EventArgs e)
        {
            CheckChuNhiem();
        }

        private void rbtnKhong_CheckedChanged(object sender, EventArgs e)
        {
            CheckChuNhiem();
        }

        private void cbGiaoVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = cbGiaoVien.SelectedIndex;
            if (i >= 0)
            {
                dataRow = (new SQLcmd()).Select_Command("giaovien").Rows[i];
                FormSuaThongTinGiaoVien_Load(this, new EventArgs());
            }
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