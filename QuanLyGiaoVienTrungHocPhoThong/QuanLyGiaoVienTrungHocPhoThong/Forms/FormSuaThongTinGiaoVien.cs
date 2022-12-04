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
        private DataTable dataHang;
        private int idx;
        private string key;
        public FormSuaThongTinGiaoVien(int i, Label title=null)
        {
            InitializeComponent();

            dtpNgaySinh.Format = DateTimePickerFormat.Custom;
            dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            
            dataBoMon = LoadComboBox("bomon", cbBoMon, 1);

            dataHang = LoadComboBox("loaigiaovien", cbHang, 0);

            this.idx = i;
            if (title != null)
                title.Text = "Sửa thông tin giáo viên";
        }

        private DataTable LoadComboBox(string tableName, ComboBox cb, int k)
        {
            DataTable data = (new SQLcmd()).Select_Command(tableName);
            for (int i = 0; i < data.Rows.Count; i++)
                cb.Items.Add(data.Rows[i].Field<string>(k));
            return data;
        }

        public string ConvertDate(string date)
        {
            string res = "";
            string[] arr = date.Split('/');
            res = arr[1] + "/" + arr[0] + "/" + arr[2];
            return res;
        }

        public int getIndex(string key, DataTable data)
        {
            int n = data.Rows.Count;
            for (int i = 0; i < n; i++)
                if (key.Equals(data.Rows[i].Field<string>(0)))
                    return i;
            return -1;
        }

        private void FormSuaThongTinGiaoVien_Load(object sender, EventArgs e)
        {
            DataRow dataRow = (new SQLcmd()).Select_Command("giaovien").Rows[idx];
            string[] cols = SQLcmd.columnsGV;
            this.key = dataRow[cols[0]].ToString();
            txtMaGV.Text = dataRow[cols[0]].ToString();
            txtHoten.Text = dataRow[cols[1]].ToString();

            string maBM = dataRow[cols[2]].ToString();
            cbBoMon.SelectedIndex = getIndex(maBM, dataBoMon);

            cbHang.SelectedIndex = getIndex(dataRow[cols[3]].ToString(), dataHang);

            txtCMND.Text = dataRow[cols[4]].ToString();

            dtpNgaySinh.Value = DateTime.Parse(dataRow[cols[5]].ToString());

            if (dataRow[cols[6]].ToString().Equals("Nam"))
                rbtnNam.Checked = true;
            else
                rbtnNu.Checked = true;
            
            txtSDT.Text = dataRow[cols[7]].ToString();
            txtEmail.Text = dataRow[cols[8]].ToString();

            
            string luong = dataRow[cols[9]].ToString();
            float hsl;
            if (luong != "null")
                hsl = float.Parse(luong) / 1490;
            else 
                hsl = (float) 2.48;
            txtHeSoLuong.Text = hsl.ToString();

        }

        private void btnLuu_Click(object sender, EventArgs e)
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
            editGV.Add((int)(hsl * 1490) + "");

            try
            {
                editGV.Update_Command("giaovien", key);
                MessageBox.Show("Edit successful!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
    }
}
