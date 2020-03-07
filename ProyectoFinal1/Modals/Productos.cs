using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFinal1.Modals
{
    public class Productos
    {
        [Key]
        public int ProductoId { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaIngreso { get; set; }
        public decimal Precio { get; set; }
        public int Cantidad { get; set; }
        public decimal Costo { get; set; }

        public decimal Ganancia { get; set; }

        public decimal ITBIS { get; set; }

        public string NombreProveedor { get; set; }

        public Productos()
        {
            ProductoId = 0;
            Descripcion = string.Empty;
            FechaIngreso = DateTime.Now;
            Precio = 0;
            Cantidad = 0;
            Costo = 0;
            Ganancia = 0;
            ITBIS = 0;
            NombreProveedor = string.Empty;

        }
    }
}
