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
    public partial class frmHS : Form
    {
        public frmHS()
        {
            InitializeComponent();
        }

        frmThemHS themHS = new frmThemHS();

        private void btnThemHS_Click(object sender, EventArgs e)
        {
            themHS.ShowDialog();
        }
    }
}
