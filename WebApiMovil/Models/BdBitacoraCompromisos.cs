﻿using System;
using System.Collections.Generic;

namespace WebApiMovil.Models
{
    public partial class BdBitacoraCompromisos
    {
        public int IdBitacoraCompromisos { get; set; }
        public int? IdCompromiso { get; set; }
        public int? IdStatusJuntaIni { get; set; }
        public int? IdStatusJuntaFin { get; set; }
        public string Comentario { get; set; }
        public int? IdUsuarioAlta { get; set; }
        public DateTime? FecAlta { get; set; }
    }
}
