using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace qlbh_Vector.cls
{
    class clsKetNoi
    {
        public String ChuoiKetNoi = "Data Source= ADMIN-PC" +
                                    ";database= QLBH"+
                                    ";Integrated Security = True"+
                                    ";User Instance = False";
        public SqlConnection con = new SqlConnection();
        public bool ketNoi()
        {
            try
            {
                con =  new SqlConnection(ChuoiKetNoi);
                con.Open();
                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error Connect in class KetNoi" + ex.ToString());
            }
            return false;
        }

        public void closeConnect()
        {
            con.Close();
        }
    }
}
