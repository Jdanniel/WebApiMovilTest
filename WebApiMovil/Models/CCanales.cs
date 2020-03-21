using System;
using System.Collections.Generic;

namespace WebApiMovil.Models
{
    public partial class CCanales
    {
        public int IdCanal { get; set; }
        public string DescCanal { get; set; }
        public string Descripcion { get; set; }
        public string Status { get; set; }
        public DateTime? FecAlta { get; set; }
        public int? IdUsuario { get; set; }
    }
}
