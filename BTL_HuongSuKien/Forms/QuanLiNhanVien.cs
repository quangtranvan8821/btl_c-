using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_HuongSuKien.Forms
{
    public partial class QuanLiNhanVien : Form
    {
        public static int id_nhan_vien = 1;
        public QuanLiNhanVien()
        {
            InitializeComponent();
        }

        //load form event
        private void loadDanhSachNhanVien(object sender, EventArgs e)
        {
            ConnectDB connectDB = new ConnectDB();

            string sql = "SELECT * FROM danhSachNhanVien";

            getDanhSacnhNhanVien(connectDB.getTable(sql));

        }

        //pass data to data grid view danh sach nhan vien
        private void getDanhSacnhNhanVien(DataTable dataTable)
        {
            dataGridViewDSNhanVien.DataSource = dataTable;
        }

        //click on cell assign id_nhan_vien
        private void getIdNhanVien(object sender, DataGridViewCellEventArgs e)
        {
            id_nhan_vien = int.Parse(dataGridViewDSNhanVien.CurrentRow.Cells["Mã nhân viên"].Value.ToString());
        }

        private void openChiTietNhanVien(object sender, EventArgs e)
        {
            ChiTietNhanVien chiTietNhanVien = new ChiTietNhanVien();

            chiTietNhanVien.Show();
        }

        //click button lọc -> filter danh sach nhan vien
        private void filterDanhSachNhanVien(object sender, EventArgs e)
        {
            int ma_phong_ban = comboBoxTenPhongBan.SelectedIndex + 1;
            int ma_chuc_vu = comboBoxTenChucVu.SelectedIndex + 1;

            if(ma_phong_ban == 0 && ma_chuc_vu == 0)
            {
                ConnectDB connectDB = new ConnectDB();

                string sql = "SELECT * FROM danhSachNhanVien";

                getDanhSacnhNhanVien(connectDB.getTable(sql));
            } else {
                getDanhSachNhanVienFiltered();
            }
        }


        //filter danh sach nhan vien
        private void getDanhSachNhanVienFiltered()
        {
            ConnectDB connectDB = new ConnectDB();

            string sql = "";

            int ma_phong_ban = comboBoxTenPhongBan.SelectedIndex + 1;
            int ma_chuc_vu = comboBoxTenChucVu.SelectedIndex + 1;
            
            if (ma_phong_ban == 0 && ma_chuc_vu != 0)
            {
                sql = "procGetChiTietNhanVien_CV";
            }

            if (ma_phong_ban != 0 && ma_chuc_vu == 0)
            {
                sql = "procGetChiTietNhanVien_PB";
            }

            if(ma_phong_ban != 0 && ma_chuc_vu != 0)
            {
                sql = "procGetChiTietNhanVien_PB_CV";
            }

            dataGridViewDSNhanVien.DataSource = connectDB.getFilterDanhSachNhanVien(sql, ma_phong_ban, ma_chuc_vu);
        }
    }
}