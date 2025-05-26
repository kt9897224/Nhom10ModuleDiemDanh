namespace API.Data
{
    public class BanDaoTao
    {
        public Guid IdBDT { get; set; }
        public string MaBanDaoTao { get; set; }
        public string TenBanDaoTao { get; set; }
        public string Email { get; set; }
        public Guid IdVaiTro { get; set; }
        public int TrangThai { get; set; }
        public DateTime NgayTao { get; set; }
        public DateTime? NgayCapNhat { get; set; }

        public VaiTro VaiTro { get; set; }
    }
}
