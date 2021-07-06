using Microsoft.EntityFrameworkCore.Migrations;

namespace Camp.DataAccess.Migrations
{
    public partial class initialize4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "Logins",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserName",
                table: "Logins");
        }
    }
}
