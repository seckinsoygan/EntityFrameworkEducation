using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCodeFirstEducation.Migrations
{
    public partial class Test9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Urunler",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Urunler_CategoryId",
                table: "Urunler",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Urunler_Kategoriler_CategoryId",
                table: "Urunler",
                column: "CategoryId",
                principalTable: "Kategoriler",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Urunler_Kategoriler_CategoryId",
                table: "Urunler");

            migrationBuilder.DropIndex(
                name: "IX_Urunler_CategoryId",
                table: "Urunler");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Urunler");
        }
    }
}
