using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace qlbh_Vector.cls
{
    class clsMatHang
    {
        public string MaMatHang = "";
        public string TenHang = "";
        public string MaCongTy = "";
        public string MaLoaiHang = "";
        public int SoLuong;
        public string DonViTinh = "";
        public float GiaHang;

        public void themMH()
        {
            clsKetNoi cn = new clsKetNoi();
            string sql = "INSERT INTO MATHANG (MAMATHANG, TENHANG, MACONGTY, MALOAIHANG, SOLUONG, DONVITINH, GIAHANG) " +
                         "VALUES (@MAMATHANG, @TENHANG, @MACONGTY, @MALOAIHANG, @SOLUONG, @DONVITINH, @GIAHANG)";
            try
            {
                cn.ketNoi();
                SqlCommand cmd = new SqlCommand(sql, cn.con);
                cmd.Parameters.AddWithValue("@MAMATHANG", MaMatHang);
                cmd.Parameters.AddWithValue("@TENHANG", TenHang);
                cmd.Parameters.AddWithValue("@MACONGTY", MaCongTy);
                cmd.Parameters.AddWithValue("@MALOAIHANG", MaLoaiHang);
                cmd.Parameters.AddWithValue("@SOLUONG", SoLuong);
                cmd.Parameters.AddWithValue("@DONVITINH", DonViTinh);
                cmd.Parameters.AddWithValue("@GIAHANG", GiaHang);
                cmd.ExecuteNonQuery();
                cn.closeConnect();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm mặt hàng: " + ex.Message);
            }
        }

        public void suaMH()
        {
            clsKetNoi cn = new clsKetNoi();
            string sql = "UPDATE MATHANG SET TENHANG=@TENHANG, MACONGTY=@MACONGTY, MALOAIHANG=@MALOAIHANG, " +
                         "SOLUONG=@SOLUONG, DONVITINH=@DONVITINH, GIAHANG=@GIAHANG WHERE MAMATHANG=@MAMATHANG";
            try
            {
                cn.ketNoi();
                SqlCommand cmd = new SqlCommand(sql, cn.con);
                cmd.Parameters.AddWithValue("@MAMATHANG", MaMatHang);
                cmd.Parameters.AddWithValue("@TENHANG", TenHang);
                cmd.Parameters.AddWithValue("@MACONGTY", MaCongTy);
                cmd.Parameters.AddWithValue("@MALOAIHANG", MaLoaiHang);
                cmd.Parameters.AddWithValue("@SOLUONG", SoLuong);
                cmd.Parameters.AddWithValue("@DONVITINH", DonViTinh);
                cmd.Parameters.AddWithValue("@GIAHANG", GiaHang);
                cmd.ExecuteNonQuery();
                cn.closeConnect();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa mặt hàng: " + ex.Message);
            }
        }

        public void xoaMH()
        {
            clsKetNoi cn = new clsKetNoi();
            string sql = "DELETE FROM MATHANG WHERE MAMATHANG=@MAMATHANG";
            try
            {
                cn.ketNoi();
                SqlCommand cmd = new SqlCommand(sql, cn.con);
                cmd.Parameters.AddWithValue("@MAMATHANG", MaMatHang);
                cmd.ExecuteNonQuery();
                cn.closeConnect();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa mặt hàng: " + ex.Message);
            }
        }

        public DataTable laydulieuMH(string sql)
        {
            clsKetNoi cn = new clsKetNoi();
            DataTable dt = new DataTable();
            try
            {
                cn.ketNoi();
                SqlDataAdapter da = new SqlDataAdapter(sql, cn.con);
                da.Fill(dt);
                cn.closeConnect();
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy dữ liệu mặt hàng: " + ex.Message);
                return null;
            }
        }

    }
}
