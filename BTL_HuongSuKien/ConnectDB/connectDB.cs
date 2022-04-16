using System;
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
            String strConn = @"Data Source=DESKTOP-88CSDCF\SQLEXPRESS;Initial Catalog=BTL_QLNS;Integrated Security=True";
            //String strConn = @"Data Source=DESKTOP-Q609H2F;Initial Catalog=BTL_QLNS;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
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

        public string getChiTietNhanVien(String sql, String procVar, int data)
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
                    string hoTen = reader["Họ tên"].ToString();
                    return hoTen;
                }
            }
            return "No Data";
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

