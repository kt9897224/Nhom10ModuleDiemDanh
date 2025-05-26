﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace API.Data
{
    public class NhomXuong
    {
        [Key]
        public Guid IdNhomXuong { get; set; } = Guid.NewGuid();

        [MaxLength(100)]
        public string TenNhomXuong { get; set; }

        public Guid? IdDuAn { get; set; }
        public Guid? IdBoMon { get; set; }
        public Guid? IdNhanVien { get; set; }

        [MaxLength(255)]
        public string MoTa { get; set; }
        public DateTime NgayTao { get; set; } = DateTime.Now;
        public DateTime? NgayCapNhat { get; set; }
        public int TrangThai { get; set; } = 1;

        // Navigation properties
        public virtual DuAn DuAn { get; set; }
        public virtual QuanLyBoMon BoMon { get; set; }
        public virtual PhuTrachXuong PhuTrachXuong { get; set; }
        public virtual ICollection<SinhVien> SinhViens { get; set; }
        public virtual ICollection<DiemDanh> DiemDanhs { get; set; }
        public virtual ICollection<LichHoc> LichHocs { get; set; }
        public virtual ICollection<LichGiangDay> LichGiangDays { get; set; }
        public virtual ICollection<KeHoachNhomXuong> KeHoachNhomXuongs { get; set; }
    }
}
