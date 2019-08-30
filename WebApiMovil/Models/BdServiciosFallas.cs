using System;
using System.Collections.Generic;

namespace WebApiMovil.Models
{
    public partial class BdServiciosFallas
    {
        public int IdServicioFalla { get; set; }
        public int? IdCliente { get; set; }
        public int? IdServicio { get; set; }
        public int? IdFalla { get; set; }
        public DateTime? FecAlta { get; set; }
        public int? IdUsuarioAlta { get; set; }
    }
}
