//Importacion de las librerias a usar
using System;
using System.Collections.Generic;

namespace E_Migration.App.Dominio
{
    public class Migrante
    {
        
        public int Id { get; set; }
        public string Nombre{ get; set; }
        public string Apellidos{ get; set; }
        public string Tipo_Documento{ get; set; }
        public string Numero_Identificacion{ get; set; }
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
