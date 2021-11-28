using Microsoft.EntityFrameworkCore;
using E_Migration.App.Dominio;
using System.Collections.Generic;

namespace E_Migration.App.Persistencia
{

    //Crud Necesidad
    public interface IRepositorioNecesidad
    {
        IEnumerable<Necesidades> GetAllNecesidades();
        bool AddNecesidad(Necesidades Necesidad);
        bool UpdateNecesidad(Necesidades Necesidad);
        bool DeleteNecesidad(int idNecesidad);
        Necesidades GetNecesidad(int idNecesidad);
    }
}