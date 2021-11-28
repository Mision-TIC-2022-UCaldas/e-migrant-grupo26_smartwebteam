using Microsoft.EntityFrameworkCore;
using E_Migration.App.Dominio;
using System.Linq;
using System.Collections.Generic;

namespace E_Migration.App.Persistencia
{
    public class RepositorioNecesidad:IRepositorioNecesidad
    {
        private readonly AppContext _appContext;
        public RepositorioNecesidad(AppContext appContext)
        {
            _appContext=appContext;
        }

        bool IRepositorioNecesidad.AddNecesidad(Necesidades Necesidad)
        {
           bool creado=false; 
           try
           {
                _appContext.Necesidades.Add(Necesidad);
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
        bool IRepositorioNecesidad.DeleteNecesidad(int idNecesidad)
        {
            bool eliminado= false;
            var Necesidad =_appContext.Necesidades.Find(idNecesidad);
            if(Necesidad != null)
            {
                try
                {
                     _appContext.Necesidades.Remove(Necesidad);
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


         IEnumerable<Necesidades> IRepositorioNecesidad.GetAllNecesidades()
        {
            return _appContext.Necesidades;
        }


        Necesidades IRepositorioNecesidad.GetNecesidad(int idNecesidad)
        {
            Necesidades Necesidad = _appContext.Necesidades.Find(idNecesidad);
            return Necesidad;
        }

    

        bool IRepositorioNecesidad.UpdateNecesidad(Necesidades Necesidad)
        {
            bool actualizado = false;
            var NecesidadEncontrado = _appContext.Necesidades.Find(Necesidad.Id);
            if(NecesidadEncontrado != null)
            {
                try 
                {
                    NecesidadEncontrado.Necesidad = Necesidad.Necesidad;
                    NecesidadEncontrado.Descripcion = Necesidad.Descripcion;
                    NecesidadEncontrado.Clasificacion = Necesidad.Clasificacion;
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