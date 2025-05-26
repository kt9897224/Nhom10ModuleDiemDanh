using System.ComponentModel.DataAnnotations;

namespace API.Data
{
    public class SinhVien
    {
        [Key]
        public Guid IDSinhVien { get; set; }
        public string HoTen { get; set; }
        public string MSSV { get; set; }
        public string Lop { get; set; }
        public string SDT { get; set; }
        public string Email { get; set; }
        public int TrangThai { get; set; }
    }
}
