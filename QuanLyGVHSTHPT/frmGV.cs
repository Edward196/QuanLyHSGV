﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyGVHSTHPT
{
    public partial class frmGV : Form
    {
        public frmGV()
        {
            InitializeComponent();
        }

        frmThemGV themGV = new frmThemGV();

        private void btnThemGV_Click(object sender, EventArgs e)
        {
            themGV.ShowDialog();
        }
    }
}