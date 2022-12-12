﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DRR.Core.DBEmpresaEjemplo.Models
{
    [Index("CuentaId", "TipoOperacionId", Name = "IX_OperacionImputacionCuentaIDTipoOperacionID")]
    [Index("CuentaId", Name = "IX_OperacionImputacion_CuentaID")]
    [Index("TipoOperacionId", Name = "IX_OperacionImputacion_TipoOperacionID")]
    [Index("TipoOperacionId", "RegistroOperacionId", Name = "IX_OperacionImputacion_TipoOperacionIDRegistroOperacionID")]
    public partial class OperacionImputacion
    {
        public OperacionImputacion()
        {
            OperacionImputacionCentroCosto = new HashSet<OperacionImputacionCentroCosto>();
            OperacionImputacionDesgloseCuenta = new HashSet<OperacionImputacionDesgloseCuenta>();
            OperacionImputacionImpuesto = new HashSet<OperacionImputacionImpuesto>();
            TransporteCombustibleImputacion = new HashSet<TransporteCombustibleImputacion>();
        }

        /// <summary>
        /// Tipo Movimiento al que pertenece (Ventas,Compras,Pagod,Cobros) de AlmaNET.OperacionTipo
        /// </summary>
        [Column("TipoOperacionID")]
        public byte TipoOperacionId { get; set; }
        /// <summary>
        /// Nro Registro de la Operacion
        /// </summary>
        [Column("RegistroOperacionID")]
        public int RegistroOperacionId { get; set; }
        /// <summary>
        /// Codigo Cuenta
        /// </summary>
        [Column("CuentaID")]
        public int CuentaId { get; set; }
        /// <summary>
        /// Leyenda Adicional
        /// </summary>
        [StringLength(190)]
        [Unicode(false)]
        public string LeyendaCuenta { get; set; }
        /// <summary>
        /// Importe 
        /// </summary>
        [Column(TypeName = "money")]
        public decimal? Importe { get; set; }
        /// <summary>
        /// 1 Determina que el Importe es Deudor 0-Acreedor
        /// </summary>
        public bool EsDebe { get; set; }
        /// <summary>
        /// Registro de Imputacion
        /// </summary>
        [Key]
        public int RegistroImputacion { get; set; }
        public bool? RegistraImpuesto { get; set; }
        /// <summary>
        /// Indica la cantidad
        /// </summary>
        [Column(TypeName = "decimal(12, 3)")]
        public decimal? Cantidad { get; set; }
        /// <summary>
        /// Indica el Precio Unitario
        /// </summary>
        [Column(TypeName = "money")]
        public decimal? ImpUnidad { get; set; }
        /// <summary>
        /// Total Importe Impuestos
        /// </summary>
        [Column(TypeName = "money")]
        public decimal? ImporteImpuestos { get; set; }
        /// <summary>
        /// Total Importe Impuestos
        /// </summary>
        [Column(TypeName = "money")]
        public decimal? ImporteCostos { get; set; }
        /// <summary>
        /// Importe + Impuestos
        /// </summary>
        [Column(TypeName = "money")]
        public decimal? ImporteTotal { get; set; }

        [ForeignKey("CuentaId")]
        [InverseProperty("OperacionImputacion")]
        public virtual PlanDeCuenta Cuenta { get; set; }
        [ForeignKey("TipoOperacionId,RegistroOperacionId")]
        [InverseProperty("OperacionImputacion")]
        public virtual OperacionCobro OperacionCobro { get; set; }
        [ForeignKey("TipoOperacionId,RegistroOperacionId")]
        [InverseProperty("OperacionImputacion")]
        public virtual OperacionCompra OperacionCompra { get; set; }
        [ForeignKey("TipoOperacionId,RegistroOperacionId")]
        [InverseProperty("OperacionImputacion")]
        public virtual OperacionPago OperacionPago { get; set; }
        [ForeignKey("TipoOperacionId,RegistroOperacionId")]
        [InverseProperty("OperacionImputacion")]
        public virtual OperacionVenta OperacionVenta { get; set; }
        [InverseProperty("RegistroImputacionNavigation")]
        public virtual ICollection<OperacionImputacionCentroCosto> OperacionImputacionCentroCosto { get; set; }
        [InverseProperty("RegistroImputacionNavigation")]
        public virtual ICollection<OperacionImputacionDesgloseCuenta> OperacionImputacionDesgloseCuenta { get; set; }
        [InverseProperty("RegistroImputacionNavigation")]
        public virtual ICollection<OperacionImputacionImpuesto> OperacionImputacionImpuesto { get; set; }
        [InverseProperty("RegistroImputacionNavigation")]
        public virtual ICollection<TransporteCombustibleImputacion> TransporteCombustibleImputacion { get; set; }
    }
}