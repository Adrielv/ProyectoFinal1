using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFinal1.Modals
{
    public class Clientes
    {
        [Key]

        public int ClienteId { get; set; }

        public string Nombre { get; set; }
        public int Telefono { get; set; }

        public string Email { get; set; }

        public Clientes()
        {
            ClienteId = 0;
            Nombre = string.Empty;
            Telefono = 0;
            Email = string.Empty;
        }
    }
}
