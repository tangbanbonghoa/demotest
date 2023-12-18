using System;
using System.Collections.Generic;

namespace A_DAL.Models;

public partial class Nhanvien
{
    public string MaNhanVien { get; set; } = null!;

    public string TenNhanVien { get; set; } = null!;

    public string DiaChi { get; set; } = null!;

    public string SoDienThoai { get; set; } = null!;

    public string GioiTinh { get; set; } = null!;

    public DateTime NamSinh { get; set; }

    public string TrangThai { get; set; } = null!;

    public DateTime NgayVaoLam { get; set; }

    public string? TenDangNhap { get; set; }

    public string? MatKhau { get; set; }

    public string TenChucVu { get; set; } = null!;

    public virtual ICollection<Hoadon> Hoadons { get; set; } = new List<Hoadon>();
}
