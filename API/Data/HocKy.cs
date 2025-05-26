using System.ComponentModel.DataAnnotations;

namespace API.Data
{
    public class HocKy
    {
        [Key]
        public Guid IDHocKy { get; set; }
        public string TenHocKy { get; set; }
        public bool TrangThai { get; set; }

        public ICollection<LichHoc> LichHocs { get; set; }
    }
}
