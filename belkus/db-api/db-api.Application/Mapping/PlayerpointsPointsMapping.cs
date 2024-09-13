using AutoMapper;
using db_api.Domain.DTO.Playerpoints.Points;
using db_api.Domain.Entities.Playerpoints;


namespace db_api.Application.Mapping
{
    public class PlayerpointsPointsMapping : Profile
    {
        public PlayerpointsPointsMapping()
        {
            // Сопоставление из PlayerpointsPoints в PlayerpointsPointsDTO
            CreateMap<PlayerpointsPoints, PlayerpointsPointsDTO>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Uuid, opt => opt.MapFrom(src => src.Uuid))
                .ForMember(dest => dest.Points, opt => opt.MapFrom(src => src.Points))
                .ReverseMap() // Обратное сопоставление из PlayerpointsPointsDTO в PlayerpointsPoints
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Uuid, opt => opt.MapFrom(src => src.Uuid))
                .ForMember(dest => dest.Points, opt => opt.MapFrom(src => src.Points));
        }
    }
}
