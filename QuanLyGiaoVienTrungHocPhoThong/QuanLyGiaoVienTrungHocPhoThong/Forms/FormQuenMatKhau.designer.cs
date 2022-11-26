namespace QuanLyGiaoVienTrungHocPhoThong.Forms2
{
    partial class FormQuenMatKhau
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQuenMatKhau));
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnLayLaiMatKhau = new QuanLyGiaoVienTrungHocPhoThong.Customdesign.RoundedButton();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(32, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 22);
            this.label4.TabIndex = 35;
            this.label4.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtEmail.CausesValidation = false;
            this.txtEmail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(124, 66);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(312, 30);
            this.txtEmail.TabIndex = 37;
            // 
            // btnLayLaiMatKhau
            // 
            this.btnLayLaiMatKhau.BackColor = System.Drawing.Color.MediumBlue;
            this.btnLayLaiMatKhau.BackgroundColor = System.Drawing.Color.MediumBlue;
            this.btnLayLaiMatKhau.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnLayLaiMatKhau.BorderRadius = 5;
            this.btnLayLaiMatKhau.BorderSize = 0;
            this.btnLayLaiMatKhau.FlatAppearance.BorderSize = 0;
            this.btnLayLaiMatKhau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLayLaiMatKhau.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLayLaiMatKhau.ForeColor = System.Drawing.Color.Snow;
            this.btnLayLaiMatKhau.Location = new System.Drawing.Point(124, 142);
            this.btnLayLaiMatKhau.Margin = new System.Windows.Forms.Padding(4);
            this.btnLayLaiMatKhau.Name = "btnLayLaiMatKhau";
            this.btnLayLaiMatKhau.Size = new System.Drawing.Size(234, 60);
            this.btnLayLaiMatKhau.TabIndex = 38;
            this.btnLayLaiMatKhau.Text = "Lấy lại mật khẩu";
            this.btnLayLaiMatKhau.TextColor = System.Drawing.Color.Snow;
            this.btnLayLaiMatKhau.UseVisualStyleBackColor = false;
            this.btnLayLaiMatKhau.Click += new System.EventHandler(this.btnLayLaiMatKhau_Click);
            // 
            // FormQuenMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(473, 233);
            this.Controls.Add(this.btnLayLaiMatKhau);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label4);
            this.Name = "FormQuenMatKhau";
            this.Text = "Lấy lại mật khẩu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmail;
        private Customdesign.RoundedButton btnLayLaiMatKhau;
    }
}