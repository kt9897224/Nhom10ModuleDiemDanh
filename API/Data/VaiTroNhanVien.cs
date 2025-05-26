namespace API.Data
{
    public class VaiTroNhanVien
    {
        public Guid IdVaiTroNhanVien { get; set; }
        public Guid? IdVaiTro { get; set; }
        public Guid? IdNhanVien { get; set; }
        public DateTime NgayTao { get; set; }
        public DateTime? NgayCapNhat { get; set; }
        public bool TrangThai { get; set; }

        public VaiTro VaiTro { get; set; }
        public PhuTrachXuong NhanVien { get; set; }
    }
}
