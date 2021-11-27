// importacion de librerias y referencias
using System;
using System.Collections.Generic;

namespace Dominio
{
    public class EntidadServicios
    {
        //Atributos de la clase entrenador
        public int Id_Servicio{get;set;}
        public int Id_Entidad{get;set;}
        public Entidad Entidad{get;set;}
        public Servicios Servicios{get;set;}

    }
}