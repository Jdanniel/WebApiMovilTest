using System;
using System.Collections.Generic;

namespace WebApiMovil.Models
{
    public partial class BdChangeLog
    {
        public int IdChengeLog { get; set; }
        public DateTime FecLiberacion { get; set; }
        public int Liberado { get; set; }
        public int IdModulo { get; set; }
        public int IdTipo { get; set; }
        public string Descripcion { get; set; }
        public int IdUsuarioAlta { get; set; }
        public DateTime FecAlta { get; set; }
    }
}
