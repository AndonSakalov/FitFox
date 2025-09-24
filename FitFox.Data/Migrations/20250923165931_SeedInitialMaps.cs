using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FitFox.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedInitialMaps : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: new Guid("7b2d7ecd-cb91-4ac1-9fd8-10b5de7b35ad"));

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Maps",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "",
                comment: "The description of the map.");

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Maps",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                comment: "The display name of the map.");

            migrationBuilder.InsertData(
                table: "Levels",
                columns: new[] { "Id", "IsDeleted", "LevelNumber", "LevelTitle", "RequiredXP" },
                values: new object[] { new Guid("11111111-1111-1111-1111-111111111111"), false, 1, "Newbie", 0 });

            migrationBuilder.InsertData(
                table: "Maps",
                columns: new[] { "Id", "Description", "IsDeleted", "MapCategory", "Title" },
                values: new object[,]
                {
                    { new Guid("04493112-8b84-43be-b926-5a32c5524ac2"), "The basics of nutrition focused on gym progression.", false, 0, "Nutrition" },
                    { new Guid("1afe12ea-606d-49d0-adb9-5f8311d86618"), "The basics of training with weights.", false, 0, "Training" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"));

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumn: "Id",
                keyValue: new Guid("04493112-8b84-43be-b926-5a32c5524ac2"));

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumn: "Id",
                keyValue: new Guid("1afe12ea-606d-49d0-adb9-5f8311d86618"));

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Maps");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Maps");

            migrationBuilder.InsertData(
                table: "Levels",
                columns: new[] { "Id", "IsDeleted", "LevelNumber", "LevelTitle", "RequiredXP" },
                values: new object[] { new Guid("7b2d7ecd-cb91-4ac1-9fd8-10b5de7b35ad"), false, 1, "Newbie", 0 });
        }
    }
}
