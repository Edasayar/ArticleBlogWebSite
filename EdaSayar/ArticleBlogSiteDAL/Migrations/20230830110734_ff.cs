using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ArticleBlogSiteDAL.Migrations
{
    public partial class ff : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Article",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 14, 7, 34, 586, DateTimeKind.Local).AddTicks(5547));

            migrationBuilder.UpdateData(
                table: "Article",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 14, 7, 34, 586, DateTimeKind.Local).AddTicks(5552));

            migrationBuilder.UpdateData(
                table: "Article",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 14, 7, 34, 586, DateTimeKind.Local).AddTicks(5554));

            migrationBuilder.UpdateData(
                table: "Article",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 14, 7, 34, 586, DateTimeKind.Local).AddTicks(5556));

            migrationBuilder.UpdateData(
                table: "Article",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 14, 7, 34, 586, DateTimeKind.Local).AddTicks(5557));

            migrationBuilder.UpdateData(
                table: "Article",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 14, 7, 34, 586, DateTimeKind.Local).AddTicks(5583));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: -2,
                column: "ConcurrencyStamp",
                value: "1b42b3d3-6557-4c43-9c04-a1057e5615c0");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: -1,
                column: "ConcurrencyStamp",
                value: "c0b64f54-e147-4191-b9ab-6462c60e279d");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 14, 7, 34, 586, DateTimeKind.Local).AddTicks(5894));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 14, 7, 34, 586, DateTimeKind.Local).AddTicks(5896));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 14, 7, 34, 586, DateTimeKind.Local).AddTicks(5917));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 14, 7, 34, 586, DateTimeKind.Local).AddTicks(5920));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 14, 7, 34, 586, DateTimeKind.Local).AddTicks(6452));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 14, 7, 34, 586, DateTimeKind.Local).AddTicks(6453));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 14, 7, 34, 586, DateTimeKind.Local).AddTicks(6455));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 14, 7, 34, 586, DateTimeKind.Local).AddTicks(6456));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 14, 7, 34, 586, DateTimeKind.Local).AddTicks(6458));

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 14, 7, 34, 586, DateTimeKind.Local).AddTicks(6740));

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 14, 7, 34, 586, DateTimeKind.Local).AddTicks(6742));

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 14, 7, 34, 586, DateTimeKind.Local).AddTicks(6744));

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 14, 7, 34, 586, DateTimeKind.Local).AddTicks(6745));

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 14, 7, 34, 586, DateTimeKind.Local).AddTicks(6747));

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 14, 7, 34, 586, DateTimeKind.Local).AddTicks(6748));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Article",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 9, 43, 54, 458, DateTimeKind.Local).AddTicks(2308));

            migrationBuilder.UpdateData(
                table: "Article",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 9, 43, 54, 458, DateTimeKind.Local).AddTicks(2311));

            migrationBuilder.UpdateData(
                table: "Article",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 9, 43, 54, 458, DateTimeKind.Local).AddTicks(2313));

            migrationBuilder.UpdateData(
                table: "Article",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 9, 43, 54, 458, DateTimeKind.Local).AddTicks(2315));

            migrationBuilder.UpdateData(
                table: "Article",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 9, 43, 54, 458, DateTimeKind.Local).AddTicks(2317));

            migrationBuilder.UpdateData(
                table: "Article",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 9, 43, 54, 458, DateTimeKind.Local).AddTicks(2318));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: -2,
                column: "ConcurrencyStamp",
                value: "b84050c2-e5a4-4677-a8cb-a3e70b210ba8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: -1,
                column: "ConcurrencyStamp",
                value: "79d2245e-40bd-4d73-bafc-0729a25f0bb3");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 9, 43, 54, 458, DateTimeKind.Local).AddTicks(2712));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 9, 43, 54, 458, DateTimeKind.Local).AddTicks(2715));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 9, 43, 54, 458, DateTimeKind.Local).AddTicks(2716));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 9, 43, 54, 458, DateTimeKind.Local).AddTicks(2718));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 9, 43, 54, 458, DateTimeKind.Local).AddTicks(3357));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 9, 43, 54, 458, DateTimeKind.Local).AddTicks(3359));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 9, 43, 54, 458, DateTimeKind.Local).AddTicks(3361));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 9, 43, 54, 458, DateTimeKind.Local).AddTicks(3362));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 9, 43, 54, 458, DateTimeKind.Local).AddTicks(3363));

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 9, 43, 54, 458, DateTimeKind.Local).AddTicks(3635));

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 9, 43, 54, 458, DateTimeKind.Local).AddTicks(3663));

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 9, 43, 54, 458, DateTimeKind.Local).AddTicks(3665));

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 9, 43, 54, 458, DateTimeKind.Local).AddTicks(3666));

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 9, 43, 54, 458, DateTimeKind.Local).AddTicks(3668));

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 9, 43, 54, 458, DateTimeKind.Local).AddTicks(3669));
        }
    }
}
