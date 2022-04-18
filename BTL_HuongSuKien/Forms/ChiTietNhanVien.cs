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

            comboBoxTenChucVu.SelectedIndex = 1;
            comboBoxTenPhongBan.SelectedIndex = 1;

            if (dataNhanVien.Gioi_tinh.ToString() == "Nam")
            {
                radioButtonNam.Checked = true;
            }
            else
            {
                radioButtonNu.Checked = true;
            }
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

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            ConnectDB connectDB = new ConnectDB();
            SqlConnection conn = connectDB.getConnect();
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            SqlCommand cmd = new SqlCommand("procSuaChiTietNhanVien", conn);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@id", textBoxMaNhanVien.Text));
            cmd.Parameters.Add(new SqlParameter("@id_chuc_vu", comboBoxTenChucVu.SelectedIndex + 1));
            cmd.Parameters.Add(new SqlParameter("@id_phong_ban", comboBoxTenPhongBan.SelectedIndex + 1));
            cmd.Parameters.Add(new SqlParameter("@ten_nhan_vien", textBoxTenNhanVien.Text));
            cmd.Parameters.Add(new SqlParameter("@ngay_sinh", textBoxNgaySinh.Text));
            cmd.Parameters.Add(new SqlParameter("@dia_chi", textBoxDiaChi.Text));
            cmd.Parameters.Add(new SqlParameter("@sdt", textBoxSDT.Text));
            cmd.Parameters.Add(new SqlParameter("@gioi_tinh", radioButtonNam.Checked == true ? "Nam" : "Nu"));
            cmd.Parameters.Add(new SqlParameter("@trang_thai", "0"));

            if (MessageBox.Show("Bạn có muốn xóa nhân viên này không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Xóa nhân viên thành công!");
                }
                else
                {
                    MessageBox.Show("Xóa nhân viên thất bại!");
                }
            }
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            ConnectDB connectDB = new ConnectDB();
            SqlConnection conn = connectDB.getConnect();
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            SqlCommand cmd = new SqlCommand("procSuaChiTietNhanVien", conn);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@id", textBoxMaNhanVien.Text));
            cmd.Parameters.Add(new SqlParameter("@id_chuc_vu", comboBoxTenChucVu.SelectedIndex+1));
            cmd.Parameters.Add(new SqlParameter("@id_phong_ban",comboBoxTenPhongBan.SelectedIndex+1 ));
            cmd.Parameters.Add(new SqlParameter("@ten_nhan_vien", textBoxTenNhanVien.Text));
            cmd.Parameters.Add(new SqlParameter("@ngay_sinh", textBoxNgaySinh.Text));
            cmd.Parameters.Add(new SqlParameter("@dia_chi", textBoxDiaChi.Text));
            cmd.Parameters.Add(new SqlParameter("@sdt", textBoxSDT.Text));
            cmd.Parameters.Add(new SqlParameter("@gioi_tinh", radioButtonNam.Checked==true?"Nam":"Nu"));
            cmd.Parameters.Add(new SqlParameter("@trang_thai", 1));
            if (MessageBox.Show("Bạn có muốn sửa nhân viên này không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Sửa nhân viên thành công!");
                }
                else
                {
                    MessageBox.Show("Sửa nhân viên thất bại!");
                }
            }
        }
    }
}
