using System;
using System.Collections.Generic;

#nullable disable

namespace DongolOfLegends.API.DAC.Entities
{
    public partial class ChampionsRoot
    {
        public long Id { get; set; }
        public string Type { get; set; }
        public string Format { get; set; }
        public string Version { get; set; }
        public int? DataId { get; set; }
    }
}
