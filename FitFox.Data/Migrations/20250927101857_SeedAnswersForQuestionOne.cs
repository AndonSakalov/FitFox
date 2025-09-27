using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FitFox.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedAnswersForQuestionOne : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "IsDeleted", "QuestionId", "Text" },
                values: new object[,]
                {
                    { new Guid("6f682b25-0953-45bc-b4aa-3f77c44f0abd"), false, new Guid("65e73cd9-dec1-4e46-8342-69b204c6b226"), "Fiber, Antioxidants, Enzymes" },
                    { new Guid("754eb19b-0e7b-4f1f-aa8b-214b0c9e4ca1"), false, new Guid("65e73cd9-dec1-4e46-8342-69b204c6b226"), "Vitamin C, Vitamin D, Vitamin E" },
                    { new Guid("995bd8c0-98e5-441b-96f2-046c4e732022"), false, new Guid("65e73cd9-dec1-4e46-8342-69b204c6b226"), "Protein, Fats, Carbohydrates" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("6f682b25-0953-45bc-b4aa-3f77c44f0abd"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("754eb19b-0e7b-4f1f-aa8b-214b0c9e4ca1"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("995bd8c0-98e5-441b-96f2-046c4e732022"));
        }
    }
}
