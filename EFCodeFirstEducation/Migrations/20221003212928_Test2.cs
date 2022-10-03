using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCodeFirstEducation.Migrations
{
    public partial class Test2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "Seckins",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Tel",
                table: "Seckins",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Age",
                table: "Seckins");

            migrationBuilder.DropColumn(
                name: "Tel",
                table: "Seckins");
        }
    }
}
