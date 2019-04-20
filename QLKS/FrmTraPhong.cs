using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace QLKS
{
    public partial class FrmTraPhong : Form
    {
        public string Ten;
     
        public FrmTraPhong()
        {
            InitializeComponent();
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            // this.Close();
            // khi click vào sẽ cập nhật tình trạng phòng lại là trống 
            HoaDon_DTO HD =new HoaDon_DTO();
            HD.MaHD = txtMaHD.Text;
            HD.MaNV = txtMaNVPhuTrach.Text;
            HD.MaPhong = cbbKhachTP.SelectedValue.ToString();
            HD.TenKH = txtTenKHTraPhong.Text;
            HD.NgayDatPhong = DateTime.Parse(dtpTEST.Text);
            HD.NgayTraPhong = DateTime.Parse(dtpNgayTraPhong.Text);
            HD.GiaHD = int.Parse(txtTraTien.Text);
            if(BUS_HoaDon.AddInvoice(HD) == true)
            {
                Phong_DTO P = new Phong_DTO();
                P.MaPhong = cbbKhachTP.SelectedValue.ToString();
                if(BUS_Phong.UpdateEmptyRoom(P))
                {
                    
                    //KhachHang_DTO K = new KhachHang_DTO();
                    //K.MaKH = txtMaKHTraPhong.Text;
                   // if(BUS_KhachHang.deleteCustomer(K) == true)
                    //{
                        MessageBox.Show("Thanh toán thành công !", "Thông báo !!!");
                        this.Close();
                    //  FrmMain main = new FrmMain();
                    // this.Hide();
                    // main.ShowDialog();

                    //}
                }
            }
            else
            {
                MessageBox.Show("Thanh toán không thành công !", "Thông báo !!!");
            }




        }

        private void FrmTraPhong_Load(object sender, EventArgs e)
        {
            cbbKhachTP.DataSource = BUS_Phong.TakeAllOderedRooms();
            cbbKhachTP.DisplayMember = "MaPhong";
            cbbKhachTP.ValueMember = "MaPhong";
            txtNVTT.Text = Ten;
            txtNVTT.Enabled = false;
            //string id = txtMaNVPhuTrach.Text;
            //MessageBox.Show(Ten);
            showMaNVInTXT(Ten);

            dgvHoaDon.DataSource = BUS_HoaDon.takeInvoice();

            int id = dgvHoaDon.Rows.Count;

            txtMaHD.Text = "HD00" + ++id;

            
        }

        private void cbbKhachTP_SelectedValueChanged(object sender, EventArgs e)
        {
          
        }
        void showMaNVInTXT(string Ten)
        {
            List<TaiKhoan_DTO> lst = BUS_TaiKhoan.takeALLAccount(Ten);
            foreach(TaiKhoan_DTO item in lst)
            {
                txtMaNVPhuTrach.Text = item.MaNV.ToString();
            }
        }
        void ShowInTXT(string ID)
        {
           List<KhachHang_DTO> K = BUS_KhachHang.takeAllCustomerFiDPhong(ID);
                foreach (KhachHang_DTO item in K)
                {
                    txtMaKHTraPhong.Text = item.MaKH.ToString();
                    txtTenKHTraPhong.Text = item.TenKH.ToString();
                    txtCMNDKHTraPhong.Text = item.Cmnd.ToString();
                    txtQuocTichTraPhong.Text = item.QuocTich.ToString();
                    if (item.GioiTinh.ToString() == "Nam")
                        radNamTraPhong.Checked = true;
                    else
                        radNuTraPhong.Checked = true;
                // txtTuoiTraPhong.Text = item.Tuoi.ToString();
                dtpNgaySinhKHTraPhong.Text = item.NgaySinh.ToString();
                    txtLienLacTraPhong.Text ="0" +item.Sdt.ToString();

                }  
                
        }

        

        void showService(string ID)
        {
            dgvDVuThanhToan.DataSource = BUS_DichVu.takeAllServiceFId(ID);
            dgvDVuThanhToan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void cbbKhachTP_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void cbbKhachTP_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string id = cbbKhachTP.SelectedValue.ToString();
            ShowInTXT(id);
            showTTThanhToan(id);
            showService(id);
            loadMoney(id);
        }

        private void cbbKhachTP_Click(object sender, EventArgs e)
        {
            
        }

        private void cbbKhachTP_ValueMemberChanged(object sender, EventArgs e)
        {
           
        }

        private void cbbKhachTP_DisplayMemberChanged(object sender, EventArgs e)
        {
           
        }

        private void cbbKhachTP_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnXacNhanTT_Click(object sender, EventArgs e)
        {
            
        }

        private void txtNgayNhanPhong_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void dtpNgayTraPhong_ValueChanged(object sender, EventArgs e)
        {
           

        }
        void showTTThanhToan(string Id)
        {
            List<Phong_DTO> P = BUS_Phong.takeALLRoomsFId(Id);
            foreach (Phong_DTO item in P)
            {
                txtTenPTT.Text = item.TenPhong.ToString();
                txtLoaiPTT.Text = item.LoaiPhong.ToString();
                txtGiaPhong.Text = item.GiaPhong.ToString();
                dtpTEST.Text = item.NgayDatPhong.ToString();
            }
        }
        void loadMoney(string id)
        {
            List<DichVu_DTO> D = BUS_DichVu.takeAllServiceFId(id);
            foreach (DichVu_DTO item in D)
            {
                // txtTongTienDV.Text = item.GiaDV.ToString();
                int SLuong = item.SoLuong;
                int price = item.GiaDV;
                int Money = SLuong * price;
                txtTongTienDV.Text = Money.ToString();
            }
        }

        private void txtSoNgay_TextChanged(object sender, EventArgs e)
        {

            int money = int.Parse(txtSoNgay.Text);
            int price = int.Parse(txtGiaPhong.Text);
            int result = money * price;
            txtTongTienTT.Text = result.ToString();

            //

           
        }

        private void txtTongTienTT_TextChanged(object sender, EventArgs e)
        {

            

        }
        private void dgvDVuThanhToan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        //    if (dgvDVuThanhToan.CurrentCell != null && dgvDVuThanhToan.CurrentCell.Value != null)
        //    {
        //        MessageBox.Show(dgvDVuThanhToan.CurrentCell.Value.ToString());
        //    }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void dtpTEST_ValueChanged(object sender, EventArgs e)
        {
            DateTime date1 = Convert.ToDateTime(dtpTEST.Text);
            DateTime date2 = Convert.ToDateTime(dtpNgayTraPhong.Text);
            TimeSpan time = date2.Subtract(date1);
            int days = time.Days;
            txtSoNgay.Text = days.ToString();
          //  txtSoThang.Text = Math.Floor(days / 30.0).ToString();
            //txtSoNam.Text = Math.Floor(days / 365.0).ToString();


        }

        private void txtTongTienDV_TextChanged(object sender, EventArgs e)
        {
            int moneyFinal = int.Parse(txtTongTienTT.Text);
            int priceFinal = int.Parse(txtTongTienDV.Text);
            int resultFinal = moneyFinal + priceFinal;
            txtTraTien.Text = resultFinal.ToString();
        }
    }
}
