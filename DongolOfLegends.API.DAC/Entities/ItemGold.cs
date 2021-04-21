using System;
using System.Collections.Generic;

#nullable disable

namespace DongolOfLegends.API.DAC.Entities
{
    public partial class ItemGold
    {
        public ItemGold()
        {
            BasicItemInfos = new HashSet<BasicItemInfo>();
            ItemData = new HashSet<ItemData>();
        }

        public long Id { get; set; }
        public int Base { get; set; }
        public int Total { get; set; }
        public int Sell { get; set; }
        public bool Purchasable { get; set; }

        public virtual ICollection<BasicItemInfo> BasicItemInfos { get; set; }
        public virtual ICollection<ItemData> ItemData { get; set; }
    }
}
