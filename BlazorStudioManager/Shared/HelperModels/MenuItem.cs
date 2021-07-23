using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorStudioManager.Shared.HelperModels
{
    public class MenuItem
    {
        public int Id { get; set; }
        public int? MenuItemId { get; set; }
        public string MenuItemName { get; set; }
        public string Image { get; set; }
        public string URL { get; set; }
        public bool refreshParameter { get; set; }
        public string MyIconClass { get; set; }
        public string MyIconField { get; set; }
        public List<MenuItem> SubMenuItemList { get; set; }
        public DrawerItem DrawerSelectedItem { get; set; }
    }
}
