using System;
using System.Collections.Generic;

#nullable disable

namespace DongolOfLegends.API.DAC.Entities
{
    public partial class Item
    {
        public Item()
        {
            ItemData = new HashSet<ItemData>();
            ItemGroups = new HashSet<ItemGroup>();
            ItemTrees = new HashSet<ItemTree>();
        }

        public string Version { get; set; }
        public string Type { get; set; }
        public string BasicCode { get; set; }

        public virtual BasicItemInfo BasicCodeNavigation { get; set; }
        public virtual ICollection<ItemData> ItemData { get; set; }
        public virtual ICollection<ItemGroup> ItemGroups { get; set; }
        public virtual ICollection<ItemTree> ItemTrees { get; set; }
    }
}
