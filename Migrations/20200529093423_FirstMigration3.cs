using Microsoft.EntityFrameworkCore.Migrations;

namespace MyBlazor.Migrations
{
    public partial class FirstMigration3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TestSurroundings",
                table: "Certificate",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TestSurroundings",
                table: "Certificate");
        }
    }
}
