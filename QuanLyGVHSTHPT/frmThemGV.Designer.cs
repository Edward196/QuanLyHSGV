namespace QuanLyGVHSTHPT
{
    partial class frmThemGV
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
            this.btnThem = new System.Windows.Forms.Button();
            this.dtpNgaysinhGV = new System.Windows.Forms.DateTimePicker();
            this.cboMonHocGV = new System.Windows.Forms.ComboBox();
            this.monhocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyGVHSTHPTDataSet = new QuanLyGVHSTHPT.QuanLyGVHSTHPTDataSet();
            this.cboChucVuGV = new System.Windows.Forms.ComboBox();
            this.chucvuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cboTonGiaoGV = new System.Windows.Forms.ComboBox();
            this.cboGioiTinhGV = new System.Windows.Forms.ComboBox();
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
            this.txtDiaChiGV = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.chucvuTableAdapter = new QuanLyGVHSTHPT.QuanLyGVHSTHPTDataSetTableAdapters.chucvuTableAdapter();
            this.monhocTableAdapter = new QuanLyGVHSTHPT.QuanLyGVHSTHPTDataSetTableAdapters.monhocTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.monhocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyGVHSTHPTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chucvuBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(424, 306);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(130, 32);
            this.btnThoat.TabIndex = 50;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(166, 306);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(130, 32);
            this.btnThem.TabIndex = 48;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dtpNgaysinhGV
            // 
            this.dtpNgaysinhGV.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaysinhGV.Location = new System.Drawing.Point(477, 38);
            this.dtpNgaysinhGV.Name = "dtpNgaysinhGV";
            this.dtpNgaysinhGV.Size = new System.Drawing.Size(164, 20);
            this.dtpNgaysinhGV.TabIndex = 41;
            // 
            // cboMonHocGV
            // 
            this.cboMonHocGV.DataSource = this.monhocBindingSource;
            this.cboMonHocGV.DisplayMember = "ten";
            this.cboMonHocGV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMonHocGV.FormattingEnabled = true;
            this.cboMonHocGV.Location = new System.Drawing.Point(477, 181);
            this.cboMonHocGV.Name = "cboMonHocGV";
            this.cboMonHocGV.Size = new System.Drawing.Size(164, 21);
            this.cboMonHocGV.TabIndex = 46;
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
            this.cboChucVuGV.Location = new System.Drawing.Point(477, 134);
            this.cboChucVuGV.Name = "cboChucVuGV";
            this.cboChucVuGV.Size = new System.Drawing.Size(164, 21);
            this.cboChucVuGV.TabIndex = 45;
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
            this.cboTonGiaoGV.Location = new System.Drawing.Point(157, 181);
            this.cboTonGiaoGV.Name = "cboTonGiaoGV";
            this.cboTonGiaoGV.Size = new System.Drawing.Size(164, 21);
            this.cboTonGiaoGV.TabIndex = 37;
            // 
            // cboGioiTinhGV
            // 
            this.cboGioiTinhGV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGioiTinhGV.FormattingEnabled = true;
            this.cboGioiTinhGV.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cboGioiTinhGV.Location = new System.Drawing.Point(157, 134);
            this.cboGioiTinhGV.Name = "cboGioiTinhGV";
            this.cboGioiTinhGV.Size = new System.Drawing.Size(164, 21);
            this.cboGioiTinhGV.TabIndex = 35;
            // 
            // txtQueQuanGV
            // 
            this.txtQueQuanGV.Location = new System.Drawing.Point(157, 227);
            this.txtQueQuanGV.Name = "txtQueQuanGV";
            this.txtQueQuanGV.Size = new System.Drawing.Size(164, 20);
            this.txtQueQuanGV.TabIndex = 39;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(59, 230);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 36;
            this.label10.Text = "Quê quán:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 40;
            this.label5.Text = "Tôn giáo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 42;
            this.label4.Text = "Giới tính:";
            // 
            // txtDanTocGV
            // 
            this.txtDanTocGV.Location = new System.Drawing.Point(157, 87);
            this.txtDanTocGV.Name = "txtDanTocGV";
            this.txtDanTocGV.Size = new System.Drawing.Size(164, 20);
            this.txtDanTocGV.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 47;
            this.label3.Text = "Dân tộc:";
            // 
            // txtTenGV
            // 
            this.txtTenGV.Location = new System.Drawing.Point(157, 41);
            this.txtTenGV.Name = "txtTenGV";
            this.txtTenGV.Size = new System.Drawing.Size(164, 20);
            this.txtTenGV.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 49;
            this.label2.Text = "Tên giáo viên:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(377, 184);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 13);
            this.label11.TabIndex = 51;
            this.label11.Text = "Môn học:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(379, 137);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 52;
            this.label9.Text = "Chức vụ:";
            // 
            // txtDiaChiGV
            // 
            this.txtDiaChiGV.Location = new System.Drawing.Point(477, 87);
            this.txtDiaChiGV.Name = "txtDiaChiGV";
            this.txtDiaChiGV.Size = new System.Drawing.Size(164, 20);
            this.txtDiaChiGV.TabIndex = 43;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(379, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 44;
            this.label7.Text = "Địa chỉ:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(379, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 38;
            this.label6.Text = "Ngày sinh:";
            // 
            // chucvuTableAdapter
            // 
            this.chucvuTableAdapter.ClearBeforeFill = true;
            // 
            // monhocTableAdapter
            // 
            this.monhocTableAdapter.ClearBeforeFill = true;
            // 
            // frmThemGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 376);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dtpNgaysinhGV);
            this.Controls.Add(this.cboMonHocGV);
            this.Controls.Add(this.cboChucVuGV);
            this.Controls.Add(this.cboTonGiaoGV);
            this.Controls.Add(this.cboGioiTinhGV);
            this.Controls.Add(this.txtQueQuanGV);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDanTocGV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTenGV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtDiaChiGV);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.MaximumSize = new System.Drawing.Size(716, 414);
            this.MinimumSize = new System.Drawing.Size(716, 414);
            this.Name = "frmThemGV";
            this.Text = "Thêm giáo viên";
            this.Load += new System.EventHandler(this.frmThemGV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.monhocBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyGVHSTHPTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chucvuBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DateTimePicker dtpNgaysinhGV;
        private System.Windows.Forms.ComboBox cboMonHocGV;
        private System.Windows.Forms.ComboBox cboChucVuGV;
        private System.Windows.Forms.ComboBox cboTonGiaoGV;
        private System.Windows.Forms.ComboBox cboGioiTinhGV;
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
        private System.Windows.Forms.TextBox txtDiaChiGV;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private QuanLyGVHSTHPTDataSet quanLyGVHSTHPTDataSet;
        private System.Windows.Forms.BindingSource chucvuBindingSource;
        private QuanLyGVHSTHPTDataSetTableAdapters.chucvuTableAdapter chucvuTableAdapter;
        private System.Windows.Forms.BindingSource monhocBindingSource;
        private QuanLyGVHSTHPTDataSetTableAdapters.monhocTableAdapter monhocTableAdapter;
    }
}