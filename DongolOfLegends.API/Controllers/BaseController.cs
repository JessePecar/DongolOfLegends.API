using DongolOfLegends.API.ApiHelpers.Contracts;
using Microsoft.AspNetCore.Mvc;
using PecTec.Riot.Core.Interfaces;
using PecTec.Riot.LoL.Interfaces;
using System;

namespace DongolOfLegends.API.Controllers
{
    public class BaseController : ControllerBase
    {
        protected readonly ILeagueData LeagueData;
        protected readonly IPecTecClient Client;
        protected readonly IStaticDataRetrieve Data;
        protected readonly ILiveDataRetrieve LiveData;

        public BaseController(ILeagueData leagueData, IPecTecClient client, IStaticDataRetrieve data, ILiveDataRetrieve liveData)
        {
            LeagueData = leagueData ?? throw new ArgumentNullException(nameof(leagueData));
            Client = client ?? throw new ArgumentNullException(nameof(client));
            Data = data ?? throw new ArgumentNullException(nameof(data));
            LiveData = liveData ?? throw new ArgumentNullException(nameof(liveData));
        }
    }
}
