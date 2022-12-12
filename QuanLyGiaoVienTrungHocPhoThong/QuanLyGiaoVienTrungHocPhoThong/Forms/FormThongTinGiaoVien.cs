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

namespace QuanLyGiaoVienTrungHocPhoThong.Forms2
{
    public partial class FormThongTin : Form
    {
        private int idx;
        private DataRow dataRow;

        public FormThongTin(int idx)
        {
            InitializeComponent();
            this.idx = idx;
        }

        private void FormThongTin_Load(object sender, EventArgs e)
        {
            DeleteAll();
            txtThongTinGV.Focus();
        }

        private void DeleteAll()
        {
            lblMaGiaoVien.Text = "";
            lblHoTen.Text = "";
            lblCMND.Text = "";
            lblNgaySinh.Text = "";
            lblGioiTinh.Text = "";
            lblSDT.Text = "";
            lblEmail.Text = "";
            lblBoMon.Text = "";
            lblHangGiaoVien.Text = "";
            lblHSL.Text = "";
            lblChuNhiem.Text = "";
            lblMaLop.Text = "";
            lblNgayNhanLop.Text = "";
        }

        private void LoadData()
        {
            lblMaGiaoVien.Text = dataRow[0].ToString();
            lblHoTen.Text = dataRow[1].ToString();

            DataRow boMon = (new SQLcmd()).Find_Command("bomon", dataRow[2].ToString());
            lblBoMon.Text = boMon[1].ToString();

            lblHangGiaoVien.Text = dataRow[3].ToString();

            lblCMND.Text = dataRow[4].ToString();

            lblNgaySinh.Text = ((DateTime)dataRow[5]).ToShortDateString();
            lblGioiTinh.Text = dataRow[6].ToString();

            lblSDT.Text = dataRow[7].ToString();
            lblEmail.Text = dataRow[8].ToString();

            string luong = dataRow[9].ToString();
            float hsl;
            if (luong != "")
                hsl = float.Parse(luong) / 1490000;
            else
                hsl = (float)3.48;
            lblHSL.Text = hsl.ToString();
            DataRow row = (new SQLcmd()).Find_Command("hinhanh", dataRow[0].ToString());
            if (row != null)
                picHinhThe.Image = LoadImages.ConvertByteArrayToImage((byte[])row[1]);
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            if (txtThongTinGV.Text != "")
            {
                try
                {
                    string key = txtThongTinGV.Text.ToUpper();
                    dataRow = (new SQLcmd()).Find_Command("giaovien", key);
                    if (dataRow != null)
                    {
                        LoadData();
                        txtThongTinGV.ResetText();
                    }
                    else
                    {
                        DeleteAll();
                    }
                }
                catch (Exception ex)
                {
                    DeleteAll();
                }
            }
        }

        private void txtThongTinGV_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnTK_Click(btnTK, new EventArgs());
                txtThongTinGV.Text = "";
            }
        }
    }
}