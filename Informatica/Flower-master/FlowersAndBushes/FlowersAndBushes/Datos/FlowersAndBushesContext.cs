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

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
{
            modelBuilder.Entity<TipoHoja>()
                .HasMany(p => p.Producto)
                .WithRequired(p => p.TipoHoja)
                .HasForeignKey(p => p.IdTipoHoja)
                .WillCascadeOnDelete(false);
 	 base.OnModelCreating(modelBuilder);
}
    }
}