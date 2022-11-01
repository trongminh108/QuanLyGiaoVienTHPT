namespace Project_QLGV_QLMK
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDMK = new System.Windows.Forms.Button();
            this.btnLui = new System.Windows.Forms.Button();
            this.txtMKcu = new System.Windows.Forms.TextBox();
            this.txtMKmoi = new System.Windows.Forms.TextBox();
            this.txtNhapMKmoi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(121, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mật khẩu cũ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(121, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mật khẩu mới";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(121, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(224, 26);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nhập lại mật khẩu mới";
            // 
            // btnDMK
            // 
            this.btnDMK.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnDMK.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDMK.Location = new System.Drawing.Point(291, 341);
            this.btnDMK.Name = "btnDMK";
            this.btnDMK.Size = new System.Drawing.Size(259, 48);
            this.btnDMK.TabIndex = 7;
            this.btnDMK.Text = "Đổi mật khẩu";
            this.btnDMK.UseVisualStyleBackColor = false;
            this.btnDMK.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnLui
            // 
            this.btnLui.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnLui.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLui.Location = new System.Drawing.Point(21, 29);
            this.btnLui.Name = "btnLui";
            this.btnLui.Size = new System.Drawing.Size(82, 48);
            this.btnLui.TabIndex = 11;
            this.btnLui.Text = "Lùi";
            this.btnLui.UseVisualStyleBackColor = false;
            // 
            // txtMKcu
            // 
            this.txtMKcu.BackColor = System.Drawing.SystemColors.Window;
            this.txtMKcu.CausesValidation = false;
            this.txtMKcu.Location = new System.Drawing.Point(363, 128);
            this.txtMKcu.Multiline = true;
            this.txtMKcu.Name = "txtMKcu";
            this.txtMKcu.Size = new System.Drawing.Size(323, 33);
            this.txtMKcu.TabIndex = 12;
            // 
            // txtMKmoi
            // 
            this.txtMKmoi.BackColor = System.Drawing.SystemColors.Window;
            this.txtMKmoi.CausesValidation = false;
            this.txtMKmoi.Location = new System.Drawing.Point(363, 183);
            this.txtMKmoi.Multiline = true;
            this.txtMKmoi.Name = "txtMKmoi";
            this.txtMKmoi.Size = new System.Drawing.Size(323, 33);
            this.txtMKmoi.TabIndex = 13;
            // 
            // txtNhapMKmoi
            // 
            this.txtNhapMKmoi.BackColor = System.Drawing.SystemColors.Window;
            this.txtNhapMKmoi.CausesValidation = false;
            this.txtNhapMKmoi.Location = new System.Drawing.Point(363, 238);
            this.txtNhapMKmoi.Multiline = true;
            this.txtNhapMKmoi.Name = "txtNhapMKmoi";
            this.txtNhapMKmoi.Size = new System.Drawing.Size(323, 33);
            this.txtNhapMKmoi.TabIndex = 14;
            // 
            // DMK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtNhapMKmoi);
            this.Controls.Add(this.txtMKmoi);
            this.Controls.Add(this.txtMKcu);
            this.Controls.Add(this.btnLui);
            this.Controls.Add(this.btnDMK);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "DMK";
            this.Text = "Đổi Mật Khẩu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDMK;
        private System.Windows.Forms.Button btnLui;
        private System.Windows.Forms.TextBox txtMKcu;
        private System.Windows.Forms.TextBox txtMKmoi;
        private System.Windows.Forms.TextBox txtNhapMKmoi;
    }
}