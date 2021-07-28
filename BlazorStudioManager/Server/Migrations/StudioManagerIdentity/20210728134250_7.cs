using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorStudioManager.Server.Migrations.StudioManagerIdentity
{
    public partial class _7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "administrator",
                column: "ConcurrencyStamp",
                value: "d4b6753e-1061-4efa-89dd-7e438922fb72");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bronze",
                column: "ConcurrencyStamp",
                value: "1e2b0382-7d19-4c2c-997b-31dcf20f4ec8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "gold",
                column: "ConcurrencyStamp",
                value: "4ef6f074-a157-476b-bffa-35b3b4f994d8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "guest",
                column: "ConcurrencyStamp",
                value: "68b943d4-2bac-4e7c-a9e9-a4b074cd3b9e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "platinum",
                column: "ConcurrencyStamp",
                value: "7218691f-6265-459e-a2ac-131cd546c6fa");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "showbronze",
                column: "ConcurrencyStamp",
                value: "c8cf181f-7ddf-4e2c-a8ef-1b3375ea7c76");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "showgold",
                column: "ConcurrencyStamp",
                value: "10f2b008-0337-48f6-9de3-5703d9c90da2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "showguest",
                column: "ConcurrencyStamp",
                value: "7818ce60-0dcc-4790-8998-edc7567c94c3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "showplatinum",
                column: "ConcurrencyStamp",
                value: "e718e736-81bc-4743-8439-cf5f22af9b80");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "showsilver",
                column: "ConcurrencyStamp",
                value: "4e1dca3e-ce9e-48ca-a42b-53707274a6fa");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "showtitanium",
                column: "ConcurrencyStamp",
                value: "1254a113-748d-43e6-83ca-8eaa39933207");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "silver",
                column: "ConcurrencyStamp",
                value: "32ff349f-30c9-4eea-98e3-0620bfc335f4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "titanium",
                column: "ConcurrencyStamp",
                value: "7a92edd3-c830-4fd5-8ad3-5385dcb9030d");

            migrationBuilder.UpdateData(
                table: "Disciplines",
                keyColumn: "RecId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 28, 13, 42, 49, 479, DateTimeKind.Utc).AddTicks(4147), new DateTime(2021, 7, 28, 13, 42, 49, 479, DateTimeKind.Utc).AddTicks(4142) });

            migrationBuilder.UpdateData(
                table: "Disciplines",
                keyColumn: "RecId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 28, 13, 42, 49, 479, DateTimeKind.Utc).AddTicks(5258), new DateTime(2021, 7, 28, 13, 42, 49, 479, DateTimeKind.Utc).AddTicks(5256) });

            migrationBuilder.UpdateData(
                table: "Disciplines",
                keyColumn: "RecId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 28, 13, 42, 49, 479, DateTimeKind.Utc).AddTicks(5261), new DateTime(2021, 7, 28, 13, 42, 49, 479, DateTimeKind.Utc).AddTicks(5261) });

            migrationBuilder.UpdateData(
                table: "Disciplines",
                keyColumn: "RecId",
                keyValue: 4,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 28, 13, 42, 49, 479, DateTimeKind.Utc).AddTicks(5263), new DateTime(2021, 7, 28, 13, 42, 49, 479, DateTimeKind.Utc).AddTicks(5262) });

            migrationBuilder.UpdateData(
                table: "Disciplines",
                keyColumn: "RecId",
                keyValue: 5,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 28, 13, 42, 49, 479, DateTimeKind.Utc).AddTicks(5264), new DateTime(2021, 7, 28, 13, 42, 49, 479, DateTimeKind.Utc).AddTicks(5264) });

            migrationBuilder.UpdateData(
                table: "Disciplines",
                keyColumn: "RecId",
                keyValue: 6,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 28, 13, 42, 49, 479, DateTimeKind.Utc).AddTicks(5266), new DateTime(2021, 7, 28, 13, 42, 49, 479, DateTimeKind.Utc).AddTicks(5265) });

            migrationBuilder.UpdateData(
                table: "Disciplines",
                keyColumn: "RecId",
                keyValue: 7,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 28, 13, 42, 49, 479, DateTimeKind.Utc).AddTicks(5268), new DateTime(2021, 7, 28, 13, 42, 49, 479, DateTimeKind.Utc).AddTicks(5267) });

            migrationBuilder.UpdateData(
                table: "Disciplines",
                keyColumn: "RecId",
                keyValue: 8,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 28, 13, 42, 49, 479, DateTimeKind.Utc).AddTicks(5269), new DateTime(2021, 7, 28, 13, 42, 49, 479, DateTimeKind.Utc).AddTicks(5269) });

            migrationBuilder.UpdateData(
                table: "Disciplines",
                keyColumn: "RecId",
                keyValue: 9,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 28, 13, 42, 49, 479, DateTimeKind.Utc).AddTicks(5271), new DateTime(2021, 7, 28, 13, 42, 49, 479, DateTimeKind.Utc).AddTicks(5270) });

            migrationBuilder.UpdateData(
                table: "Disciplines",
                keyColumn: "RecId",
                keyValue: 10,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 28, 13, 42, 49, 479, DateTimeKind.Utc).AddTicks(5273), new DateTime(2021, 7, 28, 13, 42, 49, 479, DateTimeKind.Utc).AddTicks(5272) });

            migrationBuilder.UpdateData(
                table: "Disciplines",
                keyColumn: "RecId",
                keyValue: 11,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 28, 13, 42, 49, 479, DateTimeKind.Utc).AddTicks(5274), new DateTime(2021, 7, 28, 13, 42, 49, 479, DateTimeKind.Utc).AddTicks(5274) });

            migrationBuilder.UpdateData(
                table: "Disciplines",
                keyColumn: "RecId",
                keyValue: 12,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 28, 13, 42, 49, 479, DateTimeKind.Utc).AddTicks(5276), new DateTime(2021, 7, 28, 13, 42, 49, 479, DateTimeKind.Utc).AddTicks(5276) });

            migrationBuilder.UpdateData(
                table: "Disciplines",
                keyColumn: "RecId",
                keyValue: 13,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 28, 13, 42, 49, 479, DateTimeKind.Utc).AddTicks(5278), new DateTime(2021, 7, 28, 13, 42, 49, 479, DateTimeKind.Utc).AddTicks(5277) });

            migrationBuilder.UpdateData(
                table: "Disciplines",
                keyColumn: "RecId",
                keyValue: 14,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 28, 13, 42, 49, 479, DateTimeKind.Utc).AddTicks(5279), new DateTime(2021, 7, 28, 13, 42, 49, 479, DateTimeKind.Utc).AddTicks(5279) });

            migrationBuilder.UpdateData(
                table: "Disciplines",
                keyColumn: "RecId",
                keyValue: 15,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 28, 13, 42, 49, 479, DateTimeKind.Utc).AddTicks(5281), new DateTime(2021, 7, 28, 13, 42, 49, 479, DateTimeKind.Utc).AddTicks(5280) });

            migrationBuilder.UpdateData(
                table: "Disciplines",
                keyColumn: "RecId",
                keyValue: 16,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 28, 13, 42, 49, 479, DateTimeKind.Utc).AddTicks(5283), new DateTime(2021, 7, 28, 13, 42, 49, 479, DateTimeKind.Utc).AddTicks(5283) });

            migrationBuilder.UpdateData(
                table: "Disciplines",
                keyColumn: "RecId",
                keyValue: 17,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 28, 13, 42, 49, 479, DateTimeKind.Utc).AddTicks(5285), new DateTime(2021, 7, 28, 13, 42, 49, 479, DateTimeKind.Utc).AddTicks(5284) });

            migrationBuilder.UpdateData(
                table: "Disciplines",
                keyColumn: "RecId",
                keyValue: 18,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 28, 13, 42, 49, 479, DateTimeKind.Utc).AddTicks(5286), new DateTime(2021, 7, 28, 13, 42, 49, 479, DateTimeKind.Utc).AddTicks(5286) });

            migrationBuilder.UpdateData(
                table: "ShareLevels",
                keyColumn: "RecId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 28, 13, 42, 49, 480, DateTimeKind.Utc).AddTicks(1186), new DateTime(2021, 7, 28, 13, 42, 49, 480, DateTimeKind.Utc).AddTicks(1183) });

            migrationBuilder.UpdateData(
                table: "ShareLevels",
                keyColumn: "RecId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 28, 13, 42, 49, 480, DateTimeKind.Utc).AddTicks(2546), new DateTime(2021, 7, 28, 13, 42, 49, 480, DateTimeKind.Utc).AddTicks(2544) });

            migrationBuilder.UpdateData(
                table: "ShareLevels",
                keyColumn: "RecId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 28, 13, 42, 49, 480, DateTimeKind.Utc).AddTicks(2549), new DateTime(2021, 7, 28, 13, 42, 49, 480, DateTimeKind.Utc).AddTicks(2549) });

            migrationBuilder.UpdateData(
                table: "ShareLevels",
                keyColumn: "RecId",
                keyValue: 4,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 28, 13, 42, 49, 480, DateTimeKind.Utc).AddTicks(2551), new DateTime(2021, 7, 28, 13, 42, 49, 480, DateTimeKind.Utc).AddTicks(2550) });

            migrationBuilder.UpdateData(
                table: "ShareLevels",
                keyColumn: "RecId",
                keyValue: 5,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 28, 13, 42, 49, 480, DateTimeKind.Utc).AddTicks(2553), new DateTime(2021, 7, 28, 13, 42, 49, 480, DateTimeKind.Utc).AddTicks(2552) });

            migrationBuilder.UpdateData(
                table: "ShareLevels",
                keyColumn: "RecId",
                keyValue: 6,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 28, 13, 42, 49, 480, DateTimeKind.Utc).AddTicks(2554), new DateTime(2021, 7, 28, 13, 42, 49, 480, DateTimeKind.Utc).AddTicks(2554) });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "RecId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 28, 13, 42, 49, 480, DateTimeKind.Utc).AddTicks(6195), new DateTime(2021, 7, 28, 13, 42, 49, 480, DateTimeKind.Utc).AddTicks(6192) });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "RecId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 28, 13, 42, 49, 480, DateTimeKind.Utc).AddTicks(7848), new DateTime(2021, 7, 28, 13, 42, 49, 480, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "RecId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 28, 13, 42, 49, 480, DateTimeKind.Utc).AddTicks(7851), new DateTime(2021, 7, 28, 13, 42, 49, 480, DateTimeKind.Utc).AddTicks(7850) });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "RecId",
                keyValue: 4,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 28, 13, 42, 49, 480, DateTimeKind.Utc).AddTicks(7852), new DateTime(2021, 7, 28, 13, 42, 49, 480, DateTimeKind.Utc).AddTicks(7852) });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "RecId",
                keyValue: 5,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 28, 13, 42, 49, 480, DateTimeKind.Utc).AddTicks(7855), new DateTime(2021, 7, 28, 13, 42, 49, 480, DateTimeKind.Utc).AddTicks(7854) });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "RecId",
                keyValue: 6,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 28, 13, 42, 49, 480, DateTimeKind.Utc).AddTicks(7857), new DateTime(2021, 7, 28, 13, 42, 49, 480, DateTimeKind.Utc).AddTicks(7856) });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "RecId",
                keyValue: 7,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 28, 13, 42, 49, 480, DateTimeKind.Utc).AddTicks(7858), new DateTime(2021, 7, 28, 13, 42, 49, 480, DateTimeKind.Utc).AddTicks(7858) });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "RecId",
                keyValue: 8,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 28, 13, 42, 49, 480, DateTimeKind.Utc).AddTicks(7860), new DateTime(2021, 7, 28, 13, 42, 49, 480, DateTimeKind.Utc).AddTicks(7859) });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "RecId",
                keyValue: 9,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 28, 13, 42, 49, 480, DateTimeKind.Utc).AddTicks(7896), new DateTime(2021, 7, 28, 13, 42, 49, 480, DateTimeKind.Utc).AddTicks(7892) });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "RecId",
                keyValue: 10,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 28, 13, 42, 49, 480, DateTimeKind.Utc).AddTicks(7898), new DateTime(2021, 7, 28, 13, 42, 49, 480, DateTimeKind.Utc).AddTicks(7897) });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "RecId",
                keyValue: 11,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 28, 13, 42, 49, 480, DateTimeKind.Utc).AddTicks(7899), new DateTime(2021, 7, 28, 13, 42, 49, 480, DateTimeKind.Utc).AddTicks(7899) });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "RecId",
                keyValue: 12,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 28, 13, 42, 49, 480, DateTimeKind.Utc).AddTicks(7901), new DateTime(2021, 7, 28, 13, 42, 49, 480, DateTimeKind.Utc).AddTicks(7900) });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "RecId",
                keyValue: 13,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 28, 13, 42, 49, 480, DateTimeKind.Utc).AddTicks(7903), new DateTime(2021, 7, 28, 13, 42, 49, 480, DateTimeKind.Utc).AddTicks(7902) });

            migrationBuilder.UpdateData(
                table: "VersionHistories",
                keyColumn: "RecId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 28, 13, 42, 49, 475, DateTimeKind.Utc).AddTicks(6690), new DateTime(2021, 7, 28, 13, 42, 49, 475, DateTimeKind.Utc).AddTicks(6680) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
