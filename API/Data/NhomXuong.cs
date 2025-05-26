namespace API.Data
{
    public class NhomXuong
    {
        public Guid IdNhomXuong { get; set; } = Guid.NewGuid();
        public string TenNhomXuong { get; set; }
        public Guid IdDuAn { get; set; }
        public Guid IdBoMon { get; set; }
        public Guid IdNhanVien { get; set; }
        public string MoTa { get; set; }
        public DateTime NgayTao { get; set; } = DateTime.Now;
        public DateTime? NgayCapNhat { get; set; }
        public int TrangThai { get; set; } = 1;

        public DuAn DuAn { get; set; }
        public QuanLyBoMon BoMon { get; set; }
        public PhuTrachXuong NhanVien { get; set; }

        public ICollection<KeHoachNhomXuong> KeHoachNhomXuongs { get; set; }
        public ICollection<SinhVien> SinhViens { get; set; }
        public ICollection<DiemDanh> DiemDanhs { get; set; }
    }
}
