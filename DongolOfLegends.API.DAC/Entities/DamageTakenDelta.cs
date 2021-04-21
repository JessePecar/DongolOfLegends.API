using System;
using System.Collections.Generic;

#nullable disable

namespace DongolOfLegends.API.DAC.Entities
{
    public partial class DamageTakenDelta
    {
        public long TimelineId { get; set; }
        public double _1020 { get; set; }
        public double _010 { get; set; }

        public virtual Timeline Timeline { get; set; }
    }
}
