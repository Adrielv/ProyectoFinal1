using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFinal1.Modals
{
    public class Pedidos
    {
        [Key]
        public int PedidosId { get; set; }
        public DateTime FechaPedido { get; set; }

        public string Cliente { get; set; }

        public string FormaPedido { get; set; }
        public int ProductoId { get; set; }

        public int Cantidad { get; set; }
        public decimal Total { get; set; }
        public decimal SubTotal { get; set; }
        public decimal ITBIS { get; set; }

        [ForeignKey("PedidosId")]
        public List<PedidosDetalle> Detalles { get; set; }

        public Pedidos()
        {
            PedidosId = 0;
            FechaPedido = DateTime.Now;
            Cliente = string.Empty;
            FormaPedido = string.Empty;
            ProductoId = 0;
            Total = 0;
            SubTotal = 0;
            ITBIS = 0;
            Detalles = new List<PedidosDetalle>();
        }
    }
}
