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
    public partial class FrmNhanVien : Form
    {
        public FrmNhanVien()
        {
            InitializeComponent();
        }

        private void btnThoatNhanVien_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmNhanVien_Load(object sender, EventArgs e)
        {
            dgvNhanVien.DataSource = BUS_NhanVien.takeAllEmployees();
            dgvNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
           // bindingNavigator1.BindingSource = dgvNhanVien;

        }

        private void dgvNhanVien_Click(object sender, EventArgs e)
        {
            int current = dgvNhanVien.CurrentCell.RowIndex;
            DataGridViewRow dr = dgvNhanVien.Rows[current];
            txtMaNV.Text = dr.Cells["MaNV"].Value.ToString();
            txtTenNV.Text = dr.Cells["TenNV"].Value.ToString();
            dtpNamSinhNV.Text = dr.Cells["NamSinh"].Value.ToString();
            cbbChucVu.Text = dr.Cells["ChucVu"].Value.ToString();
            if (dr.Cells["GioiTinh"].Value.ToString() == "Nam")
                radNamNV.Checked = true;
            else
                radNuNV.Checked = true;
           
        }
    }
}
