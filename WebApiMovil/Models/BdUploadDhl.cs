﻿using System;
using System.Collections.Generic;

namespace WebApiMovil.Models
{
    public partial class BdUploadDhl
    {
        public int IdUploadDhl { get; set; }
        public int? IdUsuario { get; set; }
        public DateTime? FecAlta { get; set; }
    }
}
