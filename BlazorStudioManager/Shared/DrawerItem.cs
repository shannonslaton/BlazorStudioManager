using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorStudioManager.Shared
{
    public class DrawerItem
    {
        public string Text { get; set; }
        public string GoTo { get; set; }
        public string Icon { get; set; }
        public bool IsSeparator { get; set; }
    }
}
