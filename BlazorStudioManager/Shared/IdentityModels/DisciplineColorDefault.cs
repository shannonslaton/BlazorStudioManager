using BlazorStudioManager.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorStudioManager.Shared.IdentityModels
{
    public class DisciplineColorDefault
    {
        public virtual int RecId { get; set; }
        public virtual int DisciplineId { get; set; }
        public string ColorString { get; set; }
    }
}
