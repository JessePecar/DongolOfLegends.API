using AutoMapper;
using DongolOfLegends.API.ApiHelpers.Contracts;
using DongolOfLegends.API.DAC.Interfaces;
using DongolOfLegends.API.Models.Models;
using DongolOfLegends.API.Models.Models.Champions;
using DongolOfLegends.API.Models.Models.Items;
using DongolOfLegends.API.Models.Models.MatchHistory;
using DongolOfLegends.API.Models.Utility;
using Microsoft.Extensions.Caching.Memory;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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
        private readonly IChampionRepository _championRepo;
        public LeagueData(IMemoryCache cache, IClient client, IMapper mapper, IChampionRepository championRepo)
        {
            _cache = cache;
            _client = client;
            _mapper = mapper;
            _championRepo = championRepo;
        }

        public string GetLatestVersion => GetVersions().FirstOrDefault();

        public Champion GetChampion(string championName)
        {
            return GetChampions().FirstOrDefault(c => c.Name == championName);
        }
        public Champion GetChampionById(int id)
        {
            
            return GetChampions()?.FirstOrDefault(c => c.Key == id);
        }

        public IEnumerable<Champion> GetChampions()
        {
            //Check the cache, then check the version
            IEnumerable<Champion> champions = _mapper.Map<IEnumerable<Champion>>(_championRepo.GetChampionsByVersion(GetLatestVersion));
            if(champions == null || !champions.Any())
            {
                //Save list of champions
                ChampionsRoot request = _client.GetRequestForItem<ChampionsRoot>(DataDragonValues.ChampionsGeneric.Replace("{patch}", GetLatestVersion));
                champions = request.Data.Select(d => d.Value);

                if (!_championRepo.SaveNewChampions(_mapper.Map<List<DAC.Entities.Champion>>(champions))) Console.WriteLine("Saving champions failed");
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

        public Summoner GetSummonerInfo(string summonerName)
        {
            Summoner summoner = GetDataFromCache(summonerName, () => _client.GetRequestForItem<Summoner>(RoutingValues.NA1, RiotRequests.SummonerInformation.Replace("{summonerName}", summonerName)));
            
            return summoner;
        }

        public SummonerMatches GetMatchDetails(string userId)
        {
            if(_cache.TryGetValue(userId, out DateTime expiration) && expiration < DateTime.Now.AddMinutes(-1))
            {
                return _cache.Get($"{userId}_matchHistory") as SummonerMatches;
            }

            SummonerMatches matchHistory = GetDataFromCache<SummonerMatches>($"{userId}_matchHistory", () => _client.GetRequestForItem<SummonerMatches>(RoutingValues.NA1, RiotRequests.MatchHistory.Replace("{accountId}", userId).Replace("{skipNum}", "0").Replace("{takeNum}", "10")));
            
            return matchHistory;
        }

        public MatchDetails GetGameDetailsById(long id)
        {
            MatchDetails matchDetails = new MatchDetails();

            matchDetails = _client.GetRequestForItem<MatchDetails>(RoutingValues.NA1, RiotRequests.MatchDetails.Replace("{matchId}", id.ToString()));
            
            return matchDetails;
        }

        public Items GetItemData()
        {
            string itemVersion = GetDataFromCache<string>("items_version", () => GetVersions().FirstOrDefault());
            
            Items items = GetDataFromCache<Items>("items", () => GetItems(), itemVersion != GetLatestVersion);

            return items;
        }

        private T GetDataFromCache<T>(string key, Func<T> populateData, bool ignoreCache = false)
        {
            if(!_cache.TryGetValue(key, out T cacheData) || cacheData == null || ignoreCache)
            {
                cacheData = populateData.Invoke();
                if(cacheData != null)
                {
                    _cache.Set(key, cacheData);
                }
            }

            return cacheData;
        }

        private IEnumerable<Champion> GetChampionsFromData(ChampionData data)
        {
            List<Champion> returnList = new List<Champion>();
            foreach (var champ in data.GetType().GetProperties().Where(d => d.Name != "Id"))
            {
                returnList.Add(data.GetType().GetProperty(champ.Name).GetValue(data, null) as Champion);
            }
            return returnList.AsEnumerable();
        }

        private List<ItemData> GetDataFromResponse(object response)
        {
            List<ItemData> itemData = new List<ItemData>();
            var item = (response as JObject)["data"];
            foreach(JToken data in item.AsEnumerable())
            {
                foreach(JToken dataItem in data.AsEnumerable())
                {
                    ItemData newItem = dataItem.ToObject<ItemData>();
                    newItem.Id = int.Parse(dataItem.Path.Replace("data.", ""));
                    itemData.Add(newItem);
                }
            }

            return itemData;
        }

        private Items GetItems()
        {
            object returnObject = _client.GetRequestForItem<object>(DataDragonValues.Items);
            string jsonObject = JsonConvert.SerializeObject(returnObject);
            Items items = JsonConvert.DeserializeObject<Items>(jsonObject);
            items.Data = GetDataFromResponse(returnObject);
            return items;
        }

    }
}
