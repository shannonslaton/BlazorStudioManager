using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorStudioManager.Server.Migrations
{
    public partial class _4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ReportTemplates");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ReportTemplates",
                columns: table => new
                {
                    RecId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    DisciplineId = table.Column<int>(type: "int", nullable: true),
                    EditIndex = table.Column<int>(type: "int", nullable: false),
                    GlobalLayout = table.Column<bool>(type: "bit", nullable: true),
                    Hidden = table.Column<bool>(type: "bit", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedById = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedOnDt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Layout = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Locked = table.Column<bool>(type: "bit", nullable: true),
                    OwnerContactRecId = table.Column<int>(type: "int", nullable: false),
                    ReportTemplateName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReportType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Updated = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReportTemplates", x => x.RecId);
                });
        }
    }
}
