using System;
using System.Collections.Generic;

namespace WebApiMovil.Models
{
    public partial class BdCargaCierreMasivoMinv
    {
        public long IdCierre { get; set; }
        public DateTime FechaCarga { get; set; }
        public int UsuarioCarga { get; set; }
        public string ArchivoCarga { get; set; }
        public string Odtexterna { get; set; }
        public string ComentariosServicio { get; set; }
        public int? Atiende { get; set; }
        public DateTime? FechaCierre { get; set; }
        public DateTime? HoraCierre { get; set; }
        public DateTime? MinutoCierre { get; set; }
        public string OtorganteVobo { get; set; }
        public string Aplicacion { get; set; }
        public string Version { get; set; }
        public string Caja { get; set; }
        public string OtorganteVoboRechazo { get; set; }
        public string Subrechazo { get; set; }
        public string IdCausaCancelacion { get; set; }
        public int? Status { get; set; }
        public string Correo { get; set; }
        public int? TipoAtencion { get; set; }
        public string AmexSiNo { get; set; }
        public string ConclusionesAmex { get; set; }
        public string AfiliacionAmex { get; set; }
        public int? IdRechazo { get; set; }
        public string TelefonoCampo { get; set; }
        public string ActReferencias { get; set; }
        public int? IdCriterioCambio { get; set; }
        public string Discover { get; set; }
        public string Rollosinst { get; set; }
        public string InstalacionesElavonNoSerie { get; set; }
        public int? InstalacionesElavonDescModelo { get; set; }
        public int? ConectividadEntrada { get; set; }
        public int? AplicativoEntrada { get; set; }
        public int? RetirosElavonNoSerie { get; set; }
        public int? RetirosElavonDescModelo { get; set; }
    }
}
