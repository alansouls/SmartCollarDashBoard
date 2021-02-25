using Microsoft.EntityFrameworkCore.Migrations;

namespace SmartCollar.Data.Migrations
{
    public partial class FixEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "WasAnAttack",
                table: "UserNotification",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "WasAnAttack",
                table: "UserNotification",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool));
        }
    }
}
