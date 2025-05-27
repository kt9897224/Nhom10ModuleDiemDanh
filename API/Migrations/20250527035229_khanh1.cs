﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class khanh1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BanDaoTaos_VaiTros_VaiTroIdVaiTro",
                table: "BanDaoTaos");

            migrationBuilder.AlterColumn<Guid>(
                name: "VaiTroIdVaiTro",
                table: "BanDaoTaos",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddForeignKey(
                name: "FK_BanDaoTaos_VaiTros_VaiTroIdVaiTro",
                table: "BanDaoTaos",
                column: "VaiTroIdVaiTro",
                principalTable: "VaiTros",
                principalColumn: "IdVaiTro");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BanDaoTaos_VaiTros_VaiTroIdVaiTro",
                table: "BanDaoTaos");

            migrationBuilder.AlterColumn<Guid>(
                name: "VaiTroIdVaiTro",
                table: "BanDaoTaos",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_BanDaoTaos_VaiTros_VaiTroIdVaiTro",
                table: "BanDaoTaos",
                column: "VaiTroIdVaiTro",
                principalTable: "VaiTros",
                principalColumn: "IdVaiTro",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
