using AutoMapper;
using DongolOfLegends.API.ApiHelpers.Contracts;
using DongolOfLegends.API.DAC.Interfaces;
using DongolOfLegends.API.Models.Utility;
using Microsoft.Extensions.Caching.Memory;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using PecTec.Riot.LoL.Interfaces;
using PecTec.Riot.LoL.Models;
using PecTec.Riot.LoL.Models.Account;
using PecTec.Riot.LoL.Models.Account.MatchHistory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DongolOfLegends.API.ApiHelpers
{
    public class LeagueData : ILeagueData
    {
        private readonly IClient _client;
        private readonly IMapper _mapper;
        private readonly IChampionRepository _championRepo;
        private readonly ILiveDataRetrieve _liveData;
        private readonly IStaticDataRetrieve _data;
        private readonly ISummonerRepository _summonerRepo;
        public LeagueData(IClient client, IMapper mapper, IChampionRepository championRepo, ILiveDataRetrieve liveData, IStaticDataRetrieve data, ISummonerRepository summonerRepo)
        {
            _client = client;
            _mapper = mapper;
            _championRepo = championRepo;
            _liveData = liveData;
            _data = data;
            _summonerRepo = summonerRepo;
        }

        public string GetLatestVersion => _data.RetrieveVersions().LatestVersion;

        public Summoner GetSummonerInfo(string summonerName)
        {
            //Try and grab summoner from database
            string searchSummoner = summonerName.Replace(" ", string.Empty).ToLower();

            List<DAC.Entities.Summoner> summonersReturned = _summonerRepo.SummonerLookup(searchSummoner);
            if(summonersReturned == null)
            {
                // Grab from riot apis
                Summoner summoner = _liveData.RetrieveSummonerByName(Regions.NA1, searchSummoner);

                //Save the summoner into the database
                _summonerRepo.SaveNewSummoner(_mapper.Map<DAC.Entities.Summoner>(summoner));
                return summoner;
            }
            // On summoner returned from the database, will now use that
            return _mapper.Map<Summoner>(summonersReturned.FirstOrDefault());    
        }

        public List<string> GetMatchListByPuuid(string puuid)
        {
            return default;
        }

        public MatchData GetGameDetailsById(string matchId)
        {
            return default;
        }
    }
}
