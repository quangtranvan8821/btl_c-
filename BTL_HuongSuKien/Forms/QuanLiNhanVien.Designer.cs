﻿namespace BTL_HuongSuKien.Forms
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
            this.buttonLocTheoTen = new System.Windows.Forms.Button();
            this.buttonLoc = new System.Windows.Forms.Button();
            this.comboBoxTenChucVu = new System.Windows.Forms.ComboBox();
            this.buttonThemXoa = new System.Windows.Forms.Button();
            this.buttonChiTietNV = new System.Windows.Forms.Button();
            this.comboBoxTenPhongBan = new System.Windows.Forms.ComboBox();
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
            // buttonLocTheoTen
            // 
            this.buttonLocTheoTen.Location = new System.Drawing.Point(93, 49);
            this.buttonLocTheoTen.Name = "buttonLocTheoTen";
            this.buttonLocTheoTen.Size = new System.Drawing.Size(87, 30);
            this.buttonLocTheoTen.TabIndex = 2;
            this.buttonLocTheoTen.Text = "Tên A-Z";
            this.buttonLocTheoTen.UseVisualStyleBackColor = true;
            // 
            // buttonLoc
            // 
            this.buttonLoc.Location = new System.Drawing.Point(795, 46);
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
            this.comboBoxTenChucVu.Location = new System.Drawing.Point(560, 55);
            this.comboBoxTenChucVu.Name = "comboBoxTenChucVu";
            this.comboBoxTenChucVu.Size = new System.Drawing.Size(150, 21);
            this.comboBoxTenChucVu.TabIndex = 5;
            this.comboBoxTenChucVu.Text = "Chức Vụ";
            // 
            // buttonThemXoa
            // 
            this.buttonThemXoa.Location = new System.Drawing.Point(300, 364);
            this.buttonThemXoa.Name = "buttonThemXoa";
            this.buttonThemXoa.Size = new System.Drawing.Size(113, 40);
            this.buttonThemXoa.TabIndex = 6;
            this.buttonThemXoa.Text = "Thêm, Xóa ";
            this.buttonThemXoa.UseVisualStyleBackColor = true;
            // 
            // buttonChiTietNV
            // 
            this.buttonChiTietNV.Location = new System.Drawing.Point(624, 364);
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
            this.comboBoxTenPhongBan.Items.AddRange(new object[] {
            "Phòng kinh doanh",
            "Phòng nhân sự",
            "Phòng kế toán",
            "Phòng marketing",
            "Phòng kỹ thuật"});
            this.comboBoxTenPhongBan.Location = new System.Drawing.Point(284, 54);
            this.comboBoxTenPhongBan.Name = "comboBoxTenPhongBan";
            this.comboBoxTenPhongBan.Size = new System.Drawing.Size(150, 21);
            this.comboBoxTenPhongBan.TabIndex = 8;
            this.comboBoxTenPhongBan.Text = "Phòng ban";
            // 
            // QuanLiNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1000, 450);
            this.Controls.Add(this.comboBoxTenPhongBan);
            this.Controls.Add(this.buttonChiTietNV);
            this.Controls.Add(this.buttonThemXoa);
            this.Controls.Add(this.comboBoxTenChucVu);
            this.Controls.Add(this.buttonLoc);
            this.Controls.Add(this.buttonLocTheoTen);
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
        private System.Windows.Forms.Button buttonLocTheoTen;
        private System.Windows.Forms.Button buttonLoc;
        private System.Windows.Forms.ComboBox comboBoxTenChucVu;
        private System.Windows.Forms.Button buttonThemXoa;
        private System.Windows.Forms.Button buttonChiTietNV;
        #endregion

        private System.Windows.Forms.ComboBox comboBoxTenPhongBan;
    }
}
