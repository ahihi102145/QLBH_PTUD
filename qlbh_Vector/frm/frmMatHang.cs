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
    public partial class frmMatHang : Form
    {
        public frmMatHang()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LamMoiForm()
        {
            txtMaMH.Clear();
            txtTenHang.Clear();
            txtSoLuong.Clear();
            txtDonVT.Clear();
            txtGiaBan.Clear();

            if (cbbNCC.Items.Count > 0) cbbNCC.SelectedIndex = -1;
            if (cbbLoaiHang.Items.Count > 0) cbbLoaiHang.SelectedIndex = -1;

        }

        private void dgvMH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvMH.CurrentRow != null)
            {
                txtMaMH.Text = dgvMH.CurrentRow.Cells[0].Value.ToString();
                txtTenHang.Text = dgvMH.CurrentRow.Cells[1].Value.ToString();
                cbbNCC.Text = dgvMH.CurrentRow.Cells[2].Value.ToString();
                cbbLoaiHang.Text = dgvMH.CurrentRow.Cells[3].Value.ToString();
                txtSoLuong.Text = dgvMH.CurrentRow.Cells[4].Value.ToString();
                txtDonVT.Text = dgvMH.CurrentRow.Cells[5].Value.ToString();
                txtGiaBan.Text = dgvMH.CurrentRow.Cells[6].Value.ToString();
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            clsMatHang mh = new clsMatHang();
            mh.MaMatHang = txtMaMH.Text.Trim();
            mh.TenHang = txtTenHang.Text.Trim();
            mh.MaCongTy = cbbNCC.SelectedValue.ToString();
            mh.MaLoaiHang = cbbLoaiHang.SelectedValue.ToString();
            mh.SoLuong = int.Parse(txtSoLuong.Text.Trim());
            mh.DonViTinh = txtDonVT.Text.Trim();
            mh.GiaHang = float.Parse(txtGiaBan.Text.Trim());

            mh.themMH();
            MessageBox.Show("Thêm MH thành công");
            taiDataMH();
            LamMoiForm();
        }
        private void taiDataMH()
        {
            string sql = "SELECT MH.MAMATHANG, MH.TENHANG, NCC.TENCONGTY, LH.TENLOAIHANG, MH.SOLUONG, MH.DONVITINH, MH.GIAHANG " +
                           "FROM MATHANG MH " +
                           "JOIN NHACUNGCAP NCC ON MH.MACONGTY = NCC.MACONGTY " +
                           "JOIN LOAIHANG LH ON MH.MALOAIHANG = LH.MALOAIHANG";
            clsMatHang mh = new clsMatHang();
       
            dgvMH.DataSource = mh.laydulieuMH(sql);
        }
        

        private void frmMatHang_Load(object sender, EventArgs e)
        {
            clsNhaCungCap ncc = new clsNhaCungCap();
            string sqlNCC = "SELECT MACONGTY, TENCONGTY FROM NHACUNGCAP";
            cbbNCC.DataSource = ncc.laydulieuNCC(sqlNCC);
            cbbNCC.DisplayMember = "TENCONGTY";
            cbbNCC.ValueMember = "MACONGTY";
            cbbNCC.SelectedIndex = -1; 

          
            clsLoaiHang lh = new clsLoaiHang();
            string sqlLH = "SELECT MALOAIHANG, TENLOAIHANG FROM LOAIHANG";
            cbbLoaiHang.DataSource = lh.laydulieuLoaiHang(sqlLH);
            cbbLoaiHang.DisplayMember = "TENLOAIHANG";
            cbbLoaiHang.ValueMember = "MALOAIHANG";
            cbbLoaiHang.SelectedIndex = -1;
            LamMoiForm();
            taiDataMH();
           
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            clsMatHang mh = new clsMatHang();
            mh.MaMatHang = txtMaMH.Text.Trim();
            mh.TenHang = txtTenHang.Text.Trim();
            mh.MaCongTy = cbbNCC.SelectedValue.ToString();
            mh.MaLoaiHang = cbbLoaiHang.SelectedValue.ToString();
            mh.SoLuong = int.Parse(txtSoLuong.Text.Trim());
            mh.DonViTinh = txtDonVT.Text.Trim();
            mh.GiaHang = float.Parse(txtGiaBan.Text.Trim());

            mh.suaMH();
            MessageBox.Show("Sửa MH thành công");
            taiDataMH();
            LamMoiForm();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaMH.Text))
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
                    clsMatHang mh = new clsMatHang();
                    mh.MaMatHang = txtMaMH.Text.Trim();
                    mh.xoaMH();
                    MessageBox.Show("Xóa MH thành công!");

                    taiDataMH();
                    LamMoiForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa MH: " + ex.Message);
                }
            }
        }
    }
}
