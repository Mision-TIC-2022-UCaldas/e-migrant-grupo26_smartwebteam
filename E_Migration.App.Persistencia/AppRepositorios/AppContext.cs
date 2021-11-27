using Microsoft.EntityFrameworkCore;
using Dominio;
namespace E_Migration.App.Persistencia
{
    public class AppContext:DbContext
    {
        //public DbSet<Calificacion> Calificacion { get; set; }
        public DbSet<Entidad> Entidad { get; set; }
        public DbSet<EntidadServicios> EntidadServicios { get; set; }
        public DbSet<Grupo> Grupo { get; set; }
        public DbSet<Migrante> Migrante { get; set; }
        public DbSet<Necesidades> Necesidades { get; set; }
        public DbSet<Novedades> Novedades { get; set; }
        public DbSet<Servicios> Servicios { get; set; }
        public DbSet<Solicitud> Solicitud { get; set; }
    }


}