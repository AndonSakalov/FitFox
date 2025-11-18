using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FitFox.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddCoveragePercentInUserMapModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PercentCovered",
                table: "UsersMaps",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PercentCovered",
                table: "UsersMaps");
        }
    }
}
