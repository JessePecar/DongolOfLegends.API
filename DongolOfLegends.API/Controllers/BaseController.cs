using AutoMapper;
using DongolOfLegends.API.ApiHelpers.Contracts;
using DongolOfLegends.API.DAC.Interfaces;
using Microsoft.AspNetCore.Mvc;
using PecTec.Riot.Core.Interfaces;
using PecTec.Riot.LoL.Interfaces;
using System;

namespace DongolOfLegends.API.Controllers
{
    public class BaseController : ControllerBase
    {
        protected readonly IMapper Mapper;
        protected readonly ILeagueData LeagueData;
        protected readonly IPecTecClient Client;
        protected readonly IStaticDataRetrieve Data;
        protected readonly IChampionRepository ChampRepo;

        public BaseController(IMapper mapper, ILeagueData leagueData, IPecTecClient client, IStaticDataRetrieve data, IChampionRepository champRepo)
        {
            Mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            LeagueData = leagueData ?? throw new ArgumentNullException(nameof(leagueData));
            Client = client ?? throw new ArgumentNullException(nameof(client));
            Data = data ?? throw new ArgumentNullException(nameof(data));
            ChampRepo = champRepo ?? throw new ArgumentNullException(nameof(champRepo));
        }
    }
}
