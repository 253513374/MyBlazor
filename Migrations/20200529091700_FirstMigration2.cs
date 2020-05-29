using Microsoft.EntityFrameworkCore.Migrations;

namespace MyBlazor.Migrations
{
    public partial class FirstMigration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ReprotFileMatching",
                table: "Certificate",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ReprotFileMatching",
                table: "Certificate");
        }
    }
}
