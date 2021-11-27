// importacion de librerias y referencias
using System;
using System.Collections.Generic;

namespace E_Migration.App.Dominio
{
    public class Solicitud
    {
        
        public int Id {get;set;}
        public string Fecha_Aceptacion{get;set;}
        public string Descripcion_Servicio{get;set;}
        public string Entidad_of{get;set;}
        public string Estado{get;set;}
        public bool Aceptar{get;set;}
        public bool Transferir{get;set;}
        public int Doc_Transf{get;set;}

    }
}