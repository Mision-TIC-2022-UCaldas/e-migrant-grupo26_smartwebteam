//Importar las libreriar a ser usadadas
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_Migration.App.Dominio
{
    public class Entidad
    {
        public int Id { get; set; }
        [Required(ErrorMessage="El campo {0}, es obligatorio")]
        [MaxLength(40, ErrorMessage="No puede superar los {1} cartacteres")]
        [MinLength(3, ErrorMessage="Escriba al menos {1} cartacteres")]
        [RegularExpression("[A-Za-z ]*", ErrorMessage="Sólo se permiten letras")]
        public string Razon_Social { get; set; }
        [Required(ErrorMessage="El campo {0}, es obligatorio")]
        [MaxLength(40, ErrorMessage="No puede superar los {1} cartacteres")]
        [MinLength(3, ErrorMessage="Escriba al menos {1} cartacteres")]
        [RegularExpression("[A-Za-z ]*", ErrorMessage="Sólo se permiten letras")]
        public string Nit { get; set; }
        [Required(ErrorMessage="El campo {0}, es obligatorio")]
        [MaxLength(40, ErrorMessage="No puede superar los {1} cartacteres")]
        [MinLength(3, ErrorMessage="Escriba al menos {1} cartacteres")]
        [RegularExpression("[A-Za-z ]*", ErrorMessage="Sólo se permiten letras")]
        public string Direccion { get; set; }
        [Required(ErrorMessage="El campo {0}, es obligatorio")]
        [MaxLength(40, ErrorMessage="No puede superar los {1} cartacteres")]
        [MinLength(3, ErrorMessage="Escriba al menos {1} cartacteres")]
        [RegularExpression("[A-Za-z ]*", ErrorMessage="Sólo se permiten letras")]
        public string Ciudad { get; set; }
        [Required(ErrorMessage="El campo {0}, es obligatorio")]
        [MaxLength(40, ErrorMessage="No puede superar los {1} cartacteres")]
        [MinLength(3, ErrorMessage="Escriba al menos {1} cartacteres")]
        [RegularExpression("[A-Za-z ]*", ErrorMessage="Sólo se permiten letras")]
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Pagina_Web { get; set; }
        [Required(ErrorMessage="El campo {0}, es obligatorio")]
        [MaxLength(40, ErrorMessage="No puede superar los {1} cartacteres")]
        [MinLength(3, ErrorMessage="Escriba al menos {1} cartacteres")]
        [RegularExpression("[A-Za-z ]*", ErrorMessage="Sólo se permiten letras")]
        public string Sector { get; set; }
        [Required(ErrorMessage="El campo {0}, es obligatorio")]
        public List<String> Tipo_Servicio { get; set; }

        public double Calificacion { get; set; }
    }
}