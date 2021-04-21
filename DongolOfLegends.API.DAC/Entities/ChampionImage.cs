using System;
using System.Collections.Generic;

#nullable disable

namespace DongolOfLegends.API.DAC.Entities
{
    public partial class ChampionImage
    {
        public ChampionImage()
        {
            Champions = new HashSet<Champion>();
        }

        public long Id { get; set; }
        public string Full { get; set; }
        public string Sprite { get; set; }
        public string Group { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int W { get; set; }
        public int H { get; set; }

        public virtual ICollection<Champion> Champions { get; set; }
    }
}
