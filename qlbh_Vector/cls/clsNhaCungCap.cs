using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using qlbh_Vector.frm;
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
        public int DienThoai;
        public int Fax;


        public void themNCC()
        {
            clsKetNoi cn = new clsKetNoi();
            string sql = "INSERT INTO NHACUNGCAP (MaCongTy , TENCONGTY, TENGIAODICH, DIACHI, EMAIL, DIENTHOAI, FAX) " +
             "VALUES (@MaCongTy , @Tencongty, @Tengiaodich, @Diachi, @Email, @DienThoai, @Fax)";


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
            catch
               (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm NCC: " + ex.Message);
            }
        }

        public void suaNCC()
        {
            clsKetNoi cn = new clsKetNoi();
            string sql = "UPDATE NHACUNGCAP SET TENCONGTY=@Tencongty,TENGIAODICH=@Tengiaodich, DIACHI=@Diachi, " +
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
            catch
               (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa NCC: " + ex.Message);
            }
        }

        public void xoaNCC()
        {
            clsKetNoi cn = new clsKetNoi();
            string sql = "DELETE FROM  NHACUNGCAP WHERE MACONGTY = @MaCongTy";
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
        public DataTable laydulieuNCC(String sql)
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
