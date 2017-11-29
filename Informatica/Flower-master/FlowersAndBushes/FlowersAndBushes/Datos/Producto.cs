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
        public long IdProducto { get; set; }
        public string Nombre { get; set; }
        public string Aspecto { get; set; }
        public int IdTipoHoja { get; set; }

        public string TipoFlores { get; set; }
        public string TemporadaPlantación { get; set; }
        public string TemporadaFloración { get; set; }
        public string FamiliaPertenece { get; set; }
        public string PrecioUnidad { get; set; }
        public string Fotografía { get; set; }
         public string Abonos { get; set; }
         public string Tierras{ get; set; }
        public string Adornos { get; set; }

        public virtual TipoHoja TipoHoja { get; set; }
    }
}