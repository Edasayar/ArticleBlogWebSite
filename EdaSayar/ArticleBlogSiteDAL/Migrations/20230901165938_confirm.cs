using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ArticleBlogSiteDAL.Migrations
{
    public partial class confirm : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Confirm",
                table: "AspNetUsers",
                newName: "ConfirmCode");

            migrationBuilder.UpdateData(
                table: "Article",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 19, 59, 37, 969, DateTimeKind.Local).AddTicks(6420));

            migrationBuilder.UpdateData(
                table: "Article",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 19, 59, 37, 969, DateTimeKind.Local).AddTicks(6423));

            migrationBuilder.UpdateData(
                table: "Article",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 19, 59, 37, 969, DateTimeKind.Local).AddTicks(6425));

            migrationBuilder.UpdateData(
                table: "Article",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 19, 59, 37, 969, DateTimeKind.Local).AddTicks(6427));

            migrationBuilder.UpdateData(
                table: "Article",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 19, 59, 37, 969, DateTimeKind.Local).AddTicks(6429));

            migrationBuilder.UpdateData(
                table: "Article",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 19, 59, 37, 969, DateTimeKind.Local).AddTicks(6472));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: -2,
                column: "ConcurrencyStamp",
                value: "a0e758bd-44e8-4b46-b925-74c5d453f491");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: -1,
                column: "ConcurrencyStamp",
                value: "8533a387-28eb-42de-9524-c4495796fe8a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "66a6978b-ed45-42c4-9ff7-49b24d8812d0");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "06623c7e-7c6c-4a3b-886d-ccbe6285c414");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 19, 59, 37, 969, DateTimeKind.Local).AddTicks(7879));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 19, 59, 37, 969, DateTimeKind.Local).AddTicks(7881));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 19, 59, 37, 969, DateTimeKind.Local).AddTicks(7882));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 19, 59, 37, 969, DateTimeKind.Local).AddTicks(7884));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 19, 59, 37, 969, DateTimeKind.Local).AddTicks(8578));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 19, 59, 37, 969, DateTimeKind.Local).AddTicks(8580));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 19, 59, 37, 969, DateTimeKind.Local).AddTicks(8581));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 19, 59, 37, 969, DateTimeKind.Local).AddTicks(8583));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 19, 59, 37, 969, DateTimeKind.Local).AddTicks(8584));

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 19, 59, 37, 969, DateTimeKind.Local).AddTicks(8975));

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 19, 59, 37, 969, DateTimeKind.Local).AddTicks(8977));

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 19, 59, 37, 969, DateTimeKind.Local).AddTicks(8978));

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 19, 59, 37, 969, DateTimeKind.Local).AddTicks(8980));

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 19, 59, 37, 969, DateTimeKind.Local).AddTicks(8981));

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 19, 59, 37, 969, DateTimeKind.Local).AddTicks(8983));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ConfirmCode",
                table: "AspNetUsers",
                newName: "Confirm");

            migrationBuilder.UpdateData(
                table: "Article",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 19, 56, 4, 193, DateTimeKind.Local).AddTicks(5418));

            migrationBuilder.UpdateData(
                table: "Article",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 19, 56, 4, 193, DateTimeKind.Local).AddTicks(5421));

            migrationBuilder.UpdateData(
                table: "Article",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 19, 56, 4, 193, DateTimeKind.Local).AddTicks(5424));

            migrationBuilder.UpdateData(
                table: "Article",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 19, 56, 4, 193, DateTimeKind.Local).AddTicks(5426));

            migrationBuilder.UpdateData(
                table: "Article",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 19, 56, 4, 193, DateTimeKind.Local).AddTicks(5427));

            migrationBuilder.UpdateData(
                table: "Article",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 19, 56, 4, 193, DateTimeKind.Local).AddTicks(5429));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: -2,
                column: "ConcurrencyStamp",
                value: "dac2229c-d7c4-4fc7-bba3-7ec4e0c528d9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: -1,
                column: "ConcurrencyStamp",
                value: "045cc262-4209-44a4-9be5-8aae929a2113");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "e0fc8a3e-02f6-44b1-b287-ed3098e6cf02");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "f7688e5f-59dc-4680-903b-f818ed43fad0");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 19, 56, 4, 193, DateTimeKind.Local).AddTicks(5874));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 19, 56, 4, 193, DateTimeKind.Local).AddTicks(5877));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 19, 56, 4, 193, DateTimeKind.Local).AddTicks(5879));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 19, 56, 4, 193, DateTimeKind.Local).AddTicks(5880));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 19, 56, 4, 193, DateTimeKind.Local).AddTicks(6749));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 19, 56, 4, 193, DateTimeKind.Local).AddTicks(6752));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 19, 56, 4, 193, DateTimeKind.Local).AddTicks(6754));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 19, 56, 4, 193, DateTimeKind.Local).AddTicks(6755));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 19, 56, 4, 193, DateTimeKind.Local).AddTicks(6757));

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 19, 56, 4, 193, DateTimeKind.Local).AddTicks(7185));

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 19, 56, 4, 193, DateTimeKind.Local).AddTicks(7187));

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 19, 56, 4, 193, DateTimeKind.Local).AddTicks(7189));

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 19, 56, 4, 193, DateTimeKind.Local).AddTicks(7190));

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 19, 56, 4, 193, DateTimeKind.Local).AddTicks(7192));

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 19, 56, 4, 193, DateTimeKind.Local).AddTicks(7194));
        }
    }
}
