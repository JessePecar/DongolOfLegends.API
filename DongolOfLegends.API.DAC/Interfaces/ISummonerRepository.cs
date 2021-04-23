using DongolOfLegends.API.DAC.Entities;
using System.Collections.Generic;

namespace DongolOfLegends.API.DAC.Interfaces
{
    public interface ISummonerRepository
    {
        List<Summoner> SummonerLookup(string summonerName);
        bool SaveNewSummoner(Summoner summoner);
    }
}
