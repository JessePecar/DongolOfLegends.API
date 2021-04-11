using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace DongolOfLegends.API.Models.Models.MatchHistory
{
    public class GoldPerMinuteDeltas
    {
        [JsonProperty("10-20")]
        public double _1020 { get; set; }

        [JsonProperty("0-10")]
        public double _010 { get; set; }
    }
}
