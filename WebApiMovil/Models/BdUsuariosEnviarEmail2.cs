using System;
using System.Collections.Generic;

namespace WebApiMovil.Models
{
    public partial class BdUsuariosEnviarEmail2
    {
        public int IdUsuariosEnviarEmail { get; set; }
        public string Notificacion { get; set; }
        public int? CheckValor { get; set; }
        public string Status { get; set; }
        public int? IdUsuario { get; set; }
    }
}
