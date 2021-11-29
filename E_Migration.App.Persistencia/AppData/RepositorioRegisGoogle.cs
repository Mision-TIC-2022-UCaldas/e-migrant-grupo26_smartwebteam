using Microsoft.EntityFrameworkCore;
using E_Migration.App.Dominio;
using System.Linq;
using System.Collections.Generic;

namespace E_Migration.App.Persistencia
{
    public class RepositorioRegisGoogle:IRepositorioRegisGoogle
    {
        private readonly AppContext _appContext;
        public RepositorioRegisGoogle(AppContext appContext)
        {
            _appContext=appContext;
        }

        bool IRepositorioRegisGoogle.AddRegisGoogle(RegisGoogle regisGoogle)
        {
           bool creado=false; 
           try
           {
                _appContext.RegisGoogle.Add(regisGoogle);
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
        bool IRepositorioRegisGoogle.DeleteRegisGoogle(int idRegisGoogle)
        {
            bool eliminado= false;
            var regisGoogle =_appContext.RegisGoogle.Find(idRegisGoogle);
            if(regisGoogle != null)
            {
                try
                {
                     _appContext.RegisGoogle.Remove(regisGoogle);
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


         IEnumerable<RegisGoogle> IRepositorioRegisGoogle.GetAllRegisGoogles()
        {
            return _appContext.RegisGoogle;
        }


        RegisGoogle IRepositorioRegisGoogle.GetRegisGoogle(int idRegisGoogle)
        {
            RegisGoogle regisGoogle = _appContext.RegisGoogle.Find(idRegisGoogle);
            return regisGoogle;
        }

    

        bool IRepositorioRegisGoogle.UpdateRegisGoogle(RegisGoogle regisGoogle)
        {
            bool actualizado = false;
            var RegisGoogleEncontrado = _appContext.RegisGoogle.Find(regisGoogle.Id);
            if(RegisGoogleEncontrado != null)
            {
                try 
                {
                    RegisGoogleEncontrado.Nombre = regisGoogle.Nombre;
                    RegisGoogleEncontrado.Email = regisGoogle.Email;
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