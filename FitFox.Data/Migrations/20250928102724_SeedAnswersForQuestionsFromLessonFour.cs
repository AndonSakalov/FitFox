using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FitFox.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedAnswersForQuestionsFromLessonFour : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "IsDeleted", "QuestionId", "Text" },
                values: new object[,]
                {
                    { new Guid("a2b3c4d5-6f7e-4d8a-8c5d-8f9a0b1c2d3e"), false, new Guid("34c91eb1-1e3b-4f7b-bf02-8b9f34653023"), "Soy protein" },
                    { new Guid("a8b9c0d1-2e3f-4d4a-8c1d-4f5a6b7c8d9e"), false, new Guid("ddbf95d6-d691-48e2-8c7d-6ce2150e3ac5"), "Increase fat intake" },
                    { new Guid("b3c4d5e6-7f8a-4d9b-9d6e-9a0b1c2d3e4f"), false, new Guid("cb1eb27c-eb7a-49f1-bf83-5b89a8dca794"), "Before sleep" },
                    { new Guid("b7c8d9e0-1a2b-4c3d-9f4e-3a5b6c7d8e9f"), false, new Guid("b850b9da-babb-465e-96b4-99639f04711e"), "Immediately post-workout" },
                    { new Guid("c3b1f8a4-2d7e-4b9c-9a1f-0b6d3e5f7a1b"), false, new Guid("e74d6670-97b6-42c9-8464-881dbb6bfa9d"), "Eggs" },
                    { new Guid("c4d5e6f7-8a9b-4d0c-8e7f-0b1c2d3e4f5a"), false, new Guid("cb1eb27c-eb7a-49f1-bf83-5b89a8dca794"), "Immediately post-workout" },
                    { new Guid("c8d9e0f1-2b3c-4d5e-8f1a-4b6c7d8e9f0a"), false, new Guid("b850b9da-babb-465e-96b4-99639f04711e"), "Before sleep" },
                    { new Guid("d1e5c2b3-3f8a-4c6d-8b9c-1d2e3f4a5b6c"), false, new Guid("e74d6670-97b6-42c9-8464-881dbb6bfa9d"), "Rice" },
                    { new Guid("d5e6f7a8-9b0c-4d1d-9f8a-1c2d3e4f5a6b"), false, new Guid("cb1eb27c-eb7a-49f1-bf83-5b89a8dca794"), "Before breakfast" },
                    { new Guid("d9e0f1a2-3c4d-4e5f-9b2c-5c7d8e9f0a1b"), false, new Guid("b850b9da-babb-465e-96b4-99639f04711e"), "Anytime during the day" },
                    { new Guid("e0f1a2b3-4d5e-4f6a-8c3d-6d7e8f9a0b1c"), false, new Guid("34c91eb1-1e3b-4f7b-bf02-8b9f34653023"), "Whey protein" },
                    { new Guid("e6f7a8b9-0c1d-4d2e-8a9b-2d3e4f5a6b7c"), false, new Guid("ddbf95d6-d691-48e2-8c7d-6ce2150e3ac5"), "Provide all essential amino acids" },
                    { new Guid("f1a2b3c4-5e6f-4d7a-9b4c-7e8f9a0b1c2d"), false, new Guid("34c91eb1-1e3b-4f7b-bf02-8b9f34653023"), "Casein protein" },
                    { new Guid("f2a3b4c5-4d9e-4f8a-9b0c-2f3d4e5a6b7c"), false, new Guid("e74d6670-97b6-42c9-8464-881dbb6bfa9d"), "Lentils" },
                    { new Guid("f7a8b9c0-1d2e-4d3f-9b0c-3e4f5a6b7c8d"), false, new Guid("ddbf95d6-d691-48e2-8c7d-6ce2150e3ac5"), "Reduce calorie intake" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("a2b3c4d5-6f7e-4d8a-8c5d-8f9a0b1c2d3e"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("a8b9c0d1-2e3f-4d4a-8c1d-4f5a6b7c8d9e"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("b3c4d5e6-7f8a-4d9b-9d6e-9a0b1c2d3e4f"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("b7c8d9e0-1a2b-4c3d-9f4e-3a5b6c7d8e9f"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("c3b1f8a4-2d7e-4b9c-9a1f-0b6d3e5f7a1b"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("c4d5e6f7-8a9b-4d0c-8e7f-0b1c2d3e4f5a"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("c8d9e0f1-2b3c-4d5e-8f1a-4b6c7d8e9f0a"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("d1e5c2b3-3f8a-4c6d-8b9c-1d2e3f4a5b6c"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("d5e6f7a8-9b0c-4d1d-9f8a-1c2d3e4f5a6b"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("d9e0f1a2-3c4d-4e5f-9b2c-5c7d8e9f0a1b"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("e0f1a2b3-4d5e-4f6a-8c3d-6d7e8f9a0b1c"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("e6f7a8b9-0c1d-4d2e-8a9b-2d3e4f5a6b7c"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("f1a2b3c4-5e6f-4d7a-9b4c-7e8f9a0b1c2d"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("f2a3b4c5-4d9e-4f8a-9b0c-2f3d4e5a6b7c"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("f7a8b9c0-1d2e-4d3f-9b0c-3e4f5a6b7c8d"));
        }
    }
}
