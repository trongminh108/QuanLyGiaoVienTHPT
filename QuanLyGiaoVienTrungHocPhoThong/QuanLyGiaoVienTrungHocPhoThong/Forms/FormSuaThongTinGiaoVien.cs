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
    public partial class FormSuaThongTinGiaoVien : Form
    {
        private DataTable dataBoMon;
        private int idx;
        public FormSuaThongTinGiaoVien(int i, Label title)
        {
            InitializeComponent();

            dtpNamSinh.Format = DateTimePickerFormat.Custom;
            dtpNamSinh.CustomFormat = "dd/MM/yyyy";
            LoadComboBoxBoMon();
            cbBoMon.SelectedIndex = 0;
            this.idx = i;
            title.Text = "Sửa thông tin giáo viên";
        }

        private void LoadComboBoxBoMon()
        {
            dataBoMon = (new SQLcmd()).Select_Command("bomon");
            for (int i = 0; i < dataBoMon.Rows.Count; i++)
                cbBoMon.Items.Add(dataBoMon.Rows[i].Field<string>(1));
        }

        public string ConvertDate(string date)
        {
            string res = "";
            string[] arr = date.Split('/');
            res = arr[1] + "/" + arr[0] + "/" + arr[2];
            return res;
        }

        public int getIndexMaBM(string maBM)
        {
            int n = dataBoMon.Rows.Count;
            for (int i = 0; i < n; i++)
                if (maBM.Equals(dataBoMon.Rows[i].Field<string>(0)))
                    return i;
            return -1;
        }

        private void FormSuaThongTinGiaoVien_Load(object sender, EventArgs e)
        {
            DataRow dataRow = (new SQLcmd()).Select_Command("giaovien").Rows[idx];
            string[] cols = SQLcmd.columnsGV;
            txtMaGV.Text = dataRow[cols[0]].ToString();
            txtHoten.Text = dataRow[cols[1]].ToString();
            dtpNamSinh.Value = DateTime.Parse(dataRow[cols[2]].ToString());

            string maBM = dataRow[cols[3]].ToString();
            cbBoMon.SelectedIndex = getIndexMaBM(maBM);

            if (dataRow[cols[4]].ToString().Equals("Nam"))
                rbtnNam.Checked = true;
            else
                rbtnNu.Checked = true;
            float hsl = float.Parse(dataRow[cols[5]].ToString()) / 1490;
            txtHeSoLuong.Text = hsl.ToString();

            txtSDT.Text = dataRow[cols[7]].ToString();
            txtEmail.Text = dataRow[cols[8]].ToString();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            //string mess = "";
            //string[] arr = (new SQLcmd()).getColumnsNames("giaovien");
            //for (int i = 0; i < arr.Length; i++)
            //    mess += arr[i].ToString() + "\n";
            //MessageBox.Show(mess);

            SQLcmd editGV = new SQLcmd();
            editGV.Add(txtMaGV.Text);
            editGV.Add(txtHoten.Text);
            editGV.Add(ConvertDate(dtpNamSinh.Text));
            editGV.Add(dataBoMon.Rows[cbBoMon.SelectedIndex].Field<string>(0));
            if (rbtnNam.Checked)
                editGV.Add("Nam");
            else
                editGV.Add("Nữ");
            float hsl = float.Parse(txtHeSoLuong.Text);
            editGV.Add((int)(hsl * 1490) + "");
            editGV.Add("null");
            editGV.Add(txtSDT.Text);
            editGV.Add(txtEmail.Text);
            try
            {
                editGV.Update_Command("giaovien", txtMaGV.Text);
                MessageBox.Show("Edit successful!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
