using Microsoft.EntityFrameworkCore.Migrations;

namespace Database.Migrations
{
    public partial class M2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PauseTime",
                table: "Workers");

            migrationBuilder.DropColumn(
                name: "WorkingTime",
                table: "Workers");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PauseTime",
                table: "Workers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "WorkingTime",
                table: "Workers",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
