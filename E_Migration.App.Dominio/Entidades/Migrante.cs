//Importacion de las librerias a usar
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace E_Migration.App.Dominio
{
    public class Migrante
    {
        
        public int Id { get; set; }
        [Required(ErrorMessage="El campo {0}, es obligatorio")]
        [MaxLength(40, ErrorMessage="No puede superar los {1} cartacteres")]
        [MinLength(3, ErrorMessage="Escriba al menos {1} cartacteres")]
        [RegularExpression("[A-Za-z ]*", ErrorMessage="Sólo se permiten letras")]
        public string Nombre{ get; set; }
        [Required(ErrorMessage="El campo {0}, es obligatorio")]
        [MaxLength(40, ErrorMessage="No puede superar los {1} cartacteres")]
        [MinLength(3, ErrorMessage="Escriba al menos {1} cartacteres")]
        [RegularExpression("[A-Za-z ]*", ErrorMessage="Sólo se permiten letras")]
        public string Apellidos{ get; set; }
        [Required(ErrorMessage="El campo {0}, es obligatorio")]
        public string Tipo_Documento{ get; set; }
        [Required(ErrorMessage="El campo {0}, es obligatorio")]
        [MaxLength(11, ErrorMessage="No puede superar los {1} cartacteres")]
        [MinLength(8, ErrorMessage="Escriba al menos {1} cartacteres")]
        [RegularExpression("[0-9 ]*", ErrorMessage="Sólo se permiten números")]
        public string Numero_Identificacion{ get; set; }
        [Required(ErrorMessage="El campo {0}, es obligatorio")]
        [MaxLength(40, ErrorMessage="No puede superar los {1} cartacteres")]
        [MinLength(3, ErrorMessage="Escriba al menos {1} cartacteres")]
        [RegularExpression("[A-Za-z ]*", ErrorMessage="Sólo se permiten letras")]
        public string Pais_Origen{ get; set; }
        public DateTime Fecha_Nacimiento{ get; set; }
        public string Correo_Electronico{ get; set; }
        public string Numero_Telefonico{ get; set; }
        public string Direccion_Actual{ get; set; }
        public string Ciudad{ get; set; }
        public string Situacion_Laboral{ get; set; }
        //public string Comportamiento{ get;set; }

    }

}
