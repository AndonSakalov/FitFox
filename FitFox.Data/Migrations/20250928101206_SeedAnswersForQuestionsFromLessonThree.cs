using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FitFox.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedAnswersForQuestionsFromLessonThree : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "IsDeleted", "QuestionId", "Text" },
                values: new object[,]
                {
                    { new Guid("a8e4f0c5-5a2c-4e2e-98d1-0f7bfa36c1b7"), false, new Guid("c29ae0bc-eb61-45c1-be09-2e24ca66862b"), "Transport nutrients and waste, as well as regulate body temperature" },
                    { new Guid("b1d3e972-3f27-49f3-9e5b-5f2a8c4a2b89"), false, new Guid("c29ae0bc-eb61-45c1-be09-2e24ca66862b"), "Produce hormones" },
                    { new Guid("b8f7d3c4-1a5b-4e8c-9d2a-0f4e3c7b2d1a"), false, new Guid("5ef2fcf6-df7a-4f3d-9958-3d3c20fe9b90"), "Potassium" },
                    { new Guid("c1f0e9d8-2b3c-4d5e-8f6a-0c1d2e3f4a5b"), false, new Guid("2cd2b95d-63c0-4c7f-9485-3df385a91476"), "Potassium" },
                    { new Guid("c3d2e1f0-4b5a-4c8d-9e2f-1a3b4c5d6e7f"), false, new Guid("4c550c86-a27f-480d-8a34-26a5d94d7bb3"), "Excessive energy" },
                    { new Guid("c5f4e3d2-6b7c-4d9f-8f0e-4a5b6c7d8e9f"), false, new Guid("3bbce0fb-8e12-4a03-837d-9ac269f282ff"), "Improved sleep" },
                    { new Guid("c7b6a5d4-8e9f-4f0a-9b2c-6d7e8f9a0b1d"), false, new Guid("3b1a72e5-e73e-4e8d-833e-b92a61eb2664"), "5 liters" },
                    { new Guid("c7e2f8b1-4d5a-4c9e-8b1c-3f2e6a4d1b2f"), false, new Guid("5ef2fcf6-df7a-4f3d-9958-3d3c20fe9b90"), "Sodium" },
                    { new Guid("d0c6a5e2-3c2b-4f85-8ed2-1a9b6c7d4f2a"), false, new Guid("d76f8572-c76d-4ea6-96e2-88f94b2ef5db"), "Sodium" },
                    { new Guid("d2c1f0e9-3b4c-4d6e-9f7b-1d2e3f4a5b6c"), false, new Guid("2cd2b95d-63c0-4c7f-9485-3df385a91476"), "Magnesium" },
                    { new Guid("d3f1b2a5-5e6c-4d9f-9c1a-2e3f4a5b6c7d"), false, new Guid("5ef2fcf6-df7a-4f3d-9958-3d3c20fe9b90"), "Chloride" },
                    { new Guid("d4e3f2a1-5b6c-4d8f-9a2b-3c4d5e6f7a8b"), false, new Guid("4c550c86-a27f-480d-8a34-26a5d94d7bb3"), "High blood sugar" },
                    { new Guid("d6c5f4e3-7b8c-4daf-9f1a-5b6c7d8e9f0a"), false, new Guid("3bbce0fb-8e12-4a03-837d-9ac269f282ff"), "Muscle and nerve function" },
                    { new Guid("d8c7b6a5-9f0a-4b1c-8d3e-7f8a9b0c1d2e"), false, new Guid("3b1a72e5-e73e-4e8d-833e-b92a61eb2664"), "1 liter" },
                    { new Guid("e9a3d7b1-7c18-4f5e-9b3d-2c1f4a9e6d8b"), false, new Guid("d76f8572-c76d-4ea6-96e2-88f94b2ef5db"), "Potassium" },
                    { new Guid("f0e9d8c7-1b2c-4d3e-9f5a-9b0c1d2e3f4a"), false, new Guid("2cd2b95d-63c0-4c7f-9485-3df385a91476"), "Sodium" },
                    { new Guid("f1b2d3a4-5e6c-4f8d-9a1b-2c3d4e5f6a7b"), false, new Guid("4c550c86-a27f-480d-8a34-26a5d94d7bb3"), "Dark colored urine" },
                    { new Guid("f2c3a97e-1b34-4a36-8f48-2f3c1d0d5a5b"), false, new Guid("c29ae0bc-eb61-45c1-be09-2e24ca66862b"), "Store energy" },
                    { new Guid("f4e3d2c1-5b6c-4d8e-9f9d-3f4a5b6c7d8e"), false, new Guid("3bbce0fb-8e12-4a03-837d-9ac269f282ff"), "Muscle relaxation" },
                    { new Guid("f6a5b4c3-7d8e-4f9a-8b1c-5d6e7f8a9b0c"), false, new Guid("3b1a72e5-e73e-4e8d-833e-b92a61eb2664"), "2–3 liters" },
                    { new Guid("fa1c3b47-5e6a-4c8d-9e2b-0d9c2a4e7b1f"), false, new Guid("d76f8572-c76d-4ea6-96e2-88f94b2ef5db"), "Magnesium" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("a8e4f0c5-5a2c-4e2e-98d1-0f7bfa36c1b7"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("b1d3e972-3f27-49f3-9e5b-5f2a8c4a2b89"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("b8f7d3c4-1a5b-4e8c-9d2a-0f4e3c7b2d1a"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("c1f0e9d8-2b3c-4d5e-8f6a-0c1d2e3f4a5b"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("c3d2e1f0-4b5a-4c8d-9e2f-1a3b4c5d6e7f"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("c5f4e3d2-6b7c-4d9f-8f0e-4a5b6c7d8e9f"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("c7b6a5d4-8e9f-4f0a-9b2c-6d7e8f9a0b1d"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("c7e2f8b1-4d5a-4c9e-8b1c-3f2e6a4d1b2f"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("d0c6a5e2-3c2b-4f85-8ed2-1a9b6c7d4f2a"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("d2c1f0e9-3b4c-4d6e-9f7b-1d2e3f4a5b6c"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("d3f1b2a5-5e6c-4d9f-9c1a-2e3f4a5b6c7d"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("d4e3f2a1-5b6c-4d8f-9a2b-3c4d5e6f7a8b"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("d6c5f4e3-7b8c-4daf-9f1a-5b6c7d8e9f0a"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("d8c7b6a5-9f0a-4b1c-8d3e-7f8a9b0c1d2e"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("e9a3d7b1-7c18-4f5e-9b3d-2c1f4a9e6d8b"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("f0e9d8c7-1b2c-4d3e-9f5a-9b0c1d2e3f4a"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("f1b2d3a4-5e6c-4f8d-9a1b-2c3d4e5f6a7b"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("f2c3a97e-1b34-4a36-8f48-2f3c1d0d5a5b"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("f4e3d2c1-5b6c-4d8e-9f9d-3f4a5b6c7d8e"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("f6a5b4c3-7d8e-4f9a-8b1c-5d6e7f8a9b0c"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("fa1c3b47-5e6a-4c8d-9e2b-0d9c2a4e7b1f"));
        }
    }
}
