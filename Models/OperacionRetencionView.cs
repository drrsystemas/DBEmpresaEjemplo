using System;

namespace DRR.Core.DBEmpresaEjemplo.Models
{
    public partial class OperacionRetencionView
    {
        public int RetencionId { get; set; }
        public byte? TipoOperacionId { get; set; }
        public short? RetencTalonarioId { get; set; }
        public int? RegistroOperacionId { get; set; }
        public byte? TipoEntidadId { get; set; }
        public int? NroEntidad { get; set; }
        public string RazonSocial { get; set; }
        public long? NroIdentificacion { get; set; }
        public short? TalonarioId { get; set; }
        public int? NroComprobante { get; set; }
        public string Comprobante { get; set; }
        public DateTime? FechaComprobante { get; set; }
        public DateTime? FechaRetencion { get; set; }
        public decimal? TotalOperacion { get; set; }
        public int? CodRegimen { get; set; }
        public decimal? ImporteSujetoRetencion { get; set; }
        public decimal? ImporteRetener { get; set; }
        public string Concepto { get; set; }
        public int? NroCompRetencion { get; set; }
        public short? FormaPagoId { get; set; }
        public string FormaPago { get; set; }
        public short? ImpuestoId { get; set; }
        public string Impuesto { get; set; }
        public short? SucursalId { get; set; }
        public string Sucursal { get; set; }
        public short? SectorId { get; set; }
        public string Sector { get; set; }
        public bool? EsDebe { get; set; }
        public int? CuentaId { get; set; }
        public string Cuenta { get; set; }
        public int? CuentaTotalizId { get; set; }
        public string Totalizadora { get; set; }
        public byte? TipoCuentaId { get; set; }
        public string TotalizadoraTipo { get; set; }
        public byte? ImpDesgId { get; set; }
        public decimal? PorcentajeAplicar { get; set; }
        public decimal? ImporteUnidad { get; set; }
        public byte? ModifacionTipoId { get; set; }
    }
}
