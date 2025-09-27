using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FitFox.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedAnswersForQuestionsInLessonOne : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "IsDeleted", "QuestionId", "Text" },
                values: new object[,]
                {
                    { new Guid("076d322b-61a0-4617-b7c7-adcfcd0e4a64"), false, new Guid("c1f2b3e4-7d8a-4e5b-b2c3-9f0a1d2e3b56"), "Protein" },
                    { new Guid("0b5e5a13-fa78-4329-9e1e-704b4e34c50a"), false, new Guid("83fc33fc-0db2-4695-a950-c494eb58a73c"), "6" },
                    { new Guid("5635556a-dc6d-4a95-a804-a353787f29ac"), false, new Guid("a8d6e1f2-5c33-4a0b-8cde-7e2f1a9b3d45"), "Protein" },
                    { new Guid("5b2e033a-3b69-42df-9b10-ac04fefbc4bd"), false, new Guid("83fc33fc-0db2-4695-a950-c494eb58a73c"), "9" },
                    { new Guid("5f018738-98c2-45c8-91a8-4048ec7550ea"), false, new Guid("a8d6e1f2-5c33-4a0b-8cde-7e2f1a9b3d45"), "Carbohydrates" },
                    { new Guid("84aa5695-c7af-4620-bb4e-fa860502744e"), false, new Guid("83fc33fc-0db2-4695-a950-c494eb58a73c"), "4" },
                    { new Guid("8a153745-ee3c-4fcb-b4cb-e73590bd90e3"), false, new Guid("e58fca52-c2da-44a4-b62f-9bd9bd7bb583"), "9" },
                    { new Guid("971018fd-870c-4834-b53e-9db728272f58"), false, new Guid("c1f2b3e4-7d8a-4e5b-b2c3-9f0a1d2e3b56"), "Carbohydrates" },
                    { new Guid("995c9a90-88fe-4fd2-8762-e3d46c2ea813"), false, new Guid("c46cf154-ee4c-4c5d-ac35-4b4cf69639ce"), "2" },
                    { new Guid("a2845dd5-e2c0-4c39-87dd-255e08156b89"), false, new Guid("c46cf154-ee4c-4c5d-ac35-4b4cf69639ce"), "9" },
                    { new Guid("ad15d6de-bc27-4f9c-925f-6efe5023521b"), false, new Guid("a8d6e1f2-5c33-4a0b-8cde-7e2f1a9b3d45"), "Fats" },
                    { new Guid("b052eb19-2983-4845-9e63-9cb44b67c5f1"), false, new Guid("d4e5f6a7-8b9c-4d0e-9f1a-2b3c4d5e6f78"), "Fats" },
                    { new Guid("b975ac50-9a54-4c2e-b36b-d57520da15b3"), false, new Guid("d4e5f6a7-8b9c-4d0e-9f1a-2b3c4d5e6f78"), "Carbohydrates" },
                    { new Guid("bc272712-432e-4429-bbc0-c489ff3f0380"), false, new Guid("e58fca52-c2da-44a4-b62f-9bd9bd7bb583"), "5" },
                    { new Guid("cd72868e-1d3c-40e2-99d2-9be1c6482f07"), false, new Guid("d4e5f6a7-8b9c-4d0e-9f1a-2b3c4d5e6f78"), "Protein" },
                    { new Guid("e00f1bae-9e02-4afb-871f-23a1a3a9884f"), false, new Guid("e58fca52-c2da-44a4-b62f-9bd9bd7bb583"), "4" },
                    { new Guid("fc67a38b-6748-4df0-bdec-64ae01dce087"), false, new Guid("c1f2b3e4-7d8a-4e5b-b2c3-9f0a1d2e3b56"), "Fats" },
                    { new Guid("fe9167a4-2f11-4875-899d-83c9d4b031b7"), false, new Guid("c46cf154-ee4c-4c5d-ac35-4b4cf69639ce"), "4" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("076d322b-61a0-4617-b7c7-adcfcd0e4a64"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("0b5e5a13-fa78-4329-9e1e-704b4e34c50a"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("5635556a-dc6d-4a95-a804-a353787f29ac"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("5b2e033a-3b69-42df-9b10-ac04fefbc4bd"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("5f018738-98c2-45c8-91a8-4048ec7550ea"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("84aa5695-c7af-4620-bb4e-fa860502744e"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("8a153745-ee3c-4fcb-b4cb-e73590bd90e3"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("971018fd-870c-4834-b53e-9db728272f58"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("995c9a90-88fe-4fd2-8762-e3d46c2ea813"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("a2845dd5-e2c0-4c39-87dd-255e08156b89"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("ad15d6de-bc27-4f9c-925f-6efe5023521b"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("b052eb19-2983-4845-9e63-9cb44b67c5f1"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("b975ac50-9a54-4c2e-b36b-d57520da15b3"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("bc272712-432e-4429-bbc0-c489ff3f0380"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("cd72868e-1d3c-40e2-99d2-9be1c6482f07"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("e00f1bae-9e02-4afb-871f-23a1a3a9884f"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("fc67a38b-6748-4df0-bdec-64ae01dce087"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("fe9167a4-2f11-4875-899d-83c9d4b031b7"));
        }
    }
}
