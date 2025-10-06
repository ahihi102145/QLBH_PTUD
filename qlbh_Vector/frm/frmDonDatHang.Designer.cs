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
            this.txtTenHang = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnHoan = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaCT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTenLH = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaMH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtbNDH = new System.Windows.Forms.DateTimePicker();
            this.dtbNGH = new System.Windows.Forms.DateTimePicker();
            this.dtbNCK = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Mahoadon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayĐH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayGH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayCH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoiGH = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            // txtTenHang
            // 
            this.txtTenHang.Location = new System.Drawing.Point(102, 94);
            this.txtTenHang.Name = "txtTenHang";
            this.txtTenHang.Size = new System.Drawing.Size(214, 20);
            this.txtTenHang.TabIndex = 37;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(576, 175);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 44;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnHoan
            // 
            this.btnHoan.Location = new System.Drawing.Point(469, 175);
            this.btnHoan.Name = "btnHoan";
            this.btnHoan.Size = new System.Drawing.Size(75, 23);
            this.btnHoan.TabIndex = 43;
            this.btnHoan.Text = "Hoãn";
            this.btnHoan.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(365, 175);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 42;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(266, 175);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 41;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(145, 175);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 40;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(33, 175);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 39;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
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
            // txtMaCT
            // 
            this.txtMaCT.Location = new System.Drawing.Point(106, 132);
            this.txtMaCT.Name = "txtMaCT";
            this.txtMaCT.Size = new System.Drawing.Size(210, 20);
            this.txtMaCT.TabIndex = 29;
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
            this.txtTenLH.Location = new System.Drawing.Point(4, 94);
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
            this.label3.Location = new System.Drawing.Point(12, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Nơi giao hàng";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtMaMH
            // 
            this.txtMaMH.Location = new System.Drawing.Point(106, 56);
            this.txtMaMH.Name = "txtMaMH";
            this.txtMaMH.Size = new System.Drawing.Size(210, 20);
            this.txtMaMH.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 56);
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
            this.label1.Size = new System.Drawing.Size(149, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "Quản lý mặt hàng";
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
            // dtbNCK
            // 
            this.dtbNCK.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtbNCK.Location = new System.Drawing.Point(512, 118);
            this.dtbNCK.Name = "dtbNCK";
            this.dtbNCK.Size = new System.Drawing.Size(200, 20);
            this.dtbNCK.TabIndex = 48;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Mahoadon,
            this.TenKH,
            this.TenNV,
            this.NgayĐH,
            this.NgayGH,
            this.NgayCH,
            this.NoiGH});
            this.dataGridView1.Location = new System.Drawing.Point(7, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(742, 209);
            this.dataGridView1.TabIndex = 0;
            // 
            // Mahoadon
            // 
            this.Mahoadon.HeaderText = "Mã Hoá Đơn";
            this.Mahoadon.Name = "Mahoadon";
            // 
            // TenKH
            // 
            this.TenKH.HeaderText = "Tên khách hàng";
            this.TenKH.Name = "TenKH";
            // 
            // TenNV
            // 
            this.TenNV.HeaderText = "Tên Nhân Viên";
            this.TenNV.Name = "TenNV";
            // 
            // NgayĐH
            // 
            this.NgayĐH.HeaderText = "Ngày đặt hàng";
            this.NgayĐH.Name = "NgayĐH";
            // 
            // NgayGH
            // 
            this.NgayGH.HeaderText = "Ngày giao hàng";
            this.NgayGH.Name = "NgayGH";
            // 
            // NgayCH
            // 
            this.NgayCH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NgayCH.HeaderText = "Ngày chuyển hàng";
            this.NgayCH.Name = "NgayCH";
            // 
            // NoiGH
            // 
            this.NoiGH.HeaderText = "Nơi giao hàng";
            this.NoiGH.Name = "NoiGH";
            // 
            // frmDonDatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 538);
            this.Controls.Add(this.dtbNCK);
            this.Controls.Add(this.dtbNGH);
            this.Controls.Add(this.dtbNDH);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtTenHang);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnHoan);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMaCT);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTenLH);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMaMH);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmDonDatHang";
            this.Text = "Quản lý đơn đặt hàng";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTenHang;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnHoan;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaCT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label txtTenLH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaMH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtbNDH;
        private System.Windows.Forms.DateTimePicker dtbNGH;
        private System.Windows.Forms.DateTimePicker dtbNCK;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mahoadon;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayĐH;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayGH;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayCH;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoiGH;
    }
}