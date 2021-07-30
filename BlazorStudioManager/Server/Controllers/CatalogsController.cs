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
        [HttpPost("{GridSaveName}")]
        public async Task<ActionResult> PostGridSave(object gridState, string GridSaveName)
        {
            await GetUserAndProduction();

            var jsonStringn = Newtonsoft.Json.JsonConvert.SerializeObject(gridState);
            var jsonStringd = Newtonsoft.Json.JsonConvert.DeserializeObject<GridState<Catalog>>(jsonStringn);

            var jsonString = JsonSerializer.Serialize(gridState);
            var fgridState = JsonSerializer.Deserialize<GridState<Catalog>>(jsonString);

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
}
