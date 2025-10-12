using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using qlbh_Vector.cls;
using System.Windows.Forms;
using System.Data;
namespace qlbh_Vector.cls
{
    class clsKhachHang
    {
        public string MaKhachHang = "";
        public string Tencongty = "";
        public string Tengiaodich = "";
        public string Diachi = "";
        public string Email = "";
        public int DienThoai;
        public int Fax;
      

        public void themKH()
        {
            clsKetNoi cn = new clsKetNoi();
            string sql = "INSERT INTO KHACHHANG (MAKHACHHANG, TENCONGTY, TENGIAODICH, DIACHI, EMAIL, DIENTHOAI, FAX) " +
             "VALUES (@MaKhachHang, @Tencongty, @Tengiaodich, @Diachi, @Email, @DienThoai, @Fax)";


            try
            {
                cn.ketNoi();
                SqlCommand cmd = new SqlCommand(sql, cn.con);
                cmd.Parameters.AddWithValue("@MaKhachHang", MaKhachHang);
                cmd.Parameters.AddWithValue("@Tencongty", Tencongty);
                cmd.Parameters.AddWithValue("@Tengiaodich", Tengiaodich);
                cmd.Parameters.AddWithValue("@Diachi", Diachi);
                cmd.Parameters.AddWithValue("@Email", Email);
                cmd.Parameters.AddWithValue("@DienThoai", DienThoai);
                cmd.Parameters.AddWithValue("@Fax", Fax);
                cmd.ExecuteNonQuery();
                cn.closeConnect();
            }
            catch
               (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm khách hàng: " + ex.Message);
            }
        }

        public void suaKH()
        {
            clsKetNoi cn = new clsKetNoi();
            string sql = "UPDATE KHACHHANG SET TENCONGTY=@Tencongty,TENGIAODICH=@Tengiaodich, DIACHI=@Diachi, " +
                "EMAIL=@Email, DIENTHOAI=@DienThoai, FAX=@Fax WHERE MAKHACHHANG=@MaKhachHang";
            try
            {
                cn.ketNoi();
                SqlCommand cmd = new SqlCommand(sql, cn.con);
                cmd.Parameters.AddWithValue("@MaKhachHang", MaKhachHang);
                cmd.Parameters.AddWithValue("@HTencongty", Tencongty);
                cmd.Parameters.AddWithValue("@Tengiaodich", Tengiaodich);
                cmd.Parameters.AddWithValue("@Diachi", Diachi);
                cmd.Parameters.AddWithValue("@Email", Email);
                cmd.Parameters.AddWithValue("@DienThoai", DienThoai);
                cmd.Parameters.AddWithValue("@Fax", Fax);
                cmd.ExecuteNonQuery();
                cn.closeConnect();
            }
            catch
               (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa khách hàng: " + ex.Message);
            }
        }

        public void xoaKH()
        {
            clsKetNoi cn = new clsKetNoi();
            string sql = "DELETE FROM  WHERE MAKHACHHANG = @MaKhachHang";
            try
            {
                cn.ketNoi();
                SqlCommand cmd = new SqlCommand(sql, cn.con);
                cmd.Parameters.AddWithValue("@MaKhachHang", MaKhachHang);
                cmd.ExecuteNonQuery();
                cn.closeConnect();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa KH: " + ex.Message);
            }

        }
        public DataTable laydulieuKH(String sql)
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
                MessageBox.Show("Lỗi khi lấy dữ liệu: " + ex.Message);
                return null;
            }
        }

    }
}
