using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ArticleBlogSiteDAL.Migrations.ArticleBlogSiteDb
{
    public partial class update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 9, 43, 6, 49, DateTimeKind.Local).AddTicks(852));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 9, 43, 6, 49, DateTimeKind.Local).AddTicks(855));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 9, 43, 6, 49, DateTimeKind.Local).AddTicks(857));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 9, 43, 6, 49, DateTimeKind.Local).AddTicks(859));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 9, 43, 6, 49, DateTimeKind.Local).AddTicks(861));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 9, 43, 6, 49, DateTimeKind.Local).AddTicks(863));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 9, 43, 6, 49, DateTimeKind.Local).AddTicks(1225));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 9, 43, 6, 49, DateTimeKind.Local).AddTicks(1228));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 9, 43, 6, 49, DateTimeKind.Local).AddTicks(1230));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 9, 43, 6, 49, DateTimeKind.Local).AddTicks(1256));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 9, 43, 6, 49, DateTimeKind.Local).AddTicks(1730));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 9, 43, 6, 49, DateTimeKind.Local).AddTicks(1733));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 9, 43, 6, 49, DateTimeKind.Local).AddTicks(1735));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 9, 43, 6, 49, DateTimeKind.Local).AddTicks(1736));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 9, 43, 6, 49, DateTimeKind.Local).AddTicks(1738));

            migrationBuilder.UpdateData(
                table: "Ratingss",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 9, 43, 6, 49, DateTimeKind.Local).AddTicks(1989));

            migrationBuilder.UpdateData(
                table: "Ratingss",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 9, 43, 6, 49, DateTimeKind.Local).AddTicks(1991));

            migrationBuilder.UpdateData(
                table: "Ratingss",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 9, 43, 6, 49, DateTimeKind.Local).AddTicks(1993));

            migrationBuilder.UpdateData(
                table: "Ratingss",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 9, 43, 6, 49, DateTimeKind.Local).AddTicks(1995));

            migrationBuilder.UpdateData(
                table: "Ratingss",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 9, 43, 6, 49, DateTimeKind.Local).AddTicks(1996));

            migrationBuilder.UpdateData(
                table: "Ratingss",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 9, 43, 6, 49, DateTimeKind.Local).AddTicks(1998));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
