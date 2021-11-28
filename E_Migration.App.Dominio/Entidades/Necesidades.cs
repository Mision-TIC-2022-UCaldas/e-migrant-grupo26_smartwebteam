// importacion de librerias y referencias
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_Migration.App.Dominio
{
    public class Necesidades
    {
        
        public int Id {get;set;}
        [Required(ErrorMessage="El campo {0}, es obligatorio")]
        public String Necesidad{get;set;}
        [Required(ErrorMessage="El campo {0}, es obligatorio")]
        [MaxLength(500, ErrorMessage="No puede superar los {1} cartacteres")]
        [MinLength(3, ErrorMessage="Escriba al menos {1} cartacteres")]
        public String Descripcion{get;set;}
        [Required(ErrorMessage="El campo {0}, es obligatorio")]
        public String Clasificacion {get;set;}
        [Required(ErrorMessage="El campo {0}, es obligatorio")]
        [MaxLength(40, ErrorMessage="No puede superar los {1} cartacteres")]
        [MinLength(3, ErrorMessage="Escriba al menos {1} cartacteres")]
        public String Numero_Identificacion_Migrante{get;set;}



       
    }
}