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
        public FormSuaThongTinGiaoVien()
        {
            InitializeComponent();

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
    }
}
