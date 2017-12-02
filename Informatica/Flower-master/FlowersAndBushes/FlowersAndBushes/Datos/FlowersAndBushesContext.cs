using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FlowersAndBushes.Datos
{
    public class FlowersAndBushesContext : DbContext
    { 
        public FlowersAndBushesContext() : base ("name=FlowersAndBushes")
        {
            Database.SetInitializer(new FlowersAndBushesInitializer());
        }

        public DbSet<Producto> Producto { get; set; }
        public DbSet<TipoHoja> TipoHoja { get; set; }

    }
}