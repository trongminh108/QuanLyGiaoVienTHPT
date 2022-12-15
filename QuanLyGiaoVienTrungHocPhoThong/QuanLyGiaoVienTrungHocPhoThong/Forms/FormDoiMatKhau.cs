using QuanLyGiaoVienTrungHocPhoThong.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyGiaoVienTrungHocPhoThong.Forms2
{
    public partial class FormDoiMatKhau : Form
    {
        public FormDoiMatKhau()
        {
            InitializeComponent();
        }
        SqlConnection cn = ConnectSQL.Connection.getConnection();
        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            string mkm, nlmk;
            mkm = txtMKmoi.Text;
            nlmk = txtNhapMKmoi.Text;
            {
                if (mkm == nlmk)
                {
                    if (mkm == "" || nlmk == "")
                    {
                        MessageForm msgInfor = new MessageForm("Bạn chưa nhập mật khẩu!", "Thông báo", "OK", MessageForm.Question);
                        msgInfor.ShowDialog();
                    }
                    else
                    {
                        SqlDataAdapter da1 = new SqlDataAdapter("update Taikhoan set Matkhau = N'" + mkm + "'", cn);
                        DataTable dt1 = new DataTable();
                        da1.Fill(dt1);
                        MessageForm msgInfor = new MessageForm("Đổi mật khẩu thành công", "Thông báo", "OK", MessageForm.Question);
                        msgInfor.ShowDialog();
                        this.Close();
                    }
                }
                else
                {
                    MessageForm msgInfor = new MessageForm("Mật khẩu không chính xác!", "Thông báo", "OK", MessageForm.Question);
                    msgInfor.ShowDialog();
                }
            }
        }
    }
}
