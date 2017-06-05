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
    public partial class frmHS : Form
    {
        public frmHS()
        {
            InitializeComponent();
            con = new SqlConnection(@"Data Source=(local)\SQLEXPRESS;Initial Catalog=QuanLyGVHSTHPT;Integrated Security=True");

        }
        SqlConnection con;

        frmThemHS themHS = new frmThemHS();

        string sqlHS = "select hs.ma as [Mã học sinh], hs.ten as [Tên học sinh], hs.ngaysinh as [Ngày sinh], "
               + "(CASE hs.gioitinh WHEN 'true' THEN N'Nam' WHEN 'false' THEN N'Nữ' END) as [Giới tính], "
               + "hs.dantoc as [Dân tộc], hs.diachi as [Địa chỉ], k.ten as [Khóa], l.ten as [Lớp], "
               + "hl.ten as [Học lực], hk.ten as [Hạnh kiểm] from hocsinh hs "
               + "inner join khoa k on k.ma = hs.khoama inner join lop l on l.ma = hs.lopma "
               + "inner join hocluc hl on hl.ma = hs.hoclucma inner join hanhkiem hk on hk.ma = hs.hanhkiemma";

        private void btnThemHS_Click(object sender, EventArgs e)
        {
            themHS.ShowDialog();
        }


        private void hienHS(string sql)
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvHocSinh.DataSource = dt;
            con.Close();
        }

        private void frmHS_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyGVHSTHPTDataSet.hanhkiem' table. You can move, or remove it, as needed.
            this.hanhkiemTableAdapter.Fill(this.quanLyGVHSTHPTDataSet.hanhkiem);
            // TODO: This line of code loads data into the 'quanLyGVHSTHPTDataSet.hocluc' table. You can move, or remove it, as needed.
            this.hoclucTableAdapter.Fill(this.quanLyGVHSTHPTDataSet.hocluc);
            // TODO: This line of code loads data into the 'quanLyGVHSTHPTDataSet.lop' table. You can move, or remove it, as needed.
            this.lopTableAdapter.Fill(this.quanLyGVHSTHPTDataSet.lop);
            // TODO: This line of code loads data into the 'quanLyGVHSTHPTDataSet.khoa' table. You can move, or remove it, as needed.
            this.khoaTableAdapter.Fill(this.quanLyGVHSTHPTDataSet.khoa);
            hienHS(sqlHS);
        }

        private void btnSuaGV_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn sửa thông tin?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                con.Open();
                string sql = "update hocsinh set ten = N'{0}', ngaysinh = N'{1}', gioitinh = N'{2}', dantoc = N'{3}', diachi = N'{4}', "
                        + "khoama = (select ma from khoa k where k.ten = N'{5}'), lopma = (select ma from lop l where l.ten = N'{6}'), "
                        + "hoclucma = (select ma from hocluc hl where hl.ten = N'{7}'), "
                        + "hanhkiemma = (select ma from hanhkiem hk where hk.ten = N'{8}') where ma={9}";
                string sua = string.Format(sql, txtTenHS.Text, dtpNgaySinhHS.Text, cboGioiTinhHS.SelectedIndex.ToString(), txtDanTocHS.Text, txtDiaChiHS.Text,
                                            cboKhoaHS.Text, cboLopHS.Text, cboHocLucHS.Text, cboHanhKiemHS.Text, txtMaHS.Text);
                SqlCommand sc = new SqlCommand(sua, con);
                sc.CommandType = CommandType.Text;
                try
                {
                    sc.ExecuteNonQuery();
                    MessageBox.Show("Sửa thành công");
                    con.Close();
                    hienHS(sqlHS);
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
                string sua = string.Format("delete from hocsinh where ma={0}", txtMaHS.Text);
                SqlCommand cmd = new SqlCommand(sua, con);
                cmd.CommandType = CommandType.Text;
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xóa thành công");
                    con.Close();
                    hienHS(sqlHS);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    con.Close();
                }
            }
        }

        private void btnTaiLaiHS_Click(object sender, EventArgs e)
        {
            hienHS(sqlHS);
        }

        private void dgvHocSinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaHS.Text = dgvHocSinh.CurrentRow.Cells[0].Value.ToString();
            txtTenHS.Text = dgvHocSinh.CurrentRow.Cells[1].Value.ToString();
            dtpNgaySinhHS.Text = dgvHocSinh.CurrentRow.Cells[2].Value.ToString();
            cboGioiTinhHS.Text = dgvHocSinh.CurrentRow.Cells[3].Value.ToString();
            txtDanTocHS.Text = dgvHocSinh.CurrentRow.Cells[4].Value.ToString();
            txtDiaChiHS.Text = dgvHocSinh.CurrentRow.Cells[5].Value.ToString();
            cboKhoaHS.Text = dgvHocSinh.CurrentRow.Cells[6].Value.ToString();
            cboLopHS.Text = dgvHocSinh.CurrentRow.Cells[7].Value.ToString();
            cboHocLucHS.Text = dgvHocSinh.CurrentRow.Cells[8].Value.ToString();
            cboHanhKiemHS.Text = dgvHocSinh.CurrentRow.Cells[9].Value.ToString();
        }

     

       

        private void cboTimKiemHS_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string sql = sqlHS;
            if (cboTimKiemHS.Text == "Tên học sinh")
                sql = sql + " WHERE hs.ten LIKE N'%" + txtTimKiemHS.Text + "%'";
            else if (cboTimKiemHS.Text == "Dân tộc")
                sql = sql + " WHERE hs.dantoc LIKE N'%" + txtTimKiemHS.Text + "%'";
            else if (cboTimKiemHS.Text == "Địa chỉ")
                sql = sql + " WHERE hs.diachi LIKE N'%" + txtTimKiemHS.Text + "%'";
            else if (cboTimKiemHS.Text == "Khóa")
                sql = sql + " WHERE k.ten LIKE N'%" + txtTimKiemHS.Text + "%'";
            else if (cboTimKiemHS.Text == "Lớp")
                sql = sql + " WHERE l.ten LIKE N'%" + txtTimKiemHS.Text + "%'";
            else if (cboTimKiemHS.Text == "Học lực")
                sql = sql + " WHERE hl.ten LIKE N'%" + txtTimKiemHS.Text + "%'";
            else if (cboTimKiemHS.Text == "Hạnh kiểm")
                sql = sql + " WHERE hk.ten LIKE N'%" + txtTimKiemHS.Text + "%'";
            hienHS(sql);
        }
    }
}
