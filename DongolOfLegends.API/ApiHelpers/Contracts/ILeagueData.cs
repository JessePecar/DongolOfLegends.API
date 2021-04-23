
using PecTec.Riot.LoL.Models.Account;
using PecTec.Riot.LoL.Models.Account.MatchHistory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DongolOfLegends.API.ApiHelpers.Contracts
{
    public interface ILeagueData
    {
        string GetLatestVersion { get; }
        Summoner GetSummonerInfo(string summonerName);
        List<string> GetMatchListByPuuid(string puuid);
        MatchData GetGameDetailsById(string matchId);
    }
}
