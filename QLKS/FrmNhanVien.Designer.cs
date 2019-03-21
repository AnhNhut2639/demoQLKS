namespace QLKS
{
    partial class FrmNhanVien
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radNuNV = new System.Windows.Forms.RadioButton();
            this.radNamNV = new System.Windows.Forms.RadioButton();
            this.dtpNamSinhNV = new System.Windows.Forms.DateTimePicker();
            this.cbbChucVu = new System.Windows.Forms.ComboBox();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnXoaNV = new System.Windows.Forms.Button();
            this.btnSuaNV = new System.Windows.Forms.Button();
            this.btnThemNV = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.btnThoatNhanVien = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radNuNV);
            this.groupBox1.Controls.Add(this.radNamNV);
            this.groupBox1.Controls.Add(this.dtpNamSinhNV);
            this.groupBox1.Controls.Add(this.cbbChucVu);
            this.groupBox1.Controls.Add(this.txtTenNV);
            this.groupBox1.Controls.Add(this.txtMaNV);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(53, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(785, 290);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhân viên :";
            // 
            // radNuNV
            // 
            this.radNuNV.AutoSize = true;
            this.radNuNV.Location = new System.Drawing.Point(220, 220);
            this.radNuNV.Name = "radNuNV";
            this.radNuNV.Size = new System.Drawing.Size(39, 17);
            this.radNuNV.TabIndex = 13;
            this.radNuNV.TabStop = true;
            this.radNuNV.Text = "Nữ";
            this.radNuNV.UseVisualStyleBackColor = true;
            // 
            // radNamNV
            // 
            this.radNamNV.AutoSize = true;
            this.radNamNV.Location = new System.Drawing.Point(113, 220);
            this.radNamNV.Name = "radNamNV";
            this.radNamNV.Size = new System.Drawing.Size(47, 17);
            this.radNamNV.TabIndex = 12;
            this.radNamNV.TabStop = true;
            this.radNamNV.Text = "Nam";
            this.radNamNV.UseVisualStyleBackColor = true;
            // 
            // dtpNamSinhNV
            // 
            this.dtpNamSinhNV.Location = new System.Drawing.Point(96, 173);
            this.dtpNamSinhNV.Name = "dtpNamSinhNV";
            this.dtpNamSinhNV.Size = new System.Drawing.Size(200, 20);
            this.dtpNamSinhNV.TabIndex = 11;
            // 
            // cbbChucVu
            // 
            this.cbbChucVu.FormattingEnabled = true;
            this.cbbChucVu.Location = new System.Drawing.Point(139, 114);
            this.cbbChucVu.Name = "cbbChucVu";
            this.cbbChucVu.Size = new System.Drawing.Size(119, 21);
            this.cbbChucVu.TabIndex = 10;
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(137, 75);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(121, 20);
            this.txtTenNV.TabIndex = 9;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(138, 33);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(120, 20);
            this.txtMaNV.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mã NV :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Giới Tính :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Năm Sinh :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chức vụ :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên NV:";
            // 
            // btnXoaNV
            // 
            this.btnXoaNV.Location = new System.Drawing.Point(21, 157);
            this.btnXoaNV.Name = "btnXoaNV";
            this.btnXoaNV.Size = new System.Drawing.Size(75, 23);
            this.btnXoaNV.TabIndex = 7;
            this.btnXoaNV.Text = "Xóa";
            this.btnXoaNV.UseVisualStyleBackColor = true;
            // 
            // btnSuaNV
            // 
            this.btnSuaNV.Location = new System.Drawing.Point(21, 105);
            this.btnSuaNV.Name = "btnSuaNV";
            this.btnSuaNV.Size = new System.Drawing.Size(75, 23);
            this.btnSuaNV.TabIndex = 6;
            this.btnSuaNV.Text = "Sửa ";
            this.btnSuaNV.UseVisualStyleBackColor = true;
            // 
            // btnThemNV
            // 
            this.btnThemNV.Location = new System.Drawing.Point(21, 56);
            this.btnThemNV.Name = "btnThemNV";
            this.btnThemNV.Size = new System.Drawing.Size(75, 23);
            this.btnThemNV.TabIndex = 5;
            this.btnThemNV.Text = "Thêm";
            this.btnThemNV.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvNhanVien);
            this.groupBox2.Location = new System.Drawing.Point(36, 373);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1220, 324);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách nhân viên :";
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Location = new System.Drawing.Point(42, 19);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.Size = new System.Drawing.Size(1141, 277);
            this.dgvNhanVien.TabIndex = 0;
            // 
            // btnThoatNhanVien
            // 
            this.btnThoatNhanVien.Location = new System.Drawing.Point(1170, 703);
            this.btnThoatNhanVien.Name = "btnThoatNhanVien";
            this.btnThoatNhanVien.Size = new System.Drawing.Size(75, 23);
            this.btnThoatNhanVien.TabIndex = 3;
            this.btnThoatNhanVien.Text = "Thoát";
            this.btnThoatNhanVien.UseVisualStyleBackColor = true;
            this.btnThoatNhanVien.Click += new System.EventHandler(this.btnThoatNhanVien_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox3.Controls.Add(this.btnThemNV);
            this.groupBox3.Controls.Add(this.btnSuaNV);
            this.groupBox3.Controls.Add(this.btnXoaNV);
            this.groupBox3.Location = new System.Drawing.Point(865, 72);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(179, 273);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tác vụ :";
            // 
            // FrmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1305, 744);
            this.Controls.Add(this.btnThoatNhanVien);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmNhanVien";
            this.Text = "FrmNhanVien";
            this.Load += new System.EventHandler(this.FrmNhanVien_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.RadioButton radNuNV;
        private System.Windows.Forms.RadioButton radNamNV;
        private System.Windows.Forms.DateTimePicker dtpNamSinhNV;
        private System.Windows.Forms.ComboBox cbbChucVu;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Button btnXoaNV;
        private System.Windows.Forms.Button btnSuaNV;
        private System.Windows.Forms.Button btnThemNV;
        private System.Windows.Forms.Button btnThoatNhanVien;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}