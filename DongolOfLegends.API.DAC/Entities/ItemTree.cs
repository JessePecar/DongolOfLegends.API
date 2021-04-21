using System;
using System.Collections.Generic;

#nullable disable

namespace DongolOfLegends.API.DAC.Entities
{
    public partial class ItemTree
    {
        public ItemTree()
        {
            ItemTags = new HashSet<ItemTag>();
        }

        public long Id { get; set; }
        public string Header { get; set; }
        public string ItemsVersion { get; set; }

        public virtual Item ItemsVersionNavigation { get; set; }
        public virtual ICollection<ItemTag> ItemTags { get; set; }
    }
}
