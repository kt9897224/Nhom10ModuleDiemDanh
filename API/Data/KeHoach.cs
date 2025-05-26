using System.ComponentModel.DataAnnotations;

namespace API.Data
{
    public class KeHoach
    {
        [Key]
        public Guid IDKeHoach { get; set; }
        public Guid IDPhuTrach { get; set; }
        public Guid IDLichHoc { get; set; }
        public int TrangThai { get; set; }

        public PhuTrachXuong PhuTrachXuong { get; set; }
        public LichHoc LichHoc { get; set; }
    }
}
