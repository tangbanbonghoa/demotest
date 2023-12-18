﻿using System;
using System.Collections.Generic;

namespace A_DAL.Models;

public partial class Khachhang
{
    public string SoDienThoai { get; set; } = null!;

    public string HoVaTen { get; set; } = null!;

    public string GioiTinh { get; set; } = null!;

    public string DiaChi { get; set; } = null!;

    public DateTime NgaySinh { get; set; }

    public string Email { get; set; } = null!;

    public virtual ICollection<Hoadon> Hoadons { get; set; } = new List<Hoadon>();
}
