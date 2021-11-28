using Microsoft.EntityFrameworkCore;
using E_Migration.App.Dominio;
using System.Collections.Generic;

namespace E_Migration.App.Persistencia
{

    //Crud Novedad
    public interface IRepositorioNovedades
    {
        IEnumerable<Novedades> GetAllNovedades();
        bool AddNovedades(Novedades Novedad);
        bool UpdateNovedad(Novedades Novedad);
        bool DeleteNovedad(int idNovedad);
        Novedades GetNovedad(int idNovedad);
    }
}