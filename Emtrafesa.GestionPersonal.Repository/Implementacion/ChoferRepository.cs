using Emtrafesa.GestionPersonal.Entity;
using Emtrafesa.GestionPersonal.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Emtrafesa.GestionPersonal.Repository.Implementacion
{
    public class ChoferRepository : IChoferRepository
    {
        private readonly ApplicationDbContext applicationDbContext;

        public ChoferRepository(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }
        public async Task<List<Chofer>> ListarChoferes()
        {
            var choferes = await applicationDbContext.Choferes.ToListAsync();
            return choferes;
        }

        public async Task<Chofer> ObtenerChofer(int id)
        {
            var chofer = await applicationDbContext.Choferes.FirstOrDefaultAsync(x=> x.Id == id);
            return chofer;
        }
    }
}
