﻿using System;
using System.ComponentModel.DataAnnotations;

namespace API.Data
{
    public class CoSo
    {
        [Key]
        public Guid IdCoSo { get; set; } = Guid.NewGuid();
        public string TenCoSo { get; set; }
        public string MaCoSo { get; set; }
        public string DiaChi { get; set; }
        public string SDT { get; set; }
        public string Email { get; set; }
        public Guid? IdDiaDiem { get; set; }
        public Guid? IdIP { get; set; }
        public Guid? IdCaHoc { get; set; }
        public DateTime NgayTao { get; set; } = DateTime.Now;
        public DateTime? NgayCapNhat { get; set; }
        public bool TrangThai { get; set; } = true;

        // Navigation properties
        public virtual DiaDiem DiaDiem { get; set; }
        public virtual IP IP { get; set; }
        public virtual CaHoc CaHoc { get; set; }
        public virtual ICollection<PhuTrachXuong> PhuTrachXuongs { get; set; }
        public virtual ICollection<BoMonCoSo> BoMonCoSos { get; set; }
        public virtual ICollection<KHNXCaHoc> KHNXCaHocs { get; set; }
    }
}
