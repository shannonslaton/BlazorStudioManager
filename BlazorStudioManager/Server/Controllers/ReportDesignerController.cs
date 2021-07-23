using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Telerik.Reporting.Services;
using Telerik.WebReportDesigner.Services;
using Telerik.WebReportDesigner.Services.Controllers;

namespace BlazorStudioManager.Server.Controllers
{
    [Route("api/reportdesigner")]
    [ApiController]

    public class ReportDesignerController : ReportDesignerControllerBase
    {

        public ReportDesignerController(IReportDesignerServiceConfiguration reportDesignerServiceConfiguration, IReportServiceConfiguration reportServiceConfiguration)
        : base(reportDesignerServiceConfiguration, reportServiceConfiguration)
        {
            
        }
    }
}
