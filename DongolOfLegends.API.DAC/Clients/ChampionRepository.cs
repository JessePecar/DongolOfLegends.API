using DongolOfLegends.API.DAC.Context;
using DongolOfLegends.API.DAC.Entities;
using DongolOfLegends.API.DAC.Interfaces;
using DongolOfLegends.API.Models.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DongolOfLegends.API.DAC.Clients
{
    public class ChampionRepository : IChampionRepository
    {
        private readonly DongolXContext _context;
        public ChampionRepository(IDbContextFactory<DongolXContext> contextFactory)
        {
            _context = contextFactory.CreateDbContext();
        }

        public bool SaveNewChampions(List<Champion> champions)
        {
            try
            {
                _context.Champions.AddRange(champions);
                _context.SaveChanges();

                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        public List<Champion> GetChampionsByVersion(string version)
        {
            return _context.Champions
                .Include(c => c.ChampionTags)
                .Include(c => c.Image)
                .Include(c => c.Info)
                .Include(c => c.Stats)
                .Where(c => c.Version == version).ToList();
        }
    }
}
