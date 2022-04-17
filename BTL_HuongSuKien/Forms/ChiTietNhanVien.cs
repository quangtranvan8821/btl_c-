using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BTL_HuongSuKien.Forms
{
    public partial class ChiTietNhanVien : Form
    {
        public ChiTietNhanVien()
        {
            InitializeComponent();
        }

        private void loadDataNhanVien(object sender, EventArgs e)
        {
            //MessageBox.Show("Id_nhan_vien: " + QuanLiNhanVien.id_nhan_vien.ToString());
            ConnectDB connect = new ConnectDB();

            String sql = "procGetChiTietNhanVien";
            String procVar = "@id_NV";
            int id_nhan_vien = QuanLiNhanVien.id_nhan_vien;

            DTO.NhanVien dataNhanVien = (DTO.NhanVien)connect.getChiTietNhanVien(sql, procVar, id_nhan_vien);

            textBoxMaNhanVien.Text = dataNhanVien.Id_hop_dong.ToString();
            textBoxTenNhanVien.Text = dataNhanVien.Ten_nhan_vien.ToString();
            textBoxDiaChi.Text = dataNhanVien.Dia_chi.ToString();
            textBoxNgaySinh.Text = dataNhanVien.Ngay_sinh.ToShortDateString();
            textBoxSDT.Text = dataNhanVien.Sdt.ToString();
/*            comboBoxTenChucVu.SelectedIndex = tenchucvu(dataNhanVien.Ten_chuc_vu) + 1;
            comboBoxTenPhongBan.SelectedIndex = tenphongban(dataNhanVien.Ten_phong_ban) + 1;*/

            comboBoxTenChucVu.SelectedIndex = 1;
            comboBoxTenPhongBan.SelectedIndex = 1;
            MessageBox.Show(tenchucvu(dataNhanVien.Ten_chuc_vu).ToString());

            if (dataNhanVien.Gioi_tinh.ToString() == "Nam")
            {
                radioButtonNam.Checked = true;
            }
            else
            {
                radioButtonNu.Checked = true;
            }
            //MessageBox.Show(dataNhanVien.ToString());
        }
        public int tenchucvu(string ten_chuc_vu)
        {
            ConnectDB connect = new ConnectDB();
            string sql = "SELECT id FROM chuc_vu WHERE ten_chuc_vu = '" + ten_chuc_vu + "'";
            int index = Convert.ToInt32(connect.ExcuteScalar(sql));
            return index;
        }
        public int tenphongban(string ten_phong_ban)
        {
            ConnectDB connect = new ConnectDB();
            string sql = "SELECT id FROM phong_ban WHERE ten_phong_ban = '" + ten_phong_ban + "'";
            int index = Convert.ToInt32(connect.ExcuteScalar(sql));
            return index;
        }
    }
}
