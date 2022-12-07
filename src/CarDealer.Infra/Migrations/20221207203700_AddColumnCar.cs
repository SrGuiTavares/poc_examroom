using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarDealer.Infra.Migrations
{
    public partial class AddColumnCar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Imagem",
                table: "Cars",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Imagem",
                table: "Cars");
        }
    }
}
