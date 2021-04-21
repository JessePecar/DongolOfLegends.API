using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using DongolOfLegends.API.DAC.Entities;

#nullable disable

namespace DongolOfLegends.API.DAC.Context
{
    public partial class DongolXContext : DbContext
    {
        public DongolXContext(DbContextOptions<DongolXContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BasicItemInfo> BasicItemInfos { get; set; }
        public virtual DbSet<Champion> Champions { get; set; }
        public virtual DbSet<ChampionImage> ChampionImages { get; set; }
        public virtual DbSet<ChampionInfo> ChampionInfos { get; set; }
        public virtual DbSet<ChampionTag> ChampionTags { get; set; }
        public virtual DbSet<ChampionsRoot> ChampionsRoots { get; set; }
        public virtual DbSet<ChampionsStat> ChampionsStats { get; set; }
        public virtual DbSet<CreepDelta> CreepDeltas { get; set; }
        public virtual DbSet<DamageTakenDelta> DamageTakenDeltas { get; set; }
        public virtual DbSet<ExpDelta> ExpDeltas { get; set; }
        public virtual DbSet<GameModel> GameModels { get; set; }
        public virtual DbSet<GameType> GameTypes { get; set; }
        public virtual DbSet<GoldPerMinuteDelta> GoldPerMinuteDeltas { get; set; }
        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<ItemData> ItemDatas { get; set; }
        public virtual DbSet<ItemGold> ItemGolds { get; set; }
        public virtual DbSet<ItemGroup> ItemGroups { get; set; }
        public virtual DbSet<ItemImage> ItemImages { get; set; }
        public virtual DbSet<ItemInto> ItemIntos { get; set; }
        public virtual DbSet<ItemRune> ItemRunes { get; set; }
        public virtual DbSet<ItemStat> ItemStats { get; set; }
        public virtual DbSet<ItemTag> ItemTags { get; set; }
        public virtual DbSet<ItemTree> ItemTrees { get; set; }
        public virtual DbSet<ItemsEnabledMap> ItemsEnabledMaps { get; set; }
        public virtual DbSet<Map> Maps { get; set; }
        public virtual DbSet<MatchDetail> MatchDetails { get; set; }
        public virtual DbSet<MatchHistory> MatchHistories { get; set; }
        public virtual DbSet<MatchHistoryDetailed> MatchHistoryDetaileds { get; set; }
        public virtual DbSet<MatchParticipant> MatchParticipants { get; set; }
        public virtual DbSet<MatchParticipentIdentity> MatchParticipentIdentities { get; set; }
        public virtual DbSet<MatchPlayer> MatchPlayers { get; set; }
        public virtual DbSet<MatchStat> MatchStats { get; set; }
        public virtual DbSet<Queue> Queues { get; set; }
        public virtual DbSet<Season> Seasons { get; set; }
        public virtual DbSet<Summoner> Summoners { get; set; }
        public virtual DbSet<SummonerMatch> SummonerMatches { get; set; }
        public virtual DbSet<SummonerMatchesDetailed> SummonerMatchesDetaileds { get; set; }
        public virtual DbSet<Team> Teams { get; set; }
        public virtual DbSet<TeamBan> TeamBans { get; set; }
        public virtual DbSet<Timeline> Timelines { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<BasicItemInfo>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.HasIndex(e => e.GoldId, "IX_BasicItemInfos_GoldId");

                entity.HasIndex(e => e.MapsId, "IX_BasicItemInfos_MapsId");

                entity.HasIndex(e => e.RuneId, "IX_BasicItemInfos_RuneId");

                entity.HasIndex(e => e.StatsId, "IX_BasicItemInfos_StatsId");

                entity.HasOne(d => d.Gold)
                    .WithMany(p => p.BasicItemInfos)
                    .HasForeignKey(d => d.GoldId);

                entity.HasOne(d => d.Maps)
                    .WithMany(p => p.BasicItemInfos)
                    .HasForeignKey(d => d.MapsId);

                entity.HasOne(d => d.Rune)
                    .WithMany(p => p.BasicItemInfos)
                    .HasForeignKey(d => d.RuneId);

                entity.HasOne(d => d.Stats)
                    .WithMany(p => p.BasicItemInfos)
                    .HasForeignKey(d => d.StatsId);
            });

            modelBuilder.Entity<Champion>(entity =>
            {
                entity.HasKey(e => new { e.Key, e.Version })
                    .HasName("PK_Champions_1");

                entity.HasIndex(e => e.Id, "IX_Champions")
                    .IsUnique();

                entity.HasIndex(e => e.ImageId, "IX_Champions_ImageId");

                entity.HasIndex(e => e.InfoId, "IX_Champions_InfoId");

                entity.HasIndex(e => e.StatsId, "IX_Champions_StatsId");

                entity.Property(e => e.Version)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Image)
                    .WithMany(p => p.Champions)
                    .HasForeignKey(d => d.ImageId);

                entity.HasOne(d => d.Info)
                    .WithMany(p => p.Champions)
                    .HasForeignKey(d => d.InfoId);

                entity.HasOne(d => d.Stats)
                    .WithMany(p => p.Champions)
                    .HasForeignKey(d => d.StatsId);
            });

            modelBuilder.Entity<ChampionInfo>(entity =>
            {
                entity.ToTable("ChampionInfo");
            });

            modelBuilder.Entity<ChampionTag>(entity =>
            {
                entity.HasIndex(e => e.ChampionId, "IX_ChampionTags_ChampionId");

                entity.Property(e => e.ChampionId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Champion)
                    .WithMany(p => p.ChampionTags)
                    .HasPrincipalKey(p => p.Id)
                    .HasForeignKey(d => d.ChampionId)
                    .HasConstraintName("FK_ChampionTags_Champions");
            });

            modelBuilder.Entity<ChampionsRoot>(entity =>
            {
                entity.HasIndex(e => e.DataId, "IX_ChampionsRoots_DataId");
            });

            modelBuilder.Entity<DamageTakenDelta>(entity =>
            {
                entity.HasKey(e => e.TimelineId);

                entity.Property(e => e.TimelineId).ValueGeneratedOnAdd();

                entity.HasOne(d => d.Timeline)
                    .WithOne(p => p.DamageTakenDelta)
                    .HasForeignKey<DamageTakenDelta>(d => d.TimelineId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DamageTakenDeltas_Timelines");
            });

            modelBuilder.Entity<ExpDelta>(entity =>
            {
                entity.HasKey(e => e.TimelineId);

                entity.Property(e => e.TimelineId).ValueGeneratedOnAdd();

                entity.HasOne(d => d.Timeline)
                    .WithOne(p => p.ExpDelta)
                    .HasForeignKey<ExpDelta>(d => d.TimelineId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ExpDeltas_Timelines");
            });

            modelBuilder.Entity<GameType>(entity =>
            {
                entity.HasKey(e => e.GameType1);

                entity.Property(e => e.GameType1).HasColumnName("GameType");
            });

            modelBuilder.Entity<GoldPerMinuteDelta>(entity =>
            {
                entity.HasKey(e => e.TimelineId);

                entity.Property(e => e.TimelineId).ValueGeneratedOnAdd();

                entity.HasOne(d => d.Timeline)
                    .WithOne(p => p.GoldPerMinuteDelta)
                    .HasForeignKey<GoldPerMinuteDelta>(d => d.TimelineId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GoldPerMinuteDeltas_Timelines");
            });

            modelBuilder.Entity<Item>(entity =>
            {
                entity.HasKey(e => e.Version);

                entity.HasIndex(e => e.BasicCode, "IX_Items_BasicCode");

                entity.HasOne(d => d.BasicCodeNavigation)
                    .WithMany(p => p.Items)
                    .HasForeignKey(d => d.BasicCode);
            });

            modelBuilder.Entity<ItemData>(entity =>
            {
                entity.HasIndex(e => e.GoldId, "IX_ItemDatas_GoldId");

                entity.HasIndex(e => e.ImageId, "IX_ItemDatas_ImageId");

                entity.HasIndex(e => e.ItemsVersion, "IX_ItemDatas_ItemsVersion");

                entity.HasIndex(e => e.MapsGameMode, "IX_ItemDatas_MapsGameMode");

                entity.HasIndex(e => e.MatchStatsId, "IX_ItemDatas_MatchStatsId");

                entity.HasIndex(e => e.StatsId, "IX_ItemDatas_StatsId");

                entity.HasOne(d => d.Gold)
                    .WithMany(p => p.ItemData)
                    .HasForeignKey(d => d.GoldId);

                entity.HasOne(d => d.Image)
                    .WithMany(p => p.ItemData)
                    .HasForeignKey(d => d.ImageId);

                entity.HasOne(d => d.ItemsVersionNavigation)
                    .WithMany(p => p.ItemData)
                    .HasForeignKey(d => d.ItemsVersion);

                entity.HasOne(d => d.MapsGameModeNavigation)
                    .WithMany(p => p.ItemData)
                    .HasForeignKey(d => d.MapsGameMode);

                entity.HasOne(d => d.MatchStats)
                    .WithMany(p => p.ItemData)
                    .HasForeignKey(d => d.MatchStatsId);

                entity.HasOne(d => d.Stats)
                    .WithMany(p => p.ItemData)
                    .HasForeignKey(d => d.StatsId);
            });

            modelBuilder.Entity<ItemGroup>(entity =>
            {
                entity.HasIndex(e => e.ItemsVersion, "IX_ItemGroups_ItemsVersion");

                entity.HasOne(d => d.ItemsVersionNavigation)
                    .WithMany(p => p.ItemGroups)
                    .HasForeignKey(d => d.ItemsVersion);
            });

            modelBuilder.Entity<ItemInto>(entity =>
            {
                entity.ToTable("ItemInto");

                entity.HasIndex(e => e.ItemDataId, "IX_ItemInto_ItemDataId");

                entity.HasOne(d => d.ItemData)
                    .WithMany(p => p.ItemIntos)
                    .HasForeignKey(d => d.ItemDataId);
            });

            modelBuilder.Entity<ItemRune>(entity =>
            {
                entity.HasKey(e => e.ItemId);

                entity.Property(e => e.ItemId).ValueGeneratedOnAdd();

                entity.HasOne(d => d.Item)
                    .WithOne(p => p.ItemRune)
                    .HasForeignKey<ItemRune>(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ItemRunes_ItemDatas");
            });

            modelBuilder.Entity<ItemStat>(entity =>
            {
                entity.Property(e => e.FlatExpbonus).HasColumnName("FlatEXPBonus");

                entity.Property(e => e.FlatHppoolMod).HasColumnName("FlatHPPoolMod");

                entity.Property(e => e.FlatHpregenMod).HasColumnName("FlatHPRegenMod");

                entity.Property(e => e.FlatMppoolMod).HasColumnName("FlatMPPoolMod");

                entity.Property(e => e.FlatMpregenMod).HasColumnName("FlatMPRegenMod");

                entity.Property(e => e.PercentExpbonus).HasColumnName("PercentEXPBonus");

                entity.Property(e => e.PercentHppoolMod).HasColumnName("PercentHPPoolMod");

                entity.Property(e => e.PercentHpregenMod).HasColumnName("PercentHPRegenMod");

                entity.Property(e => e.PercentMppoolMod).HasColumnName("PercentMPPoolMod");

                entity.Property(e => e.PercentMpregenMod).HasColumnName("PercentMPRegenMod");

                entity.Property(e => e.RflatArmorModPerLevel).HasColumnName("RFlatArmorModPerLevel");

                entity.Property(e => e.RflatArmorPenetrationMod).HasColumnName("RFlatArmorPenetrationMod");

                entity.Property(e => e.RflatArmorPenetrationModPerLevel).HasColumnName("RFlatArmorPenetrationModPerLevel");

                entity.Property(e => e.RflatCritChanceModPerLevel).HasColumnName("RFlatCritChanceModPerLevel");

                entity.Property(e => e.RflatCritDamageModPerLevel).HasColumnName("RFlatCritDamageModPerLevel");

                entity.Property(e => e.RflatDodgeMod).HasColumnName("RFlatDodgeMod");

                entity.Property(e => e.RflatDodgeModPerLevel).HasColumnName("RFlatDodgeModPerLevel");

                entity.Property(e => e.RflatEnergyModPerLevel).HasColumnName("RFlatEnergyModPerLevel");

                entity.Property(e => e.RflatEnergyRegenModPerLevel).HasColumnName("RFlatEnergyRegenModPerLevel");

                entity.Property(e => e.RflatGoldPer10Mod).HasColumnName("RFlatGoldPer10Mod");

                entity.Property(e => e.RflatHpmodPerLevel).HasColumnName("RFlatHPModPerLevel");

                entity.Property(e => e.RflatHpregenModPerLevel).HasColumnName("RFlatHPRegenModPerLevel");

                entity.Property(e => e.RflatMagicDamageModPerLevel).HasColumnName("RFlatMagicDamageModPerLevel");

                entity.Property(e => e.RflatMagicPenetrationMod).HasColumnName("RFlatMagicPenetrationMod");

                entity.Property(e => e.RflatMagicPenetrationModPerLevel).HasColumnName("RFlatMagicPenetrationModPerLevel");

                entity.Property(e => e.RflatMovementSpeedModPerLevel).HasColumnName("RFlatMovementSpeedModPerLevel");

                entity.Property(e => e.RflatMpmodPerLevel).HasColumnName("RFlatMPModPerLevel");

                entity.Property(e => e.RflatMpregenModPerLevel).HasColumnName("RFlatMPRegenModPerLevel");

                entity.Property(e => e.RflatPhysicalDamageModPerLevel).HasColumnName("RFlatPhysicalDamageModPerLevel");

                entity.Property(e => e.RflatSpellBlockModPerLevel).HasColumnName("RFlatSpellBlockModPerLevel");

                entity.Property(e => e.RflatTimeDeadMod).HasColumnName("RFlatTimeDeadMod");

                entity.Property(e => e.RflatTimeDeadModPerLevel).HasColumnName("RFlatTimeDeadModPerLevel");

                entity.Property(e => e.RpercentArmorPenetrationMod).HasColumnName("RPercentArmorPenetrationMod");

                entity.Property(e => e.RpercentArmorPenetrationModPerLevel).HasColumnName("RPercentArmorPenetrationModPerLevel");

                entity.Property(e => e.RpercentAttackSpeedModPerLevel).HasColumnName("RPercentAttackSpeedModPerLevel");

                entity.Property(e => e.RpercentCooldownMod).HasColumnName("RPercentCooldownMod");

                entity.Property(e => e.RpercentCooldownModPerLevel).HasColumnName("RPercentCooldownModPerLevel");

                entity.Property(e => e.RpercentMagicPenetrationMod).HasColumnName("RPercentMagicPenetrationMod");

                entity.Property(e => e.RpercentMagicPenetrationModPerLevel).HasColumnName("RPercentMagicPenetrationModPerLevel");

                entity.Property(e => e.RpercentMovementSpeedModPerLevel).HasColumnName("RPercentMovementSpeedModPerLevel");

                entity.Property(e => e.RpercentTimeDeadMod).HasColumnName("RPercentTimeDeadMod");

                entity.Property(e => e.RpercentTimeDeadModPerLevel).HasColumnName("RPercentTimeDeadModPerLevel");
            });

            modelBuilder.Entity<ItemTag>(entity =>
            {
                entity.HasIndex(e => e.ItemDataId, "IX_ItemTags_ItemDataId");

                entity.HasIndex(e => e.ItemTreeId, "IX_ItemTags_ItemTreeId");

                entity.HasOne(d => d.ItemData)
                    .WithMany(p => p.ItemTags)
                    .HasForeignKey(d => d.ItemDataId);

                entity.HasOne(d => d.ItemTree)
                    .WithMany(p => p.ItemTags)
                    .HasForeignKey(d => d.ItemTreeId);
            });

            modelBuilder.Entity<ItemTree>(entity =>
            {
                entity.HasIndex(e => e.ItemsVersion, "IX_ItemTrees_ItemsVersion");

                entity.HasOne(d => d.ItemsVersionNavigation)
                    .WithMany(p => p.ItemTrees)
                    .HasForeignKey(d => d.ItemsVersion);
            });

            modelBuilder.Entity<ItemsEnabledMap>(entity =>
            {
                entity.HasKey(e => e.ItemId);

                entity.Property(e => e.ItemId).ValueGeneratedOnAdd();

                entity.HasOne(d => d.Item)
                    .WithOne(p => p.ItemsEnabledMap)
                    .HasForeignKey<ItemsEnabledMap>(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ItemsEnabledMaps_ItemDatas");
            });

            modelBuilder.Entity<Map>(entity =>
            {
                entity.HasKey(e => e.GameMode);
            });

            modelBuilder.Entity<MatchDetail>(entity =>
            {
                entity.HasKey(e => e.GameId);
            });

            modelBuilder.Entity<MatchHistory>(entity =>
            {
                entity.HasKey(e => e.GameId);

                entity.ToTable("MatchHistory");

                entity.HasIndex(e => e.SummonerMatchesId, "IX_MatchHistory_SummonerMatchesId");

                entity.HasOne(d => d.SummonerMatches)
                    .WithMany(p => p.MatchHistories)
                    .HasForeignKey(d => d.SummonerMatchesId);
            });

            modelBuilder.Entity<MatchHistoryDetailed>(entity =>
            {
                entity.ToTable("MatchHistoryDetailed");

                entity.HasIndex(e => e.ChampionId, "IX_MatchHistoryDetailed_ChampionId");

                entity.HasIndex(e => e.GameId, "IX_MatchHistoryDetailed_GameId");

                entity.HasIndex(e => e.SummonerMatchesDetailedId, "IX_MatchHistoryDetailed_SummonerMatchesDetailedId");

                entity.HasOne(d => d.Game)
                    .WithMany(p => p.MatchHistoryDetaileds)
                    .HasForeignKey(d => d.GameId);

                entity.HasOne(d => d.SummonerMatchesDetailed)
                    .WithMany(p => p.MatchHistoryDetaileds)
                    .HasForeignKey(d => d.SummonerMatchesDetailedId);
            });

            modelBuilder.Entity<MatchParticipant>(entity =>
            {
                entity.HasIndex(e => e.ChampionId1, "IX_MatchParticipants_ChampionId1");

                entity.HasIndex(e => e.MatchDetailsGameId, "IX_MatchParticipants_MatchDetailsGameId");

                entity.HasIndex(e => e.StatsId, "IX_MatchParticipants_StatsId");

                entity.HasIndex(e => e.TimelineId, "IX_MatchParticipants_TimelineId");

                entity.HasOne(d => d.MatchDetailsGame)
                    .WithMany(p => p.MatchParticipants)
                    .HasForeignKey(d => d.MatchDetailsGameId);

                entity.HasOne(d => d.Stats)
                    .WithMany(p => p.MatchParticipants)
                    .HasForeignKey(d => d.StatsId);

                entity.HasOne(d => d.Timeline)
                    .WithMany(p => p.MatchParticipants)
                    .HasForeignKey(d => d.TimelineId);
            });

            modelBuilder.Entity<MatchParticipentIdentity>(entity =>
            {
                entity.HasIndex(e => e.MatchDetailsGameId, "IX_MatchParticipentIdentities_MatchDetailsGameId");

                entity.HasIndex(e => e.PlayerId, "IX_MatchParticipentIdentities_PlayerId");

                entity.HasOne(d => d.MatchDetailsGame)
                    .WithMany(p => p.MatchParticipentIdentities)
                    .HasForeignKey(d => d.MatchDetailsGameId);

                entity.HasOne(d => d.Player)
                    .WithMany(p => p.MatchParticipentIdentities)
                    .HasForeignKey(d => d.PlayerId);
            });

            modelBuilder.Entity<MatchStat>(entity =>
            {
                entity.Property(e => e.TimeCcingOthers).HasColumnName("TimeCCingOthers");
            });

            modelBuilder.Entity<Season>(entity =>
            {
                entity.Property(e => e.Season1).HasColumnName("Season");
            });

            modelBuilder.Entity<Team>(entity =>
            {
                entity.HasIndex(e => e.MatchDetailsGameId, "IX_Teams_MatchDetailsGameId");

                entity.HasOne(d => d.MatchDetailsGame)
                    .WithMany(p => p.Teams)
                    .HasForeignKey(d => d.MatchDetailsGameId);
            });

            modelBuilder.Entity<TeamBan>(entity =>
            {
                entity.HasKey(e => e.BanId);

                entity.HasIndex(e => e.TeamId1, "IX_TeamBans_TeamId1");

                entity.HasOne(d => d.TeamId1Navigation)
                    .WithMany(p => p.TeamBans)
                    .HasForeignKey(d => d.TeamId1);
            });

            modelBuilder.Entity<Timeline>(entity =>
            {
                entity.HasIndex(e => e.CreepsPerMinDeltasId, "IX_Timelines_CreepsPerMinDeltasId");

                entity.HasIndex(e => e.DamageTakenPerMinDeltasId, "IX_Timelines_DamageTakenPerMinDeltasId");

                entity.HasIndex(e => e.GoldPerMinDeltasId, "IX_Timelines_GoldPerMinDeltasId");

                entity.HasIndex(e => e.XpPerMinDeltasId, "IX_Timelines_XpPerMinDeltasId");

                entity.HasOne(d => d.CreepsPerMinDeltas)
                    .WithMany(p => p.Timelines)
                    .HasForeignKey(d => d.CreepsPerMinDeltasId);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
