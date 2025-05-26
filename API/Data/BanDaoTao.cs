using System;
using System.ComponentModel.DataAnnotations;

namespace API.Data
{
    public class BanDaoTao
    {
        [Key]
        public Guid IdBanDaoTao { get; set; } = Guid.NewGuid();
        public string TenBanDaoTao { get; set; }
        public string MaBanDaoTao { get; set; }
        public Guid? IdVaiTro { get; set; }
        public DateTime NgayTao { get; set; } = DateTime.Now;
        public DateTime? NgayCapNhat { get; set; }
        public bool TrangThai { get; set; } = true;

        // Navigation properties
        public virtual VaiTro VaiTro { get; set; }
    }
}
