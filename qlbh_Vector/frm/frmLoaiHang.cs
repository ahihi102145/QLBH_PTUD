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
    public partial class frmLoaiHang : Form
    {
        public String trangthai = "";
        public frmLoaiHang()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmLoaiHang_Load(object sender, EventArgs e)
        {
            taiDataLH();
            
            /*
            clsKetNoi cn = new clsKetNoi();
            if (cn.ketNoi()) {
                MessageBox.Show("Connect is success");
            }
            */
        }
        private void taiDataLH()
        {
            string sql = "SELECT * FROM LOAIHANG";
            clsLoaiHang lh = new clsLoaiHang();
            dgvLoaiHang.DataSource = lh.laydulieuLoaiHang(sql);

        }
        private void dgvLoaiHang_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                txtMaLH.Text = dgvLoaiHang.CurrentRow.Cells[0].Value.ToString();
                txtLoaiHang.Text = dgvLoaiHang.CurrentRow.Cells[1].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng chọn loại hàng cần sửa!");
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            /*
            trangthai = "them";
            txtMaLH.Text = "";
            txtLoaiHang.Text = "";
            txtMaLH.Enabled = true;
            txtLoaiHang.Enabled = true;
            txtMaLH.Focus();
            */
            if (string.IsNullOrWhiteSpace(txtMaLH.Text) || string.IsNullOrWhiteSpace(txtLoaiHang.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }
            clsLoaiHang lh = new clsLoaiHang();
            lh.MaLoaiHang = txtMaLH.Text.Trim();
            lh.TenLoaiHang = txtLoaiHang.Text.Trim();
            lh.themLH();
            MessageBox.Show("Thêm loại hàng thành công!");
            taiDataLH();

            txtMaLH.Text = "";
            txtLoaiHang.Text = "";


        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaLH.Text) || string.IsNullOrWhiteSpace(txtLoaiHang.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            clsLoaiHang lh = new clsLoaiHang();
            lh.MaLoaiHang = txtMaLH.Text.Trim();
            lh.TenLoaiHang = txtLoaiHang.Text.Trim();

            if (trangthai == "them")
            {
                lh.themLH();
                MessageBox.Show("Thêm loại hàng thành công!");
            }
            else if (trangthai == "sua")
            {
                lh.suaLH();
                MessageBox.Show("Cập nhật loại hàng thành công!");
            }

            taiDataLH();
            trangthai = "";

        }

       

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaLH.Text))
            {
                MessageBox.Show("Vui lòng chọn loại hàng cần sửa!");
                return;
            }
            
                clsLoaiHang lhs = new clsLoaiHang();
                lhs.MaLoaiHang = txtMaLH.Text.Trim();
                lhs.TenLoaiHang = txtLoaiHang.Text.Trim();
                lhs.suaLH();
                MessageBox.Show("Cập nhật loại hàng thành công!");
                taiDataLH();
           


            /*
            trangthai = "sua";
            txtMaLH.Enabled = false; // Không cho sửa mã
            txtLoaiHang.Enabled = true;
            txtLoaiHang.Focus();
            */
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaLH.Text))
            {
                MessageBox.Show("Vui lòng chọn loại hàng cần xóa!");
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa loại hàng này?",
                                                  "Xác nhận",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    clsLoaiHang lh = new clsLoaiHang();
                    lh.MaLoaiHang = txtMaLH.Text.Trim();
                    lh.XoaLH();
                    MessageBox.Show("Xóa loại hàng thành công!");
                    taiDataLH();
                    txtMaLH.Text = "";
                    txtLoaiHang.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa loại hàng: " + ex.Message);
                }
            }
        }

        private void dgvLoaiHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
