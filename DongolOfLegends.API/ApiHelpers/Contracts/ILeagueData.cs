using DongolOfLegends.API.Models.Models;
using DongolOfLegends.API.Models.Models.Champions;
using DongolOfLegends.API.Models.Models.MatchHistory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DongolOfLegends.API.ApiHelpers.Contracts
{
    public interface ILeagueData
    {
        string GetLatestVersion { get; }
        IEnumerable<string> GetRegions();
        IEnumerable<string> GetVersions();
        IEnumerable<string> GetLanguages();
        IEnumerable<Champion> GetChampions();
        Champion GetChampion(string championName);
        Champion GetChampionById(int id);
        Summoner GetSummonerInfo(string summonerName);
        SummonerMatches GetMatchDetails(string userId);
    }
}
