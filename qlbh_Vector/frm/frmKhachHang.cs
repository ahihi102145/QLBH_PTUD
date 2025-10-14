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
    public partial class frmKhachHang : Form
    {
        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        private void LamMoiForm()
        {
            txtmkh.Clear();
            txtTenct.Clear();
            txttengiaodich.Clear();
            txtDiaChi.Clear();
            txtemail.Clear();
            txtsdt.Clear();
            txtFax.Clear();
        }

        private void taiDataKH()
        {
            string sql = "SELECT * FROM KHACHHANG";
            clsKhachHang kh = new clsKhachHang();
            dgvKh.DataSource = kh.laydulieuKH(sql);

        }
       
        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            taiDataKH();
        }

        private void btnTHEMKH_Click(object sender, EventArgs e)
        {
            clsKhachHang kh = new clsKhachHang();
            kh.MaKhachHang = txtmkh.Text.Trim();
            kh.Tencongty = txtTenct.Text.Trim();
            kh.Tengiaodich = txttengiaodich.Text.Trim();
            kh.Diachi = txtDiaChi.Text.Trim();
            kh.Email = txtemail.Text.Trim();
            kh.DienThoai = int.Parse(txtsdt.Text.Trim());
            kh.Fax = int.Parse(txtFax.Text.Trim());
            kh.themKH();
            MessageBox.Show("Thêm KH thành công!");

            taiDataKH();
            LamMoiForm();

        }

        private void btnSUAKH_Click(object sender, EventArgs e)
        {
            clsKhachHang kh = new clsKhachHang();
            kh.MaKhachHang = txtmkh.Text.Trim();
            kh.Tencongty = txtTenct.Text.Trim();
            kh.Tengiaodich = txttengiaodich.Text.Trim();
            kh.Diachi = txtDiaChi.Text.Trim();
            kh.Email = txtemail.Text.Trim();
            kh.DienThoai = int.Parse(txtsdt.Text.Trim());
            kh.Fax = int.Parse(txtFax.Text.Trim());
            kh.suaKH();
            MessageBox.Show("Sửa KH thành công!");

            taiDataKH();
            LamMoiForm();

        }

        private void btnXoaKH_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtmkh.Text))
            {
                MessageBox.Show("Vui lòng chọn KH cần xóa!");
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa KH này?",
                                                  "Xác nhận",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    clsKhachHang kh = new clsKhachHang();
                    kh.MaKhachHang = txtmkh.Text.Trim();
                    kh.xoaKH();
                    MessageBox.Show("Xóa KH thành công!");
                    taiDataKH();
                    LamMoiForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa KH: " + ex.Message);
                }
            }
        }

        private void dgvKh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvKh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtmkh.Text = dgvKh.CurrentRow.Cells[0].Value.ToString();
                txtTenct.Text = dgvKh.CurrentRow.Cells[1].Value.ToString();
                txttengiaodich.Text = dgvKh.CurrentRow.Cells[2].Value.ToString();
                txtDiaChi.Text = dgvKh.CurrentRow.Cells[3].Value.ToString();
                txtemail.Text = dgvKh.CurrentRow.Cells[4].Value.ToString();
                txtsdt.Text = dgvKh.CurrentRow.Cells[5].Value.ToString();
                txtFax.Text = dgvKh.CurrentRow.Cells[6].Value.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng chọn KH cần sửa!");
            }
        }
    }
}
