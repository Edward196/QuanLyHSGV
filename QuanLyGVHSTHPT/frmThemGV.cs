using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyGVHSTHPT
{
    public partial class frmThemGV : Form
    {
        public frmThemGV()
        {
            InitializeComponent();
            con = new SqlConnection(@"Data Source=(local)\SQLEXPRESS;Initial Catalog=QuanLyGVHSTHPT;Integrated Security=True");
        }
        SqlConnection con;

        private void frmThemGV_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyGVHSTHPTDataSet.monhoc' table. You can move, or remove it, as needed.
            this.monhocTableAdapter.Fill(this.quanLyGVHSTHPTDataSet.monhoc);
            // TODO: This line of code loads data into the 'quanLyGVHSTHPTDataSet.chucvu' table. You can move, or remove it, as needed.
            this.chucvuTableAdapter.Fill(this.quanLyGVHSTHPTDataSet.chucvu);

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtTenGV.Text.ToString().Trim().Length > 0
                && txtDanTocGV.Text.ToString().Trim().Length > 0
                && cboGioiTinhGV.Text.ToString().Trim().Length > 0
                && cboTonGiaoGV.Text.ToString().Trim().Length > 0
                && txtQueQuanGV.Text.ToString().Trim().Length > 0
                && txtDiaChiGV.Text.ToString().Trim().Length > 0
                && cboMonHocGV.Text.ToString().Trim().Length > 0)
            {
                if ((MessageBox.Show("Bạn muốn thêm giáo viên này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    con.Open();
                    string gioitinh;
                    if (cboGioiTinhGV.Text == "Nữ")
                        gioitinh = "0";
                    else
                        gioitinh = "1";
                    string sql = "insert into giaovien(ten,dantoc,gioitinh,tongiao,quequan,ngaysinh,diachi,chucvuma,monhocma) "
                            + "select N'{0}', N'{1}', N'{2}', N'{3}', N'{4}', N'{5}', N'{6}', "
                            + "cv.ma, mh.ma from chucvu cv, monhoc mh "
                            + "where (cv.ten = N'{7}' and mh.ten = N'{8}')";
                    string sqlThem = string.Format(sql, txtTenGV.Text, txtDanTocGV.Text, gioitinh, cboTonGiaoGV.Text,
                            txtQueQuanGV.Text, dtpNgaysinhGV.Text, txtDiaChiGV.Text, cboChucVuGV.Text, cboMonHocGV.Text);
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
    }
}
