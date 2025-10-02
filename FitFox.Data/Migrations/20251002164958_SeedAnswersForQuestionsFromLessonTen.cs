using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FitFox.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedAnswersForQuestionsFromLessonTen : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "IsDeleted", "QuestionId", "Text" },
                values: new object[,]
                {
                    { new Guid("0a66cfa9-ef59-4f3c-a10a-9c22a76e6916"), false, new Guid("27365168-3b26-4638-927a-0a0d32108cd7"), "Foam rolling" },
                    { new Guid("0ae26420-95f0-4042-9274-3efb35d6f282"), false, new Guid("6c611141-34e9-4ae5-892c-27106d39782d"), "Magnesium" },
                    { new Guid("0ed7b430-4a62-47f7-8997-1cbb3a6b4c1a"), false, new Guid("6d2a72e4-ce9c-4f3b-a2ba-48667f8d6062"), "Poor nutrition" },
                    { new Guid("2d8378db-6883-4c42-9620-6789e7cc1799"), false, new Guid("5f83b77f-09eb-43ab-aac6-1ba1a74a8225"), "A week of complete rest from all activity" },
                    { new Guid("3b7ec122-1ed4-408f-a60c-23d1de8ccf9f"), false, new Guid("6c611141-34e9-4ae5-892c-27106d39782d"), "Protein" },
                    { new Guid("40fce5c7-61c6-44de-b0f7-902f64e1d6f5"), false, new Guid("d3207231-b15e-428f-b6e7-ab53471202af"), "Light jogging" },
                    { new Guid("47836262-2b8f-42d3-a92c-9c07f87ecf0a"), false, new Guid("6d2a72e4-ce9c-4f3b-a2ba-48667f8d6062"), "Sleep deprivation" },
                    { new Guid("5c1e34a4-36f1-46c8-98e4-efc6d2872183"), false, new Guid("6632e20e-4ff2-4342-8af2-698acaf6e495"), "10–12 hours" },
                    { new Guid("6db1e63d-9c8d-42a1-975a-2e4c91f55f2d"), false, new Guid("018a8f7d-e12b-49d5-8718-889aa668cafb"), "It allows muscles to repair and grow stronger" },
                    { new Guid("7d2f9e7f-4171-45d6-9ed9-1d4da7cbf4c7"), false, new Guid("6d2a72e4-ce9c-4f3b-a2ba-48667f8d6062"), "Chronic stress" },
                    { new Guid("7d8f3079-46dc-4a3f-a69d-5ad1a7bbf79a"), false, new Guid("5f83b77f-09eb-43ab-aac6-1ba1a74a8225"), "A planned reduction in training intensity and volume" },
                    { new Guid("939df267-6639-46f3-bf5d-29134815ebf8"), false, new Guid("6c611141-34e9-4ae5-892c-27106d39782d"), "Vitamin D" },
                    { new Guid("93d9adcf-5c78-47d7-bc3b-84d8473f6c5d"), false, new Guid("27365168-3b26-4638-927a-0a0d32108cd7"), "Active recovery workouts" },
                    { new Guid("96dfaf70-57dc-4210-99e5-f3b7dc9d8415"), false, new Guid("d3207231-b15e-428f-b6e7-ab53471202af"), "Walking" },
                    { new Guid("9f6a55dc-d7de-4d67-ae8e-8220700dcd55"), false, new Guid("27365168-3b26-4638-927a-0a0d32108cd7"), "Gentle stretching" },
                    { new Guid("b41f3261-24f1-44b5-8bdb-8f8c65ebf9b0"), false, new Guid("6632e20e-4ff2-4342-8af2-698acaf6e495"), "4–5 hours" },
                    { new Guid("c4d9784f-7d60-4fdc-858a-71af0a3f3a18"), false, new Guid("6632e20e-4ff2-4342-8af2-698acaf6e495"), "7–9 hours" },
                    { new Guid("e4e9aa20-b264-4300-8a6c-7cfde77a2f35"), false, new Guid("018a8f7d-e12b-49d5-8718-889aa668cafb"), "It prevents overtraining and reduces injury risk" },
                    { new Guid("f62e6f83-ec58-48c0-8610-56c3ff593eb2"), false, new Guid("d3207231-b15e-428f-b6e7-ab53471202af"), "Yoga" },
                    { new Guid("f6ab422b-92a5-42c7-8de0-2b6a2f7652f8"), false, new Guid("018a8f7d-e12b-49d5-8718-889aa668cafb"), "It helps restore energy levels" },
                    { new Guid("fdf93c0f-1c62-4b9f-9353-15a3eea63d60"), false, new Guid("5f83b77f-09eb-43ab-aac6-1ba1a74a8225"), "A week focused only on cardio" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("0a66cfa9-ef59-4f3c-a10a-9c22a76e6916"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("0ae26420-95f0-4042-9274-3efb35d6f282"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("0ed7b430-4a62-47f7-8997-1cbb3a6b4c1a"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("2d8378db-6883-4c42-9620-6789e7cc1799"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("3b7ec122-1ed4-408f-a60c-23d1de8ccf9f"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("40fce5c7-61c6-44de-b0f7-902f64e1d6f5"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("47836262-2b8f-42d3-a92c-9c07f87ecf0a"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("5c1e34a4-36f1-46c8-98e4-efc6d2872183"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("6db1e63d-9c8d-42a1-975a-2e4c91f55f2d"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("7d2f9e7f-4171-45d6-9ed9-1d4da7cbf4c7"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("7d8f3079-46dc-4a3f-a69d-5ad1a7bbf79a"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("939df267-6639-46f3-bf5d-29134815ebf8"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("93d9adcf-5c78-47d7-bc3b-84d8473f6c5d"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("96dfaf70-57dc-4210-99e5-f3b7dc9d8415"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("9f6a55dc-d7de-4d67-ae8e-8220700dcd55"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("b41f3261-24f1-44b5-8bdb-8f8c65ebf9b0"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("c4d9784f-7d60-4fdc-858a-71af0a3f3a18"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("e4e9aa20-b264-4300-8a6c-7cfde77a2f35"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("f62e6f83-ec58-48c0-8610-56c3ff593eb2"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("f6ab422b-92a5-42c7-8de0-2b6a2f7652f8"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("fdf93c0f-1c62-4b9f-9353-15a3eea63d60"));
        }
    }
}
