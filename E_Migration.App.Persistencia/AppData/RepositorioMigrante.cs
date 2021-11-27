using Microsoft.EntityFrameworkCore;
using E_Migration.App.Dominio;
using System.Linq;
using System.Collections.Generic;

namespace E_Migration.App.Persistencia
{
    public class RepositorioMigrante:IRepositorioMigrante
    {
        private readonly AppContext _appContext;
        public RepositorioMigrante(AppContext appContext)
        {
            _appContext=appContext;
        }

        bool IRepositorioMigrante.AddMigrante(Migrante migrante)
        {
           bool creado=false;
           try
           {
                _appContext.Migrantes.Add(migrante);
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
        bool IRepositorioMigrante.DeleteMigrante(int idMigrante)
        {
            bool eliminado= false;
            var migrante =_appContext.Migrantes.Find(idMigrante);
            if(migrante != null)
            {
                try
                {
                     _appContext.Migrantes.Remove(migrante);
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


         IEnumerable<Migrante> IRepositorioMigrante.GetAllMigrantes()
        {
            return _appContext.Migrantes;
        }


        Migrante IRepositorioMigrante.GetMigrante(int idMigrante)
        {
            Migrante migrante = _appContext.Migrantes.Find(idMigrante);
            return migrante;
        }

    

        bool IRepositorioMigrante.UpdateMigrante(Migrante migrante)
        {
            bool actualizado = false;
            var migranteEncontrado = _appContext.Migrantes.Find(migrante.Id);
            if(migranteEncontrado != null)
            {
                try 
                {
                    migranteEncontrado.Nombre = migrante.Nombre;
                    migranteEncontrado.Apellidos = migrante.Apellidos;
                    migranteEncontrado.Tipo_Documento = migrante.Tipo_Documento;
                    migranteEncontrado.Numero_Identificacion = migrante.Numero_Identificacion;
                    migranteEncontrado.Pais_Origen = migrante.Pais_Origen;
                    migranteEncontrado.Fecha_Nacimiento = migrante.Fecha_Nacimiento;
                    migranteEncontrado.Correo_Electronico = migrante.Correo_Electronico;
                    migranteEncontrado.Numero_Telefonico = migrante.Numero_Telefonico;
                    migranteEncontrado.Direccion_Actual = migrante.Direccion_Actual;
                    migranteEncontrado.Ciudad = migrante.Ciudad;
                    migranteEncontrado.Situacion_Laboral = migrante.Situacion_Laboral;
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