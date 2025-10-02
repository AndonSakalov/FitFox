using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FitFox.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedAnswersForQuestionsOfLessonTwo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "IsDeleted", "QuestionId", "Text" },
                values: new object[,]
                {
                    { new Guid("04ff28e3-1c76-43fb-9f2e-50dc89d4574d"), false, new Guid("725ac1b4-5362-484a-964a-4a1bc95a2aab"), "5 grams" },
                    { new Guid("0f9d15b7-8b2f-4df7-8613-93d80d3d3c34"), false, new Guid("ab0fda0c-dca4-4b12-a690-8e1b311ee5de"), "Carbohydrates" },
                    { new Guid("3a5ef8a4-68ae-464a-8e93-7c4d8b1f1a5a"), false, new Guid("c3dc5b10-c49e-4c55-82bf-19588f1ce0a4"), "Carbohydrates" },
                    { new Guid("3c3fd6c5-5c2d-4ef4-b2a3-fdf7f4d7dc94"), false, new Guid("725ac1b4-5362-484a-964a-4a1bc95a2aab"), "1.7–2.5 grams" },
                    { new Guid("6c44c89a-c257-4cd5-8653-c3f523b42f15"), false, new Guid("c3dc5b10-c49e-4c55-82bf-19588f1ce0a4"), "Proteins" },
                    { new Guid("8f960e0f-3f31-4f12-abe7-8e055fba26b0"), false, new Guid("ab0fda0c-dca4-4b12-a690-8e1b311ee5de"), "Fats" },
                    { new Guid("aa5d6f8b-2d44-4f0e-bd35-5e1c9d4b2f9e"), false, new Guid("b4baf54c-59b6-4b9d-91d9-7e3352b5d3ee"), "Carbohydrates" },
                    { new Guid("ac0270a6-9dc2-4c4c-9e40-16ac51137b34"), false, new Guid("c3dc5b10-c49e-4c55-82bf-19588f1ce0a4"), "Fats" },
                    { new Guid("c145af32-bb34-4c58-8f6a-63b59ad2e497"), false, new Guid("ab0fda0c-dca4-4b12-a690-8e1b311ee5de"), "Proteins" },
                    { new Guid("d1f64c0a-7d32-466b-94ae-2b0a1f7d1f3f"), false, new Guid("b4baf54c-59b6-4b9d-91d9-7e3352b5d3ee"), "Proteins" },
                    { new Guid("f3c7b58d-8fbb-4d6e-b2f5-3e6f2d9a7b21"), false, new Guid("b4baf54c-59b6-4b9d-91d9-7e3352b5d3ee"), "Fats" },
                    { new Guid("f52e1b3e-4f48-4d48-9880-3ecfcf4cc91f"), false, new Guid("725ac1b4-5362-484a-964a-4a1bc95a2aab"), "0.5 grams" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("04ff28e3-1c76-43fb-9f2e-50dc89d4574d"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("0f9d15b7-8b2f-4df7-8613-93d80d3d3c34"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("3a5ef8a4-68ae-464a-8e93-7c4d8b1f1a5a"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("3c3fd6c5-5c2d-4ef4-b2a3-fdf7f4d7dc94"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("6c44c89a-c257-4cd5-8653-c3f523b42f15"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("8f960e0f-3f31-4f12-abe7-8e055fba26b0"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("aa5d6f8b-2d44-4f0e-bd35-5e1c9d4b2f9e"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("ac0270a6-9dc2-4c4c-9e40-16ac51137b34"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("c145af32-bb34-4c58-8f6a-63b59ad2e497"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("d1f64c0a-7d32-466b-94ae-2b0a1f7d1f3f"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("f3c7b58d-8fbb-4d6e-b2f5-3e6f2d9a7b21"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("f52e1b3e-4f48-4d48-9880-3ecfcf4cc91f"));
        }
    }
}
