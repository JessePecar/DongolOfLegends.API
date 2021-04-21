using System;
using System.Collections.Generic;

#nullable disable

namespace DongolOfLegends.API.DAC.Entities
{
    public partial class ItemRune
    {
        public ItemRune()
        {
            BasicItemInfos = new HashSet<BasicItemInfo>();
        }

        public long ItemId { get; set; }
        public bool Isrune { get; set; }
        public int Tier { get; set; }
        public string Type { get; set; }

        public virtual ItemData Item { get; set; }
        public virtual ICollection<BasicItemInfo> BasicItemInfos { get; set; }
    }
}
