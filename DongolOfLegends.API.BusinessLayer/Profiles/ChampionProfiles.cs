using AutoMapper;
using Entities = DongolOfLegends.API.DAC.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using Champions = PecTec.Riot.LoL.Models.Champions;
using System.Linq;
using PecTec.Riot.LoL.Utility;
using Microsoft.Extensions.Configuration;

namespace DongolOfLegends.API.BusinessLayer.Profiles
{
    public class ChampionProfiles : Profile
    {
        private readonly IConfiguration _configuration;
        public ChampionProfiles(IConfiguration configuration)
        {
            _configuration = configuration;
            CreateMap<Champions.Champion, Entities.Champion>()
                .ForMember(dest => dest.Blurb, opt => opt.MapFrom(src => src.Blurb))
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Key))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Image, opt => opt.MapFrom(src => src.Image)) //Object
                .ForMember(dest => dest.Info, opt => opt.MapFrom(src => src.Info)) //Object
                .ForMember(dest => dest.Partype, opt => opt.MapFrom(src => src.Partype))
                .ForMember(dest => dest.RiotId, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Stats, opt => opt.MapFrom(src => src.Stats)) //Object 
                .ForMember(dest => dest.Title, opt => opt.MapFrom(src => src.Title))
                .ForMember(dest => dest.Version, opt => opt.MapFrom(src => src.Version))
                .ForMember(dest => dest.Lore, opt => opt.MapFrom(src => ""))
                .ForPath(dest => dest.Image.ImageHref, opt => opt.MapFrom(src => DataDragonValues.ChampionSquareArt(src.Image.Full, src.Version)))
                .AfterMap((src, dest) => FillInTagLinks(src, dest))
                .ReverseMap();

            CreateMap<Champions.Image, Entities.ChampionImage>()
                .ForMember(dest => dest.FullImageName, opt => opt.MapFrom(src => src.Full))
                .ForMember(dest => dest.Group, opt => opt.MapFrom(src => src.Group))
                .ForMember(dest => dest.HValue, opt => opt.MapFrom(src => src.H))
                .ForMember(dest => dest.YValue, opt => opt.MapFrom(src => src.Y))
                .ForMember(dest => dest.XValue, opt => opt.MapFrom(src => src.X))
                .ForMember(dest => dest.WValue, opt => opt.MapFrom(src => src.W))
                .ForMember(dest => dest.Sprite, opt => opt.MapFrom(src => src.Sprite))
                .ReverseMap();

            CreateMap<Champions.Info, Entities.ChampionInfo>()
                .ForMember(dest => dest.AttackLevel, opt => opt.MapFrom(src => src.Attack))
                .ForMember(dest => dest.DefenseLevel, opt => opt.MapFrom(src => src.Defense))
                .ForMember(dest => dest.Difficulty, opt => opt.MapFrom(src => src.Difficulty))
                .ForMember(dest => dest.MagicLevel, opt => opt.MapFrom(src => src.Magic))
                .ReverseMap();

            CreateMap<Champions.Stats, Entities.ChampionStat>()
                .ForMember(dest => dest.Armor, opt => opt.MapFrom(src => src.Armor))
                .ForMember(dest => dest.ArmorPerLevel, opt => opt.MapFrom(src => src.Armorperlevel))
                .ForMember(dest => dest.AttackDamage, opt => opt.MapFrom(src => src.Attackdamage))
                .ForMember(dest => dest.AttackDamagePerLevel, opt => opt.MapFrom(src => src.Attackdamageperlevel))
                .ForMember(dest => dest.AttackRange, opt => opt.MapFrom(src => src.Attackrange))
                .ForMember(dest => dest.AttackSpeed, opt => opt.MapFrom(src => src.Attackspeed))
                .ForMember(dest => dest.AttackSpeedPerLevel, opt => opt.MapFrom(src => src.Attackspeedperlevel))
                .ForMember(dest => dest.CriticalStrike, opt => opt.MapFrom(src => src.Crit))
                .ForMember(dest => dest.CriticalStrikePerLevel, opt => opt.MapFrom(src => src.Critperlevel))
                .ForMember(dest => dest.Hp, opt => opt.MapFrom(src => src.Hp))
                .ForMember(dest => dest.HpPerLevel, opt => opt.MapFrom(src => src.Hpperlevel))
                .ForMember(dest => dest.HpRegen, opt => opt.MapFrom(src => src.Hpregen))
                .ForMember(dest => dest.HpRegenPerLevel, opt => opt.MapFrom(src => src.Hpregenperlevel))
                .ForMember(dest => dest.MagicResist, opt => opt.MapFrom(src => src.Spellblock))
                .ForMember(dest => dest.MagicResistPerLevel, opt => opt.MapFrom(src => src.Spellblockperlevel))
                .ForMember(dest => dest.Mana, opt => opt.MapFrom(src => src.Mp))
                .ForMember(dest => dest.ManaPerLevel, opt => opt.MapFrom(src => src.Mpperlevel))
                .ForMember(dest => dest.ManaRegen, opt => opt.MapFrom(src => src.Mpregen))
                .ForMember(dest => dest.ManaRegenPerLevel, opt => opt.MapFrom(src => src.Mpregenperlevel))
                .ForMember(dest => dest.MovementSpeed, opt => opt.MapFrom(src => src.Movespeed))
                .ReverseMap();

        }

        private void FillInTagLinks(Champions.Champion src, Entities.Champion dest)
        {
            src.Tags.ForEach(t =>
            {
                dest.ChampionTagsLinks.Add(new Entities.ChampionTagsLink { ChampionId = src.Key, TagCode = _configuration[$"Global:TagCodes:{t}"] });
            });
        }
    }
}
