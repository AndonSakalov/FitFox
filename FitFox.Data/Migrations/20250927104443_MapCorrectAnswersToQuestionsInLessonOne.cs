using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FitFox.Data.Migrations
{
    /// <inheritdoc />
    public partial class MapCorrectAnswersToQuestionsInLessonOne : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("65e73cd9-dec1-4e46-8342-69b204c6b226"),
                column: "CorrectAnswerId",
                value: new Guid("995bd8c0-98e5-441b-96f2-046c4e732022"));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("83fc33fc-0db2-4695-a950-c494eb58a73c"),
                column: "CorrectAnswerId",
                value: new Guid("5b2e033a-3b69-42df-9b10-ac04fefbc4bd"));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("a8d6e1f2-5c33-4a0b-8cde-7e2f1a9b3d45"),
                column: "CorrectAnswerId",
                value: new Guid("ad15d6de-bc27-4f9c-925f-6efe5023521b"));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("c1f2b3e4-7d8a-4e5b-b2c3-9f0a1d2e3b56"),
                column: "CorrectAnswerId",
                value: new Guid("971018fd-870c-4834-b53e-9db728272f58"));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("c46cf154-ee4c-4c5d-ac35-4b4cf69639ce"),
                column: "CorrectAnswerId",
                value: new Guid("fe9167a4-2f11-4875-899d-83c9d4b031b7"));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("d4e5f6a7-8b9c-4d0e-9f1a-2b3c4d5e6f78"),
                column: "CorrectAnswerId",
                value: new Guid("cd72868e-1d3c-40e2-99d2-9be1c6482f07"));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("e58fca52-c2da-44a4-b62f-9bd9bd7bb583"),
                column: "CorrectAnswerId",
                value: new Guid("e00f1bae-9e02-4afb-871f-23a1a3a9884f"));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("65e73cd9-dec1-4e46-8342-69b204c6b226"),
                column: "CorrectAnswerId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("83fc33fc-0db2-4695-a950-c494eb58a73c"),
                column: "CorrectAnswerId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("a8d6e1f2-5c33-4a0b-8cde-7e2f1a9b3d45"),
                column: "CorrectAnswerId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("c1f2b3e4-7d8a-4e5b-b2c3-9f0a1d2e3b56"),
                column: "CorrectAnswerId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("c46cf154-ee4c-4c5d-ac35-4b4cf69639ce"),
                column: "CorrectAnswerId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("d4e5f6a7-8b9c-4d0e-9f1a-2b3c4d5e6f78"),
                column: "CorrectAnswerId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("e58fca52-c2da-44a4-b62f-9bd9bd7bb583"),
                column: "CorrectAnswerId",
                value: null);
        }
    }
}
