using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using qlbh_Vector.cls;

namespace qlbh_Vector.frm
{
    public partial class frmDonDatHang : Form
    {
        private int? _selectedSoHoaDon = null;

        public frmDonDatHang()
        {
            InitializeComponent();
        }

        private void frmDonDatHang_Load(object sender, EventArgs e)
        {
            TaiDataDDH();
            NapComboBox();
            LamMoiForm();
        }

        private void NapComboBox()
        {
            clsKetNoi cn = new clsKetNoi();
            cn.ketNoi();

          
            using (SqlDataAdapter da1 = new SqlDataAdapter(
                "SELECT MAKHACHHANG, TENCONGTY FROM KHACHHANG ", cn.con))
            {
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                cbbTenKH.DataSource = dt1;
                cbbTenKH.DisplayMember = "TENCONGTY";
                cbbTenKH.ValueMember = "MAKHACHHANG";
            }

      
            using (SqlDataAdapter da2 = new SqlDataAdapter(
                "SELECT MANHANVIEN, (ISNULL(HO,'') + CASE WHEN HO IS NULL OR HO='' THEN '' ELSE ' ' END + ISNULL(TEN,'')) AS HOTEN FROM NHANVIEN ", cn.con))
            {
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);
                cbbTenNV.DataSource = dt2;
                cbbTenNV.DisplayMember = "HOTEN";
                cbbTenNV.ValueMember = "MANHANVIEN";
            }

            cn.closeConnect();
        }

       private void TaiDataDDH()
{
    string sql = @"SELECT 
                    DDH.SOHOADON,
                    KH.TENCONGTY AS TENKHACHHANG,
                    (ISNULL(NV.HO,'') + CASE WHEN NV.HO IS NULL OR NV.HO='' THEN '' ELSE ' ' END + ISNULL(NV.TEN,'')) AS TENNHANVIEN,
                    DDH.NGAYDATHANG,
                    DDH.NGAYGIAOHANG,
                    DDH.NGAYCHUYENHANG,
                    DDH.NOIGIAOHANG
                FROM DONDATHANG AS DDH
                JOIN KHACHHANG AS KH ON DDH.MAKHACHHANG = KH.MAKHACHHANG
                JOIN NHANVIEN  AS NV ON DDH.MANHANVIEN   = NV.MANHANVIEN;";

    clsDonDatHang ddh = new clsDonDatHang();
  
    dataGridView1.DataSource = ddh.laydulieuDDH(sql);
}


        private void LamMoiForm()
        {
            _selectedSoHoaDon = null;
            txtNoiGH.Clear();
            if (cbbTenKH.Items.Count > 0) cbbTenKH.SelectedIndex = 0;
            if (cbbTenNV.Items.Count > 0) cbbTenNV.SelectedIndex = 0;

            dtbNDH.Value = DateTime.Now;
            dtbNGH.Value = DateTime.Now;
            dtbNCH.Value = DateTime.Now;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    _selectedSoHoaDon = Convert.ToInt32(row.Cells["SOHOADON"].Value);
                    cbbTenKH.Text = row.Cells["TENKHACHHANG"].Value?.ToString();
                    cbbTenNV.Text = row.Cells["TENNHANVIEN"].Value?.ToString();
                    if (row.Cells["NGAYDATHANG"].Value != DBNull.Value)
                        dtbNDH.Value = Convert.ToDateTime(row.Cells["NGAYDATHANG"].Value);
                    if (row.Cells["NGAYGIAOHANG"].Value != DBNull.Value)
                        dtbNGH.Value = Convert.ToDateTime(row.Cells["NGAYGIAOHANG"].Value);
                    if (row.Cells["NGAYCHUYENHANG"].Value != DBNull.Value)
                        dtbNCH.Value = Convert.ToDateTime(row.Cells["NGAYCHUYENHANG"].Value);
                    txtNoiGH.Text = row.Cells["NOIGIAOHANG"].Value?.ToString() ?? "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng chọn dòng hợp lệ " + ex.Message);
            }
        }



        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                clsDonDatHang ddh = new clsDonDatHang
                {
                    MaKhachHang = cbbTenKH.SelectedValue?.ToString(),
                    MaNhanVien = cbbTenNV.SelectedValue?.ToString(),
                    NgayDatHang = dtbNDH.Value,
                    NgayGiaoHang = dtbNGH.Value,
                    NgayChuyenHang = dtbNCH.Value,
                    NoiGiaoHang = txtNoiGH.Text.Trim()
                };

                int newId = ddh.themDDH();
                MessageBox.Show($"Thêm đơn đặt hàng thành công! Số hoá đơn: {newId}");
                TaiDataDDH();
                LamMoiForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm đơn đặt hàng: " + ex.Message);
            }
        }


        private void btnSua_Click(object sender, EventArgs e)
        {
            if (_selectedSoHoaDon == null)
            {
                MessageBox.Show("Vui lòng chọn đơn đặt hàng để sửa!");
                return;
            }

            try
            {
                clsDonDatHang ddh = new clsDonDatHang
                {
                    SoHoaDon = _selectedSoHoaDon,
                    MaKhachHang = cbbTenKH.SelectedValue?.ToString(),
                    MaNhanVien = cbbTenNV.SelectedValue?.ToString(),
                    NgayDatHang = dtbNDH.Value,
                    NgayGiaoHang = dtbNGH.Value,
                    NgayChuyenHang = dtbNCH.Value,
                    NoiGiaoHang = txtNoiGH.Text.Trim()
                };

                ddh.suaDDH();
                MessageBox.Show("Sửa đơn đặt hàng thành công!");
                TaiDataDDH();
                LamMoiForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa đơn đặt hàng: " + ex.Message);
            }
        }
        
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (_selectedSoHoaDon == null)
            {
                MessageBox.Show("Vui lòng chọn đơn đặt hàng cần xoá!");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn xoá đơn đặt hàng này?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                    clsDonDatHang ddh = new clsDonDatHang { SoHoaDon = _selectedSoHoaDon };
                    ddh.xoaDDH();
                    TaiDataDDH();
                    LamMoiForm();
            }
        }
        
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoiForm();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
    }
}
