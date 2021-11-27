using System;
using E_Migration.App.Dominio;
using E_Migration.App.Persistencia;

namespace E_Migration.App.Consola
{
    class Program
    {
        private static IRepositorioMigrante _migrante = new RepositorioMigrante(new Persistencia.AppContext());
        static void Main(string[] args)
        {
           crearMigrante();
        }
        
        private static bool crearMigrante()
        {
            try
            {
                var migrante = new Migrante
            {
                Nombre = "Camila",
                Apellidos = "Gutierrez  ",
                Tipo_Documento = "Pasaporte",
                Numero_Identificacion = "123456",
                Pais_Origen = "Venezuela",
                Fecha_Nacimiento = new DateTime(1994,12,24),
                Correo_Electronico = "gh@huj.com",
                Numero_Telefonico = "32456554",
                Direccion_Actual = "cll 478",
                Ciudad = "Bogotá DC",
                Situacion_Laboral = "Desempleado"
            };
                bool funciono = _migrante.AddMigrante(migrante);
                Console.WriteLine("Valor de funcion migrante: "+funciono);
                return funciono;

            }catch(Exception e)
            {
                Console.WriteLine("Error: "+e);
            }
            return true;   
        }
    }
}
