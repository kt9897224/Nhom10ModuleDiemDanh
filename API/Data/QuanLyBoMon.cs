using System.ComponentModel.DataAnnotations;

namespace API.Data
{
    public class QuanLyBoMon
    {
        [Key]
        public Guid IDBoMon { get; set; }

        public string MaBoMon { get; set; }
        public string TenBoMon { get; set; }
        public string CoSoHoatDong { get; set; }

        public DateTime? NgayTao { get; set; }
        public DateTime? NgayCapNhat { get; set; }
        public int TrangThai { get; set; }

        public ICollection<DuAn> DuAns { get; set; }
        public ICollection<NhomXuong> NhomXuongs { get; set; }
        public ICollection<BoMonCoSo> BoMonCoSos { get; set; }
    }
}
