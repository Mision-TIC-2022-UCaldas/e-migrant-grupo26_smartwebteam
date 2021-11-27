// importacion de librerias y referencias
using System;
using System.Collections.Generic;

namespace E_Migration.App.Dominio
{
    public class Servicios
    {
        
        public int Id {get;set;}
        public string Nombre_Ser {get;set;}
        public DateTime Fecha_In_Oferta{get;set;}
        public DateTime Fecha_fn_Oferta{get;set;}
        public string Estado{get;set;}
        public int Id_Entidad{get;set;}
        public Calificacion Calificacion{get;set;}
     

    }
}
