using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FitFox.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedAnswersForQuestionsFromLessonNine : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "IsDeleted", "QuestionId", "Text" },
                values: new object[,]
                {
                    { new Guid("18c3b8c5-c2fc-40fb-a3b1-1e6ea835edc1"), false, new Guid("1e3c972d-3549-4d00-8ca5-88ac510abe63"), "They burn more calories than compound lifts" },
                    { new Guid("22e59af2-67b2-4f33-8728-9c22d4d47a6b"), false, new Guid("a9fced86-bd78-4901-b983-f05a2ad96bcd"), "They isolate single muscles" },
                    { new Guid("3442f926-7bc4-4d93-b93e-205f39c5c24f"), false, new Guid("04ecf251-b526-4445-a6f6-a6c7dfdd586a"), "An exercise that only works one muscle" },
                    { new Guid("6c83c42a-91ee-4266-9a52-c6a11e58f5d9"), false, new Guid("04ecf251-b526-4445-a6f6-a6c7dfdd586a"), "A stretching routine" },
                    { new Guid("72af9735-5741-49c2-9bb0-f0f403d14d7d"), false, new Guid("a9fced86-bd78-4901-b983-f05a2ad96bcd"), "They only improve flexibility" },
                    { new Guid("8233a9f1-cfd0-44d7-a16a-8a993f41c292"), false, new Guid("a9fced86-bd78-4901-b983-f05a2ad96bcd"), "They build strength and efficiency by training multiple muscles at once" },
                    { new Guid("86cc5df9-62ad-4625-92f3-2145e1b4bfa3"), false, new Guid("562c6f2d-4216-4f46-b74b-a764a7ad5418"), "Deadlift" },
                    { new Guid("90f93384-46e7-48a7-9cd7-7fa246170510"), false, new Guid("1e3c972d-3549-4d00-8ca5-88ac510abe63"), "They replace all compound exercises" },
                    { new Guid("98a3c6ab-b313-4967-9176-6713db26e22f"), false, new Guid("905e3202-c416-470b-8e11-ce66a9f7a534"), "They are easier when you’re already fatigued" },
                    { new Guid("9d52f7a2-3538-4d07-b633-08c9334504e8"), false, new Guid("562c6f2d-4216-4f46-b74b-a764a7ad5418"), "Bicep curl" },
                    { new Guid("be0f259c-c282-4c5c-bf45-27d9d7468f7d"), false, new Guid("905e3202-c416-470b-8e11-ce66a9f7a534"), "They require the most energy and proper form" },
                    { new Guid("cb987d1a-3d49-48a6-bf32-50460e70c002"), false, new Guid("562c6f2d-4216-4f46-b74b-a764a7ad5418"), "Pull-up" },
                    { new Guid("d1d77957-0c67-44ff-a89c-c6bc6a267e94"), false, new Guid("ed946370-816b-4175-bfee-cc24d3d3c971"), "Calf raise" },
                    { new Guid("d67e8c6e-7322-4f30-9382-5d02a64ec230"), false, new Guid("2ca88517-a1ad-4bc9-9283-0e4100d60dcd"), "Only doing isolation exercises" },
                    { new Guid("e15973be-d5b9-4db0-8a25-8fbcb18d80cf"), false, new Guid("04ecf251-b526-4445-a6f6-a6c7dfdd586a"), "An exercise that works multiple muscle groups and joints" },
                    { new Guid("e4236c35-458f-41d4-96a8-4f7ec5f31a84"), false, new Guid("905e3202-c416-470b-8e11-ce66a9f7a534"), "They take the least focus and technique" },
                    { new Guid("ed8fd22a-57e2-42d5-8238-7e6ef1537f12"), false, new Guid("ed946370-816b-4175-bfee-cc24d3d3c971"), "Squat" },
                    { new Guid("f1db93db-420d-4d91-97a5-760312f0a633"), false, new Guid("1e3c972d-3549-4d00-8ca5-88ac510abe63"), "They target specific muscles to correct imbalances or weaknesses" },
                    { new Guid("f5ac49d1-50a3-49f6-bf7f-52ffdfd2781a"), false, new Guid("ed946370-816b-4175-bfee-cc24d3d3c971"), "Bicep curl" },
                    { new Guid("f9c02ef8-1ed0-44f0-b057-4b8a4a8e97c1"), false, new Guid("2ca88517-a1ad-4bc9-9283-0e4100d60dcd"), "A mix of compound and isolation exercises" },
                    { new Guid("fbbaaf3f-428f-4b60-95d4-5a1f5e0097d6"), false, new Guid("2ca88517-a1ad-4bc9-9283-0e4100d60dcd"), "Avoiding strength training altogether" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("18c3b8c5-c2fc-40fb-a3b1-1e6ea835edc1"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("22e59af2-67b2-4f33-8728-9c22d4d47a6b"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("3442f926-7bc4-4d93-b93e-205f39c5c24f"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("6c83c42a-91ee-4266-9a52-c6a11e58f5d9"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("72af9735-5741-49c2-9bb0-f0f403d14d7d"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("8233a9f1-cfd0-44d7-a16a-8a993f41c292"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("86cc5df9-62ad-4625-92f3-2145e1b4bfa3"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("90f93384-46e7-48a7-9cd7-7fa246170510"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("98a3c6ab-b313-4967-9176-6713db26e22f"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("9d52f7a2-3538-4d07-b633-08c9334504e8"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("be0f259c-c282-4c5c-bf45-27d9d7468f7d"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("cb987d1a-3d49-48a6-bf32-50460e70c002"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("d1d77957-0c67-44ff-a89c-c6bc6a267e94"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("d67e8c6e-7322-4f30-9382-5d02a64ec230"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("e15973be-d5b9-4db0-8a25-8fbcb18d80cf"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("e4236c35-458f-41d4-96a8-4f7ec5f31a84"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("ed8fd22a-57e2-42d5-8238-7e6ef1537f12"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("f1db93db-420d-4d91-97a5-760312f0a633"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("f5ac49d1-50a3-49f6-bf7f-52ffdfd2781a"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("f9c02ef8-1ed0-44f0-b057-4b8a4a8e97c1"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("fbbaaf3f-428f-4b60-95d4-5a1f5e0097d6"));
        }
    }
}
