using Microsoft.EntityFrameworkCore;
using E_Migration.App.Dominio;
using System.Collections.Generic;

namespace E_Migration.App.Persistencia
{

    //Crud Servicio
    public interface IRepositorioServicio
    {
        IEnumerable<Servicios> GetAllServicios();
        bool AddServicio(Servicios servicio);
        bool UpdateServicio(Servicios servicio);
        bool DeleteServicio(int idServicio);
        Servicios GetServicio(int idServicio);
    }
}