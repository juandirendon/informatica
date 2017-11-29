using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FlowersAndBushes.Datos
{
     [Table("TipoHoja")]
    public class TipoHoja
    {
         public TipoHoja()
           {
             this.Producto = new HashSet<Producto>()  ;
           }
         [Key]
         [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string Nombre { get; set; }
        public int IdTipoHoja { get; set; }


        public virtual ICollection<Producto> Producto { get; set; }

    }
}