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
                    txtLienLacTraPhong.Text = item.Sdt.ToString();

                }  
                
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
        }
    }
}
