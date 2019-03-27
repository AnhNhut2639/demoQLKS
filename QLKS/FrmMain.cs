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

        private void FrmMain_Load(object sender, EventArgs e)
        {        
            //load dữ liệu phòng trống lên DataGridview
        //    dgvPhongTrong.DataSource = BUS_Phong.TakeAllEmptyRooms();
          //  dgvPhongTrong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //load dữ liệu phòng đã đặt lên DataGridview
          //  dgvPhongDaDat.DataSource = BUS_Phong.TakeAllOderedRooms();
          //  dgvPhongDaDat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            // Nhân dạng chức vụ người đăng nhập 
            
            if(BUS_DangNhap.TakeAllAccounts(A,B)) // xác nhận tài khoản như formMain nếu đúng tiến hành nhân dạng
            {
                MessageBox.Show("Bạn đã đăng nhập với quyền " +BUS_DangNhap.getAllChucVu(A, B) , "Thông Báo");
                lb2.Text = BUS_DangNhap.getAllName(A, B); // nhận dạng người dùng thông qua tài khoản mà họ đăng nhập trước đó
                lb1.Text = "Phân quyền " + BUS_DangNhap.getPer(A, B); // lấy ID khi để phân quyền 
                lb4.Text = "Chức Vụ " + BUS_DangNhap.getAllChucVu(A, B);
            }
            
            



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
            this.Show();
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

                // sự kiện click
                btn.Click += btn_Click;
                btn.Tag = item; // trả về kiểu Object bao gồm tất cả phòng trên button


            }
        }
        public void btn_Click(object sender , EventArgs e )
        {
            Button btn = sender as Button;
            string id = (btn.Tag as Phong_DTO).MaPhong;
           // MessageBox.Show(" " + id, "Thông báo");

            dgvKHDaDat.DataSource = BUS_KhachHang.takeCustomerAllID(id);
            dgvKHDaDat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDichVuDaDat.DataSource = BUS_DichVu.takeAllServiceFId(id);
            dgvDichVuDaDat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

          



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
            f.Show();

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
    }
}
