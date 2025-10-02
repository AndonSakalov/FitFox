using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FitFox.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedAnswersForQuestionsFromLessonEight : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "IsDeleted", "QuestionId", "Text" },
                values: new object[,]
                {
                    { new Guid("0a7fded8-7e67-44cd-896f-49d04743d0c0"), false, new Guid("e70a94b3-2a6d-4f7b-8250-9f43c5ac4c72"), "Once every 3 weeks" },
                    { new Guid("3f785bfc-8c15-4a69-924c-9bbff78a6a3e"), false, new Guid("7a37747e-9f9c-4d6d-a25a-10ee17d64a09"), "You only ever train arms" },
                    { new Guid("4e32c960-39e4-4fd0-87c1-6b5645d1a0f2"), false, new Guid("dce5b4e5-c46d-4b34-b5ae-14e67d6b753e"), "A way of dividing workouts by muscle groups or days" },
                    { new Guid("5ec2107b-82eb-4721-bbbc-62aa5d1af6c3"), false, new Guid("e70a94b3-2a6d-4f7b-8250-9f43c5ac4c72"), "2–3 times per week" },
                    { new Guid("73f29d9c-3b3d-47e8-becf-f48792fc48b1"), false, new Guid("57b4cf97-88e2-4b77-a66a-dfa5704aa3cb"), "Never taking rest days" },
                    { new Guid("7c66cb38-1a4c-4c36-9b8a-f0a632cd208f"), false, new Guid("57b4cf97-88e2-4b77-a66a-dfa5704aa3cb"), "Upper/lower body split" },
                    { new Guid("88df17df-158d-4c8a-bae0-3adf42c2f9b4"), false, new Guid("f35e77c4-447c-46f3-893e-62110c2ff969"), "Rest reduces flexibility" },
                    { new Guid("8c417a1b-2182-4668-8ff3-79c0b9c520f0"), false, new Guid("dce5b4e5-c46d-4b34-b5ae-14e67d6b753e"), "A type of diet plan" },
                    { new Guid("93d0589e-c246-40f0-8f1f-f0a23f00db38"), false, new Guid("3d1a7d0b-029c-41f3-81fd-cb53ff5ed0ea"), "Never training weak muscles" },
                    { new Guid("9f0c9cf0-c5e6-46f4-9c36-134d962a28f9"), false, new Guid("39d43280-d51f-4a8e-921f-97b6f4b2873e"), "Full-body workouts 3x per week" },
                    { new Guid("9f4ebdb2-8c66-44d7-9b82-cae48c90e354"), false, new Guid("f35e77c4-447c-46f3-893e-62110c2ff969"), "Rest burns more calories" },
                    { new Guid("a07312e1-9b6c-46c4-90bb-49c1386e9122"), false, new Guid("7a37747e-9f9c-4d6d-a25a-10ee17d64a09"), "Higher training frequency for all muscles" },
                    { new Guid("a0e1c9f7-3e87-4fd6-8a38-59b06f1e9935"), false, new Guid("dce5b4e5-c46d-4b34-b5ae-14e67d6b753e"), "A supplement program" },
                    { new Guid("ace71c5c-f9f3-49cc-b229-5d54f46f04d0"), false, new Guid("3d1a7d0b-029c-41f3-81fd-cb53ff5ed0ea"), "Reducing training volume for non-lagging muscles and increasing frequency for lagging ones" },
                    { new Guid("c60ea236-991f-4b8d-bdad-d60f3035eb47"), false, new Guid("39d43280-d51f-4a8e-921f-97b6f4b2873e"), "Two-a-day workouts every day" },
                    { new Guid("cd24964d-31fc-4c0d-88e4-1b3d73e3089e"), false, new Guid("e70a94b3-2a6d-4f7b-8250-9f43c5ac4c72"), "Every single day" },
                    { new Guid("d1df8f19-9a92-48fb-83c2-7c3ab2cfb6e7"), false, new Guid("57b4cf97-88e2-4b77-a66a-dfa5704aa3cb"), "Training the same muscle twice a day" },
                    { new Guid("e6d57d8e-93c7-4f87-87e8-82b06419b8e5"), false, new Guid("7a37747e-9f9c-4d6d-a25a-10ee17d64a09"), "It requires no rest days" },
                    { new Guid("f5a53d22-1f93-4c4d-9b0f-26384913ad88"), false, new Guid("39d43280-d51f-4a8e-921f-97b6f4b2873e"), "Only training arms and chest" },
                    { new Guid("f88a1ed1-8d71-4d61-a0bb-d91e9b3d0c3f"), false, new Guid("f35e77c4-447c-46f3-893e-62110c2ff969"), "Muscles grow and repair during rest" },
                    { new Guid("fb61ab9f-6f1f-4d25-97dc-44ff1660d4e4"), false, new Guid("3d1a7d0b-029c-41f3-81fd-cb53ff5ed0ea"), "Only doing cardio" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("0a7fded8-7e67-44cd-896f-49d04743d0c0"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("3f785bfc-8c15-4a69-924c-9bbff78a6a3e"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("4e32c960-39e4-4fd0-87c1-6b5645d1a0f2"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("5ec2107b-82eb-4721-bbbc-62aa5d1af6c3"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("73f29d9c-3b3d-47e8-becf-f48792fc48b1"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("7c66cb38-1a4c-4c36-9b8a-f0a632cd208f"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("88df17df-158d-4c8a-bae0-3adf42c2f9b4"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("8c417a1b-2182-4668-8ff3-79c0b9c520f0"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("93d0589e-c246-40f0-8f1f-f0a23f00db38"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("9f0c9cf0-c5e6-46f4-9c36-134d962a28f9"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("9f4ebdb2-8c66-44d7-9b82-cae48c90e354"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("a07312e1-9b6c-46c4-90bb-49c1386e9122"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("a0e1c9f7-3e87-4fd6-8a38-59b06f1e9935"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("ace71c5c-f9f3-49cc-b229-5d54f46f04d0"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("c60ea236-991f-4b8d-bdad-d60f3035eb47"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("cd24964d-31fc-4c0d-88e4-1b3d73e3089e"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("d1df8f19-9a92-48fb-83c2-7c3ab2cfb6e7"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("e6d57d8e-93c7-4f87-87e8-82b06419b8e5"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("f5a53d22-1f93-4c4d-9b0f-26384913ad88"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("f88a1ed1-8d71-4d61-a0bb-d91e9b3d0c3f"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("fb61ab9f-6f1f-4d25-97dc-44ff1660d4e4"));
        }
    }
}
