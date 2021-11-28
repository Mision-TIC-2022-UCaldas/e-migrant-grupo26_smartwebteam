using Microsoft.EntityFrameworkCore;
using E_Migration.App.Dominio;
using System.Linq;
using System.Collections.Generic;

namespace E_Migration.App.Persistencia
{
    public class RepositorioEntidad:IRepositorioEntidad
    {
        private readonly AppContext _appContext;
        public RepositorioEntidad(AppContext appContext)
        {
            _appContext=appContext;
        }

        bool IRepositorioEntidad.AddEntidad(Entidad entidad)
        {
           bool creado=false;
           try
           {
                _appContext.Entidades.Add(entidad);
                _appContext.SaveChanges();
                creado=true;
           }
           catch (System.Exception)
           {
               return creado;
                //throw;
           }
           return creado;
        }
        bool IRepositorioEntidad.DeleteEntidad(int idEntidad)
        {
            bool eliminado= false;
            var entidad =_appContext.Entidades.Find(idEntidad);
            if(entidad != null)
            {
                try
                {
                     _appContext.Entidades.Remove(entidad);
                     _appContext.SaveChanges();
                     eliminado=true;
                }
                catch (System.Exception)
                {                    
                    return eliminado;
                }
            }
            return eliminado;
        }


         IEnumerable<Entidad> IRepositorioEntidad.GetAllEntidades()
        {
            return _appContext.Entidades;
        }


        Entidad IRepositorioEntidad.GetEntidad(int idEntidad)
        {
            Entidad entidad = _appContext.Entidades.Find(idEntidad);
            return entidad;
        }

    

        bool IRepositorioEntidad.UpdateEntidad(Entidad entidad)
        {
            bool actualizado = false;
            var EntidadEncontrado = _appContext.Entidades.Find(entidad.Id);
            if(EntidadEncontrado != null)
            {
                try 
                {
                    EntidadEncontrado.Razon_Social = entidad.Razon_Social;
                    EntidadEncontrado.Nit = entidad.Nit;
                    EntidadEncontrado.Direccion = entidad.Direccion;
                    EntidadEncontrado.Ciudad = entidad.Ciudad;
                    EntidadEncontrado.Telefono = entidad.Telefono;
                    EntidadEncontrado.Email = entidad.Email;
                    EntidadEncontrado.Pagina_Web = entidad.Pagina_Web;
                    EntidadEncontrado.Sector = entidad.Sector;
                    EntidadEncontrado.Tipo_Servicio = entidad.Tipo_Servicio;
                    EntidadEncontrado.Calificacion = entidad.Calificacion;
                    _appContext.SaveChanges();
                    actualizado = true;
                }
                catch(System.Exception )
                {
                    return actualizado;
                }
            }
            return actualizado;
        }
    }
}