﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class _543 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CaHocs",
                columns: table => new
                {
                    IdCaHoc = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    caHoc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ThoiGianBatDau = table.Column<TimeSpan>(type: "time", nullable: true),
                    ThoiGianKetThuc = table.Column<TimeSpan>(type: "time", nullable: true),
                    MoTa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NgayCapNhat = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CaHocs", x => x.IdCaHoc);
                });

            migrationBuilder.CreateTable(
                name: "CapDoDuAns",
                columns: table => new
                {
                    IdCDDA = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenCapDoDuAn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaCapDoDuAn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MoTa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgayCapNhat = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CapDoDuAns", x => x.IdCDDA);
                });

            migrationBuilder.CreateTable(
                name: "DiaDiems",
                columns: table => new
                {
                    IdDiaDiem = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenDiaDiem = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ViDo = table.Column<double>(type: "float", nullable: true),
                    KinhDo = table.Column<double>(type: "float", nullable: true),
                    BanKinh = table.Column<double>(type: "float", nullable: true),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgayCapNhat = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiaDiems", x => x.IdDiaDiem);
                });

            migrationBuilder.CreateTable(
                name: "hocKy",
                columns: table => new
                {
                    IdHocKy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenHocKy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgayCapNhat = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hocKy", x => x.IdHocKy);
                });

            migrationBuilder.CreateTable(
                name: "IPs",
                columns: table => new
                {
                    IdIP = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    KieuIP = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IP_DaiIP = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgayCapNhat = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IPs", x => x.IdIP);
                });

            migrationBuilder.CreateTable(
                name: "QuanLyBoMons",
                columns: table => new
                {
                    IDBoMon = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaBoMon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TenBoMon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CoSoHoatDong = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NgayCapNhat = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuanLyBoMons", x => x.IDBoMon);
                });

            migrationBuilder.CreateTable(
                name: "VaiTros",
                columns: table => new
                {
                    IdVaiTro = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenVaiTro = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgayCapNhat = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VaiTros", x => x.IdVaiTro);
                });

            migrationBuilder.CreateTable(
                name: "CoSos",
                columns: table => new
                {
                    IdCoSo = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenCoSo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaCoSo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SDT = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdDiaDiem = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdIP = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdCaHoc = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgayCapNhat = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false),
                    DiaDiemIdDiaDiem = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IPIdIP = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CaHocIdCaHoc = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoSos", x => x.IdCoSo);
                    table.ForeignKey(
                        name: "FK_CoSos_CaHocs_CaHocIdCaHoc",
                        column: x => x.CaHocIdCaHoc,
                        principalTable: "CaHocs",
                        principalColumn: "IdCaHoc",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CoSos_DiaDiems_DiaDiemIdDiaDiem",
                        column: x => x.DiaDiemIdDiaDiem,
                        principalTable: "DiaDiems",
                        principalColumn: "IdDiaDiem",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CoSos_IPs_IPIdIP",
                        column: x => x.IPIdIP,
                        principalTable: "IPs",
                        principalColumn: "IdIP",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DuAns",
                columns: table => new
                {
                    IdDuAn = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenDuAn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaDuAn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MoTa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdCDDA = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdBoMon = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdHocKy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgayCapNhat = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false),
                    CapDoDuAnIdCDDA = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DuAns", x => x.IdDuAn);
                    table.ForeignKey(
                        name: "FK_DuAns_CapDoDuAns_CapDoDuAnIdCDDA",
                        column: x => x.CapDoDuAnIdCDDA,
                        principalTable: "CapDoDuAns",
                        principalColumn: "IdCDDA",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DuAns_QuanLyBoMons_IdBoMon",
                        column: x => x.IdBoMon,
                        principalTable: "QuanLyBoMons",
                        principalColumn: "IDBoMon");
                    table.ForeignKey(
                        name: "FK_DuAns_hocKy_IdHocKy",
                        column: x => x.IdHocKy,
                        principalTable: "hocKy",
                        principalColumn: "IdHocKy");
                });

            migrationBuilder.CreateTable(
                name: "BanDaoTaos",
                columns: table => new
                {
                    IdBanDaoTao = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenBanDaoTao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaBanDaoTao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdVaiTro = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgayCapNhat = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false),
                    VaiTroIdVaiTro = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BanDaoTaos", x => x.IdBanDaoTao);
                    table.ForeignKey(
                        name: "FK_BanDaoTaos_VaiTros_VaiTroIdVaiTro",
                        column: x => x.VaiTroIdVaiTro,
                        principalTable: "VaiTros",
                        principalColumn: "IdVaiTro",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BoMonCoSos",
                columns: table => new
                {
                    IdBoMonCoSo = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdBoMon = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdCoSo = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgayCapNhat = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false),
                    CoSoIdCoSo = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BoMonCoSos", x => x.IdBoMonCoSo);
                    table.ForeignKey(
                        name: "FK_BoMonCoSos_CoSos_CoSoIdCoSo",
                        column: x => x.CoSoIdCoSo,
                        principalTable: "CoSos",
                        principalColumn: "IdCoSo",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BoMonCoSos_QuanLyBoMons_IdBoMon",
                        column: x => x.IdBoMon,
                        principalTable: "QuanLyBoMons",
                        principalColumn: "IDBoMon");
                });

            migrationBuilder.CreateTable(
                name: "PhuTrachXuongs",
                columns: table => new
                {
                    IdNhanVien = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenNhanVien = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    MaNhanVien = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    EmailFE = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    EmailFPT = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IdCoSo = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgayCapNhat = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhuTrachXuongs", x => x.IdNhanVien);
                    table.ForeignKey(
                        name: "FK_PhuTrachXuongs_CoSos_IdCoSo",
                        column: x => x.IdCoSo,
                        principalTable: "CoSos",
                        principalColumn: "IdCoSo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KeHoachs",
                columns: table => new
                {
                    IdKeHoach = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenKeHoach = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    IdDuAn = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    NoiDung = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NgayDienRa = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgayCapNhat = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DuAnIdDuAn = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KeHoachs", x => x.IdKeHoach);
                    table.ForeignKey(
                        name: "FK_KeHoachs_DuAns_DuAnIdDuAn",
                        column: x => x.DuAnIdDuAn,
                        principalTable: "DuAns",
                        principalColumn: "IdDuAn",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NhomXuongs",
                columns: table => new
                {
                    IdNhomXuong = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenNhomXuong = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IdDuAn = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdBoMon = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdPhuTrachXuong = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    MoTa = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgayCapNhat = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TrangThai = table.Column<int>(type: "int", nullable: false),
                    DuAnIdDuAn = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhomXuongs", x => x.IdNhomXuong);
                    table.ForeignKey(
                        name: "FK_NhomXuongs_DuAns_DuAnIdDuAn",
                        column: x => x.DuAnIdDuAn,
                        principalTable: "DuAns",
                        principalColumn: "IdDuAn",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NhomXuongs_PhuTrachXuongs_IdPhuTrachXuong",
                        column: x => x.IdPhuTrachXuong,
                        principalTable: "PhuTrachXuongs",
                        principalColumn: "IdNhanVien");
                    table.ForeignKey(
                        name: "FK_NhomXuongs_QuanLyBoMons_IdBoMon",
                        column: x => x.IdBoMon,
                        principalTable: "QuanLyBoMons",
                        principalColumn: "IDBoMon");
                });

            migrationBuilder.CreateTable(
                name: "VaiTroNhanViens",
                columns: table => new
                {
                    IdVTNV = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdNhanVien = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdVaiTro = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgayCapNhat = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false),
                    PhuTrachXuongIdNhanVien = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VaiTroNhanViens", x => x.IdVTNV);
                    table.ForeignKey(
                        name: "FK_VaiTroNhanViens_PhuTrachXuongs_PhuTrachXuongIdNhanVien",
                        column: x => x.PhuTrachXuongIdNhanVien,
                        principalTable: "PhuTrachXuongs",
                        principalColumn: "IdNhanVien",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VaiTroNhanViens_VaiTros_IdVaiTro",
                        column: x => x.IdVaiTro,
                        principalTable: "VaiTros",
                        principalColumn: "IdVaiTro");
                });

            migrationBuilder.CreateTable(
                name: "KeHoachNhomXuongs",
                columns: table => new
                {
                    IdKHNX = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdNhomXuong = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdKeHoach = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ThoiGianThucTe = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    SoBuoi = table.Column<int>(type: "int", nullable: false),
                    SoSinhVien = table.Column<int>(type: "int", nullable: false),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgayCapNhat = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KeHoachNhomXuongs", x => x.IdKHNX);
                    table.ForeignKey(
                        name: "FK_KeHoachNhomXuongs_KeHoachs_IdKeHoach",
                        column: x => x.IdKeHoach,
                        principalTable: "KeHoachs",
                        principalColumn: "IdKeHoach",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KeHoachNhomXuongs_NhomXuongs_IdNhomXuong",
                        column: x => x.IdNhomXuong,
                        principalTable: "NhomXuongs",
                        principalColumn: "IdNhomXuong",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SinhViens",
                columns: table => new
                {
                    IdSinhVien = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenSinhVien = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaSinhVien = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdNhomXuong = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NgayCapNhat = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IdVaiTro = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NhomXuongIdNhomXuong = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VaiTroIdVaiTro = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SinhViens", x => x.IdSinhVien);
                    table.ForeignKey(
                        name: "FK_SinhViens_NhomXuongs_NhomXuongIdNhomXuong",
                        column: x => x.NhomXuongIdNhomXuong,
                        principalTable: "NhomXuongs",
                        principalColumn: "IdNhomXuong",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SinhViens_VaiTros_VaiTroIdVaiTro",
                        column: x => x.VaiTroIdVaiTro,
                        principalTable: "VaiTros",
                        principalColumn: "IdVaiTro",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KHNXCaHocs",
                columns: table => new
                {
                    IdNXCH = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Buoi = table.Column<int>(type: "int", nullable: false),
                    NgayHoc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ThoiGian = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IdKHNX = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdCaHoc = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NoiDung = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LinkOnline = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    DiemDanhTre = table.Column<bool>(type: "bit", nullable: false),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgayCapNhat = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TrangThai = table.Column<int>(type: "int", nullable: false),
                    CoSoIdCoSo = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KHNXCaHocs", x => x.IdNXCH);
                    table.ForeignKey(
                        name: "FK_KHNXCaHocs_CaHocs_IdCaHoc",
                        column: x => x.IdCaHoc,
                        principalTable: "CaHocs",
                        principalColumn: "IdCaHoc",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KHNXCaHocs_CoSos_CoSoIdCoSo",
                        column: x => x.CoSoIdCoSo,
                        principalTable: "CoSos",
                        principalColumn: "IdCoSo");
                    table.ForeignKey(
                        name: "FK_KHNXCaHocs_KeHoachNhomXuongs_IdKHNX",
                        column: x => x.IdKHNX,
                        principalTable: "KeHoachNhomXuongs",
                        principalColumn: "IdKHNX",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DiemDanhs",
                columns: table => new
                {
                    IdDiemDanh = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdSinhVien = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdCaHoc = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdNhomXuong = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdNhanVien = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiemDanhs", x => x.IdDiemDanh);
                    table.ForeignKey(
                        name: "FK_DiemDanhs_CaHocs_IdCaHoc",
                        column: x => x.IdCaHoc,
                        principalTable: "CaHocs",
                        principalColumn: "IdCaHoc",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DiemDanhs_NhomXuongs_IdNhomXuong",
                        column: x => x.IdNhomXuong,
                        principalTable: "NhomXuongs",
                        principalColumn: "IdNhomXuong",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DiemDanhs_PhuTrachXuongs_IdNhanVien",
                        column: x => x.IdNhanVien,
                        principalTable: "PhuTrachXuongs",
                        principalColumn: "IdNhanVien",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DiemDanhs_SinhViens_IdSinhVien",
                        column: x => x.IdSinhVien,
                        principalTable: "SinhViens",
                        principalColumn: "IdSinhVien",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LichGiangDays",
                columns: table => new
                {
                    IdLichDay = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdNXCH = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TTDiemDanhMuon = table.Column<bool>(type: "bit", nullable: false),
                    IdNhomXuong = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdDuAn = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdDiaDiem = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HTGiangDay = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TTDiemDanh = table.Column<bool>(type: "bit", nullable: false),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgayCapNhat = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LichGiangDays", x => x.IdLichDay);
                    table.ForeignKey(
                        name: "FK_LichGiangDays_DiaDiems_IdDiaDiem",
                        column: x => x.IdDiaDiem,
                        principalTable: "DiaDiems",
                        principalColumn: "IdDiaDiem",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LichGiangDays_DuAns_IdDuAn",
                        column: x => x.IdDuAn,
                        principalTable: "DuAns",
                        principalColumn: "IdDuAn");
                    table.ForeignKey(
                        name: "FK_LichGiangDays_KHNXCaHocs_IdNXCH",
                        column: x => x.IdNXCH,
                        principalTable: "KHNXCaHocs",
                        principalColumn: "IdNXCH",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LichGiangDays_NhomXuongs_IdNhomXuong",
                        column: x => x.IdNhomXuong,
                        principalTable: "NhomXuongs",
                        principalColumn: "IdNhomXuong",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LichHocs",
                columns: table => new
                {
                    IDLichHoc = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdNXCH = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdNhomXuong = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDHocKy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false),
                    HocKyIdHocKy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CaHocIdCaHoc = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LichHocs", x => x.IDLichHoc);
                    table.ForeignKey(
                        name: "FK_LichHocs_CaHocs_CaHocIdCaHoc",
                        column: x => x.CaHocIdCaHoc,
                        principalTable: "CaHocs",
                        principalColumn: "IdCaHoc");
                    table.ForeignKey(
                        name: "FK_LichHocs_DuAns_IDHocKy",
                        column: x => x.IDHocKy,
                        principalTable: "DuAns",
                        principalColumn: "IdDuAn",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LichHocs_KHNXCaHocs_IdNXCH",
                        column: x => x.IdNXCH,
                        principalTable: "KHNXCaHocs",
                        principalColumn: "IdNXCH",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LichHocs_NhomXuongs_IdNhomXuong",
                        column: x => x.IdNhomXuong,
                        principalTable: "NhomXuongs",
                        principalColumn: "IdNhomXuong",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LichHocs_hocKy_HocKyIdHocKy",
                        column: x => x.HocKyIdHocKy,
                        principalTable: "hocKy",
                        principalColumn: "IdHocKy",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LichSuDiemDanhs",
                columns: table => new
                {
                    IdLSDD = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdDiemDanh = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdNXCH = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ThoiGianDiemDanh = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NoiDungBuoiHoc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HinhThuc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiaDiem = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgayCapNhat = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TrangThaiDuyet = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LichSuDiemDanhs", x => x.IdLSDD);
                    table.ForeignKey(
                        name: "FK_LichSuDiemDanhs_DiemDanhs_IdDiemDanh",
                        column: x => x.IdDiemDanh,
                        principalTable: "DiemDanhs",
                        principalColumn: "IdDiemDanh",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LichSuDiemDanhs_KHNXCaHocs_IdNXCH",
                        column: x => x.IdNXCH,
                        principalTable: "KHNXCaHocs",
                        principalColumn: "IdNXCH",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BanDaoTaos_VaiTroIdVaiTro",
                table: "BanDaoTaos",
                column: "VaiTroIdVaiTro");

            migrationBuilder.CreateIndex(
                name: "IX_BoMonCoSos_CoSoIdCoSo",
                table: "BoMonCoSos",
                column: "CoSoIdCoSo");

            migrationBuilder.CreateIndex(
                name: "IX_BoMonCoSos_IdBoMon",
                table: "BoMonCoSos",
                column: "IdBoMon");

            migrationBuilder.CreateIndex(
                name: "IX_CoSos_CaHocIdCaHoc",
                table: "CoSos",
                column: "CaHocIdCaHoc");

            migrationBuilder.CreateIndex(
                name: "IX_CoSos_DiaDiemIdDiaDiem",
                table: "CoSos",
                column: "DiaDiemIdDiaDiem");

            migrationBuilder.CreateIndex(
                name: "IX_CoSos_IPIdIP",
                table: "CoSos",
                column: "IPIdIP");

            migrationBuilder.CreateIndex(
                name: "IX_DiemDanhs_IdCaHoc",
                table: "DiemDanhs",
                column: "IdCaHoc");

            migrationBuilder.CreateIndex(
                name: "IX_DiemDanhs_IdNhanVien",
                table: "DiemDanhs",
                column: "IdNhanVien");

            migrationBuilder.CreateIndex(
                name: "IX_DiemDanhs_IdNhomXuong",
                table: "DiemDanhs",
                column: "IdNhomXuong");

            migrationBuilder.CreateIndex(
                name: "IX_DiemDanhs_IdSinhVien",
                table: "DiemDanhs",
                column: "IdSinhVien");

            migrationBuilder.CreateIndex(
                name: "IX_DuAns_CapDoDuAnIdCDDA",
                table: "DuAns",
                column: "CapDoDuAnIdCDDA");

            migrationBuilder.CreateIndex(
                name: "IX_DuAns_IdBoMon",
                table: "DuAns",
                column: "IdBoMon");

            migrationBuilder.CreateIndex(
                name: "IX_DuAns_IdHocKy",
                table: "DuAns",
                column: "IdHocKy");

            migrationBuilder.CreateIndex(
                name: "IX_KeHoachNhomXuongs_IdKeHoach",
                table: "KeHoachNhomXuongs",
                column: "IdKeHoach");

            migrationBuilder.CreateIndex(
                name: "IX_KeHoachNhomXuongs_IdNhomXuong",
                table: "KeHoachNhomXuongs",
                column: "IdNhomXuong");

            migrationBuilder.CreateIndex(
                name: "IX_KeHoachs_DuAnIdDuAn",
                table: "KeHoachs",
                column: "DuAnIdDuAn");

            migrationBuilder.CreateIndex(
                name: "IX_KHNXCaHocs_CoSoIdCoSo",
                table: "KHNXCaHocs",
                column: "CoSoIdCoSo");

            migrationBuilder.CreateIndex(
                name: "IX_KHNXCaHocs_IdCaHoc",
                table: "KHNXCaHocs",
                column: "IdCaHoc");

            migrationBuilder.CreateIndex(
                name: "IX_KHNXCaHocs_IdKHNX",
                table: "KHNXCaHocs",
                column: "IdKHNX");

            migrationBuilder.CreateIndex(
                name: "IX_LichGiangDays_IdDiaDiem",
                table: "LichGiangDays",
                column: "IdDiaDiem");

            migrationBuilder.CreateIndex(
                name: "IX_LichGiangDays_IdDuAn",
                table: "LichGiangDays",
                column: "IdDuAn");

            migrationBuilder.CreateIndex(
                name: "IX_LichGiangDays_IdNhomXuong",
                table: "LichGiangDays",
                column: "IdNhomXuong");

            migrationBuilder.CreateIndex(
                name: "IX_LichGiangDays_IdNXCH",
                table: "LichGiangDays",
                column: "IdNXCH");

            migrationBuilder.CreateIndex(
                name: "IX_LichHocs_CaHocIdCaHoc",
                table: "LichHocs",
                column: "CaHocIdCaHoc");

            migrationBuilder.CreateIndex(
                name: "IX_LichHocs_HocKyIdHocKy",
                table: "LichHocs",
                column: "HocKyIdHocKy");

            migrationBuilder.CreateIndex(
                name: "IX_LichHocs_IDHocKy",
                table: "LichHocs",
                column: "IDHocKy");

            migrationBuilder.CreateIndex(
                name: "IX_LichHocs_IdNhomXuong",
                table: "LichHocs",
                column: "IdNhomXuong");

            migrationBuilder.CreateIndex(
                name: "IX_LichHocs_IdNXCH",
                table: "LichHocs",
                column: "IdNXCH");

            migrationBuilder.CreateIndex(
                name: "IX_LichSuDiemDanhs_IdDiemDanh",
                table: "LichSuDiemDanhs",
                column: "IdDiemDanh");

            migrationBuilder.CreateIndex(
                name: "IX_LichSuDiemDanhs_IdNXCH",
                table: "LichSuDiemDanhs",
                column: "IdNXCH");

            migrationBuilder.CreateIndex(
                name: "IX_NhomXuongs_DuAnIdDuAn",
                table: "NhomXuongs",
                column: "DuAnIdDuAn");

            migrationBuilder.CreateIndex(
                name: "IX_NhomXuongs_IdBoMon",
                table: "NhomXuongs",
                column: "IdBoMon");

            migrationBuilder.CreateIndex(
                name: "IX_NhomXuongs_IdPhuTrachXuong",
                table: "NhomXuongs",
                column: "IdPhuTrachXuong");

            migrationBuilder.CreateIndex(
                name: "IX_PhuTrachXuongs_IdCoSo",
                table: "PhuTrachXuongs",
                column: "IdCoSo");

            migrationBuilder.CreateIndex(
                name: "IX_SinhViens_NhomXuongIdNhomXuong",
                table: "SinhViens",
                column: "NhomXuongIdNhomXuong");

            migrationBuilder.CreateIndex(
                name: "IX_SinhViens_VaiTroIdVaiTro",
                table: "SinhViens",
                column: "VaiTroIdVaiTro");

            migrationBuilder.CreateIndex(
                name: "IX_VaiTroNhanViens_IdVaiTro",
                table: "VaiTroNhanViens",
                column: "IdVaiTro");

            migrationBuilder.CreateIndex(
                name: "IX_VaiTroNhanViens_PhuTrachXuongIdNhanVien",
                table: "VaiTroNhanViens",
                column: "PhuTrachXuongIdNhanVien");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BanDaoTaos");

            migrationBuilder.DropTable(
                name: "BoMonCoSos");

            migrationBuilder.DropTable(
                name: "LichGiangDays");

            migrationBuilder.DropTable(
                name: "LichHocs");

            migrationBuilder.DropTable(
                name: "LichSuDiemDanhs");

            migrationBuilder.DropTable(
                name: "VaiTroNhanViens");

            migrationBuilder.DropTable(
                name: "DiemDanhs");

            migrationBuilder.DropTable(
                name: "KHNXCaHocs");

            migrationBuilder.DropTable(
                name: "SinhViens");

            migrationBuilder.DropTable(
                name: "KeHoachNhomXuongs");

            migrationBuilder.DropTable(
                name: "VaiTros");

            migrationBuilder.DropTable(
                name: "KeHoachs");

            migrationBuilder.DropTable(
                name: "NhomXuongs");

            migrationBuilder.DropTable(
                name: "DuAns");

            migrationBuilder.DropTable(
                name: "PhuTrachXuongs");

            migrationBuilder.DropTable(
                name: "CapDoDuAns");

            migrationBuilder.DropTable(
                name: "QuanLyBoMons");

            migrationBuilder.DropTable(
                name: "hocKy");

            migrationBuilder.DropTable(
                name: "CoSos");

            migrationBuilder.DropTable(
                name: "CaHocs");

            migrationBuilder.DropTable(
                name: "DiaDiems");

            migrationBuilder.DropTable(
                name: "IPs");
        }
    }
}
