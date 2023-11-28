using AutoMapper;
using RestDocentesAPI.Data.DTO;
using RestDocentesAPI.Data.Entities;

namespace RestDocentesAPI.DtosAutomapperProfiles
{
    public class DocentesProfile : Profile
    {
        public DocentesProfile()
        {
            CreateMap<DocenteDto, Docente>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
            .ForMember(dest => dest.Nombre, opt => opt.MapFrom(src => src.Nombre))
            .ForMember(dest => dest.Especialidad, opt => opt.MapFrom(src => src.Especialidad));
            CreateMap<Docente, DocenteDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Nombre, opt => opt.MapFrom(src => src.Nombre))
                .ForMember(dest => dest.Especialidad, opt => opt.MapFrom(src => src.Especialidad));
        }
    }
}
