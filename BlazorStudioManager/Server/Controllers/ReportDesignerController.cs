using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Telerik.Reporting.Processing;
using Telerik.Reporting.Services;
using Telerik.WebReportDesigner.Services;
using Telerik.WebReportDesigner.Services.Controllers;

namespace BlazorStudioManager.Server.Controllers
{
    [Route("api/reportdesigner")]
    [ApiController]

    public class ReportDesignerController : ReportDesignerControllerBase
    {
        private IHttpContextAccessor httpContextAccessor;

        public ReportDesignerController(IReportDesignerServiceConfiguration reportDesignerServiceConfiguration, IReportServiceConfiguration reportServiceConfiguration, IHttpContextAccessor httpContextAccessor)
        : base(reportDesignerServiceConfiguration, reportServiceConfiguration)
        {
            this.httpContextAccessor = httpContextAccessor;
        }

        protected override UserIdentity GetUserIdentity()
        {
            var identity = base.GetUserIdentity();
            identity.Context = new System.Collections.Concurrent.ConcurrentDictionary<string, object>();

            identity.Context["UrlReferrer"] = httpContextAccessor.HttpContext.Request.Headers["Referer"].ToString();

            // Any other available information can be stored in the identity.Context in the same way

            return identity;
        }
    }
}
