

using AutoMapper;
using db_api.Domain.DTO.Lands.LandsLands;
using db_api.Domain.Entities.Lands;

namespace db_api.Application.Mapping
{
    public class LandsLandsMapping : Profile
    {
        public LandsLandsMapping()
        {
            CreateMap<LandsLands, LandsLandsDTO>()
                .ForMember(dest => dest.Ulid, opt => opt.MapFrom(src => src.Ulid))
                .ForMember(dest => dest.Server, opt => opt.MapFrom(src => src.Server))
                .ForMember(dest => dest.World, opt => opt.MapFrom(src => src.World))
                .ForMember(dest => dest.Category, opt => opt.MapFrom(src => src.Category))
                .ForMember(dest => dest.Members, opt => opt.MapFrom(src => src.Members))
                .ForMember(dest => dest.Area, opt => opt.MapFrom(src => src.Area))
                .ForMember(dest => dest.Balance, opt => opt.MapFrom(src => src.Balance))
                .ForMember(dest => dest.Type, opt => opt.MapFrom(src => src.Type))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                .ForMember(dest => dest.Title, opt => opt.MapFrom(src => src.Title));

            // Mapping from LandsLandsDTO to LandsLand
            CreateMap<LandsLandsDTO, LandsLands>()
                .ForMember(dest => dest.Ulid, opt => opt.MapFrom(src => src.Ulid))
                .ForMember(dest => dest.Server, opt => opt.MapFrom(src => src.Server))
                .ForMember(dest => dest.World, opt => opt.MapFrom(src => src.World))
                .ForMember(dest => dest.Category, opt => opt.MapFrom(src => src.Category))
                .ForMember(dest => dest.Members, opt => opt.MapFrom(src => src.Members))
                .ForMember(dest => dest.Area, opt => opt.MapFrom(src => src.Area))
                .ForMember(dest => dest.Balance, opt => opt.MapFrom(src => src.Balance))
                .ForMember(dest => dest.Type, opt => opt.MapFrom(src => src.Type))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                .ForMember(dest => dest.Title, opt => opt.MapFrom(src => src.Title));
        }
    }
}
