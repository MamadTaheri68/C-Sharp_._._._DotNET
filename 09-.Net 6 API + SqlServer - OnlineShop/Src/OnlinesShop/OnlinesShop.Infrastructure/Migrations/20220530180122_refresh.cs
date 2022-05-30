using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlinesShop.Infrastructure.Migrations
{
    public partial class refresh : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ASO_Customers",
                schema: "ASO_BASE");

            migrationBuilder.DropTable(
                name: "ASO_Employees",
                schema: "ASO_BASE");

            migrationBuilder.DropTable(
                name: "ASO_Suppliers",
                schema: "ASO_BASE");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ASO_*_Products",
                table: "ASO_*_Products");

            migrationBuilder.RenameTable(
                name: "ASO_*_Products",
                newName: "Products");

            migrationBuilder.RenameColumn(
                name: "Titl20222",
                table: "Products",
                newName: "Title");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Products",
                type: "nvarchar(123)",
                maxLength: 123,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(199)",
                oldMaxLength: 199);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Products",
                table: "Products",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Products",
                table: "Products");

            migrationBuilder.EnsureSchema(
                name: "ASO_BASE");

            migrationBuilder.RenameTable(
                name: "Products",
                newName: "ASO_*_Products");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "ASO_*_Products",
                newName: "Titl20222");

            migrationBuilder.AlterColumn<string>(
                name: "Titl20222",
                table: "ASO_*_Products",
                type: "nvarchar(199)",
                maxLength: 199,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(123)",
                oldMaxLength: 123);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ASO_*_Products",
                table: "ASO_*_Products",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "ASO_Customers",
                schema: "ASO_BASE",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CustomerUniqueGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    SSN = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ASO_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ASO_Employees",
                schema: "ASO_BASE",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    JobTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    SSN = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ASO_Employees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ASO_Suppliers",
                schema: "ASO_BASE",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    InventoryName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    SSN = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ASO_Suppliers", x => x.Id);
                });
        }
    }
}
