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
        public FormSuaThongTinGiaoVien()
        {
            InitializeComponent();

            dtpNamSinh.Format = DateTimePickerFormat.Custom;
            dtpNamSinh.CustomFormat = " dd/ MM/ yyyy";
        }
    }
}
