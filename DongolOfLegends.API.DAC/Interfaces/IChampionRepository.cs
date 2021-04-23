using DongolOfLegends.API.DAC.Entities;
using System.Collections.Generic;

namespace DongolOfLegends.API.DAC.Interfaces
{
    public interface IChampionRepository
    {
        bool SaveNewChampions(List<Champion> champions);
        bool UpsertChampions(List<Champion> champions);
        List<Champion> GetChampionsByVersion(string version);
    }
}
