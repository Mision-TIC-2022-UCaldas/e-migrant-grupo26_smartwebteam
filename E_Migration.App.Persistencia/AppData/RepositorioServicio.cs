using Microsoft.EntityFrameworkCore;
using E_Migration.App.Dominio;
using System.Linq;
using System.Collections.Generic;

namespace E_Migration.App.Persistencia
{
    public class RepositorioServicio:IRepositorioServicio
    {
        private readonly AppContext _appContext;
        public RepositorioServicio(AppContext appContext)
        {
            _appContext=appContext;
        }

        bool IRepositorioServicio.AddServicio(Servicios servicio)
        {
           bool creado=false;
           try
           {
                _appContext.Servicios.Add(servicio);
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
        bool IRepositorioServicio.DeleteServicio(int idServicio)
        {
            bool eliminado= false;
            var servicio =_appContext.Servicios.Find(idServicio);
            if(servicio != null)
            {
                try
                {
                     _appContext.Servicios.Remove(servicio);
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


         IEnumerable<Servicios> IRepositorioServicio.GetAllServicios()
        {
            return _appContext.Servicios;
        }


        Servicios IRepositorioServicio.GetServicio(int idServicio)
        {
            Servicios servicio = _appContext.Servicios.Find(idServicio);
            return servicio;
        }

    

        bool IRepositorioServicio.UpdateServicio(Servicios servicio)
        {
            bool actualizado = false;
            var servicioEncontrado = _appContext.Servicios.Find(servicio.Id);
            if(servicioEncontrado != null)
            {
                try 
                {
                    servicioEncontrado.Nombre_Ser = servicio.Nombre_Ser;
                    servicioEncontrado.Fecha_In_Oferta = servicio.Fecha_In_Oferta;
                    servicioEncontrado.Fecha_fn_Oferta = servicio.Fecha_fn_Oferta;
                    servicioEncontrado.Estado = servicio.Estado;
                    servicioEncontrado.Id_Entidad = servicio.Id_Entidad;
                    servicioEncontrado.Calificacion = servicio.Calificacion;
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