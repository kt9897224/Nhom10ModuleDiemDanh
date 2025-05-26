using System.ComponentModel.DataAnnotations;

namespace API.Data
{
    public class CaHoc
    {
        [Key]
        public Guid IdCaHoc { get; set; } = Guid.NewGuid();

        public string CaHocName { get; set; }
        public TimeSpan? ThoiGianBatDau { get; set; }
        public TimeSpan? ThoiGianKetThuc { get; set; }
        public string MoTa { get; set; }

        public DateTime NgayCapNhat { get; set; } = DateTime.Now;
        public int TrangThai { get; set; } = 1;

        public ICollection<CoSo> CoSos { get; set; }
        public ICollection<LichHoc> LichHocs { get; set; }
        public ICollection<KHNXCaHoc> KHNXCaHocs { get; set; }
    }
}
