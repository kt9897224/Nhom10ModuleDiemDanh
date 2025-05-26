using System.ComponentModel.DataAnnotations;

namespace API.Data
{
    public class LichHoc
    {
        [Key]
        public Guid IDLichHoc { get; set; }
        public Guid IDCoSo { get; set; }
        public Guid IDCaHoc { get; set; }
        public Guid IDHocKy { get; set; }
        public int TrangThai { get; set; }

        public CoSo CoSo { get; set; }
        public CaHoc CaHoc { get; set; }
        public HocKy HocKy { get; set; }

        public ICollection<KeHoach> KeHoachs { get; set; }
    }
}
