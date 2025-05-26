namespace API.Data
{
    public class KHNXCaHoc
    {
        public Guid IdNXCH { get; set; }
        public int Buoi { get; set; }
        public DateTime NgayHoc { get; set; }
        public string ThoiGian { get; set; }
        public Guid IdKHNX { get; set; }
        public Guid IdCaHoc { get; set; }
        public string NoiDung { get; set; }
        public string LinkOnline { get; set; }
        public bool DiemDanhTre { get; set; }
        public DateTime NgayTao { get; set; }
        public DateTime NgayCapNhat { get; set; }
        public int TrangThai { get; set; }

        public KeHoachNhomXuong KeHoachNhomXuong { get; set; }
        public CaHoc CaHoc { get; set; }
    }
}
