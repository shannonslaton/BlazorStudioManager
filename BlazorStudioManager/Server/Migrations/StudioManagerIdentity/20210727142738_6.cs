using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorStudioManager.Server.Migrations.StudioManagerIdentity
{
    public partial class _6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "administrator",
                column: "ConcurrencyStamp",
                value: "baea2dfb-1b21-43d8-865c-1751a1846abc");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bronze",
                column: "ConcurrencyStamp",
                value: "47f91b94-bbe3-4ff5-99b1-45ca656bf239");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "gold",
                column: "ConcurrencyStamp",
                value: "e09f974e-8972-4e2b-a147-e262fe323e0b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "guest",
                column: "ConcurrencyStamp",
                value: "0c55f295-037b-4643-ba90-6ed8435eb9c7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "platinum",
                column: "ConcurrencyStamp",
                value: "ae4a4dc8-07ad-4fc9-a544-5084440a8b79");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "showbronze",
                column: "ConcurrencyStamp",
                value: "d4dd98c8-5231-452a-99d1-b982970a0b76");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "showgold",
                column: "ConcurrencyStamp",
                value: "e2f07fb3-56e7-417e-9b25-17ed3bf690b4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "showguest",
                column: "ConcurrencyStamp",
                value: "43d761e9-efc8-4c43-96b7-1e15bea6d7c9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "showplatinum",
                column: "ConcurrencyStamp",
                value: "c4fe2b2d-c82d-42f6-88f0-cd038ac35e8c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "showsilver",
                column: "ConcurrencyStamp",
                value: "e9e48aa4-63af-4fed-b138-ff49ac7f95d3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "showtitanium",
                column: "ConcurrencyStamp",
                value: "3596795d-6144-4970-9b9a-f34387592241");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "silver",
                column: "ConcurrencyStamp",
                value: "7d51666d-09aa-4a2d-ae63-11f906c55d11");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "titanium",
                column: "ConcurrencyStamp",
                value: "f65b50f0-dcf9-4e9e-96a2-1f3cdbfb6754");

            migrationBuilder.UpdateData(
                table: "Disciplines",
                keyColumn: "RecId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 27, 14, 27, 37, 702, DateTimeKind.Utc).AddTicks(4850), new DateTime(2021, 7, 27, 14, 27, 37, 702, DateTimeKind.Utc).AddTicks(4845) });

            migrationBuilder.UpdateData(
                table: "Disciplines",
                keyColumn: "RecId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 27, 14, 27, 37, 702, DateTimeKind.Utc).AddTicks(5887), new DateTime(2021, 7, 27, 14, 27, 37, 702, DateTimeKind.Utc).AddTicks(5885) });

            migrationBuilder.UpdateData(
                table: "Disciplines",
                keyColumn: "RecId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 27, 14, 27, 37, 702, DateTimeKind.Utc).AddTicks(5890), new DateTime(2021, 7, 27, 14, 27, 37, 702, DateTimeKind.Utc).AddTicks(5890) });

            migrationBuilder.UpdateData(
                table: "Disciplines",
                keyColumn: "RecId",
                keyValue: 4,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 27, 14, 27, 37, 702, DateTimeKind.Utc).AddTicks(5892), new DateTime(2021, 7, 27, 14, 27, 37, 702, DateTimeKind.Utc).AddTicks(5891) });

            migrationBuilder.UpdateData(
                table: "Disciplines",
                keyColumn: "RecId",
                keyValue: 5,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 27, 14, 27, 37, 702, DateTimeKind.Utc).AddTicks(5894), new DateTime(2021, 7, 27, 14, 27, 37, 702, DateTimeKind.Utc).AddTicks(5893) });

            migrationBuilder.UpdateData(
                table: "Disciplines",
                keyColumn: "RecId",
                keyValue: 6,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 27, 14, 27, 37, 702, DateTimeKind.Utc).AddTicks(5895), new DateTime(2021, 7, 27, 14, 27, 37, 702, DateTimeKind.Utc).AddTicks(5895) });

            migrationBuilder.UpdateData(
                table: "Disciplines",
                keyColumn: "RecId",
                keyValue: 7,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 27, 14, 27, 37, 702, DateTimeKind.Utc).AddTicks(5897), new DateTime(2021, 7, 27, 14, 27, 37, 702, DateTimeKind.Utc).AddTicks(5897) });

            migrationBuilder.UpdateData(
                table: "Disciplines",
                keyColumn: "RecId",
                keyValue: 8,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 27, 14, 27, 37, 702, DateTimeKind.Utc).AddTicks(5899), new DateTime(2021, 7, 27, 14, 27, 37, 702, DateTimeKind.Utc).AddTicks(5898) });

            migrationBuilder.UpdateData(
                table: "Disciplines",
                keyColumn: "RecId",
                keyValue: 9,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 27, 14, 27, 37, 702, DateTimeKind.Utc).AddTicks(5900), new DateTime(2021, 7, 27, 14, 27, 37, 702, DateTimeKind.Utc).AddTicks(5899) });

            migrationBuilder.UpdateData(
                table: "Disciplines",
                keyColumn: "RecId",
                keyValue: 10,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 27, 14, 27, 37, 702, DateTimeKind.Utc).AddTicks(5939), new DateTime(2021, 7, 27, 14, 27, 37, 702, DateTimeKind.Utc).AddTicks(5938) });

            migrationBuilder.UpdateData(
                table: "Disciplines",
                keyColumn: "RecId",
                keyValue: 11,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 27, 14, 27, 37, 702, DateTimeKind.Utc).AddTicks(5941), new DateTime(2021, 7, 27, 14, 27, 37, 702, DateTimeKind.Utc).AddTicks(5940) });

            migrationBuilder.UpdateData(
                table: "Disciplines",
                keyColumn: "RecId",
                keyValue: 12,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 27, 14, 27, 37, 702, DateTimeKind.Utc).AddTicks(5943), new DateTime(2021, 7, 27, 14, 27, 37, 702, DateTimeKind.Utc).AddTicks(5943) });

            migrationBuilder.UpdateData(
                table: "Disciplines",
                keyColumn: "RecId",
                keyValue: 13,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 27, 14, 27, 37, 702, DateTimeKind.Utc).AddTicks(5946), new DateTime(2021, 7, 27, 14, 27, 37, 702, DateTimeKind.Utc).AddTicks(5945) });

            migrationBuilder.UpdateData(
                table: "Disciplines",
                keyColumn: "RecId",
                keyValue: 14,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 27, 14, 27, 37, 702, DateTimeKind.Utc).AddTicks(5947), new DateTime(2021, 7, 27, 14, 27, 37, 702, DateTimeKind.Utc).AddTicks(5947) });

            migrationBuilder.UpdateData(
                table: "Disciplines",
                keyColumn: "RecId",
                keyValue: 15,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 27, 14, 27, 37, 702, DateTimeKind.Utc).AddTicks(5949), new DateTime(2021, 7, 27, 14, 27, 37, 702, DateTimeKind.Utc).AddTicks(5948) });

            migrationBuilder.UpdateData(
                table: "Disciplines",
                keyColumn: "RecId",
                keyValue: 16,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 27, 14, 27, 37, 702, DateTimeKind.Utc).AddTicks(5950), new DateTime(2021, 7, 27, 14, 27, 37, 702, DateTimeKind.Utc).AddTicks(5950) });

            migrationBuilder.UpdateData(
                table: "Disciplines",
                keyColumn: "RecId",
                keyValue: 17,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 27, 14, 27, 37, 702, DateTimeKind.Utc).AddTicks(5952), new DateTime(2021, 7, 27, 14, 27, 37, 702, DateTimeKind.Utc).AddTicks(5951) });

            migrationBuilder.UpdateData(
                table: "Disciplines",
                keyColumn: "RecId",
                keyValue: 18,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 27, 14, 27, 37, 702, DateTimeKind.Utc).AddTicks(5953), new DateTime(2021, 7, 27, 14, 27, 37, 702, DateTimeKind.Utc).AddTicks(5953) });

            migrationBuilder.UpdateData(
                table: "ShareLevels",
                keyColumn: "RecId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 27, 14, 27, 37, 703, DateTimeKind.Utc).AddTicks(1682), new DateTime(2021, 7, 27, 14, 27, 37, 703, DateTimeKind.Utc).AddTicks(1679) });

            migrationBuilder.UpdateData(
                table: "ShareLevels",
                keyColumn: "RecId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 27, 14, 27, 37, 703, DateTimeKind.Utc).AddTicks(2972), new DateTime(2021, 7, 27, 14, 27, 37, 703, DateTimeKind.Utc).AddTicks(2970) });

            migrationBuilder.UpdateData(
                table: "ShareLevels",
                keyColumn: "RecId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 27, 14, 27, 37, 703, DateTimeKind.Utc).AddTicks(2975), new DateTime(2021, 7, 27, 14, 27, 37, 703, DateTimeKind.Utc).AddTicks(2974) });

            migrationBuilder.UpdateData(
                table: "ShareLevels",
                keyColumn: "RecId",
                keyValue: 4,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 27, 14, 27, 37, 703, DateTimeKind.Utc).AddTicks(2976), new DateTime(2021, 7, 27, 14, 27, 37, 703, DateTimeKind.Utc).AddTicks(2976) });

            migrationBuilder.UpdateData(
                table: "ShareLevels",
                keyColumn: "RecId",
                keyValue: 5,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 27, 14, 27, 37, 703, DateTimeKind.Utc).AddTicks(2978), new DateTime(2021, 7, 27, 14, 27, 37, 703, DateTimeKind.Utc).AddTicks(2977) });

            migrationBuilder.UpdateData(
                table: "ShareLevels",
                keyColumn: "RecId",
                keyValue: 6,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 27, 14, 27, 37, 703, DateTimeKind.Utc).AddTicks(2979), new DateTime(2021, 7, 27, 14, 27, 37, 703, DateTimeKind.Utc).AddTicks(2979) });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "RecId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 27, 14, 27, 37, 703, DateTimeKind.Utc).AddTicks(6505), new DateTime(2021, 7, 27, 14, 27, 37, 703, DateTimeKind.Utc).AddTicks(6503) });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "RecId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 27, 14, 27, 37, 703, DateTimeKind.Utc).AddTicks(8067), new DateTime(2021, 7, 27, 14, 27, 37, 703, DateTimeKind.Utc).AddTicks(8065) });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "RecId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 27, 14, 27, 37, 703, DateTimeKind.Utc).AddTicks(8069), new DateTime(2021, 7, 27, 14, 27, 37, 703, DateTimeKind.Utc).AddTicks(8068) });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "RecId",
                keyValue: 4,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 27, 14, 27, 37, 703, DateTimeKind.Utc).AddTicks(8071), new DateTime(2021, 7, 27, 14, 27, 37, 703, DateTimeKind.Utc).AddTicks(8070) });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "RecId",
                keyValue: 5,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 27, 14, 27, 37, 703, DateTimeKind.Utc).AddTicks(8072), new DateTime(2021, 7, 27, 14, 27, 37, 703, DateTimeKind.Utc).AddTicks(8072) });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "RecId",
                keyValue: 6,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 27, 14, 27, 37, 703, DateTimeKind.Utc).AddTicks(8074), new DateTime(2021, 7, 27, 14, 27, 37, 703, DateTimeKind.Utc).AddTicks(8073) });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "RecId",
                keyValue: 7,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 27, 14, 27, 37, 703, DateTimeKind.Utc).AddTicks(8075), new DateTime(2021, 7, 27, 14, 27, 37, 703, DateTimeKind.Utc).AddTicks(8075) });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "RecId",
                keyValue: 8,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 27, 14, 27, 37, 703, DateTimeKind.Utc).AddTicks(8078), new DateTime(2021, 7, 27, 14, 27, 37, 703, DateTimeKind.Utc).AddTicks(8077) });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "RecId",
                keyValue: 9,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 27, 14, 27, 37, 703, DateTimeKind.Utc).AddTicks(8079), new DateTime(2021, 7, 27, 14, 27, 37, 703, DateTimeKind.Utc).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "RecId",
                keyValue: 10,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 27, 14, 27, 37, 703, DateTimeKind.Utc).AddTicks(8081), new DateTime(2021, 7, 27, 14, 27, 37, 703, DateTimeKind.Utc).AddTicks(8080) });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "RecId",
                keyValue: 11,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 27, 14, 27, 37, 703, DateTimeKind.Utc).AddTicks(8082), new DateTime(2021, 7, 27, 14, 27, 37, 703, DateTimeKind.Utc).AddTicks(8082) });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "RecId",
                keyValue: 12,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 27, 14, 27, 37, 703, DateTimeKind.Utc).AddTicks(8084), new DateTime(2021, 7, 27, 14, 27, 37, 703, DateTimeKind.Utc).AddTicks(8083) });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "RecId",
                keyValue: 13,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 27, 14, 27, 37, 703, DateTimeKind.Utc).AddTicks(8085), new DateTime(2021, 7, 27, 14, 27, 37, 703, DateTimeKind.Utc).AddTicks(8085) });

            migrationBuilder.UpdateData(
                table: "VersionHistories",
                keyColumn: "RecId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 27, 14, 27, 37, 698, DateTimeKind.Utc).AddTicks(7229), new DateTime(2021, 7, 27, 14, 27, 37, 698, DateTimeKind.Utc).AddTicks(7221) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "administrator",
                column: "ConcurrencyStamp",
                value: "ca0548fb-844f-423d-a94e-ec1d20dbe212");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bronze",
                column: "ConcurrencyStamp",
                value: "acc53b5b-859d-4452-b47a-74fe50ced51e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "gold",
                column: "ConcurrencyStamp",
                value: "086bd7f4-0e91-4f31-a152-64e1f23cf311");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "guest",
                column: "ConcurrencyStamp",
                value: "fd5d6b49-5363-47d6-98c3-201336738a66");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "platinum",
                column: "ConcurrencyStamp",
                value: "adef0549-1a58-4e53-b049-7bc5e66252bb");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "showbronze",
                column: "ConcurrencyStamp",
                value: "576901ad-508f-4c0c-ab75-4dfe55873279");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "showgold",
                column: "ConcurrencyStamp",
                value: "cf03d158-bcac-4cef-a2d3-66f545847ed3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "showguest",
                column: "ConcurrencyStamp",
                value: "7975c640-bbb6-4ca3-9ca8-201ac24880d3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "showplatinum",
                column: "ConcurrencyStamp",
                value: "63824080-97bd-4fc7-b6cb-ebfbf042ad04");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "showsilver",
                column: "ConcurrencyStamp",
                value: "dbc3ba7d-4495-4623-8e52-f3fe67e7c0dc");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "showtitanium",
                column: "ConcurrencyStamp",
                value: "a3d2cab6-a334-41c1-b6e0-9fe479d83d17");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "silver",
                column: "ConcurrencyStamp",
                value: "e4c8c4b5-27e0-46f3-a5c2-3fada5f71965");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "titanium",
                column: "ConcurrencyStamp",
                value: "eefa941a-4717-4780-9b6a-d8a808a01d5b");

            migrationBuilder.UpdateData(
                table: "Disciplines",
                keyColumn: "RecId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 25, 15, 29, 56, 264, DateTimeKind.Utc).AddTicks(2543), new DateTime(2021, 7, 25, 15, 29, 56, 264, DateTimeKind.Utc).AddTicks(2539) });

            migrationBuilder.UpdateData(
                table: "Disciplines",
                keyColumn: "RecId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 25, 15, 29, 56, 264, DateTimeKind.Utc).AddTicks(3252), new DateTime(2021, 7, 25, 15, 29, 56, 264, DateTimeKind.Utc).AddTicks(3250) });

            migrationBuilder.UpdateData(
                table: "Disciplines",
                keyColumn: "RecId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 25, 15, 29, 56, 264, DateTimeKind.Utc).AddTicks(3255), new DateTime(2021, 7, 25, 15, 29, 56, 264, DateTimeKind.Utc).AddTicks(3255) });

            migrationBuilder.UpdateData(
                table: "Disciplines",
                keyColumn: "RecId",
                keyValue: 4,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 25, 15, 29, 56, 264, DateTimeKind.Utc).AddTicks(3257), new DateTime(2021, 7, 25, 15, 29, 56, 264, DateTimeKind.Utc).AddTicks(3257) });

            migrationBuilder.UpdateData(
                table: "Disciplines",
                keyColumn: "RecId",
                keyValue: 5,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 25, 15, 29, 56, 264, DateTimeKind.Utc).AddTicks(3259), new DateTime(2021, 7, 25, 15, 29, 56, 264, DateTimeKind.Utc).AddTicks(3259) });

            migrationBuilder.UpdateData(
                table: "Disciplines",
                keyColumn: "RecId",
                keyValue: 6,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 25, 15, 29, 56, 264, DateTimeKind.Utc).AddTicks(3261), new DateTime(2021, 7, 25, 15, 29, 56, 264, DateTimeKind.Utc).AddTicks(3260) });

            migrationBuilder.UpdateData(
                table: "Disciplines",
                keyColumn: "RecId",
                keyValue: 7,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 25, 15, 29, 56, 264, DateTimeKind.Utc).AddTicks(3262), new DateTime(2021, 7, 25, 15, 29, 56, 264, DateTimeKind.Utc).AddTicks(3262) });

            migrationBuilder.UpdateData(
                table: "Disciplines",
                keyColumn: "RecId",
                keyValue: 8,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 25, 15, 29, 56, 264, DateTimeKind.Utc).AddTicks(3264), new DateTime(2021, 7, 25, 15, 29, 56, 264, DateTimeKind.Utc).AddTicks(3263) });

            migrationBuilder.UpdateData(
                table: "Disciplines",
                keyColumn: "RecId",
                keyValue: 9,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 25, 15, 29, 56, 264, DateTimeKind.Utc).AddTicks(3265), new DateTime(2021, 7, 25, 15, 29, 56, 264, DateTimeKind.Utc).AddTicks(3265) });

            migrationBuilder.UpdateData(
                table: "Disciplines",
                keyColumn: "RecId",
                keyValue: 10,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 25, 15, 29, 56, 264, DateTimeKind.Utc).AddTicks(3267), new DateTime(2021, 7, 25, 15, 29, 56, 264, DateTimeKind.Utc).AddTicks(3266) });

            migrationBuilder.UpdateData(
                table: "Disciplines",
                keyColumn: "RecId",
                keyValue: 11,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 25, 15, 29, 56, 264, DateTimeKind.Utc).AddTicks(3268), new DateTime(2021, 7, 25, 15, 29, 56, 264, DateTimeKind.Utc).AddTicks(3268) });

            migrationBuilder.UpdateData(
                table: "Disciplines",
                keyColumn: "RecId",
                keyValue: 12,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 25, 15, 29, 56, 264, DateTimeKind.Utc).AddTicks(3270), new DateTime(2021, 7, 25, 15, 29, 56, 264, DateTimeKind.Utc).AddTicks(3269) });

            migrationBuilder.UpdateData(
                table: "Disciplines",
                keyColumn: "RecId",
                keyValue: 13,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 25, 15, 29, 56, 264, DateTimeKind.Utc).AddTicks(3271), new DateTime(2021, 7, 25, 15, 29, 56, 264, DateTimeKind.Utc).AddTicks(3271) });

            migrationBuilder.UpdateData(
                table: "Disciplines",
                keyColumn: "RecId",
                keyValue: 14,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 25, 15, 29, 56, 264, DateTimeKind.Utc).AddTicks(3273), new DateTime(2021, 7, 25, 15, 29, 56, 264, DateTimeKind.Utc).AddTicks(3272) });

            migrationBuilder.UpdateData(
                table: "Disciplines",
                keyColumn: "RecId",
                keyValue: 15,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 25, 15, 29, 56, 264, DateTimeKind.Utc).AddTicks(3303), new DateTime(2021, 7, 25, 15, 29, 56, 264, DateTimeKind.Utc).AddTicks(3303) });

            migrationBuilder.UpdateData(
                table: "Disciplines",
                keyColumn: "RecId",
                keyValue: 16,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 25, 15, 29, 56, 264, DateTimeKind.Utc).AddTicks(3305), new DateTime(2021, 7, 25, 15, 29, 56, 264, DateTimeKind.Utc).AddTicks(3305) });

            migrationBuilder.UpdateData(
                table: "Disciplines",
                keyColumn: "RecId",
                keyValue: 17,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 25, 15, 29, 56, 264, DateTimeKind.Utc).AddTicks(3307), new DateTime(2021, 7, 25, 15, 29, 56, 264, DateTimeKind.Utc).AddTicks(3306) });

            migrationBuilder.UpdateData(
                table: "Disciplines",
                keyColumn: "RecId",
                keyValue: 18,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 25, 15, 29, 56, 264, DateTimeKind.Utc).AddTicks(3308), new DateTime(2021, 7, 25, 15, 29, 56, 264, DateTimeKind.Utc).AddTicks(3308) });

            migrationBuilder.UpdateData(
                table: "ShareLevels",
                keyColumn: "RecId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 25, 15, 29, 56, 264, DateTimeKind.Utc).AddTicks(8532), new DateTime(2021, 7, 25, 15, 29, 56, 264, DateTimeKind.Utc).AddTicks(8529) });

            migrationBuilder.UpdateData(
                table: "ShareLevels",
                keyColumn: "RecId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 25, 15, 29, 56, 264, DateTimeKind.Utc).AddTicks(9489), new DateTime(2021, 7, 25, 15, 29, 56, 264, DateTimeKind.Utc).AddTicks(9487) });

            migrationBuilder.UpdateData(
                table: "ShareLevels",
                keyColumn: "RecId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 25, 15, 29, 56, 264, DateTimeKind.Utc).AddTicks(9491), new DateTime(2021, 7, 25, 15, 29, 56, 264, DateTimeKind.Utc).AddTicks(9490) });

            migrationBuilder.UpdateData(
                table: "ShareLevels",
                keyColumn: "RecId",
                keyValue: 4,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 25, 15, 29, 56, 264, DateTimeKind.Utc).AddTicks(9493), new DateTime(2021, 7, 25, 15, 29, 56, 264, DateTimeKind.Utc).AddTicks(9492) });

            migrationBuilder.UpdateData(
                table: "ShareLevels",
                keyColumn: "RecId",
                keyValue: 5,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 25, 15, 29, 56, 264, DateTimeKind.Utc).AddTicks(9495), new DateTime(2021, 7, 25, 15, 29, 56, 264, DateTimeKind.Utc).AddTicks(9494) });

            migrationBuilder.UpdateData(
                table: "ShareLevels",
                keyColumn: "RecId",
                keyValue: 6,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 25, 15, 29, 56, 264, DateTimeKind.Utc).AddTicks(9497), new DateTime(2021, 7, 25, 15, 29, 56, 264, DateTimeKind.Utc).AddTicks(9496) });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "RecId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 25, 15, 29, 56, 265, DateTimeKind.Utc).AddTicks(3325), new DateTime(2021, 7, 25, 15, 29, 56, 265, DateTimeKind.Utc).AddTicks(3322) });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "RecId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 25, 15, 29, 56, 265, DateTimeKind.Utc).AddTicks(4876), new DateTime(2021, 7, 25, 15, 29, 56, 265, DateTimeKind.Utc).AddTicks(4875) });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "RecId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 25, 15, 29, 56, 265, DateTimeKind.Utc).AddTicks(4879), new DateTime(2021, 7, 25, 15, 29, 56, 265, DateTimeKind.Utc).AddTicks(4878) });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "RecId",
                keyValue: 4,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 25, 15, 29, 56, 265, DateTimeKind.Utc).AddTicks(4881), new DateTime(2021, 7, 25, 15, 29, 56, 265, DateTimeKind.Utc).AddTicks(4880) });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "RecId",
                keyValue: 5,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 25, 15, 29, 56, 265, DateTimeKind.Utc).AddTicks(4883), new DateTime(2021, 7, 25, 15, 29, 56, 265, DateTimeKind.Utc).AddTicks(4882) });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "RecId",
                keyValue: 6,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 25, 15, 29, 56, 265, DateTimeKind.Utc).AddTicks(4885), new DateTime(2021, 7, 25, 15, 29, 56, 265, DateTimeKind.Utc).AddTicks(4884) });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "RecId",
                keyValue: 7,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 25, 15, 29, 56, 265, DateTimeKind.Utc).AddTicks(4886), new DateTime(2021, 7, 25, 15, 29, 56, 265, DateTimeKind.Utc).AddTicks(4886) });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "RecId",
                keyValue: 8,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 25, 15, 29, 56, 265, DateTimeKind.Utc).AddTicks(4888), new DateTime(2021, 7, 25, 15, 29, 56, 265, DateTimeKind.Utc).AddTicks(4887) });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "RecId",
                keyValue: 9,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 25, 15, 29, 56, 265, DateTimeKind.Utc).AddTicks(4889), new DateTime(2021, 7, 25, 15, 29, 56, 265, DateTimeKind.Utc).AddTicks(4889) });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "RecId",
                keyValue: 10,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 25, 15, 29, 56, 265, DateTimeKind.Utc).AddTicks(4891), new DateTime(2021, 7, 25, 15, 29, 56, 265, DateTimeKind.Utc).AddTicks(4890) });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "RecId",
                keyValue: 11,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 25, 15, 29, 56, 265, DateTimeKind.Utc).AddTicks(4892), new DateTime(2021, 7, 25, 15, 29, 56, 265, DateTimeKind.Utc).AddTicks(4892) });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "RecId",
                keyValue: 12,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 25, 15, 29, 56, 265, DateTimeKind.Utc).AddTicks(4894), new DateTime(2021, 7, 25, 15, 29, 56, 265, DateTimeKind.Utc).AddTicks(4893) });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "RecId",
                keyValue: 13,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 25, 15, 29, 56, 265, DateTimeKind.Utc).AddTicks(4896), new DateTime(2021, 7, 25, 15, 29, 56, 265, DateTimeKind.Utc).AddTicks(4895) });

            migrationBuilder.UpdateData(
                table: "VersionHistories",
                keyColumn: "RecId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 25, 15, 29, 56, 261, DateTimeKind.Utc).AddTicks(1018), new DateTime(2021, 7, 25, 15, 29, 56, 261, DateTimeKind.Utc).AddTicks(1012) });
        }
    }
}
