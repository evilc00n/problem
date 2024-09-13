
using AutoMapper;
using db_api.Domain.DTO.Cmi.CmiUsers;
using db_api.Domain.Entities.Cmi;

namespace db_api.Application.Mapping
{
    public class CmiUsersMapping : Profile
    {
        public CmiUsersMapping()
        {
            CreateMap<CmiUsers, CmiUsersDTO>()
                     .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                     .ForMember(dest => dest.Username, opt => opt.MapFrom(src => src.Username))
                     .ForMember(dest => dest.Balance, opt => opt.MapFrom(src => src.Balance))
                     .ForMember(dest => dest.TotalPlayTime, opt => opt.MapFrom(src => src.TotalPlayTime.HasValue ? (ulong?)src.TotalPlayTime.Value : null))
                     .ForMember(dest => dest.PlayerUuid, opt => opt.MapFrom(src => src.PlayerUuid))
                     .ForMember(dest => dest.UserMeta, opt => opt.MapFrom(src => src.UserMeta))
                     .ForMember(dest => dest.DisplayName, opt => opt.MapFrom(src => src.DisplayName))
                     .ReverseMap() // Обратное сопоставление из CmiUsersDTO в CmiUsers
                     .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                     .ForMember(dest => dest.Username, opt => opt.MapFrom(src => src.Username))
                     .ForMember(dest => dest.Balance, opt => opt.MapFrom(src => src.Balance))
                     .ForMember(dest => dest.TotalPlayTime, opt => opt.MapFrom(src => src.TotalPlayTime.HasValue ? (long?)src.TotalPlayTime.Value : null))
                     .ForMember(dest => dest.PlayerUuid, opt => opt.MapFrom(src => src.PlayerUuid))
                     .ForMember(dest => dest.UserMeta, opt => opt.MapFrom(src => src.UserMeta))
                     .ForMember(dest => dest.DisplayName, opt => opt.MapFrom(src => src.DisplayName));
        }
    }
}
