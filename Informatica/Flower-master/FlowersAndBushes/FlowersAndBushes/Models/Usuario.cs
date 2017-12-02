using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FlowersAndBushes.Models
{
    public class Usuario
    {
        [Key]
        public long id { get; set; }

        public int tipoDocumento { get; set; }

        public string numeroDocumento { get; set; }

        public string primerNombre { get; set; }

        public string segundoNombre { get; set; }

        public string primerApellido { get; set; }

        public string segundoApellido { get; set; }

        public string contrasena { get; set; }

        public string sexo { get; set; }

        public string correo { get; set; }

        public string celular { get; set; }

        public string telefono { get; set; }
    }
}