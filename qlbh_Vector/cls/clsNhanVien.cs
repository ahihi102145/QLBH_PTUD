using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace qlbh_Vector.cls
{
    class clsNhanVien
    {
        public string MaNhanVien = "";
        public string Ho = "";
        public string Ten = "";
        public DateTime NgaySinh;
        public DateTime NgayLamViec;
        public string DiaChi = "";
        public int DienThoai;
        public int LuongCoBan;
        public int PhuCap;

        public void themNV()
        {
            clsKetNoi cn = new clsKetNoi();
            string sql = "INSERT INTO NHANVIEN (MANHANVIEN, HO, TEN, NGAYSINH, NGAYLAMVIEC, DIACHI, DIENTHOAI, LUONGCOBAN, PHUCAP) " +
             "VALUES (@MaNV, @Ho, @Ten, @NgaySinh, @NgayLamViec, @DiaChi, @DienThoai, @LuongCoBan, @PhuCap)";

            try
            {
                cn.ketNoi();
                SqlCommand cmd = new SqlCommand(sql, cn.con);
                cmd.Parameters.AddWithValue("@MaNV", MaNhanVien);
                cmd.Parameters.AddWithValue("@Ho", Ho);
                cmd.Parameters.AddWithValue("@Ten", Ten);
                cmd.Parameters.AddWithValue("@NgaySinh", NgaySinh);
                cmd.Parameters.AddWithValue("@NgayLamViec", NgayLamViec);
                cmd.Parameters.AddWithValue("@DiaChi", DiaChi);
                cmd.Parameters.AddWithValue("@DienThoai", DienThoai);
                cmd.Parameters.AddWithValue("@LuongCoBan", LuongCoBan);
                cmd.Parameters.AddWithValue("@PhuCap", PhuCap);
                cmd.ExecuteNonQuery();
                cn.closeConnect();
            }catch  
                (Exception ex)
            {
               MessageBox.Show("Lỗi khi thêm nhân viên: " + ex.Message);
            }
        }

        public void suaNV()
        {
            clsKetNoi cn = new clsKetNoi();
            string sql = "UPDATE NHANVIEN SET HO = @Ho, TEN = @Ten, NGAYSINH = @NgaySinh, NGAYLAMVIEC = @NgayLamViec, " +
                         "DIACHI = @DiaChi, DIENTHOAI = @DienThoai, LUONGCOBAN = @LuongCoBan, PHUCAP = @PhuCap " +
                         "WHERE MANHANVIEN = @MaNV";
            try
            {
                cn.ketNoi();
                SqlCommand cmd = new SqlCommand(sql, cn.con);
                cmd.Parameters.AddWithValue("@MaNV", MaNhanVien);
                cmd.Parameters.AddWithValue("@Ho", Ho);
                cmd.Parameters.AddWithValue("@Ten", Ten);
                cmd.Parameters.AddWithValue("@NgaySinh", NgaySinh);
                cmd.Parameters.AddWithValue("@NgayLamViec", NgayLamViec);
                cmd.Parameters.AddWithValue("@DiaChi", DiaChi);
                cmd.Parameters.AddWithValue("@DienThoai", DienThoai);
                cmd.Parameters.AddWithValue("@LuongCoBan", LuongCoBan);
                cmd.Parameters.AddWithValue("@PhuCap", PhuCap);
                cmd.ExecuteNonQuery();
                cn.closeConnect();
            }
            catch
               (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa nhân viên: " + ex.Message);
            }
        }

        public void xoaNV ()
        {
            clsKetNoi cn = new clsKetNoi();
            string sql = "DELETE FROM NHANVIEN WHERE MANHANVIEN=@MaNV";
            try
            {
                cn.ketNoi();
                SqlCommand cmd = new SqlCommand(sql, cn.con);
                cmd.Parameters.AddWithValue("@MaNV", MaNhanVien);
                cmd.ExecuteNonQuery();
                cn.closeConnect();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa nhân viên: " + ex.Message);
            }

        }
        public DataTable laydulieuNhanVien(String sql)
        {
            clsKetNoi cn = new clsKetNoi();
            DataSet dataSet = new DataSet();
            try
            {
                cn.ketNoi();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql, cn.con);
                sqlDataAdapter.Fill(dataSet, sql);
                DataTable tb = dataSet.Tables[0];
                return tb;
            }
            catch (Exception ex)
            {
                return null;
                //MessageBox.Show("DELETE error " + ex.ToString());
            }
        }


    }
}
