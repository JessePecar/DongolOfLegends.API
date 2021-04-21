using System;
using System.Collections.Generic;

#nullable disable

namespace DongolOfLegends.API.DAC.Entities
{
    public partial class Map
    {
        public Map()
        {
            ItemData = new HashSet<ItemData>();
        }

        public string GameMode { get; set; }
        public string Description { get; set; }

        public virtual ICollection<ItemData> ItemData { get; set; }
    }
}
