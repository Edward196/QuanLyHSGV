namespace QuanLyGVHSTHPT
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quảnLýGiáoViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýHọcSinhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hướngDẫnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýGiáoViênToolStripMenuItem,
            this.quảnLýHọcSinhToolStripMenuItem,
            this.hướngDẫnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(420, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quảnLýGiáoViênToolStripMenuItem
            // 
            this.quảnLýGiáoViênToolStripMenuItem.Name = "quảnLýGiáoViênToolStripMenuItem";
            this.quảnLýGiáoViênToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.quảnLýGiáoViênToolStripMenuItem.Text = "Quản lý giáo viên";
            this.quảnLýGiáoViênToolStripMenuItem.Click += new System.EventHandler(this.quảnLýGiáoViênToolStripMenuItem_Click);
            // 
            // quảnLýHọcSinhToolStripMenuItem
            // 
            this.quảnLýHọcSinhToolStripMenuItem.Name = "quảnLýHọcSinhToolStripMenuItem";
            this.quảnLýHọcSinhToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.quảnLýHọcSinhToolStripMenuItem.Text = "Quản lý học sinh";
            this.quảnLýHọcSinhToolStripMenuItem.Click += new System.EventHandler(this.quảnLýHọcSinhToolStripMenuItem_Click);
            // 
            // hướngDẫnToolStripMenuItem
            // 
            this.hướngDẫnToolStripMenuItem.Name = "hướngDẫnToolStripMenuItem";
            this.hướngDẫnToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.hướngDẫnToolStripMenuItem.Text = "Hướng dẫn";
            this.hướngDẫnToolStripMenuItem.Click += new System.EventHandler(this.hướngDẫnToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QuanLyGVHSTHPT.Properties.Resources.School;
            this.pictureBox1.Location = new System.Drawing.Point(12, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(398, 267);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 302);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MaximumSize = new System.Drawing.Size(436, 341);
            this.MinimumSize = new System.Drawing.Size(436, 341);
            this.Name = "frmMain";
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quảnLýGiáoViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýHọcSinhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hướngDẫnToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

