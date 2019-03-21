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

        }
    }
}
