﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKS
{
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        private void Report_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QLKS2DataSet.KhachHang' table. You can move, or remove it, as needed.
            this.KhachHangTableAdapter.Fill(this.QLKS2DataSet.KhachHang);

            this.reportViewer1.RefreshReport();
        }
    }
}
