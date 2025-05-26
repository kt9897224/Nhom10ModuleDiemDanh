using System;
using System.ComponentModel.DataAnnotations;

namespace API.Data
{
    public class CapDoDuAn
    {
        [Key]
        public Guid IdCDDA { get; set; } = Guid.NewGuid();

        [Required]
        public string TenCapDoDuAn { get; set; }

        [Required]
        public string MaCapDoDuAn { get; set; }

        public string MoTa { get; set; }
        public DateTime NgayTao { get; set; } = DateTime.Now;
        public DateTime? NgayCapNhat { get; set; }
        public int TrangThai { get; set; } = 1;

        public virtual ICollection<DuAn> DuAns { get; set; }
    }
}
