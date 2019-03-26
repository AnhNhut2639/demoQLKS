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
        }

        private void cbbKhachTP_SelectedValueChanged(object sender, EventArgs e)
        {
            
          //  string id = cbbKhachTP.Text;
         //   ShowInTXT(id);
            
        }

        void ShowInTXT(string ID)
        {
           List<KhachHang_DTO> K = BUS_KhachHang.takeAllCustomerFiDPhong(ID);
            //List<KhachHang_DTO> K = new List<KhachHang_DTO>();
            // K = BUS_KhachHang.takeAllCustomerFiDPhong(ID);
           
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
           // MessageBox.Show(" " + id, "Thông báo");
            ShowInTXT(id);
        }
    }
}
