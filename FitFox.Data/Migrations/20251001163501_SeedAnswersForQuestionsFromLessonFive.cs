using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FitFox.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedAnswersForQuestionsFromLessonFive : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "IsDeleted", "QuestionId", "Text" },
                values: new object[,]
                {
                    { new Guid("1746af68-5392-45ef-8e4b-3727a30ad3e3"), false, new Guid("4fbd5ee9-c603-4530-a325-0b8c94d87e52"), "Vitamin C" },
                    { new Guid("25ad17db-3019-4574-bc4f-183cef4d394c"), false, new Guid("99e612f3-3e52-4616-8ea1-19d620463779"), "Vitamin C" },
                    { new Guid("3d4e27ab-2849-4260-9788-0a6d80e2b70c"), false, new Guid("1020c72c-9f20-4b04-8523-e2a9dc643ed2"), "Scurvy" },
                    { new Guid("4447cf77-772e-4e12-8e2f-a2f55c90f4d2"), false, new Guid("4fbd5ee9-c603-4530-a325-0b8c94d87e52"), "Vitamin A" },
                    { new Guid("5b36f07f-a1fe-4fa8-b5f8-4cdb1813df91"), false, new Guid("99e612f3-3e52-4616-8ea1-19d620463779"), "Vitamin E" },
                    { new Guid("6222fac1-7b03-4910-a689-7389b679e51b"), false, new Guid("fc987683-272e-4874-9ec0-adbd1d4d43f0"), "Iron" },
                    { new Guid("7336f137-8ef5-40d5-9a59-515889f0bb05"), false, new Guid("99e612f3-3e52-4616-8ea1-19d620463779"), "Vitamin D" },
                    { new Guid("7354444b-3ba1-4ce6-a684-37d5626ab44b"), false, new Guid("af7f8faf-0b47-43a7-bce0-2120af75c39c"), "A, D, E, and K" },
                    { new Guid("742c20f9-e86b-42f5-b4ea-8570e33c72e9"), false, new Guid("4fbd5ee9-c603-4530-a325-0b8c94d87e52"), "Vitamin D" },
                    { new Guid("7a61b1aa-e39a-48c4-8067-c75f5805e716"), false, new Guid("1020c72c-9f20-4b04-8523-e2a9dc643ed2"), "Anemia" },
                    { new Guid("953254b5-a648-4737-b87d-4dd53394e84e"), false, new Guid("0ef6cf36-8764-4924-9b01-5fcc247c96aa"), "Protein and Carbohydrates" },
                    { new Guid("9f9493ae-cfd1-415e-99c5-0745a0118bc8"), false, new Guid("0ef6cf36-8764-4924-9b01-5fcc247c96aa"), "Fats and Carbohydrates" },
                    { new Guid("a744a2a4-b922-4423-a951-243d598c51f8"), false, new Guid("1020c72c-9f20-4b04-8523-e2a9dc643ed2"), "Osteoporosis" },
                    { new Guid("b21d3b1a-32c7-462a-9a9c-9a0b93f71296"), false, new Guid("6aea4f8b-3785-4027-8532-6592c9436898"), "Oxygen transport" },
                    { new Guid("c93b3b93-1a2a-4835-aadb-8c7040ac1aab"), false, new Guid("6aea4f8b-3785-4027-8532-6592c9436898"), "Building bone density" },
                    { new Guid("d1cedb19-1c10-4f32-a4f2-7631e8036fdc"), false, new Guid("fc987683-272e-4874-9ec0-adbd1d4d43f0"), "Calcium" },
                    { new Guid("dc110275-785c-4db3-8102-5da138cbbe8a"), false, new Guid("af7f8faf-0b47-43a7-bce0-2120af75c39c"), "B-complex and Vitamin C" },
                    { new Guid("de739138-256a-4f36-8c38-d3e69a8a0f8e"), false, new Guid("6aea4f8b-3785-4027-8532-6592c9436898"), "Wound healing" },
                    { new Guid("e8b0b203-90ba-4285-ad9e-493bd3592135"), false, new Guid("0ef6cf36-8764-4924-9b01-5fcc247c96aa"), "Vitamins and Minerals" },
                    { new Guid("f3233ca7-7639-490a-85e2-4d5044f0f7ac"), false, new Guid("fc987683-272e-4874-9ec0-adbd1d4d43f0"), "Zinc" },
                    { new Guid("fd23af3d-0ab6-40ff-b9c2-e74860f929f7"), false, new Guid("af7f8faf-0b47-43a7-bce0-2120af75c39c"), "Vitamin B12 and Vitamin C" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("1746af68-5392-45ef-8e4b-3727a30ad3e3"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("25ad17db-3019-4574-bc4f-183cef4d394c"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("3d4e27ab-2849-4260-9788-0a6d80e2b70c"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("4447cf77-772e-4e12-8e2f-a2f55c90f4d2"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("5b36f07f-a1fe-4fa8-b5f8-4cdb1813df91"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("6222fac1-7b03-4910-a689-7389b679e51b"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("7336f137-8ef5-40d5-9a59-515889f0bb05"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("7354444b-3ba1-4ce6-a684-37d5626ab44b"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("742c20f9-e86b-42f5-b4ea-8570e33c72e9"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("7a61b1aa-e39a-48c4-8067-c75f5805e716"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("953254b5-a648-4737-b87d-4dd53394e84e"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("9f9493ae-cfd1-415e-99c5-0745a0118bc8"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("a744a2a4-b922-4423-a951-243d598c51f8"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("b21d3b1a-32c7-462a-9a9c-9a0b93f71296"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("c93b3b93-1a2a-4835-aadb-8c7040ac1aab"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("d1cedb19-1c10-4f32-a4f2-7631e8036fdc"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("dc110275-785c-4db3-8102-5da138cbbe8a"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("de739138-256a-4f36-8c38-d3e69a8a0f8e"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("e8b0b203-90ba-4285-ad9e-493bd3592135"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("f3233ca7-7639-490a-85e2-4d5044f0f7ac"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("fd23af3d-0ab6-40ff-b9c2-e74860f929f7"));
        }
    }
}
