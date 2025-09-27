using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FitFox.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedLesson : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Questions_Answers_CorrectAnswerId",
                table: "Questions");

            migrationBuilder.AlterColumn<Guid>(
                name: "CorrectAnswerId",
                table: "Questions",
                type: "uniqueidentifier",
                nullable: true,
                comment: "The identifier of the correct answer.",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldComment: "The identifier of the correct answer.");

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "Id", "IsDeleted", "MapId", "OrderNumber", "Title", "XP" },
                values: new object[] { new Guid("26a98b9c-2a98-4714-8d28-99f6ed419834"), false, new Guid("04493112-8b84-43be-b926-5a32c5524ac2"), 1, "Macronutrients", 100 });

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_Answers_CorrectAnswerId",
                table: "Questions",
                column: "CorrectAnswerId",
                principalTable: "Answers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Questions_Answers_CorrectAnswerId",
                table: "Questions");

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("26a98b9c-2a98-4714-8d28-99f6ed419834"));

            migrationBuilder.AlterColumn<Guid>(
                name: "CorrectAnswerId",
                table: "Questions",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                comment: "The identifier of the correct answer.",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldComment: "The identifier of the correct answer.");

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_Answers_CorrectAnswerId",
                table: "Questions",
                column: "CorrectAnswerId",
                principalTable: "Answers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
