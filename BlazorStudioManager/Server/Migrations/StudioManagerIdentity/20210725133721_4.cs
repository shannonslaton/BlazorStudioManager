using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorStudioManager.Server.Migrations.StudioManagerIdentity
{
    public partial class _4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ReportTemplates",
                columns: table => new
                {
                    RecId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OwnerContactRecId = table.Column<int>(type: "int", nullable: false),
                    LastModifiedById = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedOnDt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated = table.Column<bool>(type: "bit", nullable: false),
                    Hidden = table.Column<bool>(type: "bit", nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EditIndex = table.Column<int>(type: "int", nullable: false),
                    ReportTemplateName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Layout = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Locked = table.Column<bool>(type: "bit", nullable: true),
                    ModelType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GlobalLayout = table.Column<bool>(type: "bit", nullable: true),
                    DisciplineId = table.Column<int>(type: "int", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReportTemplates", x => x.RecId);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ReportTemplates");

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
        }
    }
}
