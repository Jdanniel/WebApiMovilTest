using System;
using System.Collections.Generic;

namespace WebApiMovil.Models
{
    public partial class BdCargaChangeComentarios
    {
        public int IdCarga { get; set; }
        public int? IdUsuario { get; set; }
        public DateTime? FecAlta { get; set; }
    }
}
