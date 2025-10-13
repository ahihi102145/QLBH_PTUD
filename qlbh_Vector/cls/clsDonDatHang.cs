using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace qlbh_Vector.cls
{
    class clsDonDatHang
    {
        public string SoHoaDon { get; set; }
        public string MaCongTy { get; set; }
        public string MaNhanVien { get; set; }
        public DateTime NgayDatHang { get; set; }
        public DateTime NgayGiaoHang { get; set; }
        public string NoiGiaoHang { get; set; }

        clsKetNoi cn = new clsKetNoi();

        public void themDDH()
        {
            string sql = "INSERT INTO DONDATHANG VALUES(@SOHOADON,@MACONGTY,@MANHANVIEN,@NGAYDATHANG,@NGAYGIAOHANG,@NOIGIAOHANG)";
            SqlCommand cmd = new SqlCommand(sql, cn.con);
            cmd.Parameters.AddWithValue("@SOHOADON", SoHoaDon);
            cmd.Parameters.AddWithValue("@MACONGTY", MaCongTy);
            cmd.Parameters.AddWithValue("@MANHANVIEN", MaNhanVien);
            cmd.Parameters.AddWithValue("@NGAYDATHANG", NgayDatHang);
            cmd.Parameters.AddWithValue("@NGAYGIAOHANG", NgayGiaoHang);
            cmd.Parameters.AddWithValue("@NOIGIAOHANG", NoiGiaoHang);

            cn.ketNoi();
            cmd.ExecuteNonQuery();
            cn.closeConnect();
        }

        public void suaDDH()
        {
            string sql = "UPDATE DONDATHANG SET MACONGTY=@MACONGTY, MANHANVIEN=@MANHANVIEN, NGAYDATHANG=@NGAYDATHANG, NGAYGIAOHANG=@NGAYGIAOHANG, NOIGIAOHANG=@NOIGIAOHANG WHERE SOHOADON=@SOHOADON";
            SqlCommand cmd = new SqlCommand(sql, cn.con);
            cmd.Parameters.AddWithValue("@SOHOADON", SoHoaDon);
            cmd.Parameters.AddWithValue("@MACONGTY", MaCongTy);
            cmd.Parameters.AddWithValue("@MANHANVIEN", MaNhanVien);
            cmd.Parameters.AddWithValue("@NGAYDATHANG", NgayDatHang);
            cmd.Parameters.AddWithValue("@NGAYGIAOHANG", NgayGiaoHang);
            cmd.Parameters.AddWithValue("@NOIGIAOHANG", NoiGiaoHang);

            cn.ketNoi();
            cmd.ExecuteNonQuery();
            cn.closeConnect();
        }

        public void xoaDDH()
        {
            string sql = "DELETE FROM DONDATHANG WHERE SOHOADON=@SOHOADON";
            SqlCommand cmd = new SqlCommand(sql, cn.con);
            cmd.Parameters.AddWithValue("@SOHOADON", SoHoaDon);

            cn.ketNoi();
            cmd.ExecuteNonQuery();
            cn.closeConnect();
        }

        public DataTable laydulieuDDH(string sql)
        {
            cn.ketNoi();
            SqlDataAdapter da = new SqlDataAdapter(sql, cn.con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cn.closeConnect();
            return dt;
        }
    }
}
