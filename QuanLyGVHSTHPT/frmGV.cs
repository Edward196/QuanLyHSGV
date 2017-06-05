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
    public partial class frmGV : Form
    {
        public frmGV()
        {
            InitializeComponent();
            con = new SqlConnection(@"Data Source=(local)\SQLEXPRESS;Initial Catalog=QuanLyGVHSTHPT;Integrated Security=True");
        }
        SqlConnection con;
        frmThemGV themGV = new frmThemGV();

        string sqlGV = "select gv.ma as [Mã giáo viên], gv.ten as [Tên giáo viên], gv.dantoc as [Dân tộc], "
                + "(CASE gv.gioitinh WHEN 'true' THEN N'Nam' WHEN 'false' THEN N'Nữ' END) as [Giới tính], "
                + "gv.tongiao as [Tôn giáo], gv.quequan as [Quê quán], gv.ngaysinh as [Ngày sinh], "
                + "gv.diachi as [Địa chỉ], mh.tochuyenmon as [Tổ chuyên môn], cv.ten as [Chức vụ], "
                + "mh.ten as [Môn học] from giaovien gv "
                + "inner join chucvu cv on cv.ma=gv.chucvuma inner join monhoc mh on mh.ma=gv.monhocma";

        private void frmGV_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyGVHSTHPTDataSet.monhoc' table. You can move, or remove it, as needed.
            this.monhocTableAdapter.Fill(this.quanLyGVHSTHPTDataSet.monhoc);
            // TODO: This line of code loads data into the 'quanLyGVHSTHPTDataSet.chucvu' table. You can move, or remove it, as needed.
            this.chucvuTableAdapter.Fill(this.quanLyGVHSTHPTDataSet.chucvu);
            hienGV(sqlGV);

        }

        private void hienGV(string sql)
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvGiaoVien.DataSource = dt;
            con.Close();
        }

        private void dgvGiaoVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaGV.Text = dgvGiaoVien.CurrentRow.Cells[0].Value.ToString();
            txtTenGV.Text = dgvGiaoVien.CurrentRow.Cells[1].Value.ToString();
            txtDanTocGV.Text = dgvGiaoVien.CurrentRow.Cells[2].Value.ToString();
            cboGioiTinhGV.Text = dgvGiaoVien.CurrentRow.Cells[3].Value.ToString();
            cboTonGiaoGV.Text = dgvGiaoVien.CurrentRow.Cells[4].Value.ToString();
            txtQueQuanGV.Text = dgvGiaoVien.CurrentRow.Cells[5].Value.ToString();
            dtpNgaySinhGV.Text = dgvGiaoVien.CurrentRow.Cells[6].Value.ToString();
            txtDiaChiGV.Text = dgvGiaoVien.CurrentRow.Cells[7].Value.ToString();
            txtToChuyenMonGV.Text = dgvGiaoVien.CurrentRow.Cells[8].Value.ToString();
            cboChucVuGV.Text = dgvGiaoVien.CurrentRow.Cells[9].Value.ToString();
            cboMonHocGV.Text = dgvGiaoVien.CurrentRow.Cells[10].Value.ToString();
        }

        private void cboTimKiemGV_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = sqlGV;
            if (cboTimKiemGV.Text == "Tên giáo viên")
                sql = sql + " WHERE gv.ten LIKE N'%" + txtTimKiemGV.Text + "%'";
            else if (cboTimKiemGV.Text == "Dân tộc")
                sql = sql + " WHERE gv.dantoc LIKE N'%" + txtTimKiemGV.Text + "%'";
            else if (cboTimKiemGV.Text == "Tôn giáo")
                sql = sql + " WHERE gv.tongiao LIKE N'%" + txtTimKiemGV.Text + "%'";
            else if (cboTimKiemGV.Text == "Quê quán")
                sql = sql + " WHERE gv.quequan LIKE N'%" + txtTimKiemGV.Text + "%'";
            else if (cboTimKiemGV.Text == "Địa chỉ")
                sql = sql + " WHERE gv.diachi LIKE N'%" + txtTimKiemGV.Text + "%'";
            else if (cboTimKiemGV.Text == "Tổ chuyên môn")
                sql = sql + " WHERE mh.tochuyenmon LIKE N'%" + txtTimKiemGV.Text + "%'";
            else if (cboTimKiemGV.Text == "Chức vụ")
                sql = sql + " WHERE cv.ten LIKE N'%" + txtTimKiemGV.Text + "%'";
            else if (cboTimKiemGV.Text == "Môn học")
                sql = sql + " WHERE mh.ten LIKE N'%" + txtTimKiemGV.Text + "%'";
            hienGV(sql);
        }

        private void btnThemGV_Click(object sender, EventArgs e)
        {
            themGV.ShowDialog();
        }

        private void btnSuaGV_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn sửa thông tin?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                con.Open();
                string sql = "update giaovien set ten = N'{0}', dantoc = N'{1}', gioitinh = N'{2}', tongiao = N'{3}', quequan = N'{4}', "
                        + "ngaysinh = N'{5}', diachi = N'{6}', chucvuma = (select ma from chucvu cv where cv.ten = N'{7}'), "
                        + "monhocma = (select ma from monhoc mh where mh.ten = N'{8}') where ma = N'{9}'";
                string sua = string.Format(sql, txtTenGV.Text, txtDanTocGV.Text, cboGioiTinhGV.SelectedIndex.ToString(), cboTonGiaoGV.Text, txtQueQuanGV.Text,
                        dtpNgaySinhGV.Text, txtDiaChiGV.Text, cboChucVuGV.Text, cboMonHocGV.Text, txtMaGV.Text);
                SqlCommand sc = new SqlCommand(sua, con);
                sc.CommandType = CommandType.Text;
                try
                {
                    sc.ExecuteNonQuery();
                    MessageBox.Show("Sửa thành công");
                    con.Close();
                    hienGV(sqlGV);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    con.Close();
                }
            }
        }

        private void btnXoaGV_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn xóa thông tin?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                con.Open();
                string xoa = string.Format("delete from giaovien where ma={0}", txtMaGV.Text);
                SqlCommand cmd = new SqlCommand(xoa, con);
                cmd.CommandType = CommandType.Text;
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xóa thành công");
                    con.Close();
                    hienGV(sqlGV);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    con.Close();
                }
            }
        }

        private void btnTaiLaiGV_Click(object sender, EventArgs e)
        {
            hienGV(sqlGV);
        }
    }
}
