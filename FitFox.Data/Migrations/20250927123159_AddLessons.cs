using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FitFox.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddLessons : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "Id", "IsDeleted", "MapId", "OrderNumber", "Title", "XP" },
                values: new object[,]
                {
                    { new Guid("0491fb6d-5264-4beb-88e6-a247489c4825"), false, new Guid("04493112-8b84-43be-b926-5a32c5524ac2"), 4, "Micronutrients", 100 },
                    { new Guid("77c74f8c-a3ef-4cb8-8a2c-b71ca6ecd33e"), false, new Guid("04493112-8b84-43be-b926-5a32c5524ac2"), 3, "Protein Quality and Timing", 100 },
                    { new Guid("7e065ddc-a469-4bbe-b205-113c3d96f4c5"), false, new Guid("1afe12ea-606d-49d0-adb9-5f8311d86618"), 5, "Recovery and Rest", 100 },
                    { new Guid("81476c31-4e91-41d5-b37e-422e97b5882e"), false, new Guid("1afe12ea-606d-49d0-adb9-5f8311d86618"), 4, "Compound vs Isolation Movements", 100 },
                    { new Guid("8e10a739-c7a9-4c9e-887c-b2599be94f3a"), false, new Guid("1afe12ea-606d-49d0-adb9-5f8311d86618"), 3, "Training Splits and Frequency", 100 },
                    { new Guid("97300d33-6cc5-48ba-b495-ff21d5b16419"), false, new Guid("04493112-8b84-43be-b926-5a32c5524ac2"), 2, "Macronutrient Ratios", 100 },
                    { new Guid("98479667-cd5b-4953-a442-de348acda994"), false, new Guid("04493112-8b84-43be-b926-5a32c5524ac2"), 5, "Hydration and Electrolytes", 100 },
                    { new Guid("b1adc18d-8c55-4a74-8bf6-a9a2943fd9e7"), false, new Guid("1afe12ea-606d-49d0-adb9-5f8311d86618"), 1, "Benefits of Resistance Training", 100 },
                    { new Guid("cde73646-a8fb-4131-9308-8269ea662c54"), false, new Guid("1afe12ea-606d-49d0-adb9-5f8311d86618"), 2, "Exercises and Muscles Targeted", 100 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("0491fb6d-5264-4beb-88e6-a247489c4825"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("77c74f8c-a3ef-4cb8-8a2c-b71ca6ecd33e"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("7e065ddc-a469-4bbe-b205-113c3d96f4c5"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("81476c31-4e91-41d5-b37e-422e97b5882e"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("8e10a739-c7a9-4c9e-887c-b2599be94f3a"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("97300d33-6cc5-48ba-b495-ff21d5b16419"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("98479667-cd5b-4953-a442-de348acda994"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("b1adc18d-8c55-4a74-8bf6-a9a2943fd9e7"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("cde73646-a8fb-4131-9308-8269ea662c54"));
        }
    }
}
