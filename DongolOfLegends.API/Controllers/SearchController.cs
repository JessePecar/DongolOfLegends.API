using DongolOfLegends.API.ApiHelpers.Contracts;
using Microsoft.AspNetCore.Mvc;
using PecTec.Riot.Core.Interfaces;
using PecTec.Riot.LoL.Interfaces;
using PecTec.Riot.LoL.Models.Champions.Specifics;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DongolOfLegends.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SearchController : BaseController
    {
        public SearchController(ILeagueData leagueData, IPecTecClient client, IStaticDataRetrieve data) : base(leagueData, client, data)
        {

        }

        [HttpGet]
        [Route("PlayerSearch/{userName}")]
        public IActionResult PlayerSearch(string userName)
        {
            try
            {
                return Ok(LeagueData.GetSummonerInfo(userName));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet]
        [Route("ChampionSearch/{championName}")]
        public IActionResult ChampionSearch(string championName)
        {
            try
            {
                ChampionSpecificDataModel champ = Data.RetrieveChampionByName(championName);
                return Ok(champ);
            }
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
                return Ok(Data.RetrieveChampions());
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
                return Ok(Data.RetrieveChampionById(id));
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
                return Ok(Data.RetrieveVersions());
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

                return Ok();
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
            return Ok(Data.RetrieveItemData());
        }
    }
}
