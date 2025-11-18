using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FitFox.Data.Migrations
{
    /// <inheritdoc />
    public partial class ChangeDefaultImageURL : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("17e94d55-2c88-4a63-bc41-6e7fb922e3c1"),
                column: "IconUrl",
                value: "/images/No_Image_Available.jpg");

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("2f0cc148-2fa5-4f04-bfc6-0e3d139a9f52"),
                column: "IconUrl",
                value: "/images/No_Image_Available.jpg");

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("4c1f8a22-7e0b-4c13-bc38-2f4b9f7a1d90"),
                column: "IconUrl",
                value: "/images/No_Image_Available.jpg");

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("623fa9e8-0b67-4c20-b862-f2d240679cb1"),
                column: "IconUrl",
                value: "/images/No_Image_Available.jpg");

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("94c5d27e-8ee4-4fc4-a9df-36bcfb85ea48"),
                column: "IconUrl",
                value: "/images/No_Image_Available.jpg");

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("af2d9e71-3b54-4c8c-a8c5-9e2f38d12a44"),
                column: "IconUrl",
                value: "/images/No_Image_Available.jpg");

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("b28e13d4-6cb9-4ad1-9869-eaf0c1870ec3"),
                column: "IconUrl",
                value: "/images/No_Image_Available.jpg");

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("cd4a6277-0f39-4b24-b86c-167ccc0a5b61"),
                column: "IconUrl",
                value: "/images/No_Image_Available.jpg");

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("d8b0309a-bc74-4fa8-bb13-0f1c3c9e5a22"),
                column: "IconUrl",
                value: "/images/No_Image_Available.jpg");

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("f6b7903a-41e0-4753-9ad0-d8ac584c5c6f"),
                column: "IconUrl",
                value: "/images/No_Image_Available.jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("17e94d55-2c88-4a63-bc41-6e7fb922e3c1"),
                column: "IconUrl",
                value: "FitFox/wwwroot/images/No_Image_Available.jpg");

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("2f0cc148-2fa5-4f04-bfc6-0e3d139a9f52"),
                column: "IconUrl",
                value: "FitFox/wwwroot/images/No_Image_Available.jpg");

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("4c1f8a22-7e0b-4c13-bc38-2f4b9f7a1d90"),
                column: "IconUrl",
                value: "FitFox/wwwroot/images/No_Image_Available.jpg");

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("623fa9e8-0b67-4c20-b862-f2d240679cb1"),
                column: "IconUrl",
                value: "FitFox/wwwroot/images/No_Image_Available.jpg");

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("94c5d27e-8ee4-4fc4-a9df-36bcfb85ea48"),
                column: "IconUrl",
                value: "FitFox/wwwroot/images/No_Image_Available.jpg");

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("af2d9e71-3b54-4c8c-a8c5-9e2f38d12a44"),
                column: "IconUrl",
                value: "FitFox/wwwroot/images/No_Image_Available.jpg");

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("b28e13d4-6cb9-4ad1-9869-eaf0c1870ec3"),
                column: "IconUrl",
                value: "FitFox/wwwroot/images/No_Image_Available.jpg");

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("cd4a6277-0f39-4b24-b86c-167ccc0a5b61"),
                column: "IconUrl",
                value: "FitFox/wwwroot/images/No_Image_Available.jpg");

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("d8b0309a-bc74-4fa8-bb13-0f1c3c9e5a22"),
                column: "IconUrl",
                value: "FitFox/wwwroot/images/No_Image_Available.jpg");

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("f6b7903a-41e0-4753-9ad0-d8ac584c5c6f"),
                column: "IconUrl",
                value: "FitFox/wwwroot/images/No_Image_Available.jpg");
        }
    }
}
