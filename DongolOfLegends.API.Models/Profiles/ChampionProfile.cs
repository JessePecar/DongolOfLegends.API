using AutoMapper;
using DongolOfLegends.API.Models.Models.Champions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DongolOfLegends.API.Models.Profiles
{
    public class ChampionProfile : Profile
    {
        public ChampionProfile()
        {
            //CreateMap<ChampionData, IEnumerable<Champion>>()
            //    .ForMember(dest => dest, opt => opt.MapFrom(src => GetChampionsFromData(src)));
        }

        private IEnumerable<Champion> GetChampionsFromData(ChampionData data)
        {
            List<Champion> returnList = new List<Champion>();
            foreach(var champ in data.GetType().GetProperties())
            {
                returnList.Add(data.GetType().GetProperty(champ.Name).GetValue(data, null) as Champion);
            }
            return returnList.AsEnumerable();
        }
    }
}
