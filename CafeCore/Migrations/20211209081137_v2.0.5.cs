using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CafeCore.Migrations
{
    public partial class v205 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedDate",
                table: "Urunler",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Urunler",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedDate",
                table: "Siparisler",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Siparisler",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedDate",
                table: "Masalar",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Masalar",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedDate",
                table: "Katlar",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Katlar",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedDate",
                table: "Kategoriler",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Kategoriler",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DeletedDate",
                table: "Urunler");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Urunler");

            migrationBuilder.DropColumn(
                name: "DeletedDate",
                table: "Siparisler");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Siparisler");

            migrationBuilder.DropColumn(
                name: "DeletedDate",
                table: "Masalar");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Masalar");

            migrationBuilder.DropColumn(
                name: "DeletedDate",
                table: "Katlar");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Katlar");

            migrationBuilder.DropColumn(
                name: "DeletedDate",
                table: "Kategoriler");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Kategoriler");
        }
    }
}
