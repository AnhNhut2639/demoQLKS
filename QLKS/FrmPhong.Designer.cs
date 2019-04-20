namespace QLKS
{
    partial class FrmPhong
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLuuGia = new System.Windows.Forms.Button();
            this.btnLuuPhong = new System.Windows.Forms.Button();
            this.dtpNgayDatPhong = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGiaPhong = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbTinhTrang = new System.Windows.Forms.ComboBox();
            this.cbbLoaiPhong = new System.Windows.Forms.ComboBox();
            this.txtTenPhong = new System.Windows.Forms.TextBox();
            this.txtMaPhong = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvLoadPhong = new System.Windows.Forms.DataGridView();
            this.btnThemPhong = new System.Windows.Forms.Button();
            this.btnXoaPhong = new System.Windows.Forms.Button();
            this.btnThoatPhong = new System.Windows.Forms.Button();
            this.btnSuaGiaPhong = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoadPhong)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnLuuGia);
            this.groupBox2.Controls.Add(this.btnLuuPhong);
            this.groupBox2.Controls.Add(this.dtpNgayDatPhong);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtGiaPhong);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cbbTinhTrang);
            this.groupBox2.Controls.Add(this.cbbLoaiPhong);
            this.groupBox2.Controls.Add(this.txtTenPhong);
            this.groupBox2.Controls.Add(this.txtMaPhong);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(305, 36);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(686, 229);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin Phòng :";
            // 
            // btnLuuGia
            // 
            this.btnLuuGia.Location = new System.Drawing.Point(486, 190);
            this.btnLuuGia.Name = "btnLuuGia";
            this.btnLuuGia.Size = new System.Drawing.Size(75, 23);
            this.btnLuuGia.TabIndex = 13;
            this.btnLuuGia.Text = "Lưu ";
            this.btnLuuGia.UseVisualStyleBackColor = true;
            this.btnLuuGia.Click += new System.EventHandler(this.btnLuuGia_Click);
            // 
            // btnLuuPhong
            // 
            this.btnLuuPhong.Location = new System.Drawing.Point(353, 190);
            this.btnLuuPhong.Name = "btnLuuPhong";
            this.btnLuuPhong.Size = new System.Drawing.Size(75, 23);
            this.btnLuuPhong.TabIndex = 5;
            this.btnLuuPhong.Text = "Lưu";
            this.btnLuuPhong.UseVisualStyleBackColor = true;
            this.btnLuuPhong.Click += new System.EventHandler(this.btnLuuPhong_Click);
            // 
            // dtpNgayDatPhong
            // 
            this.dtpNgayDatPhong.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayDatPhong.Location = new System.Drawing.Point(434, 159);
            this.dtpNgayDatPhong.Name = "dtpNgayDatPhong";
            this.dtpNgayDatPhong.Size = new System.Drawing.Size(145, 20);
            this.dtpNgayDatPhong.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(337, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Ngày :";
            // 
            // txtGiaPhong
            // 
            this.txtGiaPhong.Location = new System.Drawing.Point(429, 41);
            this.txtGiaPhong.Name = "txtGiaPhong";
            this.txtGiaPhong.Size = new System.Drawing.Size(150, 20);
            this.txtGiaPhong.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(350, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Giá :  ";
            // 
            // cbbTinhTrang
            // 
            this.cbbTinhTrang.FormattingEnabled = true;
            this.cbbTinhTrang.Location = new System.Drawing.Point(429, 104);
            this.cbbTinhTrang.Name = "cbbTinhTrang";
            this.cbbTinhTrang.Size = new System.Drawing.Size(150, 21);
            this.cbbTinhTrang.TabIndex = 7;
            // 
            // cbbLoaiPhong
            // 
            this.cbbLoaiPhong.FormattingEnabled = true;
            this.cbbLoaiPhong.Location = new System.Drawing.Point(121, 157);
            this.cbbLoaiPhong.Name = "cbbLoaiPhong";
            this.cbbLoaiPhong.Size = new System.Drawing.Size(173, 21);
            this.cbbLoaiPhong.TabIndex = 6;
            this.cbbLoaiPhong.SelectedIndexChanged += new System.EventHandler(this.cbbLoaiPhong_SelectedIndexChanged);
            this.cbbLoaiPhong.SelectionChangeCommitted += new System.EventHandler(this.cbbLoaiPhong_SelectionChangeCommitted);
            this.cbbLoaiPhong.ValueMemberChanged += new System.EventHandler(this.cbbLoaiPhong_ValueMemberChanged);
            this.cbbLoaiPhong.SelectedValueChanged += new System.EventHandler(this.cbbLoaiPhong_SelectedValueChanged);
            this.cbbLoaiPhong.Click += new System.EventHandler(this.cbbLoaiPhong_Click);
            this.cbbLoaiPhong.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbbLoaiPhong_MouseClick);
            // 
            // txtTenPhong
            // 
            this.txtTenPhong.Location = new System.Drawing.Point(121, 97);
            this.txtTenPhong.Name = "txtTenPhong";
            this.txtTenPhong.Size = new System.Drawing.Size(173, 20);
            this.txtTenPhong.TabIndex = 5;
            // 
            // txtMaPhong
            // 
            this.txtMaPhong.Location = new System.Drawing.Point(121, 34);
            this.txtMaPhong.Name = "txtMaPhong";
            this.txtMaPhong.Size = new System.Drawing.Size(173, 20);
            this.txtMaPhong.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(337, 104);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Tình Trạng :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(35, 165);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Loại Phòng :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Tên Phòng :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Mã Phòng :";
            // 
            // dgvLoadPhong
            // 
            this.dgvLoadPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoadPhong.Location = new System.Drawing.Point(294, 293);
            this.dgvLoadPhong.Name = "dgvLoadPhong";
            this.dgvLoadPhong.Size = new System.Drawing.Size(686, 171);
            this.dgvLoadPhong.TabIndex = 2;
            this.dgvLoadPhong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLoadPhong_CellContentClick);
            this.dgvLoadPhong.Click += new System.EventHandler(this.dgvLoadPhong_Click);
            // 
            // btnThemPhong
            // 
            this.btnThemPhong.Location = new System.Drawing.Point(390, 487);
            this.btnThemPhong.Name = "btnThemPhong";
            this.btnThemPhong.Size = new System.Drawing.Size(75, 23);
            this.btnThemPhong.TabIndex = 3;
            this.btnThemPhong.Text = "Thêm";
            this.btnThemPhong.UseVisualStyleBackColor = true;
            this.btnThemPhong.Click += new System.EventHandler(this.btnThemPhong_Click);
            // 
            // btnXoaPhong
            // 
            this.btnXoaPhong.Location = new System.Drawing.Point(739, 487);
            this.btnXoaPhong.Name = "btnXoaPhong";
            this.btnXoaPhong.Size = new System.Drawing.Size(75, 23);
            this.btnXoaPhong.TabIndex = 3;
            this.btnXoaPhong.Text = "Xóa";
            this.btnXoaPhong.UseVisualStyleBackColor = true;
            this.btnXoaPhong.Click += new System.EventHandler(this.btnXoaPhong_Click);
            // 
            // btnThoatPhong
            // 
            this.btnThoatPhong.Location = new System.Drawing.Point(983, 535);
            this.btnThoatPhong.Name = "btnThoatPhong";
            this.btnThoatPhong.Size = new System.Drawing.Size(75, 23);
            this.btnThoatPhong.TabIndex = 4;
            this.btnThoatPhong.Text = "Thoát";
            this.btnThoatPhong.UseVisualStyleBackColor = true;
            this.btnThoatPhong.Click += new System.EventHandler(this.btnThoatPhong_Click);
            // 
            // btnSuaGiaPhong
            // 
            this.btnSuaGiaPhong.Location = new System.Drawing.Point(559, 487);
            this.btnSuaGiaPhong.Name = "btnSuaGiaPhong";
            this.btnSuaGiaPhong.Size = new System.Drawing.Size(75, 23);
            this.btnSuaGiaPhong.TabIndex = 5;
            this.btnSuaGiaPhong.Text = "sửa ";
            this.btnSuaGiaPhong.UseVisualStyleBackColor = true;
            this.btnSuaGiaPhong.Click += new System.EventHandler(this.btnSuaGiaPhong_Click);
            // 
            // FrmPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 580);
            this.Controls.Add(this.btnSuaGiaPhong);
            this.Controls.Add(this.btnThoatPhong);
            this.Controls.Add(this.btnXoaPhong);
            this.Controls.Add(this.btnThemPhong);
            this.Controls.Add(this.dgvLoadPhong);
            this.Controls.Add(this.groupBox2);
            this.Name = "FrmPhong";
            this.Text = "FrmPhong";
            this.Load += new System.EventHandler(this.FrmPhong_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoadPhong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbbTinhTrang;
        private System.Windows.Forms.ComboBox cbbLoaiPhong;
        private System.Windows.Forms.TextBox txtTenPhong;
        private System.Windows.Forms.TextBox txtMaPhong;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvLoadPhong;
        private System.Windows.Forms.Button btnThemPhong;
        private System.Windows.Forms.Button btnXoaPhong;
        private System.Windows.Forms.Button btnThoatPhong;
        private System.Windows.Forms.DateTimePicker dtpNgayDatPhong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGiaPhong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLuuPhong;
        private System.Windows.Forms.Button btnSuaGiaPhong;
        private System.Windows.Forms.Button btnLuuGia;
    }
}