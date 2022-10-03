using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCodeFirstEducation.Migrations
{
    public partial class Test8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Total",
                table: "Kategoriler",
                type: "decimal(5,2)",
                precision: 5,
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Total",
                table: "Kategoriler");
        }
    }
}
