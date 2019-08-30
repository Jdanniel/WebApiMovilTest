using System;
using System.Collections.Generic;

namespace WebApiMovil.Models
{
    public partial class BdMovimientosInventarioCierres
    {
        public int IdMovimientosInventarioCierres { get; set; }
        public string Odt { get; set; }
        public string Status { get; set; }
        public int? Movimiento { get; set; }
        public int? IdArchivo { get; set; }
        public DateTime? FechaAlta { get; set; }
        public int? IdUsuarioAlta { get; set; }
    }
}
