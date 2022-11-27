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
        SqlConnection cn = new SqlConnection("Data Source = MSI; Initial Catalog = QLGV; Integrated Security = True");
        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            string mkm, nlmk;
            mkm = txtMKmoi.Text;
            nlmk = txtNhapMKmoi.Text;
            {
                if (mkm == nlmk)
                {
                    if (mkm == "")
                    {
                        MessageBox.Show("Bạn chưa nhập mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (nlmk == "")
                    {
                        MessageBox.Show("Bạn chưa nhập mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        SqlDataAdapter da1 = new SqlDataAdapter("update Taikhoan set Matkhau = N'" + txtMKmoi.Text + "'", cn);
                        DataTable dt1 = new DataTable();
                        da1.Fill(dt1);
                        MessageBox.Show("Đổi mật khẩu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Mật khẩu không chính xác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Focus();
                }
            }
        }
    }
}
