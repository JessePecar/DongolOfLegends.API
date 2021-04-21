using DongolOfLegends.API.Models.Models;
using DongolOfLegends.API.Models.Models.Champions;
using DongolOfLegends.API.Models.Models.Items;
using DongolOfLegends.API.Models.Models.MatchHistory;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace DongolOfLegends.API.Models.Context
{
    public class DongolContext : DbContext
    {
        private readonly IConfiguration _configuration;
        public DongolContext(DbContextOptions<DongolContext> options, IConfiguration configuration) : base(options)
        {
            _configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer(_configuration["Global:ConnectionStrings:DONGOLX"], options =>
            {
                
            });
        }

        #region Champions

        public DbSet<Champion> Champions { get; set; }
        public DbSet<ChampionTags> ChampionTags { get; set; }
        public DbSet<ChampionImage> ChampionImages { get; set; }
        public DbSet<ChampionInfo> ChampionInfo { get; set; }
        public DbSet<ChampionsRoot> ChampionsRoots { get; set; }
        public DbSet<ChampionStats> ChampionsStats { get; set; }

        #endregion

        #region Items

        public DbSet<BasicItemInfo> BasicItemInfos { get; set; }
        public DbSet<ItemData> ItemDatas { get; set; }
        public DbSet<ItemGold> ItemGolds { get; set; }
        public DbSet<ItemGroup> ItemGroups { get; set; }
        public DbSet<ItemImage> ItemImages { get; set; }
        public DbSet<ItemRune> ItemRunes{ get; set; }
        public DbSet<Items> Items { get; set; }
        public DbSet<ItemsEnabledMaps> ItemsEnabledMaps { get; set; }
        public DbSet<ItemStats> ItemStats { get; set; }
        public DbSet<ItemTree> ItemTrees { get; set; }
        public DbSet<ItemTags> ItemTags { get; set; }
        public DbSet<ItemInto> ItemInto { get; set; }

        #endregion

        #region MatchHistory

        public DbSet<CreepDeltas> CreepDeltas { get; set; }
        public DbSet<DamageTakenDeltas> DamageTakenDeltas { get; set; }
        public DbSet<ExpDeltas> ExpDeltas { get; set; }
        public DbSet<GameModel> GameModels { get; set; }
        public DbSet<GoldPerMinuteDeltas> GoldPerMinuteDeltas { get; set; }
        public DbSet<MatchDetails> MatchDetails{ get; set; }
        public DbSet<MatchHistoryDetailed> MatchHistoryDetailed{ get; set; }
        public DbSet<MatchParticipant> MatchParticipants { get; set; }
        public DbSet<MatchParticipantIdentity> MatchParticipentIdentities{ get; set; }
        public DbSet<MatchPlayer> MatchPlayers{ get; set; }
        public DbSet<MatchStats> MatchStats{ get; set; }
        public DbSet<SummonerMatches> SummonerMatches{ get; set; }
        public DbSet<SummonerMatchesDetailed> SummonerMatchesDetaileds{ get; set; }
        public DbSet<Team> Teams{ get; set; }
        public DbSet<TeamBans> TeamBans { get; set; }
        public DbSet<Timeline> Timelines{ get; set; }
        #endregion

        public DbSet<GameTypes> GameTypes { get; set; }
        public DbSet<Maps> Maps { get; set; }
        public DbSet<Queues> Queues { get; set; }
        public DbSet<Seasons> Seasons { get; set; }
        public DbSet<Summoner> Summoners { get; set; }
    }
}
