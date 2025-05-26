using System.ComponentModel.DataAnnotations;

namespace API.Data
{
    public class LichGiangDay
    {
        [Key]
        public Guid IDLichGD { get; set; }
        public Guid IDDiaDiem { get; set; }

        public string TenGiangVien { get; set; }
        public string MonGiangDay { get; set; }
        public int SoTiet { get; set; }
        public DateTime NgayDay { get; set; }
        public int TrangThai { get; set; }

        public DiaDiem DiaDiem { get; set; }
    }
}
