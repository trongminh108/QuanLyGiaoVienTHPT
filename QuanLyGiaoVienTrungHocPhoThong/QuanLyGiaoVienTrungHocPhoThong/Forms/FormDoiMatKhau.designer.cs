namespace QuanLyGiaoVienTrungHocPhoThong.Forms2
{
    partial class FormDoiMatKhau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDoiMatKhau));
            this.txtNhapMKmoi = new System.Windows.Forms.TextBox();
            this.txtMKmoi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDoiMK = new QuanLyGiaoVienTrungHocPhoThong.Customdesign.RoundedButton();
            this.SuspendLayout();
            // 
            // txtNhapMKmoi
            // 
            this.txtNhapMKmoi.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtNhapMKmoi.CausesValidation = false;
            this.txtNhapMKmoi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhapMKmoi.Location = new System.Drawing.Point(235, 74);
            this.txtNhapMKmoi.Multiline = true;
            this.txtNhapMKmoi.Name = "txtNhapMKmoi";
            this.txtNhapMKmoi.PasswordChar = '*';
            this.txtNhapMKmoi.Size = new System.Drawing.Size(214, 30);
            this.txtNhapMKmoi.TabIndex = 30;
            // 
            // txtMKmoi
            // 
            this.txtMKmoi.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtMKmoi.CausesValidation = false;
            this.txtMKmoi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMKmoi.Location = new System.Drawing.Point(235, 22);
            this.txtMKmoi.Multiline = true;
            this.txtMKmoi.Name = "txtMKmoi";
            this.txtMKmoi.PasswordChar = '*';
            this.txtMKmoi.Size = new System.Drawing.Size(214, 30);
            this.txtMKmoi.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(26, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 22);
            this.label4.TabIndex = 27;
            this.label4.Text = "Nhập lại mật khẩu mới";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(26, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 22);
            this.label3.TabIndex = 26;
            this.label3.Text = "Mật khẩu mới";
            // 
            // btnDoiMK
            // 
            this.btnDoiMK.BackColor = System.Drawing.Color.MediumBlue;
            this.btnDoiMK.BackgroundColor = System.Drawing.Color.MediumBlue;
            this.btnDoiMK.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnDoiMK.BorderRadius = 5;
            this.btnDoiMK.BorderSize = 0;
            this.btnDoiMK.FlatAppearance.BorderSize = 0;
            this.btnDoiMK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoiMK.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoiMK.ForeColor = System.Drawing.Color.Snow;
            this.btnDoiMK.Location = new System.Drawing.Point(136, 151);
            this.btnDoiMK.Margin = new System.Windows.Forms.Padding(4);
            this.btnDoiMK.Name = "btnDoiMK";
            this.btnDoiMK.Size = new System.Drawing.Size(234, 60);
            this.btnDoiMK.TabIndex = 32;
            this.btnDoiMK.Text = "Đổi mật khẩu";
            this.btnDoiMK.TextColor = System.Drawing.Color.Snow;
            this.btnDoiMK.UseVisualStyleBackColor = false;
            // 
            // FormDoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(473, 233);
            this.Controls.Add(this.btnDoiMK);
            this.Controls.Add(this.txtNhapMKmoi);
            this.Controls.Add(this.txtMKmoi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "FormDoiMatKhau";
            this.Text = "Đổi mật khẩu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNhapMKmoi;
        private System.Windows.Forms.TextBox txtMKmoi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Customdesign.RoundedButton btnDoiMK;
    }
}