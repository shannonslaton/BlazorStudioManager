using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorStudioManager.Server.Migrations.StudioManagerIdentity
{
    public partial class _5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DisciplineId",
                table: "ReportTemplates");

            migrationBuilder.DropColumn(
                name: "OwnerContactRecId",
                table: "ReportTemplates");

            migrationBuilder.RenameColumn(
                name: "LastModifiedBy",
                table: "ReportTemplates",
                newName: "CreatedByUserId");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CreatedByUserId",
                table: "ReportTemplates",
                newName: "LastModifiedBy");

            migrationBuilder.AddColumn<int>(
                name: "DisciplineId",
                table: "ReportTemplates",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OwnerContactRecId",
                table: "ReportTemplates",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "administrator",
                column: "ConcurrencyStamp",
                value: "01b36a91-54ee-4e85-b057-70f2a2c2ea7f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bronze",
                column: "ConcurrencyStamp",
                value: "320b70f3-ec31-4c1f-bf77-848f7af666e2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "gold",
                column: "ConcurrencyStamp",
                value: "a068b1ee-9292-4564-8adc-755846a1cc26");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "guest",
                column: "ConcurrencyStamp",
                value: "62914b12-5368-4afa-9e54-924544aaf73e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "platinum",
                column: "ConcurrencyStamp",
                value: "13b606c2-def1-4f5d-9951-96c754984693");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "showbronze",
                column: "ConcurrencyStamp",
                value: "5d9b352e-d4f6-4e0a-b0d8-a9ff687b7dc4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "showgold",
                column: "ConcurrencyStamp",
                value: "3b1e81bc-9d9d-4cc0-a6c8-b05af3f131ec");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "showguest",
                column: "ConcurrencyStamp",
                value: "19bfb7e2-51df-4717-a7e2-f446fd5e21be");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "showplatinum",
                column: "ConcurrencyStamp",
                value: "e3471d4c-8844-4412-b95e-aad52cc88237");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "showsilver",
                column: "ConcurrencyStamp",
                value: "fed61a54-a155-4462-955f-e5432456e136");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "showtitanium",
                column: "ConcurrencyStamp",
                value: "1313fc42-b112-4e39-9223-ed298b50d84d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "silver",
                column: "ConcurrencyStamp",
                value: "aafa7ec8-cff7-400a-a0f5-d2f9babfa9a2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "titanium",
                column: "ConcurrencyStamp",
                value: "de36a624-0488-4080-ba61-58404c5d0a89");

            migrationBuilder.UpdateData(
                table: "Disciplines",
                keyColumn: "RecId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 25, 13, 37, 20, 631, DateTimeKind.Utc).AddTicks(1233), new DateTime(2021, 7, 25, 13, 37, 20, 631, DateTimeKind.Utc).AddTicks(1229) });

            migrationBuilder.UpdateData(
                table: "Disciplines",
                keyColumn: "RecId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 25, 13, 37, 20, 631, DateTimeKind.Utc).AddTicks(1938), new DateTime(2021, 7, 25, 13, 37, 20, 631, DateTimeKind.Utc).AddTicks(1937) });

            migrationBuilder.UpdateData(
                table: "Disciplines",
                keyColumn: "RecId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 25, 13, 37, 20, 631, DateTimeKind.Utc).AddTicks(1942), new DateTime(2021, 7, 25, 13, 37, 20, 631, DateTimeKind.Utc).AddTicks(1941) });

            migrationBuilder.UpdateData(
                table: "Disciplines",
                keyColumn: "RecId",
                keyValue: 4,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 25, 13, 37, 20, 631, DateTimeKind.Utc).AddTicks(1944), new DateTime(2021, 7, 25, 13, 37, 20, 631, DateTimeKind.Utc).AddTicks(1943) });

            migrationBuilder.UpdateData(
                table: "Disciplines",
                keyColumn: "RecId",
                keyValue: 5,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 25, 13, 37, 20, 631, DateTimeKind.Utc).AddTicks(1971), new DateTime(2021, 7, 25, 13, 37, 20, 631, DateTimeKind.Utc).AddTicks(1971) });

            migrationBuilder.UpdateData(
                table: "Disciplines",
                keyColumn: "RecId",
                keyValue: 6,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 25, 13, 37, 20, 631, DateTimeKind.Utc).AddTicks(1973), new DateTime(2021, 7, 25, 13, 37, 20, 631, DateTimeKind.Utc).AddTicks(1973) });

            migrationBuilder.UpdateData(
                table: "Disciplines",
                keyColumn: "RecId",
                keyValue: 7,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 25, 13, 37, 20, 631, DateTimeKind.Utc).AddTicks(1975), new DateTime(2021, 7, 25, 13, 37, 20, 631, DateTimeKind.Utc).AddTicks(1975) });

            migrationBuilder.UpdateData(
                table: "Disciplines",
                keyColumn: "RecId",
                keyValue: 8,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 25, 13, 37, 20, 631, DateTimeKind.Utc).AddTicks(1977), new DateTime(2021, 7, 25, 13, 37, 20, 631, DateTimeKind.Utc).AddTicks(1976) });

            migrationBuilder.UpdateData(
                table: "Disciplines",
                keyColumn: "RecId",
                keyValue: 9,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 25, 13, 37, 20, 631, DateTimeKind.Utc).AddTicks(1978), new DateTime(2021, 7, 25, 13, 37, 20, 631, DateTimeKind.Utc).AddTicks(1978) });

            migrationBuilder.UpdateData(
                table: "Disciplines",
                keyColumn: "RecId",
                keyValue: 10,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 25, 13, 37, 20, 631, DateTimeKind.Utc).AddTicks(1980), new DateTime(2021, 7, 25, 13, 37, 20, 631, DateTimeKind.Utc).AddTicks(1979) });

            migrationBuilder.UpdateData(
                table: "Disciplines",
                keyColumn: "RecId",
                keyValue: 11,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 25, 13, 37, 20, 631, DateTimeKind.Utc).AddTicks(1981), new DateTime(2021, 7, 25, 13, 37, 20, 631, DateTimeKind.Utc).AddTicks(1981) });

            migrationBuilder.UpdateData(
                table: "Disciplines",
                keyColumn: "RecId",
                keyValue: 12,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 25, 13, 37, 20, 631, DateTimeKind.Utc).AddTicks(1983), new DateTime(2021, 7, 25, 13, 37, 20, 631, DateTimeKind.Utc).AddTicks(1982) });

            migrationBuilder.UpdateData(
                table: "Disciplines",
                keyColumn: "RecId",
                keyValue: 13,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 25, 13, 37, 20, 631, DateTimeKind.Utc).AddTicks(1984), new DateTime(2021, 7, 25, 13, 37, 20, 631, DateTimeKind.Utc).AddTicks(1984) });

            migrationBuilder.UpdateData(
                table: "Disciplines",
                keyColumn: "RecId",
                keyValue: 14,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 25, 13, 37, 20, 631, DateTimeKind.Utc).AddTicks(1986), new DateTime(2021, 7, 25, 13, 37, 20, 631, DateTimeKind.Utc).AddTicks(1985) });

            migrationBuilder.UpdateData(
                table: "Disciplines",
                keyColumn: "RecId",
                keyValue: 15,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 25, 13, 37, 20, 631, DateTimeKind.Utc).AddTicks(1987), new DateTime(2021, 7, 25, 13, 37, 20, 631, DateTimeKind.Utc).AddTicks(1987) });

            migrationBuilder.UpdateData(
                table: "Disciplines",
                keyColumn: "RecId",
                keyValue: 16,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 25, 13, 37, 20, 631, DateTimeKind.Utc).AddTicks(1989), new DateTime(2021, 7, 25, 13, 37, 20, 631, DateTimeKind.Utc).AddTicks(1988) });

            migrationBuilder.UpdateData(
                table: "Disciplines",
                keyColumn: "RecId",
                keyValue: 17,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 25, 13, 37, 20, 631, DateTimeKind.Utc).AddTicks(1990), new DateTime(2021, 7, 25, 13, 37, 20, 631, DateTimeKind.Utc).AddTicks(1990) });

            migrationBuilder.UpdateData(
                table: "Disciplines",
                keyColumn: "RecId",
                keyValue: 18,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 25, 13, 37, 20, 631, DateTimeKind.Utc).AddTicks(1992), new DateTime(2021, 7, 25, 13, 37, 20, 631, DateTimeKind.Utc).AddTicks(1991) });

            migrationBuilder.UpdateData(
                table: "ShareLevels",
                keyColumn: "RecId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 25, 13, 37, 20, 631, DateTimeKind.Utc).AddTicks(7253), new DateTime(2021, 7, 25, 13, 37, 20, 631, DateTimeKind.Utc).AddTicks(7249) });

            migrationBuilder.UpdateData(
                table: "ShareLevels",
                keyColumn: "RecId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 25, 13, 37, 20, 631, DateTimeKind.Utc).AddTicks(8122), new DateTime(2021, 7, 25, 13, 37, 20, 631, DateTimeKind.Utc).AddTicks(8120) });

            migrationBuilder.UpdateData(
                table: "ShareLevels",
                keyColumn: "RecId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 25, 13, 37, 20, 631, DateTimeKind.Utc).AddTicks(8125), new DateTime(2021, 7, 25, 13, 37, 20, 631, DateTimeKind.Utc).AddTicks(8124) });

            migrationBuilder.UpdateData(
                table: "ShareLevels",
                keyColumn: "RecId",
                keyValue: 4,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 25, 13, 37, 20, 631, DateTimeKind.Utc).AddTicks(8126), new DateTime(2021, 7, 25, 13, 37, 20, 631, DateTimeKind.Utc).AddTicks(8126) });

            migrationBuilder.UpdateData(
                table: "ShareLevels",
                keyColumn: "RecId",
                keyValue: 5,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 25, 13, 37, 20, 631, DateTimeKind.Utc).AddTicks(8128), new DateTime(2021, 7, 25, 13, 37, 20, 631, DateTimeKind.Utc).AddTicks(8127) });

            migrationBuilder.UpdateData(
                table: "ShareLevels",
                keyColumn: "RecId",
                keyValue: 6,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 25, 13, 37, 20, 631, DateTimeKind.Utc).AddTicks(8130), new DateTime(2021, 7, 25, 13, 37, 20, 631, DateTimeKind.Utc).AddTicks(8129) });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "RecId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 25, 13, 37, 20, 632, DateTimeKind.Utc).AddTicks(1217), new DateTime(2021, 7, 25, 13, 37, 20, 632, DateTimeKind.Utc).AddTicks(1214) });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "RecId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 25, 13, 37, 20, 632, DateTimeKind.Utc).AddTicks(2231), new DateTime(2021, 7, 25, 13, 37, 20, 632, DateTimeKind.Utc).AddTicks(2229) });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "RecId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 25, 13, 37, 20, 632, DateTimeKind.Utc).AddTicks(2234), new DateTime(2021, 7, 25, 13, 37, 20, 632, DateTimeKind.Utc).AddTicks(2233) });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "RecId",
                keyValue: 4,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 25, 13, 37, 20, 632, DateTimeKind.Utc).AddTicks(2235), new DateTime(2021, 7, 25, 13, 37, 20, 632, DateTimeKind.Utc).AddTicks(2235) });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "RecId",
                keyValue: 5,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 25, 13, 37, 20, 632, DateTimeKind.Utc).AddTicks(2237), new DateTime(2021, 7, 25, 13, 37, 20, 632, DateTimeKind.Utc).AddTicks(2237) });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "RecId",
                keyValue: 6,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 25, 13, 37, 20, 632, DateTimeKind.Utc).AddTicks(2239), new DateTime(2021, 7, 25, 13, 37, 20, 632, DateTimeKind.Utc).AddTicks(2238) });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "RecId",
                keyValue: 7,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 25, 13, 37, 20, 632, DateTimeKind.Utc).AddTicks(2241), new DateTime(2021, 7, 25, 13, 37, 20, 632, DateTimeKind.Utc).AddTicks(2240) });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "RecId",
                keyValue: 8,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 25, 13, 37, 20, 632, DateTimeKind.Utc).AddTicks(2242), new DateTime(2021, 7, 25, 13, 37, 20, 632, DateTimeKind.Utc).AddTicks(2242) });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "RecId",
                keyValue: 9,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 25, 13, 37, 20, 632, DateTimeKind.Utc).AddTicks(2244), new DateTime(2021, 7, 25, 13, 37, 20, 632, DateTimeKind.Utc).AddTicks(2243) });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "RecId",
                keyValue: 10,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 25, 13, 37, 20, 632, DateTimeKind.Utc).AddTicks(2245), new DateTime(2021, 7, 25, 13, 37, 20, 632, DateTimeKind.Utc).AddTicks(2245) });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "RecId",
                keyValue: 11,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 25, 13, 37, 20, 632, DateTimeKind.Utc).AddTicks(2247), new DateTime(2021, 7, 25, 13, 37, 20, 632, DateTimeKind.Utc).AddTicks(2246) });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "RecId",
                keyValue: 12,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 25, 13, 37, 20, 632, DateTimeKind.Utc).AddTicks(2249), new DateTime(2021, 7, 25, 13, 37, 20, 632, DateTimeKind.Utc).AddTicks(2248) });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "RecId",
                keyValue: 13,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 25, 13, 37, 20, 632, DateTimeKind.Utc).AddTicks(2250), new DateTime(2021, 7, 25, 13, 37, 20, 632, DateTimeKind.Utc).AddTicks(2250) });

            migrationBuilder.UpdateData(
                table: "VersionHistories",
                keyColumn: "RecId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastModifiedOnDt" },
                values: new object[] { new DateTime(2021, 7, 25, 13, 37, 20, 627, DateTimeKind.Utc).AddTicks(8924), new DateTime(2021, 7, 25, 13, 37, 20, 627, DateTimeKind.Utc).AddTicks(8918) });
        }
    }
}
