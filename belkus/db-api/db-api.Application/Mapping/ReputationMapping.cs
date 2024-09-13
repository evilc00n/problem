

using AutoMapper;
using db_api.Domain.DTO.Reputation;
using db_api.Domain.Entities.Reputation;

namespace db_api.Application.Mapping
{
    public class ReputationMapping : Profile
    {
        public ReputationMapping()
        {
            CreateMap<Reputation, ReputationDTO>()
                .ForMember(dest => dest.Uuid, 
                opt => opt.MapFrom(src => src.Uuid))
            .ForMember(dest => dest.ReputationScore, 
            opt => opt.MapFrom(src => src.ReputationScore.HasValue ? (ulong?)src.ReputationScore.Value : null))
            .ForMember(dest => dest.AcceptReputation, 
            opt => opt.MapFrom(src => src.AcceptReputation))
            .ReverseMap() // Обратное сопоставление из ReputationDTO в Reputation
            .ForMember(dest => dest.Uuid, 
            opt => opt.MapFrom(src => src.Uuid))
            .ForMember(dest => dest.ReputationScore, 
            opt => opt.MapFrom(src => src.ReputationScore.HasValue ? (long?)src.ReputationScore.Value : null))
            .ForMember(dest => dest.AcceptReputation, 
            opt => opt.MapFrom(src => src.AcceptReputation));
        }
    }
}
