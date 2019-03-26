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
            this.liL1 = new System.Windows.Forms.LinkLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.themeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýPhòngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trảPhòngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýNhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêDoanhThuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flpRoom = new System.Windows.Forms.FlowLayoutPanel();
            this.dgvKHDaDat = new System.Windows.Forms.DataGridView();
            this.dgvDichVuDaDat = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKHDaDat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDichVuDaDat)).BeginInit();
            this.SuspendLayout();
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb2.ForeColor = System.Drawing.Color.Red;
            this.lb2.Location = new System.Drawing.Point(916, 59);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(42, 20);
            this.lb2.TabIndex = 7;
            this.lb2.Text = "label";
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(1161, 55);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(35, 13);
            this.lb1.TabIndex = 0;
            this.lb1.Text = "label1";
            // 
            // lb4
            // 
            this.lb4.AutoSize = true;
            this.lb4.Location = new System.Drawing.Point(1245, 55);
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
            this.groupBox1.Controls.Add(this.liL1);
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
            this.linkQLP.Location = new System.Drawing.Point(13, 119);
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
            this.linkTraPhong.Location = new System.Drawing.Point(13, 161);
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
            this.linkQLNV.Location = new System.Drawing.Point(13, 82);
            this.linkQLNV.Name = "linkQLNV";
            this.linkQLNV.Size = new System.Drawing.Size(93, 13);
            this.linkQLNV.TabIndex = 7;
            this.linkQLNV.TabStop = true;
            this.linkQLNV.Text = "Quản lý nhân viên";
            this.linkQLNV.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkQLNV_LinkClicked);
            // 
            // liL1
            // 
            this.liL1.AutoSize = true;
            this.liL1.LinkColor = System.Drawing.Color.Red;
            this.liL1.Location = new System.Drawing.Point(13, 38);
            this.liL1.Name = "liL1";
            this.liL1.Size = new System.Drawing.Size(97, 13);
            this.liL1.TabIndex = 6;
            this.liL1.TabStop = true;
            this.liL1.Text = "Thêm Khách Hàng";
            this.liL1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.liL1_LinkClicked);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.themeToolStripMenuItem,
            this.quảnLýPhòngToolStripMenuItem,
            this.trảPhòngToolStripMenuItem,
            this.quảnLýNhânViênToolStripMenuItem,
            this.thốngKêDoanhThuToolStripMenuItem,
            this.tàiKhoảnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1439, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // themeToolStripMenuItem
            // 
            this.themeToolStripMenuItem.Name = "themeToolStripMenuItem";
            this.themeToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.themeToolStripMenuItem.Text = "Thêm Khách hàng";
            this.themeToolStripMenuItem.Click += new System.EventHandler(this.themeToolStripMenuItem_Click);
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
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(809, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "Welcome";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1439, 809);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label lb4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel liL1;
        private System.Windows.Forms.LinkLabel linkQLP;
        private System.Windows.Forms.LinkLabel linkTraPhong;
        private System.Windows.Forms.LinkLabel linkQLNV;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem themeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýPhòngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trảPhòngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýNhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêDoanhThuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel flpRoom;
        private System.Windows.Forms.DataGridView dgvKHDaDat;
        private System.Windows.Forms.DataGridView dgvDichVuDaDat;
        private System.Windows.Forms.Label label1;
    }
}