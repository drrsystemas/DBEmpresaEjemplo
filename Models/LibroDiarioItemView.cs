using System;

namespace DRR.Core.DBEmpresaEjemplo.Models
{
    public partial class LibroDiarioItemView
    {
        public int DiarioId { get; set; }
        public DateTime Fecha { get; set; }
        public string Detalle { get; set; }
        public byte? TipoOperacionId { get; set; }
        public int? RegistroOperacionId { get; set; }
        public int? BalanceId { get; set; }
        public DateTime? FechaImputacion { get; set; }
        public string LeyendaCuenta { get; set; }
        public int CuentaId { get; set; }
        public decimal? Importe { get; set; }
        public bool EsDebe { get; set; }
        public int? RegEntidadId { get; set; }
        public byte? TipoEntidadId { get; set; }
        public short? SectorId { get; set; }
        public string SectorDescrip { get; set; }
        public short? ProyectoId { get; set; }
        public string ProyectoDesc { get; set; }
        public short? SucursalId { get; set; }
        public string SucursalDescripcion { get; set; }
        public string RegEntidadIdunique { get; set; }
        public string Operacion { get; set; }
        public string RegOpercionIdunique { get; set; }
        public string RegOpercionIdcuentaId { get; set; }
    }
}
