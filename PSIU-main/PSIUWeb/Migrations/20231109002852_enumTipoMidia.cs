using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PSIUWeb.Migrations
{
    public partial class enumTipoMidia : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TypeMidia",
                table: "Midias",
                type: "int",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TypeMidia",
                table: "Midias");
        }
    }
}
