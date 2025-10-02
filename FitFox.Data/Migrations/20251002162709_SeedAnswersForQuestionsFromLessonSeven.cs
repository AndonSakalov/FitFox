using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FitFox.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedAnswersForQuestionsFromLessonSeven : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "IsDeleted", "QuestionId", "Text" },
                values: new object[,]
                {
                    { new Guid("06dbe57d-c81b-4a2e-9e86-7d2a4bcaf88b"), false, new Guid("8d2dbe17-1c9e-45f7-8fd2-d38f4d7f43ff"), "Quadriceps" },
                    { new Guid("0b78db0e-50c7-41d7-91e4-96f2fa8249d5"), false, new Guid("bc00cf25-bf28-4994-92ea-34b3c1cf2b8e"), "Bench press" },
                    { new Guid("11b13c0f-20ea-4d7e-9683-4c8e20b508b9"), false, new Guid("f68f4855-4f08-4e5e-9480-497f2e7f70c5"), "Triceps" },
                    { new Guid("2928b832-58ae-4263-8f93-d0f7c76f1c7c"), false, new Guid("b77e9f69-16dc-4192-9c86-cfa9ccf86a5b"), "Forearms" },
                    { new Guid("38cc1c61-87ee-47ff-80bb-15d90a6dc7a1"), false, new Guid("f68f4855-4f08-4e5e-9480-497f2e7f70c5"), "Deltoids" },
                    { new Guid("5b1d3a91-2d5f-44cb-8e0d-3904a04d3a3d"), false, new Guid("bc00cf25-bf28-4994-92ea-34b3c1cf2b8e"), "Bicep curls" },
                    { new Guid("6f3c6c9d-1e53-4f0d-a72d-23613291c584"), false, new Guid("b6d72991-5934-4d11-8c64-2144493e4fc6"), "Glutes" },
                    { new Guid("7dc67f43-78d5-472c-88de-ff6a8284ec8b"), false, new Guid("bc00cf25-bf28-4994-92ea-34b3c1cf2b8e"), "Leg extensions" },
                    { new Guid("8a1e3735-b9f4-4176-9f87-c88228b43c74"), false, new Guid("b6d72991-5934-4d11-8c64-2144493e4fc6"), "Calves" },
                    { new Guid("8c5dcaaa-96a0-4267-9eb6-b94ec78e0f7a"), false, new Guid("8b071bdd-25b1-4ab2-9c64-32e44e2eb889"), "Deltoids" },
                    { new Guid("8e154d3b-1f8b-4ef4-85a5-3014f5ea31c2"), false, new Guid("f68f4855-4f08-4e5e-9480-497f2e7f70c5"), "Quadriceps" },
                    { new Guid("905c0a9e-9e27-4709-94c6-83a8bcbe84ef"), false, new Guid("b77e9f69-16dc-4192-9c86-cfa9ccf86a5b"), "Triceps" },
                    { new Guid("9f87c20a-60c0-4c3a-8b8c-9abbeed8f761"), false, new Guid("8d2dbe17-1c9e-45f7-8fd2-d38f4d7f43ff"), "Pectoralis major" },
                    { new Guid("aef3c9d5-9e37-45d2-9ec0-b9e2d9c16e60"), false, new Guid("b77e9f69-16dc-4192-9c86-cfa9ccf86a5b"), "Quadriceps and glutes" },
                    { new Guid("af83a62c-84ea-4d8c-a5e4-28c283e8b0f2"), false, new Guid("da4b1734-79df-4b91-a69f-7c52b4b7553a"), "Biceps" },
                    { new Guid("bbbf52d1-d379-4b59-a63f-38b611897b93"), false, new Guid("b6d72991-5934-4d11-8c64-2144493e4fc6"), "Latissimus dorsi" },
                    { new Guid("c1b89a5c-47f6-4193-bb4e-5e2e6e31b6a2"), false, new Guid("da4b1734-79df-4b91-a69f-7c52b4b7553a"), "Forearms only" },
                    { new Guid("d5e0a8e0-50a4-49a4-8c7a-2c771a8280cf"), false, new Guid("8b071bdd-25b1-4ab2-9c64-32e44e2eb889"), "Pectorals" },
                    { new Guid("d6a6d0bb-92c7-44a3-8e1b-92c08e2d97b7"), false, new Guid("8d2dbe17-1c9e-45f7-8fd2-d38f4d7f43ff"), "Latissimus dorsi" },
                    { new Guid("e85b7430-2a92-4dbd-99c2-9d3c1675a9b4"), false, new Guid("8b071bdd-25b1-4ab2-9c64-32e44e2eb889"), "Hamstrings" },
                    { new Guid("f83a6d41-2405-4c38-8b64-546e61d8c6fc"), false, new Guid("da4b1734-79df-4b91-a69f-7c52b4b7553a"), "Posterior chain (glutes, hamstrings, lower back)" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("06dbe57d-c81b-4a2e-9e86-7d2a4bcaf88b"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("0b78db0e-50c7-41d7-91e4-96f2fa8249d5"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("11b13c0f-20ea-4d7e-9683-4c8e20b508b9"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("2928b832-58ae-4263-8f93-d0f7c76f1c7c"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("38cc1c61-87ee-47ff-80bb-15d90a6dc7a1"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("5b1d3a91-2d5f-44cb-8e0d-3904a04d3a3d"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("6f3c6c9d-1e53-4f0d-a72d-23613291c584"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("7dc67f43-78d5-472c-88de-ff6a8284ec8b"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("8a1e3735-b9f4-4176-9f87-c88228b43c74"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("8c5dcaaa-96a0-4267-9eb6-b94ec78e0f7a"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("8e154d3b-1f8b-4ef4-85a5-3014f5ea31c2"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("905c0a9e-9e27-4709-94c6-83a8bcbe84ef"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("9f87c20a-60c0-4c3a-8b8c-9abbeed8f761"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("aef3c9d5-9e37-45d2-9ec0-b9e2d9c16e60"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("af83a62c-84ea-4d8c-a5e4-28c283e8b0f2"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("bbbf52d1-d379-4b59-a63f-38b611897b93"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("c1b89a5c-47f6-4193-bb4e-5e2e6e31b6a2"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("d5e0a8e0-50a4-49a4-8c7a-2c771a8280cf"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("d6a6d0bb-92c7-44a3-8e1b-92c08e2d97b7"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("e85b7430-2a92-4dbd-99c2-9d3c1675a9b4"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("f83a6d41-2405-4c38-8b64-546e61d8c6fc"));
        }
    }
}
