// importacion de librerias y referencias
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_Migration.App.Dominio
{
    public class Grupo
    {

        
        public int Id {get; set;}
        //public list<Migrante> Tipo_Grupo {get; set;}
        public int Documento  {get; set;}
        public string Apellido {get;set;}
    }
}