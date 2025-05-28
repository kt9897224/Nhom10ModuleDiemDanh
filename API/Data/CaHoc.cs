using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace API.Data
{
    public class CaHoc
    {
        [Key]
        public Guid IdCaHoc { get; set; } = Guid.NewGuid();
        public string caHoc { get; set; }
        public TimeSpan? ThoiGianBatDau { get; set; }
        public TimeSpan? ThoiGianKetThuc { get; set; }
        public string MoTa { get; set; } //
        public DateTime NgayCapNhat { get; set; } = DateTime.Now;
        public int TrangThai { get; set; } = 1;

        // Navigation properties
        public virtual ICollection<DiemDanh> DiemDanhs { get; set; }
        public virtual ICollection<LichHoc> LichHocs { get; set; }
        public virtual ICollection<KHNXCaHoc> KHNXCaHocs { get; set; }
        public virtual ICollection<CoSo> CoSos { get; set; }
    }
}
