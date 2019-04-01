using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;

namespace QLKS
{
    public partial class FrmMain : Form
    {
        public string A;
        public string B;
        public FrmMain()
        {
            InitializeComponent();
            loadRoom();
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            //FrmKhachHang frmKH = new FrmKhachHang();
            //this.Hide();
            //frmKH.ShowDialog();
            //this.Show();
        }

        private void btnTraPhong_Click(object sender, EventArgs e)
        {
            //FrmTraPhong frmTp = new FrmTraPhong();
            //this.Hide();
            //frmTp.ShowDialog();
            //this.Show();

        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            //FrmNhanVien nv = new FrmNhanVien();
            //this.Hide();
            //nv.ShowDialog();
            //this.Show();
        }

        private void btnDichVu_Click(object sender, EventArgs e)
        {

        }

        private void btnPhong_Click(object sender, EventArgs e)
        {
            //FrmPhong frmP = new FrmPhong();
            //this.Hide();
            //frmP.ShowDialog();
            //this.Show();
        }
        void showService(string ID)
        {
            dgvDichVuDaDat.DataSource = BUS_DichVu.takeAllServiceFId(ID);
            dgvDichVuDaDat.Columns["MaDV"].HeaderText = "Mã dịch vụ";
            dgvDichVuDaDat.Columns["TenDV"].HeaderText = "Tên dịch vụ";
            dgvDichVuDaDat.Columns["SoLuong"].HeaderText = "Số lượng";
            dgvDichVuDaDat.Columns["GiaDV"].HeaderText = "Giá dịch vụ";
        }

        void ShowDGVKhachHang(string ID)
        {
            List<KhachHang_DTO> lst = BUS_KhachHang.takeCustomerAllID(ID);
           dgvKHDaDat.DataSource = lst;
            dgvKHDaDat.Columns["MaKH"].HeaderText = "Mã Khách hàng";
            dgvKHDaDat.Columns["TenKH"].HeaderText = "Tên Khách hàng";
            dgvKHDaDat.Columns["CMND"].HeaderText = "CMND";
            dgvKHDaDat.Columns["QuocTich"].HeaderText = "Quốc Tịch";
            dgvKHDaDat.Columns["GioiTinh"].HeaderText = "Giới Tính";
            dgvKHDaDat.Columns["NgaySinh"].HeaderText = "Ngày Sinh";
           dgvKHDaDat.Columns["SDT"].HeaderText = "Liên Lạc";
           dgvKHDaDat.Columns["MaPhong"].HeaderText = "Mã Phòng";
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            
          //  ShowDGVKhachHang();
            
            if(BUS_DangNhap.TakeAllAccounts(A,B)) // xác nhận tài khoản như formMain nếu đúng tiến hành nhân dạng
            {
                MessageBox.Show("Bạn đã đăng nhập với quyền " +BUS_DangNhap.getAllChucVu(A, B) , "Thông Báo");
                lb2.Text = BUS_DangNhap.getAllName(A, B); // nhận dạng người dùng thông qua tài khoản mà họ đăng nhập trước đó
                lb1.Text = "Phân quyền " + BUS_DangNhap.getPer(A, B); // lấy ID khi để phân quyền 
                lb4.Text = "Chức Vụ " + BUS_DangNhap.getAllChucVu(A, B);
            }
            cbbMaDV.DataSource = BUS_DichVu.takeAllServiceTest();
            cbbMaDV.DisplayMember = "MaDV";
            cbbMaDV.ValueMember = "MaDV";


            btnThem.Visible = false;           
            btnXoa.Visible = false;
            gpDichVuKH.Visible = false;
            gbXoaDV.Visible = false;
            dgvKHDaDat.Visible = false;
            dgvDichVuDaDat.Visible = false;
            



        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            //DialogResult dlr = MessageBox.Show("Bạn có thực sự muốn đăng xuất", "Thông báo !!!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            //if (dlr == DialogResult.Yes)
            //{
               
            //    Form1 frmDangNhap = new Form1();
            //    this.Hide();
            //    frmDangNhap.ShowDialog();
            //}
            

        }

        private void lb4_Click(object sender, EventArgs e)
        {

        }

        private void liL1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmKhachHang frmKH = new FrmKhachHang();
            this.Hide();
            frmKH.ShowDialog();
            this.Show();
        }

        private void linkQLNV_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmNhanVien nv = new FrmNhanVien();
            this.Hide();
            nv.ShowDialog();
            this.Show();
        }

        private void linkQLP_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmPhong frmP = new FrmPhong();
            this.Hide();
            frmP.ShowDialog();
            //this.Show();
        }

        private void linkTraPhong_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string id = lb2.Text;
            FrmTraPhong tra = new FrmTraPhong();
            tra.Ten = id;
            this.Hide();
            tra.ShowDialog();
            this.Show();

            
           // MessageBox.Show(id);

            //}
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        void loadRoom()
        {
            List<Phong_DTO> P = BUS_Phong.TakeAllRooms();
            
            foreach(Phong_DTO item in P)
            {
                Button btn = new Button() { Height = 100, Width = 100 };
                flpRoom.Controls.Add(btn);
                btn.Text = item.TenPhong + Environment.NewLine + item.TinhTrang;
                if(item.TinhTrang == "Đã đặt")
                {
                    btn.BackColor = Color.Tomato;
                }
                else
                {
                    btn.BackColor = Color.Orange;
                }

                // sự kiện click
                btn.Click += btn_Click;
                btn.Tag = item; // trả về kiểu Object bao gồm tất cả phòng trên button


            }
        }
        public void btn_Click(object sender , EventArgs e )
        {
            Button btn = sender as Button;
            //string id = (btn.Tag as Phong_DTO).MaPhong;
            //dgvKHDaDat.DataSource = BUS_KhachHang.takeCustomerAllID(id);
            //dgvKHDaDat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //dgvDichVuDaDat.DataSource = BUS_DichVu.takeAllServiceFId(id);
            //dgvDichVuDaDat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            string status = (btn.Tag as Phong_DTO).TinhTrang;
            if(status == "Đã đặt")
            {
                // MessageBox.Show("" + status, "Thông báo !!!");
                btn.BackColor = Color.Tomato;
                string id = (btn.Tag as Phong_DTO).MaPhong;
                dgvKHDaDat.DataSource = BUS_KhachHang.takeCustomerAllID(id);
                dgvKHDaDat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvDichVuDaDat.DataSource = BUS_DichVu.takeAllServiceFId(id);
                dgvDichVuDaDat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
              //  showService(id);
               // ShowDGVKhachHang(id);

                btnThem.Visible = true;             
                btnXoa.Visible = true;

                dgvKHDaDat.Visible = true;
                dgvDichVuDaDat.Visible = true;
                
            }
            else
            {
                string ten = (btn.Tag as Phong_DTO).TenPhong;
                string maPhong = (btn.Tag as Phong_DTO).MaPhong;
                // MessageBox.Show("" + ten, "Thông Báo !!!");
                FrmKhachHang frm = new FrmKhachHang();
                this.Hide();
                frm.TenPhong = ten;
                frm.MaPhong = maPhong;
                frm.ShowDialog();
                
               // this.Show();

            }

           
           

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNhanVien f = new FrmNhanVien();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void themeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmKhachHang f = new FrmKhachHang();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void quảnLýPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPhong f = new FrmPhong();
            this.Hide();
            f.ShowDialog();
           // f.Show();

        }

        private void trảPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string id = lb2.Text;
            FrmTraPhong f = new FrmTraPhong();
            f.Ten = id;
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            gbXoaDV.Visible = false;
            gpDichVuKH.Visible = true;
            gpDichVuKH.Text = "Thêm dịch vụ";
            cbbMaDV.Enabled = false;
            txtTenDV.Enabled = false;
            txtGia.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            gpDichVuKH.Visible = false;
            gbXoaDV.Visible = true;
          //  gpDichVuKH.Text = "xóa dịch vụ";
        }

        private void dgvDichVuDaDat_Click(object sender, EventArgs e)
        {
            int current = dgvDichVuDaDat.CurrentCell.RowIndex;
            DataGridViewRow dr = dgvDichVuDaDat.Rows[current];
            cbbXoaDv.Text = dr.Cells["MaDV"].Value.ToString();
            txtTenDVXoa.Text = dr.Cells["TenDV"].Value.ToString();
            txtSoLuongXoa.Text = dr.Cells["SoLuong"].Value.ToString();
            txtGiaDVXoa.Text = dr.Cells["GiaDV"].Value.ToString();
            // sửa dv
            cbbMaDV.Text = dr.Cells["MaDV"].Value.ToString();
            txtTenDV.Text = dr.Cells["TenDV"].Value.ToString();
            txtSoLuong.Text = dr.Cells["SoLuong"].Value.ToString();
            txtGia.Text = dr.Cells["GiaDV"].Value.ToString();
        }

        private void cbbMaDV_SelectedValueChanged(object sender, EventArgs e)
        {
         
        }

        private void cbbMaDV_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string id = cbbMaDV.SelectedValue.ToString();
            ShowInTextBox(id);
            txtSoLuong.Text = "";
        }

        void ShowInTextBox(string IDDV)
        {
            List<DichVu_DTO> lstDichVu = BUS_DichVu.takeAllServiceFIdSer(IDDV);
            foreach(DichVu_DTO item in lstDichVu)
            {
                txtTenDV.Text = item.TenDV.ToString();
               // txtSoLuong.Text = item.SoLuong.ToString();
                txtGia.Text = item.GiaDV.ToString();
            }

        }

        private void btnSuaSoLuong_Click(object sender, EventArgs e)
        {
            if (txtSoLuong.Text == "")
            {
                MessageBox.Show("Nhập số lượng", "Thông báo !!!");
            }
            else
            {
                DichVu_DTO DV = new DichVu_DTO();
                DV.MaDV = cbbMaDV.SelectedValue.ToString();
                DV.SoLuong = int.Parse(txtSoLuong.Text);
                // string id = (btn.Tag as Phong_DTO).MaPhong;
                // int sl = int.Parse(txtSoLuong.Text);


                if (BUS_DichVu.UpdateSoLuong(DV) == true)
                {
                    dgvDichVuDaDat.Refresh();
                    MessageBox.Show("Đã cập nhật số lượng", "Thông báo  !!!");
                }
                else
                {
                    MessageBox.Show("không cập nhật số lượng", "Thông báo  !!!");
                }
            }
        }

        private void btnLuuDV_Click(object sender, EventArgs e)
        {

        }
    }
}
