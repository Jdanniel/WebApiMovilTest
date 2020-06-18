using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiMovil.Models
{
    public partial class BdApplicationVersions
    {
        public int IdApplicationVerion { get; set; }
        public string Version { get; set; }
        public string BuildNumber { get; set; }
        public DateTime DischargeDate { get; set; }
        public bool Status { get; set; }
    }
}
