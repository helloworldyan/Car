using Microsoft.EntityFrameworkCore.Migrations;

namespace Sample01.Migrations
{
    public partial class ModifyCity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "LastName2",
                table: "Student",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LastName2",
                table: "Student");
        }
    }
}
