using System;
using System.Collections.Generic;

#nullable disable

namespace DongolOfLegends.API.DAC.Entities
{
    public partial class ItemTag
    {
        public long Id { get; set; }
        public string Tag { get; set; }
        public long? ItemDataId { get; set; }
        public long? ItemTreeId { get; set; }

        public virtual ItemData ItemData { get; set; }
        public virtual ItemTree ItemTree { get; set; }
    }
}
