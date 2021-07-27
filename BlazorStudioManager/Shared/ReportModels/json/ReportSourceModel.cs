using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorStudioManager.Shared.ReportModels.json
{
    public class ReportSourceModel
    {
        public string Name { get; set; }
        public List<Catalog> Data { get; set; }
        public string Grouping { get; set; }
        public List<ReportSourceFilter> Filters { get; set; }
        public ReportSourceSorting Sortings { get; set; }
        public string ModelType { get; set; }

    }
}
