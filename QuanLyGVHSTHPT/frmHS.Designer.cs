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
            this.btnThemHS = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
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
            this.groupBox2.Controls.Add(this.btnThemHS);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(960, 272);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hồ sơ chi tiết";
            // 
            // frmHS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 562);
            this.Controls.Add(this.groupBox2);
            this.MaximumSize = new System.Drawing.Size(1000, 601);
            this.MinimumSize = new System.Drawing.Size(1000, 601);
            this.Name = "frmHS";
            this.Text = "frmHS";
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnThemHS;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}