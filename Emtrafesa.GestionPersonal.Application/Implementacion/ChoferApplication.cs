using AutoMapper;
using Emtrafesa.GestionPersonal.Application.Dtos;
using Emtrafesa.GestionPersonal.Application.Interfaces;
using Emtrafesa.GestionPersonal.Entity;
using Emtrafesa.GestionPersonal.Repository.Interfaces;

namespace Emtrafesa.GestionPersonal.Application.Implementacion
{
    public class ChoferApplication : IChoferApplication
    {
        private readonly IChoferRepository choferRepository;
        private readonly IMapper mapper;

        public ChoferApplication(IChoferRepository choferRepository, IMapper mapper)
        {
            this.choferRepository = choferRepository;
            this.mapper = mapper;
        }

        public async Task<List<ChoferDto>> ListarChoferes()
        {
            var choferes = await choferRepository.ListarChoferes();
            var choferDto = mapper.Map<List<ChoferDto>>(choferes);
            return choferDto;
        }

        public async Task<ChoferDetalleDto> ObtenerChofer(int id)
        {
            var chofer = await choferRepository.ObtenerChofer(id);
            var choferDto = mapper.Map<ChoferDetalleDto>(chofer);
            return choferDto;
        }

        public async Task InsertarChofer(ChoferCreacionDto choferCreacionDto)
        {
            var chofer = mapper.Map<Chofer>(choferCreacionDto);
            await choferRepository.InsertarChofer(chofer);
        }

    }
}
