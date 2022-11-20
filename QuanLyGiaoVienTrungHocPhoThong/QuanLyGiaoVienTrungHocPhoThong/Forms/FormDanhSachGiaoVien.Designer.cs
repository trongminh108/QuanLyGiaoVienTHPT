﻿namespace QuanLyGiaoVienTrungHocPhoThong.Forms2
{
    partial class FormDanhSachGiaoVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDanhSachGiaoVien));
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.cmbSapXep = new System.Windows.Forms.ComboBox();
            this.btnTimKiem = new QuanLyGiaoVienTrungHocPhoThong.Customdesign.RoundedButton();
            this.btnSapXep = new QuanLyGiaoVienTrungHocPhoThong.Customdesign.RoundedButton();
            this.dgvDSGV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSGV)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(17, 33);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTimKiem.Multiline = true;
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(200, 29);
            this.txtTimKiem.TabIndex = 16;
            // 
            // cmbSapXep
            // 
            this.cmbSapXep.FormattingEnabled = true;
            this.cmbSapXep.Location = new System.Drawing.Point(326, 37);
            this.cmbSapXep.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbSapXep.Name = "cmbSapXep";
            this.cmbSapXep.Size = new System.Drawing.Size(121, 21);
            this.cmbSapXep.TabIndex = 20;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.MediumBlue;
            this.btnTimKiem.BackgroundColor = System.Drawing.Color.MediumBlue;
            this.btnTimKiem.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnTimKiem.BorderRadius = 10;
            this.btnTimKiem.BorderSize = 0;
            this.btnTimKiem.FlatAppearance.BorderSize = 0;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.Image")));
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(221, 29);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(93, 32);
            this.btnTimKiem.TabIndex = 21;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiem.TextColor = System.Drawing.Color.White;
            this.btnTimKiem.UseVisualStyleBackColor = false;
            // 
            // btnSapXep
            // 
            this.btnSapXep.BackColor = System.Drawing.Color.MediumBlue;
            this.btnSapXep.BackgroundColor = System.Drawing.Color.MediumBlue;
            this.btnSapXep.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSapXep.BorderRadius = 10;
            this.btnSapXep.BorderSize = 0;
            this.btnSapXep.FlatAppearance.BorderSize = 0;
            this.btnSapXep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSapXep.ForeColor = System.Drawing.Color.White;
            this.btnSapXep.Image = ((System.Drawing.Image)(resources.GetObject("btnSapXep.Image")));
            this.btnSapXep.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSapXep.Location = new System.Drawing.Point(451, 29);
            this.btnSapXep.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSapXep.Name = "btnSapXep";
            this.btnSapXep.Size = new System.Drawing.Size(94, 32);
            this.btnSapXep.TabIndex = 17;
            this.btnSapXep.Text = "Sắp xếp";
            this.btnSapXep.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSapXep.TextColor = System.Drawing.Color.White;
            this.btnSapXep.UseVisualStyleBackColor = false;
            // 
            // dgvDSGV
            // 
            this.dgvDSGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSGV.Location = new System.Drawing.Point(17, 100);
            this.dgvDSGV.Name = "dgvDSGV";
            this.dgvDSGV.Size = new System.Drawing.Size(528, 258);
            this.dgvDSGV.TabIndex = 22;
            // 
            // FormDanhSachGiaoVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 370);
            this.Controls.Add(this.dgvDSGV);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.cmbSapXep);
            this.Controls.Add(this.btnSapXep);
            this.Controls.Add(this.txtTimKiem);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormDanhSachGiaoVien";
            this.Text = "FormDanhSachGiaoVien";
            this.Load += new System.EventHandler(this.FormDanhSachGiaoVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtTimKiem;
        private Customdesign.RoundedButton btnSapXep;
        private System.Windows.Forms.ComboBox cmbSapXep;
        private Customdesign.RoundedButton btnTimKiem;
        private System.Windows.Forms.DataGridView dgvDSGV;
    }
}