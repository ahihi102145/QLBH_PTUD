namespace qlbh_Vector.frm
{
    partial class frmDonDatHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnHoan = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNoiGH = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTenLH = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtbNDH = new System.Windows.Forms.DateTimePicker();
            this.dtbNGH = new System.Windows.Forms.DateTimePicker();
            this.dtbNCH = new System.Windows.Forms.DateTimePicker();
            this.cbbTenKH = new System.Windows.Forms.ComboBox();
            this.cbbTenNV = new System.Windows.Forms.ComboBox();
            this.SOHOADON = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENKHACHHANG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENNHANVIEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYDATHANG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYGIAOHANG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYCHUYENHANG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOIGIAOHANG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 262);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(760, 235);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách đơn đặt hàng";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SOHOADON,
            this.TENKHACHHANG,
            this.TENNHANVIEN,
            this.NGAYDATHANG,
            this.NGAYGIAOHANG,
            this.NGAYCHUYENHANG,
            this.NOIGIAOHANG});
            this.dataGridView1.Location = new System.Drawing.Point(7, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(742, 209);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
           // this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(581, 233);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 44;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnHoan
            // 
            this.btnHoan.Location = new System.Drawing.Point(474, 233);
            this.btnHoan.Name = "btnHoan";
            this.btnHoan.Size = new System.Drawing.Size(75, 23);
            this.btnHoan.TabIndex = 43;
            this.btnHoan.Text = "Hoãn";
            this.btnHoan.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(370, 233);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 42;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(271, 233);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 41;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(150, 233);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 40;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(38, 233);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 39;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(399, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Ngày đặt hàng";
            // 
            // txtNoiGH
            // 
            this.txtNoiGH.Location = new System.Drawing.Point(110, 176);
            this.txtNoiGH.Name = "txtNoiGH";
            this.txtNoiGH.Size = new System.Drawing.Size(210, 20);
            this.txtNoiGH.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(399, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Ngày giao hàng";
            // 
            // txtTenLH
            // 
            this.txtTenLH.AutoSize = true;
            this.txtTenLH.Location = new System.Drawing.Point(8, 138);
            this.txtTenLH.Name = "txtTenLH";
            this.txtTenLH.Size = new System.Drawing.Size(79, 13);
            this.txtTenLH.TabIndex = 31;
            this.txtTenLH.Text = "Tên nhân viên ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(399, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Ngày chuyển hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Nơi giao hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Tên khách hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(262, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "Quản lý đơn mặt hàng";
            // 
            // dtbNDH
            // 
            this.dtbNDH.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtbNDH.Location = new System.Drawing.Point(512, 56);
            this.dtbNDH.Name = "dtbNDH";
            this.dtbNDH.Size = new System.Drawing.Size(200, 20);
            this.dtbNDH.TabIndex = 46;
            // 
            // dtbNGH
            // 
            this.dtbNGH.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtbNGH.Location = new System.Drawing.Point(512, 87);
            this.dtbNGH.Name = "dtbNGH";
            this.dtbNGH.Size = new System.Drawing.Size(200, 20);
            this.dtbNGH.TabIndex = 47;
            // 
            // dtbNCH
            // 
            this.dtbNCH.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtbNCH.Location = new System.Drawing.Point(512, 118);
            this.dtbNCH.Name = "dtbNCH";
            this.dtbNCH.Size = new System.Drawing.Size(200, 20);
            this.dtbNCH.TabIndex = 48;
            // 
            // cbbTenKH
            // 
            this.cbbTenKH.FormattingEnabled = true;
            this.cbbTenKH.Location = new System.Drawing.Point(110, 91);
            this.cbbTenKH.Name = "cbbTenKH";
            this.cbbTenKH.Size = new System.Drawing.Size(210, 21);
            this.cbbTenKH.TabIndex = 49;
            // 
            // cbbTenNV
            // 
            this.cbbTenNV.FormattingEnabled = true;
            this.cbbTenNV.Location = new System.Drawing.Point(110, 134);
            this.cbbTenNV.Name = "cbbTenNV";
            this.cbbTenNV.Size = new System.Drawing.Size(210, 21);
            this.cbbTenNV.TabIndex = 50;
            // 
            // SOHOADON
            // 
            this.SOHOADON.DataPropertyName = "SOHOADON";
            this.SOHOADON.HeaderText = "Mã Hoá Đơn";
            this.SOHOADON.Name = "SOHOADON";
            // 
            // TENKHACHHANG
            // 
            this.TENKHACHHANG.DataPropertyName = "TENKHACHHANG";
            this.TENKHACHHANG.HeaderText = "Tên khách hàng";
            this.TENKHACHHANG.Name = "TENKHACHHANG";
            // 
            // TENNHANVIEN
            // 
            this.TENNHANVIEN.DataPropertyName = "TENNHANVIEN";
            this.TENNHANVIEN.HeaderText = "Tên Nhân Viên";
            this.TENNHANVIEN.Name = "TENNHANVIEN";
            // 
            // NGAYDATHANG
            // 
            this.NGAYDATHANG.DataPropertyName = "NGAYDATHANG";
            this.NGAYDATHANG.HeaderText = "Ngày đặt hàng";
            this.NGAYDATHANG.Name = "NGAYDATHANG";
            // 
            // NGAYGIAOHANG
            // 
            this.NGAYGIAOHANG.DataPropertyName = "NGAYGIAOHANG";
            this.NGAYGIAOHANG.HeaderText = "Ngày giao hàng";
            this.NGAYGIAOHANG.Name = "NGAYGIAOHANG";
            // 
            // NGAYCHUYENHANG
            // 
            this.NGAYCHUYENHANG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NGAYCHUYENHANG.DataPropertyName = "NGAYCHUYENHANG";
            this.NGAYCHUYENHANG.HeaderText = "Ngày chuyển hàng";
            this.NGAYCHUYENHANG.Name = "NGAYCHUYENHANG";
            // 
            // NOIGIAOHANG
            // 
            this.NOIGIAOHANG.DataPropertyName = "NOIGIAOHANG";
            this.NOIGIAOHANG.HeaderText = "Nơi giao hàng";
            this.NOIGIAOHANG.Name = "NOIGIAOHANG";
            // 
            // frmDonDatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 538);
            this.Controls.Add(this.cbbTenNV);
            this.Controls.Add(this.cbbTenKH);
            this.Controls.Add(this.dtbNCH);
            this.Controls.Add(this.dtbNGH);
            this.Controls.Add(this.dtbNDH);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnHoan);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNoiGH);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTenLH);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmDonDatHang";
            this.Text = "Quản lý đơn đặt hàng";
            this.Load += new System.EventHandler(this.frmDonDatHang_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnHoan;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNoiGH;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label txtTenLH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtbNDH;
        private System.Windows.Forms.DateTimePicker dtbNGH;
        private System.Windows.Forms.DateTimePicker dtbNCH;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cbbTenKH;
        private System.Windows.Forms.ComboBox cbbTenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOHOADON;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENKHACHHANG;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENNHANVIEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYDATHANG;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYGIAOHANG;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYCHUYENHANG;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOIGIAOHANG;
    }
}