using A_DAL.Models;
using B_BUS.Services;
using System.Text;

namespace DEMO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            List<Nhanvien> lstnhanvien = NhanVienServices.GetAll();
            dgvNoiDung.CellFormatting += GridCellFormatting;
            nhanvienBindingSource.DataSource = lstnhanvien;
            List<string> lstComboBoxLoc = new List<string>();
            for (int b = 0; b < lstnhanvien.Count; b++)
            {
                if (b == 0)
                {
                    lstComboBoxLoc.Add(lstnhanvien[0].TenChucVu);
                }
                else if (b != 0)
                {
                    bool giong = false;
                    for (int c = 0; c < lstComboBoxLoc.Count; c++)
                    {
                        if (string.Equals(lstnhanvien[b].TenChucVu, lstComboBoxLoc[c],
                            StringComparison.OrdinalIgnoreCase)) //so sánh 2 chuỗi ko phân biệt
                                                                 //chữ hoa chữ thường
                        {
                            giong = true;
                        }
                    }

                    if (giong == false)
                    {
                        lstComboBoxLoc.Add(lstnhanvien[b].TenChucVu);
                    }
                }
            }

            CbCV.Items.Clear();
            CbCV.Items.Add("");
            for (int d = 0; d < lstComboBoxLoc.Count; d++)
            {
                CbCV.Items.Add(lstComboBoxLoc[d]);
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("abcxyz");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void LoadData()
        {
            dgvNoiDung.DataSource = NhanVienServices.GetAll();
            dgvNoiDung.CellFormatting += GridCellFormatting;
            dgvNoiDung.Columns[0].Visible = true;

        }
        private void GridCellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvNoiDung.Columns[e.ColumnIndex].Name == "STT")
            {
                e.Value = (e.RowIndex + 1);
            }
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {


        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            nhanvienBindingSource.DataSource = new Nhanvien();
            Nhanvien nv = new Nhanvien();
            nv.MaNhanVien = txtMaNV.Text;
            nv.TenNhanVien = txtTenNV.Text;
            nv.DiaChi = txtDiaChi.Text;
            nv.SoDienThoai = txtSDT.Text;
            nv.GioiTinh = txtGioiTinh.Text;
            nv.NamSinh = dtpNamSinh.Value;
            nv.TenChucVu = txtChucVu.Text;
            nv.TrangThai = txtTrangThai.Text;
            nv.NgayVaoLam = dtpNgayVaoLam.Value;
            nv.TenDangNhap = txtTenDangNhap.Text;
            nv.MatKhau = txtMatKhau.Text;

            List<Nhanvien> lstCheck = NhanVienServices.GetAll();
            List<Nhanvien> lst1 = new List<Nhanvien>();
            foreach (var item in lstCheck)
            {
                if (item.TenDangNhap == txtTenDangNhap.Text)
                {
                    lst1.Add(item);
                }
            }

            if (lst1.Count != 0)
            {
                MessageBox.Show("Tên Tài Khoản bị trùng, Vui lòng nhập Tên Tài Khoản khác !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }
            else if (lst1.Count == 0)
            {
                if (MessageBox.Show("Bạn Có Muốn Thêm?", "Thông Báo Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    NhanVienServices.Insert(nv);

                }

            }
            LoadData();

        }

        private void dgvNoiDung_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvNoiDung.CurrentRow;
            if (row.Index < dgvNoiDung.RowCount)
            {
                if (row.Cells[1].Value != null)
                {
                    txtMaNV.Text = (row.Cells[1]).Value.ToString();
                }
                if (row.Cells[2].Value != null)
                {
                    txtTenNV.Text = (row.Cells[2]).Value.ToString();
                }
                if (row.Cells[3].Value != null)
                {
                    txtDiaChi.Text = (row.Cells[3]).Value.ToString();
                }
                if (row.Cells[4].Value != null)
                {
                    txtSDT.Text = (row.Cells[4]).Value.ToString();
                }
                if (row.Cells[5].Value != null)
                {
                    txtGioiTinh.Text = (row.Cells[5]).Value.ToString();
                }
                if (row.Cells[6].Value != null)
                {
                    dtpNamSinh.Text = (row.Cells[6]).Value.ToString();
                }
                if (row.Cells[7].Value != null)
                {
                    txtChucVu.Text = (row.Cells[7]).Value.ToString();
                }
                if (row.Cells[8].Value != null)
                {
                    txtTrangThai.Text = (row.Cells[8]).Value.ToString();
                }
                if (row.Cells[9].Value != null)
                {
                    dtpNgayVaoLam.Text = (row.Cells[9]).Value.ToString();
                }
                if (row.Cells[10].Value != null)
                {
                    txtTenDangNhap.Text = (row.Cells[10]).Value.ToString();
                }
                if (row.Cells[11].Value != null)
                {
                    txtMatKhau.Text = (row.Cells[11]).Value.ToString();
                }


            }
        }

       
        private void btnXoa_Click(object sender, EventArgs e)
        {
            var obf = NhanVienServices.DeleteByID(txtMaNV.Text);
            if (obf == null)
            {
                MessageBox.Show("Xóa Thất Bại", "Thông Báo");
            }
            else if (obf!=null)
            {
                if (MessageBox.Show("Bạn Có Muốn Xóa?", "Thông Báo Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var delete = NhanVienServices.DeleteByID(txtMaNV.Text);
                    NhanVienServices.Delete(delete);
                    LoadData();
                }
                
            }

        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn Chắc Chắn Muốn Sửa?", "Thông Báo Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Nhanvien nv = new Nhanvien();
                nv.MaNhanVien = txtMaNV.Text;
                nv.TenNhanVien = txtTenNV.Text;
                nv.DiaChi = txtDiaChi.Text;
                nv.SoDienThoai = txtSDT.Text;
                nv.GioiTinh = txtGioiTinh.Text;
                nv.NamSinh = dtpNamSinh.Value;
                nv.TenChucVu = txtChucVu.Text;
                nv.TrangThai = txtTrangThai.Text;
                nv.NgayVaoLam = dtpNgayVaoLam.Value;
                nv.TenDangNhap = txtTenDangNhap.Text;
                nv.MatKhau = txtMatKhau.Text;
                NhanVienServices.Update(nv);
                LoadData();
            }

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            List<Nhanvien> found = new List<Nhanvien>();
            if (CbCV.Text == "" && txtTimKiem.Text == "")
            {
                LoadData();
            }
            else if (CbCV.Text != "" && txtTimKiem.Text == "")
            {
                found = NhanVienServices.GetLstObjectByCV(CbCV.Text).ToList();
                dgvNoiDung.DataSource = found;
            }
            else if (CbCV.Text == "" && txtTimKiem.Text != "")
            {
                found = NhanVienServices.GetByID(txtTimKiem.Text).ToList();
                dgvNoiDung.DataSource = found;
            }
            else if (CbCV.Text != "" && txtTimKiem.Text != "")
            {
                found = NhanVienServices.GetLstObjectByCV(CbCV.Text).ToList();
                List<Nhanvien> lsv = new List<Nhanvien>();
                foreach (var item in found)
                {
                    if (item.TenNhanVien == txtTimKiem.Text)
                    {

                        lsv.Add(item);
                        dgvNoiDung.DataSource = lsv;
                    }
                }

            }
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvNoiDung_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}