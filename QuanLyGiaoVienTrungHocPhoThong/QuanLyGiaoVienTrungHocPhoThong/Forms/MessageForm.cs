using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyGiaoVienTrungHocPhoThong.Forms
{
    public partial class MessageForm : Form
    {
        private DialogResult answer;
        private string type;

        public static string typeOK = "OK";
        public static string typeYesNo = "YesNo";

        public MessageForm(string text, string title, string type)
        {
            InitializeComponent();
            lblMessage.Text = text;
            lblTitle.Text = title;
            this.type = type;
            if (type == "YesNo")
            {
                btnOK.Enabled = false;
                btnOK.Visible = false;
            }
            else
            {
                btnYes.Enabled = false;
                btnNo.Enabled = false;
                btnYes.Visible = false;
                btnNo.Visible = false;
            }
        }

        private void MessageForm_Load(object sender, EventArgs e)
        {
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            answer = DialogResult.OK;
            this.Close();
        }

        public DialogResult getAnswer()
        {
            return answer;
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            answer = DialogResult.Yes;
            this.Close();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            answer = DialogResult.No;
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            answer = DialogResult.OK;
            this.Close();
        }
    }
}