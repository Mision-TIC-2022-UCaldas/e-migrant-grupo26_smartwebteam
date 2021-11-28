// importacion de librerias y referencias
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_Migration.App.Dominio
{
    public class Servicios
    {
        
        public int Id {get;set;}
        public string Nombre_Ser {get;set;}
        public DateTime Fecha_In_Oferta{get;set;}
        public DateTime Fecha_fn_Oferta{get;set;}
        public string Estado{get;set;}
        //Llave foranea a entidad
        public int Id_Entidad{get;set;}
        public double Calificacion {get;set;}
    }
}
