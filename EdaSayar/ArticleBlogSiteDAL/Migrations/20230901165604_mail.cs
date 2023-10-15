using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ArticleBlogSiteDAL.Migrations
{
    public partial class mail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Confirm",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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
                columns: new[] { "ConcurrencyStamp", "FirstName", "Image", "LastName" },
                values: new object[] { "e0fc8a3e-02f6-44b1-b287-ed3098e6cf02", "Selin", "image.jpg", "Öztürk" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "FirstName", "Image", "LastName" },
                values: new object[] { "f7688e5f-59dc-4680-903b-f818ed43fad0", "admin", "image.jpg", "Admin" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Confirm",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "AspNetUsers");

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
    }
}
