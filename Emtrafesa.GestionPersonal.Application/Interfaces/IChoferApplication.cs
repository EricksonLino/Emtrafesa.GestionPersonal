using Emtrafesa.GestionPersonal.Application.Dtos;

namespace Emtrafesa.GestionPersonal.Application.Interfaces
{
    public interface IChoferApplication
    {
        Task<List<ChoferDto>> ListarChoferes();
    }
}
