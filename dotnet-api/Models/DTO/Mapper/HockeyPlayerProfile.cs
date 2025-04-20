using AutoMapper;
using dotnet_api.Models;
using dotnet_api.Models.DTO;

namespace dotnet_api.Models.DTO.Mapper
{
    public class HockeyPlayerProfile : Profile
    {
        public HockeyPlayerProfile()
        {
            CreateMap<AddPlayerDTO, HockeyPlayer>()
                .ForMember(dest => dest.Nation, opt => opt.MapFrom(src => new Nation { Id = src.NationId }));
        }
    }
}
