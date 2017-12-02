using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace FlowersAndBushes.Datos
{
    public class Producto
    {
        [Key]
        public long Id { get; set; }
        public string Nombre { get; set; }
        public int Tipo { get; set; } 
        public Double Precio { get; set; }
        public string Imagen { get; set; }
       
    }
}