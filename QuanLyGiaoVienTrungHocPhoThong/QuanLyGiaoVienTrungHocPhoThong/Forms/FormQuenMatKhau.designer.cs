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
            this.btnMaXN = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnLui
            // 
            this.btnLui.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnLui.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLui.Location = new System.Drawing.Point(14, 19);
            this.btnLui.Margin = new System.Windows.Forms.Padding(2);
            this.btnLui.Name = "btnLui";
            this.btnLui.Size = new System.Drawing.Size(62, 39);
            this.btnLui.TabIndex = 20;
            this.btnLui.Text = "Lùi";
            this.btnLui.UseVisualStyleBackColor = false;
            // 
            // btnMaXN
            // 
            this.btnMaXN.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnMaXN.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaXN.Location = new System.Drawing.Point(220, 232);
            this.btnMaXN.Margin = new System.Windows.Forms.Padding(2);
            this.btnMaXN.Name = "btnMaXN";
            this.btnMaXN.Size = new System.Drawing.Size(194, 39);
            this.btnMaXN.TabIndex = 16;
            this.btnMaXN.Text = "Gửi mã xác nhận";
            this.btnMaXN.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(86, 153);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 21);
            this.label3.TabIndex = 14;
            this.label3.Text = "Địa chỉ email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(86, 106);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 21);
            this.label1.TabIndex = 13;
            this.label1.Text = "Tên đăng nhập";
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.BackColor = System.Drawing.SystemColors.Window;
            this.txtTenDangNhap.CausesValidation = false;
            this.txtTenDangNhap.Location = new System.Drawing.Point(220, 106);
            this.txtTenDangNhap.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenDangNhap.Multiline = true;
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(243, 28);
            this.txtTenDangNhap.TabIndex = 21;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.Window;
            this.txtEmail.CausesValidation = false;
            this.txtEmail.Location = new System.Drawing.Point(220, 147);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(243, 28);
            this.txtEmail.TabIndex = 22;
            // 
            // QuenMK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtTenDangNhap);
            this.Controls.Add(this.btnLui);
            this.Controls.Add(this.btnMaXN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "QuenMK";
            this.Text = "Quên Mật Khẩu";
            this.Load += new System.EventHandler(this.QuenMK_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLui;
        private System.Windows.Forms.Button btnMaXN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.TextBox txtEmail;
    }
}