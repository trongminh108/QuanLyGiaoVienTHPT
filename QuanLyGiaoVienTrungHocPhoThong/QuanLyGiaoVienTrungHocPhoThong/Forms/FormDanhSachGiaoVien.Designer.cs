namespace QuanLyGiaoVienTrungHocPhoThong.Forms2
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
            this.dgvDSGV = new System.Windows.Forms.DataGridView();
            this.btnSuaGV = new QuanLyGiaoVienTrungHocPhoThong.Customdesign.RoundedButton();
            this.btnXoaGV = new QuanLyGiaoVienTrungHocPhoThong.Customdesign.RoundedButton();
            this.btnThemGV = new QuanLyGiaoVienTrungHocPhoThong.Customdesign.RoundedButton();
            this.btnTimKiem = new QuanLyGiaoVienTrungHocPhoThong.Customdesign.RoundedButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSGV)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtTimKiem.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(15, 34);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(430, 35);
            this.txtTimKiem.TabIndex = 16;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            this.txtTimKiem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTimKiem_KeyDown);
            // 
            // dgvDSGV
            // 
            this.dgvDSGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSGV.Location = new System.Drawing.Point(15, 100);
            this.dgvDSGV.Name = "dgvDSGV";
            this.dgvDSGV.RowHeadersWidth = 51;
            this.dgvDSGV.Size = new System.Drawing.Size(967, 419);
            this.dgvDSGV.TabIndex = 22;
            this.dgvDSGV.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvDSGV_KeyDown);
            this.dgvDSGV.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvDSGV_MouseDoubleClick);
            // 
            // btnSuaGV
            // 
            this.btnSuaGV.BackColor = System.Drawing.Color.Olive;
            this.btnSuaGV.BackgroundColor = System.Drawing.Color.Olive;
            this.btnSuaGV.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSuaGV.BorderRadius = 24;
            this.btnSuaGV.BorderSize = 0;
            this.btnSuaGV.FlatAppearance.BorderSize = 0;
            this.btnSuaGV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaGV.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaGV.ForeColor = System.Drawing.Color.White;
            this.btnSuaGV.Location = new System.Drawing.Point(894, 28);
            this.btnSuaGV.Name = "btnSuaGV";
            this.btnSuaGV.Size = new System.Drawing.Size(87, 49);
            this.btnSuaGV.TabIndex = 25;
            this.btnSuaGV.Text = "Sửa";
            this.btnSuaGV.TextColor = System.Drawing.Color.White;
            this.btnSuaGV.UseVisualStyleBackColor = false;
            this.btnSuaGV.Click += new System.EventHandler(this.btnSuaGV_Click);
            // 
            // btnXoaGV
            // 
            this.btnXoaGV.BackColor = System.Drawing.Color.Red;
            this.btnXoaGV.BackgroundColor = System.Drawing.Color.Red;
            this.btnXoaGV.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnXoaGV.BorderRadius = 24;
            this.btnXoaGV.BorderSize = 0;
            this.btnXoaGV.FlatAppearance.BorderSize = 0;
            this.btnXoaGV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaGV.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaGV.ForeColor = System.Drawing.Color.White;
            this.btnXoaGV.Location = new System.Drawing.Point(782, 27);
            this.btnXoaGV.Name = "btnXoaGV";
            this.btnXoaGV.Size = new System.Drawing.Size(87, 49);
            this.btnXoaGV.TabIndex = 24;
            this.btnXoaGV.Text = "Xóa";
            this.btnXoaGV.TextColor = System.Drawing.Color.White;
            this.btnXoaGV.UseVisualStyleBackColor = false;
            this.btnXoaGV.Click += new System.EventHandler(this.btnXoaGV_Click);
            // 
            // btnThemGV
            // 
            this.btnThemGV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnThemGV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnThemGV.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnThemGV.BorderRadius = 24;
            this.btnThemGV.BorderSize = 0;
            this.btnThemGV.FlatAppearance.BorderSize = 0;
            this.btnThemGV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemGV.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemGV.ForeColor = System.Drawing.Color.White;
            this.btnThemGV.Location = new System.Drawing.Point(670, 27);
            this.btnThemGV.Name = "btnThemGV";
            this.btnThemGV.Size = new System.Drawing.Size(87, 49);
            this.btnThemGV.TabIndex = 23;
            this.btnThemGV.Text = "Thêm";
            this.btnThemGV.TextColor = System.Drawing.Color.White;
            this.btnThemGV.UseVisualStyleBackColor = false;
            this.btnThemGV.Click += new System.EventHandler(this.btnThemGV_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.MediumBlue;
            this.btnTimKiem.BackgroundColor = System.Drawing.Color.MediumBlue;
            this.btnTimKiem.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnTimKiem.BorderRadius = 15;
            this.btnTimKiem.BorderSize = 0;
            this.btnTimKiem.FlatAppearance.BorderSize = 0;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.Image")));
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(470, 27);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(175, 49);
            this.btnTimKiem.TabIndex = 21;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiem.TextColor = System.Drawing.Color.White;
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // FormDanhSachGiaoVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(994, 531);
            this.Controls.Add(this.btnSuaGV);
            this.Controls.Add(this.btnXoaGV);
            this.Controls.Add(this.btnThemGV);
            this.Controls.Add(this.dgvDSGV);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtTimKiem);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormDanhSachGiaoVien";
            this.Text = "Danh sách giáo viên";
            this.Load += new System.EventHandler(this.FormDanhSachGiaoVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtTimKiem;
        private Customdesign.RoundedButton btnTimKiem;
        private System.Windows.Forms.DataGridView dgvDSGV;
        private Customdesign.RoundedButton btnThemGV;
        private Customdesign.RoundedButton btnXoaGV;
        private Customdesign.RoundedButton btnSuaGV;
    }
}