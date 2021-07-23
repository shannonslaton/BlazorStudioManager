using BlazorStudioManager.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorStudioManager.Shared.IdentityModels
{
    public class ScheduleResource
    {
        public virtual int RecId { get; set; }
        public string Value { get; set; }
        public string Text { get; set; }
        public string Color { get; set; }
        public string ColorHashTag { get; set; }
    }
}
