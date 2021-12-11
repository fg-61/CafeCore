using Microsoft.EntityFrameworkCore.Migrations;

namespace CafeCore.Migrations
{
    public partial class v209 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "AraToplam",
                table: "Siparisler",
                type: "decimal(11,2)",
                precision: 11,
                scale: 2,
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AraToplam",
                table: "Siparisler");
        }
    }
}
