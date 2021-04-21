using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DongolOfLegends.API.Models.Models.MatchHistory
{
    public class SummonerMatchesDetailed
    {
        [Key]
        public long Id { get; set; }
        public List<MatchHistoryDetailed> DetailedMatches { get; set; }
        public string PlayerName { get; set; }
    }
}
