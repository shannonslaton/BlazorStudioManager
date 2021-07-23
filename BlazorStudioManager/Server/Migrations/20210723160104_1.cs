using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorStudioManager.Server.Migrations
{
    public partial class _1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Catalogs",
                columns: table => new
                {
                    RecId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CatalogName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Catalogs", x => x.RecId);
                });

            migrationBuilder.CreateTable(
                name: "DropDownOptions",
                columns: table => new
                {
                    RecId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DdoType = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DdoTitle = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SubType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DdoAbrv = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DdoNote = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DdoUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MeasurementType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rank = table.Column<int>(type: "int", nullable: true),
                    Locked = table.Column<bool>(type: "bit", nullable: true),
                    DefaultRecId = table.Column<int>(type: "int", nullable: true),
                    ProductionId = table.Column<int>(type: "int", nullable: true),
                    OwnerContactRecId = table.Column<int>(type: "int", nullable: true),
                    DefaultDisciplineId = table.Column<int>(type: "int", nullable: true),
                    DefaultProductionDisciplineId = table.Column<int>(type: "int", nullable: true),
                    DefaultCompanyMemberDepartmentId = table.Column<int>(type: "int", nullable: true),
                    ProductionOwnerUserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductionConnectionString = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShareLevelId = table.Column<int>(type: "int", nullable: false),
                    DisciplineId = table.Column<int>(type: "int", nullable: true),
                    IndexNumber = table.Column<int>(type: "int", nullable: false),
                    Reason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LinkId = table.Column<int>(type: "int", nullable: false),
                    Abbreviation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShortName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedByUserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FromUserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FromRecId = table.Column<int>(type: "int", nullable: false),
                    LastModifiedById = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedOnDt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated = table.Column<bool>(type: "bit", nullable: false),
                    Hidden = table.Column<bool>(type: "bit", nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EditIndex = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DropDownOptions", x => x.RecId);
                });

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
                    ReportType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GlobalLayout = table.Column<bool>(type: "bit", nullable: true),
                    DisciplineId = table.Column<int>(type: "int", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReportTemplates", x => x.RecId);
                });

            migrationBuilder.InsertData(
                table: "Catalogs",
                columns: new[] { "RecId", "CatalogName" },
                values: new object[] { 1, "Performance" });

            migrationBuilder.InsertData(
                table: "Catalogs",
                columns: new[] { "RecId", "CatalogName" },
                values: new object[] { 2, "Sound" });

            migrationBuilder.InsertData(
                table: "Catalogs",
                columns: new[] { "RecId", "CatalogName" },
                values: new object[] { 3, "Lights" });

            migrationBuilder.CreateIndex(
                name: "IX_DropDownOptions_DdoType_DdoTitle",
                table: "DropDownOptions",
                columns: new[] { "DdoType", "DdoTitle" },
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Catalogs");

            migrationBuilder.DropTable(
                name: "DropDownOptions");

            migrationBuilder.DropTable(
                name: "ReportTemplates");
        }
    }
}
