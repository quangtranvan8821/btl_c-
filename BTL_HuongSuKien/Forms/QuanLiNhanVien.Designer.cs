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
            this.buttonLocTheoTen = new System.Windows.Forms.Button();
            this.buttonLocTheoPB = new System.Windows.Forms.Button();
            this.buttonLoc = new System.Windows.Forms.Button();
            this.comboBoxLocTheoCV = new System.Windows.Forms.ComboBox();
            this.buttonThemXoa = new System.Windows.Forms.Button();
            this.buttonChiTietNV = new System.Windows.Forms.Button();
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
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
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
            this.dataGridViewDSNhanVien.Size = new System.Drawing.Size(606, 228);
            this.dataGridViewDSNhanVien.TabIndex = 1;
            // 
            // buttonLocTheoTen
            // 
            this.buttonLocTheoTen.Location = new System.Drawing.Point(93, 46);
            this.buttonLocTheoTen.Name = "buttonLocTheoTen";
            this.buttonLocTheoTen.Size = new System.Drawing.Size(87, 30);
            this.buttonLocTheoTen.TabIndex = 2;
            this.buttonLocTheoTen.Text = "Tên A-Z";
            this.buttonLocTheoTen.UseVisualStyleBackColor = true;
            // 
            // buttonLocTheoPB
            // 
            this.buttonLocTheoPB.Location = new System.Drawing.Point(259, 46);
            this.buttonLocTheoPB.Name = "buttonLocTheoPB";
            this.buttonLocTheoPB.Size = new System.Drawing.Size(87, 30);
            this.buttonLocTheoPB.TabIndex = 3;
            this.buttonLocTheoPB.Text = "Phòng Ban";
            this.buttonLocTheoPB.UseVisualStyleBackColor = true;
            // 
            // buttonLoc
            // 
            this.buttonLoc.Location = new System.Drawing.Point(612, 46);
            this.buttonLoc.Name = "buttonLoc";
            this.buttonLoc.Size = new System.Drawing.Size(87, 30);
            this.buttonLoc.TabIndex = 4;
            this.buttonLoc.Text = "Lọc";
            this.buttonLoc.UseVisualStyleBackColor = true;
            // 
            // comboBoxLocTheoCV
            // 
            this.comboBoxLocTheoCV.FormattingEnabled = true;
            this.comboBoxLocTheoCV.Items.AddRange(new object[] {
            "Trưởng Phòng",
            "Phó Phòng",
            "Nhân Viên",
            "Nhân Viên Thử Việc"});
            this.comboBoxLocTheoCV.Location = new System.Drawing.Point(411, 55);
            this.comboBoxLocTheoCV.Name = "comboBoxLocTheoCV";
            this.comboBoxLocTheoCV.Size = new System.Drawing.Size(139, 21);
            this.comboBoxLocTheoCV.TabIndex = 5;
            this.comboBoxLocTheoCV.Text = "Chức Vụ";
            // 
            // buttonThemXoa
            // 
            this.buttonThemXoa.Location = new System.Drawing.Point(209, 345);
            this.buttonThemXoa.Name = "buttonThemXoa";
            this.buttonThemXoa.Size = new System.Drawing.Size(113, 40);
            this.buttonThemXoa.TabIndex = 6;
            this.buttonThemXoa.Text = "Thêm, Xóa ";
            this.buttonThemXoa.UseVisualStyleBackColor = true;
            // 
            // buttonChiTietNV
            // 
            this.buttonChiTietNV.Location = new System.Drawing.Point(455, 345);
            this.buttonChiTietNV.Name = "buttonChiTietNV";
            this.buttonChiTietNV.Size = new System.Drawing.Size(113, 40);
            this.buttonChiTietNV.TabIndex = 7;
            this.buttonChiTietNV.Text = "Xem Chi Tiết";
            this.buttonChiTietNV.UseVisualStyleBackColor = true;
            // 
            // FormQLNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            //    this.BackgroundImage = global::BTL_HuongSuKien.Properties.Resources.pngtree_office_literary_fresh_hand_drawn_background_illustration_backgroundhand_painted_backgroundmeeting_image_595905;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonChiTietNV);
            this.Controls.Add(this.buttonThemXoa);
            this.Controls.Add(this.comboBoxLocTheoCV);
            this.Controls.Add(this.buttonLoc);
            this.Controls.Add(this.buttonLocTheoPB);
            this.Controls.Add(this.buttonLocTheoTen);
            this.Controls.Add(this.dataGridViewDSNhanVien);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FormQLNV";
            this.Text = "Quản Lí Nhân Viên";
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
        private System.Windows.Forms.Button buttonLocTheoPB;
        private System.Windows.Forms.Button buttonLoc;
        private System.Windows.Forms.ComboBox comboBoxLocTheoCV;
        private System.Windows.Forms.Button buttonThemXoa;
        private System.Windows.Forms.Button buttonChiTietNV;
        #endregion
    }
}
