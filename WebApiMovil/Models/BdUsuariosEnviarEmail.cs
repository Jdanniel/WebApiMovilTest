﻿using System;
using System.Collections.Generic;

namespace WebApiMovil.Models
{
    public partial class BdUsuariosEnviarEmail
    {
        public int IdUsuarioEnviarEmail { get; set; }
        public int? IdUsuario { get; set; }
        public int? IdSendUsuarioAlta { get; set; }
    }
}
