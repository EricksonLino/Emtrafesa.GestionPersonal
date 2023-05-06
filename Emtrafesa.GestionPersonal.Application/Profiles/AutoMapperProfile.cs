using AutoMapper;
using Emtrafesa.GestionPersonal.Application.Dtos;
using Emtrafesa.GestionPersonal.Entity;

namespace Emtrafesa.GestionPersonal.Application.Profiles
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Chofer, ChoferDto>();
            CreateMap<Chofer, ChoferDetalleDto>();
        }
    }
}
