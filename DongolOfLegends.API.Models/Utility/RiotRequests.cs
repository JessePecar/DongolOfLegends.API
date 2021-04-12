using System;
using System.Collections.Generic;
using System.Text;

namespace DongolOfLegends.API.Models.Utility
{
    public static class RiotRequests
    {
        public static string MatchHistory => "/lol/match/v4/matchlists/by-account/{accountId}";
        public static string SummonerInformation => "/lol/summoner/v4/summoners/by-name/{summonerName}";
    }
}
