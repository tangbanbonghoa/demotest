﻿using System;
using System.Collections.Generic;

namespace A_DAL.Models;

public partial class Hoadon
{
    public string MaHoaDon { get; set; } = null!;

    public string SoDienThoai { get; set; } = null!;

    public string MaNhanVien { get; set; } = null!;

    public string MaKhuyenMai { get; set; } = null!;

    public DateTime NgayLap { get; set; }

    public string TrangThai { get; set; } = null!;

    public double TongTien { get; set; }

    public virtual ICollection<Hoadonchitiet> Hoadonchitiets { get; set; } = new List<Hoadonchitiet>();

    public virtual Khuyenmai MaKhuyenMaiNavigation { get; set; } = null!;

    public virtual Nhanvien MaNhanVienNavigation { get; set; } = null!;

    public virtual Khachhang SoDienThoaiNavigation { get; set; } = null!;
}
