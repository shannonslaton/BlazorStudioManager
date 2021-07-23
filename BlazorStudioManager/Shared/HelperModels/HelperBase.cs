using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorStudioManager.Shared.HelperModels
{
    public abstract class HelperBase
    {
        public virtual bool IsLoading { get; set; }
        public virtual string ErrorMessage { get; set; }
        public virtual string EditStatus { get; set; }
        public virtual bool IsFromGrid { get; set; }
        public virtual bool IsMultiUpdate { get; set; }
        public virtual bool WasReset { get; set; }
        public virtual bool DeleteCurrentImage { get; set; } //This is on double-click.  Delete Image button will delete.
        public virtual string imageSrc { get; set; }
        public virtual int CurrentEditIndex { get; set; } = 0;
        public virtual string HeaderName { get; set; }
        public virtual string EditHeaderName { get; set; }
        public virtual int previousDisciplineId { get; set; } = 0;
        public virtual int previousDepartmentId { get; set; } = 0;
        public virtual bool EditContextNeedsSubmit { get; set; }
        //public virtual string vis { get; set; } = "d-none";
        public virtual bool isValid { get; set; }
        public virtual bool IsFromComboBox { get; set; }
        public virtual bool NoAddsAllowed { get; set; }
        public virtual int SelectedId { get; set; }
        public virtual bool IsNew { get; set; }
        public virtual bool GridView { get; set; } = true;
        public virtual bool NextEnabled { get; set; }
        public virtual bool PreviousEnabled { get; set; }
        public virtual bool ViewEditStatus { get; set; }
        public virtual bool ViewToggleDrawer { get; set; } = true;
        public virtual bool ViewSelectedItems { get; set; }
        public virtual bool ViewDeleteHandler { get; set; }
        public virtual bool ViewAddHandler { get; set; }
        public virtual bool ViewResetHandler { get; set; }
        public virtual bool ViewOnSubmitFromToolbar { get; set; }
        public virtual bool ViewErrorMessage { get; set; }
        public virtual bool ViewGoBack { get; set; }
        public virtual bool ViewSaveAndClose { get; set; }
        public virtual bool ViewHeaderName { get; set; }
        //public SplitterSettings SplitterSettings { get; set; } = new SplitterSettings();
        public bool ToggleSplitterOrientation { get; set; }
        public string GridImageSrc { get; set; }
        public string sticky { get; set; } = "stickytop";
        public int ActiveTabIndex { get; set; } = 0;
        public int LocalTabIndex { get; set; } = 0;
        public bool XSmall { get; set; }
        public bool Small { get; set; }
        public bool Medium { get; set; }
        public bool Large { get; set; }
        public string CurrentText { get; set; } = "";
        public int InitialFindRecId { get; set; } = 0;
        public int InitialRecId { get; set; } = 0;
        public int GridInitialRecId { get; set; } = 0;
        public int FormInitialRecId { get; set; } = 0;
        public int InitialDisciplineRecId { get; set; } = 0;
        public int InitialCompanyMemberRecId { get; set; } = 0;
        public IEnumerable<string> validationSummaryContext { get; set; }
        public string GoToName { get; set; }
        public string CurrentDrawerName { get; set; }
        public string DdoCbType { get; set; }
    }
}
