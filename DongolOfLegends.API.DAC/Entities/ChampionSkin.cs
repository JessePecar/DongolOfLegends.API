using System;
using System.Collections.Generic;

#nullable disable

namespace DongolOfLegends.API.DAC.Entities
{
    public partial class ChampionSkin
    {
        public string Code { get; set; }
        public int Number { get; set; }
        public string Name { get; set; }
        public string HasChromas { get; set; }
        public long ChampionId { get; set; }
        public string Version { get; set; }

        public virtual Champion Champion { get; set; }
    }
}
