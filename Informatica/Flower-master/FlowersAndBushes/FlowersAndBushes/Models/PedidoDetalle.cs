using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FlowersAndBushes.Models
{
    public class PedidoDetalle
    {
        public int Id { get; set; }
        public int IdPedido { get; set; }
        public int IdProducto { get; set; }
        public int Cantidad { get; set; }
    }
}