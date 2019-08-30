using System;
using System.Collections.Generic;

namespace WebApiMovil.Models
{
    public partial class BdConfigureCausaRechazo
    {
        public int IdConfigureCausaRechazo { get; set; }
        public int? IdCausaRechazo { get; set; }
        public string Status { get; set; }
        public int? IsActivo { get; set; }
        public int? IdUsuarioAlta { get; set; }
        public DateTime? FechaAlta { get; set; }
    }
}
