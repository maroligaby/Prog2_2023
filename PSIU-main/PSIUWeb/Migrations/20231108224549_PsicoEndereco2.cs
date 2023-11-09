using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PSIUWeb.Migrations
{
    public partial class PsicoEndereco2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
               name: "Endereco",
               table: "Psicos",
               type: "nvarchar(max)",
               nullable: true,
               defaultValue: "");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Endereco",
                table: "Psicos");

        }
    }
}
