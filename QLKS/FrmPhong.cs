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
    public partial class FrmPhong : Form
    {
        public FrmPhong()
        {
            InitializeComponent();
        }
       // public string tenPhong;
        private void btnThoatPhong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmPhong_Load(object sender, EventArgs e)
        {
            dgvLoadPhong.DataSource = BUS_Phong.TakeAllRooms();
            dgvLoadPhong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            cbbLoaiPhong.DataSource = BUS_Phong.TakeAllRooms();
            cbbLoaiPhong.DisplayMember = "LoaiPhong"; 
            cbbLoaiPhong.ValueMember = "MaPhong";
            //
            cbbTinhTrang.DataSource = BUS_Phong.TakeAllRooms();
            cbbTinhTrang.DisplayMember = "TinhTrang";

           

        }

        private void dgvLoadPhong_Click(object sender, EventArgs e)
        {
            int current = dgvLoadPhong.CurrentCell.RowIndex;
            DataGridViewRow dr = dgvLoadPhong.Rows[current];
            txtMaPhong.Text = dr.Cells["MaPhong"].Value.ToString();
            txtTenPhong.Text = dr.Cells["TenPhong"].Value.ToString();
            cbbLoaiPhong.Text = dr.Cells["LoaiPhong"].Value.ToString();
            txtGiaPhong.Text = dr.Cells["GiaPhong"].Value.ToString();
            cbbTinhTrang.Text = dr.Cells["TinhTrang"].Value.ToString();
            dtpNgayDatPhong.Text = dr.Cells["NgayDatPhong"].Value.ToString();
            // string tmp = dr.Cells["MaPhong"].Value.ToString();
            //  MessageBox.Show(" " + tmp, "Thông báo");


        }

        private void dgvLoadPhong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbbLoaiPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cbbLoaiPhong_Click(object sender, EventArgs e)
        {
            
        }

        private void cbbLoaiPhong_SelectedValueChanged(object sender, EventArgs e)
        {
            
          //  string tmp = cbbLoaiPhong.Text;
           // MessageBox.Show(" " + tmp, "Thông báo");

        }

        private void cbbLoaiPhong_ValueMemberChanged(object sender, EventArgs e)
        {
            
        }

        private void cbbLoaiPhong_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void cbbLoaiPhong_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
        }
    }
}
