using System.ComponentModel.DataAnnotations;

namespace DongolOfLegends.API.Models.Models.MatchHistory
{
    public class TeamBans
    {
        [Key]
        public long BanId { get; set; }
        public int ChampionId { get; set; }
        
        public int TeamId { get; set; }
        
        public int GameId { get; set; }
        public string ChampionName { get; set; }
    }
}