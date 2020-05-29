using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyBlazor.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Certificate",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Guid = table.Column<string>(nullable: true),
                    TD = table.Column<string>(nullable: true),
                    ToTD = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Numbel = table.Column<string>(nullable: true),
                    TestDateTime = table.Column<DateTime>(nullable: false),
                    VNextTestDateTime = table.Column<DateTime>(nullable: false),
                    Manufacturer = table.Column<string>(nullable: true),
                    TestPersonnel = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Certificate", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ProductManage",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductCreateTime = table.Column<DateTime>(nullable: false),
                    ProductName = table.Column<string>(nullable: true),
                    ProductNumber = table.Column<string>(nullable: true),
                    ProductSupplier = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductManage", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Certificate");

            migrationBuilder.DropTable(
                name: "ProductManage");
        }
    }
}
