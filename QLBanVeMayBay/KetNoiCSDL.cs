using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace QLBanVeMayBay
{
    // Lớp dùng chung để gọi stored procedure trong CSDL
    public static class KetNoiCSDL
    {
        private static readonly string chuoiKetNoi =
            ConfigurationManager.ConnectionStrings["QLBanVeMayBay"].ConnectionString;

        // Gọi proc trả về dữ liệu dạng bảng (SELECT)
        public static DataTable LayDuLieu(string tenProc, params SqlParameter[] thamSo)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(chuoiKetNoi))
            using (SqlCommand cmd = new SqlCommand(tenProc, conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddRange(thamSo);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            return dt;
        }

        // Gọi proc thêm / sửa / xóa
        public static void ThucThi(string tenProc, params SqlParameter[] thamSo)
        {
            using (SqlConnection conn = new SqlConnection(chuoiKetNoi))
            using (SqlCommand cmd = new SqlCommand(tenProc, conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddRange(thamSo);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
