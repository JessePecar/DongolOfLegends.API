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
        public SearchController(ILeagueData leagueData) : base(leagueData)
        {

        }

        [HttpGet]
        [Route("PlayerSearch/{userName}")]
        public IActionResult PlayerSearch(string userName)
        {
            try { return Ok(userName); }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet]
        [Route("ChampionSearch/{championName}")]
        public IActionResult ChampionSearch(string championName)
        {
            try { return Ok(LeagueData.GetChampion(championName)); }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet]
        [Route("AllChampions")]
        public IActionResult AllChampions()
        {
            try
            {
                return Ok(LeagueData.GetChampions());
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet]
        [Route("ChampionById/{id}")]
        public IActionResult ChampionById(int id)
        {
            try
            {
                return Ok(LeagueData.GetChampionById(id));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet]
        [Route("Versions")]
        public IActionResult Versions()
        {
            try
            {
                return Ok(LeagueData.GetVersions());
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        /// <summary>
        /// Gives the game (1 being most recent) based on the user and the number given
        /// </summary>
        /// <param name="summonerName"></param>
        /// <param name="gameNumber"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("MatchHistory/{summonerName}")]
        public IActionResult MatchHistory(string summonerName)
        {
            try
            {
                Summoner summoner = LeagueData.GetSummonerInfo(summonerName);
                SummonerMatches matches = LeagueData.GetMatchDetails(summoner.AccountId);
                SummonerMatchesDetailed detailedMatches = new SummonerMatchesDetailed()
                {
                    DetailedMatches = matches.Matches.Select(m => new MatchHistoryDetailed
                    {
                        Lane = m.Lane,
                        PlatformId = m.PlatformId,
                        Queue = m.Queue,
                        Role = m.Role,
                        Season = m.Season,
                        Timestamp = m.Timestamp,
                        Game = LeagueData.GetGameDetailsById(m.GameId),
                        Champion = LeagueData.GetChampionById(m.Champion),
                        AccountId = summoner.AccountId
                    }).ToList()
                };

                detailedMatches.DetailedMatches = detailedMatches.DetailedMatches.Select(dm =>
                {
                    dm.Game.Participants = dm.Game.Participants.Select(p => { p.Champion = LeagueData.GetChampionById(p.ChampionId); return p; }).ToList();
                    dm.Game.Participants.ForEach(p =>
                    {
                        p.Stats.Items = new List<Models.Models.Items.ItemData>()
                        {
                            LeagueData.GetItemData().Data.FirstOrDefault(d => d.Id == p.Stats.Item0),
                            LeagueData.GetItemData().Data.FirstOrDefault(d => d.Id == p.Stats.Item1),
                            LeagueData.GetItemData().Data.FirstOrDefault(d => d.Id == p.Stats.Item2),
                            LeagueData.GetItemData().Data.FirstOrDefault(d => d.Id == p.Stats.Item3),
                            LeagueData.GetItemData().Data.FirstOrDefault(d => d.Id == p.Stats.Item4),
                            LeagueData.GetItemData().Data.FirstOrDefault(d => d.Id == p.Stats.Item5),
                            LeagueData.GetItemData().Data.FirstOrDefault(d => d.Id == p.Stats.Item6)
                        };
                    });
                    return dm;
                }).ToList();

                return Ok(detailedMatches);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }


        [HttpGet]
        [Route("Items")]
        public IActionResult Items()
        {
            return Ok(LeagueData.GetItemData());
        }
    }
}
