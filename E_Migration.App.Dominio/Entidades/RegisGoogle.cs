// importacion de librerias y referencias
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace E_Migration.App.Dominio
{
    public class RegisGoogle
    {
        
        public int Id {get;set;}
        public string Nombre {get;set;}
        public string Email {get;set;}

    }
}