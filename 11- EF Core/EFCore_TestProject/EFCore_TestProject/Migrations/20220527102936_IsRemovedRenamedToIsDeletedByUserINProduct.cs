using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCore_TestProject.Migrations
{
    public partial class IsRemovedRenamedToIsDeletedByUserINProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsRemoved",
                table: "Products",
                newName: "IsDeletedByUser");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsDeletedByUser",
                table: "Products",
                newName: "IsRemoved");
        }
    }
}
