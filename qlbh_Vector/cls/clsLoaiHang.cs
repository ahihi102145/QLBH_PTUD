using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace qlbh_Vector.cls
{
    class clsLoaiHang
    {
        public String MaLoaiHang = "";
        public String TenLoaiHang = "";
        //func them du lieu vao bang LoaiHang
        public void themLH()
        {
            clsKetNoi cn = new clsKetNoi();
            String sql = "INSERT INTO LoaiHang(MALOAIHANG,TENLOAIHANG)"+
                "VALUES ('"+ MaLoaiHang + "',N'"+ TenLoaiHang + "')";
            try
            {
                cn.ketNoi();
                SqlCommand cmd = new SqlCommand(sql, cn.con);
                cmd.ExecuteNonQuery();
                cn.closeConnect();
            }catch(Exception ex)
            {
                MessageBox.Show("Insert error " + ex.ToString());
            }
        }
        public void suaLH()
        {
            clsKetNoi cn = new clsKetNoi();
            string sql = "UPDATE LoaiHang SET TENLOAIHANG = '"+TenLoaiHang+"' WHERE MALOAIHANG='"+MaLoaiHang+"'";
            try
            {
                cn.ketNoi();
                SqlCommand cmd = new SqlCommand(sql, cn.con);
                cmd.ExecuteNonQuery();
                cn.closeConnect();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update error " + ex.ToString());
            }
        }

        public void  XoaLH()
        {
            clsKetNoi cn = new clsKetNoi();
            string sql = "DELETE FROM LoaiHang WHERE MALOAIHANG ='"+MaLoaiHang+"'";
            try
            {
                cn.ketNoi();
                SqlCommand cmd = new SqlCommand(sql, cn.con);
                cmd.ExecuteNonQuery();
                cn.closeConnect();
            }
            catch(Exception ex)
            {
                MessageBox.Show("DELETE error " + ex.ToString());
            }
        }

        public DataTable laydulieuLoaiHang(String sql)
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
