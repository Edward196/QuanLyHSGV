namespace QuanLyGVHSTHPT
{
    partial class frmHS
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
            this.btnThemHS = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvHocSinh = new System.Windows.Forms.DataGridView();
            this.txtTimKiemHS = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnXoaGV = new System.Windows.Forms.Button();
            this.btnSuaGV = new System.Windows.Forms.Button();
            this.cboHanhKiemHS = new System.Windows.Forms.ComboBox();
            this.cboHocLucHS = new System.Windows.Forms.ComboBox();
            this.cboLopHS = new System.Windows.Forms.ComboBox();
            this.cboKhoaHS = new System.Windows.Forms.ComboBox();
            this.cboGioiTinhHS = new System.Windows.Forms.ComboBox();
            this.dtpNgaySinhHS = new System.Windows.Forms.DateTimePicker();
            this.txtDiaChiHS = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtDanTocHS = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtTenHS = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.txtMaHS = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.quanLyGVHSTHPTDataSet = new QuanLyGVHSTHPT.QuanLyGVHSTHPTDataSet();
            this.khoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.khoaTableAdapter = new QuanLyGVHSTHPT.QuanLyGVHSTHPTDataSetTableAdapters.khoaTableAdapter();
            this.lopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lopTableAdapter = new QuanLyGVHSTHPT.QuanLyGVHSTHPTDataSetTableAdapters.lopTableAdapter();
            this.hoclucBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hoclucTableAdapter = new QuanLyGVHSTHPT.QuanLyGVHSTHPTDataSetTableAdapters.hoclucTableAdapter();
            this.hanhkiemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hanhkiemTableAdapter = new QuanLyGVHSTHPT.QuanLyGVHSTHPTDataSetTableAdapters.hanhkiemTableAdapter();
            this.btnTaiLaiHS = new System.Windows.Forms.Button();
            this.cboTimKiemHS = new System.Windows.Forms.ComboBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocSinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyGVHSTHPTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoclucBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hanhkiemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThemHS
            // 
            this.btnThemHS.Location = new System.Drawing.Point(538, 216);
            this.btnThemHS.Name = "btnThemHS";
            this.btnThemHS.Size = new System.Drawing.Size(75, 23);
            this.btnThemHS.TabIndex = 6;
            this.btnThemHS.Text = "Thêm";
            this.btnThemHS.UseVisualStyleBackColor = true;
            this.btnThemHS.Click += new System.EventHandler(this.btnThemHS_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cboTimKiemHS);
            this.groupBox2.Controls.Add(this.btnTaiLaiHS);
            this.groupBox2.Controls.Add(this.cboHanhKiemHS);
            this.groupBox2.Controls.Add(this.cboHocLucHS);
            this.groupBox2.Controls.Add(this.cboLopHS);
            this.groupBox2.Controls.Add(this.cboKhoaHS);
            this.groupBox2.Controls.Add(this.cboGioiTinhHS);
            this.groupBox2.Controls.Add(this.dtpNgaySinhHS);
            this.groupBox2.Controls.Add(this.txtDiaChiHS);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.txtDanTocHS);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.txtTenHS);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Controls.Add(this.label23);
            this.groupBox2.Controls.Add(this.txtMaHS);
            this.groupBox2.Controls.Add(this.label24);
            this.groupBox2.Controls.Add(this.btnXoaGV);
            this.groupBox2.Controls.Add(this.btnSuaGV);
            this.groupBox2.Controls.Add(this.txtTimKiemHS);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.btnThemHS);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(960, 272);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hồ sơ chi tiết";
            // 
            // dgvHocSinh
            // 
            this.dgvHocSinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHocSinh.Location = new System.Drawing.Point(12, 300);
            this.dgvHocSinh.Name = "dgvHocSinh";
            this.dgvHocSinh.Size = new System.Drawing.Size(960, 250);
            this.dgvHocSinh.TabIndex = 16;
            this.dgvHocSinh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHocSinh_CellClick);
            // 
            // txtTimKiemHS
            // 
            this.txtTimKiemHS.Location = new System.Drawing.Point(327, 223);
            this.txtTimKiemHS.Name = "txtTimKiemHS";
            this.txtTimKiemHS.Size = new System.Drawing.Size(164, 20);
            this.txtTimKiemHS.TabIndex = 74;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(52, 226);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 13);
            this.label12.TabIndex = 72;
            this.label12.Text = "Tìm kiếm theo:";
            // 
            // btnXoaGV
            // 
            this.btnXoaGV.Location = new System.Drawing.Point(743, 216);
            this.btnXoaGV.Name = "btnXoaGV";
            this.btnXoaGV.Size = new System.Drawing.Size(75, 23);
            this.btnXoaGV.TabIndex = 76;
            this.btnXoaGV.Text = "Xóa";
            this.btnXoaGV.UseVisualStyleBackColor = true;
            this.btnXoaGV.Click += new System.EventHandler(this.btnXoaGV_Click);
            // 
            // btnSuaGV
            // 
            this.btnSuaGV.Location = new System.Drawing.Point(640, 216);
            this.btnSuaGV.Name = "btnSuaGV";
            this.btnSuaGV.Size = new System.Drawing.Size(75, 23);
            this.btnSuaGV.TabIndex = 75;
            this.btnSuaGV.Text = "Sửa";
            this.btnSuaGV.UseVisualStyleBackColor = true;
            this.btnSuaGV.Click += new System.EventHandler(this.btnSuaGV_Click);
            // 
            // cboHanhKiemHS
            // 
            this.cboHanhKiemHS.DataSource = this.hanhkiemBindingSource;
            this.cboHanhKiemHS.DisplayMember = "ten";
            this.cboHanhKiemHS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHanhKiemHS.FormattingEnabled = true;
            this.cboHanhKiemHS.Location = new System.Drawing.Point(545, 138);
            this.cboHanhKiemHS.Name = "cboHanhKiemHS";
            this.cboHanhKiemHS.Size = new System.Drawing.Size(164, 21);
            this.cboHanhKiemHS.TabIndex = 96;
            this.cboHanhKiemHS.ValueMember = "ma";
            // 
            // cboHocLucHS
            // 
            this.cboHocLucHS.DataSource = this.hoclucBindingSource;
            this.cboHocLucHS.DisplayMember = "ten";
            this.cboHocLucHS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHocLucHS.FormattingEnabled = true;
            this.cboHocLucHS.Location = new System.Drawing.Point(545, 112);
            this.cboHocLucHS.Name = "cboHocLucHS";
            this.cboHocLucHS.Size = new System.Drawing.Size(164, 21);
            this.cboHocLucHS.TabIndex = 95;
            this.cboHocLucHS.ValueMember = "ma";
            // 
            // cboLopHS
            // 
            this.cboLopHS.DataSource = this.lopBindingSource;
            this.cboLopHS.DisplayMember = "ten";
            this.cboLopHS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLopHS.FormattingEnabled = true;
            this.cboLopHS.Location = new System.Drawing.Point(545, 86);
            this.cboLopHS.Name = "cboLopHS";
            this.cboLopHS.Size = new System.Drawing.Size(164, 21);
            this.cboLopHS.TabIndex = 94;
            this.cboLopHS.ValueMember = "ma";
            // 
            // cboKhoaHS
            // 
            this.cboKhoaHS.DataSource = this.khoaBindingSource;
            this.cboKhoaHS.DisplayMember = "ten";
            this.cboKhoaHS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKhoaHS.FormattingEnabled = true;
            this.cboKhoaHS.Location = new System.Drawing.Point(545, 60);
            this.cboKhoaHS.Name = "cboKhoaHS";
            this.cboKhoaHS.Size = new System.Drawing.Size(164, 21);
            this.cboKhoaHS.TabIndex = 93;
            this.cboKhoaHS.ValueMember = "ma";
            // 
            // cboGioiTinhHS
            // 
            this.cboGioiTinhHS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGioiTinhHS.FormattingEnabled = true;
            this.cboGioiTinhHS.Items.AddRange(new object[] {
            "Nữ",
            "Nam"});
            this.cboGioiTinhHS.Location = new System.Drawing.Point(150, 112);
            this.cboGioiTinhHS.Name = "cboGioiTinhHS";
            this.cboGioiTinhHS.Size = new System.Drawing.Size(164, 21);
            this.cboGioiTinhHS.TabIndex = 92;
            // 
            // dtpNgaySinhHS
            // 
            this.dtpNgaySinhHS.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinhHS.Location = new System.Drawing.Point(150, 86);
            this.dtpNgaySinhHS.Name = "dtpNgaySinhHS";
            this.dtpNgaySinhHS.Size = new System.Drawing.Size(164, 20);
            this.dtpNgaySinhHS.TabIndex = 91;
            // 
            // txtDiaChiHS
            // 
            this.txtDiaChiHS.Location = new System.Drawing.Point(545, 34);
            this.txtDiaChiHS.Name = "txtDiaChiHS";
            this.txtDiaChiHS.Size = new System.Drawing.Size(164, 20);
            this.txtDiaChiHS.TabIndex = 88;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(447, 88);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(28, 13);
            this.label14.TabIndex = 86;
            this.label14.Text = "Lớp:";
            // 
            // txtDanTocHS
            // 
            this.txtDanTocHS.Location = new System.Drawing.Point(150, 138);
            this.txtDanTocHS.Name = "txtDanTocHS";
            this.txtDanTocHS.Size = new System.Drawing.Size(164, 20);
            this.txtDanTocHS.TabIndex = 90;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(447, 63);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(35, 13);
            this.label15.TabIndex = 77;
            this.label15.Text = "Khóa:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(52, 115);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(50, 13);
            this.label16.TabIndex = 84;
            this.label16.Text = "Giới tính:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(52, 141);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(48, 13);
            this.label17.TabIndex = 83;
            this.label17.Text = "Dân tộc:";
            // 
            // txtTenHS
            // 
            this.txtTenHS.Location = new System.Drawing.Point(150, 60);
            this.txtTenHS.Name = "txtTenHS";
            this.txtTenHS.Size = new System.Drawing.Size(164, 20);
            this.txtTenHS.TabIndex = 89;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(52, 63);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(72, 13);
            this.label18.TabIndex = 82;
            this.label18.Text = "Tên học sinh:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(447, 141);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(61, 13);
            this.label20.TabIndex = 81;
            this.label20.Text = "Hạnh kiểm:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(447, 115);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(47, 13);
            this.label21.TabIndex = 80;
            this.label21.Text = "Học lực:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(447, 37);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(43, 13);
            this.label22.TabIndex = 79;
            this.label22.Text = "Địa chỉ:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(52, 88);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(57, 13);
            this.label23.TabIndex = 78;
            this.label23.Text = "Ngày sinh:";
            // 
            // txtMaHS
            // 
            this.txtMaHS.Location = new System.Drawing.Point(150, 34);
            this.txtMaHS.Name = "txtMaHS";
            this.txtMaHS.ReadOnly = true;
            this.txtMaHS.Size = new System.Drawing.Size(164, 20);
            this.txtMaHS.TabIndex = 87;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(52, 37);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(68, 13);
            this.label24.TabIndex = 85;
            this.label24.Text = "Mã học sinh:";
            // 
            // quanLyGVHSTHPTDataSet
            // 
            this.quanLyGVHSTHPTDataSet.DataSetName = "QuanLyGVHSTHPTDataSet";
            this.quanLyGVHSTHPTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // khoaBindingSource
            // 
            this.khoaBindingSource.DataMember = "khoa";
            this.khoaBindingSource.DataSource = this.quanLyGVHSTHPTDataSet;
            // 
            // khoaTableAdapter
            // 
            this.khoaTableAdapter.ClearBeforeFill = true;
            // 
            // lopBindingSource
            // 
            this.lopBindingSource.DataMember = "lop";
            this.lopBindingSource.DataSource = this.quanLyGVHSTHPTDataSet;
            // 
            // lopTableAdapter
            // 
            this.lopTableAdapter.ClearBeforeFill = true;
            // 
            // hoclucBindingSource
            // 
            this.hoclucBindingSource.DataMember = "hocluc";
            this.hoclucBindingSource.DataSource = this.quanLyGVHSTHPTDataSet;
            // 
            // hoclucTableAdapter
            // 
            this.hoclucTableAdapter.ClearBeforeFill = true;
            // 
            // hanhkiemBindingSource
            // 
            this.hanhkiemBindingSource.DataMember = "hanhkiem";
            this.hanhkiemBindingSource.DataSource = this.quanLyGVHSTHPTDataSet;
            // 
            // hanhkiemTableAdapter
            // 
            this.hanhkiemTableAdapter.ClearBeforeFill = true;
            // 
            // btnTaiLaiHS
            // 
            this.btnTaiLaiHS.Location = new System.Drawing.Point(856, 216);
            this.btnTaiLaiHS.Name = "btnTaiLaiHS";
            this.btnTaiLaiHS.Size = new System.Drawing.Size(75, 23);
            this.btnTaiLaiHS.TabIndex = 97;
            this.btnTaiLaiHS.Text = "Tải lại";
            this.btnTaiLaiHS.UseVisualStyleBackColor = true;
            this.btnTaiLaiHS.Click += new System.EventHandler(this.btnTaiLaiHS_Click);
            // 
            // cboTimKiemHS
            // 
            this.cboTimKiemHS.FormattingEnabled = true;
            this.cboTimKiemHS.Items.AddRange(new object[] {
            "Tên học sinh",
            "Dân tộc",
            "Địa chỉ",
            "Khóa",
            "Lớp",
            "Học lực",
            "Hạnh kiểm"});
            this.cboTimKiemHS.Location = new System.Drawing.Point(150, 223);
            this.cboTimKiemHS.Name = "cboTimKiemHS";
            this.cboTimKiemHS.Size = new System.Drawing.Size(158, 21);
            this.cboTimKiemHS.TabIndex = 98;
            this.cboTimKiemHS.SelectedIndexChanged += new System.EventHandler(this.cboTimKiemHS_SelectedIndexChanged_1);
            // 
            // frmHS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 562);
            this.Controls.Add(this.dgvHocSinh);
            this.Controls.Add(this.groupBox2);
            this.MaximumSize = new System.Drawing.Size(1000, 601);
            this.MinimumSize = new System.Drawing.Size(1000, 601);
            this.Name = "frmHS";
            this.Text = "frmHS";
            this.Load += new System.EventHandler(this.frmHS_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocSinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyGVHSTHPTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoclucBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hanhkiemBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnThemHS;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvHocSinh;
        private System.Windows.Forms.Button btnXoaGV;
        private System.Windows.Forms.Button btnSuaGV;
        private System.Windows.Forms.TextBox txtTimKiemHS;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cboHanhKiemHS;
        private System.Windows.Forms.ComboBox cboHocLucHS;
        private System.Windows.Forms.ComboBox cboLopHS;
        private System.Windows.Forms.ComboBox cboKhoaHS;
        private System.Windows.Forms.ComboBox cboGioiTinhHS;
        private System.Windows.Forms.DateTimePicker dtpNgaySinhHS;
        private System.Windows.Forms.TextBox txtDiaChiHS;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtDanTocHS;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtTenHS;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtMaHS;
        private System.Windows.Forms.Label label24;
        private QuanLyGVHSTHPTDataSet quanLyGVHSTHPTDataSet;
        private System.Windows.Forms.BindingSource khoaBindingSource;
        private QuanLyGVHSTHPTDataSetTableAdapters.khoaTableAdapter khoaTableAdapter;
        private System.Windows.Forms.BindingSource lopBindingSource;
        private QuanLyGVHSTHPTDataSetTableAdapters.lopTableAdapter lopTableAdapter;
        private System.Windows.Forms.BindingSource hoclucBindingSource;
        private QuanLyGVHSTHPTDataSetTableAdapters.hoclucTableAdapter hoclucTableAdapter;
        private System.Windows.Forms.BindingSource hanhkiemBindingSource;
        private QuanLyGVHSTHPTDataSetTableAdapters.hanhkiemTableAdapter hanhkiemTableAdapter;
        private System.Windows.Forms.Button btnTaiLaiHS;
        private System.Windows.Forms.ComboBox cboTimKiemHS;
    }
}