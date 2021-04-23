using DongolOfLegends.API.DAC.Context;
using DongolOfLegends.API.DAC.Entities;
using DongolOfLegends.API.DAC.Interfaces;
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
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool UpsertChampions(List<Champion> champions)
        {
            try
            {
                champions.ForEach(c =>
                {
                    Champion matchedChampion = GetChampionByNameAndVersion(c.Name, c.Version);
                    if (matchedChampion == null)
                    {
                        _context.Champions.Add(c);
                    }
                    else
                    {
                        //Update the matched champion
                        c.ImageId = matchedChampion.ImageId;
                        c.InfoId = matchedChampion.InfoId;
                        c.StatsId = matchedChampion.StatsId;
                        _context.Entry(matchedChampion).CurrentValues.SetValues(c);
                        _context.Entry(matchedChampion).State = EntityState.Modified;

                    }
                });

                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<Champion> GetChampionsByVersion(string version)
        {
            return _context.Champions
                    .Include(c => c.ChampionPassive).ThenInclude(cp => cp.Image)
                    .Include(c => c.ChampionSkins)
                    .Include(c => c.ChampionSpells).ThenInclude(cs => cs.Image)
                    .Include(c => c.ChampionSpells).ThenInclude(cs => cs.LevelTipCodeNavigation)
                    .Include(c => c.ChampionSpells).ThenInclude(cs => cs.SpellCooldownLinks)
                    .Include(c => c.ChampionSpells).ThenInclude(cs => cs.SpellCostLinks)
                    .Include(c => c.ChampionSpells).ThenInclude(cs => cs.SpellEffectBurnLinks)
                    .Include(c => c.ChampionSpells).ThenInclude(cs => cs.SpellEffectLinks)
                    .Include(c => c.ChampionSpells).ThenInclude(cs => cs.SpellRangeLinks)
                    .Include(c => c.ChampionTagsLinks).ThenInclude(ctl => ctl.TagCodeNavigation)
                    .Include(c => c.Image)
                    .Include(c => c.Info)
                    .Include(c => c.Stats)
                .Where(c => c.Version == version).ToList();
        }

        public Champion GetChampionByNameAndVersion(string name, string version)
        {
            return _context.Champions
                    .Include(c => c.ChampionPassive).ThenInclude(cp => cp.Image)
                    .Include(c => c.ChampionSkins)
                    .Include(c => c.ChampionSpells).ThenInclude(cs => cs.Image)
                    .Include(c => c.ChampionSpells).ThenInclude(cs => cs.LevelTipCodeNavigation)
                    .Include(c => c.ChampionSpells).ThenInclude(cs => cs.SpellCooldownLinks)
                    .Include(c => c.ChampionSpells).ThenInclude(cs => cs.SpellCostLinks)
                    .Include(c => c.ChampionSpells).ThenInclude(cs => cs.SpellEffectBurnLinks)
                    .Include(c => c.ChampionSpells).ThenInclude(cs => cs.SpellEffectLinks)
                    .Include(c => c.ChampionSpells).ThenInclude(cs => cs.SpellRangeLinks)
                    .Include(c => c.ChampionTagsLinks).ThenInclude(ctl => ctl.TagCodeNavigation)
                    .Include(c => c.Image)
                    .Include(c => c.Info)
                    .Include(c => c.Stats)
                    .FirstOrDefault(c => c.Name == name && c.Version == version);
        }
    }
}
