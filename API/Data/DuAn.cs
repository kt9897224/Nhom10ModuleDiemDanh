using System.ComponentModel.DataAnnotations;

namespace API.Data
{
    public class DuAn
    {
        [Key]
        public Guid IDDuAn { get; set; }
        public string TenDuAn { get; set; }

        public Guid IDCDDA { get; set; }
        public Guid IDBoMon { get; set; }
        public int TrangThai { get; set; }

        public CapDoDuAn CapDoDuAn { get; set; }
        public QuanLyBoMon QuanLyBoMon { get; set; }

        public ICollection<PhuTrachXuong> PhuTrachXuongs { get; set; }
    }
}
