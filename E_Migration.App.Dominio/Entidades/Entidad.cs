//Importar las libreriar a ser usadadas
using System;
using System.Collections.Generic;

namespace E_Migration.App.Dominio
{
    public class Entidad
    {
        public int Id { get; set; }
        public int Razon_Social { get; set; }
        public string Nit { get; set; }
        public string Direccion { get; set; }
        public string Ciudad { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Pagina_Web { get; set; }
        public string Sector { get; set; }
        public string Tipo_Servicio { get; set; }

        
        public Calificacion Calificacion { get; set; }
        


    }
}