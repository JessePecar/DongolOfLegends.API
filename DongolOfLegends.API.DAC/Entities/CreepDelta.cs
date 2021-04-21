using System;
using System.Collections.Generic;

#nullable disable

namespace DongolOfLegends.API.DAC.Entities
{
    public partial class CreepDelta
    {
        public CreepDelta()
        {
            Timelines = new HashSet<Timeline>();
        }

        public long Id { get; set; }
        public double _1020 { get; set; }
        public double _010 { get; set; }

        public virtual ICollection<Timeline> Timelines { get; set; }
    }
}
