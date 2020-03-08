using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFinal1.Modals
{
    public class PedidosDetalle
    {
        [Key]
        public int PedidosDetalleId { get; set; }
        public int PedidosId { get; set; }
        public int ProductoId { get; set; }

        public int Cantidad { get; set; }

        public decimal Precio { get; set; }

        

        public PedidosDetalle()
        {
            PedidosDetalleId = 0;
            PedidosId = 0;
            ProductoId = 0;
            Cantidad = 0;
            Precio = 0;
            
        }
    }
}
