using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace qlbh_Vector.cls
{
    class clsNhaCungCap
    {
        public string MaCongTy = "";
        public string Tencongty = "";
        public string Tengiaodich = "";
        public string Diachi = "";
        public string Email = "";
        public string DienThoai = "";   
        public string Fax = "";         

        public void themNCC()
        {
            clsKetNoi cn = new clsKetNoi();
            string sql = "INSERT INTO NHACUNGCAP (MACONGTY, TENCONGTY, TENGIAODICH, DIACHI, EMAIL, DIENTHOAI, FAX) " +
                         "VALUES (@MaCongTy, @Tencongty, @Tengiaodich, @Diachi, @Email, @DienThoai, @Fax)";
            try
            {
                cn.ketNoi();
                SqlCommand cmd = new SqlCommand(sql, cn.con);
                cmd.Parameters.AddWithValue("@MaCongTy", MaCongTy);
                cmd.Parameters.AddWithValue("@Tencongty", Tencongty);
                cmd.Parameters.AddWithValue("@Tengiaodich", Tengiaodich);
                cmd.Parameters.AddWithValue("@Diachi", Diachi);
                cmd.Parameters.AddWithValue("@Email", Email);
                cmd.Parameters.AddWithValue("@DienThoai", DienThoai);
                cmd.Parameters.AddWithValue("@Fax", Fax);
                cmd.ExecuteNonQuery();
                cn.closeConnect();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm NCC: " + ex.Message);
            }
        }

        public void suaNCC()
        {
            clsKetNoi cn = new clsKetNoi();
            string sql = "UPDATE NHACUNGCAP SET TENCONGTY=@Tencongty, TENGIAODICH=@Tengiaodich, DIACHI=@Diachi, " +
                         "EMAIL=@Email, DIENTHOAI=@DienThoai, FAX=@Fax WHERE MACONGTY=@MaCongTy";
            try
            {
                cn.ketNoi();
                SqlCommand cmd = new SqlCommand(sql, cn.con);
                cmd.Parameters.AddWithValue("@MaCongTy", MaCongTy);
                cmd.Parameters.AddWithValue("@Tencongty", Tencongty);
                cmd.Parameters.AddWithValue("@Tengiaodich", Tengiaodich);
                cmd.Parameters.AddWithValue("@Diachi", Diachi);
                cmd.Parameters.AddWithValue("@Email", Email);
                cmd.Parameters.AddWithValue("@DienThoai", DienThoai);
                cmd.Parameters.AddWithValue("@Fax", Fax);
                cmd.ExecuteNonQuery();
                cn.closeConnect();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa NCC: " + ex.Message);
            }
        }

        public void xoaNCC()
        {
            clsKetNoi cn = new clsKetNoi();
            string sql = "DELETE FROM NHACUNGCAP WHERE MACONGTY = @MaCongTy";
            try
            {
                cn.ketNoi();
                SqlCommand cmd = new SqlCommand(sql, cn.con);
                cmd.Parameters.AddWithValue("@MaCongTy", MaCongTy);
                cmd.ExecuteNonQuery();
                cn.closeConnect();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa NCC: " + ex.Message);
            }
        }

        public DataTable laydulieuNCC(string sql)
        {
            clsKetNoi cn = new clsKetNoi();
            DataSet dataSet = new DataSet();
            try
            {
                cn.ketNoi();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, cn.con);
                adapter.Fill(dataSet);
                return dataSet.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy dữ liệu: " + ex.Message);
                return null;
            }
        }
    }
}
