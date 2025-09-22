using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FitFox.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedLevel1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Levels",
                columns: new[] { "Id", "IsDeleted", "LevelNumber", "LevelTitle", "RequiredXP" },
                values: new object[] { new Guid("7b2d7ecd-cb91-4ac1-9fd8-10b5de7b35ad"), false, 1, "Newbie", 0 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: new Guid("7b2d7ecd-cb91-4ac1-9fd8-10b5de7b35ad"));
        }
    }
}
