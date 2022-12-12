using System;

namespace DRR.Core.DBEmpresaEjemplo.Models
{
    public partial class LibroDiarioView
    {
        public int DiarioId { get; set; }
        public DateTime Fecha { get; set; }
        public string Detalle { get; set; }
        public byte? TipoOperacionId { get; set; }
        public string Operacion { get; set; }
        public int? RegistroOperacionId { get; set; }
        public int? BalanceId { get; set; }
        public DateTime? FechaImputacion { get; set; }
        public string RegOpercionIdunique { get; set; }
    }
}
