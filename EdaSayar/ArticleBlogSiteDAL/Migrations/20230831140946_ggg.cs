using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ArticleBlogSiteDAL.Migrations
{
    public partial class ggg : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "AspNetUsers",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NormalizedUserName",
                table: "AspNetUsers",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(35)",
                oldMaxLength: 35,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NormalizedEmail",
                table: "AspNetUsers",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(40)",
                oldMaxLength: 40,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "AspNetUsers",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(40)",
                oldMaxLength: 40,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Article",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 31, 17, 9, 46, 217, DateTimeKind.Local).AddTicks(1692));

            migrationBuilder.UpdateData(
                table: "Article",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 31, 17, 9, 46, 217, DateTimeKind.Local).AddTicks(1695));

            migrationBuilder.UpdateData(
                table: "Article",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 31, 17, 9, 46, 217, DateTimeKind.Local).AddTicks(1698));

            migrationBuilder.UpdateData(
                table: "Article",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 31, 17, 9, 46, 217, DateTimeKind.Local).AddTicks(1700));

            migrationBuilder.UpdateData(
                table: "Article",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 31, 17, 9, 46, 217, DateTimeKind.Local).AddTicks(1702));

            migrationBuilder.UpdateData(
                table: "Article",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 31, 17, 9, 46, 217, DateTimeKind.Local).AddTicks(1704));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: -2,
                column: "ConcurrencyStamp",
                value: "97a5043f-3d83-4aca-90b7-170d1d75aa07");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: -1,
                column: "ConcurrencyStamp",
                value: "8a1fce9f-9672-484d-b40e-5e731bbe429b");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { 1, 0, "c5e568e8-72a7-408e-8dc1-3f3e2ca43ea8", "selino@gmail.com", false, false, null, null, null, "b2d1349ea3f52597f37566ed4095e10729c8329c612b64563849dcf29ee9de6e", null, false, null, false, "selino" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 31, 17, 9, 46, 217, DateTimeKind.Local).AddTicks(2103));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 31, 17, 9, 46, 217, DateTimeKind.Local).AddTicks(2105));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 31, 17, 9, 46, 217, DateTimeKind.Local).AddTicks(2107));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 31, 17, 9, 46, 217, DateTimeKind.Local).AddTicks(2109));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 31, 17, 9, 46, 217, DateTimeKind.Local).AddTicks(2932));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 31, 17, 9, 46, 217, DateTimeKind.Local).AddTicks(2934));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 31, 17, 9, 46, 217, DateTimeKind.Local).AddTicks(2935));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 31, 17, 9, 46, 217, DateTimeKind.Local).AddTicks(2937));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 31, 17, 9, 46, 217, DateTimeKind.Local).AddTicks(2938));

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 31, 17, 9, 46, 217, DateTimeKind.Local).AddTicks(3665));

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 31, 17, 9, 46, 217, DateTimeKind.Local).AddTicks(3667));

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 31, 17, 9, 46, 217, DateTimeKind.Local).AddTicks(3669));

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 31, 17, 9, 46, 217, DateTimeKind.Local).AddTicks(3670));

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 31, 17, 9, 46, 217, DateTimeKind.Local).AddTicks(3672));

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 31, 17, 9, 46, 217, DateTimeKind.Local).AddTicks(3674));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "AspNetUsers",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NormalizedUserName",
                table: "AspNetUsers",
                type: "nvarchar(35)",
                maxLength: 35,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NormalizedEmail",
                table: "AspNetUsers",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "AspNetUsers",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

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
    }
}
