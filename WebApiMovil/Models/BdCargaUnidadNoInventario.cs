﻿using System;
using System.Collections.Generic;

namespace WebApiMovil.Models
{
    public partial class BdCargaUnidadNoInventario
    {
        public int IdCargaUnidadNoInventario { get; set; }
        public int? IdUnidad { get; set; }
        public string NoInventarion { get; set; }
    }
}