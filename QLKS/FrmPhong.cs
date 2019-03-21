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
            cbbTinhTrang.Text = dr.Cells["TinhTrang"].Value.ToString();
        }

        private void dgvLoadPhong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
