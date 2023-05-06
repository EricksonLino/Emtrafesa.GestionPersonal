using Emtrafesa.GestionPersonal.Entity;
using Microsoft.EntityFrameworkCore;

namespace Emtrafesa.GestionPersonal.Repository
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Chofer> Choferes { get; set; }
    }
}
