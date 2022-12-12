﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DRR.Core.DBEmpresaEjemplo.Models
{
    [Index("CuentaId", Name = "IX_OperacionDetallePago_CuentaID")]
    [Index("Filer", Name = "IX_OperacionDetallePago_Filer")]
    [Index("FormaPagoId", Name = "IX_OperacionDetallePago_FormaPagoID")]
    [Index("PagoTipoRegistroId", Name = "IX_OperacionDetallePago_PagoTipoRegistroID")]
    [Index("RegistroOperacionId", Name = "IX_OperacionDetallePago_RegistroOperacionID")]
    [Index("TipoOperacionId", Name = "IX_OperacionDetallePago_TipoOperacionID")]
    [Index("TipoOperacionId", "RegistroOperacionId", Name = "IX_OperacionDetallePago_TipoOperacionIDRegitroOperacionID")]
    [Index("EsDebe", Name = "IX_OperacionDetallePago_esDebe")]
    [Index("TipoOperacionId", Name = "OperacionDetallePago_TipoOperIDFormaPagoRegistroOperac")]
    public partial class OperacionDetallePago
    {
        public OperacionDetallePago()
        {
            BancoTarjetaDebe = new HashSet<BancoTarjetaDebe>();
            BancoTarjetaHaber = new HashSet<BancoTarjetaHaber>();
            ChequeTercerosIngresoRegistroPago = new HashSet<ChequeTerceros>();
            ChequeTercerosSalidaRegistroPago = new HashSet<ChequeTerceros>();
            CuentaCorrienteAnticipoCancela = new HashSet<CuentaCorrienteAnticipoCancela>();
            CuentaCorrienteRegistroTerminal = new HashSet<CuentaCorrienteRegistroTerminal>();
            DonacionInstitucion = new HashSet<DonacionInstitucion>();
            OperacionAdelantoCancelacion = new HashSet<OperacionAdelantoCancelacion>();
            OperacionCredito = new HashSet<OperacionCredito>();
            OperacionDescuento = new HashSet<OperacionDescuento>();
            OperacionRetencion = new HashSet<OperacionRetencion>();
            OperacionValeContra = new HashSet<OperacionValeContra>();
            OperacionValeContraTerminal = new HashSet<OperacionValeContraTerminal>();
            OperacionVentaBaucherCancelacion = new HashSet<OperacionVentaBaucherCancelacion>();
        }

        /// <summary>
        /// De AlmaNet.OperacionTipo - Indica si se trata de una Venta, Compra, Pago, Cobro
        /// </summary>
        [Column("TipoOperacionID")]
        public byte TipoOperacionId { get; set; }
        /// <summary>
        /// El Nro de Venta, Compra, Pago, Cobro que Genero el detalle
        /// </summary>
        [Column("RegistroOperacionID")]
        public int RegistroOperacionId { get; set; }
        /// <summary>
        /// Importe de esta Forma de Pago
        /// </summary>
        [Column(TypeName = "money")]
        public decimal Importe { get; set; }
        /// <summary>
        /// Identifica la Forma de Pago seleccionada (ver OperacionFormaPago)
        /// </summary>
        [Column("FormaPagoID")]
        public short FormaPagoId { get; set; }
        /// <summary>
        /// Nro del registro del Pago realizado
        /// </summary>
        [Key]
        [Column("RegistroPagoID")]
        public int RegistroPagoId { get; set; }
        /// <summary>
        /// Indica q es un importe Deudor
        /// </summary>
        [Column("esDebe")]
        public bool EsDebe { get; set; }
        /// <summary>
        /// Tipo Moneda en la que se realizo la operacion
        /// </summary>
        [Column("MonedaID")]
        public byte? MonedaId { get; set; }
        /// <summary>
        /// Cotizacion de la Moneda al momento de la operacion
        /// </summary>
        [Column(TypeName = "money")]
        public decimal? Cotizacion { get; set; }
        /// <summary>
        /// Campo utilizado para modulos de exportacion e importacion y sincronizacion con otros sistemas que permite relacionar  el registro de origen y destino
        /// </summary>
        public int? Filer { get; set; }
        /// <summary>
        /// Cuenta Contable Vinculada por default trae la de OperacionFormaPago, pero en caso de detallar la forma de Pago se puede cambiar la asigancion de la cuenta
        /// </summary>
        [Column("CuentaID")]
        public int? CuentaId { get; set; }
        /// <summary>
        /// Permite especificar un detalle adicional en la Forma de Pago
        /// </summary>
        [StringLength(150)]
        [Unicode(false)]
        public string Detalle { get; set; }
        /// <summary>
        /// Se optiene de AlmaNET PagoRegistroTipo (Especifica la reistracion a realizar segun Forma Pago)Contado, Cuenta Corriente, Banco, Adelanto,Cheque Tercero, Credito Etc.
        /// </summary>
        [Column("PagoTipoRegistroID")]
        public byte PagoTipoRegistroId { get; set; }
        /// <summary>
        /// Indica el desglose utilizado para esta forma de pago
        /// </summary>
        [Column("DesgloseFormaPagoID")]
        public short? DesgloseFormaPagoId { get; set; }

        [ForeignKey("CuentaId")]
        [InverseProperty("OperacionDetallePago")]
        public virtual PlanDeCuenta Cuenta { get; set; }
        [ForeignKey("DesgloseFormaPagoId")]
        [InverseProperty("OperacionDetallePago")]
        public virtual OperacionFormaPagoDesgloce DesgloseFormaPago { get; set; }
        [ForeignKey("FormaPagoId")]
        [InverseProperty("OperacionDetallePago")]
        public virtual OperacionFormaPago FormaPago { get; set; }
        [ForeignKey("TipoOperacionId,RegistroOperacionId")]
        [InverseProperty("OperacionDetallePago")]
        public virtual OperacionCobro OperacionCobro { get; set; }
        [ForeignKey("TipoOperacionId,RegistroOperacionId")]
        [InverseProperty("OperacionDetallePago")]
        public virtual OperacionCompra OperacionCompra { get; set; }
        [ForeignKey("TipoOperacionId,RegistroOperacionId")]
        [InverseProperty("OperacionDetallePago")]
        public virtual OperacionPago OperacionPago { get; set; }
        [ForeignKey("TipoOperacionId,RegistroOperacionId")]
        [InverseProperty("OperacionDetallePago")]
        public virtual OperacionPedidoCompra OperacionPedidoCompra { get; set; }
        [ForeignKey("TipoOperacionId,RegistroOperacionId")]
        [InverseProperty("OperacionDetallePago")]
        public virtual OperacionPedidoVenta OperacionPedidoVenta { get; set; }
        [ForeignKey("TipoOperacionId,RegistroOperacionId")]
        [InverseProperty("OperacionDetallePago")]
        public virtual OperacionVenta OperacionVenta { get; set; }
        [InverseProperty("RegistroPago")]
        public virtual CuentaCorrienteRegistro CuentaCorrienteRegistro { get; set; }
        [InverseProperty("RegistroPago")]
        public virtual ICollection<BancoTarjetaDebe> BancoTarjetaDebe { get; set; }
        [InverseProperty("RegistroPago")]
        public virtual ICollection<BancoTarjetaHaber> BancoTarjetaHaber { get; set; }
        [InverseProperty("IngresoRegistroPago")]
        public virtual ICollection<ChequeTerceros> ChequeTercerosIngresoRegistroPago { get; set; }
        [InverseProperty("SalidaRegistroPago")]
        public virtual ICollection<ChequeTerceros> ChequeTercerosSalidaRegistroPago { get; set; }
        [InverseProperty("RegistroPago")]
        public virtual ICollection<CuentaCorrienteAnticipoCancela> CuentaCorrienteAnticipoCancela { get; set; }
        [InverseProperty("RegistroPago")]
        public virtual ICollection<CuentaCorrienteRegistroTerminal> CuentaCorrienteRegistroTerminal { get; set; }
        [InverseProperty("RegistroPago")]
        public virtual ICollection<DonacionInstitucion> DonacionInstitucion { get; set; }
        [InverseProperty("RegistroPago")]
        public virtual ICollection<OperacionAdelantoCancelacion> OperacionAdelantoCancelacion { get; set; }
        [InverseProperty("RegistroPago")]
        public virtual ICollection<OperacionCredito> OperacionCredito { get; set; }
        [InverseProperty("RegistroPago")]
        public virtual ICollection<OperacionDescuento> OperacionDescuento { get; set; }
        [InverseProperty("RegistroPago")]
        public virtual ICollection<OperacionRetencion> OperacionRetencion { get; set; }
        [InverseProperty("RegistroPago")]
        public virtual ICollection<OperacionValeContra> OperacionValeContra { get; set; }
        [InverseProperty("RegistroPago")]
        public virtual ICollection<OperacionValeContraTerminal> OperacionValeContraTerminal { get; set; }
        [InverseProperty("RegistroPago")]
        public virtual ICollection<OperacionVentaBaucherCancelacion> OperacionVentaBaucherCancelacion { get; set; }
    }
}