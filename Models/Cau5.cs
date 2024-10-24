using System;
using System.Collections.Generic;

namespace src.Models;

public partial class Cau5
{
    public string CauLacBoId { get; set; } = null!;

    public string? TenClb { get; set; }

    public string? HoVaTen { get; set; }

    public DateTime? NgayThiDau { get; set; }

    public int? ThoiDiemGhiBan { get; set; }
}
