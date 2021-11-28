using Microsoft.EntityFrameworkCore;
using E_Migration.App.Dominio;
using System.Collections.Generic;

namespace E_Migration.App.Persistencia
{

    //Crud Entidad
    public interface IRepositorioEntidad
    {
        IEnumerable<Entidad> GetAllEntidades();
        bool AddEntidad(Entidad Entidad);
        bool UpdateEntidad(Entidad Entidad);
        bool DeleteEntidad(int idEntidad);
        Entidad GetEntidad(int idEntidad);
    }
}