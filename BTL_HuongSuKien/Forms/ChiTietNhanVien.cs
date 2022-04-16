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

            String dataNhanVien = connect.getChiTietNhanVien(sql, procVar, id_nhan_vien);

            MessageBox.Show(dataNhanVien);
        }
    }
}
