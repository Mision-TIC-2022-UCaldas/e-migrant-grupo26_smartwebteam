// importacion de librerias y referencias
using System;
using System.Collections.Generic;

namespace E_Migration.App.Dominio
{
    public class EntidadServicios
    {
        //Atributos de la clase entrenador
        public int Id {get;set;}
        public int Id_Entidad{get;set;}
        public Entidad Entidad{get;set;}
        public Servicios Servicios{get;set;}
    }
}