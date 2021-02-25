using Microsoft.EntityFrameworkCore.Migrations;

namespace SmartCollar.Data.Migrations
{
    public partial class MobileUserName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "MobileUser",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "MobileUser");
        }
    }
}
