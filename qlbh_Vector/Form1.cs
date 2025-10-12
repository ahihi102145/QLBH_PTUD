using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using qlbh_Vector.frm;
namespace qlbh_Vector
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void danhMụcLoạiHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLoaiHang lh = new frmLoaiHang();
            lh.Show();
           
        }

        private void danhMụcNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhanvien nv = new frmNhanvien();
            nv.Show();
        }

        private void danhMụcMặtHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMatHang mh = new frmMatHang();
            mh.Show();
        }

        private void danhMụcKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKhachHang kh = new frmKhachHang();
            kh.Show();
        }

        private void danhMụcNhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhaCungCap ncc = new frmNhaCungCap();
            ncc.Show();
        }

        private void danhMụcĐơnĐặtHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDonDatHang dh = new frmDonDatHang();
            dh.Show();
        }
    }
}
