﻿using System;
using System.Collections.Generic;

namespace WebApiMovil.Models
{
    public partial class BdStatusDoctoTipoResponsablePrefacturacion
    {
        public int IdStatusDoctoTipoResponsablePrefacturacion { get; set; }
        public int? IdTipoDoctoPrefacturacion { get; set; }
        public int? IdStatusDoctoPrefacturacion { get; set; }
        public int? IdTipoResponsablePrefacturacion { get; set; }
        public int? IsPrefacturacionAssign { get; set; }
        public int? IsPartnerAssign { get; set; }
        public int? IsClienteAssign { get; set; }
    }
}