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
    public partial class FormQuenMatKhau : Form
    {
        public FormQuenMatKhau()
        {
            InitializeComponent();
        }
        Modify modify = new Modify();
        private void btnLayLaiMatKhau_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            if(email.Trim() == "")
            {
                MessageBox.Show("Nhập lại Email đã đăng ký!");
            }
            else
            {
                string query = "Select * from TaiKhoan where Email = '" + email + "'";
                if(modify.TaiKhoans(query).Count != 0)
                {
                    MessageBox.Show("Bạn đã đăng nhập Email thành công");
                    FormDoiMatKhau dmk = new FormDoiMatKhau();
                    dmk.ShowDialog();
                }   
                else
                {
                    MessageBox.Show("Email này chưa đăng ký!");
                }    
            }
        }
    }
}
