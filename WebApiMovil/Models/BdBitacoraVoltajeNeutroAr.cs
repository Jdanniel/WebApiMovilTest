using System;
using System.Collections.Generic;

namespace WebApiMovil.Models
{
    public partial class BdBitacoraVoltajeNeutroAr
    {
        public int IdBitacoraVoltajeNeutroAr { get; set; }
        public int? IdAr { get; set; }
        public int? VoltajeNeutroAnterior { get; set; }
        public int? VoltajeNeutroActual { get; set; }
        public int? IdUsuarioAlta { get; set; }
        public DateTime? FecAlta { get; set; }
    }
}
