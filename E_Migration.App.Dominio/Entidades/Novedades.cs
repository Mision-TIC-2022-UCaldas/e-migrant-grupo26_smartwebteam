// importacion de librerias y referencias
using System;
using System.Collections.Generic;

namespace E_Migration.App.Dominio
{
    public class Novedades
    {
        
        public int Id { get; set; }
        public DateTime Fecha_Novedad {get;set;}
        public int Duracion {get;set;}
        public string Explicacion {get; set;}

    }
}