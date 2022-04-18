namespace BTL_HuongSuKien.Forms
{
    partial class QuanLiNhanVien
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
     /*   private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Form1";
        }*/
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phòngBanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewDSNhanVien = new System.Windows.Forms.DataGridView();
            this.buttonLoc = new System.Windows.Forms.Button();
            this.comboBoxTenChucVu = new System.Windows.Forms.ComboBox();
            this.buttonXoaNhanVien = new System.Windows.Forms.Button();
            this.buttonChiTietNV = new System.Windows.Forms.Button();
            this.comboBoxTenPhongBan = new System.Windows.Forms.ComboBox();
            this.buttonThemNhanVien = new System.Windows.Forms.Button();
            this.buttonLamMoi = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDSNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhânViênToolStripMenuItem,
            this.phòngBanToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1000, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nhânViênToolStripMenuItem
            // 
            this.nhânViênToolStripMenuItem.Name = "nhânViênToolStripMenuItem";
            this.nhânViênToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.nhânViênToolStripMenuItem.Text = "Nhân Viên";
            // 
            // phòngBanToolStripMenuItem
            // 
            this.phòngBanToolStripMenuItem.Name = "phòngBanToolStripMenuItem";
            this.phòngBanToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.phòngBanToolStripMenuItem.Text = "Phòng Ban";
            // 
            // dataGridViewDSNhanVien
            // 
            this.dataGridViewDSNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDSNhanVien.Location = new System.Drawing.Point(93, 97);
            this.dataGridViewDSNhanVien.Name = "dataGridViewDSNhanVien";
            this.dataGridViewDSNhanVien.Size = new System.Drawing.Size(850, 250);
            this.dataGridViewDSNhanVien.TabIndex = 1;
            this.dataGridViewDSNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.getIdNhanVien);
            // 
            // buttonLoc
            // 
            this.buttonLoc.Location = new System.Drawing.Point(856, 49);
            this.buttonLoc.Name = "buttonLoc";
            this.buttonLoc.Size = new System.Drawing.Size(87, 30);
            this.buttonLoc.TabIndex = 4;
            this.buttonLoc.Text = "Lọc";
            this.buttonLoc.UseVisualStyleBackColor = true;
            this.buttonLoc.Click += new System.EventHandler(this.filterDanhSachNhanVien);
            // 
            // comboBoxTenChucVu
            // 
            this.comboBoxTenChucVu.FormattingEnabled = true;
            this.comboBoxTenChucVu.Items.AddRange(new object[] {
            "Trưởng Phòng",
            "Phó Phòng",
            "Nhân Viên",
            "Thử Việc"});
            this.comboBoxTenChucVu.Location = new System.Drawing.Point(334, 55);
            this.comboBoxTenChucVu.Name = "comboBoxTenChucVu";
            this.comboBoxTenChucVu.Size = new System.Drawing.Size(150, 21);
            this.comboBoxTenChucVu.TabIndex = 5;
            this.comboBoxTenChucVu.Text = "Chức Vụ";
            // 
            // buttonXoaNhanVien
            // 
            this.buttonXoaNhanVien.Location = new System.Drawing.Point(93, 364);
            this.buttonXoaNhanVien.Name = "buttonXoaNhanVien";
            this.buttonXoaNhanVien.Size = new System.Drawing.Size(113, 40);
            this.buttonXoaNhanVien.TabIndex = 6;
            this.buttonXoaNhanVien.Text = "Xóa nhân viên";
            this.buttonXoaNhanVien.UseVisualStyleBackColor = true;
            // 
            // buttonChiTietNV
            // 
            this.buttonChiTietNV.Location = new System.Drawing.Point(830, 364);
            this.buttonChiTietNV.Name = "buttonChiTietNV";
            this.buttonChiTietNV.Size = new System.Drawing.Size(113, 40);
            this.buttonChiTietNV.TabIndex = 7;
            this.buttonChiTietNV.Text = "Xem Chi Tiết";
            this.buttonChiTietNV.UseVisualStyleBackColor = true;
            this.buttonChiTietNV.Click += new System.EventHandler(this.openChiTietNhanVien);
            // 
            // comboBoxTenPhongBan
            // 
            this.comboBoxTenPhongBan.FormattingEnabled = true;
            this.comboBoxTenPhongBan.ItemHeight = 13;
            this.comboBoxTenPhongBan.Items.AddRange(new object[] {
            "Phòng kinh doanh",
            "Phòng nhân sự",
            "Phòng kế toán",
            "Phòng marketing",
            "Phòng kỹ thuật"});
            this.comboBoxTenPhongBan.Location = new System.Drawing.Point(93, 55);
            this.comboBoxTenPhongBan.Name = "comboBoxTenPhongBan";
            this.comboBoxTenPhongBan.Size = new System.Drawing.Size(150, 21);
            this.comboBoxTenPhongBan.TabIndex = 8;
            this.comboBoxTenPhongBan.Text = "Phòng ban";
            // 
            // buttonThemNhanVien
            // 
            this.buttonThemNhanVien.Location = new System.Drawing.Point(238, 364);
            this.buttonThemNhanVien.Name = "buttonThemNhanVien";
            this.buttonThemNhanVien.Size = new System.Drawing.Size(113, 40);
            this.buttonThemNhanVien.TabIndex = 9;
            this.buttonThemNhanVien.Text = "Thêm nhân viên";
            this.buttonThemNhanVien.UseVisualStyleBackColor = true;
            this.buttonThemNhanVien.Click += new System.EventHandler(this.clickThemNhanVien);
            // 
            // buttonLamMoi
            // 
            this.buttonLamMoi.Location = new System.Drawing.Point(741, 49);
            this.buttonLamMoi.Name = "buttonLamMoi";
            this.buttonLamMoi.Size = new System.Drawing.Size(91, 30);
            this.buttonLamMoi.TabIndex = 10;
            this.buttonLamMoi.Text = "Làm mới";
            this.buttonLamMoi.UseVisualStyleBackColor = true;
            this.buttonLamMoi.Click += new System.EventHandler(this.clickLamMoi);
            // 
            // QuanLiNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1000, 450);
            this.Controls.Add(this.buttonLamMoi);
            this.Controls.Add(this.buttonThemNhanVien);
            this.Controls.Add(this.comboBoxTenPhongBan);
            this.Controls.Add(this.buttonChiTietNV);
            this.Controls.Add(this.buttonXoaNhanVien);
            this.Controls.Add(this.comboBoxTenChucVu);
            this.Controls.Add(this.buttonLoc);
            this.Controls.Add(this.dataGridViewDSNhanVien);
            this.Controls.Add(this.menuStrip1);
            this.Name = "QuanLiNhanVien";
            this.Text = "Quản Lí Nhân Viên";
            this.Load += new System.EventHandler(this.loadDanhSachNhanVien);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDSNhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phòngBanToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridViewDSNhanVien;
        private System.Windows.Forms.Button buttonLoc;
        private System.Windows.Forms.ComboBox comboBoxTenChucVu;
        private System.Windows.Forms.Button buttonXoaNhanVien;
        private System.Windows.Forms.Button buttonChiTietNV;
        #endregion

        private System.Windows.Forms.ComboBox comboBoxTenPhongBan;
        private System.Windows.Forms.Button buttonThemNhanVien;
        private System.Windows.Forms.Button buttonLamMoi;
    }
}
