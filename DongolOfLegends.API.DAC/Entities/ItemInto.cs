using System;
using System.Collections.Generic;

#nullable disable

namespace DongolOfLegends.API.DAC.Entities
{
    public partial class ItemInto
    {
        public long Id { get; set; }
        public string Into { get; set; }
        public long? ItemDataId { get; set; }

        public virtual ItemData ItemData { get; set; }
    }
}
