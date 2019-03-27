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

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
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
            cbbChonPhong.DataSource = BUS_Phong.TakeAllEmptyRooms();
            cbbChonPhong.DisplayMember = "TenPhong";
            cbbChonPhong.ValueMember = "MaPhong";
            ShowDGVKhachHang();
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
            dgvKhachHang.Columns["Tuoi"].HeaderText = "Tuổi";
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
            int current = dgvKhachHang.CurrentCell.RowIndex;
            DataGridViewRow dr = dgvKhachHang.Rows[current];
            txtTenKH.Text = dr.Cells["TenKH"].Value.ToString();
            txtCMND.Text = dr.Cells["CMND"].Value.ToString();
            txtQuocTich.Text = dr.Cells["QuocTich"].Value.ToString();
            if (dr.Cells["GioiTinh"].Value.ToString() == "Nam")
                radNam.Checked = true;
            else
                radNu.Checked = true;
            txtTuoi.Text = dr.Cells["Tuoi"].Value.ToString();
            txtLienLac.Text = dr.Cells["SDT"].Value.ToString();
            cbbTimKiemTheoTen.Text = dr.Cells["TenKH"].Value.ToString();
            string makh = dr.Cells["MaKH"].Value.ToString();
            //MessageBox.Show(" " +makh,"Thông báo");
            //hiển thị lên dgvDichVuKH theo ID của Khách hàng khi click
            showService(makh);

        }

        private void dgvDichVuKH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvDichVuKH_Click(object sender, EventArgs e)
        {
            int current = dgvDichVuKH.CurrentCell.RowIndex;
            DataGridViewRow dr = dgvDichVuKH.Rows[current];
            txtMaDV.Text = dr.Cells["MaDV"].Value.ToString();
            txtTenDVKH.Text = dr.Cells["TenDV"].Value.ToString();
            txtSoLuongDV.Text = dr.Cells["SoLuong"].Value.ToString();
            txtGiaDVKH.Text = dr.Cells["GiaDV"].Value.ToString();
        }
    }
}
