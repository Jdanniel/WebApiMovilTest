using System;
using System.Collections.Generic;

namespace WebApiMovil.Models
{
    public partial class BdPlazaCp
    {
        public int IdPlazaCp { get; set; }
        public int? IdPlaza { get; set; }
        public string Cp { get; set; }
        public DateTime? FecAlta { get; set; }
        public int? IdUsuarioAlta { get; set; }

        public virtual CPlazas IdPlazaNavigation { get; set; }
    }
}
