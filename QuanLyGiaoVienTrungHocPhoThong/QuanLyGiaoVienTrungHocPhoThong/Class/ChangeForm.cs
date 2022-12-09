using QuanLyGiaoVienTrungHocPhoThong.Forms2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyGiaoVienTrungHocPhoThong.Class
{
    internal class ChangeForm
    {
        public static Panel pnChange;

        public ChangeForm(Panel pn)
        {
            pnChange = pn;
        }

        public static void OpenForm(Form childForm)
        {
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnChange.Controls.Add(childForm);
            pnChange.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
    }
}