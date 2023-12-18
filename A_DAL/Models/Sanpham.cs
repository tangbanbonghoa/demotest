using System;
using System.Collections.Generic;

namespace A_DAL.Models;

public partial class Sanpham
{
    public string MaSanPham { get; set; } = null!;

    public string TenSanPham { get; set; } = null!;

    public double GiaBan { get; set; }

    public int SoLuong { get; set; }

    public string MaThuongHieu { get; set; } = null!;

    public virtual ICollection<Hoadonchitiet> Hoadonchitiets { get; set; } = new List<Hoadonchitiet>();

    public virtual Thuonghieu MaThuongHieuNavigation { get; set; } = null!;
}
