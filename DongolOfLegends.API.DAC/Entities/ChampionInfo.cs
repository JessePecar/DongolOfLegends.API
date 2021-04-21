using System;
using System.Collections.Generic;

#nullable disable

namespace DongolOfLegends.API.DAC.Entities
{
    public partial class ChampionInfo
    {
        public ChampionInfo()
        {
            Champions = new HashSet<Champion>();
        }

        public long Id { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int Magic { get; set; }
        public int Difficulty { get; set; }

        public virtual ICollection<Champion> Champions { get; set; }
    }
}
