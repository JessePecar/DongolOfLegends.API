using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DongolOfLegends.API.ApiHelpers.Contracts
{
    public interface IClient
    {
        T GetRequestForItem<T>(string requestUrl);
        List<T> GetRequestForList<T>(string requestUrl);
    }
}
