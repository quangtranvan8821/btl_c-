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
            comboBoxTenChucVu.SelectedIndex = tenchucvu(dataNhanVien.Ten_chuc_vu);
            comboBoxTenPhongBan.SelectedIndex = tenphongban(dataNhanVien.Ten_phong_ban);
            if (dataNhanVien.Gioi_tinh.ToString()=="Nam")
            {
                radioButtonNam.Checked = true;
            }
            else
            {
                radioButtonNu.Checked = true;
            }
            //MessageBox.Show(dataNhanVien.ToString());
        }
        public int tenchucvu(string tenchucvu)
        {
            ConnectDB connect = new ConnectDB();
            string s="select id from chuc_vu where ten_chuc_vu='"+tenchucvu+"'";
            int index = Convert.ToInt32(connect.ExcuteScalar(s));
            return index-1;
        }
        public int tenphongban(string tenphongban)
        {
            ConnectDB connect = new ConnectDB();
            string s = "select id from phong_ban where ten_phong_ban='" + tenphongban + "'";
            int index = Convert.ToInt32(connect.ExcuteScalar(s));
            return index - 1;
        }
    }
}
