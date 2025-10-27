using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace qlbh_Vector.cls
{
    class cls ChiTietDH
    {
        public int? SoHoaDon;              
        public string MaKhachHang = "";
        public string MaNhanVien = "";
        public DateTime NgayDatHang;
        public DateTime? NgayGiaoHang;
        public DateTime? NgayChuyenHang;
        public string NoiGiaoHang = "";

        clsKetNoi cn = new clsKetNoi();

        public int themDDH()
        {

            string sql = @"INSERT INTO DONDATHANG (MAKHACHHANG, MANHANVIEN, NGAYDATHANG, NGAYGIAOHANG, NGAYCHUYENHANG, NOIGIAOHANG)
                            OUTPUT INSERTED.SOHOADON
                            VALUES (@MAKHACHHANG, @MANHANVIEN, @NGAYDATHANG, @NGAYGIAOHANG, @NGAYCHUYENHANG, @NOIGIAOHANG);
";
            cn.ketNoi();
            using (SqlCommand cmd = new SqlCommand(sql, cn.con))
            {

                cmd.Parameters.AddWithValue("@MAKHACHHANG", MaKhachHang);
                cmd.Parameters.AddWithValue("@MANHANVIEN", MaNhanVien);
                cmd.Parameters.AddWithValue("@NGAYDATHANG", NgayDatHang);
                cmd.Parameters.AddWithValue("@NGAYGIAOHANG", NgayGiaoHang);
                cmd.Parameters.AddWithValue("@NGAYCHUYENHANG", NgayChuyenHang);
                cmd.Parameters.AddWithValue("@NOIGIAOHANG", NoiGiaoHang);


                int newId = Convert.ToInt32(cmd.ExecuteScalar());
                cn.closeConnect();
                return newId;
            }
        }

        public void suaDDH()
        {
            if (SoHoaDon == null) throw new InvalidOperationException("Chưa chọn đơn đặt hàng để sửa.");
            string sql = @"UPDATE DONDATHANG
                            SET MAKHACHHANG=@MAKHACHHANG,
                                MANHANVIEN=@MANHANVIEN,
                                NGAYDATHANG=@NGAYDATHANG,
                                NGAYGIAOHANG=@NGAYGIAOHANG,
                                NGAYCHUYENHANG=@NGAYCHUYENHANG,
                                NOIGIAOHANG=@NOIGIAOHANG
                            WHERE SOHOADON=@SOHOADON;";
            cn.ketNoi();
            using (SqlCommand cmd = new SqlCommand(sql, cn.con))
            {
                cmd.Parameters.AddWithValue("@SOHOADON", SoHoaDon.Value);
                cmd.Parameters.AddWithValue("@MAKHACHHANG", MaKhachHang);
                cmd.Parameters.AddWithValue("@MANHANVIEN", MaNhanVien);
                cmd.Parameters.AddWithValue("@NGAYDATHANG", NgayDatHang);
                cmd.Parameters.AddWithValue("@NGAYGIAOHANG", NgayGiaoHang);
                cmd.Parameters.AddWithValue("@NGAYCHUYENHANG", NgayChuyenHang);
                cmd.Parameters.AddWithValue("@NOIGIAOHANG", NoiGiaoHang);


                cmd.ExecuteNonQuery();
                cn.closeConnect();
            }
        }

        public void xoaDDH()
        {
            if (SoHoaDon == null) throw new InvalidOperationException("Chưa chọn đơn đặt hàng để xoá.");

            try
            {
                cn.ketNoi();
                string sqlChiTiet = "DELETE FROM CHITIETDATHANG WHERE SOHOADON=@SOHOADON";
                using (SqlCommand cmd1 = new SqlCommand(sqlChiTiet, cn.con))
                {
                    cmd1.Parameters.AddWithValue("@SOHOADON", SoHoaDon.Value);
                    cmd1.ExecuteNonQuery();
                }

                string sqlDon = "DELETE FROM DONDATHANG WHERE SOHOADON=@SOHOADON";
                using (SqlCommand cmd2 = new SqlCommand(sqlDon, cn.con))
                {
                    cmd2.Parameters.AddWithValue("@SOHOADON", SoHoaDon.Value);
                    cmd2.ExecuteNonQuery();
                }

                cn.closeConnect();
                MessageBox.Show("Xóa đơn và chi tiết đơn hàng thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa đơn đặt hàng: " + ex.Message);
            }
        }

        public DataTable laydulieuDDH(string sql)
        {
            cn.ketNoi();
            SqlDataAdapter da = new SqlDataAdapter(sql, cn.con);
            DataTable tb = new DataTable();
            da.Fill(tb);
            cn.closeConnect();
            return tb;
        }
    }
}
