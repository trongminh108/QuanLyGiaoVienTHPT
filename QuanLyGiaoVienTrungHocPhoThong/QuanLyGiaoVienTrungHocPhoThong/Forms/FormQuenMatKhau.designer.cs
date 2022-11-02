namespace Project_QLGV_QLMK
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
            this.btnLui = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnGuiMaXN = new QuanLyGiaoVienTrungHocPhoThong.Customdesign.RoundedButton();
            this.SuspendLayout();
            // 
            // btnLui
            // 
            this.btnLui.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnLui.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLui.Location = new System.Drawing.Point(19, 23);
            this.btnLui.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLui.Name = "btnLui";
            this.btnLui.Size = new System.Drawing.Size(83, 48);
            this.btnLui.TabIndex = 20;
            this.btnLui.Text = "Lùi";
            this.btnLui.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(115, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 26);
            this.label3.TabIndex = 14;
            this.label3.Text = "Địa chỉ email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(115, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 26);
            this.label1.TabIndex = 13;
            this.label1.Text = "Tên đăng nhập";
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.BackColor = System.Drawing.SystemColors.Window;
            this.txtTenDangNhap.CausesValidation = false;
            this.txtTenDangNhap.Location = new System.Drawing.Point(293, 130);
            this.txtTenDangNhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenDangNhap.Multiline = true;
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(323, 34);
            this.txtTenDangNhap.TabIndex = 21;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.Window;
            this.txtEmail.CausesValidation = false;
            this.txtEmail.Location = new System.Drawing.Point(293, 181);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(323, 34);
            this.txtEmail.TabIndex = 22;
            // 
            // btnGuiMaXN
            // 
            this.btnGuiMaXN.BackColor = System.Drawing.Color.Blue;
            this.btnGuiMaXN.BackgroundColor = System.Drawing.Color.Blue;
            this.btnGuiMaXN.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnGuiMaXN.BorderRadius = 20;
            this.btnGuiMaXN.BorderSize = 0;
            this.btnGuiMaXN.FlatAppearance.BorderSize = 0;
            this.btnGuiMaXN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuiMaXN.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuiMaXN.ForeColor = System.Drawing.Color.MistyRose;
            this.btnGuiMaXN.Location = new System.Drawing.Point(293, 292);
            this.btnGuiMaXN.Name = "btnGuiMaXN";
            this.btnGuiMaXN.Size = new System.Drawing.Size(202, 52);
            this.btnGuiMaXN.TabIndex = 23;
            this.btnGuiMaXN.Text = "Gửi mã xác nhận";
            this.btnGuiMaXN.TextColor = System.Drawing.Color.MistyRose;
            this.btnGuiMaXN.UseVisualStyleBackColor = false;
            // 
            // FormQuenMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGuiMaXN);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtTenDangNhap);
            this.Controls.Add(this.btnLui);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormQuenMatKhau";
            this.Text = "Quên Mật Khẩu";
            this.Load += new System.EventHandler(this.QuenMK_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLui;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.TextBox txtEmail;
        private QuanLyGiaoVienTrungHocPhoThong.Customdesign.RoundedButton btnGuiMaXN;
    }
}