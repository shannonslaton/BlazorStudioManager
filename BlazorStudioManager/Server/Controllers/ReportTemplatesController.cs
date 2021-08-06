using BlazorStudioManager.Server.Data;
using BlazorStudioManager.Shared;
using BlazorStudioManager.Shared.IdentityModels;
using BlazorStudioManager.Shared.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Telerik.Blazor.Components;

namespace BlazorStudioManager.Server.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ReportTemplatesController : ControllerBase
    {
        private readonly StudioManagerUserContext _contextUser;
        private readonly StudioManagerIdentityContext _contextIdentity;

        private bool saveIdentitySuccess;
        private bool saveUserSuccess;
        private int savedUserChangesCount { get; set; } = 0;
        private int savedIdentityChangesCount { get; set; } = 0;
        private string GridStoreName { get; set; } = "ReportTemplates";
        private StudioManagerUser CurrentUser { get; set; }

        public ReportTemplatesController(StudioManagerUserContext contextUser, StudioManagerIdentityContext contextIdentity)
        {
            _contextUser = contextUser;
            _contextIdentity = contextIdentity;
        }

        #region Saves
        async Task GetUserAndProduction()
        {
            CurrentUser = await _contextIdentity.StudioManagerUser.FindAsync(User.FindFirst(ClaimTypes.NameIdentifier).Value);
        }
        private async Task SaveUserContext()
        {
            try
            {
                savedUserChangesCount = await _contextUser.SaveChangesAsync();

                if (savedUserChangesCount > 0)
                {
                    saveUserSuccess = true;
                }
                else
                {
                    saveUserSuccess = false;
                }
            }
            catch (System.Exception ex)
            {
                var exceptions = ex.ToString();
                throw;
            }
        }
        private async Task SaveIdentityContext()
        {
            try
            {
                savedIdentityChangesCount = await _contextIdentity.SaveChangesAsync();

                if (savedIdentityChangesCount > 0)
                {
                    saveIdentitySuccess = true;
                }
                else
                {
                    saveIdentitySuccess = false;
                }

            }
            catch (System.Exception ex)
            {
                var exceptions = ex.ToString();
                throw;
            }
        }
        #endregion
        #region GridSaves
        [HttpGet]
        [Authorize(Policy = "Editing")]
        public async Task<bool> ClearUpdates()
        {
            await GetUserAndProduction();

            var collection = from c in _contextIdentity.ReportTemplates
                             where c.Updated == true
                             select c;

            foreach (var item in collection)
            {
                item.Updated = false;
            }

            await SaveIdentityContext();
            return saveIdentitySuccess;
        }
        [HttpPost]
        public async Task<ActionResult> PostGridSave(GridState<ReportTemplate> gridState)
        {
            await GetUserAndProduction();

            var jsonString = Newtonsoft.Json.JsonConvert.SerializeObject(gridState);

            GridSave gridSave = new GridSave()
            {
                Updated = true,
                LastModifiedById = CurrentUser.Id,
                LastModifiedOnDt = DateTime.UtcNow,
                GridAllSettings = jsonString,
                AspUserId = CurrentUser.Id,
                StoreName = GridStoreName
            };

            var stateExists = await _contextIdentity.GridSaves.Where(c => c.StoreName == gridSave.StoreName).Where(c => c.AspUserId == gridSave.AspUserId).FirstOrDefaultAsync();

            if (stateExists != null)
            {
                _contextIdentity.GridSaves.Remove(stateExists);
                await SaveIdentityContext();
            }

            await _contextIdentity.AddAsync(gridSave);
            await SaveIdentityContext();

            return Ok();
        }
        [HttpGet]
        public async Task<ActionResult<GridState<ReportTemplate>>> GetGridSave()
        {
            await GetUserAndProduction();

            var gridSave = await _contextIdentity.GridSaves.Where(c => c.StoreName == GridStoreName).Where(c => c.AspUserId == CurrentUser.Id).FirstOrDefaultAsync();
            if (gridSave != null)
            {
                var jsonString = Newtonsoft.Json.JsonConvert.DeserializeObject<GridState<ReportTemplate>>(gridSave.GridAllSettings);

                return jsonString;
            }
            GridState<ReportTemplate> nullSettings = new GridState<ReportTemplate>();
            return nullSettings;
        }
        [HttpDelete]
        public async Task<ActionResult> DeleteGridSave()
        {
            await GetUserAndProduction();

            var stateExists = await _contextIdentity.GridSaves.Where(c => c.StoreName == GridStoreName).Where(c => c.AspUserId == CurrentUser.Id).FirstOrDefaultAsync();

            if (stateExists != null)
            {
                _contextIdentity.GridSaves.Remove(stateExists);
                await SaveIdentityContext();
            }

            return Ok();
        }
        #endregion

        #region Gets
        [HttpGet("{model}")]
        public async Task<ActionResult<IEnumerable<ReportTemplate>>> GetReportTemplatesByModel(string model)
        {
            await GetUserAndProduction();

            var collection = await _contextIdentity.ReportTemplates
                .Where(c => c.ModelType == model)
                .Where(c => c.Deleted == false).Where(c => c.Hidden == false).ToListAsync();

            List<ReportTemplate> finalList = new List<ReportTemplate>();

            foreach (var item in collection)
            {
                finalList.Add(item);
            }

            return finalList.OrderBy(c => c.ReportTemplateName).ToList();
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ReportTemplate>>> GetReportTemplates()
        {
            await GetUserAndProduction();

            var collection = await _contextIdentity.ReportTemplates
                .Where(c => c.Deleted == false).Where(c => c.Hidden == false).ToListAsync();

            List<ReportTemplate> finalList = new List<ReportTemplate>();

            foreach (var item in collection)
            {
                finalList.Add(item);
            }

            return finalList.OrderBy(c => c.ReportTemplateName).ToList();
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<string>>> GetReportTemplatesDdo()
        {
            await GetUserAndProduction();

            var collection = await _contextIdentity.ReportTemplates.Where(c => c.CreatedByUserId == CurrentUser.Id).Where(c => c.Deleted == false).Where(c => c.Hidden == false).ToListAsync();

            //if (collection.Count() == 0)
            //{
            //    var returnTemplate = new byte[7000];
            //    var addTemplate = new ReportTemplate()
            //    {
            //        Layout = returnTemplate,
            //        ReportTemplateName = "Blank.trdp",
            //        LastModifiedOnDt = DateTime.Now,
            //        GlobalLayout = false,
            //        ModelType = "Catalogs",
            //        CreatedOn = DateTime.UtcNow,
            //        CreatedByUserId = CurrentUser.Id,
            //        EditIndex = 0,
            //        LastModifiedById = CurrentUser.Id
            //    };

            //    await _contextIdentity.AddAsync(addTemplate);
            //    await _contextIdentity.SaveChangesAsync();

            //    collection.Add(addTemplate);
            //}

            List<string> finalList = new List<string>();

            foreach (var item in collection)
            {
                //var ddo = new DropDownOption()
                //{
                //    RecId = item.RecId,
                //    DdoTitle = item.ReportTemplateName
                //};

                finalList.Add(item.ReportTemplateName);
            }

            return finalList.OrderBy(c => c).ToList();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ReportTemplate>> GetReportTemplate(int id)
        {
            var ReportTemplate = await _contextIdentity.ReportTemplates.FirstOrDefaultAsync(c => c.RecId == id);

            if (ReportTemplate == null)
            {
                return NotFound();
            }

            return ReportTemplate;
        }
        [HttpGet("{templateName}/{model}")]
        public async Task<ActionResult<bool>> DoesNameExist(string templateName, string model)
        {
            await GetUserAndProduction();

            var existing = await _contextIdentity.ReportTemplates
                .Where(c => c.ReportTemplateName == templateName)
                .Where(c => c.ModelType == model)
                .Where(c => c.Hidden == false)
                .Where(c => c.Deleted == false)
                .FirstOrDefaultAsync(c => c.CreatedByUserId == CurrentUser.Id);

            if (existing == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        [HttpGet("{modelType}/{ReportTemplateName}/{templateName}")]
        public async Task<ActionResult<ReportTemplate>> SaveAsReportTemplate(string modelType, string ReportTemplateName, string templateName)
        {
            await GetUserAndProduction();

            templateName = templateName + ".trdp";

            var ReportTemplate = await _contextIdentity.ReportTemplates.Where(c => c.ModelType == modelType).Where(c => c.ReportTemplateName == ReportTemplateName).FirstOrDefaultAsync(c => c.CreatedByUserId == CurrentUser.Id);

            ReportTemplate.RecId = 0;
            ReportTemplate.ReportTemplateName = templateName;
            await _contextIdentity.AddAsync(ReportTemplate);
            await _contextIdentity.SaveChangesAsync();

            return ReportTemplate;
        }
        #endregion

        #region CRUD
        [HttpPut]
        [Authorize(Policy = "Editing")]
        public async Task<ActionResult<ReportTemplate>> PutReportTemplate(ReportTemplate ReportTemplate)
        {
            _contextIdentity.Entry(ReportTemplate).State = EntityState.Modified;

            try
            {
                await SaveIdentityContext();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ReportTemplateExists(ReportTemplate.RecId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return Ok(ReportTemplate);
        }

        [HttpPost]
        [Authorize(Policy = "Editing")]
        public async Task<ActionResult<ReportTemplate>> PostReportTemplate(ReportTemplate ReportTemplate)
        {
            await _contextIdentity.ReportTemplates.AddAsync(ReportTemplate);
            await _contextIdentity.SaveChangesAsync();

            return CreatedAtAction("GetReportTemplate", new { id = ReportTemplate.RecId }, ReportTemplate);
        }

        [HttpDelete("{id}")]
        [Authorize(Policy = "Editing")]
        public async Task<IActionResult> DeleteReportTemplate(int id)
        {
            var ReportTemplate = await _contextIdentity.ReportTemplates.Where(c => c.Deleted == false).Where(c => c.Hidden == false).FirstOrDefaultAsync(c => c.RecId == id);
            ReportTemplate.Deleted = true;
            await _contextIdentity.SaveChangesAsync();

            return NoContent();
        }

        private bool ReportTemplateExists(int id)
        {
            return _contextIdentity.ReportTemplates.Where(c => c.Deleted == false).Where(c => c.Hidden == false).Any(e => e.RecId == id);
        }
        #endregion
    }
}
