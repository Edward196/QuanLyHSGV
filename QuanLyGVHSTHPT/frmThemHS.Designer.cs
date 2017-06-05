namespace QuanLyGVHSTHPT
{
    partial class frmThemHS
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
            this.btnThoat = new System.Windows.Forms.Button();
            this.cboHanhKiemHS = new System.Windows.Forms.ComboBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.dtpNgaysinhHS = new System.Windows.Forms.DateTimePicker();
            this.cboHocLucHS = new System.Windows.Forms.ComboBox();
            this.cboKhoaHS = new System.Windows.Forms.ComboBox();
            this.cboLopHS = new System.Windows.Forms.ComboBox();
            this.cboGioiTinhHS = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDanTocHS = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenHS = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDiaChiHS = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.quanLyGVHSTHPTDataSet = new QuanLyGVHSTHPT.QuanLyGVHSTHPTDataSet();
            this.lopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lopTableAdapter = new QuanLyGVHSTHPT.QuanLyGVHSTHPTDataSetTableAdapters.lopTableAdapter();
            this.khoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.khoaTableAdapter = new QuanLyGVHSTHPT.QuanLyGVHSTHPTDataSetTableAdapters.khoaTableAdapter();
            this.hoclucBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hoclucTableAdapter = new QuanLyGVHSTHPT.QuanLyGVHSTHPTDataSetTableAdapters.hoclucTableAdapter();
            this.hanhkiemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hanhkiemTableAdapter = new QuanLyGVHSTHPT.QuanLyGVHSTHPTDataSetTableAdapters.hanhkiemTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyGVHSTHPTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoclucBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hanhkiemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(424, 305);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(130, 32);
            this.btnThoat.TabIndex = 66;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // cboHanhKiemHS
            // 
            this.cboHanhKiemHS.DataSource = this.hanhkiemBindingSource;
            this.cboHanhKiemHS.DisplayMember = "ten";
            this.cboHanhKiemHS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHanhKiemHS.FormattingEnabled = true;
            this.cboHanhKiemHS.Location = new System.Drawing.Point(477, 180);
            this.cboHanhKiemHS.Name = "cboHanhKiemHS";
            this.cboHanhKiemHS.Size = new System.Drawing.Size(164, 21);
            this.cboHanhKiemHS.TabIndex = 64;
            this.cboHanhKiemHS.ValueMember = "ma";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(166, 305);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(130, 32);
            this.btnThem.TabIndex = 65;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dtpNgaysinhHS
            // 
            this.dtpNgaysinhHS.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaysinhHS.Location = new System.Drawing.Point(477, 37);
            this.dtpNgaysinhHS.Name = "dtpNgaysinhHS";
            this.dtpNgaysinhHS.Size = new System.Drawing.Size(164, 20);
            this.dtpNgaysinhHS.TabIndex = 61;
            // 
            // cboHocLucHS
            // 
            this.cboHocLucHS.DataSource = this.hoclucBindingSource;
            this.cboHocLucHS.DisplayMember = "ten";
            this.cboHocLucHS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHocLucHS.FormattingEnabled = true;
            this.cboHocLucHS.Location = new System.Drawing.Point(477, 133);
            this.cboHocLucHS.Name = "cboHocLucHS";
            this.cboHocLucHS.Size = new System.Drawing.Size(164, 21);
            this.cboHocLucHS.TabIndex = 63;
            this.cboHocLucHS.ValueMember = "ma";
            // 
            // cboKhoaHS
            // 
            this.cboKhoaHS.DataSource = this.khoaBindingSource;
            this.cboKhoaHS.DisplayMember = "ten";
            this.cboKhoaHS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKhoaHS.FormattingEnabled = true;
            this.cboKhoaHS.Location = new System.Drawing.Point(157, 226);
            this.cboKhoaHS.Name = "cboKhoaHS";
            this.cboKhoaHS.Size = new System.Drawing.Size(164, 21);
            this.cboKhoaHS.TabIndex = 60;
            this.cboKhoaHS.ValueMember = "ma";
            // 
            // cboLopHS
            // 
            this.cboLopHS.DataSource = this.lopBindingSource;
            this.cboLopHS.DisplayMember = "ten";
            this.cboLopHS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLopHS.FormattingEnabled = true;
            this.cboLopHS.Location = new System.Drawing.Point(157, 180);
            this.cboLopHS.Name = "cboLopHS";
            this.cboLopHS.Size = new System.Drawing.Size(164, 21);
            this.cboLopHS.TabIndex = 59;
            this.cboLopHS.ValueMember = "ma";
            // 
            // cboGioiTinhHS
            // 
            this.cboGioiTinhHS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGioiTinhHS.FormattingEnabled = true;
            this.cboGioiTinhHS.Items.AddRange(new object[] {
            "Nữ",
            "Nam"});
            this.cboGioiTinhHS.Location = new System.Drawing.Point(157, 133);
            this.cboGioiTinhHS.Name = "cboGioiTinhHS";
            this.cboGioiTinhHS.Size = new System.Drawing.Size(164, 21);
            this.cboGioiTinhHS.TabIndex = 58;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(59, 229);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 67;
            this.label10.Text = "Khóa:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 69;
            this.label5.Text = "Lớp:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 70;
            this.label4.Text = "Giới tính:";
            // 
            // txtDanTocHS
            // 
            this.txtDanTocHS.Location = new System.Drawing.Point(157, 86);
            this.txtDanTocHS.Name = "txtDanTocHS";
            this.txtDanTocHS.Size = new System.Drawing.Size(164, 20);
            this.txtDanTocHS.TabIndex = 57;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 72;
            this.label3.Text = "Dân tộc:";
            // 
            // txtTenHS
            // 
            this.txtTenHS.Location = new System.Drawing.Point(157, 40);
            this.txtTenHS.Name = "txtTenHS";
            this.txtTenHS.Size = new System.Drawing.Size(164, 20);
            this.txtTenHS.TabIndex = 56;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 73;
            this.label2.Text = "Tên học sinh:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(377, 183);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 13);
            this.label11.TabIndex = 74;
            this.label11.Text = "Hạnh kiểm:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(379, 136);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 75;
            this.label9.Text = "Học lực:";
            // 
            // txtDiaChiHS
            // 
            this.txtDiaChiHS.Location = new System.Drawing.Point(477, 86);
            this.txtDiaChiHS.Name = "txtDiaChiHS";
            this.txtDiaChiHS.Size = new System.Drawing.Size(164, 20);
            this.txtDiaChiHS.TabIndex = 62;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(379, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 71;
            this.label7.Text = "Địa chỉ:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(379, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 68;
            this.label6.Text = "Ngày sinh:";
            // 
            // quanLyGVHSTHPTDataSet
            // 
            this.quanLyGVHSTHPTDataSet.DataSetName = "QuanLyGVHSTHPTDataSet";
            this.quanLyGVHSTHPTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // khoaBindingSource
            // 
            this.khoaBindingSource.DataMember = "khoa";
            this.khoaBindingSource.DataSource = this.quanLyGVHSTHPTDataSet;
            // 
            // khoaTableAdapter
            // 
            this.khoaTableAdapter.ClearBeforeFill = true;
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
            // frmThemHS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 375);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.cboHanhKiemHS);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dtpNgaysinhHS);
            this.Controls.Add(this.cboHocLucHS);
            this.Controls.Add(this.cboKhoaHS);
            this.Controls.Add(this.cboLopHS);
            this.Controls.Add(this.cboGioiTinhHS);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDanTocHS);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTenHS);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtDiaChiHS);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.MaximumSize = new System.Drawing.Size(716, 414);
            this.MinimumSize = new System.Drawing.Size(716, 414);
            this.Name = "frmThemHS";
            this.Text = "frmThemHS";
            this.Load += new System.EventHandler(this.frmThemHS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quanLyGVHSTHPTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoclucBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hanhkiemBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ComboBox cboHanhKiemHS;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DateTimePicker dtpNgaysinhHS;
        private System.Windows.Forms.ComboBox cboHocLucHS;
        private System.Windows.Forms.ComboBox cboKhoaHS;
        private System.Windows.Forms.ComboBox cboLopHS;
        private System.Windows.Forms.ComboBox cboGioiTinhHS;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDanTocHS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenHS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDiaChiHS;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private QuanLyGVHSTHPTDataSet quanLyGVHSTHPTDataSet;
        private System.Windows.Forms.BindingSource lopBindingSource;
        private QuanLyGVHSTHPTDataSetTableAdapters.lopTableAdapter lopTableAdapter;
        private System.Windows.Forms.BindingSource khoaBindingSource;
        private QuanLyGVHSTHPTDataSetTableAdapters.khoaTableAdapter khoaTableAdapter;
        private System.Windows.Forms.BindingSource hoclucBindingSource;
        private QuanLyGVHSTHPTDataSetTableAdapters.hoclucTableAdapter hoclucTableAdapter;
        private System.Windows.Forms.BindingSource hanhkiemBindingSource;
        private QuanLyGVHSTHPTDataSetTableAdapters.hanhkiemTableAdapter hanhkiemTableAdapter;
    }
}