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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMKmoi = new System.Windows.Forms.TextBox();
            this.txtNhapMKmoi = new System.Windows.Forms.TextBox();
            this.btnGuiMaXN = new QuanLyGiaoVienTrungHocPhoThong.Customdesign.RoundedButton();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(26, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 22);
            this.label3.TabIndex = 34;
            this.label3.Text = "Tên đăng nhập";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(26, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 22);
            this.label4.TabIndex = 35;
            this.label4.Text = "Email";
            // 
            // txtMKmoi
            // 
            this.txtMKmoi.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtMKmoi.CausesValidation = false;
            this.txtMKmoi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMKmoi.Location = new System.Drawing.Point(235, 195);
            this.txtMKmoi.Multiline = true;
            this.txtMKmoi.Name = "txtMKmoi";
            this.txtMKmoi.Size = new System.Drawing.Size(214, 30);
            this.txtMKmoi.TabIndex = 36;
            // 
            // txtNhapMKmoi
            // 
            this.txtNhapMKmoi.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtNhapMKmoi.CausesValidation = false;
            this.txtNhapMKmoi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhapMKmoi.Location = new System.Drawing.Point(235, 249);
            this.txtNhapMKmoi.Multiline = true;
            this.txtNhapMKmoi.Name = "txtNhapMKmoi";
            this.txtNhapMKmoi.Size = new System.Drawing.Size(214, 30);
            this.txtNhapMKmoi.TabIndex = 37;
            // 
            // btnGuiMaXN
            // 
            this.btnGuiMaXN.BackColor = System.Drawing.Color.MediumBlue;
            this.btnGuiMaXN.BackgroundColor = System.Drawing.Color.MediumBlue;
            this.btnGuiMaXN.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnGuiMaXN.BorderRadius = 5;
            this.btnGuiMaXN.BorderSize = 0;
            this.btnGuiMaXN.FlatAppearance.BorderSize = 0;
            this.btnGuiMaXN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuiMaXN.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuiMaXN.ForeColor = System.Drawing.Color.Snow;
            this.btnGuiMaXN.Location = new System.Drawing.Point(136, 378);
            this.btnGuiMaXN.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuiMaXN.Name = "btnGuiMaXN";
            this.btnGuiMaXN.Size = new System.Drawing.Size(234, 60);
            this.btnGuiMaXN.TabIndex = 38;
            this.btnGuiMaXN.Text = "Gửi mã xác nhận";
            this.btnGuiMaXN.TextColor = System.Drawing.Color.Snow;
            this.btnGuiMaXN.UseVisualStyleBackColor = false;
            // 
            // FormQuenMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(473, 516);
            this.Controls.Add(this.btnGuiMaXN);
            this.Controls.Add(this.txtNhapMKmoi);
            this.Controls.Add(this.txtMKmoi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "FormQuenMatKhau";
            this.Text = "FormQuenMatKhau";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMKmoi;
        private System.Windows.Forms.TextBox txtNhapMKmoi;
        private Customdesign.RoundedButton btnGuiMaXN;
    }
}