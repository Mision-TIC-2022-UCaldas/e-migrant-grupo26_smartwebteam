using Microsoft.EntityFrameworkCore;
using E_Migration.App.Dominio;

namespace E_Migration.App.Persistencia
{
    public class AppContext:DbContext
    {
        // public DbSet<Calificacion> Calificacion { get; set; }
        public DbSet<Entidad> Entidades { get; set; }
        // public DbSet<EntidadServicios> EntidadServicios { get; set; }
        // public DbSet<Grupo> Grupo { get; set; }
        public DbSet<Migrante> Migrantes { get; set; }
        public DbSet<Necesidades> Necesidades { get; set; }
        public DbSet<Novedades> Novedades { get; set; }
        public DbSet<Servicios> Servicios { get; set; }
        public DbSet<RegisGoogle> RegisGoogle {get; set; }
        // public DbSet<Solicitud> Solicitud { get; set; }

    //configurando la conexión a la base de datos
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder
            .UseSqlServer("Data Source= (localdb)\\MSSQLLocalDB;Initial Catalog= SmartWebTeam");
        }
    }
    }
}