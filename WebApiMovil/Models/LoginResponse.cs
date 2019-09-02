using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiMovil.Models
{
    public class LoginResponse
    {
        public bool respuesta { get; set; }
        public string mensaje { get; set; }
        public string nombre { get; set; }
        public string paterno { get; set; }
        public string materno { get; set; }
        public string username { get; set; }
        public string password { get; set; }
    }
}
