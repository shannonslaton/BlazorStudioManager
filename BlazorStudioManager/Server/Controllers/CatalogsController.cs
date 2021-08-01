using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BlazorStudioManager.Shared;
using BlazorStudioManager.Server.Data;
using Telerik.Blazor.Components;
using BlazorStudioManager.Shared.IdentityModels;
using System;
using System.Security.Claims;
using System.Text.Json;

namespace BlazorStudioManager.Server.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CatalogsController : ControllerBase
    {
        private readonly StudioManagerContext _context;
        private readonly StudioManagerIdentityContext _contextIdentity;
        private StudioManagerUser CurrentUser { get; set; }

        public CatalogsController(StudioManagerContext context, StudioManagerIdentityContext contextIdentity)
        {
            _context = context;
            _contextIdentity = contextIdentity;
        }

        async Task GetUserAndProduction()
        {
            CurrentUser = await _contextIdentity.StudioManagerUser.FindAsync(User.FindFirst(ClaimTypes.NameIdentifier).Value);
            //CurrentSharedProduction = await _contextIdentity.SharedProductions.Where(c => c.SharedWithEmail == CurrentUser.Email).Where(c => c.Deleted == false).Where(c => c.Hidden == false).FirstOrDefaultAsync(c => c.RecId == CurrentUser.SharedProductionId);
            //CurrentProduction = await _contextUser.Productions.Where(c => c.Deleted == false).Where(c => c.Hidden == false).FirstOrDefaultAsync(c => c.RecId == CurrentSharedProduction.ProductionId);
            //CurrentCompanyMember = await _contextUser.CompanyMembers.Where(c => c.Deleted == false).Where(c => c.Hidden == false).FirstOrDefaultAsync(c => c.RecId == CurrentSharedProduction.CompanyMemberId);
            //CurrentContact = await _contextUser.Contacts.Where(c => c.Deleted == false).Where(c => c.Hidden == false).FirstOrDefaultAsync(c => c.RecId == CurrentCompanyMember.ContactId);
        }

        // GET: api/Catalogs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Catalog>>> GetCatalogs()
        {
            


            //var pubNew = new PublicClaims();
            //var pageName = pubNew.GetClaim<string>(PublicClaims.AuthenticatedClaimTypes.PageName);
            //var userId = pubNew.GetClaim<string>(PublicClaims.AuthenticatedClaimTypes.UserId);
            //var returnList = new List<string>();


            return await _context.Catalogs.ToListAsync();
        }

        [HttpGet]
        public IEnumerable<Catalog> aGetCatalogs()
        {



            //var pubNew = new PublicClaims();
            //var pageName = pubNew.GetClaim<string>(PublicClaims.AuthenticatedClaimTypes.PageName);
            //var userId = pubNew.GetClaim<string>(PublicClaims.AuthenticatedClaimTypes.UserId);
            //var returnList = new List<string>();


            return _context.Catalogs.ToList();
        }

        // GET: api/Catalogs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Catalog>> GetCatalog(int id)
        {
            var catalog = await _context.Catalogs.FindAsync(id);

            if (catalog == null)
            {
                return NotFound();
            }

            return catalog;
        }

        // PUT: api/Catalogs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCatalog(int id, Catalog catalog)
        {
            if (id != catalog.RecId)
            {
                return BadRequest();
            }

            _context.Entry(catalog).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CatalogExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Catalogs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Catalog>> PostCatalog(Catalog catalog)
        {
            _context.Catalogs.Add(catalog);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCatalog", new { id = catalog.RecId }, catalog);
        }

        // DELETE: api/Catalogs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCatalog(int id)
        {
            var catalog = await _context.Catalogs.FindAsync(id);
            if (catalog == null)
            {
                return NotFound();
            }

            _context.Catalogs.Remove(catalog);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CatalogExists(int id)
        {
            return _context.Catalogs.Any(e => e.RecId == id);
        }

        [HttpGet("{GridSaveName}")]
        public async Task<ActionResult<GridState<Catalog>>> GetGridSave(string GridSaveName)
        {
            await GetUserAndProduction();

            var gridSave = await _contextIdentity.GridSaves.Where(c => c.StoreName == GridSaveName).Where(c => c.AspUserId == CurrentUser.Id).FirstOrDefaultAsync();
            if (gridSave != null)
            {
                var jsonString = Newtonsoft.Json.JsonConvert.DeserializeObject<GridState<Catalog>>(gridSave.GridAllSettings);

                return jsonString;
            }
            GridState<Catalog> nullSettings = new GridState<Catalog>();
            return nullSettings;
        }
        public T GetItem<T>(string key)
        {
            return JsonSerializer.Deserialize<T>(data);
        }
        [HttpPost("{GridSaveName}")]
        public async Task<ActionResult> PostGridSave(object gridState, string GridSaveName)
        {
            await GetUserAndProduction();
            Telerik.DataSource.FilterDescriptor fd;
            var jsonStringn = Newtonsoft.Json.JsonConvert.SerializeObject(gridState);
            var jsonStringd = Newtonsoft.Json.JsonConvert.DeserializeObject<CustomGridState<Catalog>>(jsonStringn);
            //Telerik.DataSource.Grid
            var jsonString = JsonSerializer.Serialize(gridState);
            var fgridState = JsonSerializer.Deserialize<CustomGridState<Catalog>>(jsonString);

            GridSave gridSave = new GridSave()
            {
                Updated = true,
                LastModifiedById = CurrentUser.Id,
                LastModifiedOnDt = DateTime.UtcNow,
                GridAllSettings = jsonString,
                AspUserId = CurrentUser.Id,
                StoreName = GridSaveName
            };

            var stateExists = await _contextIdentity.GridSaves.Where(c => c.StoreName == gridSave.StoreName).Where(c => c.AspUserId == gridSave.AspUserId).FirstOrDefaultAsync();

            if (stateExists != null)
            {
                _contextIdentity.GridSaves.Remove(stateExists);
                await _contextIdentity.SaveChangesAsync();
            }

            await _contextIdentity.AddAsync(gridSave);
            await _contextIdentity.SaveChangesAsync();

            return Ok();
        }
    }

    //
    // Summary:
    //     The class that contains the state of the Telerik Grid Component.
    public class CustomGridState<TItem>
    {
        public CustomGridState()
        {

        }

        //
        // Summary:
        //     Defines the grouping criteria for the Grid Data. Accepts Telerik.DataSource.GroupDescriptor.
        public ICollection<Telerik.DataSource.GroupDescriptor> GroupDescriptors { get; set; }
        //
        // Summary:
        //     Defines the collapsed groups in the GridData. Use together with GroupDescriptors.
        //     The collapsed groups can be defined only for the current page.
        public ICollection<int> CollapsedGroups { get; set; }
        //
        // Summary:
        //     Defines the column state of the configured columns in the Grid. Used for changing
        //     the indices of the columns and their width.
        public ICollection<GridColumnState> ColumnStates { get; set; }
        //
        // Summary:
        //     Defines the expanded rows in the Grid. The expanded rows can be defined only
        //     for the current page, and illustrate the rendering indices of the rows.
        public ICollection<int> ExpandedRows { get; set; }

        //
        // Summary:
        //     Defines the filtering criteria for the Grid Data. Accepts Telerik.DataSource.FilterDescriptor
        //     and Telerik.DataSource.CompositeFilterDescriptor.
        public ICollection<Telerik.DataSource.FilterDescriptor> FilterDescriptors { get; set; }
        //
        // Summary:
        //     Defines the sorting criteria for the Grid Data. Accepts Telerik.DataSource.SortDescriptor.
        public ICollection<Telerik.DataSource.SortDescriptor> SortDescriptors { get; set; }
        //
        // Summary:
        //     Defines the page to be loaded in the Grid. Page Parameter will be updated accordingly.
        public int? Page { get; set; }
        //
        // Summary:
        //     Defines items to be skiped when loading the Grid. Used for GridScrollMode.Virtual
        //     to automatically calculate the scroll position based on the items that need to
        //     be skiped.
        public int? Skip { get; set; }
        //
        // Summary:
        //     Defines the selected items in the Grid. Updates the SelectedItems parameter accordingly.
        public ICollection<TItem> SelectedItems { get; set; }
        //
        // Summary:
        //     Defines the original item in the Grid Data that is in edit.
        public TItem OriginalEditItem { get; set; }
        //
        // Summary:
        //     Defines the updated item while editing.
        public TItem EditItem { get; set; }
        //
        // Summary:
        //     Defines the edit field that is in edit. Used for incell editing.
        public string EditField { get; set; }
        //
        // Summary:
        //     Defines the newly added item.
        public TItem InsertedItem { get; set; }
        //
        // Summary:
        //     Defines the table width of the grid. Related to the proper persistence of table
        //     content metrics when resizing columns.
        public string TableWidth { get; set; }
    }
}
