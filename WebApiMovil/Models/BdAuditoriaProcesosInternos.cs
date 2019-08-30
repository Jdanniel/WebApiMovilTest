using System;
using System.Collections.Generic;

namespace WebApiMovil.Models
{
    public partial class BdAuditoriaProcesosInternos
    {
        public int Id { get; set; }
        public string Proceso { get; set; }
        public int? ErrorNumber { get; set; }
        public string ErrorMessage { get; set; }
        public string Referencia { get; set; }
        public DateTime? FecAlta { get; set; }
    }
}
