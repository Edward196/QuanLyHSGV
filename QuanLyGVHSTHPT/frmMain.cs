using System;
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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        frmGV GV = new frmGV();
        frmHS HS = new frmHS();

        private void quảnLýGiáoViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GV.ShowDialog();
        }

        private void quảnLýHọcSinhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HS.ShowDialog();
        }

        private void hướngDẫnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, System.IO.Path.Combine("...\\Huongdan.htm"));
        }
    }
}
