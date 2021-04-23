using AutoMapper;
using Entities = DongolOfLegends.API.DAC.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using Champions = PecTec.Riot.LoL.Models.Champions;
using System.Linq;

namespace DongolOfLegends.API.BusinessLayer.Profiles
{
    public class ChampionProfiles : Profile
    {
        public ChampionProfiles()
        {
            CreateMap<Champions.Champion, Entities.Champion>()
                .ForMember(dest => dest.ChampionTags, opt => opt.MapFrom(src => src.Tags.Select(t => new { item1 = t, item2 = src.Id })))
                .ForMember(dest => dest.Image, opt => opt.MapFrom(src => src.Image))
                .ForMember(dest => dest.Info, opt => opt.MapFrom(src => src.Info))
                .ForMember(dest => dest.Stats, opt => opt.MapFrom(src => src.Stats))
                .ReverseMap();

            CreateMap<(string, string), Entities.ChampionTag>()
                .ForMember(dest => dest.Tag, opt => opt.MapFrom(src => src.Item1))
                .ForMember(dest => dest.ChampionId, opt => opt.MapFrom(src => src.Item2)).ReverseMap()
                ;

            CreateMap<Champions.Image, Entities.ChampionImage>().ReverseMap()
                ;

            CreateMap<Champions.Info, Entities.ChampionInfo>().ReverseMap()
                ;

            CreateMap<Champions.Stats, Entities.ChampionsStat>().ReverseMap();
        }
    }
}
