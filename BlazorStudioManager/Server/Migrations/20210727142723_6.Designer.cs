// <auto-generated />
using System;
using BlazorStudioManager.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BlazorStudioManager.Server.Migrations
{
    [DbContext(typeof(StudioManagerUserContext))]
    [Migration("20210727142723_6")]
    partial class _6
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.8")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BlazorStudioManager.Shared.Catalog", b =>
                {
                    b.Property<int>("RecId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CatalogName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RecId");

                    b.ToTable("Catalogs");

                    b.HasData(
                        new
                        {
                            RecId = 1,
                            CatalogName = "Performance"
                        },
                        new
                        {
                            RecId = 2,
                            CatalogName = "Sound"
                        },
                        new
                        {
                            RecId = 3,
                            CatalogName = "Lights"
                        });
                });

            modelBuilder.Entity("BlazorStudioManager.Shared.Models.DropDownOption", b =>
                {
                    b.Property<int>("RecId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Abbreviation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Color")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedByUserId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("DdoAbrv")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DdoNote")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DdoTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("DdoType")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("DdoUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("DefaultCompanyMemberDepartmentId")
                        .HasColumnType("int");

                    b.Property<int?>("DefaultDisciplineId")
                        .HasColumnType("int");

                    b.Property<int?>("DefaultProductionDisciplineId")
                        .HasColumnType("int");

                    b.Property<int?>("DefaultRecId")
                        .HasColumnType("int");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("DisciplineId")
                        .HasColumnType("int");

                    b.Property<int>("EditIndex")
                        .HasColumnType("int");

                    b.Property<int>("FromRecId")
                        .HasColumnType("int");

                    b.Property<string>("FromUserId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Hidden")
                        .HasColumnType("bit");

                    b.Property<int>("IndexNumber")
                        .HasColumnType("int");

                    b.Property<string>("LastModifiedById")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LastModifiedOnDt")
                        .HasColumnType("datetime2");

                    b.Property<int>("LinkId")
                        .HasColumnType("int");

                    b.Property<bool?>("Locked")
                        .HasColumnType("bit");

                    b.Property<string>("MeasurementType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("OwnerContactRecId")
                        .HasColumnType("int");

                    b.Property<string>("ProductionConnectionString")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ProductionId")
                        .HasColumnType("int");

                    b.Property<string>("ProductionOwnerUserId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Rank")
                        .HasColumnType("int");

                    b.Property<string>("Reason")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ShareLevelId")
                        .HasColumnType("int");

                    b.Property<string>("ShortName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SubType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Updated")
                        .HasColumnType("bit");

                    b.HasKey("RecId");

                    b.HasIndex("DdoType", "DdoTitle")
                        .IsUnique();

                    b.ToTable("DropDownOptions");
                });
#pragma warning restore 612, 618
        }
    }
}
