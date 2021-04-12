using System;
using System.Collections.Generic;
using System.Text;

namespace DongolOfLegends.API.Models.Utility
{
    public static class RiotRequests
    {
        public static string MatchHistory => "/lol/match/v4/matchlists/by-account/{accountId}?endIndex={takeNum}&beginIndex={skipNum}";
        public static string SummonerInformation => "/lol/summoner/v4/summoners/by-name/{summonerName}";
        public static string MatchDetails => "/lol/match/v4/matches/{matchId}";
    }
}
