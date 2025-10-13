namespace qlbh_Vector.frm
{
    partial class frmKhachHang
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
            this.button1_luu = new System.Windows.Forms.Button();
            this.btnSUAKH = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btnXoaKH = new System.Windows.Forms.Button();
            this.btnTHEMKH = new System.Windows.Forms.Button();
            this.dgvKh = new System.Windows.Forms.DataGridView();
            this.MAKHACHHANG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENCONGTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENGIAODICH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIACHI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIENTHOAI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FAX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnHoan = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtsdt = new System.Windows.Forms.TextBox();
            this.txtFax = new System.Windows.Forms.TextBox();
            this.txttengiaodich = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtTenct = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtmkh = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKh)).BeginInit();
            this.SuspendLayout();
            // 
            // button1_luu
            // 
            this.button1_luu.Location = new System.Drawing.Point(412, 138);
            this.button1_luu.Name = "button1_luu";
            this.button1_luu.Size = new System.Drawing.Size(75, 23);
            this.button1_luu.TabIndex = 57;
            this.button1_luu.Text = "Lưu";
            this.button1_luu.UseVisualStyleBackColor = true;
            // 
            // btnSUAKH
            // 
            this.btnSUAKH.Location = new System.Drawing.Point(167, 137);
            this.btnSUAKH.Name = "btnSUAKH";
            this.btnSUAKH.Size = new System.Drawing.Size(75, 23);
            this.btnSUAKH.TabIndex = 56;
            this.btnSUAKH.Text = "Sửa";
            this.btnSUAKH.UseVisualStyleBackColor = true;
            this.btnSUAKH.Click += new System.EventHandler(this.btnSUAKH_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(665, 138);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 55;
            this.button5.Text = "Thoát";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(519, 138);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 54;
            this.button6.Text = "Hoãn";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // btnXoaKH
            // 
            this.btnXoaKH.Location = new System.Drawing.Point(296, 138);
            this.btnXoaKH.Name = "btnXoaKH";
            this.btnXoaKH.Size = new System.Drawing.Size(75, 23);
            this.btnXoaKH.TabIndex = 53;
            this.btnXoaKH.Text = "xóa";
            this.btnXoaKH.UseVisualStyleBackColor = true;
            this.btnXoaKH.Click += new System.EventHandler(this.btnXoaKH_Click);
            // 
            // btnTHEMKH
            // 
            this.btnTHEMKH.Location = new System.Drawing.Point(16, 138);
            this.btnTHEMKH.Name = "btnTHEMKH";
            this.btnTHEMKH.Size = new System.Drawing.Size(75, 23);
            this.btnTHEMKH.TabIndex = 52;
            this.btnTHEMKH.Text = "Thêm";
            this.btnTHEMKH.UseVisualStyleBackColor = true;
            this.btnTHEMKH.Click += new System.EventHandler(this.btnTHEMKH_Click);
            // 
            // dgvKh
            // 
            this.dgvKh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAKHACHHANG,
            this.TENCONGTY,
            this.TENGIAODICH,
            this.DIACHI,
            this.Email,
            this.DIENTHOAI,
            this.FAX});
            this.dgvKh.Location = new System.Drawing.Point(12, 197);
            this.dgvKh.Name = "dgvKh";
            this.dgvKh.Size = new System.Drawing.Size(776, 243);
            this.dgvKh.TabIndex = 45;
            this.dgvKh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKh_CellClick);
            this.dgvKh.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKh_CellContentClick);
            // 
            // MAKHACHHANG
            // 
            this.MAKHACHHANG.DataPropertyName = "MAKHACHHANG";
            this.MAKHACHHANG.HeaderText = "Mã khách hàng";
            this.MAKHACHHANG.Name = "MAKHACHHANG";
            // 
            // TENCONGTY
            // 
            this.TENCONGTY.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TENCONGTY.DataPropertyName = "TENCONGTY";
            this.TENCONGTY.HeaderText = "Tên công ty";
            this.TENCONGTY.MinimumWidth = 40;
            this.TENCONGTY.Name = "TENCONGTY";
            // 
            // TENGIAODICH
            // 
            this.TENGIAODICH.DataPropertyName = "TENGIAODICH";
            this.TENGIAODICH.HeaderText = "Tên giao dịch";
            this.TENGIAODICH.Name = "TENGIAODICH";
            // 
            // DIACHI
            // 
            this.DIACHI.DataPropertyName = "DIACHI";
            this.DIACHI.HeaderText = "Địa chỉ";
            this.DIACHI.Name = "DIACHI";
            // 
            // Email
            // 
            this.Email.DataPropertyName = "EMAIL";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            // 
            // DIENTHOAI
            // 
            this.DIENTHOAI.DataPropertyName = "DIENTHOAI";
            this.DIENTHOAI.HeaderText = "Điện thoại";
            this.DIENTHOAI.Name = "DIENTHOAI";
            // 
            // FAX
            // 
            this.FAX.DataPropertyName = "FAX";
            this.FAX.HeaderText = "Fax";
            this.FAX.Name = "FAX";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(651, 308);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 51;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnHoan
            // 
            this.btnHoan.Location = new System.Drawing.Point(501, 312);
            this.btnHoan.Name = "btnHoan";
            this.btnHoan.Size = new System.Drawing.Size(75, 23);
            this.btnHoan.TabIndex = 50;
            this.btnHoan.Text = "Hoãn";
            this.btnHoan.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(362, 310);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 49;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(651, 249);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 48;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(501, 250);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 47;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(362, 250);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 46;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // txtsdt
            // 
            this.txtsdt.Location = new System.Drawing.Point(360, 93);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(100, 20);
            this.txtsdt.TabIndex = 42;
            // 
            // txtFax
            // 
            this.txtFax.Location = new System.Drawing.Point(580, 38);
            this.txtFax.Name = "txtFax";
            this.txtFax.Size = new System.Drawing.Size(100, 20);
            this.txtFax.TabIndex = 41;
            // 
            // txttengiaodich
            // 
            this.txttengiaodich.Location = new System.Drawing.Point(107, 90);
            this.txttengiaodich.Name = "txttengiaodich";
            this.txttengiaodich.Size = new System.Drawing.Size(100, 20);
            this.txttengiaodich.TabIndex = 40;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(516, 41);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 13);
            this.label10.TabIndex = 34;
            this.label10.Text = "Fax";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(269, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Điện thoại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Tên giao dịch";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(360, 67);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(100, 20);
            this.txtDiaChi.TabIndex = 39;
            // 
            // txtTenct
            // 
            this.txtTenct.Location = new System.Drawing.Point(107, 64);
            this.txtTenct.Name = "txtTenct";
            this.txtTenct.Size = new System.Drawing.Size(100, 20);
            this.txtTenct.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(269, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Địa chỉ";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Tên công ty";
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(362, 38);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(100, 20);
            this.txtemail.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(269, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Email";
            // 
            // txtmkh
            // 
            this.txtmkh.Location = new System.Drawing.Point(107, 38);
            this.txtmkh.Name = "txtmkh";
            this.txtmkh.Size = new System.Drawing.Size(100, 20);
            this.txtmkh.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Mã khách hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(314, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 16);
            this.label1.TabIndex = 26;
            this.label1.Text = "Danh mục khách hàng";
            // 
            // frmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1_luu);
            this.Controls.Add(this.btnSUAKH);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.btnXoaKH);
            this.Controls.Add(this.btnTHEMKH);
            this.Controls.Add(this.dgvKh);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnHoan);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtsdt);
            this.Controls.Add(this.txtFax);
            this.Controls.Add(this.txttengiaodich);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtTenct);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtmkh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmKhachHang";
            this.Text = "frmKhachHang";
            this.Load += new System.EventHandler(this.frmKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1_luu;
        private System.Windows.Forms.Button btnSUAKH;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnXoaKH;
        private System.Windows.Forms.Button btnTHEMKH;
        private System.Windows.Forms.DataGridView dgvKh;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnHoan;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtsdt;
        private System.Windows.Forms.TextBox txtFax;
        private System.Windows.Forms.TextBox txttengiaodich;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtTenct;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtmkh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAKHACHHANG;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENCONGTY;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENGIAODICH;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIACHI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIENTHOAI;
        private System.Windows.Forms.DataGridViewTextBoxColumn FAX;
    }
}