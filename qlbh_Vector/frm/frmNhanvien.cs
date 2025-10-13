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
    public partial class frmNhanvien : Form
    {
        public frmNhanvien()
        {
            InitializeComponent();
        }

        private void taiDataNV()
        {
            string sql = "SELECT * FROM NHANVIEN";
            clsNhanVien nv = new clsNhanVien();
            dgvNhanVien.DataSource = nv.laydulieuNhanVien(sql);

        }
        private void frmNhanvien_Load(object sender, EventArgs e)
        {
            taiDataNV();
        }
       
        private void button2_Click(object sender, EventArgs e)
        {
            clsNhanVien nv = new clsNhanVien();
            nv.MaNhanVien = txtmnv.Text.Trim();
            nv.Ho = txtho.Text.Trim();
            nv.Ten = txtten.Text.Trim();
            nv.NgaySinh = dtpngaysinh.Value;
            nv.NgayLamViec = dtpngaylamviec.Value;
            nv.DiaChi = txtdiachi.Text.Trim();
            nv.DienThoai = int.Parse(txtSDT.Text.Trim());
            nv.LuongCoBan = int.Parse(txtLCB.Text.Trim());
            nv.PhuCap = int.Parse(txtPC.Text.Trim());

            nv.themNV();
            MessageBox.Show("Thêm nhân viên thành công!");

            taiDataNV();
        }

        private void button1_sua_Click(object sender, EventArgs e)
        {
            clsNhanVien nv = new clsNhanVien();
            nv.MaNhanVien = txtmnv.Text.Trim();
            nv.Ho = txtho.Text.Trim();
            nv.Ten = txtten.Text.Trim();
            nv.NgaySinh = dtpngaysinh.Value;
            nv.NgayLamViec = dtpngaylamviec.Value;
            nv.DiaChi = txtdiachi.Text.Trim();
            
            nv.DienThoai = int.Parse(txtSDT.Text.Trim());
            nv.LuongCoBan = int.Parse(txtLCB.Text.Trim());
            nv.PhuCap = int.Parse(txtPC.Text.Trim());

            nv.suaNV();
            MessageBox.Show("Sửa nhân viên thành công!");

            taiDataNV();
        }

        private void button4_xoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtmnv.Text))
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xóa!");
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này?",
                                                  "Xác nhận",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    clsNhanVien nv = new clsNhanVien();
                    nv.MaNhanVien = txtmnv.Text.Trim();
                    nv.xoaNV();
                    MessageBox.Show("Xóa loại hàng thành công!");
                    taiDataNV();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa nhân viên: " + ex.Message);
                }
            }
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtmnv.Text = dgvNhanVien.CurrentRow.Cells[0].Value.ToString();
                txtho.Text = dgvNhanVien.CurrentRow.Cells[1].Value.ToString();
                txtten.Text = dgvNhanVien.CurrentRow.Cells[2].Value.ToString();
                dtpngaysinh.Text = dgvNhanVien.CurrentRow.Cells[3].Value.ToString();
                dtpngaylamviec.Text = dgvNhanVien.CurrentRow.Cells[4].Value.ToString();
                txtdiachi.Text = dgvNhanVien.CurrentRow.Cells[5].Value.ToString();
                txtSDT.Text = dgvNhanVien.CurrentRow.Cells[6].Value.ToString();
                txtLCB.Text = dgvNhanVien.CurrentRow.Cells[7].Value.ToString();
                txtPC.Text = dgvNhanVien.CurrentRow.Cells[8].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần sửa!");
            }
        }
    }
}
