using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PSIUWeb.Migrations
{
    public partial class deleteenumtipomidia : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TypeMidia",
                table: "Midias");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TypeMidia",
                table: "Midias",
                type: "int",
                nullable: true);
        }
    }
}
