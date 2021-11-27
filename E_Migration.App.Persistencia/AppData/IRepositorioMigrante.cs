using Microsoft.EntityFrameworkCore;
using E_Migration.App.Dominio;
using System.Collections.Generic;

namespace E_Migration.App.Persistencia
{

    //Crud Migrante
    public interface IRepositorioMigrante
    {
        IEnumerable<Migrante> GetAllMigrantes();
        bool AddMigrante(Migrante migrante);
        bool UpdateMigrante(Migrante migrante);
        bool DeleteMigrante(int idMigrante);
        Migrante GetMigrante(int idMigrante);
    }
}