using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorStudioManager.Server.Migrations.StudioManagerIdentity
{
    public partial class _3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SharedProductions_OwnerStudioManagerUser",
                table: "SharedProductions");

            migrationBuilder.DropForeignKey(
                name: "FK_ShareLinks_AspNetUsers_StudioManagerUserId",
                table: "ShareLinks");

            migrationBuilder.DropIndex(
                name: "IX_SharedProductions_OwnerUserId",
                table: "SharedProductions");

            migrationBuilder.AlterColumn<string>(
                name: "OwnerUserId",
                table: "SharedProductions",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "administrator",
                column: "ConcurrencyStamp",
                value: "4ebe3fe3-37a1-4fe9-b77c-8c17224ee98e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bronze",
                column: "ConcurrencyStamp",
                value: "36e6fd6d-a10c-4577-b258-beee1968a324");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "gold",
                column: "ConcurrencyStamp",
                value: "7c630786-f757-4b81-9c98-1a65af8dc651");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "guest",
                column: "ConcurrencyStamp",
                value: "43b7f58e-c877-40b4-86bf-f6eb7abc98eb");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "platinum",
                column: "ConcurrencyStamp",
                value: "38c678c9-fa53-4a12-9741-e710fb3058e8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "showbronze",
                column: "ConcurrencyStamp",
                value: "a491f37b-819a-4fc8-9455-6d9fc67d1a96");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "showgold",
                column: "ConcurrencyStamp",
                value: "72c8683b-99c4-4d56-b8a0-801172670d34");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "showguest",
                column: "ConcurrencyStamp",
                value: "6bdf9d28-e65e-4715-8644-89ecc2a9e4f6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "showplatinum",
                column: "ConcurrencyStamp",
                value: "85070644-3e64-4baa-9090-ef2dfe9f56d1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "showsilver",
                column: "ConcurrencyStamp",
                value: "933b758e-8758-4ca9-be33-bc5b88f41cd3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "showtitanium",
                column: "ConcurrencyStamp",
                value: "90e3c50c-3a62-4c16-a5ea-539eccc25789");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "silver",
                column: "ConcurrencyStamp",
                value: "305bba68-1f27-463c-a417-3066ce66c608");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "titanium",
                column: "ConcurrencyStamp",
                value: "6c4d1c70-eb1f-4f2e-9506-572512c9b5a9");

            migrationBuilder.UpdateData(
                table: "Disciplines",
                keyColumn: "RecId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 23, 19, 7, 12, 600, DateTimeKind.Utc).AddTicks(9347), new DateTime(2021, 7, 23, 19, 7, 12, 600, DateTimeKind.Utc).AddTicks(9343) });

            migrationBuilder.UpdateData(
                table: "Disciplines",
                keyColumn: "RecId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 23, 19, 7, 12, 601, DateTimeKind.Utc).AddTicks(676), new DateTime(2021, 7, 23, 19, 7, 12, 601, DateTimeKind.Utc).AddTicks(674) });

            migrationBuilder.UpdateData(
                table: "Disciplines",
                keyColumn: "RecId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 23, 19, 7, 12, 601, DateTimeKind.Utc).AddTicks(680), new DateTime(2021, 7, 23, 19, 7, 12, 601, DateTimeKind.Utc).AddTicks(679) });

            migrationBuilder.UpdateData(
                table: "Disciplines",
                keyColumn: "RecId",
                keyValue: 4,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 23, 19, 7, 12, 601, DateTimeKind.Utc).AddTicks(682), new DateTime(2021, 7, 23, 19, 7, 12, 601, DateTimeKind.Utc).AddTicks(681) });

            migrationBuilder.UpdateData(
                table: "Disciplines",
                keyColumn: "RecId",
                keyValue: 5,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 23, 19, 7, 12, 601, DateTimeKind.Utc).AddTicks(706), new DateTime(2021, 7, 23, 19, 7, 12, 601, DateTimeKind.Utc).AddTicks(705) });

            migrationBuilder.UpdateData(
                table: "Disciplines",
                keyColumn: "RecId",
                keyValue: 6,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 23, 19, 7, 12, 601, DateTimeKind.Utc).AddTicks(708), new DateTime(2021, 7, 23, 19, 7, 12, 601, DateTimeKind.Utc).AddTicks(708) });

            migrationBuilder.UpdateData(
                table: "Disciplines",
                keyColumn: "RecId",
                keyValue: 7,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 23, 19, 7, 12, 601, DateTimeKind.Utc).AddTicks(710), new DateTime(2021, 7, 23, 19, 7, 12, 601, DateTimeKind.Utc).AddTicks(709) });

            migrationBuilder.UpdateData(
                table: "Disciplines",
                keyColumn: "RecId",
                keyValue: 8,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 23, 19, 7, 12, 601, DateTimeKind.Utc).AddTicks(712), new DateTime(2021, 7, 23, 19, 7, 12, 601, DateTimeKind.Utc).AddTicks(711) });

            migrationBuilder.UpdateData(
                table: "Disciplines",
                keyColumn: "RecId",
                keyValue: 9,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 23, 19, 7, 12, 601, DateTimeKind.Utc).AddTicks(879), new DateTime(2021, 7, 23, 19, 7, 12, 601, DateTimeKind.Utc).AddTicks(878) });

            migrationBuilder.UpdateData(
                table: "Disciplines",
                keyColumn: "RecId",
                keyValue: 10,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 23, 19, 7, 12, 601, DateTimeKind.Utc).AddTicks(882), new DateTime(2021, 7, 23, 19, 7, 12, 601, DateTimeKind.Utc).AddTicks(881) });

            migrationBuilder.UpdateData(
                table: "Disciplines",
                keyColumn: "RecId",
                keyValue: 11,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 23, 19, 7, 12, 601, DateTimeKind.Utc).AddTicks(883), new DateTime(2021, 7, 23, 19, 7, 12, 601, DateTimeKind.Utc).AddTicks(882) });

            migrationBuilder.UpdateData(
                table: "Disciplines",
                keyColumn: "RecId",
                keyValue: 12,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 23, 19, 7, 12, 601, DateTimeKind.Utc).AddTicks(885), new DateTime(2021, 7, 23, 19, 7, 12, 601, DateTimeKind.Utc).AddTicks(884) });

            migrationBuilder.UpdateData(
                table: "Disciplines",
                keyColumn: "RecId",
                keyValue: 13,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 23, 19, 7, 12, 601, DateTimeKind.Utc).AddTicks(886), new DateTime(2021, 7, 23, 19, 7, 12, 601, DateTimeKind.Utc).AddTicks(886) });

            migrationBuilder.UpdateData(
                table: "Disciplines",
                keyColumn: "RecId",
                keyValue: 14,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 23, 19, 7, 12, 601, DateTimeKind.Utc).AddTicks(888), new DateTime(2021, 7, 23, 19, 7, 12, 601, DateTimeKind.Utc).AddTicks(887) });

            migrationBuilder.UpdateData(
                table: "Disciplines",
                keyColumn: "RecId",
                keyValue: 15,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 23, 19, 7, 12, 601, DateTimeKind.Utc).AddTicks(890), new DateTime(2021, 7, 23, 19, 7, 12, 601, DateTimeKind.Utc).AddTicks(889) });

            migrationBuilder.UpdateData(
                table: "Disciplines",
                keyColumn: "RecId",
                keyValue: 16,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 23, 19, 7, 12, 601, DateTimeKind.Utc).AddTicks(891), new DateTime(2021, 7, 23, 19, 7, 12, 601, DateTimeKind.Utc).AddTicks(891) });

            migrationBuilder.UpdateData(
                table: "Disciplines",
                keyColumn: "RecId",
                keyValue: 17,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 23, 19, 7, 12, 601, DateTimeKind.Utc).AddTicks(893), new DateTime(2021, 7, 23, 19, 7, 12, 601, DateTimeKind.Utc).AddTicks(892) });

            migrationBuilder.UpdateData(
                table: "Disciplines",
                keyColumn: "RecId",
                keyValue: 18,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 23, 19, 7, 12, 601, DateTimeKind.Utc).AddTicks(894), new DateTime(2021, 7, 23, 19, 7, 12, 601, DateTimeKind.Utc).AddTicks(894) });

            migrationBuilder.UpdateData(
                table: "ShareLevels",
                keyColumn: "RecId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 23, 19, 7, 12, 601, DateTimeKind.Utc).AddTicks(7288), new DateTime(2021, 7, 23, 19, 7, 12, 601, DateTimeKind.Utc).AddTicks(7286) });

            migrationBuilder.UpdateData(
                table: "ShareLevels",
                keyColumn: "RecId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 23, 19, 7, 12, 601, DateTimeKind.Utc).AddTicks(8669), new DateTime(2021, 7, 23, 19, 7, 12, 601, DateTimeKind.Utc).AddTicks(8668) });

            migrationBuilder.UpdateData(
                table: "ShareLevels",
                keyColumn: "RecId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 23, 19, 7, 12, 601, DateTimeKind.Utc).AddTicks(8672), new DateTime(2021, 7, 23, 19, 7, 12, 601, DateTimeKind.Utc).AddTicks(8672) });

            migrationBuilder.UpdateData(
                table: "ShareLevels",
                keyColumn: "RecId",
                keyValue: 4,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 23, 19, 7, 12, 601, DateTimeKind.Utc).AddTicks(8674), new DateTime(2021, 7, 23, 19, 7, 12, 601, DateTimeKind.Utc).AddTicks(8673) });

            migrationBuilder.UpdateData(
                table: "ShareLevels",
                keyColumn: "RecId",
                keyValue: 5,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 23, 19, 7, 12, 601, DateTimeKind.Utc).AddTicks(8675), new DateTime(2021, 7, 23, 19, 7, 12, 601, DateTimeKind.Utc).AddTicks(8675) });

            migrationBuilder.UpdateData(
                table: "ShareLevels",
                keyColumn: "RecId",
                keyValue: 6,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 23, 19, 7, 12, 601, DateTimeKind.Utc).AddTicks(8677), new DateTime(2021, 7, 23, 19, 7, 12, 601, DateTimeKind.Utc).AddTicks(8677) });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "RecId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 23, 19, 7, 12, 602, DateTimeKind.Utc).AddTicks(3559), new DateTime(2021, 7, 23, 19, 7, 12, 602, DateTimeKind.Utc).AddTicks(3555) });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "RecId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 23, 19, 7, 12, 602, DateTimeKind.Utc).AddTicks(5264), new DateTime(2021, 7, 23, 19, 7, 12, 602, DateTimeKind.Utc).AddTicks(5263) });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "RecId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 23, 19, 7, 12, 602, DateTimeKind.Utc).AddTicks(5267), new DateTime(2021, 7, 23, 19, 7, 12, 602, DateTimeKind.Utc).AddTicks(5266) });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "RecId",
                keyValue: 4,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 23, 19, 7, 12, 602, DateTimeKind.Utc).AddTicks(5269), new DateTime(2021, 7, 23, 19, 7, 12, 602, DateTimeKind.Utc).AddTicks(5268) });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "RecId",
                keyValue: 5,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 23, 19, 7, 12, 602, DateTimeKind.Utc).AddTicks(5271), new DateTime(2021, 7, 23, 19, 7, 12, 602, DateTimeKind.Utc).AddTicks(5271) });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "RecId",
                keyValue: 6,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 23, 19, 7, 12, 602, DateTimeKind.Utc).AddTicks(5273), new DateTime(2021, 7, 23, 19, 7, 12, 602, DateTimeKind.Utc).AddTicks(5272) });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "RecId",
                keyValue: 7,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 23, 19, 7, 12, 602, DateTimeKind.Utc).AddTicks(5274), new DateTime(2021, 7, 23, 19, 7, 12, 602, DateTimeKind.Utc).AddTicks(5274) });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "RecId",
                keyValue: 8,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 23, 19, 7, 12, 602, DateTimeKind.Utc).AddTicks(5276), new DateTime(2021, 7, 23, 19, 7, 12, 602, DateTimeKind.Utc).AddTicks(5275) });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "RecId",
                keyValue: 9,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 23, 19, 7, 12, 602, DateTimeKind.Utc).AddTicks(5277), new DateTime(2021, 7, 23, 19, 7, 12, 602, DateTimeKind.Utc).AddTicks(5277) });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "RecId",
                keyValue: 10,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 23, 19, 7, 12, 602, DateTimeKind.Utc).AddTicks(5279), new DateTime(2021, 7, 23, 19, 7, 12, 602, DateTimeKind.Utc).AddTicks(5278) });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "RecId",
                keyValue: 11,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 23, 19, 7, 12, 602, DateTimeKind.Utc).AddTicks(5280), new DateTime(2021, 7, 23, 19, 7, 12, 602, DateTimeKind.Utc).AddTicks(5280) });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "RecId",
                keyValue: 12,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 23, 19, 7, 12, 602, DateTimeKind.Utc).AddTicks(5282), new DateTime(2021, 7, 23, 19, 7, 12, 602, DateTimeKind.Utc).AddTicks(5281) });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "RecId",
                keyValue: 13,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 23, 19, 7, 12, 602, DateTimeKind.Utc).AddTicks(5284), new DateTime(2021, 7, 23, 19, 7, 12, 602, DateTimeKind.Utc).AddTicks(5283) });

            migrationBuilder.UpdateData(
                table: "VersionHistories",
                keyColumn: "RecId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 23, 19, 7, 12, 596, DateTimeKind.Utc).AddTicks(8923), new DateTime(2021, 7, 23, 19, 7, 12, 596, DateTimeKind.Utc).AddTicks(8917) });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_SharedProductionId",
                table: "AspNetUsers",
                column: "SharedProductionId",
                unique: true,
                filter: "[SharedProductionId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_SharedProductions_SharedProductionId",
                table: "AspNetUsers",
                column: "SharedProductionId",
                principalTable: "SharedProductions",
                principalColumn: "RecId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ShareLinks_AspNetUsers_StudioManagerUserId",
                table: "ShareLinks",
                column: "StudioManagerUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_SharedProductions_SharedProductionId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_ShareLinks_AspNetUsers_StudioManagerUserId",
                table: "ShareLinks");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_SharedProductionId",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<string>(
                name: "OwnerUserId",
                table: "SharedProductions",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "administrator",
                column: "ConcurrencyStamp",
                value: "b034de35-b2dd-4d52-a2be-34b8018b1765");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bronze",
                column: "ConcurrencyStamp",
                value: "1a4b8913-3763-484f-9d4b-449ea9aef66d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "gold",
                column: "ConcurrencyStamp",
                value: "15b99ba0-c497-464a-84d7-e3f32f0b0dd2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "guest",
                column: "ConcurrencyStamp",
                value: "50644435-48ee-4a4e-9b4e-38acbed47a67");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "platinum",
                column: "ConcurrencyStamp",
                value: "eb4e935b-b03c-4dc4-9142-230bd41f239f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "showbronze",
                column: "ConcurrencyStamp",
                value: "26d68847-aedf-40ab-bbc4-f0e62315f6a4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "showgold",
                column: "ConcurrencyStamp",
                value: "c72349d9-9081-4be8-a3f3-9549d5b7d464");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "showguest",
                column: "ConcurrencyStamp",
                value: "6e9d366d-cb4b-421d-848b-14d69da790d9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "showplatinum",
                column: "ConcurrencyStamp",
                value: "18ac2195-933a-44fa-a6b1-d707350c243e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "showsilver",
                column: "ConcurrencyStamp",
                value: "a2162d1b-feb6-491d-96e3-8d871aab7e26");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "showtitanium",
                column: "ConcurrencyStamp",
                value: "97e37e18-91a9-4c19-b853-be5fa732e897");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "silver",
                column: "ConcurrencyStamp",
                value: "c2891455-1749-4a43-9b39-923ea7eae829");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "titanium",
                column: "ConcurrencyStamp",
                value: "192f4248-2f66-42ee-85df-05f1d5fb81a7");

            migrationBuilder.UpdateData(
                table: "Disciplines",
                keyColumn: "RecId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 23, 16, 1, 45, 974, DateTimeKind.Utc).AddTicks(5495), new DateTime(2021, 7, 23, 16, 1, 45, 974, DateTimeKind.Utc).AddTicks(5240) });

            migrationBuilder.UpdateData(
                table: "Disciplines",
                keyColumn: "RecId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 23, 16, 1, 45, 974, DateTimeKind.Utc).AddTicks(6896), new DateTime(2021, 7, 23, 16, 1, 45, 974, DateTimeKind.Utc).AddTicks(6894) });

            migrationBuilder.UpdateData(
                table: "Disciplines",
                keyColumn: "RecId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 23, 16, 1, 45, 974, DateTimeKind.Utc).AddTicks(6899), new DateTime(2021, 7, 23, 16, 1, 45, 974, DateTimeKind.Utc).AddTicks(6898) });

            migrationBuilder.UpdateData(
                table: "Disciplines",
                keyColumn: "RecId",
                keyValue: 4,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 23, 16, 1, 45, 974, DateTimeKind.Utc).AddTicks(6901), new DateTime(2021, 7, 23, 16, 1, 45, 974, DateTimeKind.Utc).AddTicks(6900) });

            migrationBuilder.UpdateData(
                table: "Disciplines",
                keyColumn: "RecId",
                keyValue: 5,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 23, 16, 1, 45, 974, DateTimeKind.Utc).AddTicks(6903), new DateTime(2021, 7, 23, 16, 1, 45, 974, DateTimeKind.Utc).AddTicks(6903) });

            migrationBuilder.UpdateData(
                table: "Disciplines",
                keyColumn: "RecId",
                keyValue: 6,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 23, 16, 1, 45, 974, DateTimeKind.Utc).AddTicks(6905), new DateTime(2021, 7, 23, 16, 1, 45, 974, DateTimeKind.Utc).AddTicks(6905) });

            migrationBuilder.UpdateData(
                table: "Disciplines",
                keyColumn: "RecId",
                keyValue: 7,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 23, 16, 1, 45, 974, DateTimeKind.Utc).AddTicks(6907), new DateTime(2021, 7, 23, 16, 1, 45, 974, DateTimeKind.Utc).AddTicks(6906) });

            migrationBuilder.UpdateData(
                table: "Disciplines",
                keyColumn: "RecId",
                keyValue: 8,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 23, 16, 1, 45, 974, DateTimeKind.Utc).AddTicks(6908), new DateTime(2021, 7, 23, 16, 1, 45, 974, DateTimeKind.Utc).AddTicks(6908) });

            migrationBuilder.UpdateData(
                table: "Disciplines",
                keyColumn: "RecId",
                keyValue: 9,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 23, 16, 1, 45, 974, DateTimeKind.Utc).AddTicks(6910), new DateTime(2021, 7, 23, 16, 1, 45, 974, DateTimeKind.Utc).AddTicks(6909) });

            migrationBuilder.UpdateData(
                table: "Disciplines",
                keyColumn: "RecId",
                keyValue: 10,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 23, 16, 1, 45, 974, DateTimeKind.Utc).AddTicks(6912), new DateTime(2021, 7, 23, 16, 1, 45, 974, DateTimeKind.Utc).AddTicks(6911) });

            migrationBuilder.UpdateData(
                table: "Disciplines",
                keyColumn: "RecId",
                keyValue: 11,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 23, 16, 1, 45, 974, DateTimeKind.Utc).AddTicks(6913), new DateTime(2021, 7, 23, 16, 1, 45, 974, DateTimeKind.Utc).AddTicks(6913) });

            migrationBuilder.UpdateData(
                table: "Disciplines",
                keyColumn: "RecId",
                keyValue: 12,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 23, 16, 1, 45, 974, DateTimeKind.Utc).AddTicks(6915), new DateTime(2021, 7, 23, 16, 1, 45, 974, DateTimeKind.Utc).AddTicks(6914) });

            migrationBuilder.UpdateData(
                table: "Disciplines",
                keyColumn: "RecId",
                keyValue: 13,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 23, 16, 1, 45, 974, DateTimeKind.Utc).AddTicks(6917), new DateTime(2021, 7, 23, 16, 1, 45, 974, DateTimeKind.Utc).AddTicks(6916) });

            migrationBuilder.UpdateData(
                table: "Disciplines",
                keyColumn: "RecId",
                keyValue: 14,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 23, 16, 1, 45, 974, DateTimeKind.Utc).AddTicks(6918), new DateTime(2021, 7, 23, 16, 1, 45, 974, DateTimeKind.Utc).AddTicks(6917) });

            migrationBuilder.UpdateData(
                table: "Disciplines",
                keyColumn: "RecId",
                keyValue: 15,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 23, 16, 1, 45, 974, DateTimeKind.Utc).AddTicks(6920), new DateTime(2021, 7, 23, 16, 1, 45, 974, DateTimeKind.Utc).AddTicks(6919) });

            migrationBuilder.UpdateData(
                table: "Disciplines",
                keyColumn: "RecId",
                keyValue: 16,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 23, 16, 1, 45, 974, DateTimeKind.Utc).AddTicks(6921), new DateTime(2021, 7, 23, 16, 1, 45, 974, DateTimeKind.Utc).AddTicks(6921) });

            migrationBuilder.UpdateData(
                table: "Disciplines",
                keyColumn: "RecId",
                keyValue: 17,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 23, 16, 1, 45, 974, DateTimeKind.Utc).AddTicks(6923), new DateTime(2021, 7, 23, 16, 1, 45, 974, DateTimeKind.Utc).AddTicks(6922) });

            migrationBuilder.UpdateData(
                table: "Disciplines",
                keyColumn: "RecId",
                keyValue: 18,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 23, 16, 1, 45, 974, DateTimeKind.Utc).AddTicks(6925), new DateTime(2021, 7, 23, 16, 1, 45, 974, DateTimeKind.Utc).AddTicks(6925) });

            migrationBuilder.UpdateData(
                table: "ShareLevels",
                keyColumn: "RecId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 23, 16, 1, 45, 975, DateTimeKind.Utc).AddTicks(2920), new DateTime(2021, 7, 23, 16, 1, 45, 975, DateTimeKind.Utc).AddTicks(2917) });

            migrationBuilder.UpdateData(
                table: "ShareLevels",
                keyColumn: "RecId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 23, 16, 1, 45, 975, DateTimeKind.Utc).AddTicks(4298), new DateTime(2021, 7, 23, 16, 1, 45, 975, DateTimeKind.Utc).AddTicks(4297) });

            migrationBuilder.UpdateData(
                table: "ShareLevels",
                keyColumn: "RecId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 23, 16, 1, 45, 975, DateTimeKind.Utc).AddTicks(4301), new DateTime(2021, 7, 23, 16, 1, 45, 975, DateTimeKind.Utc).AddTicks(4300) });

            migrationBuilder.UpdateData(
                table: "ShareLevels",
                keyColumn: "RecId",
                keyValue: 4,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 23, 16, 1, 45, 975, DateTimeKind.Utc).AddTicks(4303), new DateTime(2021, 7, 23, 16, 1, 45, 975, DateTimeKind.Utc).AddTicks(4302) });

            migrationBuilder.UpdateData(
                table: "ShareLevels",
                keyColumn: "RecId",
                keyValue: 5,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 23, 16, 1, 45, 975, DateTimeKind.Utc).AddTicks(4304), new DateTime(2021, 7, 23, 16, 1, 45, 975, DateTimeKind.Utc).AddTicks(4304) });

            migrationBuilder.UpdateData(
                table: "ShareLevels",
                keyColumn: "RecId",
                keyValue: 6,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 23, 16, 1, 45, 975, DateTimeKind.Utc).AddTicks(4306), new DateTime(2021, 7, 23, 16, 1, 45, 975, DateTimeKind.Utc).AddTicks(4306) });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "RecId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 23, 16, 1, 45, 975, DateTimeKind.Utc).AddTicks(7875), new DateTime(2021, 7, 23, 16, 1, 45, 975, DateTimeKind.Utc).AddTicks(7873) });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "RecId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 23, 16, 1, 45, 975, DateTimeKind.Utc).AddTicks(9570), new DateTime(2021, 7, 23, 16, 1, 45, 975, DateTimeKind.Utc).AddTicks(9569) });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "RecId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 23, 16, 1, 45, 975, DateTimeKind.Utc).AddTicks(9573), new DateTime(2021, 7, 23, 16, 1, 45, 975, DateTimeKind.Utc).AddTicks(9572) });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "RecId",
                keyValue: 4,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 23, 16, 1, 45, 975, DateTimeKind.Utc).AddTicks(9574), new DateTime(2021, 7, 23, 16, 1, 45, 975, DateTimeKind.Utc).AddTicks(9574) });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "RecId",
                keyValue: 5,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 23, 16, 1, 45, 975, DateTimeKind.Utc).AddTicks(9576), new DateTime(2021, 7, 23, 16, 1, 45, 975, DateTimeKind.Utc).AddTicks(9576) });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "RecId",
                keyValue: 6,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 23, 16, 1, 45, 975, DateTimeKind.Utc).AddTicks(9578), new DateTime(2021, 7, 23, 16, 1, 45, 975, DateTimeKind.Utc).AddTicks(9577) });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "RecId",
                keyValue: 7,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 23, 16, 1, 45, 975, DateTimeKind.Utc).AddTicks(9580), new DateTime(2021, 7, 23, 16, 1, 45, 975, DateTimeKind.Utc).AddTicks(9579) });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "RecId",
                keyValue: 8,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 23, 16, 1, 45, 975, DateTimeKind.Utc).AddTicks(9582), new DateTime(2021, 7, 23, 16, 1, 45, 975, DateTimeKind.Utc).AddTicks(9581) });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "RecId",
                keyValue: 9,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 23, 16, 1, 45, 975, DateTimeKind.Utc).AddTicks(9583), new DateTime(2021, 7, 23, 16, 1, 45, 975, DateTimeKind.Utc).AddTicks(9583) });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "RecId",
                keyValue: 10,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 23, 16, 1, 45, 975, DateTimeKind.Utc).AddTicks(9585), new DateTime(2021, 7, 23, 16, 1, 45, 975, DateTimeKind.Utc).AddTicks(9585) });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "RecId",
                keyValue: 11,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 23, 16, 1, 45, 975, DateTimeKind.Utc).AddTicks(9587), new DateTime(2021, 7, 23, 16, 1, 45, 975, DateTimeKind.Utc).AddTicks(9586) });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "RecId",
                keyValue: 12,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 23, 16, 1, 45, 975, DateTimeKind.Utc).AddTicks(9588), new DateTime(2021, 7, 23, 16, 1, 45, 975, DateTimeKind.Utc).AddTicks(9588) });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "RecId",
                keyValue: 13,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 23, 16, 1, 45, 975, DateTimeKind.Utc).AddTicks(9590), new DateTime(2021, 7, 23, 16, 1, 45, 975, DateTimeKind.Utc).AddTicks(9589) });

            migrationBuilder.UpdateData(
                table: "VersionHistories",
                keyColumn: "RecId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 23, 16, 1, 45, 970, DateTimeKind.Utc).AddTicks(7412), new DateTime(2021, 7, 23, 16, 1, 45, 970, DateTimeKind.Utc).AddTicks(7405) });

            migrationBuilder.CreateIndex(
                name: "IX_SharedProductions_OwnerUserId",
                table: "SharedProductions",
                column: "OwnerUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_SharedProductions_OwnerStudioManagerUser",
                table: "SharedProductions",
                column: "OwnerUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ShareLinks_AspNetUsers_StudioManagerUserId",
                table: "ShareLinks",
                column: "StudioManagerUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
