using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FitFox.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedAnswersForQuestionsFromLessonSix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "IsDeleted", "QuestionId", "Text" },
                values: new object[,]
                {
                    { new Guid("23b32ab0-7c5e-45e0-86dc-3f4315c8a0e7"), false, new Guid("196f6df9-6234-499b-9309-c6b0cd29e349"), "Improved memory recall" },
                    { new Guid("2a53f9f5-b8a2-4c7b-a38c-148d8d7c9654"), false, new Guid("cbb7907f-d0ab-4b6a-90e2-99312cdf12e4"), "It decreases calorie burn" },
                    { new Guid("37d13c3b-c97c-4edc-8f85-4049a32963de"), false, new Guid("196f6df9-6234-499b-9309-c6b0cd29e349"), "Decreased caffeine sensitivity" },
                    { new Guid("4f1c3b7c-b8a9-4cbf-9a69-27b6e12a2bb0"), false, new Guid("3da3629a-ace4-45f2-900b-6c134ba6231b"), "Increased muscle strength" },
                    { new Guid("6b3c55d0-3ec7-4b8c-bc36-9b1c6ac8d3f6"), false, new Guid("706cec35-8678-40a3-bf08-3f4a001765e5"), "Type 2 diabetes" },
                    { new Guid("7c6d4a08-47df-48c8-9d9c-23e4f5b0b8cb"), false, new Guid("3da3629a-ace4-45f2-900b-6c134ba6231b"), "Better sleep quality" },
                    { new Guid("86922f5c-4f7f-43d7-81c0-08f697e8fc6d"), false, new Guid("734b09f7-245b-43cf-bf1a-87a2ead54981"), "Increasing bone density" },
                    { new Guid("8d329f9a-9073-467c-8bb8-7748d7276bb3"), false, new Guid("4420dd55-0f57-439b-bc4b-47623fe05e5c"), "Increasing lean muscle mass" },
                    { new Guid("92e47a29-1671-4c49-b7cb-95b5c9f71624"), false, new Guid("0b831d70-b6e1-4eb6-8c5a-ac03c7d5d62f"), "Arthritis" },
                    { new Guid("96a7d4c1-0df9-4c59-b3cc-b0a93b5e31a3"), false, new Guid("3da3629a-ace4-45f2-900b-6c134ba6231b"), "Improved flexibility" },
                    { new Guid("99ed08ac-d2f2-4696-9cfa-471f89e6e1ae"), false, new Guid("cbb7907f-d0ab-4b6a-90e2-99312cdf12e4"), "It increases resting metabolic rate" },
                    { new Guid("b154f07b-5c53-4a9d-bbfa-17489e258db8"), false, new Guid("cbb7907f-d0ab-4b6a-90e2-99312cdf12e4"), "It slows down digestion" },
                    { new Guid("c1587adf-c5f3-4996-a0e8-7c4f92696cf2"), false, new Guid("706cec35-8678-40a3-bf08-3f4a001765e5"), "Common cold" },
                    { new Guid("c6b6d43b-5eaf-43b2-9e13-35c8c81ebc92"), false, new Guid("4420dd55-0f57-439b-bc4b-47623fe05e5c"), "Improving hydration" },
                    { new Guid("c7f01db0-19b4-4c64-bb64-f87fdf38ff6c"), false, new Guid("196f6df9-6234-499b-9309-c6b0cd29e349"), "Reduced symptoms of depression" },
                    { new Guid("cfa9b01c-c689-456e-8c85-60dd9d31cf34"), false, new Guid("4420dd55-0f57-439b-bc4b-47623fe05e5c"), "Reducing appetite" },
                    { new Guid("d1a2e87a-fbc1-47e0-9c0d-7fc3b5adad3b"), false, new Guid("0b831d70-b6e1-4eb6-8c5a-ac03c7d5d62f"), "Osteoporosis" },
                    { new Guid("da944b9c-95ec-4b28-b38d-4ac50815f7e4"), false, new Guid("734b09f7-245b-43cf-bf1a-87a2ead54981"), "Reducing calcium absorption" },
                    { new Guid("f52e10e0-249d-4cd6-8a5a-52c18b9c2ad7"), false, new Guid("734b09f7-245b-43cf-bf1a-87a2ead54981"), "Preventing hydration loss" },
                    { new Guid("f8bb27aa-27c6-4141-97a3-0e2d7bfc0d68"), false, new Guid("0b831d70-b6e1-4eb6-8c5a-ac03c7d5d62f"), "Alzheimer’s disease" },
                    { new Guid("f93b876a-38eb-4052-9f5d-54a58c09f059"), false, new Guid("706cec35-8678-40a3-bf08-3f4a001765e5"), "Motion sickness" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("23b32ab0-7c5e-45e0-86dc-3f4315c8a0e7"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("2a53f9f5-b8a2-4c7b-a38c-148d8d7c9654"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("37d13c3b-c97c-4edc-8f85-4049a32963de"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("4f1c3b7c-b8a9-4cbf-9a69-27b6e12a2bb0"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("6b3c55d0-3ec7-4b8c-bc36-9b1c6ac8d3f6"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("7c6d4a08-47df-48c8-9d9c-23e4f5b0b8cb"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("86922f5c-4f7f-43d7-81c0-08f697e8fc6d"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("8d329f9a-9073-467c-8bb8-7748d7276bb3"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("92e47a29-1671-4c49-b7cb-95b5c9f71624"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("96a7d4c1-0df9-4c59-b3cc-b0a93b5e31a3"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("99ed08ac-d2f2-4696-9cfa-471f89e6e1ae"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("b154f07b-5c53-4a9d-bbfa-17489e258db8"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("c1587adf-c5f3-4996-a0e8-7c4f92696cf2"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("c6b6d43b-5eaf-43b2-9e13-35c8c81ebc92"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("c7f01db0-19b4-4c64-bb64-f87fdf38ff6c"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("cfa9b01c-c689-456e-8c85-60dd9d31cf34"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("d1a2e87a-fbc1-47e0-9c0d-7fc3b5adad3b"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("da944b9c-95ec-4b28-b38d-4ac50815f7e4"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("f52e10e0-249d-4cd6-8a5a-52c18b9c2ad7"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("f8bb27aa-27c6-4141-97a3-0e2d7bfc0d68"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("f93b876a-38eb-4052-9f5d-54a58c09f059"));
        }
    }
}
