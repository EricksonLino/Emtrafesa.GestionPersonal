using Emtrafesa.GestionPersonal.Application.Dtos;

namespace Emtrafesa.GestionPersonal.Application.Interfaces
{
    public interface IChoferApplication
    {
        Task<List<ChoferDto>> ListarChoferes();
        Task<ChoferDetalleDto> ObtenerChofer(int id);
        Task InsertarChofer(ChoferCreacionDto choferCreacionDto);
        Task EliminarChofer(int id);
        Task ActualizarChofer(int id, ChoferActualizarDto choferActualizarDto);

    }
}
