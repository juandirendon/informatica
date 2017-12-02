using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FlowersAndBushes.Models
{
    public class Pedido
    {
        [Key]
        public int Id { get; set; }
        public DateTime fecha { get; set; }
        public String dimensionesJardin { get; set; }
        public Double presupuesto { get; set; }
        public String comentarios { get; set; }
        public int usuario_id { get; set; }
    }
}