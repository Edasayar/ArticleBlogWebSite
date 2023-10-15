using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ArticleBlogSiteDAL.Migrations
{
    public partial class güncel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Article",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 18, 6, 33, 161, DateTimeKind.Local).AddTicks(8023));

            migrationBuilder.UpdateData(
                table: "Article",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 18, 6, 33, 161, DateTimeKind.Local).AddTicks(8026));

            migrationBuilder.UpdateData(
                table: "Article",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 18, 6, 33, 161, DateTimeKind.Local).AddTicks(8028));

            migrationBuilder.UpdateData(
                table: "Article",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 18, 6, 33, 161, DateTimeKind.Local).AddTicks(8030));

            migrationBuilder.UpdateData(
                table: "Article",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 18, 6, 33, 161, DateTimeKind.Local).AddTicks(8032));

            migrationBuilder.UpdateData(
                table: "Article",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 18, 6, 33, 161, DateTimeKind.Local).AddTicks(8034));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: -2,
                column: "ConcurrencyStamp",
                value: "6b9c1927-f233-484a-b34a-30fc6efd8e20");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: -1,
                column: "ConcurrencyStamp",
                value: "af848300-dd7e-43e2-a215-d3ec124bf259");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName" },
                values: new object[] { "9db4452f-6747-466e-9356-0e307444f815", "Ad", "Soyad" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName" },
                values: new object[] { "73e1af5b-228d-4f34-845a-d4d8c85339b0", "Ad", "Soyad" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 18, 6, 33, 161, DateTimeKind.Local).AddTicks(8375));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 18, 6, 33, 161, DateTimeKind.Local).AddTicks(8377));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 18, 6, 33, 161, DateTimeKind.Local).AddTicks(8379));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 18, 6, 33, 161, DateTimeKind.Local).AddTicks(8380));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 18, 6, 33, 161, DateTimeKind.Local).AddTicks(8995));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 18, 6, 33, 161, DateTimeKind.Local).AddTicks(8997));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 18, 6, 33, 161, DateTimeKind.Local).AddTicks(8998));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 18, 6, 33, 161, DateTimeKind.Local).AddTicks(9000));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 18, 6, 33, 161, DateTimeKind.Local).AddTicks(9001));

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 18, 6, 33, 161, DateTimeKind.Local).AddTicks(9305));

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 18, 6, 33, 161, DateTimeKind.Local).AddTicks(9307));

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 18, 6, 33, 161, DateTimeKind.Local).AddTicks(9308));

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 18, 6, 33, 161, DateTimeKind.Local).AddTicks(9310));

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 18, 6, 33, 161, DateTimeKind.Local).AddTicks(9311));

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 18, 6, 33, 161, DateTimeKind.Local).AddTicks(9313));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Article",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 31, 17, 19, 48, 769, DateTimeKind.Local).AddTicks(8735));

            migrationBuilder.UpdateData(
                table: "Article",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 31, 17, 19, 48, 769, DateTimeKind.Local).AddTicks(8739));

            migrationBuilder.UpdateData(
                table: "Article",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 31, 17, 19, 48, 769, DateTimeKind.Local).AddTicks(8742));

            migrationBuilder.UpdateData(
                table: "Article",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 31, 17, 19, 48, 769, DateTimeKind.Local).AddTicks(8744));

            migrationBuilder.UpdateData(
                table: "Article",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 31, 17, 19, 48, 769, DateTimeKind.Local).AddTicks(8745));

            migrationBuilder.UpdateData(
                table: "Article",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 31, 17, 19, 48, 769, DateTimeKind.Local).AddTicks(8747));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: -2,
                column: "ConcurrencyStamp",
                value: "fe8e7639-7063-4bdb-bddc-483a87cbaa24");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: -1,
                column: "ConcurrencyStamp",
                value: "1df7da2d-9643-4afc-a1b7-edf81406073b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "ab87e927-be30-4a1a-a130-18a991a18b42");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "183ad47d-2438-4e9a-a64d-dc788e748100");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 31, 17, 19, 48, 769, DateTimeKind.Local).AddTicks(9105));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 31, 17, 19, 48, 769, DateTimeKind.Local).AddTicks(9107));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 31, 17, 19, 48, 769, DateTimeKind.Local).AddTicks(9109));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 31, 17, 19, 48, 769, DateTimeKind.Local).AddTicks(9110));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 31, 17, 19, 48, 769, DateTimeKind.Local).AddTicks(9793));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 31, 17, 19, 48, 769, DateTimeKind.Local).AddTicks(9795));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 31, 17, 19, 48, 769, DateTimeKind.Local).AddTicks(9796));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 31, 17, 19, 48, 769, DateTimeKind.Local).AddTicks(9798));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 31, 17, 19, 48, 769, DateTimeKind.Local).AddTicks(9799));

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 31, 17, 19, 48, 770, DateTimeKind.Local).AddTicks(141));

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 31, 17, 19, 48, 770, DateTimeKind.Local).AddTicks(143));

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 31, 17, 19, 48, 770, DateTimeKind.Local).AddTicks(145));

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 31, 17, 19, 48, 770, DateTimeKind.Local).AddTicks(146));

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 31, 17, 19, 48, 770, DateTimeKind.Local).AddTicks(148));

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 31, 17, 19, 48, 770, DateTimeKind.Local).AddTicks(149));
        }
    }
}
