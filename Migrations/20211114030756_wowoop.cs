using Microsoft.EntityFrameworkCore.Migrations;

namespace Final.Migrations
{
    public partial class wowoop : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MovieChoice",
                table: "FinalModel",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MovieChoice",
                table: "FinalModel");
        }
    }
}
