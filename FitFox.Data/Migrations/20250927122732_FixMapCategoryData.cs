using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FitFox.Data.Migrations
{
    /// <inheritdoc />
    public partial class FixMapCategoryData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Maps",
                keyColumn: "Id",
                keyValue: new Guid("04493112-8b84-43be-b926-5a32c5524ac2"),
                column: "MapCategory",
                value: 1);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Maps",
                keyColumn: "Id",
                keyValue: new Guid("04493112-8b84-43be-b926-5a32c5524ac2"),
                column: "MapCategory",
                value: 0);
        }
    }
}
