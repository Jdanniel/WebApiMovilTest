using System;
using System.Collections.Generic;

namespace WebApiMovil.Models
{
    public partial class BdCargasEquipo
    {
        public int IdCargaEquipo { get; set; }
        public int? IdUsuario { get; set; }
        public DateTime? FecAlta { get; set; }
    }
}
