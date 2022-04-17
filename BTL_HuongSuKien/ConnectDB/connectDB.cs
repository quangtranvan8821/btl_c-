using BTL_HuongSuKien.DTO;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
namespace BTL_HuongSuKien
{
    public class ConnectDB
    {
        //connect to db
        public SqlConnection getConnect()
        {
            //connect string here
            //String strConn = @"Data Source=DESKTOP-88CSDCF\SQLEXPRESS;Initial Catalog=BTL_QLNS;Integrated Security=True";
            String strConn = ConfigurationManager.ConnectionStrings["connectQ"].ConnectionString;
            return new SqlConnection(strConn);
        }
        public DataTable getTable(String sql)
        {
            DataTable dt = new DataTable();
            SqlConnection conn = getConnect();
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);
            conn.Close();
            return dt;
        }

        public object getChiTietNhanVien(String sql, String procVar, int data)
        {
            SqlConnection conn = getConnect();
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter(procVar, data));

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                // iterate through results, printing each to console
                while(reader.Read())
                {
                    int idnhanvien = Convert.ToInt32(reader["Mã nhân viên"].ToString());
                    string tennhanvien = reader["Họ tên"].ToString();
                    string tenchucvu = reader["Tên chức vụ"].ToString();
                    string tenphongban = reader["Tên phòng ban"].ToString();
                    DateTime ngaysinh = Convert.ToDateTime(reader["Ngày sinh"].ToString());
                    string diachi = reader["Địa chỉ"].ToString();
                    string sdt = reader["Số điện thoại"].ToString();
                    string gioitinh = reader["Giới tính"].ToString();
                    int idhopdong = Convert.ToInt32(reader["Mã hợp đồng"].ToString());
                    int idluong = Convert.ToInt32(reader["Mã bảng lương"].ToString());
                    NhanVien nhanVien = new NhanVien(idnhanvien, tenphongban, tenchucvu, tennhanvien, ngaysinh, diachi, sdt, gioitinh, idhopdong, idluong);
                    return nhanVien;
                }
            }
            return null;
        }

        public void ExcuteNonQuery(String sql)
        {
            SqlConnection conn = getConnect();
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            cmd.Clone();
            conn.Close();
        }
        public String ExcuteScalar(String sql)
        {
            SqlConnection conn = getConnect();
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand cmd = new SqlCommand(sql, conn);
            String kq = cmd.ExecuteScalar().ToString();
            conn.Close();
            return kq;
        }
    }
}

