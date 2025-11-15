using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FitFox.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedAchievements : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Achievements",
                columns: new[] { "Id", "ConditionType", "ConditionValue", "Description", "IconUrl", "IsDeleted", "Title" },
                values: new object[,]
                {
                    { new Guid("17e94d55-2c88-4a63-bc41-6e7fb922e3c1"), 1, 100, "Cover 100% of map's lessons.", "FitFox/wwwroot/images/No_Image_Available.jpg", false, "Workout done!" },
                    { new Guid("2f0cc148-2fa5-4f04-bfc6-0e3d139a9f52"), 1, 2, "Pass two maps.", "FitFox/wwwroot/images/No_Image_Available.jpg", false, "Strong and lean? Oh boy.." },
                    { new Guid("4c1f8a22-7e0b-4c13-bc38-2f4b9f7a1d90"), 0, 1, "Solve one lesson with a perfect score.", "FitFox/wwwroot/images/No_Image_Available.jpg", false, "Getting started!" },
                    { new Guid("623fa9e8-0b67-4c20-b862-f2d240679cb1"), 2, 5, "Getting strong!", "FitFox/wwwroot/images/No_Image_Available.jpg", false, "Getting strong!" },
                    { new Guid("94c5d27e-8ee4-4fc4-a9df-36bcfb85ea48"), 0, 5, "Solve five lessons with a perfect score.", "FitFox/wwwroot/images/No_Image_Available.jpg", false, "Smart and strong? Unbreakable!" },
                    { new Guid("af2d9e71-3b54-4c8c-a8c5-9e2f38d12a44"), 1, 50, "Cover 50% of map's lessons.", "FitFox/wwwroot/images/No_Image_Available.jpg", false, "One more set to go!" },
                    { new Guid("b28e13d4-6cb9-4ad1-9869-eaf0c1870ec3"), 2, 10, "Pass ten daily quests.", "FitFox/wwwroot/images/No_Image_Available.jpg", false, "Consistency is the key!" },
                    { new Guid("cd4a6277-0f39-4b24-b86c-167ccc0a5b61"), 3, 5, "Reach level five", "FitFox/wwwroot/images/No_Image_Available.jpg", false, "Trust the grind!" },
                    { new Guid("d8b0309a-bc74-4fa8-bb13-0f1c3c9e5a22"), 2, 1, "Pass your first daily quest.", "FitFox/wwwroot/images/No_Image_Available.jpg", false, "Additional gains!" },
                    { new Guid("f6b7903a-41e0-4753-9ad0-d8ac584c5c6f"), 0, 10, "Solve ten lessons with a perfect score.", "FitFox/wwwroot/images/No_Image_Available.jpg", false, "Leave some knowledge for the rest of us!" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("17e94d55-2c88-4a63-bc41-6e7fb922e3c1"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("2f0cc148-2fa5-4f04-bfc6-0e3d139a9f52"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("4c1f8a22-7e0b-4c13-bc38-2f4b9f7a1d90"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("623fa9e8-0b67-4c20-b862-f2d240679cb1"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("94c5d27e-8ee4-4fc4-a9df-36bcfb85ea48"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("af2d9e71-3b54-4c8c-a8c5-9e2f38d12a44"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("b28e13d4-6cb9-4ad1-9869-eaf0c1870ec3"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("cd4a6277-0f39-4b24-b86c-167ccc0a5b61"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("d8b0309a-bc74-4fa8-bb13-0f1c3c9e5a22"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("f6b7903a-41e0-4753-9ad0-d8ac584c5c6f"));
        }
    }
}
