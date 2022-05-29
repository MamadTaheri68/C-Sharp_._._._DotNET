using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlinesShop.Infrastructure.Migrations
{
    public partial class update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Titleeeeee",
                table: "ASO_*_Products",
                newName: "Titl20222");

            migrationBuilder.AlterColumn<string>(
                name: "Titl20222",
                table: "ASO_*_Products",
                type: "nvarchar(199)",
                maxLength: 199,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Titl20222",
                table: "ASO_*_Products",
                newName: "Titleeeeee");

            migrationBuilder.AlterColumn<string>(
                name: "Titleeeeee",
                table: "ASO_*_Products",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(199)",
                oldMaxLength: 199);
        }
    }
}
