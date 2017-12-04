using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace FlowersAndBushes.Models
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public Decimal Precio { get; set; }
        public string Imagen { get; set; }
        public int Tipo { get; set; }
    }
}