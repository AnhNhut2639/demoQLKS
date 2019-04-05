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
    public partial class FrmKhachHang : Form
    {
        public FrmKhachHang()
        {
            InitializeComponent();
        }
        public string TenPhong;
        public string MaPhong;

        private void btnThoat_Click(object sender, EventArgs e)
        {
           // this.Close();
            this.Hide();
            FrmMain main = new FrmMain();
            main.ShowDialog();

            
        }

        private void dgvKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmKhachHang_Load(object sender, EventArgs e)
        {
            dgvKhachHang.DataSource = BUS_KhachHang.TakeAllCustomers();
           dgvKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            txtMaKH.Enabled = false;
            int id = int.Parse(dgvKhachHang.Rows.Count.ToString());
            txtMaKH.Text = "KH00" + ++id;
            txtTenKH.Focus();


            cbbChonPhong.Visible = false;  
            txtMaPhongKHDaChon.Text = MaPhong;
            txtPhongDaChon.Text = TenPhong;
            txtPhongDaChon.Enabled = false;

            gpDichVuKHKhiDatPhong.Visible = false;

            //  cbbMaDVKhiDatPhong.DataSource = BUS_DichVu.takeAllServiceFId()
            //  cbbMaDVKhiDatPhong.DataSource = BUS_DichVu.takeAllServiceTest();
            //  cbbMaDVKhiDatPhong.DisplayMember = "MaDV";
            //   cbbMaDVKhiDatPhong.ValueMember = "MaDV";

            cbbMaDVKhiDatPhong.DataSource = BUS_DichVuDaDat.takeALLServiced();
            cbbMaDVKhiDatPhong.DisplayMember = "MaDV";
            cbbMaDVKhiDatPhong.ValueMember = "MaDV";
        }

        void ShowDGVKhachHang()
        {
            List<KhachHang_DTO> lst = BUS_KhachHang.TakeAllCustomers();
            dgvKhachHang.DataSource = lst;
            dgvKhachHang.Columns["MaKH"].HeaderText = "Mã Khách hàng";
            dgvKhachHang.Columns["TenKH"].HeaderText = "Tên Khách hàng";
            dgvKhachHang.Columns["CMND"].HeaderText = "CMND";
            dgvKhachHang.Columns["QuocTich"].HeaderText = "Quốc Tịch";
            dgvKhachHang.Columns["GioiTinh"].HeaderText = "Giới Tính";
            dgvKhachHang.Columns["NgaySinh"].HeaderText = "Ngày Sinh";
            dgvKhachHang.Columns["SDT"].HeaderText = "Liên Lạc";
            dgvKhachHang.Columns["MaPhong"].HeaderText = "Mã Phòng";
        }

        void showService(string ID)
        {
            dgvDichVuKH.DataSource = BUS_DichVu.TakeAllService(ID);
            dgvDichVuKH.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDichVuKH.Columns["MaDV"].HeaderText = "Mã dịch vụ";
            dgvDichVuKH.Columns["TenDV"].HeaderText = "Tên dịch vụ";
            dgvDichVuKH.Columns["SoLuong"].HeaderText = "Số lượng";
            dgvDichVuKH.Columns["GiaDV"].HeaderText = "Giá dịch vụ";
        }

        private void dgvKhachHang_Click(object sender, EventArgs e)
        {
            //int current = dgvKhachHang.CurrentCell.RowIndex;
            //DataGridViewRow dr = dgvKhachHang.Rows[current];
            //txtTenKH.Text = dr.Cells["TenKH"].Value.ToString();
            //txtCMND.Text = dr.Cells["CMND"].Value.ToString();
            //txtQuocTich.Text = dr.Cells["QuocTich"].Value.ToString();
            //if (dr.Cells["GioiTinh"].Value.ToString() == "Nam")
            //    radNam.Checked = true;
            //else
            //    radNu.Checked = true;
            //dtpNgaySinhKH.Text = dr.Cells["NgaySinh"].Value.ToString();
            //// txtTuoi.Text = dr.Cells["Tuoi"].Value.ToString();

            //txtLienLac.Text = dr.Cells["SDT"].Value.ToString();
            //cbbTimKiemTheoTen.Text = dr.Cells["TenKH"].Value.ToString();
            //string makh = dr.Cells["MaKH"].Value.ToString();
            ////MessageBox.Show(" " +makh,"Thông báo");
            ////hiển thị lên dgvDichVuKH theo ID của Khách hàng khi click
            //showService(makh);

        }

        private void dgvDichVuKH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvDichVuKH_Click(object sender, EventArgs e)
        {
            //int current = dgvDichVuKH.CurrentCell.RowIndex;
            //DataGridViewRow dr = dgvDichVuKH.Rows[current];
            //txtMaDV.Text = dr.Cells["MaDV"].Value.ToString();
            //txtTenDVKH.Text = dr.Cells["TenDV"].Value.ToString();
            //txtSoLuongDV.Text = dr.Cells["SoLuong"].Value.ToString();
            //txtGiaDVKH.Text = dr.Cells["GiaDV"].Value.ToString();
        }

        private void btnThemKH_Click(object sender, EventArgs e)
        {
            if(txtTenKH.Text == "" || txtLienLac.Text == "" || txtCMND.Text == "")
            {
                MessageBox.Show("Nhập đầu đủ thông tin", "Thông báo ");
            }
            else
            {

                KhachHang_DTO KH = new KhachHang_DTO();
                KH.MaKH = txtMaKH.Text;
                KH.TenKH = txtTenKH.Text;
                KH.Cmnd = int.Parse(txtCMND.Text);
                KH.QuocTich = txtQuocTich.Text;
                    if (radNam.Checked == true)
                     {
                        KH.GioiTinh = "Nam";
                    }
                    else
                    {
                        KH.GioiTinh = "Nữ";
                    }
                KH.NgaySinh = DateTime.Parse(dtpNgaySinhKH.Text);
                KH.Sdt = int.Parse(txtLienLac.Text);
                KH.MaPhong = txtMaPhongKHDaChon.Text;
                Phong_DTO P = new Phong_DTO();
                P.MaPhong = txtMaPhongKHDaChon.Text;
                // bắt đầu thêm

                if (BUS_KhachHang.AddCustomer(KH) == true)
                {
                    if (BUS_Phong.UpdateStatusRoom(P) == true)
                    {

                        Phong_DTO Ph = new Phong_DTO();
                        Ph.MaPhong = txtMaPhongKHDaChon.Text;
                        Ph.NgayDatPhong = DateTime.Parse(dtpDatPhong.Text);
                        if (BUS_Phong.UpdateDateRoom(Ph) == true)
                        {
                            // MessageBox.Show("Đã thêm khách hàng,cập nhật lại tình trạng phòng và cập nhật lại ngày đặt phòng mặc định ");
                            MessageBox.Show("Thêm khách hàng thành công ");
                            return;
                        }

                    }


                }
                else
                {
                    MessageBox.Show("Không thêm được", "Thông báo !!!");

                }
            }
            
        }

        private void txtDichVuKhiKHDatPhong_Click(object sender, EventArgs e)
        {
            gpDichVuKHKhiDatPhong.Visible = true;
        }

        private void btnLuuDVKhiDatPhong_Click(object sender, EventArgs e)
        {
            
            if (txtSoLuongKhiDatPhong.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số lượng !");
                return;
            }          
            else
            {
                DichVu_DTO DV = new DichVu_DTO();
                DV.MaDV = cbbMaDVKhiDatPhong.SelectedValue.ToString();
                DV.SoLuong = int.Parse(txtSoLuongKhiDatPhong.Text);
                DV.TenDV = txtTenDVKhiDatPhong.Text;
                DV.GiaDV = int.Parse(txtGiaKhiDatPhong.Text);
                if (BUS_DichVu.AddService(DV) == true)
                {                
                    Phong_DTO PH = new Phong_DTO();
                    PH.MaPhong = txtMaPhongKHDaChon.Text;
                    PH.MaDV = cbbMaDVKhiDatPhong.SelectedValue.ToString();
                    if (BUS_Phong.updateServiceRoom(PH) == true)
                    {
                        //  MessageBox.Show("thêm dịch vụ thành và cập nhật lại mã dịch vụ ở phòng thành công");
                        MessageBox.Show("thêm dịch vụ thành công");
                    }
                }
                else
                {
                    MessageBox.Show("Không thành công", "Thông báo  !!!");
                }
            }
        }
        void ShowInTextBox(string IDDV)
        {
            // List<DichVu_DTO> lstDichVu = BUS_DichVu.takeAllServiceFIdSer(IDDV);
            List<DichVuDaDat_DTO> lstDichVu = BUS_DichVuDaDat.takeAllServicedFIdSer(IDDV);
            foreach (DichVuDaDat_DTO item in lstDichVu)
            {
                txtTenDVKhiDatPhong.Text = item.TenDV.ToString();
                // txtSoLuong.Text = item.SoLuong.ToString();
                txtGiaKhiDatPhong.Text = item.GiaDV.ToString();
            }
        }

            private void cbbMaDVKhiDatPhong_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string id = cbbMaDVKhiDatPhong.SelectedValue.ToString();
            // string MDvHet = cbbMaDVKhiDatPhong.SelectedValue.ToString();
           // MessageBox.Show(id);
          //  if (id == "DV001" || id == "DV002" || id == "DV003")
          //if(id == "DV001")
          //  {
          //      MessageBox.Show("Dịch vụ bạn chọn đã hết !!! ","Thông báo");
          //      return;
          //  }
            ShowInTextBox(id);
            txtSoLuongKhiDatPhong.Text = "";
            txtSoLuongKhiDatPhong.Focus();
        }
    }
}
