﻿using System;
using System.Collections.Generic;

namespace src.Models;

public partial class Caulacbo
{
    public string CauLacBoId { get; set; } = null!;

    public string? TenClb { get; set; }

    public string? TenGoi { get; set; }

    public string? SanVanDongId { get; set; }

    public string? HuanLuyenVienId { get; set; }

    public string? Anh { get; set; }

    public int? SoTranDau { get; set; }

    public virtual ICollection<Cauthu> Cauthus { get; set; } = new List<Cauthu>();

    public virtual Huanluyenvien? HuanLuyenVien { get; set; }

    public virtual Sanvandong? SanVanDong { get; set; }

    public virtual ICollection<Trandau> TrandauClbkhachNavigations { get; set; } = new List<Trandau>();

    public virtual ICollection<Trandau> TrandauClbnhaNavigations { get; set; } = new List<Trandau>();

    public virtual ICollection<TrandauGhiban> TrandauGhibans { get; set; } = new List<TrandauGhiban>();
}
