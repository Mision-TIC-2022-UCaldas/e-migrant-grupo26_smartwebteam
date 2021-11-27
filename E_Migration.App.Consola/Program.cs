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
                Nombre = "Juan",
                Apellidos = "Perez",
                Tipo_Documento = "Pasaporte",
                Numero_Identificacion = "123",
                Pais_Origen = "Venezuela",
                Fecha_Nacimiento = "1987-12-24",
                Correo_Electronico = "gh@huj.com",
                Numero_Telefonico = "32154554",
                Direccion_Actual = "cll 45",
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
