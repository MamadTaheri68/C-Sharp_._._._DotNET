using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCore_TestProject.Migrations
{
    public partial class DiscountRateAddedToProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DiscountRate",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DiscountRate",
                table: "Products");
        }
    }
}
