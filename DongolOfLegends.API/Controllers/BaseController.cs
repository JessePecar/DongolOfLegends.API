using DongolOfLegends.API.ApiHelpers.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DongolOfLegends.API.Controllers
{
    public class BaseController : ControllerBase
    {
        protected readonly ILeagueData LeagueData;

        public BaseController(ILeagueData leagueData)
        {
            LeagueData = leagueData ?? throw new ArgumentNullException(nameof(leagueData));
        }
    }
}
