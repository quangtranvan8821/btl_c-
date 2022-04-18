
namespace BTL_HuongSuKien.Forms
{
    partial class ThemNhanVien
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
            this.textBoxSDT = new System.Windows.Forms.TextBox();
            this.labelSoDienThoai = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButtonNu = new System.Windows.Forms.RadioButton();
            this.radioButtonNam = new System.Windows.Forms.RadioButton();
            this.comboBoxTenPhongBan = new System.Windows.Forms.ComboBox();
            this.comboBoxTenChucVu = new System.Windows.Forms.ComboBox();
            this.labelTenChucVu = new System.Windows.Forms.Label();
            this.labelTenPhongBan = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelNgaySinh = new System.Windows.Forms.Label();
            this.labelTenNhanVien = new System.Windows.Forms.Label();
            this.textBoxTenNhanVien = new System.Windows.Forms.TextBox();
            this.buttonThem = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonHuy = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.textBoxDiaChi = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxSDT
            // 
            this.textBoxSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSDT.Location = new System.Drawing.Point(694, 106);
            this.textBoxSDT.Name = "textBoxSDT";
            this.textBoxSDT.Size = new System.Drawing.Size(192, 22);
            this.textBoxSDT.TabIndex = 51;
            // 
            // labelSoDienThoai
            // 
            this.labelSoDienThoai.AutoSize = true;
            this.labelSoDienThoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSoDienThoai.Location = new System.Drawing.Point(581, 106);
            this.labelSoDienThoai.Name = "labelSoDienThoai";
            this.labelSoDienThoai.Size = new System.Drawing.Size(106, 20);
            this.labelSoDienThoai.TabIndex = 50;
            this.labelSoDienThoai.Text = "Số điện thoại:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButtonNu);
            this.panel1.Controls.Add(this.radioButtonNam);
            this.panel1.Location = new System.Drawing.Point(694, 160);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 94);
            this.panel1.TabIndex = 49;
            // 
            // radioButtonNu
            // 
            this.radioButtonNu.AutoSize = true;
            this.radioButtonNu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonNu.Location = new System.Drawing.Point(132, 13);
            this.radioButtonNu.Name = "radioButtonNu";
            this.radioButtonNu.Size = new System.Drawing.Size(47, 24);
            this.radioButtonNu.TabIndex = 1;
            this.radioButtonNu.TabStop = true;
            this.radioButtonNu.Text = "Nữ";
            this.radioButtonNu.UseVisualStyleBackColor = true;
            // 
            // radioButtonNam
            // 
            this.radioButtonNam.AutoSize = true;
            this.radioButtonNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonNam.Location = new System.Drawing.Point(4, 13);
            this.radioButtonNam.Name = "radioButtonNam";
            this.radioButtonNam.Size = new System.Drawing.Size(60, 24);
            this.radioButtonNam.TabIndex = 0;
            this.radioButtonNam.TabStop = true;
            this.radioButtonNam.Text = "Nam";
            this.radioButtonNam.UseVisualStyleBackColor = true;
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
            this.comboBoxTenPhongBan.Location = new System.Drawing.Point(208, 306);
            this.comboBoxTenPhongBan.Name = "comboBoxTenPhongBan";
            this.comboBoxTenPhongBan.Size = new System.Drawing.Size(303, 21);
            this.comboBoxTenPhongBan.TabIndex = 48;
            // 
            // comboBoxTenChucVu
            // 
            this.comboBoxTenChucVu.FormattingEnabled = true;
            this.comboBoxTenChucVu.Items.AddRange(new object[] {
            "Trưởng phòng",
            "Phó phòng",
            "Nhân viên",
            "Thực tập"});
            this.comboBoxTenChucVu.Location = new System.Drawing.Point(208, 262);
            this.comboBoxTenChucVu.Name = "comboBoxTenChucVu";
            this.comboBoxTenChucVu.Size = new System.Drawing.Size(303, 21);
            this.comboBoxTenChucVu.TabIndex = 47;
            // 
            // labelTenChucVu
            // 
            this.labelTenChucVu.AutoSize = true;
            this.labelTenChucVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTenChucVu.Location = new System.Drawing.Point(78, 264);
            this.labelTenChucVu.Name = "labelTenChucVu";
            this.labelTenChucVu.Size = new System.Drawing.Size(98, 20);
            this.labelTenChucVu.TabIndex = 46;
            this.labelTenChucVu.Text = "Tên chức vụ:";
            // 
            // labelTenPhongBan
            // 
            this.labelTenPhongBan.AutoSize = true;
            this.labelTenPhongBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTenPhongBan.Location = new System.Drawing.Point(78, 308);
            this.labelTenPhongBan.Name = "labelTenPhongBan";
            this.labelTenPhongBan.Size = new System.Drawing.Size(120, 20);
            this.labelTenPhongBan.TabIndex = 45;
            this.labelTenPhongBan.Text = "Tên phòng ban:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(581, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 44;
            this.label2.Text = "Giới tính:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 40;
            this.label1.Text = "Địa chỉ:";
            // 
            // labelNgaySinh
            // 
            this.labelNgaySinh.AutoSize = true;
            this.labelNgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNgaySinh.Location = new System.Drawing.Point(78, 161);
            this.labelNgaySinh.Name = "labelNgaySinh";
            this.labelNgaySinh.Size = new System.Drawing.Size(82, 20);
            this.labelNgaySinh.TabIndex = 38;
            this.labelNgaySinh.Text = "Ngày sinh:";
            // 
            // labelTenNhanVien
            // 
            this.labelTenNhanVien.AutoSize = true;
            this.labelTenNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTenNhanVien.Location = new System.Drawing.Point(78, 107);
            this.labelTenNhanVien.Name = "labelTenNhanVien";
            this.labelTenNhanVien.Size = new System.Drawing.Size(112, 20);
            this.labelTenNhanVien.TabIndex = 36;
            this.labelTenNhanVien.Text = "Tên nhân viên:";
            // 
            // textBoxTenNhanVien
            // 
            this.textBoxTenNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTenNhanVien.Location = new System.Drawing.Point(208, 107);
            this.textBoxTenNhanVien.Name = "textBoxTenNhanVien";
            this.textBoxTenNhanVien.Size = new System.Drawing.Size(303, 22);
            this.textBoxTenNhanVien.TabIndex = 37;
            // 
            // buttonThem
            // 
            this.buttonThem.Location = new System.Drawing.Point(806, 380);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(95, 41);
            this.buttonThem.TabIndex = 52;
            this.buttonThem.Text = "Thêm";
            this.buttonThem.UseVisualStyleBackColor = true;
            this.buttonThem.Click += new System.EventHandler(this.clickThem);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(664, 380);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(95, 41);
            this.buttonReset.TabIndex = 53;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.clickReset);
            // 
            // buttonHuy
            // 
            this.buttonHuy.Location = new System.Drawing.Point(523, 380);
            this.buttonHuy.Name = "buttonHuy";
            this.buttonHuy.Size = new System.Drawing.Size(95, 41);
            this.buttonHuy.TabIndex = 54;
            this.buttonHuy.Text = "Hủy";
            this.buttonHuy.UseVisualStyleBackColor = true;
            this.buttonHuy.Click += new System.EventHandler(this.clickHuy);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(371, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 31);
            this.label3.TabIndex = 55;
            this.label3.Text = "Thêm nhân viên";
            // 
            // dateTimePickerNgaySinh
            // 
            this.dateTimePickerNgaySinh.CustomFormat = "yyyy-MM-dd";
            this.dateTimePickerNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerNgaySinh.Location = new System.Drawing.Point(208, 161);
            this.dateTimePickerNgaySinh.Name = "dateTimePickerNgaySinh";
            this.dateTimePickerNgaySinh.Size = new System.Drawing.Size(304, 20);
            this.dateTimePickerNgaySinh.TabIndex = 56;
            // 
            // textBoxDiaChi
            // 
            this.textBoxDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDiaChi.Location = new System.Drawing.Point(207, 210);
            this.textBoxDiaChi.Name = "textBoxDiaChi";
            this.textBoxDiaChi.Size = new System.Drawing.Size(303, 22);
            this.textBoxDiaChi.TabIndex = 43;
            // 
            // ThemNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.dateTimePickerNgaySinh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonHuy);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonThem);
            this.Controls.Add(this.textBoxSDT);
            this.Controls.Add(this.labelSoDienThoai);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comboBoxTenPhongBan);
            this.Controls.Add(this.comboBoxTenChucVu);
            this.Controls.Add(this.labelTenChucVu);
            this.Controls.Add(this.labelTenPhongBan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxDiaChi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelNgaySinh);
            this.Controls.Add(this.labelTenNhanVien);
            this.Controls.Add(this.textBoxTenNhanVien);
            this.Name = "ThemNhanVien";
            this.Text = "Thêm Nhân Viên";
            this.Load += new System.EventHandler(this.ThemNhanVien_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSDT;
        private System.Windows.Forms.Label labelSoDienThoai;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButtonNu;
        private System.Windows.Forms.RadioButton radioButtonNam;
        private System.Windows.Forms.ComboBox comboBoxTenPhongBan;
        private System.Windows.Forms.ComboBox comboBoxTenChucVu;
        private System.Windows.Forms.Label labelTenChucVu;
        private System.Windows.Forms.Label labelTenPhongBan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelNgaySinh;
        private System.Windows.Forms.Label labelTenNhanVien;
        private System.Windows.Forms.TextBox textBoxTenNhanVien;
        private System.Windows.Forms.Button buttonThem;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonHuy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgaySinh;
        private System.Windows.Forms.TextBox textBoxDiaChi;
    }
}