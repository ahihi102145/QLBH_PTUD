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
    public partial class frmNhaCungCap : Form
    {
        public frmNhaCungCap()
        {
            InitializeComponent();
        }
        private void taiDataNCC()
        {
            string sql = "SELECT * FROM NHACUNGCAP";
            clsNhaCungCap kh = new clsNhaCungCap();
           
            dgvNCC.DataSource = kh.laydulieuNCC(sql);

        }
        private void frmNhaCungCap_Load(object sender, EventArgs e)
        {
            taiDataNCC();
        }

        private void dgvNCC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtmacongty.Text = dgvNCC.CurrentRow.Cells[0].Value.ToString();
                txtTenct.Text = dgvNCC.CurrentRow.Cells[1].Value.ToString();
                txttengiaodich.Text = dgvNCC.CurrentRow.Cells[2].Value.ToString();
                txtDiaChi.Text = dgvNCC.CurrentRow.Cells[3].Value.ToString();
                txtemail.Text = dgvNCC.CurrentRow.Cells[4].Value.ToString();
                txtsdt.Text = dgvNCC.CurrentRow.Cells[5].Value.ToString();
                txtFax.Text = dgvNCC.CurrentRow.Cells[6].Value.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng chọn KH cần sửa!");
            }
        }

        private void btnTHEMNCC_Click(object sender, EventArgs e)
        {
            clsNhaCungCap kh = new clsNhaCungCap();
            kh.MaCongTy = txtmacongty.Text.Trim();
            kh.Tencongty = txtTenct.Text.Trim();
            kh.Tengiaodich = txttengiaodich.Text.Trim();
            kh.Diachi = txtDiaChi.Text.Trim();
            kh.Email = txtemail.Text.Trim();
            kh.DienThoai = int.Parse(txtsdt.Text.Trim());
            kh.Fax = int.Parse(txtFax.Text.Trim());
            kh.themNCC();
            MessageBox.Show("Thêm NCC thành công!");

            taiDataNCC();
        }

        private void btnSUANCC_Click(object sender, EventArgs e)
        {
            clsNhaCungCap kh = new clsNhaCungCap();
            kh.MaCongTy = txtmacongty.Text.Trim();
            kh.Tencongty = txtTenct.Text.Trim();
            kh.Tengiaodich = txttengiaodich.Text.Trim();
            kh.Diachi = txtDiaChi.Text.Trim();
            kh.Email = txtemail.Text.Trim();
            kh.DienThoai = int.Parse(txtsdt.Text.Trim());
            kh.Fax = int.Parse(txtFax.Text.Trim());
            kh.suaNCC();
            MessageBox.Show("Thêm NCC thành công!");

            taiDataNCC();
        }

        private void btnXoaNCC_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtmacongty.Text))
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
                    clsNhaCungCap kh = new clsNhaCungCap();
                    kh.MaCongTy = txtmacongty.Text.Trim();
                    kh.xoaNCC();
                    MessageBox.Show("Xóa NCC thành công!");
                    taiDataNCC();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa NCC: " + ex.Message);
                }
            }
        }
    }
}
