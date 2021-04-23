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

        public virtual DbSet<Champion> Champions { get; set; }
        public virtual DbSet<ChampionImage> ChampionImages { get; set; }
        public virtual DbSet<ChampionInfo> ChampionInfos { get; set; }
        public virtual DbSet<ChampionPassive> ChampionPassives { get; set; }
        public virtual DbSet<ChampionSkin> ChampionSkins { get; set; }
        public virtual DbSet<ChampionSpell> ChampionSpells { get; set; }
        public virtual DbSet<ChampionStat> ChampionStats { get; set; }
        public virtual DbSet<ChampionTag> ChampionTags { get; set; }
        public virtual DbSet<ChampionTagsLink> ChampionTagsLinks { get; set; }
        public virtual DbSet<ChampionTip> ChampionTips { get; set; }
        public virtual DbSet<SpellCooldownLink> SpellCooldownLinks { get; set; }
        public virtual DbSet<SpellCostLink> SpellCostLinks { get; set; }
        public virtual DbSet<SpellEffectBurnLink> SpellEffectBurnLinks { get; set; }
        public virtual DbSet<SpellEffectLink> SpellEffectLinks { get; set; }
        public virtual DbSet<SpellLevel> SpellLevels { get; set; }
        public virtual DbSet<SpellLevelTip> SpellLevelTips { get; set; }
        public virtual DbSet<SpellRangeLink> SpellRangeLinks { get; set; }
        public virtual DbSet<Summoner> Summoners { get; set; }
        public virtual DbSet<TipType> TipTypes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                throw new InvalidOperationException("Options were not setup up for DongolX");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Champion>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Version });

                entity.ToTable("Champion");

                entity.Property(e => e.Version)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Blurb)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.ImageId).HasColumnName("Image_Id");

                entity.Property(e => e.InfoId).HasColumnName("Info_Id");

                entity.Property(e => e.Lore)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Partype)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RiotId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Riot_Id");

                entity.Property(e => e.StatsId).HasColumnName("Stats_Id");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Image)
                    .WithMany(p => p.Champions)
                    .HasForeignKey(d => d.ImageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Champion_Champion_Image");

                entity.HasOne(d => d.Info)
                    .WithMany(p => p.Champions)
                    .HasForeignKey(d => d.InfoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Champion_Champion_Info");

                entity.HasOne(d => d.Stats)
                    .WithMany(p => p.Champions)
                    .HasForeignKey(d => d.StatsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Champion_Champion_Stats");
            });

            modelBuilder.Entity<ChampionImage>(entity =>
            {
                entity.ToTable("Champion_Image");

                entity.Property(e => e.FullImageName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Full_Image_Name");

                entity.Property(e => e.Group)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HValue).HasColumnName("H_Value");

                entity.Property(e => e.ImageHref)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Image_Href");

                entity.Property(e => e.Sprite)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WValue).HasColumnName("W_Value");

                entity.Property(e => e.XValue).HasColumnName("X_Value");

                entity.Property(e => e.YValue).HasColumnName("Y_Value");
            });

            modelBuilder.Entity<ChampionInfo>(entity =>
            {
                entity.ToTable("Champion_Info");

                entity.Property(e => e.AttackLevel)
                    .HasColumnType("decimal(5, 2)")
                    .HasColumnName("Attack_Level");

                entity.Property(e => e.DefenseLevel)
                    .HasColumnType("decimal(5, 2)")
                    .HasColumnName("Defense_Level");

                entity.Property(e => e.Difficulty).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.MagicLevel)
                    .HasColumnType("decimal(5, 2)")
                    .HasColumnName("Magic_Level");
            });

            modelBuilder.Entity<ChampionPassive>(entity =>
            {
                entity.HasKey(e => new { e.ChampionId, e.Version });

                entity.ToTable("Champion_Passive");

                entity.Property(e => e.ChampionId).HasColumnName("Champion_Id");

                entity.Property(e => e.Version)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.ImageId).HasColumnName("Image_Id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Image)
                    .WithMany(p => p.ChampionPassives)
                    .HasForeignKey(d => d.ImageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Champion_Passive_Champion_Image");

                entity.HasOne(d => d.Champion)
                    .WithOne(p => p.ChampionPassive)
                    .HasForeignKey<ChampionPassive>(d => new { d.ChampionId, d.Version })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Champion_Passive_Champion");
            });

            modelBuilder.Entity<ChampionSkin>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.ToTable("Champion_Skins");

                entity.Property(e => e.Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ChampionId).HasColumnName("Champion_Id");

                entity.Property(e => e.HasChromas)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("Has_Chromas");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.Champion)
                    .WithMany(p => p.ChampionSkins)
                    .HasForeignKey(d => new { d.ChampionId, d.Version })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Champion_Skins_Champion");
            });

            modelBuilder.Entity<ChampionSpell>(entity =>
            {
                entity.ToTable("Champion_Spells");

                entity.Property(e => e.ChampionId).HasColumnName("Champion_Id");

                entity.Property(e => e.CooldownBurn)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Cooldown_Burn");

                entity.Property(e => e.CostBurn)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Cost_Burn");

                entity.Property(e => e.CostType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Cost_Type");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.ImageId).HasColumnName("Image_Id");

                entity.Property(e => e.LevelTipCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Level_Tip_Code");

                entity.Property(e => e.MaxAmmo).HasColumnName("Max_Ammo");

                entity.Property(e => e.MaxRank).HasColumnName("Max_Rank");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RangeBurn)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Range_Burn");

                entity.Property(e => e.Resource)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tooltip)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.Image)
                    .WithMany(p => p.ChampionSpells)
                    .HasForeignKey(d => d.ImageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Champion_Spells_Champion_Image");

                entity.HasOne(d => d.LevelTipCodeNavigation)
                    .WithMany(p => p.ChampionSpells)
                    .HasForeignKey(d => d.LevelTipCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Champion_Spells_Spell_Level_Tip");

                entity.HasOne(d => d.Champion)
                    .WithMany(p => p.ChampionSpells)
                    .HasForeignKey(d => new { d.ChampionId, d.Version })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Champion_Spells_Champion");
            });

            modelBuilder.Entity<ChampionStat>(entity =>
            {
                entity.ToTable("Champion_Stats");

                entity.Property(e => e.Armor).HasColumnType("decimal(7, 2)");

                entity.Property(e => e.ArmorPerLevel)
                    .HasColumnType("decimal(7, 2)")
                    .HasColumnName("Armor_Per_Level");

                entity.Property(e => e.AttackDamage)
                    .HasColumnType("decimal(7, 2)")
                    .HasColumnName("Attack_Damage");

                entity.Property(e => e.AttackDamagePerLevel)
                    .HasColumnType("decimal(7, 2)")
                    .HasColumnName("Attack_Damage_Per_Level");

                entity.Property(e => e.AttackRange)
                    .HasColumnType("decimal(7, 2)")
                    .HasColumnName("Attack_Range");

                entity.Property(e => e.AttackSpeed)
                    .HasColumnType("decimal(7, 2)")
                    .HasColumnName("Attack_Speed");

                entity.Property(e => e.AttackSpeedPerLevel)
                    .HasColumnType("decimal(7, 2)")
                    .HasColumnName("Attack_Speed_Per_Level");

                entity.Property(e => e.CriticalStrike)
                    .HasColumnType("decimal(7, 2)")
                    .HasColumnName("Critical_Strike");

                entity.Property(e => e.CriticalStrikePerLevel)
                    .HasColumnType("decimal(7, 2)")
                    .HasColumnName("Critical_Strike_Per_Level");

                entity.Property(e => e.Hp)
                    .HasColumnType("decimal(7, 2)")
                    .HasColumnName("HP");

                entity.Property(e => e.HpPerLevel)
                    .HasColumnType("decimal(7, 2)")
                    .HasColumnName("HP_Per_Level");

                entity.Property(e => e.HpRegen)
                    .HasColumnType("decimal(7, 2)")
                    .HasColumnName("HP_Regen");

                entity.Property(e => e.HpRegenPerLevel)
                    .HasColumnType("decimal(7, 2)")
                    .HasColumnName("HP_Regen_Per_Level");

                entity.Property(e => e.MagicResist)
                    .HasColumnType("decimal(7, 2)")
                    .HasColumnName("Magic_Resist");

                entity.Property(e => e.MagicResistPerLevel)
                    .HasColumnType("decimal(7, 2)")
                    .HasColumnName("Magic_Resist_Per_Level");

                entity.Property(e => e.Mana).HasColumnType("decimal(7, 2)");

                entity.Property(e => e.ManaPerLevel)
                    .HasColumnType("decimal(7, 2)")
                    .HasColumnName("Mana_Per_Level");

                entity.Property(e => e.ManaRegen)
                    .HasColumnType("decimal(7, 2)")
                    .HasColumnName("Mana_Regen");

                entity.Property(e => e.ManaRegenPerLevel)
                    .HasColumnType("decimal(7, 2)")
                    .HasColumnName("Mana_Regen_Per_Level");

                entity.Property(e => e.MovementSpeed)
                    .HasColumnType("decimal(7, 2)")
                    .HasColumnName("Movement_Speed");
            });

            modelBuilder.Entity<ChampionTag>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.ToTable("Champion_Tags");

                entity.Property(e => e.Code)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ChampionTagsLink>(entity =>
            {
                entity.HasKey(e => new { e.ChampionId, e.TagCode, e.ChampionVersion });

                entity.ToTable("Champion_Tags_Link");

                entity.Property(e => e.ChampionId).HasColumnName("Champion_Id");

                entity.Property(e => e.TagCode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("Tag_Code");

                entity.Property(e => e.ChampionVersion)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Champion_Version");

                entity.HasOne(d => d.TagCodeNavigation)
                    .WithMany(p => p.ChampionTagsLinks)
                    .HasForeignKey(d => d.TagCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Champion_Tags_Link_Champion_Tags");

                entity.HasOne(d => d.Champion)
                    .WithMany(p => p.ChampionTagsLinks)
                    .HasForeignKey(d => new { d.ChampionId, d.ChampionVersion })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Champion_Tags_Link_Champion");
            });

            modelBuilder.Entity<ChampionTip>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Champion_Tips");

                entity.Property(e => e.ChampionId).HasColumnName("Champion_Id");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.TipType)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("Tip_Type");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.TipTypeNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.TipType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Champion_Tips_Tip_Types");

                entity.HasOne(d => d.Champion)
                    .WithMany()
                    .HasForeignKey(d => new { d.ChampionId, d.Version })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Champion_Tips_Champion");
            });

            modelBuilder.Entity<SpellCooldownLink>(entity =>
            {
                entity.HasKey(e => new { e.SpellId, e.SpellLevel });

                entity.ToTable("Spell_Cooldown_Link");

                entity.Property(e => e.SpellId).HasColumnName("Spell_Id");

                entity.Property(e => e.SpellLevel).HasColumnName("Spell_Level");

                entity.Property(e => e.Cooldown).HasColumnType("decimal(9, 2)");

                entity.HasOne(d => d.Spell)
                    .WithMany(p => p.SpellCooldownLinks)
                    .HasForeignKey(d => d.SpellId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Spell_Cooldown_Link_Champion_Spells");

                entity.HasOne(d => d.SpellLevelNavigation)
                    .WithMany(p => p.SpellCooldownLinks)
                    .HasForeignKey(d => d.SpellLevel)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Spell_Cooldown_Link_Spell_Levels");
            });

            modelBuilder.Entity<SpellCostLink>(entity =>
            {
                entity.HasKey(e => new { e.SpellId, e.SpellLevel });

                entity.ToTable("Spell_Cost_Link");

                entity.Property(e => e.SpellId).HasColumnName("Spell_Id");

                entity.Property(e => e.SpellLevel).HasColumnName("Spell_Level");

                entity.HasOne(d => d.Spell)
                    .WithMany(p => p.SpellCostLinks)
                    .HasForeignKey(d => d.SpellId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Spell_Cost_Link_Champion_Spells");

                entity.HasOne(d => d.SpellLevelNavigation)
                    .WithMany(p => p.SpellCostLinks)
                    .HasForeignKey(d => d.SpellLevel)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Spell_Cost_Link_Spell_Levels");
            });

            modelBuilder.Entity<SpellEffectBurnLink>(entity =>
            {
                entity.HasKey(e => new { e.SpellId, e.SpellLevel });

                entity.ToTable("Spell_Effect_Burn_Link");

                entity.Property(e => e.SpellId).HasColumnName("Spell_Id");

                entity.Property(e => e.SpellLevel).HasColumnName("Spell_Level");

                entity.Property(e => e.EffectBurn)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Effect_Burn");

                entity.HasOne(d => d.Spell)
                    .WithMany(p => p.SpellEffectBurnLinks)
                    .HasForeignKey(d => d.SpellId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Spell_Effect_Burn_Link_Champion_Spells");

                entity.HasOne(d => d.SpellLevelNavigation)
                    .WithMany(p => p.SpellEffectBurnLinks)
                    .HasForeignKey(d => d.SpellLevel)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Spell_Effect_Burn_Link_Spell_Levels");
            });

            modelBuilder.Entity<SpellEffectLink>(entity =>
            {
                entity.HasKey(e => new { e.SpellId, e.EffectId, e.SpellLevel });

                entity.ToTable("Spell_Effect_Link");

                entity.Property(e => e.SpellId).HasColumnName("Spell_Id");

                entity.Property(e => e.EffectId).HasColumnName("Effect_Id");

                entity.Property(e => e.SpellLevel).HasColumnName("Spell_Level");

                entity.Property(e => e.EffectValue)
                    .HasColumnType("decimal(9, 2)")
                    .HasColumnName("Effect_Value");

                entity.HasOne(d => d.Spell)
                    .WithMany(p => p.SpellEffectLinks)
                    .HasForeignKey(d => d.SpellId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Spell_Effect_Link_Champion_Spells");

                entity.HasOne(d => d.SpellLevelNavigation)
                    .WithMany(p => p.SpellEffectLinks)
                    .HasForeignKey(d => d.SpellLevel)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Spell_Effect_Link_Spell_Levels");
            });

            modelBuilder.Entity<SpellLevel>(entity =>
            {
                entity.ToTable("Spell_Levels");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SpellLevelTip>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.ToTable("Spell_Level_Tip");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Effect)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SpellRangeLink>(entity =>
            {
                entity.HasKey(e => new { e.SpellId, e.SpellLevel });

                entity.ToTable("Spell_Range_Link");

                entity.Property(e => e.SpellId).HasColumnName("Spell_Id");

                entity.Property(e => e.SpellLevel).HasColumnName("Spell_Level");

                entity.HasOne(d => d.Spell)
                    .WithMany(p => p.SpellRangeLinks)
                    .HasForeignKey(d => d.SpellId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Spell_Range_Link_Champion_Spells");

                entity.HasOne(d => d.SpellLevelNavigation)
                    .WithMany(p => p.SpellRangeLinks)
                    .HasForeignKey(d => d.SpellLevel)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Spell_Range_Link_Spell_Levels");
            });

            modelBuilder.Entity<TipType>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.ToTable("Tip_Types");

                entity.Property(e => e.Code)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
