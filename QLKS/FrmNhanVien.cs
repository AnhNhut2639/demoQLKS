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
            cbbChucVu.DataSource = BUS_NhanVien.loadALLChucVu();
            cbbChucVu.DisplayMember = "ChucVu";
            cbbChucVu.ValueMember = "ChucVu";
            HienThiDGV();

        }

        void HienThiDGV()
        {
            List<NhanVien_DTO> lst = BUS_NhanVien.takeAllEmployees();
            dgvNhanVien.DataSource = lst;
            dgvNhanVien.Columns["MaNV"].HeaderText = "Mã nhân viên";
            dgvNhanVien.Columns["TenNV"].HeaderText = "Tên nhân viên";
            dgvNhanVien.Columns["ChucVu"].HeaderText = "Chức vụ";
            dgvNhanVien.Columns["NamSinh"].HeaderText = "Năm Sinh";
            dgvNhanVien.Columns["GioiTinh"].HeaderText = "Giới Tính";


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

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            // kiểm tra dữ liệu có trống không
            int id = int.Parse(dgvNhanVien.Rows.Count.ToString());
            txtMaNV.Text = "NV00" + ++id;
            txtTenNV.Text = "";
            txtTenNV.Focus();
            radNamNV.Checked = true;
            dtpNamSinhNV.ResetText();           
        }

        private void cbbChucVu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSuaNV_Click(object sender, EventArgs e)
        {
            // kiểm tra mã có tồn tại
            //if (txtMaNV.Text == "" || BUS_NhanVien.TakeAllIDEmployees(txtMaNV.Text) == null)
            //{
            //    MessageBox.Show("Vui lòng chọn mã nhân viên!");
            //    return;
            //}
            NhanVien_DTO nv = new NhanVien_DTO();
            nv.MaNV = txtMaNV.Text;
            nv.TenNV = txtTenNV.Text;
            nv.ChucVu = cbbChucVu.SelectedValue.ToString();
           // nv.ChucVu = cbbChucVu.Text;
            nv.NamSinh = DateTime.Parse(dtpNamSinhNV.Text);
            if (radNuNV.Checked == true)
            {
                nv.GioiTinh = "Nữ"; // không sửa được khi giới tính là nữ
            }
            else 
            {
                nv.GioiTinh = "Nam";
            }
           
            

            if (BUS_NhanVien.UpdateALLEmployess(nv) == true)
            {
                HienThiDGV();
                MessageBox.Show("Đã Sửa nhân viên.");
            }
            else
            {
                MessageBox.Show("Không sửa được.");
            }
        }

        private void btnLuuNV_Click(object sender, EventArgs e)
        {

            if (txtMaNV.Text == "" || txtTenNV.Text == "" || cbbChucVu.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!");
                return;
            }
            if (txtMaNV.Text.Length < 5)
            {
                MessageBox.Show("Mã nhân viên tối đa 5 ký tự!");
                return;
            }
            //kiểm tra có trùng mã nhân viên không 
            if (BUS_NhanVien.TakeAllIDEmployees(txtMaNV.Text) != null)
            {
                MessageBox.Show("Mã nhân viên đã tồn tại!");
                return;
            }

            NhanVien_DTO nv = new NhanVien_DTO();
            nv.MaNV = txtMaNV.Text;
            nv.TenNV = txtTenNV.Text;
            nv.ChucVu = cbbChucVu.SelectedValue.ToString();
            if (radNamNV.Checked == true)
            {
                nv.GioiTinh = "Nam";
            }
            else
            {
                nv.GioiTinh = "Nữ";
            }
            nv.NamSinh = DateTime.Parse(dtpNamSinhNV.Text);

            if (BUS_NhanVien.AddAllEmployess(nv) == false)
            {
                MessageBox.Show("Không thêm được.");
                return;
            }

            MessageBox.Show("Đã thêm nhân viên.");
            HienThiDGV();
        }

        private void btnXoaNV_Click(object sender, EventArgs e)
        {
            NhanVien_DTO nv = new NhanVien_DTO();
            nv.MaNV = txtMaNV.Text;
            nv.TenNV = txtTenNV.Text;
            nv.ChucVu = cbbChucVu.SelectedValue.ToString();
            nv.NamSinh = DateTime.Parse(dtpNamSinhNV.Text);
            if (radNuNV.Checked == true)
            {
                nv.GioiTinh = "Nữ";
            }
            else
            {
                nv.GioiTinh = "Nam";
            }

            if (BUS_NhanVien.deleteALLEmployess(nv) == true)
            {
                HienThiDGV();
                MessageBox.Show("Đã xóa nhân viên.");
                txtMaNV.ResetText();
                txtTenNV.Text = "";
                txtTenNV.Focus();
                cbbChucVu.ResetText();
                radNamNV.Checked = true;
                dtpNamSinhNV.ResetText();
            }
            else
            {
                MessageBox.Show("Không xóa được.");
            }
        }
    }
}
