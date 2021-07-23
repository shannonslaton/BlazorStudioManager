using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorStudioManager.Server.Migrations.StudioManagerIdentity
{
    public partial class _1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ShowRoleId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubscriptionDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YearlyCost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ShowRole = table.Column<bool>(type: "bit", nullable: false),
                    PublicRole = table.Column<bool>(type: "bit", nullable: false),
                    UpgradeDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Feature1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Feature2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Feature3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Feature4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Feature5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Feature6 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Feature7 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ColorNames",
                columns: table => new
                {
                    RecId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ColorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    table.PrimaryKey("PK_ColorNames", x => x.RecId);
                });

            migrationBuilder.CreateTable(
                name: "DefaultAppointmentTypes",
                columns: table => new
                {
                    RecId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AppointmentTypeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ColorString = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DefaultAppointmentTypes", x => x.RecId);
                });

            migrationBuilder.CreateTable(
                name: "DisciplineColorDefaults",
                columns: table => new
                {
                    RecId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DisciplineId = table.Column<int>(type: "int", nullable: false),
                    ColorString = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DisciplineColorDefaults", x => x.RecId);
                });

            migrationBuilder.CreateTable(
                name: "DisciplineMerges",
                columns: table => new
                {
                    RecId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DisciplineId = table.Column<int>(type: "int", nullable: false),
                    LastMergedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
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
                    table.PrimaryKey("PK_DisciplineMerges", x => x.RecId);
                });

            migrationBuilder.CreateTable(
                name: "Disciplines",
                columns: table => new
                {
                    RecId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DisciplineName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DisciplineNameShort = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    table.PrimaryKey("PK_Disciplines", x => x.RecId);
                });

            migrationBuilder.CreateTable(
                name: "DropDownOptionDefaults",
                columns: table => new
                {
                    RecId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DdoType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DdoTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DdoAbrv = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DefaultDisciplineId = table.Column<int>(type: "int", nullable: true),
                    DefaultProductionDisciplineId = table.Column<int>(type: "int", nullable: true),
                    DefaultCompanyMemberDepartmentId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DropDownOptionDefaults", x => x.RecId);
                });

            migrationBuilder.CreateTable(
                name: "GridSaves",
                columns: table => new
                {
                    RecId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastModifiedById = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedOnDt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Updated = table.Column<bool>(type: "bit", nullable: true),
                    AspUserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StoreName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GridAllSettings = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GridState = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GridSaves", x => x.RecId);
                });

            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    RecId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DisciplineId = table.Column<int>(type: "int", nullable: true),
                    MessageTypeRecId = table.Column<int>(type: "int", nullable: true),
                    FromContactRecId = table.Column<int>(type: "int", nullable: false),
                    ToContactRecId = table.Column<int>(type: "int", nullable: false),
                    DateSent = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HasBeenRead = table.Column<bool>(type: "bit", nullable: false),
                    FromArchive = table.Column<bool>(type: "bit", nullable: false),
                    FromFlag = table.Column<bool>(type: "bit", nullable: false),
                    MessageSubject = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MessageBody = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MessagesImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MessagesImageFriendlyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MessagesPdfUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MessagesPdfFriendlyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedByContactRecId = table.Column<int>(type: "int", nullable: true),
                    DateFrom = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FromName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ToName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NoteTypeString = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RunningOrderWasIn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CueToWasIn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CueFromWasIn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShowSection = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShowClock = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SectionElapsedTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReplyId = table.Column<int>(type: "int", nullable: false),
                    ToArchive = table.Column<bool>(type: "bit", nullable: false),
                    ToFlag = table.Column<bool>(type: "bit", nullable: false),
                    StudioManagerUserFromId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudioManagerUserToId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductionName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FromCompanyMemeberTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ToCompanyMemeberTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    table.PrimaryKey("PK_Messages", x => x.RecId);
                });

            migrationBuilder.CreateTable(
                name: "PageHelpers",
                columns: table => new
                {
                    RecId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WidgetId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PageTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PageHelp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VideoUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VideoTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PageType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GridVersion = table.Column<int>(type: "int", nullable: false),
                    LoadType = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    table.PrimaryKey("PK_PageHelpers", x => x.RecId);
                });

            migrationBuilder.CreateTable(
                name: "PromoCodes",
                columns: table => new
                {
                    RecId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PromoCodeString = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CodeUses = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SubscriptionRoleId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PurchaseId = table.Column<int>(type: "int", nullable: true),
                    PercentDiscount = table.Column<int>(type: "int", nullable: false),
                    OwnerContactRecId = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_PromoCode", x => x.RecId);
                });

            migrationBuilder.CreateTable(
                name: "PromoCodesUsed",
                columns: table => new
                {
                    RecId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudioManagerUserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateUsed = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PromoCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    table.PrimaryKey("PK_PromoCodeUsed", x => x.RecId);
                });

            migrationBuilder.CreateTable(
                name: "Purchases",
                columns: table => new
                {
                    RecId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PurchaseDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PurchaserEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PurchasePrice = table.Column<decimal>(type: "money", nullable: true),
                    SubscriptionRoleId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpgradeRenewalGift = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PromoCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransactionId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OwnerContactRecId = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_Purchases", x => x.RecId);
                });

            migrationBuilder.CreateTable(
                name: "ReportDefinitions",
                columns: table => new
                {
                    RecId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReportTemplate = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    StudioManagerUserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReportType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReportName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedByName = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    table.PrimaryKey("PK_ReportDefinitions", x => x.RecId);
                });

            migrationBuilder.CreateTable(
                name: "ScheduleResources",
                columns: table => new
                {
                    RecId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ColorHashTag = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScheduleResources", x => x.RecId);
                });

            migrationBuilder.CreateTable(
                name: "Themes",
                columns: table => new
                {
                    RecId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ThemeId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThemeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThemeUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    isDark = table.Column<bool>(type: "bit", nullable: false),
                    ThemeShade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OwnerContactRecId = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_Themes", x => x.RecId);
                });

            migrationBuilder.CreateTable(
                name: "VersionHistories",
                columns: table => new
                {
                    RecId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Version = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsCurrent = table.Column<bool>(type: "bit", nullable: false),
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
                    table.PrimaryKey("PK_VersionHistories", x => x.RecId);
                });

            migrationBuilder.CreateTable(
                name: "ZipCodes",
                columns: table => new
                {
                    RecId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Zip = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    County = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TimeZone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Latitude = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Longitude = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    LatitudeSt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LongitudeSt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ZipCodes", x => x.RecId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ShareLevels",
                columns: table => new
                {
                    RecId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShareLevelName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    SizeAllotment = table.Column<long>(type: "bigint", nullable: false),
                    SizeFriendlyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudioManagerNetRoleId = table.Column<string>(type: "nvarchar(450)", nullable: true),
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
                    table.PrimaryKey("PK_ShareLevels", x => x.RecId);
                    table.ForeignKey(
                        name: "FK_ShareLevels_AspNetRoles_StudioManagerNetRoleId",
                        column: x => x.StudioManagerNetRoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DisciplineId = table.Column<int>(type: "int", nullable: true),
                    ProductionDisciplineId = table.Column<int>(type: "int", nullable: true),
                    ContactId = table.Column<int>(type: "int", nullable: true),
                    ThemeId = table.Column<int>(type: "int", nullable: true),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductionId = table.Column<int>(type: "int", nullable: true),
                    SharedProductionId = table.Column<int>(type: "int", nullable: true),
                    ProductionAspUserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KeepInfoPrivate = table.Column<bool>(type: "bit", nullable: false),
                    ShowNewUser = table.Column<bool>(type: "bit", nullable: false),
                    ShowNewFeatures = table.Column<bool>(type: "bit", nullable: false),
                    DatabaseNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiscountPoints = table.Column<int>(type: "int", nullable: false),
                    IsCustomerSupport = table.Column<bool>(type: "bit", nullable: false),
                    CustomerSupportPoints = table.Column<int>(type: "int", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P256dh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Auth = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FreeTrialEnded = table.Column<bool>(type: "bit", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Discipline_StudioManagerUsers",
                        column: x => x.DisciplineId,
                        principalTable: "Disciplines",
                        principalColumn: "RecId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PurchaseDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SubscriptionEndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RecId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubscriptionRoleId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DisciplineColors",
                columns: table => new
                {
                    RecId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastModifiedById = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedOnDt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Updated = table.Column<bool>(type: "bit", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DisciplineId = table.Column<int>(type: "int", nullable: false),
                    ColorString = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudioManagerUserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DisciplineColors", x => x.RecId);
                    table.ForeignKey(
                        name: "FK_DisciplineColors_AspNetUsers_StudioManagerUserId",
                        column: x => x.StudioManagerUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "NotificationMessages",
                columns: table => new
                {
                    RecId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MessageType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SendMessage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NotificationUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SendToEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HasBeenRead = table.Column<bool>(type: "bit", nullable: false),
                    Archive = table.Column<bool>(type: "bit", nullable: false),
                    ReportId = table.Column<int>(type: "int", nullable: false),
                    StudioManagerUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
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
                    table.PrimaryKey("PK_NotificationMessages", x => x.RecId);
                    table.ForeignKey(
                        name: "FK_NotificationMessages_AspNetUsers_StudioManagerUserId",
                        column: x => x.StudioManagerUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SharedProductions",
                columns: table => new
                {
                    RecId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastModifiedById = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedOnDt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Updated = table.Column<bool>(type: "bit", nullable: true),
                    ProductionId = table.Column<int>(type: "int", nullable: false),
                    OwnerUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    OwnerContactId = table.Column<int>(type: "int", nullable: false),
                    SharedWithUserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Archive = table.Column<bool>(type: "bit", nullable: false),
                    ShareLevelId = table.Column<int>(type: "int", nullable: false),
                    IsProductionCreator = table.Column<bool>(type: "bit", nullable: false),
                    UserHasConnected = table.Column<bool>(type: "bit", nullable: false),
                    SharedWithEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShareWithContactId = table.Column<int>(type: "int", nullable: false),
                    Enabled = table.Column<bool>(type: "bit", nullable: false),
                    CompanyMemberId = table.Column<int>(type: "int", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    Hidden = table.Column<bool>(type: "bit", nullable: false),
                    LastLoggedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastMergedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AllowMerge = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SharedProductions", x => x.RecId);
                    table.ForeignKey(
                        name: "FK_SharedProductions_OwnerStudioManagerUser",
                        column: x => x.OwnerUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ShareLinks",
                columns: table => new
                {
                    RecId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShareName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Enabled = table.Column<bool>(type: "bit", nullable: false),
                    ShareLinkUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FileTypes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UrlId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OwnerContactRecId = table.Column<int>(type: "int", nullable: false),
                    NameOfProduction = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudioManagerUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ProductionId = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_ShareLinks", x => x.RecId);
                    table.ForeignKey(
                        name: "FK_ShareLinks_AspNetUsers_StudioManagerUserId",
                        column: x => x.StudioManagerUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ShareMessages",
                columns: table => new
                {
                    RecId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LinkId = table.Column<int>(type: "int", nullable: false),
                    LastModifiedById = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedOnDt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Updated = table.Column<bool>(type: "bit", nullable: true),
                    MessageFromUserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MessageTypeId = table.Column<int>(type: "int", nullable: false),
                    MessageLinkId = table.Column<int>(type: "int", nullable: false),
                    HasBeenRead = table.Column<bool>(type: "bit", nullable: false),
                    Archived = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShareMessages", x => x.RecId);
                    table.ForeignKey(
                        name: "FK_ShareMessages_ShareMessage",
                        column: x => x.LinkId,
                        principalTable: "SharedProductions",
                        principalColumn: "RecId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ShareLinkFiles",
                columns: table => new
                {
                    RecId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FileId = table.Column<int>(type: "int", nullable: false),
                    LinkId = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_ShareLinkFiles", x => x.RecId);
                    table.ForeignKey(
                        name: "FK_ShareLinkFiles_ShareLinks_LinkId",
                        column: x => x.LinkId,
                        principalTable: "ShareLinks",
                        principalColumn: "RecId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ShareMessageReplies",
                columns: table => new
                {
                    RecId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LinkId = table.Column<int>(type: "int", nullable: false),
                    LastModifiedById = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedOnDt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Updated = table.Column<bool>(type: "bit", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReplyFromUserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReplyToUserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReplySubject = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReplyText = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShareMessageReplies", x => x.RecId);
                    table.ForeignKey(
                        name: "FK_ShareMessageReply_ShareMessage",
                        column: x => x.LinkId,
                        principalTable: "ShareMessages",
                        principalColumn: "RecId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Feature1", "Feature2", "Feature3", "Feature4", "Feature5", "Feature6", "Feature7", "Name", "NormalizedName", "PublicRole", "ShowRole", "ShowRoleId", "SubscriptionDescription", "UpgradeDescription", "YearlyCost" },
                values: new object[,]
                {
                    { "showgold", "c72349d9-9081-4be8-a3f3-9549d5b7d464", null, null, null, null, null, null, null, "ShowGold", "SHOWGOLD", false, true, null, "", null, 0m },
                    { "guest", "50644435-48ee-4a4e-9b4e-38acbed47a67", "View shared productions", "Unlimited collaborators", "Online Scheduling", "Customizable Reports", "Online Cast Check-in", "No Online Storage", " per year", "Guest", "GUEST", false, false, "showguest", "No Rights", null, 0m },
                    { "bronze", "1a4b8913-3763-484f-9d4b-449ea9aef66d", "View shared productions", "Mark Check List information", "Online Scheduling", "Online performance reports", "Online Cast Check-in", "No Online Storage", " per year", "Bronze", "BRONZE", true, false, "showbronze", "Viewing and Check List Only", null, 0m },
                    { "gold", "15b99ba0-c497-464a-84d7-e3f32f0b0dd2", "Unlimited productions", "Unlimited collaborators", "Online Scheduling", "Customizable Reports", "Online Cast Check-in", "1 Terabyte Online Storage", " per year", "Gold", "GOLD", true, false, "showgold", "Full Rights and 1GB of storage", null, 200m },
                    { "silver", "c2891455-1749-4a43-9b39-923ea7eae829", "Unlimited productions", "Unlimited collaborators", "Online Scheduling", "Customizable Reports", "Online Cast Check-in", "1 Gigabyte Online Storage", " per year", "Silver", "SILVER", true, false, "showsilver", "Full Rights and 500MB of storage", null, 100m },
                    { "platinum", "eb4e935b-b03c-4dc4-9142-230bd41f239f", "Unlimited productions", "Unlimited collaborators", "Online Scheduling", "Customizable Reports", "Online Cast Check-in", "5 Terabytes Online Storage", " per year", "Platinum", "PLATINUM", true, false, "showplatinum", "Full Rights and 2TB of storage", null, 400m },
                    { "titanium", "192f4248-2f66-42ee-85df-05f1d5fb81a7", "Unlimited productions", "Unlimited collaborators", "Online Scheduling", "Customizable Reports", "Online Cast Check-in", "2 Terabytes Online Storage", " per year", "Titanium", "TITANIUM", true, false, "showtitanium", "Full Rights and 1TB of storage", null, 300m },
                    { "showguest", "6e9d366d-cb4b-421d-848b-14d69da790d9", null, null, null, null, null, null, null, "ShowGuest", "SHOWGUEST", false, true, null, "", null, 0m },
                    { "showbronze", "26d68847-aedf-40ab-bbc4-f0e62315f6a4", null, null, null, null, null, null, null, "ShowBronze", "SHOWBRONZE", false, true, null, "", null, 0m },
                    { "showsilver", "a2162d1b-feb6-491d-96e3-8d871aab7e26", null, null, null, null, null, null, null, "ShowSilver", "SHOWSILVER", false, true, null, "", null, 0m },
                    { "showplatinum", "18ac2195-933a-44fa-a6b1-d707350c243e", null, null, null, null, null, null, null, "ShowPlatinum", "SHOWPLATINUM", false, true, null, "", null, 0m },
                    { "showtitanium", "97e37e18-91a9-4c19-b853-be5fa732e897", null, null, null, null, null, null, null, "ShowTitanium", "SHOWTITANIUM", false, true, null, "", null, 0m },
                    { "administrator", "b034de35-b2dd-4d52-a2be-34b8018b1765", null, null, null, null, null, null, null, "Administrator", "ADMINISTRATOR", false, false, "showplatinum", "Greetings Professor Falken", null, 0m }
                });

            migrationBuilder.InsertData(
                table: "DefaultAppointmentTypes",
                columns: new[] { "RecId", "AppointmentTypeName", "ColorString" },
                values: new object[,]
                {
                    { 1, "Performance", "CornflowerBlue" },
                    { 4, "Audition", "DarkOrange" },
                    { 11, "Haircut", "OrangeRed" },
                    { 9, "Coverage", "MediumSeaGreen" },
                    { 8, "Meeting", "MediumTurquoise" },
                    { 7, "Housing", "AntiqueWhite" },
                    { 10, "Costume Fitting", "OrangeRed" },
                    { 5, "Callback", "DeepSkyBlue" },
                    { 3, "Press", "CadetBlue" },
                    { 2, "Rehearsal", "Coral" },
                    { 6, "Travel", "BurlyWood" }
                });

            migrationBuilder.InsertData(
                table: "DisciplineColorDefaults",
                columns: new[] { "RecId", "ColorString", "DisciplineId" },
                values: new object[,]
                {
                    { 14, "#FF00FFFF", 14 },
                    { 7, "#FF00FFFF", 7 },
                    { 13, "#FF00FFFF", 13 },
                    { 12, "#FF00FFFF", 12 },
                    { 11, "#FF00FFFF", 11 },
                    { 10, "#FF00FFFF", 10 },
                    { 9, "#FF00FFFF", 9 },
                    { 8, "#FF00FFFF", 8 },
                    { 6, "#FF00FFFF", 6 },
                    { 1, "#FF00FFFF", 1 },
                    { 4, "#FF00FFFF", 4 },
                    { 3, "#FF00FFFF", 3 },
                    { 2, "#FF00FFFF", 2 },
                    { 15, "#FF00FFFF", 15 },
                    { 17, "#FF00FFFF", 17 },
                    { 18, "#FF00FFFF", 18 },
                    { 5, "#FF00FFFF", 5 },
                    { 16, "#FF00FFFF", 16 }
                });

            migrationBuilder.InsertData(
                table: "Disciplines",
                columns: new[] { "RecId", "CreatedOn", "Deleted", "DisciplineName", "DisciplineNameShort", "EditIndex", "Hidden", "LastModifiedById", "LastModifiedOnDt", "Updated" },
                values: new object[,]
                {
                    { 2, new DateTime(2021, 7, 23, 16, 1, 45, 974, DateTimeKind.Utc).AddTicks(6896), false, "Sound", "Sound", 0, false, null, new DateTime(2021, 7, 23, 16, 1, 45, 974, DateTimeKind.Utc).AddTicks(6894), true },
                    { 1, new DateTime(2021, 7, 23, 16, 1, 45, 974, DateTimeKind.Utc).AddTicks(5495), false, "Actor", "Actor", 0, false, null, new DateTime(2021, 7, 23, 16, 1, 45, 974, DateTimeKind.Utc).AddTicks(5240), true },
                    { 3, new DateTime(2021, 7, 23, 16, 1, 45, 974, DateTimeKind.Utc).AddTicks(6899), false, "Lighting", "Lighting", 0, false, null, new DateTime(2021, 7, 23, 16, 1, 45, 974, DateTimeKind.Utc).AddTicks(6898), true },
                    { 4, new DateTime(2021, 7, 23, 16, 1, 45, 974, DateTimeKind.Utc).AddTicks(6901), false, "Props", "Props", 0, false, null, new DateTime(2021, 7, 23, 16, 1, 45, 974, DateTimeKind.Utc).AddTicks(6900), true },
                    { 17, new DateTime(2021, 7, 23, 16, 1, 45, 974, DateTimeKind.Utc).AddTicks(6923), false, "Make Up", "Make Up", 0, false, null, new DateTime(2021, 7, 23, 16, 1, 45, 974, DateTimeKind.Utc).AddTicks(6922), true },
                    { 18, new DateTime(2021, 7, 23, 16, 1, 45, 974, DateTimeKind.Utc).AddTicks(6925), false, "Production Management", "Production Management", 0, false, null, new DateTime(2021, 7, 23, 16, 1, 45, 974, DateTimeKind.Utc).AddTicks(6925), true },
                    { 5, new DateTime(2021, 7, 23, 16, 1, 45, 974, DateTimeKind.Utc).AddTicks(6903), false, "Choreography", "Choreography", 0, false, null, new DateTime(2021, 7, 23, 16, 1, 45, 974, DateTimeKind.Utc).AddTicks(6903), true },
                    { 6, new DateTime(2021, 7, 23, 16, 1, 45, 974, DateTimeKind.Utc).AddTicks(6905), false, "Stage Management", "Stage Management", 0, false, null, new DateTime(2021, 7, 23, 16, 1, 45, 974, DateTimeKind.Utc).AddTicks(6905), true },
                    { 7, new DateTime(2021, 7, 23, 16, 1, 45, 974, DateTimeKind.Utc).AddTicks(6907), false, "Wardrobe", "Wardrobe", 0, false, null, new DateTime(2021, 7, 23, 16, 1, 45, 974, DateTimeKind.Utc).AddTicks(6906), true },
                    { 9, new DateTime(2021, 7, 23, 16, 1, 45, 974, DateTimeKind.Utc).AddTicks(6910), false, "Company Management", "Company Management", 0, false, null, new DateTime(2021, 7, 23, 16, 1, 45, 974, DateTimeKind.Utc).AddTicks(6909), true },
                    { 10, new DateTime(2021, 7, 23, 16, 1, 45, 974, DateTimeKind.Utc).AddTicks(6912), false, "General Management", "General Management", 0, false, null, new DateTime(2021, 7, 23, 16, 1, 45, 974, DateTimeKind.Utc).AddTicks(6911), true },
                    { 8, new DateTime(2021, 7, 23, 16, 1, 45, 974, DateTimeKind.Utc).AddTicks(6908), false, "Hair", "Hair", 0, false, null, new DateTime(2021, 7, 23, 16, 1, 45, 974, DateTimeKind.Utc).AddTicks(6908), true },
                    { 12, new DateTime(2021, 7, 23, 16, 1, 45, 974, DateTimeKind.Utc).AddTicks(6915), false, "Directing", "Directing", 0, false, null, new DateTime(2021, 7, 23, 16, 1, 45, 974, DateTimeKind.Utc).AddTicks(6914), true },
                    { 13, new DateTime(2021, 7, 23, 16, 1, 45, 974, DateTimeKind.Utc).AddTicks(6917), false, "Musician", "Musician", 0, false, null, new DateTime(2021, 7, 23, 16, 1, 45, 974, DateTimeKind.Utc).AddTicks(6916), true },
                    { 14, new DateTime(2021, 7, 23, 16, 1, 45, 974, DateTimeKind.Utc).AddTicks(6918), false, "Scenic", "Scenic", 0, false, null, new DateTime(2021, 7, 23, 16, 1, 45, 974, DateTimeKind.Utc).AddTicks(6917), true },
                    { 15, new DateTime(2021, 7, 23, 16, 1, 45, 974, DateTimeKind.Utc).AddTicks(6920), false, "Projections", "Projections", 0, false, null, new DateTime(2021, 7, 23, 16, 1, 45, 974, DateTimeKind.Utc).AddTicks(6919), true },
                    { 16, new DateTime(2021, 7, 23, 16, 1, 45, 974, DateTimeKind.Utc).AddTicks(6921), false, "House Management", "House Management", 0, false, null, new DateTime(2021, 7, 23, 16, 1, 45, 974, DateTimeKind.Utc).AddTicks(6921), true },
                    { 11, new DateTime(2021, 7, 23, 16, 1, 45, 974, DateTimeKind.Utc).AddTicks(6913), false, "Marketing", "Marketing", 0, false, null, new DateTime(2021, 7, 23, 16, 1, 45, 974, DateTimeKind.Utc).AddTicks(6913), true }
                });

            migrationBuilder.InsertData(
                table: "DropDownOptionDefaults",
                columns: new[] { "RecId", "DdoAbrv", "DdoTitle", "DdoType", "DefaultCompanyMemberDepartmentId", "DefaultDisciplineId", "DefaultProductionDisciplineId" },
                values: new object[,]
                {
                    { 133, null, "Metric", "MeasurementType", null, null, null },
                    { 125, null, "Musician", "CompanyMemberTitle", null, 13, 13 },
                    { 128, null, "Actor", "CompanyMemberTitle", null, 1, 1 },
                    { 129, null, "Small", "LabelType", null, null, null },
                    { 130, null, "Large", "LabelType", null, null, null },
                    { 131, null, "Both", "LabelType", null, null, null },
                    { 132, null, "Imperial", "MeasurementType", null, null, null },
                    { 134, null, "Green", "CueLightColor", null, null, null },
                    { 141, null, "China", "CountryOfOrigin", null, null, null },
                    { 136, null, "Red", "CueLightColor", null, null, null },
                    { 137, null, "Yellow", "CueLightColor", null, null, null },
                    { 138, null, "USA", "CountryOfOrigin", null, null, null },
                    { 139, null, "Canada", "CountryOfOrigin", null, null, null },
                    { 140, null, "Mexico", "CountryOfOrigin", null, null, null },
                    { 124, null, "Director", "CompanyMemberTitle", null, 12, 12 },
                    { 142, null, "Russia", "CountryOfOrigin", null, null, null },
                    { 143, null, "Finland", "CountryOfOrigin", null, null, null },
                    { 144, null, "Sweden", "CountryOfOrigin", null, null, null },
                    { 135, null, "Blue", "CueLightColor", null, null, null },
                    { 123, null, "Marketing Manager", "CompanyMemberTitle", null, 11, 11 },
                    { 116, null, "They/Them", "PreferredPronoun", null, null, null },
                    { 121, null, "Split Track", "PerformerHierarchy", null, null, null },
                    { 145, null, "Ireland", "CountryOfOrigin", null, null, null },
                    { 103, null, "Cis", "GenderOption", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "DropDownOptionDefaults",
                columns: new[] { "RecId", "DdoAbrv", "DdoTitle", "DdoType", "DefaultCompanyMemberDepartmentId", "DefaultDisciplineId", "DefaultProductionDisciplineId" },
                values: new object[,]
                {
                    { 104, null, "Gender Fluid", "GenderOption", null, null, null },
                    { 105, null, "Cis Male", "GenderOption", null, null, null },
                    { 106, null, "Cis Female", "GenderOption", null, null, null },
                    { 107, null, "Bigender", "GenderOption", null, null, null },
                    { 108, null, "Intersex", "GenderOption", null, null, null },
                    { 109, null, "Non-binary", "GenderOption", null, null, null },
                    { 122, null, "Archive", "PerformerHierarchy", null, null, null },
                    { 110, null, "Other", "GenderOption", null, null, null },
                    { 112, null, "Transgender", "GenderOption", null, null, null },
                    { 113, null, "Transsexual", "GenderOption", null, null, null },
                    { 114, null, "He/Him", "PreferredPronoun", null, null, null },
                    { 115, null, "She/Her", "PreferredPronoun", null, null, null },
                    { 117, null, "Main", "PerformerHierarchy", null, null, null },
                    { 118, null, "First Cover", "PerformerHierarchy", null, null, null },
                    { 119, null, "Second Cover", "PerformerHierarchy", null, null, null },
                    { 120, null, "Third Cover", "PerformerHierarchy", null, null, null },
                    { 111, null, "Trans", "GenderOption", null, null, null },
                    { 146, null, "England", "CountryOfOrigin", null, null, null },
                    { 176, null, "Spacing", "Rehearsal", null, null, null },
                    { 148, null, "Italy", "CountryOfOrigin", null, null, null },
                    { 172, null, "Dress Run", "Rehearsal", null, null, null },
                    { 173, null, "Blocking", "Rehearsal", null, null, null },
                    { 174, null, "Choreography", "Rehearsal", null, null, null },
                    { 175, null, "Table Read", "Rehearsal", null, null, null },
                    { 102, null, "Female", "GenderOption", null, null, null },
                    { 177, null, "Week", "Route", null, null, null },
                    { 178, null, "Split-Week", "Route", null, null, null },
                    { 179, null, "One-Off", "Route", null, null, null },
                    { 171, null, "Tech", "Rehearsal", null, null, null },
                    { 180, null, "Flight", "Travel", null, null, null },
                    { 182, null, "Train", "Travel", null, null, null },
                    { 183, null, "Boat", "Travel", null, null, null },
                    { 184, null, "Car", "Travel", null, null, null },
                    { 185, null, "Production", "Meeting", null, null, null },
                    { 186, null, "Load-out", "Meeting", null, null, null },
                    { 187, null, "Load-in", "Meeting", null, null, null },
                    { 188, null, "Meet and Greet", "Meeting", null, null, null },
                    { 189, null, "Equity", "Meeting", null, null, null },
                    { 181, null, "Bus", "Travel", null, null, null },
                    { 170, null, "Hotel", "Accommodations", null, null, null },
                    { 169, null, "Invited Dress", "Performance", null, null, null },
                    { 168, null, "Closing", "Performance", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "DropDownOptionDefaults",
                columns: new[] { "RecId", "DdoAbrv", "DdoTitle", "DdoType", "DefaultCompanyMemberDepartmentId", "DefaultDisciplineId", "DefaultProductionDisciplineId" },
                values: new object[,]
                {
                    { 149, null, "Germany", "CountryOfOrigin", null, null, null },
                    { 150, null, "Brazil", "CountryOfOrigin", null, null, null },
                    { 151, null, "Peru", "CountryOfOrigin", null, null, null },
                    { 152, null, "Argentina", "CountryOfOrigin", null, null, null },
                    { 153, null, "Austria", "CountryOfOrigin", null, null, null },
                    { 154, null, "Spain", "CountryOfOrigin", null, null, null },
                    { 155, null, "Lithuania", "CountryOfOrigin", null, null, null },
                    { 156, null, "Poland", "CountryOfOrigin", null, null, null },
                    { 157, null, "Choreographer", "CompanyMemberTitle", null, 5, 5 },
                    { 158, null, "Associate Choreographer", "CompanyMemberTitle", null, null, 5 },
                    { 159, null, "Assistant Choreographer", "CompanyMemberTitle", null, null, 5 },
                    { 160, null, "Intern Choreographer", "CompanyMemberTitle", null, null, 5 },
                    { 161, null, "Dance Captain", "CompanyMemberTitle", null, null, 5 },
                    { 162, null, "Matinee", "Performance", null, null, null },
                    { 163, null, "Evening", "Performance", null, null, null },
                    { 164, null, "First Preview", "Performance", null, null, null },
                    { 165, null, "Preview Evening", "Performance", null, null, null },
                    { 166, null, "Preview Matinee", "Performance", null, null, null },
                    { 167, null, "Preview", "Performance", null, null, null },
                    { 147, null, "Russia", "CountryOfOrigin", null, null, null },
                    { 101, null, "Male", "GenderOption", null, null, null },
                    { 87, null, "Assistant Projection Designer", "CompanyMemberTitle", null, null, 15 },
                    { 99, null, "Proscenium Width", "ContactSpecTypeVenue", null, null, null },
                    { 27, null, "RF Tech", "CompanyMemberTitle", null, null, 2 },
                    { 28, null, "Production Sound", "CompanyMemberTitle", null, null, 2 },
                    { 29, null, "Scenic Designer", "CompanyMemberTitle", null, 14, 14 },
                    { 30, null, "Associate Scenic Designer", "CompanyMemberTitle", null, null, 14 },
                    { 31, null, "Assistant Scenic Designer", "CompanyMemberTitle", null, null, 14 },
                    { 32, null, "Scenic Intern", "CompanyMemberTitle", null, null, 14 },
                    { 33, null, "Scenic Draftsman", "CompanyMemberTitle", null, null, 14 },
                    { 34, null, "Head Electrician", "CompanyMemberTitle", null, null, 3 },
                    { 35, null, "Head Sound", "CompanyMemberTitle", null, null, 2 },
                    { 36, null, "Head Carpenter", "CompanyMemberTitle", null, 14, null },
                    { 37, null, "Head Props", "CompanyMemberTitle", null, null, 4 },
                    { 38, null, "Head Wardrobe", "CompanyMemberTitle", null, null, 7 },
                    { 39, null, "Head Hair", "CompanyMemberTitle", null, null, 8 },
                    { 100, null, "Proscenium Width", "ContactSpecTypeVenue", null, null, null },
                    { 41, null, "Deck Carpenter", "CompanyMemberTitle", null, null, 14 },
                    { 42, null, "Flyman", "CompanyMemberTitle", null, null, 14 },
                    { 43, null, "Automation Operator", "CompanyMemberTitle", null, null, 14 },
                    { 44, null, "Automation", "CompanyMemberTitle", null, null, 14 },
                    { 45, null, "Prop Designer", "CompanyMemberTitle", null, 4, 4 }
                });

            migrationBuilder.InsertData(
                table: "DropDownOptionDefaults",
                columns: new[] { "RecId", "DdoAbrv", "DdoTitle", "DdoType", "DefaultCompanyMemberDepartmentId", "DefaultDisciplineId", "DefaultProductionDisciplineId" },
                values: new object[,]
                {
                    { 46, null, "Associate Prop Designer", "CompanyMemberTitle", null, null, 4 },
                    { 47, null, "Assistant Prop Designer", "CompanyMemberTitle", null, null, 4 },
                    { 26, null, "Deck Sound", "CompanyMemberTitle", null, null, 2 },
                    { 25, null, "Sound Board Operator", "CompanyMemberTitle", null, null, 2 },
                    { 24, null, "Sound Intern", "CompanyMemberTitle", null, null, 2 },
                    { 23, null, "Qlab Programmer", "CompanyMemberTitle", null, null, 2 },
                    { 1, null, "Lead", "ActorType", null, null, null },
                    { 2, null, "Ensemble", "ActorType", null, null, null },
                    { 3, null, "Investment", "BudgetLineItemType", null, null, null },
                    { 4, null, "Invoice", "BudgetLineItemType", null, null, null },
                    { 5, null, "Pay", "BudgetLineItemType", null, null, null },
                    { 6, null, "Cast", "CompanyMemberDepartment", null, null, null },
                    { 7, null, "Creatives", "CompanyMemberDepartment", null, null, null },
                    { 8, null, "Musicians", "CompanyMemberDepartment", null, null, null },
                    { 9, null, "Crew", "CompanyMemberDepartment", null, null, null },
                    { 10, null, "Management", "CompanyMemberDepartment", null, null, null },
                    { 48, null, "Prop Design Intern", "CompanyMemberTitle", null, null, 4 },
                    { 11, null, "Lighting Designer", "CompanyMemberTitle", null, 3, 3 },
                    { 13, null, "Assistant Lighting Designer", "CompanyMemberTitle", null, null, 3 },
                    { 14, null, "Moving Light Programmer", "CompanyMemberTitle", null, null, 3 },
                    { 15, null, "Light Board Operator", "CompanyMemberTitle", null, null, 3 },
                    { 16, null, "Deck Electrician", "CompanyMemberTitle", null, null, 3 },
                    { 17, null, "Spot Operator", "CompanyMemberTitle", null, null, 3 },
                    { 18, null, "Lighting Intern", "CompanyMemberTitle", null, null, 3 },
                    { 19, null, "Production Lighting", "CompanyMemberTitle", null, null, 3 },
                    { 20, null, "Sound Designer", "CompanyMemberTitle", null, 2, 2 },
                    { 21, null, "Associate Sound Designer", "CompanyMemberTitle", null, null, 2 },
                    { 22, null, "Assistant Sound Designer", "CompanyMemberTitle", null, null, 2 },
                    { 12, null, "Associate Lighting Designer", "CompanyMemberTitle", null, null, 3 },
                    { 49, null, "Props", "CompanyMemberTitle", null, null, 4 },
                    { 40, null, "Carpenter", "CompanyMemberTitle", null, null, 14 },
                    { 51, null, "Associate Costume Designer", "CompanyMemberTitle", null, null, 7 },
                    { 77, null, "Associate Production Manager", "CompanyMemberTitle", null, null, 18 },
                    { 78, null, "Associate Production Manager", "CompanyMemberTitle", null, null, 18 },
                    { 79, null, "Production Manager Intern", "CompanyMemberTitle", null, null, 18 },
                    { 80, null, "Production Stage Manager", "CompanyMemberTitle", null, null, 6 },
                    { 81, null, "Deck Stage Manager", "CompanyMemberTitle", null, null, 6 },
                    { 82, null, "Stage Manager", "CompanyMemberTitle", null, null, 6 },
                    { 83, null, "Stage Manager Intern", "CompanyMemberTitle", null, null, 6 },
                    { 50, null, "Costume Designer", "CompanyMemberTitle", null, null, 7 },
                    { 85, null, "Projection Designer", "CompanyMemberTitle", null, 15, 15 },
                    { 86, null, "Associate Projection Designer", "CompanyMemberTitle", null, null, 15 }
                });

            migrationBuilder.InsertData(
                table: "DropDownOptionDefaults",
                columns: new[] { "RecId", "DdoAbrv", "DdoTitle", "DdoType", "DefaultCompanyMemberDepartmentId", "DefaultDisciplineId", "DefaultProductionDisciplineId" },
                values: new object[,]
                {
                    { 88, null, "Projection Design Intern", "CompanyMemberTitle", null, null, 15 },
                    { 89, null, "Projection Operator", "CompanyMemberTitle", null, null, 15 },
                    { 90, null, "Video", "CompanyMemberTitle", null, null, 15 },
                    { 91, null, "House Manager", "CompanyMemberTitle", null, 16, 16 },
                    { 92, null, "Assistant House Manager", "CompanyMemberTitle", null, null, 16 },
                    { 93, null, "Box Office Manager", "CompanyMemberTitle", null, null, 16 },
                    { 94, null, "Assistant Box Office Manager", "CompanyMemberTitle", null, null, 16 },
                    { 95, null, "Usher", "CompanyMemberTitle", null, null, 16 },
                    { 96, null, "Height", "ContactSpecTypePerson", null, null, null },
                    { 97, null, "Weight", "ContactSpecTypePerson", null, null, null },
                    { 98, null, "Proscenium Height", "ContactSpecTypeVenue", null, null, null },
                    { 76, null, "Production Manager", "CompanyMemberTitle", null, 18, 18 },
                    { 75, null, "General Manager Intern", "CompanyMemberTitle", null, null, 10 },
                    { 84, null, "Assistant Stage Manager", "CompanyMemberTitle", null, null, 6 },
                    { 73, null, "Associate General Manager", "CompanyMemberTitle", null, null, 10 },
                    { 52, null, "Assistant Costume Designer", "CompanyMemberTitle", null, null, 7 },
                    { 53, null, "Costume Design Intern", "CompanyMemberTitle", null, null, 7 },
                    { 54, null, "Wardrobe", "CompanyMemberTitle", null, 7, 7 },
                    { 55, null, "Dresser", "CompanyMemberTitle", null, null, 7 },
                    { 56, null, "Stitcher", "CompanyMemberTitle", null, null, 7 },
                    { 57, null, "Costume Pattern Maker", "CompanyMemberTitle", null, null, 7 },
                    { 58, null, "Hair Designer", "CompanyMemberTitle", null, null, 8 },
                    { 74, null, "Assistant General Manager", "CompanyMemberTitle", null, null, 10 },
                    { 60, null, "Assistant Hair Designer", "CompanyMemberTitle", null, null, 8 },
                    { 61, null, "Hair Design Intern", "CompanyMemberTitle", null, null, 8 },
                    { 62, null, "Hair", "CompanyMemberTitle", null, 8, 8 },
                    { 63, null, "Make-up Designer", "CompanyMemberTitle", null, 17, 17 },
                    { 59, null, "Associate Hair Designer", "CompanyMemberTitle", null, null, 8 },
                    { 72, null, "General Manager", "CompanyMemberTitle", null, 10, 10 },
                    { 71, null, "Company Manager Intern", "CompanyMemberTitle", null, null, 9 },
                    { 70, null, "Assistant Company Manager", "CompanyMemberTitle", null, null, 9 },
                    { 69, null, "Associate Company Manager", "CompanyMemberTitle", null, null, 9 },
                    { 68, null, "Company Manager", "CompanyMemberTitle", null, 9, 9 },
                    { 64, null, "Associate Make-up Designer", "CompanyMemberTitle", null, null, 17 },
                    { 65, null, "Assistant Make-up Designer", "CompanyMemberTitle", null, null, 17 },
                    { 66, null, "Make-up Design Intern", "CompanyMemberTitle", null, null, 17 },
                    { 67, null, "Make-up", "CompanyMemberTitle", null, null, 17 }
                });

            migrationBuilder.InsertData(
                table: "ShareLevels",
                columns: new[] { "RecId", "CreatedOn", "Deleted", "EditIndex", "Hidden", "LastModifiedById", "LastModifiedOnDt", "RoleId", "ShareLevelName", "SizeAllotment", "SizeFriendlyName", "StudioManagerNetRoleId", "Updated" },
                values: new object[,]
                {
                    { 4, new DateTime(2021, 7, 23, 16, 1, 45, 975, DateTimeKind.Utc).AddTicks(4303), false, 0, false, null, new DateTime(2021, 7, 23, 16, 1, 45, 975, DateTimeKind.Utc).AddTicks(4302), "showsilver", "Checklist, and View", 500L, "500MB", null, true },
                    { 5, new DateTime(2021, 7, 23, 16, 1, 45, 975, DateTimeKind.Utc).AddTicks(4304), false, 0, false, null, new DateTime(2021, 7, 23, 16, 1, 45, 975, DateTimeKind.Utc).AddTicks(4304), "showbronze", "Checklist", 0L, "None", null, true },
                    { 2, new DateTime(2021, 7, 23, 16, 1, 45, 975, DateTimeKind.Utc).AddTicks(4298), false, 0, false, null, new DateTime(2021, 7, 23, 16, 1, 45, 975, DateTimeKind.Utc).AddTicks(4297), "showtitanium", "Checklist, View, Print, and Edit", 1000000L, "1TB", null, true },
                    { 3, new DateTime(2021, 7, 23, 16, 1, 45, 975, DateTimeKind.Utc).AddTicks(4301), false, 0, false, null, new DateTime(2021, 7, 23, 16, 1, 45, 975, DateTimeKind.Utc).AddTicks(4300), "showgold", "Checklist, View, and Print", 1000L, "1Gig", null, true },
                    { 6, new DateTime(2021, 7, 23, 16, 1, 45, 975, DateTimeKind.Utc).AddTicks(4306), false, 0, false, null, new DateTime(2021, 7, 23, 16, 1, 45, 975, DateTimeKind.Utc).AddTicks(4306), "showguest", "No Access", 0L, "None", null, true }
                });

            migrationBuilder.InsertData(
                table: "ShareLevels",
                columns: new[] { "RecId", "CreatedOn", "Deleted", "EditIndex", "Hidden", "LastModifiedById", "LastModifiedOnDt", "RoleId", "ShareLevelName", "SizeAllotment", "SizeFriendlyName", "StudioManagerNetRoleId", "Updated" },
                values: new object[] { 1, new DateTime(2021, 7, 23, 16, 1, 45, 975, DateTimeKind.Utc).AddTicks(2920), false, 0, false, null, new DateTime(2021, 7, 23, 16, 1, 45, 975, DateTimeKind.Utc).AddTicks(2917), "showplatinum", "Full Access", 2000000L, "2TB", null, true });

            migrationBuilder.InsertData(
                table: "Themes",
                columns: new[] { "RecId", "CreatedOn", "Deleted", "EditIndex", "Hidden", "LastModifiedById", "LastModifiedOnDt", "OwnerContactRecId", "ThemeId", "ThemeName", "ThemeShade", "ThemeUrl", "Updated", "isDark" },
                values: new object[,]
                {
                    { 12, new DateTime(2021, 7, 23, 16, 1, 45, 975, DateTimeKind.Utc).AddTicks(9588), false, 0, false, null, new DateTime(2021, 7, 23, 16, 1, 45, 975, DateTimeKind.Utc).AddTicks(9588), 0, null, "Nordic", "Dark", "/themes/Nordic.css", true, true },
                    { 11, new DateTime(2021, 7, 23, 16, 1, 45, 975, DateTimeKind.Utc).AddTicks(9587), false, 0, false, null, new DateTime(2021, 7, 23, 16, 1, 45, 975, DateTimeKind.Utc).AddTicks(9586), 0, null, "Indigo", "Dark", "/themes/Indigo.css", true, true },
                    { 10, new DateTime(2021, 7, 23, 16, 1, 45, 975, DateTimeKind.Utc).AddTicks(9585), false, 0, false, null, new DateTime(2021, 7, 23, 16, 1, 45, 975, DateTimeKind.Utc).AddTicks(9585), 0, null, "High Contrast", "Dark", "/themes/HighContrast.css", true, true },
                    { 9, new DateTime(2021, 7, 23, 16, 1, 45, 975, DateTimeKind.Utc).AddTicks(9583), false, 0, false, null, new DateTime(2021, 7, 23, 16, 1, 45, 975, DateTimeKind.Utc).AddTicks(9583), 0, null, "Vintage", "Dark", "/themes/Vintage.css", true, true },
                    { 8, new DateTime(2021, 7, 23, 16, 1, 45, 975, DateTimeKind.Utc).AddTicks(9582), false, 0, false, null, new DateTime(2021, 7, 23, 16, 1, 45, 975, DateTimeKind.Utc).AddTicks(9581), 0, null, "Turquiose", "Dark", "/themes/Turquiose.css", true, true },
                    { 7, new DateTime(2021, 7, 23, 16, 1, 45, 975, DateTimeKind.Utc).AddTicks(9580), false, 0, false, null, new DateTime(2021, 7, 23, 16, 1, 45, 975, DateTimeKind.Utc).AddTicks(9579), 0, null, "Urban", "Light", "/themes/Urban.css", true, false },
                    { 5, new DateTime(2021, 7, 23, 16, 1, 45, 975, DateTimeKind.Utc).AddTicks(9576), false, 0, false, null, new DateTime(2021, 7, 23, 16, 1, 45, 975, DateTimeKind.Utc).AddTicks(9576), 0, null, "Moonlight", "Dark", "/themes/moonlight.css", true, true },
                    { 4, new DateTime(2021, 7, 23, 16, 1, 45, 975, DateTimeKind.Utc).AddTicks(9574), false, 0, false, null, new DateTime(2021, 7, 23, 16, 1, 45, 975, DateTimeKind.Utc).AddTicks(9574), 0, null, "Default", "Light", "_content/Telerik.UI.for.Blazor/css/kendo-theme-default/all.css", true, false },
                    { 3, new DateTime(2021, 7, 23, 16, 1, 45, 975, DateTimeKind.Utc).AddTicks(9573), false, 0, false, null, new DateTime(2021, 7, 23, 16, 1, 45, 975, DateTimeKind.Utc).AddTicks(9572), 0, null, "Material", "Plain", "_content/Telerik.UI.for.Blazor/css/kendo-theme-material/all.css", true, false },
                    { 2, new DateTime(2021, 7, 23, 16, 1, 45, 975, DateTimeKind.Utc).AddTicks(9570), false, 0, false, null, new DateTime(2021, 7, 23, 16, 1, 45, 975, DateTimeKind.Utc).AddTicks(9569), 0, null, "Flat", "Medium", "/themes/flat.css", true, true },
                    { 1, new DateTime(2021, 7, 23, 16, 1, 45, 975, DateTimeKind.Utc).AddTicks(7875), false, 0, false, null, new DateTime(2021, 7, 23, 16, 1, 45, 975, DateTimeKind.Utc).AddTicks(7873), 0, null, "Metro Black", "Dark", "/themes/metroblack.css", true, true },
                    { 13, new DateTime(2021, 7, 23, 16, 1, 45, 975, DateTimeKind.Utc).AddTicks(9590), false, 0, false, null, new DateTime(2021, 7, 23, 16, 1, 45, 975, DateTimeKind.Utc).AddTicks(9589), 0, null, "Indigo Blue Dark", "Dark", "/themes/IndigoBlueDark.css", true, true },
                    { 6, new DateTime(2021, 7, 23, 16, 1, 45, 975, DateTimeKind.Utc).AddTicks(9578), false, 0, false, null, new DateTime(2021, 7, 23, 16, 1, 45, 975, DateTimeKind.Utc).AddTicks(9577), 0, null, "Bootstrap", "Light", "_content/Telerik.UI.for.Blazor/css/kendo-theme-default/all.css", true, false }
                });

            migrationBuilder.InsertData(
                table: "VersionHistories",
                columns: new[] { "RecId", "CreatedOn", "Deleted", "EditIndex", "Hidden", "IsCurrent", "LastModifiedById", "LastModifiedOnDt", "Updated", "Version" },
                values: new object[] { 1, new DateTime(2021, 7, 23, 16, 1, 45, 970, DateTimeKind.Utc).AddTicks(7412), false, 0, false, true, null, new DateTime(2021, 7, 23, 16, 1, 45, 970, DateTimeKind.Utc).AddTicks(7405), true, "1.040" });

            migrationBuilder.InsertData(
                table: "AspNetRoleClaims",
                columns: new[] { "Id", "ClaimType", "ClaimValue", "Discriminator", "RoleId" },
                values: new object[,]
                {
                    { 1, "Demo", "Demo", "StudioManagerNetRoleClaim", "guest" },
                    { 31, "Editing", "Editing", "StudioManagerNetRoleClaim", "administrator" },
                    { 30, "Printing", "Printing", "StudioManagerNetRoleClaim", "administrator" },
                    { 29, "Viewing", "Viewing", "StudioManagerNetRoleClaim", "administrator" },
                    { 28, "Checklist", "Checklist", "StudioManagerNetRoleClaim", "administrator" },
                    { 27, "Demo", "Demo", "StudioManagerNetRoleClaim", "administrator" },
                    { 26, "Editing", "Editing", "StudioManagerNetRoleClaim", "showtitanium" },
                    { 25, "Printing", "Printing", "StudioManagerNetRoleClaim", "showtitanium" },
                    { 24, "Viewing", "Viewing", "StudioManagerNetRoleClaim", "showtitanium" },
                    { 23, "Checklist", "Checklist", "StudioManagerNetRoleClaim", "showtitanium" },
                    { 22, "Demo", "Demo", "StudioManagerNetRoleClaim", "showtitanium" },
                    { 21, "Creating", "Creating", "StudioManagerNetRoleClaim", "showplatinum" },
                    { 20, "Editing", "Editing", "StudioManagerNetRoleClaim", "showplatinum" },
                    { 19, "Printing", "Printing", "StudioManagerNetRoleClaim", "showplatinum" },
                    { 18, "Viewing", "Viewing", "StudioManagerNetRoleClaim", "showplatinum" },
                    { 32, "Creating", "Creating", "StudioManagerNetRoleClaim", "administrator" },
                    { 17, "Checklist", "Checklist", "StudioManagerNetRoleClaim", "showplatinum" },
                    { 9, "Creating", "Creating", "StudioManagerNetRoleClaim", "showgold" },
                    { 8, "Editing", "Editing", "StudioManagerNetRoleClaim", "showgold" },
                    { 7, "Printing", "Printing", "StudioManagerNetRoleClaim", "showgold" },
                    { 6, "Viewing", "Viewing", "StudioManagerNetRoleClaim", "showgold" },
                    { 5, "Checklist", "Checklist", "StudioManagerNetRoleClaim", "showgold" },
                    { 4, "Demo", "Demo", "StudioManagerNetRoleClaim", "showgold" },
                    { 15, "Creating", "Creating", "StudioManagerNetRoleClaim", "showsilver" },
                    { 14, "Editing", "Editing", "StudioManagerNetRoleClaim", "showsilver" },
                    { 13, "Printing", "Printing", "StudioManagerNetRoleClaim", "showsilver" },
                    { 12, "Viewing", "Viewing", "StudioManagerNetRoleClaim", "showsilver" },
                    { 11, "Checklist", "Checklist", "StudioManagerNetRoleClaim", "showsilver" },
                    { 10, "Demo", "Demo", "StudioManagerNetRoleClaim", "showsilver" },
                    { 3, "Checklist", "Checklist", "StudioManagerNetRoleClaim", "showbronze" },
                    { 2, "Demo", "Demo", "StudioManagerNetRoleClaim", "showbronze" },
                    { 16, "Demo", "Demo", "StudioManagerNetRoleClaim", "showplatinum" },
                    { 33, "Admin", "Admin", "StudioManagerNetRoleClaim", "administrator" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_DisciplineId",
                table: "AspNetUsers",
                column: "DisciplineId");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_DisciplineColors_StudioManagerUserId",
                table: "DisciplineColors",
                column: "StudioManagerUserId");

            migrationBuilder.CreateIndex(
                name: "IX_NotificationMessages_StudioManagerUserId",
                table: "NotificationMessages",
                column: "StudioManagerUserId");

            migrationBuilder.CreateIndex(
                name: "IX_SharedProductions_OwnerUserId",
                table: "SharedProductions",
                column: "OwnerUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ShareLevels_StudioManagerNetRoleId",
                table: "ShareLevels",
                column: "StudioManagerNetRoleId");

            migrationBuilder.CreateIndex(
                name: "IX_ShareLinkFiles_LinkId",
                table: "ShareLinkFiles",
                column: "LinkId");

            migrationBuilder.CreateIndex(
                name: "IX_ShareLinks_StudioManagerUserId",
                table: "ShareLinks",
                column: "StudioManagerUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ShareMessageReplies_LinkId",
                table: "ShareMessageReplies",
                column: "LinkId");

            migrationBuilder.CreateIndex(
                name: "IX_ShareMessages_LinkId",
                table: "ShareMessages",
                column: "LinkId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "ColorNames");

            migrationBuilder.DropTable(
                name: "DefaultAppointmentTypes");

            migrationBuilder.DropTable(
                name: "DisciplineColorDefaults");

            migrationBuilder.DropTable(
                name: "DisciplineColors");

            migrationBuilder.DropTable(
                name: "DisciplineMerges");

            migrationBuilder.DropTable(
                name: "DropDownOptionDefaults");

            migrationBuilder.DropTable(
                name: "GridSaves");

            migrationBuilder.DropTable(
                name: "Messages");

            migrationBuilder.DropTable(
                name: "NotificationMessages");

            migrationBuilder.DropTable(
                name: "PageHelpers");

            migrationBuilder.DropTable(
                name: "PromoCodes");

            migrationBuilder.DropTable(
                name: "PromoCodesUsed");

            migrationBuilder.DropTable(
                name: "Purchases");

            migrationBuilder.DropTable(
                name: "ReportDefinitions");

            migrationBuilder.DropTable(
                name: "ScheduleResources");

            migrationBuilder.DropTable(
                name: "ShareLevels");

            migrationBuilder.DropTable(
                name: "ShareLinkFiles");

            migrationBuilder.DropTable(
                name: "ShareMessageReplies");

            migrationBuilder.DropTable(
                name: "Themes");

            migrationBuilder.DropTable(
                name: "VersionHistories");

            migrationBuilder.DropTable(
                name: "ZipCodes");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "ShareLinks");

            migrationBuilder.DropTable(
                name: "ShareMessages");

            migrationBuilder.DropTable(
                name: "SharedProductions");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Disciplines");
        }
    }
}
