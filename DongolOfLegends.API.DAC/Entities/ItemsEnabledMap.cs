using System;
using System.Collections.Generic;

#nullable disable

namespace DongolOfLegends.API.DAC.Entities
{
    public partial class ItemsEnabledMap
    {
        public ItemsEnabledMap()
        {
            BasicItemInfos = new HashSet<BasicItemInfo>();
        }

        public long ItemId { get; set; }
        public bool _1 { get; set; }
        public bool _8 { get; set; }
        public bool _10 { get; set; }
        public bool _12 { get; set; }

        public virtual ItemData Item { get; set; }
        public virtual ICollection<BasicItemInfo> BasicItemInfos { get; set; }
    }
}
