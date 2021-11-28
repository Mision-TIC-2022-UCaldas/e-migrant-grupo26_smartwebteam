// importacion de librerias y referencias
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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