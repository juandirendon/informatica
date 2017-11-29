using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace FlowersAndBushes.Datos
{
    public class FlowersAndBushesInitializer : DropCreateDatabaseIfModelChanges<FlowersAndBushesContext>
    {
        protected override void Seed(FlowersAndBushesContext context)
        {
            context.TipoHoja.Add(new TipoHoja() { Nombre = "Acicular", IdTipoHoja = 1 });
            context.TipoHoja.Add(new TipoHoja() { Nombre = "Lanceolada", IdTipoHoja = 2 });
            context.TipoHoja.Add(new TipoHoja() { Nombre = "Orbicular", IdTipoHoja = 3 });
            context.TipoHoja.Add(new TipoHoja() { Nombre = "Romboide", IdTipoHoja = 4 });
            context.TipoHoja.Add(new TipoHoja() { Nombre = "Acumitada", IdTipoHoja = 5 });
            context.TipoHoja.Add(new TipoHoja() { Nombre = "Flabelada", IdTipoHoja = 6 });
            context.TipoHoja.Add(new TipoHoja() { Nombre = "Ovada", IdTipoHoja = 7 });
            context.TipoHoja.Add(new TipoHoja() { Nombre = "En Roceta", IdTipoHoja = 8 });
            context.TipoHoja.Add(new TipoHoja() { Nombre = "Alternas", IdTipoHoja = 9 });
            context.TipoHoja.Add(new TipoHoja() { Nombre = "Hastada", IdTipoHoja = 10 });
            context.TipoHoja.Add(new TipoHoja() { Nombre = "Palmeada", IdTipoHoja = 11 });
            context.TipoHoja.Add(new TipoHoja() { Nombre = "Espatulada", IdTipoHoja = 12 });
            context.TipoHoja.Add(new TipoHoja() { Nombre = "Aristada", IdTipoHoja = 13 });
            context.TipoHoja.Add(new TipoHoja() { Nombre = "Palma Simple", IdTipoHoja = 14 });
            context.TipoHoja.Add(new TipoHoja() { Nombre = "Sagitada", IdTipoHoja = 15 });
            context.TipoHoja.Add(new TipoHoja() { Nombre = "Bipinnada", IdTipoHoja = 16 });
            context.TipoHoja.Add(new TipoHoja() { Nombre = "Lineal", IdTipoHoja = 17 });
            context.TipoHoja.Add(new TipoHoja() { Nombre = "Peltada", IdTipoHoja = 18 });
            context.TipoHoja.Add(new TipoHoja() { Nombre = "Subulada", IdTipoHoja = 19 });
            context.TipoHoja.Add(new TipoHoja() { Nombre = "Cordada", IdTipoHoja = 20 });
            context.TipoHoja.Add(new TipoHoja() { Nombre = "Lobulada", IdTipoHoja = 21 });
            context.TipoHoja.Add(new TipoHoja() { Nombre = "Amplexicaule", IdTipoHoja = 22 });
            context.TipoHoja.Add(new TipoHoja() { Nombre = "Trifoliada", IdTipoHoja = 23 });
            context.TipoHoja.Add(new TipoHoja() { Nombre = "Cuneada", IdTipoHoja = 24 });
            context.TipoHoja.Add(new TipoHoja() { Nombre = "Imparipinnada", IdTipoHoja = 25 });
            context.TipoHoja.Add(new TipoHoja() { Nombre = "Tripinnada", IdTipoHoja = 26 });
            context.TipoHoja.Add(new TipoHoja() { Nombre = "Truncada", IdTipoHoja = 27 });
            context.TipoHoja.Add(new TipoHoja() { Nombre = "Digitada", IdTipoHoja = 28 });
            context.TipoHoja.Add(new TipoHoja() { Nombre = "Obtusa", IdTipoHoja = 29 });
            context.TipoHoja.Add(new TipoHoja() { Nombre = "Pinnatisecta", IdTipoHoja = 30 });
            context.TipoHoja.Add(new TipoHoja() { Nombre = "Eliptica", IdTipoHoja = 31 });
            context.TipoHoja.Add(new TipoHoja() { Nombre = "Opuestas", IdTipoHoja = 32 });
            context.TipoHoja.Add(new TipoHoja() { Nombre = "Reniforme", IdTipoHoja = 33 });
            context.TipoHoja.Add(new TipoHoja() { Nombre = "Verticilados", IdTipoHoja = 34 });
            context.TipoHoja.Add(new TipoHoja() { Nombre = "Entera", IdTipoHoja = 35 });
           
            
            
        }
    }
}