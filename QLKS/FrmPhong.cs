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
           // main.Show();
            //this.Hide();
            
            
            //main.ShowDialog();
            // this.Close();
        }

        private void FrmPhong_Load(object sender, EventArgs e)
        {
            dgvLoadPhong.DataSource = BUS_Phong.TakeAllRooms();
            dgvLoadPhong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            cbbLoaiPhong.DataSource = BUS_Phong.TakeAllRooms();
            cbbLoaiPhong.DisplayMember = "LoaiPhong";
            cbbLoaiPhong.ValueMember = "LoaiPhong";

            //
            cbbTinhTrang.DataSource = BUS_Phong.TakeAllRooms();
            cbbTinhTrang.DisplayMember = "TinhTrang";
            txtMaPhong.Enabled = false;
            txtTenPhong.Enabled = false;
            txtGiaPhong.Enabled = false;
            cbbTinhTrang.Enabled = false;
            HienThiDGV();
            btnLuuPhong.Visible = false;
            btnLuuGia.Visible = false;
            
        }

        void HienThiDGV()
        {
            List<Phong_DTO> lst = BUS_Phong.TakeAllRooms();
            dgvLoadPhong.DataSource = lst;
            dgvLoadPhong.Columns["MaPhong"].HeaderText = "Mã phòng";
            dgvLoadPhong.Columns["TenPhong"].HeaderText = "Tên phòng";
            dgvLoadPhong.Columns["LoaiPhong"].HeaderText = "Loại Phòng";
            dgvLoadPhong.Columns["TinhTrang"].HeaderText = "Tình trạng";
            //dgvLoadPhong.Columns["NgayDatPhong"].HeaderText = "Ngày đặt phòng";
            dgvLoadPhong.Columns["MaNV"].Visible = false;
            dgvLoadPhong.Columns["MaDV"].Visible = false;
            dgvLoadPhong.Columns["NgayDatPhong"].Visible = false;
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
            string id = cbbLoaiPhong.SelectedValue.ToString();
            //MessageBox.Show(id);
            //   int gia = int.Parse(BUS_Phong.takeKindROOM(id).ToString());
            // txtGiaPhong.Text = int.Parse(gia);
            showInTxtGia(id);
        }

        private void btnThemPhong_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgvLoadPhong.Rows.Count.ToString());
            txtMaPhong.Text = "P00" + ++id;
            txtTenPhong.Text = "Phòng " + id;
            txtGiaPhong.Text = "";
            btnLuuPhong.Visible = true;
            btnLuuGia.Visible = false;



        }
        void showInTxtGia(string id)
        {
            List<Phong_DTO> P = BUS_Phong.takeKindROOM(id);
            foreach (Phong_DTO item in P)
            {
                txtGiaPhong.Text = item.GiaPhong.ToString();
            }
        }

        private void btnLuuPhong_Click(object sender, EventArgs e)
        {
            if(txtGiaPhong.Text == "")
            {
                MessageBox.Show("chọn loại phòng để xác định giá phòng ");
                return;
            }
            else
            {
                Phong_DTO P = new Phong_DTO();
                P.MaPhong = txtMaPhong.Text;
                P.TenPhong = txtTenPhong.Text;
                P.LoaiPhong = cbbLoaiPhong.SelectedValue.ToString();
                P.GiaPhong = int.Parse(txtGiaPhong.Text);
                P.TinhTrang = cbbTinhTrang.Text;
                P.NgayDatPhong = DateTime.Parse(dtpNgayDatPhong.Text);

                if (BUS_Phong.AddRooms(P) == true)
                {
                    HienThiDGV();
                    MessageBox.Show("đã thêm phòng", "Thông báo !!!");
                }
                else
                {
                    MessageBox.Show("không thể thêm phòng", "Thông báo !!!");
                }
            }
            
        }

        private void btnXoaPhong_Click(object sender, EventArgs e)
        {
            Phong_DTO P = new Phong_DTO();
            P.MaPhong = txtMaPhong.Text;
            if (BUS_Phong.deleteRooms(P) == true)
            {
                HienThiDGV();
                MessageBox.Show("đã xóa phòng", "Thông báo !!!");
            }
            else
            {
                MessageBox.Show("không thể xóa phòng phòng", "Thông báo !!!");
            }
        }

        private void btnSuaGiaPhong_Click(object sender, EventArgs e)
        {
            txtGiaPhong.Enabled = true;
            txtGiaPhong.Focus();
            btnLuuGia.Visible = true;
            btnLuuPhong.Visible = false;
        }

        private void btnLuuGia_Click(object sender, EventArgs e)
        {
            Phong_DTO P = new Phong_DTO();
            P.GiaPhong = int.Parse(txtGiaPhong.Text);
            P.LoaiPhong = cbbLoaiPhong.SelectedValue.ToString();
            if (BUS_Phong.UpdatePriceRooms(P) == true)
            {
                HienThiDGV();
                MessageBox.Show("đã cập nhật giá phòng", "Thông báo !!! ");
            }
            else
            {
                MessageBox.Show("không cập nhật được giá phòng", "Thông báo !!! ");
            }
        }
    }
}
