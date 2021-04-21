using System;
using System.Collections.Generic;

#nullable disable

namespace DongolOfLegends.API.DAC.Entities
{
    public partial class ItemImage
    {
        public ItemImage()
        {
            ItemData = new HashSet<ItemData>();
        }

        public long Id { get; set; }
        public string Full { get; set; }
        public string Sprite { get; set; }
        public string Group { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int W { get; set; }
        public int H { get; set; }

        public virtual ICollection<ItemData> ItemData { get; set; }
    }
}
