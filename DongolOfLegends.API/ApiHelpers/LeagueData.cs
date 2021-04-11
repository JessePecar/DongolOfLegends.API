using AutoMapper;
using DongolOfLegends.API.ApiHelpers.Contracts;
using DongolOfLegends.API.Models.Models;
using DongolOfLegends.API.Models.Models.Champions;
using DongolOfLegends.API.Models.Utility;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DongolOfLegends.API.ApiHelpers
{
    public class LeagueData : ILeagueData
    {
        private readonly IMemoryCache _cache;
        private readonly IClient _client;
        private readonly IMapper _mapper;
        public LeagueData(IMemoryCache cache, IClient client, IMapper mapper)
        {
            _cache = cache;
            _client = client;
            _mapper = mapper;
        }

        public string GetLatestVersion => GetVersions().FirstOrDefault();

        public Champion GetChampion(string championName)
        {
            IEnumerable<Champion> champions = new List<Champion>();
            if (!_cache.TryGetValue("championVersion", out string champVersion) || champVersion != GetLatestVersion || !_cache.TryGetValue("champions", out champions))
            {
                ChampionsRoot request = _client.GetRequestForItem<ChampionsRoot>(DataDragonValues.ChampionsGeneric.Replace("{patch}", GetLatestVersion));

                if (request != null)
                {
                    champions = GetChampionsFromData(request.Data);  //Save list of champions
                    _cache.Set("championVersion", GetLatestVersion);
                    _cache.Set("champions", champions);
                }

            }
            return champions.FirstOrDefault(c => c.Name == championName);
        }
        public Champion GetChampionById(int id)
        {
            IEnumerable<Champion> champions = new List<Champion>();
            if (!_cache.TryGetValue("championVersion", out string champVersion) || champVersion != GetLatestVersion || !_cache.TryGetValue("champions", out champions))
            {
                ChampionsRoot request = _client.GetRequestForItem<ChampionsRoot>(DataDragonValues.ChampionsGeneric.Replace("{patch}", GetLatestVersion));

                if (request != null)
                {
                    champions = GetChampionsFromData(request.Data);  //Save list of champions
                    _cache.Set("championVersion", GetLatestVersion);
                    _cache.Set("champions", champions);
                }

            }
            return champions.FirstOrDefault(c => int.Parse(c.Key) == id);
        }

        public IEnumerable<Champion> GetChampions()
        {
            //Check the cache, then check the version
            IEnumerable<Champion> champions = new List<Champion>();
            if (!_cache.TryGetValue("championVersion", out string champVersion) || champVersion != GetLatestVersion || !_cache.TryGetValue("champions", out champions))
            {
                ChampionsRoot request = _client.GetRequestForItem<ChampionsRoot>(DataDragonValues.ChampionsGeneric.Replace("{patch}", GetLatestVersion));

                if (request != null)
                {
                    champions = GetChampionsFromData(request.Data);  //Save list of champions
                    _cache.Set("championVersion", GetLatestVersion);
                    _cache.Set("champions", champions);
                }
            }

            return champions;
        }

        public IEnumerable<string> GetLanguages()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<string> GetRegions()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<string> GetVersions()
        {
            IEnumerable<string> versions = new List<string>();
            if (!_cache.TryGetValue("versionsAge", out DateTime versionAge) || versionAge < DateTime.Today || !_cache.TryGetValue("versions", out versions))
            {
                List<string> request = _client.GetRequestForList<string>(DataDragonValues.Versions);

                if (request != null)
                {
                    versions = request;
                    _cache.Set("versionsAge", DateTime.Now);
                    _cache.Set("versions", versions);
                }
            }

            return versions;
        }

        private IEnumerable<Champion> GetChampionsFromData(ChampionData data)
        {
            List<Champion> returnList = new List<Champion>();
            foreach (var champ in data.GetType().GetProperties())
            {
                returnList.Add(data.GetType().GetProperty(champ.Name).GetValue(data, null) as Champion);
            }
            return returnList.AsEnumerable();
        }

        public Summoner GetSummonerInfo(string summonerName)
        {
            Summoner summoner = new Summoner();
            if (!_cache.TryGetValue(summonerName, out summoner))
            {

            }
            
            return summoner;
        }
    }
}
