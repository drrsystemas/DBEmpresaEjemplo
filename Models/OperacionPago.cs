// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DRR.Core.DBEmpresaEjemplo.Models
{
    [Index("PagoId", Name = "IX_OperacionPago", IsUnique = true)]
    [Index("FechaComprobante", Name = "IX_OperacionPagoFechaComprobante")]
    [Index("ComprobanteId", Name = "IX_OperacionPago_ComprobanteID")]
    [Index("ComprobanteId", "TalonarioId", "NroComprobante", Name = "IX_OperacionPago_CompteTalonarioTipoOperacion")]
    [Index("FechaDevengado", Name = "IX_OperacionPago_FechaDevengado")]
    [Index("FechaImputacion", Name = "IX_OperacionPago_FechaImputacion")]
    [Index("Filer", Name = "IX_OperacionPago_Filer")]
    [Index("GeneraAsiento", Name = "IX_OperacionPago_GeneraAsiento")]
    [Index("NroComprobante", Name = "IX_OperacionPago_NroComprobante")]
    [Index("OrdenPagoTipo", Name = "IX_OperacionPago_OrdenPagoTipo")]
    [Index("PagadorId", Name = "IX_OperacionPago_PagadorID")]
    [Index("ProveedorId", Name = "IX_OperacionPago_ProveedorID")]
    [Index("ProyectoId", Name = "IX_OperacionPago_ProyectoID")]
    [Index("ResumenId", Name = "IX_OperacionPago_ResumenID")]
    [Index("SectorId", Name = "IX_OperacionPago_SectorID")]
    [Index("SucursalId", Name = "IX_OperacionPago_SucursalID")]
    [Index("TalonarioId", Name = "IX_OperacionPago_TalonarioID")]
    [Index("TipoOperacionId", Name = "IX_OperacionPago_TipoOperacionID")]
    public partial class OperacionPago
    {
        public OperacionPago()
        {
            BancoTarjetaDebe = new HashSet<BancoTarjetaDebe>();
            CuentaCorrienteCancelacion = new HashSet<CuentaCorrienteCancelacion>();
            DonacionInstitucion = new HashSet<DonacionInstitucion>();
            ImpuestoFormularioLiquidacion = new HashSet<ImpuestoFormularioLiquidacion>();
            OperacionAdelanto = new HashSet<OperacionAdelanto>();
            OperacionArchivo = new HashSet<OperacionArchivo>();
            OperacionDescuento = new HashSet<OperacionDescuento>();
            OperacionDetallePago = new HashSet<OperacionDetallePago>();
            OperacionImpuesto = new HashSet<OperacionImpuesto>();
            OperacionImputacion = new HashSet<OperacionImputacion>();
            OperacionPagoAutorizacionCancelacion = new HashSet<OperacionPagoAutorizacionCancelacion>();
            OperacionRendicion = new HashSet<OperacionRendicion>();
            OperacionRendicionDetalle = new HashSet<OperacionRendicionDetalle>();
            OperacionValeCancelacion = new HashSet<OperacionValeCancelacion>();
            RepartoRendicion = new HashSet<RepartoRendicion>();
            TransporteContrareembolso = new HashSet<TransporteContrareembolso>();
        }

        [Key]
        [Column("TipoOperacionID")]
        public byte TipoOperacionId { get; set; }
        [Key]
        [Column("PagoID")]
        public int PagoId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FechaComprobante { get; set; }
        [Column("ComprobanteID")]
        public short ComprobanteId { get; set; }
        [Column("TalonarioID")]
        public short TalonarioId { get; set; }
        public int NroComprobante { get; set; }
        [Column(TypeName = "money")]
        public decimal ImporteRegistraImpuesto { get; set; }
        [Column(TypeName = "money")]
        public decimal ImporteNoRegistraImpuesto { get; set; }
        [Column(TypeName = "money")]
        public decimal ImporteDescuento { get; set; }
        [Column(TypeName = "money")]
        public decimal ImporteImpuestos { get; set; }
        [Column(TypeName = "money")]
        public decimal SubTotal { get; set; }
        [Column(TypeName = "money")]
        public decimal TotalPago { get; set; }
        public bool EsPagoDetallar { get; set; }
        [Column("SectorID")]
        public short? SectorId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FechaImputacion { get; set; }
        public bool GeneraAsiento { get; set; }
        [Column("SucursalID")]
        public short? SucursalId { get; set; }
        [Column("ProyectoID")]
        public short? ProyectoId { get; set; }
        [Column("PagadorID")]
        public int? PagadorId { get; set; }
        [Column("ResumenID")]
        public int? ResumenId { get; set; }
        public short? OrdenPagoTipo { get; set; }
        [Column("TipoEntidadID")]
        public byte? TipoEntidadId { get; set; }
        [Column("RegistroEntidadID")]
        public int? RegistroEntidadId { get; set; }
        [Unicode(false)]
        public string Observacion { get; set; }
        [Column("ProveedorID")]
        public int? ProveedorId { get; set; }
        [Column("AlmaUserID")]
        public int? AlmaUserId { get; set; }
        [Column(TypeName = "date")]
        public DateTime? FechaDevengado { get; set; }
        [Column("TerminalID")]
        public short? TerminalId { get; set; }
        public int? Filer { get; set; }
        [Column("MonedaID")]
        public byte? MonedaId { get; set; }
        [Column(TypeName = "money")]
        public decimal? Cotizacion { get; set; }

        [ForeignKey("AlmaUserId")]
        [InverseProperty("OperacionPago")]
        public virtual Usuario AlmaUser { get; set; }
        [ForeignKey("PagadorId")]
        [InverseProperty("OperacionPago")]
        public virtual Pagador Pagador { get; set; }
        [ForeignKey("ProveedorId")]
        [InverseProperty("OperacionPago")]
        public virtual Proveedor Proveedor { get; set; }
        [ForeignKey("ProyectoId")]
        [InverseProperty("OperacionPago")]
        public virtual Proyecto Proyecto { get; set; }
        [ForeignKey("ResumenId")]
        [InverseProperty("OperacionPago")]
        public virtual OperacionResumen Resumen { get; set; }
        [ForeignKey("SectorId")]
        [InverseProperty("OperacionPago")]
        public virtual Sector Sector { get; set; }
        [ForeignKey("SucursalId")]
        [InverseProperty("OperacionPago")]
        public virtual Sucursal Sucursal { get; set; }
        [ForeignKey("TerminalId")]
        [InverseProperty("OperacionPago")]
        public virtual SincronizacionTerminal Terminal { get; set; }
        [InverseProperty("OperacionPago")]
        public virtual LibroDiario LibroDiario { get; set; }
        [InverseProperty("OperacionPago")]
        public virtual OperacionAltaModicacion OperacionAltaModicacion { get; set; }
        [InverseProperty("OperacionPago")]
        public virtual ICollection<BancoTarjetaDebe> BancoTarjetaDebe { get; set; }
        [InverseProperty("OperacionPago")]
        public virtual ICollection<CuentaCorrienteCancelacion> CuentaCorrienteCancelacion { get; set; }
        [InverseProperty("OperacionPago")]
        public virtual ICollection<DonacionInstitucion> DonacionInstitucion { get; set; }
        public virtual ICollection<ImpuestoFormularioLiquidacion> ImpuestoFormularioLiquidacion { get; set; }
        [InverseProperty("OperacionPago")]
        public virtual ICollection<OperacionAdelanto> OperacionAdelanto { get; set; }
        [InverseProperty("OperacionPago")]
        public virtual ICollection<OperacionArchivo> OperacionArchivo { get; set; }
        [InverseProperty("OperacionPago")]
        public virtual ICollection<OperacionDescuento> OperacionDescuento { get; set; }
        [InverseProperty("OperacionPago")]
        public virtual ICollection<OperacionDetallePago> OperacionDetallePago { get; set; }
        [InverseProperty("OperacionPago")]
        public virtual ICollection<OperacionImpuesto> OperacionImpuesto { get; set; }
        [InverseProperty("OperacionPago")]
        public virtual ICollection<OperacionImputacion> OperacionImputacion { get; set; }
        public virtual ICollection<OperacionPagoAutorizacionCancelacion> OperacionPagoAutorizacionCancelacion { get; set; }
        [InverseProperty("Pago")]
        public virtual ICollection<OperacionRendicion> OperacionRendicion { get; set; }
        [InverseProperty("OperacionPago")]
        public virtual ICollection<OperacionRendicionDetalle> OperacionRendicionDetalle { get; set; }
        [InverseProperty("OperacionPago")]
        public virtual ICollection<OperacionValeCancelacion> OperacionValeCancelacion { get; set; }
        [InverseProperty("OperacionPago")]
        public virtual ICollection<RepartoRendicion> RepartoRendicion { get; set; }
        [InverseProperty("OperacionPago")]
        public virtual ICollection<TransporteContrareembolso> TransporteContrareembolso { get; set; }
    }
}