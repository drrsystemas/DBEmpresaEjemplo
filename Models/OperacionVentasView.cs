using System;

namespace DRR.Core.DBEmpresaEjemplo.Models
{
    public partial class OperacionVentasView
    {
        public byte TipoOperacionId { get; set; }
        public int VentaId { get; set; }
        public int? ClienteId { get; set; }
        public DateTime FechaComprobante { get; set; }
        public string CategoriaImpuesto { get; set; }
        public short ComprobanteId { get; set; }
        public string ComprobanteTipo { get; set; }
        public short TalonarioId { get; set; }
        public int NroComprobante { get; set; }
        public string Comprobante { get; set; }
        public decimal? ImporteSinImpuesto { get; set; }
        public decimal ImporteDescuento { get; set; }
        public decimal ImporteImpuestos { get; set; }
        public decimal SubTotal { get; set; }
        public decimal TotalVenta { get; set; }
        public bool EsPagoDetallar { get; set; }
        public decimal ImpBonificacion { get; set; }
        public short? SectorId { get; set; }
        public string SectorDescripcion { get; set; }
        public DateTime FechaImputacion { get; set; }
        public int? CierreZId { get; set; }
        public short? SucursalId { get; set; }
        public string SucursalDescripcion { get; set; }
        public short? ProyectoId { get; set; }
        public int? ResumenId { get; set; }
        public DateTime? FerchaStock { get; set; }
        public DateTime? FechaVencimiento { get; set; }
        public byte? MonedaId { get; set; }
        public decimal? Cotizacion { get; set; }
        public byte? TipoNroIdentificacion { get; set; }
        public long? NroIdentificacion { get; set; }
        public int? Filer { get; set; }
        public int? AlmaUserId { get; set; }
        public short? RetirarDespositoId { get; set; }
        public string Detalle { get; set; }
        public decimal? SaldoVt { get; set; }
        public string Vendedor { get; set; }
        public string RegOpercionIdunique { get; set; }
        public int? DiarioId { get; set; }
    }
}
