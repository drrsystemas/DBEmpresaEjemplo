using System;

namespace DRR.Core.DBEmpresaEjemplo.Models
{
    public partial class CtaCteCanceladoView
    {
        public byte TipoOperacionId { get; set; }
        public string Operacion { get; set; }
        public int RegistroId { get; set; }
        public DateTime? Fecha { get; set; }
        public DateTime FechaImputacion { get; set; }
        public DateTime FechaComprobante { get; set; }
        public string Comprobante { get; set; }
        public int? RegistEntidadId { get; set; }
        public int TipoEntidadId { get; set; }
        public string RegEntidadIdunique { get; set; }
        public decimal? Importe { get; set; }
        public int EsDebe { get; set; }
        public int PagoTipoRegistroId { get; set; }
        public string TipoRegist { get; set; }
        public string Detalle { get; set; }
        public int? CuentaId { get; set; }
        public short? SucursalId { get; set; }
        public string SucursalDescripcion { get; set; }
        public string CategoriaImpuestoId { get; set; }
        public string ComprobanteTipo { get; set; }
        public short ComprobanteId { get; set; }
        public short TalonarioId { get; set; }
        public int FormaPagoId { get; set; }
        public string FormaPago { get; set; }
        public short? SectorId { get; set; }
        public string SectorDescrip { get; set; }
        public string Operador { get; set; }
        public int? ResumenId { get; set; }
        public short? ProyectoId { get; set; }
        public string ProyectoDesc { get; set; }
        public int? RendicionId { get; set; }
        public int? MovId { get; set; }
        public int Orden { get; set; }
        public bool? GeneraAsiento { get; set; }
        public int Filer { get; set; }
        public string RegOperacionIdunique { get; set; }
    }
}
