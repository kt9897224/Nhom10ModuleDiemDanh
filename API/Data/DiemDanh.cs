namespace API.Data
{
    public class DiemDanh
    {
        public Guid IdDiemDanh { get; set; }
        public Guid IdSinhVien { get; set; }
        public Guid IdCaHoc { get; set; }
        public Guid IdNhomXuong { get; set; }
        public Guid IdNhanVien { get; set; }
        public DateTime NgayTao { get; set; }

        public SinhVien SinhVien { get; set; }
        public CaHoc CaHoc { get; set; }
        public NhomXuong NhomXuong { get; set; }
        public PhuTrachXuong NhanVien { get; set; }
        public ICollection<LichSuDiemDanh> LichSuDiemDanhs { get; set; }
    }
}
