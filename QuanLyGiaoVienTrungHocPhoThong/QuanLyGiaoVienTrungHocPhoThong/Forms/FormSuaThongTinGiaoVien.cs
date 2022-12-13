using QuanLyGiaoVienTrungHocPhoThong.Class;
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
    public partial class FormSuaThongTinGiaoVien : Form
    {
        private DataTable dataBoMon;
        private DataTable dataHang;
        private DataTable dataMaLop;
        private DataRow dataRow;

        private int idx;
        private string key;

        public FormSuaThongTinGiaoVien(int i, Label title = null)
        {
            InitializeComponent();

            dtpNgaySinh.Format = DateTimePickerFormat.Custom;
            dtpNgaySinh.CustomFormat = "dd/MM/yyyy";

            dataBoMon = LoadData.LoadComboBox("bomon", cbBoMon, 1);

            dataHang = LoadData.LoadComboBox("loaigiaovien", cbHang, 0);

            dataMaLop = LoadData.LoadComboBox("lop", cbMaLop, 0);
            cbMaLop.SelectedIndex = 0;

            this.idx = i;
            if (title != null)
                title.Text = "Sửa thông tin giáo viên";

            dataRow = (new SQLcmd()).Select_Command("giaovien").Rows[idx];
            txtMaGV.Focus();
        }

        public string ConvertDate(string date)
        {
            string res = "";
            string[] arr = date.Split('/');
            res = arr[1] + "/" + arr[0] + "/" + arr[2];
            return res;
        }

        public int getIndex(string key, DataTable data, int k = 0)
        {
            int n = data.Rows.Count;
            for (int i = 0; i < n; i++)
                if (key.Equals(data.Rows[i].Field<string>(k)))
                    return i;
            return -1;
        }

        private void FormSuaThongTinGiaoVien_Load(object sender, EventArgs e)
        {
            this.key = dataRow[0].ToString();
            txtMaGV.Text = dataRow[0].ToString();
            txtHoten.Text = dataRow[1].ToString();

            string maBM = dataRow[2].ToString();
            cbBoMon.SelectedIndex = getIndex(maBM, dataBoMon);

            cbHang.SelectedIndex = getIndex(dataRow[3].ToString(), dataHang);

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
                    [getIndex(cbBoMon.Text, dataBoMon, 1)]["mabomon"].ToString();
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
                        [getIndex(cbBoMon.Text, dataBoMon, 1)]["mabomon"].ToString();
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
                    MessageForm msg = new MessageForm("Lớp này đang có chủ nhiệm\r\nBạn có muốn thay đổi không?", "Thông báo", MessageForm.typeYesNo);
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
                SQLcmd editGV = new SQLcmd();
                editGV.Add(txtMaGV.Text);
                editGV.Add(txtHoten.Text);
                editGV.Add(dataBoMon.Rows[cbBoMon.SelectedIndex].Field<string>(0));
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
                MessageForm msgForm = new MessageForm("Sửa Giáo Viên thành công!", "Sửa Giáo Viên", "OK");
                msgForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageForm msgForm = new MessageForm("Sửa Giáo Viên thất bại!\n" + ex.Message, "Sửa Giáo Viên", "OK");
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
    }
}