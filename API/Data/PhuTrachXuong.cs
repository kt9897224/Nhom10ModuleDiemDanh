using System.ComponentModel.DataAnnotations;

namespace API.Data
{
    public class PhuTrachXuong
    {
        [Key]
        public Guid IDPhuTrach { get; set; }
        public string TenPhuTrach { get; set; }
        public Guid IDDuAn { get; set; }
        public int TrangThai { get; set; }

        public DuAn DuAn { get; set; }
        public ICollection<KeHoach> KeHoachs { get; set; }
    }
}
