using Microsoft.EntityFrameworkCore;
using E_Migration.App.Dominio;
using System.Linq;
using System.Collections.Generic;

namespace E_Migration.App.Persistencia
{
    public class RepositorioNovedades:IRepositorioNovedades
    {
        private readonly AppContext _appContext;
        public RepositorioNovedades(AppContext appContext)
        {
            _appContext=appContext;
        }

        bool IRepositorioNovedades.AddNovedades(Novedades Novedad)
        {
           bool creado=false; 
           try
           {
                _appContext.Novedades.Add(Novedad);
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
        bool IRepositorioNovedades.DeleteNovedad(int idNovedad)
        {
            bool eliminado= false;
            var Novedad =_appContext.Novedades.Find(idNovedad);
            if(Novedad != null)
            {
                try
                {
                     _appContext.Novedades.Remove(Novedad);
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


         IEnumerable<Novedades> IRepositorioNovedades.GetAllNovedades()
        {
            return _appContext.Novedades;
        }


        Novedades IRepositorioNovedades.GetNovedad(int idNovedades)
        {
            Novedades Novedades = _appContext.Novedades.Find(idNovedades);
            return Novedades;
        }

    

        bool IRepositorioNovedades.UpdateNovedad(Novedades Novedades)
        {
            bool actualizado = false;
            var NovedadesEncontrado = _appContext.Novedades.Find(Novedades.Id);
            if(NovedadesEncontrado != null)
            {
                try 
                {
                    NovedadesEncontrado.Fecha_Novedad = Novedades.Fecha_Novedad;
                    NovedadesEncontrado.Duracion = Novedades.Duracion;
                    NovedadesEncontrado.Explicacion = Novedades.Explicacion;
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