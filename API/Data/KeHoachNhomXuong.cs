namespace API.Data
{
    public class KeHoachNhomXuong
    {
        public Guid IdKHNX { get; set; }
        public Guid IdNhomXuong { get; set; }
        public Guid IdKeHoach { get; set; }
        public string ThoiGianThucTe { get; set; }
        public int SoBuoi { get; set; }
        public int SoSinhVien { get; set; }
        public DateTime NgayTao { get; set; }
        public DateTime NgayCapNhat { get; set; }
        public int TrangThai { get; set; }

        public NhomXuong NhomXuong { get; set; }
        public KeHoach KeHoach { get; set; }
        public ICollection<KHNXCaHoc> KHNXCaHocs { get; set; }
    }
}
