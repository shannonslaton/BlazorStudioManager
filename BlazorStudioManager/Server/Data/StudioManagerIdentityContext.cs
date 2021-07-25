using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using BlazorStudioManager.Shared.IdentityModels;
using BlazorStudioManager.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorStudioManager.Server.Data
{
    public partial class StudioManagerIdentityContext : IdentityDbContext<
    StudioManagerUser, // TUser
    StudioManagerNetRole, // TRole
    string, // TKey
    IdentityUserClaim<string>, // TUserClaim
    StudioManagerUserRole, // TUserRole,
    IdentityUserLogin<string>, // TUserLogin
    IdentityRoleClaim<string>, // TRoleClaim
    IdentityUserToken<string> // TUserToken
>
    {
        public StudioManagerIdentityContext(DbContextOptions<StudioManagerIdentityContext> options) : base(options)
        {
        }

        public virtual DbSet<Discipline> Disciplines { get; set; }
        public virtual DbSet<DefaultAppointmentType> DefaultAppointmentTypes { get; set; }
        public virtual DbSet<DropDownOptionDefault> DropDownOptionDefaults { get; set; }
        public virtual DbSet<GridSave> GridSaves { get; set; }
        public virtual DbSet<Message> Messages { get; set; }
        public virtual DbSet<PageHelper> PageHelpers { get; set; }
        public virtual DbSet<PromoCode> PromoCodes { get; set; }
        public virtual DbSet<PromoCodesUsed> PromoCodesUsed { get; set; }
        public virtual DbSet<Purchase> Purchases { get; set; }
        public virtual DbSet<ShareLevel> ShareLevels { get; set; }
        public virtual DbSet<StudioManagerUserRole> StudioManagerUserRole { get; set; }
        public virtual DbSet<StudioManagerNetRole> StudioManagerNetRole { get; set; }
        public virtual DbSet<StudioManagerUser> StudioManagerUser { get; set; }
        public virtual DbSet<SharedProduction> SharedProductions { get; set; }
        public virtual DbSet<ShareMessage> ShareMessages { get; set; }
        public virtual DbSet<ShareMessageReply> ShareMessageReplies { get; set; }
        public virtual DbSet<StudioManagerNetRoleClaim> StudioManagerNetRoleClaim { get; set; }
        public virtual DbSet<ZipCode> ZipCodes { get; set; }
        public virtual DbSet<DisciplineColor> DisciplineColors { get; set; }
        public virtual DbSet<DisciplineColorDefault> DisciplineColorDefaults { get; set; }
        public virtual DbSet<NotificationMessage> NotificationMessages { get; set; }
        public virtual DbSet<ShareLink> ShareLinks { get; set; }
        public virtual DbSet<ShareLinkFile> ShareLinkFiles { get; set; }
        public virtual DbSet<Theme> Themes { get; set; }
        public virtual DbSet<VersionHistory> VersionHistories { get; set; }
        public virtual DbSet<DisciplineMerge> DisciplineMerges { get; set; }
        public virtual DbSet<ReportDefinition> ReportDefinitions { get; set; }
        public virtual DbSet<ColorName> ColorNames { get; set; }
        public virtual DbSet<ScheduleResource> ScheduleResources { get; set; }
        public virtual DbSet<ReportTemplate> ReportTemplates { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<StudioManagerNetRole>(entity =>
            {
                entity.Property(e => e.YearlyCost).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<StudioManagerNetRole>().HasData(
                new StudioManagerNetRole() { 
                    Id = "guest", 
                    YearlyCost = 0, 
                    ShowRole = false, 
                    Name = "Guest", 
                    NormalizedName = "GUEST", 
                    SubscriptionDescription = "No Rights", 
                    PublicRole = false, 
                    ShowRoleId = "showguest",
                    Feature1 = "View shared productions",
                    Feature2 = "Unlimited collaborators",
                    Feature3 = "Online Scheduling",
                    Feature4 = "Customizable Reports",
                    Feature5 = "Online Cast Check-in",
                    Feature6 = "No Online Storage",
                    Feature7 = " per year"
                },
                new StudioManagerNetRole() { 
                    Id = "bronze", 
                    YearlyCost = 0, 
                    ShowRole = false, 
                    Name = "Bronze", 
                    NormalizedName = "BRONZE", 
                    SubscriptionDescription = "Viewing and Check List Only", 
                    PublicRole = true, 
                    ShowRoleId = "showbronze",
                    Feature1 = "View shared productions",
                    Feature2 = "Mark Check List information",
                    Feature3 = "Online Scheduling",
                    Feature4 = "Online performance reports",
                    Feature5 = "Online Cast Check-in",
                    Feature6 = "No Online Storage",
                    Feature7 = " per year"
                },
                new StudioManagerNetRole() {
                    Id = "gold",
                    YearlyCost = 200,
                    ShowRole = false,
                    Name = "Gold",
                    NormalizedName = "GOLD",
                    SubscriptionDescription = "Full Rights and 1GB of storage",
                    PublicRole = true,
                    ShowRoleId = "showgold",
                    Feature1 = "Unlimited productions",
                    Feature2 = "Unlimited collaborators",
                    Feature3 = "Online Scheduling",
                    Feature4 = "Customizable Reports",
                    Feature5 = "Online Cast Check-in",
                    Feature6 = "1 Terabyte Online Storage",
                    Feature7 = " per year"
                },
                new StudioManagerNetRole() {
                    Id = "silver",
                    YearlyCost = 100,
                    ShowRole = false,
                    Name = "Silver",
                    NormalizedName = "SILVER",
                    SubscriptionDescription = "Full Rights and 500MB of storage",
                    PublicRole = true,
                    ShowRoleId = "showsilver",
                    Feature1 = "Unlimited productions",
                    Feature2 = "Unlimited collaborators",
                    Feature3 = "Online Scheduling",
                    Feature4 = "Customizable Reports",
                    Feature5 = "Online Cast Check-in",
                    Feature6 = "1 Gigabyte Online Storage",
                    Feature7 = " per year"
                },
                new StudioManagerNetRole() {
                    Id = "platinum",
                    YearlyCost = 400,
                    ShowRole = false,
                    Name = "Platinum",
                    NormalizedName = "PLATINUM",
                    SubscriptionDescription = "Full Rights and 2TB of storage",
                    PublicRole = true,
                    ShowRoleId = "showplatinum",
                    Feature1 = "Unlimited productions",
                    Feature2 = "Unlimited collaborators",
                    Feature3 = "Online Scheduling",
                    Feature4 = "Customizable Reports",
                    Feature5 = "Online Cast Check-in",
                    Feature6 = "5 Terabytes Online Storage",
                    Feature7 = " per year"
                },
                new StudioManagerNetRole() {
                    Id = "titanium",
                    YearlyCost = 300,
                    ShowRole = false,
                    Name = "Titanium",
                    NormalizedName = "TITANIUM",
                    SubscriptionDescription = "Full Rights and 1TB of storage",
                    PublicRole = true,
                    ShowRoleId = "showtitanium",
                    Feature1 = "Unlimited productions",
                    Feature2 = "Unlimited collaborators",
                    Feature3 = "Online Scheduling",
                    Feature4 = "Customizable Reports",
                    Feature5 = "Online Cast Check-in",
                    Feature6 = "2 Terabytes Online Storage",
                    Feature7 = " per year"
                },
                new StudioManagerNetRole() {
                    Id = "showguest",
                    YearlyCost = 0,
                    ShowRole = true,
                    Name = "ShowGuest",
                    NormalizedName = "SHOWGUEST",
                    SubscriptionDescription = "",
                    PublicRole = false
                },
                new StudioManagerNetRole() {
                    Id = "showbronze",
                    YearlyCost = 0,
                    ShowRole = true,
                    Name = "ShowBronze",
                    NormalizedName = "SHOWBRONZE",
                    SubscriptionDescription = "",
                    PublicRole = false
                },
                new StudioManagerNetRole() {
                    Id = "showsilver",
                    YearlyCost = 0,
                    ShowRole = true,
                    Name = "ShowSilver",
                    NormalizedName = "SHOWSILVER",
                    SubscriptionDescription = "",
                    PublicRole = false
                },
                new StudioManagerNetRole() {
                    Id = "showgold",
                    YearlyCost = 0,
                    ShowRole = true,
                    Name = "ShowGold",
                    NormalizedName = "SHOWGOLD",
                    SubscriptionDescription = "",
                    PublicRole = false
                },
                new StudioManagerNetRole() {
                    Id = "showplatinum",
                    YearlyCost = 0,
                    ShowRole = true,
                    Name = "ShowPlatinum",
                    NormalizedName = "SHOWPLATINUM",
                    SubscriptionDescription = "",
                    PublicRole = false
                },
                new StudioManagerNetRole() {
                    Id = "showtitanium",
                    YearlyCost = 0,
                    ShowRole = true,
                    Name = "ShowTitanium",
                    NormalizedName = "SHOWTITANIUM",
                    SubscriptionDescription = "",
                    PublicRole = false
                },
                new StudioManagerNetRole() {
                    Id = "administrator",
                    YearlyCost = 0,
                    ShowRole = false,
                    Name = "Administrator",
                    NormalizedName = "ADMINISTRATOR",
                    SubscriptionDescription = "Greetings Professor Falken",
                    PublicRole = false,
                    ShowRoleId = "showplatinum"
                }
            );

            modelBuilder.Entity<StudioManagerUserRole>(entity =>
            {
                entity.Property(e => e.RecId).ValueGeneratedOnAdd();

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.StudioManagerUserRoles)
                    .HasForeignKey(d => d.RoleId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.StudioManagerUserRoles)
                    .HasForeignKey(d => d.UserId);

            });

            modelBuilder.Entity<SharedProduction>(entity =>
            {
                entity.HasKey(e => e.RecId);
            });

            modelBuilder.Entity<StudioManagerNetRoleClaim>(entity =>
            {

            });

            modelBuilder.Entity<StudioManagerNetRoleClaim>().HasData(
                new StudioManagerNetRoleClaim() { Id = 1, RoleId = "guest", ClaimType = "Demo", ClaimValue = "Demo" },
                new StudioManagerNetRoleClaim() { Id = 2, RoleId = "showbronze", ClaimType = "Demo", ClaimValue = "Demo" },
                new StudioManagerNetRoleClaim() { Id = 3, RoleId = "showbronze", ClaimType = "Checklist", ClaimValue = "Checklist" },
                new StudioManagerNetRoleClaim() { Id = 4, RoleId = "showgold", ClaimType = "Demo", ClaimValue = "Demo" },
                new StudioManagerNetRoleClaim() { Id = 5, RoleId = "showgold", ClaimType = "Checklist", ClaimValue = "Checklist" },
                new StudioManagerNetRoleClaim() { Id = 6, RoleId = "showgold", ClaimType = "Viewing", ClaimValue = "Viewing" },
                new StudioManagerNetRoleClaim() { Id = 7, RoleId = "showgold", ClaimType = "Printing", ClaimValue = "Printing" },
                new StudioManagerNetRoleClaim() { Id = 8, RoleId = "showgold", ClaimType = "Editing", ClaimValue = "Editing" },
                new StudioManagerNetRoleClaim() { Id = 9, RoleId = "showgold", ClaimType = "Creating", ClaimValue = "Creating" },
                new StudioManagerNetRoleClaim() { Id = 10, RoleId = "showsilver", ClaimType = "Demo", ClaimValue = "Demo" },
                new StudioManagerNetRoleClaim() { Id = 11, RoleId = "showsilver", ClaimType = "Checklist", ClaimValue = "Checklist" },
                new StudioManagerNetRoleClaim() { Id = 12, RoleId = "showsilver", ClaimType = "Viewing", ClaimValue = "Viewing" },
                new StudioManagerNetRoleClaim() { Id = 13, RoleId = "showsilver", ClaimType = "Printing", ClaimValue = "Printing" },
                new StudioManagerNetRoleClaim() { Id = 14, RoleId = "showsilver", ClaimType = "Editing", ClaimValue = "Editing" },
                new StudioManagerNetRoleClaim() { Id = 15, RoleId = "showsilver", ClaimType = "Creating", ClaimValue = "Creating" },
                new StudioManagerNetRoleClaim() { Id = 16, RoleId = "showplatinum", ClaimType = "Demo", ClaimValue = "Demo" },
                new StudioManagerNetRoleClaim() { Id = 17, RoleId = "showplatinum", ClaimType = "Checklist", ClaimValue = "Checklist" },
                new StudioManagerNetRoleClaim() { Id = 18, RoleId = "showplatinum", ClaimType = "Viewing", ClaimValue = "Viewing" },
                new StudioManagerNetRoleClaim() { Id = 19, RoleId = "showplatinum", ClaimType = "Printing", ClaimValue = "Printing" },
                new StudioManagerNetRoleClaim() { Id = 20, RoleId = "showplatinum", ClaimType = "Editing", ClaimValue = "Editing" },
                new StudioManagerNetRoleClaim() { Id = 21, RoleId = "showplatinum", ClaimType = "Creating", ClaimValue = "Creating" },
                new StudioManagerNetRoleClaim() { Id = 22, RoleId = "showtitanium", ClaimType = "Demo", ClaimValue = "Demo" },
                new StudioManagerNetRoleClaim() { Id = 23, RoleId = "showtitanium", ClaimType = "Checklist", ClaimValue = "Checklist" },
                new StudioManagerNetRoleClaim() { Id = 24, RoleId = "showtitanium", ClaimType = "Viewing", ClaimValue = "Viewing" },
                new StudioManagerNetRoleClaim() { Id = 25, RoleId = "showtitanium", ClaimType = "Printing", ClaimValue = "Printing" },
                new StudioManagerNetRoleClaim() { Id = 26, RoleId = "showtitanium", ClaimType = "Editing", ClaimValue = "Editing" },
                new StudioManagerNetRoleClaim() { Id = 27, RoleId = "administrator", ClaimType = "Demo", ClaimValue = "Demo" },
                new StudioManagerNetRoleClaim() { Id = 28, RoleId = "administrator", ClaimType = "Checklist", ClaimValue = "Checklist" },
                new StudioManagerNetRoleClaim() { Id = 29, RoleId = "administrator", ClaimType = "Viewing", ClaimValue = "Viewing" },
                new StudioManagerNetRoleClaim() { Id = 30, RoleId = "administrator", ClaimType = "Printing", ClaimValue = "Printing" },
                new StudioManagerNetRoleClaim() { Id = 31, RoleId = "administrator", ClaimType = "Editing", ClaimValue = "Editing" },
                new StudioManagerNetRoleClaim() { Id = 32, RoleId = "administrator", ClaimType = "Creating", ClaimValue = "Creating" },
                new StudioManagerNetRoleClaim() { Id = 33, RoleId = "administrator", ClaimType = "Admin", ClaimValue = "Admin" }
            );

            modelBuilder.Entity<StudioManagerUser>(entity =>
            {
                entity.HasOne(d => d.Discipline)
                    .WithMany(p => p.StudioManagerUsers)
                    .HasForeignKey(d => d.DisciplineId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Discipline_StudioManagerUsers");
            });

            modelBuilder.Entity<PageHelper>(entity =>
            {
                entity.HasKey(e => e.RecId);

            });

            modelBuilder.Entity<ZipCode>(entity =>
            {
                entity.HasKey(e => e.RecId);

            });
            modelBuilder.Entity<ColorName>(entity =>
            {
                entity.HasKey(e => e.RecId);

            });
            modelBuilder.Entity<ScheduleResource>(entity =>
            {
                entity.HasKey(e => e.RecId);

            });
            modelBuilder.Entity<VersionHistory>(entity =>
            {
                entity.HasKey(e => e.RecId);

            });
            modelBuilder.Entity<ReportDefinition>(entity =>
            {
                entity.HasKey(e => e.RecId);

            });
            modelBuilder.Entity<VersionHistory>().HasData(
                new VersionHistory() { RecId = 1, IsCurrent = true, Version = "1.040" }
            );
            modelBuilder.Entity<GridSave>(entity =>
            {
                entity.HasKey(e => e.RecId);

            });

            modelBuilder.Entity<DisciplineMerge>(entity =>
            {
                entity.HasKey(e => e.RecId);
            });

            modelBuilder.Entity<ReportTemplate>(entity =>
            {
                entity.HasKey(e => e.RecId);
            });

            modelBuilder.Entity<DefaultAppointmentType>(entity =>
            {
                entity.HasKey(e => e.RecId);
            });

            modelBuilder.Entity<DefaultAppointmentType>().HasData(
                new DefaultAppointmentType() { RecId = 1, AppointmentTypeName = "Performance", ColorString = "CornflowerBlue" },
                new DefaultAppointmentType() { RecId = 2, AppointmentTypeName = "Rehearsal", ColorString = "Coral" },
                new DefaultAppointmentType() { RecId = 3, AppointmentTypeName = "Press", ColorString = "CadetBlue" },
                new DefaultAppointmentType() { RecId = 4, AppointmentTypeName = "Audition", ColorString = "DarkOrange" },
                new DefaultAppointmentType() { RecId = 5, AppointmentTypeName = "Callback", ColorString = "DeepSkyBlue" },
                new DefaultAppointmentType() { RecId = 6, AppointmentTypeName = "Travel", ColorString = "BurlyWood" },
                new DefaultAppointmentType() { RecId = 7, AppointmentTypeName = "Housing", ColorString = "AntiqueWhite" },
                new DefaultAppointmentType() { RecId = 8, AppointmentTypeName = "Meeting", ColorString = "MediumTurquoise" },
                new DefaultAppointmentType() { RecId = 9, AppointmentTypeName = "Coverage", ColorString = "MediumSeaGreen" },
                new DefaultAppointmentType() { RecId = 10, AppointmentTypeName = "Costume Fitting", ColorString = "OrangeRed" },
                new DefaultAppointmentType() { RecId = 11, AppointmentTypeName = "Haircut", ColorString = "OrangeRed" }
            );

            modelBuilder.Entity<DropDownOptionDefault>(entity =>
            {
                entity.HasKey(e => e.RecId);
            });

            modelBuilder.Entity<DropDownOptionDefault>().HasData(
                new DropDownOptionDefault() { RecId = 1, DdoType = "ActorType", DdoTitle = "Lead" },
                new DropDownOptionDefault() { RecId = 2, DdoType = "ActorType", DdoTitle = "Ensemble" },
                new DropDownOptionDefault() { RecId = 3, DdoType = "BudgetLineItemType", DdoTitle = "Investment" },
                new DropDownOptionDefault() { RecId = 4, DdoType = "BudgetLineItemType", DdoTitle = "Invoice" },
                new DropDownOptionDefault() { RecId = 5, DdoType = "BudgetLineItemType", DdoTitle = "Pay" },
                new DropDownOptionDefault() { RecId = 6, DdoType = "CompanyMemberDepartment", DdoTitle = "Cast" },
                new DropDownOptionDefault() { RecId = 7, DdoType = "CompanyMemberDepartment", DdoTitle = "Creatives" },
                new DropDownOptionDefault() { RecId = 8, DdoType = "CompanyMemberDepartment", DdoTitle = "Musicians" },
                new DropDownOptionDefault() { RecId = 9, DdoType = "CompanyMemberDepartment", DdoTitle = "Crew" },
                new DropDownOptionDefault() { RecId = 10, DdoType = "CompanyMemberDepartment", DdoTitle = "Management" },
                new DropDownOptionDefault() { RecId = 11, DdoType = "CompanyMemberTitle", DdoTitle = "Lighting Designer", DefaultDisciplineId = 3, DefaultProductionDisciplineId = 3 },
                new DropDownOptionDefault() { RecId = 12, DdoType = "CompanyMemberTitle", DdoTitle = "Associate Lighting Designer", DefaultProductionDisciplineId = 3 },
                new DropDownOptionDefault() { RecId = 13, DdoType = "CompanyMemberTitle", DdoTitle = "Assistant Lighting Designer", DefaultProductionDisciplineId = 3 },
                new DropDownOptionDefault() { RecId = 14, DdoType = "CompanyMemberTitle", DdoTitle = "Moving Light Programmer", DefaultProductionDisciplineId = 3 },
                new DropDownOptionDefault() { RecId = 15, DdoType = "CompanyMemberTitle", DdoTitle = "Light Board Operator", DefaultProductionDisciplineId = 3 },
                new DropDownOptionDefault() { RecId = 16, DdoType = "CompanyMemberTitle", DdoTitle = "Deck Electrician", DefaultProductionDisciplineId = 3 },
                new DropDownOptionDefault() { RecId = 17, DdoType = "CompanyMemberTitle", DdoTitle = "Spot Operator", DefaultProductionDisciplineId = 3 },
                new DropDownOptionDefault() { RecId = 18, DdoType = "CompanyMemberTitle", DdoTitle = "Lighting Intern", DefaultProductionDisciplineId = 3 },
                new DropDownOptionDefault() { RecId = 19, DdoType = "CompanyMemberTitle", DdoTitle = "Production Lighting", DefaultProductionDisciplineId = 3 },
                new DropDownOptionDefault() { RecId = 20, DdoType = "CompanyMemberTitle", DdoTitle = "Sound Designer", DefaultDisciplineId = 2, DefaultProductionDisciplineId = 2 },
                new DropDownOptionDefault() { RecId = 21, DdoType = "CompanyMemberTitle", DdoTitle = "Associate Sound Designer", DefaultProductionDisciplineId = 2 },
                new DropDownOptionDefault() { RecId = 22, DdoType = "CompanyMemberTitle", DdoTitle = "Assistant Sound Designer", DefaultProductionDisciplineId = 2 },
                new DropDownOptionDefault() { RecId = 23, DdoType = "CompanyMemberTitle", DdoTitle = "Qlab Programmer", DefaultProductionDisciplineId = 2 },
                new DropDownOptionDefault() { RecId = 24, DdoType = "CompanyMemberTitle", DdoTitle = "Sound Intern", DefaultProductionDisciplineId = 2 },
                new DropDownOptionDefault() { RecId = 25, DdoType = "CompanyMemberTitle", DdoTitle = "Sound Board Operator", DefaultProductionDisciplineId = 2 },
                new DropDownOptionDefault() { RecId = 26, DdoType = "CompanyMemberTitle", DdoTitle = "Deck Sound", DefaultProductionDisciplineId = 2 },
                new DropDownOptionDefault() { RecId = 27, DdoType = "CompanyMemberTitle", DdoTitle = "RF Tech", DefaultProductionDisciplineId = 2 },
                new DropDownOptionDefault() { RecId = 28, DdoType = "CompanyMemberTitle", DdoTitle = "Production Sound", DefaultProductionDisciplineId = 2 },
                new DropDownOptionDefault() { RecId = 29, DdoType = "CompanyMemberTitle", DdoTitle = "Scenic Designer", DefaultDisciplineId = 14, DefaultProductionDisciplineId = 14 },
                new DropDownOptionDefault() { RecId = 30, DdoType = "CompanyMemberTitle", DdoTitle = "Associate Scenic Designer", DefaultProductionDisciplineId = 14 },
                new DropDownOptionDefault() { RecId = 31, DdoType = "CompanyMemberTitle", DdoTitle = "Assistant Scenic Designer", DefaultProductionDisciplineId = 14 },
                new DropDownOptionDefault() { RecId = 32, DdoType = "CompanyMemberTitle", DdoTitle = "Scenic Intern", DefaultProductionDisciplineId = 14 },
                new DropDownOptionDefault() { RecId = 33, DdoType = "CompanyMemberTitle", DdoTitle = "Scenic Draftsman", DefaultProductionDisciplineId = 14 },
                new DropDownOptionDefault() { RecId = 34, DdoType = "CompanyMemberTitle", DdoTitle = "Head Electrician", DefaultProductionDisciplineId = 3 },
                new DropDownOptionDefault() { RecId = 35, DdoType = "CompanyMemberTitle", DdoTitle = "Head Sound", DefaultProductionDisciplineId = 2 },
                new DropDownOptionDefault() { RecId = 36, DdoType = "CompanyMemberTitle", DdoTitle = "Head Carpenter", DefaultDisciplineId = 14 },
                new DropDownOptionDefault() { RecId = 37, DdoType = "CompanyMemberTitle", DdoTitle = "Head Props", DefaultProductionDisciplineId = 4 },
                new DropDownOptionDefault() { RecId = 38, DdoType = "CompanyMemberTitle", DdoTitle = "Head Wardrobe", DefaultProductionDisciplineId = 7 },
                new DropDownOptionDefault() { RecId = 39, DdoType = "CompanyMemberTitle", DdoTitle = "Head Hair", DefaultProductionDisciplineId = 8 },
                new DropDownOptionDefault() { RecId = 40, DdoType = "CompanyMemberTitle", DdoTitle = "Carpenter", DefaultProductionDisciplineId = 14 },
                new DropDownOptionDefault() { RecId = 41, DdoType = "CompanyMemberTitle", DdoTitle = "Deck Carpenter", DefaultProductionDisciplineId = 14 },
                new DropDownOptionDefault() { RecId = 42, DdoType = "CompanyMemberTitle", DdoTitle = "Flyman", DefaultProductionDisciplineId = 14 },
                new DropDownOptionDefault() { RecId = 43, DdoType = "CompanyMemberTitle", DdoTitle = "Automation Operator", DefaultProductionDisciplineId = 14 },
                new DropDownOptionDefault() { RecId = 44, DdoType = "CompanyMemberTitle", DdoTitle = "Automation", DefaultProductionDisciplineId = 14 },
                new DropDownOptionDefault() { RecId = 45, DdoType = "CompanyMemberTitle", DdoTitle = "Prop Designer", DefaultDisciplineId = 4, DefaultProductionDisciplineId = 4 },
                new DropDownOptionDefault() { RecId = 46, DdoType = "CompanyMemberTitle", DdoTitle = "Associate Prop Designer", DefaultProductionDisciplineId = 4 },
                new DropDownOptionDefault() { RecId = 47, DdoType = "CompanyMemberTitle", DdoTitle = "Assistant Prop Designer", DefaultProductionDisciplineId = 4 },
                new DropDownOptionDefault() { RecId = 48, DdoType = "CompanyMemberTitle", DdoTitle = "Prop Design Intern", DefaultProductionDisciplineId = 4 },
                new DropDownOptionDefault() { RecId = 49, DdoType = "CompanyMemberTitle", DdoTitle = "Props", DefaultProductionDisciplineId = 4 },
                new DropDownOptionDefault() { RecId = 50, DdoType = "CompanyMemberTitle", DdoTitle = "Costume Designer", DefaultProductionDisciplineId = 7 },
                new DropDownOptionDefault() { RecId = 51, DdoType = "CompanyMemberTitle", DdoTitle = "Associate Costume Designer", DefaultProductionDisciplineId = 7 },
                new DropDownOptionDefault() { RecId = 52, DdoType = "CompanyMemberTitle", DdoTitle = "Assistant Costume Designer", DefaultProductionDisciplineId = 7 },
                new DropDownOptionDefault() { RecId = 53, DdoType = "CompanyMemberTitle", DdoTitle = "Costume Design Intern", DefaultProductionDisciplineId = 7 },
                new DropDownOptionDefault() { RecId = 54, DdoType = "CompanyMemberTitle", DdoTitle = "Wardrobe", DefaultDisciplineId = 7, DefaultProductionDisciplineId = 7 },
                new DropDownOptionDefault() { RecId = 55, DdoType = "CompanyMemberTitle", DdoTitle = "Dresser", DefaultProductionDisciplineId = 7 },
                new DropDownOptionDefault() { RecId = 56, DdoType = "CompanyMemberTitle", DdoTitle = "Stitcher", DefaultProductionDisciplineId = 7 },
                new DropDownOptionDefault() { RecId = 57, DdoType = "CompanyMemberTitle", DdoTitle = "Costume Pattern Maker", DefaultProductionDisciplineId = 7 },
                new DropDownOptionDefault() { RecId = 58, DdoType = "CompanyMemberTitle", DdoTitle = "Hair Designer", DefaultProductionDisciplineId = 8 },
                new DropDownOptionDefault() { RecId = 59, DdoType = "CompanyMemberTitle", DdoTitle = "Associate Hair Designer", DefaultProductionDisciplineId = 8 },
                new DropDownOptionDefault() { RecId = 60, DdoType = "CompanyMemberTitle", DdoTitle = "Assistant Hair Designer", DefaultProductionDisciplineId = 8 },
                new DropDownOptionDefault() { RecId = 61, DdoType = "CompanyMemberTitle", DdoTitle = "Hair Design Intern", DefaultProductionDisciplineId = 8 },
                new DropDownOptionDefault() { RecId = 62, DdoType = "CompanyMemberTitle", DdoTitle = "Hair", DefaultDisciplineId = 8, DefaultProductionDisciplineId = 8 },
                new DropDownOptionDefault() { RecId = 63, DdoType = "CompanyMemberTitle", DdoTitle = "Make-up Designer", DefaultDisciplineId = 17, DefaultProductionDisciplineId = 17 },
                new DropDownOptionDefault() { RecId = 64, DdoType = "CompanyMemberTitle", DdoTitle = "Associate Make-up Designer", DefaultProductionDisciplineId = 17 },
                new DropDownOptionDefault() { RecId = 65, DdoType = "CompanyMemberTitle", DdoTitle = "Assistant Make-up Designer", DefaultProductionDisciplineId = 17 },
                new DropDownOptionDefault() { RecId = 66, DdoType = "CompanyMemberTitle", DdoTitle = "Make-up Design Intern", DefaultProductionDisciplineId = 17 },
                new DropDownOptionDefault() { RecId = 67, DdoType = "CompanyMemberTitle", DdoTitle = "Make-up", DefaultProductionDisciplineId = 17 },
                new DropDownOptionDefault() { RecId = 68, DdoType = "CompanyMemberTitle", DdoTitle = "Company Manager", DefaultDisciplineId = 9, DefaultProductionDisciplineId = 9 },
                new DropDownOptionDefault() { RecId = 69, DdoType = "CompanyMemberTitle", DdoTitle = "Associate Company Manager", DefaultProductionDisciplineId = 9 },
                new DropDownOptionDefault() { RecId = 70, DdoType = "CompanyMemberTitle", DdoTitle = "Assistant Company Manager", DefaultProductionDisciplineId = 9 },
                new DropDownOptionDefault() { RecId = 71, DdoType = "CompanyMemberTitle", DdoTitle = "Company Manager Intern", DefaultProductionDisciplineId = 9 },
                new DropDownOptionDefault() { RecId = 72, DdoType = "CompanyMemberTitle", DdoTitle = "General Manager", DefaultDisciplineId = 10, DefaultProductionDisciplineId = 10 },
                new DropDownOptionDefault() { RecId = 73, DdoType = "CompanyMemberTitle", DdoTitle = "Associate General Manager", DefaultProductionDisciplineId = 10 },
                new DropDownOptionDefault() { RecId = 74, DdoType = "CompanyMemberTitle", DdoTitle = "Assistant General Manager", DefaultProductionDisciplineId = 10 },
                new DropDownOptionDefault() { RecId = 75, DdoType = "CompanyMemberTitle", DdoTitle = "General Manager Intern", DefaultProductionDisciplineId = 10 },
                new DropDownOptionDefault() { RecId = 76, DdoType = "CompanyMemberTitle", DdoTitle = "Production Manager", DefaultDisciplineId = 18, DefaultProductionDisciplineId = 18 },
                new DropDownOptionDefault() { RecId = 77, DdoType = "CompanyMemberTitle", DdoTitle = "Associate Production Manager", DefaultProductionDisciplineId = 18 },
                new DropDownOptionDefault() { RecId = 78, DdoType = "CompanyMemberTitle", DdoTitle = "Associate Production Manager", DefaultProductionDisciplineId = 18 },
                new DropDownOptionDefault() { RecId = 79, DdoType = "CompanyMemberTitle", DdoTitle = "Production Manager Intern", DefaultProductionDisciplineId = 18 },
                new DropDownOptionDefault() { RecId = 80, DdoType = "CompanyMemberTitle", DdoTitle = "Production Stage Manager", DefaultProductionDisciplineId = 6 },
                new DropDownOptionDefault() { RecId = 81, DdoType = "CompanyMemberTitle", DdoTitle = "Deck Stage Manager", DefaultProductionDisciplineId = 6 },
                new DropDownOptionDefault() { RecId = 82, DdoType = "CompanyMemberTitle", DdoTitle = "Stage Manager", DefaultProductionDisciplineId = 6 },
                new DropDownOptionDefault() { RecId = 83, DdoType = "CompanyMemberTitle", DdoTitle = "Stage Manager Intern", DefaultProductionDisciplineId = 6 },
                new DropDownOptionDefault() { RecId = 84, DdoType = "CompanyMemberTitle", DdoTitle = "Assistant Stage Manager", DefaultProductionDisciplineId = 6 },
                new DropDownOptionDefault() { RecId = 85, DdoType = "CompanyMemberTitle", DdoTitle = "Projection Designer", DefaultDisciplineId = 15, DefaultProductionDisciplineId = 15 },
                new DropDownOptionDefault() { RecId = 86, DdoType = "CompanyMemberTitle", DdoTitle = "Associate Projection Designer", DefaultProductionDisciplineId = 15 },
                new DropDownOptionDefault() { RecId = 87, DdoType = "CompanyMemberTitle", DdoTitle = "Assistant Projection Designer", DefaultProductionDisciplineId = 15 },
                new DropDownOptionDefault() { RecId = 88, DdoType = "CompanyMemberTitle", DdoTitle = "Projection Design Intern", DefaultProductionDisciplineId = 15 },
                new DropDownOptionDefault() { RecId = 89, DdoType = "CompanyMemberTitle", DdoTitle = "Projection Operator", DefaultProductionDisciplineId = 15 },
                new DropDownOptionDefault() { RecId = 90, DdoType = "CompanyMemberTitle", DdoTitle = "Video", DefaultProductionDisciplineId = 15 },
                new DropDownOptionDefault() { RecId = 91, DdoType = "CompanyMemberTitle", DdoTitle = "House Manager", DefaultDisciplineId = 16, DefaultProductionDisciplineId = 16 },
                new DropDownOptionDefault() { RecId = 92, DdoType = "CompanyMemberTitle", DdoTitle = "Assistant House Manager", DefaultProductionDisciplineId = 16 },
                new DropDownOptionDefault() { RecId = 93, DdoType = "CompanyMemberTitle", DdoTitle = "Box Office Manager", DefaultProductionDisciplineId = 16 },
                new DropDownOptionDefault() { RecId = 94, DdoType = "CompanyMemberTitle", DdoTitle = "Assistant Box Office Manager", DefaultProductionDisciplineId = 16 },
                new DropDownOptionDefault() { RecId = 95, DdoType = "CompanyMemberTitle", DdoTitle = "Usher", DefaultProductionDisciplineId = 16 },
                new DropDownOptionDefault() { RecId = 96, DdoType = "ContactSpecTypePerson", DdoTitle = "Height" },
                new DropDownOptionDefault() { RecId = 97, DdoType = "ContactSpecTypePerson", DdoTitle = "Weight" },
                new DropDownOptionDefault() { RecId = 98, DdoType = "ContactSpecTypeVenue", DdoTitle = "Proscenium Height" },
                new DropDownOptionDefault() { RecId = 99, DdoType = "ContactSpecTypeVenue", DdoTitle = "Proscenium Width" },
                new DropDownOptionDefault() { RecId = 100, DdoType = "ContactSpecTypeVenue", DdoTitle = "Proscenium Width" },
                new DropDownOptionDefault() { RecId = 101, DdoType = "GenderOption", DdoTitle = "Male" },
                new DropDownOptionDefault() { RecId = 102, DdoType = "GenderOption", DdoTitle = "Female" },
                new DropDownOptionDefault() { RecId = 103, DdoType = "GenderOption", DdoTitle = "Cis" },
                new DropDownOptionDefault() { RecId = 104, DdoType = "GenderOption", DdoTitle = "Gender Fluid" },
                new DropDownOptionDefault() { RecId = 105, DdoType = "GenderOption", DdoTitle = "Cis Male" },
                new DropDownOptionDefault() { RecId = 106, DdoType = "GenderOption", DdoTitle = "Cis Female" },
                new DropDownOptionDefault() { RecId = 107, DdoType = "GenderOption", DdoTitle = "Bigender" },
                new DropDownOptionDefault() { RecId = 108, DdoType = "GenderOption", DdoTitle = "Intersex" },
                new DropDownOptionDefault() { RecId = 109, DdoType = "GenderOption", DdoTitle = "Non-binary" },
                new DropDownOptionDefault() { RecId = 110, DdoType = "GenderOption", DdoTitle = "Other" },
                new DropDownOptionDefault() { RecId = 111, DdoType = "GenderOption", DdoTitle = "Trans" },
                new DropDownOptionDefault() { RecId = 112, DdoType = "GenderOption", DdoTitle = "Transgender" },
                new DropDownOptionDefault() { RecId = 113, DdoType = "GenderOption", DdoTitle = "Transsexual" },
                new DropDownOptionDefault() { RecId = 114, DdoType = "PreferredPronoun", DdoTitle = "He/Him" },
                new DropDownOptionDefault() { RecId = 115, DdoType = "PreferredPronoun", DdoTitle = "She/Her" },
                new DropDownOptionDefault() { RecId = 116, DdoType = "PreferredPronoun", DdoTitle = "They/Them" },
                new DropDownOptionDefault() { RecId = 117, DdoType = "PerformerHierarchy", DdoTitle = "Main" },
                new DropDownOptionDefault() { RecId = 118, DdoType = "PerformerHierarchy", DdoTitle = "First Cover" },
                new DropDownOptionDefault() { RecId = 119, DdoType = "PerformerHierarchy", DdoTitle = "Second Cover" },
                new DropDownOptionDefault() { RecId = 120, DdoType = "PerformerHierarchy", DdoTitle = "Third Cover" },
                new DropDownOptionDefault() { RecId = 121, DdoType = "PerformerHierarchy", DdoTitle = "Split Track" },
                new DropDownOptionDefault() { RecId = 122, DdoType = "PerformerHierarchy", DdoTitle = "Archive" },
                new DropDownOptionDefault() { RecId = 123, DdoType = "CompanyMemberTitle", DdoTitle = "Marketing Manager", DefaultDisciplineId = 11, DefaultProductionDisciplineId = 11 },
                new DropDownOptionDefault() { RecId = 124, DdoType = "CompanyMemberTitle", DdoTitle = "Director", DefaultDisciplineId = 12, DefaultProductionDisciplineId = 12 },
                new DropDownOptionDefault() { RecId = 125, DdoType = "CompanyMemberTitle", DdoTitle = "Musician", DefaultDisciplineId = 13, DefaultProductionDisciplineId = 13 },
                new DropDownOptionDefault() { RecId = 128, DdoType = "CompanyMemberTitle", DdoTitle = "Actor", DefaultDisciplineId = 1, DefaultProductionDisciplineId = 1 },
                new DropDownOptionDefault() { RecId = 129, DdoType = "LabelType", DdoTitle = "Small" },
                new DropDownOptionDefault() { RecId = 130, DdoType = "LabelType", DdoTitle = "Large" },
                new DropDownOptionDefault() { RecId = 131, DdoType = "LabelType", DdoTitle = "Both" },
                new DropDownOptionDefault() { RecId = 132, DdoType = "MeasurementType", DdoTitle = "Imperial" },
                new DropDownOptionDefault() { RecId = 133, DdoType = "MeasurementType", DdoTitle = "Metric" },
                new DropDownOptionDefault() { RecId = 134, DdoType = "CueLightColor", DdoTitle = "Green" },
                new DropDownOptionDefault() { RecId = 135, DdoType = "CueLightColor", DdoTitle = "Blue" },
                new DropDownOptionDefault() { RecId = 136, DdoType = "CueLightColor", DdoTitle = "Red" },
                new DropDownOptionDefault() { RecId = 137, DdoType = "CueLightColor", DdoTitle = "Yellow" },
                new DropDownOptionDefault() { RecId = 138, DdoType = "CountryOfOrigin", DdoTitle = "USA" },
                new DropDownOptionDefault() { RecId = 139, DdoType = "CountryOfOrigin", DdoTitle = "Canada" },
                new DropDownOptionDefault() { RecId = 140, DdoType = "CountryOfOrigin", DdoTitle = "Mexico" },
                new DropDownOptionDefault() { RecId = 141, DdoType = "CountryOfOrigin", DdoTitle = "China" },
                new DropDownOptionDefault() { RecId = 142, DdoType = "CountryOfOrigin", DdoTitle = "Russia" },
                new DropDownOptionDefault() { RecId = 143, DdoType = "CountryOfOrigin", DdoTitle = "Finland" },
                new DropDownOptionDefault() { RecId = 144, DdoType = "CountryOfOrigin", DdoTitle = "Sweden" },
                new DropDownOptionDefault() { RecId = 145, DdoType = "CountryOfOrigin", DdoTitle = "Ireland" },
                new DropDownOptionDefault() { RecId = 146, DdoType = "CountryOfOrigin", DdoTitle = "England" },
                new DropDownOptionDefault() { RecId = 147, DdoType = "CountryOfOrigin", DdoTitle = "Russia" },
                new DropDownOptionDefault() { RecId = 148, DdoType = "CountryOfOrigin", DdoTitle = "Italy" },
                new DropDownOptionDefault() { RecId = 149, DdoType = "CountryOfOrigin", DdoTitle = "Germany" },
                new DropDownOptionDefault() { RecId = 150, DdoType = "CountryOfOrigin", DdoTitle = "Brazil" },
                new DropDownOptionDefault() { RecId = 151, DdoType = "CountryOfOrigin", DdoTitle = "Peru" },
                new DropDownOptionDefault() { RecId = 152, DdoType = "CountryOfOrigin", DdoTitle = "Argentina" },
                new DropDownOptionDefault() { RecId = 153, DdoType = "CountryOfOrigin", DdoTitle = "Austria" },
                new DropDownOptionDefault() { RecId = 154, DdoType = "CountryOfOrigin", DdoTitle = "Spain" },
                new DropDownOptionDefault() { RecId = 155, DdoType = "CountryOfOrigin", DdoTitle = "Lithuania" },
                new DropDownOptionDefault() { RecId = 156, DdoType = "CountryOfOrigin", DdoTitle = "Poland" },
                new DropDownOptionDefault() { RecId = 157, DdoType = "CompanyMemberTitle", DdoTitle = "Choreographer", DefaultDisciplineId = 5, DefaultProductionDisciplineId = 5 },
                new DropDownOptionDefault() { RecId = 158, DdoType = "CompanyMemberTitle", DdoTitle = "Associate Choreographer", DefaultProductionDisciplineId = 5 },
                new DropDownOptionDefault() { RecId = 159, DdoType = "CompanyMemberTitle", DdoTitle = "Assistant Choreographer", DefaultProductionDisciplineId = 5 },
                new DropDownOptionDefault() { RecId = 160, DdoType = "CompanyMemberTitle", DdoTitle = "Intern Choreographer", DefaultProductionDisciplineId = 5 },
                new DropDownOptionDefault() { RecId = 161, DdoType = "CompanyMemberTitle", DdoTitle = "Dance Captain", DefaultProductionDisciplineId = 5 },
                new DropDownOptionDefault() { RecId = 162, DdoType = "Performance", DdoTitle = "Matinee" },
                new DropDownOptionDefault() { RecId = 163, DdoType = "Performance", DdoTitle = "Evening" },
                new DropDownOptionDefault() { RecId = 164, DdoType = "Performance", DdoTitle = "First Preview" },
                new DropDownOptionDefault() { RecId = 165, DdoType = "Performance", DdoTitle = "Preview Evening" },
                new DropDownOptionDefault() { RecId = 166, DdoType = "Performance", DdoTitle = "Preview Matinee" },
                new DropDownOptionDefault() { RecId = 167, DdoType = "Performance", DdoTitle = "Preview" },
                new DropDownOptionDefault() { RecId = 168, DdoType = "Performance", DdoTitle = "Closing" },
                new DropDownOptionDefault() { RecId = 169, DdoType = "Performance", DdoTitle = "Invited Dress" },
                new DropDownOptionDefault() { RecId = 170, DdoType = "Accommodations", DdoTitle = "Hotel" },
                new DropDownOptionDefault() { RecId = 171, DdoType = "Rehearsal", DdoTitle = "Tech" },
                new DropDownOptionDefault() { RecId = 172, DdoType = "Rehearsal", DdoTitle = "Dress Run" },
                new DropDownOptionDefault() { RecId = 173, DdoType = "Rehearsal", DdoTitle = "Blocking" },
                new DropDownOptionDefault() { RecId = 174, DdoType = "Rehearsal", DdoTitle = "Choreography" },
                new DropDownOptionDefault() { RecId = 175, DdoType = "Rehearsal", DdoTitle = "Table Read" },
                new DropDownOptionDefault() { RecId = 176, DdoType = "Rehearsal", DdoTitle = "Spacing" },
                new DropDownOptionDefault() { RecId = 177, DdoType = "Route", DdoTitle = "Week" },
                new DropDownOptionDefault() { RecId = 178, DdoType = "Route", DdoTitle = "Split-Week" },
                new DropDownOptionDefault() { RecId = 179, DdoType = "Route", DdoTitle = "One-Off" },
                new DropDownOptionDefault() { RecId = 180, DdoType = "Travel", DdoTitle = "Flight" },
                new DropDownOptionDefault() { RecId = 181, DdoType = "Travel", DdoTitle = "Bus" },
                new DropDownOptionDefault() { RecId = 182, DdoType = "Travel", DdoTitle = "Train" },
                new DropDownOptionDefault() { RecId = 183, DdoType = "Travel", DdoTitle = "Boat" },
                new DropDownOptionDefault() { RecId = 184, DdoType = "Travel", DdoTitle = "Car" },
                new DropDownOptionDefault() { RecId = 185, DdoType = "Meeting", DdoTitle = "Production" },
                new DropDownOptionDefault() { RecId = 186, DdoType = "Meeting", DdoTitle = "Load-out" },
                new DropDownOptionDefault() { RecId = 187, DdoType = "Meeting", DdoTitle = "Load-in" },
                new DropDownOptionDefault() { RecId = 188, DdoType = "Meeting", DdoTitle = "Meet and Greet" },
                new DropDownOptionDefault() { RecId = 189, DdoType = "Meeting", DdoTitle = "Equity" }
            );

            modelBuilder.Entity<DisciplineColor>(entity =>
            {
                entity.HasKey(e => e.RecId);

            });

            modelBuilder.Entity<DisciplineColorDefault>(entity =>
            {
                entity.HasKey(e => e.RecId);

            });

            modelBuilder.Entity<DisciplineColorDefault>().HasData(
                new DisciplineColorDefault() { RecId = 1, DisciplineId = 1, ColorString = "#FF00FFFF" },
                new DisciplineColorDefault() { RecId = 2, DisciplineId = 2, ColorString = "#FF00FFFF" },
                new DisciplineColorDefault() { RecId = 3, DisciplineId = 3, ColorString = "#FF00FFFF" },
                new DisciplineColorDefault() { RecId = 4, DisciplineId = 4, ColorString = "#FF00FFFF" },
                new DisciplineColorDefault() { RecId = 5, DisciplineId = 5, ColorString = "#FF00FFFF" },
                new DisciplineColorDefault() { RecId = 6, DisciplineId = 6, ColorString = "#FF00FFFF" },
                new DisciplineColorDefault() { RecId = 7, DisciplineId = 7, ColorString = "#FF00FFFF" },
                new DisciplineColorDefault() { RecId = 8, DisciplineId = 8, ColorString = "#FF00FFFF" },
                new DisciplineColorDefault() { RecId = 9, DisciplineId = 9, ColorString = "#FF00FFFF" },
                new DisciplineColorDefault() { RecId = 10, DisciplineId = 10, ColorString = "#FF00FFFF" },
                new DisciplineColorDefault() { RecId = 11, DisciplineId = 11, ColorString = "#FF00FFFF" },
                new DisciplineColorDefault() { RecId = 12, DisciplineId = 12, ColorString = "#FF00FFFF" },
                new DisciplineColorDefault() { RecId = 13, DisciplineId = 13, ColorString = "#FF00FFFF" },
                new DisciplineColorDefault() { RecId = 14, DisciplineId = 14, ColorString = "#FF00FFFF" },
                new DisciplineColorDefault() { RecId = 15, DisciplineId = 15, ColorString = "#FF00FFFF" },
                new DisciplineColorDefault() { RecId = 16, DisciplineId = 16, ColorString = "#FF00FFFF" },
                new DisciplineColorDefault() { RecId = 17, DisciplineId = 17, ColorString = "#FF00FFFF" },
                new DisciplineColorDefault() { RecId = 18, DisciplineId = 18, ColorString = "#FF00FFFF" }
            );

            modelBuilder.Entity<Discipline>(entity =>
            {
                entity.HasKey(e => e.RecId);
            });

            modelBuilder.Entity<Discipline>().HasData(
                new Discipline() { RecId = 1, DisciplineName = "Actor", DisciplineNameShort = "Actor" },
                new Discipline() { RecId = 2, DisciplineName = "Sound", DisciplineNameShort = "Sound" },
                new Discipline() { RecId = 3, DisciplineName = "Lighting", DisciplineNameShort = "Lighting" },
                new Discipline() { RecId = 4, DisciplineName = "Props", DisciplineNameShort = "Props" },
                new Discipline() { RecId = 5, DisciplineName = "Choreography", DisciplineNameShort = "Choreography" },
                new Discipline() { RecId = 6, DisciplineName = "Stage Management", DisciplineNameShort = "Stage Management" },
                new Discipline() { RecId = 7, DisciplineName = "Wardrobe", DisciplineNameShort = "Wardrobe" },
                new Discipline() { RecId = 8, DisciplineName = "Hair", DisciplineNameShort = "Hair" },
                new Discipline() { RecId = 9, DisciplineName = "Company Management", DisciplineNameShort = "Company Management" },
                new Discipline() { RecId = 10, DisciplineName = "General Management", DisciplineNameShort = "General Management" },
                new Discipline() { RecId = 11, DisciplineName = "Marketing", DisciplineNameShort = "Marketing" },
                new Discipline() { RecId = 12, DisciplineName = "Directing", DisciplineNameShort = "Directing" },
                new Discipline() { RecId = 13, DisciplineName = "Musician", DisciplineNameShort = "Musician" },
                new Discipline() { RecId = 14, DisciplineName = "Scenic", DisciplineNameShort = "Scenic" },
                new Discipline() { RecId = 15, DisciplineName = "Projections", DisciplineNameShort = "Projections" },
                new Discipline() { RecId = 16, DisciplineName = "House Management", DisciplineNameShort = "House Management" },
                new Discipline() { RecId = 17, DisciplineName = "Make Up", DisciplineNameShort = "Make Up" },
                new Discipline() { RecId = 18, DisciplineName = "Production Management", DisciplineNameShort = "Production Management" }
            );


            modelBuilder.Entity<ShareLevel>(entity =>
            {
                entity.HasKey(e => e.RecId);

                entity.Property(e => e.RoleId)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.ShareLevelName)
                    .IsRequired();

            });

            modelBuilder.Entity<ShareLevel>().HasData(
                new ShareLevel() { RoleId = "showplatinum", RecId = 1, ShareLevelName = "Full Access", SizeFriendlyName = "2TB", SizeAllotment = 2000000 },
                new ShareLevel() { RoleId = "showtitanium", RecId = 2, ShareLevelName = "Checklist, View, Print, and Edit", SizeFriendlyName = "1TB", SizeAllotment = 1000000 },
                new ShareLevel() { RoleId = "showgold", RecId = 3, ShareLevelName = "Checklist, View, and Print", SizeFriendlyName = "1Gig", SizeAllotment = 1000 },
                new ShareLevel() { RoleId = "showsilver", RecId = 4, ShareLevelName = "Checklist, and View", SizeFriendlyName = "500MB", SizeAllotment = 500 },
                new ShareLevel() { RoleId = "showbronze", RecId = 5, ShareLevelName = "Checklist", SizeFriendlyName = "None", SizeAllotment = 0 },
                new ShareLevel() { RoleId = "showguest", RecId = 6, ShareLevelName = "No Access", SizeFriendlyName = "None", SizeAllotment = 0 }
            );

            modelBuilder.Entity<Theme>(entity =>
            {
                entity.HasKey(e => e.RecId);
            });

            modelBuilder.Entity<Theme>().HasData(
                new Theme() { RecId = 1, ThemeName = "Metro Black", ThemeUrl = "/themes/metroblack.css", isDark = true, ThemeShade = "Dark" },
                new Theme() { RecId = 2, ThemeName = "Flat", ThemeUrl = "/themes/flat.css", isDark = true, ThemeShade = "Medium" },
                new Theme() { RecId = 3, ThemeName = "Material", ThemeUrl = "_content/Telerik.UI.for.Blazor/css/kendo-theme-material/all.css", isDark = false, ThemeShade = "Plain" },
                new Theme() { RecId = 4, ThemeName = "Default", ThemeUrl = "_content/Telerik.UI.for.Blazor/css/kendo-theme-default/all.css", isDark = false, ThemeShade = "Light" },
                new Theme() { RecId = 5, ThemeName = "Moonlight", ThemeUrl = "/themes/moonlight.css", isDark = true, ThemeShade = "Dark" },
                new Theme() { RecId = 6, ThemeName = "Bootstrap", ThemeUrl = "_content/Telerik.UI.for.Blazor/css/kendo-theme-default/all.css", isDark = false, ThemeShade = "Light" },
                new Theme() { RecId = 7, ThemeName = "Urban", ThemeUrl = "/themes/Urban.css", isDark = false, ThemeShade = "Light" },
                new Theme() { RecId = 8, ThemeName = "Turquiose", ThemeUrl = "/themes/Turquiose.css", isDark = true, ThemeShade = "Dark" },
                new Theme() { RecId = 9, ThemeName = "Vintage", ThemeUrl = "/themes/Vintage.css", isDark = true, ThemeShade = "Dark" },
                new Theme() { RecId = 10, ThemeName = "High Contrast", ThemeUrl = "/themes/HighContrast.css", isDark = true, ThemeShade = "Dark" },
                new Theme() { RecId = 11, ThemeName = "Indigo", ThemeUrl = "/themes/Indigo.css", isDark = true, ThemeShade = "Dark" },
                new Theme() { RecId = 12, ThemeName = "Nordic", ThemeUrl = "/themes/Nordic.css", isDark = true, ThemeShade = "Dark" },
                new Theme() { RecId = 13, ThemeName = "Indigo Blue Dark", ThemeUrl = "/themes/IndigoBlueDark.css", isDark = true, ThemeShade = "Dark" }
            );

            modelBuilder.Entity<PromoCode>(entity =>
            {
                entity.HasKey(e => e.RecId)
                    .HasName("PK_PromoCode");
            });

            modelBuilder.Entity<Message>(entity =>
            {
                entity.HasKey(e => e.RecId);

                //entity.HasOne(d => d.MessageType)
                //    .WithMany(p => p.Messages)
                //    .HasForeignKey(d => d.MessageTypeRecId)
                //    .OnDelete(DeleteBehavior.ClientSetNull)
                //    .HasConstraintName("FK_Messages_DropDownOptions");

                //entity.HasOne(d => d.Production)
                //    .WithMany(p => p.Messages)
                //    .HasForeignKey(d => d.ProductionId)
                //    .OnDelete(DeleteBehavior.Cascade)
                //    .HasConstraintName("FK_Messages_ShowInfo");

                //entity.HasOne(d => d.FromContacts)
                //    .WithMany(p => p.FromMessage)
                //    .OnDelete(DeleteBehavior.ClientSetNull)
                //    .HasForeignKey(d => d.FromContactRecId)
                //    .HasConstraintName("FK_FromMessage_FromContacts");

                //entity.HasOne(d => d.ToContacts)
                //    .WithMany(p => p.ToMessage)
                //    .OnDelete(DeleteBehavior.ClientSetNull)
                //    .HasForeignKey(d => d.ToContactRecId)
                //    .HasConstraintName("FK_ToMessage_ToContacts");
            });

            modelBuilder.Entity<PromoCodesUsed>(entity =>
            {
                entity.HasKey(e => e.RecId)
                    .HasName("PK_PromoCodeUsed");
            });

            modelBuilder.Entity<Purchase>(entity =>
            {
                entity.HasKey(e => e.RecId);

                entity.Property(e => e.PurchasePrice).HasColumnType("money");
            });

            modelBuilder.Entity<ShareLink>(entity =>
            {
                entity.HasKey(e => e.RecId);

                //entity.HasOne(d => d.StudioManagerUser)
                //    .WithMany(p => p.ShareLinks)
                //    .HasForeignKey(d => d.StudioManagerUserId)
                //    .OnDelete(DeleteBehavior.Cascade);

            });

            modelBuilder.Entity<ShareLinkFile>(entity =>
            {
                entity.HasKey(e => e.RecId);

                entity.HasOne(d => d.ShareLink)
                    .WithMany(p => p.ShareLinkFiles)
                    .HasForeignKey(d => d.LinkId);

            });

            modelBuilder.Entity<SharedProduction>(entity =>
            {
                entity.HasKey(e => e.RecId);

                //entity.HasOne(d => d.OwnerStudioManagerUser)
                //    .WithMany(p => p.SharedProductions)
                //    .HasForeignKey(d => d.OwnerUserId)
                //    .OnDelete(DeleteBehavior.Cascade)
                //    .HasConstraintName("FK_SharedProductions_OwnerStudioManagerUser");
            });

            modelBuilder.Entity<ShareMessage>(entity =>
            {
                entity.HasKey(e => e.RecId);

                entity.HasOne(d => d.SharedProduction)
                    .WithMany(p => p.ShareMessages)
                    .HasForeignKey(d => d.LinkId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_ShareMessages_ShareMessage");
            });

            modelBuilder.Entity<ShareMessageReply>(entity =>
            {
                entity.HasKey(e => e.RecId);

                entity.HasOne(d => d.ShareMessage)
                    .WithMany(p => p.ShareMessageReplies)
                    .HasForeignKey(d => d.LinkId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_ShareMessageReply_ShareMessage");
            });

            modelBuilder.Entity<NotificationMessage>(entity =>
            {
                entity.HasKey(e => e.RecId);

            });
        }
    }
}
