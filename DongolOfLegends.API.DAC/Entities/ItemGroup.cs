using System;
using System.Collections.Generic;

#nullable disable

namespace DongolOfLegends.API.DAC.Entities
{
    public partial class ItemGroup
    {
        public string Id { get; set; }
        public string MaxGroupOwnable { get; set; }
        public string ItemsVersion { get; set; }

        public virtual Item ItemsVersionNavigation { get; set; }
    }
}
