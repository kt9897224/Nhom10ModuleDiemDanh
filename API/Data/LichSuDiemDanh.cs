namespace API.Data
{
    public class LichSuDiemDanh
    {
        public Guid IdLSDD { get; set; }
        public Guid IdDiemDanh { get; set; }
        public Guid IdNXCH { get; set; }
        public DateTime ThoiGianDiemDanh { get; set; }
        public string NoiDungBuoiHoc { get; set; }
        public string HinhThuc { get; set; }
        public string DiaDiem { get; set; }
        public string GhiChu { get; set; }
        public int TrangThai { get; set; }
        public DateTime NgayTao { get; set; }
        public DateTime? NgayCapNhat { get; set; }
        public int TrangThaiDuyet { get; set; }

        public DiemDanh DiemDanh { get; set; }
        public CoSo CoSo { get; set; }
    }
}
