using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using qlbh_Vector.cls;
namespace qlbh_Vector.frm
{
    public partial class frmDonDatHang : Form
    {
        public frmDonDatHang()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

       

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmDonDatHang_Load(object sender, EventArgs e)
        {
           
           

            taiDataDDH();
        }
        private void taiDataDDH()
        {
            string sql = "SELECT SOHOADON, TENCONGTY, TENNHANVIEN, NGAYDATHANG, NGAYGIAOHANG, NOIGIAOHANG " +
                         "FROM DONDATHANG DDH " +
                         "JOIN NHACUNGCAP NCC ON DDH.MACONGTY = NCC.MACONGTY " +
                         "JOIN NHANVIEN NV ON DDH.MANHANVIEN = NV.MANHANVIEN";

            clsDonDatHang ddh = new clsDonDatHang();
            dataGridView1.DataSource = ddh.laydulieuDDH(sql);
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            
        }
        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
