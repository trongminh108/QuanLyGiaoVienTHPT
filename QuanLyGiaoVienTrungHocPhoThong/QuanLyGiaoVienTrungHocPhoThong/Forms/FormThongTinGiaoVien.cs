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
        public FormThongTin(int idx)
        {
            InitializeComponent();
            this.idx = idx;
        }

        private void btnTimKiem_Load(object sender, EventArgs e)
        {

        }

        private void FormThongTin_Load(object sender, EventArgs e)
        {
            DataRow dataRow = (new SQLcmd()).Select_Command("giaovien").Rows[idx];
            string[] cols = SQLcmd.columnsGV;
            lblMaGiaoVien.Text = dataRow[0].ToString();
            lblHoTen.Text = dataRow[1].ToString();

            DataRow boMon = (new SQLcmd()).Find_Command("bomon", dataRow[2].ToString()).Rows[0];
            lblBoMon.Text = boMon[1].ToString();

            lblHangGiaoVien.Text = dataRow[cols[3]].ToString();

            lblCMND.Text = dataRow[cols[4]].ToString();

            lblNgaySinh.Text = ((DateTime)dataRow[5]).ToShortDateString();
            lblGioiTinh.Text = dataRow[6].ToString();
            
            lblSDT.Text = dataRow[7].ToString();
            lblEmail.Text = dataRow[8].ToString();

            string luong = dataRow[9].ToString();
            float hsl;
            if (luong != "null")
                hsl = float.Parse(luong) / 1490;
            else
                hsl = (float)3.48;
            lblHSL.Text = hsl.ToString();
        }
    }
}
