using System;
using System.Data;
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
            clsNhaCungCap ncc = new clsNhaCungCap();
            dgvNCC.DataSource = ncc.laydulieuNCC(sql);
        }

        private void frmNhaCungCap_Load(object sender, EventArgs e)
        {
            taiDataNCC();
        }

        private void dgvNCC_CellClick(object sender, DataGridViewCellEventArgs e)
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
            catch
            {
                MessageBox.Show("Vui lòng chọn nhà cung cấp cần sửa!");
            }
        }

        private void btnTHEMNCC_Click(object sender, EventArgs e)
        {
            clsNhaCungCap ncc = new clsNhaCungCap();
            ncc.MaCongTy = txtmacongty.Text.Trim();
            ncc.Tencongty = txtTenct.Text.Trim();
            ncc.Tengiaodich = txttengiaodich.Text.Trim();
            ncc.Diachi = txtDiaChi.Text.Trim();
            ncc.Email = txtemail.Text.Trim();
            ncc.DienThoai = txtsdt.Text.Trim();
            ncc.Fax = txtFax.Text.Trim();

            ncc.themNCC();
            MessageBox.Show("Thêm NCC thành công!");
            taiDataNCC();
        }

        private void btnSUANCC_Click(object sender, EventArgs e)
        {
            clsNhaCungCap ncc = new clsNhaCungCap();
            ncc.MaCongTy = txtmacongty.Text.Trim();
            ncc.Tencongty = txtTenct.Text.Trim();
            ncc.Tengiaodich = txttengiaodich.Text.Trim();
            ncc.Diachi = txtDiaChi.Text.Trim();
            ncc.Email = txtemail.Text.Trim();
            ncc.DienThoai = txtsdt.Text.Trim();
            ncc.Fax = txtFax.Text.Trim();

            ncc.suaNCC();
            MessageBox.Show("Sửa NCC thành công!");
            taiDataNCC();
        }

        private void btnXoaNCC_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtmacongty.Text))
            {
                MessageBox.Show("Vui lòng chọn NCC cần xóa!");
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa NCC này?",
                                                  "Xác nhận",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    clsNhaCungCap ncc = new clsNhaCungCap();
                    ncc.MaCongTy = txtmacongty.Text.Trim();
                    ncc.xoaNCC();
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
