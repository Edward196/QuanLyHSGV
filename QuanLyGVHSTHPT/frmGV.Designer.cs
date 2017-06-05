namespace QuanLyGVHSTHPT
{
    partial class frmGV
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dgvGiaoVien = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTaiLaiGV = new System.Windows.Forms.Button();
            this.btnXoaGV = new System.Windows.Forms.Button();
            this.btnThemGV = new System.Windows.Forms.Button();
            this.btnSuaGV = new System.Windows.Forms.Button();
            this.cboTimKiemGV = new System.Windows.Forms.ComboBox();
            this.txtTimKiemGV = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cboMonHocGV = new System.Windows.Forms.ComboBox();
            this.monhocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyGVHSTHPTDataSet = new QuanLyGVHSTHPT.QuanLyGVHSTHPTDataSet();
            this.cboChucVuGV = new System.Windows.Forms.ComboBox();
            this.chucvuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cboTonGiaoGV = new System.Windows.Forms.ComboBox();
            this.cboGioiTinhGV = new System.Windows.Forms.ComboBox();
            this.dtpNgaySinhGV = new System.Windows.Forms.DateTimePicker();
            this.txtQueQuanGV = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDanTocGV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenGV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtToChuyenMonGV = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDiaChiGV = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaGV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chucvuTableAdapter = new QuanLyGVHSTHPT.QuanLyGVHSTHPTDataSetTableAdapters.chucvuTableAdapter();
            this.monhocTableAdapter = new QuanLyGVHSTHPT.QuanLyGVHSTHPTDataSetTableAdapters.monhocTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiaoVien)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.monhocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyGVHSTHPTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chucvuBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGiaoVien
            // 
            this.dgvGiaoVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGiaoVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGiaoVien.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvGiaoVien.Location = new System.Drawing.Point(0, 290);
            this.dgvGiaoVien.Name = "dgvGiaoVien";
            this.dgvGiaoVien.ReadOnly = true;
            this.dgvGiaoVien.Size = new System.Drawing.Size(984, 272);
            this.dgvGiaoVien.TabIndex = 0;
            this.dgvGiaoVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGiaoVien_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTaiLaiGV);
            this.groupBox1.Controls.Add(this.btnXoaGV);
            this.groupBox1.Controls.Add(this.btnThemGV);
            this.groupBox1.Controls.Add(this.btnSuaGV);
            this.groupBox1.Controls.Add(this.cboTimKiemGV);
            this.groupBox1.Controls.Add(this.txtTimKiemGV);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.cboMonHocGV);
            this.groupBox1.Controls.Add(this.cboChucVuGV);
            this.groupBox1.Controls.Add(this.cboTonGiaoGV);
            this.groupBox1.Controls.Add(this.cboGioiTinhGV);
            this.groupBox1.Controls.Add(this.dtpNgaySinhGV);
            this.groupBox1.Controls.Add(this.txtQueQuanGV);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtDanTocGV);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtTenGV);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtToChuyenMonGV);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtDiaChiGV);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtMaGV);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(960, 272);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chi tiết";
            // 
            // btnTaiLaiGV
            // 
            this.btnTaiLaiGV.Location = new System.Drawing.Point(837, 220);
            this.btnTaiLaiGV.Name = "btnTaiLaiGV";
            this.btnTaiLaiGV.Size = new System.Drawing.Size(75, 23);
            this.btnTaiLaiGV.TabIndex = 59;
            this.btnTaiLaiGV.Text = "Tải lại";
            this.btnTaiLaiGV.UseVisualStyleBackColor = true;
            this.btnTaiLaiGV.Click += new System.EventHandler(this.btnTaiLaiGV_Click);
            // 
            // btnXoaGV
            // 
            this.btnXoaGV.Location = new System.Drawing.Point(734, 220);
            this.btnXoaGV.Name = "btnXoaGV";
            this.btnXoaGV.Size = new System.Drawing.Size(75, 23);
            this.btnXoaGV.TabIndex = 60;
            this.btnXoaGV.Text = "Xóa";
            this.btnXoaGV.UseVisualStyleBackColor = true;
            this.btnXoaGV.Click += new System.EventHandler(this.btnXoaGV_Click);
            // 
            // btnThemGV
            // 
            this.btnThemGV.Location = new System.Drawing.Point(526, 220);
            this.btnThemGV.Name = "btnThemGV";
            this.btnThemGV.Size = new System.Drawing.Size(75, 23);
            this.btnThemGV.TabIndex = 58;
            this.btnThemGV.Text = "Thêm";
            this.btnThemGV.UseVisualStyleBackColor = true;
            this.btnThemGV.Click += new System.EventHandler(this.btnThemGV_Click);
            // 
            // btnSuaGV
            // 
            this.btnSuaGV.Location = new System.Drawing.Point(631, 220);
            this.btnSuaGV.Name = "btnSuaGV";
            this.btnSuaGV.Size = new System.Drawing.Size(75, 23);
            this.btnSuaGV.TabIndex = 58;
            this.btnSuaGV.Text = "Sửa";
            this.btnSuaGV.UseVisualStyleBackColor = true;
            this.btnSuaGV.Click += new System.EventHandler(this.btnSuaGV_Click);
            // 
            // cboTimKiemGV
            // 
            this.cboTimKiemGV.FormattingEnabled = true;
            this.cboTimKiemGV.Items.AddRange(new object[] {
            "Tên giáo viên",
            "Dân tộc",
            "Tôn giáo",
            "Quê quán",
            "Địa chỉ",
            "Tổ chuyên môn",
            "Chức vụ",
            "Môn học"});
            this.cboTimKiemGV.Location = new System.Drawing.Point(139, 223);
            this.cboTimKiemGV.Name = "cboTimKiemGV";
            this.cboTimKiemGV.Size = new System.Drawing.Size(158, 21);
            this.cboTimKiemGV.TabIndex = 56;
            this.cboTimKiemGV.SelectedIndexChanged += new System.EventHandler(this.cboTimKiemGV_SelectedIndexChanged);
            // 
            // txtTimKiemGV
            // 
            this.txtTimKiemGV.Location = new System.Drawing.Point(319, 223);
            this.txtTimKiemGV.Name = "txtTimKiemGV";
            this.txtTimKiemGV.Size = new System.Drawing.Size(164, 20);
            this.txtTimKiemGV.TabIndex = 57;
            this.txtTimKiemGV.TextChanged += new System.EventHandler(this.cboTimKiemGV_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(44, 226);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 13);
            this.label12.TabIndex = 55;
            this.label12.Text = "Tìm kiếm theo:";
            // 
            // cboMonHocGV
            // 
            this.cboMonHocGV.DataSource = this.monhocBindingSource;
            this.cboMonHocGV.DisplayMember = "ten";
            this.cboMonHocGV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMonHocGV.FormattingEnabled = true;
            this.cboMonHocGV.Location = new System.Drawing.Point(631, 137);
            this.cboMonHocGV.Name = "cboMonHocGV";
            this.cboMonHocGV.Size = new System.Drawing.Size(164, 21);
            this.cboMonHocGV.TabIndex = 54;
            this.cboMonHocGV.ValueMember = "ma";
            // 
            // monhocBindingSource
            // 
            this.monhocBindingSource.DataMember = "monhoc";
            this.monhocBindingSource.DataSource = this.quanLyGVHSTHPTDataSet;
            // 
            // quanLyGVHSTHPTDataSet
            // 
            this.quanLyGVHSTHPTDataSet.DataSetName = "QuanLyGVHSTHPTDataSet";
            this.quanLyGVHSTHPTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cboChucVuGV
            // 
            this.cboChucVuGV.DataSource = this.chucvuBindingSource;
            this.cboChucVuGV.DisplayMember = "ten";
            this.cboChucVuGV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboChucVuGV.FormattingEnabled = true;
            this.cboChucVuGV.Location = new System.Drawing.Point(631, 110);
            this.cboChucVuGV.Name = "cboChucVuGV";
            this.cboChucVuGV.Size = new System.Drawing.Size(164, 21);
            this.cboChucVuGV.TabIndex = 53;
            this.cboChucVuGV.ValueMember = "ma";
            // 
            // chucvuBindingSource
            // 
            this.chucvuBindingSource.DataMember = "chucvu";
            this.chucvuBindingSource.DataSource = this.quanLyGVHSTHPTDataSet;
            // 
            // cboTonGiaoGV
            // 
            this.cboTonGiaoGV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTonGiaoGV.FormattingEnabled = true;
            this.cboTonGiaoGV.Items.AddRange(new object[] {
            "Không",
            "Phật giáo",
            "Công giáo",
            "Hào hảo",
            "Cao đài",
            "Tin lành",
            "Khác"});
            this.cboTonGiaoGV.Location = new System.Drawing.Point(232, 136);
            this.cboTonGiaoGV.Name = "cboTonGiaoGV";
            this.cboTonGiaoGV.Size = new System.Drawing.Size(164, 21);
            this.cboTonGiaoGV.TabIndex = 48;
            // 
            // cboGioiTinhGV
            // 
            this.cboGioiTinhGV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGioiTinhGV.FormattingEnabled = true;
            this.cboGioiTinhGV.Items.AddRange(new object[] {
            "Nữ",
            "Nam"});
            this.cboGioiTinhGV.Location = new System.Drawing.Point(232, 110);
            this.cboGioiTinhGV.Name = "cboGioiTinhGV";
            this.cboGioiTinhGV.Size = new System.Drawing.Size(164, 21);
            this.cboGioiTinhGV.TabIndex = 47;
            // 
            // dtpNgaySinhGV
            // 
            this.dtpNgaySinhGV.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinhGV.Location = new System.Drawing.Point(631, 33);
            this.dtpNgaySinhGV.Name = "dtpNgaySinhGV";
            this.dtpNgaySinhGV.Size = new System.Drawing.Size(164, 20);
            this.dtpNgaySinhGV.TabIndex = 50;
            // 
            // txtQueQuanGV
            // 
            this.txtQueQuanGV.Location = new System.Drawing.Point(232, 163);
            this.txtQueQuanGV.Name = "txtQueQuanGV";
            this.txtQueQuanGV.Size = new System.Drawing.Size(164, 20);
            this.txtQueQuanGV.TabIndex = 49;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(134, 166);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 43;
            this.label10.Text = "Quê quán:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(134, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 42;
            this.label5.Text = "Tôn giáo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(134, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 44;
            this.label4.Text = "Giới tính:";
            // 
            // txtDanTocGV
            // 
            this.txtDanTocGV.Location = new System.Drawing.Point(232, 85);
            this.txtDanTocGV.Name = "txtDanTocGV";
            this.txtDanTocGV.Size = new System.Drawing.Size(164, 20);
            this.txtDanTocGV.TabIndex = 46;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(134, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Dân tộc:";
            // 
            // txtTenGV
            // 
            this.txtTenGV.Location = new System.Drawing.Point(232, 59);
            this.txtTenGV.Name = "txtTenGV";
            this.txtTenGV.Size = new System.Drawing.Size(164, 20);
            this.txtTenGV.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Tên giáo viên:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(533, 140);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 13);
            this.label11.TabIndex = 38;
            this.label11.Text = "Môn học:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(533, 114);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 37;
            this.label9.Text = "Chức vụ:";
            // 
            // txtToChuyenMonGV
            // 
            this.txtToChuyenMonGV.Location = new System.Drawing.Point(631, 85);
            this.txtToChuyenMonGV.Name = "txtToChuyenMonGV";
            this.txtToChuyenMonGV.ReadOnly = true;
            this.txtToChuyenMonGV.Size = new System.Drawing.Size(164, 20);
            this.txtToChuyenMonGV.TabIndex = 52;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(533, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 13);
            this.label8.TabIndex = 36;
            this.label8.Text = "Tổ chuyên môn:";
            // 
            // txtDiaChiGV
            // 
            this.txtDiaChiGV.Location = new System.Drawing.Point(631, 59);
            this.txtDiaChiGV.Name = "txtDiaChiGV";
            this.txtDiaChiGV.Size = new System.Drawing.Size(164, 20);
            this.txtDiaChiGV.TabIndex = 51;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(533, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 35;
            this.label7.Text = "Địa chỉ:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(533, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "Ngày sinh:";
            // 
            // txtMaGV
            // 
            this.txtMaGV.Location = new System.Drawing.Point(232, 33);
            this.txtMaGV.Name = "txtMaGV";
            this.txtMaGV.ReadOnly = true;
            this.txtMaGV.Size = new System.Drawing.Size(164, 20);
            this.txtMaGV.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "Mã giáo viên:";
            // 
            // chucvuTableAdapter
            // 
            this.chucvuTableAdapter.ClearBeforeFill = true;
            // 
            // monhocTableAdapter
            // 
            this.monhocTableAdapter.ClearBeforeFill = true;
            // 
            // frmGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 562);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvGiaoVien);
            this.MaximumSize = new System.Drawing.Size(1000, 601);
            this.MinimumSize = new System.Drawing.Size(1000, 601);
            this.Name = "frmGV";
            this.Text = "Giáo viên";
            this.Load += new System.EventHandler(this.frmGV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiaoVien)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.monhocBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyGVHSTHPTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chucvuBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dgvGiaoVien;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTaiLaiGV;
        private System.Windows.Forms.Button btnXoaGV;
        private System.Windows.Forms.Button btnThemGV;
        private System.Windows.Forms.Button btnSuaGV;
        private System.Windows.Forms.ComboBox cboTimKiemGV;
        private System.Windows.Forms.TextBox txtTimKiemGV;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cboMonHocGV;
        private System.Windows.Forms.ComboBox cboChucVuGV;
        private System.Windows.Forms.ComboBox cboTonGiaoGV;
        private System.Windows.Forms.ComboBox cboGioiTinhGV;
        private System.Windows.Forms.DateTimePicker dtpNgaySinhGV;
        private System.Windows.Forms.TextBox txtQueQuanGV;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDanTocGV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenGV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtToChuyenMonGV;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDiaChiGV;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMaGV;
        private System.Windows.Forms.Label label1;
        private QuanLyGVHSTHPTDataSet quanLyGVHSTHPTDataSet;
        private System.Windows.Forms.BindingSource chucvuBindingSource;
        private QuanLyGVHSTHPTDataSetTableAdapters.chucvuTableAdapter chucvuTableAdapter;
        private System.Windows.Forms.BindingSource monhocBindingSource;
        private QuanLyGVHSTHPTDataSetTableAdapters.monhocTableAdapter monhocTableAdapter;
    }
}