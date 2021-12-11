using Microsoft.EntityFrameworkCore.Migrations;

namespace CafeCore.Migrations
{
    public partial class deneme : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SiparisId",
                table: "Urunler",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Urunler_SiparisId",
                table: "Urunler",
                column: "SiparisId");

            migrationBuilder.AddForeignKey(
                name: "FK_Urunler_Siparisler_SiparisId",
                table: "Urunler",
                column: "SiparisId",
                principalTable: "Siparisler",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Urunler_Siparisler_SiparisId",
                table: "Urunler");

            migrationBuilder.DropIndex(
                name: "IX_Urunler_SiparisId",
                table: "Urunler");

            migrationBuilder.DropColumn(
                name: "SiparisId",
                table: "Urunler");
        }
    }
}
