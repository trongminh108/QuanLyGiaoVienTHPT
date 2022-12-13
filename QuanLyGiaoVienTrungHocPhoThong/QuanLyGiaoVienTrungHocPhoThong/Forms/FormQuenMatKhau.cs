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
    public partial class FormQuenMatKhau : Form
    {
        public FormQuenMatKhau()
        {
            InitializeComponent();
        }

        private Modify modify = new Modify();

        private void btnLayLaiMatKhau_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            if (email.Trim() == "")
            {
                (new MessageForm("Nhập lại Email đã đăng ký!", "Thông báo",
                    MessageForm.typeOK, MessageForm.Infor)).ShowDialog();
            }
            else
            {
                string query = "Select * from TaiKhoan where Email = '" + email + "'";
                if (modify.TaiKhoans(query).Count != 0)
                {
                    FormDoiMatKhau dmk = new FormDoiMatKhau();
                    this.Hide();
                    dmk.ShowDialog();
                }
                else
                {
                    (new MessageForm("Email này chưa đăng ký!", "Thông báo",
                    MessageForm.typeOK, MessageForm.Infor)).ShowDialog();
                }
            }
        }
    }
}