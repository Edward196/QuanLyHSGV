using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyGVHSTHPT
{
    public partial class frmThemHS : Form
    {
        public frmThemHS()
        {
            InitializeComponent();
            con = new SqlConnection(@"Data Source=(local)\SQLEXPRESS;Initial Catalog=QuanLyGVHSTHPT;Integrated Security=True");
        }
        SqlConnection con;

        private void frmThemHS_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyGVHSTHPTDataSet.hanhkiem' table. You can move, or remove it, as needed.
            this.hanhkiemTableAdapter.Fill(this.quanLyGVHSTHPTDataSet.hanhkiem);
            // TODO: This line of code loads data into the 'quanLyGVHSTHPTDataSet.hocluc' table. You can move, or remove it, as needed.
            this.hoclucTableAdapter.Fill(this.quanLyGVHSTHPTDataSet.hocluc);
            // TODO: This line of code loads data into the 'quanLyGVHSTHPTDataSet.khoa' table. You can move, or remove it, as needed.
            this.khoaTableAdapter.Fill(this.quanLyGVHSTHPTDataSet.khoa);
            // TODO: This line of code loads data into the 'quanLyGVHSTHPTDataSet.lop' table. You can move, or remove it, as needed.
            this.lopTableAdapter.Fill(this.quanLyGVHSTHPTDataSet.lop);

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtTenHS.Text.ToString().Trim().Length > 0
                && txtDanTocHS.Text.ToString().Trim().Length > 0
                && cboGioiTinhHS.Text.ToString().Trim().Length > 0
                && txtDiaChiHS.Text.ToString().Trim().Length > 0)
            {
                if ((MessageBox.Show("Bạn muốn thêm học sinh này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    con.Open();
                    string sql = "insert into hocsinh(ten,ngaysinh,gioitinh,dantoc,diachi,khoama,lopma,hoclucma,hanhkiemma) "
                            + "select N'{0}', N'{1}', N'{2}', N'{3}', N'{4}', k.ma, l.ma, hl.ma, hk.ma "
                            + "from khoa k, lop l, hocluc hl, hanhkiem hk "
                            + "where (k.ten = N'{5}' and l.ten = N'{6}' and hl.ten = N'{7}' and hk.ten = N'{8}')";
                    string sqlThem = string.Format(sql, txtTenHS.Text, dtpNgaysinhHS.Text, cboGioiTinhHS.SelectedIndex.ToString(), txtDanTocHS.Text, txtDiaChiHS.Text,
                                                    cboKhoaHS.Text, cboLopHS.Text, cboHocLucHS.Text, cboHanhKiemHS.Text);
                    SqlCommand sc = new SqlCommand(sqlThem, con);
                    sc.CommandType = CommandType.Text;
                    try
                    {
                        sc.ExecuteNonQuery();
                        MessageBox.Show("Thêm thành công");
                        con.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        con.Close();
                    }
                }
            }
            else
                MessageBox.Show("Chưa nhập đủ thông tin", "Cảnh báo");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
