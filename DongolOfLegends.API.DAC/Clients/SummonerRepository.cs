using DongolOfLegends.API.DAC.Context;
using DongolOfLegends.API.DAC.Entities;
using DongolOfLegends.API.DAC.Interfaces;
using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace DongolOfLegends.API.DAC.Clients
{
    public class SummonerRepository : ISummonerRepository
    {
        private readonly DongolXContext _context;
        public SummonerRepository(IDbContextFactory<DongolXContext> contextFactory)
        {
            _context = contextFactory.CreateDbContext();
        }

        public List<Summoner> SummonerLookup(string summonerName)
        {
            try
            {
                return _context.Summoners.Where(s => s.Name.Replace(" ", string.Empty).ToLower() == summonerName).ToList();
            }
            catch(Exception ex)
            {
                return null;
            }
        }

        public bool SaveNewSummoner(Summoner summoner)
        {
            try
            {
                _context.Summoners.Add(summoner);
                _context.SaveChanges();
                return true;
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return false;
            }
        }
    }
}
