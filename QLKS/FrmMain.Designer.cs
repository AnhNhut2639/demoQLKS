namespace QLKS
{
    partial class FrmMain
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
            this.lb2 = new System.Windows.Forms.Label();
            this.lb1 = new System.Windows.Forms.Label();
            this.lb4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.linkQLP = new System.Windows.Forms.LinkLabel();
            this.linkTraPhong = new System.Windows.Forms.LinkLabel();
            this.linkQLNV = new System.Windows.Forms.LinkLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quảnLýPhòngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trảPhòngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýNhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêDoanhThuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flpRoom = new System.Windows.Forms.FlowLayoutPanel();
            this.dgvKHDaDat = new System.Windows.Forms.DataGridView();
            this.dgvDichVuDaDat = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTenDV = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.gpDichVuKH = new System.Windows.Forms.GroupBox();
            this.btnSuaSoLuong = new System.Windows.Forms.Button();
            this.btnLuuDV = new System.Windows.Forms.Button();
            this.cbbMaDV = new System.Windows.Forms.ComboBox();
            this.gbXoaDV = new System.Windows.Forms.GroupBox();
            this.btnXoaDVVuaChon = new System.Windows.Forms.Button();
            this.cbbXoaDv = new System.Windows.Forms.ComboBox();
            this.txtGiaDVXoa = new System.Windows.Forms.TextBox();
            this.txtSoLuongXoa = new System.Windows.Forms.TextBox();
            this.txtTenDVXoa = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKHDaDat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDichVuDaDat)).BeginInit();
            this.gpDichVuKH.SuspendLayout();
            this.gbXoaDV.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb2.ForeColor = System.Drawing.Color.Red;
            this.lb2.Location = new System.Drawing.Point(944, 4);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(42, 20);
            this.lb2.TabIndex = 7;
            this.lb2.Text = "label";
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(1140, 11);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(35, 13);
            this.lb1.TabIndex = 0;
            this.lb1.Text = "label1";
            // 
            // lb4
            // 
            this.lb4.AutoSize = true;
            this.lb4.Location = new System.Drawing.Point(1321, 9);
            this.lb4.Name = "lb4";
            this.lb4.Size = new System.Drawing.Size(35, 13);
            this.lb4.TabIndex = 1;
            this.lb4.Text = "label1";
            this.lb4.Click += new System.EventHandler(this.lb4_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.linkQLP);
            this.groupBox1.Controls.Add(this.linkTraPhong);
            this.groupBox1.Controls.Add(this.linkQLNV);
            this.groupBox1.Location = new System.Drawing.Point(65, 484);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(512, 216);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tác vụ";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // linkQLP
            // 
            this.linkQLP.AutoSize = true;
            this.linkQLP.Location = new System.Drawing.Point(13, 73);
            this.linkQLP.Name = "linkQLP";
            this.linkQLP.Size = new System.Drawing.Size(76, 13);
            this.linkQLP.TabIndex = 9;
            this.linkQLP.TabStop = true;
            this.linkQLP.Text = "Quản lý phòng";
            this.linkQLP.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkQLP_LinkClicked);
            // 
            // linkTraPhong
            // 
            this.linkTraPhong.AutoSize = true;
            this.linkTraPhong.Location = new System.Drawing.Point(13, 117);
            this.linkTraPhong.Name = "linkTraPhong";
            this.linkTraPhong.Size = new System.Drawing.Size(56, 13);
            this.linkTraPhong.TabIndex = 8;
            this.linkTraPhong.TabStop = true;
            this.linkTraPhong.Text = "Trả phòng";
            this.linkTraPhong.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkTraPhong_LinkClicked);
            // 
            // linkQLNV
            // 
            this.linkQLNV.AutoSize = true;
            this.linkQLNV.Location = new System.Drawing.Point(6, 38);
            this.linkQLNV.Name = "linkQLNV";
            this.linkQLNV.Size = new System.Drawing.Size(93, 13);
            this.linkQLNV.TabIndex = 7;
            this.linkQLNV.TabStop = true;
            this.linkQLNV.Text = "Quản lý nhân viên";
            this.linkQLNV.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkQLNV_LinkClicked);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýPhòngToolStripMenuItem,
            this.trảPhòngToolStripMenuItem,
            this.quảnLýNhânViênToolStripMenuItem,
            this.thốngKêDoanhThuToolStripMenuItem,
            this.tàiKhoảnToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1439, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quảnLýPhòngToolStripMenuItem
            // 
            this.quảnLýPhòngToolStripMenuItem.Name = "quảnLýPhòngToolStripMenuItem";
            this.quảnLýPhòngToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.quảnLýPhòngToolStripMenuItem.Text = "Quản lý phòng";
            this.quảnLýPhòngToolStripMenuItem.Click += new System.EventHandler(this.quảnLýPhòngToolStripMenuItem_Click);
            // 
            // trảPhòngToolStripMenuItem
            // 
            this.trảPhòngToolStripMenuItem.Name = "trảPhòngToolStripMenuItem";
            this.trảPhòngToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.trảPhòngToolStripMenuItem.Text = "Trả Phòng";
            this.trảPhòngToolStripMenuItem.Click += new System.EventHandler(this.trảPhòngToolStripMenuItem_Click);
            // 
            // quảnLýNhânViênToolStripMenuItem
            // 
            this.quảnLýNhânViênToolStripMenuItem.Name = "quảnLýNhânViênToolStripMenuItem";
            this.quảnLýNhânViênToolStripMenuItem.Size = new System.Drawing.Size(115, 20);
            this.quảnLýNhânViênToolStripMenuItem.Text = "Quản lý nhân viên";
            this.quảnLýNhânViênToolStripMenuItem.Click += new System.EventHandler(this.quảnLýNhânViênToolStripMenuItem_Click);
            // 
            // thốngKêDoanhThuToolStripMenuItem
            // 
            this.thốngKêDoanhThuToolStripMenuItem.Name = "thốngKêDoanhThuToolStripMenuItem";
            this.thốngKêDoanhThuToolStripMenuItem.Size = new System.Drawing.Size(130, 20);
            this.thốngKêDoanhThuToolStripMenuItem.Text = "Thống kê doanh thu ";
            // 
            // tàiKhoảnToolStripMenuItem
            // 
            this.tàiKhoảnToolStripMenuItem.Name = "tàiKhoảnToolStripMenuItem";
            this.tàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.tàiKhoảnToolStripMenuItem.Text = "Tài khoản";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click_1);
            // 
            // flpRoom
            // 
            this.flpRoom.BackColor = System.Drawing.Color.Gainsboro;
            this.flpRoom.Location = new System.Drawing.Point(52, 86);
            this.flpRoom.Name = "flpRoom";
            this.flpRoom.Size = new System.Drawing.Size(525, 363);
            this.flpRoom.TabIndex = 10;
            // 
            // dgvKHDaDat
            // 
            this.dgvKHDaDat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKHDaDat.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvKHDaDat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKHDaDat.Location = new System.Drawing.Point(641, 118);
            this.dgvKHDaDat.Name = "dgvKHDaDat";
            this.dgvKHDaDat.Size = new System.Drawing.Size(690, 124);
            this.dgvKHDaDat.TabIndex = 11;
            // 
            // dgvDichVuDaDat
            // 
            this.dgvDichVuDaDat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDichVuDaDat.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDichVuDaDat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDichVuDaDat.Location = new System.Drawing.Point(641, 290);
            this.dgvDichVuDaDat.Name = "dgvDichVuDaDat";
            this.dgvDichVuDaDat.Size = new System.Drawing.Size(690, 111);
            this.dgvDichVuDaDat.TabIndex = 12;
            this.dgvDichVuDaDat.Click += new System.EventHandler(this.dgvDichVuDaDat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(817, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "Welcome";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(852, 426);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(102, 23);
            this.btnThem.TabIndex = 14;
            this.btnThem.Text = "Thêm dịch vụ ";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(1017, 426);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(84, 23);
            this.btnXoa.TabIndex = 16;
            this.btnXoa.Text = "Xóa dịch vụ";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Mã dịch vụ :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(336, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Tên dịch vụ :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Số lượng :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(350, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Giá :";
            // 
            // txtTenDV
            // 
            this.txtTenDV.Location = new System.Drawing.Point(455, 51);
            this.txtTenDV.Name = "txtTenDV";
            this.txtTenDV.Size = new System.Drawing.Size(147, 20);
            this.txtTenDV.TabIndex = 30;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(133, 102);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(143, 20);
            this.txtSoLuong.TabIndex = 31;
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(455, 102);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(147, 20);
            this.txtGia.TabIndex = 32;
            // 
            // gpDichVuKH
            // 
            this.gpDichVuKH.Controls.Add(this.btnSuaSoLuong);
            this.gpDichVuKH.Controls.Add(this.btnLuuDV);
            this.gpDichVuKH.Controls.Add(this.cbbMaDV);
            this.gpDichVuKH.Controls.Add(this.txtGia);
            this.gpDichVuKH.Controls.Add(this.txtSoLuong);
            this.gpDichVuKH.Controls.Add(this.txtTenDV);
            this.gpDichVuKH.Controls.Add(this.label5);
            this.gpDichVuKH.Controls.Add(this.label4);
            this.gpDichVuKH.Controls.Add(this.label3);
            this.gpDichVuKH.Controls.Add(this.label2);
            this.gpDichVuKH.Location = new System.Drawing.Point(743, 499);
            this.gpDichVuKH.Name = "gpDichVuKH";
            this.gpDichVuKH.Size = new System.Drawing.Size(653, 202);
            this.gpDichVuKH.TabIndex = 33;
            this.gpDichVuKH.TabStop = false;
            this.gpDichVuKH.Text = "Thêm dịch vụ";
            // 
            // btnSuaSoLuong
            // 
            this.btnSuaSoLuong.Location = new System.Drawing.Point(128, 145);
            this.btnSuaSoLuong.Name = "btnSuaSoLuong";
            this.btnSuaSoLuong.Size = new System.Drawing.Size(115, 23);
            this.btnSuaSoLuong.TabIndex = 36;
            this.btnSuaSoLuong.Text = "cập nhật số lượng";
            this.btnSuaSoLuong.UseVisualStyleBackColor = true;
            this.btnSuaSoLuong.Click += new System.EventHandler(this.btnSuaSoLuong_Click);
            // 
            // btnLuuDV
            // 
            this.btnLuuDV.Location = new System.Drawing.Point(486, 157);
            this.btnLuuDV.Name = "btnLuuDV";
            this.btnLuuDV.Size = new System.Drawing.Size(75, 23);
            this.btnLuuDV.TabIndex = 35;
            this.btnLuuDV.Text = "Lưu";
            this.btnLuuDV.UseVisualStyleBackColor = true;
            this.btnLuuDV.Click += new System.EventHandler(this.btnLuuDV_Click);
            // 
            // cbbMaDV
            // 
            this.cbbMaDV.FormattingEnabled = true;
            this.cbbMaDV.Location = new System.Drawing.Point(128, 50);
            this.cbbMaDV.Name = "cbbMaDV";
            this.cbbMaDV.Size = new System.Drawing.Size(143, 21);
            this.cbbMaDV.TabIndex = 34;
            this.cbbMaDV.SelectionChangeCommitted += new System.EventHandler(this.cbbMaDV_SelectionChangeCommitted);
            this.cbbMaDV.SelectedValueChanged += new System.EventHandler(this.cbbMaDV_SelectedValueChanged);
            // 
            // gbXoaDV
            // 
            this.gbXoaDV.Controls.Add(this.btnXoaDVVuaChon);
            this.gbXoaDV.Controls.Add(this.cbbXoaDv);
            this.gbXoaDV.Controls.Add(this.txtGiaDVXoa);
            this.gbXoaDV.Controls.Add(this.txtSoLuongXoa);
            this.gbXoaDV.Controls.Add(this.txtTenDVXoa);
            this.gbXoaDV.Controls.Add(this.label6);
            this.gbXoaDV.Controls.Add(this.label7);
            this.gbXoaDV.Controls.Add(this.label8);
            this.gbXoaDV.Controls.Add(this.label9);
            this.gbXoaDV.Location = new System.Drawing.Point(743, 522);
            this.gbXoaDV.Name = "gbXoaDV";
            this.gbXoaDV.Size = new System.Drawing.Size(653, 181);
            this.gbXoaDV.TabIndex = 36;
            this.gbXoaDV.TabStop = false;
            this.gbXoaDV.Text = "Xóa dịch vụ";
            // 
            // btnXoaDVVuaChon
            // 
            this.btnXoaDVVuaChon.Location = new System.Drawing.Point(486, 131);
            this.btnXoaDVVuaChon.Name = "btnXoaDVVuaChon";
            this.btnXoaDVVuaChon.Size = new System.Drawing.Size(75, 28);
            this.btnXoaDVVuaChon.TabIndex = 35;
            this.btnXoaDVVuaChon.Text = "Xóa dịch vụ";
            this.btnXoaDVVuaChon.UseVisualStyleBackColor = true;
            this.btnXoaDVVuaChon.Click += new System.EventHandler(this.btnXoaDVVuaChon_Click);
            // 
            // cbbXoaDv
            // 
            this.cbbXoaDv.FormattingEnabled = true;
            this.cbbXoaDv.Location = new System.Drawing.Point(128, 50);
            this.cbbXoaDv.Name = "cbbXoaDv";
            this.cbbXoaDv.Size = new System.Drawing.Size(143, 21);
            this.cbbXoaDv.TabIndex = 34;
            // 
            // txtGiaDVXoa
            // 
            this.txtGiaDVXoa.Location = new System.Drawing.Point(455, 102);
            this.txtGiaDVXoa.Name = "txtGiaDVXoa";
            this.txtGiaDVXoa.Size = new System.Drawing.Size(147, 20);
            this.txtGiaDVXoa.TabIndex = 32;
            // 
            // txtSoLuongXoa
            // 
            this.txtSoLuongXoa.Location = new System.Drawing.Point(133, 102);
            this.txtSoLuongXoa.Name = "txtSoLuongXoa";
            this.txtSoLuongXoa.Size = new System.Drawing.Size(143, 20);
            this.txtSoLuongXoa.TabIndex = 31;
            // 
            // txtTenDVXoa
            // 
            this.txtTenDVXoa.Location = new System.Drawing.Point(455, 51);
            this.txtTenDVXoa.Name = "txtTenDVXoa";
            this.txtTenDVXoa.Size = new System.Drawing.Size(147, 20);
            this.txtTenDVXoa.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(350, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Giá :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(56, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Số lượng :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(336, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Tên dịch vụ :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(56, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Mã dịch vụ :";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 787);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1439, 22);
            this.statusStrip1.TabIndex = 37;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1439, 809);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.gbXoaDV);
            this.Controls.Add(this.gpDichVuKH);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDichVuDaDat);
            this.Controls.Add(this.dgvKHDaDat);
            this.Controls.Add(this.flpRoom);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.lb4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMain";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKHDaDat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDichVuDaDat)).EndInit();
            this.gpDichVuKH.ResumeLayout(false);
            this.gpDichVuKH.PerformLayout();
            this.gbXoaDV.ResumeLayout(false);
            this.gbXoaDV.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label lb4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel linkQLP;
        private System.Windows.Forms.LinkLabel linkTraPhong;
        private System.Windows.Forms.LinkLabel linkQLNV;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quảnLýPhòngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trảPhòngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýNhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêDoanhThuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel flpRoom;
        private System.Windows.Forms.DataGridView dgvKHDaDat;
        private System.Windows.Forms.DataGridView dgvDichVuDaDat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTenDV;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.GroupBox gpDichVuKH;
        private System.Windows.Forms.ComboBox cbbMaDV;
        private System.Windows.Forms.Button btnLuuDV;
        private System.Windows.Forms.GroupBox gbXoaDV;
        private System.Windows.Forms.ComboBox cbbXoaDv;
        private System.Windows.Forms.TextBox txtGiaDVXoa;
        private System.Windows.Forms.TextBox txtSoLuongXoa;
        private System.Windows.Forms.TextBox txtTenDVXoa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnXoaDVVuaChon;
        private System.Windows.Forms.Button btnSuaSoLuong;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}