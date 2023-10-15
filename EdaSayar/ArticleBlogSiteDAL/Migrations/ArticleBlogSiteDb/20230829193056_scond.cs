using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ArticleBlogSiteDAL.Migrations.ArticleBlogSiteDb
{
    public partial class scond : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 22, 30, 55, 743, DateTimeKind.Local).AddTicks(5484));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 22, 30, 55, 743, DateTimeKind.Local).AddTicks(5487));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 22, 30, 55, 743, DateTimeKind.Local).AddTicks(5490));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 22, 30, 55, 743, DateTimeKind.Local).AddTicks(5491));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 22, 30, 55, 743, DateTimeKind.Local).AddTicks(5493));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 22, 30, 55, 743, DateTimeKind.Local).AddTicks(5495));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 22, 30, 55, 743, DateTimeKind.Local).AddTicks(5905));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 22, 30, 55, 743, DateTimeKind.Local).AddTicks(5907));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 22, 30, 55, 743, DateTimeKind.Local).AddTicks(5909));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 22, 30, 55, 743, DateTimeKind.Local).AddTicks(5911));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 22, 30, 55, 743, DateTimeKind.Local).AddTicks(6424));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 22, 30, 55, 743, DateTimeKind.Local).AddTicks(6425));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 22, 30, 55, 743, DateTimeKind.Local).AddTicks(6427));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 22, 30, 55, 743, DateTimeKind.Local).AddTicks(6429));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 22, 30, 55, 743, DateTimeKind.Local).AddTicks(6430));

            migrationBuilder.UpdateData(
                table: "Ratingss",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 22, 30, 55, 743, DateTimeKind.Local).AddTicks(6705));

            migrationBuilder.UpdateData(
                table: "Ratingss",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 22, 30, 55, 743, DateTimeKind.Local).AddTicks(6707));

            migrationBuilder.UpdateData(
                table: "Ratingss",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 22, 30, 55, 743, DateTimeKind.Local).AddTicks(6709));

            migrationBuilder.UpdateData(
                table: "Ratingss",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 22, 30, 55, 743, DateTimeKind.Local).AddTicks(6710));

            migrationBuilder.UpdateData(
                table: "Ratingss",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 22, 30, 55, 743, DateTimeKind.Local).AddTicks(6712));

            migrationBuilder.UpdateData(
                table: "Ratingss",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 22, 30, 55, 743, DateTimeKind.Local).AddTicks(6714));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 22, 27, 6, 395, DateTimeKind.Local).AddTicks(1470));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 22, 27, 6, 395, DateTimeKind.Local).AddTicks(1473));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 22, 27, 6, 395, DateTimeKind.Local).AddTicks(1475));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 22, 27, 6, 395, DateTimeKind.Local).AddTicks(1477));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 22, 27, 6, 395, DateTimeKind.Local).AddTicks(1478));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 22, 27, 6, 395, DateTimeKind.Local).AddTicks(1480));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 22, 27, 6, 395, DateTimeKind.Local).AddTicks(1842));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 22, 27, 6, 395, DateTimeKind.Local).AddTicks(1844));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 22, 27, 6, 395, DateTimeKind.Local).AddTicks(1845));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 22, 27, 6, 395, DateTimeKind.Local).AddTicks(1847));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 22, 27, 6, 395, DateTimeKind.Local).AddTicks(2268));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 22, 27, 6, 395, DateTimeKind.Local).AddTicks(2270));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 22, 27, 6, 395, DateTimeKind.Local).AddTicks(2272));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 22, 27, 6, 395, DateTimeKind.Local).AddTicks(2273));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 22, 27, 6, 395, DateTimeKind.Local).AddTicks(2274));

            migrationBuilder.UpdateData(
                table: "Ratingss",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 22, 27, 6, 395, DateTimeKind.Local).AddTicks(2529));

            migrationBuilder.UpdateData(
                table: "Ratingss",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 22, 27, 6, 395, DateTimeKind.Local).AddTicks(2531));

            migrationBuilder.UpdateData(
                table: "Ratingss",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 22, 27, 6, 395, DateTimeKind.Local).AddTicks(2532));

            migrationBuilder.UpdateData(
                table: "Ratingss",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 22, 27, 6, 395, DateTimeKind.Local).AddTicks(2534));

            migrationBuilder.UpdateData(
                table: "Ratingss",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 22, 27, 6, 395, DateTimeKind.Local).AddTicks(2535));

            migrationBuilder.UpdateData(
                table: "Ratingss",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 22, 27, 6, 395, DateTimeKind.Local).AddTicks(2536));
        }
    }
}
