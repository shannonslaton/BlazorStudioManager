using BlazorStudioManager.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorStudioManager.Shared.IdentityModels
{
    public class DisciplineMerge : BaseEntity
    {
        public string UserId { get; set; }
        public int DisciplineId { get; set; }
        public DateTime LastMergedOn { get; set; }
    }
}
