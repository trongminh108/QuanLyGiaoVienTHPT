using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyGiaoVienTrungHocPhoThong.Forms
{
    public partial class MessageForm : Form
    {
        public MessageForm(string text, string title)
        {
            InitializeComponent();
            lblMessage.Text = text;
            lblTitle.Text = title;
        }

        private void MessageForm_Load(object sender, EventArgs e)
        {

        }

        private static void ShowMessage(string mess)
        {
            
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
