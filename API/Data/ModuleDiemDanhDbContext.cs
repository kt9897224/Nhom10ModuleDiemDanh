using Microsoft.EntityFrameworkCore;
using System;

namespace API.Data
{
    public class ModuleDiemDanhDbContext : DbContext
    {
        public ModuleDiemDanhDbContext(DbContextOptions<ModuleDiemDanhDbContext> options) : base(options)
        {
        }

        public DbSet<SinhVien> SinhViens { get; set; }
        public DbSet<DiemDanh> DiemDanhs { get; set; }
        public DbSet<NhomXuong> NhomXuongs { get; set; }
        public DbSet<KeHoach> KeHoachs { get; set; }
        public DbSet<KeHoachNhomXuong> KeHoachNhomXuongs { get; set; }
        public DbSet<KHNXCaHoc> KHNXCaHocs { get; set; }
        public DbSet<CaHoc> CaHocs { get; set; }
        public DbSet<LichHoc> LichHocs { get; set; }
        public DbSet<LichGiangDay> LichGiangDays { get; set; }
        public DbSet<DuAn> DuAns { get; set; }
        public DbSet<CoSo> CoSos { get; set; }
        public DbSet<BoMonCoSo> BoMonCoSos { get; set; }
        public DbSet<BanDaoTao> BanDaoTaos { get; set; }
        public DbSet<QuanLyBoMon> QuanLyBoMons { get; set; }
        public DbSet<PhuTrachXuong> PhuTrachXuongs { get; set; }
        public DbSet<VaiTro> VaiTros { get; set; }
        public DbSet<VaiTroNhanVien> VaiTroNhanViens { get; set; }
        public DbSet<CapDoDuAn> CapDoDuAns { get; set; }
        public DbSet<DiaDiem> DiaDiems { get; set; }
        public DbSet<IP> IPs { get; set; }
        public DbSet<LichSuDiemDanh> LichSuDiemDanhs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure relationships and constraints here
            modelBuilder.Entity<DiemDanh>()
                .HasOne(d => d.SinhVien)
                .WithMany(s => s.DiemDanhs)
                .HasForeignKey(d => d.IdSinhVien);

            modelBuilder.Entity<DiemDanh>()
                .HasOne(d => d.CaHoc)
                .WithMany(c => c.DiemDanhs)
                .HasForeignKey(d => d.IdCaHoc);

            modelBuilder.Entity<DiemDanh>()
                .HasOne(d => d.NhomXuong)
                .WithMany(n => n.DiemDanhs)
                .HasForeignKey(d => d.IdNhomXuong);

            modelBuilder.Entity<DiemDanh>()
                .HasOne(d => d.PhuTrachXuong)
                .WithMany(p => p.DiemDanhs)
                .HasForeignKey(d => d.IdNhanVien);

            modelBuilder.Entity<KeHoachNhomXuong>()
                .HasOne(k => k.KeHoach)
                .WithMany(k => k.KeHoachNhomXuongs)
                .HasForeignKey(k => k.IdKeHoach);

            modelBuilder.Entity<KeHoachNhomXuong>()
                .HasOne(k => k.NhomXuong)
                .WithMany(n => n.KeHoachNhomXuongs)
                .HasForeignKey(k => k.IdNhomXuong);

            modelBuilder.Entity<KHNXCaHoc>()
                .HasOne(k => k.KeHoachNhomXuong)
                .WithMany(k => k.KHNXCaHocs)
                .HasForeignKey(k => k.IdKHNX);

            modelBuilder.Entity<KHNXCaHoc>()
                .HasOne(k => k.CaHoc)
                .WithMany(c => c.KHNXCaHocs)
                .HasForeignKey(k => k.IdCaHoc);

            modelBuilder.Entity<LichGiangDay>()
                .HasOne(l => l.KHNXCaHoc)
                .WithMany(k => k.LichGiangDays)
                .HasForeignKey(l => l.IdNXCH);

            modelBuilder.Entity<LichGiangDay>()
                .HasOne(l => l.DiaDiem)
                .WithMany(d => d.LichGiangDays)
                .HasForeignKey(l => l.IdDiaDiem);

            modelBuilder.Entity<LichGiangDay>()
                .HasOne(l => l.NhomXuong)
                .WithMany(n => n.LichGiangDays)
                .HasForeignKey(l => l.IdNhomXuong);

            modelBuilder.Entity<LichGiangDay>()
                .HasOne(l => l.DuAn)
                .WithMany(d => d.LichGiangDays)
                .HasForeignKey(l => l.IdDuAn);

            modelBuilder.Entity<PhuTrachXuong>()
                .HasOne(p => p.CoSo)
                .WithMany(c => c.PhuTrachXuongs)
                .HasForeignKey(p => p.IdCoSo);

            modelBuilder.Entity<PhuTrachXuong>()
                .HasMany(p => p.NhomXuongs)
                .WithOne(n => n.PhuTrachXuong)
                .HasForeignKey(n => n.IdPhuTrachXuong);

            modelBuilder.Entity<QuanLyBoMon>()
                .HasMany(q => q.NhomXuongs)
                .WithOne(n => n.QuanLyBoMon)
                .HasForeignKey(n => n.IdBoMon);

            modelBuilder.Entity<QuanLyBoMon>()
                .HasMany(q => q.DuAns)
                .WithOne(d => d.QuanLyBoMon)
                .HasForeignKey(d => d.IdBoMon);

            modelBuilder.Entity<QuanLyBoMon>()
                .HasMany(q => q.BoMonCoSos)
                .WithOne(b => b.QuanLyBoMon)
                .HasForeignKey(b => b.IdBoMon);

            modelBuilder.Entity<VaiTroNhanVien>()
                .HasOne(v => v.VaiTro)
                .WithMany(v => v.VaiTroNhanViens)
                .HasForeignKey(v => v.IdVaiTro);

            modelBuilder.Entity<LichSuDiemDanh>()
                .HasOne(l => l.DiemDanh)
                .WithMany(d => d.LichSuDiemDanhs)
                .HasForeignKey(l => l.IdDiemDanh);
        }
    }
}
