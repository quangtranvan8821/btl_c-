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
    public partial class ThemNhanVien : Form
    {
        public ThemNhanVien()
        {
            InitializeComponent();
        }

        private void ThemNhanVien_Load(object sender, EventArgs e)
        {

        }


        //handle close form
        private void clickHuy(object sender, EventArgs e)
        {
            Boolean checkBlank = textBoxTenNhanVien.Text != "" ||
                                dateTimePickerNgaySinh.Text != "" ||
                                textBoxDiaChi.Text != "" ||
                                textBoxSDT.Text != "" ||
                                comboBoxTenChucVu.SelectedIndex != -1 ||
                                comboBoxTenPhongBan.SelectedIndex != -1;
            if (checkBlank)
            {
                // message confirm box
                DialogResult dialogResult = MessageBox.Show("Thoát ra sẽ mất hết thay đổi!","", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Close();
                } else
                {
                    return;
                }
            }
            Close();
        }

        //reset form value to blank
        private void clickReset(object sender, EventArgs e)
        {
            textBoxTenNhanVien.Text = "";
            dateTimePickerNgaySinh.Text = "";
            textBoxDiaChi.Text = "";
            textBoxSDT.Text = "";
            comboBoxTenChucVu.SelectedIndex = -1;
            comboBoxTenPhongBan.SelectedIndex = -1;
        }

        //add Nhan Vien to db
        private void clickThem(object sender, EventArgs e)
        {

            //date time format yyyy-MM-dd
            ConnectDB connectDB = new ConnectDB();
            SqlConnection conn = connectDB.getConnect();

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            SqlCommand cmd = new SqlCommand("procThemNhanVien", conn);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@id_chuc_vu", comboBoxTenChucVu.SelectedIndex + 1));
            cmd.Parameters.Add(new SqlParameter("@id_phong_ban", comboBoxTenPhongBan.SelectedIndex + 1));
            cmd.Parameters.Add(new SqlParameter("@ten_nhan_vien", textBoxTenNhanVien.Text));
            cmd.Parameters.Add(new SqlParameter("@ngay_sinh", dateTimePickerNgaySinh.Text));
            cmd.Parameters.Add(new SqlParameter("@dia_chi", textBoxDiaChi.Text));
            cmd.Parameters.Add(new SqlParameter("@sdt", textBoxSDT.Text));
            cmd.Parameters.Add(new SqlParameter("@gioi_tinh", radioButtonNam.Checked == true ? "Nam" : "Nu"));

            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Thêm nhân viên thành công");
            } else
            {
                return;
            }

            Close();
        }
    }
}
