using DongolOfLegends.API.ApiHelpers.Contracts;
using DongolOfLegends.API.Models.Models;
using DongolOfLegends.API.Models.Models.MatchHistory;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DongolOfLegends.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SearchController : BaseController
    {
        public SearchController(ILeagueData leagueData) :base(leagueData)
        {

        }

        [HttpGet]
        [Route("PlayerSearch/{userName}")]
        public IActionResult PlayerSearch(string userName)
        {
            return Ok(userName);
        }

        [HttpGet]
        [Route("ChampionSearch/{championName}")]
        public IActionResult ChampionSearch(string championName)
        {
            return Ok(LeagueData.GetChampion(championName));
        }

        [HttpGet]
        [Route("AllChampions")]
        public IActionResult AllChampions()
        {
            return Ok(LeagueData.GetChampions());
        }

        [HttpGet]
        [Route("ChampionById/{id}")]
        public IActionResult ChampionById(int id)
        {
            return Ok(LeagueData.GetChampionById(id));
        }

        [HttpGet]
        [Route("Versions")]
        public IActionResult Versions()
        {
            return Ok(LeagueData.GetVersions());
        }

        [HttpGet]
        [Route("MatchHistory/{summonerName}")]
        public IActionResult MatchHistory(string summonerName)
        {
            Summoner summoner = LeagueData.GetSummonerInfo(summonerName);
            SummonerMatches matches = LeagueData.GetMatchDetails(summoner.AccountId);

            return Ok(matches);
        }
    }
}
