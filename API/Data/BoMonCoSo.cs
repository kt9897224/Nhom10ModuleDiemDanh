namespace API.Data
{
    public class BoMonCoSo
    {
        public Guid IDBoMon { get; set; }
        public Guid IDCoSo { get; set; }

        public QuanLyBoMon QuanLyBoMon { get; set; }
        public CoSo CoSo { get; set; }
    }
}
