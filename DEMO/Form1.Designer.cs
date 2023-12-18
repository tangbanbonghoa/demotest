namespace DEMO
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dgvNoiDung = new DataGridView();
            STT = new DataGridViewTextBoxColumn();
            maNhanVienDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tenNhanVienDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            diaChiDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            soDienThoaiDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            gioiTinhDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            namSinhDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tenChucVuDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            trangThaiDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ngayVaoLamDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tenDangNhapDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            matKhauDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nhanvienBindingSource = new BindingSource(components);
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            txtMaNV = new TextBox();
            txtDiaChi = new TextBox();
            txtTenNV = new TextBox();
            txtGioiTinh = new TextBox();
            txtSDT = new TextBox();
            txtMatKhau = new TextBox();
            txtTenDangNhap = new TextBox();
            txtTrangThai = new TextBox();
            txtChucVu = new TextBox();
            dtpNamSinh = new DateTimePicker();
            dtpNgayVaoLam = new DateTimePicker();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnTimKiem = new Button();
            txtTimKiem = new TextBox();
            CbCV = new ComboBox();
            groupBox1 = new GroupBox();
            btnHienThi = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvNoiDung).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nhanvienBindingSource).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvNoiDung
            // 
            dgvNoiDung.AllowUserToAddRows = false;
            dgvNoiDung.AllowUserToDeleteRows = false;
            dgvNoiDung.AutoGenerateColumns = false;
            dgvNoiDung.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNoiDung.Columns.AddRange(new DataGridViewColumn[] { STT, maNhanVienDataGridViewTextBoxColumn, tenNhanVienDataGridViewTextBoxColumn, diaChiDataGridViewTextBoxColumn, soDienThoaiDataGridViewTextBoxColumn, gioiTinhDataGridViewTextBoxColumn, namSinhDataGridViewTextBoxColumn, tenChucVuDataGridViewTextBoxColumn, trangThaiDataGridViewTextBoxColumn, ngayVaoLamDataGridViewTextBoxColumn, tenDangNhapDataGridViewTextBoxColumn, matKhauDataGridViewTextBoxColumn });
            dgvNoiDung.DataSource = nhanvienBindingSource;
            dgvNoiDung.Location = new Point(46, 327);
            dgvNoiDung.Name = "dgvNoiDung";
            dgvNoiDung.ReadOnly = true;
            dgvNoiDung.RowHeadersWidth = 51;
            dgvNoiDung.RowTemplate.Height = 29;
            dgvNoiDung.Size = new Size(1430, 375);
            dgvNoiDung.TabIndex = 0;
            dgvNoiDung.CellClick += dgvNoiDung_CellClick;
            dgvNoiDung.CellContentClick += dataGridView1_CellContentClick;
            dgvNoiDung.Click += dgvNoiDung_Click;
            // 
            // STT
            // 
            STT.DataPropertyName = "MaNhanVien";
            STT.HeaderText = "STT";
            STT.MinimumWidth = 6;
            STT.Name = "STT";
            STT.ReadOnly = true;
            STT.Width = 50;
            // 
            // maNhanVienDataGridViewTextBoxColumn
            // 
            maNhanVienDataGridViewTextBoxColumn.DataPropertyName = "MaNhanVien";
            maNhanVienDataGridViewTextBoxColumn.HeaderText = "MaNhanVien";
            maNhanVienDataGridViewTextBoxColumn.MinimumWidth = 6;
            maNhanVienDataGridViewTextBoxColumn.Name = "maNhanVienDataGridViewTextBoxColumn";
            maNhanVienDataGridViewTextBoxColumn.ReadOnly = true;
            maNhanVienDataGridViewTextBoxColumn.Width = 125;
            // 
            // tenNhanVienDataGridViewTextBoxColumn
            // 
            tenNhanVienDataGridViewTextBoxColumn.DataPropertyName = "TenNhanVien";
            tenNhanVienDataGridViewTextBoxColumn.HeaderText = "TenNhanVien";
            tenNhanVienDataGridViewTextBoxColumn.MinimumWidth = 6;
            tenNhanVienDataGridViewTextBoxColumn.Name = "tenNhanVienDataGridViewTextBoxColumn";
            tenNhanVienDataGridViewTextBoxColumn.ReadOnly = true;
            tenNhanVienDataGridViewTextBoxColumn.Width = 125;
            // 
            // diaChiDataGridViewTextBoxColumn
            // 
            diaChiDataGridViewTextBoxColumn.DataPropertyName = "DiaChi";
            diaChiDataGridViewTextBoxColumn.HeaderText = "DiaChi";
            diaChiDataGridViewTextBoxColumn.MinimumWidth = 6;
            diaChiDataGridViewTextBoxColumn.Name = "diaChiDataGridViewTextBoxColumn";
            diaChiDataGridViewTextBoxColumn.ReadOnly = true;
            diaChiDataGridViewTextBoxColumn.Width = 125;
            // 
            // soDienThoaiDataGridViewTextBoxColumn
            // 
            soDienThoaiDataGridViewTextBoxColumn.DataPropertyName = "SoDienThoai";
            soDienThoaiDataGridViewTextBoxColumn.HeaderText = "SoDienThoai";
            soDienThoaiDataGridViewTextBoxColumn.MinimumWidth = 6;
            soDienThoaiDataGridViewTextBoxColumn.Name = "soDienThoaiDataGridViewTextBoxColumn";
            soDienThoaiDataGridViewTextBoxColumn.ReadOnly = true;
            soDienThoaiDataGridViewTextBoxColumn.Width = 125;
            // 
            // gioiTinhDataGridViewTextBoxColumn
            // 
            gioiTinhDataGridViewTextBoxColumn.DataPropertyName = "GioiTinh";
            gioiTinhDataGridViewTextBoxColumn.HeaderText = "GioiTinh";
            gioiTinhDataGridViewTextBoxColumn.MinimumWidth = 6;
            gioiTinhDataGridViewTextBoxColumn.Name = "gioiTinhDataGridViewTextBoxColumn";
            gioiTinhDataGridViewTextBoxColumn.ReadOnly = true;
            gioiTinhDataGridViewTextBoxColumn.Width = 80;
            // 
            // namSinhDataGridViewTextBoxColumn
            // 
            namSinhDataGridViewTextBoxColumn.DataPropertyName = "NamSinh";
            namSinhDataGridViewTextBoxColumn.HeaderText = "NamSinh";
            namSinhDataGridViewTextBoxColumn.MinimumWidth = 6;
            namSinhDataGridViewTextBoxColumn.Name = "namSinhDataGridViewTextBoxColumn";
            namSinhDataGridViewTextBoxColumn.ReadOnly = true;
            namSinhDataGridViewTextBoxColumn.Width = 125;
            // 
            // tenChucVuDataGridViewTextBoxColumn
            // 
            tenChucVuDataGridViewTextBoxColumn.DataPropertyName = "TenChucVu";
            tenChucVuDataGridViewTextBoxColumn.HeaderText = "TenChucVu";
            tenChucVuDataGridViewTextBoxColumn.MinimumWidth = 6;
            tenChucVuDataGridViewTextBoxColumn.Name = "tenChucVuDataGridViewTextBoxColumn";
            tenChucVuDataGridViewTextBoxColumn.ReadOnly = true;
            tenChucVuDataGridViewTextBoxColumn.Width = 125;
            // 
            // trangThaiDataGridViewTextBoxColumn
            // 
            trangThaiDataGridViewTextBoxColumn.DataPropertyName = "TrangThai";
            trangThaiDataGridViewTextBoxColumn.HeaderText = "TrangThai";
            trangThaiDataGridViewTextBoxColumn.MinimumWidth = 6;
            trangThaiDataGridViewTextBoxColumn.Name = "trangThaiDataGridViewTextBoxColumn";
            trangThaiDataGridViewTextBoxColumn.ReadOnly = true;
            trangThaiDataGridViewTextBoxColumn.Width = 125;
            // 
            // ngayVaoLamDataGridViewTextBoxColumn
            // 
            ngayVaoLamDataGridViewTextBoxColumn.DataPropertyName = "NgayVaoLam";
            ngayVaoLamDataGridViewTextBoxColumn.HeaderText = "NgayVaoLam";
            ngayVaoLamDataGridViewTextBoxColumn.MinimumWidth = 6;
            ngayVaoLamDataGridViewTextBoxColumn.Name = "ngayVaoLamDataGridViewTextBoxColumn";
            ngayVaoLamDataGridViewTextBoxColumn.ReadOnly = true;
            ngayVaoLamDataGridViewTextBoxColumn.Width = 125;
            // 
            // tenDangNhapDataGridViewTextBoxColumn
            // 
            tenDangNhapDataGridViewTextBoxColumn.DataPropertyName = "TenDangNhap";
            tenDangNhapDataGridViewTextBoxColumn.HeaderText = "TenDangNhap";
            tenDangNhapDataGridViewTextBoxColumn.MinimumWidth = 6;
            tenDangNhapDataGridViewTextBoxColumn.Name = "tenDangNhapDataGridViewTextBoxColumn";
            tenDangNhapDataGridViewTextBoxColumn.ReadOnly = true;
            tenDangNhapDataGridViewTextBoxColumn.Width = 125;
            // 
            // matKhauDataGridViewTextBoxColumn
            // 
            matKhauDataGridViewTextBoxColumn.DataPropertyName = "MatKhau";
            matKhauDataGridViewTextBoxColumn.HeaderText = "MatKhau";
            matKhauDataGridViewTextBoxColumn.MinimumWidth = 6;
            matKhauDataGridViewTextBoxColumn.Name = "matKhauDataGridViewTextBoxColumn";
            matKhauDataGridViewTextBoxColumn.ReadOnly = true;
            matKhauDataGridViewTextBoxColumn.Width = 125;
            // 
            // nhanvienBindingSource
            // 
            nhanvienBindingSource.DataSource = typeof(A_DAL.Models.Nhanvien);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 46);
            label1.Name = "label1";
            label1.Size = new Size(102, 20);
            label1.TabIndex = 1;
            label1.Text = "Mã Nhân Viên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 102);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 2;
            label2.Text = "Tên Nhân Viên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 154);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 3;
            label3.Text = "Địa Chỉ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(44, 214);
            label4.Name = "label4";
            label4.Size = new Size(102, 20);
            label4.TabIndex = 4;
            label4.Text = "Số Điện Thoại";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(728, 46);
            label5.Name = "label5";
            label5.Size = new Size(68, 20);
            label5.TabIndex = 5;
            label5.Text = "Giới Tính";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(728, 102);
            label6.Name = "label6";
            label6.Size = new Size(73, 20);
            label6.TabIndex = 6;
            label6.Text = "Năm Sinh";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(728, 154);
            label7.Name = "label7";
            label7.Size = new Size(90, 20);
            label7.TabIndex = 7;
            label7.Text = "Tên Chức Vụ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(728, 214);
            label8.Name = "label8";
            label8.Size = new Size(78, 20);
            label8.TabIndex = 8;
            label8.Text = "Trạng Thái";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(1082, 159);
            label9.Name = "label9";
            label9.Size = new Size(105, 20);
            label9.TabIndex = 9;
            label9.Text = "Ngày Vào Làm";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(1082, 46);
            label10.Name = "label10";
            label10.Size = new Size(112, 20);
            label10.TabIndex = 10;
            label10.Text = "Tên Đăng Nhập";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(1089, 105);
            label11.Name = "label11";
            label11.Size = new Size(72, 20);
            label11.TabIndex = 11;
            label11.Text = "Mật Khẩu";
            // 
            // txtMaNV
            // 
            txtMaNV.Location = new Point(178, 43);
            txtMaNV.Name = "txtMaNV";
            txtMaNV.Size = new Size(407, 27);
            txtMaNV.TabIndex = 13;
            txtMaNV.TabStop = false;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(178, 151);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(407, 27);
            txtDiaChi.TabIndex = 14;
            txtDiaChi.TabStop = false;
            // 
            // txtTenNV
            // 
            txtTenNV.Location = new Point(178, 99);
            txtTenNV.Name = "txtTenNV";
            txtTenNV.Size = new Size(407, 27);
            txtTenNV.TabIndex = 15;
            txtTenNV.TabStop = false;
            // 
            // txtGioiTinh
            // 
            txtGioiTinh.Location = new Point(839, 43);
            txtGioiTinh.Name = "txtGioiTinh";
            txtGioiTinh.Size = new Size(202, 27);
            txtGioiTinh.TabIndex = 16;
            txtGioiTinh.TabStop = false;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(178, 207);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(407, 27);
            txtSDT.TabIndex = 17;
            txtSDT.TabStop = false;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(1218, 98);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(213, 27);
            txtMatKhau.TabIndex = 18;
            txtMatKhau.TabStop = false;
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Location = new Point(1218, 43);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(213, 27);
            txtTenDangNhap.TabIndex = 19;
            txtTenDangNhap.TabStop = false;
            // 
            // txtTrangThai
            // 
            txtTrangThai.Location = new Point(839, 211);
            txtTrangThai.Name = "txtTrangThai";
            txtTrangThai.Size = new Size(202, 27);
            txtTrangThai.TabIndex = 20;
            txtTrangThai.TabStop = false;
            // 
            // txtChucVu
            // 
            txtChucVu.Location = new Point(839, 151);
            txtChucVu.Name = "txtChucVu";
            txtChucVu.Size = new Size(202, 27);
            txtChucVu.TabIndex = 21;
            txtChucVu.TabStop = false;
            // 
            // dtpNamSinh
            // 
            dtpNamSinh.Format = DateTimePickerFormat.Short;
            dtpNamSinh.Location = new Point(839, 97);
            dtpNamSinh.Name = "dtpNamSinh";
            dtpNamSinh.Size = new Size(202, 27);
            dtpNamSinh.TabIndex = 22;
            dtpNamSinh.TabStop = false;
            // 
            // dtpNgayVaoLam
            // 
            dtpNgayVaoLam.Format = DateTimePickerFormat.Short;
            dtpNgayVaoLam.Location = new Point(1218, 154);
            dtpNgayVaoLam.Name = "dtpNgayVaoLam";
            dtpNgayVaoLam.Size = new Size(213, 27);
            dtpNgayVaoLam.TabIndex = 23;
            dtpNgayVaoLam.TabStop = false;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(151, 261);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(121, 60);
            btnThem.TabIndex = 24;
            btnThem.Text = "Thêm Nhân Viên";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(383, 261);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(122, 60);
            btnSua.TabIndex = 25;
            btnSua.Text = "Cập Nhật Thông Tin";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(598, 261);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(125, 60);
            btnXoa.TabIndex = 26;
            btnXoa.Text = "Xóa Nhân Viên";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(7, 48);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(105, 71);
            btnTimKiem.TabIndex = 27;
            btnTimKiem.Text = "Tìm Kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(124, 82);
            txtTimKiem.Multiline = true;
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(264, 34);
            txtTimKiem.TabIndex = 29;
            // 
            // CbCV
            // 
            CbCV.FormattingEnabled = true;
            CbCV.Location = new Point(124, 48);
            CbCV.Name = "CbCV";
            CbCV.Size = new Size(264, 28);
            CbCV.TabIndex = 30;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(CbCV);
            groupBox1.Controls.Add(txtTimKiem);
            groupBox1.Controls.Add(btnTimKiem);
            groupBox1.Location = new Point(1082, 196);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(394, 125);
            groupBox1.TabIndex = 31;
            groupBox1.TabStop = false;
            groupBox1.Text = "Lọc";
            // 
            // btnHienThi
            // 
            btnHienThi.Location = new Point(791, 261);
            btnHienThi.Name = "btnHienThi";
            btnHienThi.Size = new Size(115, 60);
            btnHienThi.TabIndex = 32;
            btnHienThi.Text = "Hiển Thị";
            btnHienThi.UseVisualStyleBackColor = true;
            btnHienThi.Click += btnHienThi_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1504, 726);
            Controls.Add(btnHienThi);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvNoiDung);
            Controls.Add(txtMaNV);
            Controls.Add(txtTenNV);
            Controls.Add(txtDiaChi);
            Controls.Add(txtSDT);
            Controls.Add(txtGioiTinh);
            Controls.Add(dtpNamSinh);
            Controls.Add(txtChucVu);
            Controls.Add(txtTrangThai);
            Controls.Add(txtTenDangNhap);
            Controls.Add(txtMatKhau);
            Controls.Add(dtpNgayVaoLam);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Quản Lý Nhân Viên";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvNoiDung).EndInit();
            ((System.ComponentModel.ISupportInitialize)nhanvienBindingSource).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvNoiDung;
        private BindingSource nhanvienBindingSource;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox txtMaNV;
        private TextBox txtDiaChi;
        private TextBox txtTenNV;
        private TextBox txtGioiTinh;
        private TextBox txtSDT;
        private TextBox txtMatKhau;
        private TextBox txtTenDangNhap;
        private TextBox txtTrangThai;
        private TextBox txtChucVu;
        private DateTimePicker dtpNamSinh;
        private DateTimePicker dtpNgayVaoLam;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnTimKiem;
        private TextBox txtTimKiem;
        private ComboBox CbCV;
        private GroupBox groupBox1;
        private Button btnHienThi;
        private DataGridViewTextBoxColumn STT;
        private DataGridViewTextBoxColumn maNhanVienDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tenNhanVienDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn diaChiDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn soDienThoaiDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn gioiTinhDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn namSinhDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tenChucVuDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn trangThaiDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ngayVaoLamDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tenDangNhapDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn matKhauDataGridViewTextBoxColumn;
    }
}