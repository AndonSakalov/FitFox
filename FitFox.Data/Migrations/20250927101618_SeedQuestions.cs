using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FitFox.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedQuestions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "CorrectAnswerId", "IsDeleted", "LessonId", "Text" },
                values: new object[,]
                {
                    { new Guid("65e73cd9-dec1-4e46-8342-69b204c6b226"), null, false, new Guid("26a98b9c-2a98-4714-8d28-99f6ed419834"), "Which are the 3 macronutrients?" },
                    { new Guid("83fc33fc-0db2-4695-a950-c494eb58a73c"), null, false, new Guid("26a98b9c-2a98-4714-8d28-99f6ed419834"), "How many calories does 1 gram of fat contain?" },
                    { new Guid("a8d6e1f2-5c33-4a0b-8cde-7e2f1a9b3d45"), null, false, new Guid("26a98b9c-2a98-4714-8d28-99f6ed419834"), "Which macronutrient regulates hormone production?" },
                    { new Guid("c1f2b3e4-7d8a-4e5b-b2c3-9f0a1d2e3b56"), null, false, new Guid("26a98b9c-2a98-4714-8d28-99f6ed419834"), "Which macronutrient is the main source of energy for the body?" },
                    { new Guid("c46cf154-ee4c-4c5d-ac35-4b4cf69639ce"), null, false, new Guid("26a98b9c-2a98-4714-8d28-99f6ed419834"), "How many calories does 1 gram of protein contain?" },
                    { new Guid("d4e5f6a7-8b9c-4d0e-9f1a-2b3c4d5e6f78"), null, false, new Guid("26a98b9c-2a98-4714-8d28-99f6ed419834"), "Which nutrient is primarily used for muscle repair?" },
                    { new Guid("e58fca52-c2da-44a4-b62f-9bd9bd7bb583"), null, false, new Guid("26a98b9c-2a98-4714-8d28-99f6ed419834"), "How many calories does 1 gram of carbohydrates contain?" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("65e73cd9-dec1-4e46-8342-69b204c6b226"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("83fc33fc-0db2-4695-a950-c494eb58a73c"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("a8d6e1f2-5c33-4a0b-8cde-7e2f1a9b3d45"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("c1f2b3e4-7d8a-4e5b-b2c3-9f0a1d2e3b56"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("c46cf154-ee4c-4c5d-ac35-4b4cf69639ce"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("d4e5f6a7-8b9c-4d0e-9f1a-2b3c4d5e6f78"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("e58fca52-c2da-44a4-b62f-9bd9bd7bb583"));
        }
    }
}
