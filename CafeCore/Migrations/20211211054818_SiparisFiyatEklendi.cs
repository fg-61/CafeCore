using Microsoft.EntityFrameworkCore.Migrations;

namespace CafeCore.Migrations
{
    public partial class SiparisFiyatEklendi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Fiyat",
                table: "Siparisler",
                type: "decimal(8,2)",
                precision: 8,
                scale: 2,
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Fiyat",
                table: "Siparisler");
        }
    }
}
