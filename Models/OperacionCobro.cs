﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DRR.Core.DBEmpresaEjemplo.Models
{
    [Index("ComprobanteId", "TalonarioId", "TipoOperacionId", Name = "ComprobanteIDTalonarioIDTipoOperacion")]
    [Index("FechaComprobante", Name = "IX_OperacionCobroFechaComprobante")]
    [Index("FechaDevengado", Name = "IX_OperacionCobroFechaDevengado")]
    [Index("FechaImputacion", Name = "IX_OperacionCobroFechaImputacion")]
    [Index("ClienteId", Name = "IX_OperacionCobro_ClienteID")]
    [Index("CobradorId", Name = "IX_OperacionCobro_CobradorID")]
    [Index("CobroId", Name = "IX_OperacionCobro_CobroID", IsUnique = true)]
    [Index("ComprobanteId", Name = "IX_OperacionCobro_ComprobanteID")]
    [Index("ComprobanteId", "TalonarioId", "TipoOperacionId", Name = "IX_OperacionCobro_CompteTalonarioTipoOper")]
    [Index("GeneraAsiento", Name = "IX_OperacionCobro_GeneraAsiento")]
    [Index("NroComprobante", Name = "IX_OperacionCobro_NroComprobante")]
    [Index("ResumenId", Name = "IX_OperacionCobro_ResumenOperID")]
    [Index("SectorId", Name = "IX_OperacionCobro_SectorID")]
    [Index("SucursalId", Name = "IX_OperacionCobro_SucursalID")]
    [Index("TalonarioId", Name = "IX_OperacionCobro_TalonarioID")]
    [Index("TipoOperacionId", "CobroId", Name = "IX_OperacionCobro_TipoOpIDNro", IsUnique = true)]
    [Index("TipoOperacionId", Name = "IX_OperacionCobro_TipoOperacionID")]
    public partial class OperacionCobro
    {
        public OperacionCobro()
        {
            CuentaCorrienteAnticipo = new HashSet<CuentaCorrienteAnticipo>();
            CuentaCorrienteCancelacion = new HashSet<CuentaCorrienteCancelacion>();
            OperacionAdelanto = new HashSet<OperacionAdelanto>();
            OperacionArchivo = new HashSet<OperacionArchivo>();
            OperacionCobroWeb = new HashSet<OperacionCobroWeb>();
            OperacionCobroWebItem = new HashSet<OperacionCobroWebItem>();
            OperacionComisionCompra = new HashSet<OperacionComisionCompra>();
            OperacionCreditoCuotaCobrada = new HashSet<OperacionCreditoCuotaCobrada>();
            OperacionDescuento = new HashSet<OperacionDescuento>();
            OperacionDetallePago = new HashSet<OperacionDetallePago>();
            OperacionImpuesto = new HashSet<OperacionImpuesto>();
            OperacionImputacion = new HashSet<OperacionImputacion>();
            OperacionRelacionOperacionOperacionCobro = new HashSet<OperacionRelacionOperacion>();
            OperacionRelacionOperacionOperacionCobroNavigation = new HashSet<OperacionRelacionOperacion>();
            OperacionRendicionDetalle = new HashSet<OperacionRendicionDetalle>();
            OperacionValeCancelacion = new HashSet<OperacionValeCancelacion>();
            RepartoRendicion = new HashSet<RepartoRendicion>();
            TransporteContrareembolso = new HashSet<TransporteContrareembolso>();
        }

        /// <summary>
        /// Tipo Movimiento al que pertenece (Ventas,Compras,Pagod,Cobros) de AlmaNET.OperacionTipo
        /// </summary>
        [Key]
        [Column("TipoOperacionID")]
        public byte TipoOperacionId { get; set; }
        /// <summary>
        /// Nro Imputacion del COBRO
        /// </summary>
        [Key]
        [Column("CobroID")]
        public int CobroId { get; set; }
        /// <summary>
        /// Nro Cliente
        /// </summary>
        [Column("ClienteID")]
        public int? ClienteId { get; set; }
        /// <summary>
        /// Fecha en que se realizo la Operacion
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime FechaComprobante { get; set; }
        /// <summary>
        /// Tipo de comprobante utilizado
        /// </summary>
        [Column("ComprobanteID")]
        public short ComprobanteId { get; set; }
        /// <summary>
        /// Nro Talonario al que pertenece la Numeracion del comprobante
        /// </summary>
        [Column("TalonarioID")]
        public short TalonarioId { get; set; }
        /// <summary>
        /// Nro de comprobante / Se repite por ComprobnateID y TalonarioID
        /// </summary>
        public int NroComprobante { get; set; }
        /// <summary>
        /// Total Importes Sugeto a impuestos
        /// </summary>
        [Column(TypeName = "money")]
        public decimal ImporteRegistraImpuesto { get; set; }
        /// <summary>
        /// Total Importes que no registra Impuesto
        /// </summary>
        [Column(TypeName = "money")]
        public decimal ImporteNoRegistraImpuesto { get; set; }
        /// <summary>
        /// Total Importe Impuestos
        /// </summary>
        [Column(TypeName = "money")]
        public decimal ImporteImpuestos { get; set; }
        /// <summary>
        /// ImporteRegistraImpuesto+ImporteNoRegistraImpuesto
        /// </summary>
        [Column(TypeName = "money")]
        public decimal SubTotal { get; set; }
        /// <summary>
        /// ((ImporteRegistraImpuesto+ImporteNoRegistraImpuesto))+ImporteImpuestos+
        /// </summary>
        [Column(TypeName = "money")]
        public decimal TotalCobro { get; set; }
        /// <summary>
        /// Indica si el pago es deglosado (Tiene + de 1 forma de Pago)
        /// </summary>
        public bool EsPagoDetallar { get; set; }
        /// <summary>
        /// Sector que realizo la Venta
        /// </summary>
        [Column("SectorID")]
        public short? SectorId { get; set; }
        /// <summary>
        /// Fecha imputacion Contable
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime FechaImputacion { get; set; }
        /// <summary>
        /// Indica si la operacion registra asiento contable
        /// </summary>
        public bool GeneraAsiento { get; set; }
        /// <summary>
        /// Nro de Sucursal de la Empresa q realizo la venta
        /// </summary>
        [Column("SucursalID")]
        public short? SucursalId { get; set; }
        /// <summary>
        /// Codigo Proyecto
        /// </summary>
        [Column("ProyectoID")]
        public short? ProyectoId { get; set; }
        /// <summary>
        /// Persona q realizo el Cobro
        /// </summary>
        [Column("CobradorID")]
        public int? CobradorId { get; set; }
        /// <summary>
        /// Nro de Resmun de Operaciones
        /// </summary>
        [Column("ResumenID")]
        public int? ResumenId { get; set; }
        [Unicode(false)]
        public string Observacion { get; set; }
        [Column(TypeName = "money")]
        public decimal ImporteDescuento { get; set; }
        /// <summary>
        /// Nro Usuario AlmaID q registro la Operacion
        /// </summary>
        [Column("AlmaUserID")]
        public int? AlmaUserId { get; set; }
        /// <summary>
        /// Indica el momento en q se realizo la reprocesacion de las notas de Pedidos generadas desde Android
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? FechaHoraReproceso { get; set; }
        public bool EsMobile { get; set; }
        [Column(TypeName = "date")]
        public DateTime? FechaDevengado { get; set; }
        [Column("TerminalID")]
        public short? TerminalId { get; set; }
        [Column("MonedaID")]
        public byte? MonedaId { get; set; }
        [Column(TypeName = "money")]
        public decimal? Cotizacion { get; set; }

        [ForeignKey("AlmaUserId")]
        [InverseProperty("OperacionCobro")]
        public virtual Usuario AlmaUser { get; set; }
        [ForeignKey("ClienteId")]
        [InverseProperty("OperacionCobro")]
        public virtual Cliente Cliente { get; set; }
        [ForeignKey("CobradorId")]
        [InverseProperty("OperacionCobro")]
        public virtual Cobrador Cobrador { get; set; }
        [ForeignKey("ProyectoId")]
        [InverseProperty("OperacionCobro")]
        public virtual Proyecto Proyecto { get; set; }
        [ForeignKey("ResumenId")]
        [InverseProperty("OperacionCobro")]
        public virtual OperacionResumen Resumen { get; set; }
        [ForeignKey("SectorId")]
        [InverseProperty("OperacionCobro")]
        public virtual Sector Sector { get; set; }
        [ForeignKey("SucursalId")]
        [InverseProperty("OperacionCobro")]
        public virtual Sucursal Sucursal { get; set; }
        [ForeignKey("TerminalId")]
        [InverseProperty("OperacionCobro")]
        public virtual SincronizacionTerminal Terminal { get; set; }
        [InverseProperty("OperacionCobro")]
        public virtual LibroDiario LibroDiario { get; set; }
        [InverseProperty("OperacionCobro")]
        public virtual OperacionAltaModicacion OperacionAltaModicacion { get; set; }
        [InverseProperty("OperacionCobro")]
        public virtual ICollection<CuentaCorrienteAnticipo> CuentaCorrienteAnticipo { get; set; }
        [InverseProperty("OperacionCobro")]
        public virtual ICollection<CuentaCorrienteCancelacion> CuentaCorrienteCancelacion { get; set; }
        [InverseProperty("OperacionCobro")]
        public virtual ICollection<OperacionAdelanto> OperacionAdelanto { get; set; }
        [InverseProperty("OperacionCobro")]
        public virtual ICollection<OperacionArchivo> OperacionArchivo { get; set; }
        [InverseProperty("OperacionCobro")]
        public virtual ICollection<OperacionCobroWeb> OperacionCobroWeb { get; set; }
        [InverseProperty("OperacionCobro")]
        public virtual ICollection<OperacionCobroWebItem> OperacionCobroWebItem { get; set; }
        [InverseProperty("OperacionCobro")]
        public virtual ICollection<OperacionComisionCompra> OperacionComisionCompra { get; set; }
        [InverseProperty("OperacionCobro")]
        public virtual ICollection<OperacionCreditoCuotaCobrada> OperacionCreditoCuotaCobrada { get; set; }
        [InverseProperty("OperacionCobro")]
        public virtual ICollection<OperacionDescuento> OperacionDescuento { get; set; }
        [InverseProperty("OperacionCobro")]
        public virtual ICollection<OperacionDetallePago> OperacionDetallePago { get; set; }
        [InverseProperty("OperacionCobro")]
        public virtual ICollection<OperacionImpuesto> OperacionImpuesto { get; set; }
        [InverseProperty("OperacionCobro")]
        public virtual ICollection<OperacionImputacion> OperacionImputacion { get; set; }
        [InverseProperty("OperacionCobro")]
        public virtual ICollection<OperacionRelacionOperacion> OperacionRelacionOperacionOperacionCobro { get; set; }
        [InverseProperty("OperacionCobroNavigation")]
        public virtual ICollection<OperacionRelacionOperacion> OperacionRelacionOperacionOperacionCobroNavigation { get; set; }
        [InverseProperty("OperacionCobro")]
        public virtual ICollection<OperacionRendicionDetalle> OperacionRendicionDetalle { get; set; }
        [InverseProperty("OperacionCobro")]
        public virtual ICollection<OperacionValeCancelacion> OperacionValeCancelacion { get; set; }
        [InverseProperty("OperacionCobro")]
        public virtual ICollection<RepartoRendicion> RepartoRendicion { get; set; }
        [InverseProperty("OperacionCobro")]
        public virtual ICollection<TransporteContrareembolso> TransporteContrareembolso { get; set; }
    }
}