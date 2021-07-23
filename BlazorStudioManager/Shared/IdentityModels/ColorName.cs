using BlazorStudioManager.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorStudioManager.Shared.IdentityModels
{
    public class ColorName : BaseEntity
    {
        public string ColorId { get; set; }
        public string Color { get; set; }
    }
}
