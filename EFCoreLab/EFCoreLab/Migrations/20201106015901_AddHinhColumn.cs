using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCoreLab.Migrations
{
    public partial class AddHinhColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Hinh",
                table: "HangHoa",
                maxLength: 150,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Hinh",
                table: "HangHoa");
        }
    }
}
