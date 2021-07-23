using BlazorStudioManager.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorStudioManager.Shared.HelperModels
{
    public class DropDownOptionHelper : HelperBase
    {
        public DropDownOption EditItem { get; set; } = new DropDownOption();
        public DropDownOption CurrentlyEditedItem { get; set; }
        public IEnumerable<DropDownOption> SelectedItems { get; set; } = new List<DropDownOption>();
        public List<DropDownOption> GridData { get; set; } = new List<DropDownOption>();
        public DropDownOption FormModel { get; set; } = new DropDownOption();
    }
}
