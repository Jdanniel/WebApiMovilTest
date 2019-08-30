using System;
using System.Collections.Generic;

namespace WebApiMovil.Models
{
    public partial class CMcViaticosRazonesCancelacion
    {
        public int IdRazon { get; set; }
        public string Comentario { get; set; }
        public string Status { get; set; }
        public int? IdUsuarioAlta { get; set; }
        public DateTime? FecAlta { get; set; }
    }
}
