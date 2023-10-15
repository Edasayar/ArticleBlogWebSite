using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ArticleBlogSiteDAL.Migrations
{
    public partial class update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppWriters");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppWriters",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppWriters", x => x.ID);
                });

            migrationBuilder.UpdateData(
                table: "Article",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 22, 26, 17, 314, DateTimeKind.Local).AddTicks(2396));

            migrationBuilder.UpdateData(
                table: "Article",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 22, 26, 17, 314, DateTimeKind.Local).AddTicks(2399));

            migrationBuilder.UpdateData(
                table: "Article",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 22, 26, 17, 314, DateTimeKind.Local).AddTicks(2401));

            migrationBuilder.UpdateData(
                table: "Article",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 22, 26, 17, 314, DateTimeKind.Local).AddTicks(2403));

            migrationBuilder.UpdateData(
                table: "Article",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 22, 26, 17, 314, DateTimeKind.Local).AddTicks(2428));

            migrationBuilder.UpdateData(
                table: "Article",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 22, 26, 17, 314, DateTimeKind.Local).AddTicks(2431));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: -2,
                column: "ConcurrencyStamp",
                value: "38ed729f-48fc-4e61-bc0e-fbb973c1079d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: -1,
                column: "ConcurrencyStamp",
                value: "8dc86583-a2eb-4cd0-b773-9ceeafbe3331");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 22, 26, 17, 314, DateTimeKind.Local).AddTicks(2766));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 22, 26, 17, 314, DateTimeKind.Local).AddTicks(2769));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 22, 26, 17, 314, DateTimeKind.Local).AddTicks(2805));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 22, 26, 17, 314, DateTimeKind.Local).AddTicks(2807));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 22, 26, 17, 314, DateTimeKind.Local).AddTicks(3444));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 22, 26, 17, 314, DateTimeKind.Local).AddTicks(3447));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 22, 26, 17, 314, DateTimeKind.Local).AddTicks(3448));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 22, 26, 17, 314, DateTimeKind.Local).AddTicks(3449));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 22, 26, 17, 314, DateTimeKind.Local).AddTicks(3451));

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 22, 26, 17, 314, DateTimeKind.Local).AddTicks(3793));

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 22, 26, 17, 314, DateTimeKind.Local).AddTicks(3796));

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 22, 26, 17, 314, DateTimeKind.Local).AddTicks(3798));

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 22, 26, 17, 314, DateTimeKind.Local).AddTicks(3799));

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 22, 26, 17, 314, DateTimeKind.Local).AddTicks(3801));

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 22, 26, 17, 314, DateTimeKind.Local).AddTicks(3802));
        }
    }
}
