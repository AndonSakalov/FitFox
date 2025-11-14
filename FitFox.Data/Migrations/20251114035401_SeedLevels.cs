using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FitFox.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedLevels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Levels",
                columns: new[] { "Id", "IsDeleted", "LevelNumber", "LevelTitle", "RequiredXP" },
                values: new object[,]
                {
                    { new Guid("3f8d2c64-7a41-4d8e-9a3d-0c5b2c9e8f11"), false, 2, "Newbie", 300 },
                    { new Guid("52a0df49-868e-4f6e-9b73-1e3c0a44e91f"), false, 7, "Beginner", 300 },
                    { new Guid("6a5f3e11-8fd1-4b62-91d9-5c3dcd73f8c2"), false, 10, "Skilled Novice", 300 },
                    { new Guid("81cce7d4-b7b2-4a22-9364-9daccf28a6ba"), false, 8, "Beginner", 300 },
                    { new Guid("9d2c4e8f-3af1-41c7-8fab-7b1c9e72aa90"), false, 5, "Beginner", 300 },
                    { new Guid("a74b2fa1-0e9c-4c88-b1d2-1510e754ad55"), false, 4, "Newbie", 300 },
                    { new Guid("c1a4b9d7-5e32-4893-9f6f-2a7d23b0e4d2"), false, 3, "Newbie", 300 },
                    { new Guid("e3b69c2a-2f80-4d6d-9b1e-dbc7d257c89b"), false, 9, "Beginner", 300 },
                    { new Guid("f0b8d6c1-4ec3-4c99-92fb-41e1bfb83b3a"), false, 6, "Beginner", 300 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: new Guid("3f8d2c64-7a41-4d8e-9a3d-0c5b2c9e8f11"));

            migrationBuilder.DeleteData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: new Guid("52a0df49-868e-4f6e-9b73-1e3c0a44e91f"));

            migrationBuilder.DeleteData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: new Guid("6a5f3e11-8fd1-4b62-91d9-5c3dcd73f8c2"));

            migrationBuilder.DeleteData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: new Guid("81cce7d4-b7b2-4a22-9364-9daccf28a6ba"));

            migrationBuilder.DeleteData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: new Guid("9d2c4e8f-3af1-41c7-8fab-7b1c9e72aa90"));

            migrationBuilder.DeleteData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: new Guid("a74b2fa1-0e9c-4c88-b1d2-1510e754ad55"));

            migrationBuilder.DeleteData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: new Guid("c1a4b9d7-5e32-4893-9f6f-2a7d23b0e4d2"));

            migrationBuilder.DeleteData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: new Guid("e3b69c2a-2f80-4d6d-9b1e-dbc7d257c89b"));

            migrationBuilder.DeleteData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: new Guid("f0b8d6c1-4ec3-4c99-92fb-41e1bfb83b3a"));
        }
    }
}
