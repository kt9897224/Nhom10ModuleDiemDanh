using System.ComponentModel.DataAnnotations;

namespace API.Data
{
    public class CoSo
    {
        [Key]
        public Guid IDCoSo { get; set; }

        public Guid IDDiaDiem { get; set; }
        public Guid IDCaHoc { get; set; }
        public Guid IDIP { get; set; }

        public string TenCoSo { get; set; }
        public int TrangThai { get; set; }

        public DiaDiem DiaDiem { get; set; }
        public CaHoc CaHoc { get; set; }
        public IP IP { get; set; }

        public ICollection<LichHoc> LichHocs { get; set; }
        public ICollection<BoMonCoSo> BoMonCoSos { get; set; }
    }
}
