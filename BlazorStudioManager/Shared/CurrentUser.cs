using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorStudioManager.Shared
{
    public class CurrentUser
    {
        public bool IsAuthenticated { get; set; }
        public string UserName { get; set; }
        public string CurrentProductionName { get; set; }
        public string CurrentPageName { get; set; } = "Current Production";
        public string ThemeUrl { get; set; }
        //public int ContactId { get; set; }
        public int ShareWithContactId { get; set; }
        public string StudioManagerUserId { get; set; }
        public int CurrentProductionId { get; set; }
        public int ProductionOwnerContactId { get; set; }
        public string ProductionCreatorUserId { get; set; }
        public int ProductionDisciplineId { get; set; }
        public string DisciplineName { get; set; }
        public bool ShowNewUser { get; set; }
        public bool ShowNewFeatures { get; set; }
        public string ContactsImageUrl { get; set; }
        public bool CurrentUserSignedIn { get; set; }
        public string ShowRoleName { get; set; }
        public Dictionary<string, string> Claims { get; set; }
        public bool IsAdministrator { get; set; }
        public bool HasEditRights { get; set; }
        public bool HasPrintRights { get; set; }
        public string HelpId { get; set; }
        public DateTime SubscriptionEndDate { get; set; }
        public bool CurrentSubscriber { get; set; }
        public int StorageAllotment { get; set; }
        public bool HasEditDisciplineRights { get; set; }
        public bool IsDisciplineLeader { get; set; }
        public bool IsThemeDark { get; set; }
        public string ThemeShade { get; set; }
        public string BlobUrl { get; set; }
        public DateTime MinDate { get; set; }
        public string CurrentContactDisplayName { get; set; }
        public int ThemeId { get; set; }
        public int DisciplineId { get; set; }
        public bool IsProductionCreator { get; set; }
        public int SharedProductionId { get; set; }
        public int CurrentCompanyMemberId { get; set; }
        public string BackPageUrl { get; set; }
        public string CurrentPageUrl { get; set; } = "/";
        public string ProductionPartViewType { get; set; }
        public int ViewAsCompanyMemberId { get; set; }
        public bool UserHasViewAsEditRights { get; set; } //This is keeps user from editing cues that aren't theirs
        public bool CanUserEditScenesSongs { get; set; }
        public bool CanUserEditCompanyMembersAndContacts { get; set; }
        public bool CanUserEditPrivateContacts { get; set; }
        public int CatalogId { get; set; }
        public int LatestVersion { get; set; }
        public int CurrentTabIndex { get; set; }
        public int ViewAsDisciplineId { get; set; }
        public int TemporaryViewAsDisciplineId { get; set; }
        public int TemporaryViewAsCompanyMemberId { get; set; }
        public bool TemporaryUserHasEditRights { get; set; }
        public int PreviousViewAsDisciplineId { get; set; }
        public int PreviousViewAsCompanyMemberId { get; set; }
        public int CurrentPerformanceId { get; set; }
        public string CurrentPerformanceDateString { get; set; }
        public bool ViewingPastAppointment { get; set; }
        public bool IsSignInAvailable { get; set; }
        public bool IsHouseOpen { get; set; }
        //public bool IsPerformanceRunning { get; set; }
        public bool InPerformanceMode { get; set; }
        public string GridHeight { get; set; }
        public string GridWidth { get; set; }
        public string GalleryWidth { get; set; }
        public string GalleryHeight { get; set; }
        public string InnerGalleryWidth { get; set; }
        public string InnerGalleryHeight { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int GridRowHeight { get; set; } = 60;
        public int PageSize { get; set; } = 15;
        public int GalleryPageSize { get; set; } = 20;
        public string PageSizeSelect { get; set; } = "10";
        public string SplitterOrientation { get; set; } = "Vertical";
        public string ImagePaneSize { get; set; } = "270px";
        public int ColSpan { get; set; } = 4;
        public string GridOrGallery { get; set; } = "Gallery";
        public string FormWidth { get; set; }
        public string FormHeight { get; set; }
        public DrawerItem DrawerSelectedItem { get; set; } = new DrawerItem() { GoTo = "EditorForm" };
        public DrawerItem ProfileDrawerSelectedItem { get; set; } = new DrawerItem() { GoTo = "MyProfile" };
        public string ImageSize { get; set; } = "200px;";
        public string ImageContainerSize { get; set; } = "240px;";
        public string DrawerSection { get; set; } = "CurrentProduction";
        public bool HasCreateRights { get; set; }
        public bool AllowMerge { get; set; }
        public int UserDefaultContactId { get; set; }
        public string CurrentUserRoleId { get; set; }
        public bool NewPerformanceReport { get; set; }
        public int NewPerformanceReportId { get; set; }
        //public string ShowClockSection { get; set; }
        //public DateTimeOffset ShowClock { get; set; }
        //public string ShowClockElapsedTimeSpan { get; set; }
        public string ShowSectionElapsedTime { get; set; }
        public bool ShowElapsedTime { get; set; }
        public DateTimeOffset SceneClock { get; set; }
        public string SceneElapsedTime { get; set; }
        public DateTimeOffset CueClock { get; set; }
        public string CueElapsedTime { get; set; }
        public bool FreeTrialEnded { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal? CurrentLatitude { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal? CurrentLongitude { get; set; }
        public int CurrentCueIndex { get; set; }
        public int CurrentSceneIndex { get; set; }
        public string CurrentCompanyMemberTitle { get; set; }
        //CompanyMember's Script
        public string PdfName { get; set; }
        public string PdfFriendlyName { get; set; }
        public string PdfOwnerUserId { get; set; }
    }
}
