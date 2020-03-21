using System;
using System.Collections.Generic;

namespace WebApiMovil.Models
{
    public partial class BdArSegmentoFail
    {
        public int IdArSegmento { get; set; }
        public int IdAr { get; set; }
        public int IdSegmentoElavon { get; set; }
        public int FecAlta { get; set; }
        public int IdUsuarioAlta { get; set; }
    }
}
