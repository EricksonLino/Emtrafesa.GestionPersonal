using Emtrafesa.GestionPersonal.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emtrafesa.GestionPersonal.Repository.Interfaces
{
    public interface IChoferRepository
    {
        Task<List<Chofer>> ListarChoferes();
        Task<Chofer> ObtenerChofer(int id);
        Task InsertarChofer(Chofer chofer); 
    }
}
