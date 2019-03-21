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
    public partial class Form1 : Form
    {
      
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string Account = txtTaiKhoan.Text;
            string Pass = txtMatKhau.Text;
            if (BUS_DangNhap.TakeAllAccounts(Account,Pass))
            {
                // MessageBox.Show("Bạn đã đăng nhập thành công !!!", "Thông báo");
                FrmMain main = new FrmMain();
                main.A = Account; // truyền tài khoản và mật khẩu nhập ở Textbox sang cho form main để nhận dạng người dùng 
                main.B = Pass;
                this.Hide();
                main.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Vui Lòng xem lại tài khoản và mật khẩu ");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
      
    }
    }
}
