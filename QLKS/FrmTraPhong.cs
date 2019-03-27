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
            this.Close();
            // khi click vào sẽ cập nhật tình trạng phòng lại là trống 
        }

        private void FrmTraPhong_Load(object sender, EventArgs e)
        {
            cbbKhachTP.DataSource = BUS_Phong.TakeAllRooms();
            cbbKhachTP.DisplayMember = "MaPhong";
            txtNVTT.Text = Ten;
            txtNVTT.Enabled = false; 
            
        }

        private void cbbKhachTP_SelectedValueChanged(object sender, EventArgs e)
        {
          
        }

        void ShowInTXT(string ID)
        {
           List<KhachHang_DTO> K = BUS_KhachHang.takeAllCustomerFiDPhong(ID);
                foreach (KhachHang_DTO item in K)
                {
                    txtTenKHTraPhong.Text = item.TenKH.ToString();
                    txtCMNDKHTraPhong.Text = item.Cmnd.ToString();
                    txtQuocTichTraPhong.Text = item.QuocTich.ToString();
                    if (item.GioiTinh.ToString() == "Nam")
                        radNamTraPhong.Checked = true;
                    else
                        radNuTraPhong.Checked = true;
                    txtTuoiTraPhong.Text = item.Tuoi.ToString();
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
            string id = cbbKhachTP.Text;
            ShowInTXT(id);
            showTTThanhToan(id);
            showService(id);
            loadMoney(id);
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
        }

        private void txtTongTienTT_TextChanged(object sender, EventArgs e)
        {
            int money = int.Parse(txtTongTienTT.Text);
            int price = int.Parse(txtTongTienDV.Text);
            int result = money + price;
            txtTraTien.Text = result.ToString();
        
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

        
    }
}
