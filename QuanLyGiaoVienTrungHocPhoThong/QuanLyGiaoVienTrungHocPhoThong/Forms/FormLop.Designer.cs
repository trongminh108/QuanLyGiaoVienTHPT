namespace QuanLyGiaoVienTrungHocPhoThong.Forms
{
    partial class FormLop
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLop));
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtLop = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvLop = new System.Windows.Forms.DataGridView();
            this.cbMaChuNhiem = new System.Windows.Forms.ComboBox();
            this.btnXoaLop = new QuanLyGiaoVienTrungHocPhoThong.Customdesign.RoundedButton();
            this.btnCapNhatLop = new QuanLyGiaoVienTrungHocPhoThong.Customdesign.RoundedButton();
            this.btnThemLop = new QuanLyGiaoVienTrungHocPhoThong.Customdesign.RoundedButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLop)).BeginInit();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(36, 74);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 27);
            this.label12.TabIndex = 68;
            this.label12.Text = "Lớp:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(36, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 27);
            this.label1.TabIndex = 69;
            this.label1.Text = "Chủ nhiệm:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbMaChuNhiem);
            this.groupBox1.Controls.Add(this.txtLop);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 223);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(491, 231);
            this.groupBox1.TabIndex = 80;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "LỚP";
            // 
            // txtLop
            // 
            this.txtLop.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtLop.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLop.Location = new System.Drawing.Point(187, 69);
            this.txtLop.Name = "txtLop";
            this.txtLop.Size = new System.Drawing.Size(238, 38);
            this.txtLop.TabIndex = 87;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(115, -15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(293, 245);
            this.pictureBox1.TabIndex = 81;
            this.pictureBox1.TabStop = false;
            // 
            // dgvLop
            // 
            this.dgvLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLop.Location = new System.Drawing.Point(523, 12);
            this.dgvLop.Name = "dgvLop";
            this.dgvLop.RowHeadersWidth = 51;
            this.dgvLop.Size = new System.Drawing.Size(459, 507);
            this.dgvLop.TabIndex = 82;
            this.dgvLop.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvLop_MouseDoubleClick);
            // 
            // cbMaChuNhiem
            // 
            this.cbMaChuNhiem.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMaChuNhiem.FormattingEnabled = true;
            this.cbMaChuNhiem.Location = new System.Drawing.Point(187, 140);
            this.cbMaChuNhiem.Name = "cbMaChuNhiem";
            this.cbMaChuNhiem.Size = new System.Drawing.Size(238, 37);
            this.cbMaChuNhiem.TabIndex = 86;
            // 
            // btnXoaLop
            // 
            this.btnXoaLop.BackColor = System.Drawing.Color.Red;
            this.btnXoaLop.BackgroundColor = System.Drawing.Color.Red;
            this.btnXoaLop.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnXoaLop.BorderRadius = 20;
            this.btnXoaLop.BorderSize = 0;
            this.btnXoaLop.FlatAppearance.BorderSize = 0;
            this.btnXoaLop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaLop.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaLop.ForeColor = System.Drawing.Color.White;
            this.btnXoaLop.Location = new System.Drawing.Point(353, 470);
            this.btnXoaLop.Name = "btnXoaLop";
            this.btnXoaLop.Size = new System.Drawing.Size(150, 40);
            this.btnXoaLop.TabIndex = 85;
            this.btnXoaLop.Text = "Xóa Lớp";
            this.btnXoaLop.TextColor = System.Drawing.Color.White;
            this.btnXoaLop.UseVisualStyleBackColor = false;
            this.btnXoaLop.Click += new System.EventHandler(this.btnXoaLop_Click);
            // 
            // btnCapNhatLop
            // 
            this.btnCapNhatLop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCapNhatLop.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCapNhatLop.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCapNhatLop.BorderRadius = 20;
            this.btnCapNhatLop.BorderSize = 0;
            this.btnCapNhatLop.FlatAppearance.BorderSize = 0;
            this.btnCapNhatLop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapNhatLop.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhatLop.ForeColor = System.Drawing.Color.White;
            this.btnCapNhatLop.Location = new System.Drawing.Point(183, 470);
            this.btnCapNhatLop.Name = "btnCapNhatLop";
            this.btnCapNhatLop.Size = new System.Drawing.Size(150, 40);
            this.btnCapNhatLop.TabIndex = 84;
            this.btnCapNhatLop.Text = "Cập Nhật Lớp";
            this.btnCapNhatLop.TextColor = System.Drawing.Color.White;
            this.btnCapNhatLop.UseVisualStyleBackColor = false;
            this.btnCapNhatLop.Click += new System.EventHandler(this.btnCapNhatLop_Click);
            // 
            // btnThemLop
            // 
            this.btnThemLop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnThemLop.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnThemLop.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnThemLop.BorderRadius = 20;
            this.btnThemLop.BorderSize = 0;
            this.btnThemLop.FlatAppearance.BorderSize = 0;
            this.btnThemLop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemLop.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemLop.ForeColor = System.Drawing.Color.White;
            this.btnThemLop.Location = new System.Drawing.Point(13, 470);
            this.btnThemLop.Name = "btnThemLop";
            this.btnThemLop.Size = new System.Drawing.Size(150, 40);
            this.btnThemLop.TabIndex = 83;
            this.btnThemLop.Text = "Thêm Lớp";
            this.btnThemLop.TextColor = System.Drawing.Color.White;
            this.btnThemLop.UseVisualStyleBackColor = false;
            this.btnThemLop.Click += new System.EventHandler(this.btnThemLop_Click);
            // 
            // FormLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 531);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnXoaLop);
            this.Controls.Add(this.btnCapNhatLop);
            this.Controls.Add(this.btnThemLop);
            this.Controls.Add(this.dgvLop);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormLop";
            this.Text = "Lớp";
            this.Load += new System.EventHandler(this.FormLop_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private Customdesign.RoundedButton btnXoaLop;
        private Customdesign.RoundedButton btnCapNhatLop;
        private Customdesign.RoundedButton btnThemLop;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtLop;
        private System.Windows.Forms.ComboBox cbMaChuNhiem;
        private System.Windows.Forms.DataGridView dgvLop;
    }
}