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
           
        }
    }
}
