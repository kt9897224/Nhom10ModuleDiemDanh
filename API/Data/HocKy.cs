using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace API.Data
{
    public class HocKy
    {
        [Key]
        public Guid IdHocKy { get; set; } = Guid.NewGuid();
        public string TenHocKy { get; set; }
        public DateTime NgayTao { get; set; } = DateTime.Now;
        public DateTime? NgayCapNhat { get; set; }
        public bool TrangThai { get; set; } = true;

        // Navigation properties
        public virtual ICollection<DuAn> DuAns { get; set; }
    }
}
