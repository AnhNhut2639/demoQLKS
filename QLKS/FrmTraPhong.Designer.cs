namespace QLKS
{
    partial class FrmTraPhong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTraPhong));
            this.label1 = new System.Windows.Forms.Label();
            this.cbbKhachTP = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTraTien = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtTongTienDV = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpTEST = new System.Windows.Forms.DateTimePicker();
            this.txtNVTT = new System.Windows.Forms.TextBox();
            this.dtpNgayTraPhong = new System.Windows.Forms.DateTimePicker();
            this.txtNgayNhanPhong = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnHoaDon = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dgvDVuThanhToan = new System.Windows.Forms.DataGridView();
            this.txtTongTienTT = new System.Windows.Forms.TextBox();
            this.txtSoNgay = new System.Windows.Forms.TextBox();
            this.txtGiaPhong = new System.Windows.Forms.TextBox();
            this.txtLoaiPTT = new System.Windows.Forms.TextBox();
            this.txtTenPTT = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radNuTraPhong = new System.Windows.Forms.RadioButton();
            this.radNamTraPhong = new System.Windows.Forms.RadioButton();
            this.txtLienLacTraPhong = new System.Windows.Forms.TextBox();
            this.txtQuocTichTraPhong = new System.Windows.Forms.TextBox();
            this.txtCMNDKHTraPhong = new System.Windows.Forms.TextBox();
            this.txtTenKHTraPhong = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.btnXacNhanTT = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpNgaySinhKHTraPhong = new System.Windows.Forms.DateTimePicker();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDVuThanhToan)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Phòng :";
            // 
            // cbbKhachTP
            // 
            this.cbbKhachTP.FormattingEnabled = true;
            this.cbbKhachTP.Location = new System.Drawing.Point(76, 23);
            this.cbbKhachTP.Name = "cbbKhachTP";
            this.cbbKhachTP.Size = new System.Drawing.Size(185, 21);
            this.cbbKhachTP.TabIndex = 2;
            this.cbbKhachTP.SelectedIndexChanged += new System.EventHandler(this.cbbKhachTP_SelectedIndexChanged);
            this.cbbKhachTP.SelectionChangeCommitted += new System.EventHandler(this.cbbKhachTP_SelectionChangeCommitted);
            this.cbbKhachTP.DisplayMemberChanged += new System.EventHandler(this.cbbKhachTP_DisplayMemberChanged);
            this.cbbKhachTP.ValueMemberChanged += new System.EventHandler(this.cbbKhachTP_ValueMemberChanged);
            this.cbbKhachTP.SelectedValueChanged += new System.EventHandler(this.cbbKhachTP_SelectedValueChanged);
            this.cbbKhachTP.TextChanged += new System.EventHandler(this.cbbKhachTP_TextChanged);
            this.cbbKhachTP.Click += new System.EventHandler(this.cbbKhachTP_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTraTien);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.txtTongTienDV);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.dtpTEST);
            this.groupBox2.Controls.Add(this.txtNVTT);
            this.groupBox2.Controls.Add(this.dtpNgayTraPhong);
            this.groupBox2.Controls.Add(this.txtNgayNhanPhong);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btnHoaDon);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.dgvDVuThanhToan);
            this.groupBox2.Controls.Add(this.txtTongTienTT);
            this.groupBox2.Controls.Add(this.txtSoNgay);
            this.groupBox2.Controls.Add(this.txtGiaPhong);
            this.groupBox2.Controls.Add(this.txtLoaiPTT);
            this.groupBox2.Controls.Add(this.txtTenPTT);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(290, 75);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(644, 743);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin Thanh Toán :";
            // 
            // txtTraTien
            // 
            this.txtTraTien.Location = new System.Drawing.Point(183, 679);
            this.txtTraTien.Name = "txtTraTien";
            this.txtTraTien.Size = new System.Drawing.Size(158, 20);
            this.txtTraTien.TabIndex = 41;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(30, 630);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(84, 13);
            this.label19.TabIndex = 40;
            this.label19.Text = "Phí thuê phòng ";
            // 
            // txtTongTienDV
            // 
            this.txtTongTienDV.Location = new System.Drawing.Point(183, 580);
            this.txtTongTienDV.Name = "txtTongTienDV";
            this.txtTongTienDV.Size = new System.Drawing.Size(158, 20);
            this.txtTongTienDV.TabIndex = 39;
            this.txtTongTienDV.TextChanged += new System.EventHandler(this.txtTongTienDV_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(30, 580);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 13);
            this.label10.TabIndex = 38;
            this.label10.Text = "Tổng phí dịch vụ :";
            // 
            // dtpTEST
            // 
            this.dtpTEST.CustomFormat = "dd/MM/yyyy";
            this.dtpTEST.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTEST.Location = new System.Drawing.Point(113, 214);
            this.dtpTEST.Name = "dtpTEST";
            this.dtpTEST.Size = new System.Drawing.Size(185, 20);
            this.dtpTEST.TabIndex = 37;
            this.dtpTEST.ValueChanged += new System.EventHandler(this.dtpTEST_ValueChanged);
            // 
            // txtNVTT
            // 
            this.txtNVTT.Location = new System.Drawing.Point(455, 330);
            this.txtNVTT.Name = "txtNVTT";
            this.txtNVTT.Size = new System.Drawing.Size(138, 20);
            this.txtNVTT.TabIndex = 36;
            // 
            // dtpNgayTraPhong
            // 
            this.dtpNgayTraPhong.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayTraPhong.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayTraPhong.Location = new System.Drawing.Point(113, 276);
            this.dtpNgayTraPhong.Name = "dtpNgayTraPhong";
            this.dtpNgayTraPhong.Size = new System.Drawing.Size(185, 20);
            this.dtpNgayTraPhong.TabIndex = 35;
            this.dtpNgayTraPhong.ValueChanged += new System.EventHandler(this.dtpNgayTraPhong_ValueChanged);
            // 
            // txtNgayNhanPhong
            // 
            this.txtNgayNhanPhong.Location = new System.Drawing.Point(128, 174);
            this.txtNgayNhanPhong.Name = "txtNgayNhanPhong";
            this.txtNgayNhanPhong.Size = new System.Drawing.Size(136, 20);
            this.txtNgayNhanPhong.TabIndex = 34;
            this.txtNgayNhanPhong.TextChanged += new System.EventHandler(this.txtNgayNhanPhong_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 283);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "Ngày Trả Phòng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(328, 333);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Nhân viên phụ trách:";
            // 
            // btnHoaDon
            // 
            this.btnHoaDon.Location = new System.Drawing.Point(473, 659);
            this.btnHoaDon.Name = "btnHoaDon";
            this.btnHoaDon.Size = new System.Drawing.Size(99, 23);
            this.btnHoaDon.TabIndex = 29;
            this.btnHoaDon.Text = "Xuất hóa đơn";
            this.btnHoaDon.UseVisualStyleBackColor = true;
            this.btnHoaDon.Click += new System.EventHandler(this.btnHoaDon_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(357, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(227, 203);
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(43, 377);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "Dịch vụ :";
            // 
            // dgvDVuThanhToan
            // 
            this.dgvDVuThanhToan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDVuThanhToan.Location = new System.Drawing.Point(87, 393);
            this.dgvDVuThanhToan.Name = "dgvDVuThanhToan";
            this.dgvDVuThanhToan.Size = new System.Drawing.Size(451, 150);
            this.dgvDVuThanhToan.TabIndex = 26;
            this.dgvDVuThanhToan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDVuThanhToan_CellClick);
            // 
            // txtTongTienTT
            // 
            this.txtTongTienTT.Location = new System.Drawing.Point(183, 623);
            this.txtTongTienTT.Name = "txtTongTienTT";
            this.txtTongTienTT.Size = new System.Drawing.Size(158, 20);
            this.txtTongTienTT.TabIndex = 19;
            this.txtTongTienTT.TextChanged += new System.EventHandler(this.txtTongTienTT_TextChanged);
            // 
            // txtSoNgay
            // 
            this.txtSoNgay.Location = new System.Drawing.Point(152, 333);
            this.txtSoNgay.Name = "txtSoNgay";
            this.txtSoNgay.Size = new System.Drawing.Size(136, 20);
            this.txtSoNgay.TabIndex = 18;
            this.txtSoNgay.TextChanged += new System.EventHandler(this.txtSoNgay_TextChanged);
            // 
            // txtGiaPhong
            // 
            this.txtGiaPhong.Location = new System.Drawing.Point(128, 130);
            this.txtGiaPhong.Name = "txtGiaPhong";
            this.txtGiaPhong.Size = new System.Drawing.Size(136, 20);
            this.txtGiaPhong.TabIndex = 15;
            // 
            // txtLoaiPTT
            // 
            this.txtLoaiPTT.Location = new System.Drawing.Point(128, 78);
            this.txtLoaiPTT.Name = "txtLoaiPTT";
            this.txtLoaiPTT.Size = new System.Drawing.Size(136, 20);
            this.txtLoaiPTT.TabIndex = 14;
            // 
            // txtTenPTT
            // 
            this.txtTenPTT.Location = new System.Drawing.Point(128, 41);
            this.txtTenPTT.Name = "txtTenPTT";
            this.txtTenPTT.Size = new System.Drawing.Size(136, 20);
            this.txtTenPTT.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(22, 686);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(109, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "Tổng tiền thanh toán:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(41, 333);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Số ngày :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Ngày Nhận Phòng :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Giá Phòng :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Loại Phòng :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên Phòng :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtpNgaySinhKHTraPhong);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.radNuTraPhong);
            this.groupBox3.Controls.Add(this.radNamTraPhong);
            this.groupBox3.Controls.Add(this.txtLienLacTraPhong);
            this.groupBox3.Controls.Add(this.txtQuocTichTraPhong);
            this.groupBox3.Controls.Add(this.txtCMNDKHTraPhong);
            this.groupBox3.Controls.Add(this.txtTenKHTraPhong);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Location = new System.Drawing.Point(7, 75);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(277, 411);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin khách trả phòng :";
            // 
            // radNuTraPhong
            // 
            this.radNuTraPhong.AutoSize = true;
            this.radNuTraPhong.Location = new System.Drawing.Point(196, 204);
            this.radNuTraPhong.Name = "radNuTraPhong";
            this.radNuTraPhong.Size = new System.Drawing.Size(39, 17);
            this.radNuTraPhong.TabIndex = 16;
            this.radNuTraPhong.Text = "Nữ";
            this.radNuTraPhong.UseVisualStyleBackColor = true;
            // 
            // radNamTraPhong
            // 
            this.radNamTraPhong.AutoSize = true;
            this.radNamTraPhong.Checked = true;
            this.radNamTraPhong.Location = new System.Drawing.Point(95, 204);
            this.radNamTraPhong.Name = "radNamTraPhong";
            this.radNamTraPhong.Size = new System.Drawing.Size(50, 17);
            this.radNamTraPhong.TabIndex = 15;
            this.radNamTraPhong.TabStop = true;
            this.radNamTraPhong.Text = "Nam ";
            this.radNamTraPhong.UseVisualStyleBackColor = true;
            // 
            // txtLienLacTraPhong
            // 
            this.txtLienLacTraPhong.Location = new System.Drawing.Point(95, 321);
            this.txtLienLacTraPhong.Name = "txtLienLacTraPhong";
            this.txtLienLacTraPhong.Size = new System.Drawing.Size(144, 20);
            this.txtLienLacTraPhong.TabIndex = 14;
            // 
            // txtQuocTichTraPhong
            // 
            this.txtQuocTichTraPhong.Location = new System.Drawing.Point(99, 150);
            this.txtQuocTichTraPhong.Name = "txtQuocTichTraPhong";
            this.txtQuocTichTraPhong.Size = new System.Drawing.Size(140, 20);
            this.txtQuocTichTraPhong.TabIndex = 11;
            // 
            // txtCMNDKHTraPhong
            // 
            this.txtCMNDKHTraPhong.Location = new System.Drawing.Point(99, 102);
            this.txtCMNDKHTraPhong.Name = "txtCMNDKHTraPhong";
            this.txtCMNDKHTraPhong.Size = new System.Drawing.Size(140, 20);
            this.txtCMNDKHTraPhong.TabIndex = 10;
            // 
            // txtTenKHTraPhong
            // 
            this.txtTenKHTraPhong.Location = new System.Drawing.Point(95, 49);
            this.txtTenKHTraPhong.Name = "txtTenKHTraPhong";
            this.txtTenKHTraPhong.Size = new System.Drawing.Size(144, 20);
            this.txtTenKHTraPhong.TabIndex = 9;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(19, 49);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 13);
            this.label13.TabIndex = 5;
            this.label13.Text = "Tên KH:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(19, 324);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(50, 13);
            this.label14.TabIndex = 4;
            this.label14.Text = "Liên lạc :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(19, 204);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(51, 13);
            this.label16.TabIndex = 2;
            this.label16.Text = "Giới Tính";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(19, 153);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(57, 13);
            this.label17.TabIndex = 1;
            this.label17.Text = "Quốc Tịch";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(19, 102);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(45, 13);
            this.label18.TabIndex = 0;
            this.label18.Text = "CMND :";
            // 
            // btnXacNhanTT
            // 
            this.btnXacNhanTT.Location = new System.Drawing.Point(290, 23);
            this.btnXacNhanTT.Name = "btnXacNhanTT";
            this.btnXacNhanTT.Size = new System.Drawing.Size(109, 23);
            this.btnXacNhanTT.TabIndex = 5;
            this.btnXacNhanTT.Text = "Xác nhận ";
            this.btnXacNhanTT.UseVisualStyleBackColor = true;
            this.btnXacNhanTT.Click += new System.EventHandler(this.btnXacNhanTT_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 258);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Ngày Sinh : ";
            // 
            // dtpNgaySinhKHTraPhong
            // 
            this.dtpNgaySinhKHTraPhong.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinhKHTraPhong.Location = new System.Drawing.Point(90, 252);
            this.dtpNgaySinhKHTraPhong.Name = "dtpNgaySinhKHTraPhong";
            this.dtpNgaySinhKHTraPhong.Size = new System.Drawing.Size(145, 20);
            this.dtpNgaySinhKHTraPhong.TabIndex = 18;
            // 
            // FrmTraPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 822);
            this.Controls.Add(this.btnXacNhanTT);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.cbbKhachTP);
            this.Controls.Add(this.label1);
            this.Name = "FrmTraPhong";
            this.Text = "FrmTraPhong";
            this.Load += new System.EventHandler(this.FrmTraPhong_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDVuThanhToan)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbKhachTP;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvDVuThanhToan;
        private System.Windows.Forms.TextBox txtTongTienTT;
        private System.Windows.Forms.TextBox txtSoNgay;
        private System.Windows.Forms.TextBox txtGiaPhong;
        private System.Windows.Forms.TextBox txtLoaiPTT;
        private System.Windows.Forms.TextBox txtTenPTT;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radNuTraPhong;
        private System.Windows.Forms.RadioButton radNamTraPhong;
        private System.Windows.Forms.TextBox txtLienLacTraPhong;
        private System.Windows.Forms.TextBox txtQuocTichTraPhong;
        private System.Windows.Forms.TextBox txtCMNDKHTraPhong;
        private System.Windows.Forms.TextBox txtTenKHTraPhong;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnHoaDon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNgayNhanPhong;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpNgayTraPhong;
        private System.Windows.Forms.Button btnXacNhanTT;
        private System.Windows.Forms.TextBox txtNVTT;
        private System.Windows.Forms.DateTimePicker dtpTEST;
        private System.Windows.Forms.TextBox txtTongTienDV;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTraTien;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DateTimePicker dtpNgaySinhKHTraPhong;
        private System.Windows.Forms.Label label7;
    }
}